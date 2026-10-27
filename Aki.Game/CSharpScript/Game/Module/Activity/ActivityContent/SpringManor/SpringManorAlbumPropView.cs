using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02006076 RID: 24694
	public class SpringManorAlbumPropView : UiViewBase
	{
		// Token: 0x0603E722 RID: 255778 RVA: 0x00F165AD File Offset: 0x00F147AD
		[NullableContext(1)]
		public SpringManorAlbumPropView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603E723 RID: 255779 RVA: 0x00F165B8 File Offset: 0x00F147B8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClickButton))
			};
		}

		// Token: 0x0603E724 RID: 255780 RVA: 0x00F1664B File Offset: 0x00F1484B
		protected override void OnBeforeDestroy()
		{
			this.ClearAutoCloseTimer();
		}

		// Token: 0x0603E725 RID: 255781 RVA: 0x00F16653 File Offset: 0x00F14853
		protected override void OnBeforeShow()
		{
			this.RefreshView();
			this.AutoCloseTimer = TimerSystem.Instance.Delay(new TTimerAction(this.OnAutoClose), 4000f, null, null, true, 1f);
		}

		// Token: 0x0603E726 RID: 255782 RVA: 0x00F16684 File Offset: 0x00F14884
		private void RefreshView()
		{
			SpringManorAlbumPropViewOpenParam springManorAlbumPropViewOpenParam = this.OpenParam as SpringManorAlbumPropViewOpenParam;
			SpringManorConfig instance = SpringManorConfig.Instance;
			Brochure? brochure = (instance != null) ? instance.GetSpringManorBrochureById(springManorAlbumPropViewOpenParam.BrochureId) : null;
			if (brochure != null)
			{
				EBrochureType type = (EBrochureType)brochure.Value.Type;
				if (type == EBrochureType.Character)
				{
					UUIText text = base.GetText(2);
					if (text != null)
					{
						text.ShowTextNew("PrefabTextItem_1493464652_Text");
					}
					string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_AlbumPropIcon01");
					base.SetTextureByPath(resourcePath, base.GetTexture(1), null, null);
				}
				else if (type == EBrochureType.EasterEggBook)
				{
					UUIText text2 = base.GetText(2);
					if (text2 != null)
					{
						text2.ShowTextNew("PrefabTextItem_3103733560_Text");
					}
					string resourcePath2 = UiResourceConfig.Instance.GetResourcePath("T_AlbumPropIcon00");
					base.SetTextureByPath(resourcePath2, base.GetTexture(1), null, null);
				}
			}
			SpringManorConfig instance2 = SpringManorConfig.Instance;
			BookItem? bookItem = (instance2 != null) ? instance2.GetSpringManorBookItemById(springManorAlbumPropViewOpenParam.ConfigId) : null;
			if (bookItem != null)
			{
				UUIText text3 = base.GetText(3);
				if (text3 == null)
				{
					return;
				}
				text3.ShowTextNew((bookItem != null) ? bookItem.GetValueOrDefault().DescriptionTitle : null);
			}
		}

		// Token: 0x0603E727 RID: 255783 RVA: 0x00F167C1 File Offset: 0x00F149C1
		private void OnAutoClose(float _)
		{
			this.AutoCloseTimer = null;
			base.CloseMe(null);
		}

		// Token: 0x0603E728 RID: 255784 RVA: 0x00F167D1 File Offset: 0x00F149D1
		private void ClearAutoCloseTimer()
		{
			TimerHandle autoCloseTimer = this.AutoCloseTimer;
			if (autoCloseTimer != null && autoCloseTimer.Valid())
			{
				TimerSystem.Instance.Remove(this.AutoCloseTimer);
				this.AutoCloseTimer = null;
			}
		}

		// Token: 0x0603E729 RID: 255785 RVA: 0x00F16800 File Offset: 0x00F14A00
		private void OnClickButton()
		{
			SpringManorAlbumPropViewOpenParam springManorAlbumPropViewOpenParam = this.OpenParam as SpringManorAlbumPropViewOpenParam;
			SpringManorConfig instance = SpringManorConfig.Instance;
			Brochure? brochure = (instance != null) ? instance.GetSpringManorBrochureById(springManorAlbumPropViewOpenParam.BrochureId) : null;
			if (brochure != null)
			{
				SpringManorAlbumViewOpenParam param = new SpringManorAlbumViewOpenParam
				{
					OpenTab = (EBrochureType)brochure.Value.Type
				};
				UiManager.Instance.OpenView(EUiViewName.SpringManorAlbumView, param, null);
				base.CloseMe(null);
			}
		}

		// Token: 0x04020A6E RID: 133742
		private const int DEFAULT_AUTO_CLOSE_TIME = 4000;

		// Token: 0x04020A6F RID: 133743
		[Nullable(2)]
		private TimerHandle AutoCloseTimer;
	}
}
