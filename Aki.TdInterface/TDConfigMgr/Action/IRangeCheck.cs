using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D88 RID: 7560
	[NullableContext(1)]
	[Nullable(0)]
	public class IRangeCheck
	{
		// Token: 0x0600A20F RID: 41487 RVA: 0x00170CDC File Offset: 0x0016EEDC
		private IRangeCheck_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRangeCheck 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRangeCheck_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRangeCheck_SetValue());
			}
			return result;
		}

		// Token: 0x0600A210 RID: 41488 RVA: 0x00170D14 File Offset: 0x0016EF14
		public static IRangeCheck Create([Nullable(2)] IRangeCheck instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRangeCheck
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A211 RID: 41489 RVA: 0x00170D27 File Offset: 0x0016EF27
		public static IRangeCheck CreateFromSetValue([Nullable(2)] IRangeCheck_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRangeCheck
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A212 RID: 41490 RVA: 0x00170D3A File Offset: 0x0016EF3A
		public IRangeCheck_SetValue ToSetValue()
		{
			return new IRangeCheck_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003212 RID: 12818
		// (get) Token: 0x0600A213 RID: 41491 RVA: 0x00170D4D File Offset: 0x0016EF4D
		// (set) Token: 0x0600A214 RID: 41492 RVA: 0x00170D78 File Offset: 0x0016EF78
		public virtual ERangeCheckType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERangeCheckType.Cone;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006165 RID: 24933
		[Nullable(2)]
		protected IRangeCheck FbInstance;

		// Token: 0x04006166 RID: 24934
		[Nullable(2)]
		protected IRangeCheck_SetValue PocoInterface;
	}
}
