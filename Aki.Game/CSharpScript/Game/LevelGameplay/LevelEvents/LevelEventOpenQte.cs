using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.Common.Component;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CBE RID: 23742
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventOpenQte : LevelEventBase
	{
		// Token: 0x0603A2CB RID: 238283 RVA: 0x0106984A File Offset: 0x01067A4A
		public LevelEventOpenQte(int id) : base(id)
		{
		}

		// Token: 0x0603A2CC RID: 238284 RVA: 0x01069854 File Offset: 0x01067A54
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			OpenQteAction openQteAction = inParams as OpenQteAction;
			if (openQteAction == null)
			{
				base.FinishExecute(false, false, true);
				return;
			}
			EOpenQteType type = openQteAction.Config.Type;
			bool value;
			if (type != EOpenQteType.PanelQte)
			{
				value = (type == EOpenQteType.LevelQte && this.ExecuteLevelQte(openQteAction, context));
			}
			else
			{
				value = this.ExecutePanelQte(openQteAction, context);
			}
			base.FinishExecute(value, false, true);
		}

		// Token: 0x0603A2CD RID: 238285 RVA: 0x010698B0 File Offset: 0x01067AB0
		private bool ExecutePanelQte(OpenQteAction param, GeneralContext context)
		{
			IOpenPanelQteQte openPanelQteQte = param.Config as IOpenPanelQteQte;
			if (openPanelQteQte == null || openPanelQteQte.Type != EOpenQteType.PanelQte)
			{
				return false;
			}
			PanelQteController.Instance.StartLevelEventQte(openPanelQteQte.Id);
			return true;
		}

		// Token: 0x0603A2CE RID: 238286 RVA: 0x010698E8 File Offset: 0x01067AE8
		private bool ExecuteLevelQte(OpenQteAction param, GeneralContext context)
		{
			IOpenLevelQte openLevelQte = param.Config as IOpenLevelQte;
			if (openLevelQte == null || openLevelQte.Type != EOpenQteType.LevelQte)
			{
				return false;
			}
			Entity targetEntityByContext = this.GetTargetEntityByContext(openLevelQte.LevelQteEntity, context);
			if (targetEntityByContext == null || !targetEntityByContext.Valid)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.ZYL, "[LevelEventOpenQte] 找不到对应的QTE实体", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			LevelQteComponent component = targetEntityByContext.GetComponent<LevelQteComponent>();
			if (component == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.ZYL, "[LevelEventOpenQte] 实体缺少LevelQte组件", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			return component.StartQte(false);
		}

		// Token: 0x0603A2CF RID: 238287 RVA: 0x0106997C File Offset: 0x01067B7C
		[return: Nullable(2)]
		private Entity GetTargetEntityByContext(ITargetEntityType targetEntityConfig, GeneralContext context)
		{
			Entity result = null;
			switch (targetEntityConfig.Type)
			{
			case ETargetEntityType.Target:
			{
				CreatureModel instance = CreatureModel.Instance;
				Entity entity;
				if (instance == null)
				{
					entity = null;
				}
				else
				{
					EntityHandle entityByPbDataId = instance.GetEntityByPbDataId(((ITargetEntity)targetEntityConfig).EntityId);
					entity = ((entityByPbDataId != null) ? entityByPbDataId.Entity : null);
				}
				result = entity;
				break;
			}
			case ETargetEntityType.Self:
			{
				TriggerContext triggerContext = context as TriggerContext;
				if (triggerContext != null && triggerContext.TriggerEntityId != null)
				{
					CreatureModel instance2 = CreatureModel.Instance;
					Entity entity2;
					if (instance2 == null)
					{
						entity2 = null;
					}
					else
					{
						EntityHandle entityById = instance2.GetEntityById(triggerContext.TriggerEntityId.Value);
						entity2 = ((entityById != null) ? entityById.Entity : null);
					}
					result = entity2;
				}
				else
				{
					EntityContext entityContext = context as EntityContext;
					if (entityContext != null && entityContext.EntityId != null)
					{
						CreatureModel instance3 = CreatureModel.Instance;
						Entity entity3;
						if (instance3 == null)
						{
							entity3 = null;
						}
						else
						{
							EntityHandle entityById2 = instance3.GetEntityById(entityContext.EntityId.Value);
							entity3 = ((entityById2 != null) ? entityById2.Entity : null);
						}
						result = entity3;
					}
				}
				break;
			}
			case ETargetEntityType.Triggered:
			{
				TriggerContext triggerContext2 = context as TriggerContext;
				if (triggerContext2 == null || triggerContext2.OtherEntityId == null)
				{
					global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.ZYL, "[LevelEventOpenQte] context数据异常", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				else
				{
					CreatureModel instance4 = CreatureModel.Instance;
					Entity entity4;
					if (instance4 == null)
					{
						entity4 = null;
					}
					else
					{
						EntityHandle entityById3 = instance4.GetEntityById(triggerContext2.OtherEntityId.Value);
						entity4 = ((entityById3 != null) ? entityById3.Entity : null);
					}
					result = entity4;
				}
				break;
			}
			case ETargetEntityType.Player:
			{
				TsBaseCharacter baseCharacter = Global.BaseCharacter;
				result = ((baseCharacter != null) ? baseCharacter.GetEntityNoBlueprint() : null);
				break;
			}
			}
			return result;
		}
	}
}
