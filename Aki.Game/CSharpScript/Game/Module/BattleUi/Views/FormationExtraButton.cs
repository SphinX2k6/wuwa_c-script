using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D0E RID: 19726
	public abstract class FormationExtraButton : BattleChildView
	{
		// Token: 0x0603172D RID: 202541 RVA: 0x00DD3923 File Offset: 0x00DD1B23
		[NullableContext(1)]
		public virtual void InitHandle(FormationUnitNodeHandle handle)
		{
			this.Handle = handle;
		}

		// Token: 0x0603172E RID: 202542 RVA: 0x00DD392C File Offset: 0x00DD1B2C
		public virtual void SetVisible(bool visibility)
		{
			this.SetActive(visibility);
			FormationUnitNodeHandle handle = this.Handle;
			if (handle == null)
			{
				return;
			}
			handle.SetNodeVisible(visibility);
		}

		// Token: 0x0603172F RID: 202543 RVA: 0x00DD3946 File Offset: 0x00DD1B46
		public virtual void Tick(float delta)
		{
		}

		// Token: 0x0401A30D RID: 107277
		[Nullable(2)]
		protected FormationUnitNodeHandle Handle;
	}
}
