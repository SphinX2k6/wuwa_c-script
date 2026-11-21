using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001953 RID: 6483
	public class IAirPassageMove : ISplineMovePattern
	{
		// Token: 0x060089DB RID: 35291 RVA: 0x001480D4 File Offset: 0x001462D4
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

		// Token: 0x060089DC RID: 35292 RVA: 0x0014810C File Offset: 0x0014630C
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

		// Token: 0x060089DD RID: 35293 RVA: 0x0014811F File Offset: 0x0014631F
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

		// Token: 0x060089DE RID: 35294 RVA: 0x00148134 File Offset: 0x00146334
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

		// Token: 0x17002CFD RID: 11517
		// (get) Token: 0x060089DF RID: 35295 RVA: 0x001481A6 File Offset: 0x001463A6
		// (set) Token: 0x060089E0 RID: 35296 RVA: 0x001481D1 File Offset: 0x001463D1
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

		// Token: 0x17002CFE RID: 11518
		// (get) Token: 0x060089E1 RID: 35297 RVA: 0x001481E0 File Offset: 0x001463E0
		// (set) Token: 0x060089E2 RID: 35298 RVA: 0x0014821A File Offset: 0x0014641A
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

		// Token: 0x17002CFF RID: 11519
		// (get) Token: 0x060089E3 RID: 35299 RVA: 0x00148228 File Offset: 0x00146428
		// (set) Token: 0x060089E4 RID: 35300 RVA: 0x00148262 File Offset: 0x00146462
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

		// Token: 0x17002D00 RID: 11520
		// (get) Token: 0x060089E5 RID: 35301 RVA: 0x00148270 File Offset: 0x00146470
		// (set) Token: 0x060089E6 RID: 35302 RVA: 0x001482AA File Offset: 0x001464AA
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

		// Token: 0x17002D01 RID: 11521
		// (get) Token: 0x060089E7 RID: 35303 RVA: 0x001482B8 File Offset: 0x001464B8
		// (set) Token: 0x060089E8 RID: 35304 RVA: 0x001482F2 File Offset: 0x001464F2
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

		// Token: 0x17002D02 RID: 11522
		// (get) Token: 0x060089E9 RID: 35305 RVA: 0x00148300 File Offset: 0x00146500
		// (set) Token: 0x060089EA RID: 35306 RVA: 0x0014833A File Offset: 0x0014653A
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

		// Token: 0x17002D03 RID: 11523
		// (get) Token: 0x060089EB RID: 35307 RVA: 0x00148348 File Offset: 0x00146548
		// (set) Token: 0x060089EC RID: 35308 RVA: 0x00148382 File Offset: 0x00146582
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

		// Token: 0x17002D04 RID: 11524
		// (get) Token: 0x060089ED RID: 35309 RVA: 0x00148390 File Offset: 0x00146590
		// (set) Token: 0x060089EE RID: 35310 RVA: 0x001483F1 File Offset: 0x001465F1
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

		// Token: 0x04005762 RID: 22370
		[Nullable(2)]
		protected new IAirPassageMove FbInstance;

		// Token: 0x04005763 RID: 22371
		[Nullable(2)]
		protected new IAirPassageMove_SetValue PocoInterface;

		// Token: 0x04005764 RID: 22372
		private IAirPassageMoveLimit _LimitCache;

		// Token: 0x04005765 RID: 22373
		private bool _LimitInited;
	}
}
