using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Card
{
	// Token: 0x020052BD RID: 21181
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaCardComponentLogic
	{
		// Token: 0x060362EC RID: 221932 RVA: 0x00CD1ABB File Offset: 0x00CCFCBB
		public void SetCardShowComponent(PhantomArenaCardShowComponent component)
		{
			this.Component = component;
			this.SetActive(this.IsActive);
		}

		// Token: 0x060362ED RID: 221933 RVA: 0x00CD1AD0 File Offset: 0x00CCFCD0
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

		// Token: 0x0401CA9E RID: 117406
		protected PhantomArenaCardShowComponent Component;

		// Token: 0x0401CA9F RID: 117407
		protected bool IsActive;

		// Token: 0x0401CAA0 RID: 117408
		public bool IsNeedAutoHide = true;
	}
}
