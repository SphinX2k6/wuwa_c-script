using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C10 RID: 3088
	public class VisionItemComponent : IComponentBase
	{
		// Token: 0x060046DD RID: 18141 RVA: 0x000B2BCE File Offset: 0x000B0DCE
		[NullableContext(1)]
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

		// Token: 0x1700147A RID: 5242
		// (get) Token: 0x060046DE RID: 18142 RVA: 0x000B2BF0 File Offset: 0x000B0DF0
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

		// Token: 0x1700147B RID: 5243
		// (get) Token: 0x060046DF RID: 18143 RVA: 0x000B2C28 File Offset: 0x000B0E28
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04002845 RID: 10309
		private IVisionItemComponent Instance;
	}
}
