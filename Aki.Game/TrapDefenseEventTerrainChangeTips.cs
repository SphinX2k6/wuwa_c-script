using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GameMainView.TrapDefense;
using CSharpScript.Game.Ui;

// Token: 0x02001209 RID: 4617
public class TrapDefenseEventTerrainChangeTips : UiViewBase
{
	// Token: 0x0600B762 RID: 46946 RVA: 0x00362009 File Offset: 0x00360209
	[NullableContext(1)]
	public TrapDefenseEventTerrainChangeTips(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600B763 RID: 46947 RVA: 0x00362012 File Offset: 0x00360212
	protected override void OnStart()
	{
		this.Data = (this.OpenParam as ITrapDefenseTerrainChangeTipsData);
	}

	// Token: 0x0600B764 RID: 46948 RVA: 0x00362025 File Offset: 0x00360225
	protected override void OnFinishShow()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600B765 RID: 46949 RVA: 0x00362030 File Offset: 0x00360230
	protected override void OnBeforeDestroy()
	{
		ITrapDefenseTerrainChangeTipsData data = this.Data;
		Action action = (data != null) ? data.Callback : null;
		if (action != null)
		{
			action();
		}
	}

	// Token: 0x040069D1 RID: 27089
	[Nullable(2)]
	protected ITrapDefenseTerrainChangeTipsData Data;
}
