using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002701 RID: 9985
	public class IAssistCharacterSplineMove : IAssistCharacterMoveType
	{
		// Token: 0x0600DEE1 RID: 57057 RVA: 0x00210C86 File Offset: 0x0020EE86
		[NullableContext(1)]
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

		// Token: 0x170042A1 RID: 17057
		// (get) Token: 0x0600DEE2 RID: 57058 RVA: 0x00210CA5 File Offset: 0x0020EEA5
		public override EAssistCharacterMoveType Type
		{
			get
			{
				return (EAssistCharacterMoveType)this.Instance.Type;
			}
		}

		// Token: 0x170042A2 RID: 17058
		// (get) Token: 0x0600DEE3 RID: 57059 RVA: 0x00210CB2 File Offset: 0x0020EEB2
		public virtual int SplineId
		{
			get
			{
				return this.Instance.SplineId;
			}
		}

		// Token: 0x04007BB3 RID: 31667
		private IAssistCharacterSplineMove Instance;
	}
}
