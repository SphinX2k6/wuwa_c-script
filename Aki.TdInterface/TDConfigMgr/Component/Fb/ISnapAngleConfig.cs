using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DC5 RID: 3525
	public class ISnapAngleConfig
	{
		// Token: 0x06004FFC RID: 20476 RVA: 0x000C5C6A File Offset: 0x000C3E6A
		[NullableContext(1)]
		public static ISnapAngleConfig Create(ISnapAngleConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISnapAngleConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A2F RID: 6703
		// (get) Token: 0x06004FFD RID: 20477 RVA: 0x000C5C89 File Offset: 0x000C3E89
		public virtual float Angle
		{
			get
			{
				return this.Instance.Angle;
			}
		}

		// Token: 0x17001A30 RID: 6704
		// (get) Token: 0x06004FFE RID: 20478 RVA: 0x000C5C96 File Offset: 0x000C3E96
		public virtual float Range
		{
			get
			{
				return this.Instance.Range;
			}
		}

		// Token: 0x04002DDC RID: 11740
		private ISnapAngleConfig Instance;
	}
}
