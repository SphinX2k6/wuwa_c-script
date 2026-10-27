using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002607 RID: 9735
	public class IInteractType
	{
		// Token: 0x0600DAA5 RID: 55973 RVA: 0x002093AD File Offset: 0x002075AD
		[NullableContext(1)]
		public static IInteractType Create(IInteractType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004059 RID: 16473
		// (get) Token: 0x0600DAA6 RID: 55974 RVA: 0x002093CC File Offset: 0x002075CC
		public virtual EInteractOption Type
		{
			get
			{
				return (EInteractOption)this.Instance.Type;
			}
		}

		// Token: 0x04007973 RID: 31091
		private IInteractType Instance;
	}
}
