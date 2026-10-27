using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C5B RID: 3163
	public class IVehicleGenerationType
	{
		// Token: 0x06004873 RID: 18547 RVA: 0x000B6097 File Offset: 0x000B4297
		[NullableContext(1)]
		public static IVehicleGenerationType Create(IVehicleGenerationType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleGenerationType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700157A RID: 5498
		// (get) Token: 0x06004874 RID: 18548 RVA: 0x000B60B6 File Offset: 0x000B42B6
		public virtual EVehicleGenerationType Type
		{
			get
			{
				return (EVehicleGenerationType)this.Instance.Type;
			}
		}

		// Token: 0x1700157B RID: 5499
		// (get) Token: 0x06004875 RID: 18549 RVA: 0x000B60C3 File Offset: 0x000B42C3
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x1700157C RID: 5500
		// (get) Token: 0x06004876 RID: 18550 RVA: 0x000B60D0 File Offset: 0x000B42D0
		public virtual int Weight
		{
			get
			{
				return this.Instance.Weight;
			}
		}

		// Token: 0x04002946 RID: 10566
		private IVehicleGenerationType Instance;
	}
}
