using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D4D RID: 3405
	public class IVehiclePassengerConfig
	{
		// Token: 0x06004D9B RID: 19867 RVA: 0x000C0EEF File Offset: 0x000BF0EF
		[NullableContext(1)]
		public static IVehiclePassengerConfig Create(IVehiclePassengerConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehiclePassengerConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170018BE RID: 6334
		// (get) Token: 0x06004D9C RID: 19868 RVA: 0x000C0F0E File Offset: 0x000BF10E
		public virtual int PassengerNpc
		{
			get
			{
				return this.Instance.PassengerNpc;
			}
		}

		// Token: 0x170018BF RID: 6335
		// (get) Token: 0x06004D9D RID: 19869 RVA: 0x000C0F1B File Offset: 0x000BF11B
		public virtual int Seat
		{
			get
			{
				return this.Instance.Seat;
			}
		}

		// Token: 0x04002C7A RID: 11386
		private IVehiclePassengerConfig Instance;
	}
}
