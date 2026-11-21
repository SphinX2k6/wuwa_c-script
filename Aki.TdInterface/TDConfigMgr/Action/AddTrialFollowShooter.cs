using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015F2 RID: 5618
	public class AddTrialFollowShooter : ActionParams
	{
		// Token: 0x06007EE5 RID: 32485 RVA: 0x0012EE64 File Offset: 0x0012D064
		private AddTrialFollowShooter_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("AddTrialFollowShooter 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			AddTrialFollowShooter_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new AddTrialFollowShooter_SetValue());
			}
			return result;
		}

		// Token: 0x06007EE6 RID: 32486 RVA: 0x0012EE9C File Offset: 0x0012D09C
		public static AddTrialFollowShooter Create([Nullable(2)] AddTrialFollowShooter instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AddTrialFollowShooter
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007EE7 RID: 32487 RVA: 0x0012EEAF File Offset: 0x0012D0AF
		public static AddTrialFollowShooter CreateFromSetValue([Nullable(2)] AddTrialFollowShooter_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new AddTrialFollowShooter
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007EE8 RID: 32488 RVA: 0x0012EEC2 File Offset: 0x0012D0C2
		public AddTrialFollowShooter_SetValue ToSetValue()
		{
			return new AddTrialFollowShooter_SetValue
			{
				Id = this.Id,
				ActiveRange = this.ActiveRange
			};
		}

		// Token: 0x17002A46 RID: 10822
		// (get) Token: 0x06007EE9 RID: 32489 RVA: 0x0012EEE1 File Offset: 0x0012D0E1
		// (set) Token: 0x06007EEA RID: 32490 RVA: 0x0012EF0C File Offset: 0x0012D10C
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x17002A47 RID: 10823
		// (get) Token: 0x06007EEB RID: 32491 RVA: 0x0012EF1C File Offset: 0x0012D11C
		// (set) Token: 0x06007EEC RID: 32492 RVA: 0x0012EF7D File Offset: 0x0012D17D
		public virtual IActiveRange ActiveRange
		{
			get
			{
				if (this._ActiveRangeInited)
				{
					return this._ActiveRangeCache;
				}
				this._ActiveRangeInited = true;
				if (this.FbInstance != null)
				{
					this._ActiveRangeCache = IActiveRange.Create(this.FbInstance.ActiveRange);
				}
				else
				{
					AddTrialFollowShooter_SetValue pocoInterface = this.PocoInterface;
					this._ActiveRangeCache = ((pocoInterface != null) ? pocoInterface.ActiveRange : null);
				}
				return this._ActiveRangeCache;
			}
			set
			{
				this.GetOrCreatePoco().ActiveRange = value;
				this._ActiveRangeInited = false;
			}
		}

		// Token: 0x0400496F RID: 18799
		[Nullable(2)]
		protected new AddTrialFollowShooter FbInstance;

		// Token: 0x04004970 RID: 18800
		[Nullable(2)]
		protected AddTrialFollowShooter_SetValue PocoInterface;

		// Token: 0x04004971 RID: 18801
		private IActiveRange _ActiveRangeCache;

		// Token: 0x04004972 RID: 18802
		private bool _ActiveRangeInited;
	}
}
