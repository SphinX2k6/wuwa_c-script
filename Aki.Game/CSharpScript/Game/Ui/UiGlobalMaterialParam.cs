using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035FD RID: 13821
	[NullableContext(1)]
	[Nullable(0)]
	public class UiGlobalMaterialParam : Singleton
	{
		// Token: 0x0602330A RID: 144138 RVA: 0x009FF6C8 File Offset: 0x009FD8C8
		public UniTask InitAsync()
		{
			UiGlobalMaterialParam.<InitAsync>d__2 <InitAsync>d__;
			<InitAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitAsync>d__.<>4__this = this;
			<InitAsync>d__.<>1__state = -1;
			<InitAsync>d__.<>t__builder.Start<UiGlobalMaterialParam.<InitAsync>d__2>(ref <InitAsync>d__);
			return <InitAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602330B RID: 144139 RVA: 0x009FF70B File Offset: 0x009FD90B
		public void Refresh()
		{
			this.ResetLguiWidth();
		}

		// Token: 0x0602330C RID: 144140 RVA: 0x009FF713 File Offset: 0x009FD913
		public void Clear()
		{
			Application.Instance.RemoveApplicationHandler(EApplicationLifetimeDelegate.ApplicationHasReactivatedDelegate, new Action(this.AppEnterForeground));
		}

		// Token: 0x0602330D RID: 144141 RVA: 0x009FF72C File Offset: 0x009FD92C
		private void AppEnterForeground()
		{
			this.ResetLguiWidth();
		}

		// Token: 0x0602330E RID: 144142 RVA: 0x009FF734 File Offset: 0x009FD934
		private void ResetLguiWidth()
		{
			UMaterialParameterCollection collection = new UMaterialParameterCollection();
			BP_CharacterRenderingFunctionLibrary_C.StaticClass();
			BP_CharacterRenderingFunctionLibrary_C.GetLGUIMPC(UiLayer.Instance.UiRoot, ref collection);
			UKismetMaterialLibrary.SetScalarParameterValue(UiLayer.Instance.UiRoot.GetWorld(), collection, this.LguiWidth, UiLayer.Instance.UiRootItem.GetWidth());
			UKismetMaterialLibrary.SetScalarParameterValue(UiLayer.Instance.UiRoot.GetWorld(), collection, this.LguiRenderOnScreen, 1f);
		}

		// Token: 0x17004931 RID: 18737
		// (get) Token: 0x0602330F RID: 144143 RVA: 0x009FF7A8 File Offset: 0x009FD9A8
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

		// Token: 0x06023310 RID: 144144 RVA: 0x009FF7CB File Offset: 0x009FD9CB
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06023311 RID: 144145 RVA: 0x009FF7CD File Offset: 0x009FD9CD
		public static void ResetStaticDefaultValue()
		{
			UiGlobalMaterialParam instance = UiGlobalMaterialParam._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			UiGlobalMaterialParam._instance = null;
		}

		// Token: 0x06023312 RID: 144146 RVA: 0x009FF7E6 File Offset: 0x009FD9E6
		static UiGlobalMaterialParam()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiGlobalMaterialParam.CreateStaticDefaultValue), new Action(UiGlobalMaterialParam.ResetStaticDefaultValue));
		}

		// Token: 0x04013DB4 RID: 81332
		public FName LguiWidth = new FName("LGUIWidth");

		// Token: 0x04013DB5 RID: 81333
		public FName LguiRenderOnScreen = new FName("RenderOnScreenWPO");

		// Token: 0x04013DB6 RID: 81334
		[Nullable(2)]
		private static UiGlobalMaterialParam _instance;
	}
}
