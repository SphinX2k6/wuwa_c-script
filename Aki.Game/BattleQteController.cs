using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Pawn.Component;

// Token: 0x02001AEA RID: 6890
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class BattleQteController : ControllerBase
{
	// Token: 0x060111A6 RID: 70054 RVA: 0x00506164 File Offset: 0x00504364
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

	// Token: 0x17001993 RID: 6547
	// (get) Token: 0x060111A7 RID: 70055 RVA: 0x005062E2 File Offset: 0x005044E2
	public static BattleQteController Instance
	{
		get
		{
			return BattleQteController._Instance;
		}
	}

	// Token: 0x060111A8 RID: 70056 RVA: 0x005062E9 File Offset: 0x005044E9
	public static BattleQteController GetOrCreateInstance()
	{
		if (BattleQteController._Instance == null)
		{
			BattleQteController.CreateInstance();
		}
		return BattleQteController._Instance;
	}

	// Token: 0x060111A9 RID: 70057 RVA: 0x005062FD File Offset: 0x005044FD
	public static bool CreateInstance()
	{
		if (BattleQteController._Instance != null)
		{
			return true;
		}
		BattleQteController._Instance = new BattleQteController();
		return true;
	}

	// Token: 0x060111AA RID: 70058 RVA: 0x00506313 File Offset: 0x00504513
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060111AB RID: 70059 RVA: 0x00506315 File Offset: 0x00504515
	public static void ResetStaticDefaultValue()
	{
		BattleQteController._Instance = null;
	}

	// Token: 0x060111AC RID: 70060 RVA: 0x0050631D File Offset: 0x0050451D
	static BattleQteController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BattleQteController.CreateStaticDefaultValue), new Action(BattleQteController.ResetStaticDefaultValue));
	}

	// Token: 0x04009686 RID: 38534
	[Nullable(2)]
	private static BattleQteController _Instance;
}
