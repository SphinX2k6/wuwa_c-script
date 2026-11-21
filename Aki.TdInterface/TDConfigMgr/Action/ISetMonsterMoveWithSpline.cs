using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200205D RID: 8285
	public class ISetMonsterMoveWithSpline : IExecBattleActionType
	{
		// Token: 0x0600AFD3 RID: 45011 RVA: 0x0018BDD8 File Offset: 0x00189FD8
		private ISetMonsterMoveWithSpline_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetMonsterMoveWithSpline 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetMonsterMoveWithSpline_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetMonsterMoveWithSpline_SetValue());
			}
			return result;
		}

		// Token: 0x0600AFD4 RID: 45012 RVA: 0x0018BE10 File Offset: 0x0018A010
		public static ISetMonsterMoveWithSpline Create([Nullable(2)] ISetMonsterMoveWithSpline instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetMonsterMoveWithSpline
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AFD5 RID: 45013 RVA: 0x0018BE23 File Offset: 0x0018A023
		public static ISetMonsterMoveWithSpline CreateFromSetValue([Nullable(2)] ISetMonsterMoveWithSpline_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetMonsterMoveWithSpline
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AFD6 RID: 45014 RVA: 0x0018BE36 File Offset: 0x0018A036
		public new ISetMonsterMoveWithSpline_SetValue ToSetValue()
		{
			return new ISetMonsterMoveWithSpline_SetValue
			{
				Type = this.Type,
				MoveSplineConfigs = this.MoveSplineConfigs
			};
		}

		// Token: 0x1700356C RID: 13676
		// (get) Token: 0x0600AFD7 RID: 45015 RVA: 0x0018BE55 File Offset: 0x0018A055
		// (set) Token: 0x0600AFD8 RID: 45016 RVA: 0x0018BE80 File Offset: 0x0018A080
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

		// Token: 0x1700356D RID: 13677
		// (get) Token: 0x0600AFD9 RID: 45017 RVA: 0x0018BE90 File Offset: 0x0018A090
		// (set) Token: 0x0600AFDA RID: 45018 RVA: 0x0018BF23 File Offset: 0x0018A123
		public virtual List<IMonsterMoveSplineConfig> MoveSplineConfigs
		{
			get
			{
				if (this._MoveSplineConfigsInited)
				{
					return this._MoveSplineConfigsCache;
				}
				this._MoveSplineConfigsInited = true;
				if (this.FbInstance != null)
				{
					List<IMonsterMoveSplineConfig> moveSplineConfigs = this.FbInstance.MoveSplineConfigs;
					if (moveSplineConfigs != null)
					{
						this._MoveSplineConfigsCache = new List<IMonsterMoveSplineConfig>(moveSplineConfigs.Count);
						for (int i = 0; i < moveSplineConfigs.Count; i++)
						{
							this._MoveSplineConfigsCache.Add(IMonsterMoveSplineConfig.Create(moveSplineConfigs[i]));
						}
					}
				}
				else
				{
					ISetMonsterMoveWithSpline_SetValue pocoInterface = this.PocoInterface;
					this._MoveSplineConfigsCache = ((pocoInterface != null) ? pocoInterface.MoveSplineConfigs : null);
				}
				return this._MoveSplineConfigsCache;
			}
			set
			{
				this.GetOrCreatePoco().MoveSplineConfigs = value;
				this._MoveSplineConfigsInited = false;
			}
		}

		// Token: 0x040068A1 RID: 26785
		[Nullable(2)]
		protected new ISetMonsterMoveWithSpline FbInstance;

		// Token: 0x040068A2 RID: 26786
		[Nullable(2)]
		protected new ISetMonsterMoveWithSpline_SetValue PocoInterface;

		// Token: 0x040068A3 RID: 26787
		private List<IMonsterMoveSplineConfig> _MoveSplineConfigsCache;

		// Token: 0x040068A4 RID: 26788
		private bool _MoveSplineConfigsInited;
	}
}
