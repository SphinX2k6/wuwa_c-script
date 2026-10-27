using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C88 RID: 7304
	[NullableContext(1)]
	[Nullable(0)]
	public class Invoke : ActionParams
	{
		// Token: 0x06009CAB RID: 40107 RVA: 0x00167370 File Offset: 0x00165570
		private Invoke_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("Invoke 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			Invoke_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new Invoke_SetValue());
			}
			return result;
		}

		// Token: 0x06009CAC RID: 40108 RVA: 0x001673A8 File Offset: 0x001655A8
		public static Invoke Create([Nullable(2)] Invoke instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new Invoke
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009CAD RID: 40109 RVA: 0x001673BB File Offset: 0x001655BB
		public static Invoke CreateFromSetValue([Nullable(2)] Invoke_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new Invoke
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009CAE RID: 40110 RVA: 0x001673CE File Offset: 0x001655CE
		public Invoke_SetValue ToSetValue()
		{
			return new Invoke_SetValue
			{
				Who = this.Who,
				ActionInfo = this.ActionInfo
			};
		}

		// Token: 0x170030E0 RID: 12512
		// (get) Token: 0x06009CAF RID: 40111 RVA: 0x001673ED File Offset: 0x001655ED
		// (set) Token: 0x06009CB0 RID: 40112 RVA: 0x00167418 File Offset: 0x00165618
		public virtual int Who
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Who;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Who;
			}
			set
			{
				this.GetOrCreatePoco().Who = value;
			}
		}

		// Token: 0x170030E1 RID: 12513
		// (get) Token: 0x06009CB1 RID: 40113 RVA: 0x00167428 File Offset: 0x00165628
		// (set) Token: 0x06009CB2 RID: 40114 RVA: 0x00167489 File Offset: 0x00165689
		public virtual ActionInfo ActionInfo
		{
			get
			{
				if (this._ActionInfoInited)
				{
					return this._ActionInfoCache;
				}
				this._ActionInfoInited = true;
				if (this.FbInstance != null)
				{
					this._ActionInfoCache = ActionInfo.Create(this.FbInstance.ActionInfo);
				}
				else
				{
					Invoke_SetValue pocoInterface = this.PocoInterface;
					this._ActionInfoCache = ((pocoInterface != null) ? pocoInterface.ActionInfo : null);
				}
				return this._ActionInfoCache;
			}
			set
			{
				this.GetOrCreatePoco().ActionInfo = value;
				this._ActionInfoInited = false;
			}
		}

		// Token: 0x04005EF7 RID: 24311
		[Nullable(2)]
		protected new Invoke FbInstance;

		// Token: 0x04005EF8 RID: 24312
		[Nullable(2)]
		protected Invoke_SetValue PocoInterface;

		// Token: 0x04005EF9 RID: 24313
		private ActionInfo _ActionInfoCache;

		// Token: 0x04005EFA RID: 24314
		private bool _ActionInfoInited;
	}
}
