using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E23 RID: 3619
	public class ITransportBoxElementalRange : IElementalRangeTypeBase
	{
		// Token: 0x060051DF RID: 20959 RVA: 0x000C9CBC File Offset: 0x000C7EBC
		[NullableContext(1)]
		public static ITransportBoxElementalRange Create(ITransportBoxElementalRange? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITransportBoxElementalRange
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B56 RID: 6998
		// (get) Token: 0x060051E0 RID: 20960 RVA: 0x000C9CDB File Offset: 0x000C7EDB
		public override EElementalRangeType Type
		{
			get
			{
				return (EElementalRangeType)this.Instance.Type;
			}
		}

		// Token: 0x04002F28 RID: 12072
		private ITransportBoxElementalRange Instance;
	}
}
