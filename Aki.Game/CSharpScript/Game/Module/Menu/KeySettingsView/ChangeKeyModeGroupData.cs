using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu.KeySettingsView
{
	// Token: 0x0200545C RID: 21596
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeKeyModeGroupData
	{
		// Token: 0x06037204 RID: 225796 RVA: 0x00D11164 File Offset: 0x00D0F364
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

		// Token: 0x06037205 RID: 225797 RVA: 0x00D111CF File Offset: 0x00D0F3CF
		public IReadOnlyList<ChangeKeyModeRowData> GetChangeKeyModeRowDataList()
		{
			return this.ChangeKeyModeRowDataList;
		}

		// Token: 0x0401D158 RID: 119128
		[Nullable(2)]
		public readonly string GroupName;

		// Token: 0x0401D159 RID: 119129
		public readonly int DefaultKeyModeRowIndex;

		// Token: 0x0401D15A RID: 119130
		private readonly List<ChangeKeyModeRowData> ChangeKeyModeRowDataList = new List<ChangeKeyModeRowData>();
	}
}
