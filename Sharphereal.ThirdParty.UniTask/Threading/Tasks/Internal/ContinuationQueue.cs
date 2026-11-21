using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnrealEngine.Utils;

namespace Sharphereal.UniTaskExtensions.Threading.Tasks.Internal
{
	// Token: 0x0200000A RID: 10
	[NullableContext(1)]
	[Nullable(0)]
	internal sealed class ContinuationQueue
	{
		// Token: 0x06000030 RID: 48 RVA: 0x000027F7 File Offset: 0x000009F7
		public ContinuationQueue(PlayerLoopTiming timing)
		{
			this.timing = timing;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000282C File Offset: 0x00000A2C
		public void Enqueue(Action continuation)
		{
			bool flag = false;
			try
			{
				this.gate.Enter(ref flag);
				if (this.dequing)
				{
					if (this.waitingList.Length == this.waitingListCount)
					{
						int num = this.waitingListCount * 2;
						if (num > 2146435071)
						{
							num = 2146435071;
						}
						Action[] destinationArray = new Action[num];
						Array.Copy(this.waitingList, destinationArray, this.waitingListCount);
						this.waitingList = destinationArray;
					}
					this.waitingList[this.waitingListCount] = continuation;
					this.waitingListCount++;
				}
				else
				{
					if (this.actionList.Length == this.actionListCount)
					{
						int num2 = this.actionListCount * 2;
						if (num2 > 2146435071)
						{
							num2 = 2146435071;
						}
						Action[] destinationArray2 = new Action[num2];
						Array.Copy(this.actionList, destinationArray2, this.actionListCount);
						this.actionList = destinationArray2;
					}
					this.actionList[this.actionListCount] = continuation;
					this.actionListCount++;
				}
			}
			finally
			{
				if (flag)
				{
					this.gate.Exit(false);
				}
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002940 File Offset: 0x00000B40
		public int Clear()
		{
			int result = this.actionListCount + this.waitingListCount;
			this.actionListCount = 0;
			this.actionList = new Action[16];
			this.waitingListCount = 0;
			this.waitingList = new Action[16];
			return result;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002977 File Offset: 0x00000B77
		public void Run()
		{
			this.RunCore();
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000297F File Offset: 0x00000B7F
		private void PrePhysics()
		{
			this.RunCore();
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002987 File Offset: 0x00000B87
		private void StartPhysics()
		{
			this.RunCore();
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000298F File Offset: 0x00000B8F
		private void DuringPhysics()
		{
			this.RunCore();
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002997 File Offset: 0x00000B97
		private void EndPhysics()
		{
			this.RunCore();
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000299F File Offset: 0x00000B9F
		private void PostPhysics()
		{
			this.RunCore();
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000029A7 File Offset: 0x00000BA7
		private void PostUpdateWork()
		{
			this.RunCore();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000029AF File Offset: 0x00000BAF
		private void LastDemotable()
		{
			this.RunCore();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000029B8 File Offset: 0x00000BB8
		[DebuggerHidden]
		private void RunCore()
		{
			bool flag = false;
			try
			{
				this.gate.Enter(ref flag);
				if (this.actionListCount == 0)
				{
					return;
				}
				this.dequing = true;
			}
			finally
			{
				if (flag)
				{
					this.gate.Exit(false);
				}
			}
			for (int i = 0; i < this.actionListCount; i++)
			{
				Action action = this.actionList[i];
				this.actionList[i] = null;
				try
				{
					action();
				}
				catch (Exception ex)
				{
					UnrealLogger.Info(ex.ToString());
				}
			}
			bool flag2 = false;
			try
			{
				this.gate.Enter(ref flag2);
				this.dequing = false;
				Action[] array = this.actionList;
				this.actionListCount = this.waitingListCount;
				this.actionList = this.waitingList;
				this.waitingListCount = 0;
				this.waitingList = array;
			}
			finally
			{
				if (flag2)
				{
					this.gate.Exit(false);
				}
			}
		}

		// Token: 0x0400001C RID: 28
		private const int MaxArrayLength = 2146435071;

		// Token: 0x0400001D RID: 29
		private const int InitialSize = 16;

		// Token: 0x0400001E RID: 30
		private readonly PlayerLoopTiming timing;

		// Token: 0x0400001F RID: 31
		private SpinLock gate = new SpinLock(false);

		// Token: 0x04000020 RID: 32
		private bool dequing;

		// Token: 0x04000021 RID: 33
		private int actionListCount;

		// Token: 0x04000022 RID: 34
		private Action[] actionList = new Action[16];

		// Token: 0x04000023 RID: 35
		private int waitingListCount;

		// Token: 0x04000024 RID: 36
		private Action[] waitingList = new Action[16];
	}
}
