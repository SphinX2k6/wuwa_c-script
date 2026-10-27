using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004516 RID: 17686
	public class ILevelPlayRewardT
	{
		// Token: 0x17007D61 RID: 32097
		// (get) Token: 0x0601A943 RID: 108867 RVA: 0x003CB946 File Offset: 0x003C9B46
		// (set) Token: 0x0601A944 RID: 108868 RVA: 0x003CB94E File Offset: 0x003C9B4E
		public ELevelPlayRewardType Type { get; set; }

		// Token: 0x0601A945 RID: 108869 RVA: 0x003CB957 File Offset: 0x003C9B57
		public ILevelPlayRewardT()
		{
			this.Type = ELevelPlayRewardType.None;
		}
	}
}
