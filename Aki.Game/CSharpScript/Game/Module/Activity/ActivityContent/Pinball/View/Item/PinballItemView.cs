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
	// Token: 0x020052CD RID: 21197
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballItemView : UiPanelBase
	{
		// Token: 0x06034C56 RID: 216150 RVA: 0x00EC1388 File Offset: 0x00EBF588
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

		// Token: 0x06034C57 RID: 216151 RVA: 0x00EC14FC File Offset: 0x00EBF6FC
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

		// Token: 0x06034C58 RID: 216152 RVA: 0x00EC15B8 File Offset: 0x00EBF7B8
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

		// Token: 0x06034C59 RID: 216153 RVA: 0x00EC15F8 File Offset: 0x00EBF7F8
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

		// Token: 0x06034C5A RID: 216154 RVA: 0x00EC1644 File Offset: 0x00EBF844
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

		// Token: 0x06034C5B RID: 216155 RVA: 0x00EC16C8 File Offset: 0x00EBF8C8
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

		// Token: 0x06034C5C RID: 216156 RVA: 0x00EC1738 File Offset: 0x00EBF938
		private void RefreshShopItemName(CommonGameplayShopItemProxy proxy)
		{
			UUIText text = base.GetText(7);
			if (text != null)
			{
				GameplayShopUtil.SetText(text, proxy.ItemNameTextData);
			}
		}

		// Token: 0x06034C5D RID: 216157 RVA: 0x00EC175C File Offset: 0x00EBF95C
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

		// Token: 0x06034C5E RID: 216158 RVA: 0x00EC17C4 File Offset: 0x00EBF9C4
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

		// Token: 0x06034C5F RID: 216159 RVA: 0x00EC1818 File Offset: 0x00EBFA18
		private UniTask ClearShopNewTagAsync()
		{
			PinballItemView.<ClearShopNewTagAsync>d__30 <ClearShopNewTagAsync>d__;
			<ClearShopNewTagAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ClearShopNewTagAsync>d__.<>4__this = this;
			<ClearShopNewTagAsync>d__.<>1__state = -1;
			<ClearShopNewTagAsync>d__.<>t__builder.Start<PinballItemView.<ClearShopNewTagAsync>d__30>(ref <ClearShopNewTagAsync>d__);
			return <ClearShopNewTagAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034C60 RID: 216160 RVA: 0x00EC185C File Offset: 0x00EBFA5C
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

		// Token: 0x06034C61 RID: 216161 RVA: 0x00EC18A8 File Offset: 0x00EBFAA8
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

		// Token: 0x06034C62 RID: 216162 RVA: 0x00EC19B0 File Offset: 0x00EBFBB0
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

		// Token: 0x06034C63 RID: 216163 RVA: 0x00EC19FC File Offset: 0x00EBFBFC
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

		// Token: 0x06034C64 RID: 216164 RVA: 0x00EC1A48 File Offset: 0x00EBFC48
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

		// Token: 0x06034C65 RID: 216165 RVA: 0x00EC1B4C File Offset: 0x00EBFD4C
		protected void ApplyBase()
		{
			base.TrySetSpriteByPath("/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity33/CatapultStory/ComItem/SP_ComItemBg3.SP_ComItemBg3", base.GetSprite(3), false, null, null);
			this.RefreshRainbow(false);
		}

		// Token: 0x06034C66 RID: 216166 RVA: 0x00EC1B80 File Offset: 0x00EBFD80
		protected void RefreshColor(string[] colorList)
		{
			for (int i = 0; i < colorList.Length; i++)
			{
				this.SpriteQualityList[i].SetColor(FColor.FromHex(colorList[i]));
			}
		}

		// Token: 0x06034C67 RID: 216167 RVA: 0x00EC1BB0 File Offset: 0x00EBFDB0
		protected void RefreshRainbow(bool bShow)
		{
			UUISprite sprite = base.GetSprite(5);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(bShow);
		}

		// Token: 0x06034C68 RID: 216168 RVA: 0x00EC1BC4 File Offset: 0x00EBFDC4
		protected void RefreshTxt(string txt)
		{
			UUIText text = base.GetText(7);
			if (text == null)
			{
				return;
			}
			text.SetText(txt, true);
		}

		// Token: 0x06034C69 RID: 216169 RVA: 0x00EC1BD9 File Offset: 0x00EBFDD9
		protected void RefreshTxtByTextId(string textId)
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(7), textId, Array.Empty<object>());
		}

		// Token: 0x06034C6A RID: 216170 RVA: 0x00EC1BF2 File Offset: 0x00EBFDF2
		protected void RefreshTxtByTableTextArgNew(TableTextArgNew bottomText)
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(7), bottomText.TextKey, bottomText.Params);
		}

		// Token: 0x06034C6B RID: 216171 RVA: 0x00EC1C14 File Offset: 0x00EBFE14
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

		// Token: 0x06034C6C RID: 216172 RVA: 0x00EC1C78 File Offset: 0x00EBFE78
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

		// Token: 0x06034C6D RID: 216173 RVA: 0x00EC1C98 File Offset: 0x00EBFE98
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

		// Token: 0x06034C6E RID: 216174 RVA: 0x00EC1CEB File Offset: 0x00EBFEEB
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

		// Token: 0x06034C6F RID: 216175 RVA: 0x00EC1D0E File Offset: 0x00EBFF0E
		private void OnComponentVisibleChanged(PinballItemGridComponentBase component, bool bVisible)
		{
			if (bVisible)
			{
				this.VisibleComponents.Add(component);
				return;
			}
			this.VisibleComponents.Remove(component);
		}

		// Token: 0x06034C70 RID: 216176 RVA: 0x00EC1D2E File Offset: 0x00EBFF2E
		private void ClearVisibleComponent()
		{
			this.VisibleComponents.Clear();
		}

		// Token: 0x06034C71 RID: 216177 RVA: 0x00EC1D3C File Offset: 0x00EBFF3C
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

		// Token: 0x06034C72 RID: 216178 RVA: 0x00EC1DA4 File Offset: 0x00EBFFA4
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

		// Token: 0x06034C73 RID: 216179 RVA: 0x00EC1DF0 File Offset: 0x00EBFFF0
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

		// Token: 0x06034C74 RID: 216180 RVA: 0x00EC1E43 File Offset: 0x00EC0043
		[NullableContext(2)]
		public UUIExtendToggle GetItemToggle()
		{
			return base.GetExtendToggle(0);
		}

		// Token: 0x06034C75 RID: 216181 RVA: 0x00EC1E4C File Offset: 0x00EC004C
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

		// Token: 0x06034C76 RID: 216182 RVA: 0x00EC1EAC File Offset: 0x00EC00AC
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

		// Token: 0x06034C77 RID: 216183 RVA: 0x00EC1EF1 File Offset: 0x00EC00F1
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

		// Token: 0x06034C78 RID: 216184 RVA: 0x00EC1F2C File Offset: 0x00EC012C
		protected virtual void OnExtendToggleStateChanged(EToggleState state)
		{
		}

		// Token: 0x06034C79 RID: 216185 RVA: 0x00EC1F2E File Offset: 0x00EC012E
		private bool CanExecuteChange()
		{
			return this.OnCanExecuteChangeCallback == null || this.OnCanExecuteChangeCallback(new PinballItemToggleCallbackData
			{
				View = this,
				State = this.GetItemToggle().GetToggleState(),
				Data = this.Data
			});
		}

		// Token: 0x06034C7A RID: 216186 RVA: 0x00EC1F6E File Offset: 0x00EC016E
		public void BindOnStateChangeCallback(Action<IPinballItemToggleCallback> onStateChangeCallback)
		{
			this.OnStateChangedCallback = onStateChangeCallback;
		}

		// Token: 0x06034C7B RID: 216187 RVA: 0x00EC1F77 File Offset: 0x00EC0177
		public void UnBindOnStateChangeCallback()
		{
			this.OnStateChangedCallback = null;
		}

		// Token: 0x06034C7C RID: 216188 RVA: 0x00EC1F80 File Offset: 0x00EC0180
		public void BindOnCanExecuteChangeCallback(Func<IPinballItemToggleCallback, bool> onCanExecuteChangeCallback)
		{
			this.OnCanExecuteChangeCallback = onCanExecuteChangeCallback;
		}

		// Token: 0x06034C7D RID: 216189 RVA: 0x00EC1F89 File Offset: 0x00EC0189
		public void BindReduceButtonCallback(Action<IPinballItemButtonCallback> onClickedReduceButton)
		{
			this.OnClickedReduceButtonCallback = onClickedReduceButton;
		}

		// Token: 0x06034C7E RID: 216190 RVA: 0x00EC1F92 File Offset: 0x00EC0192
		public void UnBindReduceButtonCallback()
		{
			this.OnClickedReduceButtonCallback = null;
		}

		// Token: 0x06034C7F RID: 216191 RVA: 0x00EC1F9C File Offset: 0x00EC019C
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

		// Token: 0x06034C80 RID: 216192 RVA: 0x00EC1FD6 File Offset: 0x00EC01D6
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

		// Token: 0x06034C81 RID: 216193 RVA: 0x00EC2009 File Offset: 0x00EC0209
		public void UnBindLongPress()
		{
			this.OnLongPressActiveCallback = null;
			this.CanItemLongPressCallback = null;
		}

		// Token: 0x06034C82 RID: 216194 RVA: 0x00EC2019 File Offset: 0x00EC0219
		protected void OnLongPressActivate(bool isShortPress)
		{
			if (this.OnLongPressActiveCallback != null)
			{
				this.OnLongPressActiveCallback(isShortPress, this, this.Data);
			}
		}

		// Token: 0x06034C83 RID: 216195 RVA: 0x00EC2036 File Offset: 0x00EC0236
		protected bool CanItemLongPressClick()
		{
			return this.CanItemLongPressCallback == null || this.CanItemLongPressCallback(this, this.Data);
		}

		// Token: 0x06034C84 RID: 216196 RVA: 0x00EC2054 File Offset: 0x00EC0254
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

		// Token: 0x06034C85 RID: 216197 RVA: 0x00EC20A0 File Offset: 0x00EC02A0
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

		// Token: 0x06034C86 RID: 216198 RVA: 0x00EC2129 File Offset: 0x00EC0329
		public void BindReduceLongPress([Nullable(new byte[]
		{
			1,
			1,
			2
		})] Action<bool, PinballItemView, object> callback)
		{
			this.OnReduceButtonLongActiveCallback = callback;
		}

		// Token: 0x06034C87 RID: 216199 RVA: 0x00EC2132 File Offset: 0x00EC0332
		public void UnBindReduceLongPress()
		{
			this.OnReduceButtonLongActiveCallback = null;
		}

		// Token: 0x06034C88 RID: 216200 RVA: 0x00EC213B File Offset: 0x00EC033B
		private void OnReduceButtonLongPressActive(bool isShortPress)
		{
			if (this.OnReduceButtonLongActiveCallback != null)
			{
				this.OnReduceButtonLongActiveCallback(isShortPress, this, this.Data);
			}
		}

		// Token: 0x06034C89 RID: 216201 RVA: 0x00EC2158 File Offset: 0x00EC0358
		public void BindOnExtendToggleClicked(Action<IPinballItemToggleCallback> onExtendToggleClickedCallback)
		{
			this.OnExtendToggleClickedCallback = onExtendToggleClickedCallback;
		}

		// Token: 0x06034C8A RID: 216202 RVA: 0x00EC2161 File Offset: 0x00EC0361
		public void UnBindOnExtendToggleClicked()
		{
			this.OnExtendToggleClickedCallback = null;
		}

		// Token: 0x06034C8B RID: 216203 RVA: 0x00EC216A File Offset: 0x00EC036A
		public void BindFocusFocusListenerDelegate(Action<IPinballItemToggleCallback> onFocusListenerDelegate)
		{
			this.OnFocusListenerDelegate = onFocusListenerDelegate;
		}

		// Token: 0x06034C8C RID: 216204 RVA: 0x00EC2173 File Offset: 0x00EC0373
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

		// Token: 0x0401BEE2 RID: 114402
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

		// Token: 0x0401BEE3 RID: 114403
		[StaticVariableRuleIgnore]
		private static readonly string[] roleColorList = new string[]
		{
			"D1AA78FF",
			"FEF6E1FF",
			"FFFFFFFF",
			"DCAF88FF"
		};

		// Token: 0x0401BEE4 RID: 114404
		private const string COMMON_SPRITE_QUALITY_PATH = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity33/CatapultStory/ComItem/SP_ComItemBg3.SP_ComItemBg3";

		// Token: 0x0401BEE5 RID: 114405
		private const string ROLE_SPRITE_QUALITY_PATH = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity33/CatapultStory/ComItem/SP_ComItemBg3Role.SP_ComItemBg3Role";

		// Token: 0x0401BEE6 RID: 114406
		private const int MAX_QUALITY_ID = 5;

		// Token: 0x0401BEE7 RID: 114407
		[Nullable(2)]
		protected object Data;

		// Token: 0x0401BEE8 RID: 114408
		private UUISprite[] SpriteQualityList = Array.Empty<UUISprite>();

		// Token: 0x0401BEE9 RID: 114409
		[Nullable(2)]
		private PinballShopItemNewTagView ShopNewTagView;

		// Token: 0x0401BEEA RID: 114410
		private int ShopNewTagSyncGeneration;

		// Token: 0x0401BEEB RID: 114411
		[Nullable(2)]
		protected LongPressButtonItem LongPressButton;

		// Token: 0x0401BEEC RID: 114412
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<IPinballItemButtonCallback> OnClickedReduceButtonCallback;

		// Token: 0x0401BEED RID: 114413
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Func<IPinballItemToggleCallback, bool> OnCanExecuteChangeCallback;

		// Token: 0x0401BEEE RID: 114414
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<IPinballItemToggleCallback> OnStateChangedCallback;

		// Token: 0x0401BEEF RID: 114415
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<IPinballItemToggleCallback> OnFocusListenerDelegate;

		// Token: 0x0401BEF0 RID: 114416
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private readonly Action<IPinballItemToggleCallback> OnExtendTogglePressCallback;

		// Token: 0x0401BEF1 RID: 114417
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private readonly Action<IPinballItemToggleCallback> OnExtendToggleReleaseCallback;

		// Token: 0x0401BEF2 RID: 114418
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<IPinballItemToggleCallback> OnExtendToggleClickedCallback;

		// Token: 0x0401BEF3 RID: 114419
		[Nullable(new byte[]
		{
			2,
			1,
			2
		})]
		private Action<bool, PinballItemView, object> OnLongPressActiveCallback;

		// Token: 0x0401BEF4 RID: 114420
		[Nullable(new byte[]
		{
			2,
			1,
			2
		})]
		private Func<PinballItemView, object, bool> CanItemLongPressCallback;

		// Token: 0x0401BEF5 RID: 114421
		[Nullable(new byte[]
		{
			2,
			1,
			2
		})]
		private Action<bool, PinballItemView, object> OnReduceButtonLongActiveCallback;

		// Token: 0x0401BEF6 RID: 114422
		private readonly HashSet<PinballItemGridComponentBase> VisibleComponents = new HashSet<PinballItemGridComponentBase>();

		// Token: 0x0401BEF7 RID: 114423
		private readonly Dictionary<Type, PinballItemGridComponentBase> ComponentMap = new Dictionary<Type, PinballItemGridComponentBase>();

		// Token: 0x0200AF52 RID: 44882
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x040362BF RID: 221887
			public const int ItemToggle = 0;

			// Token: 0x040362C0 RID: 221888
			public const int SpriteQualityBgOne = 1;

			// Token: 0x040362C1 RID: 221889
			public const int SpriteQualityBgTwo = 2;

			// Token: 0x040362C2 RID: 221890
			public const int SpriteQualityBgThree = 3;

			// Token: 0x040362C3 RID: 221891
			public const int SpriteQualityBgFour = 4;

			// Token: 0x040362C4 RID: 221892
			public const int SpriteRainbow = 5;

			// Token: 0x040362C5 RID: 221893
			public const int TexIcon = 6;

			// Token: 0x040362C6 RID: 221894
			public const int TextName = 7;

			// Token: 0x040362C7 RID: 221895
			public const int Content = 8;

			// Token: 0x040362C8 RID: 221896
			public const int TopContent = 9;
		}
	}
}
