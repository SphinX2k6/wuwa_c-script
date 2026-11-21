using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonComponentModel
{
	// Token: 0x0200488A RID: 18570
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class RankTimeItemModelBase
	{
		// Token: 0x0602EB0B RID: 191243 RVA: 0x00D086E7 File Offset: 0x00D068E7
		public void RefreshInstance(int instanceId)
		{
			this.InstanceId = instanceId;
		}

		// Token: 0x0602EB0C RID: 191244 RVA: 0x00D086F0 File Offset: 0x00D068F0
		public void ButtonClick()
		{
			this.OnButtonClick();
		}

		// Token: 0x0602EB0D RID: 191245 RVA: 0x00D086F8 File Offset: 0x00D068F8
		public TableTextArgNew GetContent()
		{
			return this.OnGetContent();
		}

		// Token: 0x0602EB0E RID: 191246
		protected abstract void OnButtonClick();

		// Token: 0x0602EB0F RID: 191247
		protected abstract TableTextArgNew OnGetContent();

		// Token: 0x04018D1D RID: 101661
		protected int InstanceId;
	}
}
