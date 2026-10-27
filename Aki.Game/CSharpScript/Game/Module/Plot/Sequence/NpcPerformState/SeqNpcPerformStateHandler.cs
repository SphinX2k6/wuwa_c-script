using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.Sequence.NpcPerformState
{
	// Token: 0x0200502C RID: 20524
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class SeqNpcPerformStateHandler
	{
		// Token: 0x17008027 RID: 32807
		// (get) Token: 0x06034861 RID: 215137
		public abstract ENpcGroupPerformType PerformType { get; }

		// Token: 0x17008028 RID: 32808
		// (get) Token: 0x06034862 RID: 215138
		public abstract ENpcRelationType RelationType { get; }

		// Token: 0x06034863 RID: 215139
		[return: Nullable(2)]
		public abstract NpcRelation Capture(string key);

		// Token: 0x06034864 RID: 215140
		public abstract void Restore(NpcRelation relation, string reason);

		// Token: 0x06034865 RID: 215141 RVA: 0x00C60564 File Offset: 0x00C5E764
		public virtual void OnBattleCharacterHidden(NpcRelation relation, string reason)
		{
		}
	}
}
