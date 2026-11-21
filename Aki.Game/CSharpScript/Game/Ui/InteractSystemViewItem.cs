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
	// Token: 0x0200357D RID: 13693
	[NullableContext(1)]
	[Nullable(0)]
	public class InteractSystemViewItem : CommonPopViewBase
	{
		// Token: 0x06022E6D RID: 142957 RVA: 0x009E8770 File Offset: 0x009E6970
		public override UUIItem GetAttachParent()
		{
			return base.GetItem(4);
		}

		// Token: 0x06022E6E RID: 142958 RVA: 0x009E877C File Offset: 0x009E697C
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

		// Token: 0x06022E6F RID: 142959 RVA: 0x009E8848 File Offset: 0x009E6A48
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

		// Token: 0x06022E70 RID: 142960 RVA: 0x009E89ED File Offset: 0x009E6BED
		protected override void OnBeforeDestroy()
		{
			this.InteractBackgroundConfig = null;
			this.PopupCaptionItem = null;
		}

		// Token: 0x06022E71 RID: 142961 RVA: 0x009E8A04 File Offset: 0x009E6C04
		private void OnClickedHelpButton()
		{
			if (this.InteractBackgroundConfig != null)
			{
				int helpGroupId = this.InteractBackgroundConfig.Value.HelpGroupId;
				HelpController.Instance.OpenHelpById(helpGroupId);
			}
		}

		// Token: 0x06022E72 RID: 142962 RVA: 0x009E8A40 File Offset: 0x009E6C40
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

		// Token: 0x06022E73 RID: 142963 RVA: 0x009E8A99 File Offset: 0x009E6C99
		public override void SetTitleVisible(bool bVisible)
		{
			base.GetText(1).SetUIActive(bVisible);
		}

		// Token: 0x06022E74 RID: 142964 RVA: 0x009E8AA8 File Offset: 0x009E6CA8
		public override void SetTitleText(string titleTextId)
		{
			UUIText text = base.GetText(1);
			LguiUtil.Instance.SetLocalTextNew(text, titleTextId, Array.Empty<object>());
		}

		// Token: 0x06022E75 RID: 142965 RVA: 0x009E8ACE File Offset: 0x009E6CCE
		public void SetTitleSpriteVisible(bool bVisible)
		{
			base.GetSprite(0).SetUIActive(bVisible);
		}

		// Token: 0x06022E76 RID: 142966 RVA: 0x009E8AE0 File Offset: 0x009E6CE0
		public void SetTitleSprite(string spritePath)
		{
			UUISprite titleSprite = base.GetSprite(0);
			titleSprite.SetUIActive(false);
			this.SetSpriteByPath(spritePath, titleSprite, false, null, delegate(bool arg)
			{
				titleSprite.SetUIActive(true);
			});
		}

		// Token: 0x06022E77 RID: 142967 RVA: 0x009E8B2F File Offset: 0x009E6D2F
		public void SetContentSpriteVisible(bool bVisible)
		{
			base.GetSprite(2).SetUIActive(bVisible);
		}

		// Token: 0x06022E78 RID: 142968 RVA: 0x009E8B40 File Offset: 0x009E6D40
		public void SetContentSprite(string spritePath)
		{
			UUISprite contentSprite = base.GetSprite(2);
			contentSprite.SetUIActive(false);
			this.SetSpriteByPath(spritePath, contentSprite, false, null, delegate(bool arg)
			{
				contentSprite.SetUIActive(true);
			});
		}

		// Token: 0x06022E79 RID: 142969 RVA: 0x009E8B8F File Offset: 0x009E6D8F
		public void SetCaptionTitleVisible(bool bVisible)
		{
			PopupCaptionItem popupCaptionItem = this.PopupCaptionItem;
			if (popupCaptionItem == null)
			{
				return;
			}
			popupCaptionItem.SetTitleTextActive(bVisible);
		}

		// Token: 0x06022E7A RID: 142970 RVA: 0x009E8BA2 File Offset: 0x009E6DA2
		public void SetCurrencyItemVisible(bool bVisible)
		{
			PopupCaptionItem popupCaptionItem = this.PopupCaptionItem;
			if (popupCaptionItem == null)
			{
				return;
			}
			popupCaptionItem.SetCurrencyItemVisible(bVisible);
		}

		// Token: 0x06022E7B RID: 142971 RVA: 0x009E8BB5 File Offset: 0x009E6DB5
		public void SetCaptionTitleSprite(string spriteTexture)
		{
			PopupCaptionItem popupCaptionItem = this.PopupCaptionItem;
			if (popupCaptionItem == null)
			{
				return;
			}
			popupCaptionItem.SetTitleIcon(spriteTexture);
		}

		// Token: 0x06022E7C RID: 142972 RVA: 0x009E8BC8 File Offset: 0x009E6DC8
		public void SetCaptionTitleIconVisible(bool bVisible)
		{
			PopupCaptionItem popupCaptionItem = this.PopupCaptionItem;
			if (popupCaptionItem == null)
			{
				return;
			}
			popupCaptionItem.SetTitleIconVisible(bVisible);
		}

		// Token: 0x06022E7D RID: 142973 RVA: 0x009E8BDC File Offset: 0x009E6DDC
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

		// Token: 0x06022E7E RID: 142974 RVA: 0x009E8C27 File Offset: 0x009E6E27
		public void SetHelpButtonVisible(bool bVisible)
		{
			PopupCaptionItem popupCaptionItem = this.PopupCaptionItem;
			if (popupCaptionItem == null)
			{
				return;
			}
			popupCaptionItem.SetHelpBtnActive(bVisible);
		}

		// Token: 0x0401347C RID: 78972
		[Nullable(2)]
		private PopupCaptionItem PopupCaptionItem;

		// Token: 0x0401347D RID: 78973
		private InteractBackGround? InteractBackgroundConfig;

		// Token: 0x02009263 RID: 37475
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x0402DD16 RID: 187670
			public const int TitleSprite = 0;

			// Token: 0x0402DD17 RID: 187671
			public const int TitleText = 1;

			// Token: 0x0402DD18 RID: 187672
			public const int ContentSprite = 2;

			// Token: 0x0402DD19 RID: 187673
			public const int CaptionItem = 3;

			// Token: 0x0402DD1A RID: 187674
			public const int ContentItem = 4;
		}
	}
}
