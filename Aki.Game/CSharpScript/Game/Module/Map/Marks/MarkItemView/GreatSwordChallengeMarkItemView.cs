using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x020044E3 RID: 17635
	[NullableContext(1)]
	[Nullable(0)]
	public class GreatSwordChallengeMarkItemView : ConfigMarkItemView
	{
		// Token: 0x0602C88E RID: 182414 RVA: 0x00C81936 File Offset: 0x00C7FB36
		public GreatSwordChallengeMarkItemView(GreatSwordChallengeMarkItem holder) : base(holder)
		{
			this.GreatSwordChallengeMarkItem = holder;
		}

		// Token: 0x0602C88F RID: 182415 RVA: 0x00C81946 File Offset: 0x00C7FB46
		protected override void OnViewRefresh()
		{
			this.GreatSwordChallengeMarkItem.UpdateIconPath();
			this.OnIconPathChanged(this.Holder.IconPath);
		}

		// Token: 0x0602C890 RID: 182416 RVA: 0x00C81964 File Offset: 0x00C7FB64
		public override void RegisterEvents()
		{
		}

		// Token: 0x0602C891 RID: 182417 RVA: 0x00C81966 File Offset: 0x00C7FB66
		public override void UnRegisterEvents()
		{
		}

		// Token: 0x0602C892 RID: 182418 RVA: 0x00C81968 File Offset: 0x00C7FB68
		protected override void OnSafeUpdate(Vector playerLocation, bool bDragging = false, bool bIsScale = false)
		{
			this.GreatSwordChallengeMarkItem.UpdateIconPath();
			this.OnIconPathChanged(this.Holder.IconPath);
		}

		// Token: 0x04017E8F RID: 97935
		[Nullable(2)]
		private readonly GreatSwordChallengeMarkItem GreatSwordChallengeMarkItem;
	}
}
