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
	// Token: 0x02005449 RID: 21577
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class EyeProtectController : UiControllerBase
	{
		// Token: 0x06037167 RID: 225639 RVA: 0x00D0EBB7 File Offset: 0x00D0CDB7
		protected override void OnRegisterNetEvent()
		{
		}

		// Token: 0x06037168 RID: 225640 RVA: 0x00D0EBB9 File Offset: 0x00D0CDB9
		protected override void OnUnRegisterNetEvent()
		{
		}

		// Token: 0x06037169 RID: 225641 RVA: 0x00D0EBBB File Offset: 0x00D0CDBB
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<int>(EEventName.CharOnRoleDead, new Action<int>(this.OnRoleDead));
			EventSystem.Instance.Add(EEventName.LogOut, new Action(this.HandleBackLoginView));
		}

		// Token: 0x0603716A RID: 225642 RVA: 0x00D0EBF5 File Offset: 0x00D0CDF5
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.CharOnRoleDead, new Action<int>(this.OnRoleDead));
			EventSystem.Instance.Remove(EEventName.LogOut, new Action(this.HandleBackLoginView));
		}

		// Token: 0x0603716B RID: 225643 RVA: 0x00D0EC30 File Offset: 0x00D0CE30
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

		// Token: 0x0603716C RID: 225644 RVA: 0x00D0EC74 File Offset: 0x00D0CE74
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

		// Token: 0x0603716D RID: 225645 RVA: 0x00D0ECB8 File Offset: 0x00D0CEB8
		public UniTask CloseEyeProtectView()
		{
			EyeProtectController.<CloseEyeProtectView>d__6 <CloseEyeProtectView>d__;
			<CloseEyeProtectView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CloseEyeProtectView>d__.<>1__state = -1;
			<CloseEyeProtectView>d__.<>t__builder.Start<EyeProtectController.<CloseEyeProtectView>d__6>(ref <CloseEyeProtectView>d__);
			return <CloseEyeProtectView>d__.<>t__builder.Task;
		}

		// Token: 0x0603716E RID: 225646 RVA: 0x00D0ECF3 File Offset: 0x00D0CEF3
		private EyeProtectViewModel BuildViewModel()
		{
			return new EyeProtectViewModel();
		}

		// Token: 0x0603716F RID: 225647 RVA: 0x00D0ECFA File Offset: 0x00D0CEFA
		public void ApplyEyeProtectSetting()
		{
			GameSettingsUtils.ApplyEyeProtectionMode(GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.EyeProtectionMode, 0, true));
		}

		// Token: 0x06037170 RID: 225648 RVA: 0x00D0ED13 File Offset: 0x00D0CF13
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

		// Token: 0x06037171 RID: 225649 RVA: 0x00D0ED50 File Offset: 0x00D0CF50
		private void HandleBackLoginView()
		{
			this.SwitchFilter(false);
		}

		// Token: 0x06037172 RID: 225650 RVA: 0x00D0ED59 File Offset: 0x00D0CF59
		private void OnRoleDead(int charId)
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.EyeProtectView))
			{
				UiManager.Instance.CloseView(EUiViewName.EyeProtectView, null);
			}
		}

		// Token: 0x17008444 RID: 33860
		// (get) Token: 0x06037173 RID: 225651 RVA: 0x00D0ED7C File Offset: 0x00D0CF7C
		public static EyeProtectController Instance
		{
			get
			{
				return EyeProtectController._Instance;
			}
		}

		// Token: 0x06037174 RID: 225652 RVA: 0x00D0ED83 File Offset: 0x00D0CF83
		public static EyeProtectController GetOrCreateInstance()
		{
			if (EyeProtectController._Instance == null)
			{
				EyeProtectController.CreateInstance();
			}
			return EyeProtectController._Instance;
		}

		// Token: 0x06037175 RID: 225653 RVA: 0x00D0ED97 File Offset: 0x00D0CF97
		public static bool CreateInstance()
		{
			if (EyeProtectController._Instance != null)
			{
				return true;
			}
			EyeProtectController._Instance = new EyeProtectController();
			return true;
		}

		// Token: 0x06037176 RID: 225654 RVA: 0x00D0EDAD File Offset: 0x00D0CFAD
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06037177 RID: 225655 RVA: 0x00D0EDAF File Offset: 0x00D0CFAF
		public static void ResetStaticDefaultValue()
		{
			EyeProtectController._Instance = null;
		}

		// Token: 0x06037178 RID: 225656 RVA: 0x00D0EDB7 File Offset: 0x00D0CFB7
		static EyeProtectController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(EyeProtectController.CreateStaticDefaultValue), new Action(EyeProtectController.ResetStaticDefaultValue));
		}

		// Token: 0x0401D108 RID: 119048
		[Nullable(2)]
		private static EyeProtectController _Instance;
	}
}
