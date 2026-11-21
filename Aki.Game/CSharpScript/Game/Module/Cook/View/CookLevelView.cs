using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Cook.View
{
	// Token: 0x02004AF8 RID: 19192
	[NullableContext(1)]
	[Nullable(0)]
	public class CookLevelView : UiViewBase
	{
		// Token: 0x0602FFEA RID: 196586 RVA: 0x00D63468 File Offset: 0x00D61668
		public CookLevelView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602FFEB RID: 196587 RVA: 0x00D63498 File Offset: 0x00D61698
		protected unsafe override void OnRegisterComponent()
		{
			int num = 13;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(delegate()
			{
				this.OnLeft();
			}));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(delegate()
			{
				this.OnRight();
			}));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602FFEC RID: 196588 RVA: 0x00D636D1 File Offset: 0x00D618D1
		protected override void OnBeforeDestroy()
		{
			this.DisableRedDot();
			if (this.RewardItemLayout != null)
			{
				this.RewardItemLayout.ClearChildren();
				this.RewardItemLayout = null;
			}
			this.StarLayout.ClearChildren();
		}

		// Token: 0x0602FFED RID: 196589 RVA: 0x00D63700 File Offset: 0x00D61900
		protected override UniTask OnBeforeStartAsync()
		{
			CookLevelView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CookLevelView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FFEE RID: 196590 RVA: 0x00D63744 File Offset: 0x00D61944
		protected override void OnStart()
		{
			this.RewardItemLayout = new GenericLayout<LevelRewardItem, IRewardData>(base.GetHorizontalLayout(7), this.InitReward, null, false, true);
			this.TmpRewardItem = new List<IRewardData>();
			LguiUtil.Instance.SetLocalText(base.GetText(12), "CookUpgradeButtonText", Array.Empty<object>());
			this.StarLayout = new GenericLayoutNew<StarItem>(base.GetHorizontalLayout(11), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<StarItem>(this.OnCreateStarProxy), null);
			CookModel.Instance.CurrentCookViewType = ECookDataType.CookLevel;
			CookModel.Instance.SelectedCookerLevel = CookModel.Instance.GetCookerInfo().CookingLevel;
			this.Refresh();
			this.OnShowRedDot();
		}

		// Token: 0x0602FFEF RID: 196591 RVA: 0x00D637E3 File Offset: 0x00D619E3
		protected override void OnBeforeShow()
		{
			IUiPopFrameInterface childPopView = this.ChildPopView;
			if (childPopView != null)
			{
				CommonPopViewBase popItem = childPopView.PopItem;
				if (popItem != null)
				{
					popItem.SetTexBgVisible(false);
				}
			}
			this.RefreshConfirmButton();
		}

		// Token: 0x0602FFF0 RID: 196592 RVA: 0x00D63808 File Offset: 0x00D61A08
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private ILayoutItem<StarItem> OnCreateStarProxy([Nullable(2)] object data, UUIItem uiItem, int index)
		{
			if (data is bool)
			{
				bool state = (bool)data;
				StarItem starItem = new StarItem();
				starItem.CreateThenShowByActor(uiItem.GetOwner(), null);
				starItem.SetState(state);
				return new LayoutItem<StarItem>
				{
					Key = index,
					Value = starItem
				};
			}
			return null;
		}

		// Token: 0x0602FFF1 RID: 196593 RVA: 0x00D6385A File Offset: 0x00D61A5A
		private void OnShowRedDot()
		{
			RedDotController.Instance.BindRedDot(ERedDotName.CookerLevelMain, this.ConfirmItem.GetRedDot(), null, 0);
		}

		// Token: 0x0602FFF2 RID: 196594 RVA: 0x00D63875 File Offset: 0x00D61A75
		public void DisableRedDot()
		{
			RedDotController.Instance.UnBindRedDot(ERedDotName.CookerLevelMain);
		}

		// Token: 0x0602FFF3 RID: 196595 RVA: 0x00D63883 File Offset: 0x00D61A83
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.UpgradeCookerLevel, new Action(this.ShowRewardView));
		}

		// Token: 0x0602FFF4 RID: 196596 RVA: 0x00D638A1 File Offset: 0x00D61AA1
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.UpgradeCookerLevel, new Action(this.ShowRewardView));
		}

		// Token: 0x0602FFF5 RID: 196597 RVA: 0x00D638BF File Offset: 0x00D61ABF
		public void ShowView()
		{
			this.SetActive(true);
		}

		// Token: 0x0602FFF6 RID: 196598 RVA: 0x00D638C8 File Offset: 0x00D61AC8
		private void Update()
		{
			CookModel.Instance.SelectedCookerLevel = CookModel.Instance.GetCookerInfo().CookingLevel;
			this.Refresh();
		}

		// Token: 0x0602FFF7 RID: 196599 RVA: 0x00D638E9 File Offset: 0x00D61AE9
		private void ShowRewardView()
		{
			if (this.TmpRewardItem.Count == 0)
			{
				return;
			}
			this.Update();
		}

		// Token: 0x0602FFF8 RID: 196600 RVA: 0x00D638FF File Offset: 0x00D61AFF
		private void Refresh()
		{
			this.RefreshTypeIconTexture();
			this.RefreshName();
			this.RefreshInfo();
			this.RefreshLevel();
			this.RefreshSumExp();
			this.RefreshExpBarSprite();
			this.RefreshConfirmButton();
			this.RefreshRewardList();
			this.RefreshLeftAndRightButtonEnable();
			this.RefreshRewardItem();
		}

		// Token: 0x0602FFF9 RID: 196601 RVA: 0x00D63940 File Offset: 0x00D61B40
		private void RefreshTypeIconTexture()
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_CookingType");
			base.SetTextureByPath(resourcePath, base.GetTexture(9), null, null);
		}

		// Token: 0x0602FFFA RID: 196602 RVA: 0x00D63978 File Offset: 0x00D61B78
		private void RefreshName()
		{
			CookLevel cookLevelByLevel = CookModel.Instance.GetCookLevelByLevel(CookModel.Instance.SelectedCookerLevel);
			string localText = CookConfig.Instance.GetLocalText(cookLevelByLevel.Name);
			base.GetText(0).SetText(localText, true);
		}

		// Token: 0x0602FFFB RID: 196603 RVA: 0x00D639BC File Offset: 0x00D61BBC
		private void RefreshInfo()
		{
			CookLevel cookLevelByLevel = CookModel.Instance.GetCookLevelByLevel(CookModel.Instance.SelectedCookerLevel);
			string localText = CookConfig.Instance.GetLocalText(cookLevelByLevel.AttributesDescription);
			base.GetText(1).SetText(localText, true);
		}

		// Token: 0x0602FFFC RID: 196604 RVA: 0x00D63A00 File Offset: 0x00D61C00
		private void RefreshLevel()
		{
			int cookerMaxLevel = CookModel.Instance.GetCookerMaxLevel();
			List<bool> list = new List<bool>(cookerMaxLevel);
			for (int i = 0; i < CookModel.Instance.SelectedCookerLevel; i++)
			{
				list.Add(true);
			}
			for (int j = CookModel.Instance.SelectedCookerLevel; j < cookerMaxLevel; j++)
			{
				list.Add(false);
			}
			this.StarLayout.RebuildLayoutByDataNew<bool>(list, null);
		}

		// Token: 0x0602FFFD RID: 196605 RVA: 0x00D63A70 File Offset: 0x00D61C70
		private void RefreshSumExp()
		{
			int totalProficiencys = CookModel.Instance.GetCookerInfo().TotalProficiencys;
			string newText;
			if (CookModel.Instance.SelectedCookerLevel == CookModel.Instance.GetCookerMaxLevel())
			{
				newText = "MAX";
			}
			else
			{
				int sumExpByLevel = CookModel.Instance.GetSumExpByLevel(CookModel.Instance.SelectedCookerLevel);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(totalProficiencys);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(sumExpByLevel);
				newText = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			base.GetText(2).SetText(newText, true);
		}

		// Token: 0x0602FFFE RID: 196606 RVA: 0x00D63B04 File Offset: 0x00D61D04
		private void RefreshExpBarSprite()
		{
			int totalProficiencys = CookModel.Instance.GetCookerInfo().TotalProficiencys;
			int sumExpByLevel = CookModel.Instance.GetSumExpByLevel(CookModel.Instance.SelectedCookerLevel);
			double num = MathUtils.Instance.GetFloatPointFloor((double)totalProficiencys / (double)sumExpByLevel, 3);
			num = ((num > 1.0) ? 1.0 : num);
			base.GetSprite(3).SetFillAmount((float)num);
		}

		// Token: 0x0602FFFF RID: 196607 RVA: 0x00D63B6E File Offset: 0x00D61D6E
		private void RefreshConfirmButton()
		{
			this.ConfirmItem.SetEnable();
		}

		// Token: 0x06030000 RID: 196608 RVA: 0x00D63B7C File Offset: 0x00D61D7C
		private void RefreshRewardList()
		{
			this.TmpRewardItem.Clear();
			int dropIdByLevel = CookModel.Instance.GetDropIdByLevel(CookModel.Instance.SelectedCookerLevel);
			if (dropIdByLevel == -1)
			{
				base.GetItem(8).SetUIActive(false);
				return;
			}
			base.GetItem(8).SetUIActive(true);
			DropPackage? dropPackage = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(dropIdByLevel);
			if (dropPackage != null)
			{
				for (int i = 0; i < dropPackage.Value.DropPreviewLength; i++)
				{
					DicIntInt? dicIntInt = dropPackage.Value.DropPreview(i);
					if (dicIntInt != null)
					{
						int selectedCookerLevel = CookModel.Instance.SelectedCookerLevel;
						int cookingLevel = CookModel.Instance.GetCookerInfo().CookingLevel;
						this.TmpRewardItem.Add(new RewardData
						{
							RewardId = dicIntInt.Value.Key,
							Count = dicIntInt.Value.Value,
							IsGet = (selectedCookerLevel < cookingLevel)
						});
					}
				}
			}
			this.RewardItemLayout.RefreshByData(this.TmpRewardItem, null, false);
		}

		// Token: 0x06030001 RID: 196609 RVA: 0x00D63C94 File Offset: 0x00D61E94
		private void RefreshLeftAndRightButtonEnable()
		{
			((base.GetButton(5).GetOwner() as AUIBaseActor).GetComponentByClass(UUIItem.StaticClass()) as UUIItem).SetUIActive(CookModel.Instance.SelectedCookerLevel != 1);
			((base.GetButton(6).GetOwner() as AUIBaseActor).GetComponentByClass(UUIItem.StaticClass()) as UUIItem).SetUIActive(CookModel.Instance.SelectedCookerLevel != CookModel.Instance.GetCookerMaxLevel());
		}

		// Token: 0x06030002 RID: 196610 RVA: 0x00D63D1E File Offset: 0x00D61F1E
		private void RefreshRewardItem()
		{
			base.GetItem(10).SetUIActive(CookModel.Instance.SelectedCookerLevel != CookModel.Instance.GetCookerMaxLevel());
		}

		// Token: 0x06030003 RID: 196611 RVA: 0x00D63D46 File Offset: 0x00D61F46
		private void OnClick()
		{
			CookController.Instance.SendCertificateLevelRewardRequest();
		}

		// Token: 0x06030004 RID: 196612 RVA: 0x00D63D52 File Offset: 0x00D61F52
		private void OnLeft()
		{
			CookModel.Instance.SelectedCookerLevel--;
			this.Refresh();
		}

		// Token: 0x06030005 RID: 196613 RVA: 0x00D63D6C File Offset: 0x00D61F6C
		private void OnRight()
		{
			CookModel.Instance.SelectedCookerLevel++;
			this.Refresh();
		}

		// Token: 0x0401976C RID: 104300
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<LevelRewardItem, IRewardData> RewardItemLayout;

		// Token: 0x0401976D RID: 104301
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IRewardData> TmpRewardItem;

		// Token: 0x0401976E RID: 104302
		[Nullable(2)]
		private ConfirmItem ConfirmItem;

		// Token: 0x0401976F RID: 104303
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutNew<StarItem> StarLayout;

		// Token: 0x04019770 RID: 104304
		private readonly Func<LevelRewardItem> InitReward = () => new LevelRewardItem();

		// Token: 0x0200A75A RID: 42842
		[NullableContext(0)]
		public enum ECookLevelDefine
		{
			// Token: 0x04033B5B RID: 211803
			NameText,
			// Token: 0x04033B5C RID: 211804
			InfoText,
			// Token: 0x04033B5D RID: 211805
			SumExpText,
			// Token: 0x04033B5E RID: 211806
			ExpBarSprite,
			// Token: 0x04033B5F RID: 211807
			ConfirmItem,
			// Token: 0x04033B60 RID: 211808
			LeftButton,
			// Token: 0x04033B61 RID: 211809
			RightButton,
			// Token: 0x04033B62 RID: 211810
			RewardItemHorizontalLayout,
			// Token: 0x04033B63 RID: 211811
			RewardLayoutItem,
			// Token: 0x04033B64 RID: 211812
			TypeIconTexture,
			// Token: 0x04033B65 RID: 211813
			RewardItem,
			// Token: 0x04033B66 RID: 211814
			PnlStar,
			// Token: 0x04033B67 RID: 211815
			TxtConfirm
		}
	}
}
