using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001DE RID: 478
	public class IAllKillCondition : ISpawnMonsterCompleteCondition
	{
		// Token: 0x06000754 RID: 1876 RVA: 0x000254DC File Offset: 0x000236DC
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

		// Token: 0x06000755 RID: 1877 RVA: 0x00025514 File Offset: 0x00023714
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

		// Token: 0x06000756 RID: 1878 RVA: 0x00025527 File Offset: 0x00023727
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

		// Token: 0x06000757 RID: 1879 RVA: 0x0002553A File Offset: 0x0002373A
		public new IAllKillCondition_SetValue ToSetValue()
		{
			return new IAllKillCondition_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x0002554D File Offset: 0x0002374D
		// (set) Token: 0x06000759 RID: 1881 RVA: 0x00025578 File Offset: 0x00023778
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

		// Token: 0x040008DB RID: 2267
		[Nullable(2)]
		protected new IAllKillCondition FbInstance;

		// Token: 0x040008DC RID: 2268
		[Nullable(2)]
		protected new IAllKillCondition_SetValue PocoInterface;
	}
}
