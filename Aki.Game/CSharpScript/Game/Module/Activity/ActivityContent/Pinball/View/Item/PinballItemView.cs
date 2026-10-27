using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item.ItemComponent;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item
{
	// Token: 0x0200634F RID: 25423
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballItemView : UiPanelBase
	{
		// Token: 0x0603FF95 RID: 262037 RVA: 0x00F7A428 File Offset: 0x00F78628
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603FF96 RID: 262038 RVA: 0x00F7A59C File Offset: 0x00F7879C
		protected override void OnStart()
		{
			this.SpriteQualityList = new UUISprite[]
			{
				base.GetSprite(1),
				base.GetSprite(2),
				base.GetSprite(3),
				base.GetSprite(4)
			};
			this.BindToggle();
			UUIExtendToggle itemToggle = this.GetItemToggle();
			if (itemToggle != null)
			{
				this.LongPressButton = new LongPressButtonItem(null, null, null);
				this.LongPressButton.Initialize(itemToggle, new Action<bool>(this.OnLongPressActivate), new Action(this.ExtendTogglePress), new Action(this.ExtendToggleRelease), null);
				this.LongPressButton.SetTickConditionDelegate(new Func<bool>(this.CanItemLongPressClick));
			}
		}

		// Token: 0x0603FF97 RID: 262039 RVA: 0x00F7A658 File Offset: 0x00F78858
		protected override void OnBeforeDestroy()
		{
			PinballShopItemNewTagView shopNewTagView = this.ShopNewTagView;
			if (shopNewTagView != null)
			{
				shopNewTagView.DestroyAsync().Forget<bool>();
			}
			this.ShopNewTagView = null;
			this.UnBindToggle();
			LongPressButtonItem longPressButton = this.LongPressButton;
			if (longPressButton != null)
			{
				longPressButton.Clear();
			}
			this.LongPressButton = null;
		}

		// Token: 0x0603FF98 RID: 262040 RVA: 0x00F7A698 File Offset: 0x00F78898
		public UniTask Apply(object data)
		{
			PinballItemView.<Apply>d__24 <Apply>d__;
			<Apply>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Apply>d__.<>4__this = this;
			<Apply>d__.data = data;
			<Apply>d__.<>1__state = -1;
			<Apply>d__.<>t__builder.Start<PinballItemView.<Apply>d__24>(ref <Apply>d__);
			return <Apply>d__.<>t__builder.Task;
		}

		// Token: 0x0603FF99 RID: 262041 RVA: 0x00F7A6E4 File Offset: 0x00F788E4
		public void RefreshByShopData(object data)
		{
			CommonGameplayShopItemProxy commonGameplayShopItemProxy = data as CommonGameplayShopItemProxy;
			if (commonGameplayShopItemProxy == null)
			{
				return;
			}
			this.RefreshShopItemIcon(commonGameplayShopItemProxy);
			this.RefreshShopItemName(commonGameplayShopItemProxy);
			this.RefreshShopQualityColor(commonGameplayShopItemProxy);
			PayShopGoods goodsData = commonGameplayShopItemProxy.GoodsData;
			int? num;
			if (goodsData == null)
			{
				num = null;
			}
			else
			{
				CSharpScript.Game.Module.PayShop.IItemData itemData = goodsData.GetItemData();
				num = ((itemData != null) ? new int?(itemData.Quality) : null);
			}
			int? num2 = num;
			this.RefreshRainbow(num2.GetValueOrDefault() == 5);
			this.RefreshShopContentText(commonGameplayShopItemProxy);
			this.SyncShopNewTagAsync(commonGameplayShopItemProxy).Forget();
		}

		// Token: 0x0603FF9A RID: 262042 RVA: 0x00F7A768 File Offset: 0x00F78968
		private void RefreshShopItemIcon(CommonGameplayShopItemProxy proxy)
		{
			UUITexture texture = base.GetTexture(6);
			if (texture == null)
			{
				return;
			}
			texture.SetUIActive(proxy.ItemTextureVisible);
			if (proxy.ItemTextureVisible)
			{
				if (proxy.ItemId > 0)
				{
					base.SetItemIcon(texture, proxy.ItemId, null, null);
					return;
				}
				if (proxy.ItemTexturePath != null)
				{
					base.SetTextureByPath(proxy.ItemTexturePath, texture, null, null);
				}
			}
		}

		// Token: 0x0603FF9B RID: 262043 RVA: 0x00F7A7D8 File Offset: 0x00F789D8
		private void RefreshShopItemName(CommonGameplayShopItemProxy proxy)
		{
			UUIText text = base.GetText(7);
			if (text != null)
			{
				GameplayShopUtil.SetText(text, proxy.ItemNameTextData);
			}
		}

		// Token: 0x0603FF9C RID: 262044 RVA: 0x00F7A7FC File Offset: 0x00F789FC
		private void RefreshShopQualityColor(CommonGameplayShopItemProxy proxy)
		{
			PayShopGoods goodsData = proxy.GoodsData;
			int? num;
			if (goodsData == null)
			{
				num = null;
			}
			else
			{
				CSharpScript.Game.Module.PayShop.IItemData itemData = goodsData.GetItemData();
				num = ((itemData != null) ? new int?(itemData.Quality) : null);
			}
			int? num2 = num;
			if (num2 == null)
			{
				return;
			}
			string[] colorList;
			if (!PinballItemView.qualityColorListMap.TryGetValue(num2.Value, out colorList))
			{
				return;
			}
			this.RefreshColor(colorList);
		}

		// Token: 0x0603FF9D RID: 262045 RVA: 0x00F7A864 File Offset: 0x00F78A64
		private void RefreshShopContentText(CommonGameplayShopItemProxy proxy)
		{
			UUIItem item = base.GetItem(8);
			if (item != null)
			{
				PayShopGoods goodsData = proxy.GoodsData;
				int num = (goodsData != null) ? goodsData.GetGoodsId() : 0;
				bool flag = NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.PayShopTabItemChecked, num);
				bool flag2 = num > 0 && !flag;
				item.SetUIActive(proxy.BuyLimitCountTextVisible || flag2);
			}
		}

		// Token: 0x0603FF9E RID: 262046 RVA: 0x00F7A8B8 File Offset: 0x00F78AB8
		private UniTask ClearShopNewTagAsync()
		{
			PinballItemView.<ClearShopNewTagAsync>d__30 <ClearShopNewTagAsync>d__;
			<ClearShopNewTagAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ClearShopNewTagAsync>d__.<>4__this = this;
			<ClearShopNewTagAsync>d__.<>1__state = -1;
			<ClearShopNewTagAsync>d__.<>t__builder.Start<PinballItemView.<ClearShopNewTagAsync>d__30>(ref <ClearShopNewTagAsync>d__);
			return <ClearShopNewTagAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FF9F RID: 262047 RVA: 0x00F7A8FC File Offset: 0x00F78AFC
		private UniTask SyncShopNewTagAsync(CommonGameplayShopItemProxy proxy)
		{
			PinballItemView.<SyncShopNewTagAsync>d__31 <SyncShopNewTagAsync>d__;
			<SyncShopNewTagAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SyncShopNewTagAsync>d__.<>4__this = this;
			<SyncShopNewTagAsync>d__.proxy = proxy;
			<SyncShopNewTagAsync>d__.<>1__state = -1;
			<SyncShopNewTagAsync>d__.<>t__builder.Start<PinballItemView.<SyncShopNewTagAsync>d__31>(ref <SyncShopNewTagAsync>d__);
			return <SyncShopNewTagAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FFA0 RID: 262048 RVA: 0x00F7A948 File Offset: 0x00F78B48
		protected void ApplyTypeItem(IPinballItemDataItem data)
		{
			this.ApplyBase();
			ItemConfig instance = ItemConfig.Instance;
			ItemInfo? itemInfo = (instance != null) ? instance.GetConfig(data.Item.ItemData.ItemId) : null;
			if (itemInfo == null)
			{
				return;
			}
			base.TrySetTextureByPath(itemInfo.Value.Icon, base.GetTexture(6), null, null);
			this.RefreshTxt(data.Item.Count.ToString());
			string[] colorList;
			if (!PinballItemView.qualityColorListMap.TryGetValue(itemInfo.Value.QualityId, out colorList))
			{
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.PinballBattle;
				ELogAuthor author = ELogAuthor.CB;
				string message = "没有对应品质颜色列表";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("qualityId", itemInfo.Value.QualityId);
				instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.RefreshColor(colorList);
			this.RefreshRainbow(itemInfo.Value.QualityId == 5);
		}

		// Token: 0x0603FFA1 RID: 262049 RVA: 0x00F7AA50 File Offset: 0x00F78C50
		protected UniTask ApplyTypeRole(IPinballItemDataRole data)
		{
			PinballItemView.<ApplyTypeRole>d__33 <ApplyTypeRole>d__;
			<ApplyTypeRole>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ApplyTypeRole>d__.<>4__this = this;
			<ApplyTypeRole>d__.data = data;
			<ApplyTypeRole>d__.<>1__state = -1;
			<ApplyTypeRole>d__.<>t__builder.Start<PinballItemView.<ApplyTypeRole>d__33>(ref <ApplyTypeRole>d__);
			return <ApplyTypeRole>d__.<>t__builder.Task;
		}

		// Token: 0x0603FFA2 RID: 262050 RVA: 0x00F7AA9C File Offset: 0x00F78C9C
		protected UniTask ApplyTypeWeapon(IPinballItemDataWeapon data)
		{
			PinballItemView.<ApplyTypeWeapon>d__34 <ApplyTypeWeapon>d__;
			<ApplyTypeWeapon>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ApplyTypeWeapon>d__.<>4__this = this;
			<ApplyTypeWeapon>d__.data = data;
			<ApplyTypeWeapon>d__.<>1__state = -1;
			<ApplyTypeWeapon>d__.<>t__builder.Start<PinballItemView.<ApplyTypeWeapon>d__34>(ref <ApplyTypeWeapon>d__);
			return <ApplyTypeWeapon>d__.<>t__builder.Task;
		}

		// Token: 0x0603FFA3 RID: 262051 RVA: 0x00F7AAE8 File Offset: 0x00F78CE8
		protected void ApplyTypeMonster(IPinballItemDataMonster data)
		{
			this.ApplyBase();
			PinballConfig instance = PinballConfig.Instance;
			PinballMonsterType? pinballMonsterType = (instance != null) ? instance.GetPinballMonsterTypeConfigById(data.Id) : null;
			if (pinballMonsterType == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.PinballBattle;
				ELogAuthor author = ELogAuthor.CB;
				string message = "没有对应怪物配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", data.Id);
				instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			int key = 1;
			switch (pinballMonsterType.Value.RiskType)
			{
			case 1:
				key = 2;
				break;
			case 2:
				key = 3;
				break;
			case 3:
				key = 4;
				break;
			}
			string[] colorList;
			PinballItemView.qualityColorListMap.TryGetValue(key, out colorList);
			this.RefreshColor(colorList);
			this.RefreshRainbow(false);
			this.RefreshTxtByTextId(pinballMonsterType.Value.Name);
			base.TrySetTextureByPath(pinballMonsterType.Value.Icon, base.GetTexture(6), null, null);
		}

		// Token: 0x0603FFA4 RID: 262052 RVA: 0x00F7ABEC File Offset: 0x00F78DEC
		protected void ApplyBase()
		{
			base.TrySetSpriteByPath("/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity33/CatapultStory/ComItem/SP_ComItemBg3.SP_ComItemBg3", base.GetSprite(3), false, null, null);
			this.RefreshRainbow(false);
		}

		// Token: 0x0603FFA5 RID: 262053 RVA: 0x00F7AC20 File Offset: 0x00F78E20
		protected void RefreshColor(string[] colorList)
		{
			for (int i = 0; i < colorList.Length; i++)
			{
				this.SpriteQualityList[i].SetColor(FColor.FromHex(colorList[i]));
			}
		}

		// Token: 0x0603FFA6 RID: 262054 RVA: 0x00F7AC50 File Offset: 0x00F78E50
		protected void RefreshRainbow(bool bShow)
		{
			UUISprite sprite = base.GetSprite(5);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(bShow);
		}

		// Token: 0x0603FFA7 RID: 262055 RVA: 0x00F7AC64 File Offset: 0x00F78E64
		protected void RefreshTxt(string txt)
		{
			UUIText text = base.GetText(7);
			if (text == null)
			{
				return;
			}
			text.SetText(txt, true);
		}

		// Token: 0x0603FFA8 RID: 262056 RVA: 0x00F7AC79 File Offset: 0x00F78E79
		protected void RefreshTxtByTextId(string textId)
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(7), textId, Array.Empty<object>());
		}

		// Token: 0x0603FFA9 RID: 262057 RVA: 0x00F7AC92 File Offset: 0x00F78E92
		protected void RefreshTxtByTableTextArgNew(TableTextArgNew bottomText)
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(7), bottomText.TextKey, bottomText.Params);
		}

		// Token: 0x0603FFAA RID: 262058 RVA: 0x00F7ACB4 File Offset: 0x00F78EB4
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		protected UniTask<PinballItemGridComponentBase> RefreshComponent(Type gridClass, bool bNewIfNull, EPinballItemComponentLayer layer, params object[] args)
		{
			PinballItemView.<RefreshComponent>d__44 <RefreshComponent>d__;
			<RefreshComponent>d__.<>t__builder = AsyncUniTaskMethodBuilder<PinballItemGridComponentBase>.Create();
			<RefreshComponent>d__.<>4__this = this;
			<RefreshComponent>d__.gridClass = gridClass;
			<RefreshComponent>d__.bNewIfNull = bNewIfNull;
			<RefreshComponent>d__.layer = layer;
			<RefreshComponent>d__.args = args;
			<RefreshComponent>d__.<>1__state = -1;
			<RefreshComponent>d__.<>t__builder.Start<PinballItemView.<RefreshComponent>d__44>(ref <RefreshComponent>d__);
			return <RefreshComponent>d__.<>t__builder.Task;
		}

		// Token: 0x0603FFAB RID: 262059 RVA: 0x00F7AD18 File Offset: 0x00F78F18
		[return: Nullable(2)]
		private PinballItemGridComponentBase GetComponentByType(Type ctor)
		{
			PinballItemGridComponentBase result;
			if (!this.ComponentMap.TryGetValue(ctor, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0603FFAC RID: 262060 RVA: 0x00F7AD38 File Offset: 0x00F78F38
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<PinballItemGridComponentBase> CreateComponent(Type componentClass, EPinballItemComponentLayer layer = EPinballItemComponentLayer.Normal)
		{
			PinballItemView.<CreateComponent>d__46 <CreateComponent>d__;
			<CreateComponent>d__.<>t__builder = AsyncUniTaskMethodBuilder<PinballItemGridComponentBase>.Create();
			<CreateComponent>d__.<>4__this = this;
			<CreateComponent>d__.componentClass = componentClass;
			<CreateComponent>d__.layer = layer;
			<CreateComponent>d__.<>1__state = -1;
			<CreateComponent>d__.<>t__builder.Start<PinballItemView.<CreateComponent>d__46>(ref <CreateComponent>d__);
			return <CreateComponent>d__.<>t__builder.Task;
		}

		// Token: 0x0603FFAD RID: 262061 RVA: 0x00F7AD8B File Offset: 0x00F78F8B
		private UUIItem GetParentItem(EPinballItemComponentLayer layer)
		{
			if (layer == EPinballItemComponentLayer.Normal)
			{
				return base.GetItem(8);
			}
			if (layer != EPinballItemComponentLayer.Top)
			{
				return base.GetItem(8);
			}
			return base.GetItem(9);
		}

		// Token: 0x0603FFAE RID: 262062 RVA: 0x00F7ADAE File Offset: 0x00F78FAE
		private void OnComponentVisibleChanged(PinballItemGridComponentBase component, bool bVisible)
		{
			if (bVisible)
			{
				this.VisibleComponents.Add(component);
				return;
			}
			this.VisibleComponents.Remove(component);
		}

		// Token: 0x0603FFAF RID: 262063 RVA: 0x00F7ADCE File Offset: 0x00F78FCE
		private void ClearVisibleComponent()
		{
			this.VisibleComponents.Clear();
		}

		// Token: 0x0603FFB0 RID: 262064 RVA: 0x00F7ADDC File Offset: 0x00F78FDC
		protected void RefreshComponentVisible()
		{
			foreach (PinballItemGridComponentBase pinballItemGridComponentBase in this.ComponentMap.Values)
			{
				if (!this.VisibleComponents.Contains(pinballItemGridComponentBase))
				{
					pinballItemGridComponentBase.SetActive(false);
				}
			}
		}

		// Token: 0x0603FFB1 RID: 262065 RVA: 0x00F7AE44 File Offset: 0x00F79044
		public UniTask RefreshReduceBtnComponent(bool isVisible)
		{
			PinballItemView.<RefreshReduceBtnComponent>d__51 <RefreshReduceBtnComponent>d__;
			<RefreshReduceBtnComponent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshReduceBtnComponent>d__.<>4__this = this;
			<RefreshReduceBtnComponent>d__.isVisible = isVisible;
			<RefreshReduceBtnComponent>d__.<>1__state = -1;
			<RefreshReduceBtnComponent>d__.<>t__builder.Start<PinballItemView.<RefreshReduceBtnComponent>d__51>(ref <RefreshReduceBtnComponent>d__);
			return <RefreshReduceBtnComponent>d__.<>t__builder.Task;
		}

		// Token: 0x0603FFB2 RID: 262066 RVA: 0x00F7AE90 File Offset: 0x00F79090
		public UniTask RefreshFormationNumberComponent(bool isVisible, int formationId = 0)
		{
			PinballItemView.<RefreshFormationNumberComponent>d__52 <RefreshFormationNumberComponent>d__;
			<RefreshFormationNumberComponent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshFormationNumberComponent>d__.<>4__this = this;
			<RefreshFormationNumberComponent>d__.isVisible = isVisible;
			<RefreshFormationNumberComponent>d__.formationId = formationId;
			<RefreshFormationNumberComponent>d__.<>1__state = -1;
			<RefreshFormationNumberComponent>d__.<>t__builder.Start<PinballItemView.<RefreshFormationNumberComponent>d__52>(ref <RefreshFormationNumberComponent>d__);
			return <RefreshFormationNumberComponent>d__.<>t__builder.Task;
		}

		// Token: 0x0603FFB3 RID: 262067 RVA: 0x00F7AEE3 File Offset: 0x00F790E3
		[NullableContext(2)]
		public UUIExtendToggle GetItemToggle()
		{
			return base.GetExtendToggle(0);
		}

		// Token: 0x0603FFB4 RID: 262068 RVA: 0x00F7AEEC File Offset: 0x00F790EC
		private void BindToggle()
		{
			UUIExtendToggle itemToggle = this.GetItemToggle();
			if (itemToggle == null)
			{
				return;
			}
			itemToggle.OnStateChange.Add(new Action<EToggleState>(this.ExtendToggleStateChanged));
			itemToggle.CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
			itemToggle.FocusListenerDelegate.Bind(new Action(this.FocusListenerDelegateHandler));
		}

		// Token: 0x0603FFB5 RID: 262069 RVA: 0x00F7AF4C File Offset: 0x00F7914C
		private void UnBindToggle()
		{
			UUIExtendToggle itemToggle = this.GetItemToggle();
			if (itemToggle == null)
			{
				return;
			}
			itemToggle.OnStateChange.Remove(new Action<EToggleState>(this.ExtendToggleStateChanged));
			itemToggle.CanExecuteChange.Unbind();
			itemToggle.FocusListenerDelegate.Unbind();
		}

		// Token: 0x0603FFB6 RID: 262070 RVA: 0x00F7AF91 File Offset: 0x00F79191
		private void ExtendToggleStateChanged(EToggleState state)
		{
			this.OnExtendToggleStateChanged(state);
			if (this.OnStateChangedCallback != null)
			{
				this.OnStateChangedCallback(new PinballItemToggleCallbackData
				{
					View = this,
					State = state,
					Data = this.Data
				});
			}
		}

		// Token: 0x0603FFB7 RID: 262071 RVA: 0x00F7AFCC File Offset: 0x00F791CC
		protected virtual void OnExtendToggleStateChanged(EToggleState state)
		{
		}

		// Token: 0x0603FFB8 RID: 262072 RVA: 0x00F7AFCE File Offset: 0x00F791CE
		private bool CanExecuteChange()
		{
			return this.OnCanExecuteChangeCallback == null || this.OnCanExecuteChangeCallback(new PinballItemToggleCallbackData
			{
				View = this,
				State = this.GetItemToggle().GetToggleState(),
				Data = this.Data
			});
		}

		// Token: 0x0603FFB9 RID: 262073 RVA: 0x00F7B00E File Offset: 0x00F7920E
		public void BindOnStateChangeCallback(Action<IPinballItemToggleCallback> onStateChangeCallback)
		{
			this.OnStateChangedCallback = onStateChangeCallback;
		}

		// Token: 0x0603FFBA RID: 262074 RVA: 0x00F7B017 File Offset: 0x00F79217
		public void UnBindOnStateChangeCallback()
		{
			this.OnStateChangedCallback = null;
		}

		// Token: 0x0603FFBB RID: 262075 RVA: 0x00F7B020 File Offset: 0x00F79220
		public void BindOnCanExecuteChangeCallback(Func<IPinballItemToggleCallback, bool> onCanExecuteChangeCallback)
		{
			this.OnCanExecuteChangeCallback = onCanExecuteChangeCallback;
		}

		// Token: 0x0603FFBC RID: 262076 RVA: 0x00F7B029 File Offset: 0x00F79229
		public void BindReduceButtonCallback(Action<IPinballItemButtonCallback> onClickedReduceButton)
		{
			this.OnClickedReduceButtonCallback = onClickedReduceButton;
		}

		// Token: 0x0603FFBD RID: 262077 RVA: 0x00F7B032 File Offset: 0x00F79232
		public void UnBindReduceButtonCallback()
		{
			this.OnClickedReduceButtonCallback = null;
		}

		// Token: 0x0603FFBE RID: 262078 RVA: 0x00F7B03C File Offset: 0x00F7923C
		protected void OnClickedReduceButton()
		{
			if (this.OnClickedReduceButtonCallback != null)
			{
				PinballItemButtonCallbackData obj = new PinballItemButtonCallbackData
				{
					View = this,
					Data = this.Data
				};
				this.OnClickedReduceButtonCallback(obj);
			}
		}

		// Token: 0x0603FFBF RID: 262079 RVA: 0x00F7B076 File Offset: 0x00F79276
		public void BindLongPress(LongPressButtonItem.ELongPressConfigId longPressConfigId, [Nullable(new byte[]
		{
			1,
			1,
			2
		})] Action<bool, PinballItemView, object> callback, [Nullable(new byte[]
		{
			2,
			1,
			2
		})] Func<PinballItemView, object, bool> canLongPressCallBack = null)
		{
			LongPressButtonItem longPressButton = this.LongPressButton;
			if (longPressButton != null)
			{
				longPressButton.Deactivate();
			}
			LongPressButtonItem longPressButton2 = this.LongPressButton;
			if (longPressButton2 != null)
			{
				longPressButton2.Activate(longPressConfigId);
			}
			this.OnLongPressActiveCallback = callback;
			this.CanItemLongPressCallback = canLongPressCallBack;
		}

		// Token: 0x0603FFC0 RID: 262080 RVA: 0x00F7B0A9 File Offset: 0x00F792A9
		public void UnBindLongPress()
		{
			this.OnLongPressActiveCallback = null;
			this.CanItemLongPressCallback = null;
		}

		// Token: 0x0603FFC1 RID: 262081 RVA: 0x00F7B0B9 File Offset: 0x00F792B9
		protected void OnLongPressActivate(bool isShortPress)
		{
			if (this.OnLongPressActiveCallback != null)
			{
				this.OnLongPressActiveCallback(isShortPress, this, this.Data);
			}
		}

		// Token: 0x0603FFC2 RID: 262082 RVA: 0x00F7B0D6 File Offset: 0x00F792D6
		protected bool CanItemLongPressClick()
		{
			return this.CanItemLongPressCallback == null || this.CanItemLongPressCallback(this, this.Data);
		}

		// Token: 0x0603FFC3 RID: 262083 RVA: 0x00F7B0F4 File Offset: 0x00F792F4
		private void ExtendTogglePress()
		{
			if (this.OnExtendTogglePressCallback != null)
			{
				PinballItemToggleCallbackData obj = new PinballItemToggleCallbackData
				{
					View = this,
					State = this.GetItemToggle().GetToggleState(),
					Data = this.Data
				};
				this.OnExtendTogglePressCallback(obj);
			}
		}

		// Token: 0x0603FFC4 RID: 262084 RVA: 0x00F7B140 File Offset: 0x00F79340
		private void ExtendToggleRelease()
		{
			if (this.OnExtendToggleReleaseCallback != null)
			{
				PinballItemToggleCallbackData obj = new PinballItemToggleCallbackData
				{
					View = this,
					State = this.GetItemToggle().GetToggleState(),
					Data = this.Data
				};
				this.OnExtendToggleReleaseCallback(obj);
			}
			if (this.OnExtendToggleClickedCallback != null)
			{
				PinballItemToggleCallbackData obj2 = new PinballItemToggleCallbackData
				{
					View = this,
					State = this.GetItemToggle().GetToggleState(),
					Data = this.Data
				};
				this.OnExtendToggleClickedCallback(obj2);
			}
		}

		// Token: 0x0603FFC5 RID: 262085 RVA: 0x00F7B1C9 File Offset: 0x00F793C9
		public void BindReduceLongPress([Nullable(new byte[]
		{
			1,
			1,
			2
		})] Action<bool, PinballItemView, object> callback)
		{
			this.OnReduceButtonLongActiveCallback = callback;
		}

		// Token: 0x0603FFC6 RID: 262086 RVA: 0x00F7B1D2 File Offset: 0x00F793D2
		public void UnBindReduceLongPress()
		{
			this.OnReduceButtonLongActiveCallback = null;
		}

		// Token: 0x0603FFC7 RID: 262087 RVA: 0x00F7B1DB File Offset: 0x00F793DB
		private void OnReduceButtonLongPressActive(bool isShortPress)
		{
			if (this.OnReduceButtonLongActiveCallback != null)
			{
				this.OnReduceButtonLongActiveCallback(isShortPress, this, this.Data);
			}
		}

		// Token: 0x0603FFC8 RID: 262088 RVA: 0x00F7B1F8 File Offset: 0x00F793F8
		public void BindOnExtendToggleClicked(Action<IPinballItemToggleCallback> onExtendToggleClickedCallback)
		{
			this.OnExtendToggleClickedCallback = onExtendToggleClickedCallback;
		}

		// Token: 0x0603FFC9 RID: 262089 RVA: 0x00F7B201 File Offset: 0x00F79401
		public void UnBindOnExtendToggleClicked()
		{
			this.OnExtendToggleClickedCallback = null;
		}

		// Token: 0x0603FFCA RID: 262090 RVA: 0x00F7B20A File Offset: 0x00F7940A
		public void BindFocusFocusListenerDelegate(Action<IPinballItemToggleCallback> onFocusListenerDelegate)
		{
			this.OnFocusListenerDelegate = onFocusListenerDelegate;
		}

		// Token: 0x0603FFCB RID: 262091 RVA: 0x00F7B213 File Offset: 0x00F79413
		private void FocusListenerDelegateHandler()
		{
			Action<IPinballItemToggleCallback> onFocusListenerDelegate = this.OnFocusListenerDelegate;
			if (onFocusListenerDelegate == null)
			{
				return;
			}
			onFocusListenerDelegate(new PinballItemToggleCallbackData
			{
				View = this,
				State = this.GetItemToggle().GetToggleState(),
				Data = this.Data
			});
		}

		// Token: 0x040215B3 RID: 136627
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<int, string[]> qualityColorListMap = new Dictionary<int, string[]>
		{
			{
				1,
				new string[]
				{
					"5B9D94FF",
					"94C5B2FF",
					"FFFCE7FF",
					"5B9D94FF"
				}
			},
			{
				2,
				new string[]
				{
					"6B8BBEFF",
					"8EB7DEFF",
					"FFFCE7FF",
					"6B8BBEFF"
				}
			},
			{
				3,
				new string[]
				{
					"9232F5FF",
					"B695D8FF",
					"FFFCE7FF",
					"9232F5FF"
				}
			},
			{
				4,
				new string[]
				{
					"E47C62FF",
					"F7C95AFF",
					"FFFCE7FF",
					"E47C62FF"
				}
			},
			{
				5,
				new string[]
				{
					"D80C59FF",
					"FF5D65FF",
					"FFFCE7FF",
					"D80C59FF"
				}
			}
		};

		// Token: 0x040215B4 RID: 136628
		[StaticVariableRuleIgnore]
		private static readonly string[] roleColorList = new string[]
		{
			"D1AA78FF",
			"FEF6E1FF",
			"FFFFFFFF",
			"DCAF88FF"
		};

		// Token: 0x040215B5 RID: 136629
		private const string COMMON_SPRITE_QUALITY_PATH = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity33/CatapultStory/ComItem/SP_ComItemBg3.SP_ComItemBg3";

		// Token: 0x040215B6 RID: 136630
		private const string ROLE_SPRITE_QUALITY_PATH = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity33/CatapultStory/ComItem/SP_ComItemBg3Role.SP_ComItemBg3Role";

		// Token: 0x040215B7 RID: 136631
		private const int MAX_QUALITY_ID = 5;

		// Token: 0x040215B8 RID: 136632
		[Nullable(2)]
		protected object Data;

		// Token: 0x040215B9 RID: 136633
		private UUISprite[] SpriteQualityList = Array.Empty<UUISprite>();

		// Token: 0x040215BA RID: 136634
		[Nullable(2)]
		private PinballShopItemNewTagView ShopNewTagView;

		// Token: 0x040215BB RID: 136635
		private int ShopNewTagSyncGeneration;

		// Token: 0x040215BC RID: 136636
		[Nullable(2)]
		protected LongPressButtonItem LongPressButton;

		// Token: 0x040215BD RID: 136637
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<IPinballItemButtonCallback> OnClickedReduceButtonCallback;

		// Token: 0x040215BE RID: 136638
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Func<IPinballItemToggleCallback, bool> OnCanExecuteChangeCallback;

		// Token: 0x040215BF RID: 136639
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<IPinballItemToggleCallback> OnStateChangedCallback;

		// Token: 0x040215C0 RID: 136640
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<IPinballItemToggleCallback> OnFocusListenerDelegate;

		// Token: 0x040215C1 RID: 136641
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private readonly Action<IPinballItemToggleCallback> OnExtendTogglePressCallback;

		// Token: 0x040215C2 RID: 136642
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private readonly Action<IPinballItemToggleCallback> OnExtendToggleReleaseCallback;

		// Token: 0x040215C3 RID: 136643
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<IPinballItemToggleCallback> OnExtendToggleClickedCallback;

		// Token: 0x040215C4 RID: 136644
		[Nullable(new byte[]
		{
			2,
			1,
			2
		})]
		private Action<bool, PinballItemView, object> OnLongPressActiveCallback;

		// Token: 0x040215C5 RID: 136645
		[Nullable(new byte[]
		{
			2,
			1,
			2
		})]
		private Func<PinballItemView, object, bool> CanItemLongPressCallback;

		// Token: 0x040215C6 RID: 136646
		[Nullable(new byte[]
		{
			2,
			1,
			2
		})]
		private Action<bool, PinballItemView, object> OnReduceButtonLongActiveCallback;

		// Token: 0x040215C7 RID: 136647
		private readonly HashSet<PinballItemGridComponentBase> VisibleComponents = new HashSet<PinballItemGridComponentBase>();

		// Token: 0x040215C8 RID: 136648
		private readonly Dictionary<Type, PinballItemGridComponentBase> ComponentMap = new Dictionary<Type, PinballItemGridComponentBase>();

		// Token: 0x0200C56B RID: 50539
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403B95D RID: 244061
			public const int ItemToggle = 0;

			// Token: 0x0403B95E RID: 244062
			public const int SpriteQualityBgOne = 1;

			// Token: 0x0403B95F RID: 244063
			public const int SpriteQualityBgTwo = 2;

			// Token: 0x0403B960 RID: 244064
			public const int SpriteQualityBgThree = 3;

			// Token: 0x0403B961 RID: 244065
			public const int SpriteQualityBgFour = 4;

			// Token: 0x0403B962 RID: 244066
			public const int SpriteRainbow = 5;

			// Token: 0x0403B963 RID: 244067
			public const int TexIcon = 6;

			// Token: 0x0403B964 RID: 244068
			public const int TextName = 7;

			// Token: 0x0403B965 RID: 244069
			public const int Content = 8;

			// Token: 0x0403B966 RID: 244070
			public const int TopContent = 9;
		}
	}
}
