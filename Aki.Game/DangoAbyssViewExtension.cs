using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02001091 RID: 4241
[NullableContext(1)]
[Nullable(0)]
public class DangoAbyssViewExtension : IViewExtension
{
	// Token: 0x0600A872 RID: 43122 RVA: 0x003191E3 File Offset: 0x003173E3
	public DangoAbyssViewExtension(Action refreshEnter)
	{
		this.RefreshEnter = refreshEnter;
	}

	// Token: 0x0600A873 RID: 43123 RVA: 0x003191F2 File Offset: 0x003173F2
	public bool ShouldActivate()
	{
		return DangoAbyssModel.Instance.CheckInAbyssEditFormationState();
	}

	// Token: 0x0600A874 RID: 43124 RVA: 0x003191FE File Offset: 0x003173FE
	public void OnViewStart()
	{
		this.Active = true;
		EventSystem.Instance.Add<IReadOnlyDictionary<int, int[]>>(EEventName.OnAbyssDangoSelect, new Action<IReadOnlyDictionary<int, int[]>>(this.OnAbyssDangoSelect));
	}

	// Token: 0x0600A875 RID: 43125 RVA: 0x00319223 File Offset: 0x00317423
	public void OnViewRefresh()
	{
	}

	// Token: 0x0600A876 RID: 43126 RVA: 0x00319225 File Offset: 0x00317425
	public void OnDetach()
	{
		if (!this.Active)
		{
			return;
		}
		EventSystem.Instance.Remove(EEventName.OnAbyssDangoSelect, new Action<IReadOnlyDictionary<int, int[]>>(this.OnAbyssDangoSelect));
		this.Active = false;
	}

	// Token: 0x0600A877 RID: 43127 RVA: 0x00319253 File Offset: 0x00317453
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

	// Token: 0x0600A878 RID: 43128 RVA: 0x00319286 File Offset: 0x00317486
	private void OnAbyssDangoSelect(IReadOnlyDictionary<int, int[]> dataMap)
	{
		this.RefreshEnter();
	}

	// Token: 0x040061DA RID: 25050
	private bool Active;

	// Token: 0x040061DB RID: 25051
	private readonly Action RefreshEnter;
}
