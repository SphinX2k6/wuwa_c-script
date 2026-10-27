using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200462D RID: 17965
	public class UiBehaviourUiBlur : IUiBehavior, IStaticVariableResetter
	{
		// Token: 0x0602E45F RID: 189535 RVA: 0x00AB2849 File Offset: 0x00AB0A49
		static UiBehaviourUiBlur()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiBehaviourUiBlur.CreateStaticDefaultValue), new Action(UiBehaviourUiBlur.ResetStaticDefaultValue));
		}

		// Token: 0x170075E2 RID: 30178
		// (get) Token: 0x0602E460 RID: 189536 RVA: 0x00AB2868 File Offset: 0x00AB0A68
		[Nullable(1)]
		private static List<int> BlurViewSet
		{
			[NullableContext(1)]
			get
			{
				return UiBehaviourUiBlur._blurViewSet;
			}
		}

		// Token: 0x0602E461 RID: 189537 RVA: 0x00AB2870 File Offset: 0x00AB0A70
		public void OnAfterUiStart()
		{
			if ((this.CurrentLayer.GetValueOrDefault() & (ELayerType.Normal | ELayerType.Plot | ELayerType.Pop)) == (ELayerType)0)
			{
				return;
			}
			this.IfNeedBlurEffect = true;
			if (this.CurrentView != null)
			{
				UiBlurLogic.Instance.SetNormalUiRenderAfterBlur(this.CurrentView);
				int viewId = this.CurrentView.GetViewId();
				if (!UiBehaviourUiBlur.BlurViewSet.Contains(viewId))
				{
					UiBehaviourUiBlur.BlurViewSet.Add(viewId);
				}
			}
			this.RefreshViewBlurMode();
		}

		// Token: 0x0602E462 RID: 189538 RVA: 0x00AB28D7 File Offset: 0x00AB0AD7
		public void OnAfterUiShow()
		{
			if (!this.IfNeedBlurEffect)
			{
				return;
			}
			if (this.HasExitingPartialBlurView())
			{
				return;
			}
			this.SetSaveModeByCurrentView();
			if (this.CurrentView != null)
			{
				UiBlurLogic.Instance.SetNormalUiRenderAfterBlur(this.CurrentView);
			}
		}

		// Token: 0x0602E463 RID: 189539 RVA: 0x00AB2909 File Offset: 0x00AB0B09
		public void OnBeforeUiHide()
		{
		}

		// Token: 0x0602E464 RID: 189540 RVA: 0x00AB290C File Offset: 0x00AB0B0C
		private bool HasExitingPartialBlurView()
		{
			UiViewBase currentView = this.CurrentView;
			int? num = (currentView != null) ? new int?(currentView.GetViewId()) : null;
			foreach (int num2 in UiBehaviourUiBlur.BlurViewSet)
			{
				int num3 = num2;
				int? num4 = num;
				if (!(num3 == num4.GetValueOrDefault() & num4 != null))
				{
					UiViewBase view = UiManager.Instance.GetView(num2);
					UiShow? uiShow;
					if (view != null && (view.IsStartOrStarting || view.IsShowOrShowing || view.IsHiding) && (UiViewConfig.Instance.GetUiShowConfig(view.ViewInfo.Name) != null && uiShow.GetValueOrDefault().PartialBlur))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0602E465 RID: 189541 RVA: 0x00AB2A00 File Offset: 0x00AB0C00
		private void SetSaveModeByCurrentView()
		{
			UiShow? uiShow;
			if (UiViewConfig.Instance.GetUiShowConfig(this.CurrentView.ViewInfo.Name) != null && uiShow.GetValueOrDefault().PartialBlur)
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.kuro.LGUIBlurTexture.save 1", null);
				return;
			}
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.kuro.LGUIBlurTexture.save 0", null);
		}

		// Token: 0x0602E466 RID: 189542 RVA: 0x00AB2A68 File Offset: 0x00AB0C68
		private void RefreshViewBlurMode()
		{
			if (!this.IfNeedBlurEffect)
			{
				return;
			}
			int? num = (UiBehaviourUiBlur.BlurViewSet.Count > 0) ? new int?(UiBehaviourUiBlur.BlurViewSet[UiBehaviourUiBlur.BlurViewSet.Count - 1]) : null;
			if (num != null)
			{
				UiViewBase view = UiManager.Instance.GetView(num.Value);
				if (view != null)
				{
					UiShow? uiShow;
					bool? flag = (UiViewConfig.Instance.GetUiShowConfig(view.ViewInfo.Name) != null) ? new bool?(uiShow.GetValueOrDefault().PartialBlur) : null;
					if (flag != null && flag.Value)
					{
						UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.kuro.LGUIBlurTexture.save 1", null);
						return;
					}
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.kuro.LGUIBlurTexture.save 0", null);
				}
			}
		}

		// Token: 0x0602E467 RID: 189543 RVA: 0x00AB2B48 File Offset: 0x00AB0D48
		public void RefreshBlur()
		{
			if (!this.IfNeedBlurEffect)
			{
				return;
			}
			UiBlurLogic.Instance.SetNormalUiRenderAfterBlur(this.CurrentView);
		}

		// Token: 0x0602E468 RID: 189544 RVA: 0x00AB2B63 File Offset: 0x00AB0D63
		public void ChangeNeedBlurState(bool state)
		{
			this.IfNeedBlurEffect = state;
		}

		// Token: 0x0602E469 RID: 189545 RVA: 0x00AB2B6C File Offset: 0x00AB0D6C
		public void SetCurrentLayer(ELayerType layerType)
		{
			this.CurrentLayer = new ELayerType?(layerType);
		}

		// Token: 0x0602E46A RID: 189546 RVA: 0x00AB2B7A File Offset: 0x00AB0D7A
		[NullableContext(1)]
		public void SetViewInfo(UiViewBase baseView)
		{
			this.CurrentView = baseView;
		}

		// Token: 0x0602E46B RID: 189547 RVA: 0x00AB2B84 File Offset: 0x00AB0D84
		public void OnBeforeDestroy()
		{
			if (this.CurrentView != null)
			{
				UiBehaviourUiBlur.BlurViewSet.Remove(this.CurrentView.GetViewId());
			}
			this.RefreshViewBlurMode();
			if (!this.IfNeedBlurEffect)
			{
				return;
			}
			if (this.CurrentLayer.GetValueOrDefault() == ELayerType.Pop || this.IsCurrentViewPartialBlur())
			{
				UiBlurLogic.Instance.ResumeTopUiRenderAfterBlur();
			}
		}

		// Token: 0x0602E46C RID: 189548 RVA: 0x00AB2BE0 File Offset: 0x00AB0DE0
		public bool IsCurrentViewPartialBlur()
		{
			if (this.IfNeedBlurEffect)
			{
				UiViewBase currentView = this.CurrentView;
				bool flag;
				if (currentView == null)
				{
					flag = true;
				}
				else
				{
					UiViewInfo viewInfo = currentView.ViewInfo;
					EUiViewName? euiViewName = (viewInfo != null) ? new EUiViewName?(viewInfo.Name) : null;
					flag = (euiViewName == null);
				}
				if (!flag)
				{
					UiShow? uiShow;
					return UiViewConfig.Instance.GetUiShowConfig(this.CurrentView.ViewInfo.Name) != null && uiShow.GetValueOrDefault().PartialBlur;
				}
			}
			return false;
		}

		// Token: 0x0602E46D RID: 189549 RVA: 0x00AB2C64 File Offset: 0x00AB0E64
		public UniTask OnUiCreateAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0602E46E RID: 189550 RVA: 0x00AB2C6B File Offset: 0x00AB0E6B
		public static void CreateStaticDefaultValue()
		{
			UiBehaviourUiBlur._blurViewSet = new List<int>();
		}

		// Token: 0x0602E46F RID: 189551 RVA: 0x00AB2C77 File Offset: 0x00AB0E77
		public static void ResetStaticDefaultValue()
		{
			UiBehaviourUiBlur._blurViewSet = null;
		}

		// Token: 0x04018D63 RID: 101731
		private ELayerType? CurrentLayer;

		// Token: 0x04018D64 RID: 101732
		[Nullable(2)]
		protected UiViewBase CurrentView;

		// Token: 0x04018D65 RID: 101733
		private bool IfNeedBlurEffect;

		// Token: 0x04018D66 RID: 101734
		[Nullable(2)]
		private static List<int> _blurViewSet;
	}
}
