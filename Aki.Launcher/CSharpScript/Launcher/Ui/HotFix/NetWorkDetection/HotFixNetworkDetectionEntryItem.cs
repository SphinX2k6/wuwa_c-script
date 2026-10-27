using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.NetworkDetection;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.HotFix.NetWorkDetection
{
	// Token: 0x020000F7 RID: 247
	public class HotFixNetworkDetectionEntryItem : LaunchComponentsAction, IHotFixLayoutItem
	{
		// Token: 0x06000815 RID: 2069 RVA: 0x0003CF89 File Offset: 0x0003B189
		[NullableContext(1)]
		public void SetRootActor(AActor actor)
		{
			base.SetRootActorLaunchComponentsAction(actor);
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x0003CF92 File Offset: 0x0003B192
		protected override void OnShow()
		{
			this.UpdateView();
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x0003CF9C File Offset: 0x0003B19C
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

		// Token: 0x06000818 RID: 2072 RVA: 0x0003D090 File Offset: 0x0003B290
		[NullableContext(1)]
		public void Refresh(IHotFixLayoutData data)
		{
			this.Data = (IHotFixNetworkDetectionLayoutItemData)data;
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x0003D0A0 File Offset: 0x0003B2A0
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

		// Token: 0x0600081A RID: 2074 RVA: 0x0003D0F0 File Offset: 0x0003B2F0
		public UniTask Proceed()
		{
			HotFixNetworkDetectionEntryItem.<Proceed>d__8 <Proceed>d__;
			<Proceed>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Proceed>d__.<>4__this = this;
			<Proceed>d__.<>1__state = -1;
			<Proceed>d__.<>t__builder.Start<HotFixNetworkDetectionEntryItem.<Proceed>d__8>(ref <Proceed>d__);
			return <Proceed>d__.<>t__builder.Task;
		}

		// Token: 0x0400049F RID: 1183
		[Nullable(2)]
		public THotFixLayoutItemClickCallBack ItemClickCallBack;

		// Token: 0x040004A0 RID: 1184
		[Nullable(2)]
		private IHotFixNetworkDetectionLayoutItemData Data;

		// Token: 0x0200038E RID: 910
		private static class EComponents
		{
			// Token: 0x0400124C RID: 4684
			public const int TxtName = 0;

			// Token: 0x0400124D RID: 4685
			public const int ErrorIcon = 1;

			// Token: 0x0400124E RID: 4686
			public const int CorrectIcon = 2;

			// Token: 0x0400124F RID: 4687
			public const int ProceedIcon = 3;

			// Token: 0x04001250 RID: 4688
			public const int PnlError = 4;

			// Token: 0x04001251 RID: 4689
			public const int TxtError = 5;
		}
	}
}
