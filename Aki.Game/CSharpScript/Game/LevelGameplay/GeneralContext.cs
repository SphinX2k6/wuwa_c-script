using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02006998 RID: 27032
	[NullableContext(1)]
	[Nullable(0)]
	public class GeneralContext : IStaticVariableResetter
	{
		// Token: 0x0604342E RID: 275502 RVA: 0x0106587F File Offset: 0x01063A7F
		static GeneralContext()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GeneralContext.CreateStaticDefaultValue), new Action(GeneralContext.ResetStaticDefaultValue));
		}

		// Token: 0x0604342F RID: 275503 RVA: 0x0106589E File Offset: 0x01063A9E
		public virtual void Reset()
		{
			this.SubType = null;
		}

		// Token: 0x06043430 RID: 275504 RVA: 0x010658AC File Offset: 0x01063AAC
		protected static GeneralContext GetObj(EGeneralContextType type, GameCtxType? subType, Func<GeneralContext> ctor)
		{
			List<GeneralContext> list;
			if (!GeneralContext.Pool.TryGetValue((int)type, out list))
			{
				list = new List<GeneralContext>();
				GeneralContext.Pool[(int)type] = list;
			}
			GeneralContext generalContext;
			if (list.Count > 0)
			{
				generalContext = list[list.Count - 1];
				list.RemoveAt(list.Count - 1);
				generalContext.InPool = false;
			}
			else
			{
				generalContext = ctor();
			}
			generalContext.SubType = subType;
			return generalContext;
		}

		// Token: 0x06043431 RID: 275505 RVA: 0x0106591C File Offset: 0x01063B1C
		public void Release()
		{
			this.Reset();
			if (this.InPool)
			{
				return;
			}
			List<GeneralContext> list;
			if (!GeneralContext.Pool.TryGetValue((int)this.Type.Value, out list))
			{
				list = new List<GeneralContext>();
				GeneralContext.Pool[(int)this.Type.Value] = list;
			}
			list.Add(this);
			this.InPool = true;
		}

		// Token: 0x06043432 RID: 275506 RVA: 0x0106597C File Offset: 0x01063B7C
		[return: Nullable(2)]
		public static GeneralContext Copy(GeneralContext obj)
		{
			if (obj == null)
			{
				return null;
			}
			GeneralContext result = null;
			EGeneralContextType? type = obj.Type;
			if (type != null)
			{
				switch (type.GetValueOrDefault())
				{
				case EGeneralContextType.Entity:
					result = EntityContext.Create((obj as EntityContext).EntityId.GetValueOrDefault(), obj.SubType);
					break;
				case EGeneralContextType.Quest:
					result = QuestContext.Create((obj as QuestContext).QuestId, obj.SubType);
					break;
				case EGeneralContextType.LevelPlay:
					result = LevelPlayContext.Create((obj as LevelPlayContext).LevelPlayId, obj.SubType);
					break;
				case EGeneralContextType.InstanceDungeon:
					result = InstanceDungeonContext.Create((obj as InstanceDungeonContext).InstanceDungeonId.GetValueOrDefault(), 0, obj.SubType);
					break;
				case EGeneralContextType.Trigger:
				{
					TriggerContext triggerContext = obj as TriggerContext;
					result = TriggerContext.Create(triggerContext.TriggerEntityId.GetValueOrDefault(), triggerContext.OtherEntityId.GetValueOrDefault(), obj.SubType, new ETriggerEventType?(triggerContext.TriggerType), null);
					break;
				}
				case EGeneralContextType.GeneralLogicTree:
				{
					GeneralLogicTreeContext generalLogicTreeContext = obj as GeneralLogicTreeContext;
					result = GeneralLogicTreeContext.Create(generalLogicTreeContext.BtType, generalLogicTreeContext.TreeIncId, generalLogicTreeContext.TreeConfigId, generalLogicTreeContext.NodeId, obj.SubType);
					break;
				}
				case EGeneralContextType.Guarantee:
				{
					GuaranteeContext guaranteeContext = obj as GuaranteeContext;
					result = GuaranteeContext.Create(obj.SubType, guaranteeContext.GuaranteeReason);
					break;
				}
				case EGeneralContextType.Plot:
					result = PlotContext.Create((obj as PlotContext).FlowIncId, obj.SubType);
					break;
				case EGeneralContextType.ClientEvent:
				{
					ClientEventContext clientEventContext = obj as ClientEventContext;
					result = ClientEventContext.Create(clientEventContext.EventName.Value, clientEventContext.Params);
					break;
				}
				case EGeneralContextType.Combination:
					result = CombinationContext.Create((obj as CombinationContext).Contexts.ToArray());
					break;
				case EGeneralContextType.DynamicInteract:
				{
					DynamicInteractContext dynamicInteractContext = obj as DynamicInteractContext;
					result = DynamicInteractContext.Create(dynamicInteractContext.EntityId.GetValueOrDefault(), dynamicInteractContext.FinalContext, obj.SubType);
					break;
				}
				case EGeneralContextType.SplinePointArrival:
				{
					SplinePointArrivalContext splinePointArrivalContext = obj as SplinePointArrivalContext;
					result = SplinePointArrivalContext.Create(splinePointArrivalContext.EntityId, splinePointArrivalContext.SplineId, splinePointArrivalContext.PointIndex);
					break;
				}
				}
			}
			return result;
		}

		// Token: 0x06043433 RID: 275507 RVA: 0x01065BAC File Offset: 0x01063DAC
		[return: Nullable(2)]
		public static T ExtractContext<[Nullable(0)] T>(GeneralContext context, EGeneralContextType targetType) where T : GeneralContext
		{
			EGeneralContextType? type = context.Type;
			if (type.GetValueOrDefault() == targetType & type != null)
			{
				return context as T;
			}
			if (context.Type != EGeneralContextType.Combination)
			{
				return default(T);
			}
			GeneralContext contextByType = (context as CombinationContext).GetContextByType<GeneralContext>(targetType);
			if (contextByType == null)
			{
				return default(T);
			}
			return contextByType as T;
		}

		// Token: 0x06043434 RID: 275508 RVA: 0x01065C2C File Offset: 0x01063E2C
		public static void CreateStaticDefaultValue()
		{
			GeneralContext.Pool = new Dictionary<int, List<GeneralContext>>();
		}

		// Token: 0x06043435 RID: 275509 RVA: 0x01065C38 File Offset: 0x01063E38
		public static void ResetStaticDefaultValue()
		{
			GeneralContext.Pool = null;
		}

		// Token: 0x0402309D RID: 143517
		private static Dictionary<int, List<GeneralContext>> Pool;

		// Token: 0x0402309E RID: 143518
		public EGeneralContextType? Type;

		// Token: 0x0402309F RID: 143519
		public GameCtxType? SubType;

		// Token: 0x040230A0 RID: 143520
		private bool InPool;
	}
}
