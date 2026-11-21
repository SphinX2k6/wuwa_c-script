using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket
{
	// Token: 0x02006001 RID: 24577
	[NullableContext(1)]
	[Nullable(0)]
	public class ElementalFieldCollision
	{
		// Token: 0x0603B0BA RID: 241850 RVA: 0x010B2348 File Offset: 0x010B0548
		public ElementalFieldCollision(Action<EntityHandle, List<ElementalFieldTarget>> OnEnter, Action<EntityHandle, List<ElementalFieldTarget>> OnLeave)
		{
			this.OnEnter = OnEnter;
			this.OnLeave = OnLeave;
		}

		// Token: 0x0603B0BB RID: 241851 RVA: 0x010B2398 File Offset: 0x010B0598
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

		// Token: 0x0603B0BC RID: 241852 RVA: 0x010B2464 File Offset: 0x010B0664
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

		// Token: 0x0603B0BD RID: 241853 RVA: 0x010B24EC File Offset: 0x010B06EC
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

		// Token: 0x0603B0BE RID: 241854 RVA: 0x010B25C4 File Offset: 0x010B07C4
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

		// Token: 0x0603B0BF RID: 241855 RVA: 0x010B271C File Offset: 0x010B091C
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

		// Token: 0x0603B0C0 RID: 241856 RVA: 0x010B27D0 File Offset: 0x010B09D0
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

		// Token: 0x0603B0C1 RID: 241857 RVA: 0x010B291C File Offset: 0x010B0B1C
		public IEnumerable<ElementalFieldTarget> GetOverlappingTargetList(int detectorOwnerId)
		{
			ElementalFieldCollision.<GetOverlappingTargetList>d__14 <GetOverlappingTargetList>d__ = new ElementalFieldCollision.<GetOverlappingTargetList>d__14(-2);
			<GetOverlappingTargetList>d__.<>4__this = this;
			<GetOverlappingTargetList>d__.<>3__detectorOwnerId = detectorOwnerId;
			return <GetOverlappingTargetList>d__;
		}

		// Token: 0x0603B0C2 RID: 241858 RVA: 0x010B2933 File Offset: 0x010B0B33
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

		// Token: 0x0603B0C3 RID: 241859 RVA: 0x010B294C File Offset: 0x010B0B4C
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

		// Token: 0x0603B0C4 RID: 241860 RVA: 0x010B2988 File Offset: 0x010B0B88
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

		// Token: 0x0603B0C5 RID: 241861 RVA: 0x010B2AE4 File Offset: 0x010B0CE4
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

		// Token: 0x0603B0C6 RID: 241862 RVA: 0x010B2C00 File Offset: 0x010B0E00
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

		// Token: 0x0603B0C7 RID: 241863 RVA: 0x010B2D0F File Offset: 0x010B0F0F
		private void RemoveDetectorDelegates(UKuroFastCollisionShapeComponent shape)
		{
			if (!shape.IsValid())
			{
				return;
			}
			shape.OnKFCBeginOverlap.Remove(new FKuroFastCollisionOverlapSignature.FKuroFastCollisionOverlapSignature_ScriptDelegate(this.OnBeginOverlap));
			shape.OnKFCEndOverlap.Remove(new FKuroFastCollisionOverlapSignature.FKuroFastCollisionOverlapSignature_ScriptDelegate(this.OnEndOverlap));
		}

		// Token: 0x0603B0C8 RID: 241864 RVA: 0x010B2D48 File Offset: 0x010B0F48
		private bool EnsureEnvironment()
		{
			if (this.Algorithm != null)
			{
				return true;
			}
			this.Algorithm = KuroFastCollisionController.Instance.CreateAlgorithm(UKuroFastCollisionAlgorithm_Grid.StaticClass().ToWeakClass(), true);
			return this.Algorithm != null;
		}

		// Token: 0x0603B0C9 RID: 241865 RVA: 0x010B2D7D File Offset: 0x010B0F7D
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

		// Token: 0x0603B0CA RID: 241866 RVA: 0x010B2DAB File Offset: 0x010B0FAB
		private void DestroyEnvironment()
		{
			if (this.Algorithm != null)
			{
				KuroFastCollisionController.Instance.DestroyAlgorithm(this.Algorithm);
				this.Algorithm = null;
			}
		}

		// Token: 0x0401F10D RID: 127245
		[Nullable(2)]
		private UKuroFastCollisionAlgorithm Algorithm;

		// Token: 0x0401F10E RID: 127246
		private readonly Dictionary<int, FieldEntry> DetectorEntries = new Dictionary<int, FieldEntry>();

		// Token: 0x0401F10F RID: 127247
		private readonly Dictionary<UKuroFastCollisionShapeComponent, FieldEntry> DetectorShapeEntry = new Dictionary<UKuroFastCollisionShapeComponent, FieldEntry>();

		// Token: 0x0401F110 RID: 127248
		private readonly Dictionary<int, DetectableEntry> DetectableEntries = new Dictionary<int, DetectableEntry>();

		// Token: 0x0401F111 RID: 127249
		private readonly Dictionary<UObject, EntityHandle> DetectableShapeOwner = new Dictionary<UObject, EntityHandle>();

		// Token: 0x0401F112 RID: 127250
		private readonly Action<EntityHandle, List<ElementalFieldTarget>> OnEnter;

		// Token: 0x0401F113 RID: 127251
		private readonly Action<EntityHandle, List<ElementalFieldTarget>> OnLeave;
	}
}
