using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C9C RID: 3228
	public class LevitateMagnetComponent : IComponentBase
	{
		// Token: 0x060049CF RID: 18895 RVA: 0x000B8FE2 File Offset: 0x000B71E2
		[NullableContext(1)]
		public static LevitateMagnetComponent Create(ILevitateMagnetComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new LevitateMagnetComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001654 RID: 5716
		// (get) Token: 0x060049D0 RID: 18896 RVA: 0x000B9004 File Offset: 0x000B7204
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

		// Token: 0x17001655 RID: 5717
		// (get) Token: 0x060049D1 RID: 18897 RVA: 0x000B903C File Offset: 0x000B723C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001656 RID: 5718
		// (get) Token: 0x060049D2 RID: 18898 RVA: 0x000B9052 File Offset: 0x000B7252
		public virtual int MoveSpeed
		{
			get
			{
				return this.Instance.MoveSpeed;
			}
		}

		// Token: 0x17001657 RID: 5719
		// (get) Token: 0x060049D3 RID: 18899 RVA: 0x000B9060 File Offset: 0x000B7260
		public virtual int? Test
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.Test);
			}
		}

		// Token: 0x04002A29 RID: 10793
		private ILevitateMagnetComponent Instance;
	}
}
