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
	// Token: 0x02005768 RID: 22376
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlItemTipsBase : UiPanelBase
	{
		// Token: 0x06037303 RID: 226051 RVA: 0x00F67D7C File Offset: 0x00F65F7C
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

		// Token: 0x06037304 RID: 226052 RVA: 0x00F67E74 File Offset: 0x00F66074
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

		// Token: 0x06037305 RID: 226053 RVA: 0x00F67EE8 File Offset: 0x00F660E8
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

		// Token: 0x06037306 RID: 226054 RVA: 0x00F67F40 File Offset: 0x00F66140
		private static string[] GetStarDescParams(DangoBrawlItem itemConfig)
		{
			string[] array = new string[itemConfig.StarDescParamLength];
			for (int i = 0; i < itemConfig.StarDescParamLength; i++)
			{
				array[i] = (itemConfig.StarDescParam(i) ?? string.Empty);
			}
			return array;
		}

		// Token: 0x06037307 RID: 226055 RVA: 0x00F67F84 File Offset: 0x00F66184
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

		// Token: 0x06037308 RID: 226056 RVA: 0x00F682B0 File Offset: 0x00F664B0
		protected override void OnBeforeCreateImplement()
		{
			this.TipsSequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.TipsSequence);
			this.TipsSequence.AddSequenceStartEvent("Start", new Action<string>(this.OnTipsStartSequenceStart));
			this.TipsSequence.AddSequenceFinishEvent("Close", new Action<string>(this.OnTipsCloseSequenceFinish), false);
		}

		// Token: 0x06037309 RID: 226057 RVA: 0x00F68310 File Offset: 0x00F66510
		protected override void OnStart()
		{
			this.AttrLayout = new GenericLayout<DangoBrawlItemTipsAttrItem, DangoBrawlItemTipsAttrData>(base.GetVerticalLayout(8), new Func<DangoBrawlItemTipsAttrItem>(this.CreateAttrItem), base.GetItem(9).GetOwner() as AUIBaseActor, false, true);
			this.DescLayout = new GenericLayout<DangoBrawlItemTipsDescItem, DangoBrawlItemTipsDescData>(base.GetVerticalLayout(10), new Func<DangoBrawlItemTipsDescItem>(this.CreateDescItem), base.GetItem(11).GetOwner() as AUIBaseActor, false, true);
			ActivityDangoBrawlController.Instance.RegisterTermHyperlink(base.GetText(14));
			base.GetScrollViewWithScrollbar(21).OnLateUpdate.Bind(new Action<float>(this.OnTotalScrollLateUpdate));
			EventSystem.Instance.Add<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
		}

		// Token: 0x0603730A RID: 226058 RVA: 0x00F683D0 File Offset: 0x00F665D0
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

		// Token: 0x0603730B RID: 226059 RVA: 0x00F6842A File Offset: 0x00F6662A
		private DangoBrawlItemTipsAttrItem CreateAttrItem()
		{
			return new DangoBrawlItemTipsAttrItem();
		}

		// Token: 0x0603730C RID: 226060 RVA: 0x00F68431 File Offset: 0x00F66631
		private DangoBrawlItemTipsDescItem CreateDescItem()
		{
			return new DangoBrawlItemTipsDescItem();
		}

		// Token: 0x0603730D RID: 226061 RVA: 0x00F68438 File Offset: 0x00F66638
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

		// Token: 0x0603730E RID: 226062 RVA: 0x00F68484 File Offset: 0x00F66684
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

		// Token: 0x0603730F RID: 226063 RVA: 0x00F684CF File Offset: 0x00F666CF
		private void OnInputControllerMainTypeChange(EInputControllerMainType last, EInputControllerMainType now)
		{
			this.RefreshClickEmptyClose();
		}

		// Token: 0x06037310 RID: 226064 RVA: 0x00F684D8 File Offset: 0x00F666D8
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

		// Token: 0x06037311 RID: 226065 RVA: 0x00F68520 File Offset: 0x00F66720
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

		// Token: 0x06037312 RID: 226066 RVA: 0x00F68570 File Offset: 0x00F66770
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

		// Token: 0x06037313 RID: 226067 RVA: 0x00F68834 File Offset: 0x00F66A34
		private bool IsLastRowGridItem()
		{
			DangoBrawlItemTipsData itemData = this.ItemData;
			PanelPos? panelPos = (itemData != null) ? itemData.ItemLeftTopPos : null;
			return panelPos != null && panelPos.Value.RowIndex >= 5;
		}

		// Token: 0x06037314 RID: 226068 RVA: 0x00F68879 File Offset: 0x00F66A79
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

		// Token: 0x06037315 RID: 226069 RVA: 0x00F688B0 File Offset: 0x00F66AB0
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

		// Token: 0x06037316 RID: 226070 RVA: 0x00F68906 File Offset: 0x00F66B06
		public void SetMaskAttach(UUIButtonComponent maskButton)
		{
			this.MaskButton = maskButton;
		}

		// Token: 0x06037317 RID: 226071 RVA: 0x00F68910 File Offset: 0x00F66B10
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

		// Token: 0x06037318 RID: 226072 RVA: 0x00F68A38 File Offset: 0x00F66C38
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

		// Token: 0x06037319 RID: 226073 RVA: 0x00F68A70 File Offset: 0x00F66C70
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

		// Token: 0x0603731A RID: 226074 RVA: 0x00F68AD0 File Offset: 0x00F66CD0
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

		// Token: 0x0603731B RID: 226075 RVA: 0x00F68B1C File Offset: 0x00F66D1C
		private void OnTipsStartSequenceStart(string _)
		{
			base.SetUiActive(true);
		}

		// Token: 0x0603731C RID: 226076 RVA: 0x00F68B25 File Offset: 0x00F66D25
		private void OnTipsCloseSequenceFinish(string _)
		{
			if (!this.TipsWantVisible)
			{
				base.SetUiActive(false);
			}
		}

		// Token: 0x0603731D RID: 226077 RVA: 0x00F68B38 File Offset: 0x00F66D38
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

		// Token: 0x0603731E RID: 226078 RVA: 0x00F68BA8 File Offset: 0x00F66DA8
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

		// Token: 0x0603731F RID: 226079 RVA: 0x00F68CA8 File Offset: 0x00F66EA8
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

		// Token: 0x0401D29E RID: 119454
		private const int GAP_WITH_STAR = 2;

		// Token: 0x0401D29F RID: 119455
		private const int GAP_WITHOUT_STAR = 1;

		// Token: 0x0401D2A0 RID: 119456
		private const int ADAPTIVE_GAP_RATE = 2;

		// Token: 0x0401D2A1 RID: 119457
		private const int ADAPTIVE_BOTTOM_OFFSET = 300;

		// Token: 0x0401D2A2 RID: 119458
		private const int ADAPTIVE_TOP_OFFSET = 100;

		// Token: 0x0401D2A3 RID: 119459
		private const string DAMAGE_ICON_PATH = "T_DangoBrawl_TipsIconDamage";

		// Token: 0x0401D2A4 RID: 119460
		private const string CD_ICON_PATH = "T_DangoBrawl_TipsIconCd";

		// Token: 0x0401D2A5 RID: 119461
		private const string COST_ICON_PATH = "T_DangoBrawl_TipsIconCost";

		// Token: 0x0401D2A6 RID: 119462
		private const string OCCUPATION_GENERAL_ICON_PATH = "T_DangoBrawl_GeneralOccupation";

		// Token: 0x0401D2A7 RID: 119463
		[Nullable(2)]
		private UUIButtonComponent MaskButton;

		// Token: 0x0401D2A8 RID: 119464
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlItemTipsAttrItem, DangoBrawlItemTipsAttrData> AttrLayout;

		// Token: 0x0401D2A9 RID: 119465
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlItemTipsDescItem, DangoBrawlItemTipsDescData> DescLayout;

		// Token: 0x0401D2AA RID: 119466
		[Nullable(2)]
		private DangoBrawlItemTipsData ItemData;

		// Token: 0x0401D2AB RID: 119467
		[Nullable(2)]
		private UiBehaviorLevelSequence TipsSequence;

		// Token: 0x0401D2AC RID: 119468
		private bool TipsWantVisible;

		// Token: 0x0401D2AD RID: 119469
		private int ShowSeq;

		// Token: 0x0401D2AE RID: 119470
		private bool HoverScrollListenerActive;

		// Token: 0x0401D2AF RID: 119471
		private float LastTipsHeight;

		// Token: 0x0401D2B0 RID: 119472
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<DangoBrawlItemTipsData> OnCombineInfoClick;

		// Token: 0x0401D2B1 RID: 119473
		private readonly Vector2D DefaultVector = Vector2D.Create();

		// Token: 0x0401D2B2 RID: 119474
		private readonly global::Vector WorldVector = global::Vector.Create();

		// Token: 0x0200B374 RID: 45940
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403776C RID: 227180
			TexQuality,
			// Token: 0x0403776D RID: 227181
			TxtName,
			// Token: 0x0403776E RID: 227182
			PnlItemOccupation,
			// Token: 0x0403776F RID: 227183
			TexItemOccupation,
			// Token: 0x04037770 RID: 227184
			TxtItemOccupation,
			// Token: 0x04037771 RID: 227185
			PnlItemType,
			// Token: 0x04037772 RID: 227186
			TexItemType,
			// Token: 0x04037773 RID: 227187
			TxtItemType,
			// Token: 0x04037774 RID: 227188
			AttrLayout,
			// Token: 0x04037775 RID: 227189
			AttrItem,
			// Token: 0x04037776 RID: 227190
			DescLayout,
			// Token: 0x04037777 RID: 227191
			DescItem,
			// Token: 0x04037778 RID: 227192
			PnlLine,
			// Token: 0x04037779 RID: 227193
			StarContentItem,
			// Token: 0x0403777A RID: 227194
			StarDesc,
			// Token: 0x0403777B RID: 227195
			BtnCombineInfo,
			// Token: 0x0403777C RID: 227196
			BtnSell,
			// Token: 0x0403777D RID: 227197
			TxtSell,
			// Token: 0x0403777E RID: 227198
			PnlClickEmptyClose,
			// Token: 0x0403777F RID: 227199
			PnlPcHover,
			// Token: 0x04037780 RID: 227200
			TotalScroll = 21
		}
	}
}
