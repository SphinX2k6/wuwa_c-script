using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003558 RID: 13656
	[NullableContext(1)]
	[Nullable(0)]
	public class UiBlurLogic : Singleton
	{
		// Token: 0x06022B84 RID: 142212 RVA: 0x009DFA18 File Offset: 0x009DDC18
		[NullableContext(2)]
		private void SetGlobalBlurIndex(UUIItem uiItem)
		{
			if (uiItem == null)
			{
				return;
			}
			TsUiBlur tsUiBlur = uiItem.GetOwner().GetComponentByClass(TsUiBlur.StaticClass()) as TsUiBlur;
			UUIItem uuiitem = null;
			if (tsUiBlur != null)
			{
				uuiitem = ((tsUiBlur.OverrideItem == null) ? uiItem : ((UUIItem)tsUiBlur.OverrideItem.RootComponent));
				tsUiBlur.ApplyItem = uiItem;
			}
			if (uuiitem == null || !tsUiBlur.EnableUiBlur)
			{
				ULGUIBPLibrary.ResetGlobalBlurUIItem(uiItem.GetWorld());
				return;
			}
			ULGUIBPLibrary.SetGlobalBlurUIItem(uuiitem, uiItem.GetWorld());
		}

		// Token: 0x06022B85 RID: 142213 RVA: 0x009DFA90 File Offset: 0x009DDC90
		private UUIItem GetRootItem(UiViewBase view)
		{
			IPopViewWithCustomUiBlurItem popViewWithCustomUiBlurItem = view as IPopViewWithCustomUiBlurItem;
			if (popViewWithCustomUiBlurItem != null)
			{
				return popViewWithCustomUiBlurItem.GetOverrideRootItem();
			}
			if (view.ChildPopView != null)
			{
				return view.ChildPopView.GetPopViewRootItem();
			}
			return view.GetBlurRootItem();
		}

		// Token: 0x06022B86 RID: 142214 RVA: 0x009DFAC8 File Offset: 0x009DDCC8
		public void SetNormalUiRenderAfterBlur(UiViewBase view)
		{
			this.SetGlobalBlurIndex(this.GetRootItem(view));
		}

		// Token: 0x06022B87 RID: 142215 RVA: 0x009DFAD8 File Offset: 0x009DDCD8
		public void ResumeTopUiRenderAfterBlur()
		{
			UiViewBase topView = UiModel.Instance.GetTopView(ELayerType.Pop);
			if (topView != null && topView.IsShowOrShowing)
			{
				this.SetNormalUiRenderAfterBlur(topView);
				return;
			}
			topView = UiModel.Instance.GetTopView(ELayerType.Plot);
			if (topView != null)
			{
				this.SetNormalUiRenderAfterBlur(topView);
				return;
			}
			topView = UiModel.Instance.GetTopView(ELayerType.Normal);
			if (topView != null)
			{
				this.SetNormalUiRenderAfterBlur(topView);
				return;
			}
			ULGUIBPLibrary.ResetGlobalBlurUIItem(GlobalData.GameInstance.GetWorld());
		}

		// Token: 0x1700489D RID: 18589
		// (get) Token: 0x06022B88 RID: 142216 RVA: 0x009DFB42 File Offset: 0x009DDD42
		public static UiBlurLogic Instance
		{
			get
			{
				if (UiBlurLogic._instance == null)
				{
					UiBlurLogic._instance = new UiBlurLogic();
					UiBlurLogic._instance.OnInit();
				}
				return UiBlurLogic._instance;
			}
		}

		// Token: 0x06022B89 RID: 142217 RVA: 0x009DFB65 File Offset: 0x009DDD65
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06022B8A RID: 142218 RVA: 0x009DFB67 File Offset: 0x009DDD67
		public static void ResetStaticDefaultValue()
		{
			UiBlurLogic instance = UiBlurLogic._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			UiBlurLogic._instance = null;
		}

		// Token: 0x06022B8B RID: 142219 RVA: 0x009DFB80 File Offset: 0x009DDD80
		static UiBlurLogic()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiBlurLogic.CreateStaticDefaultValue), new Action(UiBlurLogic.ResetStaticDefaultValue));
		}

		// Token: 0x040133B4 RID: 78772
		[Nullable(2)]
		private static UiBlurLogic _instance;
	}
}
