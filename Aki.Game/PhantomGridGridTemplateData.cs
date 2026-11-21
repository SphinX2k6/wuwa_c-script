using System;
using System.Runtime.CompilerServices;

// Token: 0x02001962 RID: 6498
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class PhantomGridGridTemplateData : MultiTemplateGridDataBase<PhantomInteractEditGridViewModel, PhantomGridItem>
{
	// Token: 0x060100A5 RID: 65701 RVA: 0x004AD4D9 File Offset: 0x004AB6D9
	public override int GetTemplateIndex()
	{
		return 1;
	}

	// Token: 0x060100A6 RID: 65702 RVA: 0x004AD4DC File Offset: 0x004AB6DC
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

	// Token: 0x04008E78 RID: 36472
	public Action<IPhantomInteractGridViewModel, int> OnClickCb;
}
