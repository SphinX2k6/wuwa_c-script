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
	// Token: 0x0200464C RID: 17996
	[NullableContext(1)]
	[Nullable(0)]
	public class InteractSystemViewItem : CommonPopViewBase
	{
		// Token: 0x0602E723 RID: 190243 RVA: 0x00ABB140 File Offset: 0x00AB9340
		public override UUIItem GetAttachParent()
		{
			return base.GetItem(4);
		}

		// Token: 0x0602E724 RID: 190244 RVA: 0x00ABB14C File Offset: 0x00AB934C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602E725 RID: 190245 RVA: 0x00ABB218 File Offset: 0x00AB9418
		protected override void OnStart()
		{
			this.PopupCaptionItem = new PopupCaptionItem(base.GetItem(3));
			string commonPopBgKey = this.ViewInfo.CommonPopBgKey;
			InteractBackGround? interactBackgroundByViewName = UiCommonConfig.Instance.GetInteractBackgroundByViewName(commonPopBgKey);
			if (interactBackgroundByViewName == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Test;
				ELogAuthor author = ELogAuthor.WLJ;
				string message = "u.Ui表现表中配置了通用背景面板(CommonPopBg)为5，但是t.通用背景-Npc系统界面通用背景中没有配置对应界面";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", commonPopBgKey);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.InteractBackgroundConfig = interactBackgroundByViewName;
			string title = this.InteractBackgroundConfig.Value.Title;
			string titleSpritePath = this.InteractBackgroundConfig.Value.TitleSpritePath;
			string contentSpritePath = this.InteractBackgroundConfig.Value.ContentSpritePath;
			int[] costItemListArray = this.InteractBackgroundConfig.Value.GetCostItemListArray();
			bool flag = !StringUtils.IsEmpty(title);
			bool flag2 = !StringUtils.IsEmpty(titleSpritePath);
			bool flag3 = !StringUtils.IsEmpty(contentSpritePath);
			bool flag4 = costItemListArray != null && costItemListArray.Length != 0;
			this.SetTitleVisible(flag);
			if (flag)
			{
				this.SetTitleText(title);
			}
			this.SetTitleSpriteVisible(flag2);
			if (flag2)
			{
				this.SetTitleSprite(titleSpritePath);
			}
			this.SetContentSpriteVisible(flag3);
			if (flag3)
			{
				this.SetContentSprite(contentSpritePath);
			}
			this.SetCurrencyItemVisible(flag4);
			if (flag4)
			{
				this.SetCostItemList(costItemListArray);
			}
			this.SetHelpButtonVisible(this.InteractBackgroundConfig.Value.IsHelpButtonVisible);
			this.PopupCaptionItem.SetHelpCallBack(new Action(this.OnClickedHelpButton));
			this.PopupCaptionItem.SetCloseCallBack(new Action(this.OnClickedCloseButton));
			this.PopupCaptionItem.SetTitleTextActive(false);
			this.PopupCaptionItem.SetTitleIconVisible(false);
		}

		// Token: 0x0602E726 RID: 190246 RVA: 0x00ABB3BD File Offset: 0x00AB95BD
		protected override void OnBeforeDestroy()
		{
			this.InteractBackgroundConfig = null;
			this.PopupCaptionItem = null;
		}

		// Token: 0x0602E727 RID: 190247 RVA: 0x00ABB3D4 File Offset: 0x00AB95D4
		private void OnClickedHelpButton()
		{
			if (this.InteractBackgroundConfig != null)
			{
				int helpGroupId = this.InteractBackgroundConfig.Value.HelpGroupId;
				HelpController.Instance.OpenHelpById(helpGroupId);
			}
		}

		// Token: 0x0602E728 RID: 190248 RVA: 0x00ABB410 File Offset: 0x00AB9610
		private void OnClickedCloseButton()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Test;
			ELogAuthor author = ELogAuthor.WLJ;
			string message = "[CloseCookRootView]当点击关闭按钮时";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("viewName", this.ViewInfo.Name);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			UiManager.Instance.CloseView(this.ViewInfo.Name, null);
		}

		// Token: 0x0602E729 RID: 190249 RVA: 0x00ABB469 File Offset: 0x00AB9669
		public override void SetTitleVisible(bool bVisible)
		{
			base.GetText(1).SetUIActive(bVisible);
		}

		// Token: 0x0602E72A RID: 190250 RVA: 0x00ABB478 File Offset: 0x00AB9678
		public override void SetTitleText(string titleTextId)
		{
			UUIText text = base.GetText(1);
			LguiUtil.Instance.SetLocalTextNew(text, titleTextId, Array.Empty<object>());
		}

		// Token: 0x0602E72B RID: 190251 RVA: 0x00ABB49E File Offset: 0x00AB969E
		public void SetTitleSpriteVisible(bool bVisible)
		{
			base.GetSprite(0).SetUIActive(bVisible);
		}

		// Token: 0x0602E72C RID: 190252 RVA: 0x00ABB4B0 File Offset: 0x00AB96B0
		public void SetTitleSprite(string spritePath)
		{
			UUISprite titleSprite = base.GetSprite(0);
			titleSprite.SetUIActive(false);
			this.SetSpriteByPath(spritePath, titleSprite, false, null, delegate(bool arg)
			{
				titleSprite.SetUIActive(true);
			});
		}

		// Token: 0x0602E72D RID: 190253 RVA: 0x00ABB4FF File Offset: 0x00AB96FF
		public void SetContentSpriteVisible(bool bVisible)
		{
			base.GetSprite(2).SetUIActive(bVisible);
		}

		// Token: 0x0602E72E RID: 190254 RVA: 0x00ABB510 File Offset: 0x00AB9710
		public void SetContentSprite(string spritePath)
		{
			UUISprite contentSprite = base.GetSprite(2);
			contentSprite.SetUIActive(false);
			this.SetSpriteByPath(spritePath, contentSprite, false, null, delegate(bool arg)
			{
				contentSprite.SetUIActive(true);
			});
		}

		// Token: 0x0602E72F RID: 190255 RVA: 0x00ABB55F File Offset: 0x00AB975F
		public void SetCaptionTitleVisible(bool bVisible)
		{
			PopupCaptionItem popupCaptionItem = this.PopupCaptionItem;
			if (popupCaptionItem == null)
			{
				return;
			}
			popupCaptionItem.SetTitleTextActive(bVisible);
		}

		// Token: 0x0602E730 RID: 190256 RVA: 0x00ABB572 File Offset: 0x00AB9772
		public void SetCurrencyItemVisible(bool bVisible)
		{
			PopupCaptionItem popupCaptionItem = this.PopupCaptionItem;
			if (popupCaptionItem == null)
			{
				return;
			}
			popupCaptionItem.SetCurrencyItemVisible(bVisible);
		}

		// Token: 0x0602E731 RID: 190257 RVA: 0x00ABB585 File Offset: 0x00AB9785
		public void SetCaptionTitleSprite(string spriteTexture)
		{
			PopupCaptionItem popupCaptionItem = this.PopupCaptionItem;
			if (popupCaptionItem == null)
			{
				return;
			}
			popupCaptionItem.SetTitleIcon(spriteTexture);
		}

		// Token: 0x0602E732 RID: 190258 RVA: 0x00ABB598 File Offset: 0x00AB9798
		public void SetCaptionTitleIconVisible(bool bVisible)
		{
			PopupCaptionItem popupCaptionItem = this.PopupCaptionItem;
			if (popupCaptionItem == null)
			{
				return;
			}
			popupCaptionItem.SetTitleIconVisible(bVisible);
		}

		// Token: 0x0602E733 RID: 190259 RVA: 0x00ABB5AC File Offset: 0x00AB97AC
		public UniTask SetCostItemList(int[] itemConfigList)
		{
			InteractSystemViewItem.<SetCostItemList>d__19 <SetCostItemList>d__;
			<SetCostItemList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetCostItemList>d__.<>4__this = this;
			<SetCostItemList>d__.itemConfigList = itemConfigList;
			<SetCostItemList>d__.<>1__state = -1;
			<SetCostItemList>d__.<>t__builder.Start<InteractSystemViewItem.<SetCostItemList>d__19>(ref <SetCostItemList>d__);
			return <SetCostItemList>d__.<>t__builder.Task;
		}

		// Token: 0x0602E734 RID: 190260 RVA: 0x00ABB5F7 File Offset: 0x00AB97F7
		public void SetHelpButtonVisible(bool bVisible)
		{
			PopupCaptionItem popupCaptionItem = this.PopupCaptionItem;
			if (popupCaptionItem == null)
			{
				return;
			}
			popupCaptionItem.SetHelpBtnActive(bVisible);
		}

		// Token: 0x04018E23 RID: 101923
		[Nullable(2)]
		private PopupCaptionItem PopupCaptionItem;

		// Token: 0x04018E24 RID: 101924
		private InteractBackGround? InteractBackgroundConfig;

		// Token: 0x0200A8A7 RID: 43175
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04033580 RID: 210304
			public const int TitleSprite = 0;

			// Token: 0x04033581 RID: 210305
			public const int TitleText = 1;

			// Token: 0x04033582 RID: 210306
			public const int ContentSprite = 2;

			// Token: 0x04033583 RID: 210307
			public const int CaptionItem = 3;

			// Token: 0x04033584 RID: 210308
			public const int ContentItem = 4;
		}
	}
}
