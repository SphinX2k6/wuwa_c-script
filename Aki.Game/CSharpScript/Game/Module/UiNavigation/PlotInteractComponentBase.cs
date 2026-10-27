using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049B4 RID: 18868
	public class PlotInteractComponentBase : HotKeyComponent
	{
		// Token: 0x0603119E RID: 201118 RVA: 0x00B647E0 File Offset: 0x00B629E0
		public PlotInteractComponentBase(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603119F RID: 201119 RVA: 0x00B647E9 File Offset: 0x00B629E9
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.PlotEnableControlView, new Action<bool>(this.PlotEnableControlView));
		}

		// Token: 0x060311A0 RID: 201120 RVA: 0x00B64807 File Offset: 0x00B62A07
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.PlotEnableControlView, new Action<bool>(this.PlotEnableControlView));
		}

		// Token: 0x060311A1 RID: 201121 RVA: 0x00B64828 File Offset: 0x00B62A28
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

		// Token: 0x060311A2 RID: 201122 RVA: 0x00B64890 File Offset: 0x00B62A90
		private void PlotEnableControlView(bool isActive)
		{
			bool flag = isActive && this.CheckAxisCanInput() && this.CheckCameraMode();
			TsUiNavigationBehaviorListener listener = this.Listener;
			bool flag2 = listener != null && listener.IsListenerActive();
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, flag2 && flag, false);
		}

		// Token: 0x060311A3 RID: 201123 RVA: 0x00B648D0 File Offset: 0x00B62AD0
		private bool CheckCameraMode()
		{
			ECustomCameraMode? cameraMode = CameraModel.Instance.MainModel.CameraMode;
			ECustomCameraMode ecustomCameraMode = ECustomCameraMode.LockOn;
			return cameraMode.GetValueOrDefault() == ecustomCameraMode & cameraMode != null;
		}

		// Token: 0x060311A4 RID: 201124 RVA: 0x00B64901 File Offset: 0x00B62B01
		protected virtual bool CheckAxisCanInput()
		{
			return true;
		}

		// Token: 0x0401A4B9 RID: 107705
		protected const float ZOOM_RATE = 30f;

		// Token: 0x0401A4BA RID: 107706
		protected const float MOVE_RATE = 0.7f;

		// Token: 0x0401A4BB RID: 107707
		[Nullable(2)]
		private TsUiNavigationBehaviorListener Listener;
	}
}
