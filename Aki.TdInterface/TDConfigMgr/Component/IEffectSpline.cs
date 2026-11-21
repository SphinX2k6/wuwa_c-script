using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200033A RID: 826
	public class IEffectSpline : ISplineType
	{
		// Token: 0x06000FBF RID: 4031 RVA: 0x0003783C File Offset: 0x00035A3C
		private IEffectSpline_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEffectSpline 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEffectSpline_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEffectSpline_SetValue());
			}
			return result;
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x00037874 File Offset: 0x00035A74
		public static IEffectSpline Create([Nullable(2)] IEffectSpline instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEffectSpline
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x00037887 File Offset: 0x00035A87
		public static IEffectSpline CreateFromSetValue([Nullable(2)] IEffectSpline_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEffectSpline
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x0003789A File Offset: 0x00035A9A
		public new IEffectSpline_SetValue ToSetValue()
		{
			return new IEffectSpline_SetValue
			{
				Type = this.Type,
				Effect = this.Effect,
				CreateOption = this.CreateOption,
				Points = this.Points
			};
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000FC3 RID: 4035 RVA: 0x000378D1 File Offset: 0x00035AD1
		// (set) Token: 0x06000FC4 RID: 4036 RVA: 0x000378FC File Offset: 0x00035AFC
		public override ESplineType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESplineType.Common;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000FC5 RID: 4037 RVA: 0x0003790A File Offset: 0x00035B0A
		// (set) Token: 0x06000FC6 RID: 4038 RVA: 0x00037935 File Offset: 0x00035B35
		public virtual string Effect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Effect;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Effect;
			}
			set
			{
				this.GetOrCreatePoco().Effect = value;
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000FC7 RID: 4039 RVA: 0x00037943 File Offset: 0x00035B43
		// (set) Token: 0x06000FC8 RID: 4040 RVA: 0x0003796A File Offset: 0x00035B6A
		public virtual IEffectSplineCreationMode CreateOption
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CreateOption;
				}
				IEffectSpline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CreateOption;
			}
			set
			{
				this.GetOrCreatePoco().CreateOption = value;
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000FC9 RID: 4041 RVA: 0x00037978 File Offset: 0x00035B78
		// (set) Token: 0x06000FCA RID: 4042 RVA: 0x00037A0B File Offset: 0x00035C0B
		public virtual List<ICommonSplinePoint> Points
		{
			get
			{
				if (this._PointsInited)
				{
					return this._PointsCache;
				}
				this._PointsInited = true;
				if (this.FbInstance != null)
				{
					List<ICommonSplinePoint> points = this.FbInstance.Points;
					if (points != null)
					{
						this._PointsCache = new List<ICommonSplinePoint>(points.Count);
						for (int i = 0; i < points.Count; i++)
						{
							this._PointsCache.Add(ICommonSplinePoint.Create(points[i]));
						}
					}
				}
				else
				{
					IEffectSpline_SetValue pocoInterface = this.PocoInterface;
					this._PointsCache = ((pocoInterface != null) ? pocoInterface.Points : null);
				}
				return this._PointsCache;
			}
			set
			{
				this.GetOrCreatePoco().Points = value;
				this._PointsInited = false;
			}
		}

		// Token: 0x04000DC1 RID: 3521
		[Nullable(2)]
		protected new IEffectSpline FbInstance;

		// Token: 0x04000DC2 RID: 3522
		[Nullable(2)]
		protected new IEffectSpline_SetValue PocoInterface;

		// Token: 0x04000DC3 RID: 3523
		private List<ICommonSplinePoint> _PointsCache;

		// Token: 0x04000DC4 RID: 3524
		private bool _PointsInited;
	}
}
