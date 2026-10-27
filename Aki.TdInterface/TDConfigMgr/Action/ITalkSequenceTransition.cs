using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F88 RID: 8072
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkSequenceTransition
	{
		// Token: 0x0600B190 RID: 45456 RVA: 0x0019E4B8 File Offset: 0x0019C6B8
		private ITalkSequenceTransition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkSequenceTransition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkSequenceTransition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkSequenceTransition_SetValue());
			}
			return result;
		}

		// Token: 0x0600B191 RID: 45457 RVA: 0x0019E4F0 File Offset: 0x0019C6F0
		public static ITalkSequenceTransition Create([Nullable(2)] ITalkSequenceTransition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkSequenceTransition
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B192 RID: 45458 RVA: 0x0019E503 File Offset: 0x0019C703
		public static ITalkSequenceTransition CreateFromSetValue([Nullable(2)] ITalkSequenceTransition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkSequenceTransition
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B193 RID: 45459 RVA: 0x0019E516 File Offset: 0x0019C716
		public ITalkSequenceTransition_SetValue ToSetValue()
		{
			return new ITalkSequenceTransition_SetValue
			{
				OptionText = this.OptionText,
				OptionTextKey = this.OptionTextKey,
				NextSequenceIndex = this.NextSequenceIndex
			};
		}

		// Token: 0x170036D4 RID: 14036
		// (get) Token: 0x0600B194 RID: 45460 RVA: 0x0019E541 File Offset: 0x0019C741
		// (set) Token: 0x0600B195 RID: 45461 RVA: 0x0019E56C File Offset: 0x0019C76C
		public virtual string OptionText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.OptionText;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.OptionText;
			}
			set
			{
				this.GetOrCreatePoco().OptionText = value;
			}
		}

		// Token: 0x170036D5 RID: 14037
		// (get) Token: 0x0600B196 RID: 45462 RVA: 0x0019E57A File Offset: 0x0019C77A
		// (set) Token: 0x0600B197 RID: 45463 RVA: 0x0019E5A5 File Offset: 0x0019C7A5
		public virtual string OptionTextKey
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.OptionTextKey;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.OptionTextKey;
			}
			set
			{
				this.GetOrCreatePoco().OptionTextKey = value;
			}
		}

		// Token: 0x170036D6 RID: 14038
		// (get) Token: 0x0600B198 RID: 45464 RVA: 0x0019E5B3 File Offset: 0x0019C7B3
		// (set) Token: 0x0600B199 RID: 45465 RVA: 0x0019E5DE File Offset: 0x0019C7DE
		public virtual int NextSequenceIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.NextSequenceIndex;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.NextSequenceIndex;
			}
			set
			{
				this.GetOrCreatePoco().NextSequenceIndex = value;
			}
		}

		// Token: 0x04006B5B RID: 27483
		[Nullable(2)]
		protected ITalkSequenceTransition FbInstance;

		// Token: 0x04006B5C RID: 27484
		[Nullable(2)]
		protected ITalkSequenceTransition_SetValue PocoInterface;
	}
}
