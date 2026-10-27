using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket
{
	// Token: 0x02006E80 RID: 28288
	[NullableContext(1)]
	[Nullable(0)]
	public class ElementalFieldCollision
	{
		// Token: 0x06044F0A RID: 282378 RVA: 0x01107DE0 File Offset: 0x01105FE0
		public ElementalFieldCollision(Action<EntityHandle, List<ElementalFieldTarget>> OnEnter, Action<EntityHandle, List<ElementalFieldTarget>> OnLeave)
		{
			this.OnEnter = OnEnter;
			this.OnLeave = OnLeave;
		}

		// Token: 0x06044F0B RID: 282379 RVA: 0x01107E30 File Offset: 0x01106030
		public void RegisterDetector(EntityHandle owner, UKuroFastCollisionShapeComponent shape)
		{
			if (this.DetectorEntries.ContainsKey(owner.Id))
			{
				return;
			}
			if (!this.EnsureEnvironment())
			{
				return;
			}
			this.Algorithm.Add(shape);
			FieldEntry value = new FieldEntry
			{
				Owner = owner,
				Shape = shape,
				Overlaps = new Dictionary<EntityHandle, HashSet<UObject>>()
			};
			this.DetectorEntries[owner.Id] = value;
			this.DetectorShapeEntry[shape] = value;
			shape.OnKFCBeginOverlap.Add(new FKuroFastCollisionOverlapSignature.FKuroFastCollisionOverlapSignature_ScriptDelegate(this.OnBeginOverlap));
			shape.OnKFCEndOverlap.Add(new FKuroFastCollisionOverlapSignature.FKuroFastCollisionOverlapSignature_ScriptDelegate(this.OnEndOverlap));
			ElementalFieldDebugDrawController instance = ElementalFieldDebugDrawController.Instance;
			if (instance == null)
			{
				return;
			}
			instance.RegisterShape(owner.Id, new ElementalDebugDrawShapeInfo
			{
				Shape = shape,
				Role = EElementalFieldDebugShapeRole.Detector
			});
		}

		// Token: 0x06044F0C RID: 282380 RVA: 0x01107EFC File Offset: 0x011060FC
		public void UnregisterDetector(int ownerId)
		{
			FieldEntry fieldEntry;
			if (!this.DetectorEntries.TryGetValue(ownerId, out fieldEntry))
			{
				return;
			}
			ElementalFieldDebugDrawController instance = ElementalFieldDebugDrawController.Instance;
			if (instance != null)
			{
				instance.UnregisterShape(ownerId, fieldEntry.Shape);
			}
			this.RemoveDetectorDelegates(fieldEntry.Shape);
			fieldEntry.Overlaps.Clear();
			UKuroFastCollisionAlgorithm algorithm = this.Algorithm;
			if (algorithm != null)
			{
				algorithm.Remove(fieldEntry.Shape);
			}
			this.DetectorShapeEntry.Remove(fieldEntry.Shape);
			this.DetectorEntries.Remove(ownerId);
			this.TryDestroyEnvironment();
		}

		// Token: 0x06044F0D RID: 282381 RVA: 0x01107F84 File Offset: 0x01106184
		public void RegisterDetectable(EntityHandle owner, List<UObject> shapes)
		{
			if (shapes.Count == 0)
			{
				return;
			}
			int id = owner.Id;
			if (this.DetectableEntries.ContainsKey(id))
			{
				this.UnregisterDetectable(id);
			}
			if (!this.EnsureEnvironment())
			{
				return;
			}
			foreach (UObject uobject in shapes)
			{
				this.Algorithm.Add(uobject);
				this.DetectableShapeOwner[uobject] = owner;
				ElementalFieldDebugDrawController instance = ElementalFieldDebugDrawController.Instance;
				if (instance != null)
				{
					instance.RegisterShape(id, new ElementalDebugDrawShapeInfo
					{
						Shape = uobject,
						Role = EElementalFieldDebugShapeRole.Detectable
					});
				}
			}
			this.DetectableEntries[owner.Id] = new DetectableEntry
			{
				Owner = owner,
				Shapes = shapes
			};
		}

		// Token: 0x06044F0E RID: 282382 RVA: 0x0110805C File Offset: 0x0110625C
		public void UnregisterDetectable(int ownerId)
		{
			DetectableEntry detectableEntry;
			if (!this.DetectableEntries.TryGetValue(ownerId, out detectableEntry))
			{
				return;
			}
			foreach (UObject uobject in detectableEntry.Shapes)
			{
				UKuroFastCollisionAlgorithm algorithm = this.Algorithm;
				if (algorithm != null)
				{
					algorithm.Remove(uobject);
				}
				this.DetectableShapeOwner.Remove(uobject);
				ElementalFieldDebugDrawController instance = ElementalFieldDebugDrawController.Instance;
				if (instance != null)
				{
					instance.UnregisterShape(ownerId, uobject);
				}
			}
			this.DetectableEntries.Remove(ownerId);
			foreach (FieldEntry fieldEntry in this.DetectorEntries.Values)
			{
				HashSet<UObject> source;
				if (fieldEntry.Overlaps.TryGetValue(detectableEntry.Owner, out source))
				{
					fieldEntry.Overlaps.Remove(detectableEntry.Owner);
					if (fieldEntry.Owner.Valid)
					{
						this.OnLeave(fieldEntry.Owner, new List<ElementalFieldTarget>
						{
							new ElementalFieldTarget
							{
								Detectable = detectableEntry.Owner,
								Shapes = source.ToList<UObject>()
							}
						});
					}
				}
			}
			this.TryDestroyEnvironment();
		}

		// Token: 0x06044F0F RID: 282383 RVA: 0x011081B4 File Offset: 0x011063B4
		public void AddDetectableShape(EntityHandle owner, UKuroFastCollisionShapeComponent shape)
		{
			if (!this.EnsureEnvironment())
			{
				return;
			}
			DetectableEntry detectableEntry;
			if (!this.DetectableEntries.TryGetValue(owner.Id, out detectableEntry))
			{
				detectableEntry = new DetectableEntry
				{
					Owner = owner,
					Shapes = new List<UObject>()
				};
				this.DetectableEntries[owner.Id] = detectableEntry;
			}
			if (detectableEntry.Shapes.Contains(shape))
			{
				return;
			}
			this.Algorithm.Add(shape);
			this.DetectableShapeOwner[shape] = owner;
			detectableEntry.Shapes.Add(shape);
			ElementalFieldDebugDrawController instance = ElementalFieldDebugDrawController.Instance;
			if (instance == null)
			{
				return;
			}
			instance.RegisterShape(owner.Id, new ElementalDebugDrawShapeInfo
			{
				Shape = shape,
				Role = EElementalFieldDebugShapeRole.Detectable
			});
		}

		// Token: 0x06044F10 RID: 282384 RVA: 0x01108268 File Offset: 0x01106468
		public void RemoveDetectableShape(int ownerId, UKuroFastCollisionShapeComponent shape)
		{
			DetectableEntry detectableEntry;
			if (!this.DetectableEntries.TryGetValue(ownerId, out detectableEntry))
			{
				return;
			}
			if (!detectableEntry.Shapes.Remove(shape))
			{
				return;
			}
			UKuroFastCollisionAlgorithm algorithm = this.Algorithm;
			if (algorithm != null)
			{
				algorithm.Remove(shape);
			}
			this.DetectableShapeOwner.Remove(shape);
			ElementalFieldDebugDrawController instance = ElementalFieldDebugDrawController.Instance;
			if (instance != null)
			{
				instance.UnregisterShape(ownerId, shape);
			}
			foreach (FieldEntry fieldEntry in this.DetectorEntries.Values)
			{
				HashSet<UObject> hashSet;
				if (fieldEntry.Overlaps.TryGetValue(detectableEntry.Owner, out hashSet) && hashSet.Remove(shape))
				{
					if (hashSet.Count == 0)
					{
						fieldEntry.Overlaps.Remove(detectableEntry.Owner);
					}
					if (fieldEntry.Owner.Valid)
					{
						this.OnLeave(fieldEntry.Owner, new List<ElementalFieldTarget>
						{
							new ElementalFieldTarget
							{
								Detectable = detectableEntry.Owner,
								Shapes = new List<UObject>
								{
									shape
								}
							}
						});
					}
				}
			}
			if (detectableEntry.Shapes.Count == 0)
			{
				this.DetectableEntries.Remove(ownerId);
				this.TryDestroyEnvironment();
			}
		}

		// Token: 0x06044F11 RID: 282385 RVA: 0x011083B4 File Offset: 0x011065B4
		public IEnumerable<ElementalFieldTarget> GetOverlappingTargetList(int detectorOwnerId)
		{
			ElementalFieldCollision.<GetOverlappingTargetList>d__14 <GetOverlappingTargetList>d__ = new ElementalFieldCollision.<GetOverlappingTargetList>d__14(-2);
			<GetOverlappingTargetList>d__.<>4__this = this;
			<GetOverlappingTargetList>d__.<>3__detectorOwnerId = detectorOwnerId;
			return <GetOverlappingTargetList>d__;
		}

		// Token: 0x06044F12 RID: 282386 RVA: 0x011083CB File Offset: 0x011065CB
		[return: TupleElementNames(new string[]
		{
			"Detector",
			"Target"
		})]
		[return: Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		public IEnumerable<ValueTuple<EntityHandle, ElementalFieldTarget>> GetOverlappingFieldList(int detectableId)
		{
			ElementalFieldCollision.<GetOverlappingFieldList>d__15 <GetOverlappingFieldList>d__ = new ElementalFieldCollision.<GetOverlappingFieldList>d__15(-2);
			<GetOverlappingFieldList>d__.<>4__this = this;
			<GetOverlappingFieldList>d__.<>3__detectableId = detectableId;
			return <GetOverlappingFieldList>d__;
		}

		// Token: 0x06044F13 RID: 282387 RVA: 0x011083E4 File Offset: 0x011065E4
		[NullableContext(2)]
		public ElementalFieldTarget GetDetectable(int detectableId)
		{
			DetectableEntry detectableEntry;
			if (!this.DetectableEntries.TryGetValue(detectableId, out detectableEntry))
			{
				return null;
			}
			return new ElementalFieldTarget
			{
				Detectable = detectableEntry.Owner,
				Shapes = detectableEntry.Shapes
			};
		}

		// Token: 0x06044F14 RID: 282388 RVA: 0x01108420 File Offset: 0x01106620
		public void Clear()
		{
			foreach (KeyValuePair<int, FieldEntry> keyValuePair in this.DetectorEntries)
			{
				int num;
				FieldEntry fieldEntry;
				keyValuePair.Deconstruct(out num, out fieldEntry);
				int ownerId = num;
				FieldEntry fieldEntry2 = fieldEntry;
				ElementalFieldDebugDrawController instance = ElementalFieldDebugDrawController.Instance;
				if (instance != null)
				{
					instance.UnregisterShape(ownerId, fieldEntry2.Shape);
				}
				this.RemoveDetectorDelegates(fieldEntry2.Shape);
				fieldEntry2.Overlaps.Clear();
			}
			foreach (KeyValuePair<int, DetectableEntry> keyValuePair2 in this.DetectableEntries)
			{
				int num;
				DetectableEntry detectableEntry;
				keyValuePair2.Deconstruct(out num, out detectableEntry);
				int ownerId2 = num;
				foreach (UObject shape in detectableEntry.Shapes)
				{
					ElementalFieldDebugDrawController instance2 = ElementalFieldDebugDrawController.Instance;
					if (instance2 != null)
					{
						instance2.UnregisterShape(ownerId2, shape);
					}
				}
			}
			this.DetectorEntries.Clear();
			this.DetectorShapeEntry.Clear();
			this.DetectableEntries.Clear();
			this.DetectableShapeOwner.Clear();
			this.DestroyEnvironment();
		}

		// Token: 0x06044F15 RID: 282389 RVA: 0x0110857C File Offset: 0x0110677C
		[NullableContext(2)]
		private void OnBeginOverlap(UKuroFastCollisionShapeComponent overlappedComponent, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UObject> otherObjects)
		{
			if (overlappedComponent == null || otherObjects == null)
			{
				return;
			}
			FieldEntry fieldEntry;
			if (!this.DetectorShapeEntry.TryGetValue(overlappedComponent, out fieldEntry))
			{
				return;
			}
			EntityHandle owner = fieldEntry.Owner;
			if (!owner.Valid)
			{
				return;
			}
			int num = otherObjects.Num();
			Dictionary<int, ElementalFieldTarget> dictionary = new Dictionary<int, ElementalFieldTarget>();
			for (int i = 0; i < num; i++)
			{
				UObject uobject = otherObjects.Get(i);
				EntityHandle entityHandle;
				if (this.DetectableShapeOwner.TryGetValue(uobject, out entityHandle) && entityHandle.Valid)
				{
					int id = entityHandle.Id;
					HashSet<UObject> hashSet;
					if (!fieldEntry.Overlaps.TryGetValue(entityHandle, out hashSet))
					{
						hashSet = new HashSet<UObject>();
						fieldEntry.Overlaps[entityHandle] = hashSet;
					}
					hashSet.Add(uobject);
					ElementalFieldTarget elementalFieldTarget;
					if (!dictionary.TryGetValue(id, out elementalFieldTarget))
					{
						elementalFieldTarget = new ElementalFieldTarget
						{
							Detectable = entityHandle,
							Shapes = new List<UObject>()
						};
						dictionary[id] = elementalFieldTarget;
					}
					elementalFieldTarget.Shapes.Add(uobject);
				}
			}
			if (dictionary.Count > 0)
			{
				this.OnEnter(owner, dictionary.Values.ToList<ElementalFieldTarget>());
			}
		}

		// Token: 0x06044F16 RID: 282390 RVA: 0x01108698 File Offset: 0x01106898
		[NullableContext(2)]
		private void OnEndOverlap(UKuroFastCollisionShapeComponent overlappedComponent, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UObject> otherObjects)
		{
			if (overlappedComponent == null || otherObjects == null)
			{
				return;
			}
			FieldEntry fieldEntry;
			if (!this.DetectorShapeEntry.TryGetValue(overlappedComponent, out fieldEntry))
			{
				return;
			}
			EntityHandle owner = fieldEntry.Owner;
			int num = otherObjects.Num();
			Dictionary<int, ElementalFieldTarget> dictionary = new Dictionary<int, ElementalFieldTarget>();
			for (int i = 0; i < num; i++)
			{
				UObject uobject = otherObjects.Get(i);
				EntityHandle entityHandle;
				if (this.DetectableShapeOwner.TryGetValue(uobject, out entityHandle))
				{
					int id = entityHandle.Id;
					HashSet<UObject> hashSet;
					if (fieldEntry.Overlaps.TryGetValue(entityHandle, out hashSet) && hashSet.Remove(uobject))
					{
						if (hashSet.Count == 0)
						{
							fieldEntry.Overlaps.Remove(entityHandle);
						}
						ElementalFieldTarget elementalFieldTarget;
						if (!dictionary.TryGetValue(id, out elementalFieldTarget))
						{
							elementalFieldTarget = new ElementalFieldTarget
							{
								Detectable = entityHandle,
								Shapes = new List<UObject>()
							};
							dictionary[id] = elementalFieldTarget;
						}
						elementalFieldTarget.Shapes.Add(uobject);
					}
				}
			}
			if (dictionary.Count > 0 && owner.Valid)
			{
				this.OnLeave(owner, dictionary.Values.ToList<ElementalFieldTarget>());
			}
		}

		// Token: 0x06044F17 RID: 282391 RVA: 0x011087A7 File Offset: 0x011069A7
		private void RemoveDetectorDelegates(UKuroFastCollisionShapeComponent shape)
		{
			if (!shape.IsValid())
			{
				return;
			}
			shape.OnKFCBeginOverlap.Remove(new FKuroFastCollisionOverlapSignature.FKuroFastCollisionOverlapSignature_ScriptDelegate(this.OnBeginOverlap));
			shape.OnKFCEndOverlap.Remove(new FKuroFastCollisionOverlapSignature.FKuroFastCollisionOverlapSignature_ScriptDelegate(this.OnEndOverlap));
		}

		// Token: 0x06044F18 RID: 282392 RVA: 0x011087E0 File Offset: 0x011069E0
		private bool EnsureEnvironment()
		{
			if (this.Algorithm != null)
			{
				return true;
			}
			this.Algorithm = KuroFastCollisionController.Instance.CreateAlgorithm(UKuroFastCollisionAlgorithm_Grid.StaticClass().ToWeakClass(), true);
			return this.Algorithm != null;
		}

		// Token: 0x06044F19 RID: 282393 RVA: 0x01108815 File Offset: 0x01106A15
		private void TryDestroyEnvironment()
		{
			if (this.Algorithm == null)
			{
				return;
			}
			if (this.DetectorEntries.Count > 0 || this.DetectableEntries.Count > 0)
			{
				return;
			}
			this.DestroyEnvironment();
		}

		// Token: 0x06044F1A RID: 282394 RVA: 0x01108843 File Offset: 0x01106A43
		private void DestroyEnvironment()
		{
			if (this.Algorithm != null)
			{
				KuroFastCollisionController.Instance.DestroyAlgorithm(this.Algorithm);
				this.Algorithm = null;
			}
		}

		// Token: 0x04023E55 RID: 147029
		[Nullable(2)]
		private UKuroFastCollisionAlgorithm Algorithm;

		// Token: 0x04023E56 RID: 147030
		private readonly Dictionary<int, FieldEntry> DetectorEntries = new Dictionary<int, FieldEntry>();

		// Token: 0x04023E57 RID: 147031
		private readonly Dictionary<UKuroFastCollisionShapeComponent, FieldEntry> DetectorShapeEntry = new Dictionary<UKuroFastCollisionShapeComponent, FieldEntry>();

		// Token: 0x04023E58 RID: 147032
		private readonly Dictionary<int, DetectableEntry> DetectableEntries = new Dictionary<int, DetectableEntry>();

		// Token: 0x04023E59 RID: 147033
		private readonly Dictionary<UObject, EntityHandle> DetectableShapeOwner = new Dictionary<UObject, EntityHandle>();

		// Token: 0x04023E5A RID: 147034
		private readonly Action<EntityHandle, List<ElementalFieldTarget>> OnEnter;

		// Token: 0x04023E5B RID: 147035
		private readonly Action<EntityHandle, List<ElementalFieldTarget>> OnLeave;
	}
}
