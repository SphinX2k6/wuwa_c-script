using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D82 RID: 3458
	public class LifePointCenterComponent : IComponentBase
	{
		// Token: 0x06004EAD RID: 20141 RVA: 0x000C31A5 File Offset: 0x000C13A5
		[NullableContext(1)]
		public static LifePointCenterComponent Create(ILifePointCenterComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new LifePointCenterComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001966 RID: 6502
		// (get) Token: 0x06004EAE RID: 20142 RVA: 0x000C31C4 File Offset: 0x000C13C4
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

		// Token: 0x17001967 RID: 6503
		// (get) Token: 0x06004EAF RID: 20143 RVA: 0x000C31FC File Offset: 0x000C13FC
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04002D29 RID: 11561
		private ILifePointCenterComponent Instance;
	}
}
