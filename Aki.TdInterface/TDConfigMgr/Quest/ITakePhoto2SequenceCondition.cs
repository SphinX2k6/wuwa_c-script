using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012AA RID: 4778
	public class ITakePhoto2SequenceCondition
	{
		// Token: 0x06006BA1 RID: 27553 RVA: 0x00100E7C File Offset: 0x000FF07C
		private ITakePhoto2SequenceCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITakePhoto2SequenceCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITakePhoto2SequenceCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITakePhoto2SequenceCondition_SetValue());
			}
			return result;
		}

		// Token: 0x06006BA2 RID: 27554 RVA: 0x00100EB4 File Offset: 0x000FF0B4
		public static ITakePhoto2SequenceCondition Create([Nullable(2)] ITakePhoto2SequenceCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2SequenceCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006BA3 RID: 27555 RVA: 0x00100EC7 File Offset: 0x000FF0C7
		public static ITakePhoto2SequenceCondition CreateFromSetValue([Nullable(2)] ITakePhoto2SequenceCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITakePhoto2SequenceCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006BA4 RID: 27556 RVA: 0x00100EDA File Offset: 0x000FF0DA
		public ITakePhoto2SequenceCondition_SetValue ToSetValue()
		{
			return new ITakePhoto2SequenceCondition_SetValue
			{
				SequencePath = this.SequencePath
			};
		}

		// Token: 0x170022D1 RID: 8913
		// (get) Token: 0x06006BA5 RID: 27557 RVA: 0x00100EED File Offset: 0x000FF0ED
		// (set) Token: 0x06006BA6 RID: 27558 RVA: 0x00100F18 File Offset: 0x000FF118
		public virtual string SequencePath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SequencePath;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.SequencePath;
			}
			set
			{
				this.GetOrCreatePoco().SequencePath = value;
			}
		}

		// Token: 0x04004049 RID: 16457
		[Nullable(2)]
		protected ITakePhoto2SequenceCondition FbInstance;

		// Token: 0x0400404A RID: 16458
		[Nullable(2)]
		protected ITakePhoto2SequenceCondition_SetValue PocoInterface;
	}
}
