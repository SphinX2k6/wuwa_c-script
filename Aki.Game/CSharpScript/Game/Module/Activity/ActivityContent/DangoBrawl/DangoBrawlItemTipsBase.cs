using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006818 RID: 26648
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlItemTipsBase : UiPanelBase
	{
		// Token: 0x060427AE RID: 272302 RVA: 0x01026838 File Offset: 0x01024A38
		private List<DangoBrawlItemTipsAttrData> GetAttrList(int damage, float cd, int cost)
		{
			List<DangoBrawlItemTipsAttrData> list = new List<DangoBrawlItemTipsAttrData>();
			if (damage > 0)
			{
				list.Add(new DangoBrawlItemTipsAttrData
				{
					AttrIcon = UiResourceConfig.Instance.GetResourcePath("T_DangoBrawl_TipsIconDamage"),
					AttrName = "DangoBrawlGeneral_1004",
					AttrValue = damage.ToString()
				});
			}
			if (cd > 0f)
			{
				string inString = ConfigMultiTextLang.GetLocalTextNew("DangoBrawlBattleUIText_040", null) ?? "";
				list.Add(new DangoBrawlItemTipsAttrData
				{
					AttrIcon = UiResourceConfig.Instance.GetResourcePath("T_DangoBrawl_TipsIconCd"),
					AttrName = "DangoBrawlGeneral_1005",
					AttrValue = StringUtils.Format(inString, new string[]
					{
						cd.ToString("0.#")
					})
				});
			}
			if (cost > 0)
			{
				list.Add(new DangoBrawlItemTipsAttrData
				{
					AttrIcon = UiResourceConfig.Instance.GetResourcePath("T_DangoBrawl_TipsIconCost"),
					AttrName = "DangoBrawlGeneral_1006",
					AttrValue = cost.ToString()
				});
			}
			return list;
		}

		// Token: 0x060427AF RID: 272303 RVA: 0x01026930 File Offset: 0x01024B30
		private List<DangoBrawlItemTipsDescData> GetDescList(DangoBrawlItem itemConfig)
		{
			List<DangoBrawlItemTipsDescData> list = new List<DangoBrawlItemTipsDescData>();
			for (int i = 0; i < itemConfig.SpeEffectDescLength; i++)
			{
				StringArray? stringArray = (i < itemConfig.SpeEffectDescParamLength) ? itemConfig.SpeEffectDescParam(i) : null;
				list.Add(new DangoBrawlItemTipsDescData
				{
					Desc = (itemConfig.SpeEffectDesc(i) ?? string.Empty),
					DescParams = this.GetStringArray(stringArray)
				});
			}
			return list;
		}

		// Token: 0x060427B0 RID: 272304 RVA: 0x010269A4 File Offset: 0x01024BA4
		private string[] GetStringArray(StringArray? stringArray)
		{
			if (stringArray == null)
			{
				return Array.Empty<string>();
			}
			StringArray value = stringArray.Value;
			string[] array = new string[value.ArrayStringLength];
			for (int i = 0; i < value.ArrayStringLength; i++)
			{
				array[i] = (value.ArrayString(i) ?? string.Empty);
			}
			return array;
		}

		// Token: 0x060427B1 RID: 272305 RVA: 0x010269FC File Offset: 0x01024BFC
		private static string[] GetStarDescParams(DangoBrawlItem itemConfig)
		{
			string[] array = new string[itemConfig.StarDescParamLength];
			for (int i = 0; i < itemConfig.StarDescParamLength; i++)
			{
				array[i] = (itemConfig.StarDescParam(i) ?? string.Empty);
			}
			return array;
		}

		// Token: 0x060427B2 RID: 272306 RVA: 0x01026A40 File Offset: 0x01024C40
		protected unsafe override void OnRegisterComponent()
		{
			int num = 20;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIScrollViewWithScrollbarComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(15, new Action(this.OnCombineInfoBtnClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(16, new Action(this.OnSellBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060427B3 RID: 272307 RVA: 0x01026D6C File Offset: 0x01024F6C
		protected override void OnBeforeCreateImplement()
		{
			this.TipsSequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.TipsSequence);
			this.TipsSequence.AddSequenceStartEvent("Start", new Action<string>(this.OnTipsStartSequenceStart));
			this.TipsSequence.AddSequenceFinishEvent("Close", new Action<string>(this.OnTipsCloseSequenceFinish), false);
		}

		// Token: 0x060427B4 RID: 272308 RVA: 0x01026DCC File Offset: 0x01024FCC
		protected override void OnStart()
		{
			this.AttrLayout = new GenericLayout<DangoBrawlItemTipsAttrItem, DangoBrawlItemTipsAttrData>(base.GetVerticalLayout(8), new Func<DangoBrawlItemTipsAttrItem>(this.CreateAttrItem), base.GetItem(9).GetOwner() as AUIBaseActor, false, true);
			this.DescLayout = new GenericLayout<DangoBrawlItemTipsDescItem, DangoBrawlItemTipsDescData>(base.GetVerticalLayout(10), new Func<DangoBrawlItemTipsDescItem>(this.CreateDescItem), base.GetItem(11).GetOwner() as AUIBaseActor, false, true);
			ActivityDangoBrawlController.Instance.RegisterTermHyperlink(base.GetText(14));
			base.GetScrollViewWithScrollbar(21).OnLateUpdate.Bind(new Action<float>(this.OnTotalScrollLateUpdate));
			EventSystem.Instance.Add<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
		}

		// Token: 0x060427B5 RID: 272309 RVA: 0x01026E8C File Offset: 0x0102508C
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(21);
			if (scrollViewWithScrollbar != null)
			{
				scrollViewWithScrollbar.OnLateUpdate.Unbind();
			}
			this.SetHoverScrollListenerActive(false);
			ActivityDangoBrawlController.Instance.UnRegisterTermHyperlink(base.GetText(14));
		}

		// Token: 0x060427B6 RID: 272310 RVA: 0x01026EE6 File Offset: 0x010250E6
		private DangoBrawlItemTipsAttrItem CreateAttrItem()
		{
			return new DangoBrawlItemTipsAttrItem();
		}

		// Token: 0x060427B7 RID: 272311 RVA: 0x01026EED File Offset: 0x010250ED
		private DangoBrawlItemTipsDescItem CreateDescItem()
		{
			return new DangoBrawlItemTipsDescItem();
		}

		// Token: 0x060427B8 RID: 272312 RVA: 0x01026EF4 File Offset: 0x010250F4
		public UniTask RefreshAndShow(DangoBrawlItemTipsData data)
		{
			DangoBrawlItemTipsBase.<RefreshAndShow>d__32 <RefreshAndShow>d__;
			<RefreshAndShow>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAndShow>d__.<>4__this = this;
			<RefreshAndShow>d__.data = data;
			<RefreshAndShow>d__.<>1__state = -1;
			<RefreshAndShow>d__.<>t__builder.Start<DangoBrawlItemTipsBase.<RefreshAndShow>d__32>(ref <RefreshAndShow>d__);
			return <RefreshAndShow>d__.<>t__builder.Task;
		}

		// Token: 0x060427B9 RID: 272313 RVA: 0x01026F40 File Offset: 0x01025140
		public UniTask Refresh(DangoBrawlItemTipsData data)
		{
			DangoBrawlItemTipsBase.<Refresh>d__33 <Refresh>d__;
			<Refresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Refresh>d__.<>4__this = this;
			<Refresh>d__.data = data;
			<Refresh>d__.<>1__state = -1;
			<Refresh>d__.<>t__builder.Start<DangoBrawlItemTipsBase.<Refresh>d__33>(ref <Refresh>d__);
			return <Refresh>d__.<>t__builder.Task;
		}

		// Token: 0x060427BA RID: 272314 RVA: 0x01026F8B File Offset: 0x0102518B
		private void OnInputControllerMainTypeChange(EInputControllerMainType last, EInputControllerMainType now)
		{
			this.RefreshClickEmptyClose();
		}

		// Token: 0x060427BB RID: 272315 RVA: 0x01026F94 File Offset: 0x01025194
		private void RefreshClickEmptyClose()
		{
			DangoBrawlItemTipsData itemData = this.ItemData;
			bool uiactive = itemData != null && itemData.OperationMode == EDangoBrawlTipsOperationMode.Selected && !Info.Instance.IsInGamepad();
			UUIItem item = base.GetItem(18);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(uiactive);
		}

		// Token: 0x060427BC RID: 272316 RVA: 0x01026FDC File Offset: 0x010251DC
		private void OnTotalScrollLateUpdate(float _)
		{
			if (this.ItemData != null)
			{
				UUIItem rootItem = this.RootItem;
				if (rootItem != null && rootItem.IsValid())
				{
					float height = this.RootItem.GetHeight();
					if (height == this.LastTipsHeight)
					{
						return;
					}
					this.LastTipsHeight = height;
					this.CheckTipsLocation();
					return;
				}
			}
		}

		// Token: 0x060427BD RID: 272317 RVA: 0x0102702C File Offset: 0x0102522C
		private void CheckTipsLocation()
		{
			if (this.ItemData != null)
			{
				UUIItem rootItem = this.RootItem;
				if (rootItem != null && rootItem.IsValid())
				{
					EDangoBrawlItemTipsFrom from = this.ItemData.From;
					if (from == EDangoBrawlItemTipsFrom.Fixed)
					{
						return;
					}
					UUIItem gridItem = this.ItemData.GridItem;
					if (gridItem == null)
					{
						return;
					}
					float num = this.ItemData.GridSize.GetValueOrDefault();
					if (num == 0f)
					{
						num = gridItem.Width;
					}
					float num2 = (float)this.GetTipsGapGridCount() * num;
					float width = this.RootItem.GetWidth();
					FVector uiworldPosition = gridItem.GetUIWorldPosition();
					float num3 = width / 2f;
					float num4 = gridItem.Width / 2f;
					float num5 = this.ItemData.ChangeY ?? uiworldPosition.Z;
					if (from == EDangoBrawlItemTipsFrom.Shop)
					{
						this.DefaultVector.Set(0.5, 1.0);
						this.RootItem.SetPivot(this.DefaultVector.ToUeVector2D(false));
						float num6 = uiworldPosition.X - num4 - num3;
						this.WorldVector.X = (double)(num6 - num2);
						this.WorldVector.Z = (double)num5;
						UUIItem rootItem2 = this.RootItem;
						FVector fvector = this.WorldVector.ToUeVectorOld();
						rootItem2.SetUIWorldLocation(fvector);
						return;
					}
					if (from == EDangoBrawlItemTipsFrom.Bag)
					{
						this.DefaultVector.Set(0.5, 1.0);
						this.RootItem.SetPivot(this.DefaultVector.ToUeVector2D(false));
						float num7 = uiworldPosition.X + num4 + num3;
						this.WorldVector.X = (double)(num7 + num2);
						this.WorldVector.Z = (double)num5;
						UUIItem rootItem3 = this.RootItem;
						FVector fvector = this.WorldVector.ToUeVectorOld();
						rootItem3.SetUIWorldLocation(fvector);
						return;
					}
					if (from == EDangoBrawlItemTipsFrom.Bench)
					{
						this.DefaultVector.Set(0.5, 0.0);
						this.RootItem.SetPivot(this.DefaultVector.ToUeVector2D(false));
						float realWidth = (float)(this.GetTipsGapGridCount() * 2) * num + width;
						global::Vector adaptiveTipsPositionByParam = LguiUtil.Instance.GetAdaptiveTipsPositionByParam(gridItem, this.RootItem, new AdaptiveTipsPositionParam
						{
							RealWidth = realWidth
						});
						adaptiveTipsPositionByParam.Z = (double)num5;
						UUIItem rootItem4 = this.RootItem;
						FVector fvector = adaptiveTipsPositionByParam.ToUeVectorOld();
						rootItem4.SetUIWorldLocation(fvector);
						return;
					}
					if (from == EDangoBrawlItemTipsFrom.Battle)
					{
						float realWidth2 = 2f * num + width;
						AdaptiveTipsPositionParam adaptiveTipsPositionParam = new AdaptiveTipsPositionParam
						{
							RealWidth = realWidth2,
							BottomOffset = 300f
						};
						if (this.IsLastRowGridItem())
						{
							adaptiveTipsPositionParam.TopOffset = 100f;
						}
						global::Vector adaptiveTipsPositionByParam2 = LguiUtil.Instance.GetAdaptiveTipsPositionByParam(gridItem, this.RootItem, adaptiveTipsPositionParam);
						UUIItem rootItem5 = this.RootItem;
						FVector fvector = adaptiveTipsPositionByParam2.ToUeVectorOld();
						rootItem5.SetUIWorldLocation(fvector);
					}
					return;
				}
			}
		}

		// Token: 0x060427BE RID: 272318 RVA: 0x010272F0 File Offset: 0x010254F0
		private bool IsLastRowGridItem()
		{
			DangoBrawlItemTipsData itemData = this.ItemData;
			PanelPos? panelPos = (itemData != null) ? itemData.ItemLeftTopPos : null;
			return panelPos != null && panelPos.Value.RowIndex >= 5;
		}

		// Token: 0x060427BF RID: 272319 RVA: 0x01027335 File Offset: 0x01025535
		private int GetTipsGapGridCount()
		{
			if (this.ItemData == null || this.ItemData.ItemId <= 0)
			{
				return 1;
			}
			if (DangoBrawlUtil.GetTemplateStarPanelPosList(DangoBrawlUtil.GetTemplateId(this.ItemData.ItemId)).Length == 0)
			{
				return 1;
			}
			return 2;
		}

		// Token: 0x060427C0 RID: 272320 RVA: 0x0102736C File Offset: 0x0102556C
		public void SetAutoLocation(UUIItem gridItem, float gridSize, float changeY)
		{
			float num = (float)(this.GetTipsGapGridCount() * 2) * gridSize;
			float width = this.RootItem.GetWidth();
			float realWidth = num + width;
			global::Vector adaptiveTipsPosition = LguiUtil.Instance.GetAdaptiveTipsPosition(gridItem, this.RootItem, realWidth);
			adaptiveTipsPosition.Z = (double)changeY;
			UUIItem rootItem = this.RootItem;
			FVector fvector = adaptiveTipsPosition.ToUeVectorOld();
			rootItem.SetUIWorldLocation(fvector);
		}

		// Token: 0x060427C1 RID: 272321 RVA: 0x010273C2 File Offset: 0x010255C2
		public void SetMaskAttach(UUIButtonComponent maskButton)
		{
			this.MaskButton = maskButton;
		}

		// Token: 0x060427C2 RID: 272322 RVA: 0x010273CC File Offset: 0x010255CC
		public void SetTipsVisible(bool isVisible)
		{
			if (isVisible)
			{
				DangoBrawlItemTipsData itemData = this.ItemData;
				bool uiactive = itemData == null || itemData.OperationMode != EDangoBrawlTipsOperationMode.Hover;
				UUIButtonComponent maskButton = this.MaskButton;
				if (maskButton != null)
				{
					UUIItem uuiitem = maskButton.RootUIComp.Get();
					if (uuiitem != null)
					{
						uuiitem.SetUIActive(uiactive);
					}
				}
				if (this.TipsWantVisible)
				{
					this.UpdateHoverScrollListener();
					return;
				}
				this.TipsWantVisible = true;
				UiBehaviorLevelSequence tipsSequence = this.TipsSequence;
				if (tipsSequence != null)
				{
					tipsSequence.StopSequenceByKey("Close", false, false);
				}
				UiBehaviorLevelSequence tipsSequence2 = this.TipsSequence;
				if (tipsSequence2 != null)
				{
					tipsSequence2.PlaySequence("Start", false, null);
				}
				this.UpdateHoverScrollListener();
				return;
			}
			else
			{
				this.ShowSeq++;
				UUIButtonComponent maskButton2 = this.MaskButton;
				if (maskButton2 != null)
				{
					UUIItem uuiitem2 = maskButton2.RootUIComp.Get();
					if (uuiitem2 != null)
					{
						uuiitem2.SetUIActive(false);
					}
				}
				if (!this.TipsWantVisible)
				{
					base.SetUiActive(false);
					this.SetHoverScrollListenerActive(false);
					return;
				}
				this.TipsWantVisible = false;
				UiBehaviorLevelSequence tipsSequence3 = this.TipsSequence;
				if (tipsSequence3 != null)
				{
					tipsSequence3.PlaySequence("Close", false, null);
				}
				this.ItemData = null;
				this.SetHoverScrollListenerActive(false);
				return;
			}
		}

		// Token: 0x060427C3 RID: 272323 RVA: 0x010274F4 File Offset: 0x010256F4
		private void UpdateHoverScrollListener()
		{
			bool flag;
			if (this.TipsWantVisible)
			{
				DangoBrawlItemTipsData itemData = this.ItemData;
				flag = (itemData != null && itemData.OperationMode == EDangoBrawlTipsOperationMode.Hover);
			}
			else
			{
				flag = false;
			}
			bool hoverScrollListenerActive = flag;
			this.SetHoverScrollListenerActive(hoverScrollListenerActive);
		}

		// Token: 0x060427C4 RID: 272324 RVA: 0x0102752C File Offset: 0x0102572C
		private void SetHoverScrollListenerActive(bool active)
		{
			if (!Info.Instance.IsPcPlatform() || this.HoverScrollListenerActive == active)
			{
				return;
			}
			ULGUIEventSystem lguiEventSystem = LguiEventSystemManager.Instance.LguiEventSystem;
			if (lguiEventSystem == null)
			{
				return;
			}
			this.HoverScrollListenerActive = active;
			if (active)
			{
				lguiEventSystem.OnScrollTriggeredDelegate.Bind(new Action<ULGUIPointerEventData>(this.OnHoverScrollTriggered));
				return;
			}
			lguiEventSystem.OnScrollTriggeredDelegate.Unbind();
		}

		// Token: 0x060427C5 RID: 272325 RVA: 0x0102758C File Offset: 0x0102578C
		[NullableContext(2)]
		private void OnHoverScrollTriggered(ULGUIPointerEventData eventData)
		{
			if (this.TipsWantVisible)
			{
				DangoBrawlItemTipsData itemData = this.ItemData;
				if (itemData != null && itemData.OperationMode == EDangoBrawlTipsOperationMode.Hover)
				{
					UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(21);
					if (scrollViewWithScrollbar == null || !scrollViewWithScrollbar.IsValid())
					{
						return;
					}
					scrollViewWithScrollbar.TriggerScrollEventManually(eventData);
					return;
				}
			}
		}

		// Token: 0x060427C6 RID: 272326 RVA: 0x010275D8 File Offset: 0x010257D8
		private void OnTipsStartSequenceStart(string _)
		{
			base.SetUiActive(true);
		}

		// Token: 0x060427C7 RID: 272327 RVA: 0x010275E1 File Offset: 0x010257E1
		private void OnTipsCloseSequenceFinish(string _)
		{
			if (!this.TipsWantVisible)
			{
				base.SetUiActive(false);
			}
		}

		// Token: 0x060427C8 RID: 272328 RVA: 0x010275F4 File Offset: 0x010257F4
		private void OnCombineInfoBtnClick()
		{
			if (this.ItemData == null || this.ItemData.ItemId <= 0 || !DangoBrawlCombineUtil.HasCombineInfo(this.ItemData.ItemId))
			{
				return;
			}
			if (this.OnCombineInfoClick == null)
			{
				Log.Instance.Warn(ELogModule.DangoBrawl, ELogAuthor.WHJ, "ItemTips 未设置 OnCombineInfoClick，无法打开合成界面", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.OnCombineInfoClick(this.ItemData);
		}

		// Token: 0x060427C9 RID: 272329 RVA: 0x01027664 File Offset: 0x01025864
		private void OnSellBtnClick()
		{
			if (this.ItemData == null)
			{
				return;
			}
			int? itemUid = this.ItemData.ItemUid;
			if (itemUid == null || itemUid.GetValueOrDefault() <= 0)
			{
				return;
			}
			bool isFromBench = this.ItemData.From == EDangoBrawlItemTipsFrom.Bench;
			int valueOrDefault = ConfigCommonParamById.GetIntConfig("DangoBrawlSellItemQuality").GetValueOrDefault();
			DangoBrawlItem? itemConfigById = DangoBrawlConfig.Instance.GetItemConfigById(this.ItemData.ItemId);
			if (((itemConfigById != null) ? itemConfigById.GetValueOrDefault().Quality : 0) >= valueOrDefault)
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.DangoBrawlSellConfirm);
				confirmBoxDataNew.FunctionMap[2] = delegate()
				{
					ActivityDangoBrawlController instance2 = ActivityDangoBrawlController.Instance;
					if (instance2 == null)
					{
						return;
					}
					instance2.RequestShopSell(itemUid.Value, isFromBench, null, false).Forget<bool>();
				};
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			ActivityDangoBrawlController instance = ActivityDangoBrawlController.Instance;
			if (instance == null)
			{
				return;
			}
			instance.RequestShopSell(itemUid.Value, isFromBench, null, false).Forget<bool>();
		}

		// Token: 0x060427CA RID: 272330 RVA: 0x01027764 File Offset: 0x01025964
		[NullableContext(2)]
		public UUIItem GetCombineInfoBtnItem()
		{
			UUIButtonComponent button = base.GetButton(15);
			if (button == null)
			{
				return null;
			}
			return button.RootUIComp.Get();
		}

		// Token: 0x04022A41 RID: 141889
		private const int GAP_WITH_STAR = 2;

		// Token: 0x04022A42 RID: 141890
		private const int GAP_WITHOUT_STAR = 1;

		// Token: 0x04022A43 RID: 141891
		private const int ADAPTIVE_GAP_RATE = 2;

		// Token: 0x04022A44 RID: 141892
		private const int ADAPTIVE_BOTTOM_OFFSET = 300;

		// Token: 0x04022A45 RID: 141893
		private const int ADAPTIVE_TOP_OFFSET = 100;

		// Token: 0x04022A46 RID: 141894
		private const string DAMAGE_ICON_PATH = "T_DangoBrawl_TipsIconDamage";

		// Token: 0x04022A47 RID: 141895
		private const string CD_ICON_PATH = "T_DangoBrawl_TipsIconCd";

		// Token: 0x04022A48 RID: 141896
		private const string COST_ICON_PATH = "T_DangoBrawl_TipsIconCost";

		// Token: 0x04022A49 RID: 141897
		private const string OCCUPATION_GENERAL_ICON_PATH = "T_DangoBrawl_GeneralOccupation";

		// Token: 0x04022A4A RID: 141898
		[Nullable(2)]
		private UUIButtonComponent MaskButton;

		// Token: 0x04022A4B RID: 141899
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlItemTipsAttrItem, DangoBrawlItemTipsAttrData> AttrLayout;

		// Token: 0x04022A4C RID: 141900
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlItemTipsDescItem, DangoBrawlItemTipsDescData> DescLayout;

		// Token: 0x04022A4D RID: 141901
		[Nullable(2)]
		private DangoBrawlItemTipsData ItemData;

		// Token: 0x04022A4E RID: 141902
		[Nullable(2)]
		private UiBehaviorLevelSequence TipsSequence;

		// Token: 0x04022A4F RID: 141903
		private bool TipsWantVisible;

		// Token: 0x04022A50 RID: 141904
		private int ShowSeq;

		// Token: 0x04022A51 RID: 141905
		private bool HoverScrollListenerActive;

		// Token: 0x04022A52 RID: 141906
		private float LastTipsHeight;

		// Token: 0x04022A53 RID: 141907
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<DangoBrawlItemTipsData> OnCombineInfoClick;

		// Token: 0x04022A54 RID: 141908
		private readonly Vector2D DefaultVector = Vector2D.Create();

		// Token: 0x04022A55 RID: 141909
		private readonly global::Vector WorldVector = global::Vector.Create();

		// Token: 0x0200C9A7 RID: 51623
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403CE7F RID: 249471
			TexQuality,
			// Token: 0x0403CE80 RID: 249472
			TxtName,
			// Token: 0x0403CE81 RID: 249473
			PnlItemOccupation,
			// Token: 0x0403CE82 RID: 249474
			TexItemOccupation,
			// Token: 0x0403CE83 RID: 249475
			TxtItemOccupation,
			// Token: 0x0403CE84 RID: 249476
			PnlItemType,
			// Token: 0x0403CE85 RID: 249477
			TexItemType,
			// Token: 0x0403CE86 RID: 249478
			TxtItemType,
			// Token: 0x0403CE87 RID: 249479
			AttrLayout,
			// Token: 0x0403CE88 RID: 249480
			AttrItem,
			// Token: 0x0403CE89 RID: 249481
			DescLayout,
			// Token: 0x0403CE8A RID: 249482
			DescItem,
			// Token: 0x0403CE8B RID: 249483
			PnlLine,
			// Token: 0x0403CE8C RID: 249484
			StarContentItem,
			// Token: 0x0403CE8D RID: 249485
			StarDesc,
			// Token: 0x0403CE8E RID: 249486
			BtnCombineInfo,
			// Token: 0x0403CE8F RID: 249487
			BtnSell,
			// Token: 0x0403CE90 RID: 249488
			TxtSell,
			// Token: 0x0403CE91 RID: 249489
			PnlClickEmptyClose,
			// Token: 0x0403CE92 RID: 249490
			PnlPcHover,
			// Token: 0x0403CE93 RID: 249491
			TotalScroll = 21
		}
	}
}
