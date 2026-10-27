using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Pawn.Component;

// Token: 0x020025FF RID: 9727
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class BattleQteController : ControllerBase
{
	// Token: 0x06013CC4 RID: 81092 RVA: 0x004F7388 File Offset: 0x004F5588
	[return: Nullable(2)]
	public BattleQteContext StartBattleQte(int battleQteId, long messageId, EntityHandle entityHandle, EBattleQteSource source)
	{
		BattleQteController.<>c__DisplayClass0_0 CS$<>8__locals1 = new BattleQteController.<>c__DisplayClass0_0();
		string text = null;
		if (CommonQteController.Instance.IsInQte())
		{
			text = "当前存在执行中的Qte, 无法开始新的Qte";
		}
		else if (CommonQteController.Instance.IsPreloading())
		{
			text = "Qte预加载中, 无法开始新的Qte";
		}
		else
		{
			GameModeModel instance = GameModeModel.Instance;
			if (instance != null && instance.IsMulti)
			{
				text = "联机状态下不能触发战斗Qte";
			}
			else if (Time.Instance.FlowTimeDilation == 0f)
			{
				text = "副本时停中, 不能触发战斗Qte";
			}
			else
			{
				SceneTeamModel instance2 = SceneTeamModel.Instance;
				SceneTeamItem sceneTeamItem = (instance2 != null) ? instance2.GetCurrentTeamItem : null;
				EntityHandle entityHandle2 = (sceneTeamItem != null) ? sceneTeamItem.EntityHandle : null;
				WorldEntity worldEntity = (entityHandle2 != null) ? entityHandle2.Entity : null;
				if (entityHandle2 == null || !entityHandle2.Valid || worldEntity == null)
				{
					text = "当前角色实体无效, 不能触发战斗Qte";
				}
				else if (sceneTeamItem != null && sceneTeamItem.IsDead())
				{
					text = "当前角色已死亡, 不能触发战斗Qte";
				}
				else
				{
					PawnTimeScaleComponent component = worldEntity.GetComponent<PawnTimeScaleComponent>();
					if (component != null && component.HasPauseLock())
					{
						text = "当前角色大招时停中, 不能触发战斗Qte";
					}
				}
			}
		}
		if (text != null)
		{
			return null;
		}
		BattleQteController.<>c__DisplayClass0_0 CS$<>8__locals2 = CS$<>8__locals1;
		BattleQteModel instance3 = BattleQteModel.Instance;
		CS$<>8__locals2.context = ((instance3 != null) ? instance3.CreateBattleQteContext(battleQteId, messageId, entityHandle, source) : null);
		if (CS$<>8__locals1.context == null)
		{
			return null;
		}
		CommonQteContextBase commonQteContextBase = CommonQteController.Instance.StartQte(CS$<>8__locals1.context.CommonQteId, delegate(CommonQteContextBase _)
		{
			CS$<>8__locals1.context.QteSuccess();
		}, delegate(CommonQteContextBase _)
		{
			CS$<>8__locals1.context.QteFail();
		}, EQteSource.Battle, null);
		if (commonQteContextBase != null)
		{
			CS$<>8__locals1.context.CommonQteHandleId = commonQteContextBase.HandleId;
			BattleQteModel instance4 = BattleQteModel.Instance;
			if (instance4 != null)
			{
				instance4.SetCurrentBattleQte(CS$<>8__locals1.context);
			}
			return CS$<>8__locals1.context;
		}
		return null;
	}

	// Token: 0x1700195B RID: 6491
	// (get) Token: 0x06013CC5 RID: 81093 RVA: 0x004F7506 File Offset: 0x004F5706
	public static BattleQteController Instance
	{
		get
		{
			return BattleQteController._Instance;
		}
	}

	// Token: 0x06013CC6 RID: 81094 RVA: 0x004F750D File Offset: 0x004F570D
	public static BattleQteController GetOrCreateInstance()
	{
		if (BattleQteController._Instance == null)
		{
			BattleQteController.CreateInstance();
		}
		return BattleQteController._Instance;
	}

	// Token: 0x06013CC7 RID: 81095 RVA: 0x004F7521 File Offset: 0x004F5721
	public static bool CreateInstance()
	{
		if (BattleQteController._Instance != null)
		{
			return true;
		}
		BattleQteController._Instance = new BattleQteController();
		return true;
	}

	// Token: 0x06013CC8 RID: 81096 RVA: 0x004F7537 File Offset: 0x004F5737
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06013CC9 RID: 81097 RVA: 0x004F7539 File Offset: 0x004F5739
	public static void ResetStaticDefaultValue()
	{
		BattleQteController._Instance = null;
	}

	// Token: 0x06013CCA RID: 81098 RVA: 0x004F7541 File Offset: 0x004F5741
	static BattleQteController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BattleQteController.CreateStaticDefaultValue), new Action(BattleQteController.ResetStaticDefaultValue));
	}

	// Token: 0x0400952F RID: 38191
	[Nullable(2)]
	private static BattleQteController _Instance;
}
