using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001282 RID: 4738
	public class ISurvivorsRougeConditionStepBase
	{
		// Token: 0x06006AC9 RID: 27337 RVA: 0x000FF47C File Offset: 0x000FD67C
		private ISurvivorsRougeConditionStepBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISurvivorsRougeConditionStepBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISurvivorsRougeConditionStepBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISurvivorsRougeConditionStepBase_SetValue());
			}
			return result;
		}

		// Token: 0x06006ACA RID: 27338 RVA: 0x000FF4B4 File Offset: 0x000FD6B4
		public static ISurvivorsRougeConditionStepBase Create([Nullable(2)] ISurvivorsRougeConditionStepBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISurvivorsRougeConditionStepBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006ACB RID: 27339 RVA: 0x000FF4C7 File Offset: 0x000FD6C7
		public static ISurvivorsRougeConditionStepBase CreateFromSetValue([Nullable(2)] ISurvivorsRougeConditionStepBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISurvivorsRougeConditionStepBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006ACC RID: 27340 RVA: 0x000FF4DA File Offset: 0x000FD6DA
		public ISurvivorsRougeConditionStepBase_SetValue ToSetValue()
		{
			return new ISurvivorsRougeConditionStepBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170022A1 RID: 8865
		// (get) Token: 0x06006ACD RID: 27341 RVA: 0x000FF4ED File Offset: 0x000FD6ED
		// (set) Token: 0x06006ACE RID: 27342 RVA: 0x000FF518 File Offset: 0x000FD718
		public virtual ESurvivorsRougeConditionStep Type
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

		// Token: 0x04003FD5 RID: 16341
		[Nullable(2)]
		protected ISurvivorsRougeConditionStepBase FbInstance;

		// Token: 0x04003FD6 RID: 16342
		[Nullable(2)]
		protected ISurvivorsRougeConditionStepBase_SetValue PocoInterface;
	}
}
