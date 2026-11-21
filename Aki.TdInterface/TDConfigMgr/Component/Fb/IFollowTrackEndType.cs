using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CAF RID: 3247
	public class IFollowTrackEndType
	{
		// Token: 0x06004A38 RID: 19000 RVA: 0x000BAC9D File Offset: 0x000B8E9D
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

		// Token: 0x170014D5 RID: 5333
		// (get) Token: 0x06004A39 RID: 19001 RVA: 0x000BACBC File Offset: 0x000B8EBC
		public virtual EFollowTrackEndType Type
		{
			get
			{
				return (EFollowTrackEndType)this.Instance.Type;
			}
		}

		// Token: 0x04002A12 RID: 10770
		private IFollowTrackEndType Instance;
	}
}
