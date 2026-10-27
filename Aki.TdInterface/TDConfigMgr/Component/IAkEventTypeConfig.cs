using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001B9 RID: 441
	[NullableContext(1)]
	[Nullable(0)]
	public class IAkEventTypeConfig
	{
		// Token: 0x060006F8 RID: 1784 RVA: 0x0002411C File Offset: 0x0002231C
		private IAkEventTypeConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAkEventTypeConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAkEventTypeConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAkEventTypeConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00024154 File Offset: 0x00022354
		public static IAkEventTypeConfig Create([Nullable(2)] IAkEventTypeConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAkEventTypeConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00024167 File Offset: 0x00022367
		public static IAkEventTypeConfig CreateFromSetValue([Nullable(2)] IAkEventTypeConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAkEventTypeConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x0002417A File Offset: 0x0002237A
		public IAkEventTypeConfig_SetValue ToSetValue()
		{
			return new IAkEventTypeConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x060006FC RID: 1788 RVA: 0x0002418D File Offset: 0x0002238D
		// (set) Token: 0x060006FD RID: 1789 RVA: 0x000241B8 File Offset: 0x000223B8
		public virtual EAkEventType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAkEventType.Point;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000864 RID: 2148
		[Nullable(2)]
		protected IAkEventTypeConfig FbInstance;

		// Token: 0x04000865 RID: 2149
		[Nullable(2)]
		protected IAkEventTypeConfig_SetValue PocoInterface;
	}
}
