using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003557 RID: 13655
	public class UiBehaviourUiBlur : IUiBehavior, IStaticVariableResetter
	{
		// Token: 0x06022B72 RID: 142194 RVA: 0x009DF5D9 File Offset: 0x009DD7D9
		static UiBehaviourUiBlur()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiBehaviourUiBlur.CreateStaticDefaultValue), new Action(UiBehaviourUiBlur.ResetStaticDefaultValue));
		}

		// Token: 0x1700489C RID: 18588
		// (get) Token: 0x06022B73 RID: 142195 RVA: 0x009DF5F8 File Offset: 0x009DD7F8
		[Nullable(1)]
		private static List<int> BlurViewSet
		{
			[NullableContext(1)]
			get
			{
				return UiBehaviourUiBlur._blurViewSet;
			}
		}

		// Token: 0x06022B74 RID: 142196 RVA: 0x009DF600 File Offset: 0x009DD800
		public void OnUiStart()
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

		// Token: 0x06022B75 RID: 142197 RVA: 0x009DF667 File Offset: 0x009DD867
		public void OnUiShow()
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

		// Token: 0x06022B76 RID: 142198 RVA: 0x009DF699 File Offset: 0x009DD899
		public void OnUiHide()
		{
		}

		// Token: 0x06022B77 RID: 142199 RVA: 0x009DF69C File Offset: 0x009DD89C
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

		// Token: 0x06022B78 RID: 142200 RVA: 0x009DF790 File Offset: 0x009DD990
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

		// Token: 0x06022B79 RID: 142201 RVA: 0x009DF7F8 File Offset: 0x009DD9F8
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

		// Token: 0x06022B7A RID: 142202 RVA: 0x009DF8D8 File Offset: 0x009DDAD8
		public void RefreshBlur()
		{
			if (!this.IfNeedBlurEffect)
			{
				return;
			}
			UiBlurLogic.Instance.SetNormalUiRenderAfterBlur(this.CurrentView);
		}

		// Token: 0x06022B7B RID: 142203 RVA: 0x009DF8F3 File Offset: 0x009DDAF3
		public void ChangeNeedBlurState(bool state)
		{
			this.IfNeedBlurEffect = state;
		}

		// Token: 0x06022B7C RID: 142204 RVA: 0x009DF8FC File Offset: 0x009DDAFC
		public void SetCurrentLayer(ELayerType layerType)
		{
			this.CurrentLayer = new ELayerType?(layerType);
		}

		// Token: 0x06022B7D RID: 142205 RVA: 0x009DF90A File Offset: 0x009DDB0A
		[NullableContext(1)]
		public void SetViewInfo(UiViewBase baseView)
		{
			this.CurrentView = baseView;
		}

		// Token: 0x06022B7E RID: 142206 RVA: 0x009DF914 File Offset: 0x009DDB14
		public void OnDestroy()
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

		// Token: 0x06022B7F RID: 142207 RVA: 0x009DF970 File Offset: 0x009DDB70
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

		// Token: 0x06022B80 RID: 142208 RVA: 0x009DF9F4 File Offset: 0x009DDBF4
		public UniTask OnUiCreateAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06022B81 RID: 142209 RVA: 0x009DF9FB File Offset: 0x009DDBFB
		public static void CreateStaticDefaultValue()
		{
			UiBehaviourUiBlur._blurViewSet = new List<int>();
		}

		// Token: 0x06022B82 RID: 142210 RVA: 0x009DFA07 File Offset: 0x009DDC07
		public static void ResetStaticDefaultValue()
		{
			UiBehaviourUiBlur._blurViewSet = null;
		}

		// Token: 0x040133B0 RID: 78768
		private ELayerType? CurrentLayer;

		// Token: 0x040133B1 RID: 78769
		[Nullable(2)]
		protected UiViewBase CurrentView;

		// Token: 0x040133B2 RID: 78770
		private bool IfNeedBlurEffect;

		// Token: 0x040133B3 RID: 78771
		[Nullable(2)]
		private static List<int> _blurViewSet;
	}
}
