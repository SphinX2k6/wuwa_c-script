using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Ui.HotFix.NetWorkDetection;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000EB RID: 235
	public class HotFixToolWindowView : LaunchComponentsAction
	{
		// Token: 0x060007AA RID: 1962 RVA: 0x0003D9DC File Offset: 0x0003BBDC
		[NullableContext(1)]
		public UniTask LoadAsync(UObject worldContext)
		{
			HotFixToolWindowView.<LoadAsync>d__1 <LoadAsync>d__;
			<LoadAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadAsync>d__.<>4__this = this;
			<LoadAsync>d__.worldContext = worldContext;
			<LoadAsync>d__.<>1__state = -1;
			<LoadAsync>d__.<>t__builder.Start<HotFixToolWindowView.<LoadAsync>d__1>(ref <LoadAsync>d__);
			return <LoadAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x0003DA27 File Offset: 0x0003BC27
		private void SetRepairItemActive(bool value)
		{
			base.GetElement<HotFixPopupRepairView>(101).SetActive(value);
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x0003DA37 File Offset: 0x0003BC37
		private void SetNetworkDetectItemActive(bool value)
		{
			base.GetElement<HotFixNetworkDetectionView>(102).SetActive(value);
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x0003DA48 File Offset: 0x0003BC48
		protected override void OnStart()
		{
			base.AttachElement<HotFixButtonItem>(3).BindClickCallback(new Action(this.OnCleanBtnClick));
			HotFixButtonItem hotFixButtonItem = base.AttachElement<HotFixButtonItem>(4);
			hotFixButtonItem.BindClickCallback(new Action(this.OnLogBtnClick));
			hotFixButtonItem.SetActive(false);
			base.AttachElement<HotFixButtonItem>(5).BindClickCallback(new Action(this.OnNetBtnClick));
			base.GetButton(1).OnClickCallBack.Bind(new Action(this.OnBackBtnClick));
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x0003DAC1 File Offset: 0x0003BCC1
		private void OnCleanBtnClick()
		{
			this.SetRepairItemActive(true);
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x0003DACA File Offset: 0x0003BCCA
		private void OnLogBtnClick()
		{
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x0003DACC File Offset: 0x0003BCCC
		private void OnNetBtnClick()
		{
			this.SetNetworkDetectItemActive(true);
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x0003DAD5 File Offset: 0x0003BCD5
		private void OnBackBtnClick()
		{
			base.SetActive(false);
		}

		// Token: 0x0200038B RID: 907
		private static class EComponents
		{
			// Token: 0x0400125B RID: 4699
			public const int BtnMask = 0;

			// Token: 0x0400125C RID: 4700
			public const int BtnBack = 1;

			// Token: 0x0400125D RID: 4701
			public const int TxtTile = 2;

			// Token: 0x0400125E RID: 4702
			public const int BtnClean = 3;

			// Token: 0x0400125F RID: 4703
			public const int BtnLog = 4;

			// Token: 0x04001260 RID: 4704
			public const int BtnNet = 5;

			// Token: 0x04001261 RID: 4705
			public const int RepairPop = 101;

			// Token: 0x04001262 RID: 4706
			public const int NetworkDetectPop = 102;
		}
	}
}
