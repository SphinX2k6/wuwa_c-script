using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x0200070A RID: 1802
[NullableContext(1)]
[Nullable(0)]
public class DangoMonopolyViewBase : UiTickViewBase
{
	// Token: 0x0600531B RID: 21275 RVA: 0x001B8F6D File Offset: 0x001B716D
	public DangoMonopolyViewBase(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600531C RID: 21276 RVA: 0x001B8F76 File Offset: 0x001B7176
	protected override void OnBeforeCreate()
	{
		this.UpdateActivityData();
	}

	// Token: 0x0600531D RID: 21277 RVA: 0x001B8F7F File Offset: 0x001B717F
	protected bool UpdateActivityData()
	{
		this.ActivityData = ActivityDangoMonopolyController.Instance.GetData();
		return this.ActivityData != null;
	}

	// Token: 0x04003A9B RID: 15003
	protected ActivityDangoMonopolyData ActivityData;
}
