using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029E8 RID: 10728
	public class IDelayRemoveType
	{
		// Token: 0x0600ECEC RID: 60652 RVA: 0x002293E0 File Offset: 0x002275E0
		[NullableContext(1)]
		public static IDelayRemoveType Create(IDelayRemoveType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDelayRemoveType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004ADE RID: 19166
		// (get) Token: 0x0600ECED RID: 60653 RVA: 0x002293FF File Offset: 0x002275FF
		public virtual EDelayRemoveType Type
		{
			get
			{
				return (EDelayRemoveType)this.Instance.Type;
			}
		}

		// Token: 0x0400827C RID: 33404
		private IDelayRemoveType Instance;
	}
}
