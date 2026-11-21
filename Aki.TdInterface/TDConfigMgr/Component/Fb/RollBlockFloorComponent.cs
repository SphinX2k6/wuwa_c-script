using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E96 RID: 3734
	public class RollBlockFloorComponent : IComponentBase
	{
		// Token: 0x06005453 RID: 21587 RVA: 0x000CFD9E File Offset: 0x000CDF9E
		public static RollBlockFloorComponent Create(IRollBlockFloorComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RollBlockFloorComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B22 RID: 6946
		// (get) Token: 0x06005454 RID: 21588 RVA: 0x000CFDC0 File Offset: 0x000CDFC0
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

		// Token: 0x17001B23 RID: 6947
		// (get) Token: 0x06005455 RID: 21589 RVA: 0x000CFDF8 File Offset: 0x000CDFF8
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04003041 RID: 12353
		private IRollBlockFloorComponent Instance;
	}
}
