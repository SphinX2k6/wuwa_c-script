using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu.KeySettingsView
{
	// Token: 0x0200443F RID: 17471
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeKeyModeGroupData
	{
		// Token: 0x0602C14D RID: 180557 RVA: 0x00C6057C File Offset: 0x00C5E77C
		public ChangeKeyModeGroupData(IChangeKeyModeGroup changeKeyModeGroup)
		{
			this.GroupName = changeKeyModeGroup.GroupName;
			this.DefaultKeyModeRowIndex = changeKeyModeGroup.DefaultKeyModeRowIndex;
			int num = 0;
			foreach (IChangeKeyModeRow changeKeyModeRow in changeKeyModeGroup.ChangeKeyModeRowList)
			{
				ChangeKeyModeRowData item = new ChangeKeyModeRowData(num, changeKeyModeRow);
				this.ChangeKeyModeRowDataList.Add(item);
				num++;
			}
		}

		// Token: 0x0602C14E RID: 180558 RVA: 0x00C605E7 File Offset: 0x00C5E7E7
		public IReadOnlyList<ChangeKeyModeRowData> GetChangeKeyModeRowDataList()
		{
			return this.ChangeKeyModeRowDataList;
		}

		// Token: 0x04017BF1 RID: 97265
		[Nullable(2)]
		public readonly string GroupName;

		// Token: 0x04017BF2 RID: 97266
		public readonly int DefaultKeyModeRowIndex;

		// Token: 0x04017BF3 RID: 97267
		private readonly List<ChangeKeyModeRowData> ChangeKeyModeRowDataList = new List<ChangeKeyModeRowData>();
	}
}
