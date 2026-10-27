using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200282F RID: 10287
	public class ILiftMoveTypeDefault : ILiftMoveType
	{
		// Token: 0x0600E41E RID: 58398 RVA: 0x00219796 File Offset: 0x00217996
		[NullableContext(1)]
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

		// Token: 0x17004582 RID: 17794
		// (get) Token: 0x0600E41F RID: 58399 RVA: 0x002197B5 File Offset: 0x002179B5
		public override ELiftMoveType Type
		{
			get
			{
				return (ELiftMoveType)this.Instance.Type;
			}
		}

		// Token: 0x04007E3D RID: 32317
		private ILiftMoveTypeDefault Instance;
	}
}
