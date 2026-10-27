using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000311 RID: 785
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityBatchType
	{
		// Token: 0x06000F39 RID: 3897 RVA: 0x00035DD8 File Offset: 0x00033FD8
		private IEntityBatchType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEntityBatchType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEntityBatchType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEntityBatchType_SetValue());
			}
			return result;
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x00035E10 File Offset: 0x00034010
		public static IEntityBatchType Create([Nullable(2)] IEntityBatchType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityBatchType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x00035E23 File Offset: 0x00034023
		public static IEntityBatchType CreateFromSetValue([Nullable(2)] IEntityBatchType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEntityBatchType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x00035E36 File Offset: 0x00034036
		public IEntityBatchType_SetValue ToSetValue()
		{
			return new IEntityBatchType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x00035E49 File Offset: 0x00034049
		// (set) Token: 0x06000F3E RID: 3902 RVA: 0x00035E74 File Offset: 0x00034074
		public virtual EEntityBatchType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEntityBatchType.EntityList;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000D2B RID: 3371
		[Nullable(2)]
		protected IEntityBatchType FbInstance;

		// Token: 0x04000D2C RID: 3372
		[Nullable(2)]
		protected IEntityBatchType_SetValue PocoInterface;
	}
}
