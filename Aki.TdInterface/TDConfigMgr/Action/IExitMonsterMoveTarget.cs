using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BB8 RID: 7096
	public class IExitMonsterMoveTarget : IExecBattleActionType
	{
		// Token: 0x060096BC RID: 38588 RVA: 0x0015EB60 File Offset: 0x0015CD60
		private IExitMonsterMoveTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IExitMonsterMoveTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IExitMonsterMoveTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IExitMonsterMoveTarget_SetValue());
			}
			return result;
		}

		// Token: 0x060096BD RID: 38589 RVA: 0x0015EB98 File Offset: 0x0015CD98
		public static IExitMonsterMoveTarget Create([Nullable(2)] IExitMonsterMoveTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExitMonsterMoveTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x060096BE RID: 38590 RVA: 0x0015EBAB File Offset: 0x0015CDAB
		public static IExitMonsterMoveTarget CreateFromSetValue([Nullable(2)] IExitMonsterMoveTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IExitMonsterMoveTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x060096BF RID: 38591 RVA: 0x0015EBBE File Offset: 0x0015CDBE
		public new IExitMonsterMoveTarget_SetValue ToSetValue()
		{
			return new IExitMonsterMoveTarget_SetValue
			{
				Type = this.Type,
				TargetEntities = this.TargetEntities
			};
		}

		// Token: 0x17002FD7 RID: 12247
		// (get) Token: 0x060096C0 RID: 38592 RVA: 0x0015EBDD File Offset: 0x0015CDDD
		// (set) Token: 0x060096C1 RID: 38593 RVA: 0x0015EC08 File Offset: 0x0015CE08
		public override EExecBattleActionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EExecBattleActionType.SetBattleTags;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002FD8 RID: 12248
		// (get) Token: 0x060096C2 RID: 38594 RVA: 0x0015EC16 File Offset: 0x0015CE16
		// (set) Token: 0x060096C3 RID: 38595 RVA: 0x0015EC3D File Offset: 0x0015CE3D
		public virtual List<int> TargetEntities
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetEntities;
				}
				IExitMonsterMoveTarget_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TargetEntities;
			}
			set
			{
				this.GetOrCreatePoco().TargetEntities = value;
			}
		}

		// Token: 0x04005D16 RID: 23830
		[Nullable(2)]
		protected new IExitMonsterMoveTarget FbInstance;

		// Token: 0x04005D17 RID: 23831
		[Nullable(2)]
		protected new IExitMonsterMoveTarget_SetValue PocoInterface;
	}
}
