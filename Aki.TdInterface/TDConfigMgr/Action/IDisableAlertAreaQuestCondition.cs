using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B27 RID: 6951
	public class IDisableAlertAreaQuestCondition : IDisableAlertAreaCondition
	{
		// Token: 0x06009385 RID: 37765 RVA: 0x00158E6C File Offset: 0x0015706C
		private IDisableAlertAreaQuestCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDisableAlertAreaQuestCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDisableAlertAreaQuestCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDisableAlertAreaQuestCondition_SetValue());
			}
			return result;
		}

		// Token: 0x06009386 RID: 37766 RVA: 0x00158EA4 File Offset: 0x001570A4
		public static IDisableAlertAreaQuestCondition Create([Nullable(2)] IDisableAlertAreaQuestCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableAlertAreaQuestCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009387 RID: 37767 RVA: 0x00158EB7 File Offset: 0x001570B7
		public static IDisableAlertAreaQuestCondition CreateFromSetValue([Nullable(2)] IDisableAlertAreaQuestCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDisableAlertAreaQuestCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009388 RID: 37768 RVA: 0x00158ECA File Offset: 0x001570CA
		public new IDisableAlertAreaQuestCondition_SetValue ToSetValue()
		{
			return new IDisableAlertAreaQuestCondition_SetValue
			{
				Type = this.Type,
				RelatedQuestId = this.RelatedQuestId
			};
		}

		// Token: 0x17002F14 RID: 12052
		// (get) Token: 0x06009389 RID: 37769 RVA: 0x00158EE9 File Offset: 0x001570E9
		// (set) Token: 0x0600938A RID: 37770 RVA: 0x00158F14 File Offset: 0x00157114
		public override EDisableAlertAreaCondition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDisableAlertAreaCondition.DungeonCondition;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002F15 RID: 12053
		// (get) Token: 0x0600938B RID: 37771 RVA: 0x00158F22 File Offset: 0x00157122
		// (set) Token: 0x0600938C RID: 37772 RVA: 0x00158F4D File Offset: 0x0015714D
		public virtual int RelatedQuestId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RelatedQuestId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RelatedQuestId;
			}
			set
			{
				this.GetOrCreatePoco().RelatedQuestId = value;
			}
		}

		// Token: 0x04005BAD RID: 23469
		[Nullable(2)]
		protected new IDisableAlertAreaQuestCondition FbInstance;

		// Token: 0x04005BAE RID: 23470
		[Nullable(2)]
		protected new IDisableAlertAreaQuestCondition_SetValue PocoInterface;
	}
}
