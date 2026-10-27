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
	// Token: 0x02006083 RID: 24707
	public class SpringManorBrochureCompletedView : UiViewBase
	{
		// Token: 0x0603E77F RID: 255871 RVA: 0x00F18BCA File Offset: 0x00F16DCA
		[NullableContext(1)]
		public SpringManorBrochureCompletedView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603E780 RID: 255872 RVA: 0x00F18BD4 File Offset: 0x00F16DD4
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

		// Token: 0x0603E781 RID: 255873 RVA: 0x00F18CAB File Offset: 0x00F16EAB
		protected override void OnStart()
		{
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.CaptionItem.SetCloseCallBack(delegate
			{
				base.CloseMe(null);
			});
		}

		// Token: 0x0603E782 RID: 255874 RVA: 0x00F18CD8 File Offset: 0x00F16ED8
		protected override void OnBeforeShow()
		{
			SpringManorBrochureCompletedViewOpenParam springManorBrochureCompletedViewOpenParam = this.OpenParam as SpringManorBrochureCompletedViewOpenParam;
			this.ConfigId = springManorBrochureCompletedViewOpenParam.ConfigId;
			this.SetDetailInfo();
		}

		// Token: 0x0603E783 RID: 255875 RVA: 0x00F18D04 File Offset: 0x00F16F04
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

		// Token: 0x0603E784 RID: 255876 RVA: 0x00F18E20 File Offset: 0x00F17020
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

		// Token: 0x0603E785 RID: 255877 RVA: 0x00F18E84 File Offset: 0x00F17084
		private UniTask TeleportPlayerToEntity(int configId)
		{
			SpringManorBrochureCompletedView.<TeleportPlayerToEntity>d__9 <TeleportPlayerToEntity>d__;
			<TeleportPlayerToEntity>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TeleportPlayerToEntity>d__.configId = configId;
			<TeleportPlayerToEntity>d__.<>1__state = -1;
			<TeleportPlayerToEntity>d__.<>t__builder.Start<SpringManorBrochureCompletedView.<TeleportPlayerToEntity>d__9>(ref <TeleportPlayerToEntity>d__);
			return <TeleportPlayerToEntity>d__.<>t__builder.Task;
		}

		// Token: 0x0603E786 RID: 255878 RVA: 0x00F18EC7 File Offset: 0x00F170C7
		private void OnClickBtnConfirmL()
		{
			UiManager.Instance.OpenView(EUiViewName.SpringManorBrochureView, null, null);
			base.CloseMe(null);
		}

		// Token: 0x04020ADF RID: 133855
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04020AE0 RID: 133856
		private int ConfigId;

		// Token: 0x04020AE1 RID: 133857
		private int NextConfigId;
	}
}
