using System;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component
{
	// Token: 0x020051ED RID: 20973
	public class CardLockComponent : CardComponentBase<bool>
	{
		// Token: 0x06035A67 RID: 219751 RVA: 0x00CB52B7 File Offset: 0x00CB34B7
		public override void Refresh(bool isLocked)
		{
			this.SetActive(isLocked);
		}
	}
}
