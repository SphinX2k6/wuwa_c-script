using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;

// Token: 0x02002913 RID: 10515
public class AssemblyExploreGridData : AssemblyGridData
{
	// Token: 0x17001D28 RID: 7464
	// (get) Token: 0x06015AF0 RID: 88816 RVA: 0x0057863E File Offset: 0x0057683E
	public bool HasNew
	{
		get
		{
			return NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.RouletteAssemblyItemRedDot, this.Id);
		}
	}

	// Token: 0x06015AF1 RID: 88817 RVA: 0x00578651 File Offset: 0x00576851
	public AssemblyExploreGridData()
	{
		this.IconPath = "";
	}

	// Token: 0x0400A18C RID: 41356
	[Nullable(1)]
	public string IconPath;
}
