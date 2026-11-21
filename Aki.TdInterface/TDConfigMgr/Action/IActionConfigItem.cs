using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018D5 RID: 6357
	public class IActionConfigItem : IActionFunctionalConfigItem
	{
		// Token: 0x06008559 RID: 34137 RVA: 0x0013DE40 File Offset: 0x0013C040
		private IActionConfigItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActionConfigItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActionConfigItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActionConfigItem_SetValue());
			}
			return result;
		}

		// Token: 0x0600855A RID: 34138 RVA: 0x0013DE78 File Offset: 0x0013C078
		public static IActionConfigItem Create([Nullable(2)] IActionConfigItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActionConfigItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600855B RID: 34139 RVA: 0x0013DE8B File Offset: 0x0013C08B
		public static IActionConfigItem CreateFromSetValue([Nullable(2)] IActionConfigItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActionConfigItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600855C RID: 34140 RVA: 0x0013DEA0 File Offset: 0x0013C0A0
		public new IActionConfigItem_SetValue ToSetValue()
		{
			return new IActionConfigItem_SetValue
			{
				OnlineParticipateRule = this.OnlineParticipateRule,
				IsDetectScreenOccupation = this.IsDetectScreenOccupation,
				IsWithResultOnly = this.IsWithResultOnly,
				IsOperatePlayer = this.IsOperatePlayer,
				CnName = this.CnName
			};
		}

		// Token: 0x17002B79 RID: 11129
		// (get) Token: 0x0600855D RID: 34141 RVA: 0x0013DEF0 File Offset: 0x0013C0F0
		// (set) Token: 0x0600855E RID: 34142 RVA: 0x0013DF2A File Offset: 0x0013C12A
		public override EOnlineParticipateRule? OnlineParticipateRule
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.OnlineParticipateRule;
				}
				IActionConfigItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.OnlineParticipateRule;
			}
			set
			{
				this.GetOrCreatePoco().OnlineParticipateRule = value;
			}
		}

		// Token: 0x17002B7A RID: 11130
		// (get) Token: 0x0600855F RID: 34143 RVA: 0x0013DF38 File Offset: 0x0013C138
		// (set) Token: 0x06008560 RID: 34144 RVA: 0x0013DF72 File Offset: 0x0013C172
		public override bool? IsDetectScreenOccupation
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsDetectScreenOccupation;
				}
				IActionConfigItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsDetectScreenOccupation;
			}
			set
			{
				this.GetOrCreatePoco().IsDetectScreenOccupation = value;
			}
		}

		// Token: 0x17002B7B RID: 11131
		// (get) Token: 0x06008561 RID: 34145 RVA: 0x0013DF80 File Offset: 0x0013C180
		// (set) Token: 0x06008562 RID: 34146 RVA: 0x0013DFBA File Offset: 0x0013C1BA
		public override bool? IsWithResultOnly
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsWithResultOnly;
				}
				IActionConfigItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsWithResultOnly;
			}
			set
			{
				this.GetOrCreatePoco().IsWithResultOnly = value;
			}
		}

		// Token: 0x17002B7C RID: 11132
		// (get) Token: 0x06008563 RID: 34147 RVA: 0x0013DFC8 File Offset: 0x0013C1C8
		// (set) Token: 0x06008564 RID: 34148 RVA: 0x0013E002 File Offset: 0x0013C202
		public override bool? IsOperatePlayer
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsOperatePlayer;
				}
				IActionConfigItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsOperatePlayer;
			}
			set
			{
				this.GetOrCreatePoco().IsOperatePlayer = value;
			}
		}

		// Token: 0x17002B7D RID: 11133
		// (get) Token: 0x06008565 RID: 34149 RVA: 0x0013E010 File Offset: 0x0013C210
		// (set) Token: 0x06008566 RID: 34150 RVA: 0x0013E03B File Offset: 0x0013C23B
		public virtual string CnName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CnName;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.CnName;
			}
			set
			{
				this.GetOrCreatePoco().CnName = value;
			}
		}

		// Token: 0x040054BC RID: 21692
		[Nullable(2)]
		protected new IActionConfigItem FbInstance;

		// Token: 0x040054BD RID: 21693
		[Nullable(2)]
		protected new IActionConfigItem_SetValue PocoInterface;
	}
}
