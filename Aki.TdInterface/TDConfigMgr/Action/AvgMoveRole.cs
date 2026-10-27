using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014A3 RID: 5283
	[NullableContext(1)]
	[Nullable(0)]
	public class AvgMoveRole : ActionParams
	{
		// Token: 0x0600784A RID: 30794 RVA: 0x00120750 File Offset: 0x0011E950
		private AvgMoveRole_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("AvgMoveRole 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			AvgMoveRole_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new AvgMoveRole_SetValue());
			}
			return result;
		}

		// Token: 0x0600784B RID: 30795 RVA: 0x00120788 File Offset: 0x0011E988
		public static AvgMoveRole Create([Nullable(2)] AvgMoveRole instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AvgMoveRole
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600784C RID: 30796 RVA: 0x0012079B File Offset: 0x0011E99B
		public static AvgMoveRole CreateFromSetValue([Nullable(2)] AvgMoveRole_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new AvgMoveRole
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600784D RID: 30797 RVA: 0x001207B0 File Offset: 0x0011E9B0
		public AvgMoveRole_SetValue ToSetValue()
		{
			return new AvgMoveRole_SetValue
			{
				RoleId = this.RoleId,
				AnimationType = this.AnimationType,
				IsAnimationLoop = this.IsAnimationLoop,
				TargetPosition = this.TargetPosition,
				EaseCurve = this.EaseCurve
			};
		}

		// Token: 0x17002866 RID: 10342
		// (get) Token: 0x0600784E RID: 30798 RVA: 0x001207FE File Offset: 0x0011E9FE
		// (set) Token: 0x0600784F RID: 30799 RVA: 0x00120829 File Offset: 0x0011EA29
		public virtual int RoleId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RoleId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RoleId;
			}
			set
			{
				this.GetOrCreatePoco().RoleId = value;
			}
		}

		// Token: 0x17002867 RID: 10343
		// (get) Token: 0x06007850 RID: 30800 RVA: 0x00120837 File Offset: 0x0011EA37
		// (set) Token: 0x06007851 RID: 30801 RVA: 0x00120862 File Offset: 0x0011EA62
		public virtual EAvgRoleAnimationType AnimationType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AnimationType;
				}
				if (this.PocoInterface == null)
				{
					return EAvgRoleAnimationType.Idle;
				}
				return this.PocoInterface.AnimationType;
			}
			set
			{
				this.GetOrCreatePoco().AnimationType = value;
			}
		}

		// Token: 0x17002868 RID: 10344
		// (get) Token: 0x06007852 RID: 30802 RVA: 0x00120870 File Offset: 0x0011EA70
		// (set) Token: 0x06007853 RID: 30803 RVA: 0x001208AA File Offset: 0x0011EAAA
		public virtual bool? IsAnimationLoop
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsAnimationLoop;
				}
				AvgMoveRole_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsAnimationLoop;
			}
			set
			{
				this.GetOrCreatePoco().IsAnimationLoop = value;
			}
		}

		// Token: 0x17002869 RID: 10345
		// (get) Token: 0x06007854 RID: 30804 RVA: 0x001208B8 File Offset: 0x0011EAB8
		// (set) Token: 0x06007855 RID: 30805 RVA: 0x001208E3 File Offset: 0x0011EAE3
		public virtual EAvgRolePosition TargetPosition
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetPosition;
				}
				if (this.PocoInterface == null)
				{
					return EAvgRolePosition.Center;
				}
				return this.PocoInterface.TargetPosition;
			}
			set
			{
				this.GetOrCreatePoco().TargetPosition = value;
			}
		}

		// Token: 0x1700286A RID: 10346
		// (get) Token: 0x06007856 RID: 30806 RVA: 0x001208F4 File Offset: 0x0011EAF4
		// (set) Token: 0x06007857 RID: 30807 RVA: 0x00120955 File Offset: 0x0011EB55
		public virtual IEaseData EaseCurve
		{
			get
			{
				if (this._EaseCurveInited)
				{
					return this._EaseCurveCache;
				}
				this._EaseCurveInited = true;
				if (this.FbInstance != null)
				{
					this._EaseCurveCache = IEaseData.Create(this.FbInstance.EaseCurve);
				}
				else
				{
					AvgMoveRole_SetValue pocoInterface = this.PocoInterface;
					this._EaseCurveCache = ((pocoInterface != null) ? pocoInterface.EaseCurve : null);
				}
				return this._EaseCurveCache;
			}
			set
			{
				this.GetOrCreatePoco().EaseCurve = value;
				this._EaseCurveInited = false;
			}
		}

		// Token: 0x040045EA RID: 17898
		[Nullable(2)]
		protected new AvgMoveRole FbInstance;

		// Token: 0x040045EB RID: 17899
		[Nullable(2)]
		protected AvgMoveRole_SetValue PocoInterface;

		// Token: 0x040045EC RID: 17900
		private IEaseData _EaseCurveCache;

		// Token: 0x040045ED RID: 17901
		private bool _EaseCurveInited;
	}
}
