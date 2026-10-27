using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DE5 RID: 3557
	[NullableContext(1)]
	[Nullable(0)]
	public class ICustomPrimitiveMapping
	{
		// Token: 0x060050A1 RID: 20641 RVA: 0x000C7107 File Offset: 0x000C5307
		public static ICustomPrimitiveMapping Create(ICustomPrimitiveMapping? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomPrimitiveMapping
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A94 RID: 6804
		// (get) Token: 0x060050A2 RID: 20642 RVA: 0x000C7126 File Offset: 0x000C5326
		public virtual string KeyPrefix
		{
			get
			{
				return this.Instance.KeyPrefix;
			}
		}

		// Token: 0x17001A95 RID: 6805
		// (get) Token: 0x060050A3 RID: 20643 RVA: 0x000C7133 File Offset: 0x000C5333
		public virtual int Index
		{
			get
			{
				return this.Instance.Index;
			}
		}

		// Token: 0x04002E4C RID: 11852
		private ICustomPrimitiveMapping Instance;
	}
}
