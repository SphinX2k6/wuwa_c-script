using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E97 RID: 7831
	[NullableContext(1)]
	[Nullable(0)]
	public class ISolarSchoolTime
	{
		// Token: 0x0600A78A RID: 42890 RVA: 0x0017A998 File Offset: 0x00178B98
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

		// Token: 0x0600A78B RID: 42891 RVA: 0x0017A9D0 File Offset: 0x00178BD0
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

		// Token: 0x0600A78C RID: 42892 RVA: 0x0017A9E3 File Offset: 0x00178BE3
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

		// Token: 0x0600A78D RID: 42893 RVA: 0x0017A9F6 File Offset: 0x00178BF6
		public ISolarSchoolTime_SetValue ToSetValue()
		{
			return new ISolarSchoolTime_SetValue
			{
				Date = this.Date,
				PeriodId = this.PeriodId
			};
		}

		// Token: 0x1700333A RID: 13114
		// (get) Token: 0x0600A78E RID: 42894 RVA: 0x0017AA18 File Offset: 0x00178C18
		// (set) Token: 0x0600A78F RID: 42895 RVA: 0x0017AA79 File Offset: 0x00178C79
		public virtual IVisualNovelDate Date
		{
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
			set
			{
				this.GetOrCreatePoco().Date = value;
				this._DateInited = false;
			}
		}

		// Token: 0x1700333B RID: 13115
		// (get) Token: 0x0600A790 RID: 42896 RVA: 0x0017AA8E File Offset: 0x00178C8E
		// (set) Token: 0x0600A791 RID: 42897 RVA: 0x0017AAB9 File Offset: 0x00178CB9
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

		// Token: 0x040063E9 RID: 25577
		[Nullable(2)]
		protected ISolarSchoolTime FbInstance;

		// Token: 0x040063EA RID: 25578
		[Nullable(2)]
		protected ISolarSchoolTime_SetValue PocoInterface;

		// Token: 0x040063EB RID: 25579
		private IVisualNovelDate _DateCache;

		// Token: 0x040063EC RID: 25580
		private bool _DateInited;
	}
}
