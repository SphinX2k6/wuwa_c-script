using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B1C RID: 2844
	public class UnUseComponent : IComponentBase
	{
		// Token: 0x060040FE RID: 16638 RVA: 0x000A5E31 File Offset: 0x000A4031
		public static UnUseComponent Create(IUnUseComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new UnUseComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000EC1 RID: 3777
		// (get) Token: 0x060040FF RID: 16639 RVA: 0x000A5E50 File Offset: 0x000A4050
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

		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x06004100 RID: 16640 RVA: 0x000A5E88 File Offset: 0x000A4088
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04002407 RID: 9223
		private IUnUseComponent Instance;
	}
}
