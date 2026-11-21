using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F99 RID: 8089
	public class IRangeCheck
	{
		// Token: 0x0600ABFB RID: 44027 RVA: 0x00185100 File Offset: 0x00183300
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

		// Token: 0x0600ABFC RID: 44028 RVA: 0x00185138 File Offset: 0x00183338
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

		// Token: 0x0600ABFD RID: 44029 RVA: 0x0018514B File Offset: 0x0018334B
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

		// Token: 0x0600ABFE RID: 44030 RVA: 0x0018515E File Offset: 0x0018335E
		public IRangeCheck_SetValue ToSetValue()
		{
			return new IRangeCheck_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170034A6 RID: 13478
		// (get) Token: 0x0600ABFF RID: 44031 RVA: 0x00185171 File Offset: 0x00183371
		// (set) Token: 0x0600AC00 RID: 44032 RVA: 0x0018519C File Offset: 0x0018339C
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

		// Token: 0x040066E1 RID: 26337
		[Nullable(2)]
		protected IRangeCheck FbInstance;

		// Token: 0x040066E2 RID: 26338
		[Nullable(2)]
		protected IRangeCheck_SetValue PocoInterface;
	}
}
