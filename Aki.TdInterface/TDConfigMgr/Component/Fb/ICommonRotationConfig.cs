using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A63 RID: 2659
	[NullableContext(2)]
	[Nullable(0)]
	public class ICommonRotationConfig
	{
		// Token: 0x06003D45 RID: 15685 RVA: 0x0009D6A3 File Offset: 0x0009B8A3
		[NullableContext(1)]
		public static ICommonRotationConfig Create(ICommonRotationConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonRotationConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000E3C RID: 3644
		// (get) Token: 0x06003D46 RID: 15686 RVA: 0x0009D6C2 File Offset: 0x0009B8C2
		public virtual ERotationType Type
		{
			get
			{
				return (ERotationType)this.Instance.Type;
			}
		}

		// Token: 0x17000E3D RID: 3645
		// (get) Token: 0x06003D47 RID: 15687 RVA: 0x0009D6CF File Offset: 0x0009B8CF
		public virtual float Time
		{
			get
			{
				return this.Instance.Time;
			}
		}

		// Token: 0x17000E3E RID: 3646
		// (get) Token: 0x06003D48 RID: 15688 RVA: 0x0009D6DC File Offset: 0x0009B8DC
		public virtual float? Cd
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Cd);
			}
		}

		// Token: 0x17000E3F RID: 3647
		// (get) Token: 0x06003D49 RID: 15689 RVA: 0x0009D712 File Offset: 0x0009B912
		public virtual string Curve
		{
			get
			{
				return this.Instance.Curve;
			}
		}

		// Token: 0x04002224 RID: 8740
		private ICommonRotationConfig Instance;
	}
}
