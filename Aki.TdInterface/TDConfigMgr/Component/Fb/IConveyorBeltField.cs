using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BD9 RID: 3033
	public class IConveyorBeltField
	{
		// Token: 0x060045BF RID: 17855 RVA: 0x000B0863 File Offset: 0x000AEA63
		[NullableContext(1)]
		public static IConveyorBeltField Create(IConveyorBeltField? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IConveyorBeltField
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013CA RID: 5066
		// (get) Token: 0x060045C0 RID: 17856 RVA: 0x000B0882 File Offset: 0x000AEA82
		public virtual EConveyorBeltFieldType Type
		{
			get
			{
				return (EConveyorBeltFieldType)this.Instance.Type;
			}
		}

		// Token: 0x040027B8 RID: 10168
		private IConveyorBeltField Instance;
	}
}
