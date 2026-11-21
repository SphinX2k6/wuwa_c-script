using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010BB RID: 4283
	public class IFlipperConditionStepBase
	{
		// Token: 0x06005EA0 RID: 24224 RVA: 0x000E5488 File Offset: 0x000E3688
		private IFlipperConditionStepBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFlipperConditionStepBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFlipperConditionStepBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFlipperConditionStepBase_SetValue());
			}
			return result;
		}

		// Token: 0x06005EA1 RID: 24225 RVA: 0x000E54C0 File Offset: 0x000E36C0
		public static IFlipperConditionStepBase Create([Nullable(2)] IFlipperConditionStepBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlipperConditionStepBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005EA2 RID: 24226 RVA: 0x000E54D3 File Offset: 0x000E36D3
		public static IFlipperConditionStepBase CreateFromSetValue([Nullable(2)] IFlipperConditionStepBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFlipperConditionStepBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005EA3 RID: 24227 RVA: 0x000E54E6 File Offset: 0x000E36E6
		public IFlipperConditionStepBase_SetValue ToSetValue()
		{
			return new IFlipperConditionStepBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001F34 RID: 7988
		// (get) Token: 0x06005EA4 RID: 24228 RVA: 0x000E54F9 File Offset: 0x000E36F9
		// (set) Token: 0x06005EA5 RID: 24229 RVA: 0x000E5524 File Offset: 0x000E3724
		public virtual EFlipperConditionStep Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFlipperConditionStep.Fight;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040038D6 RID: 14550
		[Nullable(2)]
		protected IFlipperConditionStepBase FbInstance;

		// Token: 0x040038D7 RID: 14551
		[Nullable(2)]
		protected IFlipperConditionStepBase_SetValue PocoInterface;
	}
}
