using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002205 RID: 8709
	public class ITimeLimitOptionGroup
	{
		// Token: 0x0600BDE0 RID: 48608 RVA: 0x001B6E88 File Offset: 0x001B5088
		private ITimeLimitOptionGroup_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITimeLimitOptionGroup 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITimeLimitOptionGroup_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITimeLimitOptionGroup_SetValue());
			}
			return result;
		}

		// Token: 0x0600BDE1 RID: 48609 RVA: 0x001B6EC0 File Offset: 0x001B50C0
		public static ITimeLimitOptionGroup Create([Nullable(2)] ITimeLimitOptionGroup instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeLimitOptionGroup
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BDE2 RID: 48610 RVA: 0x001B6ED3 File Offset: 0x001B50D3
		public static ITimeLimitOptionGroup CreateFromSetValue([Nullable(2)] ITimeLimitOptionGroup_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITimeLimitOptionGroup
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BDE3 RID: 48611 RVA: 0x001B6EE6 File Offset: 0x001B50E6
		public ITimeLimitOptionGroup_SetValue ToSetValue()
		{
			return new ITimeLimitOptionGroup_SetValue
			{
				Style = this.Style
			};
		}

		// Token: 0x170039F8 RID: 14840
		// (get) Token: 0x0600BDE4 RID: 48612 RVA: 0x001B6EFC File Offset: 0x001B50FC
		// (set) Token: 0x0600BDE5 RID: 48613 RVA: 0x001B6F5D File Offset: 0x001B515D
		public virtual ITimeLimitOptionGroupDefault Style
		{
			get
			{
				if (this._StyleInited)
				{
					return this._StyleCache;
				}
				this._StyleInited = true;
				if (this.FbInstance != null)
				{
					this._StyleCache = ITimeLimitOptionGroupDefault.Create(this.FbInstance.Style);
				}
				else
				{
					ITimeLimitOptionGroup_SetValue pocoInterface = this.PocoInterface;
					this._StyleCache = ((pocoInterface != null) ? pocoInterface.Style : null);
				}
				return this._StyleCache;
			}
			set
			{
				this.GetOrCreatePoco().Style = value;
				this._StyleInited = false;
			}
		}

		// Token: 0x040071F5 RID: 29173
		[Nullable(2)]
		protected ITimeLimitOptionGroup FbInstance;

		// Token: 0x040071F6 RID: 29174
		[Nullable(2)]
		protected ITimeLimitOptionGroup_SetValue PocoInterface;

		// Token: 0x040071F7 RID: 29175
		private ITimeLimitOptionGroupDefault _StyleCache;

		// Token: 0x040071F8 RID: 29176
		private bool _StyleInited;
	}
}
