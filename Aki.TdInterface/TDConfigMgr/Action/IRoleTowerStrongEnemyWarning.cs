using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FE7 RID: 8167
	public class IRoleTowerStrongEnemyWarning : ICommonTipType
	{
		// Token: 0x0600AD77 RID: 44407 RVA: 0x0018789C File Offset: 0x00185A9C
		private IRoleTowerStrongEnemyWarning_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRoleTowerStrongEnemyWarning 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRoleTowerStrongEnemyWarning_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRoleTowerStrongEnemyWarning_SetValue());
			}
			return result;
		}

		// Token: 0x0600AD78 RID: 44408 RVA: 0x001878D4 File Offset: 0x00185AD4
		public static IRoleTowerStrongEnemyWarning Create([Nullable(2)] IRoleTowerStrongEnemyWarning instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleTowerStrongEnemyWarning
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AD79 RID: 44409 RVA: 0x001878E7 File Offset: 0x00185AE7
		public static IRoleTowerStrongEnemyWarning CreateFromSetValue([Nullable(2)] IRoleTowerStrongEnemyWarning_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRoleTowerStrongEnemyWarning
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AD7A RID: 44410 RVA: 0x001878FA File Offset: 0x00185AFA
		public new IRoleTowerStrongEnemyWarning_SetValue ToSetValue()
		{
			return new IRoleTowerStrongEnemyWarning_SetValue
			{
				Type = this.Type,
				TidMainText = this.TidMainText,
				EdTidMainText = this.EdTidMainText
			};
		}

		// Token: 0x170034EF RID: 13551
		// (get) Token: 0x0600AD7B RID: 44411 RVA: 0x00187925 File Offset: 0x00185B25
		// (set) Token: 0x0600AD7C RID: 44412 RVA: 0x00187950 File Offset: 0x00185B50
		public override ECommonTipType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170034F0 RID: 13552
		// (get) Token: 0x0600AD7D RID: 44413 RVA: 0x0018795E File Offset: 0x00185B5E
		// (set) Token: 0x0600AD7E RID: 44414 RVA: 0x00187989 File Offset: 0x00185B89
		public virtual string TidMainText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidMainText;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidMainText;
			}
			set
			{
				this.GetOrCreatePoco().TidMainText = value;
			}
		}

		// Token: 0x170034F1 RID: 13553
		// (get) Token: 0x0600AD7F RID: 44415 RVA: 0x00187997 File Offset: 0x00185B97
		// (set) Token: 0x0600AD80 RID: 44416 RVA: 0x001879AE File Offset: 0x00185BAE
		[Nullable(2)]
		public virtual string EdTidMainText
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidMainText;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdTidMainText = value;
			}
		}

		// Token: 0x04006784 RID: 26500
		[Nullable(2)]
		protected new IRoleTowerStrongEnemyWarning FbInstance;

		// Token: 0x04006785 RID: 26501
		[Nullable(2)]
		protected new IRoleTowerStrongEnemyWarning_SetValue PocoInterface;
	}
}
