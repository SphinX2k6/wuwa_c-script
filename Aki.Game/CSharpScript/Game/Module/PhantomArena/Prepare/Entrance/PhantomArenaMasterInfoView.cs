using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AutoAttach;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02004148 RID: 16712
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaMasterInfoView : UiViewBase
	{
		// Token: 0x0602A446 RID: 173126 RVA: 0x00BEF404 File Offset: 0x00BED604
		public PhantomArenaMasterInfoView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602A447 RID: 173127 RVA: 0x00BEF414 File Offset: 0x00BED614
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUITexture)),
				new ValueTuple<int, Type>(4, typeof(UUITexture)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(13, typeof(UUIItem)),
				new ValueTuple<int, Type>(14, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(12, new Action(this.OnClickTake))
			};
		}

		// Token: 0x0602A448 RID: 173128 RVA: 0x00BEF5A0 File Offset: 0x00BED7A0
		protected override void OnStart()
		{
			this.ActivityId = (int)this.OpenParam;
			this.CaptionItem = new PopupCaptionItem(base.GetItem(13));
			this.CaptionItem.SetHelpCallBack(new Action(this.OnClickHelp));
			this.CaptionItem.SetCloseCallBack(new Action(this.OnClickClose));
			this.LevelAttachView = new NoCircleAttachView<MasterLevelData, MasterLevelItem>(base.GetItem(0).GetOwner(), false);
			UUIItem item = base.GetItem(1);
			item.SetUIActive(false);
			this.LevelAttachView.CreateItems(item.GetOwner(), 0f, new Func<AActor, int, int, MasterLevelItem>(this.CreateLevelItem), EAttachDirection.Horizontal);
			this.RewardLayout = new GenericLayout<CommonItemSmallItemGrid, TItem>(base.GetHorizontalLayout(8), new Func<CommonItemSmallItemGrid>(this.CreateRewardItem), null, false, true);
			this.ScrollDesc = new GenericScrollViewNew<MasterLevelDescItem, MasterLevelDescData>(base.GetScrollViewWithScrollbar(6), new Func<MasterLevelDescItem>(this.CreateDescItem), null, false, null);
		}

		// Token: 0x0602A449 RID: 173129 RVA: 0x00BEF68C File Offset: 0x00BED88C
		protected override UniTask OnCreateAsync()
		{
			PhantomArenaMasterInfoView.<OnCreateAsync>d__10 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<PhantomArenaMasterInfoView.<OnCreateAsync>d__10>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A44A RID: 173130 RVA: 0x00BEF6C7 File Offset: 0x00BED8C7
		private MasterLevelItem CreateLevelItem(AActor actor, int index, int showNum)
		{
			MasterLevelItem masterLevelItem = new MasterLevelItem();
			masterLevelItem.CreateThenShowByActor(actor, null);
			masterLevelItem.CallbackOnSelect = new Action<int, MasterLevelItem>(this.OnSelectLevel);
			masterLevelItem.ActivityId = this.ActivityId;
			return masterLevelItem;
		}

		// Token: 0x0602A44B RID: 173131 RVA: 0x00BEF6F4 File Offset: 0x00BED8F4
		private CommonItemSmallItemGrid CreateRewardItem()
		{
			return new CommonItemSmallItemGrid
			{
				ShowReceivedCallBack = new Func<TItem, bool>(this.OnCheckItemTaken)
			};
		}

		// Token: 0x0602A44C RID: 173132 RVA: 0x00BEF70D File Offset: 0x00BED90D
		private MasterLevelDescItem CreateDescItem()
		{
			return new MasterLevelDescItem();
		}

		// Token: 0x0602A44D RID: 173133 RVA: 0x00BEF714 File Offset: 0x00BED914
		protected override void OnBeforeShow()
		{
			this.RefreshLevelView(new bool?(true));
			this.RefreshTitle();
			this.RefreshReward();
		}

		// Token: 0x0602A44E RID: 173134 RVA: 0x00BEF72E File Offset: 0x00BED92E
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnPhantomArenaMasterInfoUpdate, new Action(this.OnMasterInfoUpdate));
		}

		// Token: 0x0602A44F RID: 173135 RVA: 0x00BEF74C File Offset: 0x00BED94C
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaMasterInfoUpdate, new Action(this.OnMasterInfoUpdate));
		}

		// Token: 0x0602A450 RID: 173136 RVA: 0x00BEF76C File Offset: 0x00BED96C
		private void RefreshAll()
		{
			this.RefreshLevelView(null);
			this.RefreshTitle();
			this.RefreshDesc();
			this.RefreshReward();
		}

		// Token: 0x0602A451 RID: 173137 RVA: 0x00BEF79C File Offset: 0x00BED99C
		private void RefreshLevelView(bool? isInit = null)
		{
			List<MasterLevelData> masterLevelData = PhantomArenaModel.Instance.GetMasterLevelData(this.ActivityId);
			int masterLevel = PhantomArenaModel.Instance.GetMasterLevel(this.ActivityId);
			if (isInit.GetValueOrDefault())
			{
				this.LevelAttachView.ReloadView(masterLevelData.Count, masterLevelData.ToArray(), 0);
				this.LevelAttachView.AttachToIndex(masterLevel - 1, true);
				return;
			}
			foreach (MasterLevelItem masterLevelItem in this.LevelAttachView.GetItems())
			{
				masterLevelItem.SetData(masterLevelData.ToArray());
				masterLevelItem.RefreshItem();
			}
		}

		// Token: 0x0602A452 RID: 173138 RVA: 0x00BEF850 File Offset: 0x00BEDA50
		private void RefreshTitle()
		{
			PhantomArenaModel instance = PhantomArenaModel.Instance;
			int masterLevel = instance.GetMasterLevel(this.ActivityId);
			PhantomBattleMasterLevel? masterLevelConfig = instance.GetMasterLevelConfig(masterLevel, this.ActivityId);
			if (masterLevelConfig == null)
			{
				return;
			}
			int titleId = masterLevelConfig.Value.TitleId;
			PhantomBattleMasterTitle phantomBattleMasterTitleById = PhantomArenaConfig.Instance.GetPhantomBattleMasterTitleById(titleId);
			base.SetTextureByPath(phantomBattleMasterTitleById.Icon, base.GetTexture(3), null, null);
			base.SetTextureByPath(phantomBattleMasterTitleById.IconBg, base.GetTexture(4), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), phantomBattleMasterTitleById.Name, Array.Empty<object>());
			string text = instance.GetMasterExpNextNeed(this.ActivityId).ToString();
			string text2 = instance.GetMasterExpNow(this.ActivityId, null).ToString();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "TowerDefence_LV", new <>z__ReadOnlyArray<object>(new object[]
			{
				text2,
				text
			}));
		}

		// Token: 0x0602A453 RID: 173139 RVA: 0x00BEF964 File Offset: 0x00BEDB64
		private void RefreshDesc()
		{
			List<MasterLevelDescData> masterLevelDescData = PhantomArenaModel.Instance.GetMasterLevelDescData(this.SelectLevel, this.ActivityId);
			GenericScrollViewNew<MasterLevelDescItem, MasterLevelDescData> scrollDesc = this.ScrollDesc;
			if (scrollDesc == null)
			{
				return;
			}
			scrollDesc.RefreshByData(masterLevelDescData, null, false);
		}

		// Token: 0x0602A454 RID: 173140 RVA: 0x00BEF99C File Offset: 0x00BEDB9C
		private void RefreshReward()
		{
			List<TItem> masterLevelRewardList = PhantomArenaModel.Instance.GetMasterLevelRewardList(this.SelectLevel, this.ActivityId);
			this.RewardLayout.RefreshByData(masterLevelRewardList, null, false);
			bool flag = masterLevelRewardList.Count == 0;
			bool masterLevelRewardIfTaken = PhantomArenaModel.Instance.GetMasterLevelRewardIfTaken(this.SelectLevel, this.ActivityId);
			bool masterLevelRewardCanTake = PhantomArenaModel.Instance.GetMasterLevelRewardCanTake(this.SelectLevel, this.ActivityId);
			base.GetItem(10).SetUIActive(masterLevelRewardIfTaken && !flag);
			base.GetItem(11).SetUIActive(!masterLevelRewardIfTaken && !masterLevelRewardCanTake && !flag);
			base.SetButtonUiActive(12, !masterLevelRewardIfTaken && masterLevelRewardCanTake && !flag);
			base.GetItem(14).SetUIActive(!flag);
		}

		// Token: 0x0602A455 RID: 173141 RVA: 0x00BEFA60 File Offset: 0x00BEDC60
		private void OnClickTake()
		{
			List<MasterLevelData> masterLevelData = PhantomArenaModel.Instance.GetMasterLevelData(this.ActivityId);
			List<int> list = new List<int>();
			foreach (MasterLevelData masterLevelData2 in masterLevelData)
			{
				if (PhantomArenaModel.Instance.GetMasterLevelRewardCanTake(masterLevelData2.Level, this.ActivityId))
				{
					list.Add(masterLevelData2.Level);
				}
			}
			int[] array = new int[list.Count];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = list[i];
			}
			if (array.Length != 0)
			{
				PhantomArenaController.Instance.MasterLevelMultiRewardRequest(array, this.ActivityId);
			}
		}

		// Token: 0x0602A456 RID: 173142 RVA: 0x00BEFB20 File Offset: 0x00BEDD20
		private void OnSelectLevel(int level, MasterLevelItem levelItem)
		{
			if (this.SelectLevel == level)
			{
				return;
			}
			this.SelectLevel = level;
			if (this.LevelAttachView.GetCurrentSelectIndex() != level - 1)
			{
				this.LevelAttachView.AttachToIndex(level - 1, false);
			}
			this.OnSelectedLevelChange();
		}

		// Token: 0x0602A457 RID: 173143 RVA: 0x00BEFB58 File Offset: 0x00BEDD58
		private void OnSelectedLevelChange()
		{
			this.RefreshAll();
		}

		// Token: 0x0602A458 RID: 173144 RVA: 0x00BEFB60 File Offset: 0x00BEDD60
		private void OnMasterInfoUpdate()
		{
			this.RefreshAll();
		}

		// Token: 0x0602A459 RID: 173145 RVA: 0x00BEFB68 File Offset: 0x00BEDD68
		private void OnClickHelp()
		{
			HelpController.Instance.OpenHelpById(341);
		}

		// Token: 0x0602A45A RID: 173146 RVA: 0x00BEFB79 File Offset: 0x00BEDD79
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602A45B RID: 173147 RVA: 0x00BEFB82 File Offset: 0x00BEDD82
		private bool OnCheckItemTaken(TItem item)
		{
			return PhantomArenaModel.Instance.GetMasterLevelRewardIfTaken(this.SelectLevel, this.ActivityId);
		}

		// Token: 0x04016FDF RID: 94175
		protected int ActivityId;

		// Token: 0x04016FE0 RID: 94176
		private int SelectLevel = -1;

		// Token: 0x04016FE1 RID: 94177
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private NoCircleAttachView<MasterLevelData, MasterLevelItem> LevelAttachView;

		// Token: 0x04016FE2 RID: 94178
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04016FE3 RID: 94179
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

		// Token: 0x04016FE4 RID: 94180
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<MasterLevelDescItem, MasterLevelDescData> ScrollDesc;

		// Token: 0x02009D22 RID: 40226
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04030DB5 RID: 200117
			public const int PanelLevel = 0;

			// Token: 0x04030DB6 RID: 200118
			public const int ItemLevel = 1;

			// Token: 0x04030DB7 RID: 200119
			public const int TextExp = 2;

			// Token: 0x04030DB8 RID: 200120
			public const int IconTitle = 3;

			// Token: 0x04030DB9 RID: 200121
			public const int IconTitleBg = 4;

			// Token: 0x04030DBA RID: 200122
			public const int TextTitle = 5;

			// Token: 0x04030DBB RID: 200123
			public const int ScrollDesc = 6;

			// Token: 0x04030DBC RID: 200124
			public const int ItemDesc = 7;

			// Token: 0x04030DBD RID: 200125
			public const int LayoutReward = 8;

			// Token: 0x04030DBE RID: 200126
			public const int ItemReward = 9;

			// Token: 0x04030DBF RID: 200127
			public const int PanelTaken = 10;

			// Token: 0x04030DC0 RID: 200128
			public const int PanelPending = 11;

			// Token: 0x04030DC1 RID: 200129
			public const int BtnTake = 12;

			// Token: 0x04030DC2 RID: 200130
			public const int ItemCaption = 13;

			// Token: 0x04030DC3 RID: 200131
			public const int PanelReward = 14;
		}
	}
}
