using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Ui;

// Token: 0x0200154D RID: 5453
[NullableContext(1)]
[Nullable(0)]
public class LoadingDefine
{
	// Token: 0x0600DA41 RID: 55873 RVA: 0x0040A154 File Offset: 0x00408354
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

	// Token: 0x0600DA43 RID: 55875 RVA: 0x0040A1C8 File Offset: 0x004083C8
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

	// Token: 0x040079C4 RID: 31172
	[StaticVariableRuleIgnore]
	public static readonly EUiViewName[] loadingViewList = new EUiViewName[]
	{
		EUiViewName.LoadingView,
		EUiViewName.RacingBetsLoadingView,
		EUiViewName.DangoAbyssWorldLoadingView,
		EUiViewName.RoleLoadingView,
		EUiViewName.PhantomArenaCardBattleLoadingView
	};

	// Token: 0x040079C5 RID: 31173
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<EDungeonSubType, LoadingDefine.IDungeonLoadingData> dungeonToLoadingViewMap;

	// Token: 0x020077E9 RID: 30697
	[NullableContext(2)]
	public interface IDungeonLoadingData
	{
		// Token: 0x17007821 RID: 30753
		// (get) Token: 0x06040D1F RID: 265503
		// (set) Token: 0x06040D20 RID: 265504
		EWorldDungeonSubType? WorldSubType { get; set; }

		// Token: 0x17007822 RID: 30754
		// (get) Token: 0x06040D21 RID: 265505
		// (set) Token: 0x06040D22 RID: 265506
		EUiViewName View { get; set; }

		// Token: 0x17007823 RID: 30755
		// (get) Token: 0x06040D23 RID: 265507
		// (set) Token: 0x06040D24 RID: 265508
		bool? IgnoreExitLoading { get; set; }

		// Token: 0x17007824 RID: 30756
		// (get) Token: 0x06040D25 RID: 265509
		// (set) Token: 0x06040D26 RID: 265510
		Func<int, bool> Filter { get; set; }
	}

	// Token: 0x020077EA RID: 30698
	[NullableContext(2)]
	[Nullable(0)]
	public class DungeonLoadingData : LoadingDefine.IDungeonLoadingData
	{
		// Token: 0x17007825 RID: 30757
		// (get) Token: 0x06040D27 RID: 265511 RVA: 0x01319C3E File Offset: 0x01317E3E
		// (set) Token: 0x06040D28 RID: 265512 RVA: 0x01319C46 File Offset: 0x01317E46
		public EWorldDungeonSubType? WorldSubType { get; set; }

		// Token: 0x17007826 RID: 30758
		// (get) Token: 0x06040D29 RID: 265513 RVA: 0x01319C4F File Offset: 0x01317E4F
		// (set) Token: 0x06040D2A RID: 265514 RVA: 0x01319C57 File Offset: 0x01317E57
		public EUiViewName View { get; set; }

		// Token: 0x17007827 RID: 30759
		// (get) Token: 0x06040D2B RID: 265515 RVA: 0x01319C60 File Offset: 0x01317E60
		// (set) Token: 0x06040D2C RID: 265516 RVA: 0x01319C68 File Offset: 0x01317E68
		public bool? IgnoreExitLoading { get; set; }

		// Token: 0x17007828 RID: 30760
		// (get) Token: 0x06040D2D RID: 265517 RVA: 0x01319C71 File Offset: 0x01317E71
		// (set) Token: 0x06040D2E RID: 265518 RVA: 0x01319C79 File Offset: 0x01317E79
		public Func<int, bool> Filter { get; set; }
	}
}
