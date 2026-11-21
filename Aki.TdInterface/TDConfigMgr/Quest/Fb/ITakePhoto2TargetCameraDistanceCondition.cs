using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001502 RID: 5378
	public class ITakePhoto2TargetCameraDistanceCondition
	{
		// Token: 0x060079CA RID: 31178 RVA: 0x00122ED0 File Offset: 0x001210D0
		public static ITakePhoto2TargetCameraDistanceCondition Create(ITakePhoto2TargetCameraDistanceCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2TargetCameraDistanceCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002768 RID: 10088
		// (get) Token: 0x060079CB RID: 31179 RVA: 0x00122EEF File Offset: 0x001210EF
		public virtual int MaxDistance
		{
			get
			{
				return this.Instance.MaxDistance;
			}
		}

		// Token: 0x04004616 RID: 17942
		private ITakePhoto2TargetCameraDistanceCondition Instance;
	}
}
