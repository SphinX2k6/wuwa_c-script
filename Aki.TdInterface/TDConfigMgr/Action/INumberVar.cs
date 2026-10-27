using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C86 RID: 7302
	[NullableContext(1)]
	[Nullable(0)]
	public class INumberVar
	{
		// Token: 0x06009CA1 RID: 40097 RVA: 0x0016726C File Offset: 0x0016546C
		private INumberVar_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INumberVar 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INumberVar_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INumberVar_SetValue());
			}
			return result;
		}

		// Token: 0x06009CA2 RID: 40098 RVA: 0x001672A4 File Offset: 0x001654A4
		public static INumberVar Create([Nullable(2)] INumberVar instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INumberVar
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009CA3 RID: 40099 RVA: 0x001672B7 File Offset: 0x001654B7
		public static INumberVar CreateFromSetValue([Nullable(2)] INumberVar_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INumberVar
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009CA4 RID: 40100 RVA: 0x001672CA File Offset: 0x001654CA
		public INumberVar_SetValue ToSetValue()
		{
			return new INumberVar_SetValue
			{
				Name = this.Name,
				Value = this.Value
			};
		}

		// Token: 0x170030DE RID: 12510
		// (get) Token: 0x06009CA5 RID: 40101 RVA: 0x001672E9 File Offset: 0x001654E9
		// (set) Token: 0x06009CA6 RID: 40102 RVA: 0x00167314 File Offset: 0x00165514
		public virtual string Name
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Name;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Name;
			}
			set
			{
				this.GetOrCreatePoco().Name = value;
			}
		}

		// Token: 0x170030DF RID: 12511
		// (get) Token: 0x06009CA7 RID: 40103 RVA: 0x00167322 File Offset: 0x00165522
		// (set) Token: 0x06009CA8 RID: 40104 RVA: 0x00167351 File Offset: 0x00165551
		public virtual float Value
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Value;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Value;
			}
			set
			{
				this.GetOrCreatePoco().Value = value;
			}
		}

		// Token: 0x04005EF3 RID: 24307
		[Nullable(2)]
		protected INumberVar FbInstance;

		// Token: 0x04005EF4 RID: 24308
		[Nullable(2)]
		protected INumberVar_SetValue PocoInterface;
	}
}
