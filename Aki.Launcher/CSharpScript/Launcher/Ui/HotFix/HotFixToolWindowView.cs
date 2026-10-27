using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Ui.HotFix.NetWorkDetection;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000E8 RID: 232
	public class HotFixToolWindowView : LaunchComponentsAction
	{
		// Token: 0x0600078D RID: 1933 RVA: 0x0003BDF0 File Offset: 0x00039FF0
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

		// Token: 0x0600078E RID: 1934 RVA: 0x0003BE3B File Offset: 0x0003A03B
		private void SetRepairItemActive(bool value)
		{
			base.GetElement<HotFixPopupRepairView>(101).SetActive(value);
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x0003BE4B File Offset: 0x0003A04B
		private void SetNetworkDetectItemActive(bool value)
		{
			base.GetElement<HotFixNetworkDetectionView>(102).SetActive(value);
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x0003BE5C File Offset: 0x0003A05C
		protected override void OnStart()
		{
			base.AttachElement<HotFixButtonItem>(3).BindClickCallback(new Action(this.OnCleanBtnClick));
			HotFixButtonItem hotFixButtonItem = base.AttachElement<HotFixButtonItem>(4);
			hotFixButtonItem.BindClickCallback(new Action(this.OnLogBtnClick));
			hotFixButtonItem.SetActive(false);
			base.AttachElement<HotFixButtonItem>(5).BindClickCallback(new Action(this.OnNetBtnClick));
			base.GetButton(1).OnClickCallBack.Bind(new Action(this.OnBackBtnClick));
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x0003BED5 File Offset: 0x0003A0D5
		private void OnCleanBtnClick()
		{
			this.SetRepairItemActive(true);
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x0003BEDE File Offset: 0x0003A0DE
		private void OnLogBtnClick()
		{
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x0003BEE0 File Offset: 0x0003A0E0
		private void OnNetBtnClick()
		{
			this.SetNetworkDetectItemActive(true);
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x0003BEE9 File Offset: 0x0003A0E9
		private void OnBackBtnClick()
		{
			base.SetActive(false);
		}

		// Token: 0x02000380 RID: 896
		private static class EComponents
		{
			// Token: 0x040011F6 RID: 4598
			public const int BtnMask = 0;

			// Token: 0x040011F7 RID: 4599
			public const int BtnBack = 1;

			// Token: 0x040011F8 RID: 4600
			public const int TxtTile = 2;

			// Token: 0x040011F9 RID: 4601
			public const int BtnClean = 3;

			// Token: 0x040011FA RID: 4602
			public const int BtnLog = 4;

			// Token: 0x040011FB RID: 4603
			public const int BtnNet = 5;

			// Token: 0x040011FC RID: 4604
			public const int RepairPop = 101;

			// Token: 0x040011FD RID: 4605
			public const int NetworkDetectPop = 102;
		}
	}
}
