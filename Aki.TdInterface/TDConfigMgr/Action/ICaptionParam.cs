using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019E1 RID: 6625
	public class ICaptionParam
	{
		// Token: 0x06008CFF RID: 36095 RVA: 0x0014DBB0 File Offset: 0x0014BDB0
		private ICaptionParam_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICaptionParam 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICaptionParam_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICaptionParam_SetValue());
			}
			return result;
		}

		// Token: 0x06008D00 RID: 36096 RVA: 0x0014DBE8 File Offset: 0x0014BDE8
		public static ICaptionParam Create([Nullable(2)] ICaptionParam instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICaptionParam
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008D01 RID: 36097 RVA: 0x0014DBFB File Offset: 0x0014BDFB
		public static ICaptionParam CreateFromSetValue([Nullable(2)] ICaptionParam_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICaptionParam
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008D02 RID: 36098 RVA: 0x0014DC0E File Offset: 0x0014BE0E
		public ICaptionParam_SetValue ToSetValue()
		{
			return new ICaptionParam_SetValue
			{
				StartTime = this.StartTime,
				TotalTime = this.TotalTime,
				IntervalTime = this.IntervalTime
			};
		}

		// Token: 0x17002DBA RID: 11706
		// (get) Token: 0x06008D03 RID: 36099 RVA: 0x0014DC3C File Offset: 0x0014BE3C
		// (set) Token: 0x06008D04 RID: 36100 RVA: 0x0014DC76 File Offset: 0x0014BE76
		public virtual float? StartTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StartTime;
				}
				ICaptionParam_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StartTime;
			}
			set
			{
				this.GetOrCreatePoco().StartTime = value;
			}
		}

		// Token: 0x17002DBB RID: 11707
		// (get) Token: 0x06008D05 RID: 36101 RVA: 0x0014DC84 File Offset: 0x0014BE84
		// (set) Token: 0x06008D06 RID: 36102 RVA: 0x0014DCBE File Offset: 0x0014BEBE
		public virtual float? TotalTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TotalTime;
				}
				ICaptionParam_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TotalTime;
			}
			set
			{
				this.GetOrCreatePoco().TotalTime = value;
			}
		}

		// Token: 0x17002DBC RID: 11708
		// (get) Token: 0x06008D07 RID: 36103 RVA: 0x0014DCCC File Offset: 0x0014BECC
		// (set) Token: 0x06008D08 RID: 36104 RVA: 0x0014DD06 File Offset: 0x0014BF06
		public virtual float? IntervalTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IntervalTime;
				}
				ICaptionParam_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IntervalTime;
			}
			set
			{
				this.GetOrCreatePoco().IntervalTime = value;
			}
		}

		// Token: 0x040058CD RID: 22733
		[Nullable(2)]
		protected ICaptionParam FbInstance;

		// Token: 0x040058CE RID: 22734
		[Nullable(2)]
		protected ICaptionParam_SetValue PocoInterface;
	}
}
