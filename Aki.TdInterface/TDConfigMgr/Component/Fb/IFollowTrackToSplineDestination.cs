using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CB2 RID: 3250
	public class IFollowTrackToSplineDestination : IFollowTrackEndType
	{
		// Token: 0x06004A43 RID: 19011 RVA: 0x000BAD7A File Offset: 0x000B8F7A
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

		// Token: 0x170014DA RID: 5338
		// (get) Token: 0x06004A44 RID: 19012 RVA: 0x000BAD99 File Offset: 0x000B8F99
		public override EFollowTrackEndType Type
		{
			get
			{
				return (EFollowTrackEndType)this.Instance.Type;
			}
		}

		// Token: 0x170014DB RID: 5339
		// (get) Token: 0x06004A45 RID: 19013 RVA: 0x000BADA6 File Offset: 0x000B8FA6
		public virtual string ChangeSelfState
		{
			get
			{
				return this.Instance.ChangeSelfState;
			}
		}

		// Token: 0x04002A17 RID: 10775
		private IFollowTrackToSplineDestination Instance;
	}
}
