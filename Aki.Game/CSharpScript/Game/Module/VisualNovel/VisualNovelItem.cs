using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Dialogue;

namespace CSharpScript.Game.Module.VisualNovel
{
	// Token: 0x020037B8 RID: 14264
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class VisualNovelItem
	{
		// Token: 0x17004C63 RID: 19555
		// (get) Token: 0x060251C1 RID: 152001 RVA: 0x00A780B7 File Offset: 0x00A762B7
		public int Id { get; }

		// Token: 0x17004C64 RID: 19556
		// (get) Token: 0x060251C2 RID: 152002 RVA: 0x00A780BF File Offset: 0x00A762BF
		// (set) Token: 0x060251C3 RID: 152003 RVA: 0x00A780C7 File Offset: 0x00A762C7
		public ETalkItemType Type { get; private set; }

		// Token: 0x17004C65 RID: 19557
		// (get) Token: 0x060251C4 RID: 152004 RVA: 0x00A780D0 File Offset: 0x00A762D0
		public int SpeakerId { get; }

		// Token: 0x17004C66 RID: 19558
		// (get) Token: 0x060251C5 RID: 152005 RVA: 0x00A780D8 File Offset: 0x00A762D8
		public string TextKey { get; }

		// Token: 0x17004C67 RID: 19559
		// (get) Token: 0x060251C6 RID: 152006 RVA: 0x00A780E0 File Offset: 0x00A762E0
		public int? TextId { get; }

		// Token: 0x17004C68 RID: 19560
		// (get) Token: 0x060251C7 RID: 152007 RVA: 0x00A780E8 File Offset: 0x00A762E8
		public bool PlayVoice { get; }

		// Token: 0x17004C69 RID: 19561
		// (get) Token: 0x060251C8 RID: 152008 RVA: 0x00A780F0 File Offset: 0x00A762F0
		// (set) Token: 0x060251C9 RID: 152009 RVA: 0x00A780F8 File Offset: 0x00A762F8
		public string Interjection { get; private set; } = string.Empty;

		// Token: 0x17004C6A RID: 19562
		// (get) Token: 0x060251CA RID: 152010 RVA: 0x00A78101 File Offset: 0x00A76301
		// (set) Token: 0x060251CB RID: 152011 RVA: 0x00A78109 File Offset: 0x00A76309
		public string QuestionTextKey { get; private set; }

		// Token: 0x17004C6B RID: 19563
		// (get) Token: 0x060251CC RID: 152012 RVA: 0x00A78112 File Offset: 0x00A76312
		// (set) Token: 0x060251CD RID: 152013 RVA: 0x00A7811A File Offset: 0x00A7631A
		public float DialogueDelay { get; private set; }

		// Token: 0x17004C6C RID: 19564
		// (get) Token: 0x060251CE RID: 152014 RVA: 0x00A78123 File Offset: 0x00A76323
		public float ClickProtectionTime { get; }

		// Token: 0x17004C6D RID: 19565
		// (get) Token: 0x060251CF RID: 152015 RVA: 0x00A7812B File Offset: 0x00A7632B
		// (set) Token: 0x060251D0 RID: 152016 RVA: 0x00A78133 File Offset: 0x00A76333
		public bool ClickShowFull { get; private set; }

		// Token: 0x17004C6E RID: 19566
		// (get) Token: 0x060251D1 RID: 152017 RVA: 0x00A7813C File Offset: 0x00A7633C
		// (set) Token: 0x060251D2 RID: 152018 RVA: 0x00A78144 File Offset: 0x00A76344
		public int? PlotKeyId { get; private set; }

		// Token: 0x17004C6F RID: 19567
		// (get) Token: 0x060251D3 RID: 152019 RVA: 0x00A7814D File Offset: 0x00A7634D
		// (set) Token: 0x060251D4 RID: 152020 RVA: 0x00A78155 File Offset: 0x00A76355
		public int? ReadPlotKeyId { get; internal set; }

		// Token: 0x17004C70 RID: 19568
		// (get) Token: 0x060251D5 RID: 152021 RVA: 0x00A7815E File Offset: 0x00A7635E
		// (set) Token: 0x060251D6 RID: 152022 RVA: 0x00A78166 File Offset: 0x00A76366
		public EVisualNovelOptionInteractionType? OptionInteractionType { get; private set; }

		// Token: 0x17004C71 RID: 19569
		// (get) Token: 0x060251D7 RID: 152023 RVA: 0x00A7816F File Offset: 0x00A7636F
		// (set) Token: 0x060251D8 RID: 152024 RVA: 0x00A78177 File Offset: 0x00A76377
		public EVisualNovelOptionGroupType OptionGroupType { get; private set; }

		// Token: 0x17004C72 RID: 19570
		// (get) Token: 0x060251D9 RID: 152025 RVA: 0x00A78180 File Offset: 0x00A76380
		// (set) Token: 0x060251DA RID: 152026 RVA: 0x00A78188 File Offset: 0x00A76388
		[Nullable(2)]
		public IVisualNovelBackgroundBase BackgroundConfig { [NullableContext(2)] get; [NullableContext(2)] private set; }

		// Token: 0x17004C73 RID: 19571
		// (get) Token: 0x060251DB RID: 152027 RVA: 0x00A78191 File Offset: 0x00A76391
		// (set) Token: 0x060251DC RID: 152028 RVA: 0x00A78199 File Offset: 0x00A76399
		[Nullable(2)]
		public IVisualNovelCgBase CgConfig { [NullableContext(2)] get; [NullableContext(2)] private set; }

		// Token: 0x17004C74 RID: 19572
		// (get) Token: 0x060251DD RID: 152029 RVA: 0x00A781A2 File Offset: 0x00A763A2
		// (set) Token: 0x060251DE RID: 152030 RVA: 0x00A781AA File Offset: 0x00A763AA
		public IReadOnlyList<IVisualNovelPerformanceBase> StartPerformances { get; private set; } = Array.Empty<IVisualNovelPerformanceBase>();

		// Token: 0x17004C75 RID: 19573
		// (get) Token: 0x060251DF RID: 152031 RVA: 0x00A781B3 File Offset: 0x00A763B3
		// (set) Token: 0x060251E0 RID: 152032 RVA: 0x00A781BB File Offset: 0x00A763BB
		public IReadOnlyList<IVisualNovelPerformanceBase> EndPerformances { get; private set; } = Array.Empty<IVisualNovelPerformanceBase>();

		// Token: 0x17004C76 RID: 19574
		// (get) Token: 0x060251E1 RID: 152033 RVA: 0x00A781C4 File Offset: 0x00A763C4
		public IReadOnlyList<VisualNovelOption> Options { get; }

		// Token: 0x060251E2 RID: 152034 RVA: 0x00A781CC File Offset: 0x00A763CC
		private VisualNovelItem(DialogueItem item)
		{
			ITalkItem config = item.Config;
			this.Id = config.Id;
			this.SpeakerId = config.WhoId.GetValueOrDefault();
			this.TextKey = (config.TidTalk ?? string.Empty);
			this.TextId = config.TextId;
			this.PlayVoice = config.PlayVoice.GetValueOrDefault();
			this.QuestionTextKey = this.TextKey;
			this.ClickProtectionTime = Math.Max(config.WaitTime.GetValueOrDefault(), 0f);
			this.Options = VisualNovelItem.CreateOptions(item.Options);
		}

		// Token: 0x060251E3 RID: 152035 RVA: 0x00A78298 File Offset: 0x00A76498
		[return: Nullable(2)]
		public static VisualNovelItem Create(DialogueItem item)
		{
			VisualNovelItem visualNovelItem = new VisualNovelItem(item);
			ITalkItem config = item.Config;
			ITalkItemVisualNovelTalk talkItemVisualNovelTalk = config as ITalkItemVisualNovelTalk;
			if (talkItemVisualNovelTalk == null)
			{
				ITalkItemVisualNovelNarration talkItemVisualNovelNarration = config as ITalkItemVisualNovelNarration;
				if (talkItemVisualNovelNarration == null)
				{
					ITalkItemVisualNovelCenterText talkItemVisualNovelCenterText = config as ITalkItemVisualNovelCenterText;
					if (talkItemVisualNovelCenterText == null)
					{
						ITalkItemVisualNovelNoTextItem talkItemVisualNovelNoTextItem = config as ITalkItemVisualNovelNoTextItem;
						if (talkItemVisualNovelNoTextItem == null)
						{
							ITalkItemVisualNovelOption talkItemVisualNovelOption = config as ITalkItemVisualNovelOption;
							if (talkItemVisualNovelOption == null)
							{
								return null;
							}
							visualNovelItem.Type = ETalkItemType.VisualNovelOption;
							VisualNovelItem visualNovelItem2 = visualNovelItem;
							IVisualNovelOptionGroupConfigBase optionGroup = talkItemVisualNovelOption.OptionGroup;
							visualNovelItem2.OptionGroupType = ((optionGroup != null) ? optionGroup.Type : EVisualNovelOptionGroupType.FullScreen);
							visualNovelItem.BackgroundConfig = talkItemVisualNovelOption.VisualNovelBackgroundConfig;
							visualNovelItem.QuestionTextKey = (string.IsNullOrEmpty(talkItemVisualNovelOption.TidCustomDescText) ? visualNovelItem.TextKey : talkItemVisualNovelOption.TidCustomDescText);
							visualNovelItem.OptionInteractionType = talkItemVisualNovelOption.OptionInteractionType;
							visualNovelItem.PlotKeyId = talkItemVisualNovelOption.PlotKeyId;
							visualNovelItem.CgConfig = talkItemVisualNovelOption.CgConfig;
						}
						else
						{
							visualNovelItem.Type = ETalkItemType.VisualNovelNoTextItem;
							VisualNovelItem visualNovelItem3 = visualNovelItem;
							IVisualNovelOptionGroupConfigBase optionGroup2 = talkItemVisualNovelNoTextItem.OptionGroup;
							visualNovelItem3.OptionGroupType = ((optionGroup2 != null) ? optionGroup2.Type : EVisualNovelOptionGroupType.Normal);
							visualNovelItem.BackgroundConfig = talkItemVisualNovelNoTextItem.VisualNovelBackgroundConfig;
							visualNovelItem.OptionInteractionType = talkItemVisualNovelNoTextItem.OptionInteractionType;
							visualNovelItem.PlotKeyId = talkItemVisualNovelNoTextItem.PlotKeyId;
							visualNovelItem.CgConfig = talkItemVisualNovelNoTextItem.CgConfig;
							visualNovelItem.StartPerformances = (talkItemVisualNovelNoTextItem.StartPerformances ?? new List<IVisualNovelPerformanceBase>());
							visualNovelItem.EndPerformances = (talkItemVisualNovelNoTextItem.EndPerformances ?? new List<IVisualNovelPerformanceBase>());
						}
					}
					else
					{
						visualNovelItem.Type = ETalkItemType.VisualNovelCenterText;
						VisualNovelItem visualNovelItem4 = visualNovelItem;
						IVisualNovelOptionGroupConfigBase optionGroup3 = talkItemVisualNovelCenterText.OptionGroup;
						visualNovelItem4.OptionGroupType = ((optionGroup3 != null) ? optionGroup3.Type : EVisualNovelOptionGroupType.Normal);
						visualNovelItem.OptionInteractionType = talkItemVisualNovelCenterText.OptionInteractionType;
						visualNovelItem.PlotKeyId = talkItemVisualNovelCenterText.PlotKeyId;
					}
				}
				else
				{
					visualNovelItem.Type = ETalkItemType.VisualNovelNarration;
					VisualNovelItem visualNovelItem5 = visualNovelItem;
					IVisualNovelOptionGroupConfigBase optionGroup4 = talkItemVisualNovelNarration.OptionGroup;
					visualNovelItem5.OptionGroupType = ((optionGroup4 != null) ? optionGroup4.Type : EVisualNovelOptionGroupType.Normal);
					visualNovelItem.BackgroundConfig = talkItemVisualNovelNarration.VisualNovelBackgroundConfig;
					visualNovelItem.ApplyTextConfig(talkItemVisualNovelNarration.DialogDelay, talkItemVisualNovelNarration.ClickShowFull, talkItemVisualNovelNarration.OptionInteractionType, talkItemVisualNovelNarration.PlotKeyId, talkItemVisualNovelNarration.CgConfig, talkItemVisualNovelNarration.StartPerformances, talkItemVisualNovelNarration.EndPerformances);
				}
			}
			else
			{
				visualNovelItem.Type = ETalkItemType.VisualNovelTalk;
				VisualNovelItem visualNovelItem6 = visualNovelItem;
				IVisualNovelOptionGroupConfigBase optionGroup5 = talkItemVisualNovelTalk.OptionGroup;
				visualNovelItem6.OptionGroupType = ((optionGroup5 != null) ? optionGroup5.Type : EVisualNovelOptionGroupType.Normal);
				visualNovelItem.Interjection = (talkItemVisualNovelTalk.Interjection ?? string.Empty);
				visualNovelItem.BackgroundConfig = talkItemVisualNovelTalk.VisualNovelBackgroundConfig;
				visualNovelItem.ApplyTextConfig(talkItemVisualNovelTalk.DialogDelay, talkItemVisualNovelTalk.ClickShowFull, talkItemVisualNovelTalk.OptionInteractionType, talkItemVisualNovelTalk.PlotKeyId, talkItemVisualNovelTalk.CgConfig, talkItemVisualNovelTalk.StartPerformances, talkItemVisualNovelTalk.EndPerformances);
				visualNovelItem.AddCharacterStartPerformance(talkItemVisualNovelTalk.Transform, talkItemVisualNovelTalk.RoleConfig);
			}
			return visualNovelItem;
		}

		// Token: 0x060251E4 RID: 152036 RVA: 0x00A78528 File Offset: 0x00A76728
		[NullableContext(2)]
		public VisualNovelOption GetOption(int sourceIndex)
		{
			foreach (VisualNovelOption visualNovelOption in this.Options)
			{
				if (visualNovelOption.SourceIndex == sourceIndex)
				{
					return visualNovelOption;
				}
			}
			return null;
		}

		// Token: 0x060251E5 RID: 152037 RVA: 0x00A78580 File Offset: 0x00A76780
		public EVisualNovelBlackScreenType? GetInitialBlackScreenType()
		{
			EVisualNovelBlackScreenType? result = null;
			foreach (IVisualNovelPerformanceBase visualNovelPerformanceBase in this.StartPerformances)
			{
				if (visualNovelPerformanceBase is IVisualNovelPerformanceLeaveBlackScreen)
				{
					return null;
				}
				IVisualNovelPerformanceEnterBlackScreen visualNovelPerformanceEnterBlackScreen = visualNovelPerformanceBase as IVisualNovelPerformanceEnterBlackScreen;
				if (visualNovelPerformanceEnterBlackScreen != null && !(visualNovelPerformanceEnterBlackScreen.StartTime > 0f))
				{
					EVisualNovelBlackScreenType valueOrDefault = visualNovelPerformanceEnterBlackScreen.ScreenType.GetValueOrDefault();
					if (result != null && result.Value != valueOrDefault)
					{
						return null;
					}
					result = new EVisualNovelBlackScreenType?(valueOrDefault);
				}
			}
			return result;
		}

		// Token: 0x060251E6 RID: 152038 RVA: 0x00A78654 File Offset: 0x00A76854
		[NullableContext(2)]
		private void ApplyTextConfig(float? dialogueDelay, bool? clickShowFull, EVisualNovelOptionInteractionType? optionInteractionType, int? plotKeyId, IVisualNovelCgBase cgConfig, [Nullable(new byte[]
		{
			2,
			1
		})] IReadOnlyList<IVisualNovelPerformanceBase> startPerformances, [Nullable(new byte[]
		{
			2,
			1
		})] IReadOnlyList<IVisualNovelPerformanceBase> endPerformances)
		{
			this.DialogueDelay = dialogueDelay.GetValueOrDefault();
			this.ClickShowFull = clickShowFull.GetValueOrDefault();
			this.OptionInteractionType = optionInteractionType;
			this.PlotKeyId = plotKeyId;
			this.CgConfig = cgConfig;
			this.StartPerformances = (startPerformances ?? Array.Empty<IVisualNovelPerformanceBase>());
			this.EndPerformances = (endPerformances ?? Array.Empty<IVisualNovelPerformanceBase>());
		}

		// Token: 0x060251E7 RID: 152039 RVA: 0x00A786B4 File Offset: 0x00A768B4
		[NullableContext(2)]
		private void AddCharacterStartPerformance(IVisualNovelPortraitTransform transform, IVisualNovelRoleConfig roleConfig)
		{
			if (this.SpeakerId == 0 || (transform == null && roleConfig == null))
			{
				return;
			}
			IVisualNovelPerformanceModifyRole item = new IVisualNovelPerformanceModifyRole
			{
				Type = EVisualNovelPerformanceType.ModifyRole,
				StartTime = new float?(0f),
				WhoId = this.SpeakerId,
				Transform = transform,
				RoleConfig = roleConfig
			};
			List<IVisualNovelPerformanceBase> list = new List<IVisualNovelPerformanceBase>(this.StartPerformances.Count + 1)
			{
				item
			};
			list.AddRange(this.StartPerformances);
			this.StartPerformances = list;
		}

		// Token: 0x060251E8 RID: 152040 RVA: 0x00A78734 File Offset: 0x00A76934
		private static IReadOnlyList<VisualNovelOption> CreateOptions(IReadOnlyList<DialogueOption> options)
		{
			if (options.Count == 0)
			{
				return Array.Empty<VisualNovelOption>();
			}
			List<VisualNovelOption> list = new List<VisualNovelOption>(options.Count);
			foreach (DialogueOption option in options)
			{
				list.Add(VisualNovelOption.Create(option));
			}
			return list;
		}
	}
}
