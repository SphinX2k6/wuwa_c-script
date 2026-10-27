using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.View;

namespace CSharpScript.Game.Module.PhantomArena.Battle
{
	// Token: 0x02005241 RID: 21057
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaRoundOverCheck
	{
		// Token: 0x17008253 RID: 33363
		// (get) Token: 0x06035C9D RID: 220317 RVA: 0x00CBA0D6 File Offset: 0x00CB82D6
		public bool HasAnyOperation
		{
			get
			{
				return this.HasAnyOperationInternal;
			}
		}

		// Token: 0x06035C9E RID: 220318 RVA: 0x00CBA0E0 File Offset: 0x00CB82E0
		public PhantomArenaRoundOverCheck(PhantomArenaBattleProxy proxy)
		{
			this.Proxy = proxy;
			int phantomArenaRoundOverCheck = PhantomArenaConfig.Instance.GetPhantomArenaRoundOverCheck();
			this.DelayTime = phantomArenaRoundOverCheck * 1000;
		}

		// Token: 0x17008254 RID: 33364
		// (get) Token: 0x06035C9F RID: 220319 RVA: 0x00CBA119 File Offset: 0x00CB8319
		// (set) Token: 0x06035CA0 RID: 220320 RVA: 0x00CBA121 File Offset: 0x00CB8321
		private protected PhantomArenaBattleProxy Proxy { protected get; private set; }

		// Token: 0x06035CA1 RID: 220321 RVA: 0x00CBA12A File Offset: 0x00CB832A
		private void RemoveTimer()
		{
			if (this.TimerHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x06035CA2 RID: 220322 RVA: 0x00CBA14C File Offset: 0x00CB834C
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

		// Token: 0x06035CA3 RID: 220323 RVA: 0x00CBA1E2 File Offset: 0x00CB83E2
		public void StartCheck()
		{
			this.AddTimer();
		}

		// Token: 0x06035CA4 RID: 220324 RVA: 0x00CBA1EA File Offset: 0x00CB83EA
		public void RepeatCheck()
		{
			this.RemoveTimer();
			this.AddTimer();
		}

		// Token: 0x06035CA5 RID: 220325 RVA: 0x00CBA1F8 File Offset: 0x00CB83F8
		public void Clear()
		{
			this.HasAnyOperationInternal = false;
			this.RemoveTimer();
		}

		// Token: 0x0401C856 RID: 116822
		protected bool HasAnyOperationInternal = true;

		// Token: 0x0401C857 RID: 116823
		protected int DelayTime;

		// Token: 0x0401C858 RID: 116824
		protected TimerHandle TimerHandle;
	}
}
