using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001EA9 RID: 7849
[NullableContext(2)]
[Nullable(0)]
public class RouletteGridForbiddenSettings : IStaticVariableResetter
{
	// Token: 0x06013615 RID: 79381 RVA: 0x005A7C32 File Offset: 0x005A5E32
	static RouletteGridForbiddenSettings()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RouletteGridForbiddenSettings.CreateStaticDefaultValue), new Action(RouletteGridForbiddenSettings.ResetStaticDefaultValue));
	}

	// Token: 0x06013616 RID: 79382 RVA: 0x005A7C54 File Offset: 0x005A5E54
	public static bool CheckForbiddenState(ERouletteGridType gridType, int id)
	{
		Func<bool> func;
		return gridType == ERouletteGridType.Explore && RouletteGridForbiddenSettings.ExploreGridForbiddenCheckMap.TryGetValue((ERouletteExploreId)id, out func) && func();
	}

	// Token: 0x06013617 RID: 79383 RVA: 0x005A7C7C File Offset: 0x005A5E7C
	public static void TipsForbiddenState(ERouletteGridType gridType, int id)
	{
		Action action;
		if (gridType == ERouletteGridType.Explore && RouletteGridForbiddenSettings.ExploreGridForbiddenTipsMap.TryGetValue((ERouletteExploreId)id, out action))
		{
			action();
		}
	}

	// Token: 0x06013618 RID: 79384 RVA: 0x005A7CA4 File Offset: 0x005A5EA4
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

	// Token: 0x06013619 RID: 79385 RVA: 0x005A7CEC File Offset: 0x005A5EEC
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

	// Token: 0x0601361A RID: 79386 RVA: 0x005A7D38 File Offset: 0x005A5F38
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

	// Token: 0x0601361B RID: 79387 RVA: 0x005A7DC0 File Offset: 0x005A5FC0
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

	// Token: 0x0601361C RID: 79388 RVA: 0x005A7EB1 File Offset: 0x005A60B1
	public static void ResetStaticDefaultValue()
	{
		RouletteGridForbiddenSettings.IsBanHook = null;
		RouletteGridForbiddenSettings.IsBanFloaterAim = null;
		RouletteGridForbiddenSettings.IsBanMotorcyclePark = null;
		RouletteGridForbiddenSettings.MotorcycleParkBanTips = null;
		RouletteGridForbiddenSettings.ExploreGridForbiddenCheckMap = null;
		RouletteGridForbiddenSettings.ExploreGridForbiddenTipsMap = null;
	}

	// Token: 0x0400A5F4 RID: 42484
	private static Func<bool> IsBanHook;

	// Token: 0x0400A5F5 RID: 42485
	private static Func<bool> IsBanFloaterAim;

	// Token: 0x0400A5F6 RID: 42486
	private static Func<bool> IsBanMotorcyclePark;

	// Token: 0x0400A5F7 RID: 42487
	private static Action MotorcycleParkBanTips;

	// Token: 0x0400A5F8 RID: 42488
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<ERouletteExploreId, Func<bool>> ExploreGridForbiddenCheckMap;

	// Token: 0x0400A5F9 RID: 42489
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<ERouletteExploreId, Action> ExploreGridForbiddenTipsMap;
}
