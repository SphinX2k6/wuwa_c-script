using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026FF RID: 9983
	public class IAssistCharacterMoveType
	{
		// Token: 0x0600DED9 RID: 57049 RVA: 0x00210BDD File Offset: 0x0020EDDD
		[NullableContext(1)]
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

		// Token: 0x1700429D RID: 17053
		// (get) Token: 0x0600DEDA RID: 57050 RVA: 0x00210BFC File Offset: 0x0020EDFC
		public virtual EAssistCharacterMoveType Type
		{
			get
			{
				return (EAssistCharacterMoveType)this.Instance.Type;
			}
		}

		// Token: 0x04007BAF RID: 31663
		private IAssistCharacterMoveType Instance;
	}
}
