using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A29 RID: 10793
	public class ISheriffStartTrack : ICommonTipType
	{
		// Token: 0x0600EE85 RID: 61061 RVA: 0x0022FCCD File Offset: 0x0022DECD
		public static ISheriffStartTrack Create(ISheriffStartTrack? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISheriffStartTrack
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046E1 RID: 18145
		// (get) Token: 0x0600EE86 RID: 61062 RVA: 0x0022FCEC File Offset: 0x0022DEEC
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x170046E2 RID: 18146
		// (get) Token: 0x0600EE87 RID: 61063 RVA: 0x0022FCF9 File Offset: 0x0022DEF9
		public virtual int AnomalyId
		{
			get
			{
				return this.Instance.AnomalyId;
			}
		}

		// Token: 0x04008309 RID: 33545
		private ISheriffStartTrack Instance;
	}
}
