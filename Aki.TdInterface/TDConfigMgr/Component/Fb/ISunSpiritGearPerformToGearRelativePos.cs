using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DBB RID: 3515
	public class ISunSpiritGearPerformToGearRelativePos : ISunSpiritGearPerformConfig
	{
		// Token: 0x06004FCA RID: 20426 RVA: 0x000C56ED File Offset: 0x000C38ED
		[NullableContext(1)]
		public static ISunSpiritGearPerformToGearRelativePos Create(ISunSpiritGearPerformToGearRelativePos? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISunSpiritGearPerformToGearRelativePos
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A11 RID: 6673
		// (get) Token: 0x06004FCB RID: 20427 RVA: 0x000C570C File Offset: 0x000C390C
		public override ESunSpiritGearPerformType Type
		{
			get
			{
				return (ESunSpiritGearPerformType)this.Instance.Type;
			}
		}

		// Token: 0x04002DC6 RID: 11718
		private ISunSpiritGearPerformToGearRelativePos Instance;
	}
}
