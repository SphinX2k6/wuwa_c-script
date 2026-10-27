using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FC0 RID: 8128
	[NullableContext(1)]
	[Nullable(0)]
	public class ITimeLimitOptionGroup
	{
		// Token: 0x0600B2D2 RID: 45778 RVA: 0x001A09D8 File Offset: 0x0019EBD8
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

		// Token: 0x0600B2D3 RID: 45779 RVA: 0x001A0A10 File Offset: 0x0019EC10
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

		// Token: 0x0600B2D4 RID: 45780 RVA: 0x001A0A23 File Offset: 0x0019EC23
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

		// Token: 0x0600B2D5 RID: 45781 RVA: 0x001A0A36 File Offset: 0x0019EC36
		public ITimeLimitOptionGroup_SetValue ToSetValue()
		{
			return new ITimeLimitOptionGroup_SetValue
			{
				Style = this.Style
			};
		}

		// Token: 0x17003721 RID: 14113
		// (get) Token: 0x0600B2D6 RID: 45782 RVA: 0x001A0A4C File Offset: 0x0019EC4C
		// (set) Token: 0x0600B2D7 RID: 45783 RVA: 0x001A0AAD File Offset: 0x0019ECAD
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

		// Token: 0x04006BF6 RID: 27638
		[Nullable(2)]
		protected ITimeLimitOptionGroup FbInstance;

		// Token: 0x04006BF7 RID: 27639
		[Nullable(2)]
		protected ITimeLimitOptionGroup_SetValue PocoInterface;

		// Token: 0x04006BF8 RID: 27640
		private ITimeLimitOptionGroupDefault _StyleCache;

		// Token: 0x04006BF9 RID: 27641
		private bool _StyleInited;
	}
}
