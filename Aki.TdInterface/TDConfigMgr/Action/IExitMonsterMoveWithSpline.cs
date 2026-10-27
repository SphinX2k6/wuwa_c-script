using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A25 RID: 6693
	[NullableContext(1)]
	[Nullable(0)]
	public class IExitMonsterMoveWithSpline : IExecBattleActionType
	{
		// Token: 0x06008F5C RID: 36700 RVA: 0x0014ED30 File Offset: 0x0014CF30
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

		// Token: 0x06008F5D RID: 36701 RVA: 0x0014ED68 File Offset: 0x0014CF68
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

		// Token: 0x06008F5E RID: 36702 RVA: 0x0014ED7B File Offset: 0x0014CF7B
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

		// Token: 0x06008F5F RID: 36703 RVA: 0x0014ED8E File Offset: 0x0014CF8E
		public new IExitMonsterMoveWithSpline_SetValue ToSetValue()
		{
			return new IExitMonsterMoveWithSpline_SetValue
			{
				Type = this.Type,
				TargetEntities = this.TargetEntities
			};
		}

		// Token: 0x17002DCC RID: 11724
		// (get) Token: 0x06008F60 RID: 36704 RVA: 0x0014EDAD File Offset: 0x0014CFAD
		// (set) Token: 0x06008F61 RID: 36705 RVA: 0x0014EDD8 File Offset: 0x0014CFD8
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

		// Token: 0x17002DCD RID: 11725
		// (get) Token: 0x06008F62 RID: 36706 RVA: 0x0014EDE6 File Offset: 0x0014CFE6
		// (set) Token: 0x06008F63 RID: 36707 RVA: 0x0014EE0D File Offset: 0x0014D00D
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

		// Token: 0x040058B5 RID: 22709
		[Nullable(2)]
		protected new IExitMonsterMoveWithSpline FbInstance;

		// Token: 0x040058B6 RID: 22710
		[Nullable(2)]
		protected new IExitMonsterMoveWithSpline_SetValue PocoInterface;
	}
}
