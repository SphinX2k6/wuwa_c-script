using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002832 RID: 10290
	public class ILiftMoveTypeCircular : ILiftMoveType
	{
		// Token: 0x0600E42D RID: 58413 RVA: 0x00219880 File Offset: 0x00217A80
		[NullableContext(1)]
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

		// Token: 0x1700458B RID: 17803
		// (get) Token: 0x0600E42E RID: 58414 RVA: 0x0021989F File Offset: 0x00217A9F
		public override ELiftMoveType Type
		{
			get
			{
				return (ELiftMoveType)this.Instance.Type;
			}
		}

		// Token: 0x04007E40 RID: 32320
		private ILiftMoveTypeCircular Instance;
	}
}
