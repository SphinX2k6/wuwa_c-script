using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Launcher.Util
{
	// Token: 0x02000076 RID: 118
	public class NearbyQuitGate : IStaticVariableResetter
	{
		// Token: 0x06000322 RID: 802 RVA: 0x00010FED File Offset: 0x0000F1ED
		static NearbyQuitGate()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(NearbyQuitGate.CreateStaticDefaultValue), new Action(NearbyQuitGate.ResetStaticDefaultValue));
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0001100C File Offset: 0x0000F20C
		public static void Trip()
		{
			if (NearbyQuitGate.bPending)
			{
				return;
			}
			NearbyQuitGate.bPending = true;
			LauncherLog.Instance.Info("[NearbyQuitGate] tripped.", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0001103F File Offset: 0x0000F23F
		public static bool IsPending()
		{
			return NearbyQuitGate.bPending;
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00011046 File Offset: 0x0000F246
		[NullableContext(1)]
		public static void SetPresenter(Func<UniTask> presenter)
		{
			NearbyQuitGate.Presenter = presenter;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00011050 File Offset: 0x0000F250
		public static UniTask ParkIfPending()
		{
			NearbyQuitGate.<ParkIfPending>d__7 <ParkIfPending>d__;
			<ParkIfPending>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ParkIfPending>d__.<>1__state = -1;
			<ParkIfPending>d__.<>t__builder.Start<NearbyQuitGate.<ParkIfPending>d__7>(ref <ParkIfPending>d__);
			return <ParkIfPending>d__.<>t__builder.Task;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0001108B File Offset: 0x0000F28B
		public static void CreateStaticDefaultValue()
		{
			NearbyQuitGate.bPending = false;
			NearbyQuitGate.bPresented = false;
			NearbyQuitGate.Presenter = null;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0001109F File Offset: 0x0000F29F
		public static void ResetStaticDefaultValue()
		{
			NearbyQuitGate.bPending = false;
			NearbyQuitGate.bPresented = false;
			NearbyQuitGate.Presenter = null;
		}

		// Token: 0x04000246 RID: 582
		private static bool bPending;

		// Token: 0x04000247 RID: 583
		private static bool bPresented;

		// Token: 0x04000248 RID: 584
		[Nullable(2)]
		private static Func<UniTask> Presenter;
	}
}
