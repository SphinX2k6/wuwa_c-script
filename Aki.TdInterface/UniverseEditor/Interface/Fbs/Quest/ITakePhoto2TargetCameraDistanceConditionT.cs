using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045ED RID: 17901
	public class ITakePhoto2TargetCameraDistanceConditionT
	{
		// Token: 0x17007D37 RID: 32055
		// (get) Token: 0x0601A287 RID: 107143 RVA: 0x003B9CF6 File Offset: 0x003B7EF6
		// (set) Token: 0x0601A288 RID: 107144 RVA: 0x003B9CFE File Offset: 0x003B7EFE
		public int MaxDistance { get; set; }

		// Token: 0x0601A289 RID: 107145 RVA: 0x003B9D07 File Offset: 0x003B7F07
		public ITakePhoto2TargetCameraDistanceConditionT()
		{
			this.MaxDistance = 0;
		}
	}
}
