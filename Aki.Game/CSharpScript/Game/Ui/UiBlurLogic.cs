using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200462E RID: 17966
	[NullableContext(1)]
	[Nullable(0)]
	public class UiBlurLogic : Singleton
	{
		// Token: 0x0602E471 RID: 189553 RVA: 0x00AB2C88 File Offset: 0x00AB0E88
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

		// Token: 0x0602E472 RID: 189554 RVA: 0x00AB2D00 File Offset: 0x00AB0F00
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

		// Token: 0x0602E473 RID: 189555 RVA: 0x00AB2D38 File Offset: 0x00AB0F38
		public void SetNormalUiRenderAfterBlur(UiViewBase view)
		{
			this.SetGlobalBlurIndex(this.GetRootItem(view));
		}

		// Token: 0x0602E474 RID: 189556 RVA: 0x00AB2D48 File Offset: 0x00AB0F48
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

		// Token: 0x170075E3 RID: 30179
		// (get) Token: 0x0602E475 RID: 189557 RVA: 0x00AB2DB2 File Offset: 0x00AB0FB2
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

		// Token: 0x0602E476 RID: 189558 RVA: 0x00AB2DD5 File Offset: 0x00AB0FD5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E477 RID: 189559 RVA: 0x00AB2DD7 File Offset: 0x00AB0FD7
		public static void ResetStaticDefaultValue()
		{
			UiBlurLogic instance = UiBlurLogic._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			UiBlurLogic._instance = null;
		}

		// Token: 0x0602E478 RID: 189560 RVA: 0x00AB2DF0 File Offset: 0x00AB0FF0
		static UiBlurLogic()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiBlurLogic.CreateStaticDefaultValue), new Action(UiBlurLogic.ResetStaticDefaultValue));
		}

		// Token: 0x04018D67 RID: 101735
		[Nullable(2)]
		private static UiBlurLogic _instance;
	}
}
