using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BE0 RID: 3040
	public class IFollowTrackEndType
	{
		// Token: 0x060045DA RID: 17882 RVA: 0x000B0B21 File Offset: 0x000AED21
		[NullableContext(1)]
		public static IFollowTrackEndType Create(IFollowTrackEndType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFollowTrackEndType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013D7 RID: 5079
		// (get) Token: 0x060045DB RID: 17883 RVA: 0x000B0B40 File Offset: 0x000AED40
		public virtual EFollowTrackEndType Type
		{
			get
			{
				return (EFollowTrackEndType)this.Instance.Type;
			}
		}

		// Token: 0x040027C7 RID: 10183
		private IFollowTrackEndType Instance;
	}
}
