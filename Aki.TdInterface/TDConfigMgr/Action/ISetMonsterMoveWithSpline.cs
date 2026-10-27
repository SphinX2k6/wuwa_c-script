using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E2A RID: 7722
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetMonsterMoveWithSpline : IExecBattleActionType
	{
		// Token: 0x0600A52B RID: 42283 RVA: 0x001763D0 File Offset: 0x001745D0
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

		// Token: 0x0600A52C RID: 42284 RVA: 0x00176408 File Offset: 0x00174608
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

		// Token: 0x0600A52D RID: 42285 RVA: 0x0017641B File Offset: 0x0017461B
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

		// Token: 0x0600A52E RID: 42286 RVA: 0x0017642E File Offset: 0x0017462E
		public new ISetMonsterMoveWithSpline_SetValue ToSetValue()
		{
			return new ISetMonsterMoveWithSpline_SetValue
			{
				Type = this.Type,
				MoveSplineConfigs = this.MoveSplineConfigs
			};
		}

		// Token: 0x170032AD RID: 12973
		// (get) Token: 0x0600A52F RID: 42287 RVA: 0x0017644D File Offset: 0x0017464D
		// (set) Token: 0x0600A530 RID: 42288 RVA: 0x00176478 File Offset: 0x00174678
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

		// Token: 0x170032AE RID: 12974
		// (get) Token: 0x0600A531 RID: 42289 RVA: 0x00176488 File Offset: 0x00174688
		// (set) Token: 0x0600A532 RID: 42290 RVA: 0x0017651B File Offset: 0x0017471B
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

		// Token: 0x040062CA RID: 25290
		[Nullable(2)]
		protected new ISetMonsterMoveWithSpline FbInstance;

		// Token: 0x040062CB RID: 25291
		[Nullable(2)]
		protected new ISetMonsterMoveWithSpline_SetValue PocoInterface;

		// Token: 0x040062CC RID: 25292
		private List<IMonsterMoveSplineConfig> _MoveSplineConfigsCache;

		// Token: 0x040062CD RID: 25293
		private bool _MoveSplineConfigsInited;
	}
}
