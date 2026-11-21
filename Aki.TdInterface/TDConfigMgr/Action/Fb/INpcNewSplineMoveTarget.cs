using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029F2 RID: 10738
	public class INpcNewSplineMoveTarget : INewSplineMoveTarget
	{
		// Token: 0x0600ED80 RID: 60800 RVA: 0x0022EA13 File Offset: 0x0022CC13
		public static INpcNewSplineMoveTarget Create(INpcNewSplineMoveTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcNewSplineMoveTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700464A RID: 17994
		// (get) Token: 0x0600ED81 RID: 60801 RVA: 0x0022EA32 File Offset: 0x0022CC32
		public override ENewSplineMoveTargetType Type
		{
			get
			{
				return (ENewSplineMoveTargetType)this.Instance.Type;
			}
		}

		// Token: 0x1700464B RID: 17995
		// (get) Token: 0x0600ED82 RID: 60802 RVA: 0x0022EA3F File Offset: 0x0022CC3F
		public virtual int NpcId
		{
			get
			{
				return this.Instance.NpcId;
			}
		}

		// Token: 0x040082BA RID: 33466
		private INpcNewSplineMoveTarget Instance;
	}
}
