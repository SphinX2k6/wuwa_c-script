using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02005178 RID: 20856
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaMasterInfoView : UiViewBase
	{
		// Token: 0x0603554A RID: 218442 RVA: 0x00CA1E88 File Offset: 0x00CA0088
		public PhantomArenaMasterInfoView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603554B RID: 218443 RVA: 0x00CA1E98 File Offset: 0x00CA0098
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

		// Token: 0x0603554C RID: 218444 RVA: 0x00CA2024 File Offset: 0x00CA0224
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

		// Token: 0x0603554D RID: 218445 RVA: 0x00CA2110 File Offset: 0x00CA0310
		protected override UniTask OnCreateAsync()
		{
			PhantomArenaMasterInfoView.<OnCreateAsync>d__10 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<PhantomArenaMasterInfoView.<OnCreateAsync>d__10>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603554E RID: 218446 RVA: 0x00CA214B File Offset: 0x00CA034B
		private MasterLevelItem CreateLevelItem(AActor actor, int index, int showNum)
		{
			MasterLevelItem masterLevelItem = new MasterLevelItem();
			masterLevelItem.CreateThenShowByActor(actor, null);
			masterLevelItem.CallbackOnSelect = new Action<int, MasterLevelItem>(this.OnSelectLevel);
			masterLevelItem.ActivityId = this.ActivityId;
			return masterLevelItem;
		}

		// Token: 0x0603554F RID: 218447 RVA: 0x00CA2178 File Offset: 0x00CA0378
		private CommonItemSmallItemGrid CreateRewardItem()
		{
			return new CommonItemSmallItemGrid
			{
				ShowReceivedCallBack = new Func<TItem, bool>(this.OnCheckItemTaken)
			};
		}

		// Token: 0x06035550 RID: 218448 RVA: 0x00CA2191 File Offset: 0x00CA0391
		private MasterLevelDescItem CreateDescItem()
		{
			return new MasterLevelDescItem();
		}

		// Token: 0x06035551 RID: 218449 RVA: 0x00CA2198 File Offset: 0x00CA0398
		protected override void OnBeforeShow()
		{
			this.RefreshLevelView(new bool?(true));
			this.RefreshTitle();
			this.RefreshReward();
		}

		// Token: 0x06035552 RID: 218450 RVA: 0x00CA21B2 File Offset: 0x00CA03B2
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnPhantomArenaMasterInfoUpdate, new Action(this.OnMasterInfoUpdate));
		}

		// Token: 0x06035553 RID: 218451 RVA: 0x00CA21D0 File Offset: 0x00CA03D0
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaMasterInfoUpdate, new Action(this.OnMasterInfoUpdate));
		}

		// Token: 0x06035554 RID: 218452 RVA: 0x00CA21F0 File Offset: 0x00CA03F0
		private void RefreshAll()
		{
			this.RefreshLevelView(null);
			this.RefreshTitle();
			this.RefreshDesc();
			this.RefreshReward();
		}

		// Token: 0x06035555 RID: 218453 RVA: 0x00CA2220 File Offset: 0x00CA0420
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

		// Token: 0x06035556 RID: 218454 RVA: 0x00CA22D4 File Offset: 0x00CA04D4
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

		// Token: 0x06035557 RID: 218455 RVA: 0x00CA23E8 File Offset: 0x00CA05E8
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

		// Token: 0x06035558 RID: 218456 RVA: 0x00CA2420 File Offset: 0x00CA0620
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

		// Token: 0x06035559 RID: 218457 RVA: 0x00CA24E4 File Offset: 0x00CA06E4
		private void OnClickTake()
		{
			int[] array = (from item in PhantomArenaModel.Instance.GetMasterLevelData(this.ActivityId)
			where PhantomArenaModel.Instance.GetMasterLevelRewardCanTake(item.Level, this.ActivityId)
			select item.Level).ToArray<int>();
			if (array.Length != 0)
			{
				PhantomArenaController.Instance.MasterLevelMultiRewardRequest(array, this.ActivityId);
			}
		}

		// Token: 0x0603555A RID: 218458 RVA: 0x00CA2551 File Offset: 0x00CA0751
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

		// Token: 0x0603555B RID: 218459 RVA: 0x00CA2589 File Offset: 0x00CA0789
		private void OnSelectedLevelChange()
		{
			this.RefreshAll();
		}

		// Token: 0x0603555C RID: 218460 RVA: 0x00CA2591 File Offset: 0x00CA0791
		private void OnMasterInfoUpdate()
		{
			this.RefreshAll();
		}

		// Token: 0x0603555D RID: 218461 RVA: 0x00CA2599 File Offset: 0x00CA0799
		private void OnClickHelp()
		{
			HelpController.Instance.OpenHelpById(341);
		}

		// Token: 0x0603555E RID: 218462 RVA: 0x00CA25AA File Offset: 0x00CA07AA
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603555F RID: 218463 RVA: 0x00CA25B3 File Offset: 0x00CA07B3
		private bool OnCheckItemTaken(TItem item)
		{
			return PhantomArenaModel.Instance.GetMasterLevelRewardIfTaken(this.SelectLevel, this.ActivityId);
		}

		// Token: 0x0401C5AA RID: 116138
		protected int ActivityId;

		// Token: 0x0401C5AB RID: 116139
		private int SelectLevel = -1;

		// Token: 0x0401C5AC RID: 116140
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private NoCircleAttachView<MasterLevelData, MasterLevelItem> LevelAttachView;

		// Token: 0x0401C5AD RID: 116141
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401C5AE RID: 116142
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

		// Token: 0x0401C5AF RID: 116143
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<MasterLevelDescItem, MasterLevelDescData> ScrollDesc;

		// Token: 0x0200B2E8 RID: 45800
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403635E RID: 222046
			public const int PanelLevel = 0;

			// Token: 0x0403635F RID: 222047
			public const int ItemLevel = 1;

			// Token: 0x04036360 RID: 222048
			public const int TextExp = 2;

			// Token: 0x04036361 RID: 222049
			public const int IconTitle = 3;

			// Token: 0x04036362 RID: 222050
			public const int IconTitleBg = 4;

			// Token: 0x04036363 RID: 222051
			public const int TextTitle = 5;

			// Token: 0x04036364 RID: 222052
			public const int ScrollDesc = 6;

			// Token: 0x04036365 RID: 222053
			public const int ItemDesc = 7;

			// Token: 0x04036366 RID: 222054
			public const int LayoutReward = 8;

			// Token: 0x04036367 RID: 222055
			public const int ItemReward = 9;

			// Token: 0x04036368 RID: 222056
			public const int PanelTaken = 10;

			// Token: 0x04036369 RID: 222057
			public const int PanelPending = 11;

			// Token: 0x0403636A RID: 222058
			public const int BtnTake = 12;

			// Token: 0x0403636B RID: 222059
			public const int ItemCaption = 13;

			// Token: 0x0403636C RID: 222060
			public const int PanelReward = 14;
		}
	}
}
