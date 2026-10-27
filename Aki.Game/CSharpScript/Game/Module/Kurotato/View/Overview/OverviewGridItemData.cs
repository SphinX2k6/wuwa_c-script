using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato.View.Overview
{
	// Token: 0x02005752 RID: 22354
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	internal class OverviewGridItemData : MultiTemplateGridDataBase<IKurotatoMediumItemGridData, WeaponGridItem>
	{
		// Token: 0x06038D0A RID: 232714 RVA: 0x00D7E75E File Offset: 0x00D7C95E
		public override int GetTemplateIndex()
		{
			return 1;
		}

		// Token: 0x06038D0B RID: 232715 RVA: 0x00D7E761 File Offset: 0x00D7C961
		public override bool IsNavigable()
		{
			return base.Data.Type != EKurotatoCardType.None;
		}

		// Token: 0x06038D0C RID: 232716 RVA: 0x00D7E774 File Offset: 0x00D7C974
		public override WeaponGridItem CreateProxy()
		{
			WeaponGridItem proxy = new WeaponGridItem();
			proxy.OnClickCb = delegate(bool selected)
			{
				this.OnClickCb(proxy, selected);
			};
			proxy.IsSelectedCb = this.IsSelectedCb;
			return proxy;
		}

		// Token: 0x0401DCBF RID: 122047
		public Action<WeaponGridItem, bool> OnClickCb = delegate(WeaponGridItem _, bool _)
		{
		};

		// Token: 0x0401DCC0 RID: 122048
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<IKurotatoMediumItemGridData, bool> IsSelectedCb;
	}
}
