using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x0200019C RID: 412
	public class PlayStationTrophy
	{
		// Token: 0x06000B56 RID: 2902 RVA: 0x00048128 File Offset: 0x00046328
		[NullableContext(1)]
		public UniTask Init(UniversalDataSystemManager uds, PlatformSdkNew sdkSource)
		{
			PlayStationTrophy.<Init>d__11 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.uds = uds;
			<Init>d__.sdkSource = sdkSource;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<PlayStationTrophy.<Init>d__11>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x0004817C File Offset: 0x0004637C
		private UniTask InitTrophy()
		{
			PlayStationTrophy.<InitTrophy>d__12 <InitTrophy>d__;
			<InitTrophy>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTrophy>d__.<>4__this = this;
			<InitTrophy>d__.<>1__state = -1;
			<InitTrophy>d__.<>t__builder.Start<PlayStationTrophy.<InitTrophy>d__12>(ref <InitTrophy>d__);
			return <InitTrophy>d__.<>t__builder.Task;
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x000481C0 File Offset: 0x000463C0
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public UniTask<List<ISdkTrophyInfo>> GetSdkTrophyInfo(int offset = 0, int length = 0)
		{
			PlayStationTrophy.<GetSdkTrophyInfo>d__13 <GetSdkTrophyInfo>d__;
			<GetSdkTrophyInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder<List<ISdkTrophyInfo>>.Create();
			<GetSdkTrophyInfo>d__.<>4__this = this;
			<GetSdkTrophyInfo>d__.offset = offset;
			<GetSdkTrophyInfo>d__.length = length;
			<GetSdkTrophyInfo>d__.<>1__state = -1;
			<GetSdkTrophyInfo>d__.<>t__builder.Start<PlayStationTrophy.<GetSdkTrophyInfo>d__13>(ref <GetSdkTrophyInfo>d__);
			return <GetSdkTrophyInfo>d__.<>t__builder.Task;
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x00048214 File Offset: 0x00046414
		public UniTask<bool> UnlockSdkTrophy(int trophyId)
		{
			PlayStationTrophy.<UnlockSdkTrophy>d__14 <UnlockSdkTrophy>d__;
			<UnlockSdkTrophy>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<UnlockSdkTrophy>d__.<>4__this = this;
			<UnlockSdkTrophy>d__.trophyId = trophyId;
			<UnlockSdkTrophy>d__.<>1__state = -1;
			<UnlockSdkTrophy>d__.<>t__builder.Start<PlayStationTrophy.<UnlockSdkTrophy>d__14>(ref <UnlockSdkTrophy>d__);
			return <UnlockSdkTrophy>d__.<>t__builder.Task;
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x00048260 File Offset: 0x00046460
		private void ProcessUnlockQueue()
		{
			PlayStationTrophy.<>c__DisplayClass15_0 CS$<>8__locals1 = new PlayStationTrophy.<>c__DisplayClass15_0();
			CS$<>8__locals1.<>4__this = this;
			if (this.UnlockQueue.Count == 0)
			{
				this.IsUnlocking = false;
				return;
			}
			this.IsUnlocking = true;
			CS$<>8__locals1.data = this.UnlockQueue[0];
			this.UnlockQueue.RemoveAt(0);
			int context = this.UniversalDataSystemManager.GetContext();
			int handle = this.UniversalDataSystemManager.GetHandle();
			int item = CS$<>8__locals1.data.Item1;
			FPlayStationUnlockTrophyCallBack fplayStationUnlockTrophyCallBack = DelegateUtils.ToManualReleaseDelegate<FPlayStationUnlockTrophyCallBack>(new Action<int>(CS$<>8__locals1.<ProcessUnlockQueue>g__OnUnlockTrophy|0));
			UKuroStaticPS5Library.UnlockTrophyWithContextIdAndHandleIdAsync(context, handle, item, fplayStationUnlockTrophyCallBack);
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x000482F0 File Offset: 0x000464F0
		public UniTask<bool> UpdateSdkTrophyProgress(int trophyId, int progress)
		{
			PlayStationTrophy.<UpdateSdkTrophyProgress>d__16 <UpdateSdkTrophyProgress>d__;
			<UpdateSdkTrophyProgress>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<UpdateSdkTrophyProgress>d__.<>4__this = this;
			<UpdateSdkTrophyProgress>d__.trophyId = trophyId;
			<UpdateSdkTrophyProgress>d__.progress = progress;
			<UpdateSdkTrophyProgress>d__.<>1__state = -1;
			<UpdateSdkTrophyProgress>d__.<>t__builder.Start<PlayStationTrophy.<UpdateSdkTrophyProgress>d__16>(ref <UpdateSdkTrophyProgress>d__);
			return <UpdateSdkTrophyProgress>d__.<>t__builder.Task;
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x00048344 File Offset: 0x00046544
		private UniTask<int> RegistTrophyContextAsync(int contextId, int handleId)
		{
			PlayStationTrophy.<RegistTrophyContextAsync>d__17 <RegistTrophyContextAsync>d__;
			<RegistTrophyContextAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<int>.Create();
			<RegistTrophyContextAsync>d__.contextId = contextId;
			<RegistTrophyContextAsync>d__.handleId = handleId;
			<RegistTrophyContextAsync>d__.<>1__state = -1;
			<RegistTrophyContextAsync>d__.<>t__builder.Start<PlayStationTrophy.<RegistTrophyContextAsync>d__17>(ref <RegistTrophyContextAsync>d__);
			return <RegistTrophyContextAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x00048390 File Offset: 0x00046590
		private UniTask<int> CreateTrophyContextAsync()
		{
			PlayStationTrophy.<CreateTrophyContextAsync>d__18 <CreateTrophyContextAsync>d__;
			<CreateTrophyContextAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<int>.Create();
			<CreateTrophyContextAsync>d__.<>4__this = this;
			<CreateTrophyContextAsync>d__.<>1__state = -1;
			<CreateTrophyContextAsync>d__.<>t__builder.Start<PlayStationTrophy.<CreateTrophyContextAsync>d__18>(ref <CreateTrophyContextAsync>d__);
			return <CreateTrophyContextAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x000483D4 File Offset: 0x000465D4
		private UniTask<int> CreateTrophyHandleAsync()
		{
			PlayStationTrophy.<CreateTrophyHandleAsync>d__19 <CreateTrophyHandleAsync>d__;
			<CreateTrophyHandleAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<int>.Create();
			<CreateTrophyHandleAsync>d__.<>1__state = -1;
			<CreateTrophyHandleAsync>d__.<>t__builder.Start<PlayStationTrophy.<CreateTrophyHandleAsync>d__19>(ref <CreateTrophyHandleAsync>d__);
			return <CreateTrophyHandleAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x00048410 File Offset: 0x00046610
		private UniTask<bool> DestroyTrophyHandleAsync(int handleId)
		{
			PlayStationTrophy.<DestroyTrophyHandleAsync>d__20 <DestroyTrophyHandleAsync>d__;
			<DestroyTrophyHandleAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<DestroyTrophyHandleAsync>d__.handleId = handleId;
			<DestroyTrophyHandleAsync>d__.<>1__state = -1;
			<DestroyTrophyHandleAsync>d__.<>t__builder.Start<PlayStationTrophy.<DestroyTrophyHandleAsync>d__20>(ref <DestroyTrophyHandleAsync>d__);
			return <DestroyTrophyHandleAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x00048454 File Offset: 0x00046654
		private UniTask<bool> DestroyTrophyContextAsync(int contextId)
		{
			PlayStationTrophy.<DestroyTrophyContextAsync>d__21 <DestroyTrophyContextAsync>d__;
			<DestroyTrophyContextAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<DestroyTrophyContextAsync>d__.contextId = contextId;
			<DestroyTrophyContextAsync>d__.<>1__state = -1;
			<DestroyTrophyContextAsync>d__.<>t__builder.Start<PlayStationTrophy.<DestroyTrophyContextAsync>d__21>(ref <DestroyTrophyContextAsync>d__);
			return <DestroyTrophyContextAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x00048497 File Offset: 0x00046697
		public void Clear()
		{
			this.DestroyTrophyHandleAsync(this.TrophyHandleId).Forget<bool>();
			this.DestroyTrophyContextAsync(this.TrophyContextId).Forget<bool>();
		}

		// Token: 0x04000716 RID: 1814
		private const int DEFAULTLABEL = 0;

		// Token: 0x04000717 RID: 1815
		private const int PROGRESSTYPEPROGRESS = 1;

		// Token: 0x04000718 RID: 1816
		private const int PROGRESSTYPEUNLOCK = 0;

		// Token: 0x04000719 RID: 1817
		[Nullable(2)]
		private UniversalDataSystemManager UniversalDataSystemManager;

		// Token: 0x0400071A RID: 1818
		[Nullable(2)]
		private PlatformSdkNew PlatformSource;

		// Token: 0x0400071B RID: 1819
		private int TrophyContextId;

		// Token: 0x0400071C RID: 1820
		private int TrophyHandleId;

		// Token: 0x0400071D RID: 1821
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ISdkTrophyInfo> CurrentTrophyInfo;

		// Token: 0x0400071E RID: 1822
		[Nullable(1)]
		private readonly Dictionary<int, ISdkTrophyInfo> CurrentTrophyMap = new Dictionary<int, ISdkTrophyInfo>();

		// Token: 0x0400071F RID: 1823
		[TupleElementNames(new string[]
		{
			"TrophyId",
			"Task"
		})]
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		private readonly List<ValueTuple<int, Action<bool>>> UnlockQueue = new List<ValueTuple<int, Action<bool>>>();

		// Token: 0x04000720 RID: 1824
		private bool IsUnlocking;
	}
}
