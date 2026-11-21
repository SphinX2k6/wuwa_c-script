using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;

// Token: 0x02001E8E RID: 7822
public class AssemblyExploreGridData : AssemblyGridData
{
	// Token: 0x17001D82 RID: 7554
	// (get) Token: 0x060134F4 RID: 79092 RVA: 0x005A3532 File Offset: 0x005A1732
	public bool HasNew
	{
		get
		{
			return NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.RouletteAssemblyItemRedDot, this.Id);
		}
	}

	// Token: 0x060134F5 RID: 79093 RVA: 0x005A3545 File Offset: 0x005A1745
	public AssemblyExploreGridData()
	{
		this.IconPath = "";
	}

	// Token: 0x0400A577 RID: 42359
	[Nullable(1)]
	public string IconPath;
}
