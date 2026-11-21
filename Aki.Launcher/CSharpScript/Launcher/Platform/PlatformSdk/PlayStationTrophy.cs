using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x020001A0 RID: 416
	public class PlayStationTrophy
	{
		// Token: 0x06000B8D RID: 2957 RVA: 0x0004A918 File Offset: 0x00048B18
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

		// Token: 0x06000B8E RID: 2958 RVA: 0x0004A96C File Offset: 0x00048B6C
		private UniTask InitTrophy()
		{
			PlayStationTrophy.<InitTrophy>d__12 <InitTrophy>d__;
			<InitTrophy>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTrophy>d__.<>4__this = this;
			<InitTrophy>d__.<>1__state = -1;
			<InitTrophy>d__.<>t__builder.Start<PlayStationTrophy.<InitTrophy>d__12>(ref <InitTrophy>d__);
			return <InitTrophy>d__.<>t__builder.Task;
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x0004A9B0 File Offset: 0x00048BB0
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

		// Token: 0x06000B90 RID: 2960 RVA: 0x0004AA04 File Offset: 0x00048C04
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

		// Token: 0x06000B91 RID: 2961 RVA: 0x0004AA50 File Offset: 0x00048C50
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

		// Token: 0x06000B92 RID: 2962 RVA: 0x0004AAE0 File Offset: 0x00048CE0
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

		// Token: 0x06000B93 RID: 2963 RVA: 0x0004AB34 File Offset: 0x00048D34
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

		// Token: 0x06000B94 RID: 2964 RVA: 0x0004AB80 File Offset: 0x00048D80
		private UniTask<int> CreateTrophyContextAsync()
		{
			PlayStationTrophy.<CreateTrophyContextAsync>d__18 <CreateTrophyContextAsync>d__;
			<CreateTrophyContextAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<int>.Create();
			<CreateTrophyContextAsync>d__.<>4__this = this;
			<CreateTrophyContextAsync>d__.<>1__state = -1;
			<CreateTrophyContextAsync>d__.<>t__builder.Start<PlayStationTrophy.<CreateTrophyContextAsync>d__18>(ref <CreateTrophyContextAsync>d__);
			return <CreateTrophyContextAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x0004ABC4 File Offset: 0x00048DC4
		private UniTask<int> CreateTrophyHandleAsync()
		{
			PlayStationTrophy.<CreateTrophyHandleAsync>d__19 <CreateTrophyHandleAsync>d__;
			<CreateTrophyHandleAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<int>.Create();
			<CreateTrophyHandleAsync>d__.<>1__state = -1;
			<CreateTrophyHandleAsync>d__.<>t__builder.Start<PlayStationTrophy.<CreateTrophyHandleAsync>d__19>(ref <CreateTrophyHandleAsync>d__);
			return <CreateTrophyHandleAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x0004AC00 File Offset: 0x00048E00
		private UniTask<bool> DestroyTrophyHandleAsync(int handleId)
		{
			PlayStationTrophy.<DestroyTrophyHandleAsync>d__20 <DestroyTrophyHandleAsync>d__;
			<DestroyTrophyHandleAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<DestroyTrophyHandleAsync>d__.handleId = handleId;
			<DestroyTrophyHandleAsync>d__.<>1__state = -1;
			<DestroyTrophyHandleAsync>d__.<>t__builder.Start<PlayStationTrophy.<DestroyTrophyHandleAsync>d__20>(ref <DestroyTrophyHandleAsync>d__);
			return <DestroyTrophyHandleAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x0004AC44 File Offset: 0x00048E44
		private UniTask<bool> DestroyTrophyContextAsync(int contextId)
		{
			PlayStationTrophy.<DestroyTrophyContextAsync>d__21 <DestroyTrophyContextAsync>d__;
			<DestroyTrophyContextAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<DestroyTrophyContextAsync>d__.contextId = contextId;
			<DestroyTrophyContextAsync>d__.<>1__state = -1;
			<DestroyTrophyContextAsync>d__.<>t__builder.Start<PlayStationTrophy.<DestroyTrophyContextAsync>d__21>(ref <DestroyTrophyContextAsync>d__);
			return <DestroyTrophyContextAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x0004AC87 File Offset: 0x00048E87
		public void Clear()
		{
			this.DestroyTrophyHandleAsync(this.TrophyHandleId).Forget<bool>();
			this.DestroyTrophyContextAsync(this.TrophyContextId).Forget<bool>();
		}

		// Token: 0x04000752 RID: 1874
		private const int DEFAULTLABEL = 0;

		// Token: 0x04000753 RID: 1875
		private const int PROGRESSTYPEPROGRESS = 1;

		// Token: 0x04000754 RID: 1876
		private const int PROGRESSTYPEUNLOCK = 0;

		// Token: 0x04000755 RID: 1877
		[Nullable(2)]
		private UniversalDataSystemManager UniversalDataSystemManager;

		// Token: 0x04000756 RID: 1878
		[Nullable(2)]
		private PlatformSdkNew PlatformSource;

		// Token: 0x04000757 RID: 1879
		private int TrophyContextId;

		// Token: 0x04000758 RID: 1880
		private int TrophyHandleId;

		// Token: 0x04000759 RID: 1881
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ISdkTrophyInfo> CurrentTrophyInfo;

		// Token: 0x0400075A RID: 1882
		[Nullable(1)]
		private readonly Dictionary<int, ISdkTrophyInfo> CurrentTrophyMap = new Dictionary<int, ISdkTrophyInfo>();

		// Token: 0x0400075B RID: 1883
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

		// Token: 0x0400075C RID: 1884
		private bool IsUnlocking;
	}
}
