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
	// Token: 0x02004A22 RID: 18978
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeAreaDetailView : UiViewBase
	{
		// Token: 0x17005FC1 RID: 24513
		// (get) Token: 0x0602F905 RID: 194821 RVA: 0x00D43911 File Offset: 0x00D41B11
		[Nullable(2)]
		public new FlagChallengeAreaDetailViewParams OpenParam
		{
			[NullableContext(2)]
			get
			{
				return this.OpenParam as FlagChallengeAreaDetailViewParams;
			}
		}

		// Token: 0x0602F906 RID: 194822 RVA: 0x00D43920 File Offset: 0x00D41B20
		public FlagChallengeAreaDetailView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602F907 RID: 194823 RVA: 0x00D43A64 File Offset: 0x00D41C64
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

		// Token: 0x0602F908 RID: 194824 RVA: 0x00D43D68 File Offset: 0x00D41F68
		protected override UniTask OnBeforeStartAsync()
		{
			FlagChallengeAreaDetailView.<OnBeforeStartAsync>d__22 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FlagChallengeAreaDetailView.<OnBeforeStartAsync>d__22>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602F909 RID: 194825 RVA: 0x00D43DAC File Offset: 0x00D41FAC
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

		// Token: 0x0602F90A RID: 194826 RVA: 0x00D43EF0 File Offset: 0x00D420F0
		protected override void OnBeforeDestroy()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotFlagChallengeActivityReward, base.GetItem(26), this.ActivityId);
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotFlagChallengeActivityBuffNewlyUnlocked, base.GetItem(27), this.ActivityId);
		}

		// Token: 0x0602F90B RID: 194827 RVA: 0x00D43F2C File Offset: 0x00D4212C
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

		// Token: 0x0602F90C RID: 194828 RVA: 0x00D43FA0 File Offset: 0x00D421A0
		private UniTask InitStrongholdViewAsync()
		{
			FlagChallengeAreaDetailView.<InitStrongholdViewAsync>d__26 <InitStrongholdViewAsync>d__;
			<InitStrongholdViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitStrongholdViewAsync>d__.<>4__this = this;
			<InitStrongholdViewAsync>d__.<>1__state = -1;
			<InitStrongholdViewAsync>d__.<>t__builder.Start<FlagChallengeAreaDetailView.<InitStrongholdViewAsync>d__26>(ref <InitStrongholdViewAsync>d__);
			return <InitStrongholdViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602F90D RID: 194829 RVA: 0x00D43FE4 File Offset: 0x00D421E4
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

		// Token: 0x0602F90E RID: 194830 RVA: 0x00D4403E File Offset: 0x00D4223E
		private void RefreshTaskView()
		{
			UUIText text = base.GetText(25);
			if (text == null)
			{
				return;
			}
			text.SetText(this.Data.GetTaskProgressText(), true);
		}

		// Token: 0x0602F90F RID: 194831 RVA: 0x00D44060 File Offset: 0x00D42260
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

		// Token: 0x0602F910 RID: 194832 RVA: 0x00D440F4 File Offset: 0x00D422F4
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

		// Token: 0x0602F911 RID: 194833 RVA: 0x00D44128 File Offset: 0x00D42328
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

		// Token: 0x0602F912 RID: 194834 RVA: 0x00D44174 File Offset: 0x00D42374
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

		// Token: 0x0602F913 RID: 194835 RVA: 0x00D441F8 File Offset: 0x00D423F8
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

		// Token: 0x0602F914 RID: 194836 RVA: 0x00D44243 File Offset: 0x00D42443
		private FlagChallengeAreaPageDotItem CreatePageDotItem()
		{
			return new FlagChallengeAreaPageDotItem();
		}

		// Token: 0x0602F915 RID: 194837 RVA: 0x00D4424A File Offset: 0x00D4244A
		private void OnCloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602F916 RID: 194838 RVA: 0x00D44254 File Offset: 0x00D42454
		private void OnHelpClick()
		{
			int areaDetailViewHelpId = FlagChallengeConfig.Instance.GetAreaDetailViewHelpId();
			HelpController.Instance.OpenHelpById(areaDetailViewHelpId);
		}

		// Token: 0x0602F917 RID: 194839 RVA: 0x00D44278 File Offset: 0x00D42478
		private void OnBuffButtonClick()
		{
			FlagChallengeController.Instance.OpenFlagChallengeBuffView(this.ActivityId, null);
		}

		// Token: 0x0602F918 RID: 194840 RVA: 0x00D4429E File Offset: 0x00D4249E
		private void OnTaskButtonClick()
		{
			FlagChallengeController.Instance.OpenFlagChallengeTaskView(this.ActivityId);
		}

		// Token: 0x0602F919 RID: 194841 RVA: 0x00D442B0 File Offset: 0x00D424B0
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

		// Token: 0x0602F91A RID: 194842 RVA: 0x00D4431C File Offset: 0x00D4251C
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

		// Token: 0x0602F91B RID: 194843 RVA: 0x00D44385 File Offset: 0x00D42585
		private void OnItemSelectChangeCallback(int id)
		{
			this.RefreshStrongholdPanel(id);
		}

		// Token: 0x0602F91C RID: 194844 RVA: 0x00D44390 File Offset: 0x00D42590
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

		// Token: 0x04019347 RID: 103239
		private PopupCaptionItem CaptionItem;

		// Token: 0x04019348 RID: 103240
		private int ActivityId;

		// Token: 0x04019349 RID: 103241
		private int LevelId;

		// Token: 0x0401934A RID: 103242
		private int AreaId;

		// Token: 0x0401934B RID: 103243
		private int? SelectStrongholdId;

		// Token: 0x0401934C RID: 103244
		private FlagChallengeData Data;

		// Token: 0x0401934D RID: 103245
		private List<FlagChallengeAreaData> AreaDataList;

		// Token: 0x0401934E RID: 103246
		private FlagChallengeLevelInfoItem LevelInfoItem;

		// Token: 0x0401934F RID: 103247
		private FlagChallengeAreaStrongholdPanel StrongholdPanel;

		// Token: 0x04019350 RID: 103248
		private FlagChallengeAreaStrongholdContainer StrongholdContainer;

		// Token: 0x04019351 RID: 103249
		private readonly Dictionary<int, FlagChallengeAreaStrongholdContainer> AreaId2StrongholdContainer = new Dictionary<int, FlagChallengeAreaStrongholdContainer>();

		// Token: 0x04019352 RID: 103250
		private GenericLayout<FlagChallengeAreaPageDotItem, IFlagChallengeAreaPageDotItemData> DotLayout;

		// Token: 0x04019353 RID: 103251
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x04019354 RID: 103252
		private readonly int[] strongholdItemList = new int[]
		{
			3,
			4,
			5,
			6,
			7
		};

		// Token: 0x04019355 RID: 103253
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

		// Token: 0x04019356 RID: 103254
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

		// Token: 0x04019357 RID: 103255
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

		// Token: 0x04019358 RID: 103256
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
