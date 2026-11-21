using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B02 RID: 11010
	public class ILiftMoveTypeDefault : ILiftMoveType
	{
		// Token: 0x0600F243 RID: 62019 RVA: 0x002365FA File Offset: 0x002347FA
		public static ILiftMoveTypeDefault Create(ILiftMoveTypeDefault? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiftMoveTypeDefault
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048ED RID: 18669
		// (get) Token: 0x0600F244 RID: 62020 RVA: 0x00236619 File Offset: 0x00234819
		public override ELiftMoveType Type
		{
			get
			{
				return (ELiftMoveType)this.Instance.Type;
			}
		}

		// Token: 0x040084FA RID: 34042
		private ILiftMoveTypeDefault Instance;
	}
}
