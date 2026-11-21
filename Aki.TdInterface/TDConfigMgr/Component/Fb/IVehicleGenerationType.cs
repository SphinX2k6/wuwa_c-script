using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D34 RID: 3380
	public class IVehicleGenerationType
	{
		// Token: 0x06004CF8 RID: 19704 RVA: 0x000C068B File Offset: 0x000BE88B
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

		// Token: 0x1700168B RID: 5771
		// (get) Token: 0x06004CF9 RID: 19705 RVA: 0x000C06AA File Offset: 0x000BE8AA
		public virtual EVehicleGenerationType Type
		{
			get
			{
				return (EVehicleGenerationType)this.Instance.Type;
			}
		}

		// Token: 0x1700168C RID: 5772
		// (get) Token: 0x06004CFA RID: 19706 RVA: 0x000C06B7 File Offset: 0x000BE8B7
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x1700168D RID: 5773
		// (get) Token: 0x06004CFB RID: 19707 RVA: 0x000C06C4 File Offset: 0x000BE8C4
		public virtual int Weight
		{
			get
			{
				return this.Instance.Weight;
			}
		}

		// Token: 0x04002BA7 RID: 11175
		private IVehicleGenerationType Instance;
	}
}
