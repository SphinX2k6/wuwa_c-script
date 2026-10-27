using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B6A RID: 2922
	public class IElementDamage
	{
		// Token: 0x06004347 RID: 17223 RVA: 0x000AB856 File Offset: 0x000A9A56
		[NullableContext(1)]
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

		// Token: 0x17001230 RID: 4656
		// (get) Token: 0x06004348 RID: 17224 RVA: 0x000AB875 File Offset: 0x000A9A75
		public virtual int DefaultValue
		{
			get
			{
				return this.Instance.DefaultValue;
			}
		}

		// Token: 0x17001231 RID: 4657
		// (get) Token: 0x06004349 RID: 17225 RVA: 0x000AB884 File Offset: 0x000A9A84
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

		// Token: 0x17001232 RID: 4658
		// (get) Token: 0x0600434A RID: 17226 RVA: 0x000AB8BC File Offset: 0x000A9ABC
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

		// Token: 0x17001233 RID: 4659
		// (get) Token: 0x0600434B RID: 17227 RVA: 0x000AB8F4 File Offset: 0x000A9AF4
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

		// Token: 0x17001234 RID: 4660
		// (get) Token: 0x0600434C RID: 17228 RVA: 0x000AB92C File Offset: 0x000A9B2C
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

		// Token: 0x17001235 RID: 4661
		// (get) Token: 0x0600434D RID: 17229 RVA: 0x000AB964 File Offset: 0x000A9B64
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

		// Token: 0x17001236 RID: 4662
		// (get) Token: 0x0600434E RID: 17230 RVA: 0x000AB99C File Offset: 0x000A9B9C
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

		// Token: 0x17001237 RID: 4663
		// (get) Token: 0x0600434F RID: 17231 RVA: 0x000AB9D4 File Offset: 0x000A9BD4
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

		// Token: 0x040025F7 RID: 9719
		private IElementDamage Instance;
	}
}
