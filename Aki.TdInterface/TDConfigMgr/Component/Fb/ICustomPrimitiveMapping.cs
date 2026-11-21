using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EE1 RID: 3809
	public class ICustomPrimitiveMapping
	{
		// Token: 0x060055C8 RID: 21960 RVA: 0x000D29CF File Offset: 0x000D0BCF
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

		// Token: 0x17001C01 RID: 7169
		// (get) Token: 0x060055C9 RID: 21961 RVA: 0x000D29EE File Offset: 0x000D0BEE
		public virtual string KeyPrefix
		{
			get
			{
				return this.Instance.KeyPrefix;
			}
		}

		// Token: 0x17001C02 RID: 7170
		// (get) Token: 0x060055CA RID: 21962 RVA: 0x000D29FB File Offset: 0x000D0BFB
		public virtual int Index
		{
			get
			{
				return this.Instance.Index;
			}
		}

		// Token: 0x04003114 RID: 12564
		private ICustomPrimitiveMapping Instance;
	}
}
