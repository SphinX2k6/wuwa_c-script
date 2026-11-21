using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B2C RID: 2860
	public class ICommonRotationConfig
	{
		// Token: 0x06004165 RID: 16741 RVA: 0x000A6B1B File Offset: 0x000A4D1B
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

		// Token: 0x17000F08 RID: 3848
		// (get) Token: 0x06004166 RID: 16742 RVA: 0x000A6B3A File Offset: 0x000A4D3A
		public virtual ERotationType Type
		{
			get
			{
				return (ERotationType)this.Instance.Type;
			}
		}

		// Token: 0x17000F09 RID: 3849
		// (get) Token: 0x06004167 RID: 16743 RVA: 0x000A6B47 File Offset: 0x000A4D47
		public virtual float Time
		{
			get
			{
				return this.Instance.Time;
			}
		}

		// Token: 0x17000F0A RID: 3850
		// (get) Token: 0x06004168 RID: 16744 RVA: 0x000A6B54 File Offset: 0x000A4D54
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

		// Token: 0x17000F0B RID: 3851
		// (get) Token: 0x06004169 RID: 16745 RVA: 0x000A6B8A File Offset: 0x000A4D8A
		[Nullable(2)]
		public virtual string Curve
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.Curve;
			}
		}

		// Token: 0x0400243B RID: 9275
		private ICommonRotationConfig Instance;
	}
}
