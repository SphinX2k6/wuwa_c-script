using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B05 RID: 11013
	public class ILiftMoveTypeCircular : ILiftMoveType
	{
		// Token: 0x0600F252 RID: 62034 RVA: 0x002366E4 File Offset: 0x002348E4
		public static ILiftMoveTypeCircular Create(ILiftMoveTypeCircular? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiftMoveTypeCircular
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048F6 RID: 18678
		// (get) Token: 0x0600F253 RID: 62035 RVA: 0x00236703 File Offset: 0x00234903
		public override ELiftMoveType Type
		{
			get
			{
				return (ELiftMoveType)this.Instance.Type;
			}
		}

		// Token: 0x040084FD RID: 34045
		private ILiftMoveTypeCircular Instance;
	}
}
