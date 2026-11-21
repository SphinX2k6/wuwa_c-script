using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CDF RID: 3295
	public class DropComponent : IComponentBase
	{
		// Token: 0x06004B3C RID: 19260 RVA: 0x000BCD22 File Offset: 0x000BAF22
		public static DropComponent Create(IDropComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DropComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001579 RID: 5497
		// (get) Token: 0x06004B3D RID: 19261 RVA: 0x000BCD44 File Offset: 0x000BAF44
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

		// Token: 0x1700157A RID: 5498
		// (get) Token: 0x06004B3E RID: 19262 RVA: 0x000BCD7C File Offset: 0x000BAF7C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04002A90 RID: 10896
		private IDropComponent Instance;
	}
}
