using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006FD RID: 1789
	public class IRangedRandom
	{
		// Token: 0x060025F2 RID: 9714 RVA: 0x000669F0 File Offset: 0x00064BF0
		private IRangedRandom_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRangedRandom 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRangedRandom_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRangedRandom_SetValue());
			}
			return result;
		}

		// Token: 0x060025F3 RID: 9715 RVA: 0x00066A28 File Offset: 0x00064C28
		public static IRangedRandom Create([Nullable(2)] IRangedRandom instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRangedRandom
			{
				FbInstance = instance
			};
		}

		// Token: 0x060025F4 RID: 9716 RVA: 0x00066A3B File Offset: 0x00064C3B
		public static IRangedRandom CreateFromSetValue([Nullable(2)] IRangedRandom_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRangedRandom
			{
				PocoInterface = value
			};
		}

		// Token: 0x060025F5 RID: 9717 RVA: 0x00066A4E File Offset: 0x00064C4E
		public IRangedRandom_SetValue ToSetValue()
		{
			return new IRangedRandom_SetValue
			{
				Left = this.Left,
				Right = this.Right
			};
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x060025F6 RID: 9718 RVA: 0x00066A6D File Offset: 0x00064C6D
		// (set) Token: 0x060025F7 RID: 9719 RVA: 0x00066A9C File Offset: 0x00064C9C
		public virtual float Left
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Left;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Left;
			}
			set
			{
				this.GetOrCreatePoco().Left = value;
			}
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x060025F8 RID: 9720 RVA: 0x00066AAA File Offset: 0x00064CAA
		// (set) Token: 0x060025F9 RID: 9721 RVA: 0x00066AD9 File Offset: 0x00064CD9
		public virtual float Right
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Right;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Right;
			}
			set
			{
				this.GetOrCreatePoco().Right = value;
			}
		}

		// Token: 0x04001A2D RID: 6701
		[Nullable(2)]
		protected IRangedRandom FbInstance;

		// Token: 0x04001A2E RID: 6702
		[Nullable(2)]
		protected IRangedRandom_SetValue PocoInterface;
	}
}
