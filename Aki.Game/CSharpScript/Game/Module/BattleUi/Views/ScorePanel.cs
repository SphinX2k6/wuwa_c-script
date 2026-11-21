using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Battle;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CAC RID: 19628
	[NullableContext(1)]
	[Nullable(0)]
	public class ScorePanel : BattleChildViewPanel
	{
		// Token: 0x06031065 RID: 200805 RVA: 0x00DAF5BC File Offset: 0x00DAD7BC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031066 RID: 200806 RVA: 0x00DAF604 File Offset: 0x00DAD804
		public override UniTask InitializeAsync()
		{
			ScorePanel.<InitializeAsync>d__7 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<ScorePanel.<InitializeAsync>d__7>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031067 RID: 200807 RVA: 0x00DAF647 File Offset: 0x00DAD847
		public override void Reset()
		{
			this.ScoreItemList.Clear();
			this.RogueScoreItem = null;
			this.FarmGoldScoreItem = null;
			base.Reset();
		}

		// Token: 0x06031068 RID: 200808 RVA: 0x00DAF668 File Offset: 0x00DAD868
		protected override void OnBeforeDestroyImplement()
		{
			this.ScoreItemList.Clear();
			this.RogueScoreItem = null;
			this.FarmGoldScoreItem = null;
		}

		// Token: 0x06031069 RID: 200809 RVA: 0x00DAF683 File Offset: 0x00DAD883
		protected override void AddEvents()
		{
			EventSystem.Instance.Add<int, bool>(EEventName.BattleScoreEnableChanged, new Action<int, bool>(this.OnBattleScoreEnableChanged));
		}

		// Token: 0x0603106A RID: 200810 RVA: 0x00DAF6A1 File Offset: 0x00DAD8A1
		protected override void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.BattleScoreEnableChanged, new Action<int, bool>(this.OnBattleScoreEnableChanged));
		}

		// Token: 0x0603106B RID: 200811 RVA: 0x00DAF6BF File Offset: 0x00DAD8BF
		private void OnBattleScoreEnableChanged(int scoreId, bool enable)
		{
			if (enable)
			{
				this.TryLoadScoreItem(scoreId);
			}
		}

		// Token: 0x0603106C RID: 200812 RVA: 0x00DAF6CC File Offset: 0x00DAD8CC
		private void TryLoadScoreItem(int scoreId)
		{
			BattleScoreConf? battleScoreConfig = BattleScoreConfig.Instance.GetBattleScoreConfig(scoreId);
			if (battleScoreConfig == null)
			{
				return;
			}
			EBattleScoreType type = (EBattleScoreType)battleScoreConfig.Value.Type;
			if (type == EBattleScoreType.LevelPlayReport)
			{
				this.LoadRogueScoreItem(false).Forget();
				return;
			}
			if (type != EBattleScoreType.VisionArena)
			{
				return;
			}
			this.LoadVisionArenaScoreItem(scoreId).Forget();
		}

		// Token: 0x0603106D RID: 200813 RVA: 0x00DAF724 File Offset: 0x00DAD924
		private UniTask LoadRogueScoreItem(bool initHide = true)
		{
			ScorePanel.<LoadRogueScoreItem>d__14 <LoadRogueScoreItem>d__;
			<LoadRogueScoreItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadRogueScoreItem>d__.<>4__this = this;
			<LoadRogueScoreItem>d__.initHide = initHide;
			<LoadRogueScoreItem>d__.<>1__state = -1;
			<LoadRogueScoreItem>d__.<>t__builder.Start<ScorePanel.<LoadRogueScoreItem>d__14>(ref <LoadRogueScoreItem>d__);
			return <LoadRogueScoreItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603106E RID: 200814 RVA: 0x00DAF770 File Offset: 0x00DAD970
		private UniTask LoadFarmGoldScoreItem()
		{
			ScorePanel.<LoadFarmGoldScoreItem>d__15 <LoadFarmGoldScoreItem>d__;
			<LoadFarmGoldScoreItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadFarmGoldScoreItem>d__.<>4__this = this;
			<LoadFarmGoldScoreItem>d__.<>1__state = -1;
			<LoadFarmGoldScoreItem>d__.<>t__builder.Start<ScorePanel.<LoadFarmGoldScoreItem>d__15>(ref <LoadFarmGoldScoreItem>d__);
			return <LoadFarmGoldScoreItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603106F RID: 200815 RVA: 0x00DAF7B4 File Offset: 0x00DAD9B4
		private UniTask LoadDreamLinkScoreItem()
		{
			ScorePanel.<LoadDreamLinkScoreItem>d__16 <LoadDreamLinkScoreItem>d__;
			<LoadDreamLinkScoreItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadDreamLinkScoreItem>d__.<>4__this = this;
			<LoadDreamLinkScoreItem>d__.<>1__state = -1;
			<LoadDreamLinkScoreItem>d__.<>t__builder.Start<ScorePanel.<LoadDreamLinkScoreItem>d__16>(ref <LoadDreamLinkScoreItem>d__);
			return <LoadDreamLinkScoreItem>d__.<>t__builder.Task;
		}

		// Token: 0x06031070 RID: 200816 RVA: 0x00DAF7F8 File Offset: 0x00DAD9F8
		private UniTask LoadLinkScoreItem()
		{
			ScorePanel.<LoadLinkScoreItem>d__17 <LoadLinkScoreItem>d__;
			<LoadLinkScoreItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadLinkScoreItem>d__.<>4__this = this;
			<LoadLinkScoreItem>d__.<>1__state = -1;
			<LoadLinkScoreItem>d__.<>t__builder.Start<ScorePanel.<LoadLinkScoreItem>d__17>(ref <LoadLinkScoreItem>d__);
			return <LoadLinkScoreItem>d__.<>t__builder.Task;
		}

		// Token: 0x06031071 RID: 200817 RVA: 0x00DAF83C File Offset: 0x00DADA3C
		private UniTask LoadShipTowerScoreItem()
		{
			ScorePanel.<LoadShipTowerScoreItem>d__18 <LoadShipTowerScoreItem>d__;
			<LoadShipTowerScoreItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadShipTowerScoreItem>d__.<>4__this = this;
			<LoadShipTowerScoreItem>d__.<>1__state = -1;
			<LoadShipTowerScoreItem>d__.<>t__builder.Start<ScorePanel.<LoadShipTowerScoreItem>d__18>(ref <LoadShipTowerScoreItem>d__);
			return <LoadShipTowerScoreItem>d__.<>t__builder.Task;
		}

		// Token: 0x06031072 RID: 200818 RVA: 0x00DAF880 File Offset: 0x00DADA80
		private UniTask LoadBossPilingScoreItem()
		{
			ScorePanel.<LoadBossPilingScoreItem>d__19 <LoadBossPilingScoreItem>d__;
			<LoadBossPilingScoreItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadBossPilingScoreItem>d__.<>4__this = this;
			<LoadBossPilingScoreItem>d__.<>1__state = -1;
			<LoadBossPilingScoreItem>d__.<>t__builder.Start<ScorePanel.<LoadBossPilingScoreItem>d__19>(ref <LoadBossPilingScoreItem>d__);
			return <LoadBossPilingScoreItem>d__.<>t__builder.Task;
		}

		// Token: 0x06031073 RID: 200819 RVA: 0x00DAF8C4 File Offset: 0x00DADAC4
		private UniTask LoadVisionArenaScoreItem(int scoreId)
		{
			ScorePanel.<LoadVisionArenaScoreItem>d__20 <LoadVisionArenaScoreItem>d__;
			<LoadVisionArenaScoreItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadVisionArenaScoreItem>d__.<>4__this = this;
			<LoadVisionArenaScoreItem>d__.scoreId = scoreId;
			<LoadVisionArenaScoreItem>d__.<>1__state = -1;
			<LoadVisionArenaScoreItem>d__.<>t__builder.Start<ScorePanel.<LoadVisionArenaScoreItem>d__20>(ref <LoadVisionArenaScoreItem>d__);
			return <LoadVisionArenaScoreItem>d__.<>t__builder.Task;
		}

		// Token: 0x06031074 RID: 200820 RVA: 0x00DAF910 File Offset: 0x00DADB10
		protected override void OnShowBattleChildViewPanel(bool isFirst)
		{
			if (isFirst)
			{
				foreach (BaseScoreItem baseScoreItem in this.ScoreItemList.Values)
				{
					baseScoreItem.OnShowFirstTime();
				}
			}
		}

		// Token: 0x06031075 RID: 200821 RVA: 0x00DAF968 File Offset: 0x00DADB68
		public override void OnTickBattleChildViewPanel(float delta)
		{
			foreach (BaseScoreItem baseScoreItem in this.ScoreItemList.Values)
			{
				if (baseScoreItem.IsScoreEnable)
				{
					baseScoreItem.OnTick(delta);
				}
			}
		}

		// Token: 0x06031076 RID: 200822 RVA: 0x00DAF9C8 File Offset: 0x00DADBC8
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length == 0)
			{
				return null;
			}
			BaseScoreItem valueOrDefault = this.ScoreItemList.GetValueOrDefault("ShipTowerScoreItem");
			UUIItem uuiitem = (valueOrDefault != null) ? valueOrDefault.GetGuideUiItem("0") : null;
			if (uuiitem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem,
				uuiitem
			};
		}

		// Token: 0x04019FFE RID: 106494
		[StaticVariableRuleIgnore]
		private static readonly Stat TickStatsObject = Stat.Create("[BattleView]ScorePanelTick", "", "");

		// Token: 0x04019FFF RID: 106495
		private readonly Dictionary<string, BaseScoreItem> ScoreItemList = new Dictionary<string, BaseScoreItem>();

		// Token: 0x0401A000 RID: 106496
		[Nullable(2)]
		private RogueScoreItem RogueScoreItem;

		// Token: 0x0401A001 RID: 106497
		[Nullable(2)]
		private FarmGoldScoreItem FarmGoldScoreItem;

		// Token: 0x0200A8DF RID: 43231
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x040342AC RID: 213676
			FarmGoldPoint
		}

		// Token: 0x0200A8E0 RID: 43232
		[Nullable(0)]
		private static class EScoreItemType
		{
			// Token: 0x040342AD RID: 213677
			public const string RogueScoreItemType = "RogueScoreItem";

			// Token: 0x040342AE RID: 213678
			public const string FarmGoldScoreItemType = "FarmGoldScoreItem";

			// Token: 0x040342AF RID: 213679
			public const string DreamLinkScoreItemType = "DreamLinkScoreItem";

			// Token: 0x040342B0 RID: 213680
			public const string LinkScoreItemType = "LinkScoreItem";

			// Token: 0x040342B1 RID: 213681
			public const string VisionArenaScoreItemType = "VisionArenaScoreItem";

			// Token: 0x040342B2 RID: 213682
			public const string ShipTowerScoreItemType = "ShipTowerScoreItem";

			// Token: 0x040342B3 RID: 213683
			public const string BossPilingScoreItem = "BossPilingScoreItem";
		}
	}
}
