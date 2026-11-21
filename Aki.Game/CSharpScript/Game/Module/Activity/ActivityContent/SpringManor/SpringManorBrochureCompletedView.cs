using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02005001 RID: 20481
	public class SpringManorBrochureCompletedView : UiViewBase
	{
		// Token: 0x06033443 RID: 209987 RVA: 0x00E5F98E File Offset: 0x00E5DB8E
		[NullableContext(1)]
		public SpringManorBrochureCompletedView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06033444 RID: 209988 RVA: 0x00E5F998 File Offset: 0x00E5DB98
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(4, new Action(this.OnClickBtnConfirmL)),
				new ValueTuple<int, Delegate>(5, new Action(this.OnClickBtnConfirmR))
			};
		}

		// Token: 0x06033445 RID: 209989 RVA: 0x00E5FA6F File Offset: 0x00E5DC6F
		protected override void OnStart()
		{
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.CaptionItem.SetCloseCallBack(delegate
			{
				base.CloseMe(null);
			});
		}

		// Token: 0x06033446 RID: 209990 RVA: 0x00E5FA9C File Offset: 0x00E5DC9C
		protected override void OnBeforeShow()
		{
			SpringManorBrochureCompletedViewOpenParam springManorBrochureCompletedViewOpenParam = this.OpenParam as SpringManorBrochureCompletedViewOpenParam;
			this.ConfigId = springManorBrochureCompletedViewOpenParam.ConfigId;
			this.SetDetailInfo();
		}

		// Token: 0x06033447 RID: 209991 RVA: 0x00E5FAC8 File Offset: 0x00E5DCC8
		private void SetDetailInfo()
		{
			SpringManorConfig instance = SpringManorConfig.Instance;
			BookItem? bookItem = (instance != null) ? instance.GetSpringManorBookItemById(this.ConfigId) : null;
			if (bookItem == null)
			{
				return;
			}
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.ShowTextNew(bookItem.Value.DescriptionTitle);
			}
			UUIText text2 = base.GetText(3);
			if (text2 != null)
			{
				text2.ShowTextNew(bookItem.Value.DescriptionText);
			}
			this.NextConfigId = 0;
			SpringManorModel instance2 = SpringManorModel.Instance;
			SpringManorData springManorData = (instance2 != null) ? instance2.ActivityData : null;
			if (springManorData != null)
			{
				this.NextConfigId = springManorData.GetNextLockBookItemId(this.ConfigId);
			}
			UUIButtonComponent button = base.GetButton(5);
			if (button != null)
			{
				UUIItem uuiitem = button.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(this.NextConfigId > 0);
				}
			}
			base.SetTextureByPath(bookItem.Value.ScreenIconDonePath, base.GetTexture(2), null, null);
			PopupCaptionItem captionItem = this.CaptionItem;
			if (captionItem == null)
			{
				return;
			}
			captionItem.SetTitle(bookItem.Value.DescriptionTitle);
		}

		// Token: 0x06033448 RID: 209992 RVA: 0x00E5FBE4 File Offset: 0x00E5DDE4
		private void OnClickBtnConfirmR()
		{
			if (this.NextConfigId <= 0)
			{
				return;
			}
			SpringManorConfig instance = SpringManorConfig.Instance;
			BookItem? bookItem = (instance != null) ? instance.GetSpringManorBookItemById(this.NextConfigId) : null;
			if (bookItem == null)
			{
				return;
			}
			if (bookItem.Value.TeleportEntityId > 0)
			{
				this.TeleportPlayerToEntity(this.NextConfigId).Forget();
			}
		}

		// Token: 0x06033449 RID: 209993 RVA: 0x00E5FC48 File Offset: 0x00E5DE48
		private UniTask TeleportPlayerToEntity(int configId)
		{
			SpringManorBrochureCompletedView.<TeleportPlayerToEntity>d__9 <TeleportPlayerToEntity>d__;
			<TeleportPlayerToEntity>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TeleportPlayerToEntity>d__.configId = configId;
			<TeleportPlayerToEntity>d__.<>1__state = -1;
			<TeleportPlayerToEntity>d__.<>t__builder.Start<SpringManorBrochureCompletedView.<TeleportPlayerToEntity>d__9>(ref <TeleportPlayerToEntity>d__);
			return <TeleportPlayerToEntity>d__.<>t__builder.Task;
		}

		// Token: 0x0603344A RID: 209994 RVA: 0x00E5FC8B File Offset: 0x00E5DE8B
		private void OnClickBtnConfirmL()
		{
			UiManager.Instance.OpenView(EUiViewName.SpringManorBrochureView, null, null);
			base.CloseMe(null);
		}

		// Token: 0x0401B40C RID: 111628
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401B40D RID: 111629
		private int ConfigId;

		// Token: 0x0401B40E RID: 111630
		private int NextConfigId;
	}
}
