using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002207 RID: 8711
	public class ITimeLimitOptionGroupBaseStyle
	{
		// Token: 0x0600BDE8 RID: 48616 RVA: 0x001B6F84 File Offset: 0x001B5184
		private ITimeLimitOptionGroupBaseStyle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITimeLimitOptionGroupBaseStyle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITimeLimitOptionGroupBaseStyle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITimeLimitOptionGroupBaseStyle_SetValue());
			}
			return result;
		}

		// Token: 0x0600BDE9 RID: 48617 RVA: 0x001B6FBC File Offset: 0x001B51BC
		public static ITimeLimitOptionGroupBaseStyle Create([Nullable(2)] ITimeLimitOptionGroupBaseStyle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeLimitOptionGroupBaseStyle
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BDEA RID: 48618 RVA: 0x001B6FCF File Offset: 0x001B51CF
		public static ITimeLimitOptionGroupBaseStyle CreateFromSetValue([Nullable(2)] ITimeLimitOptionGroupBaseStyle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITimeLimitOptionGroupBaseStyle
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BDEB RID: 48619 RVA: 0x001B6FE2 File Offset: 0x001B51E2
		public ITimeLimitOptionGroupBaseStyle_SetValue ToSetValue()
		{
			return new ITimeLimitOptionGroupBaseStyle_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170039F9 RID: 14841
		// (get) Token: 0x0600BDEC RID: 48620 RVA: 0x001B6FF5 File Offset: 0x001B51F5
		// (set) Token: 0x0600BDED RID: 48621 RVA: 0x001B7020 File Offset: 0x001B5220
		public virtual ETimeLimitOptionGroupStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETimeLimitOptionGroupStyle.Default;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040071FA RID: 29178
		[Nullable(2)]
		protected ITimeLimitOptionGroupBaseStyle FbInstance;

		// Token: 0x040071FB RID: 29179
		[Nullable(2)]
		protected ITimeLimitOptionGroupBaseStyle_SetValue PocoInterface;
	}
}
