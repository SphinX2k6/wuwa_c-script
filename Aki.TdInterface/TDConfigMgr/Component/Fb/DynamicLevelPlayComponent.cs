using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B71 RID: 2929
	public class DynamicLevelPlayComponent : IComponentBase
	{
		// Token: 0x0600437D RID: 17277 RVA: 0x000AC0FF File Offset: 0x000AA2FF
		[NullableContext(1)]
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

		// Token: 0x17001258 RID: 4696
		// (get) Token: 0x0600437E RID: 17278 RVA: 0x000AC120 File Offset: 0x000AA320
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

		// Token: 0x17001259 RID: 4697
		// (get) Token: 0x0600437F RID: 17279 RVA: 0x000AC158 File Offset: 0x000AA358
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700125A RID: 4698
		// (get) Token: 0x06004380 RID: 17280 RVA: 0x000AC16E File Offset: 0x000AA36E
		public virtual int DynamicLevelPlayId
		{
			get
			{
				return this.Instance.DynamicLevelPlayId;
			}
		}

		// Token: 0x04002618 RID: 9752
		private IDynamicLevelPlayComponent Instance;
	}
}
