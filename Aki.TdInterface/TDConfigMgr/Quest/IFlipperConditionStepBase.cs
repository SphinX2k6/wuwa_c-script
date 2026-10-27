using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F91 RID: 3985
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlipperConditionStepBase
	{
		// Token: 0x060058CE RID: 22734 RVA: 0x000D8A60 File Offset: 0x000D6C60
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

		// Token: 0x060058CF RID: 22735 RVA: 0x000D8A98 File Offset: 0x000D6C98
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

		// Token: 0x060058D0 RID: 22736 RVA: 0x000D8AAB File Offset: 0x000D6CAB
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

		// Token: 0x060058D1 RID: 22737 RVA: 0x000D8ABE File Offset: 0x000D6CBE
		public IFlipperConditionStepBase_SetValue ToSetValue()
		{
			return new IFlipperConditionStepBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001D8F RID: 7567
		// (get) Token: 0x060058D2 RID: 22738 RVA: 0x000D8AD1 File Offset: 0x000D6CD1
		// (set) Token: 0x060058D3 RID: 22739 RVA: 0x000D8AFC File Offset: 0x000D6CFC
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

		// Token: 0x040035A6 RID: 13734
		[Nullable(2)]
		protected IFlipperConditionStepBase FbInstance;

		// Token: 0x040035A7 RID: 13735
		[Nullable(2)]
		protected IFlipperConditionStepBase_SetValue PocoInterface;
	}
}
