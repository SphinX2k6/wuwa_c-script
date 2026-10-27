using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BDC RID: 3036
	public class IConveyorBeltMove
	{
		// Token: 0x060045C9 RID: 17865 RVA: 0x000B0933 File Offset: 0x000AEB33
		[NullableContext(1)]
		public static IConveyorBeltMove Create(IConveyorBeltMove? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IConveyorBeltMove
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013CE RID: 5070
		// (get) Token: 0x060045CA RID: 17866 RVA: 0x000B0952 File Offset: 0x000AEB52
		public virtual EConveyorBeltMoveType Type
		{
			get
			{
				return (EConveyorBeltMoveType)this.Instance.Type;
			}
		}

		// Token: 0x040027BD RID: 10173
		private IConveyorBeltMove Instance;
	}
}
