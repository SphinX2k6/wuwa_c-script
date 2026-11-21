using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato.View.Settlement
{
	// Token: 0x02004705 RID: 18181
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class RoleItemData : MultiTemplateGridDataBase<int, RoleItem>
	{
		// Token: 0x0602DAE0 RID: 187104 RVA: 0x00CC5D0C File Offset: 0x00CC3F0C
		public override int GetTemplateIndex()
		{
			return 2;
		}

		// Token: 0x0602DAE1 RID: 187105 RVA: 0x00CC5D10 File Offset: 0x00CC3F10
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

		// Token: 0x040186E4 RID: 100068
		public Action<RoleItem, bool> OnClickCb;
	}
}
