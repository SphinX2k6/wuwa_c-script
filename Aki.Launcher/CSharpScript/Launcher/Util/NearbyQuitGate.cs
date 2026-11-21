using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Launcher.Util
{
	// Token: 0x02000079 RID: 121
	public class NearbyQuitGate : IStaticVariableResetter
	{
		// Token: 0x06000332 RID: 818 RVA: 0x00011E6D File Offset: 0x0001006D
		static NearbyQuitGate()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(NearbyQuitGate.CreateStaticDefaultValue), new Action(NearbyQuitGate.ResetStaticDefaultValue));
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00011E8C File Offset: 0x0001008C
		public static void Trip()
		{
			if (NearbyQuitGate.bPending)
			{
				return;
			}
			NearbyQuitGate.bPending = true;
			LauncherLog.Instance.Info("[NearbyQuitGate] tripped.", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00011EBF File Offset: 0x000100BF
		public static bool IsPending()
		{
			return NearbyQuitGate.bPending;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00011EC6 File Offset: 0x000100C6
		[NullableContext(1)]
		public static void SetPresenter(Func<UniTask> presenter)
		{
			NearbyQuitGate.Presenter = presenter;
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00011ED0 File Offset: 0x000100D0
		public static UniTask ParkIfPending()
		{
			NearbyQuitGate.<ParkIfPending>d__7 <ParkIfPending>d__;
			<ParkIfPending>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ParkIfPending>d__.<>1__state = -1;
			<ParkIfPending>d__.<>t__builder.Start<NearbyQuitGate.<ParkIfPending>d__7>(ref <ParkIfPending>d__);
			return <ParkIfPending>d__.<>t__builder.Task;
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00011F0B File Offset: 0x0001010B
		public static void CreateStaticDefaultValue()
		{
			NearbyQuitGate.bPending = false;
			NearbyQuitGate.bPresented = false;
			NearbyQuitGate.Presenter = null;
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00011F1F File Offset: 0x0001011F
		public static void ResetStaticDefaultValue()
		{
			NearbyQuitGate.bPending = false;
			NearbyQuitGate.bPresented = false;
			NearbyQuitGate.Presenter = null;
		}

		// Token: 0x04000272 RID: 626
		private static bool bPending;

		// Token: 0x04000273 RID: 627
		private static bool bPresented;

		// Token: 0x04000274 RID: 628
		[Nullable(2)]
		private static Func<UniTask> Presenter;
	}
}
