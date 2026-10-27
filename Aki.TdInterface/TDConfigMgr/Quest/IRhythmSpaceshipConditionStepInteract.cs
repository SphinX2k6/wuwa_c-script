using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010F4 RID: 4340
	[NullableContext(1)]
	[Nullable(0)]
	public class IRhythmSpaceshipConditionStepInteract : IRhythmSpaceshipConditionStepBase
	{
		// Token: 0x06006232 RID: 25138 RVA: 0x000ECB0C File Offset: 0x000EAD0C
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

		// Token: 0x06006233 RID: 25139 RVA: 0x000ECB44 File Offset: 0x000EAD44
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

		// Token: 0x06006234 RID: 25140 RVA: 0x000ECB57 File Offset: 0x000EAD57
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

		// Token: 0x06006235 RID: 25141 RVA: 0x000ECB6A File Offset: 0x000EAD6A
		public new IRhythmSpaceshipConditionStepInteract_SetValue ToSetValue()
		{
			return new IRhythmSpaceshipConditionStepInteract_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700202F RID: 8239
		// (get) Token: 0x06006236 RID: 25142 RVA: 0x000ECB7D File Offset: 0x000EAD7D
		// (set) Token: 0x06006237 RID: 25143 RVA: 0x000ECBA8 File Offset: 0x000EADA8
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

		// Token: 0x04003B04 RID: 15108
		[Nullable(2)]
		protected new IRhythmSpaceshipConditionStepInteract FbInstance;

		// Token: 0x04003B05 RID: 15109
		[Nullable(2)]
		protected new IRhythmSpaceshipConditionStepInteract_SetValue PocoInterface;
	}
}
