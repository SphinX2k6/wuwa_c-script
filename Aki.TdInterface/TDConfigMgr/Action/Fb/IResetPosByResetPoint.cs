using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AE7 RID: 10983
	public class IResetPosByResetPoint : IResetPosType
	{
		// Token: 0x0600F0B9 RID: 61625 RVA: 0x0022F10D File Offset: 0x0022D30D
		[NullableContext(1)]
		public static IResetPosByResetPoint Create(IResetPosByResetPoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IResetPosByResetPoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CAD RID: 19629
		// (get) Token: 0x0600F0BA RID: 61626 RVA: 0x0022F12C File Offset: 0x0022D32C
		public override EResetPosType Type
		{
			get
			{
				return (EResetPosType)this.Instance.Type;
			}
		}

		// Token: 0x0400846F RID: 33903
		private IResetPosByResetPoint Instance;
	}
}
