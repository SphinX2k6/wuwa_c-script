using System;
using System.Runtime.CompilerServices;

// Token: 0x0200247D RID: 9341
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class PhantomGridGridTemplateData : MultiTemplateGridDataBase<PhantomInteractEditGridViewModel, PhantomGridItem>
{
	// Token: 0x06012BEE RID: 76782 RVA: 0x0049FD81 File Offset: 0x0049DF81
	public override int GetTemplateIndex()
	{
		return 1;
	}

	// Token: 0x06012BEF RID: 76783 RVA: 0x0049FD84 File Offset: 0x0049DF84
	public override PhantomGridItem CreateProxy()
	{
		return new PhantomGridItem
		{
			OnClickCb = delegate(IPhantomInteractGridViewModel data, int gridIndex)
			{
				this.OnClickCb(data, gridIndex);
			}
		};
	}

	// Token: 0x04008D31 RID: 36145
	public Action<IPhantomInteractGridViewModel, int> OnClickCb;
}
