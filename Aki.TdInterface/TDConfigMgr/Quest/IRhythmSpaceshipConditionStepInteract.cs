using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001222 RID: 4642
	public class IRhythmSpaceshipConditionStepInteract : IRhythmSpaceshipConditionStepBase
	{
		// Token: 0x0600682D RID: 26669 RVA: 0x000F9C80 File Offset: 0x000F7E80
		private IRhythmSpaceshipConditionStepInteract_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRhythmSpaceshipConditionStepInteract 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRhythmSpaceshipConditionStepInteract_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRhythmSpaceshipConditionStepInteract_SetValue());
			}
			return result;
		}

		// Token: 0x0600682E RID: 26670 RVA: 0x000F9CB8 File Offset: 0x000F7EB8
		public static IRhythmSpaceshipConditionStepInteract Create([Nullable(2)] IRhythmSpaceshipConditionStepInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRhythmSpaceshipConditionStepInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600682F RID: 26671 RVA: 0x000F9CCB File Offset: 0x000F7ECB
		public static IRhythmSpaceshipConditionStepInteract CreateFromSetValue([Nullable(2)] IRhythmSpaceshipConditionStepInteract_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRhythmSpaceshipConditionStepInteract
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006830 RID: 26672 RVA: 0x000F9CDE File Offset: 0x000F7EDE
		public new IRhythmSpaceshipConditionStepInteract_SetValue ToSetValue()
		{
			return new IRhythmSpaceshipConditionStepInteract_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170021E2 RID: 8674
		// (get) Token: 0x06006831 RID: 26673 RVA: 0x000F9CF1 File Offset: 0x000F7EF1
		// (set) Token: 0x06006832 RID: 26674 RVA: 0x000F9D1C File Offset: 0x000F7F1C
		public override ERhythmSpaceshipConditionStep Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERhythmSpaceshipConditionStep.Interact;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003E52 RID: 15954
		[Nullable(2)]
		protected new IRhythmSpaceshipConditionStepInteract FbInstance;

		// Token: 0x04003E53 RID: 15955
		[Nullable(2)]
		protected new IRhythmSpaceshipConditionStepInteract_SetValue PocoInterface;
	}
}
