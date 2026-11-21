using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CB0 RID: 3248
	public class IFollowTrackToStart : IFollowTrackEndType
	{
		// Token: 0x06004A3B RID: 19003 RVA: 0x000BACD1 File Offset: 0x000B8ED1
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

		// Token: 0x170014D6 RID: 5334
		// (get) Token: 0x06004A3C RID: 19004 RVA: 0x000BACF0 File Offset: 0x000B8EF0
		public override EFollowTrackEndType Type
		{
			get
			{
				return (EFollowTrackEndType)this.Instance.Type;
			}
		}

		// Token: 0x04002A13 RID: 10771
		private IFollowTrackToStart Instance;
	}
}
