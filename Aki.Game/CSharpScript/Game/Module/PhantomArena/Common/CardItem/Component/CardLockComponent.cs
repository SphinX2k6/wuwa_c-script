using System;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component
{
	// Token: 0x020041BD RID: 16829
	public class CardLockComponent : CardComponentBase<bool>
	{
		// Token: 0x0602A962 RID: 174434 RVA: 0x00C028F3 File Offset: 0x00C00AF3
		public override void Refresh(bool isLocked)
		{
			this.SetActive(isLocked);
		}
	}
}
