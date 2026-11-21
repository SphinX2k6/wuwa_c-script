using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.SignalDeviceControl
{
	// Token: 0x02005BA3 RID: 23459
	[NullableContext(1)]
	[Nullable(0)]
	public class SignalDeviceController : UiControllerBase
	{
		// Token: 0x06039AFC RID: 236284 RVA: 0x01032792 File Offset: 0x01030992
		public void OpenGameplay(List<IColorPiece> config, Action finishCallback)
		{
			SignalDeviceModel.Instance.InitData(config);
			SignalDeviceModel.Instance.ViewType = EViewType.Normal;
			UiManager.Instance.OpenView(EUiViewName.SignalDeviceView, config, null);
			this.FinishCallback = finishCallback;
		}

		// Token: 0x06039AFD RID: 236285 RVA: 0x010327C2 File Offset: 0x010309C2
		public void OpenGameplayChasingMoon(List<IColorPiece> config, Action finishCallback)
		{
			SignalDeviceModel.Instance.InitData(config);
			SignalDeviceModel.Instance.ViewType = EViewType.ChasingMoon;
			UiManager.Instance.OpenView(EUiViewName.SignalDeviceChasingMoonView, config, null);
			this.FinishCallback = finishCallback;
		}

		// Token: 0x06039AFE RID: 236286 RVA: 0x010327F2 File Offset: 0x010309F2
		public void OnDotPressed(int index, EPieceColorType color)
		{
			if (SignalDeviceModel.Instance.IsGridFinished(index))
			{
				return;
			}
			SignalDeviceModel.Instance.LinkingStart(index, color);
		}

		// Token: 0x06039AFF RID: 236287 RVA: 0x0103280E File Offset: 0x01030A0E
		public void OnHovering(int index)
		{
			if (SignalDeviceModel.Instance.CurrentColor == EPieceColorType.White)
			{
				return;
			}
			SignalDeviceModel.Instance.Linking(index);
		}

		// Token: 0x06039B00 RID: 236288 RVA: 0x01032828 File Offset: 0x01030A28
		public void CheckLinking(int index)
		{
			SignalDeviceModel.Instance.CheckLinking(index);
		}

		// Token: 0x06039B01 RID: 236289 RVA: 0x01032835 File Offset: 0x01030A35
		public void ResetAll()
		{
			SignalDeviceModel.Instance.ResetData();
		}

		// Token: 0x06039B02 RID: 236290 RVA: 0x01032844 File Offset: 0x01030A44
		public void CallFinishCallback()
		{
			if (this.FinishCallback != null)
			{
				this.FinishCallback();
			}
			if (SignalDeviceModel.Instance.ViewType == EViewType.ChasingMoon)
			{
				UiManager.Instance.CloseView(EUiViewName.SignalDeviceChasingMoonView, null);
				return;
			}
			UiManager.Instance.CloseView(EUiViewName.SignalDeviceView, null);
		}

		// Token: 0x17006DF7 RID: 28151
		// (get) Token: 0x06039B03 RID: 236291 RVA: 0x01032892 File Offset: 0x01030A92
		public static SignalDeviceController Instance
		{
			get
			{
				return SignalDeviceController._Instance;
			}
		}

		// Token: 0x06039B04 RID: 236292 RVA: 0x01032899 File Offset: 0x01030A99
		public static SignalDeviceController GetOrCreateInstance()
		{
			if (SignalDeviceController._Instance == null)
			{
				SignalDeviceController.CreateInstance();
			}
			return SignalDeviceController._Instance;
		}

		// Token: 0x06039B05 RID: 236293 RVA: 0x010328AD File Offset: 0x01030AAD
		public static bool CreateInstance()
		{
			if (SignalDeviceController._Instance != null)
			{
				return true;
			}
			SignalDeviceController._Instance = new SignalDeviceController();
			return true;
		}

		// Token: 0x06039B06 RID: 236294 RVA: 0x010328C3 File Offset: 0x01030AC3
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06039B07 RID: 236295 RVA: 0x010328C5 File Offset: 0x01030AC5
		public static void ResetStaticDefaultValue()
		{
			SignalDeviceController._Instance = null;
		}

		// Token: 0x06039B08 RID: 236296 RVA: 0x010328CD File Offset: 0x01030ACD
		static SignalDeviceController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SignalDeviceController.CreateStaticDefaultValue), new Action(SignalDeviceController.ResetStaticDefaultValue));
		}

		// Token: 0x0401E71E RID: 124702
		[Nullable(2)]
		private Action FinishCallback;

		// Token: 0x0401E71F RID: 124703
		[Nullable(2)]
		private static SignalDeviceController _Instance;
	}
}
