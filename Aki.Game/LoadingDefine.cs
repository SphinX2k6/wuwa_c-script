using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Ui;

// Token: 0x0200207A RID: 8314
[NullableContext(1)]
[Nullable(0)]
public class LoadingDefine
{
	// Token: 0x060105D9 RID: 67033 RVA: 0x003FDD0C File Offset: 0x003FBF0C
	private static bool IsThirdLordGymInstance(int instanceId)
	{
		IReadOnlyList<LordGymEntranceSet> configList = ConfigLordGymEntranceSetAll.GetConfigList(true);
		if (configList == null)
		{
			return false;
		}
		foreach (LordGymEntranceSet lordGymEntranceSet in configList)
		{
			if (lordGymEntranceSet.DungeonId == instanceId)
			{
				return lordGymEntranceSet.Id == 200103;
			}
		}
		return false;
	}

	// Token: 0x060105DB RID: 67035 RVA: 0x003FDD80 File Offset: 0x003FBF80
	// Note: this type is marked as 'beforefieldinit'.
	static LoadingDefine()
	{
		Dictionary<EDungeonSubType, LoadingDefine.IDungeonLoadingData> dictionary = new Dictionary<EDungeonSubType, LoadingDefine.IDungeonLoadingData>();
		dictionary[EDungeonSubType.RacingBets] = new LoadingDefine.DungeonLoadingData
		{
			View = EUiViewName.RacingBetsLoadingView
		};
		dictionary[EDungeonSubType.DangoMonopoly] = new LoadingDefine.DungeonLoadingData
		{
			View = EUiViewName.RacingBetsLoadingView
		};
		dictionary[EDungeonSubType.DangoAbyssSmallWorld] = new LoadingDefine.DungeonLoadingData
		{
			View = EUiViewName.DangoAbyssWorldLoadingView
		};
		dictionary[EDungeonSubType.WorldInstance] = new LoadingDefine.DungeonLoadingData
		{
			WorldSubType = new EWorldDungeonSubType?(EWorldDungeonSubType.DangoSmallWorld),
			View = EUiViewName.DangoAbyssWorldLoadingView
		};
		dictionary[EDungeonSubType.TetrisGame] = new LoadingDefine.DungeonLoadingData
		{
			View = EUiViewName.TetrisGameLoading,
			IgnoreExitLoading = new bool?(true)
		};
		dictionary[EDungeonSubType.PhantomArena] = new LoadingDefine.DungeonLoadingData
		{
			View = EUiViewName.PhantomArenaCardBattleLoadingView,
			IgnoreExitLoading = new bool?(true)
		};
		dictionary[EDungeonSubType.LordGym] = new LoadingDefine.DungeonLoadingData
		{
			View = EUiViewName.LordGymLoadingView,
			Filter = new Func<int, bool>(LoadingDefine.IsThirdLordGymInstance)
		};
		dictionary[EDungeonSubType.NewTowerClimbing] = new LoadingDefine.DungeonLoadingData
		{
			View = EUiViewName.WheelTowerLoadingView,
			IgnoreExitLoading = new bool?(true)
		};
		dictionary[EDungeonSubType.PinballBattle] = new LoadingDefine.DungeonLoadingData
		{
			View = EUiViewName.PinballLoadingView,
			IgnoreExitLoading = new bool?(true)
		};
		LoadingDefine.dungeonToLoadingViewMap = dictionary;
	}

	// Token: 0x040078DB RID: 30939
	[StaticVariableRuleIgnore]
	public static readonly EUiViewName[] loadingViewList = new EUiViewName[]
	{
		EUiViewName.LoadingView,
		EUiViewName.RacingBetsLoadingView,
		EUiViewName.DangoAbyssWorldLoadingView,
		EUiViewName.RoleLoadingView,
		EUiViewName.PhantomArenaCardBattleLoadingView
	};

	// Token: 0x040078DC RID: 30940
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<EDungeonSubType, LoadingDefine.IDungeonLoadingData> dungeonToLoadingViewMap;

	// Token: 0x02008662 RID: 34402
	[NullableContext(2)]
	public interface IDungeonLoadingData
	{
		// Token: 0x1700A083 RID: 41091
		// (get) Token: 0x0604A925 RID: 305445
		// (set) Token: 0x0604A926 RID: 305446
		EWorldDungeonSubType? WorldSubType { get; set; }

		// Token: 0x1700A084 RID: 41092
		// (get) Token: 0x0604A927 RID: 305447
		// (set) Token: 0x0604A928 RID: 305448
		EUiViewName View { get; set; }

		// Token: 0x1700A085 RID: 41093
		// (get) Token: 0x0604A929 RID: 305449
		// (set) Token: 0x0604A92A RID: 305450
		bool? IgnoreExitLoading { get; set; }

		// Token: 0x1700A086 RID: 41094
		// (get) Token: 0x0604A92B RID: 305451
		// (set) Token: 0x0604A92C RID: 305452
		Func<int, bool> Filter { get; set; }
	}

	// Token: 0x02008663 RID: 34403
	[NullableContext(2)]
	[Nullable(0)]
	public class DungeonLoadingData : LoadingDefine.IDungeonLoadingData
	{
		// Token: 0x1700A087 RID: 41095
		// (get) Token: 0x0604A92D RID: 305453 RVA: 0x013767DE File Offset: 0x013749DE
		// (set) Token: 0x0604A92E RID: 305454 RVA: 0x013767E6 File Offset: 0x013749E6
		public EWorldDungeonSubType? WorldSubType { get; set; }

		// Token: 0x1700A088 RID: 41096
		// (get) Token: 0x0604A92F RID: 305455 RVA: 0x013767EF File Offset: 0x013749EF
		// (set) Token: 0x0604A930 RID: 305456 RVA: 0x013767F7 File Offset: 0x013749F7
		public EUiViewName View { get; set; }

		// Token: 0x1700A089 RID: 41097
		// (get) Token: 0x0604A931 RID: 305457 RVA: 0x01376800 File Offset: 0x01374A00
		// (set) Token: 0x0604A932 RID: 305458 RVA: 0x01376808 File Offset: 0x01374A08
		public bool? IgnoreExitLoading { get; set; }

		// Token: 0x1700A08A RID: 41098
		// (get) Token: 0x0604A933 RID: 305459 RVA: 0x01376811 File Offset: 0x01374A11
		// (set) Token: 0x0604A934 RID: 305460 RVA: 0x01376819 File Offset: 0x01374A19
		public Func<int, bool> Filter { get; set; }
	}
}
