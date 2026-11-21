using System;
using System.Runtime.CompilerServices;
using System.Threading;
using UnrealEngine.Utils;

namespace Sharphereal.UniTaskExtensions.Threading.Tasks.Internal
{
	// Token: 0x0200000C RID: 12
	[NullableContext(1)]
	[Nullable(0)]
	internal sealed class PlayerLoopRunner
	{
		// Token: 0x06000045 RID: 69 RVA: 0x00002CF0 File Offset: 0x00000EF0
		public PlayerLoopRunner(PlayerLoopTiming timing)
		{
			this.unhandledExceptionCallback = delegate(Exception ex)
			{
				UnrealLogger.Info(ex.ToString());
			};
			this.timing = timing;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002D60 File Offset: 0x00000F60
		public void AddAction(IPlayerLoopItem item)
		{
			using (this.runningAndQueueLock.EnterScope())
			{
				if (this.running)
				{
					this.waitQueue.Enqueue(item);
					return;
				}
			}
			using (this.arrayLock.EnterScope())
			{
				if (this.loopItems.Length == this.tail)
				{
					Array.Resize<IPlayerLoopItem>(ref this.loopItems, checked(this.tail * 2));
				}
				IPlayerLoopItem[] array = this.loopItems;
				int num = this.tail;
				this.tail = num + 1;
				array[num] = item;
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002E08 File Offset: 0x00001008
		public int Clear()
		{
			int result;
			using (this.arrayLock.EnterScope())
			{
				int num = 0;
				for (int i = 0; i < this.loopItems.Length; i++)
				{
					if (this.loopItems[i] != null)
					{
						num++;
					}
					this.loopItems[i] = null;
				}
				this.tail = 0;
				result = num;
			}
			return result;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002E74 File Offset: 0x00001074
		public void Run()
		{
			this.RunCore();
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002E7C File Offset: 0x0000107C
		private void PrePhysics()
		{
			this.RunCore();
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002E84 File Offset: 0x00001084
		private void StartPhysics()
		{
			this.RunCore();
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002E8C File Offset: 0x0000108C
		private void DuringPhysics()
		{
			this.RunCore();
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002E94 File Offset: 0x00001094
		private void EndPhysics()
		{
			this.RunCore();
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002E9C File Offset: 0x0000109C
		private void PostPhysics()
		{
			this.RunCore();
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002EA4 File Offset: 0x000010A4
		private void PostUpdateWork()
		{
			this.RunCore();
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002EAC File Offset: 0x000010AC
		private void LastDemotable()
		{
			this.RunCore();
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002EB4 File Offset: 0x000010B4
		private void RunCore()
		{
			using (this.runningAndQueueLock.EnterScope())
			{
				this.running = true;
			}
			using (this.arrayLock.EnterScope())
			{
				int num = this.tail - 1;
				int i = 0;
				while (i < this.loopItems.Length)
				{
					IPlayerLoopItem playerLoopItem = this.loopItems[i];
					if (playerLoopItem != null)
					{
						try
						{
							if (!playerLoopItem.MoveNext())
							{
								this.loopItems[i] = null;
								goto IL_EA;
							}
							goto IL_F7;
						}
						catch (Exception obj)
						{
							this.loopItems[i] = null;
							try
							{
								this.unhandledExceptionCallback(obj);
							}
							catch
							{
							}
							goto IL_EA;
						}
						goto IL_84;
					}
					goto IL_EA;
					IL_F7:
					i++;
					continue;
					IL_84:
					IPlayerLoopItem playerLoopItem2 = this.loopItems[num];
					if (playerLoopItem2 != null)
					{
						try
						{
							if (!playerLoopItem2.MoveNext())
							{
								this.loopItems[num] = null;
								num--;
								goto IL_EA;
							}
							this.loopItems[i] = playerLoopItem2;
							this.loopItems[num] = null;
							num--;
							goto IL_F7;
						}
						catch (Exception obj2)
						{
							this.loopItems[num] = null;
							num--;
							try
							{
								this.unhandledExceptionCallback(obj2);
							}
							catch
							{
							}
							goto IL_EA;
						}
					}
					num--;
					IL_EA:
					if (i >= num)
					{
						this.tail = i;
						break;
					}
					goto IL_84;
				}
				using (this.runningAndQueueLock.EnterScope())
				{
					this.running = false;
					while (this.waitQueue.Count != 0)
					{
						if (this.loopItems.Length == this.tail)
						{
							Array.Resize<IPlayerLoopItem>(ref this.loopItems, checked(this.tail * 2));
						}
						IPlayerLoopItem[] array = this.loopItems;
						int num2 = this.tail;
						this.tail = num2 + 1;
						array[num2] = this.waitQueue.Dequeue();
					}
				}
			}
		}

		// Token: 0x0400002B RID: 43
		private const int InitialSize = 16;

		// Token: 0x0400002C RID: 44
		private readonly PlayerLoopTiming timing;

		// Token: 0x0400002D RID: 45
		private readonly Lock runningAndQueueLock = new Lock();

		// Token: 0x0400002E RID: 46
		private readonly Lock arrayLock = new Lock();

		// Token: 0x0400002F RID: 47
		private readonly Action<Exception> unhandledExceptionCallback;

		// Token: 0x04000030 RID: 48
		private int tail;

		// Token: 0x04000031 RID: 49
		private bool running;

		// Token: 0x04000032 RID: 50
		private IPlayerLoopItem[] loopItems = new IPlayerLoopItem[16];

		// Token: 0x04000033 RID: 51
		private MinimumQueue<IPlayerLoopItem> waitQueue = new MinimumQueue<IPlayerLoopItem>(16);
	}
}
