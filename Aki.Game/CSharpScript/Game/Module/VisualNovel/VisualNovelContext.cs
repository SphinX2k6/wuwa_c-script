using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Dialogue;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.VisualNovel
{
	// Token: 0x020037A9 RID: 14249
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class VisualNovelContext
	{
		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0602510A RID: 151818 RVA: 0x00A768B4 File Offset: 0x00A74AB4
		// (remove) Token: 0x0602510B RID: 151819 RVA: 0x00A768EC File Offset: 0x00A74AEC
		[Nullable(2)]
		[method: NullableContext(2)]
		[Nullable(2)]
		internal event Action<EVisualNovelPlaybackMode> PlaybackModeChanged;

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x0602510C RID: 151820 RVA: 0x00A76924 File Offset: 0x00A74B24
		// (remove) Token: 0x0602510D RID: 151821 RVA: 0x00A7695C File Offset: 0x00A74B5C
		[Nullable(2)]
		[method: NullableContext(2)]
		[Nullable(2)]
		internal event Action AutoAdvanceMutedChanged;

		// Token: 0x17004C12 RID: 19474
		// (get) Token: 0x0602510E RID: 151822 RVA: 0x00A76991 File Offset: 0x00A74B91
		public DialogueScript Script { get; }

		// Token: 0x17004C13 RID: 19475
		// (get) Token: 0x0602510F RID: 151823 RVA: 0x00A76999 File Offset: 0x00A74B99
		public IReadOnlyList<VisualNovelItem> Items
		{
			get
			{
				return this.ItemList;
			}
		}

		// Token: 0x17004C14 RID: 19476
		// (get) Token: 0x06025110 RID: 151824 RVA: 0x00A769A1 File Offset: 0x00A74BA1
		// (set) Token: 0x06025111 RID: 151825 RVA: 0x00A769A9 File Offset: 0x00A74BA9
		public VisualNovelActionCenter ActionCenter { get; set; } = new VisualNovelActionCenter();

		// Token: 0x17004C15 RID: 19477
		// (get) Token: 0x06025112 RID: 151826 RVA: 0x00A769B2 File Offset: 0x00A74BB2
		public VisualNovelConfigCenter ConfigCenter { get; }

		// Token: 0x17004C16 RID: 19478
		// (get) Token: 0x06025113 RID: 151827 RVA: 0x00A769BA File Offset: 0x00A74BBA
		public VisualNovelAssetCache Assets { get; }

		// Token: 0x17004C17 RID: 19479
		// (get) Token: 0x06025114 RID: 151828 RVA: 0x00A769C2 File Offset: 0x00A74BC2
		public VisualNovelAudio Audio { get; }

		// Token: 0x17004C18 RID: 19480
		// (get) Token: 0x06025115 RID: 151829 RVA: 0x00A769CA File Offset: 0x00A74BCA
		public VisualNovelEffects Effects { get; }

		// Token: 0x17004C19 RID: 19481
		// (get) Token: 0x06025116 RID: 151830 RVA: 0x00A769D2 File Offset: 0x00A74BD2
		public VisualNovelReadRecord ReadRecord { get; } = new VisualNovelReadRecord();

		// Token: 0x17004C1A RID: 19482
		// (get) Token: 0x06025117 RID: 151831 RVA: 0x00A769DA File Offset: 0x00A74BDA
		// (set) Token: 0x06025118 RID: 151832 RVA: 0x00A769E2 File Offset: 0x00A74BE2
		[Nullable(2)]
		public Action<int> SyncReadRecord { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17004C1B RID: 19483
		// (get) Token: 0x06025119 RID: 151833 RVA: 0x00A769EB File Offset: 0x00A74BEB
		// (set) Token: 0x0602511A RID: 151834 RVA: 0x00A769F3 File Offset: 0x00A74BF3
		public VisualNovelPlayer Player { get; private set; }

		// Token: 0x17004C1C RID: 19484
		// (get) Token: 0x0602511B RID: 151835 RVA: 0x00A769FC File Offset: 0x00A74BFC
		// (set) Token: 0x0602511C RID: 151836 RVA: 0x00A76A04 File Offset: 0x00A74C04
		public VisualNovelScene Scene { get; private set; }

		// Token: 0x17004C1D RID: 19485
		// (get) Token: 0x0602511D RID: 151837 RVA: 0x00A76A0D File Offset: 0x00A74C0D
		// (set) Token: 0x0602511E RID: 151838 RVA: 0x00A76A15 File Offset: 0x00A74C15
		public IVisualNovelView View { get; private set; }

		// Token: 0x17004C1E RID: 19486
		// (get) Token: 0x0602511F RID: 151839 RVA: 0x00A76A1E File Offset: 0x00A74C1E
		// (set) Token: 0x06025120 RID: 151840 RVA: 0x00A76A26 File Offset: 0x00A74C26
		public bool IsReady { get; private set; }

		// Token: 0x17004C1F RID: 19487
		// (get) Token: 0x06025121 RID: 151841 RVA: 0x00A76A2F File Offset: 0x00A74C2F
		// (set) Token: 0x06025122 RID: 151842 RVA: 0x00A76A37 File Offset: 0x00A74C37
		public bool IsPrepared { get; internal set; }

		// Token: 0x17004C20 RID: 19488
		// (get) Token: 0x06025123 RID: 151843 RVA: 0x00A76A40 File Offset: 0x00A74C40
		// (set) Token: 0x06025124 RID: 151844 RVA: 0x00A76A48 File Offset: 0x00A74C48
		public bool IsStopped { get; private set; }

		// Token: 0x17004C21 RID: 19489
		// (get) Token: 0x06025125 RID: 151845 RVA: 0x00A76A51 File Offset: 0x00A74C51
		// (set) Token: 0x06025126 RID: 151846 RVA: 0x00A76A59 File Offset: 0x00A74C59
		public bool IsPaused { get; private set; }

		// Token: 0x17004C22 RID: 19490
		// (get) Token: 0x06025127 RID: 151847 RVA: 0x00A76A62 File Offset: 0x00A74C62
		// (set) Token: 0x06025128 RID: 151848 RVA: 0x00A76A6A File Offset: 0x00A74C6A
		public bool IsAutoAdvanceMuted { get; private set; }

		// Token: 0x17004C23 RID: 19491
		// (get) Token: 0x06025129 RID: 151849 RVA: 0x00A76A73 File Offset: 0x00A74C73
		// (set) Token: 0x0602512A RID: 151850 RVA: 0x00A76A7B File Offset: 0x00A74C7B
		public bool IsInputLocked { get; private set; }

		// Token: 0x17004C24 RID: 19492
		// (get) Token: 0x0602512B RID: 151851 RVA: 0x00A76A84 File Offset: 0x00A74C84
		// (set) Token: 0x0602512C RID: 151852 RVA: 0x00A76A8C File Offset: 0x00A74C8C
		public bool AreCharactersTemporarilyHidden { get; internal set; }

		// Token: 0x17004C25 RID: 19493
		// (get) Token: 0x0602512D RID: 151853 RVA: 0x00A76A95 File Offset: 0x00A74C95
		// (set) Token: 0x0602512E RID: 151854 RVA: 0x00A76A9D File Offset: 0x00A74C9D
		public EVisualNovelPlaybackMode PlaybackMode { get; private set; }

		// Token: 0x17004C26 RID: 19494
		// (get) Token: 0x0602512F RID: 151855 RVA: 0x00A76AA6 File Offset: 0x00A74CA6
		// (set) Token: 0x06025130 RID: 151856 RVA: 0x00A76AAE File Offset: 0x00A74CAE
		public float PlaybackRate { get; private set; } = 1f;

		// Token: 0x17004C27 RID: 19495
		// (get) Token: 0x06025131 RID: 151857 RVA: 0x00A76AB7 File Offset: 0x00A74CB7
		// (set) Token: 0x06025132 RID: 151858 RVA: 0x00A76ABF File Offset: 0x00A74CBF
		public float AutoAdvanceDelay { get; set; } = 1f;

		// Token: 0x17004C28 RID: 19496
		// (get) Token: 0x06025133 RID: 151859 RVA: 0x00A76AC8 File Offset: 0x00A74CC8
		// (set) Token: 0x06025134 RID: 151860 RVA: 0x00A76AD0 File Offset: 0x00A74CD0
		public float NoVoiceEndWaitTime { get; set; } = 3f;

		// Token: 0x17004C29 RID: 19497
		// (get) Token: 0x06025135 RID: 151861 RVA: 0x00A76AD9 File Offset: 0x00A74CD9
		// (set) Token: 0x06025136 RID: 151862 RVA: 0x00A76AE1 File Offset: 0x00A74CE1
		public float CharacterEnterDuration { get; set; } = 0.5f;

		// Token: 0x17004C2A RID: 19498
		// (get) Token: 0x06025137 RID: 151863 RVA: 0x00A76AEA File Offset: 0x00A74CEA
		// (set) Token: 0x06025138 RID: 151864 RVA: 0x00A76AF2 File Offset: 0x00A74CF2
		public float CharacterExitDuration { get; set; } = 0.5f;

		// Token: 0x17004C2B RID: 19499
		// (get) Token: 0x06025139 RID: 151865 RVA: 0x00A76AFB File Offset: 0x00A74CFB
		// (set) Token: 0x0602513A RID: 151866 RVA: 0x00A76B03 File Offset: 0x00A74D03
		public float BlackScreenDuration { get; set; } = 1f;

		// Token: 0x17004C2C RID: 19500
		// (get) Token: 0x0602513B RID: 151867 RVA: 0x00A76B0C File Offset: 0x00A74D0C
		// (set) Token: 0x0602513C RID: 151868 RVA: 0x00A76B14 File Offset: 0x00A74D14
		public float CharacterIntroductionDuration { get; set; } = 5f;

		// Token: 0x17004C2D RID: 19501
		// (get) Token: 0x0602513D RID: 151869 RVA: 0x00A76B1D File Offset: 0x00A74D1D
		// (set) Token: 0x0602513E RID: 151870 RVA: 0x00A76B25 File Offset: 0x00A74D25
		public float FastForwardRate { get; set; } = 2f;

		// Token: 0x17004C2E RID: 19502
		// (get) Token: 0x0602513F RID: 151871 RVA: 0x00A76B2E File Offset: 0x00A74D2E
		// (set) Token: 0x06025140 RID: 151872 RVA: 0x00A76B36 File Offset: 0x00A74D36
		public float ReadFastForwardRate { get; set; } = 10f;

		// Token: 0x17004C2F RID: 19503
		// (get) Token: 0x06025141 RID: 151873 RVA: 0x00A76B3F File Offset: 0x00A74D3F
		// (set) Token: 0x06025142 RID: 151874 RVA: 0x00A76B47 File Offset: 0x00A74D47
		public float UltraFastForwardRate { get; set; } = 10f;

		// Token: 0x17004C30 RID: 19504
		// (get) Token: 0x06025143 RID: 151875 RVA: 0x00A76B50 File Offset: 0x00A74D50
		// (set) Token: 0x06025144 RID: 151876 RVA: 0x00A76B58 File Offset: 0x00A74D58
		public bool RemainLastMovieView { get; set; }

		// Token: 0x17004C31 RID: 19505
		// (get) Token: 0x06025145 RID: 151877 RVA: 0x00A76B61 File Offset: 0x00A74D61
		// (set) Token: 0x06025146 RID: 151878 RVA: 0x00A76B69 File Offset: 0x00A74D69
		public bool IsMovieViewRemained { get; internal set; }

		// Token: 0x17004C32 RID: 19506
		// (get) Token: 0x06025147 RID: 151879 RVA: 0x00A76B72 File Offset: 0x00A74D72
		public bool FastForwardEnabled { get; }

		// Token: 0x17004C33 RID: 19507
		// (get) Token: 0x06025148 RID: 151880 RVA: 0x00A76B7A File Offset: 0x00A74D7A
		// (set) Token: 0x06025149 RID: 151881 RVA: 0x00A76B82 File Offset: 0x00A74D82
		public VisualNovelDate Date { get; private set; }

		// Token: 0x17004C34 RID: 19508
		// (get) Token: 0x0602514A RID: 151882 RVA: 0x00A76B8B File Offset: 0x00A74D8B
		// (set) Token: 0x0602514B RID: 151883 RVA: 0x00A76B93 File Offset: 0x00A74D93
		public int BackgroundId { get; private set; }

		// Token: 0x17004C35 RID: 19509
		// (get) Token: 0x0602514C RID: 151884 RVA: 0x00A76B9C File Offset: 0x00A74D9C
		// (set) Token: 0x0602514D RID: 151885 RVA: 0x00A76BA4 File Offset: 0x00A74DA4
		public bool DateVisible { get; internal set; } = true;

		// Token: 0x17004C36 RID: 19510
		// (get) Token: 0x0602514E RID: 151886 RVA: 0x00A76BAD File Offset: 0x00A74DAD
		// (set) Token: 0x0602514F RID: 151887 RVA: 0x00A76BB5 File Offset: 0x00A74DB5
		public bool DialogueVisible { get; internal set; }

		// Token: 0x17004C37 RID: 19511
		// (get) Token: 0x06025150 RID: 151888 RVA: 0x00A76BBE File Offset: 0x00A74DBE
		// (set) Token: 0x06025151 RID: 151889 RVA: 0x00A76BC6 File Offset: 0x00A74DC6
		public bool AutoButtonVisible { get; internal set; }

		// Token: 0x17004C38 RID: 19512
		// (get) Token: 0x06025152 RID: 151890 RVA: 0x00A76BCF File Offset: 0x00A74DCF
		// (set) Token: 0x06025153 RID: 151891 RVA: 0x00A76BD7 File Offset: 0x00A74DD7
		public bool ReviewButtonVisible { get; internal set; }

		// Token: 0x17004C39 RID: 19513
		// (get) Token: 0x06025154 RID: 151892 RVA: 0x00A76BE0 File Offset: 0x00A74DE0
		// (set) Token: 0x06025155 RID: 151893 RVA: 0x00A76BE8 File Offset: 0x00A74DE8
		public bool MenuButtonVisible { get; internal set; }

		// Token: 0x17004C3A RID: 19514
		// (get) Token: 0x06025156 RID: 151894 RVA: 0x00A76BF1 File Offset: 0x00A74DF1
		// (set) Token: 0x06025157 RID: 151895 RVA: 0x00A76BF9 File Offset: 0x00A74DF9
		public bool AccelerateButtonVisible { get; internal set; }

		// Token: 0x17004C3B RID: 19515
		// (get) Token: 0x06025158 RID: 151896 RVA: 0x00A76C02 File Offset: 0x00A74E02
		// (set) Token: 0x06025159 RID: 151897 RVA: 0x00A76C0A File Offset: 0x00A74E0A
		public bool HideUiButtonVisible { get; internal set; }

		// Token: 0x17004C3C RID: 19516
		// (get) Token: 0x0602515A RID: 151898 RVA: 0x00A76C13 File Offset: 0x00A74E13
		// (set) Token: 0x0602515B RID: 151899 RVA: 0x00A76C1B File Offset: 0x00A74E1B
		public bool UltraFastForwardButtonVisible { get; internal set; }

		// Token: 0x17004C3D RID: 19517
		// (get) Token: 0x0602515C RID: 151900 RVA: 0x00A76C24 File Offset: 0x00A74E24
		// (set) Token: 0x0602515D RID: 151901 RVA: 0x00A76C2C File Offset: 0x00A74E2C
		public int CurrentSpeakerId { get; private set; }

		// Token: 0x17004C3E RID: 19518
		// (get) Token: 0x0602515E RID: 151902 RVA: 0x00A76C35 File Offset: 0x00A74E35
		// (set) Token: 0x0602515F RID: 151903 RVA: 0x00A76C3D File Offset: 0x00A74E3D
		public int CurrentAvgTalkerId { get; private set; }

		// Token: 0x17004C3F RID: 19519
		// (get) Token: 0x06025160 RID: 151904 RVA: 0x00A76C46 File Offset: 0x00A74E46
		// (set) Token: 0x06025161 RID: 151905 RVA: 0x00A76C4E File Offset: 0x00A74E4E
		[Nullable(2)]
		public VisualNovelItem CurrentItem { [NullableContext(2)] get; [NullableContext(2)] internal set; }

		// Token: 0x17004C40 RID: 19520
		// (get) Token: 0x06025162 RID: 151906 RVA: 0x00A76C57 File Offset: 0x00A74E57
		// (set) Token: 0x06025163 RID: 151907 RVA: 0x00A76C5F File Offset: 0x00A74E5F
		[Nullable(2)]
		public VisualNovelItem NextItem { [NullableContext(2)] get; [NullableContext(2)] internal set; }

		// Token: 0x17004C41 RID: 19521
		// (get) Token: 0x06025164 RID: 151908 RVA: 0x00A76C68 File Offset: 0x00A74E68
		internal CancellationToken StopToken
		{
			get
			{
				return this.StopSource.Token;
			}
		}

		// Token: 0x06025165 RID: 151909 RVA: 0x00A76C78 File Offset: 0x00A74E78
		public VisualNovelContext(DialogueScript script, VisualNovelDate date, int backgroundId, [Nullable(2)] VisualNovelConfigCenter configCenter = null)
		{
			this.Script = script;
			foreach (DialogueItem dialogueItem in script.GetItems())
			{
				VisualNovelItem visualNovelItem = VisualNovelItem.Create(dialogueItem);
				if (visualNovelItem != null)
				{
					visualNovelItem.ReadPlotKeyId = ((visualNovelItem.PlotKeyId > 0) ? visualNovelItem.PlotKeyId : null);
					this.ItemList.Add(visualNovelItem);
					this.ItemByDialogueItem.Add(dialogueItem, visualNovelItem);
				}
			}
			this.InitializeReadPlotKeys();
			this.ConfigCenter = (configCenter ?? new VisualNovelConfigCenter());
			this.Assets = new VisualNovelAssetCache(this.ConfigCenter);
			this.Audio = new VisualNovelAudio(this.Assets);
			this.Effects = new VisualNovelEffects(this, "VisualNovel");
			this.Date = date;
			this.BackgroundId = backgroundId;
			SetPlotMode plotMode = script.GetPlotMode();
			IVisualNovelConfig visualNovelConfig = (plotMode != null) ? plotMode.VisualNovelConfig : null;
			this.FastForwardEnabled = (visualNovelConfig != null && visualNovelConfig.EnableFastForward.GetValueOrDefault());
			bool flag = visualNovelConfig == null || !visualNovelConfig.HideControlUi.GetValueOrDefault();
			this.AutoButtonVisible = flag;
			this.ReviewButtonVisible = flag;
			this.MenuButtonVisible = flag;
			this.AccelerateButtonVisible = (flag && this.FastForwardEnabled);
			this.HideUiButtonVisible = true;
			this.UltraFastForwardButtonVisible = true;
		}

		// Token: 0x06025166 RID: 151910 RVA: 0x00A76EA8 File Offset: 0x00A750A8
		private void InitializeReadPlotKeys()
		{
			VisualNovelContext.<>c__DisplayClass193_0 CS$<>8__locals1;
			CS$<>8__locals1.readKeyUses = new Dictionary<int, int>();
			foreach (VisualNovelItem visualNovelItem in this.ItemList)
			{
				VisualNovelContext.<InitializeReadPlotKeys>g__CountReadKey|193_0(visualNovelItem.PlotKeyId, ref CS$<>8__locals1);
				foreach (VisualNovelOption visualNovelOption in visualNovelItem.Options)
				{
					VisualNovelContext.<InitializeReadPlotKeys>g__CountReadKey|193_0(visualNovelOption.PlotOptionId, ref CS$<>8__locals1);
				}
			}
			foreach (ActionInfo actionInfo in this.Script.GetPlaybackActions())
			{
				ShowTalk showTalk = actionInfo.Params as ShowTalk;
				if (showTalk != null)
				{
					IReadOnlyList<DialogueItem> items = this.Script.GetItems(showTalk);
					VisualNovelContext.<>c__DisplayClass193_1 CS$<>8__locals2;
					CS$<>8__locals2.itemById = new Dictionary<int, DialogueItem>();
					CS$<>8__locals2.predecessors = new Dictionary<DialogueItem, DialogueItem>();
					CS$<>8__locals2.incomingEdges = new Dictionary<DialogueItem, int>();
					Dictionary<DialogueItem, DialogueItem> dictionary = new Dictionary<DialogueItem, DialogueItem>();
					HashSet<DialogueItem> hashSet = new HashSet<DialogueItem>();
					foreach (DialogueItem dialogueItem in items)
					{
						CS$<>8__locals2.itemById.TryAdd(dialogueItem.Id, dialogueItem);
						VisualNovelItem item = this.GetItem(dialogueItem);
						if (item != null)
						{
							foreach (IVisualNovelPerformanceBase visualNovelPerformanceBase in item.StartPerformances)
							{
								if (visualNovelPerformanceBase != null && visualNovelPerformanceBase.Type == EVisualNovelPerformanceType.ActivityAction)
								{
									hashSet.Add(dialogueItem);
								}
							}
							foreach (IVisualNovelPerformanceBase visualNovelPerformanceBase2 in item.EndPerformances)
							{
								if (visualNovelPerformanceBase2 != null && visualNovelPerformanceBase2.Type == EVisualNovelPerformanceType.ActivityAction)
								{
									hashSet.Add(dialogueItem);
								}
							}
						}
					}
					for (int i = 0; i < items.Count; i++)
					{
						DialogueItem dialogueItem2 = items[i];
						DialogueItem dialogueItem3 = (i + 1 < items.Count) ? items[i + 1] : null;
						dictionary.Add(dialogueItem2, dialogueItem3);
						if (dialogueItem2.Options.Count == 0)
						{
							VisualNovelContext.<InitializeReadPlotKeys>g__AddPredecessor|193_1(dialogueItem2, dialogueItem2.Jump, dialogueItem3, ref CS$<>8__locals2);
						}
						else
						{
							foreach (DialogueOption dialogueOption in dialogueItem2.Options)
							{
								DialogueItem source = dialogueItem2;
								DialogueJump? jump = dialogueOption.Jump;
								VisualNovelContext.<InitializeReadPlotKeys>g__AddPredecessor|193_1(source, (jump != null) ? jump : dialogueItem2.Jump, dialogueItem3, ref CS$<>8__locals2);
							}
						}
					}
					foreach (DialogueItem dialogueItem4 in items)
					{
						VisualNovelItem item2 = this.GetItem(dialogueItem4);
						if (item2 != null)
						{
							int? plotKeyId = item2.PlotKeyId;
							if (plotKeyId != null && plotKeyId.GetValueOrDefault() > 0)
							{
								DialogueItem dialogueItem5 = dialogueItem4;
								HashSet<DialogueItem> hashSet2 = new HashSet<DialogueItem>();
								DialogueItem dialogueItem6;
								while (hashSet2.Add(dialogueItem5) && !hashSet.Contains(dialogueItem5) && CS$<>8__locals2.predecessors.TryGetValue(dialogueItem5, out dialogueItem6) && dialogueItem6 != null)
								{
									VisualNovelItem item3 = this.GetItem(dialogueItem6);
									if (item3 == null || item3.PlotKeyId > 0 || dialogueItem6.Options.Count > 0 || hashSet.Contains(dialogueItem6))
									{
										break;
									}
									item3.ReadPlotKeyId = item2.PlotKeyId;
									dialogueItem5 = dialogueItem6;
								}
							}
						}
					}
					foreach (DialogueItem dialogueItem7 in items)
					{
						if (this.GetItem(dialogueItem7) != null && !hashSet.Contains(dialogueItem7))
						{
							foreach (DialogueOption dialogueOption2 in dialogueItem7.Options)
							{
								ITalkOptionVisualNovel talkOptionVisualNovel = dialogueOption2.Config.TypeParams as ITalkOptionVisualNovel;
								int? readPlotKeyId = (talkOptionVisualNovel != null) ? talkOptionVisualNovel.PlotOptionId : null;
								if (readPlotKeyId != null && readPlotKeyId.GetValueOrDefault() > 0 && CS$<>8__locals1.readKeyUses.GetValueOrDefault(readPlotKeyId.Value, 0) == 1)
								{
									bool flag = false;
									foreach (IVisualNovelPerformanceBase visualNovelPerformanceBase3 in (((talkOptionVisualNovel != null) ? talkOptionVisualNovel.OptionPerformances : null) ?? new List<IVisualNovelPerformanceBase>()))
									{
										if (visualNovelPerformanceBase3 != null && visualNovelPerformanceBase3.Type == EVisualNovelPerformanceType.ActivityAction)
										{
											flag = true;
											break;
										}
									}
									if (!flag)
									{
										DialogueJump? jump = dialogueOption2.Jump;
										DialogueItem dialogueItem8 = VisualNovelContext.<InitializeReadPlotKeys>g__GetTarget|193_2((jump != null) ? jump : dialogueItem7.Jump, dictionary[dialogueItem7], ref CS$<>8__locals2);
										DialogueItem dialogueItem9 = dialogueItem7;
										HashSet<DialogueItem> hashSet3 = new HashSet<DialogueItem>();
										List<VisualNovelItem> list = new List<VisualNovelItem>();
										while (dialogueItem8 != null)
										{
											if (!hashSet3.Add(dialogueItem8))
											{
												list.Clear();
												break;
											}
											DialogueItem dialogueItem10;
											if (CS$<>8__locals2.incomingEdges.GetValueOrDefault(dialogueItem8, 0) != 1 || !CS$<>8__locals2.predecessors.TryGetValue(dialogueItem8, out dialogueItem10) || dialogueItem10 != dialogueItem9)
											{
												break;
											}
											VisualNovelItem item4 = this.GetItem(dialogueItem8);
											if (item4 == null || item4.ReadPlotKeyId > 0 || dialogueItem8.Options.Count > 0 || hashSet.Contains(dialogueItem8))
											{
												break;
											}
											list.Add(item4);
											DialogueItem dialogueItem11 = VisualNovelContext.<InitializeReadPlotKeys>g__GetTarget|193_2(dialogueItem8.Jump, dictionary[dialogueItem8], ref CS$<>8__locals2);
											if (dialogueItem11 == null)
											{
												jump = dialogueItem8.Jump;
												if (jump != null && !jump.GetValueOrDefault().EndsDialogue)
												{
													list.Clear();
													break;
												}
											}
											dialogueItem9 = dialogueItem8;
											dialogueItem8 = dialogueItem11;
										}
										foreach (VisualNovelItem visualNovelItem2 in list)
										{
											visualNovelItem2.ReadPlotKeyId = readPlotKeyId;
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06025167 RID: 151911 RVA: 0x00A77630 File Offset: 0x00A75830
		internal void BindPlayer(VisualNovelPlayer player)
		{
			this.Player = player;
		}

		// Token: 0x06025168 RID: 151912 RVA: 0x00A7763C File Offset: 0x00A7583C
		public void SetSceneAndView(VisualNovelScene scene, IVisualNovelView view)
		{
			this.Scene = scene;
			this.View = view;
			this.IsReady = true;
			VisualNovelBackground background = scene.GetBackground();
			if (background != null)
			{
				background.SetPlaybackRate(this.PlaybackRate);
			}
			VisualNovelBackground background2 = scene.GetBackground();
			if (background2 != null)
			{
				background2.SetPaused(this.IsPaused);
			}
			this.Effects.SetPlaybackRate(this.PlaybackRate);
			this.Effects.SetPaused(this.IsPaused);
		}

		// Token: 0x06025169 RID: 151913 RVA: 0x00A776AE File Offset: 0x00A758AE
		public void ClearSceneAndView()
		{
			if (this.IsReady)
			{
				this.View.ClearScreenEffects();
			}
			this.Scene = null;
			this.View = null;
			this.IsReady = false;
			this.AreCharactersTemporarilyHidden = false;
		}

		// Token: 0x0602516A RID: 151914 RVA: 0x00A776DF File Offset: 0x00A758DF
		internal void SetCurrentSpeaker(int speakerId)
		{
			this.CurrentSpeakerId = speakerId;
			this.CurrentAvgTalkerId = ((speakerId > 0) ? this.ConfigCenter.GetAvgTalkerId(speakerId) : 0);
		}

		// Token: 0x0602516B RID: 151915 RVA: 0x00A77701 File Offset: 0x00A75901
		internal void SetDate(VisualNovelDate date)
		{
			this.Date = date;
		}

		// Token: 0x0602516C RID: 151916 RVA: 0x00A7770A File Offset: 0x00A7590A
		internal void SetBackground(int backgroundId)
		{
			this.BackgroundId = backgroundId;
		}

		// Token: 0x0602516D RID: 151917 RVA: 0x00A77713 File Offset: 0x00A75913
		internal void SetPlaybackMode(EVisualNovelPlaybackMode playbackMode)
		{
			this.PlaybackMode = playbackMode;
			Action<EVisualNovelPlaybackMode> playbackModeChanged = this.PlaybackModeChanged;
			if (playbackModeChanged == null)
			{
				return;
			}
			playbackModeChanged(playbackMode);
		}

		// Token: 0x0602516E RID: 151918 RVA: 0x00A7772D File Offset: 0x00A7592D
		internal void SetPlaybackRate(float playbackRate)
		{
			this.PlaybackRate = playbackRate;
			this.Audio.SetPlaybackRate(this.PlaybackRate);
		}

		// Token: 0x0602516F RID: 151919 RVA: 0x00A77747 File Offset: 0x00A75947
		internal void SetInputLocked(bool locked)
		{
			this.IsInputLocked = locked;
		}

		// Token: 0x06025170 RID: 151920 RVA: 0x00A77750 File Offset: 0x00A75950
		internal void SetAutoAdvanceMuted(bool muted)
		{
			if (this.IsStopped || this.IsAutoAdvanceMuted == muted)
			{
				return;
			}
			this.IsAutoAdvanceMuted = muted;
			if (muted)
			{
				this.AutoAdvanceResumePromise = new UniTaskCompletionSource();
			}
			Action autoAdvanceMutedChanged = this.AutoAdvanceMutedChanged;
			if (autoAdvanceMutedChanged != null)
			{
				autoAdvanceMutedChanged();
			}
			if (!muted)
			{
				this.CompleteAutoAdvanceResumePromise();
			}
		}

		// Token: 0x06025171 RID: 151921 RVA: 0x00A7779E File Offset: 0x00A7599E
		internal bool Pause()
		{
			if (this.IsStopped || this.IsPaused)
			{
				return false;
			}
			this.IsPaused = true;
			this.ResumePromise = new UniTaskCompletionSource();
			this.Audio.SetPaused(true);
			return true;
		}

		// Token: 0x06025172 RID: 151922 RVA: 0x00A777D1 File Offset: 0x00A759D1
		internal bool Resume()
		{
			if (!this.IsPaused)
			{
				return false;
			}
			this.IsPaused = false;
			this.Audio.SetPaused(false);
			this.CompleteResumePromise();
			return true;
		}

		// Token: 0x06025173 RID: 151923 RVA: 0x00A777F8 File Offset: 0x00A759F8
		internal UniTask WaitUntilResumedAsync()
		{
			VisualNovelContext.<WaitUntilResumedAsync>d__206 <WaitUntilResumedAsync>d__;
			<WaitUntilResumedAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitUntilResumedAsync>d__.<>4__this = this;
			<WaitUntilResumedAsync>d__.<>1__state = -1;
			<WaitUntilResumedAsync>d__.<>t__builder.Start<VisualNovelContext.<WaitUntilResumedAsync>d__206>(ref <WaitUntilResumedAsync>d__);
			return <WaitUntilResumedAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025174 RID: 151924 RVA: 0x00A7783C File Offset: 0x00A75A3C
		internal UniTask EnsureResumedAsync()
		{
			VisualNovelContext.<EnsureResumedAsync>d__207 <EnsureResumedAsync>d__;
			<EnsureResumedAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EnsureResumedAsync>d__.<>4__this = this;
			<EnsureResumedAsync>d__.<>1__state = -1;
			<EnsureResumedAsync>d__.<>t__builder.Start<VisualNovelContext.<EnsureResumedAsync>d__207>(ref <EnsureResumedAsync>d__);
			return <EnsureResumedAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025175 RID: 151925 RVA: 0x00A77880 File Offset: 0x00A75A80
		internal UniTask WaitUntilAutoAdvanceResumedAsync()
		{
			VisualNovelContext.<WaitUntilAutoAdvanceResumedAsync>d__208 <WaitUntilAutoAdvanceResumedAsync>d__;
			<WaitUntilAutoAdvanceResumedAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitUntilAutoAdvanceResumedAsync>d__.<>4__this = this;
			<WaitUntilAutoAdvanceResumedAsync>d__.<>1__state = -1;
			<WaitUntilAutoAdvanceResumedAsync>d__.<>t__builder.Start<VisualNovelContext.<WaitUntilAutoAdvanceResumedAsync>d__208>(ref <WaitUntilAutoAdvanceResumedAsync>d__);
			return <WaitUntilAutoAdvanceResumedAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025176 RID: 151926 RVA: 0x00A778C3 File Offset: 0x00A75AC3
		internal void Stop()
		{
			this.IsStopped = true;
			this.IsPaused = false;
			this.IsAutoAdvanceMuted = false;
			this.Audio.SetPaused(true);
			this.CompleteResumePromise();
			this.CompleteAutoAdvanceResumePromise();
			this.Assets.Clear();
		}

		// Token: 0x06025177 RID: 151927 RVA: 0x00A778FD File Offset: 0x00A75AFD
		internal void CancelExecutingActions()
		{
			this.StopSource.Cancel();
		}

		// Token: 0x06025178 RID: 151928 RVA: 0x00A7790A File Offset: 0x00A75B0A
		internal void Dispose()
		{
			this.PlaybackModeChanged = null;
			this.AutoAdvanceMutedChanged = null;
			this.Audio.Dispose();
			this.Effects.Destroy();
			this.Assets.Clear();
		}

		// Token: 0x06025179 RID: 151929 RVA: 0x00A7793C File Offset: 0x00A75B3C
		public void Jump(int talkId)
		{
			DialogueItem item;
			VisualNovelItem visualNovelItem = this.Script.TryGetItem(talkId, out item) ? this.GetItem(item) : null;
			if (visualNovelItem == null)
			{
				VisualNovelPlayer player = this.Player;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
				defaultInterpolatedStringHandler.AppendLiteral("找不到可播放的目标 TalkItem: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(talkId);
				player.Fail(defaultInterpolatedStringHandler.ToStringAndClear());
				return;
			}
			this.NextItem = visualNovelItem;
		}

		// Token: 0x0602517A RID: 151930 RVA: 0x00A7799F File Offset: 0x00A75B9F
		[return: Nullable(2)]
		internal VisualNovelItem GetItem(DialogueItem item)
		{
			return this.ItemByDialogueItem.GetValueOrDefault(item);
		}

		// Token: 0x0602517B RID: 151931 RVA: 0x00A779B0 File Offset: 0x00A75BB0
		[NullableContext(2)]
		public VisualNovelItem GetFirstItem()
		{
			foreach (ActionInfo actionInfo in this.Script.GetPlaybackActions())
			{
				ShowTalk showTalk = actionInfo.Params as ShowTalk;
				if (showTalk != null)
				{
					IReadOnlyList<DialogueItem> items = this.Script.GetItems(showTalk);
					if (items.Count > 0)
					{
						return this.GetItem(items[0]);
					}
				}
				else
				{
					PlayMovie playMovie = actionInfo.Params as PlayMovie;
					if (playMovie != null && !string.IsNullOrEmpty(playMovie.VideoName))
					{
						return null;
					}
				}
			}
			return null;
		}

		// Token: 0x0602517C RID: 151932 RVA: 0x00A77A5C File Offset: 0x00A75C5C
		private void CompleteResumePromise()
		{
			UniTaskCompletionSource resumePromise = this.ResumePromise;
			this.ResumePromise = null;
			if (resumePromise == null)
			{
				return;
			}
			resumePromise.TrySetResult();
		}

		// Token: 0x0602517D RID: 151933 RVA: 0x00A77A76 File Offset: 0x00A75C76
		private void CompleteAutoAdvanceResumePromise()
		{
			UniTaskCompletionSource autoAdvanceResumePromise = this.AutoAdvanceResumePromise;
			this.AutoAdvanceResumePromise = null;
			if (autoAdvanceResumePromise == null)
			{
				return;
			}
			autoAdvanceResumePromise.TrySetResult();
		}

		// Token: 0x0602517E RID: 151934 RVA: 0x00A77A90 File Offset: 0x00A75C90
		[CompilerGenerated]
		internal static void <InitializeReadPlotKeys>g__AddPredecessor|193_1(DialogueItem source, DialogueJump? jump, [Nullable(2)] DialogueItem next, ref VisualNovelContext.<>c__DisplayClass193_1 A_3)
		{
			DialogueItem dialogueItem = VisualNovelContext.<InitializeReadPlotKeys>g__GetTarget|193_2(jump, next, ref A_3);
			if (dialogueItem == null)
			{
				return;
			}
			A_3.incomingEdges[dialogueItem] = A_3.incomingEdges.GetValueOrDefault(dialogueItem, 0) + 1;
			DialogueItem dialogueItem2;
			if (!A_3.predecessors.TryGetValue(dialogueItem, out dialogueItem2))
			{
				A_3.predecessors.Add(dialogueItem, source);
				return;
			}
			if (dialogueItem2 != source)
			{
				A_3.predecessors[dialogueItem] = null;
			}
		}

		// Token: 0x0602517F RID: 151935 RVA: 0x00A77AF4 File Offset: 0x00A75CF4
		[NullableContext(2)]
		[CompilerGenerated]
		internal static DialogueItem <InitializeReadPlotKeys>g__GetTarget|193_2(DialogueJump? jump, DialogueItem next, ref VisualNovelContext.<>c__DisplayClass193_1 A_2)
		{
			if (jump != null && jump.GetValueOrDefault().EndsDialogue)
			{
				return null;
			}
			if (jump == null)
			{
				return next;
			}
			return A_2.itemById.GetValueOrDefault(jump.Value.TargetId);
		}

		// Token: 0x06025180 RID: 151936 RVA: 0x00A77B45 File Offset: 0x00A75D45
		[CompilerGenerated]
		internal static void <InitializeReadPlotKeys>g__CountReadKey|193_0(int? plotId, ref VisualNovelContext.<>c__DisplayClass193_0 A_1)
		{
			if (plotId != null && plotId.GetValueOrDefault() > 0)
			{
				A_1.readKeyUses[plotId.Value] = A_1.readKeyUses.GetValueOrDefault(plotId.Value, 0) + 1;
			}
		}

		// Token: 0x040147FF RID: 83967
		private readonly List<VisualNovelItem> ItemList = new List<VisualNovelItem>();

		// Token: 0x04014800 RID: 83968
		private readonly Dictionary<DialogueItem, VisualNovelItem> ItemByDialogueItem = new Dictionary<DialogueItem, VisualNovelItem>();

		// Token: 0x04014831 RID: 84017
		[Nullable(2)]
		private UniTaskCompletionSource ResumePromise;

		// Token: 0x04014832 RID: 84018
		[Nullable(2)]
		private UniTaskCompletionSource AutoAdvanceResumePromise;

		// Token: 0x04014833 RID: 84019
		private readonly CancellationTokenSource StopSource = new CancellationTokenSource();
	}
}
