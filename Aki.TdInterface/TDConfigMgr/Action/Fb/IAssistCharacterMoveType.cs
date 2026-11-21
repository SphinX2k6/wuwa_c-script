using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029C5 RID: 10693
	public class IAssistCharacterMoveType
	{
		// Token: 0x0600ECC1 RID: 60609 RVA: 0x0022D545 File Offset: 0x0022B745
		public static IAssistCharacterMoveType Create(IAssistCharacterMoveType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAssistCharacterMoveType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045E5 RID: 17893
		// (get) Token: 0x0600ECC2 RID: 60610 RVA: 0x0022D564 File Offset: 0x0022B764
		public virtual EAssistCharacterMoveType Type
		{
			get
			{
				return (EAssistCharacterMoveType)this.Instance.Type;
			}
		}

		// Token: 0x04008253 RID: 33363
		private IAssistCharacterMoveType Instance;
	}
}
