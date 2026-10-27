using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200292E RID: 10542
[NullableContext(2)]
[Nullable(0)]
public class RouletteGridForbiddenSettings : IStaticVariableResetter
{
	// Token: 0x06015C10 RID: 89104 RVA: 0x0057CBF2 File Offset: 0x0057ADF2
	static RouletteGridForbiddenSettings()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RouletteGridForbiddenSettings.CreateStaticDefaultValue), new Action(RouletteGridForbiddenSettings.ResetStaticDefaultValue));
	}

	// Token: 0x06015C11 RID: 89105 RVA: 0x0057CC14 File Offset: 0x0057AE14
	public static bool CheckForbiddenState(ERouletteGridType gridType, int id)
	{
		Func<bool> func;
		return gridType == ERouletteGridType.Explore && RouletteGridForbiddenSettings.ExploreGridForbiddenCheckMap.TryGetValue((ERouletteExploreId)id, out func) && func();
	}

	// Token: 0x06015C12 RID: 89106 RVA: 0x0057CC3C File Offset: 0x0057AE3C
	public static void TipsForbiddenState(ERouletteGridType gridType, int id)
	{
		Action action;
		if (gridType == ERouletteGridType.Explore && RouletteGridForbiddenSettings.ExploreGridForbiddenTipsMap.TryGetValue((ERouletteExploreId)id, out action))
		{
			action();
		}
	}

	// Token: 0x06015C13 RID: 89107 RVA: 0x0057CC64 File Offset: 0x0057AE64
	public static bool CheckLockState(ERouletteGridType gridType, int id)
	{
		if (gridType != ERouletteGridType.Explore)
		{
			if (gridType == ERouletteGridType.Function)
			{
				if (RouletteModel.Instance.GetFuncDataByFuncId(id) == null)
				{
					return true;
				}
			}
		}
		else if (RouletteModel.Instance.GetExploreDataBySkillId(id) == null)
		{
			return true;
		}
		return false;
	}

	// Token: 0x06015C14 RID: 89108 RVA: 0x0057CCAC File Offset: 0x0057AEAC
	public static void TipsLockState(ERouletteGridType gridType, int id)
	{
		if (gridType == ERouletteGridType.Explore)
		{
			ExploreTools? exploreConfigById = RouletteConfig.Instance.GetExploreConfigById(id);
			if (exploreConfigById == null)
			{
				return;
			}
			if (exploreConfigById.Value.SkillType == 4)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_SkillUnlockTech", Array.Empty<object>());
			}
		}
	}

	// Token: 0x06015C15 RID: 89109 RVA: 0x0057CCF8 File Offset: 0x0057AEF8
	public static EGridBehavior? CheckGridSpecialState(ERouletteViewType rouletteViewType, ERouletteGridType gridType, int id)
	{
		switch (gridType)
		{
		case ERouletteGridType.Explore:
			if (RouletteGridForbiddenSettings.CheckForbiddenState(gridType, id))
			{
				return new EGridBehavior?(EGridBehavior.Forbidden);
			}
			if (RouletteGridForbiddenSettings.CheckLockState(gridType, id))
			{
				return new EGridBehavior?(EGridBehavior.Lock);
			}
			break;
		case ERouletteGridType.Function:
			if (RouletteGridForbiddenSettings.CheckLockState(gridType, id))
			{
				return new EGridBehavior?(EGridBehavior.Empty);
			}
			break;
		case ERouletteGridType.EquipItem:
		{
			bool flag = rouletteViewType == ERouletteViewType.Main;
			bool flag2 = RouletteModel.Instance.GetCurrentExploreRouletteListData().IsRouletteReplace();
			if (flag && flag2 && RouletteModel.Instance.CurrentEquipItemId == 0)
			{
				return new EGridBehavior?(EGridBehavior.Empty);
			}
			break;
		}
		}
		return null;
	}

	// Token: 0x06015C16 RID: 89110 RVA: 0x0057CD80 File Offset: 0x0057AF80
	public static void CreateStaticDefaultValue()
	{
		RouletteGridForbiddenSettings.IsBanHook = delegate()
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			object obj;
			if (getCurrentEntity == null)
			{
				obj = null;
			}
			else
			{
				WorldEntity entity = getCurrentEntity.Entity;
				obj = ((entity != null) ? entity.GetComponent<BaseTagComponent>() : null);
			}
			object obj2 = obj;
			return obj2 != null && obj2.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.探索技能.禁用自由钩锁"]);
		};
		RouletteGridForbiddenSettings.IsBanFloaterAim = delegate()
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			object obj;
			if (getCurrentEntity == null)
			{
				obj = null;
			}
			else
			{
				WorldEntity entity = getCurrentEntity.Entity;
				obj = ((entity != null) ? entity.GetComponent<BaseTagComponent>() : null);
			}
			object obj2 = obj;
			return obj2 != null && obj2.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.探索技能.禁用辅助机"]);
		};
		RouletteGridForbiddenSettings.IsBanMotorcyclePark = (() => GameModeModel.Instance.IsMulti);
		RouletteGridForbiddenSettings.MotorcycleParkBanTips = delegate()
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Flying_Tip_002", Array.Empty<object>());
		};
		RouletteGridForbiddenSettings.ExploreGridForbiddenCheckMap = new Dictionary<ERouletteExploreId, Func<bool>>
		{
			{
				ERouletteExploreId.钩索,
				RouletteGridForbiddenSettings.IsBanHook
			},
			{
				ERouletteExploreId.辅助机,
				RouletteGridForbiddenSettings.IsBanFloaterAim
			},
			{
				ERouletteExploreId.摩托车停靠,
				RouletteGridForbiddenSettings.IsBanMotorcyclePark
			}
		};
		RouletteGridForbiddenSettings.ExploreGridForbiddenTipsMap = new Dictionary<ERouletteExploreId, Action>
		{
			{
				ERouletteExploreId.摩托车停靠,
				RouletteGridForbiddenSettings.MotorcycleParkBanTips
			}
		};
	}

	// Token: 0x06015C17 RID: 89111 RVA: 0x0057CE71 File Offset: 0x0057B071
	public static void ResetStaticDefaultValue()
	{
		RouletteGridForbiddenSettings.IsBanHook = null;
		RouletteGridForbiddenSettings.IsBanFloaterAim = null;
		RouletteGridForbiddenSettings.IsBanMotorcyclePark = null;
		RouletteGridForbiddenSettings.MotorcycleParkBanTips = null;
		RouletteGridForbiddenSettings.ExploreGridForbiddenCheckMap = null;
		RouletteGridForbiddenSettings.ExploreGridForbiddenTipsMap = null;
	}

	// Token: 0x0400A209 RID: 41481
	private static Func<bool> IsBanHook;

	// Token: 0x0400A20A RID: 41482
	private static Func<bool> IsBanFloaterAim;

	// Token: 0x0400A20B RID: 41483
	private static Func<bool> IsBanMotorcyclePark;

	// Token: 0x0400A20C RID: 41484
	private static Action MotorcycleParkBanTips;

	// Token: 0x0400A20D RID: 41485
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<ERouletteExploreId, Func<bool>> ExploreGridForbiddenCheckMap;

	// Token: 0x0400A20E RID: 41486
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<ERouletteExploreId, Action> ExploreGridForbiddenTipsMap;
}
