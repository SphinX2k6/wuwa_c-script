using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020CC RID: 8396
	public class ISolarSchoolTime
	{
		// Token: 0x0600B242 RID: 45634 RVA: 0x00190698 File Offset: 0x0018E898
		private ISolarSchoolTime_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISolarSchoolTime 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISolarSchoolTime_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISolarSchoolTime_SetValue());
			}
			return result;
		}

		// Token: 0x0600B243 RID: 45635 RVA: 0x001906D0 File Offset: 0x0018E8D0
		public static ISolarSchoolTime Create([Nullable(2)] ISolarSchoolTime instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISolarSchoolTime
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B244 RID: 45636 RVA: 0x001906E3 File Offset: 0x0018E8E3
		public static ISolarSchoolTime CreateFromSetValue([Nullable(2)] ISolarSchoolTime_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISolarSchoolTime
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B245 RID: 45637 RVA: 0x001906F6 File Offset: 0x0018E8F6
		public ISolarSchoolTime_SetValue ToSetValue()
		{
			return new ISolarSchoolTime_SetValue
			{
				Date = this.Date,
				PeriodId = this.PeriodId
			};
		}

		// Token: 0x170035FE RID: 13822
		// (get) Token: 0x0600B246 RID: 45638 RVA: 0x00190718 File Offset: 0x0018E918
		// (set) Token: 0x0600B247 RID: 45639 RVA: 0x00190779 File Offset: 0x0018E979
		[Nullable(2)]
		public virtual IVisualNovelDate Date
		{
			[NullableContext(2)]
			get
			{
				if (this._DateInited)
				{
					return this._DateCache;
				}
				this._DateInited = true;
				if (this.FbInstance != null)
				{
					this._DateCache = IVisualNovelDate.Create(this.FbInstance.Date);
				}
				else
				{
					ISolarSchoolTime_SetValue pocoInterface = this.PocoInterface;
					this._DateCache = ((pocoInterface != null) ? pocoInterface.Date : null);
				}
				return this._DateCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().Date = value;
				this._DateInited = false;
			}
		}

		// Token: 0x170035FF RID: 13823
		// (get) Token: 0x0600B248 RID: 45640 RVA: 0x0019078E File Offset: 0x0018E98E
		// (set) Token: 0x0600B249 RID: 45641 RVA: 0x001907B9 File Offset: 0x0018E9B9
		public virtual int PeriodId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PeriodId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.PeriodId;
			}
			set
			{
				this.GetOrCreatePoco().PeriodId = value;
			}
		}

		// Token: 0x040069CD RID: 27085
		[Nullable(2)]
		protected ISolarSchoolTime FbInstance;

		// Token: 0x040069CE RID: 27086
		[Nullable(2)]
		protected ISolarSchoolTime_SetValue PocoInterface;

		// Token: 0x040069CF RID: 27087
		private IVisualNovelDate _DateCache;

		// Token: 0x040069D0 RID: 27088
		private bool _DateInited;
	}
}
