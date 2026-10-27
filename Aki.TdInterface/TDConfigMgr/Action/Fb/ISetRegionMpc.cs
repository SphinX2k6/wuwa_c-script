using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002969 RID: 10601
	public class ISetRegionMpc : SetRegionConfig
	{
		// Token: 0x0600EAF5 RID: 60149 RVA: 0x002263D5 File Offset: 0x002245D5
		[NullableContext(1)]
		public static ISetRegionMpc Create(ISetRegionMpc? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetRegionMpc
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049E5 RID: 18917
		// (get) Token: 0x0600EAF6 RID: 60150 RVA: 0x002263F4 File Offset: 0x002245F4
		public override ERegionConfigType Type
		{
			get
			{
				return (ERegionConfigType)this.Instance.Type;
			}
		}

		// Token: 0x170049E6 RID: 18918
		// (get) Token: 0x0600EAF7 RID: 60151 RVA: 0x00226401 File Offset: 0x00224601
		public virtual int RegionMpcId
		{
			get
			{
				return this.Instance.RegionMpcId;
			}
		}

		// Token: 0x04008173 RID: 33139
		private ISetRegionMpc Instance;
	}
}
