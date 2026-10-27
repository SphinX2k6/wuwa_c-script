using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001856 RID: 6230
	[NullableContext(1)]
	[Nullable(0)]
	public class ICaptionParam
	{
		// Token: 0x060085D9 RID: 34265 RVA: 0x0013E3BC File Offset: 0x0013C5BC
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

		// Token: 0x060085DA RID: 34266 RVA: 0x0013E3F4 File Offset: 0x0013C5F4
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

		// Token: 0x060085DB RID: 34267 RVA: 0x0013E407 File Offset: 0x0013C607
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

		// Token: 0x060085DC RID: 34268 RVA: 0x0013E41A File Offset: 0x0013C61A
		public ICaptionParam_SetValue ToSetValue()
		{
			return new ICaptionParam_SetValue
			{
				StartTime = this.StartTime,
				TotalTime = this.TotalTime,
				IntervalTime = this.IntervalTime
			};
		}

		// Token: 0x17002BC0 RID: 11200
		// (get) Token: 0x060085DD RID: 34269 RVA: 0x0013E448 File Offset: 0x0013C648
		// (set) Token: 0x060085DE RID: 34270 RVA: 0x0013E482 File Offset: 0x0013C682
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

		// Token: 0x17002BC1 RID: 11201
		// (get) Token: 0x060085DF RID: 34271 RVA: 0x0013E490 File Offset: 0x0013C690
		// (set) Token: 0x060085E0 RID: 34272 RVA: 0x0013E4CA File Offset: 0x0013C6CA
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

		// Token: 0x17002BC2 RID: 11202
		// (get) Token: 0x060085E1 RID: 34273 RVA: 0x0013E4D8 File Offset: 0x0013C6D8
		// (set) Token: 0x060085E2 RID: 34274 RVA: 0x0013E512 File Offset: 0x0013C712
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

		// Token: 0x04005481 RID: 21633
		[Nullable(2)]
		protected ICaptionParam FbInstance;

		// Token: 0x04005482 RID: 21634
		[Nullable(2)]
		protected ICaptionParam_SetValue PocoInterface;
	}
}
