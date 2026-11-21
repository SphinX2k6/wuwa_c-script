using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003567 RID: 13671
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class UiSwitcherBase
	{
		// Token: 0x06022CDC RID: 142556 RVA: 0x009E3975 File Offset: 0x009E1B75
		protected UiSwitcherBase(string name)
		{
		}

		// Token: 0x170048A4 RID: 18596
		// (get) Token: 0x06022CDD RID: 142557 RVA: 0x009E3984 File Offset: 0x009E1B84
		public bool IsApplied
		{
			get
			{
				return this.Owner != null;
			}
		}

		// Token: 0x06022CDE RID: 142558 RVA: 0x009E398F File Offset: 0x009E1B8F
		internal bool Apply(UiPanelBase owner)
		{
			if (this.Owner != null)
			{
				return false;
			}
			this.Owner = owner;
			this.ApplyInternal();
			return true;
		}

		// Token: 0x06022CDF RID: 142559 RVA: 0x009E39A9 File Offset: 0x009E1BA9
		internal bool Restore(UiPanelBase owner)
		{
			if (this.Owner != owner)
			{
				return false;
			}
			this.RestoreInternal();
			this.Owner = null;
			return true;
		}

		// Token: 0x06022CE0 RID: 142560
		protected abstract void ApplyInternal();

		// Token: 0x06022CE1 RID: 142561
		protected abstract void RestoreInternal();

		// Token: 0x040133EB RID: 78827
		[Nullable(2)]
		private UiPanelBase Owner;

		// Token: 0x040133EC RID: 78828
		public readonly string Name = name;
	}
}
