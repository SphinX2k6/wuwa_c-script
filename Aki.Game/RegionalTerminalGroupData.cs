using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WorldMap.RegionalTerminal.Data;

// Token: 0x020022CD RID: 8909
[NullableContext(1)]
[Nullable(0)]
public class RegionalTerminalGroupData
{
	// Token: 0x1700216B RID: 8555
	// (get) Token: 0x06016021 RID: 90145 RVA: 0x006603AC File Offset: 0x0065E5AC
	// (set) Token: 0x06016022 RID: 90146 RVA: 0x006603B4 File Offset: 0x0065E5B4
	public int GroupId { get; set; }

	// Token: 0x1700216C RID: 8556
	// (get) Token: 0x06016023 RID: 90147 RVA: 0x006603BD File Offset: 0x0065E5BD
	// (set) Token: 0x06016024 RID: 90148 RVA: 0x006603C5 File Offset: 0x0065E5C5
	public int SortId { get; set; }

	// Token: 0x1700216D RID: 8557
	// (get) Token: 0x06016025 RID: 90149 RVA: 0x006603CE File Offset: 0x0065E5CE
	// (set) Token: 0x06016026 RID: 90150 RVA: 0x006603D6 File Offset: 0x0065E5D6
	public List<RegionalTerminalGameplayData> GameplayDataList { get; set; } = new List<RegionalTerminalGameplayData>();

	// Token: 0x06016027 RID: 90151 RVA: 0x006603E0 File Offset: 0x0065E5E0
	public bool IsAvailableShow()
	{
		using (List<RegionalTerminalGameplayData>.Enumerator enumerator = this.GameplayDataList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.GetShowState())
				{
					return true;
				}
			}
		}
		return false;
	}
}
