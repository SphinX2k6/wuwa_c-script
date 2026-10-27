using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WorldMap.RegionalTerminal.Data;

// Token: 0x02002D73 RID: 11635
[NullableContext(1)]
[Nullable(0)]
public class RegionalTerminalGroupData
{
	// Token: 0x17002110 RID: 8464
	// (get) Token: 0x0601877F RID: 100223 RVA: 0x0063A394 File Offset: 0x00638594
	// (set) Token: 0x06018780 RID: 100224 RVA: 0x0063A39C File Offset: 0x0063859C
	public int GroupId { get; set; }

	// Token: 0x17002111 RID: 8465
	// (get) Token: 0x06018781 RID: 100225 RVA: 0x0063A3A5 File Offset: 0x006385A5
	// (set) Token: 0x06018782 RID: 100226 RVA: 0x0063A3AD File Offset: 0x006385AD
	public int SortId { get; set; }

	// Token: 0x17002112 RID: 8466
	// (get) Token: 0x06018783 RID: 100227 RVA: 0x0063A3B6 File Offset: 0x006385B6
	// (set) Token: 0x06018784 RID: 100228 RVA: 0x0063A3BE File Offset: 0x006385BE
	public List<RegionalTerminalGameplayData> GameplayDataList { get; set; } = new List<RegionalTerminalGameplayData>();

	// Token: 0x06018785 RID: 100229 RVA: 0x0063A3C8 File Offset: 0x006385C8
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
