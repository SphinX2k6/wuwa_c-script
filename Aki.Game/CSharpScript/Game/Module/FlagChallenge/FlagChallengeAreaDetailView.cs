using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02005A46 RID: 23110
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeAreaDetailView : UiViewBase
	{
		// Token: 0x17008BF3 RID: 35827
		// (get) Token: 0x0603A9BC RID: 240060 RVA: 0x00DF338D File Offset: 0x00DF158D
		[Nullable(2)]
		public new FlagChallengeAreaDetailViewParams OpenParam
		{
			[NullableContext(2)]
			get
			{
				return this.OpenParam as FlagChallengeAreaDetailViewParams;
			}
		}

		// Token: 0x0603A9BD RID: 240061 RVA: 0x00DF339C File Offset: 0x00DF159C
		public FlagChallengeAreaDetailView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603A9BE RID: 240062 RVA: 0x00DF34E0 File Offset: 0x00DF16E0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUITexture)),
				new ValueTuple<int, Type>(9, typeof(UUITexture)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(12, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(13, typeof(UUIItem)),
				new ValueTuple<int, Type>(14, typeof(UUITexture)),
				new ValueTuple<int, Type>(15, typeof(UUITexture)),
				new ValueTuple<int, Type>(16, typeof(UUIItem)),
				new ValueTuple<int, Type>(17, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(18, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(19, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(20, typeof(UUIItem)),
				new ValueTuple<int, Type>(21, typeof(UUISprite)),
				new ValueTuple<int, Type>(22, typeof(UUIItem)),
				new ValueTuple<int, Type>(23, typeof(UUIItem)),
				new ValueTuple<int, Type>(24, typeof(UUIItem)),
				new ValueTuple<int, Type>(25, typeof(UUIText)),
				new ValueTuple<int, Type>(26, typeof(UUIItem)),
				new ValueTuple<int, Type>(27, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(11, new Action(this.OnBuffButtonClick)),
				new ValueTuple<int, Delegate>(12, new Action(this.OnTaskButtonClick)),
				new ValueTuple<int, Delegate>(17, new Action(this.OnLeftPageButtonClick)),
				new ValueTuple<int, Delegate>(18, new Action(this.OnRightPageButtonClick))
			};
		}

		// Token: 0x0603A9BF RID: 240063 RVA: 0x00DF37E4 File Offset: 0x00DF19E4
		protected override UniTask OnBeforeStartAsync()
		{
			FlagChallengeAreaDetailView.<OnBeforeStartAsync>d__22 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FlagChallengeAreaDetailView.<OnBeforeStartAsync>d__22>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603A9C0 RID: 240064 RVA: 0x00DF3828 File Offset: 0x00DF1A28
		protected override void OnStart()
		{
			EFlagChallengeUiStyleType uiStyle = this.Data.GetLevelData(this.LevelId).GetUiStyle();
			base.GetTexture(9).SetColor(FColor.FromHex(this.gridColor[uiStyle]));
			base.GetTexture(8).SetColor(FColor.FromHex(this.centerBgColor[uiStyle]));
			base.GetTexture(14).SetColor(FColor.FromHex(this.bgColor[uiStyle]));
			Dictionary<string, string> dictionary;
			if (!FlagChallengeDefine.Instance.flagChallengeStyleRes.TryGetValue(uiStyle, out dictionary))
			{
				return;
			}
			base.SetTextureByPath(UiResourceConfig.Instance.GetResourcePath(dictionary["LevelSetOffLight"]), base.GetTexture(15), null, null);
			base.SetTextureByPath(UiResourceConfig.Instance.GetResourcePath(dictionary["MaskBg"]), base.GetTexture(1), null, null);
			this.SetStrongholdSelect(this.SelectStrongholdId);
			this.LevelInfoItem.RefreshView();
			this.RefreshTaskView();
			RedDotController.Instance.BindRedDot(ERedDotName.RedDotFlagChallengeActivityReward, base.GetItem(26), null, this.ActivityId);
			RedDotController.Instance.BindRedDot(ERedDotName.RedDotFlagChallengeActivityBuffNewlyUnlocked, base.GetItem(27), null, this.ActivityId);
		}

		// Token: 0x0603A9C1 RID: 240065 RVA: 0x00DF396C File Offset: 0x00DF1B6C
		protected override void OnBeforeDestroy()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotFlagChallengeActivityReward, base.GetItem(26), this.ActivityId);
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotFlagChallengeActivityBuffNewlyUnlocked, base.GetItem(27), this.ActivityId);
		}

		// Token: 0x0603A9C2 RID: 240066 RVA: 0x00DF39A8 File Offset: 0x00DF1BA8
		private void InitViewData()
		{
			FlagChallengeAreaDetailViewParams openParam = this.OpenParam;
			this.ActivityId = openParam.ActivityId;
			this.LevelId = openParam.LevelId;
			this.AreaId = openParam.AreaId;
			this.Data = FlagChallengeModel.Instance.GetFlagChallengeData(this.ActivityId);
			this.AreaDataList = this.Data.GetLevelAreaDataList(this.LevelId);
			this.SelectStrongholdId = openParam.StrongholdId;
		}

		// Token: 0x0603A9C3 RID: 240067 RVA: 0x00DF3A1C File Offset: 0x00DF1C1C
		private UniTask InitStrongholdViewAsync()
		{
			FlagChallengeAreaDetailView.<InitStrongholdViewAsync>d__26 <InitStrongholdViewAsync>d__;
			<InitStrongholdViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitStrongholdViewAsync>d__.<>4__this = this;
			<InitStrongholdViewAsync>d__.<>1__state = -1;
			<InitStrongholdViewAsync>d__.<>t__builder.Start<FlagChallengeAreaDetailView.<InitStrongholdViewAsync>d__26>(ref <InitStrongholdViewAsync>d__);
			return <InitStrongholdViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603A9C4 RID: 240068 RVA: 0x00DF3A60 File Offset: 0x00DF1C60
		private void InitPageView()
		{
			if (this.AreaDataList.Count <= 1)
			{
				base.GetItem(16).SetUIActive(false);
				return;
			}
			base.GetItem(16).SetUIActive(true);
			this.DotLayout = new GenericLayout<FlagChallengeAreaPageDotItem, IFlagChallengeAreaPageDotItemData>(base.GetHorizontalLayout(19), new Func<FlagChallengeAreaPageDotItem>(this.CreatePageDotItem), null, false, true);
		}

		// Token: 0x0603A9C5 RID: 240069 RVA: 0x00DF3ABA File Offset: 0x00DF1CBA
		private void RefreshTaskView()
		{
			UUIText text = base.GetText(25);
			if (text == null)
			{
				return;
			}
			text.SetText(this.Data.GetTaskProgressText(), true);
		}

		// Token: 0x0603A9C6 RID: 240070 RVA: 0x00DF3ADC File Offset: 0x00DF1CDC
		private void RefreshStrongholdPanel(int id)
		{
			this.StrongholdPanel.SetUiActive(true);
			this.StrongholdPanel.RefreshView(id);
			FlagChallengeStrongholdData strongholdData = FlagChallengeModel.Instance.GetStrongholdData(id);
			int totalLevel = FlagChallengeModel.Instance.GetTotalLevel(this.ActivityId);
			base.GetItem(13).SetUIActive(!strongholdData.IsPass && totalLevel < strongholdData.StrongholdConfig.RecommendLevel);
			this.SequencePlayer.StopCurrentSequenceByName("Switch", false, true);
			this.SequencePlayer.PlayOrReplaySequenceByName("Switch", false, null);
		}

		// Token: 0x0603A9C7 RID: 240071 RVA: 0x00DF3B70 File Offset: 0x00DF1D70
		private void SetStrongholdSelect(int? strongholdId)
		{
			if (strongholdId != null)
			{
				this.StrongholdContainer.SetItemSelect(strongholdId.Value);
			}
			else
			{
				this.StrongholdPanel.SetUiActive(false);
			}
			this.SelectStrongholdId = strongholdId;
		}

		// Token: 0x0603A9C8 RID: 240072 RVA: 0x00DF3BA4 File Offset: 0x00DF1DA4
		private UniTask RefreshStrongholdViewAsync(int areaId)
		{
			FlagChallengeAreaDetailView.<RefreshStrongholdViewAsync>d__31 <RefreshStrongholdViewAsync>d__;
			<RefreshStrongholdViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshStrongholdViewAsync>d__.<>4__this = this;
			<RefreshStrongholdViewAsync>d__.areaId = areaId;
			<RefreshStrongholdViewAsync>d__.<>1__state = -1;
			<RefreshStrongholdViewAsync>d__.<>t__builder.Start<FlagChallengeAreaDetailView.<RefreshStrongholdViewAsync>d__31>(ref <RefreshStrongholdViewAsync>d__);
			return <RefreshStrongholdViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603A9C9 RID: 240073 RVA: 0x00DF3BF0 File Offset: 0x00DF1DF0
		private void RefreshPageView(int areaId)
		{
			if (this.DotLayout == null)
			{
				return;
			}
			List<IFlagChallengeAreaPageDotItemData> list = new List<IFlagChallengeAreaPageDotItemData>();
			foreach (FlagChallengeAreaData flagChallengeAreaData in this.AreaDataList)
			{
				list.Add(new FlagChallengeAreaPageDotItemData
				{
					IsHighlight = (flagChallengeAreaData.Id == areaId)
				});
			}
			this.DotLayout.RefreshByData(list, null, false);
		}

		// Token: 0x0603A9CA RID: 240074 RVA: 0x00DF3C74 File Offset: 0x00DF1E74
		private UniTask SwitchAreaAsync(int areaId)
		{
			FlagChallengeAreaDetailView.<SwitchAreaAsync>d__33 <SwitchAreaAsync>d__;
			<SwitchAreaAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SwitchAreaAsync>d__.<>4__this = this;
			<SwitchAreaAsync>d__.areaId = areaId;
			<SwitchAreaAsync>d__.<>1__state = -1;
			<SwitchAreaAsync>d__.<>t__builder.Start<FlagChallengeAreaDetailView.<SwitchAreaAsync>d__33>(ref <SwitchAreaAsync>d__);
			return <SwitchAreaAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603A9CB RID: 240075 RVA: 0x00DF3CBF File Offset: 0x00DF1EBF
		private FlagChallengeAreaPageDotItem CreatePageDotItem()
		{
			return new FlagChallengeAreaPageDotItem();
		}

		// Token: 0x0603A9CC RID: 240076 RVA: 0x00DF3CC6 File Offset: 0x00DF1EC6
		private void OnCloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603A9CD RID: 240077 RVA: 0x00DF3CD0 File Offset: 0x00DF1ED0
		private void OnHelpClick()
		{
			int areaDetailViewHelpId = FlagChallengeConfig.Instance.GetAreaDetailViewHelpId();
			HelpController.Instance.OpenHelpById(areaDetailViewHelpId);
		}

		// Token: 0x0603A9CE RID: 240078 RVA: 0x00DF3CF4 File Offset: 0x00DF1EF4
		private void OnBuffButtonClick()
		{
			FlagChallengeController.Instance.OpenFlagChallengeBuffView(this.ActivityId, null);
		}

		// Token: 0x0603A9CF RID: 240079 RVA: 0x00DF3D1A File Offset: 0x00DF1F1A
		private void OnTaskButtonClick()
		{
			FlagChallengeController.Instance.OpenFlagChallengeTaskView(this.ActivityId);
		}

		// Token: 0x0603A9D0 RID: 240080 RVA: 0x00DF3D2C File Offset: 0x00DF1F2C
		private void OnLeftPageButtonClick()
		{
			List<FlagChallengeAreaData> areaDataList = this.AreaDataList;
			int count = areaDataList.Count;
			int num = -1;
			for (int i = 0; i < areaDataList.Count; i++)
			{
				if (areaDataList[i].Id == this.AreaId)
				{
					num = i;
					break;
				}
			}
			int index = (num - 1 + count) % count;
			int id = areaDataList[index].Id;
			this.SwitchAreaAsync(id);
		}

		// Token: 0x0603A9D1 RID: 240081 RVA: 0x00DF3D98 File Offset: 0x00DF1F98
		private void OnRightPageButtonClick()
		{
			List<FlagChallengeAreaData> areaDataList = this.AreaDataList;
			int count = areaDataList.Count;
			int num = -1;
			for (int i = 0; i < areaDataList.Count; i++)
			{
				if (areaDataList[i].Id == this.AreaId)
				{
					num = i;
					break;
				}
			}
			int index = (num + 1) % count;
			int id = areaDataList[index].Id;
			this.SwitchAreaAsync(id);
		}

		// Token: 0x0603A9D2 RID: 240082 RVA: 0x00DF3E01 File Offset: 0x00DF2001
		private void OnItemSelectChangeCallback(int id)
		{
			this.RefreshStrongholdPanel(id);
		}

		// Token: 0x0603A9D3 RID: 240083 RVA: 0x00DF3E0C File Offset: 0x00DF200C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (!(configParams[0] == "Boss"))
			{
				return null;
			}
			FlagChallengeAreaStrongholdContainer strongholdContainer = this.StrongholdContainer;
			UUIItem uuiitem;
			if (strongholdContainer == null)
			{
				uuiitem = null;
			}
			else
			{
				FlagChallengeAreaStrongholdItem bossStrongholdItem = strongholdContainer.GetBossStrongholdItem();
				uuiitem = ((bossStrongholdItem != null) ? bossStrongholdItem.GetRootItem() : null);
			}
			UUIItem uuiitem2 = uuiitem;
			if (uuiitem2 == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem2,
				uuiitem2
			};
		}

		// Token: 0x0401E8A0 RID: 125088
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401E8A1 RID: 125089
		private int ActivityId;

		// Token: 0x0401E8A2 RID: 125090
		private int LevelId;

		// Token: 0x0401E8A3 RID: 125091
		private int AreaId;

		// Token: 0x0401E8A4 RID: 125092
		private int? SelectStrongholdId;

		// Token: 0x0401E8A5 RID: 125093
		private FlagChallengeData Data;

		// Token: 0x0401E8A6 RID: 125094
		private List<FlagChallengeAreaData> AreaDataList;

		// Token: 0x0401E8A7 RID: 125095
		private FlagChallengeLevelInfoItem LevelInfoItem;

		// Token: 0x0401E8A8 RID: 125096
		private FlagChallengeAreaStrongholdPanel StrongholdPanel;

		// Token: 0x0401E8A9 RID: 125097
		private FlagChallengeAreaStrongholdContainer StrongholdContainer;

		// Token: 0x0401E8AA RID: 125098
		private readonly Dictionary<int, FlagChallengeAreaStrongholdContainer> AreaId2StrongholdContainer = new Dictionary<int, FlagChallengeAreaStrongholdContainer>();

		// Token: 0x0401E8AB RID: 125099
		private GenericLayout<FlagChallengeAreaPageDotItem, IFlagChallengeAreaPageDotItemData> DotLayout;

		// Token: 0x0401E8AC RID: 125100
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0401E8AD RID: 125101
		private readonly int[] strongholdItemList = new int[]
		{
			3,
			4,
			5,
			6,
			7
		};

		// Token: 0x0401E8AE RID: 125102
		private readonly Dictionary<EFlagChallengeUiStyleType, string> bgColor = new Dictionary<EFlagChallengeUiStyleType, string>
		{
			{
				EFlagChallengeUiStyleType.Green,
				"#040811"
			},
			{
				EFlagChallengeUiStyleType.Yellow,
				"#090709"
			},
			{
				EFlagChallengeUiStyleType.Red,
				"#0A0510"
			},
			{
				EFlagChallengeUiStyleType.Hidden,
				"#0A0510"
			}
		};

		// Token: 0x0401E8AF RID: 125103
		private readonly Dictionary<EFlagChallengeUiStyleType, string> centerBgColor = new Dictionary<EFlagChallengeUiStyleType, string>
		{
			{
				EFlagChallengeUiStyleType.Green,
				"#6AD6ED"
			},
			{
				EFlagChallengeUiStyleType.Yellow,
				"#E2B083"
			},
			{
				EFlagChallengeUiStyleType.Red,
				"#FF83E9"
			},
			{
				EFlagChallengeUiStyleType.Hidden,
				"#FF83E9"
			}
		};

		// Token: 0x0401E8B0 RID: 125104
		private readonly Dictionary<EFlagChallengeUiStyleType, string> gridColor = new Dictionary<EFlagChallengeUiStyleType, string>
		{
			{
				EFlagChallengeUiStyleType.Green,
				"#DAE6FE"
			},
			{
				EFlagChallengeUiStyleType.Yellow,
				"#FEF9DA"
			},
			{
				EFlagChallengeUiStyleType.Red,
				"#FEDAF9"
			},
			{
				EFlagChallengeUiStyleType.Hidden,
				"#FEDAF9"
			}
		};

		// Token: 0x0401E8B1 RID: 125105
		[TupleElementNames(new string[]
		{
			"Left",
			"Top"
		})]
		[Nullable(new byte[]
		{
			1,
			0
		})]
		private readonly Dictionary<int, ValueTuple<int, int>> frameBgStretch = new Dictionary<int, ValueTuple<int, int>>
		{
			{
				1,
				new ValueTuple<int, int>(-38, -16)
			},
			{
				2,
				new ValueTuple<int, int>(-14, -8)
			},
			{
				3,
				new ValueTuple<int, int>(-14, -26)
			},
			{
				4,
				new ValueTuple<int, int>(-50, -90)
			},
			{
				5,
				new ValueTuple<int, int>(-57, -43)
			}
		};
	}
}
