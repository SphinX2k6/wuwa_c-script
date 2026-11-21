using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02004FF4 RID: 20468
	public class SpringManorAlbumPropView : UiViewBase
	{
		// Token: 0x060333E6 RID: 209894 RVA: 0x00E5D371 File Offset: 0x00E5B571
		[NullableContext(1)]
		public SpringManorAlbumPropView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060333E7 RID: 209895 RVA: 0x00E5D37C File Offset: 0x00E5B57C
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

		// Token: 0x060333E8 RID: 209896 RVA: 0x00E5D40F File Offset: 0x00E5B60F
		protected override void OnBeforeDestroy()
		{
			this.ClearAutoCloseTimer();
		}

		// Token: 0x060333E9 RID: 209897 RVA: 0x00E5D417 File Offset: 0x00E5B617
		protected override void OnBeforeShow()
		{
			this.RefreshView();
			this.AutoCloseTimer = TimerSystem.Instance.Delay(new TTimerAction(this.OnAutoClose), 4000f, null, null, true, 1f);
		}

		// Token: 0x060333EA RID: 209898 RVA: 0x00E5D448 File Offset: 0x00E5B648
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

		// Token: 0x060333EB RID: 209899 RVA: 0x00E5D585 File Offset: 0x00E5B785
		private void OnAutoClose(float _)
		{
			this.AutoCloseTimer = null;
			base.CloseMe(null);
		}

		// Token: 0x060333EC RID: 209900 RVA: 0x00E5D595 File Offset: 0x00E5B795
		private void ClearAutoCloseTimer()
		{
			TimerHandle autoCloseTimer = this.AutoCloseTimer;
			if (autoCloseTimer != null && autoCloseTimer.Valid())
			{
				TimerSystem.Instance.Remove(this.AutoCloseTimer);
				this.AutoCloseTimer = null;
			}
		}

		// Token: 0x060333ED RID: 209901 RVA: 0x00E5D5C4 File Offset: 0x00E5B7C4
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

		// Token: 0x0401B39B RID: 111515
		private const int DEFAULT_AUTO_CLOSE_TIME = 4000;

		// Token: 0x0401B39C RID: 111516
		[Nullable(2)]
		private TimerHandle AutoCloseTimer;
	}
}
