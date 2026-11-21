using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D35 RID: 3381
	public class IVehicleGenerateByVehicleEntityTemplate : IVehicleGenerationType
	{
		// Token: 0x06004CFD RID: 19709 RVA: 0x000C06D9 File Offset: 0x000BE8D9
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

		// Token: 0x1700168E RID: 5774
		// (get) Token: 0x06004CFE RID: 19710 RVA: 0x000C06F8 File Offset: 0x000BE8F8
		public override EVehicleGenerationType Type
		{
			get
			{
				return (EVehicleGenerationType)this.Instance.Type;
			}
		}

		// Token: 0x1700168F RID: 5775
		// (get) Token: 0x06004CFF RID: 19711 RVA: 0x000C0705 File Offset: 0x000BE905
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17001690 RID: 5776
		// (get) Token: 0x06004D00 RID: 19712 RVA: 0x000C0712 File Offset: 0x000BE912
		public override int Weight
		{
			get
			{
				return this.Instance.Weight;
			}
		}

		// Token: 0x04002BA8 RID: 11176
		private IVehicleGenerateByVehicleEntityTemplate Instance;
	}
}
