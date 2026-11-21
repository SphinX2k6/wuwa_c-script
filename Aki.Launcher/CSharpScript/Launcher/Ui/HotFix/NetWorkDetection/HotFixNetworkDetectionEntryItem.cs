using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.NetworkDetection;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.HotFix.NetWorkDetection
{
	// Token: 0x020000FB RID: 251
	public class HotFixNetworkDetectionEntryItem : LaunchComponentsAction, IHotFixLayoutItem
	{
		// Token: 0x06000849 RID: 2121 RVA: 0x0003F329 File Offset: 0x0003D529
		[NullableContext(1)]
		public void SetRootActor(AActor actor)
		{
			base.SetRootActorLaunchComponentsAction(actor);
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x0003F332 File Offset: 0x0003D532
		protected override void OnShow()
		{
			this.UpdateView();
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x0003F33C File Offset: 0x0003D53C
		private void UpdateView()
		{
			INetworkDetectionEntry entryData = this.Data.EntryData;
			INetworkDetectionResult result = this.Data.Result;
			HotFixManager.SetLocalText(base.GetText(0), entryData.NameLocalKey, Array.Empty<string>());
			base.GetTexture(1).SetUIActive(result != null && (result == null || !result.Success));
			base.GetTexture(2).SetUIActive(result != null && result != null && result.Success);
			base.GetTexture(3).SetUIActive(this.Data.Proceed);
			bool flag = result != null && !result.Success && result != null && result.Code != null;
			if (flag)
			{
				string genericErrorCodeTips = LauncherNetworkDetectionModel.GetGenericErrorCodeTips(entryData.Type, result.Code.Value, result);
				base.GetText(5).SetText(genericErrorCodeTips, true);
				this.Data.ErrorCodeText = genericErrorCodeTips;
			}
			base.GetItem(4).SetUIActive(flag);
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x0003F430 File Offset: 0x0003D630
		[NullableContext(1)]
		public void Refresh(IHotFixLayoutData data)
		{
			this.Data = (IHotFixNetworkDetectionLayoutItemData)data;
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x0003F440 File Offset: 0x0003D640
		protected override void OnBeforeDestroy()
		{
			if (this.Data.EntryData.Type == ENetworkDetectionType.UdpPort)
			{
				if (LauncherNetworkDetectionController.Instance.GetGateWayUdpCheckState())
				{
					UKuroNetworkDetection.AbortGatewayUdpReachable();
					return;
				}
				INetworkDetectionResult result = this.Data.Result;
				UKuroNetworkDetection.DetectionFinish(result != null && result.Success);
			}
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x0003F490 File Offset: 0x0003D690
		public UniTask Proceed()
		{
			HotFixNetworkDetectionEntryItem.<Proceed>d__8 <Proceed>d__;
			<Proceed>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Proceed>d__.<>4__this = this;
			<Proceed>d__.<>1__state = -1;
			<Proceed>d__.<>t__builder.Start<HotFixNetworkDetectionEntryItem.<Proceed>d__8>(ref <Proceed>d__);
			return <Proceed>d__.<>t__builder.Task;
		}

		// Token: 0x040004DA RID: 1242
		[Nullable(2)]
		public THotFixLayoutItemClickCallBack ItemClickCallBack;

		// Token: 0x040004DB RID: 1243
		[Nullable(2)]
		private IHotFixNetworkDetectionLayoutItemData Data;

		// Token: 0x0200039B RID: 923
		private static class EComponents
		{
			// Token: 0x040012C2 RID: 4802
			public const int TxtName = 0;

			// Token: 0x040012C3 RID: 4803
			public const int ErrorIcon = 1;

			// Token: 0x040012C4 RID: 4804
			public const int CorrectIcon = 2;

			// Token: 0x040012C5 RID: 4805
			public const int ProceedIcon = 3;

			// Token: 0x040012C6 RID: 4806
			public const int PnlError = 4;

			// Token: 0x040012C7 RID: 4807
			public const int TxtError = 5;
		}
	}
}
