using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200029D RID: 669
	[NullableContext(1)]
	[Nullable(0)]
	public class ICustomPrimitiveMapping
	{
		// Token: 0x06000C7D RID: 3197 RVA: 0x000304A4 File Offset: 0x0002E6A4
		private ICustomPrimitiveMapping_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICustomPrimitiveMapping 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICustomPrimitiveMapping_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICustomPrimitiveMapping_SetValue());
			}
			return result;
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x000304DC File Offset: 0x0002E6DC
		public static ICustomPrimitiveMapping Create([Nullable(2)] ICustomPrimitiveMapping instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomPrimitiveMapping
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x000304EF File Offset: 0x0002E6EF
		public static ICustomPrimitiveMapping CreateFromSetValue([Nullable(2)] ICustomPrimitiveMapping_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICustomPrimitiveMapping
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x00030502 File Offset: 0x0002E702
		public ICustomPrimitiveMapping_SetValue ToSetValue()
		{
			return new ICustomPrimitiveMapping_SetValue
			{
				KeyPrefix = this.KeyPrefix,
				Index = this.Index
			};
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000C81 RID: 3201 RVA: 0x00030521 File Offset: 0x0002E721
		// (set) Token: 0x06000C82 RID: 3202 RVA: 0x0003054C File Offset: 0x0002E74C
		public virtual string KeyPrefix
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.KeyPrefix;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.KeyPrefix;
			}
			set
			{
				this.GetOrCreatePoco().KeyPrefix = value;
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000C83 RID: 3203 RVA: 0x0003055A File Offset: 0x0002E75A
		// (set) Token: 0x06000C84 RID: 3204 RVA: 0x00030585 File Offset: 0x0002E785
		public virtual int Index
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Index;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Index;
			}
			set
			{
				this.GetOrCreatePoco().Index = value;
			}
		}

		// Token: 0x04000BB3 RID: 2995
		[Nullable(2)]
		protected ICustomPrimitiveMapping FbInstance;

		// Token: 0x04000BB4 RID: 2996
		[Nullable(2)]
		protected ICustomPrimitiveMapping_SetValue PocoInterface;
	}
}
