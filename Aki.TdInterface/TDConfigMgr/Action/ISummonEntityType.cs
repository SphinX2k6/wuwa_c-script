using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EEB RID: 7915
	[NullableContext(1)]
	[Nullable(0)]
	public class ISummonEntityType
	{
		// Token: 0x0600A94E RID: 43342 RVA: 0x0017DD40 File Offset: 0x0017BF40
		private ISummonEntityType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISummonEntityType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISummonEntityType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISummonEntityType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A94F RID: 43343 RVA: 0x0017DD78 File Offset: 0x0017BF78
		public static ISummonEntityType Create([Nullable(2)] ISummonEntityType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISummonEntityType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A950 RID: 43344 RVA: 0x0017DD8B File Offset: 0x0017BF8B
		public static ISummonEntityType CreateFromSetValue([Nullable(2)] ISummonEntityType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISummonEntityType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A951 RID: 43345 RVA: 0x0017DD9E File Offset: 0x0017BF9E
		public ISummonEntityType_SetValue ToSetValue()
		{
			return new ISummonEntityType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700339E RID: 13214
		// (get) Token: 0x0600A952 RID: 43346 RVA: 0x0017DDB1 File Offset: 0x0017BFB1
		// (set) Token: 0x0600A953 RID: 43347 RVA: 0x0017DDDC File Offset: 0x0017BFDC
		public virtual ESummonEntityType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESummonEntityType.Vehicle;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040064BF RID: 25791
		[Nullable(2)]
		protected ISummonEntityType FbInstance;

		// Token: 0x040064C0 RID: 25792
		[Nullable(2)]
		protected ISummonEntityType_SetValue PocoInterface;
	}
}
