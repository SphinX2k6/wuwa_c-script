using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EB7 RID: 3767
	public class ISunSpiritGearPerformToGearRelativePos : ISunSpiritGearPerformConfig
	{
		// Token: 0x060054EF RID: 21743 RVA: 0x000D0F3D File Offset: 0x000CF13D
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

		// Token: 0x17001B7C RID: 7036
		// (get) Token: 0x060054F0 RID: 21744 RVA: 0x000D0F5C File Offset: 0x000CF15C
		public override ESunSpiritGearPerformType Type
		{
			get
			{
				return (ESunSpiritGearPerformType)this.Instance.Type;
			}
		}

		// Token: 0x0400308C RID: 12428
		private ISunSpiritGearPerformToGearRelativePos Instance;
	}
}
