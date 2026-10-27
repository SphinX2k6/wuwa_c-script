using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C5C RID: 3164
	public class IVehicleGenerateByVehicleEntityTemplate : IVehicleGenerationType
	{
		// Token: 0x06004878 RID: 18552 RVA: 0x000B60E5 File Offset: 0x000B42E5
		[NullableContext(1)]
		public static IVehicleGenerateByVehicleEntityTemplate Create(IVehicleGenerateByVehicleEntityTemplate? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleGenerateByVehicleEntityTemplate
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700157D RID: 5501
		// (get) Token: 0x06004879 RID: 18553 RVA: 0x000B6104 File Offset: 0x000B4304
		public override EVehicleGenerationType Type
		{
			get
			{
				return (EVehicleGenerationType)this.Instance.Type;
			}
		}

		// Token: 0x1700157E RID: 5502
		// (get) Token: 0x0600487A RID: 18554 RVA: 0x000B6111 File Offset: 0x000B4311
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x1700157F RID: 5503
		// (get) Token: 0x0600487B RID: 18555 RVA: 0x000B611E File Offset: 0x000B431E
		public override int Weight
		{
			get
			{
				return this.Instance.Weight;
			}
		}

		// Token: 0x04002947 RID: 10567
		private IVehicleGenerateByVehicleEntityTemplate Instance;
	}
}
