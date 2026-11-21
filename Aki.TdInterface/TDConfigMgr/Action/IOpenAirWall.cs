using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E91 RID: 7825
	[NullableContext(2)]
	[Nullable(0)]
	public class IOpenAirWall : IToggleAirWallType
	{
		// Token: 0x0600A65B RID: 42587 RVA: 0x0017AFF8 File Offset: 0x001791F8
		[NullableContext(0)]
		private IOpenAirWall_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOpenAirWall 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOpenAirWall_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOpenAirWall_SetValue());
			}
			return result;
		}

		// Token: 0x0600A65C RID: 42588 RVA: 0x0017B030 File Offset: 0x00179230
		[NullableContext(0)]
		public static IOpenAirWall Create([Nullable(2)] IOpenAirWall instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOpenAirWall
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A65D RID: 42589 RVA: 0x0017B043 File Offset: 0x00179243
		[NullableContext(0)]
		public static IOpenAirWall CreateFromSetValue([Nullable(2)] IOpenAirWall_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOpenAirWall
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A65E RID: 42590 RVA: 0x0017B058 File Offset: 0x00179258
		[NullableContext(0)]
		public new IOpenAirWall_SetValue ToSetValue()
		{
			return new IOpenAirWall_SetValue
			{
				Type = this.Type,
				HitEffectData = this.HitEffectData,
				HitCd = this.HitCd,
				AirWallEffectData = this.AirWallEffectData,
				VectorArrayAirWallEffectData = this.VectorArrayAirWallEffectData,
				AirWallEffectSplineEntityId = this.AirWallEffectSplineEntityId,
				AirWallEffectHeight = this.AirWallEffectHeight,
				AirWallEffectThickness = this.AirWallEffectThickness,
				CollisionPreset = this.CollisionPreset
			};
		}

		// Token: 0x17003362 RID: 13154
		// (get) Token: 0x0600A65F RID: 42591 RVA: 0x0017B0D6 File Offset: 0x001792D6
		// (set) Token: 0x0600A660 RID: 42592 RVA: 0x0017B101 File Offset: 0x00179301
		public override EToggleAirWall Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EToggleAirWall.Open;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003363 RID: 13155
		// (get) Token: 0x0600A661 RID: 42593 RVA: 0x0017B10F File Offset: 0x0017930F
		// (set) Token: 0x0600A662 RID: 42594 RVA: 0x0017B136 File Offset: 0x00179336
		public virtual string HitEffectData
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HitEffectData;
				}
				IOpenAirWall_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HitEffectData;
			}
			set
			{
				this.GetOrCreatePoco().HitEffectData = value;
			}
		}

		// Token: 0x17003364 RID: 13156
		// (get) Token: 0x0600A663 RID: 42595 RVA: 0x0017B144 File Offset: 0x00179344
		// (set) Token: 0x0600A664 RID: 42596 RVA: 0x0017B17E File Offset: 0x0017937E
		public virtual float? HitCd
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HitCd;
				}
				IOpenAirWall_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HitCd;
			}
			set
			{
				this.GetOrCreatePoco().HitCd = value;
			}
		}

		// Token: 0x17003365 RID: 13157
		// (get) Token: 0x0600A665 RID: 42597 RVA: 0x0017B18C File Offset: 0x0017938C
		// (set) Token: 0x0600A666 RID: 42598 RVA: 0x0017B1B3 File Offset: 0x001793B3
		public virtual string AirWallEffectData
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AirWallEffectData;
				}
				IOpenAirWall_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AirWallEffectData;
			}
			set
			{
				this.GetOrCreatePoco().AirWallEffectData = value;
			}
		}

		// Token: 0x17003366 RID: 13158
		// (get) Token: 0x0600A667 RID: 42599 RVA: 0x0017B1C1 File Offset: 0x001793C1
		// (set) Token: 0x0600A668 RID: 42600 RVA: 0x0017B1E8 File Offset: 0x001793E8
		public virtual string VectorArrayAirWallEffectData
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.VectorArrayAirWallEffectData;
				}
				IOpenAirWall_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.VectorArrayAirWallEffectData;
			}
			set
			{
				this.GetOrCreatePoco().VectorArrayAirWallEffectData = value;
			}
		}

		// Token: 0x17003367 RID: 13159
		// (get) Token: 0x0600A669 RID: 42601 RVA: 0x0017B1F8 File Offset: 0x001793F8
		// (set) Token: 0x0600A66A RID: 42602 RVA: 0x0017B232 File Offset: 0x00179432
		public virtual int? AirWallEffectSplineEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AirWallEffectSplineEntityId;
				}
				IOpenAirWall_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AirWallEffectSplineEntityId;
			}
			set
			{
				this.GetOrCreatePoco().AirWallEffectSplineEntityId = value;
			}
		}

		// Token: 0x17003368 RID: 13160
		// (get) Token: 0x0600A66B RID: 42603 RVA: 0x0017B240 File Offset: 0x00179440
		// (set) Token: 0x0600A66C RID: 42604 RVA: 0x0017B27A File Offset: 0x0017947A
		public virtual float? AirWallEffectHeight
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AirWallEffectHeight;
				}
				IOpenAirWall_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AirWallEffectHeight;
			}
			set
			{
				this.GetOrCreatePoco().AirWallEffectHeight = value;
			}
		}

		// Token: 0x17003369 RID: 13161
		// (get) Token: 0x0600A66D RID: 42605 RVA: 0x0017B288 File Offset: 0x00179488
		// (set) Token: 0x0600A66E RID: 42606 RVA: 0x0017B2C2 File Offset: 0x001794C2
		public virtual float? AirWallEffectThickness
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AirWallEffectThickness;
				}
				IOpenAirWall_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AirWallEffectThickness;
			}
			set
			{
				this.GetOrCreatePoco().AirWallEffectThickness = value;
			}
		}

		// Token: 0x1700336A RID: 13162
		// (get) Token: 0x0600A66F RID: 42607 RVA: 0x0017B2D0 File Offset: 0x001794D0
		// (set) Token: 0x0600A670 RID: 42608 RVA: 0x0017B2FB File Offset: 0x001794FB
		public virtual EAirWallCollisionPreset CollisionPreset
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CollisionPreset;
				}
				if (this.PocoInterface == null)
				{
					return EAirWallCollisionPreset.Normal;
				}
				return this.PocoInterface.CollisionPreset;
			}
			set
			{
				this.GetOrCreatePoco().CollisionPreset = value;
			}
		}

		// Token: 0x04006455 RID: 25685
		protected new IOpenAirWall FbInstance;

		// Token: 0x04006456 RID: 25686
		protected new IOpenAirWall_SetValue PocoInterface;
	}
}
