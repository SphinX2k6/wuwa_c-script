using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.View;

namespace CSharpScript.Game.Module.PhantomArena.Battle
{
	// Token: 0x02004211 RID: 16913
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaRoundOverCheck
	{
		// Token: 0x17005613 RID: 22035
		// (get) Token: 0x0602AB98 RID: 175000 RVA: 0x00C07716 File Offset: 0x00C05916
		public bool HasAnyOperation
		{
			get
			{
				return this.HasAnyOperationInternal;
			}
		}

		// Token: 0x0602AB99 RID: 175001 RVA: 0x00C07720 File Offset: 0x00C05920
		public PhantomArenaRoundOverCheck(PhantomArenaBattleProxy proxy)
		{
			this.Proxy = proxy;
			int phantomArenaRoundOverCheck = PhantomArenaConfig.Instance.GetPhantomArenaRoundOverCheck();
			this.DelayTime = phantomArenaRoundOverCheck * 1000;
		}

		// Token: 0x17005614 RID: 22036
		// (get) Token: 0x0602AB9A RID: 175002 RVA: 0x00C07759 File Offset: 0x00C05959
		// (set) Token: 0x0602AB9B RID: 175003 RVA: 0x00C07761 File Offset: 0x00C05961
		private protected PhantomArenaBattleProxy Proxy { protected get; private set; }

		// Token: 0x0602AB9C RID: 175004 RVA: 0x00C0776A File Offset: 0x00C0596A
		private void RemoveTimer()
		{
			if (this.TimerHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x0602AB9D RID: 175005 RVA: 0x00C0778C File Offset: 0x00C0598C
		private void AddTimer()
		{
			this.HasAnyOperationInternal = true;
			this.Proxy.HideRoundOverEffect();
			if (this.Proxy.CheckRepeatCondition())
			{
				Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "PhantomArenaRoundOverCheck检测无操作条件满足", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.TimerHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
				{
					this.HasAnyOperationInternal = false;
					this.Proxy.PlayRoundOverEffect();
					this.TimerHandle = null;
				}, (float)this.DelayTime, null, null, true, 1f);
				return;
			}
			Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "PhantomArenaRoundOverCheck检测无操作条件不满足", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0602AB9E RID: 175006 RVA: 0x00C07822 File Offset: 0x00C05A22
		public void StartCheck()
		{
			this.AddTimer();
		}

		// Token: 0x0602AB9F RID: 175007 RVA: 0x00C0782A File Offset: 0x00C05A2A
		public void RepeatCheck()
		{
			this.RemoveTimer();
			this.AddTimer();
		}

		// Token: 0x0602ABA0 RID: 175008 RVA: 0x00C07838 File Offset: 0x00C05A38
		public void Clear()
		{
			this.HasAnyOperationInternal = false;
			this.RemoveTimer();
		}

		// Token: 0x0401728B RID: 94859
		protected bool HasAnyOperationInternal = true;

		// Token: 0x0401728C RID: 94860
		protected int DelayTime;

		// Token: 0x0401728D RID: 94861
		protected TimerHandle TimerHandle;
	}
}
