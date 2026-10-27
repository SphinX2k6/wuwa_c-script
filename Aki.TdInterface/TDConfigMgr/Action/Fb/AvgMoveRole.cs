using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002562 RID: 9570
	[NullableContext(1)]
	[Nullable(0)]
	public class AvgMoveRole : ActionParams
	{
		// Token: 0x0600D6DF RID: 55007 RVA: 0x00200729 File Offset: 0x001FE929
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

		// Token: 0x17003DDD RID: 15837
		// (get) Token: 0x0600D6E0 RID: 55008 RVA: 0x00200748 File Offset: 0x001FE948
		public virtual int RoleId
		{
			get
			{
				return this.Instance.RoleId;
			}
		}

		// Token: 0x17003DDE RID: 15838
		// (get) Token: 0x0600D6E1 RID: 55009 RVA: 0x00200755 File Offset: 0x001FE955
		public virtual EAvgRoleAnimationType AnimationType
		{
			get
			{
				return (EAvgRoleAnimationType)this.Instance.AnimationType;
			}
		}

		// Token: 0x17003DDF RID: 15839
		// (get) Token: 0x0600D6E2 RID: 55010 RVA: 0x00200764 File Offset: 0x001FE964
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

		// Token: 0x17003DE0 RID: 15840
		// (get) Token: 0x0600D6E3 RID: 55011 RVA: 0x0020079A File Offset: 0x001FE99A
		public virtual EAvgRolePosition TargetPosition
		{
			get
			{
				return (EAvgRolePosition)this.Instance.TargetPosition;
			}
		}

		// Token: 0x17003DE1 RID: 15841
		// (get) Token: 0x0600D6E4 RID: 55012 RVA: 0x002007A7 File Offset: 0x001FE9A7
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

		// Token: 0x04007702 RID: 30466
		private IAvgMoveRole Instance;

		// Token: 0x04007703 RID: 30467
		[Nullable(2)]
		private IEaseData _EaseCurveCache;

		// Token: 0x04007704 RID: 30468
		private bool _EaseCurveInited;
	}
}
