using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000660 RID: 1632
	[NullableContext(1)]
	[Nullable(0)]
	public class IRangedRandom
	{
		// Token: 0x060022EC RID: 8940 RVA: 0x0005FCDC File Offset: 0x0005DEDC
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

		// Token: 0x060022ED RID: 8941 RVA: 0x0005FD14 File Offset: 0x0005DF14
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

		// Token: 0x060022EE RID: 8942 RVA: 0x0005FD27 File Offset: 0x0005DF27
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

		// Token: 0x060022EF RID: 8943 RVA: 0x0005FD3A File Offset: 0x0005DF3A
		public IRangedRandom_SetValue ToSetValue()
		{
			return new IRangedRandom_SetValue
			{
				Left = this.Left,
				Right = this.Right
			};
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x060022F0 RID: 8944 RVA: 0x0005FD59 File Offset: 0x0005DF59
		// (set) Token: 0x060022F1 RID: 8945 RVA: 0x0005FD88 File Offset: 0x0005DF88
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

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x060022F2 RID: 8946 RVA: 0x0005FD96 File Offset: 0x0005DF96
		// (set) Token: 0x060022F3 RID: 8947 RVA: 0x0005FDC5 File Offset: 0x0005DFC5
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

		// Token: 0x0400183B RID: 6203
		[Nullable(2)]
		protected IRangedRandom FbInstance;

		// Token: 0x0400183C RID: 6204
		[Nullable(2)]
		protected IRangedRandom_SetValue PocoInterface;
	}
}
