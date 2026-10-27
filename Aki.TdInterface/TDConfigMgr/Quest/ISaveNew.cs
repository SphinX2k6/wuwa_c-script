using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001124 RID: 4388
	[NullableContext(1)]
	[Nullable(0)]
	public class ISaveNew : ISaveConfigType
	{
		// Token: 0x0600630C RID: 25356 RVA: 0x000EE254 File Offset: 0x000EC454
		private ISaveNew_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISaveNew 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISaveNew_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISaveNew_SetValue());
			}
			return result;
		}

		// Token: 0x0600630D RID: 25357 RVA: 0x000EE28C File Offset: 0x000EC48C
		public static ISaveNew Create([Nullable(2)] ISaveNew instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISaveNew
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600630E RID: 25358 RVA: 0x000EE29F File Offset: 0x000EC49F
		public static ISaveNew CreateFromSetValue([Nullable(2)] ISaveNew_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISaveNew
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600630F RID: 25359 RVA: 0x000EE2B2 File Offset: 0x000EC4B2
		public new ISaveNew_SetValue ToSetValue()
		{
			return new ISaveNew_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002054 RID: 8276
		// (get) Token: 0x06006310 RID: 25360 RVA: 0x000EE2C5 File Offset: 0x000EC4C5
		// (set) Token: 0x06006311 RID: 25361 RVA: 0x000EE2F0 File Offset: 0x000EC4F0
		public override ESaveConfig Type
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

		// Token: 0x04003B63 RID: 15203
		[Nullable(2)]
		protected new ISaveNew FbInstance;

		// Token: 0x04003B64 RID: 15204
		[Nullable(2)]
		protected new ISaveNew_SetValue PocoInterface;
	}
}
