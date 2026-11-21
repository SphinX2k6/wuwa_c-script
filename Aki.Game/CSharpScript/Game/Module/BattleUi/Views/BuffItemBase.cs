using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CF2 RID: 19698
	public abstract class BuffItemBase : UiPanelBase
	{
		// Token: 0x0603158B RID: 202123
		[NullableContext(2)]
		public abstract void Activate(GameplayCue buffCueConfig, IActiveBuff buff, bool playAnim = false, int buffNum = 0);

		// Token: 0x0603158C RID: 202124 RVA: 0x00DC993C File Offset: 0x00DC7B3C
		public virtual void SetNum(int num)
		{
		}

		// Token: 0x0603158D RID: 202125
		public abstract void Tick(float delta);

		// Token: 0x0603158E RID: 202126
		public abstract bool TickHiding(float delta);

		// Token: 0x0603158F RID: 202127
		public abstract void Deactivate();

		// Token: 0x06031590 RID: 202128
		public abstract void DeactivateWithCloseAnim();

		// Token: 0x06031591 RID: 202129 RVA: 0x00DC993E File Offset: 0x00DC7B3E
		public virtual void PlayAddBuffAnim()
		{
		}
	}
}
