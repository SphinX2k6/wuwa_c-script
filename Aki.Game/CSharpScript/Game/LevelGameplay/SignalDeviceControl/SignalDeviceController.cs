using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.SignalDeviceControl
{
	// Token: 0x02006A46 RID: 27206
	[NullableContext(1)]
	[Nullable(0)]
	public class SignalDeviceController : UiControllerBase
	{
		// Token: 0x06043AAE RID: 277166 RVA: 0x0108DF8A File Offset: 0x0108C18A
		public void OpenGameplay(List<IColorPiece> config, Action finishCallback)
		{
			SignalDeviceModel.Instance.InitData(config);
			SignalDeviceModel.Instance.ViewType = EViewType.Normal;
			UiManager.Instance.OpenView(EUiViewName.SignalDeviceView, config, null);
			this.FinishCallback = finishCallback;
		}

		// Token: 0x06043AAF RID: 277167 RVA: 0x0108DFBA File Offset: 0x0108C1BA
		public void OpenGameplayChasingMoon(List<IColorPiece> config, Action finishCallback)
		{
			SignalDeviceModel.Instance.InitData(config);
			SignalDeviceModel.Instance.ViewType = EViewType.ChasingMoon;
			UiManager.Instance.OpenView(EUiViewName.SignalDeviceChasingMoonView, config, null);
			this.FinishCallback = finishCallback;
		}

		// Token: 0x06043AB0 RID: 277168 RVA: 0x0108DFEA File Offset: 0x0108C1EA
		public void OnDotPressed(int index, EPieceColorType color)
		{
			if (SignalDeviceModel.Instance.IsGridFinished(index))
			{
				return;
			}
			SignalDeviceModel.Instance.LinkingStart(index, color);
		}

		// Token: 0x06043AB1 RID: 277169 RVA: 0x0108E006 File Offset: 0x0108C206
		public void OnHovering(int index)
		{
			if (SignalDeviceModel.Instance.CurrentColor == EPieceColorType.White)
			{
				return;
			}
			SignalDeviceModel.Instance.Linking(index);
		}

		// Token: 0x06043AB2 RID: 277170 RVA: 0x0108E020 File Offset: 0x0108C220
		public void CheckLinking(int index)
		{
			SignalDeviceModel.Instance.CheckLinking(index);
		}

		// Token: 0x06043AB3 RID: 277171 RVA: 0x0108E02D File Offset: 0x0108C22D
		public void ResetAll()
		{
			SignalDeviceModel.Instance.ResetData();
		}

		// Token: 0x06043AB4 RID: 277172 RVA: 0x0108E03C File Offset: 0x0108C23C
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

		// Token: 0x17009912 RID: 39186
		// (get) Token: 0x06043AB5 RID: 277173 RVA: 0x0108E08A File Offset: 0x0108C28A
		public static SignalDeviceController Instance
		{
			get
			{
				return SignalDeviceController._Instance;
			}
		}

		// Token: 0x06043AB6 RID: 277174 RVA: 0x0108E091 File Offset: 0x0108C291
		public static SignalDeviceController GetOrCreateInstance()
		{
			if (SignalDeviceController._Instance == null)
			{
				SignalDeviceController.CreateInstance();
			}
			return SignalDeviceController._Instance;
		}

		// Token: 0x06043AB7 RID: 277175 RVA: 0x0108E0A5 File Offset: 0x0108C2A5
		public static bool CreateInstance()
		{
			if (SignalDeviceController._Instance != null)
			{
				return true;
			}
			SignalDeviceController._Instance = new SignalDeviceController();
			return true;
		}

		// Token: 0x06043AB8 RID: 277176 RVA: 0x0108E0BB File Offset: 0x0108C2BB
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06043AB9 RID: 277177 RVA: 0x0108E0BD File Offset: 0x0108C2BD
		public static void ResetStaticDefaultValue()
		{
			SignalDeviceController._Instance = null;
		}

		// Token: 0x06043ABA RID: 277178 RVA: 0x0108E0C5 File Offset: 0x0108C2C5
		static SignalDeviceController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SignalDeviceController.CreateStaticDefaultValue), new Action(SignalDeviceController.ResetStaticDefaultValue));
		}

		// Token: 0x0402352C RID: 144684
		[Nullable(2)]
		private Action FinishCallback;

		// Token: 0x0402352D RID: 144685
		[Nullable(2)]
		private static SignalDeviceController _Instance;
	}
}
