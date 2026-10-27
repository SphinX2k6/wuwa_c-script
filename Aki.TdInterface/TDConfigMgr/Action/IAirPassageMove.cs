using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017CC RID: 6092
	[NullableContext(1)]
	[Nullable(0)]
	public class IAirPassageMove : ISplineMovePattern
	{
		// Token: 0x060082C9 RID: 33481 RVA: 0x00138AEC File Offset: 0x00136CEC
		private IAirPassageMove_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAirPassageMove 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAirPassageMove_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAirPassageMove_SetValue());
			}
			return result;
		}

		// Token: 0x060082CA RID: 33482 RVA: 0x00138B24 File Offset: 0x00136D24
		public static IAirPassageMove Create([Nullable(2)] IAirPassageMove instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAirPassageMove
			{
				FbInstance = instance
			};
		}

		// Token: 0x060082CB RID: 33483 RVA: 0x00138B37 File Offset: 0x00136D37
		public static IAirPassageMove CreateFromSetValue([Nullable(2)] IAirPassageMove_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAirPassageMove
			{
				PocoInterface = value
			};
		}

		// Token: 0x060082CC RID: 33484 RVA: 0x00138B4C File Offset: 0x00136D4C
		public new IAirPassageMove_SetValue ToSetValue()
		{
			return new IAirPassageMove_SetValue
			{
				Type = this.Type,
				MaxOffsetDistance = this.MaxOffsetDistance,
				IsOneWay = this.IsOneWay,
				LayerVerticalLimit = this.LayerVerticalLimit,
				DynamicGravity = this.DynamicGravity,
				GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity,
				AutoExitDistance = this.AutoExitDistance,
				Limit = this.Limit
			};
		}

		// Token: 0x17002B07 RID: 11015
		// (get) Token: 0x060082CD RID: 33485 RVA: 0x00138BBE File Offset: 0x00136DBE
		// (set) Token: 0x060082CE RID: 33486 RVA: 0x00138BE9 File Offset: 0x00136DE9
		public override ESplineMovePattern Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESplineMovePattern.PathLine;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002B08 RID: 11016
		// (get) Token: 0x060082CF RID: 33487 RVA: 0x00138BF8 File Offset: 0x00136DF8
		// (set) Token: 0x060082D0 RID: 33488 RVA: 0x00138C32 File Offset: 0x00136E32
		public override float? MaxOffsetDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxOffsetDistance;
				}
				IAirPassageMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MaxOffsetDistance;
			}
			set
			{
				this.GetOrCreatePoco().MaxOffsetDistance = value;
			}
		}

		// Token: 0x17002B09 RID: 11017
		// (get) Token: 0x060082D1 RID: 33489 RVA: 0x00138C40 File Offset: 0x00136E40
		// (set) Token: 0x060082D2 RID: 33490 RVA: 0x00138C7A File Offset: 0x00136E7A
		public override bool? IsOneWay
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsOneWay;
				}
				IAirPassageMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsOneWay;
			}
			set
			{
				this.GetOrCreatePoco().IsOneWay = value;
			}
		}

		// Token: 0x17002B0A RID: 11018
		// (get) Token: 0x060082D3 RID: 33491 RVA: 0x00138C88 File Offset: 0x00136E88
		// (set) Token: 0x060082D4 RID: 33492 RVA: 0x00138CC2 File Offset: 0x00136EC2
		public override float? LayerVerticalLimit
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LayerVerticalLimit;
				}
				IAirPassageMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LayerVerticalLimit;
			}
			set
			{
				this.GetOrCreatePoco().LayerVerticalLimit = value;
			}
		}

		// Token: 0x17002B0B RID: 11019
		// (get) Token: 0x060082D5 RID: 33493 RVA: 0x00138CD0 File Offset: 0x00136ED0
		// (set) Token: 0x060082D6 RID: 33494 RVA: 0x00138D0A File Offset: 0x00136F0A
		public override bool? DynamicGravity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DynamicGravity;
				}
				IAirPassageMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DynamicGravity;
			}
			set
			{
				this.GetOrCreatePoco().DynamicGravity = value;
			}
		}

		// Token: 0x17002B0C RID: 11020
		// (get) Token: 0x060082D7 RID: 33495 RVA: 0x00138D18 File Offset: 0x00136F18
		// (set) Token: 0x060082D8 RID: 33496 RVA: 0x00138D52 File Offset: 0x00136F52
		public override float? GravitySwitchAngularVelocity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GravitySwitchAngularVelocity;
				}
				IAirPassageMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.GravitySwitchAngularVelocity;
			}
			set
			{
				this.GetOrCreatePoco().GravitySwitchAngularVelocity = value;
			}
		}

		// Token: 0x17002B0D RID: 11021
		// (get) Token: 0x060082D9 RID: 33497 RVA: 0x00138D60 File Offset: 0x00136F60
		// (set) Token: 0x060082DA RID: 33498 RVA: 0x00138D9A File Offset: 0x00136F9A
		public override int? AutoExitDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AutoExitDistance;
				}
				IAirPassageMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AutoExitDistance;
			}
			set
			{
				this.GetOrCreatePoco().AutoExitDistance = value;
			}
		}

		// Token: 0x17002B0E RID: 11022
		// (get) Token: 0x060082DB RID: 33499 RVA: 0x00138DA8 File Offset: 0x00136FA8
		// (set) Token: 0x060082DC RID: 33500 RVA: 0x00138E09 File Offset: 0x00137009
		[Nullable(2)]
		public virtual IAirPassageMoveLimit Limit
		{
			[NullableContext(2)]
			get
			{
				if (this._LimitInited)
				{
					return this._LimitCache;
				}
				this._LimitInited = true;
				if (this.FbInstance != null)
				{
					this._LimitCache = IAirPassageMoveLimit.Create(this.FbInstance.Limit);
				}
				else
				{
					IAirPassageMove_SetValue pocoInterface = this.PocoInterface;
					this._LimitCache = ((pocoInterface != null) ? pocoInterface.Limit : null);
				}
				return this._LimitCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().Limit = value;
				this._LimitInited = false;
			}
		}

		// Token: 0x0400531E RID: 21278
		[Nullable(2)]
		protected new IAirPassageMove FbInstance;

		// Token: 0x0400531F RID: 21279
		[Nullable(2)]
		protected new IAirPassageMove_SetValue PocoInterface;

		// Token: 0x04005320 RID: 21280
		private IAirPassageMoveLimit _LimitCache;

		// Token: 0x04005321 RID: 21281
		private bool _LimitInited;
	}
}
