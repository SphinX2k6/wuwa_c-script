using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C11 RID: 3089
	public class AdviseItemComponent : IComponentBase
	{
		// Token: 0x060046E1 RID: 18145 RVA: 0x000B2C46 File Offset: 0x000B0E46
		[NullableContext(1)]
		public static AdviseItemComponent Create(IAdviseItemComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AdviseItemComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700147C RID: 5244
		// (get) Token: 0x060046E2 RID: 18146 RVA: 0x000B2C68 File Offset: 0x000B0E68
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

		// Token: 0x1700147D RID: 5245
		// (get) Token: 0x060046E3 RID: 18147 RVA: 0x000B2CA0 File Offset: 0x000B0EA0
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04002846 RID: 10310
		private IAdviseItemComponent Instance;
	}
}
