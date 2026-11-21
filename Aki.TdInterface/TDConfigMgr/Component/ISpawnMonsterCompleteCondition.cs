using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000785 RID: 1925
	public class ISpawnMonsterCompleteCondition
	{
		// Token: 0x06002920 RID: 10528 RVA: 0x0006D0FC File Offset: 0x0006B2FC
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

		// Token: 0x06002921 RID: 10529 RVA: 0x0006D134 File Offset: 0x0006B334
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

		// Token: 0x06002922 RID: 10530 RVA: 0x0006D147 File Offset: 0x0006B347
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

		// Token: 0x06002923 RID: 10531 RVA: 0x0006D15A File Offset: 0x0006B35A
		public ISpawnMonsterCompleteCondition_SetValue ToSetValue()
		{
			return new ISpawnMonsterCompleteCondition_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x06002924 RID: 10532 RVA: 0x0006D16D File Offset: 0x0006B36D
		// (set) Token: 0x06002925 RID: 10533 RVA: 0x0006D198 File Offset: 0x0006B398
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

		// Token: 0x04001BDE RID: 7134
		[Nullable(2)]
		protected ISpawnMonsterCompleteCondition FbInstance;

		// Token: 0x04001BDF RID: 7135
		[Nullable(2)]
		protected ISpawnMonsterCompleteCondition_SetValue PocoInterface;
	}
}
