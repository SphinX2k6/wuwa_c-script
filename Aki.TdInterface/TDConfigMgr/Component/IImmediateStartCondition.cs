using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000452 RID: 1106
	[NullableContext(1)]
	[Nullable(0)]
	public class IImmediateStartCondition : ISpawnMonsterStartCondition
	{
		// Token: 0x06001661 RID: 5729 RVA: 0x000452B0 File Offset: 0x000434B0
		private IImmediateStartCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IImmediateStartCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IImmediateStartCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IImmediateStartCondition_SetValue());
			}
			return result;
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x000452E8 File Offset: 0x000434E8
		public static IImmediateStartCondition Create([Nullable(2)] IImmediateStartCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IImmediateStartCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x000452FB File Offset: 0x000434FB
		public static IImmediateStartCondition CreateFromSetValue([Nullable(2)] IImmediateStartCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IImmediateStartCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x0004530E File Offset: 0x0004350E
		public new IImmediateStartCondition_SetValue ToSetValue()
		{
			return new IImmediateStartCondition_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06001665 RID: 5733 RVA: 0x00045321 File Offset: 0x00043521
		// (set) Token: 0x06001666 RID: 5734 RVA: 0x0004534C File Offset: 0x0004354C
		public override ESpawnMonsterStartCondition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESpawnMonsterStartCondition.Immediate;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001118 RID: 4376
		[Nullable(2)]
		protected new IImmediateStartCondition FbInstance;

		// Token: 0x04001119 RID: 4377
		[Nullable(2)]
		protected new IImmediateStartCondition_SetValue PocoInterface;
	}
}
