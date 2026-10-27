using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001920 RID: 6432
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonTipMissionCompleteNew : ICommonTipType
	{
		// Token: 0x060089E5 RID: 35301 RVA: 0x00145328 File Offset: 0x00143528
		private ICommonTipMissionCompleteNew_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonTipMissionCompleteNew 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonTipMissionCompleteNew_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonTipMissionCompleteNew_SetValue());
			}
			return result;
		}

		// Token: 0x060089E6 RID: 35302 RVA: 0x00145360 File Offset: 0x00143560
		public static ICommonTipMissionCompleteNew Create([Nullable(2)] ICommonTipMissionCompleteNew instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTipMissionCompleteNew
			{
				FbInstance = instance
			};
		}

		// Token: 0x060089E7 RID: 35303 RVA: 0x00145373 File Offset: 0x00143573
		public static ICommonTipMissionCompleteNew CreateFromSetValue([Nullable(2)] ICommonTipMissionCompleteNew_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonTipMissionCompleteNew
			{
				PocoInterface = value
			};
		}

		// Token: 0x060089E8 RID: 35304 RVA: 0x00145386 File Offset: 0x00143586
		public new ICommonTipMissionCompleteNew_SetValue ToSetValue()
		{
			return new ICommonTipMissionCompleteNew_SetValue
			{
				Type = this.Type,
				QuestType = this.QuestType,
				TipTextKey = this.TipTextKey
			};
		}

		// Token: 0x17002C97 RID: 11415
		// (get) Token: 0x060089E9 RID: 35305 RVA: 0x001453B1 File Offset: 0x001435B1
		// (set) Token: 0x060089EA RID: 35306 RVA: 0x001453DC File Offset: 0x001435DC
		public override ECommonTipType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002C98 RID: 11416
		// (get) Token: 0x060089EB RID: 35307 RVA: 0x001453EA File Offset: 0x001435EA
		// (set) Token: 0x060089EC RID: 35308 RVA: 0x00145415 File Offset: 0x00143615
		public virtual EQuestCommonTipType QuestType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.QuestType;
				}
				if (this.PocoInterface == null)
				{
					return EQuestCommonTipType.Branch;
				}
				return this.PocoInterface.QuestType;
			}
			set
			{
				this.GetOrCreatePoco().QuestType = value;
			}
		}

		// Token: 0x17002C99 RID: 11417
		// (get) Token: 0x060089ED RID: 35309 RVA: 0x00145423 File Offset: 0x00143623
		// (set) Token: 0x060089EE RID: 35310 RVA: 0x0014544E File Offset: 0x0014364E
		public virtual string TipTextKey
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TipTextKey;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TipTextKey;
			}
			set
			{
				this.GetOrCreatePoco().TipTextKey = value;
			}
		}

		// Token: 0x0400564E RID: 22094
		[Nullable(2)]
		protected new ICommonTipMissionCompleteNew FbInstance;

		// Token: 0x0400564F RID: 22095
		[Nullable(2)]
		protected new ICommonTipMissionCompleteNew_SetValue PocoInterface;
	}
}
