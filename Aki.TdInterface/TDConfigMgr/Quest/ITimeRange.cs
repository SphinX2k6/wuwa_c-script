using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012DA RID: 4826
	public class ITimeRange
	{
		// Token: 0x06006CA1 RID: 27809 RVA: 0x00102E74 File Offset: 0x00101074
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

		// Token: 0x06006CA2 RID: 27810 RVA: 0x00102EAC File Offset: 0x001010AC
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

		// Token: 0x06006CA3 RID: 27811 RVA: 0x00102EBF File Offset: 0x001010BF
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

		// Token: 0x06006CA4 RID: 27812 RVA: 0x00102ED2 File Offset: 0x001010D2
		public ITimeRange_SetValue ToSetValue()
		{
			return new ITimeRange_SetValue
			{
				StartTime = this.StartTime,
				EndTime = this.EndTime
			};
		}

		// Token: 0x17002309 RID: 8969
		// (get) Token: 0x06006CA5 RID: 27813 RVA: 0x00102EF4 File Offset: 0x001010F4
		// (set) Token: 0x06006CA6 RID: 27814 RVA: 0x00102F55 File Offset: 0x00101155
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

		// Token: 0x1700230A RID: 8970
		// (get) Token: 0x06006CA7 RID: 27815 RVA: 0x00102F6C File Offset: 0x0010116C
		// (set) Token: 0x06006CA8 RID: 27816 RVA: 0x00102FCD File Offset: 0x001011CD
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

		// Token: 0x040040D9 RID: 16601
		[Nullable(2)]
		protected ITimeRange FbInstance;

		// Token: 0x040040DA RID: 16602
		[Nullable(2)]
		protected ITimeRange_SetValue PocoInterface;

		// Token: 0x040040DB RID: 16603
		private IDateTime _StartTimeCache;

		// Token: 0x040040DC RID: 16604
		private bool _StartTimeInited;

		// Token: 0x040040DD RID: 16605
		private IDateTime _EndTimeCache;

		// Token: 0x040040DE RID: 16606
		private bool _EndTimeInited;
	}
}
