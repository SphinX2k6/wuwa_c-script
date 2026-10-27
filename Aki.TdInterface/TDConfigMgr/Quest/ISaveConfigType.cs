using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001122 RID: 4386
	[NullableContext(1)]
	[Nullable(0)]
	public class ISaveConfigType
	{
		// Token: 0x06006304 RID: 25348 RVA: 0x000EE198 File Offset: 0x000EC398
		private ISaveConfigType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISaveConfigType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISaveConfigType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISaveConfigType_SetValue());
			}
			return result;
		}

		// Token: 0x06006305 RID: 25349 RVA: 0x000EE1D0 File Offset: 0x000EC3D0
		public static ISaveConfigType Create([Nullable(2)] ISaveConfigType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISaveConfigType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006306 RID: 25350 RVA: 0x000EE1E3 File Offset: 0x000EC3E3
		public static ISaveConfigType CreateFromSetValue([Nullable(2)] ISaveConfigType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISaveConfigType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006307 RID: 25351 RVA: 0x000EE1F6 File Offset: 0x000EC3F6
		public ISaveConfigType_SetValue ToSetValue()
		{
			return new ISaveConfigType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002053 RID: 8275
		// (get) Token: 0x06006308 RID: 25352 RVA: 0x000EE209 File Offset: 0x000EC409
		// (set) Token: 0x06006309 RID: 25353 RVA: 0x000EE234 File Offset: 0x000EC434
		public virtual ESaveConfig Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESaveConfig.SaveNew;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003B60 RID: 15200
		[Nullable(2)]
		protected ISaveConfigType FbInstance;

		// Token: 0x04003B61 RID: 15201
		[Nullable(2)]
		protected ISaveConfigType_SetValue PocoInterface;
	}
}
