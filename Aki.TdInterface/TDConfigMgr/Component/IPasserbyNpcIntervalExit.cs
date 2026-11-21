using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200063B RID: 1595
	public class IPasserbyNpcIntervalExit
	{
		// Token: 0x06002186 RID: 8582 RVA: 0x0005D408 File Offset: 0x0005B608
		private IPasserbyNpcIntervalExit_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPasserbyNpcIntervalExit 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPasserbyNpcIntervalExit_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPasserbyNpcIntervalExit_SetValue());
			}
			return result;
		}

		// Token: 0x06002187 RID: 8583 RVA: 0x0005D440 File Offset: 0x0005B640
		public static IPasserbyNpcIntervalExit Create([Nullable(2)] IPasserbyNpcIntervalExit instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcIntervalExit
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002188 RID: 8584 RVA: 0x0005D453 File Offset: 0x0005B653
		public static IPasserbyNpcIntervalExit CreateFromSetValue([Nullable(2)] IPasserbyNpcIntervalExit_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPasserbyNpcIntervalExit
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002189 RID: 8585 RVA: 0x0005D466 File Offset: 0x0005B666
		public IPasserbyNpcIntervalExit_SetValue ToSetValue()
		{
			return new IPasserbyNpcIntervalExit_SetValue
			{
				IntervalType = this.IntervalType
			};
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x0600218A RID: 8586 RVA: 0x0005D47C File Offset: 0x0005B67C
		// (set) Token: 0x0600218B RID: 8587 RVA: 0x0005D4DD File Offset: 0x0005B6DD
		public virtual IPasserbyNpcPerNpcRandomExitInterval IntervalType
		{
			get
			{
				if (this._IntervalTypeInited)
				{
					return this._IntervalTypeCache;
				}
				this._IntervalTypeInited = true;
				if (this.FbInstance != null)
				{
					this._IntervalTypeCache = IPasserbyNpcPerNpcRandomExitInterval.Create(this.FbInstance.IntervalType);
				}
				else
				{
					IPasserbyNpcIntervalExit_SetValue pocoInterface = this.PocoInterface;
					this._IntervalTypeCache = ((pocoInterface != null) ? pocoInterface.IntervalType : null);
				}
				return this._IntervalTypeCache;
			}
			set
			{
				this.GetOrCreatePoco().IntervalType = value;
				this._IntervalTypeInited = false;
			}
		}

		// Token: 0x040017B0 RID: 6064
		[Nullable(2)]
		protected IPasserbyNpcIntervalExit FbInstance;

		// Token: 0x040017B1 RID: 6065
		[Nullable(2)]
		protected IPasserbyNpcIntervalExit_SetValue PocoInterface;

		// Token: 0x040017B2 RID: 6066
		private IPasserbyNpcPerNpcRandomExitInterval _IntervalTypeCache;

		// Token: 0x040017B3 RID: 6067
		private bool _IntervalTypeInited;
	}
}
