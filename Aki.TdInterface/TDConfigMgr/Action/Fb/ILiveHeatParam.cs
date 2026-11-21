using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E23 RID: 11811
	public class ILiveHeatParam : ILiveParamConfig
	{
		// Token: 0x06010082 RID: 65666 RVA: 0x0024E64C File Offset: 0x0024C84C
		public static ILiveHeatParam Create(ILiveHeatParam? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveHeatParam
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050EA RID: 20714
		// (get) Token: 0x06010083 RID: 65667 RVA: 0x0024E66B File Offset: 0x0024C86B
		public override ELiveParamType Type
		{
			get
			{
				return (ELiveParamType)this.Instance.Type;
			}
		}

		// Token: 0x170050EB RID: 20715
		// (get) Token: 0x06010084 RID: 65668 RVA: 0x0024E678 File Offset: 0x0024C878
		public virtual int MinHeat
		{
			get
			{
				return this.Instance.MinHeat;
			}
		}

		// Token: 0x170050EC RID: 20716
		// (get) Token: 0x06010085 RID: 65669 RVA: 0x0024E685 File Offset: 0x0024C885
		public virtual int MaxHeat
		{
			get
			{
				return this.Instance.MaxHeat;
			}
		}

		// Token: 0x04008BF1 RID: 35825
		private ILiveHeatParam Instance;
	}
}
