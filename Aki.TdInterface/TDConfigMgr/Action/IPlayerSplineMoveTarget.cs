using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F1F RID: 7967
	public class IPlayerSplineMoveTarget : ISplineMoveTargetType
	{
		// Token: 0x0600A983 RID: 43395 RVA: 0x00180B68 File Offset: 0x0017ED68
		private IPlayerSplineMoveTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlayerSplineMoveTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlayerSplineMoveTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlayerSplineMoveTarget_SetValue());
			}
			return result;
		}

		// Token: 0x0600A984 RID: 43396 RVA: 0x00180BA0 File Offset: 0x0017EDA0
		public static IPlayerSplineMoveTarget Create([Nullable(2)] IPlayerSplineMoveTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayerSplineMoveTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A985 RID: 43397 RVA: 0x00180BB3 File Offset: 0x0017EDB3
		public static IPlayerSplineMoveTarget CreateFromSetValue([Nullable(2)] IPlayerSplineMoveTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlayerSplineMoveTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A986 RID: 43398 RVA: 0x00180BC6 File Offset: 0x0017EDC6
		public new IPlayerSplineMoveTarget_SetValue ToSetValue()
		{
			return new IPlayerSplineMoveTarget_SetValue
			{
				Type = this.Type,
				CustomMoveMontage = this.CustomMoveMontage
			};
		}

		// Token: 0x17003421 RID: 13345
		// (get) Token: 0x0600A987 RID: 43399 RVA: 0x00180BE5 File Offset: 0x0017EDE5
		// (set) Token: 0x0600A988 RID: 43400 RVA: 0x00180C10 File Offset: 0x0017EE10
		public override ESplineMoveTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESplineMoveTargetType.Entity;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003422 RID: 13346
		// (get) Token: 0x0600A989 RID: 43401 RVA: 0x00180C20 File Offset: 0x0017EE20
		// (set) Token: 0x0600A98A RID: 43402 RVA: 0x00180C81 File Offset: 0x0017EE81
		[Nullable(2)]
		public virtual IThreeStageSplineMoveMontage CustomMoveMontage
		{
			[NullableContext(2)]
			get
			{
				if (this._CustomMoveMontageInited)
				{
					return this._CustomMoveMontageCache;
				}
				this._CustomMoveMontageInited = true;
				if (this.FbInstance != null)
				{
					this._CustomMoveMontageCache = IThreeStageSplineMoveMontage.Create(this.FbInstance.CustomMoveMontage);
				}
				else
				{
					IPlayerSplineMoveTarget_SetValue pocoInterface = this.PocoInterface;
					this._CustomMoveMontageCache = ((pocoInterface != null) ? pocoInterface.CustomMoveMontage : null);
				}
				return this._CustomMoveMontageCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().CustomMoveMontage = value;
				this._CustomMoveMontageInited = false;
			}
		}

		// Token: 0x040065C6 RID: 26054
		[Nullable(2)]
		protected new IPlayerSplineMoveTarget FbInstance;

		// Token: 0x040065C7 RID: 26055
		[Nullable(2)]
		protected new IPlayerSplineMoveTarget_SetValue PocoInterface;

		// Token: 0x040065C8 RID: 26056
		private IThreeStageSplineMoveMontage _CustomMoveMontageCache;

		// Token: 0x040065C9 RID: 26057
		private bool _CustomMoveMontageInited;
	}
}
