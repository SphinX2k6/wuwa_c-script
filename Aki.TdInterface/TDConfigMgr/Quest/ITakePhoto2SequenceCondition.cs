using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001172 RID: 4466
	[NullableContext(1)]
	[Nullable(0)]
	public class ITakePhoto2SequenceCondition
	{
		// Token: 0x06006572 RID: 25970 RVA: 0x000F376C File Offset: 0x000F196C
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

		// Token: 0x06006573 RID: 25971 RVA: 0x000F37A4 File Offset: 0x000F19A4
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

		// Token: 0x06006574 RID: 25972 RVA: 0x000F37B7 File Offset: 0x000F19B7
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

		// Token: 0x06006575 RID: 25973 RVA: 0x000F37CA File Offset: 0x000F19CA
		public ITakePhoto2SequenceCondition_SetValue ToSetValue()
		{
			return new ITakePhoto2SequenceCondition_SetValue
			{
				SequencePath = this.SequencePath
			};
		}

		// Token: 0x17002113 RID: 8467
		// (get) Token: 0x06006576 RID: 25974 RVA: 0x000F37DD File Offset: 0x000F19DD
		// (set) Token: 0x06006577 RID: 25975 RVA: 0x000F3808 File Offset: 0x000F1A08
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

		// Token: 0x04003CE4 RID: 15588
		[Nullable(2)]
		protected ITakePhoto2SequenceCondition FbInstance;

		// Token: 0x04003CE5 RID: 15589
		[Nullable(2)]
		protected ITakePhoto2SequenceCondition_SetValue PocoInterface;
	}
}
