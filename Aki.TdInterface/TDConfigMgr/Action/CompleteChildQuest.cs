using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001673 RID: 5747
	public class CompleteChildQuest : ActionParams
	{
		// Token: 0x0600817D RID: 33149 RVA: 0x001338C8 File Offset: 0x00131AC8
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

		// Token: 0x0600817E RID: 33150 RVA: 0x00133900 File Offset: 0x00131B00
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

		// Token: 0x0600817F RID: 33151 RVA: 0x00133913 File Offset: 0x00131B13
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

		// Token: 0x06008180 RID: 33152 RVA: 0x00133926 File Offset: 0x00131B26
		public CompleteChildQuest_SetValue ToSetValue()
		{
			return new CompleteChildQuest_SetValue
			{
				QuestId = this.QuestId,
				NodeId = this.NodeId
			};
		}

		// Token: 0x17002AD3 RID: 10963
		// (get) Token: 0x06008181 RID: 33153 RVA: 0x00133945 File Offset: 0x00131B45
		// (set) Token: 0x06008182 RID: 33154 RVA: 0x00133970 File Offset: 0x00131B70
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

		// Token: 0x17002AD4 RID: 10964
		// (get) Token: 0x06008183 RID: 33155 RVA: 0x0013397E File Offset: 0x00131B7E
		// (set) Token: 0x06008184 RID: 33156 RVA: 0x001339A9 File Offset: 0x00131BA9
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

		// Token: 0x04004AA7 RID: 19111
		[Nullable(2)]
		protected new CompleteChildQuest FbInstance;

		// Token: 0x04004AA8 RID: 19112
		[Nullable(2)]
		protected CompleteChildQuest_SetValue PocoInterface;
	}
}
