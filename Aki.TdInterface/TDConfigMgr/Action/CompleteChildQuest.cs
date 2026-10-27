using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200151A RID: 5402
	[NullableContext(1)]
	[Nullable(0)]
	public class CompleteChildQuest : ActionParams
	{
		// Token: 0x06007AB2 RID: 31410 RVA: 0x00124CA0 File Offset: 0x00122EA0
		private CompleteChildQuest_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("CompleteChildQuest 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			CompleteChildQuest_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new CompleteChildQuest_SetValue());
			}
			return result;
		}

		// Token: 0x06007AB3 RID: 31411 RVA: 0x00124CD8 File Offset: 0x00122ED8
		public static CompleteChildQuest Create([Nullable(2)] CompleteChildQuest instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CompleteChildQuest
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007AB4 RID: 31412 RVA: 0x00124CEB File Offset: 0x00122EEB
		public static CompleteChildQuest CreateFromSetValue([Nullable(2)] CompleteChildQuest_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new CompleteChildQuest
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007AB5 RID: 31413 RVA: 0x00124CFE File Offset: 0x00122EFE
		public CompleteChildQuest_SetValue ToSetValue()
		{
			return new CompleteChildQuest_SetValue
			{
				QuestId = this.QuestId,
				NodeId = this.NodeId
			};
		}

		// Token: 0x170028EA RID: 10474
		// (get) Token: 0x06007AB6 RID: 31414 RVA: 0x00124D1D File Offset: 0x00122F1D
		// (set) Token: 0x06007AB7 RID: 31415 RVA: 0x00124D48 File Offset: 0x00122F48
		public virtual int QuestId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.QuestId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.QuestId;
			}
			set
			{
				this.GetOrCreatePoco().QuestId = value;
			}
		}

		// Token: 0x170028EB RID: 10475
		// (get) Token: 0x06007AB8 RID: 31416 RVA: 0x00124D56 File Offset: 0x00122F56
		// (set) Token: 0x06007AB9 RID: 31417 RVA: 0x00124D81 File Offset: 0x00122F81
		public virtual int NodeId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.NodeId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.NodeId;
			}
			set
			{
				this.GetOrCreatePoco().NodeId = value;
			}
		}

		// Token: 0x0400470B RID: 18187
		[Nullable(2)]
		protected new CompleteChildQuest FbInstance;

		// Token: 0x0400470C RID: 18188
		[Nullable(2)]
		protected CompleteChildQuest_SetValue PocoInterface;
	}
}
