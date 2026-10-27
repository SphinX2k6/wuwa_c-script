using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C5D RID: 3165
	public class IVehicleGenerateByVehicleTeamTemplate : IVehicleGenerationType
	{
		// Token: 0x0600487D RID: 18557 RVA: 0x000B6133 File Offset: 0x000B4333
		[NullableContext(1)]
		public static IVehicleGenerateByVehicleTeamTemplate Create(IVehicleGenerateByVehicleTeamTemplate? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleGenerateByVehicleTeamTemplate
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001580 RID: 5504
		// (get) Token: 0x0600487E RID: 18558 RVA: 0x000B6152 File Offset: 0x000B4352
		public override EVehicleGenerationType Type
		{
			get
			{
				return (EVehicleGenerationType)this.Instance.Type;
			}
		}

		// Token: 0x17001581 RID: 5505
		// (get) Token: 0x0600487F RID: 18559 RVA: 0x000B615F File Offset: 0x000B435F
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17001582 RID: 5506
		// (get) Token: 0x06004880 RID: 18560 RVA: 0x000B616C File Offset: 0x000B436C
		public override int Weight
		{
			get
			{
				return this.Instance.Weight;
			}
		}

		// Token: 0x04002948 RID: 10568
		private IVehicleGenerateByVehicleTeamTemplate Instance;
	}
}
