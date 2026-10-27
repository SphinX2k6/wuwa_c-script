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
	// Token: 0x0200464D RID: 17997
	[NullableContext(1)]
	[Nullable(0)]
	public class NpcSystemViewItem : CommonPopViewBase
	{
		// Token: 0x0602E736 RID: 190262 RVA: 0x00ABB612 File Offset: 0x00AB9812
		public override UUIItem GetAttachParent()
		{
			return base.GetItem(4);
		}

		// Token: 0x0602E737 RID: 190263 RVA: 0x00ABB61C File Offset: 0x00AB981C
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

		// Token: 0x0602E738 RID: 190264 RVA: 0x00ABB788 File Offset: 0x00AB9988
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

		// Token: 0x0602E739 RID: 190265 RVA: 0x00ABB9A5 File Offset: 0x00AB9BA5
		protected override void OnBeforeDestroy()
		{
			this.NpcSystemBackgroundConfig = null;
			this.PopupCaptionItem = null;
		}

		// Token: 0x0602E73A RID: 190266 RVA: 0x00ABB9BC File Offset: 0x00AB9BBC
		private void OnClickedHelpButton()
		{
			if (this.NpcSystemBackgroundConfig != null)
			{
				int helpGroupId = this.NpcSystemBackgroundConfig.Value.HelpGroupId;
				HelpController.Instance.OpenHelpById(helpGroupId);
			}
		}

		// Token: 0x0602E73B RID: 190267 RVA: 0x00ABB9F8 File Offset: 0x00AB9BF8
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

		// Token: 0x0602E73C RID: 190268 RVA: 0x00ABBA6D File Offset: 0x00AB9C6D
		public override void SetTitleVisible(bool bVisible)
		{
			base.GetText(0).SetUIActive(bVisible);
		}

		// Token: 0x0602E73D RID: 190269 RVA: 0x00ABBA7C File Offset: 0x00AB9C7C
		public override void SetTitleText(string titleTextId)
		{
			UUIText text = base.GetText(0);
			LguiUtil.Instance.SetLocalTextNew(text, titleTextId, Array.Empty<object>());
		}

		// Token: 0x0602E73E RID: 190270 RVA: 0x00ABBAA2 File Offset: 0x00AB9CA2
		public void SetTitleTextureVisible(bool bVisible)
		{
			base.GetTexture(2).SetUIActive(bVisible);
		}

		// Token: 0x0602E73F RID: 190271 RVA: 0x00ABBAB4 File Offset: 0x00AB9CB4
		public void SetTitleTexture(string texturePath)
		{
			UUITexture titleTexture = base.GetTexture(2);
			titleTexture.SetUIActive(false);
			base.SetTextureByPath(texturePath, titleTexture, null, delegate(bool _)
			{
				titleTexture.SetUIActive(true);
			});
		}

		// Token: 0x0602E740 RID: 190272 RVA: 0x00ABBB02 File Offset: 0x00AB9D02
		public void SetTitleBackgroundTextureVisible(bool bVisible)
		{
			base.GetTexture(1).SetUIActive(bVisible);
		}

		// Token: 0x0602E741 RID: 190273 RVA: 0x00ABBB14 File Offset: 0x00AB9D14
		public void SetTitleBackgroundTexture(string texturePath)
		{
			UUITexture titleBgTexture = base.GetTexture(1);
			titleBgTexture.SetUIActive(false);
			base.SetTextureByPath(texturePath, titleBgTexture, null, delegate(bool _)
			{
				titleBgTexture.SetUIActive(true);
			});
		}

		// Token: 0x0602E742 RID: 190274 RVA: 0x00ABBB62 File Offset: 0x00AB9D62
		public void SetTitleSymbolVisible(bool bVisible)
		{
			base.GetSprite(3).SetUIActive(bVisible);
		}

		// Token: 0x0602E743 RID: 190275 RVA: 0x00ABBB71 File Offset: 0x00AB9D71
		public void SetTitleSymbolColor(string hexColor)
		{
			base.GetSprite(3).SetColor(FColor.FromHex(hexColor));
		}

		// Token: 0x0602E744 RID: 190276 RVA: 0x00ABBB85 File Offset: 0x00AB9D85
		public void SetCaptionTitleText(string titleTextId)
		{
			PopupCaptionItem popupCaptionItem = this.PopupCaptionItem;
			if (popupCaptionItem == null)
			{
				return;
			}
			popupCaptionItem.SetTitleLocalText(titleTextId);
		}

		// Token: 0x0602E745 RID: 190277 RVA: 0x00ABBB98 File Offset: 0x00AB9D98
		public void SetCaptionTitleVisible(bool bVisible)
		{
			PopupCaptionItem popupCaptionItem = this.PopupCaptionItem;
			if (popupCaptionItem == null)
			{
				return;
			}
			popupCaptionItem.SetTitleTextActive(bVisible);
		}

		// Token: 0x0602E746 RID: 190278 RVA: 0x00ABBBAB File Offset: 0x00AB9DAB
		public void SetCurrencyItemVisible(bool bVisible)
		{
			PopupCaptionItem popupCaptionItem = this.PopupCaptionItem;
			if (popupCaptionItem == null)
			{
				return;
			}
			popupCaptionItem.SetCurrencyItemVisible(bVisible);
		}

		// Token: 0x0602E747 RID: 190279 RVA: 0x00ABBBBE File Offset: 0x00AB9DBE
		public void SetCaptionTitleSprite(string spriteTexture)
		{
			PopupCaptionItem popupCaptionItem = this.PopupCaptionItem;
			if (popupCaptionItem == null)
			{
				return;
			}
			popupCaptionItem.SetTitleIcon(spriteTexture);
		}

		// Token: 0x0602E748 RID: 190280 RVA: 0x00ABBBD1 File Offset: 0x00AB9DD1
		public void SetCaptionTitleIconVisible(bool bVisible)
		{
			PopupCaptionItem popupCaptionItem = this.PopupCaptionItem;
			if (popupCaptionItem == null)
			{
				return;
			}
			popupCaptionItem.SetTitleIconVisible(bVisible);
		}

		// Token: 0x0602E749 RID: 190281 RVA: 0x00ABBBE4 File Offset: 0x00AB9DE4
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

		// Token: 0x0602E74A RID: 190282 RVA: 0x00ABBC2F File Offset: 0x00AB9E2F
		public void SetHelpButtonVisible(bool bVisible)
		{
			PopupCaptionItem popupCaptionItem = this.PopupCaptionItem;
			if (popupCaptionItem == null)
			{
				return;
			}
			popupCaptionItem.SetHelpBtnActive(bVisible);
		}

		// Token: 0x0602E74B RID: 190283 RVA: 0x00ABBC42 File Offset: 0x00AB9E42
		public override void SetTexBgVisible(bool bVisible)
		{
			base.GetItem(7).SetUIActive(bVisible);
		}

		// Token: 0x04018E25 RID: 101925
		[Nullable(2)]
		private PopupCaptionItem PopupCaptionItem;

		// Token: 0x04018E26 RID: 101926
		private NpcSystemBackground? NpcSystemBackgroundConfig;

		// Token: 0x0200A8AB RID: 43179
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x0403358C RID: 210316
			public const int TitleText = 0;

			// Token: 0x0403358D RID: 210317
			public const int TitleBgTexture = 1;

			// Token: 0x0403358E RID: 210318
			public const int TitleTexture = 2;

			// Token: 0x0403358F RID: 210319
			public const int TitleSymbolSprite = 3;

			// Token: 0x04033590 RID: 210320
			public const int ContentItem = 4;

			// Token: 0x04033591 RID: 210321
			public const int CaptionItem = 5;

			// Token: 0x04033592 RID: 210322
			public const int BtnMask = 6;

			// Token: 0x04033593 RID: 210323
			public const int PnlTop = 7;
		}
	}
}
