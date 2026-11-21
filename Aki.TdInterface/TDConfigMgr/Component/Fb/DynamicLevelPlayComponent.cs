using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C3F RID: 3135
	public class DynamicLevelPlayComponent : IComponentBase
	{
		// Token: 0x060047D6 RID: 18390 RVA: 0x000B61C3 File Offset: 0x000B43C3
		public static DynamicLevelPlayComponent Create(IDynamicLevelPlayComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DynamicLevelPlayComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001353 RID: 4947
		// (get) Token: 0x060047D7 RID: 18391 RVA: 0x000B61E4 File Offset: 0x000B43E4
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

		// Token: 0x17001354 RID: 4948
		// (get) Token: 0x060047D8 RID: 18392 RVA: 0x000B621C File Offset: 0x000B441C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001355 RID: 4949
		// (get) Token: 0x060047D9 RID: 18393 RVA: 0x000B6232 File Offset: 0x000B4432
		public virtual int DynamicLevelPlayId
		{
			get
			{
				return this.Instance.DynamicLevelPlayId;
			}
		}

		// Token: 0x04002860 RID: 10336
		private IDynamicLevelPlayComponent Instance;
	}
}
