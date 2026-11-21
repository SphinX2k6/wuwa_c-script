using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200280B RID: 10251
	public class AvgMoveRole : ActionParams
	{
		// Token: 0x0600E449 RID: 58441 RVA: 0x0021C325 File Offset: 0x0021A525
		public static AvgMoveRole Create(IAvgMoveRole? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AvgMoveRole
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170040E1 RID: 16609
		// (get) Token: 0x0600E44A RID: 58442 RVA: 0x0021C344 File Offset: 0x0021A544
		public virtual int RoleId
		{
			get
			{
				return this.Instance.RoleId;
			}
		}

		// Token: 0x170040E2 RID: 16610
		// (get) Token: 0x0600E44B RID: 58443 RVA: 0x0021C351 File Offset: 0x0021A551
		public virtual EAvgRoleAnimationType AnimationType
		{
			get
			{
				return (EAvgRoleAnimationType)this.Instance.AnimationType;
			}
		}

		// Token: 0x170040E3 RID: 16611
		// (get) Token: 0x0600E44C RID: 58444 RVA: 0x0021C360 File Offset: 0x0021A560
		public virtual bool? IsAnimationLoop
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsAnimationLoop);
			}
		}

		// Token: 0x170040E4 RID: 16612
		// (get) Token: 0x0600E44D RID: 58445 RVA: 0x0021C396 File Offset: 0x0021A596
		public virtual EAvgRolePosition TargetPosition
		{
			get
			{
				return (EAvgRolePosition)this.Instance.TargetPosition;
			}
		}

		// Token: 0x170040E5 RID: 16613
		// (get) Token: 0x0600E44E RID: 58446 RVA: 0x0021C3A3 File Offset: 0x0021A5A3
		public virtual IEaseData EaseCurve
		{
			get
			{
				if (this._EaseCurveInited)
				{
					return this._EaseCurveCache;
				}
				this._EaseCurveInited = true;
				this._EaseCurveCache = IEaseData.Create(this.Instance.EaseCurve);
				return this._EaseCurveCache;
			}
		}

		// Token: 0x04007D5F RID: 32095
		private IAvgMoveRole Instance;

		// Token: 0x04007D60 RID: 32096
		[Nullable(2)]
		private IEaseData _EaseCurveCache;

		// Token: 0x04007D61 RID: 32097
		private bool _EaseCurveInited;
	}
}
