using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001284 RID: 4740
	public class ISurvivorsRougeConditionStepBattle : ISurvivorsRougeConditionStepBase
	{
		// Token: 0x06006AD1 RID: 27345 RVA: 0x000FF538 File Offset: 0x000FD738
		private ISurvivorsRougeConditionStepBattle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISurvivorsRougeConditionStepBattle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISurvivorsRougeConditionStepBattle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISurvivorsRougeConditionStepBattle_SetValue());
			}
			return result;
		}

		// Token: 0x06006AD2 RID: 27346 RVA: 0x000FF570 File Offset: 0x000FD770
		public static ISurvivorsRougeConditionStepBattle Create([Nullable(2)] ISurvivorsRougeConditionStepBattle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISurvivorsRougeConditionStepBattle
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006AD3 RID: 27347 RVA: 0x000FF583 File Offset: 0x000FD783
		public static ISurvivorsRougeConditionStepBattle CreateFromSetValue([Nullable(2)] ISurvivorsRougeConditionStepBattle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISurvivorsRougeConditionStepBattle
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006AD4 RID: 27348 RVA: 0x000FF596 File Offset: 0x000FD796
		public new ISurvivorsRougeConditionStepBattle_SetValue ToSetValue()
		{
			return new ISurvivorsRougeConditionStepBattle_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170022A2 RID: 8866
		// (get) Token: 0x06006AD5 RID: 27349 RVA: 0x000FF5A9 File Offset: 0x000FD7A9
		// (set) Token: 0x06006AD6 RID: 27350 RVA: 0x000FF5D4 File Offset: 0x000FD7D4
		public override ESurvivorsRougeConditionStep Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESurvivorsRougeConditionStep.Prepare;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003FD8 RID: 16344
		[Nullable(2)]
		protected new ISurvivorsRougeConditionStepBattle FbInstance;

		// Token: 0x04003FD9 RID: 16345
		[Nullable(2)]
		protected new ISurvivorsRougeConditionStepBattle_SetValue PocoInterface;
	}
}
