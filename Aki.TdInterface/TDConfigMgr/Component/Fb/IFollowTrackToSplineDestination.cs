using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BE3 RID: 3043
	[NullableContext(1)]
	[Nullable(0)]
	public class IFollowTrackToSplineDestination : IFollowTrackEndType
	{
		// Token: 0x060045E5 RID: 17893 RVA: 0x000B0BFE File Offset: 0x000AEDFE
		public static IFollowTrackToSplineDestination Create(IFollowTrackToSplineDestination? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFollowTrackToSplineDestination
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013DC RID: 5084
		// (get) Token: 0x060045E6 RID: 17894 RVA: 0x000B0C1D File Offset: 0x000AEE1D
		public override EFollowTrackEndType Type
		{
			get
			{
				return (EFollowTrackEndType)this.Instance.Type;
			}
		}

		// Token: 0x170013DD RID: 5085
		// (get) Token: 0x060045E7 RID: 17895 RVA: 0x000B0C2A File Offset: 0x000AEE2A
		public virtual string ChangeSelfState
		{
			get
			{
				return this.Instance.ChangeSelfState;
			}
		}

		// Token: 0x040027CC RID: 10188
		private IFollowTrackToSplineDestination Instance;
	}
}
