using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.DiffPatch.OH;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Update;
using CSharpScript.Launcher.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.DiffPatch.Procedure
{
	// Token: 0x02000218 RID: 536
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenHarmonyDiffPatchProcedure : MobileDiffPatchProcedure
	{
		// Token: 0x06000DEB RID: 3563 RVA: 0x00053F0C File Offset: 0x0005210C
		public OpenHarmonyDiffPatchProcedure(AppPathMisc pathMisc, HotFixManager viewMgr) : base(pathMisc, viewMgr)
		{
			LauncherLog.Instance.Info("Create OpenHarmony DiffPatchProcedure", default(ReadOnlySpan<ValueTuple<string, object>>));
			NearbyQuitGate.SetPresenter(delegate
			{
				OpenHarmonyDiffPatchProcedure.<<-ctor>b__8_0>d <<-ctor>b__8_0>d;
				<<-ctor>b__8_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<-ctor>b__8_0>d.<>4__this = this;
				<<-ctor>b__8_0>d.<>1__state = -1;
				<<-ctor>b__8_0>d.<>t__builder.Start<OpenHarmonyDiffPatchProcedure.<<-ctor>b__8_0>d>(ref <<-ctor>b__8_0>d);
				return <<-ctor>b__8_0>d.<>t__builder.Task;
			});
			this.NearbyNotify = UOHNearbyNotifyLib.GetNotify();
			this.TransferCb = delegate(int state)
			{
				if (state == 6)
				{
					this.OnNearbyReceiveFinish();
				}
			};
			if (this.NearbyNotify != null)
			{
				this.TransferEvent = this.NearbyNotify.OnTransferEvent;
				this.TransferEvent.Add(this.TransferCb);
				if (this.NearbyNotify.GetLastTransferState() == 6)
				{
					this.OnNearbyReceiveFinish();
				}
			}
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x00053FB0 File Offset: 0x000521B0
		private void OnNearbyReceiveFinish()
		{
			if (this.bFinishHandled)
			{
				return;
			}
			this.bFinishHandled = true;
			LauncherLog.Instance.Info("NotifyNearbyReceiveComplete", default(ReadOnlySpan<ValueTuple<string, object>>));
			NearbyQuitGate.Trip();
			DiffUpdate activeUpdate = this.ActiveUpdate;
			if (activeUpdate == null)
			{
				return;
			}
			activeUpdate.Stop();
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x00053FFC File Offset: 0x000521FC
		[NullableContext(0)]
		public override UniTask<bool> UpdateResource(bool bUseBgDownload, [Nullable(1)] DiffUpdate update, bool bIsLauncher)
		{
			OpenHarmonyDiffPatchProcedure.<UpdateResource>d__10 <UpdateResource>d__;
			<UpdateResource>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<UpdateResource>d__.<>4__this = this;
			<UpdateResource>d__.bUseBgDownload = bUseBgDownload;
			<UpdateResource>d__.update = update;
			<UpdateResource>d__.bIsLauncher = bIsLauncher;
			<UpdateResource>d__.<>1__state = -1;
			<UpdateResource>d__.<>t__builder.Start<OpenHarmonyDiffPatchProcedure.<UpdateResource>d__10>(ref <UpdateResource>d__);
			return <UpdateResource>d__.<>t__builder.Task;
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x00054058 File Offset: 0x00052258
		protected override UniTask OnAfterResolveManifests(DiffUpdate update)
		{
			OpenHarmonyDiffPatchProcedure.<OnAfterResolveManifests>d__11 <OnAfterResolveManifests>d__;
			<OnAfterResolveManifests>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnAfterResolveManifests>d__.<>4__this = this;
			<OnAfterResolveManifests>d__.update = update;
			<OnAfterResolveManifests>d__.<>1__state = -1;
			<OnAfterResolveManifests>d__.<>t__builder.Start<OpenHarmonyDiffPatchProcedure.<OnAfterResolveManifests>d__11>(ref <OnAfterResolveManifests>d__);
			return <OnAfterResolveManifests>d__.<>t__builder.Task;
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x000540A4 File Offset: 0x000522A4
		public void CleanupPresetResources()
		{
			LauncherLog.Instance.Info("OpenHarmony CleanupPresetResources", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (this.NearbyNotify != null)
			{
				FKuroNearbyTransferEvent transferEvent = this.TransferEvent;
				if (transferEvent != null)
				{
					transferEvent.Remove(this.TransferCb);
				}
				this.TransferEvent = null;
				this.NearbyNotify = null;
			}
			this.PresetConsumer.Cleanup();
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x00054104 File Offset: 0x00052304
		public override void PreComplete()
		{
			base.PreComplete();
			RemoteInfo instance = RemoteInfo.Instance;
			VersionItem versionItem;
			if (instance == null)
			{
				versionItem = null;
			}
			else
			{
				RemoteVersionConfig newConfig = instance.NewConfig;
				versionItem = ((newConfig != null) ? newConfig.ResVersions.GetValueOrDefault("resource") : null);
			}
			VersionItem versionItem2 = versionItem;
			if (versionItem2 != null)
			{
				LauncherStorageLib.Instance.SetDeviceSaved<string>(ELauncherStorageDeviceKey.OH_Preset_Version, versionItem2.Version);
			}
		}

		// Token: 0x040008AD RID: 2221
		private const int NearbyStateReceiveFinish = 6;

		// Token: 0x040008AE RID: 2222
		private readonly OHPresetResourceConsumer PresetConsumer = new OHPresetResourceConsumer();

		// Token: 0x040008AF RID: 2223
		private readonly Action<int> TransferCb;

		// Token: 0x040008B0 RID: 2224
		private UOHNearbyNotify NearbyNotify;

		// Token: 0x040008B1 RID: 2225
		private FKuroNearbyTransferEvent TransferEvent;

		// Token: 0x040008B2 RID: 2226
		private DiffUpdate ActiveUpdate;

		// Token: 0x040008B3 RID: 2227
		private bool bActiveIsLauncher;

		// Token: 0x040008B4 RID: 2228
		private bool bFinishHandled;
	}
}
