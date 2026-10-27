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
	// Token: 0x02005696 RID: 22166
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelUpgradeView : UiViewBase
	{
		// Token: 0x0603865E RID: 231006 RVA: 0x00D6323B File Offset: 0x00D6143B
		public LevelUpgradeView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603865F RID: 231007 RVA: 0x00D6324C File Offset: 0x00D6144C
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

		// Token: 0x06038660 RID: 231008 RVA: 0x00D63556 File Offset: 0x00D61756
		protected override void OnBeforeDestroy()
		{
			if (this.RewardItemLayout != null)
			{
				this.RewardItemLayout.ClearChildren();
				this.RewardItemLayout = null;
			}
			this.StarLayout.ClearChildren();
		}

		// Token: 0x06038661 RID: 231009 RVA: 0x00D6357D File Offset: 0x00D6177D
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

		// Token: 0x06038662 RID: 231010 RVA: 0x00D635A0 File Offset: 0x00D617A0
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

		// Token: 0x06038663 RID: 231011 RVA: 0x00D6367C File Offset: 0x00D6187C
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

		// Token: 0x06038664 RID: 231012 RVA: 0x00D636CE File Offset: 0x00D618CE
		private LevelRewardItem InitReward()
		{
			return new LevelRewardItem();
		}

		// Token: 0x06038665 RID: 231013 RVA: 0x00D636D8 File Offset: 0x00D618D8
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.UpgradeComposeLevel, new Action(this.ShowRewardView));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OpenView));
			EventSystem.Instance.Add(EEventName.SwitchComposeType, new Action(this.SwitchComposeType));
		}

		// Token: 0x06038666 RID: 231014 RVA: 0x00D63738 File Offset: 0x00D61938
		protected override void OnRemoveEventListener()
		{
			if (!this.IsFirstShow)
			{
				EventSystem.Instance.Remove(EEventName.UpgradeComposeLevel, new Action(this.ShowRewardView));
			}
			EventSystem.Instance.Remove(EEventName.OpenView, new Action<EUiViewName, int>(this.OpenView));
			EventSystem.Instance.Remove(EEventName.SwitchComposeType, new Action(this.SwitchComposeType));
		}

		// Token: 0x06038667 RID: 231015 RVA: 0x00D6379D File Offset: 0x00D6199D
		private void ShowRewardView()
		{
			if (this.TmpRewardItem.Count == 0)
			{
				return;
			}
			this.Update();
		}

		// Token: 0x06038668 RID: 231016 RVA: 0x00D637B3 File Offset: 0x00D619B3
		private void OpenView(EUiViewName uiView, int viewId)
		{
			if (uiView == EUiViewName.WorldMapView)
			{
				base.CloseMe(null);
			}
		}

		// Token: 0x06038669 RID: 231017 RVA: 0x00D637C9 File Offset: 0x00D619C9
		private void SwitchComposeType()
		{
			base.CloseMe(null);
			if (UiManager.Instance.IsViewOpen(EUiViewName.ItemTipsView))
			{
				UiManager.Instance.CloseView(EUiViewName.ItemTipsView, null);
			}
		}

		// Token: 0x0603866A RID: 231018 RVA: 0x00D637F4 File Offset: 0x00D619F4
		private void Update()
		{
			CommonManager.Instance.SetSelectedLevel(CommonManager.Instance.GetCurrentRewardLevel().Value);
			this.Refresh();
		}

		// Token: 0x0603866B RID: 231019 RVA: 0x00D63824 File Offset: 0x00D61A24
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

		// Token: 0x0603866C RID: 231020 RVA: 0x00D63874 File Offset: 0x00D61A74
		private void RefreshTypeIconSprite()
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_ComposeType");
			base.SetTextureByPath(resourcePath, base.GetTexture(9), null, null);
		}

		// Token: 0x0603866D RID: 231021 RVA: 0x00D638AC File Offset: 0x00D61AAC
		private void RefreshName()
		{
			SynthesisLevel? composeLevelByLevel = CommonManager.Instance.GetComposeLevelByLevel(CommonManager.Instance.GetSelectedLevel().Value);
			string localText = ComposeConfig.Instance.GetLocalText(composeLevelByLevel.Value.Name);
			base.GetText(0).SetText(localText, true);
		}

		// Token: 0x0603866E RID: 231022 RVA: 0x00D63900 File Offset: 0x00D61B00
		private void RefreshInfo()
		{
			SynthesisLevel? composeLevelByLevel = CommonManager.Instance.GetComposeLevelByLevel(CommonManager.Instance.GetSelectedLevel().Value);
			string localText = ComposeConfig.Instance.GetLocalText(composeLevelByLevel.Value.AttributesDescription);
			base.GetText(1).SetText(localText, true);
		}

		// Token: 0x0603866F RID: 231023 RVA: 0x00D63954 File Offset: 0x00D61B54
		private void RefreshLevel()
		{
			List<bool> list = new List<bool>(new bool[CommonManager.Instance.GetComposeMaxLevel().Value]);
			for (int i = 0; i < CommonManager.Instance.GetSelectedLevel().Value; i++)
			{
				list[i] = true;
			}
			this.StarLayout.RebuildLayoutByDataNew<bool>(list, null);
		}

		// Token: 0x06038670 RID: 231024 RVA: 0x00D639B8 File Offset: 0x00D61BB8
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

		// Token: 0x06038671 RID: 231025 RVA: 0x00D63A64 File Offset: 0x00D61C64
		private void RefreshExpBarSprite()
		{
			int value = CommonManager.Instance.GetCurrentRewardTotalProficiency().Value;
			int? sumExpByLevel = CommonManager.Instance.GetSumExpByLevel(CommonManager.Instance.GetSelectedLevel().Value);
			double num = (double)MathUtils.Instance.GetFloatPointFloor((float)value / (float)sumExpByLevel.Value, 3);
			num = ((num > 1.0) ? 1.0 : num);
			base.GetSprite(3).SetFillAmount((float)num);
		}

		// Token: 0x06038672 RID: 231026 RVA: 0x00D63AE0 File Offset: 0x00D61CE0
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

		// Token: 0x06038673 RID: 231027 RVA: 0x00D63BB8 File Offset: 0x00D61DB8
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

		// Token: 0x06038674 RID: 231028 RVA: 0x00D63CE4 File Offset: 0x00D61EE4
		private void RefreshLeftAndRightButtonEnable()
		{
			((base.GetButton(5).GetOwner() as AUIBaseActor).GetComponentByClass(UUIItem.StaticClass()) as UUIItem).SetUIActive(CommonManager.Instance.GetSelectedLevel().Value != 1);
			((base.GetButton(6).GetOwner() as AUIBaseActor).GetComponentByClass(UUIItem.StaticClass()) as UUIItem).SetUIActive(CommonManager.Instance.GetSelectedLevel().Value != CommonManager.Instance.GetComposeMaxLevel().Value);
		}

		// Token: 0x06038675 RID: 231029 RVA: 0x00D63D88 File Offset: 0x00D61F88
		private void RefreshRewardItem()
		{
			base.GetItem(10).SetUIActive(CommonManager.Instance.GetSelectedLevel().Value != CommonManager.Instance.GetComposeMaxLevel().Value);
		}

		// Token: 0x06038676 RID: 231030 RVA: 0x00D63DCC File Offset: 0x00D61FCC
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

		// Token: 0x06038677 RID: 231031 RVA: 0x00D63E40 File Offset: 0x00D62040
		private void OnClick()
		{
			if (base.GetButton(4).GetSelfInteractive())
			{
				CommonManager.Instance.SendLevelRewardRequest();
				return;
			}
			GenericPromptController.Instance.ShowPromptByCode("ComposeUpgrade", Array.Empty<object>());
		}

		// Token: 0x06038678 RID: 231032 RVA: 0x00D63E70 File Offset: 0x00D62070
		private void OnLeft()
		{
			CommonManager.Instance.SetSelectedLevel(CommonManager.Instance.GetSelectedLevel().Value - 1);
			this.Refresh();
		}

		// Token: 0x06038679 RID: 231033 RVA: 0x00D63EA4 File Offset: 0x00D620A4
		private void OnRight()
		{
			CommonManager.Instance.SetSelectedLevel(CommonManager.Instance.GetSelectedLevel().Value + 1);
			this.Refresh();
		}

		// Token: 0x0603867A RID: 231034 RVA: 0x00D63ED5 File Offset: 0x00D620D5
		private void OnClickBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401DA16 RID: 121366
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<LevelRewardItem, IRewardData> RewardItemLayout;

		// Token: 0x0401DA17 RID: 121367
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IRewardData> TmpRewardItem;

		// Token: 0x0401DA18 RID: 121368
		private bool IsFirstShow = true;

		// Token: 0x0401DA19 RID: 121369
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutNew<StarItem> StarLayout;

		// Token: 0x0200B857 RID: 47191
		[NullableContext(0)]
		private class ELevelUpgradeDefine
		{
			// Token: 0x04037CB3 RID: 228531
			public const int NameText = 0;

			// Token: 0x04037CB4 RID: 228532
			public const int InfoText = 1;

			// Token: 0x04037CB5 RID: 228533
			public const int SumExpText = 2;

			// Token: 0x04037CB6 RID: 228534
			public const int ExpBarSprite = 3;

			// Token: 0x04037CB7 RID: 228535
			public const int ConfirmButton = 4;

			// Token: 0x04037CB8 RID: 228536
			public const int LeftButton = 5;

			// Token: 0x04037CB9 RID: 228537
			public const int RightButton = 6;

			// Token: 0x04037CBA RID: 228538
			public const int RewardItemHorizontalLayout = 7;

			// Token: 0x04037CBB RID: 228539
			public const int RewardLayoutItem = 8;

			// Token: 0x04037CBC RID: 228540
			public const int TypeIconTexture = 9;

			// Token: 0x04037CBD RID: 228541
			public const int RewardItem = 10;

			// Token: 0x04037CBE RID: 228542
			public const int PnlStar = 11;

			// Token: 0x04037CBF RID: 228543
			public const int TxtConfirm = 12;

			// Token: 0x04037CC0 RID: 228544
			public const int RedDot = 13;

			// Token: 0x04037CC1 RID: 228545
			public const int MaskBtn = 14;

			// Token: 0x04037CC2 RID: 228546
			public const int BackBtn = 15;
		}
	}
}
