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
	// Token: 0x02005CCA RID: 23754
	[NullableContext(1)]
	[Nullable(0)]
	public class ScorePanel : BattleChildViewPanel
	{
		// Token: 0x0603C110 RID: 246032 RVA: 0x00E5F068 File Offset: 0x00E5D268
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

		// Token: 0x0603C111 RID: 246033 RVA: 0x00E5F0B0 File Offset: 0x00E5D2B0
		public override UniTask InitializeAsync()
		{
			ScorePanel.<InitializeAsync>d__7 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<ScorePanel.<InitializeAsync>d__7>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603C112 RID: 246034 RVA: 0x00E5F0F3 File Offset: 0x00E5D2F3
		public override void Reset()
		{
			this.ScoreItemList.Clear();
			this.RogueScoreItem = null;
			this.FarmGoldScoreItem = null;
			base.Reset();
		}

		// Token: 0x0603C113 RID: 246035 RVA: 0x00E5F114 File Offset: 0x00E5D314
		protected override void OnBeforeDestroyImplement()
		{
			this.ScoreItemList.Clear();
			this.RogueScoreItem = null;
			this.FarmGoldScoreItem = null;
		}

		// Token: 0x0603C114 RID: 246036 RVA: 0x00E5F12F File Offset: 0x00E5D32F
		protected override void AddEvents()
		{
			EventSystem.Instance.Add<int, bool>(EEventName.BattleScoreEnableChanged, new Action<int, bool>(this.OnBattleScoreEnableChanged));
		}

		// Token: 0x0603C115 RID: 246037 RVA: 0x00E5F14D File Offset: 0x00E5D34D
		protected override void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.BattleScoreEnableChanged, new Action<int, bool>(this.OnBattleScoreEnableChanged));
		}

		// Token: 0x0603C116 RID: 246038 RVA: 0x00E5F16B File Offset: 0x00E5D36B
		private void OnBattleScoreEnableChanged(int scoreId, bool enable)
		{
			if (enable)
			{
				this.TryLoadScoreItem(scoreId);
			}
		}

		// Token: 0x0603C117 RID: 246039 RVA: 0x00E5F178 File Offset: 0x00E5D378
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

		// Token: 0x0603C118 RID: 246040 RVA: 0x00E5F1D0 File Offset: 0x00E5D3D0
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

		// Token: 0x0603C119 RID: 246041 RVA: 0x00E5F21C File Offset: 0x00E5D41C
		private UniTask LoadFarmGoldScoreItem()
		{
			ScorePanel.<LoadFarmGoldScoreItem>d__15 <LoadFarmGoldScoreItem>d__;
			<LoadFarmGoldScoreItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadFarmGoldScoreItem>d__.<>4__this = this;
			<LoadFarmGoldScoreItem>d__.<>1__state = -1;
			<LoadFarmGoldScoreItem>d__.<>t__builder.Start<ScorePanel.<LoadFarmGoldScoreItem>d__15>(ref <LoadFarmGoldScoreItem>d__);
			return <LoadFarmGoldScoreItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603C11A RID: 246042 RVA: 0x00E5F260 File Offset: 0x00E5D460
		private UniTask LoadDreamLinkScoreItem()
		{
			ScorePanel.<LoadDreamLinkScoreItem>d__16 <LoadDreamLinkScoreItem>d__;
			<LoadDreamLinkScoreItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadDreamLinkScoreItem>d__.<>4__this = this;
			<LoadDreamLinkScoreItem>d__.<>1__state = -1;
			<LoadDreamLinkScoreItem>d__.<>t__builder.Start<ScorePanel.<LoadDreamLinkScoreItem>d__16>(ref <LoadDreamLinkScoreItem>d__);
			return <LoadDreamLinkScoreItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603C11B RID: 246043 RVA: 0x00E5F2A4 File Offset: 0x00E5D4A4
		private UniTask LoadLinkScoreItem()
		{
			ScorePanel.<LoadLinkScoreItem>d__17 <LoadLinkScoreItem>d__;
			<LoadLinkScoreItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadLinkScoreItem>d__.<>4__this = this;
			<LoadLinkScoreItem>d__.<>1__state = -1;
			<LoadLinkScoreItem>d__.<>t__builder.Start<ScorePanel.<LoadLinkScoreItem>d__17>(ref <LoadLinkScoreItem>d__);
			return <LoadLinkScoreItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603C11C RID: 246044 RVA: 0x00E5F2E8 File Offset: 0x00E5D4E8
		private UniTask LoadShipTowerScoreItem()
		{
			ScorePanel.<LoadShipTowerScoreItem>d__18 <LoadShipTowerScoreItem>d__;
			<LoadShipTowerScoreItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadShipTowerScoreItem>d__.<>4__this = this;
			<LoadShipTowerScoreItem>d__.<>1__state = -1;
			<LoadShipTowerScoreItem>d__.<>t__builder.Start<ScorePanel.<LoadShipTowerScoreItem>d__18>(ref <LoadShipTowerScoreItem>d__);
			return <LoadShipTowerScoreItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603C11D RID: 246045 RVA: 0x00E5F32C File Offset: 0x00E5D52C
		private UniTask LoadBossPilingScoreItem()
		{
			ScorePanel.<LoadBossPilingScoreItem>d__19 <LoadBossPilingScoreItem>d__;
			<LoadBossPilingScoreItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadBossPilingScoreItem>d__.<>4__this = this;
			<LoadBossPilingScoreItem>d__.<>1__state = -1;
			<LoadBossPilingScoreItem>d__.<>t__builder.Start<ScorePanel.<LoadBossPilingScoreItem>d__19>(ref <LoadBossPilingScoreItem>d__);
			return <LoadBossPilingScoreItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603C11E RID: 246046 RVA: 0x00E5F370 File Offset: 0x00E5D570
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

		// Token: 0x0603C11F RID: 246047 RVA: 0x00E5F3BC File Offset: 0x00E5D5BC
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

		// Token: 0x0603C120 RID: 246048 RVA: 0x00E5F414 File Offset: 0x00E5D614
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

		// Token: 0x0603C121 RID: 246049 RVA: 0x00E5F474 File Offset: 0x00E5D674
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

		// Token: 0x0401F545 RID: 128325
		[StaticVariableRuleIgnore]
		private static readonly Stat TickStatsObject = Stat.Create("[BattleView]ScorePanelTick", "", "");

		// Token: 0x0401F546 RID: 128326
		private readonly Dictionary<string, BaseScoreItem> ScoreItemList = new Dictionary<string, BaseScoreItem>();

		// Token: 0x0401F547 RID: 128327
		[Nullable(2)]
		private RogueScoreItem RogueScoreItem;

		// Token: 0x0401F548 RID: 128328
		[Nullable(2)]
		private FarmGoldScoreItem FarmGoldScoreItem;

		// Token: 0x0200BED9 RID: 48857
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x040398EB RID: 235755
			FarmGoldPoint
		}

		// Token: 0x0200BEDA RID: 48858
		[Nullable(0)]
		private static class EScoreItemType
		{
			// Token: 0x040398EC RID: 235756
			public const string RogueScoreItemType = "RogueScoreItem";

			// Token: 0x040398ED RID: 235757
			public const string FarmGoldScoreItemType = "FarmGoldScoreItem";

			// Token: 0x040398EE RID: 235758
			public const string DreamLinkScoreItemType = "DreamLinkScoreItem";

			// Token: 0x040398EF RID: 235759
			public const string LinkScoreItemType = "LinkScoreItem";

			// Token: 0x040398F0 RID: 235760
			public const string VisionArenaScoreItemType = "VisionArenaScoreItem";

			// Token: 0x040398F1 RID: 235761
			public const string ShipTowerScoreItemType = "ShipTowerScoreItem";

			// Token: 0x040398F2 RID: 235762
			public const string BossPilingScoreItem = "BossPilingScoreItem";
		}
	}
}
