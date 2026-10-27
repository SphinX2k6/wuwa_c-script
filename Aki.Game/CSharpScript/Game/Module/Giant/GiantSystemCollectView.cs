using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Giant.View;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Giant
{
	// Token: 0x02005971 RID: 22897
	[NullableContext(1)]
	[Nullable(0)]
	public class GiantSystemCollectView : UiViewBase
	{
		// Token: 0x0603A18B RID: 237963 RVA: 0x00DCE6B8 File Offset: 0x00DCC8B8
		public GiantSystemCollectView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603A18C RID: 237964 RVA: 0x00DCE6D0 File Offset: 0x00DCC8D0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 33;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(27, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(28, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(29, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(30, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(31, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(32, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 4;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickBtnPre));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickBtnNext));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(26, new Action(this.OnClickBtnGoto));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(27, new Action(this.OnClickBtnSubmit));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603A18D RID: 237965 RVA: 0x00DCEBFC File Offset: 0x00DCCDFC
		protected override void OnBeforeCreate()
		{
			IGiantSystemCollectOpenParam giantSystemCollectOpenParam = this.OpenParam as IGiantSystemCollectOpenParam;
			this.EcoType = giantSystemCollectOpenParam.EcoType;
			this.IncId = giantSystemCollectOpenParam.IncId;
		}

		// Token: 0x0603A18E RID: 237966 RVA: 0x00DCEC30 File Offset: 0x00DCCE30
		protected override UniTask OnBeforeStartAsync()
		{
			GiantSystemCollectView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<GiantSystemCollectView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603A18F RID: 237967 RVA: 0x00DCEC74 File Offset: 0x00DCCE74
		protected override void OnStart()
		{
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(24);
			object obj;
			if (scrollViewWithScrollbar == null)
			{
				obj = null;
			}
			else
			{
				AUIBaseActor content = scrollViewWithScrollbar.GetContent();
				obj = ((content != null) ? content.GetComponentByClass(UUILayoutBase.StaticClass()) : null);
			}
			UUILayoutBase uuilayoutBase = obj as UUILayoutBase;
			if (uuilayoutBase != null)
			{
				this.ItemLayout = new GenericLayout<GiantCollectItemGrid, GiantCollectItemData>(uuilayoutBase, () => new GiantCollectItemGrid(), null, false, true);
			}
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar2 = base.GetScrollViewWithScrollbar(19);
			object obj2;
			if (scrollViewWithScrollbar2 == null)
			{
				obj2 = null;
			}
			else
			{
				AUIBaseActor content2 = scrollViewWithScrollbar2.GetContent();
				obj2 = ((content2 != null) ? content2.GetComponentByClass(UUILayoutBase.StaticClass()) : null);
			}
			UUILayoutBase uuilayoutBase2 = obj2 as UUILayoutBase;
			if (uuilayoutBase2 != null)
			{
				this.RewardLayout = new GenericLayout<CommonItemSmallItemGrid, TItem>(uuilayoutBase2, () => new CommonItemSmallItemGrid
				{
					ShowReceivedCallBack = ((TItem data) => this.DisplayLevel < this.GetDisplayLevelFromStage())
				}, null, false, true);
			}
			this.Caption = new PopupCaptionItem(base.GetItem(0));
			this.Caption.SetCloseCallBack(delegate
			{
				base.CloseMe(null);
			});
			this.Caption.SetHelpBtnActive(false);
			this.BarTween = new GiantBarTween(base.GetSprite(7), base.GetSprite(6));
			this.Refresh();
		}

		// Token: 0x0603A190 RID: 237968 RVA: 0x00DCED84 File Offset: 0x00DCCF84
		protected override void OnBeforeDestroy()
		{
			GiantBarTween barTween = this.BarTween;
			if (barTween != null)
			{
				barTween.Destroy();
			}
			this.BarTween = null;
			GeneralLogicTreeController.Instance.OpenSystemBoardResultRequest(this.LastTopQuality, this.IncId);
		}

		// Token: 0x0603A191 RID: 237969 RVA: 0x00DCEDB4 File Offset: 0x00DCCFB4
		private void Refresh()
		{
			IGiantEcoDisplayConfig config = GiantDefine.EcoDisplayConfigs[this.EcoType];
			GiantEcoNetStatus ecoStatus = GiantModel.Instance.GetEcoStatus(this.EcoType);
			this.DisplayLevel = this.GetDisplayLevelFromStage();
			this.RefreshStateVisibility(ecoStatus);
			this.RefreshIcon(config, ecoStatus);
			this.RefreshTextAndColor(config, ecoStatus);
			this.RefreshProgress();
			this.RefreshItemList(ecoStatus);
			this.RefreshLevelBrowse();
			this.RefreshRewardList();
			this.RefreshSubmitBtnState();
		}

		// Token: 0x0603A192 RID: 237970 RVA: 0x00DCEE28 File Offset: 0x00DCD028
		private void RefreshStateVisibility(GiantEcoNetStatus status)
		{
			bool flag = status == GiantEcoNetStatus.Lock;
			bool flag2 = status == GiantEcoNetStatus.MaxStableValue;
			bool flag3 = !flag2;
			if (flag)
			{
				GiantLockTipItem lockTip = this.LockTip;
				if (lockTip != null)
				{
					lockTip.SetTipText(GiantConfig.GetEcoLockHintText(this.EcoType));
				}
			}
			UUIItem item = base.GetItem(28);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			UUIItem item2 = base.GetItem(29);
			if (item2 != null)
			{
				item2.SetUIActive(flag2);
			}
			UUIItem item3 = base.GetItem(21);
			if (item3 != null)
			{
				item3.SetUIActive(flag3);
			}
			UUIButtonComponent button = base.GetButton(22);
			if (button != null)
			{
				UUIItem uuiitem = button.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(false);
				}
			}
			UUIButtonComponent button2 = base.GetButton(27);
			if (button2 != null)
			{
				UUIItem uuiitem2 = button2.RootUIComp.Get();
				if (uuiitem2 != null)
				{
					uuiitem2.SetUIActive(flag3 && !flag);
				}
			}
			UUIItem item4 = base.GetItem(18);
			if (item4 == null)
			{
				return;
			}
			item4.SetUIActive(!flag2);
		}

		// Token: 0x0603A193 RID: 237971 RVA: 0x00DCEF0C File Offset: 0x00DCD10C
		private void RefreshIcon(IGiantEcoDisplayConfig config, GiantEcoNetStatus status)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(config.IconSpriteNormal);
			base.TrySetSpriteByPath(resourcePath, base.GetSprite(2), false, null, null);
			string resourcePath2 = UiResourceConfig.Instance.GetResourcePath(config.IconSpriteActive);
			base.TrySetSpriteByPath(resourcePath2, base.GetSprite(1), false, null, null);
		}

		// Token: 0x0603A194 RID: 237972 RVA: 0x00DCEF70 File Offset: 0x00DCD170
		private void RefreshTextAndColor(IGiantEcoDisplayConfig config, GiantEcoNetStatus status)
		{
			FColor color = FColor.FromHex(config.OutlineColorHex);
			UUIText text = base.GetText(3);
			if (text != null)
			{
				text.SetText(GiantConfig.ResolveLocalTextOrKey(config.MindsetNameKey), true);
			}
			this.SetTextOutline(3, color);
			this.RefreshLevelDesc();
			this.RefreshFeatureActivation();
		}

		// Token: 0x0603A195 RID: 237973 RVA: 0x00DCEFBC File Offset: 0x00DCD1BC
		private void RefreshLevelDesc()
		{
			GiantLevelUnlock? levelUnlock = GiantConfig.GetLevelUnlock(this.EcoType, this.DisplayLevel);
			int displayLevelFromStage = this.GetDisplayLevelFromStage();
			bool flag = this.DisplayLevel < displayLevelFromStage || displayLevelFromStage >= this.GetMaxLevel();
			string text = (flag ? ((levelUnlock != null) ? levelUnlock.GetValueOrDefault().PostUnlockDesc1 : null) : ((levelUnlock != null) ? levelUnlock.GetValueOrDefault().PreUnlockDesc : null)) ?? "";
			string text2 = (flag ? ((levelUnlock != null) ? levelUnlock.GetValueOrDefault().PostUnlockDesc2 : null) : "") ?? "";
			bool flag2 = text != "";
			bool flag3 = text2 != "";
			UUIText text3 = base.GetText(13);
			if (text3 != null)
			{
				text3.SetText(flag2 ? GiantConfig.ResolveLocalTextOrKey(text) : "", true);
			}
			UUISprite sprite = base.GetSprite(12);
			if (sprite != null)
			{
				sprite.SetUIActive(flag2);
			}
			UUIText text4 = base.GetText(17);
			if (text4 != null)
			{
				text4.SetUIActive(flag3);
			}
			UUISprite sprite2 = base.GetSprite(16);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(flag3);
			}
			UUIItem item = base.GetItem(14);
			if (item != null)
			{
				item.SetUIActive(flag3);
			}
			if (flag3)
			{
				UUIText text5 = base.GetText(17);
				if (text5 != null)
				{
					text5.SetText(GiantConfig.ResolveLocalTextOrKey(text2), true);
				}
			}
			this.RefreshTitles();
		}

		// Token: 0x0603A196 RID: 237974 RVA: 0x00DCF128 File Offset: 0x00DCD328
		private void RefreshTitles()
		{
			bool flag = this.DisplayLevel >= this.GetMaxLevel();
			string textKey = flag ? GiantConfig.GetTextKeyTraitTitleMax() : GiantConfig.GetTextKeyTraitTitleUpgrade();
			UUIText text = base.GetText(32);
			if (text != null)
			{
				text.SetText(GiantConfig.ResolveLocalTextOrKey(textKey), true);
			}
			string newText = flag ? GiantConfig.GetRewardTitleOfferingText(this.EcoType) : GiantConfig.ResolveLocalTextOrKey(GiantConfig.GetTextKeyRewardTitleUpgrade());
			UUIText text2 = base.GetText(30);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(newText, true);
		}

		// Token: 0x0603A197 RID: 237975 RVA: 0x00DCF1A0 File Offset: 0x00DCD3A0
		private void RefreshFeatureActivation()
		{
			int displayLevelFromStage = this.GetDisplayLevelFromStage();
			bool flag = this.DisplayLevel < displayLevelFromStage || displayLevelFromStage >= this.GetMaxLevel();
			UUISprite sprite = base.GetSprite(12);
			UUISprite sprite2 = base.GetSprite(16);
			UUIText text = base.GetText(13);
			UUIText text2 = base.GetText(17);
			if (sprite != null)
			{
				UUIItem uuiitem = sprite;
				bool bUseChangeColor = flag;
				FColor? fcolor = new FColor?(sprite.changeColor);
				uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			}
			if (sprite2 != null)
			{
				UUIItem uuiitem2 = sprite2;
				bool bUseChangeColor2 = flag;
				FColor? fcolor = new FColor?(sprite2.changeColor);
				uuiitem2.SetChangeColor(bUseChangeColor2, fcolor);
			}
			if (text != null)
			{
				UUIItem uuiitem3 = text;
				bool bUseChangeColor3 = flag;
				FColor? fcolor = new FColor?(text.changeColor);
				uuiitem3.SetChangeColor(bUseChangeColor3, fcolor);
			}
			if (text2 != null)
			{
				UUIItem uuiitem4 = text2;
				bool bUseChangeColor4 = flag;
				FColor? fcolor = new FColor?(text2.changeColor);
				uuiitem4.SetChangeColor(bUseChangeColor4, fcolor);
			}
		}

		// Token: 0x0603A198 RID: 237976 RVA: 0x00DCF25D File Offset: 0x00DCD45D
		private void SetTextOutline(int name, FColor color)
		{
			UUIText text = base.GetText(name);
			if (text == null)
			{
				return;
			}
			text.SetFontOutlineColor(color);
		}

		// Token: 0x0603A199 RID: 237977 RVA: 0x00DCF274 File Offset: 0x00DCD474
		private void RefreshItemList(GiantEcoNetStatus status)
		{
			bool flag = status == GiantEcoNetStatus.MaxStableValue;
			bool flag2 = !flag;
			if (flag)
			{
				UUIText text = base.GetText(10);
				if (text != null)
				{
					text.SetUIActive(false);
				}
			}
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(24);
			if (scrollViewWithScrollbar != null)
			{
				UUIItem uuiitem = scrollViewWithScrollbar.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(flag2);
				}
			}
			if (flag2)
			{
				this.RefreshItemGrids();
				return;
			}
			GenericLayout<GiantCollectItemGrid, GiantCollectItemData> itemLayout = this.ItemLayout;
			if (itemLayout == null)
			{
				return;
			}
			itemLayout.RefreshByData(Array.Empty<GiantCollectItemData>(), null, false);
		}

		// Token: 0x0603A19A RID: 237978 RVA: 0x00DCF2E8 File Offset: 0x00DCD4E8
		private void RefreshItemGrids()
		{
			bool isComplete = GiantModel.Instance.GetEcoStatus(this.EcoType) == GiantEcoNetStatus.MaxStableValue;
			List<GiantCollectItemData> data = (from itemId in GiantConfig.GetEcoItemIds(this.EcoType)
			select new GiantCollectItemData
			{
				ItemId = itemId,
				IsLocked = this.IsItemLocked(itemId),
				IsDelivered = new bool?(isComplete),
				OnClick = new Action<int>(this.OnClickItem)
			}).ToList<GiantCollectItemData>();
			GenericLayout<GiantCollectItemGrid, GiantCollectItemData> itemLayout = this.ItemLayout;
			if (itemLayout == null)
			{
				return;
			}
			itemLayout.RefreshByData(data, null, false);
		}

		// Token: 0x0603A19B RID: 237979 RVA: 0x00DCF350 File Offset: 0x00DCD550
		private void RefreshRewardList()
		{
			if (this.RewardLayout == null)
			{
				return;
			}
			GiantDeliveryReward? deliveryReward = GiantConfig.GetDeliveryReward(this.EcoType);
			if (deliveryReward == null)
			{
				this.RewardLayout.RefreshByData(Array.Empty<TItem>(), null, false);
				return;
			}
			GiantDeliveryReward value = deliveryReward.Value;
			CSharpScript.Game.Module.Reward.RewardConfig instance = CSharpScript.Game.Module.Reward.RewardConfig.Instance;
			int maxLevel = this.GetMaxLevel();
			if (this.DisplayLevel >= maxLevel)
			{
				List<TItem> dropPackagePreviewItemListByIdList = instance.GetDropPackagePreviewItemListByIdList(new List<int>
				{
					value.MaxLevelDropId
				});
				this.RewardLayout.RefreshByData(dropPackagePreviewItemListByIdList, null, false);
				return;
			}
			int[] array = value.GetDropIdsArray() ?? Array.Empty<int>();
			int? num = (this.DisplayLevel - 1 < array.Length) ? new int?(array[this.DisplayLevel - 1]) : null;
			List<TItem> dropPackagePreviewItemListByIdList2 = instance.GetDropPackagePreviewItemListByIdList(new List<int>
			{
				num ?? value.MaxLevelDropId
			});
			this.RewardLayout.RefreshByData(dropPackagePreviewItemListByIdList2, null, false);
		}

		// Token: 0x0603A19C RID: 237980 RVA: 0x00DCF454 File Offset: 0x00DCD654
		private int GetMaxLevel()
		{
			int num = GiantConfig.GetEcoGoals(this.EcoType).Length;
			if (num <= 0)
			{
				return 1;
			}
			return num + 1;
		}

		// Token: 0x0603A19D RID: 237981 RVA: 0x00DCF478 File Offset: 0x00DCD678
		private int GetDisplayLevelFromStage()
		{
			return this.GetDisplayLevelByValue((int)GiantModel.Instance.GetStableValue(this.EcoType));
		}

		// Token: 0x0603A19E RID: 237982 RVA: 0x00DCF494 File Offset: 0x00DCD694
		private IGiantLevelSpan GetLevelSpan(int displayLevel)
		{
			int[] ecoGoals = GiantConfig.GetEcoGoals(this.EcoType);
			if (displayLevel >= this.GetMaxLevel())
			{
				int num = (ecoGoals.Length != 0) ? ecoGoals[ecoGoals.Length - 1] : 0;
				int num2 = GiantConfig.GetMaxStableValue(this.EcoType) - num;
				return new GiantLevelSpan
				{
					Start = (double)num,
					Span = (double)((num2 > 0) ? num2 : 0)
				};
			}
			int num3 = (displayLevel - 1 < ecoGoals.Length) ? ecoGoals[displayLevel - 1] : ((ecoGoals.Length != 0) ? ecoGoals[ecoGoals.Length - 1] : 0);
			int num4 = (displayLevel > 1) ? ((displayLevel - 2 < ecoGoals.Length) ? ecoGoals[displayLevel - 2] : 0) : 0;
			int num5 = (num3 - num4 > 0) ? (num3 - num4) : num3;
			return new GiantLevelSpan
			{
				Start = (double)num4,
				Span = (double)num5
			};
		}

		// Token: 0x0603A19F RID: 237983 RVA: 0x00DCF550 File Offset: 0x00DCD750
		private void ApplyBarFill(double currentInLevel, double addedValue, double span, bool animatePreview)
		{
			UUISprite sprite = base.GetSprite(7);
			bool flag = span <= 0.0;
			UUIItem item = base.GetItem(31);
			if (item != null)
			{
				item.SetUIActive(!flag);
			}
			if (sprite != null)
			{
				sprite.SetUIActive(true);
			}
			UUISprite sprite2 = base.GetSprite(6);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(true);
			}
			bool flag2 = addedValue > 0.0;
			if (flag)
			{
				if (sprite != null)
				{
					sprite.SetFillAmount(1f);
				}
				this.SetPreviewFill(flag2 > false, animatePreview);
				return;
			}
			double num = Math.Max(0.0, Math.Min(currentInLevel / span, 1.0));
			double target = flag2 ? Math.Max(0.0, Math.Min((currentInLevel + addedValue) / span, 1.0)) : 0.0;
			if (sprite != null)
			{
				sprite.SetFillAmount((float)num);
			}
			this.SetPreviewFill(target, animatePreview);
		}

		// Token: 0x0603A1A0 RID: 237984 RVA: 0x00DCF63C File Offset: 0x00DCD83C
		private void SetPreviewFill(double target, bool animate)
		{
			UUISprite sprite = base.GetSprite(6);
			if (sprite == null)
			{
				return;
			}
			if (animate && this.BarTween != null)
			{
				this.BarTween.PlayPreview(sprite, target, GiantDefine.YellowPreviewTime);
				return;
			}
			GiantBarTween barTween = this.BarTween;
			if (barTween != null)
			{
				barTween.KillPreview();
			}
			sprite.SetFillAmount((float)target);
		}

		// Token: 0x0603A1A1 RID: 237985 RVA: 0x00DCF68C File Offset: 0x00DCD88C
		private void RefreshValueAddText(int addedValue)
		{
			UUIText text = base.GetText(9);
			if (addedValue > 0)
			{
				if (text != null)
				{
					text.SetText("+" + addedValue.ToString(), true);
				}
				if (text != null)
				{
					text.SetUIActive(true);
					return;
				}
			}
			else if (text != null)
			{
				text.SetUIActive(false);
			}
		}

		// Token: 0x0603A1A2 RID: 237986 RVA: 0x00DCF6D8 File Offset: 0x00DCD8D8
		private void RefreshProgress()
		{
			int displayLevelFromStage = this.GetDisplayLevelFromStage();
			IGiantLevelSpan levelSpan = this.GetLevelSpan(displayLevelFromStage);
			double num = GiantModel.Instance.GetStableValue(this.EcoType) - levelSpan.Start;
			double value = Math.Max(0.0, Math.Min(num, levelSpan.Span));
			bool flag = levelSpan.Span <= 0.0;
			UUIText text = base.GetText(8);
			if (text != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Lv.");
				defaultInterpolatedStringHandler.AppendFormatted<int>(displayLevelFromStage);
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			UUIText text2 = base.GetText(10);
			if (text2 != null)
			{
				string newText;
				if (!flag)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
					defaultInterpolatedStringHandler.AppendFormatted<double>(value);
					defaultInterpolatedStringHandler.AppendLiteral("/");
					defaultInterpolatedStringHandler.AppendFormatted<double>(levelSpan.Span);
					newText = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				else
				{
					newText = "MAX";
				}
				text2.SetText(newText, true);
			}
			this.RefreshValueAddText(0);
			this.ApplyBarFill(num, 0.0, levelSpan.Span, false);
		}

		// Token: 0x0603A1A3 RID: 237987 RVA: 0x00DCF7E4 File Offset: 0x00DCD9E4
		private void RefreshBrowseProgress()
		{
			int displayLevel = this.DisplayLevel;
			IGiantLevelSpan levelSpan = this.GetLevelSpan(displayLevel);
			double num = GiantModel.Instance.GetStableValue(this.EcoType) - levelSpan.Start;
			double value = Math.Max(0.0, Math.Min(num, levelSpan.Span));
			bool flag = levelSpan.Span <= 0.0;
			UUIText text = base.GetText(8);
			if (text != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Lv.");
				defaultInterpolatedStringHandler.AppendFormatted<int>(displayLevel);
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			UUIText text2 = base.GetText(10);
			if (text2 != null)
			{
				string newText;
				if (!flag)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
					defaultInterpolatedStringHandler.AppendFormatted<double>(value);
					defaultInterpolatedStringHandler.AppendLiteral("/");
					defaultInterpolatedStringHandler.AppendFormatted<double>(levelSpan.Span);
					newText = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				else
				{
					newText = "MAX";
				}
				text2.SetText(newText, true);
			}
			this.RefreshValueAddText(0);
			this.ApplyBarFill(num, 0.0, levelSpan.Span, false);
		}

		// Token: 0x0603A1A4 RID: 237988 RVA: 0x00DCF8EE File Offset: 0x00DCDAEE
		private bool IsEcoWholeLocked()
		{
			return GiantModel.Instance.GetEcoStatus(this.EcoType) == GiantEcoNetStatus.Lock;
		}

		// Token: 0x0603A1A5 RID: 237989 RVA: 0x00DCF903 File Offset: 0x00DCDB03
		private bool IsItemLocked(int itemId)
		{
			return this.IsEcoWholeLocked() || GiantModel.Instance.GetItemLocked(itemId);
		}

		// Token: 0x0603A1A6 RID: 237990 RVA: 0x00DCF91A File Offset: 0x00DCDB1A
		private void OnClickLockHelp()
		{
			GiantController.Instance.OpenUnlockConditionView(this.EcoType);
		}

		// Token: 0x0603A1A7 RID: 237991 RVA: 0x00DCF92C File Offset: 0x00DCDB2C
		private void OnClickItem(int itemId)
		{
			if (this.IsEcoWholeLocked())
			{
				ScrollingTipsController.Instance.ShowTipsByText(GiantConfig.ResolveLocalTextOrKey(GiantConfig.GetTipsKeyPreMainlineWholeLock()));
				return;
			}
			if (this.IsItemLocked(itemId))
			{
				ScrollingTipsController.Instance.ShowTipsByText(GiantConfig.ResolveLocalTextOrKey(GiantConfig.GetTipsKeyHighQualityLock()));
				return;
			}
			ItemController.Instance.OpenItemTipsByItemId(itemId, true, null);
		}

		// Token: 0x0603A1A8 RID: 237992 RVA: 0x00DCF984 File Offset: 0x00DCDB84
		private IReadOnlyDictionary<int, int> CollectAllDeliverable()
		{
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			if (this.IsEcoWholeLocked())
			{
				return dictionary;
			}
			InventoryModel instance = InventoryModel.Instance;
			bool flag = GiantModel.Instance.GetEcoStatus(this.EcoType) == GiantEcoNetStatus.MaxLevel;
			int maxDeliveryCount = GiantConfig.GetMaxDeliveryCount(this.EcoType);
			Dictionary<int, int> dictionary2 = new Dictionary<int, int>();
			foreach (int num in GiantConfig.GetEcoItemIds(this.EcoType))
			{
				if (!this.IsItemLocked(num))
				{
					int itemCountByConfigId = instance.GetItemCountByConfigId(num, 0);
					if (itemCountByConfigId > 0)
					{
						int num2 = itemCountByConfigId;
						if (!flag)
						{
							int itemQuality = GiantConfig.GetItemQuality(num);
							int num4;
							int num3 = dictionary2.TryGetValue(itemQuality, out num4) ? num4 : maxDeliveryCount;
							num2 = Math.Min(itemCountByConfigId, num3);
							if (num2 <= 0)
							{
								goto IL_BC;
							}
							dictionary2[itemQuality] = num3 - num2;
						}
						dictionary[num] = num2;
					}
				}
				IL_BC:;
			}
			return dictionary;
		}

		// Token: 0x0603A1A9 RID: 237993 RVA: 0x00DCFA5C File Offset: 0x00DCDC5C
		private bool HasAnyDeliverable()
		{
			return this.CollectAllDeliverable().Count > 0;
		}

		// Token: 0x0603A1AA RID: 237994 RVA: 0x00DCFA6C File Offset: 0x00DCDC6C
		private void RefreshSubmitBtnState()
		{
			UUIButtonComponent button = base.GetButton(27);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(this.HasAnyDeliverable());
		}

		// Token: 0x0603A1AB RID: 237995 RVA: 0x00DCFA86 File Offset: 0x00DCDC86
		private int GetDisplayLevelByValue(int value)
		{
			return GiantConfig.GetEcoLevelByValue(this.EcoType, value);
		}

		// Token: 0x0603A1AC RID: 237996 RVA: 0x00DCFA94 File Offset: 0x00DCDC94
		private void OnClickBtnPre()
		{
			this.SwitchLevel(-1);
		}

		// Token: 0x0603A1AD RID: 237997 RVA: 0x00DCFA9D File Offset: 0x00DCDC9D
		private void OnClickBtnNext()
		{
			this.SwitchLevel(1);
		}

		// Token: 0x0603A1AE RID: 237998 RVA: 0x00DCFAA8 File Offset: 0x00DCDCA8
		private void SwitchLevel(int delta)
		{
			int num = this.DisplayLevel + delta;
			if (num < 1 || num > this.GetBrowseCap())
			{
				return;
			}
			this.DisplayLevel = num;
			base.PlayOrReplaySequence("Switch", false, null);
			this.RefreshLevelBrowse();
			this.RefreshBrowseProgress();
			this.RefreshLevelDesc();
			this.RefreshFeatureActivation();
			this.RefreshRewardList();
		}

		// Token: 0x0603A1AF RID: 237999 RVA: 0x00DCFB06 File Offset: 0x00DCDD06
		private int GetBrowseCap()
		{
			return this.GetMaxLevel();
		}

		// Token: 0x0603A1B0 RID: 238000 RVA: 0x00DCFB10 File Offset: 0x00DCDD10
		private void RefreshLevelBrowse()
		{
			int browseCap = this.GetBrowseCap();
			UUIButtonComponent button = base.GetButton(4);
			if (button != null)
			{
				UUIItem uuiitem = button.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(this.DisplayLevel > 1);
				}
			}
			UUIButtonComponent button2 = base.GetButton(5);
			if (button2 == null)
			{
				return;
			}
			UUIItem uuiitem2 = button2.RootUIComp.Get();
			if (uuiitem2 == null)
			{
				return;
			}
			uuiitem2.SetUIActive(this.DisplayLevel < browseCap);
		}

		// Token: 0x0603A1B1 RID: 238001 RVA: 0x00DCFB80 File Offset: 0x00DCDD80
		private void OnClickBtnGoto()
		{
			GiantSystemQuestOpenParam param = new GiantSystemQuestOpenParam
			{
				EcoType = this.EcoType,
				GuideOnly = new bool?(true)
			};
			UiManager.Instance.OpenView(EUiViewName.GiantSystemQuestView, param, null);
		}

		// Token: 0x0603A1B2 RID: 238002 RVA: 0x00DCFBBC File Offset: 0x00DCDDBC
		private void OnClickBtnSubmit()
		{
			if (this.IsEcoWholeLocked())
			{
				ScrollingTipsController.Instance.ShowTipsByText(GiantConfig.ResolveLocalTextOrKey(GiantConfig.GetTipsKeyPreMainlineWholeLock()));
				return;
			}
			IReadOnlyDictionary<int, int> readOnlyDictionary = this.CollectAllDeliverable();
			if (readOnlyDictionary.Count <= 0)
			{
				ScrollingTipsController.Instance.ShowTipsByText(GiantConfig.ResolveLocalTextOrKey(GiantConfig.GetTipsKeyNoDeliverableItem()));
				return;
			}
			this.SubmitSelected(readOnlyDictionary);
		}

		// Token: 0x0603A1B3 RID: 238003 RVA: 0x00DCFC14 File Offset: 0x00DCDE14
		private void SubmitSelected(IReadOnlyDictionary<int, int> itemInfos)
		{
			if (GiantModel.Instance.GetEcoStatus(this.EcoType) == GiantEcoNetStatus.MaxLevel)
			{
				GiantController.Instance.SendGiantMaxLevelDeliveryItemRequest(this.EcoType, itemInfos, new Action<GiantMaxLevelDeliveryItemResponse>(this.OnDeliveryResponse));
				return;
			}
			GiantController.Instance.SendGiantDeliveryItemRequest(this.EcoType, itemInfos, new Action<GiantDeliveryItemResponse>(this.OnDeliveryResponse));
		}

		// Token: 0x0603A1B4 RID: 238004 RVA: 0x00DCFC74 File Offset: 0x00DCDE74
		[NullableContext(2)]
		private void OnDeliveryResponse(GiantDeliveryItemResponse response)
		{
			this.OnDeliveryResponse((response == null) ? null : new Aki.Protocol.ErrorCode?(response.ErrorCode), (response != null) ? response.TopQuality : 0);
		}

		// Token: 0x0603A1B5 RID: 238005 RVA: 0x00DCFCAC File Offset: 0x00DCDEAC
		[NullableContext(2)]
		private void OnDeliveryResponse(GiantMaxLevelDeliveryItemResponse response)
		{
			this.OnDeliveryResponse((response == null) ? null : new Aki.Protocol.ErrorCode?(response.ErrorCode), (response != null) ? response.TopQuality : 0);
		}

		// Token: 0x0603A1B6 RID: 238006 RVA: 0x00DCFCE4 File Offset: 0x00DCDEE4
		private void OnDeliveryResponse(Aki.Protocol.ErrorCode? errorCode, int topQuality)
		{
			if (this.BarTween == null)
			{
				return;
			}
			if (errorCode != null)
			{
				Aki.Protocol.ErrorCode? errorCode2 = errorCode;
				Aki.Protocol.ErrorCode errorCode3 = Aki.Protocol.ErrorCode.Success;
				if (errorCode2.GetValueOrDefault() == errorCode3 & errorCode2 != null)
				{
					this.LastTopQuality = topQuality;
					GiantModel.Instance.SetPendingPicEco(this.EcoType);
					base.CloseMe(null);
					return;
				}
			}
		}

		// Token: 0x0401E4D8 RID: 124120
		private GiantEcoNetType EcoType;

		// Token: 0x0401E4D9 RID: 124121
		private int IncId;

		// Token: 0x0401E4DA RID: 124122
		private int LastTopQuality = -1;

		// Token: 0x0401E4DB RID: 124123
		private int DisplayLevel = 1;

		// Token: 0x0401E4DC RID: 124124
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<GiantCollectItemGrid, GiantCollectItemData> ItemLayout;

		// Token: 0x0401E4DD RID: 124125
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

		// Token: 0x0401E4DE RID: 124126
		[Nullable(2)]
		private PopupCaptionItem Caption;

		// Token: 0x0401E4DF RID: 124127
		[Nullable(2)]
		private GiantLockTipItem LockTip;

		// Token: 0x0401E4E0 RID: 124128
		[Nullable(2)]
		private GiantBarTween BarTween;
	}
}
