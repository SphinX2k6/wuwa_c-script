using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021C5 RID: 8645
	public class ITalkSequenceTransition
	{
		// Token: 0x0600BC74 RID: 48244 RVA: 0x001B454C File Offset: 0x001B274C
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

		// Token: 0x0600BC75 RID: 48245 RVA: 0x001B4584 File Offset: 0x001B2784
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

		// Token: 0x0600BC76 RID: 48246 RVA: 0x001B4597 File Offset: 0x001B2797
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

		// Token: 0x0600BC77 RID: 48247 RVA: 0x001B45AA File Offset: 0x001B27AA
		public ITalkSequenceTransition_SetValue ToSetValue()
		{
			return new ITalkSequenceTransition_SetValue
			{
				OptionText = this.OptionText,
				OptionTextKey = this.OptionTextKey,
				NextSequenceIndex = this.NextSequenceIndex
			};
		}

		// Token: 0x170039A2 RID: 14754
		// (get) Token: 0x0600BC78 RID: 48248 RVA: 0x001B45D5 File Offset: 0x001B27D5
		// (set) Token: 0x0600BC79 RID: 48249 RVA: 0x001B4600 File Offset: 0x001B2800
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

		// Token: 0x170039A3 RID: 14755
		// (get) Token: 0x0600BC7A RID: 48250 RVA: 0x001B460E File Offset: 0x001B280E
		// (set) Token: 0x0600BC7B RID: 48251 RVA: 0x001B4639 File Offset: 0x001B2839
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

		// Token: 0x170039A4 RID: 14756
		// (get) Token: 0x0600BC7C RID: 48252 RVA: 0x001B4647 File Offset: 0x001B2847
		// (set) Token: 0x0600BC7D RID: 48253 RVA: 0x001B4672 File Offset: 0x001B2872
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

		// Token: 0x04007149 RID: 29001
		[Nullable(2)]
		protected ITalkSequenceTransition FbInstance;

		// Token: 0x0400714A RID: 29002
		[Nullable(2)]
		protected ITalkSequenceTransition_SetValue PocoInterface;
	}
}
