using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonComponentModel
{
	// Token: 0x020058B2 RID: 22706
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class RankTimeItemModelBase
	{
		// Token: 0x06039BE8 RID: 236520 RVA: 0x00DB97CF File Offset: 0x00DB79CF
		public void RefreshInstance(int instanceId)
		{
			this.InstanceId = instanceId;
		}

		// Token: 0x06039BE9 RID: 236521 RVA: 0x00DB97D8 File Offset: 0x00DB79D8
		public void ButtonClick()
		{
			this.OnButtonClick();
		}

		// Token: 0x06039BEA RID: 236522 RVA: 0x00DB97E0 File Offset: 0x00DB79E0
		public TableTextArgNew GetContent()
		{
			return this.OnGetContent();
		}

		// Token: 0x06039BEB RID: 236523
		protected abstract void OnButtonClick();

		// Token: 0x06039BEC RID: 236524
		protected abstract TableTextArgNew OnGetContent();

		// Token: 0x0401E280 RID: 123520
		protected int InstanceId;
	}
}
