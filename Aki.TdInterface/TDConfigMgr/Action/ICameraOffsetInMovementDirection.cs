using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019D3 RID: 6611
	public class ICameraOffsetInMovementDirection
	{
		// Token: 0x06008CA3 RID: 36003 RVA: 0x0014CFA8 File Offset: 0x0014B1A8
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

		// Token: 0x06008CA4 RID: 36004 RVA: 0x0014CFE0 File Offset: 0x0014B1E0
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

		// Token: 0x06008CA5 RID: 36005 RVA: 0x0014CFF3 File Offset: 0x0014B1F3
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

		// Token: 0x06008CA6 RID: 36006 RVA: 0x0014D008 File Offset: 0x0014B208
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

		// Token: 0x17002DA1 RID: 11681
		// (get) Token: 0x06008CA7 RID: 36007 RVA: 0x0014D06E File Offset: 0x0014B26E
		// (set) Token: 0x06008CA8 RID: 36008 RVA: 0x0014D09D File Offset: 0x0014B29D
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

		// Token: 0x17002DA2 RID: 11682
		// (get) Token: 0x06008CA9 RID: 36009 RVA: 0x0014D0AB File Offset: 0x0014B2AB
		// (set) Token: 0x06008CAA RID: 36010 RVA: 0x0014D0DA File Offset: 0x0014B2DA
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

		// Token: 0x17002DA3 RID: 11683
		// (get) Token: 0x06008CAB RID: 36011 RVA: 0x0014D0E8 File Offset: 0x0014B2E8
		// (set) Token: 0x06008CAC RID: 36012 RVA: 0x0014D117 File Offset: 0x0014B317
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

		// Token: 0x17002DA4 RID: 11684
		// (get) Token: 0x06008CAD RID: 36013 RVA: 0x0014D125 File Offset: 0x0014B325
		// (set) Token: 0x06008CAE RID: 36014 RVA: 0x0014D154 File Offset: 0x0014B354
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

		// Token: 0x17002DA5 RID: 11685
		// (get) Token: 0x06008CAF RID: 36015 RVA: 0x0014D164 File Offset: 0x0014B364
		// (set) Token: 0x06008CB0 RID: 36016 RVA: 0x0014D1C5 File Offset: 0x0014B3C5
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

		// Token: 0x17002DA6 RID: 11686
		// (get) Token: 0x06008CB1 RID: 36017 RVA: 0x0014D1DC File Offset: 0x0014B3DC
		// (set) Token: 0x06008CB2 RID: 36018 RVA: 0x0014D216 File Offset: 0x0014B416
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

		// Token: 0x17002DA7 RID: 11687
		// (get) Token: 0x06008CB3 RID: 36019 RVA: 0x0014D224 File Offset: 0x0014B424
		// (set) Token: 0x06008CB4 RID: 36020 RVA: 0x0014D25E File Offset: 0x0014B45E
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

		// Token: 0x0400589C RID: 22684
		[Nullable(2)]
		protected ICameraOffsetInMovementDirection FbInstance;

		// Token: 0x0400589D RID: 22685
		[Nullable(2)]
		protected ICameraOffsetInMovementDirection_SetValue PocoInterface;

		// Token: 0x0400589E RID: 22686
		private IBaseCurve _OffsetCurveCache;

		// Token: 0x0400589F RID: 22687
		private bool _OffsetCurveInited;
	}
}
