using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BBA RID: 7098
	public class IExitMonsterMoveWithSpline : IExecBattleActionType
	{
		// Token: 0x060096C6 RID: 38598 RVA: 0x0015EC5C File Offset: 0x0015CE5C
		private IExitMonsterMoveWithSpline_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IExitMonsterMoveWithSpline 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IExitMonsterMoveWithSpline_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IExitMonsterMoveWithSpline_SetValue());
			}
			return result;
		}

		// Token: 0x060096C7 RID: 38599 RVA: 0x0015EC94 File Offset: 0x0015CE94
		public static IExitMonsterMoveWithSpline Create([Nullable(2)] IExitMonsterMoveWithSpline instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExitMonsterMoveWithSpline
			{
				FbInstance = instance
			};
		}

		// Token: 0x060096C8 RID: 38600 RVA: 0x0015ECA7 File Offset: 0x0015CEA7
		public static IExitMonsterMoveWithSpline CreateFromSetValue([Nullable(2)] IExitMonsterMoveWithSpline_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IExitMonsterMoveWithSpline
			{
				PocoInterface = value
			};
		}

		// Token: 0x060096C9 RID: 38601 RVA: 0x0015ECBA File Offset: 0x0015CEBA
		public new IExitMonsterMoveWithSpline_SetValue ToSetValue()
		{
			return new IExitMonsterMoveWithSpline_SetValue
			{
				Type = this.Type,
				TargetEntities = this.TargetEntities
			};
		}

		// Token: 0x17002FD9 RID: 12249
		// (get) Token: 0x060096CA RID: 38602 RVA: 0x0015ECD9 File Offset: 0x0015CED9
		// (set) Token: 0x060096CB RID: 38603 RVA: 0x0015ED04 File Offset: 0x0015CF04
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

		// Token: 0x17002FDA RID: 12250
		// (get) Token: 0x060096CC RID: 38604 RVA: 0x0015ED12 File Offset: 0x0015CF12
		// (set) Token: 0x060096CD RID: 38605 RVA: 0x0015ED39 File Offset: 0x0015CF39
		public virtual List<int> TargetEntities
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetEntities;
				}
				IExitMonsterMoveWithSpline_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04005D1A RID: 23834
		[Nullable(2)]
		protected new IExitMonsterMoveWithSpline FbInstance;

		// Token: 0x04005D1B RID: 23835
		[Nullable(2)]
		protected new IExitMonsterMoveWithSpline_SetValue PocoInterface;
	}
}
