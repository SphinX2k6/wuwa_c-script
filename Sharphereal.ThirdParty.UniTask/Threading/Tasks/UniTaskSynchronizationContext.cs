using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using UnrealEngine.Utils;

namespace Sharphereal.UniTaskExtensions.Threading.Tasks
{
	// Token: 0x02000009 RID: 9
	[NullableContext(1)]
	[Nullable(0)]
	public class UniTaskSynchronizationContext : SynchronizationContext
	{
		// Token: 0x06000028 RID: 40 RVA: 0x000025A4 File Offset: 0x000007A4
		public override void Send(SendOrPostCallback d, [Nullable(2)] object state)
		{
			d(state);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000025B0 File Offset: 0x000007B0
		public override void Post(SendOrPostCallback d, [Nullable(2)] object state)
		{
			bool flag = false;
			try
			{
				UniTaskSynchronizationContext.gate.Enter(ref flag);
				if (UniTaskSynchronizationContext.dequing)
				{
					if (UniTaskSynchronizationContext.waitingList.Length == UniTaskSynchronizationContext.waitingListCount)
					{
						int num = UniTaskSynchronizationContext.waitingListCount * 2;
						if (num > 2146435071)
						{
							num = 2146435071;
						}
						UniTaskSynchronizationContext.Callback[] destinationArray = new UniTaskSynchronizationContext.Callback[num];
						Array.Copy(UniTaskSynchronizationContext.waitingList, destinationArray, UniTaskSynchronizationContext.waitingListCount);
						UniTaskSynchronizationContext.waitingList = destinationArray;
					}
					UniTaskSynchronizationContext.waitingList[UniTaskSynchronizationContext.waitingListCount] = new UniTaskSynchronizationContext.Callback(d, state);
					UniTaskSynchronizationContext.waitingListCount++;
				}
				else
				{
					if (UniTaskSynchronizationContext.actionList.Length == UniTaskSynchronizationContext.actionListCount)
					{
						int num2 = UniTaskSynchronizationContext.actionListCount * 2;
						if (num2 > 2146435071)
						{
							num2 = 2146435071;
						}
						UniTaskSynchronizationContext.Callback[] destinationArray2 = new UniTaskSynchronizationContext.Callback[num2];
						Array.Copy(UniTaskSynchronizationContext.actionList, destinationArray2, UniTaskSynchronizationContext.actionListCount);
						UniTaskSynchronizationContext.actionList = destinationArray2;
					}
					UniTaskSynchronizationContext.actionList[UniTaskSynchronizationContext.actionListCount] = new UniTaskSynchronizationContext.Callback(d, state);
					UniTaskSynchronizationContext.actionListCount++;
				}
			}
			finally
			{
				if (flag)
				{
					UniTaskSynchronizationContext.gate.Exit(false);
				}
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000026C0 File Offset: 0x000008C0
		public override void OperationStarted()
		{
			Interlocked.Increment(ref UniTaskSynchronizationContext.opCount);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000026CD File Offset: 0x000008CD
		public override void OperationCompleted()
		{
			Interlocked.Decrement(ref UniTaskSynchronizationContext.opCount);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000026DA File Offset: 0x000008DA
		public override SynchronizationContext CreateCopy()
		{
			return this;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000026E0 File Offset: 0x000008E0
		internal static void Run()
		{
			bool flag = false;
			try
			{
				UniTaskSynchronizationContext.gate.Enter(ref flag);
				if (UniTaskSynchronizationContext.actionListCount == 0)
				{
					return;
				}
				UniTaskSynchronizationContext.dequing = true;
			}
			finally
			{
				if (flag)
				{
					UniTaskSynchronizationContext.gate.Exit(false);
				}
			}
			for (int i = 0; i < UniTaskSynchronizationContext.actionListCount; i++)
			{
				UniTaskSynchronizationContext.Callback callback = UniTaskSynchronizationContext.actionList[i];
				UniTaskSynchronizationContext.actionList[i] = default(UniTaskSynchronizationContext.Callback);
				callback.Invoke();
			}
			bool flag2 = false;
			try
			{
				UniTaskSynchronizationContext.gate.Enter(ref flag2);
				UniTaskSynchronizationContext.dequing = false;
				UniTaskSynchronizationContext.Callback[] array = UniTaskSynchronizationContext.actionList;
				UniTaskSynchronizationContext.actionListCount = UniTaskSynchronizationContext.waitingListCount;
				UniTaskSynchronizationContext.actionList = UniTaskSynchronizationContext.waitingList;
				UniTaskSynchronizationContext.waitingListCount = 0;
				UniTaskSynchronizationContext.waitingList = array;
			}
			finally
			{
				if (flag2)
				{
					UniTaskSynchronizationContext.gate.Exit(false);
				}
			}
		}

		// Token: 0x04000013 RID: 19
		private const int MaxArrayLength = 2146435071;

		// Token: 0x04000014 RID: 20
		private const int InitialSize = 16;

		// Token: 0x04000015 RID: 21
		private static SpinLock gate = new SpinLock(false);

		// Token: 0x04000016 RID: 22
		private static bool dequing = false;

		// Token: 0x04000017 RID: 23
		private static int actionListCount = 0;

		// Token: 0x04000018 RID: 24
		private static UniTaskSynchronizationContext.Callback[] actionList = new UniTaskSynchronizationContext.Callback[16];

		// Token: 0x04000019 RID: 25
		private static int waitingListCount = 0;

		// Token: 0x0400001A RID: 26
		private static UniTaskSynchronizationContext.Callback[] waitingList = new UniTaskSynchronizationContext.Callback[16];

		// Token: 0x0400001B RID: 27
		private static int opCount;

		// Token: 0x0200001C RID: 28
		[Nullable(0)]
		[StructLayout(LayoutKind.Auto)]
		private readonly struct Callback
		{
			// Token: 0x060000A6 RID: 166 RVA: 0x00004657 File Offset: 0x00002857
			public Callback(SendOrPostCallback callback, object state)
			{
				this.callback = callback;
				this.state = state;
			}

			// Token: 0x060000A7 RID: 167 RVA: 0x00004668 File Offset: 0x00002868
			public void Invoke()
			{
				try
				{
					this.callback(this.state);
				}
				catch (Exception ex)
				{
					UnrealLogger.Error(ex.ToString());
				}
			}

			// Token: 0x0400007F RID: 127
			private readonly SendOrPostCallback callback;

			// Token: 0x04000080 RID: 128
			private readonly object state;
		}
	}
}
