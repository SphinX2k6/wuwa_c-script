using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GameMainView.TrapDefense;
using CSharpScript.Game.Ui;

// Token: 0x02001D47 RID: 7495
public class TrapDefenseEventTerrainChangeTips : UiViewBase
{
	// Token: 0x0600E345 RID: 58181 RVA: 0x003565D9 File Offset: 0x003547D9
	[NullableContext(1)]
	public TrapDefenseEventTerrainChangeTips(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E346 RID: 58182 RVA: 0x003565E2 File Offset: 0x003547E2
	protected override void OnStart()
	{
		this.Data = (this.OpenParam as ITrapDefenseTerrainChangeTipsData);
	}

	// Token: 0x0600E347 RID: 58183 RVA: 0x003565F5 File Offset: 0x003547F5
	protected override void OnFinishShow()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600E348 RID: 58184 RVA: 0x00356600 File Offset: 0x00354800
	protected override void OnBeforeDestroy()
	{
		ITrapDefenseTerrainChangeTipsData data = this.Data;
		Action action = (data != null) ? data.Callback : null;
		if (action != null)
		{
			action();
		}
	}

	// Token: 0x040068F2 RID: 26866
	[Nullable(2)]
	protected ITrapDefenseTerrainChangeTipsData Data;
}
