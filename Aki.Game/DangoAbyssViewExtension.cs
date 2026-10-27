using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02001BD2 RID: 7122
[NullableContext(1)]
[Nullable(0)]
public class DangoAbyssViewExtension : IViewExtension
{
	// Token: 0x0600D460 RID: 54368 RVA: 0x0030E06F File Offset: 0x0030C26F
	public DangoAbyssViewExtension(Action refreshEnter)
	{
		this.RefreshEnter = refreshEnter;
	}

	// Token: 0x0600D461 RID: 54369 RVA: 0x0030E07E File Offset: 0x0030C27E
	public bool ShouldActivate()
	{
		return DangoAbyssModel.Instance.CheckInAbyssEditFormationState();
	}

	// Token: 0x0600D462 RID: 54370 RVA: 0x0030E08A File Offset: 0x0030C28A
	public void OnViewStart()
	{
		this.Active = true;
		EventSystem.Instance.Add<IReadOnlyDictionary<int, int[]>>(EEventName.OnAbyssDangoSelect, new Action<IReadOnlyDictionary<int, int[]>>(this.OnAbyssDangoSelect));
	}

	// Token: 0x0600D463 RID: 54371 RVA: 0x0030E0AF File Offset: 0x0030C2AF
	public void OnViewRefresh()
	{
	}

	// Token: 0x0600D464 RID: 54372 RVA: 0x0030E0B1 File Offset: 0x0030C2B1
	public void OnDetach()
	{
		if (!this.Active)
		{
			return;
		}
		EventSystem.Instance.Remove(EEventName.OnAbyssDangoSelect, new Action<IReadOnlyDictionary<int, int[]>>(this.OnAbyssDangoSelect));
		this.Active = false;
	}

	// Token: 0x0600D465 RID: 54373 RVA: 0x0030E0DF File Offset: 0x0030C2DF
	public IEnterGateResult ContributeEnterGate()
	{
		if (DangoAbyssModel.Instance.CheckInAbyssEditFormationState() && !DangoAbyssModel.Instance.CheckAllDangoReady())
		{
			return new IEnterGateResult
			{
				Ok = false
			};
		}
		return new IEnterGateResult
		{
			Ok = true
		};
	}

	// Token: 0x0600D466 RID: 54374 RVA: 0x0030E112 File Offset: 0x0030C312
	private void OnAbyssDangoSelect(IReadOnlyDictionary<int, int[]> dataMap)
	{
		this.RefreshEnter();
	}

	// Token: 0x0400610B RID: 24843
	private bool Active;

	// Token: 0x0400610C RID: 24844
	private readonly Action RefreshEnter;
}
