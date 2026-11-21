using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200392E RID: 14638
	public class PlotInteractComponentBase : HotKeyComponent
	{
		// Token: 0x06025CD4 RID: 154836 RVA: 0x00A9F730 File Offset: 0x00A9D930
		public PlotInteractComponentBase(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025CD5 RID: 154837 RVA: 0x00A9F739 File Offset: 0x00A9D939
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.PlotEnableControlView, new Action<bool>(this.PlotEnableControlView));
		}

		// Token: 0x06025CD6 RID: 154838 RVA: 0x00A9F757 File Offset: 0x00A9D957
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.PlotEnableControlView, new Action<bool>(this.PlotEnableControlView));
		}

		// Token: 0x06025CD7 RID: 154839 RVA: 0x00A9F778 File Offset: 0x00A9D978
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			string bindButtonTag = base.GetBindButtonTag();
			if (StringUtils.IsEmpty(bindButtonTag))
			{
				return;
			}
			TsUiNavigationBehaviorListener activeListenerByTag = viewHandle.GetActiveListenerByTag(bindButtonTag);
			this.Listener = activeListenerByTag;
			TsUiNavigationBehaviorListener listener = this.Listener;
			bool flag = listener != null && listener.IsListenerActive();
			bool flag2 = PlotModel.Instance.CanControlView && this.CheckAxisCanInput() && this.CheckCameraMode();
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, flag && flag2, false);
		}

		// Token: 0x06025CD8 RID: 154840 RVA: 0x00A9F7E0 File Offset: 0x00A9D9E0
		private void PlotEnableControlView(bool isActive)
		{
			bool flag = isActive && this.CheckAxisCanInput() && this.CheckCameraMode();
			TsUiNavigationBehaviorListener listener = this.Listener;
			bool flag2 = listener != null && listener.IsListenerActive();
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, flag2 && flag, false);
		}

		// Token: 0x06025CD9 RID: 154841 RVA: 0x00A9F820 File Offset: 0x00A9DA20
		private bool CheckCameraMode()
		{
			ECustomCameraMode? cameraMode = CameraModel.Instance.MainModel.CameraMode;
			ECustomCameraMode ecustomCameraMode = ECustomCameraMode.LockOn;
			return cameraMode.GetValueOrDefault() == ecustomCameraMode & cameraMode != null;
		}

		// Token: 0x06025CDA RID: 154842 RVA: 0x00A9F851 File Offset: 0x00A9DA51
		protected virtual bool CheckAxisCanInput()
		{
			return true;
		}

		// Token: 0x04014D2B RID: 85291
		protected const float ZOOM_RATE = 30f;

		// Token: 0x04014D2C RID: 85292
		protected const float MOVE_RATE = 0.7f;

		// Token: 0x04014D2D RID: 85293
		[Nullable(2)]
		private TsUiNavigationBehaviorListener Listener;
	}
}
