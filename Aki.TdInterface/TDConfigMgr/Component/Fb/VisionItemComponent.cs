using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CE0 RID: 3296
	public class VisionItemComponent : IComponentBase
	{
		// Token: 0x06004B40 RID: 19264 RVA: 0x000BCD9A File Offset: 0x000BAF9A
		public static VisionItemComponent Create(IVisionItemComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new VisionItemComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700157B RID: 5499
		// (get) Token: 0x06004B41 RID: 19265 RVA: 0x000BCDBC File Offset: 0x000BAFBC
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

		// Token: 0x1700157C RID: 5500
		// (get) Token: 0x06004B42 RID: 19266 RVA: 0x000BCDF4 File Offset: 0x000BAFF4
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04002A91 RID: 10897
		private IVisionItemComponent Instance;
	}
}
