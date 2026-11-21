using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019A7 RID: 6567
	public class IBubbleData : ActionParams
	{
		// Token: 0x06008B9B RID: 35739 RVA: 0x0014B068 File Offset: 0x00149268
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

		// Token: 0x06008B9C RID: 35740 RVA: 0x0014B0A0 File Offset: 0x001492A0
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

		// Token: 0x06008B9D RID: 35741 RVA: 0x0014B0B3 File Offset: 0x001492B3
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

		// Token: 0x06008B9E RID: 35742 RVA: 0x0014B0C6 File Offset: 0x001492C6
		public IBubbleData_SetValue ToSetValue()
		{
			return new IBubbleData_SetValue
			{
				FlowIndex = this.FlowIndex,
				WaitTime = this.WaitTime
			};
		}

		// Token: 0x17002D5F RID: 11615
		// (get) Token: 0x06008B9F RID: 35743 RVA: 0x0014B0E8 File Offset: 0x001492E8
		// (set) Token: 0x06008BA0 RID: 35744 RVA: 0x0014B149 File Offset: 0x00149349
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

		// Token: 0x17002D60 RID: 11616
		// (get) Token: 0x06008BA1 RID: 35745 RVA: 0x0014B15E File Offset: 0x0014935E
		// (set) Token: 0x06008BA2 RID: 35746 RVA: 0x0014B189 File Offset: 0x00149389
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

		// Token: 0x0400581E RID: 22558
		[Nullable(2)]
		protected new IBubbleData FbInstance;

		// Token: 0x0400581F RID: 22559
		[Nullable(2)]
		protected IBubbleData_SetValue PocoInterface;

		// Token: 0x04005820 RID: 22560
		private IBubbleIndex _FlowIndexCache;

		// Token: 0x04005821 RID: 22561
		private bool _FlowIndexInited;
	}
}
