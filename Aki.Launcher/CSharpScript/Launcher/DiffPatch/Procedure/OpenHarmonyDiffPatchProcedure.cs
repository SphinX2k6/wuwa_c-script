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
	// Token: 0x0200021D RID: 541
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenHarmonyDiffPatchProcedure : MobileDiffPatchProcedure
	{
		// Token: 0x06000E2C RID: 3628 RVA: 0x00056A00 File Offset: 0x00054C00
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

		// Token: 0x06000E2D RID: 3629 RVA: 0x00056AA4 File Offset: 0x00054CA4
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

		// Token: 0x06000E2E RID: 3630 RVA: 0x00056AF0 File Offset: 0x00054CF0
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

		// Token: 0x06000E2F RID: 3631 RVA: 0x00056B4C File Offset: 0x00054D4C
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

		// Token: 0x06000E30 RID: 3632 RVA: 0x00056B98 File Offset: 0x00054D98
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

		// Token: 0x06000E31 RID: 3633 RVA: 0x00056BF8 File Offset: 0x00054DF8
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

		// Token: 0x040008EE RID: 2286
		private const int NearbyStateReceiveFinish = 6;

		// Token: 0x040008EF RID: 2287
		private readonly OHPresetResourceConsumer PresetConsumer = new OHPresetResourceConsumer();

		// Token: 0x040008F0 RID: 2288
		private readonly Action<int> TransferCb;

		// Token: 0x040008F1 RID: 2289
		private UOHNearbyNotify NearbyNotify;

		// Token: 0x040008F2 RID: 2290
		private FKuroNearbyTransferEvent TransferEvent;

		// Token: 0x040008F3 RID: 2291
		private DiffUpdate ActiveUpdate;

		// Token: 0x040008F4 RID: 2292
		private bool bActiveIsLauncher;

		// Token: 0x040008F5 RID: 2293
		private bool bFinishHandled;
	}
}
