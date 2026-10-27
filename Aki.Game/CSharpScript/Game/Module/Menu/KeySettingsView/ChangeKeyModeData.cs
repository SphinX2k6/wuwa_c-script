using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu.KeySettingsView
{
	// Token: 0x0200545B RID: 21595
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeKeyModeData
	{
		// Token: 0x06037201 RID: 225793 RVA: 0x00D110EC File Offset: 0x00D0F2EC
		public ChangeKeyModeData(IChangeKeyMode changeKeyMode)
		{
			this.TitleName = changeKeyMode.TitleName;
			this.DefaultGroupIndex = changeKeyMode.DefaultGroupIndex;
			IChangeKeyModeGroup[] changeKeyModeGroupList = changeKeyMode.ChangeKeyModeGroupList;
			for (int i = 0; i < changeKeyModeGroupList.Length; i++)
			{
				ChangeKeyModeGroupData item = new ChangeKeyModeGroupData(changeKeyModeGroupList[i]);
				this.ChangeKeyModeGroupDataList.Add(item);
			}
		}

		// Token: 0x06037202 RID: 225794 RVA: 0x00D1114C File Offset: 0x00D0F34C
		public IReadOnlyList<ChangeKeyModeGroupData> GetChangeKeyModeGroupDataList()
		{
			return this.ChangeKeyModeGroupDataList;
		}

		// Token: 0x06037203 RID: 225795 RVA: 0x00D11154 File Offset: 0x00D0F354
		public int GetMaxGroupIndex()
		{
			return this.GetChangeKeyModeGroupDataList().Count - 1;
		}

		// Token: 0x0401D155 RID: 119125
		[Nullable(2)]
		public readonly string TitleName;

		// Token: 0x0401D156 RID: 119126
		public int DefaultGroupIndex;

		// Token: 0x0401D157 RID: 119127
		private readonly List<ChangeKeyModeGroupData> ChangeKeyModeGroupDataList = new List<ChangeKeyModeGroupData>();
	}
}
