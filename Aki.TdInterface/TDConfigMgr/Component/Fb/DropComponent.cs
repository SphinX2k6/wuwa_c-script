using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C0F RID: 3087
	public class DropComponent : IComponentBase
	{
		// Token: 0x060046D9 RID: 18137 RVA: 0x000B2B56 File Offset: 0x000B0D56
		[NullableContext(1)]
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

		// Token: 0x17001478 RID: 5240
		// (get) Token: 0x060046DA RID: 18138 RVA: 0x000B2B78 File Offset: 0x000B0D78
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

		// Token: 0x17001479 RID: 5241
		// (get) Token: 0x060046DB RID: 18139 RVA: 0x000B2BB0 File Offset: 0x000B0DB0
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04002844 RID: 10308
		private IDropComponent Instance;
	}
}
