using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Common.Component;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x02007186 RID: 29062
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemMovementSyncComponent : BaseMovementSyncComponent
	{
		// Token: 0x060470F4 RID: 291060 RVA: 0x0120406C File Offset: 0x0120226C
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

		// Token: 0x060470F5 RID: 291061 RVA: 0x012040C4 File Offset: 0x012022C4
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

		// Token: 0x060470F6 RID: 291062 RVA: 0x01204138 File Offset: 0x01202338
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

		// Token: 0x060470F7 RID: 291063 RVA: 0x012041C6 File Offset: 0x012023C6
		public int GetAutonomousId()
		{
			return this.MoveAutonomousId;
		}

		// Token: 0x060470F8 RID: 291064 RVA: 0x012041CE File Offset: 0x012023CE
		public bool HasMoveController()
		{
			return this.MoveAutonomousId != 0;
		}

		// Token: 0x060470F9 RID: 291065 RVA: 0x012041D9 File Offset: 0x012023D9
		public bool HasMoveAuthority()
		{
			BaseActorComponent actorComp = this.ActorComp;
			return actorComp != null && actorComp.IsMoveAutonomousProxy;
		}

		// Token: 0x060470FA RID: 291066 RVA: 0x012041EC File Offset: 0x012023EC
		[NullableContext(2)]
		private void SetBlackboardInner(SceneItemBBKey key, SceneItemMovementSyncComponent.TBlackboardValue? value, bool fromRemote, string reason = null)
		{
			this.Blackboards[key] = value;
			this.StateEvents.Emit<SceneItemMovementSyncComponent.TBlackboardValue?, bool, string>(key, value, fromRemote, reason ?? "");
		}

		// Token: 0x060470FB RID: 291067 RVA: 0x01204215 File Offset: 0x01202415
		public void ListenBlackboard(SceneItemBBKey key, Action<SceneItemMovementSyncComponent.TBlackboardValue?, bool, string> callback)
		{
			this.StateEvents.Add(key, callback);
		}

		// Token: 0x060470FC RID: 291068 RVA: 0x01204225 File Offset: 0x01202425
		public void RemoveBlackboardListener(SceneItemBBKey key, Action<SceneItemMovementSyncComponent.TBlackboardValue?, bool, string> callback)
		{
			this.StateEvents.Remove(key, callback);
		}

		// Token: 0x060470FD RID: 291069 RVA: 0x01204238 File Offset: 0x01202438
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
						value = new SceneItemMovementSyncComponent.TBlackboardValue?(sceneItemBlackboardParam.IntValues.Values.ToArray<int>());
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
						value = new SceneItemMovementSyncComponent.TBlackboardValue?(sceneItemBlackboardParam.LongValues.Values.ToArray<long>());
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
						value = new SceneItemMovementSyncComponent.TBlackboardValue?(sceneItemBlackboardParam.FloatValues.Values.ToArray<float>());
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

		// Token: 0x060470FE RID: 291070 RVA: 0x012044D8 File Offset: 0x012026D8
		public SceneItemMovementSyncComponent.TBlackboardValue? GetBlackboard(SceneItemBBKey key)
		{
			SceneItemMovementSyncComponent.TBlackboardValue? result;
			if (this.Blackboards.TryGetValue(key, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x060470FF RID: 291071 RVA: 0x01204500 File Offset: 0x01202700
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

		// Token: 0x06047100 RID: 291072 RVA: 0x012047BC File Offset: 0x012029BC
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemMovementSyncComponent sceneItemMovementSyncComponent = (SceneItemMovementSyncComponent)componentTemplate;
			if (base.CanResetComponentProperty("MoveAutonomousId"))
			{
				this.MoveAutonomousId = sceneItemMovementSyncComponent.MoveAutonomousId;
			}
			return (!base.CanResetComponentProperty("Blackboards") || sceneItemMovementSyncComponent.Blackboards == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<SceneItemBBKey, SceneItemMovementSyncComponent.TBlackboardValue?>>(this.Blackboards), "Blackboards")) && (!base.CanResetComponentProperty("StateEvents") || sceneItemMovementSyncComponent.StateEvents == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Event<SceneItemBBKey, Action<SceneItemMovementSyncComponent.TBlackboardValue?, bool, string>>>(this.StateEvents), "StateEvents"));
		}

		// Token: 0x040255B5 RID: 153013
		private const int INVALID_ID = 0;

		// Token: 0x040255B6 RID: 153014
		private int MoveAutonomousId;

		// Token: 0x040255B7 RID: 153015
		private readonly Dictionary<SceneItemBBKey, SceneItemMovementSyncComponent.TBlackboardValue?> Blackboards = new Dictionary<SceneItemBBKey, SceneItemMovementSyncComponent.TBlackboardValue?>();

		// Token: 0x040255B8 RID: 153016
		private readonly Event<SceneItemBBKey, Action<SceneItemMovementSyncComponent.TBlackboardValue?, bool, string>> StateEvents = new Event<SceneItemBBKey, Action<SceneItemMovementSyncComponent.TBlackboardValue?, bool, string>>();

		// Token: 0x0200CED4 RID: 52948
		// (Invoke) Token: 0x06051F7B RID: 335739
		[NullableContext(0)]
		public delegate void TStateEventCallback(SceneItemMovementSyncComponent.TBlackboardValue? value, bool fromRemote, string reason);

		// Token: 0x0200CED5 RID: 52949
		[Nullable(0)]
		public struct TBlackboardValue
		{
			// Token: 0x1700A2CE RID: 41678
			// (get) Token: 0x06051F7E RID: 335742 RVA: 0x01645BCC File Offset: 0x01643DCC
			// (set) Token: 0x06051F7F RID: 335743 RVA: 0x01645BD4 File Offset: 0x01643DD4
			public SceneItemMovementSyncComponent.TBlackboardValue.EBlackboardValueType ValueType { readonly get; private set; }

			// Token: 0x06051F80 RID: 335744 RVA: 0x01645BE0 File Offset: 0x01643DE0
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

			// Token: 0x1700A2CF RID: 41679
			// (get) Token: 0x06051F81 RID: 335745 RVA: 0x01645C54 File Offset: 0x01643E54
			// (set) Token: 0x06051F82 RID: 335746 RVA: 0x01645CA0 File Offset: 0x01643EA0
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

			// Token: 0x1700A2D0 RID: 41680
			// (get) Token: 0x06051F83 RID: 335747 RVA: 0x01645CB0 File Offset: 0x01643EB0
			// (set) Token: 0x06051F84 RID: 335748 RVA: 0x01645CFC File Offset: 0x01643EFC
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

			// Token: 0x1700A2D1 RID: 41681
			// (get) Token: 0x06051F85 RID: 335749 RVA: 0x01645D0C File Offset: 0x01643F0C
			// (set) Token: 0x06051F86 RID: 335750 RVA: 0x01645D58 File Offset: 0x01643F58
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

			// Token: 0x1700A2D2 RID: 41682
			// (get) Token: 0x06051F87 RID: 335751 RVA: 0x01645D68 File Offset: 0x01643F68
			// (set) Token: 0x06051F88 RID: 335752 RVA: 0x01645DB4 File Offset: 0x01643FB4
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

			// Token: 0x1700A2D3 RID: 41683
			// (get) Token: 0x06051F89 RID: 335753 RVA: 0x01645DC4 File Offset: 0x01643FC4
			// (set) Token: 0x06051F8A RID: 335754 RVA: 0x01645E10 File Offset: 0x01644010
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

			// Token: 0x1700A2D4 RID: 41684
			// (get) Token: 0x06051F8B RID: 335755 RVA: 0x01645E20 File Offset: 0x01644020
			// (set) Token: 0x06051F8C RID: 335756 RVA: 0x01645E6C File Offset: 0x0164406C
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

			// Token: 0x1700A2D5 RID: 41685
			// (get) Token: 0x06051F8D RID: 335757 RVA: 0x01645E7C File Offset: 0x0164407C
			// (set) Token: 0x06051F8E RID: 335758 RVA: 0x01645EC8 File Offset: 0x016440C8
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

			// Token: 0x1700A2D6 RID: 41686
			// (get) Token: 0x06051F8F RID: 335759 RVA: 0x01645ED8 File Offset: 0x016440D8
			// (set) Token: 0x06051F90 RID: 335760 RVA: 0x01645F24 File Offset: 0x01644124
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

			// Token: 0x1700A2D7 RID: 41687
			// (get) Token: 0x06051F91 RID: 335761 RVA: 0x01645F34 File Offset: 0x01644134
			// (set) Token: 0x06051F92 RID: 335762 RVA: 0x01645F81 File Offset: 0x01644181
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

			// Token: 0x1700A2D8 RID: 41688
			// (get) Token: 0x06051F93 RID: 335763 RVA: 0x01645F94 File Offset: 0x01644194
			// (set) Token: 0x06051F94 RID: 335764 RVA: 0x01645FE1 File Offset: 0x016441E1
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

			// Token: 0x1700A2D9 RID: 41689
			// (get) Token: 0x06051F95 RID: 335765 RVA: 0x01645FF4 File Offset: 0x016441F4
			// (set) Token: 0x06051F96 RID: 335766 RVA: 0x01646041 File Offset: 0x01644241
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

			// Token: 0x1700A2DA RID: 41690
			// (get) Token: 0x06051F97 RID: 335767 RVA: 0x01646054 File Offset: 0x01644254
			// (set) Token: 0x06051F98 RID: 335768 RVA: 0x016460A1 File Offset: 0x016442A1
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

			// Token: 0x1700A2DB RID: 41691
			// (get) Token: 0x06051F99 RID: 335769 RVA: 0x016460B4 File Offset: 0x016442B4
			// (set) Token: 0x06051F9A RID: 335770 RVA: 0x01646101 File Offset: 0x01644301
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

			// Token: 0x06051F9B RID: 335771 RVA: 0x01646114 File Offset: 0x01644314
			public static implicit operator SceneItemMovementSyncComponent.TBlackboardValue(int value)
			{
				return new SceneItemMovementSyncComponent.TBlackboardValue
				{
					IntValue = value
				};
			}

			// Token: 0x06051F9C RID: 335772 RVA: 0x01646134 File Offset: 0x01644334
			public static implicit operator SceneItemMovementSyncComponent.TBlackboardValue(int[] value)
			{
				return new SceneItemMovementSyncComponent.TBlackboardValue
				{
					IntArrayValue = value
				};
			}

			// Token: 0x06051F9D RID: 335773 RVA: 0x01646154 File Offset: 0x01644354
			public static implicit operator SceneItemMovementSyncComponent.TBlackboardValue(float value)
			{
				return new SceneItemMovementSyncComponent.TBlackboardValue
				{
					FloatValue = value
				};
			}

			// Token: 0x06051F9E RID: 335774 RVA: 0x01646174 File Offset: 0x01644374
			public static implicit operator SceneItemMovementSyncComponent.TBlackboardValue(float[] value)
			{
				return new SceneItemMovementSyncComponent.TBlackboardValue
				{
					FloatArrayValue = value
				};
			}

			// Token: 0x06051F9F RID: 335775 RVA: 0x01646194 File Offset: 0x01644394
			public static implicit operator SceneItemMovementSyncComponent.TBlackboardValue(long value)
			{
				return new SceneItemMovementSyncComponent.TBlackboardValue
				{
					LongValue = value
				};
			}

			// Token: 0x06051FA0 RID: 335776 RVA: 0x016461B4 File Offset: 0x016443B4
			public static implicit operator SceneItemMovementSyncComponent.TBlackboardValue(long[] value)
			{
				return new SceneItemMovementSyncComponent.TBlackboardValue
				{
					LongArrayValue = value
				};
			}

			// Token: 0x06051FA1 RID: 335777 RVA: 0x016461D4 File Offset: 0x016443D4
			public static implicit operator SceneItemMovementSyncComponent.TBlackboardValue(global::Rotator value)
			{
				return new SceneItemMovementSyncComponent.TBlackboardValue
				{
					RotatorValue = value
				};
			}

			// Token: 0x06051FA2 RID: 335778 RVA: 0x016461F4 File Offset: 0x016443F4
			public static implicit operator SceneItemMovementSyncComponent.TBlackboardValue(global::Rotator[] value)
			{
				return new SceneItemMovementSyncComponent.TBlackboardValue
				{
					RotatorArrayValue = value
				};
			}

			// Token: 0x06051FA3 RID: 335779 RVA: 0x01646214 File Offset: 0x01644414
			public static implicit operator SceneItemMovementSyncComponent.TBlackboardValue(string value)
			{
				return new SceneItemMovementSyncComponent.TBlackboardValue
				{
					StringValue = value
				};
			}

			// Token: 0x06051FA4 RID: 335780 RVA: 0x01646234 File Offset: 0x01644434
			public static implicit operator SceneItemMovementSyncComponent.TBlackboardValue(string[] value)
			{
				return new SceneItemMovementSyncComponent.TBlackboardValue
				{
					StringArrayValue = value
				};
			}

			// Token: 0x06051FA5 RID: 335781 RVA: 0x01646254 File Offset: 0x01644454
			public static implicit operator SceneItemMovementSyncComponent.TBlackboardValue(global::Vector value)
			{
				return new SceneItemMovementSyncComponent.TBlackboardValue
				{
					VectorValue = value
				};
			}

			// Token: 0x06051FA6 RID: 335782 RVA: 0x01646274 File Offset: 0x01644474
			public static implicit operator SceneItemMovementSyncComponent.TBlackboardValue(global::Vector[] value)
			{
				return new SceneItemMovementSyncComponent.TBlackboardValue
				{
					VectorArrayValue = value
				};
			}

			// Token: 0x06051FA7 RID: 335783 RVA: 0x01646294 File Offset: 0x01644494
			public static implicit operator SceneItemMovementSyncComponent.TBlackboardValue(bool value)
			{
				return new SceneItemMovementSyncComponent.TBlackboardValue
				{
					BoolValue = value
				};
			}

			// Token: 0x0403E3A7 RID: 254887
			private int IntValueInternal;

			// Token: 0x0403E3A8 RID: 254888
			[Nullable(2)]
			private int[] IntArrayValueInternal;

			// Token: 0x0403E3A9 RID: 254889
			private float FloatValueInternal;

			// Token: 0x0403E3AA RID: 254890
			[Nullable(2)]
			private float[] FloatArrayValueInternal;

			// Token: 0x0403E3AB RID: 254891
			private long LongValueInternal;

			// Token: 0x0403E3AC RID: 254892
			[Nullable(2)]
			private long[] LongArrayValueInternal;

			// Token: 0x0403E3AD RID: 254893
			[Nullable(2)]
			private global::Rotator RotatorValueInternal;

			// Token: 0x0403E3AE RID: 254894
			[Nullable(new byte[]
			{
				2,
				1
			})]
			private global::Rotator[] RotatorArrayValueInternal;

			// Token: 0x0403E3AF RID: 254895
			[Nullable(2)]
			private string StringValueInternal;

			// Token: 0x0403E3B0 RID: 254896
			[Nullable(new byte[]
			{
				2,
				1
			})]
			private string[] StringArrayValueInternal;

			// Token: 0x0403E3B1 RID: 254897
			[Nullable(2)]
			private global::Vector VectorValueInternal;

			// Token: 0x0403E3B2 RID: 254898
			[Nullable(new byte[]
			{
				2,
				1
			})]
			private global::Vector[] VectorArrayValueInternal;

			// Token: 0x0403E3B3 RID: 254899
			private bool BoolValueInternal;

			// Token: 0x0200D1B6 RID: 53686
			[NullableContext(0)]
			public enum EBlackboardValueType
			{
				// Token: 0x0403EEC9 RID: 257737
				None,
				// Token: 0x0403EECA RID: 257738
				Int,
				// Token: 0x0403EECB RID: 257739
				IntArray,
				// Token: 0x0403EECC RID: 257740
				Float,
				// Token: 0x0403EECD RID: 257741
				FloatArray,
				// Token: 0x0403EECE RID: 257742
				Long,
				// Token: 0x0403EECF RID: 257743
				LongArray,
				// Token: 0x0403EED0 RID: 257744
				Rotator,
				// Token: 0x0403EED1 RID: 257745
				RotatorArray,
				// Token: 0x0403EED2 RID: 257746
				String,
				// Token: 0x0403EED3 RID: 257747
				StringArray,
				// Token: 0x0403EED4 RID: 257748
				Vector,
				// Token: 0x0403EED5 RID: 257749
				VectorArray,
				// Token: 0x0403EED6 RID: 257750
				Bool
			}
		}
	}
}
