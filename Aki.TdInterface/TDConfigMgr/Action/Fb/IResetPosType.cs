using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AE5 RID: 10981
	public class IResetPosType
	{
		// Token: 0x0600F0B2 RID: 61618 RVA: 0x0022F098 File Offset: 0x0022D298
		[NullableContext(1)]
		public static IResetPosType Create(IResetPosType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IResetPosType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CAA RID: 19626
		// (get) Token: 0x0600F0B3 RID: 61619 RVA: 0x0022F0B7 File Offset: 0x0022D2B7
		public virtual EResetPosType Type
		{
			get
			{
				return (EResetPosType)this.Instance.Type;
			}
		}

		// Token: 0x0400846D RID: 33901
		private IResetPosType Instance;
	}
}
