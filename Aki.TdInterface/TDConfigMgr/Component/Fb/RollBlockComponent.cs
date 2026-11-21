using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E95 RID: 3733
	public class RollBlockComponent : IComponentBase
	{
		// Token: 0x0600544F RID: 21583 RVA: 0x000CFD26 File Offset: 0x000CDF26
		public static RollBlockComponent Create(IRollBlockComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RollBlockComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B20 RID: 6944
		// (get) Token: 0x06005450 RID: 21584 RVA: 0x000CFD48 File Offset: 0x000CDF48
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

		// Token: 0x17001B21 RID: 6945
		// (get) Token: 0x06005451 RID: 21585 RVA: 0x000CFD80 File Offset: 0x000CDF80
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04003040 RID: 12352
		private IRollBlockComponent Instance;
	}
}
