using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001220 RID: 4640
	public class IRhythmSpaceshipConditionStepBase
	{
		// Token: 0x06006825 RID: 26661 RVA: 0x000F9BC4 File Offset: 0x000F7DC4
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

		// Token: 0x06006826 RID: 26662 RVA: 0x000F9BFC File Offset: 0x000F7DFC
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

		// Token: 0x06006827 RID: 26663 RVA: 0x000F9C0F File Offset: 0x000F7E0F
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

		// Token: 0x06006828 RID: 26664 RVA: 0x000F9C22 File Offset: 0x000F7E22
		public IRhythmSpaceshipConditionStepBase_SetValue ToSetValue()
		{
			return new IRhythmSpaceshipConditionStepBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170021E1 RID: 8673
		// (get) Token: 0x06006829 RID: 26665 RVA: 0x000F9C35 File Offset: 0x000F7E35
		// (set) Token: 0x0600682A RID: 26666 RVA: 0x000F9C60 File Offset: 0x000F7E60
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

		// Token: 0x04003E4F RID: 15951
		[Nullable(2)]
		protected IRhythmSpaceshipConditionStepBase FbInstance;

		// Token: 0x04003E50 RID: 15952
		[Nullable(2)]
		protected IRhythmSpaceshipConditionStepBase_SetValue PocoInterface;
	}
}
