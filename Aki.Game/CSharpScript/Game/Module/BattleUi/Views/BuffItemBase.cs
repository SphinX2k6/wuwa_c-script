using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D10 RID: 23824
	public abstract class BuffItemBase : UiPanelBase
	{
		// Token: 0x0603C632 RID: 247346
		[NullableContext(2)]
		public abstract void Activate(GameplayCue buffCueConfig, IActiveBuff buff, bool playAnim = false, int buffNum = 0);

		// Token: 0x0603C633 RID: 247347 RVA: 0x00E792BC File Offset: 0x00E774BC
		public virtual void SetNum(int num)
		{
		}

		// Token: 0x0603C634 RID: 247348
		public abstract void Tick(float delta);

		// Token: 0x0603C635 RID: 247349
		public abstract bool TickHiding(float delta);

		// Token: 0x0603C636 RID: 247350
		public abstract void Deactivate();

		// Token: 0x0603C637 RID: 247351
		public abstract void DeactivateWithCloseAnim();

		// Token: 0x0603C638 RID: 247352 RVA: 0x00E792BE File Offset: 0x00E774BE
		public virtual void PlayAddBuffAnim()
		{
		}
	}
}
