using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001904 RID: 6404
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonBtOverrideTaskInfoBase
	{
		// Token: 0x06008937 RID: 35127 RVA: 0x00144124 File Offset: 0x00142324
		private ICommonBtOverrideTaskInfoBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonBtOverrideTaskInfoBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonBtOverrideTaskInfoBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonBtOverrideTaskInfoBase_SetValue());
			}
			return result;
		}

		// Token: 0x06008938 RID: 35128 RVA: 0x0014415C File Offset: 0x0014235C
		public static ICommonBtOverrideTaskInfoBase Create([Nullable(2)] ICommonBtOverrideTaskInfoBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonBtOverrideTaskInfoBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008939 RID: 35129 RVA: 0x0014416F File Offset: 0x0014236F
		public static ICommonBtOverrideTaskInfoBase CreateFromSetValue([Nullable(2)] ICommonBtOverrideTaskInfoBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonBtOverrideTaskInfoBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600893A RID: 35130 RVA: 0x00144182 File Offset: 0x00142382
		public ICommonBtOverrideTaskInfoBase_SetValue ToSetValue()
		{
			return new ICommonBtOverrideTaskInfoBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002C6A RID: 11370
		// (get) Token: 0x0600893B RID: 35131 RVA: 0x00144195 File Offset: 0x00142395
		// (set) Token: 0x0600893C RID: 35132 RVA: 0x001441C0 File Offset: 0x001423C0
		public virtual ECommonBtPlaceholderTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECommonBtPlaceholderTargetType.Action;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005605 RID: 22021
		[Nullable(2)]
		protected ICommonBtOverrideTaskInfoBase FbInstance;

		// Token: 0x04005606 RID: 22022
		[Nullable(2)]
		protected ICommonBtOverrideTaskInfoBase_SetValue PocoInterface;
	}
}
