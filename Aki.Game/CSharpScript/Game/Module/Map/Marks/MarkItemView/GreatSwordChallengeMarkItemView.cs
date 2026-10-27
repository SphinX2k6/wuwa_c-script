using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x02005510 RID: 21776
	[NullableContext(1)]
	[Nullable(0)]
	public class GreatSwordChallengeMarkItemView : ConfigMarkItemView
	{
		// Token: 0x060379C0 RID: 227776 RVA: 0x00D33A5A File Offset: 0x00D31C5A
		public GreatSwordChallengeMarkItemView(GreatSwordChallengeMarkItem holder) : base(holder)
		{
			this.GreatSwordChallengeMarkItem = holder;
		}

		// Token: 0x060379C1 RID: 227777 RVA: 0x00D33A6A File Offset: 0x00D31C6A
		protected override void OnViewRefresh()
		{
			this.GreatSwordChallengeMarkItem.UpdateIconPath();
			this.OnIconPathChanged(this.Holder.IconPath);
		}

		// Token: 0x060379C2 RID: 227778 RVA: 0x00D33A88 File Offset: 0x00D31C88
		public override void RegisterEvents()
		{
		}

		// Token: 0x060379C3 RID: 227779 RVA: 0x00D33A8A File Offset: 0x00D31C8A
		public override void UnRegisterEvents()
		{
		}

		// Token: 0x060379C4 RID: 227780 RVA: 0x00D33A8C File Offset: 0x00D31C8C
		protected override void OnSafeUpdate(Vector playerLocation, bool bDragging = false, bool bIsScale = false)
		{
			this.GreatSwordChallengeMarkItem.UpdateIconPath();
			this.OnIconPathChanged(this.Holder.IconPath);
		}

		// Token: 0x0401D40B RID: 119819
		[Nullable(2)]
		private readonly GreatSwordChallengeMarkItem GreatSwordChallengeMarkItem;
	}
}
