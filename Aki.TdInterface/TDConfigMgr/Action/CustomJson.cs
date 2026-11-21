using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016AF RID: 5807
	public class CustomJson : ActionParams
	{
		// Token: 0x06008241 RID: 33345 RVA: 0x0013872C File Offset: 0x0013692C
		private CustomJson_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("CustomJson 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			CustomJson_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new CustomJson_SetValue());
			}
			return result;
		}

		// Token: 0x06008242 RID: 33346 RVA: 0x00138764 File Offset: 0x00136964
		public static CustomJson Create([Nullable(2)] CustomJson instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CustomJson
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008243 RID: 33347 RVA: 0x00138777 File Offset: 0x00136977
		public static CustomJson CreateFromSetValue([Nullable(2)] CustomJson_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new CustomJson
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008244 RID: 33348 RVA: 0x0013878A File Offset: 0x0013698A
		public CustomJson_SetValue ToSetValue()
		{
			return new CustomJson_SetValue
			{
				Name = this.Name,
				JsonString = this.JsonString
			};
		}

		// Token: 0x17002ADB RID: 10971
		// (get) Token: 0x06008245 RID: 33349 RVA: 0x001387A9 File Offset: 0x001369A9
		// (set) Token: 0x06008246 RID: 33350 RVA: 0x001387D4 File Offset: 0x001369D4
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

		// Token: 0x17002ADC RID: 10972
		// (get) Token: 0x06008247 RID: 33351 RVA: 0x001387E2 File Offset: 0x001369E2
		// (set) Token: 0x06008248 RID: 33352 RVA: 0x0013880D File Offset: 0x00136A0D
		public virtual string JsonString
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.JsonString;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.JsonString;
			}
			set
			{
				this.GetOrCreatePoco().JsonString = value;
			}
		}

		// Token: 0x04004AB5 RID: 19125
		[Nullable(2)]
		protected new CustomJson FbInstance;

		// Token: 0x04004AB6 RID: 19126
		[Nullable(2)]
		protected CustomJson_SetValue PocoInterface;
	}
}
