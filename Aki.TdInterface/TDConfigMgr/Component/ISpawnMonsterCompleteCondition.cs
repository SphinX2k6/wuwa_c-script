using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006E4 RID: 1764
	[NullableContext(1)]
	[Nullable(0)]
	public class ISpawnMonsterCompleteCondition
	{
		// Token: 0x06002600 RID: 9728 RVA: 0x0006608C File Offset: 0x0006428C
		private ISpawnMonsterCompleteCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISpawnMonsterCompleteCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISpawnMonsterCompleteCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISpawnMonsterCompleteCondition_SetValue());
			}
			return result;
		}

		// Token: 0x06002601 RID: 9729 RVA: 0x000660C4 File Offset: 0x000642C4
		public static ISpawnMonsterCompleteCondition Create([Nullable(2)] ISpawnMonsterCompleteCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpawnMonsterCompleteCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002602 RID: 9730 RVA: 0x000660D7 File Offset: 0x000642D7
		public static ISpawnMonsterCompleteCondition CreateFromSetValue([Nullable(2)] ISpawnMonsterCompleteCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISpawnMonsterCompleteCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002603 RID: 9731 RVA: 0x000660EA File Offset: 0x000642EA
		public ISpawnMonsterCompleteCondition_SetValue ToSetValue()
		{
			return new ISpawnMonsterCompleteCondition_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06002604 RID: 9732 RVA: 0x000660FD File Offset: 0x000642FD
		// (set) Token: 0x06002605 RID: 9733 RVA: 0x00066128 File Offset: 0x00064328
		public virtual ESpawnMonsterCompleteCondition Type
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

		// Token: 0x040019DF RID: 6623
		[Nullable(2)]
		protected ISpawnMonsterCompleteCondition FbInstance;

		// Token: 0x040019E0 RID: 6624
		[Nullable(2)]
		protected ISpawnMonsterCompleteCondition_SetValue PocoInterface;
	}
}
