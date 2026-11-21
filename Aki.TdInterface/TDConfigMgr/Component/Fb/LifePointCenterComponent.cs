using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E7E RID: 3710
	public class LifePointCenterComponent : IComponentBase
	{
		// Token: 0x060053D2 RID: 21458 RVA: 0x000CE9F5 File Offset: 0x000CCBF5
		public static LifePointCenterComponent Create(ILifePointCenterComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new LifePointCenterComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001AD1 RID: 6865
		// (get) Token: 0x060053D3 RID: 21459 RVA: 0x000CEA14 File Offset: 0x000CCC14
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001AD2 RID: 6866
		// (get) Token: 0x060053D4 RID: 21460 RVA: 0x000CEA4C File Offset: 0x000CCC4C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04002FEF RID: 12271
		private ILifePointCenterComponent Instance;
	}
}
