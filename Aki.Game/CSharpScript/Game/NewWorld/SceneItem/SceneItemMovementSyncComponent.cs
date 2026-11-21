using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Common.Component;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x0200623A RID: 25146
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemMovementSyncComponent : BaseMovementSyncComponent
	{
		// Token: 0x0603C99C RID: 248220 RVA: 0x0115E1FC File Offset: 0x0115C3FC
		[NullableContext(2)]
		protected override bool OnInitData(IEntityArgs args = null)
		{
			base.OnInitData(args);
			CreateEntityData p = args.GetP1<CreateEntityData>();
			SceneItemComponentPb sceneItemComponentPb;
			if (p == null)
			{
				sceneItemComponentPb = null;
			}
			else
			{
				Dictionary<string, EntityComponentPb> componentDataMap = p.ComponentDataMap;
				if (componentDataMap == null)
				{
					sceneItemComponentPb = null;
				}
				else
				{
					EntityComponentPb valueOrDefault = componentDataMap.GetValueOrDefault("SceneItemComponentPb");
					sceneItemComponentPb = ((valueOrDefault != null) ? valueOrDefault.SceneItemComponentPb : null);
				}
			}
			SceneItemComponentPb sceneItemComponentPb2 = sceneItemComponentPb;
			if (sceneItemComponentPb2 != null)
			{
				this.ModifyBlackboardFromRemote(sceneItemComponentPb2.BlackBoards, false);
			}
			return true;
		}

		// Token: 0x0603C99D RID: 248221 RVA: 0x0115E254 File Offset: 0x0115C454
		protected override bool OnStart()
		{
			base.OnStart();
			CreatureDataComponent creatureDataComp = this.CreatureDataComp;
			this.SetAutonomousId(new int?((creatureDataComp != null) ? creatureDataComp.AutonomousId : 0));
			CreatureDataComponent creatureDataComp2 = this.CreatureDataComp;
			SceneItemComponentPb sceneItemComponentPb;
			if (creatureDataComp2 == null)
			{
				sceneItemComponentPb = null;
			}
			else
			{
				Dictionary<string, EntityComponentPb> componentDataMap = creatureDataComp2.ComponentDataMap;
				if (componentDataMap == null)
				{
					sceneItemComponentPb = null;
				}
				else
				{
					EntityComponentPb valueOrDefault = componentDataMap.GetValueOrDefault("SceneItemComponentPb");
					sceneItemComponentPb = ((valueOrDefault != null) ? valueOrDefault.SceneItemComponentPb : null);
				}
			}
			SceneItemComponentPb sceneItemComponentPb2 = sceneItemComponentPb;
			if (sceneItemComponentPb2 != null)
			{
				this.ModifyBlackboardFromRemote(sceneItemComponentPb2.BlackBoards, false);
			}
			return true;
		}

		// Token: 0x0603C99E RID: 248222 RVA: 0x0115E2C8 File Offset: 0x0115C4C8
		public void SetAutonomousId(int? playerId)
		{
			int valueOrDefault = playerId.GetValueOrDefault();
			int moveAutonomousId = this.MoveAutonomousId;
			this.MoveAutonomousId = valueOrDefault;
			bool flag = valueOrDefault != 0;
			int playerId2 = CreatureModel.Instance.GetPlayerId();
			bool flag2 = playerId2 == moveAutonomousId;
			bool flag3 = flag && playerId2 == valueOrDefault;
			BaseActorComponent actorComp = this.ActorComp;
			if (actorComp != null)
			{
				actorComp.SetAutonomous(this.ActorComp.IsAutonomousProxy, new bool?(flag3));
			}
			base.SetEnableMovementSync(flag, "SceneItemManipulatableComponent.SetAutonomousId");
			if (flag2 != flag3)
			{
				EventSystem.Instance.EmitWithTarget<bool>(base.Entity, EEventName.OnSceneItemSwitchMoveControl, flag3);
			}
		}

		// Token: 0x0603C99F RID: 248223 RVA: 0x0115E356 File Offset: 0x0115C556
		public int GetAutonomousId()
		{
			return this.MoveAutonomousId;
		}

		// Token: 0x0603C9A0 RID: 248224 RVA: 0x0115E35E File Offset: 0x0115C55E
		public bool HasMoveController()
		{
			return this.MoveAutonomousId != 0;
		}

		// Token: 0x0603C9A1 RID: 248225 RVA: 0x0115E369 File Offset: 0x0115C569
		public bool HasMoveAuthority()
		{
			BaseActorComponent actorComp = this.ActorComp;
			return actorComp != null && actorComp.IsMoveAutonomousProxy;
		}

		// Token: 0x0603C9A2 RID: 248226 RVA: 0x0115E37C File Offset: 0x0115C57C
		[NullableContext(2)]
		private void SetBlackboardInner(SceneItemBBKey key, SceneItemMovementSyncComponent.TBlackboardValue? value, bool fromRemote, string reason = null)
		{
			this.Blackboards[key] = value;
			this.StateEvents.Emit<SceneItemMovementSyncComponent.TBlackboardValue?, bool, string>(key, value, fromRemote, reason ?? "");
		}

		// Token: 0x0603C9A3 RID: 248227 RVA: 0x0115E3A5 File Offset: 0x0115C5A5
		public void ListenBlackboard(SceneItemBBKey key, Action<SceneItemMovementSyncComponent.TBlackboardValue?, bool, string> callback)
		{
			this.StateEvents.Add(key, callback);
		}

		// Token: 0x0603C9A4 RID: 248228 RVA: 0x0115E3B5 File Offset: 0x0115C5B5
		public void RemoveBlackboardListener(SceneItemBBKey key, Action<SceneItemMovementSyncComponent.TBlackboardValue?, bool, string> callback)
		{
			this.StateEvents.Remove(key, callback);
		}

		// Token: 0x0603C9A5 RID: 248229 RVA: 0x0115E3C8 File Offset: 0x0115C5C8
		public void ModifyBlackboardFromRemote(IList<SceneItemBlackboardParam> blackboards, bool isFullUpdate = false)
		{
			if (isFullUpdate)
			{
				foreach (SceneItemBBKey key in new List<SceneItemBBKey>(this.Blackboards.Keys))
				{
					this.SetBlackboardInner(key, null, true, "ModifyStateFromRemote");
				}
				this.Blackboards.Clear();
				return;
			}
			foreach (SceneItemBlackboardParam sceneItemBlackboardParam in blackboards)
			{
				SceneItemBlackboardParam.ValueOneofCase valueCase = sceneItemBlackboardParam.ValueCase;
				SceneItemBBKey key2 = sceneItemBlackboardParam.Key;
				SceneItemMovementSyncComponent.TBlackboardValue? value = null;
				switch (valueCase)
				{
				case SceneItemBlackboardParam.ValueOneofCase.IntValue:
					value = new SceneItemMovementSyncComponent.TBlackboardValue?(sceneItemBlackboardParam.IntValue);
					break;
				case SceneItemBlackboardParam.ValueOneofCase.IntValues:
				{
					IntArrayBlackboard intValues = sceneItemBlackboardParam.IntValues;
					if (((intValues != null) ? intValues.Values : null) != null)
					{
						int[] array = new int[sceneItemBlackboardParam.IntValues.Values.Count];
						sceneItemBlackboardParam.IntValues.Values.CopyTo(array, 0);
						value = new SceneItemMovementSyncComponent.TBlackboardValue?(array);
					}
					break;
				}
				case SceneItemBlackboardParam.ValueOneofCase.LongValue:
					if (sceneItemBlackboardParam.LongValue != 0L)
					{
						value = new SceneItemMovementSyncComponent.TBlackboardValue?(sceneItemBlackboardParam.LongValue);
					}
					break;
				case SceneItemBlackboardParam.ValueOneofCase.LongValues:
				{
					LongArrayBlackboard longValues = sceneItemBlackboardParam.LongValues;
					if (((longValues != null) ? longValues.Values : null) != null)
					{
						long[] array2 = new long[sceneItemBlackboardParam.LongValues.Values.Count];
						sceneItemBlackboardParam.LongValues.Values.CopyTo(array2, 0);
						value = new SceneItemMovementSyncComponent.TBlackboardValue?(array2);
					}
					break;
				}
				case SceneItemBlackboardParam.ValueOneofCase.BooleanValue:
					value = new SceneItemMovementSyncComponent.TBlackboardValue?(sceneItemBlackboardParam.BooleanValue);
					break;
				case SceneItemBlackboardParam.ValueOneofCase.StringValue:
					value = new SceneItemMovementSyncComponent.TBlackboardValue?(sceneItemBlackboardParam.StringValue);
					break;
				case SceneItemBlackboardParam.ValueOneofCase.FloatValue:
					value = new SceneItemMovementSyncComponent.TBlackboardValue?(sceneItemBlackboardParam.FloatValue);
					break;
				case SceneItemBlackboardParam.ValueOneofCase.FloatValues:
				{
					FloatArrayBlackboard floatValues = sceneItemBlackboardParam.FloatValues;
					if (((floatValues != null) ? floatValues.Values : null) != null)
					{
						float[] array3 = new float[sceneItemBlackboardParam.FloatValues.Values.Count];
						sceneItemBlackboardParam.FloatValues.Values.CopyTo(array3, 0);
						value = new SceneItemMovementSyncComponent.TBlackboardValue?(array3);
					}
					break;
				}
				case SceneItemBlackboardParam.ValueOneofCase.VectorValue:
					if (sceneItemBlackboardParam.VectorValue != null)
					{
						value = new SceneItemMovementSyncComponent.TBlackboardValue?(global::Vector.Create(sceneItemBlackboardParam.VectorValue));
					}
					break;
				case SceneItemBlackboardParam.ValueOneofCase.RotatorValue:
					if (sceneItemBlackboardParam.RotatorValue != null)
					{
						value = new SceneItemMovementSyncComponent.TBlackboardValue?(global::Rotator.Create(sceneItemBlackboardParam.RotatorValue));
					}
					break;
				}
				this.SetBlackboardInner(key2, value, true, "ModifyStateFromRemote");
			}
		}

		// Token: 0x0603C9A6 RID: 248230 RVA: 0x0115E6C8 File Offset: 0x0115C8C8
		public SceneItemMovementSyncComponent.TBlackboardValue? GetBlackboard(SceneItemBBKey key)
		{
			SceneItemMovementSyncComponent.TBlackboardValue? result;
			if (this.Blackboards.TryGetValue(key, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x0603C9A7 RID: 248231 RVA: 0x0115E6F0 File Offset: 0x0115C8F0
		[NullableContext(2)]
		public unsafe bool ModifyBlackboard(SceneItemBBKey key, SceneItemMovementSyncComponent.TBlackboardValue value, string reason = null)
		{
			if (!this.HasMoveAuthority())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Level;
				ELogAuthor author = ELogAuthor.ZQR;
				string message = "[ModifyState] 尝试设置状态但没有移动控制权";
				<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
				string item = "creatureId";
				CreatureDataComponent creatureDataComp = this.CreatureDataComp;
				ptr = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new long?(creatureDataComp.GetCreatureDataId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("entityId", base.Entity.Id);
				ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
				string item2 = "pbDataId";
				CreatureDataComponent creatureDataComp2 = this.CreatureDataComp;
				ptr2 = new ValueTuple<string, object>(item2, (creatureDataComp2 != null) ? new int?(creatureDataComp2.GetPbDataId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("stateType", key);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("stateId", value);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("reason", reason);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
				return false;
			}
			this.SetBlackboardInner(key, new SceneItemMovementSyncComponent.TBlackboardValue?(value), false, reason);
			UpdateSceneItemBlackboardRequest updateSceneItemBlackboardRequest = UpdateSceneItemBlackboardRequest.Create();
			UpdateSceneItemBlackboardRequest updateSceneItemBlackboardRequest2 = updateSceneItemBlackboardRequest;
			CreatureDataComponent creatureDataComp3 = this.CreatureDataComp;
			updateSceneItemBlackboardRequest2.EntityId = ((creatureDataComp3 != null) ? creatureDataComp3.GetCreatureDataId() : 0L);
			SceneItemBlackboardParam sceneItemBlackboardParam = SceneItemBlackboardParam.Create();
			sceneItemBlackboardParam.Key = key;
			if (key == SceneItemBBKey.ManipulatableState)
			{
				sceneItemBlackboardParam.IntValue = value.IntValue;
				updateSceneItemBlackboardRequest.Params.Add(sceneItemBlackboardParam);
				Net.Instance.Call(ERequestMessageId.UpdateSceneItemBlackboardRequest, updateSceneItemBlackboardRequest, null, 0);
				this.CollectSampleAndSend(true);
				return true;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Level;
			ELogAuthor author2 = ELogAuthor.ZQR;
			string message2 = "[ModifyState] 未知的黑板值字段";
			<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray6<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr3 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0);
			string item3 = "creatureId";
			CreatureDataComponent creatureDataComp4 = this.CreatureDataComp;
			ptr3 = new ValueTuple<string, object>(item3, (creatureDataComp4 != null) ? new long?(creatureDataComp4.GetCreatureDataId()) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("entityId", base.Entity.Id);
			ref ValueTuple<string, object> ptr4 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2);
			string item4 = "pbDataId";
			CreatureDataComponent creatureDataComp5 = this.CreatureDataComp;
			ptr4 = new ValueTuple<string, object>(item4, (creatureDataComp5 != null) ? new int?(creatureDataComp5.GetPbDataId()) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("stateType", key);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 4) = new ValueTuple<string, object>("stateId", value);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 5) = new ValueTuple<string, object>("reason", reason);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 6));
			return false;
		}

		// Token: 0x0603C9A8 RID: 248232 RVA: 0x0115E9AC File Offset: 0x0115CBAC
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemMovementSyncComponent sceneItemMovementSyncComponent = (SceneItemMovementSyncComponent)componentTemplate;
			this.MoveAutonomousId = sceneItemMovementSyncComponent.MoveAutonomousId;
			return (sceneItemMovementSyncComponent.Blackboards == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.Blackboards), "Blackboards")) && (sceneItemMovementSyncComponent.StateEvents == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.StateEvents), "StateEvents"));
		}

		// Token: 0x17007290 RID: 29328
		// (get) Token: 0x0603C9A9 RID: 248233 RVA: 0x0115EA1C File Offset: 0x0115CC1C
		public override bool NeedInitInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007291 RID: 29329
		// (get) Token: 0x0603C9AA RID: 248234 RVA: 0x0115EA1F File Offset: 0x0115CC1F
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007292 RID: 29330
		// (get) Token: 0x0603C9AB RID: 248235 RVA: 0x0115EA22 File Offset: 0x0115CC22
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007293 RID: 29331
		// (get) Token: 0x0603C9AC RID: 248236 RVA: 0x0115EA25 File Offset: 0x0115CC25
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007294 RID: 29332
		// (get) Token: 0x0603C9AD RID: 248237 RVA: 0x0115EA28 File Offset: 0x0115CC28
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0402021C RID: 131612
		private const int INVALID_ID = 0;

		// Token: 0x0402021D RID: 131613
		private int MoveAutonomousId;

		// Token: 0x0402021E RID: 131614
		private readonly Dictionary<SceneItemBBKey, SceneItemMovementSyncComponent.TBlackboardValue?> Blackboards = new Dictionary<SceneItemBBKey, SceneItemMovementSyncComponent.TBlackboardValue?>();

		// Token: 0x0402021F RID: 131615
		private readonly Event<SceneItemBBKey, Action<SceneItemMovementSyncComponent.TBlackboardValue?, bool, string>> StateEvents = new Event<SceneItemBBKey, Action<SceneItemMovementSyncComponent.TBlackboardValue?, bool, string>>();

		// Token: 0x0200BA6A RID: 47722
		// (Invoke) Token: 0x06048725 RID: 296741
		[NullableContext(0)]
		public delegate void TStateEventCallback(SceneItemMovementSyncComponent.TBlackboardValue? value, bool fromRemote, string reason);

		// Token: 0x0200BA6B RID: 47723
		[Nullable(0)]
		public struct TBlackboardValue
		{
			// Token: 0x17007A68 RID: 31336
			// (get) Token: 0x06048728 RID: 296744 RVA: 0x01617CF4 File Offset: 0x01615EF4
			// (set) Token: 0x06048729 RID: 296745 RVA: 0x01617CFC File Offset: 0x01615EFC
			public SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType ValueType { readonly get; private set; }

			// Token: 0x0604872A RID: 296746 RVA: 0x01617D08 File Offset: 0x01615F08
			public TBlackboardValue()
			{
				this.IntValueInternal = 0;
				this.IntArrayValueInternal = null;
				this.FloatValueInternal = 0f;
				this.FloatArrayValueInternal = null;
				this.LongValueInternal = 0L;
				this.LongArrayValueInternal = null;
				this.RotatorValueInternal = null;
				this.RotatorArrayValueInternal = null;
				this.StringValueInternal = null;
				this.StringArrayValueInternal = null;
				this.VectorValueInternal = null;
				this.VectorArrayValueInternal = null;
				this.BoolValueInternal = false;
				this.ValueType = SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType.None;
			}

			// Token: 0x17007A69 RID: 31337
			// (get) Token: 0x0604872B RID: 296747 RVA: 0x01617D7C File Offset: 0x01615F7C
			// (set) Token: 0x0604872C RID: 296748 RVA: 0x01617DC8 File Offset: 0x01615FC8
			public int IntValue
			{
				get
				{
					if (this.ValueType == SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType.Int)
					{
						return this.IntValueInternal;
					}
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 1);
					defaultInterpolatedStringHandler.AppendLiteral("Value is not Int, current is ");
					defaultInterpolatedStringHandler.AppendFormatted<SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType>(this.ValueType);
					throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				set
				{
					this.ValueType = SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType.Int;
					this.IntValueInternal = value;
				}
			}

			// Token: 0x17007A6A RID: 31338
			// (get) Token: 0x0604872D RID: 296749 RVA: 0x01617DD8 File Offset: 0x01615FD8
			// (set) Token: 0x0604872E RID: 296750 RVA: 0x01617E24 File Offset: 0x01616024
			public int[] IntArrayValue
			{
				get
				{
					if (this.ValueType == SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType.IntArray)
					{
						return this.IntArrayValueInternal;
					}
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 1);
					defaultInterpolatedStringHandler.AppendLiteral("Value is not IntArray, current is ");
					defaultInterpolatedStringHandler.AppendFormatted<SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType>(this.ValueType);
					throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				set
				{
					this.ValueType = SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType.IntArray;
					this.IntArrayValueInternal = value;
				}
			}

			// Token: 0x17007A6B RID: 31339
			// (get) Token: 0x0604872F RID: 296751 RVA: 0x01617E34 File Offset: 0x01616034
			// (set) Token: 0x06048730 RID: 296752 RVA: 0x01617E80 File Offset: 0x01616080
			public float FloatValue
			{
				get
				{
					if (this.ValueType == SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType.Float)
					{
						return this.FloatValueInternal;
					}
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 1);
					defaultInterpolatedStringHandler.AppendLiteral("Value is not Float, current is ");
					defaultInterpolatedStringHandler.AppendFormatted<SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType>(this.ValueType);
					throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				set
				{
					this.ValueType = SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType.Float;
					this.FloatValueInternal = value;
				}
			}

			// Token: 0x17007A6C RID: 31340
			// (get) Token: 0x06048731 RID: 296753 RVA: 0x01617E90 File Offset: 0x01616090
			// (set) Token: 0x06048732 RID: 296754 RVA: 0x01617EDC File Offset: 0x016160DC
			public float[] FloatArrayValue
			{
				get
				{
					if (this.ValueType == SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType.FloatArray)
					{
						return this.FloatArrayValueInternal;
					}
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 1);
					defaultInterpolatedStringHandler.AppendLiteral("Value is not FloatArray, current is ");
					defaultInterpolatedStringHandler.AppendFormatted<SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType>(this.ValueType);
					throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				set
				{
					this.ValueType = SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType.FloatArray;
					this.FloatArrayValueInternal = value;
				}
			}

			// Token: 0x17007A6D RID: 31341
			// (get) Token: 0x06048733 RID: 296755 RVA: 0x01617EEC File Offset: 0x016160EC
			// (set) Token: 0x06048734 RID: 296756 RVA: 0x01617F38 File Offset: 0x01616138
			public long LongValue
			{
				get
				{
					if (this.ValueType == SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType.Long)
					{
						return this.LongValueInternal;
					}
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 1);
					defaultInterpolatedStringHandler.AppendLiteral("Value is not Long, current is ");
					defaultInterpolatedStringHandler.AppendFormatted<SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType>(this.ValueType);
					throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				set
				{
					this.ValueType = SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType.Long;
					this.LongValueInternal = value;
				}
			}

			// Token: 0x17007A6E RID: 31342
			// (get) Token: 0x06048735 RID: 296757 RVA: 0x01617F48 File Offset: 0x01616148
			// (set) Token: 0x06048736 RID: 296758 RVA: 0x01617F94 File Offset: 0x01616194
			public long[] LongArrayValue
			{
				get
				{
					if (this.ValueType == SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType.LongArray)
					{
						return this.LongArrayValueInternal;
					}
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 1);
					defaultInterpolatedStringHandler.AppendLiteral("Value is not LongArray, current is ");
					defaultInterpolatedStringHandler.AppendFormatted<SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType>(this.ValueType);
					throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				set
				{
					this.ValueType = SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType.LongArray;
					this.LongArrayValueInternal = value;
				}
			}

			// Token: 0x17007A6F RID: 31343
			// (get) Token: 0x06048737 RID: 296759 RVA: 0x01617FA4 File Offset: 0x016161A4
			// (set) Token: 0x06048738 RID: 296760 RVA: 0x01617FF0 File Offset: 0x016161F0
			public global::Rotator RotatorValue
			{
				get
				{
					if (this.ValueType == SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType.Rotator)
					{
						return this.RotatorValueInternal;
					}
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 1);
					defaultInterpolatedStringHandler.AppendLiteral("Value is not Rotator, current is ");
					defaultInterpolatedStringHandler.AppendFormatted<SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType>(this.ValueType);
					throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				set
				{
					this.ValueType = SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType.Rotator;
					this.RotatorValueInternal = value;
				}
			}

			// Token: 0x17007A70 RID: 31344
			// (get) Token: 0x06048739 RID: 296761 RVA: 0x01618000 File Offset: 0x01616200
			// (set) Token: 0x0604873A RID: 296762 RVA: 0x0161804C File Offset: 0x0161624C
			public global::Rotator[] RotatorArrayValue
			{
				get
				{
					if (this.ValueType == SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType.RotatorArray)
					{
						return this.RotatorArrayValueInternal;
					}
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(38, 1);
					defaultInterpolatedStringHandler.AppendLiteral("Value is not RotatorArray, current is ");
					defaultInterpolatedStringHandler.AppendFormatted<SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType>(this.ValueType);
					throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				set
				{
					this.ValueType = SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType.RotatorArray;
					this.RotatorArrayValueInternal = value;
				}
			}

			// Token: 0x17007A71 RID: 31345
			// (get) Token: 0x0604873B RID: 296763 RVA: 0x0161805C File Offset: 0x0161625C
			// (set) Token: 0x0604873C RID: 296764 RVA: 0x016180A9 File Offset: 0x016162A9
			public string StringValue
			{
				get
				{
					if (this.ValueType == SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType.String)
					{
						return this.StringValueInternal;
					}
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 1);
					defaultInterpolatedStringHandler.AppendLiteral("Value is not String, current is ");
					defaultInterpolatedStringHandler.AppendFormatted<SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType>(this.ValueType);
					throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				set
				{
					this.ValueType = SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType.String;
					this.StringValueInternal = value;
				}
			}

			// Token: 0x17007A72 RID: 31346
			// (get) Token: 0x0604873D RID: 296765 RVA: 0x016180BC File Offset: 0x016162BC
			// (set) Token: 0x0604873E RID: 296766 RVA: 0x01618109 File Offset: 0x01616309
			public string[] StringArrayValue
			{
				get
				{
					if (this.ValueType == SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType.StringArray)
					{
						return this.StringArrayValueInternal;
					}
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 1);
					defaultInterpolatedStringHandler.AppendLiteral("Value is not StringArray, current is ");
					defaultInterpolatedStringHandler.AppendFormatted<SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType>(this.ValueType);
					throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				set
				{
					this.ValueType = SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType.StringArray;
					this.StringArrayValueInternal = value;
				}
			}

			// Token: 0x17007A73 RID: 31347
			// (get) Token: 0x0604873F RID: 296767 RVA: 0x0161811C File Offset: 0x0161631C
			// (set) Token: 0x06048740 RID: 296768 RVA: 0x01618169 File Offset: 0x01616369
			public global::Vector VectorValue
			{
				get
				{
					if (this.ValueType == SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType.Vector)
					{
						return this.VectorValueInternal;
					}
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 1);
					defaultInterpolatedStringHandler.AppendLiteral("Value is not Vector, current is ");
					defaultInterpolatedStringHandler.AppendFormatted<SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType>(this.ValueType);
					throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				set
				{
					this.ValueType = SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType.Vector;
					this.VectorValueInternal = value;
				}
			}

			// Token: 0x17007A74 RID: 31348
			// (get) Token: 0x06048741 RID: 296769 RVA: 0x0161817C File Offset: 0x0161637C
			// (set) Token: 0x06048742 RID: 296770 RVA: 0x016181C9 File Offset: 0x016163C9
			public global::Vector[] VectorArrayValue
			{
				get
				{
					if (this.ValueType == SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType.VectorArray)
					{
						return this.VectorArrayValueInternal;
					}
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 1);
					defaultInterpolatedStringHandler.AppendLiteral("Value is not VectorArray, current is ");
					defaultInterpolatedStringHandler.AppendFormatted<SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType>(this.ValueType);
					throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				set
				{
					this.ValueType = SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType.VectorArray;
					this.VectorArrayValueInternal = value;
				}
			}

			// Token: 0x17007A75 RID: 31349
			// (get) Token: 0x06048743 RID: 296771 RVA: 0x016181DC File Offset: 0x016163DC
			// (set) Token: 0x06048744 RID: 296772 RVA: 0x01618229 File Offset: 0x01616429
			public bool BoolValue
			{
				get
				{
					if (this.ValueType == SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType.Bool)
					{
						return this.BoolValueInternal;
					}
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 1);
					defaultInterpolatedStringHandler.AppendLiteral("Value is not Bool, current is ");
					defaultInterpolatedStringHandler.AppendFormatted<SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType>(this.ValueType);
					throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				set
				{
					this.ValueType = SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType.Bool;
					this.BoolValueInternal = value;
				}
			}

			// Token: 0x06048745 RID: 296773 RVA: 0x0161823C File Offset: 0x0161643C
			public static implicit operator SceneItemMovementSyncComponent.TBlackboardValue(int value)
			{
				return new SceneItemMovementSyncComponent.TBlackboardValue
				{
					IntValue = value
				};
			}

			// Token: 0x06048746 RID: 296774 RVA: 0x0161825C File Offset: 0x0161645C
			public static implicit operator SceneItemMovementSyncComponent.TBlackboardValue(int[] value)
			{
				return new SceneItemMovementSyncComponent.TBlackboardValue
				{
					IntArrayValue = value
				};
			}

			// Token: 0x06048747 RID: 296775 RVA: 0x0161827C File Offset: 0x0161647C
			public static implicit operator SceneItemMovementSyncComponent.TBlackboardValue(float value)
			{
				return new SceneItemMovementSyncComponent.TBlackboardValue
				{
					FloatValue = value
				};
			}

			// Token: 0x06048748 RID: 296776 RVA: 0x0161829C File Offset: 0x0161649C
			public static implicit operator SceneItemMovementSyncComponent.TBlackboardValue(float[] value)
			{
				return new SceneItemMovementSyncComponent.TBlackboardValue
				{
					FloatArrayValue = value
				};
			}

			// Token: 0x06048749 RID: 296777 RVA: 0x016182BC File Offset: 0x016164BC
			public static implicit operator SceneItemMovementSyncComponent.TBlackboardValue(long value)
			{
				return new SceneItemMovementSyncComponent.TBlackboardValue
				{
					LongValue = value
				};
			}

			// Token: 0x0604874A RID: 296778 RVA: 0x016182DC File Offset: 0x016164DC
			public static implicit operator SceneItemMovementSyncComponent.TBlackboardValue(long[] value)
			{
				return new SceneItemMovementSyncComponent.TBlackboardValue
				{
					LongArrayValue = value
				};
			}

			// Token: 0x0604874B RID: 296779 RVA: 0x016182FC File Offset: 0x016164FC
			public static implicit operator SceneItemMovementSyncComponent.TBlackboardValue(global::Rotator value)
			{
				return new SceneItemMovementSyncComponent.TBlackboardValue
				{
					RotatorValue = value
				};
			}

			// Token: 0x0604874C RID: 296780 RVA: 0x0161831C File Offset: 0x0161651C
			public static implicit operator SceneItemMovementSyncComponent.TBlackboardValue(global::Rotator[] value)
			{
				return new SceneItemMovementSyncComponent.TBlackboardValue
				{
					RotatorArrayValue = value
				};
			}

			// Token: 0x0604874D RID: 296781 RVA: 0x0161833C File Offset: 0x0161653C
			public static implicit operator SceneItemMovementSyncComponent.TBlackboardValue(string value)
			{
				return new SceneItemMovementSyncComponent.TBlackboardValue
				{
					StringValue = value
				};
			}

			// Token: 0x0604874E RID: 296782 RVA: 0x0161835C File Offset: 0x0161655C
			public static implicit operator SceneItemMovementSyncComponent.TBlackboardValue(string[] value)
			{
				return new SceneItemMovementSyncComponent.TBlackboardValue
				{
					StringArrayValue = value
				};
			}

			// Token: 0x0604874F RID: 296783 RVA: 0x0161837C File Offset: 0x0161657C
			public static implicit operator SceneItemMovementSyncComponent.TBlackboardValue(global::Vector value)
			{
				return new SceneItemMovementSyncComponent.TBlackboardValue
				{
					VectorValue = value
				};
			}

			// Token: 0x06048750 RID: 296784 RVA: 0x0161839C File Offset: 0x0161659C
			public static implicit operator SceneItemMovementSyncComponent.TBlackboardValue(global::Vector[] value)
			{
				return new SceneItemMovementSyncComponent.TBlackboardValue
				{
					VectorArrayValue = value
				};
			}

			// Token: 0x06048751 RID: 296785 RVA: 0x016183BC File Offset: 0x016165BC
			public static implicit operator SceneItemMovementSyncComponent.TBlackboardValue(bool value)
			{
				return new SceneItemMovementSyncComponent.TBlackboardValue
				{
					BoolValue = value
				};
			}

			// Token: 0x040396CD RID: 235213
			private int IntValueInternal;

			// Token: 0x040396CE RID: 235214
			[Nullable(2)]
			private int[] IntArrayValueInternal;

			// Token: 0x040396CF RID: 235215
			private float FloatValueInternal;

			// Token: 0x040396D0 RID: 235216
			[Nullable(2)]
			private float[] FloatArrayValueInternal;

			// Token: 0x040396D1 RID: 235217
			private long LongValueInternal;

			// Token: 0x040396D2 RID: 235218
			[Nullable(2)]
			private long[] LongArrayValueInternal;

			// Token: 0x040396D3 RID: 235219
			[Nullable(2)]
			private global::Rotator RotatorValueInternal;

			// Token: 0x040396D4 RID: 235220
			[Nullable(new byte[]
			{
				2,
				1
			})]
			private global::Rotator[] RotatorArrayValueInternal;

			// Token: 0x040396D5 RID: 235221
			[Nullable(2)]
			private string StringValueInternal;

			// Token: 0x040396D6 RID: 235222
			[Nullable(new byte[]
			{
				2,
				1
			})]
			private string[] StringArrayValueInternal;

			// Token: 0x040396D7 RID: 235223
			[Nullable(2)]
			private global::Vector VectorValueInternal;

			// Token: 0x040396D8 RID: 235224
			[Nullable(new byte[]
			{
				2,
				1
			})]
			private global::Vector[] VectorArrayValueInternal;

			// Token: 0x040396D9 RID: 235225
			private bool BoolValueInternal;

			// Token: 0x0200BD99 RID: 48537
			[NullableContext(0)]
			public enum EBlackboardValueType
			{
				// Token: 0x0403A326 RID: 238374
				None,
				// Token: 0x0403A327 RID: 238375
				Int,
				// Token: 0x0403A328 RID: 238376
				IntArray,
				// Token: 0x0403A329 RID: 238377
				Float,
				// Token: 0x0403A32A RID: 238378
				FloatArray,
				// Token: 0x0403A32B RID: 238379
				Long,
				// Token: 0x0403A32C RID: 238380
				LongArray,
				// Token: 0x0403A32D RID: 238381
				Rotator,
				// Token: 0x0403A32E RID: 238382
				RotatorArray,
				// Token: 0x0403A32F RID: 238383
				String,
				// Token: 0x0403A330 RID: 238384
				StringArray,
				// Token: 0x0403A331 RID: 238385
				Vector,
				// Token: 0x0403A332 RID: 238386
				VectorArray,
				// Token: 0x0403A333 RID: 238387
				Bool
			}
		}
	}
}
