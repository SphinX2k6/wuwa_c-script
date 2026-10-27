using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001848 RID: 6216
	[NullableContext(1)]
	[Nullable(0)]
	public class ICameraOffsetInMovementDirection
	{
		// Token: 0x0600857D RID: 34173 RVA: 0x0013D7B4 File Offset: 0x0013B9B4
		private ICameraOffsetInMovementDirection_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICameraOffsetInMovementDirection 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICameraOffsetInMovementDirection_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICameraOffsetInMovementDirection_SetValue());
			}
			return result;
		}

		// Token: 0x0600857E RID: 34174 RVA: 0x0013D7EC File Offset: 0x0013B9EC
		public static ICameraOffsetInMovementDirection Create([Nullable(2)] ICameraOffsetInMovementDirection instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICameraOffsetInMovementDirection
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600857F RID: 34175 RVA: 0x0013D7FF File Offset: 0x0013B9FF
		public static ICameraOffsetInMovementDirection CreateFromSetValue([Nullable(2)] ICameraOffsetInMovementDirection_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICameraOffsetInMovementDirection
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008580 RID: 34176 RVA: 0x0013D814 File Offset: 0x0013BA14
		public ICameraOffsetInMovementDirection_SetValue ToSetValue()
		{
			return new ICameraOffsetInMovementDirection_SetValue
			{
				MinInterpolationSpeed = this.MinInterpolationSpeed,
				MaxInterpolationSpeed = this.MaxInterpolationSpeed,
				OffsetDistance1 = this.OffsetDistance1,
				OffsetDistance2 = this.OffsetDistance2,
				OffsetCurve = this.OffsetCurve,
				CenteringWaitTime = this.CenteringWaitTime,
				StartupWaitTime = this.StartupWaitTime
			};
		}

		// Token: 0x17002BA7 RID: 11175
		// (get) Token: 0x06008581 RID: 34177 RVA: 0x0013D87A File Offset: 0x0013BA7A
		// (set) Token: 0x06008582 RID: 34178 RVA: 0x0013D8A9 File Offset: 0x0013BAA9
		public virtual float MinInterpolationSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MinInterpolationSpeed;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.MinInterpolationSpeed;
			}
			set
			{
				this.GetOrCreatePoco().MinInterpolationSpeed = value;
			}
		}

		// Token: 0x17002BA8 RID: 11176
		// (get) Token: 0x06008583 RID: 34179 RVA: 0x0013D8B7 File Offset: 0x0013BAB7
		// (set) Token: 0x06008584 RID: 34180 RVA: 0x0013D8E6 File Offset: 0x0013BAE6
		public virtual float MaxInterpolationSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxInterpolationSpeed;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.MaxInterpolationSpeed;
			}
			set
			{
				this.GetOrCreatePoco().MaxInterpolationSpeed = value;
			}
		}

		// Token: 0x17002BA9 RID: 11177
		// (get) Token: 0x06008585 RID: 34181 RVA: 0x0013D8F4 File Offset: 0x0013BAF4
		// (set) Token: 0x06008586 RID: 34182 RVA: 0x0013D923 File Offset: 0x0013BB23
		public virtual float OffsetDistance1
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.OffsetDistance1;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.OffsetDistance1;
			}
			set
			{
				this.GetOrCreatePoco().OffsetDistance1 = value;
			}
		}

		// Token: 0x17002BAA RID: 11178
		// (get) Token: 0x06008587 RID: 34183 RVA: 0x0013D931 File Offset: 0x0013BB31
		// (set) Token: 0x06008588 RID: 34184 RVA: 0x0013D960 File Offset: 0x0013BB60
		public virtual float OffsetDistance2
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.OffsetDistance2;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.OffsetDistance2;
			}
			set
			{
				this.GetOrCreatePoco().OffsetDistance2 = value;
			}
		}

		// Token: 0x17002BAB RID: 11179
		// (get) Token: 0x06008589 RID: 34185 RVA: 0x0013D970 File Offset: 0x0013BB70
		// (set) Token: 0x0600858A RID: 34186 RVA: 0x0013D9D1 File Offset: 0x0013BBD1
		[Nullable(2)]
		public virtual IBaseCurve OffsetCurve
		{
			[NullableContext(2)]
			get
			{
				if (this._OffsetCurveInited)
				{
					return this._OffsetCurveCache;
				}
				this._OffsetCurveInited = true;
				if (this.FbInstance != null)
				{
					this._OffsetCurveCache = IBaseCurve.Create(this.FbInstance.OffsetCurve);
				}
				else
				{
					ICameraOffsetInMovementDirection_SetValue pocoInterface = this.PocoInterface;
					this._OffsetCurveCache = ((pocoInterface != null) ? pocoInterface.OffsetCurve : null);
				}
				return this._OffsetCurveCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().OffsetCurve = value;
				this._OffsetCurveInited = false;
			}
		}

		// Token: 0x17002BAC RID: 11180
		// (get) Token: 0x0600858B RID: 34187 RVA: 0x0013D9E8 File Offset: 0x0013BBE8
		// (set) Token: 0x0600858C RID: 34188 RVA: 0x0013DA22 File Offset: 0x0013BC22
		public virtual int? CenteringWaitTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CenteringWaitTime;
				}
				ICameraOffsetInMovementDirection_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CenteringWaitTime;
			}
			set
			{
				this.GetOrCreatePoco().CenteringWaitTime = value;
			}
		}

		// Token: 0x17002BAD RID: 11181
		// (get) Token: 0x0600858D RID: 34189 RVA: 0x0013DA30 File Offset: 0x0013BC30
		// (set) Token: 0x0600858E RID: 34190 RVA: 0x0013DA6A File Offset: 0x0013BC6A
		public virtual int? StartupWaitTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StartupWaitTime;
				}
				ICameraOffsetInMovementDirection_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StartupWaitTime;
			}
			set
			{
				this.GetOrCreatePoco().StartupWaitTime = value;
			}
		}

		// Token: 0x04005450 RID: 21584
		[Nullable(2)]
		protected ICameraOffsetInMovementDirection FbInstance;

		// Token: 0x04005451 RID: 21585
		[Nullable(2)]
		protected ICameraOffsetInMovementDirection_SetValue PocoInterface;

		// Token: 0x04005452 RID: 21586
		private IBaseCurve _OffsetCurveCache;

		// Token: 0x04005453 RID: 21587
		private bool _OffsetCurveInited;
	}
}
