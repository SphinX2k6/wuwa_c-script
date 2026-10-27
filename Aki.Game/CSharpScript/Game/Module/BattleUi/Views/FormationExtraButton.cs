using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D2C RID: 23852
	public abstract class FormationExtraButton : BattleChildView
	{
		// Token: 0x0603C7D4 RID: 247764 RVA: 0x00E83183 File Offset: 0x00E81383
		[NullableContext(1)]
		public virtual void InitHandle(FormationUnitNodeHandle handle)
		{
			this.Handle = handle;
		}

		// Token: 0x0603C7D5 RID: 247765 RVA: 0x00E8318C File Offset: 0x00E8138C
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

		// Token: 0x0603C7D6 RID: 247766 RVA: 0x00E831A6 File Offset: 0x00E813A6
		public virtual void Tick(float delta)
		{
		}

		// Token: 0x0401F854 RID: 129108
		[Nullable(2)]
		protected FormationUnitNodeHandle Handle;
	}
}
