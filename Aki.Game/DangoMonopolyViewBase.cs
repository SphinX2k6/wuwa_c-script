using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001256 RID: 4694
[NullableContext(1)]
[Nullable(0)]
public class DangoMonopolyViewBase : UiTickViewBase
{
	// Token: 0x06007F84 RID: 32644 RVA: 0x001B02BD File Offset: 0x001AE4BD
	public DangoMonopolyViewBase(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06007F85 RID: 32645 RVA: 0x001B02C6 File Offset: 0x001AE4C6
	protected override void OnBeforeCreate()
	{
		this.UpdateActivityData();
	}

	// Token: 0x06007F86 RID: 32646 RVA: 0x001B02CF File Offset: 0x001AE4CF
	protected bool UpdateActivityData()
	{
		this.ActivityData = ActivityDangoMonopolyController.Instance.GetData();
		return this.ActivityData != null;
	}

	// Token: 0x04003A03 RID: 14851
	protected ActivityDangoMonopolyData ActivityData;
}
