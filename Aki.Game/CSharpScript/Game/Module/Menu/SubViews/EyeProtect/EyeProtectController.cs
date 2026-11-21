using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.GameSettings;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews.EyeProtect
{
	// Token: 0x0200442C RID: 17452
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class EyeProtectController : UiControllerBase
	{
		// Token: 0x0602C0B0 RID: 180400 RVA: 0x00C5DFCF File Offset: 0x00C5C1CF
		protected override void OnRegisterNetEvent()
		{
		}

		// Token: 0x0602C0B1 RID: 180401 RVA: 0x00C5DFD1 File Offset: 0x00C5C1D1
		protected override void OnUnRegisterNetEvent()
		{
		}

		// Token: 0x0602C0B2 RID: 180402 RVA: 0x00C5DFD3 File Offset: 0x00C5C1D3
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<int>(EEventName.CharOnRoleDead, new Action<int>(this.OnRoleDead));
			EventSystem.Instance.Add(EEventName.LogOut, new Action(this.HandleBackLoginView));
		}

		// Token: 0x0602C0B3 RID: 180403 RVA: 0x00C5E00D File Offset: 0x00C5C20D
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.CharOnRoleDead, new Action<int>(this.OnRoleDead));
			EventSystem.Instance.Remove(EEventName.LogOut, new Action(this.HandleBackLoginView));
		}

		// Token: 0x0602C0B4 RID: 180404 RVA: 0x00C5E048 File Offset: 0x00C5C248
		[NullableContext(0)]
		public UniTask<bool> BuildViewModelAndOpen([Nullable(1)] EyeProtectViewModel viewModel)
		{
			EyeProtectController.<BuildViewModelAndOpen>d__4 <BuildViewModelAndOpen>d__;
			<BuildViewModelAndOpen>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<BuildViewModelAndOpen>d__.viewModel = viewModel;
			<BuildViewModelAndOpen>d__.<>1__state = -1;
			<BuildViewModelAndOpen>d__.<>t__builder.Start<EyeProtectController.<BuildViewModelAndOpen>d__4>(ref <BuildViewModelAndOpen>d__);
			return <BuildViewModelAndOpen>d__.<>t__builder.Task;
		}

		// Token: 0x0602C0B5 RID: 180405 RVA: 0x00C5E08C File Offset: 0x00C5C28C
		[NullableContext(0)]
		public UniTask<bool> OpenEyeProtectView()
		{
			EyeProtectController.<OpenEyeProtectView>d__5 <OpenEyeProtectView>d__;
			<OpenEyeProtectView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenEyeProtectView>d__.<>4__this = this;
			<OpenEyeProtectView>d__.<>1__state = -1;
			<OpenEyeProtectView>d__.<>t__builder.Start<EyeProtectController.<OpenEyeProtectView>d__5>(ref <OpenEyeProtectView>d__);
			return <OpenEyeProtectView>d__.<>t__builder.Task;
		}

		// Token: 0x0602C0B6 RID: 180406 RVA: 0x00C5E0D0 File Offset: 0x00C5C2D0
		public UniTask CloseEyeProtectView()
		{
			EyeProtectController.<CloseEyeProtectView>d__6 <CloseEyeProtectView>d__;
			<CloseEyeProtectView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CloseEyeProtectView>d__.<>1__state = -1;
			<CloseEyeProtectView>d__.<>t__builder.Start<EyeProtectController.<CloseEyeProtectView>d__6>(ref <CloseEyeProtectView>d__);
			return <CloseEyeProtectView>d__.<>t__builder.Task;
		}

		// Token: 0x0602C0B7 RID: 180407 RVA: 0x00C5E10B File Offset: 0x00C5C30B
		private EyeProtectViewModel BuildViewModel()
		{
			return new EyeProtectViewModel();
		}

		// Token: 0x0602C0B8 RID: 180408 RVA: 0x00C5E112 File Offset: 0x00C5C312
		public void ApplyEyeProtectSetting()
		{
			GameSettingsUtils.ApplyEyeProtectionMode(GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.EyeProtectionMode, 0, true));
		}

		// Token: 0x0602C0B9 RID: 180409 RVA: 0x00C5E12B File Offset: 0x00C5C32B
		public void SwitchFilter(bool isOn)
		{
			if (isOn)
			{
				GameSettingsUtils.ApplyImageDisplayMode(GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.ImageDisplayMode, 0, true));
				return;
			}
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.BlueLightFilter.Disable 1", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Tonemapper.BrightnessAndTextureDisable 1", null);
		}

		// Token: 0x0602C0BA RID: 180410 RVA: 0x00C5E168 File Offset: 0x00C5C368
		private void HandleBackLoginView()
		{
			this.SwitchFilter(false);
		}

		// Token: 0x0602C0BB RID: 180411 RVA: 0x00C5E171 File Offset: 0x00C5C371
		private void OnRoleDead(int charId)
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.EyeProtectView))
			{
				UiManager.Instance.CloseView(EUiViewName.EyeProtectView, null);
			}
		}

		// Token: 0x17005810 RID: 22544
		// (get) Token: 0x0602C0BC RID: 180412 RVA: 0x00C5E194 File Offset: 0x00C5C394
		public static EyeProtectController Instance
		{
			get
			{
				return EyeProtectController._Instance;
			}
		}

		// Token: 0x0602C0BD RID: 180413 RVA: 0x00C5E19B File Offset: 0x00C5C39B
		public static EyeProtectController GetOrCreateInstance()
		{
			if (EyeProtectController._Instance == null)
			{
				EyeProtectController.CreateInstance();
			}
			return EyeProtectController._Instance;
		}

		// Token: 0x0602C0BE RID: 180414 RVA: 0x00C5E1AF File Offset: 0x00C5C3AF
		public static bool CreateInstance()
		{
			if (EyeProtectController._Instance != null)
			{
				return true;
			}
			EyeProtectController._Instance = new EyeProtectController();
			return true;
		}

		// Token: 0x0602C0BF RID: 180415 RVA: 0x00C5E1C5 File Offset: 0x00C5C3C5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602C0C0 RID: 180416 RVA: 0x00C5E1C7 File Offset: 0x00C5C3C7
		public static void ResetStaticDefaultValue()
		{
			EyeProtectController._Instance = null;
		}

		// Token: 0x0602C0C1 RID: 180417 RVA: 0x00C5E1CF File Offset: 0x00C5C3CF
		static EyeProtectController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(EyeProtectController.CreateStaticDefaultValue), new Action(EyeProtectController.ResetStaticDefaultValue));
		}

		// Token: 0x04017BA1 RID: 97185
		[Nullable(2)]
		private static EyeProtectController _Instance;
	}
}
