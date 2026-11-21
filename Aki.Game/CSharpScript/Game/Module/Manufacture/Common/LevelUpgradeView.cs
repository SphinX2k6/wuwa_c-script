using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Manufacture.Compose;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Common
{
	// Token: 0x0200466C RID: 18028
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelUpgradeView : UiViewBase
	{
		// Token: 0x0602D55B RID: 185691 RVA: 0x00CB138C File Offset: 0x00CAF58C
		public LevelUpgradeView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602D55C RID: 185692 RVA: 0x00CB139C File Offset: 0x00CAF59C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 16;
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
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
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
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 5;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnLeft));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnRight));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(14, new Action(this.OnClickBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(15, new Action(this.OnClickBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602D55D RID: 185693 RVA: 0x00CB16A6 File Offset: 0x00CAF8A6
		protected override void OnBeforeDestroy()
		{
			if (this.RewardItemLayout != null)
			{
				this.RewardItemLayout.ClearChildren();
				this.RewardItemLayout = null;
			}
			this.StarLayout.ClearChildren();
		}

		// Token: 0x0602D55E RID: 185694 RVA: 0x00CB16CD File Offset: 0x00CAF8CD
		protected override void OnBeforeShow()
		{
			this.RefreshConfirmButton();
			IUiPopFrameInterface childPopView = this.ChildPopView;
			if (childPopView == null)
			{
				return;
			}
			CommonPopViewBase popItem = childPopView.PopItem;
			if (popItem == null)
			{
				return;
			}
			popItem.SetTexBgVisible(false);
		}

		// Token: 0x0602D55F RID: 185695 RVA: 0x00CB16F0 File Offset: 0x00CAF8F0
		protected override void OnStart()
		{
			this.RewardItemLayout = new GenericLayout<LevelRewardItem, IRewardData>(base.GetHorizontalLayout(7), new Func<LevelRewardItem>(this.InitReward), null, false, true);
			this.TmpRewardItem = new List<IRewardData>();
			LguiUtil.Instance.SetLocalText(base.GetText(12), "ComposeUpgradeButtonText", Array.Empty<object>());
			this.StarLayout = new GenericLayoutNew<StarItem>(base.GetHorizontalLayout(11), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<StarItem>(this.OnCreateStarProxy), null);
			base.GetButton(4).SetCanClickWhenDisable(true);
			EventSystem.Instance.Emit<EViewType>(EEventName.SwitchViewType, EViewType.LevelViewType);
			if (this.IsFirstShow)
			{
				this.IsFirstShow = false;
			}
			CommonManager.Instance.SetSelectedLevel(CommonManager.Instance.GetCurrentRewardLevel().Value);
			RedDotController.Instance.BindRedDot(ERedDotName.ComposeReagentProduction, base.GetItem(13), null, 0);
			this.Refresh();
		}

		// Token: 0x0602D560 RID: 185696 RVA: 0x00CB17CC File Offset: 0x00CAF9CC
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private ILayoutItem<StarItem> OnCreateStarProxy(object data, UUIItem uiItem, int index)
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

		// Token: 0x0602D561 RID: 185697 RVA: 0x00CB181E File Offset: 0x00CAFA1E
		private LevelRewardItem InitReward()
		{
			return new LevelRewardItem();
		}

		// Token: 0x0602D562 RID: 185698 RVA: 0x00CB1828 File Offset: 0x00CAFA28
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.UpgradeComposeLevel, new Action(this.ShowRewardView));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OpenView));
			EventSystem.Instance.Add(EEventName.SwitchComposeType, new Action(this.SwitchComposeType));
		}

		// Token: 0x0602D563 RID: 185699 RVA: 0x00CB1888 File Offset: 0x00CAFA88
		protected override void OnRemoveEventListener()
		{
			if (!this.IsFirstShow)
			{
				EventSystem.Instance.Remove(EEventName.UpgradeComposeLevel, new Action(this.ShowRewardView));
			}
			EventSystem.Instance.Remove(EEventName.OpenView, new Action<EUiViewName, int>(this.OpenView));
			EventSystem.Instance.Remove(EEventName.SwitchComposeType, new Action(this.SwitchComposeType));
		}

		// Token: 0x0602D564 RID: 185700 RVA: 0x00CB18ED File Offset: 0x00CAFAED
		private void ShowRewardView()
		{
			if (this.TmpRewardItem.Count == 0)
			{
				return;
			}
			this.Update();
		}

		// Token: 0x0602D565 RID: 185701 RVA: 0x00CB1903 File Offset: 0x00CAFB03
		private void OpenView(EUiViewName uiView, int viewId)
		{
			if (uiView == EUiViewName.WorldMapView)
			{
				base.CloseMe(null);
			}
		}

		// Token: 0x0602D566 RID: 185702 RVA: 0x00CB1919 File Offset: 0x00CAFB19
		private void SwitchComposeType()
		{
			base.CloseMe(null);
			if (UiManager.Instance.IsViewOpen(EUiViewName.ItemTipsView))
			{
				UiManager.Instance.CloseView(EUiViewName.ItemTipsView, null);
			}
		}

		// Token: 0x0602D567 RID: 185703 RVA: 0x00CB1944 File Offset: 0x00CAFB44
		private void Update()
		{
			CommonManager.Instance.SetSelectedLevel(CommonManager.Instance.GetCurrentRewardLevel().Value);
			this.Refresh();
		}

		// Token: 0x0602D568 RID: 185704 RVA: 0x00CB1974 File Offset: 0x00CAFB74
		private void Refresh()
		{
			this.RefreshTypeIconSprite();
			this.RefreshName();
			this.RefreshInfo();
			this.RefreshLevel();
			this.RefreshSumExp();
			this.RefreshExpBarSprite();
			this.RefreshConfirmButton();
			this.RefreshRewardList();
			this.RefreshLeftAndRightButtonEnable();
			this.RefreshRewardItem();
			this.RefreshRedDotVisible();
		}

		// Token: 0x0602D569 RID: 185705 RVA: 0x00CB19C4 File Offset: 0x00CAFBC4
		private void RefreshTypeIconSprite()
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_ComposeType");
			base.SetTextureByPath(resourcePath, base.GetTexture(9), null, null);
		}

		// Token: 0x0602D56A RID: 185706 RVA: 0x00CB19FC File Offset: 0x00CAFBFC
		private void RefreshName()
		{
			SynthesisLevel? composeLevelByLevel = CommonManager.Instance.GetComposeLevelByLevel(CommonManager.Instance.GetSelectedLevel().Value);
			string localText = ComposeConfig.Instance.GetLocalText(composeLevelByLevel.Value.Name);
			base.GetText(0).SetText(localText, true);
		}

		// Token: 0x0602D56B RID: 185707 RVA: 0x00CB1A50 File Offset: 0x00CAFC50
		private void RefreshInfo()
		{
			SynthesisLevel? composeLevelByLevel = CommonManager.Instance.GetComposeLevelByLevel(CommonManager.Instance.GetSelectedLevel().Value);
			string localText = ComposeConfig.Instance.GetLocalText(composeLevelByLevel.Value.AttributesDescription);
			base.GetText(1).SetText(localText, true);
		}

		// Token: 0x0602D56C RID: 185708 RVA: 0x00CB1AA4 File Offset: 0x00CAFCA4
		private void RefreshLevel()
		{
			List<bool> list = new List<bool>(new bool[CommonManager.Instance.GetComposeMaxLevel().Value]);
			for (int i = 0; i < CommonManager.Instance.GetSelectedLevel().Value; i++)
			{
				list[i] = true;
			}
			this.StarLayout.RebuildLayoutByDataNew<bool>(list, null);
		}

		// Token: 0x0602D56D RID: 185709 RVA: 0x00CB1B08 File Offset: 0x00CAFD08
		private void RefreshSumExp()
		{
			int value = CommonManager.Instance.GetCurrentRewardTotalProficiency().Value;
			string newText;
			if (CommonManager.Instance.GetSelectedLevel().Value == CommonManager.Instance.GetComposeMaxLevel().Value)
			{
				newText = "MAX";
			}
			else
			{
				int? sumExpByLevel = CommonManager.Instance.GetSumExpByLevel(CommonManager.Instance.GetSelectedLevel().Value);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(value);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int?>(sumExpByLevel);
				newText = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			base.GetText(2).SetText(newText, true);
		}

		// Token: 0x0602D56E RID: 185710 RVA: 0x00CB1BB4 File Offset: 0x00CAFDB4
		private void RefreshExpBarSprite()
		{
			int value = CommonManager.Instance.GetCurrentRewardTotalProficiency().Value;
			int? sumExpByLevel = CommonManager.Instance.GetSumExpByLevel(CommonManager.Instance.GetSelectedLevel().Value);
			double num = (double)MathUtils.Instance.GetFloatPointFloor((float)value / (float)sumExpByLevel.Value, 3);
			num = ((num > 1.0) ? 1.0 : num);
			base.GetSprite(3).SetFillAmount((float)num);
		}

		// Token: 0x0602D56F RID: 185711 RVA: 0x00CB1C30 File Offset: 0x00CAFE30
		private void RefreshConfirmButton()
		{
			int value = CommonManager.Instance.GetComposeMaxLevel().Value;
			int value2 = CommonManager.Instance.GetCurrentRewardLevel().Value;
			int value3 = CommonManager.Instance.GetSelectedLevel().Value;
			AUIBaseActor auibaseActor = base.GetButton(4).GetOwner() as AUIBaseActor;
			auibaseActor.GetUIItem().SetUIActive(true);
			if (value2 >= value || value3 >= value || value3 < value2)
			{
				auibaseActor.GetUIItem().SetUIActive(false);
				return;
			}
			int value4 = CommonManager.Instance.GetCurrentRewardTotalProficiency().Value;
			int value5 = CommonManager.Instance.GetSumExpByLevel(CommonManager.Instance.GetSelectedLevel().Value).Value;
			base.GetButton(4).SetSelfInteractive(value4 >= value5 && value2 < value);
		}

		// Token: 0x0602D570 RID: 185712 RVA: 0x00CB1D08 File Offset: 0x00CAFF08
		private void RefreshRewardList()
		{
			this.TmpRewardItem.Clear();
			int value = CommonManager.Instance.GetDropIdByLevel(CommonManager.Instance.GetSelectedLevel().Value).Value;
			if (value == -1)
			{
				base.GetItem(8).SetUIActive(false);
				return;
			}
			base.GetItem(8).SetUIActive(true);
			DropPackage? dropPackage = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(value);
			if (dropPackage != null)
			{
				for (int i = 0; i < dropPackage.Value.DropPreviewLength; i++)
				{
					DicIntInt? dicIntInt = dropPackage.Value.DropPreview(i);
					if (dicIntInt != null)
					{
						this.TmpRewardItem.Add(new IRewardData
						{
							RewardId = dicIntInt.Value.Key,
							Count = dicIntInt.Value.Value,
							IsGet = (CommonManager.Instance.GetSelectedLevel().Value < CommonManager.Instance.GetCurrentRewardLevel().Value)
						});
					}
				}
			}
			this.RewardItemLayout.RefreshByData(this.TmpRewardItem, null, false);
		}

		// Token: 0x0602D571 RID: 185713 RVA: 0x00CB1E34 File Offset: 0x00CB0034
		private void RefreshLeftAndRightButtonEnable()
		{
			((base.GetButton(5).GetOwner() as AUIBaseActor).GetComponentByClass(UUIItem.StaticClass()) as UUIItem).SetUIActive(CommonManager.Instance.GetSelectedLevel().Value != 1);
			((base.GetButton(6).GetOwner() as AUIBaseActor).GetComponentByClass(UUIItem.StaticClass()) as UUIItem).SetUIActive(CommonManager.Instance.GetSelectedLevel().Value != CommonManager.Instance.GetComposeMaxLevel().Value);
		}

		// Token: 0x0602D572 RID: 185714 RVA: 0x00CB1ED8 File Offset: 0x00CB00D8
		private void RefreshRewardItem()
		{
			base.GetItem(10).SetUIActive(CommonManager.Instance.GetSelectedLevel().Value != CommonManager.Instance.GetComposeMaxLevel().Value);
		}

		// Token: 0x0602D573 RID: 185715 RVA: 0x00CB1F1C File Offset: 0x00CB011C
		private void RefreshRedDotVisible()
		{
			int value = CommonManager.Instance.GetCurrentRewardLevel().Value;
			int value2 = CommonManager.Instance.GetSelectedLevel().Value;
			if (value == value2)
			{
				RedDotController.Instance.BindRedDot(ERedDotName.ComposeReagentProduction, base.GetItem(13), null, 0);
				return;
			}
			RedDotController.Instance.UnBindGivenUi(ERedDotName.ComposeReagentProduction, base.GetItem(13), 0);
			UUIItem item = base.GetItem(13);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x0602D574 RID: 185716 RVA: 0x00CB1F90 File Offset: 0x00CB0190
		private void OnClick()
		{
			if (base.GetButton(4).GetSelfInteractive())
			{
				CommonManager.Instance.SendLevelRewardRequest();
				return;
			}
			GenericPromptController.Instance.ShowPromptByCode("ComposeUpgrade", Array.Empty<object>());
		}

		// Token: 0x0602D575 RID: 185717 RVA: 0x00CB1FC0 File Offset: 0x00CB01C0
		private void OnLeft()
		{
			CommonManager.Instance.SetSelectedLevel(CommonManager.Instance.GetSelectedLevel().Value - 1);
			this.Refresh();
		}

		// Token: 0x0602D576 RID: 185718 RVA: 0x00CB1FF4 File Offset: 0x00CB01F4
		private void OnRight()
		{
			CommonManager.Instance.SetSelectedLevel(CommonManager.Instance.GetSelectedLevel().Value + 1);
			this.Refresh();
		}

		// Token: 0x0602D577 RID: 185719 RVA: 0x00CB2025 File Offset: 0x00CB0225
		private void OnClickBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x040184A1 RID: 99489
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<LevelRewardItem, IRewardData> RewardItemLayout;

		// Token: 0x040184A2 RID: 99490
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IRewardData> TmpRewardItem;

		// Token: 0x040184A3 RID: 99491
		private bool IsFirstShow = true;

		// Token: 0x040184A4 RID: 99492
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutNew<StarItem> StarLayout;

		// Token: 0x0200A27F RID: 41599
		[NullableContext(0)]
		private class ELevelUpgradeDefine
		{
			// Token: 0x040326D0 RID: 206544
			public const int NameText = 0;

			// Token: 0x040326D1 RID: 206545
			public const int InfoText = 1;

			// Token: 0x040326D2 RID: 206546
			public const int SumExpText = 2;

			// Token: 0x040326D3 RID: 206547
			public const int ExpBarSprite = 3;

			// Token: 0x040326D4 RID: 206548
			public const int ConfirmButton = 4;

			// Token: 0x040326D5 RID: 206549
			public const int LeftButton = 5;

			// Token: 0x040326D6 RID: 206550
			public const int RightButton = 6;

			// Token: 0x040326D7 RID: 206551
			public const int RewardItemHorizontalLayout = 7;

			// Token: 0x040326D8 RID: 206552
			public const int RewardLayoutItem = 8;

			// Token: 0x040326D9 RID: 206553
			public const int TypeIconTexture = 9;

			// Token: 0x040326DA RID: 206554
			public const int RewardItem = 10;

			// Token: 0x040326DB RID: 206555
			public const int PnlStar = 11;

			// Token: 0x040326DC RID: 206556
			public const int TxtConfirm = 12;

			// Token: 0x040326DD RID: 206557
			public const int RedDot = 13;

			// Token: 0x040326DE RID: 206558
			public const int MaskBtn = 14;

			// Token: 0x040326DF RID: 206559
			public const int BackBtn = 15;
		}
	}
}
