using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001499 RID: 5273
	[NullableContext(1)]
	[Nullable(0)]
	public class AddTrialFollowShooter : ActionParams
	{
		// Token: 0x06007818 RID: 30744 RVA: 0x00120218 File Offset: 0x0011E418
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

		// Token: 0x06007819 RID: 30745 RVA: 0x00120250 File Offset: 0x0011E450
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

		// Token: 0x0600781A RID: 30746 RVA: 0x00120263 File Offset: 0x0011E463
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

		// Token: 0x0600781B RID: 30747 RVA: 0x00120276 File Offset: 0x0011E476
		public AddTrialFollowShooter_SetValue ToSetValue()
		{
			return new AddTrialFollowShooter_SetValue
			{
				Id = this.Id,
				ActiveRange = this.ActiveRange
			};
		}

		// Token: 0x1700285C RID: 10332
		// (get) Token: 0x0600781C RID: 30748 RVA: 0x00120295 File Offset: 0x0011E495
		// (set) Token: 0x0600781D RID: 30749 RVA: 0x001202C0 File Offset: 0x0011E4C0
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

		// Token: 0x1700285D RID: 10333
		// (get) Token: 0x0600781E RID: 30750 RVA: 0x001202D0 File Offset: 0x0011E4D0
		// (set) Token: 0x0600781F RID: 30751 RVA: 0x00120331 File Offset: 0x0011E531
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

		// Token: 0x040045D4 RID: 17876
		[Nullable(2)]
		protected new AddTrialFollowShooter FbInstance;

		// Token: 0x040045D5 RID: 17877
		[Nullable(2)]
		protected AddTrialFollowShooter_SetValue PocoInterface;

		// Token: 0x040045D6 RID: 17878
		private IActiveRange _ActiveRangeCache;

		// Token: 0x040045D7 RID: 17879
		private bool _ActiveRangeInited;
	}
}
