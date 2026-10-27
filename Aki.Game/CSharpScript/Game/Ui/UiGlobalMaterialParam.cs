using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046CD RID: 18125
	[NullableContext(1)]
	[Nullable(0)]
	public class UiGlobalMaterialParam : Singleton
	{
		// Token: 0x0602EBD0 RID: 191440 RVA: 0x00AD13F0 File Offset: 0x00ACF5F0
		public UniTask InitAsync()
		{
			UiGlobalMaterialParam.<InitAsync>d__2 <InitAsync>d__;
			<InitAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitAsync>d__.<>4__this = this;
			<InitAsync>d__.<>1__state = -1;
			<InitAsync>d__.<>t__builder.Start<UiGlobalMaterialParam.<InitAsync>d__2>(ref <InitAsync>d__);
			return <InitAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EBD1 RID: 191441 RVA: 0x00AD1433 File Offset: 0x00ACF633
		public void Refresh()
		{
			this.ResetLguiWidth();
		}

		// Token: 0x0602EBD2 RID: 191442 RVA: 0x00AD143B File Offset: 0x00ACF63B
		public void Clear()
		{
			Application.Instance.RemoveApplicationHandler(EApplicationLifetimeDelegate.ApplicationHasReactivatedDelegate, new Action(this.AppEnterForeground));
		}

		// Token: 0x0602EBD3 RID: 191443 RVA: 0x00AD1454 File Offset: 0x00ACF654
		private void AppEnterForeground()
		{
			this.ResetLguiWidth();
		}

		// Token: 0x0602EBD4 RID: 191444 RVA: 0x00AD145C File Offset: 0x00ACF65C
		private void ResetLguiWidth()
		{
			UMaterialParameterCollection collection = new UMaterialParameterCollection();
			BP_CharacterRenderingFunctionLibrary_C.StaticClass();
			BP_CharacterRenderingFunctionLibrary_C.GetLGUIMPC(UiLayer.Instance.UiRoot, ref collection);
			UKismetMaterialLibrary.SetScalarParameterValue(UiLayer.Instance.UiRoot.GetWorld(), collection, this.LguiWidth, UiLayer.Instance.UiRootItem.GetWidth());
			UKismetMaterialLibrary.SetScalarParameterValue(UiLayer.Instance.UiRoot.GetWorld(), collection, this.LguiRenderOnScreen, 1f);
		}

		// Token: 0x17007676 RID: 30326
		// (get) Token: 0x0602EBD5 RID: 191445 RVA: 0x00AD14D0 File Offset: 0x00ACF6D0
		public static UiGlobalMaterialParam Instance
		{
			get
			{
				if (UiGlobalMaterialParam._instance == null)
				{
					UiGlobalMaterialParam._instance = new UiGlobalMaterialParam();
					UiGlobalMaterialParam._instance.OnInit();
				}
				return UiGlobalMaterialParam._instance;
			}
		}

		// Token: 0x0602EBD6 RID: 191446 RVA: 0x00AD14F3 File Offset: 0x00ACF6F3
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602EBD7 RID: 191447 RVA: 0x00AD14F5 File Offset: 0x00ACF6F5
		public static void ResetStaticDefaultValue()
		{
			UiGlobalMaterialParam instance = UiGlobalMaterialParam._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			UiGlobalMaterialParam._instance = null;
		}

		// Token: 0x0602EBD8 RID: 191448 RVA: 0x00AD150E File Offset: 0x00ACF70E
		static UiGlobalMaterialParam()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiGlobalMaterialParam.CreateStaticDefaultValue), new Action(UiGlobalMaterialParam.ResetStaticDefaultValue));
		}

		// Token: 0x04019716 RID: 104214
		public FName LguiWidth = new FName("LGUIWidth");

		// Token: 0x04019717 RID: 104215
		public FName LguiRenderOnScreen = new FName("RenderOnScreenWPO");

		// Token: 0x04019718 RID: 104216
		[Nullable(2)]
		private static UiGlobalMaterialParam _instance;
	}
}
