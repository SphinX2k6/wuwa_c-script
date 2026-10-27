using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013B1 RID: 5041
	public class ITakePhoto2TargetCameraDistanceCondition
	{
		// Token: 0x06007323 RID: 29475 RVA: 0x00114814 File Offset: 0x00112A14
		[NullableContext(1)]
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

		// Token: 0x17002594 RID: 9620
		// (get) Token: 0x06007324 RID: 29476 RVA: 0x00114833 File Offset: 0x00112A33
		public virtual int MaxDistance
		{
			get
			{
				return this.Instance.MaxDistance;
			}
		}

		// Token: 0x04004295 RID: 17045
		private ITakePhoto2TargetCameraDistanceCondition Instance;
	}
}
