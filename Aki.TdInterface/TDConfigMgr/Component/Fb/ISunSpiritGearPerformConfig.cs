using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DBA RID: 3514
	public class ISunSpiritGearPerformConfig
	{
		// Token: 0x06004FC7 RID: 20423 RVA: 0x000C56B9 File Offset: 0x000C38B9
		[NullableContext(1)]
		public static ISunSpiritGearPerformConfig Create(ISunSpiritGearPerformConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISunSpiritGearPerformConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A10 RID: 6672
		// (get) Token: 0x06004FC8 RID: 20424 RVA: 0x000C56D8 File Offset: 0x000C38D8
		public virtual ESunSpiritGearPerformType Type
		{
			get
			{
				return (ESunSpiritGearPerformType)this.Instance.Type;
			}
		}

		// Token: 0x04002DC5 RID: 11717
		private ISunSpiritGearPerformConfig Instance;
	}
}
