using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BE1 RID: 3041
	public class IFollowTrackToStart : IFollowTrackEndType
	{
		// Token: 0x060045DD RID: 17885 RVA: 0x000B0B55 File Offset: 0x000AED55
		[NullableContext(1)]
		public static IFollowTrackToStart Create(IFollowTrackToStart? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFollowTrackToStart
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013D8 RID: 5080
		// (get) Token: 0x060045DE RID: 17886 RVA: 0x000B0B74 File Offset: 0x000AED74
		public override EFollowTrackEndType Type
		{
			get
			{
				return (EFollowTrackEndType)this.Instance.Type;
			}
		}

		// Token: 0x040027C8 RID: 10184
		private IFollowTrackToStart Instance;
	}
}
