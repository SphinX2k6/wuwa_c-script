using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010F2 RID: 4338
	[NullableContext(1)]
	[Nullable(0)]
	public class IRhythmSpaceshipConditionStepBase
	{
		// Token: 0x0600622A RID: 25130 RVA: 0x000ECA50 File Offset: 0x000EAC50
		private IRhythmSpaceshipConditionStepBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRhythmSpaceshipConditionStepBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRhythmSpaceshipConditionStepBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRhythmSpaceshipConditionStepBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600622B RID: 25131 RVA: 0x000ECA88 File Offset: 0x000EAC88
		public static IRhythmSpaceshipConditionStepBase Create([Nullable(2)] IRhythmSpaceshipConditionStepBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRhythmSpaceshipConditionStepBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600622C RID: 25132 RVA: 0x000ECA9B File Offset: 0x000EAC9B
		public static IRhythmSpaceshipConditionStepBase CreateFromSetValue([Nullable(2)] IRhythmSpaceshipConditionStepBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRhythmSpaceshipConditionStepBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600622D RID: 25133 RVA: 0x000ECAAE File Offset: 0x000EACAE
		public IRhythmSpaceshipConditionStepBase_SetValue ToSetValue()
		{
			return new IRhythmSpaceshipConditionStepBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700202E RID: 8238
		// (get) Token: 0x0600622E RID: 25134 RVA: 0x000ECAC1 File Offset: 0x000EACC1
		// (set) Token: 0x0600622F RID: 25135 RVA: 0x000ECAEC File Offset: 0x000EACEC
		public virtual ERhythmSpaceshipConditionStep Type
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

		// Token: 0x04003B01 RID: 15105
		[Nullable(2)]
		protected IRhythmSpaceshipConditionStepBase FbInstance;

		// Token: 0x04003B02 RID: 15106
		[Nullable(2)]
		protected IRhythmSpaceshipConditionStepBase_SetValue PocoInterface;
	}
}
