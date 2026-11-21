using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029C7 RID: 10695
	public class IAssistCharacterSplineMove : IAssistCharacterMoveType
	{
		// Token: 0x0600ECC9 RID: 60617 RVA: 0x0022D5EE File Offset: 0x0022B7EE
		public static IAssistCharacterSplineMove Create(IAssistCharacterSplineMove? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAssistCharacterSplineMove
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045E9 RID: 17897
		// (get) Token: 0x0600ECCA RID: 60618 RVA: 0x0022D60D File Offset: 0x0022B80D
		public override EAssistCharacterMoveType Type
		{
			get
			{
				return (EAssistCharacterMoveType)this.Instance.Type;
			}
		}

		// Token: 0x170045EA RID: 17898
		// (get) Token: 0x0600ECCB RID: 60619 RVA: 0x0022D61A File Offset: 0x0022B81A
		public virtual int SplineId
		{
			get
			{
				return this.Instance.SplineId;
			}
		}

		// Token: 0x04008257 RID: 33367
		private IAssistCharacterSplineMove Instance;
	}
}
