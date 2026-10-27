using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019C8 RID: 6600
	[NullableContext(1)]
	[Nullable(0)]
	public class IDurationInteract
	{
		// Token: 0x06008D61 RID: 36193 RVA: 0x0014B4A0 File Offset: 0x001496A0
		private IDurationInteract_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDurationInteract 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDurationInteract_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDurationInteract_SetValue());
			}
			return result;
		}

		// Token: 0x06008D62 RID: 36194 RVA: 0x0014B4D8 File Offset: 0x001496D8
		public static IDurationInteract Create([Nullable(2)] IDurationInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDurationInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008D63 RID: 36195 RVA: 0x0014B4EB File Offset: 0x001496EB
		public static IDurationInteract CreateFromSetValue([Nullable(2)] IDurationInteract_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDurationInteract
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008D64 RID: 36196 RVA: 0x0014B4FE File Offset: 0x001496FE
		public IDurationInteract_SetValue ToSetValue()
		{
			return new IDurationInteract_SetValue
			{
				Duration = this.Duration
			};
		}

		// Token: 0x17002D59 RID: 11609
		// (get) Token: 0x06008D65 RID: 36197 RVA: 0x0014B511 File Offset: 0x00149711
		// (set) Token: 0x06008D66 RID: 36198 RVA: 0x0014B540 File Offset: 0x00149740
		public virtual float Duration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Duration;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Duration;
			}
			set
			{
				this.GetOrCreatePoco().Duration = value;
			}
		}

		// Token: 0x040057D6 RID: 22486
		[Nullable(2)]
		protected IDurationInteract FbInstance;

		// Token: 0x040057D7 RID: 22487
		[Nullable(2)]
		protected IDurationInteract_SetValue PocoInterface;
	}
}
