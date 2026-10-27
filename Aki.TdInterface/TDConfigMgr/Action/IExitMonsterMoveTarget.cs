using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A23 RID: 6691
	[NullableContext(1)]
	[Nullable(0)]
	public class IExitMonsterMoveTarget : IExecBattleActionType
	{
		// Token: 0x06008F52 RID: 36690 RVA: 0x0014EC34 File Offset: 0x0014CE34
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

		// Token: 0x06008F53 RID: 36691 RVA: 0x0014EC6C File Offset: 0x0014CE6C
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

		// Token: 0x06008F54 RID: 36692 RVA: 0x0014EC7F File Offset: 0x0014CE7F
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

		// Token: 0x06008F55 RID: 36693 RVA: 0x0014EC92 File Offset: 0x0014CE92
		public new IExitMonsterMoveTarget_SetValue ToSetValue()
		{
			return new IExitMonsterMoveTarget_SetValue
			{
				Type = this.Type,
				TargetEntities = this.TargetEntities
			};
		}

		// Token: 0x17002DCA RID: 11722
		// (get) Token: 0x06008F56 RID: 36694 RVA: 0x0014ECB1 File Offset: 0x0014CEB1
		// (set) Token: 0x06008F57 RID: 36695 RVA: 0x0014ECDC File Offset: 0x0014CEDC
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

		// Token: 0x17002DCB RID: 11723
		// (get) Token: 0x06008F58 RID: 36696 RVA: 0x0014ECEA File Offset: 0x0014CEEA
		// (set) Token: 0x06008F59 RID: 36697 RVA: 0x0014ED11 File Offset: 0x0014CF11
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

		// Token: 0x040058B1 RID: 22705
		[Nullable(2)]
		protected new IExitMonsterMoveTarget FbInstance;

		// Token: 0x040058B2 RID: 22706
		[Nullable(2)]
		protected new IExitMonsterMoveTarget_SetValue PocoInterface;
	}
}
