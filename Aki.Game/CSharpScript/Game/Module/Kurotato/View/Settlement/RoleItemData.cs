using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato.View.Settlement
{
	// Token: 0x0200572E RID: 22318
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class RoleItemData : MultiTemplateGridDataBase<int, RoleItem>
	{
		// Token: 0x06038BD0 RID: 232400 RVA: 0x00D77660 File Offset: 0x00D75860
		public override int GetTemplateIndex()
		{
			return 2;
		}

		// Token: 0x06038BD1 RID: 232401 RVA: 0x00D77664 File Offset: 0x00D75864
		public override RoleItem CreateProxy()
		{
			RoleItem proxy = new RoleItem();
			proxy.OnClickCb = delegate(int roleId)
			{
				Action<RoleItem, bool> onClickCb = this.OnClickCb;
				if (onClickCb == null)
				{
					return;
				}
				onClickCb(proxy, true);
			};
			return proxy;
		}

		// Token: 0x0401DC4E RID: 121934
		public Action<RoleItem, bool> OnClickCb;
	}
}
