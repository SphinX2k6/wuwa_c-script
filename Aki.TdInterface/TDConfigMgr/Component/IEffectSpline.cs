using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002F3 RID: 755
	[NullableContext(1)]
	[Nullable(0)]
	public class IEffectSpline : ISplineType
	{
		// Token: 0x06000E8F RID: 3727 RVA: 0x00034908 File Offset: 0x00032B08
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

		// Token: 0x06000E90 RID: 3728 RVA: 0x00034940 File Offset: 0x00032B40
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

		// Token: 0x06000E91 RID: 3729 RVA: 0x00034953 File Offset: 0x00032B53
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

		// Token: 0x06000E92 RID: 3730 RVA: 0x00034966 File Offset: 0x00032B66
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

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000E93 RID: 3731 RVA: 0x0003499D File Offset: 0x00032B9D
		// (set) Token: 0x06000E94 RID: 3732 RVA: 0x000349C8 File Offset: 0x00032BC8
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

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000E95 RID: 3733 RVA: 0x000349D6 File Offset: 0x00032BD6
		// (set) Token: 0x06000E96 RID: 3734 RVA: 0x00034A01 File Offset: 0x00032C01
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

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000E97 RID: 3735 RVA: 0x00034A0F File Offset: 0x00032C0F
		// (set) Token: 0x06000E98 RID: 3736 RVA: 0x00034A36 File Offset: 0x00032C36
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

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000E99 RID: 3737 RVA: 0x00034A44 File Offset: 0x00032C44
		// (set) Token: 0x06000E9A RID: 3738 RVA: 0x00034AD7 File Offset: 0x00032CD7
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

		// Token: 0x04000CD7 RID: 3287
		[Nullable(2)]
		protected new IEffectSpline FbInstance;

		// Token: 0x04000CD8 RID: 3288
		[Nullable(2)]
		protected new IEffectSpline_SetValue PocoInterface;

		// Token: 0x04000CD9 RID: 3289
		private List<ICommonSplinePoint> _PointsCache;

		// Token: 0x04000CDA RID: 3290
		private bool _PointsInited;
	}
}
