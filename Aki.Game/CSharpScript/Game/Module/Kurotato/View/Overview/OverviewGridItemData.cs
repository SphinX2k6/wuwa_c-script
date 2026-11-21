using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato.View.Overview
{
	// Token: 0x02004729 RID: 18217
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	internal class OverviewGridItemData : MultiTemplateGridDataBase<IKurotatoMediumItemGridData, WeaponGridItem>
	{
		// Token: 0x0602DC1A RID: 187418 RVA: 0x00CCD13E File Offset: 0x00CCB33E
		public override int GetTemplateIndex()
		{
			return 1;
		}

		// Token: 0x0602DC1B RID: 187419 RVA: 0x00CCD141 File Offset: 0x00CCB341
		public override bool IsNavigable()
		{
			return base.Data.Type != EKurotatoCardType.None;
		}

		// Token: 0x0602DC1C RID: 187420 RVA: 0x00CCD154 File Offset: 0x00CCB354
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

		// Token: 0x04018755 RID: 100181
		public Action<WeaponGridItem, bool> OnClickCb = delegate(WeaponGridItem _, bool _)
		{
		};

		// Token: 0x04018756 RID: 100182
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<IKurotatoMediumItemGridData, bool> IsSelectedCb;
	}
}
