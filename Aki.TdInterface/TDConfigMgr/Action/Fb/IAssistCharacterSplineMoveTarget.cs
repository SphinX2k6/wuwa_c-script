using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029EA RID: 10730
	public class IAssistCharacterSplineMoveTarget : ISplineMoveTargetType
	{
		// Token: 0x0600ED58 RID: 60760 RVA: 0x0022E4BB File Offset: 0x0022C6BB
		public static IAssistCharacterSplineMoveTarget Create(IAssistCharacterSplineMoveTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAssistCharacterSplineMoveTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004632 RID: 17970
		// (get) Token: 0x0600ED59 RID: 60761 RVA: 0x0022E4DA File Offset: 0x0022C6DA
		public override ESplineMoveTargetType Type
		{
			get
			{
				return (ESplineMoveTargetType)this.Instance.Type;
			}
		}

		// Token: 0x17004633 RID: 17971
		// (get) Token: 0x0600ED5A RID: 60762 RVA: 0x0022E4E7 File Offset: 0x0022C6E7
		public virtual int TrailRoleId
		{
			get
			{
				return this.Instance.TrailRoleId;
			}
		}

		// Token: 0x040082A0 RID: 33440
		private IAssistCharacterSplineMoveTarget Instance;
	}
}
