using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200181C RID: 6172
	[NullableContext(1)]
	[Nullable(0)]
	public class IBubbleData : ActionParams
	{
		// Token: 0x06008475 RID: 33909 RVA: 0x0013B874 File Offset: 0x00139A74
		private IBubbleData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBubbleData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBubbleData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBubbleData_SetValue());
			}
			return result;
		}

		// Token: 0x06008476 RID: 33910 RVA: 0x0013B8AC File Offset: 0x00139AAC
		public static IBubbleData Create([Nullable(2)] IBubbleData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBubbleData
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008477 RID: 33911 RVA: 0x0013B8BF File Offset: 0x00139ABF
		public static IBubbleData CreateFromSetValue([Nullable(2)] IBubbleData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBubbleData
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008478 RID: 33912 RVA: 0x0013B8D2 File Offset: 0x00139AD2
		public IBubbleData_SetValue ToSetValue()
		{
			return new IBubbleData_SetValue
			{
				FlowIndex = this.FlowIndex,
				WaitTime = this.WaitTime
			};
		}

		// Token: 0x17002B65 RID: 11109
		// (get) Token: 0x06008479 RID: 33913 RVA: 0x0013B8F4 File Offset: 0x00139AF4
		// (set) Token: 0x0600847A RID: 33914 RVA: 0x0013B955 File Offset: 0x00139B55
		public virtual IBubbleIndex FlowIndex
		{
			get
			{
				if (this._FlowIndexInited)
				{
					return this._FlowIndexCache;
				}
				this._FlowIndexInited = true;
				if (this.FbInstance != null)
				{
					this._FlowIndexCache = IBubbleIndex.Create(this.FbInstance.FlowIndex);
				}
				else
				{
					IBubbleData_SetValue pocoInterface = this.PocoInterface;
					this._FlowIndexCache = ((pocoInterface != null) ? pocoInterface.FlowIndex : null);
				}
				return this._FlowIndexCache;
			}
			set
			{
				this.GetOrCreatePoco().FlowIndex = value;
				this._FlowIndexInited = false;
			}
		}

		// Token: 0x17002B66 RID: 11110
		// (get) Token: 0x0600847B RID: 33915 RVA: 0x0013B96A File Offset: 0x00139B6A
		// (set) Token: 0x0600847C RID: 33916 RVA: 0x0013B995 File Offset: 0x00139B95
		public virtual int WaitTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.WaitTime;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.WaitTime;
			}
			set
			{
				this.GetOrCreatePoco().WaitTime = value;
			}
		}

		// Token: 0x040053D2 RID: 21458
		[Nullable(2)]
		protected new IBubbleData FbInstance;

		// Token: 0x040053D3 RID: 21459
		[Nullable(2)]
		protected IBubbleData_SetValue PocoInterface;

		// Token: 0x040053D4 RID: 21460
		private IBubbleIndex _FlowIndexCache;

		// Token: 0x040053D5 RID: 21461
		private bool _FlowIndexInited;
	}
}
