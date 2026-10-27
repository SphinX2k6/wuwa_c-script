using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011A0 RID: 4512
	[NullableContext(1)]
	[Nullable(0)]
	public class ITimeRange
	{
		// Token: 0x0600666A RID: 26218 RVA: 0x000F56A8 File Offset: 0x000F38A8
		private ITimeRange_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITimeRange 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITimeRange_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITimeRange_SetValue());
			}
			return result;
		}

		// Token: 0x0600666B RID: 26219 RVA: 0x000F56E0 File Offset: 0x000F38E0
		public static ITimeRange Create([Nullable(2)] ITimeRange instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeRange
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600666C RID: 26220 RVA: 0x000F56F3 File Offset: 0x000F38F3
		public static ITimeRange CreateFromSetValue([Nullable(2)] ITimeRange_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITimeRange
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600666D RID: 26221 RVA: 0x000F5706 File Offset: 0x000F3906
		public ITimeRange_SetValue ToSetValue()
		{
			return new ITimeRange_SetValue
			{
				StartTime = this.StartTime,
				EndTime = this.EndTime
			};
		}

		// Token: 0x1700214A RID: 8522
		// (get) Token: 0x0600666E RID: 26222 RVA: 0x000F5728 File Offset: 0x000F3928
		// (set) Token: 0x0600666F RID: 26223 RVA: 0x000F5789 File Offset: 0x000F3989
		public virtual IDateTime StartTime
		{
			get
			{
				if (this._StartTimeInited)
				{
					return this._StartTimeCache;
				}
				this._StartTimeInited = true;
				if (this.FbInstance != null)
				{
					this._StartTimeCache = IDateTime.Create(this.FbInstance.StartTime);
				}
				else
				{
					ITimeRange_SetValue pocoInterface = this.PocoInterface;
					this._StartTimeCache = ((pocoInterface != null) ? pocoInterface.StartTime : null);
				}
				return this._StartTimeCache;
			}
			set
			{
				this.GetOrCreatePoco().StartTime = value;
				this._StartTimeInited = false;
			}
		}

		// Token: 0x1700214B RID: 8523
		// (get) Token: 0x06006670 RID: 26224 RVA: 0x000F57A0 File Offset: 0x000F39A0
		// (set) Token: 0x06006671 RID: 26225 RVA: 0x000F5801 File Offset: 0x000F3A01
		public virtual IDateTime EndTime
		{
			get
			{
				if (this._EndTimeInited)
				{
					return this._EndTimeCache;
				}
				this._EndTimeInited = true;
				if (this.FbInstance != null)
				{
					this._EndTimeCache = IDateTime.Create(this.FbInstance.EndTime);
				}
				else
				{
					ITimeRange_SetValue pocoInterface = this.PocoInterface;
					this._EndTimeCache = ((pocoInterface != null) ? pocoInterface.EndTime : null);
				}
				return this._EndTimeCache;
			}
			set
			{
				this.GetOrCreatePoco().EndTime = value;
				this._EndTimeInited = false;
			}
		}

		// Token: 0x04003D71 RID: 15729
		[Nullable(2)]
		protected ITimeRange FbInstance;

		// Token: 0x04003D72 RID: 15730
		[Nullable(2)]
		protected ITimeRange_SetValue PocoInterface;

		// Token: 0x04003D73 RID: 15731
		private IDateTime _StartTimeCache;

		// Token: 0x04003D74 RID: 15732
		private bool _StartTimeInited;

		// Token: 0x04003D75 RID: 15733
		private IDateTime _EndTimeCache;

		// Token: 0x04003D76 RID: 15734
		private bool _EndTimeInited;
	}
}
