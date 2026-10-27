using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001BB RID: 443
	[NullableContext(1)]
	[Nullable(0)]
	public class IAllKillCondition : ISpawnMonsterCompleteCondition
	{
		// Token: 0x06000700 RID: 1792 RVA: 0x000241D8 File Offset: 0x000223D8
		private IAllKillCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAllKillCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAllKillCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAllKillCondition_SetValue());
			}
			return result;
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x00024210 File Offset: 0x00022410
		public static IAllKillCondition Create([Nullable(2)] IAllKillCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAllKillCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x00024223 File Offset: 0x00022423
		public static IAllKillCondition CreateFromSetValue([Nullable(2)] IAllKillCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAllKillCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00024236 File Offset: 0x00022436
		public new IAllKillCondition_SetValue ToSetValue()
		{
			return new IAllKillCondition_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x00024249 File Offset: 0x00022449
		// (set) Token: 0x06000705 RID: 1797 RVA: 0x00024274 File Offset: 0x00022474
		public override ESpawnMonsterCompleteCondition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESpawnMonsterCompleteCondition.AllKill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000867 RID: 2151
		[Nullable(2)]
		protected new IAllKillCondition FbInstance;

		// Token: 0x04000868 RID: 2152
		[Nullable(2)]
		protected new IAllKillCondition_SetValue PocoInterface;
	}
}
