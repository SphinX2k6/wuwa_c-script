using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002728 RID: 10024
	public class INpcNewSplineMoveTarget : INewSplineMoveTarget
	{
		// Token: 0x0600DF88 RID: 57224 RVA: 0x00211F83 File Offset: 0x00210183
		[NullableContext(1)]
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

		// Token: 0x170042FA RID: 17146
		// (get) Token: 0x0600DF89 RID: 57225 RVA: 0x00211FA2 File Offset: 0x002101A2
		public override ENewSplineMoveTargetType Type
		{
			get
			{
				return (ENewSplineMoveTargetType)this.Instance.Type;
			}
		}

		// Token: 0x170042FB RID: 17147
		// (get) Token: 0x0600DF8A RID: 57226 RVA: 0x00211FAF File Offset: 0x002101AF
		public virtual int NpcId
		{
			get
			{
				return this.Instance.NpcId;
			}
		}

		// Token: 0x04007C10 RID: 31760
		private INpcNewSplineMoveTarget Instance;
	}
}
