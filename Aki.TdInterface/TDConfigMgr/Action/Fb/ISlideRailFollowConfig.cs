using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D01 RID: 11521
	public class ISlideRailFollowConfig
	{
		// Token: 0x0600FC1C RID: 64540 RVA: 0x002478F4 File Offset: 0x00245AF4
		public static ISlideRailFollowConfig Create(ISlideRailFollowConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISlideRailFollowConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004EC8 RID: 20168
		// (get) Token: 0x0600FC1D RID: 64541 RVA: 0x00247913 File Offset: 0x00245B13
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17004EC9 RID: 20169
		// (get) Token: 0x0600FC1E RID: 64542 RVA: 0x00247920 File Offset: 0x00245B20
		[Nullable(2)]
		public virtual string FollowDaPath
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.FollowDaPath;
			}
		}

		// Token: 0x040089AF RID: 35247
		private ISlideRailFollowConfig Instance;
	}
}
