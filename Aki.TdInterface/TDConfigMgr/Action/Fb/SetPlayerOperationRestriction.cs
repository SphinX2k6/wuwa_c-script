using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200292F RID: 10543
	public class SetPlayerOperationRestriction : ActionParams
	{
		// Token: 0x0600E9EE RID: 59886 RVA: 0x002245EB File Offset: 0x002227EB
		[NullableContext(1)]
		public static SetPlayerOperationRestriction Create(ISetPlayerOperationRestriction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetPlayerOperationRestriction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004952 RID: 18770
		// (get) Token: 0x0600E9EF RID: 59887 RVA: 0x0022460A File Offset: 0x0022280A
		public virtual EPlayerOperationType Type
		{
			get
			{
				return (EPlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x04008109 RID: 33033
		private ISetPlayerOperationRestriction Instance;
	}
}
