using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu.KeySettingsView
{
	// Token: 0x0200443E RID: 17470
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeKeyModeData
	{
		// Token: 0x0602C14A RID: 180554 RVA: 0x00C60504 File Offset: 0x00C5E704
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

		// Token: 0x0602C14B RID: 180555 RVA: 0x00C60564 File Offset: 0x00C5E764
		public IReadOnlyList<ChangeKeyModeGroupData> GetChangeKeyModeGroupDataList()
		{
			return this.ChangeKeyModeGroupDataList;
		}

		// Token: 0x0602C14C RID: 180556 RVA: 0x00C6056C File Offset: 0x00C5E76C
		public int GetMaxGroupIndex()
		{
			return this.GetChangeKeyModeGroupDataList().Count - 1;
		}

		// Token: 0x04017BEE RID: 97262
		[Nullable(2)]
		public readonly string TitleName;

		// Token: 0x04017BEF RID: 97263
		public int DefaultGroupIndex;

		// Token: 0x04017BF0 RID: 97264
		private readonly List<ChangeKeyModeGroupData> ChangeKeyModeGroupDataList = new List<ChangeKeyModeGroupData>();
	}
}
