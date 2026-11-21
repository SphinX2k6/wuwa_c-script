using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Card
{
	// Token: 0x0200428D RID: 17037
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaCardComponentLogic
	{
		// Token: 0x0602B1E7 RID: 176615 RVA: 0x00C1F1E3 File Offset: 0x00C1D3E3
		public void SetCardShowComponent(PhantomArenaCardShowComponent component)
		{
			this.Component = component;
			this.SetActive(this.IsActive);
		}

		// Token: 0x0602B1E8 RID: 176616 RVA: 0x00C1F1F8 File Offset: 0x00C1D3F8
		public void SetActive(bool isActive)
		{
			this.IsActive = isActive;
			if (this.Component == null)
			{
				return;
			}
			if (!isActive)
			{
				this.Component.PlayClose();
				return;
			}
			if (this.IsNeedAutoHide)
			{
				this.Component.PlayStart();
				return;
			}
			this.Component.PlayLoop();
		}

		// Token: 0x040174D3 RID: 95443
		protected PhantomArenaCardShowComponent Component;

		// Token: 0x040174D4 RID: 95444
		protected bool IsActive;

		// Token: 0x040174D5 RID: 95445
		public bool IsNeedAutoHide = true;
	}
}
