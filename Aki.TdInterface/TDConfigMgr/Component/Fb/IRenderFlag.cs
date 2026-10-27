using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CFB RID: 3323
	public class IRenderFlag
	{
		// Token: 0x06004BDF RID: 19423 RVA: 0x000BD499 File Offset: 0x000BB699
		[NullableContext(1)]
		public static IRenderFlag Create(IRenderFlag? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRenderFlag
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170017A6 RID: 6054
		// (get) Token: 0x06004BE0 RID: 19424 RVA: 0x000BD4B8 File Offset: 0x000BB6B8
		public virtual ERenderFlagType Type
		{
			get
			{
				return (ERenderFlagType)this.Instance.Type;
			}
		}

		// Token: 0x170017A7 RID: 6055
		// (get) Token: 0x06004BE1 RID: 19425 RVA: 0x000BD4C5 File Offset: 0x000BB6C5
		public virtual bool Enable
		{
			get
			{
				return this.Instance.Enable;
			}
		}

		// Token: 0x04002B5E RID: 11102
		private IRenderFlag Instance;
	}
}
