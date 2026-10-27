using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002881 RID: 10369
	public class ICloseRideFlyingCar : ICloseUiGame
	{
		// Token: 0x0600E5B2 RID: 58802 RVA: 0x0021C314 File Offset: 0x0021A514
		[NullableContext(1)]
		public static ICloseRideFlyingCar Create(ICloseRideFlyingCar? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseRideFlyingCar
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004672 RID: 18034
		// (get) Token: 0x0600E5B3 RID: 58803 RVA: 0x0021C333 File Offset: 0x0021A533
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x04007F03 RID: 32515
		private ICloseRideFlyingCar Instance;
	}
}
