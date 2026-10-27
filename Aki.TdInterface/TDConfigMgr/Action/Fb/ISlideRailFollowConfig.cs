using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A14 RID: 10772
	[NullableContext(2)]
	[Nullable(0)]
	public class ISlideRailFollowConfig
	{
		// Token: 0x0600ED85 RID: 60805 RVA: 0x00229F70 File Offset: 0x00228170
		[NullableContext(1)]
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

		// Token: 0x17004B1F RID: 19231
		// (get) Token: 0x0600ED86 RID: 60806 RVA: 0x00229F8F File Offset: 0x0022818F
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17004B20 RID: 19232
		// (get) Token: 0x0600ED87 RID: 60807 RVA: 0x00229F9C File Offset: 0x0022819C
		public virtual string FollowDaPath
		{
			get
			{
				return this.Instance.FollowDaPath;
			}
		}

		// Token: 0x040082BE RID: 33470
		private ISlideRailFollowConfig Instance;
	}
}
