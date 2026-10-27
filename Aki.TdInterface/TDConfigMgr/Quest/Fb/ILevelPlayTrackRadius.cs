using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200133C RID: 4924
	public class ILevelPlayTrackRadius
	{
		// Token: 0x060070DC RID: 28892 RVA: 0x001103DD File Offset: 0x0010E5DD
		[NullableContext(1)]
		public static ILevelPlayTrackRadius Create(ILevelPlayTrackRadius? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILevelPlayTrackRadius
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002437 RID: 9271
		// (get) Token: 0x060070DD RID: 28893 RVA: 0x001103FC File Offset: 0x0010E5FC
		public virtual int TrackRadius
		{
			get
			{
				return this.Instance.TrackRadius;
			}
		}

		// Token: 0x04004120 RID: 16672
		private ILevelPlayTrackRadius Instance;
	}
}
