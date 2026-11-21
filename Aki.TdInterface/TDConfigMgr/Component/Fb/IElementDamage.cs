using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C38 RID: 3128
	public class IElementDamage
	{
		// Token: 0x060047A0 RID: 18336 RVA: 0x000B591A File Offset: 0x000B3B1A
		public static IElementDamage Create(IElementDamage? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IElementDamage
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700132B RID: 4907
		// (get) Token: 0x060047A1 RID: 18337 RVA: 0x000B5939 File Offset: 0x000B3B39
		public virtual int DefaultValue
		{
			get
			{
				return this.Instance.DefaultValue;
			}
		}

		// Token: 0x1700132C RID: 4908
		// (get) Token: 0x060047A2 RID: 18338 RVA: 0x000B5948 File Offset: 0x000B3B48
		public virtual int? Physics
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.Physics);
			}
		}

		// Token: 0x1700132D RID: 4909
		// (get) Token: 0x060047A3 RID: 18339 RVA: 0x000B5980 File Offset: 0x000B3B80
		public virtual int? Ice
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.Ice);
			}
		}

		// Token: 0x1700132E RID: 4910
		// (get) Token: 0x060047A4 RID: 18340 RVA: 0x000B59B8 File Offset: 0x000B3BB8
		public virtual int? Fire
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new int?(this.Instance.Fire);
			}
		}

		// Token: 0x1700132F RID: 4911
		// (get) Token: 0x060047A5 RID: 18341 RVA: 0x000B59F0 File Offset: 0x000B3BF0
		public virtual int? Thunder
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new int?(this.Instance.Thunder);
			}
		}

		// Token: 0x17001330 RID: 4912
		// (get) Token: 0x060047A6 RID: 18342 RVA: 0x000B5A28 File Offset: 0x000B3C28
		public virtual int? Wind
		{
			get
			{
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				return new int?(this.Instance.Wind);
			}
		}

		// Token: 0x17001331 RID: 4913
		// (get) Token: 0x060047A7 RID: 18343 RVA: 0x000B5A60 File Offset: 0x000B3C60
		public virtual int? Light
		{
			get
			{
				if ((this.Instance.NullMask & 32) == 0)
				{
					return null;
				}
				return new int?(this.Instance.Light);
			}
		}

		// Token: 0x17001332 RID: 4914
		// (get) Token: 0x060047A8 RID: 18344 RVA: 0x000B5A98 File Offset: 0x000B3C98
		public virtual int? Dark
		{
			get
			{
				if ((this.Instance.NullMask & 64) == 0)
				{
					return null;
				}
				return new int?(this.Instance.Dark);
			}
		}

		// Token: 0x0400283F RID: 10303
		private IElementDamage Instance;
	}
}
