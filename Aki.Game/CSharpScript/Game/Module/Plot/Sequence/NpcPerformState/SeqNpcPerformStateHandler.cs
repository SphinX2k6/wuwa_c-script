using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.Sequence.NpcPerformState
{
	// Token: 0x02003FF6 RID: 16374
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class SeqNpcPerformStateHandler
	{
		// Token: 0x170053DC RID: 21468
		// (get) Token: 0x06029704 RID: 169732
		public abstract ENpcGroupPerformType PerformType { get; }

		// Token: 0x170053DD RID: 21469
		// (get) Token: 0x06029705 RID: 169733
		public abstract ENpcRelationType RelationType { get; }

		// Token: 0x06029706 RID: 169734
		[return: Nullable(2)]
		public abstract NpcRelation Capture(string key);

		// Token: 0x06029707 RID: 169735
		public abstract void Restore(NpcRelation relation, string reason);

		// Token: 0x06029708 RID: 169736 RVA: 0x00BABADC File Offset: 0x00BA9CDC
		public virtual void OnBattleCharacterHidden(NpcRelation relation, string reason)
		{
		}
	}
}
