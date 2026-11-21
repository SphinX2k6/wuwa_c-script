using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200357E RID: 13694
	[NullableContext(1)]
	[Nullable(0)]
	public class NpcSystemViewItem : CommonPopViewBase
	{
		// Token: 0x06022E80 RID: 142976 RVA: 0x009E8C42 File Offset: 0x009E6E42
		public override UUIItem GetAttachParent()
		{
			return base.GetItem(4);
		}

		// Token: 0x06022E81 RID: 142977 RVA: 0x009E8C4C File Offset: 0x009E6E4C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(base.OnClickMaskButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06022E82 RID: 142978 RVA: 0x009E8DB8 File Offset: 0x009E6FB8
		protected override void OnStart()
		{
			this.PopupCaptionItem = new PopupCaptionItem(base.GetItem(5));
			string commonPopBgKey = this.ViewInfo.CommonPopBgKey;
			NpcSystemBackground? npcSystemBackgroundByViewName = UiCommonConfig.Instance.GetNpcSystemBackgroundByViewName(commonPopBgKey);
			if (npcSystemBackgroundByViewName == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Test;
				ELogAuthor author = ELogAuthor.WLJ;
				string message = "u.Ui表现表中配置了通用背景面板(CommonPopBg)为5，但是t.通用背景-Npc系统界面通用背景中没有配置对应界面";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", commonPopBgKey);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.NpcSystemBackgroundConfig = npcSystemBackgroundByViewName;
			string title = npcSystemBackgroundByViewName.Value.Title;
			string titleTexturePath = npcSystemBackgroundByViewName.Value.TitleTexturePath;
			string titleBgTexturePath = npcSystemBackgroundByViewName.Value.TitleBgTexturePath;
			string titleSymbolColor = npcSystemBackgroundByViewName.Value.TitleSymbolColor;
			string captionTitle = npcSystemBackgroundByViewName.Value.CaptionTitle;
			string captionTitleSpritePath = npcSystemBackgroundByViewName.Value.CaptionTitleSpritePath;
			int[] costItemListArray = npcSystemBackgroundByViewName.Value.GetCostItemListArray();
			bool flag = !StringUtils.IsEmpty(title);
			bool flag2 = !StringUtils.IsEmpty(titleTexturePath);
			bool flag3 = !StringUtils.IsEmpty(titleBgTexturePath);
			bool flag4 = !StringUtils.IsEmpty(titleSymbolColor);
			bool flag5 = !StringUtils.IsEmpty(captionTitle);
			bool flag6 = !StringUtils.IsEmpty(captionTitleSpritePath);
			bool flag7 = costItemListArray != null && costItemListArray.Length != 0;
			this.SetTitleVisible(flag);
			if (flag)
			{
				this.SetTitleText(npcSystemBackgroundByViewName.Value.Title);
			}
			this.SetTitleTextureVisible(flag2);
			if (flag2)
			{
				this.SetTitleTexture(titleTexturePath);
			}
			this.SetTitleBackgroundTextureVisible(flag3);
			if (flag3)
			{
				this.SetTitleBackgroundTexture(titleBgTexturePath);
			}
			this.SetTitleSymbolVisible(flag4);
			if (flag4)
			{
				this.SetTitleSymbolColor(titleSymbolColor);
			}
			this.SetCaptionTitleVisible(flag5);
			if (flag5)
			{
				this.SetCaptionTitleText(captionTitle);
			}
			this.SetCaptionTitleIconVisible(flag6);
			if (flag6)
			{
				this.SetCaptionTitleSprite(captionTitleSpritePath);
			}
			this.SetCurrencyItemVisible(flag7);
			if (flag7 && costItemListArray != null)
			{
				this.SetCostItemList(costItemListArray);
			}
			this.SetHelpButtonVisible(npcSystemBackgroundByViewName.Value.IsHelpButtonVisible);
			this.PopupCaptionItem.SetHelpCallBack(new Action(this.OnClickedHelpButton));
			this.PopupCaptionItem.SetCloseCallBack(new Action(this.OnClickedCloseButton));
		}

		// Token: 0x06022E83 RID: 142979 RVA: 0x009E8FD5 File Offset: 0x009E71D5
		protected override void OnBeforeDestroy()
		{
			this.NpcSystemBackgroundConfig = null;
			this.PopupCaptionItem = null;
		}

		// Token: 0x06022E84 RID: 142980 RVA: 0x009E8FEC File Offset: 0x009E71EC
		private void OnClickedHelpButton()
		{
			if (this.NpcSystemBackgroundConfig != null)
			{
				int helpGroupId = this.NpcSystemBackgroundConfig.Value.HelpGroupId;
				HelpController.Instance.OpenHelpById(helpGroupId);
			}
		}

		// Token: 0x06022E85 RID: 142981 RVA: 0x009E9028 File Offset: 0x009E7228
		private void OnClickedCloseButton()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Test;
			ELogAuthor author = ELogAuthor.WLJ;
			string message = "[CloseCookRootView]当点击关闭按钮时";
			string item = "viewName";
			UiViewInfo viewInfo = this.ViewInfo;
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (viewInfo != null) ? new EUiViewName?(viewInfo.Name) : null);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (this.ViewInfo != null)
			{
				UiManager.Instance.CloseView(this.ViewInfo.Name, null);
			}
		}

		// Token: 0x06022E86 RID: 142982 RVA: 0x009E909D File Offset: 0x009E729D
		public override void SetTitleVisible(bool bVisible)
		{
			base.GetText(0).SetUIActive(bVisible);
		}

		// Token: 0x06022E87 RID: 142983 RVA: 0x009E90AC File Offset: 0x009E72AC
		public override void SetTitleText(string titleTextId)
		{
			UUIText text = base.GetText(0);
			LguiUtil.Instance.SetLocalTextNew(text, titleTextId, Array.Empty<object>());
		}

		// Token: 0x06022E88 RID: 142984 RVA: 0x009E90D2 File Offset: 0x009E72D2
		public void SetTitleTextureVisible(bool bVisible)
		{
			base.GetTexture(2).SetUIActive(bVisible);
		}

		// Token: 0x06022E89 RID: 142985 RVA: 0x009E90E4 File Offset: 0x009E72E4
		public void SetTitleTexture(string texturePath)
		{
			UUITexture titleTexture = base.GetTexture(2);
			titleTexture.SetUIActive(false);
			base.SetTextureByPath(texturePath, titleTexture, null, delegate(bool _)
			{
				titleTexture.SetUIActive(true);
			});
		}

		// Token: 0x06022E8A RID: 142986 RVA: 0x009E9132 File Offset: 0x009E7332
		public void SetTitleBackgroundTextureVisible(bool bVisible)
		{
			base.GetTexture(1).SetUIActive(bVisible);
		}

		// Token: 0x06022E8B RID: 142987 RVA: 0x009E9144 File Offset: 0x009E7344
		public void SetTitleBackgroundTexture(string texturePath)
		{
			UUITexture titleBgTexture = base.GetTexture(1);
			titleBgTexture.SetUIActive(false);
			base.SetTextureByPath(texturePath, titleBgTexture, null, delegate(bool _)
			{
				titleBgTexture.SetUIActive(true);
			});
		}

		// Token: 0x06022E8C RID: 142988 RVA: 0x009E9192 File Offset: 0x009E7392
		public void SetTitleSymbolVisible(bool bVisible)
		{
			base.GetSprite(3).SetUIActive(bVisible);
		}

		// Token: 0x06022E8D RID: 142989 RVA: 0x009E91A1 File Offset: 0x009E73A1
		public void SetTitleSymbolColor(string hexColor)
		{
			base.GetSprite(3).SetColor(FColor.FromHex(hexColor));
		}

		// Token: 0x06022E8E RID: 142990 RVA: 0x009E91B5 File Offset: 0x009E73B5
		public void SetCaptionTitleText(string titleTextId)
		{
			PopupCaptionItem popupCaptionItem = this.PopupCaptionItem;
			if (popupCaptionItem == null)
			{
				return;
			}
			popupCaptionItem.SetTitleLocalText(titleTextId);
		}

		// Token: 0x06022E8F RID: 142991 RVA: 0x009E91C8 File Offset: 0x009E73C8
		public void SetCaptionTitleVisible(bool bVisible)
		{
			PopupCaptionItem popupCaptionItem = this.PopupCaptionItem;
			if (popupCaptionItem == null)
			{
				return;
			}
			popupCaptionItem.SetTitleTextActive(bVisible);
		}

		// Token: 0x06022E90 RID: 142992 RVA: 0x009E91DB File Offset: 0x009E73DB
		public void SetCurrencyItemVisible(bool bVisible)
		{
			PopupCaptionItem popupCaptionItem = this.PopupCaptionItem;
			if (popupCaptionItem == null)
			{
				return;
			}
			popupCaptionItem.SetCurrencyItemVisible(bVisible);
		}

		// Token: 0x06022E91 RID: 142993 RVA: 0x009E91EE File Offset: 0x009E73EE
		public void SetCaptionTitleSprite(string spriteTexture)
		{
			PopupCaptionItem popupCaptionItem = this.PopupCaptionItem;
			if (popupCaptionItem == null)
			{
				return;
			}
			popupCaptionItem.SetTitleIcon(spriteTexture);
		}

		// Token: 0x06022E92 RID: 142994 RVA: 0x009E9201 File Offset: 0x009E7401
		public void SetCaptionTitleIconVisible(bool bVisible)
		{
			PopupCaptionItem popupCaptionItem = this.PopupCaptionItem;
			if (popupCaptionItem == null)
			{
				return;
			}
			popupCaptionItem.SetTitleIconVisible(bVisible);
		}

		// Token: 0x06022E93 RID: 142995 RVA: 0x009E9214 File Offset: 0x009E7414
		public UniTask SetCostItemList(int[] itemConfigList)
		{
			NpcSystemViewItem.<SetCostItemList>d__22 <SetCostItemList>d__;
			<SetCostItemList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetCostItemList>d__.<>4__this = this;
			<SetCostItemList>d__.itemConfigList = itemConfigList;
			<SetCostItemList>d__.<>1__state = -1;
			<SetCostItemList>d__.<>t__builder.Start<NpcSystemViewItem.<SetCostItemList>d__22>(ref <SetCostItemList>d__);
			return <SetCostItemList>d__.<>t__builder.Task;
		}

		// Token: 0x06022E94 RID: 142996 RVA: 0x009E925F File Offset: 0x009E745F
		public void SetHelpButtonVisible(bool bVisible)
		{
			PopupCaptionItem popupCaptionItem = this.PopupCaptionItem;
			if (popupCaptionItem == null)
			{
				return;
			}
			popupCaptionItem.SetHelpBtnActive(bVisible);
		}

		// Token: 0x06022E95 RID: 142997 RVA: 0x009E9272 File Offset: 0x009E7472
		public override void SetTexBgVisible(bool bVisible)
		{
			base.GetItem(7).SetUIActive(bVisible);
		}

		// Token: 0x0401347E RID: 78974
		[Nullable(2)]
		private PopupCaptionItem PopupCaptionItem;

		// Token: 0x0401347F RID: 78975
		private NpcSystemBackground? NpcSystemBackgroundConfig;

		// Token: 0x02009267 RID: 37479
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x0402DD22 RID: 187682
			public const int TitleText = 0;

			// Token: 0x0402DD23 RID: 187683
			public const int TitleBgTexture = 1;

			// Token: 0x0402DD24 RID: 187684
			public const int TitleTexture = 2;

			// Token: 0x0402DD25 RID: 187685
			public const int TitleSymbolSprite = 3;

			// Token: 0x0402DD26 RID: 187686
			public const int ContentItem = 4;

			// Token: 0x0402DD27 RID: 187687
			public const int CaptionItem = 5;

			// Token: 0x0402DD28 RID: 187688
			public const int BtnMask = 6;

			// Token: 0x0402DD29 RID: 187689
			public const int PnlTop = 7;
		}
	}
}
