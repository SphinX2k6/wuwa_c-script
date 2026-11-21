using System;
using System.Runtime.CompilerServices;

// Token: 0x0200195F RID: 6495
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhantomGridRowTitleTemplateData : MultiTemplateGridDataBase<int, PhantomGridRowTitleItem>
{
	// Token: 0x0601009B RID: 65691 RVA: 0x004AD38E File Offset: 0x004AB58E
	public override int GetTemplateIndex()
	{
		return 0;
	}

	// Token: 0x0601009C RID: 65692 RVA: 0x004AD391 File Offset: 0x004AB591
	public override PhantomGridRowTitleItem CreateProxy()
	{
		return new PhantomGridRowTitleItem
		{
			ClickRecommendBtnCb = delegate()
			{
				Action clickRecommendBtnCb = this.ClickRecommendBtnCb;
				if (clickRecommendBtnCb == null)
				{
					return;
				}
				clickRecommendBtnCb();
			}
		};
	}

	// Token: 0x04008E73 RID: 36467
	[Nullable(2)]
	public Action ClickRecommendBtnCb;
}
