using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FE0 RID: 4064
	public class IAreaQuestTracking
	{
		// Token: 0x06005912 RID: 22802 RVA: 0x000D9B24 File Offset: 0x000D7D24
		private IAreaQuestTracking_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAreaQuestTracking 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAreaQuestTracking_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAreaQuestTracking_SetValue());
			}
			return result;
		}

		// Token: 0x06005913 RID: 22803 RVA: 0x000D9B5C File Offset: 0x000D7D5C
		public static IAreaQuestTracking Create([Nullable(2)] IAreaQuestTracking instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAreaQuestTracking
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005914 RID: 22804 RVA: 0x000D9B6F File Offset: 0x000D7D6F
		public static IAreaQuestTracking CreateFromSetValue([Nullable(2)] IAreaQuestTracking_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAreaQuestTracking
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005915 RID: 22805 RVA: 0x000D9B82 File Offset: 0x000D7D82
		public IAreaQuestTracking_SetValue ToSetValue()
		{
			return new IAreaQuestTracking_SetValue
			{
				QuestId = this.QuestId,
				NodeId = this.NodeId,
				AreaIds = this.AreaIds
			};
		}

		// Token: 0x17001DB3 RID: 7603
		// (get) Token: 0x06005916 RID: 22806 RVA: 0x000D9BAD File Offset: 0x000D7DAD
		// (set) Token: 0x06005917 RID: 22807 RVA: 0x000D9BD8 File Offset: 0x000D7DD8
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

		// Token: 0x17001DB4 RID: 7604
		// (get) Token: 0x06005918 RID: 22808 RVA: 0x000D9BE6 File Offset: 0x000D7DE6
		// (set) Token: 0x06005919 RID: 22809 RVA: 0x000D9C11 File Offset: 0x000D7E11
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

		// Token: 0x17001DB5 RID: 7605
		// (get) Token: 0x0600591A RID: 22810 RVA: 0x000D9C1F File Offset: 0x000D7E1F
		// (set) Token: 0x0600591B RID: 22811 RVA: 0x000D9C46 File Offset: 0x000D7E46
		public virtual List<int> AreaIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AreaIds;
				}
				IAreaQuestTracking_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AreaIds;
			}
			set
			{
				this.GetOrCreatePoco().AreaIds = value;
			}
		}

		// Token: 0x040035AE RID: 13742
		[Nullable(2)]
		protected IAreaQuestTracking FbInstance;

		// Token: 0x040035AF RID: 13743
		[Nullable(2)]
		protected IAreaQuestTracking_SetValue PocoInterface;
	}
}
