using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C8C RID: 7308
	[NullableContext(2)]
	[Nullable(0)]
	public class IOpenAirWall : IToggleAirWallType
	{
		// Token: 0x06009CC1 RID: 40129 RVA: 0x00167604 File Offset: 0x00165804
		[NullableContext(1)]
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

		// Token: 0x06009CC2 RID: 40130 RVA: 0x0016763C File Offset: 0x0016583C
		[NullableContext(1)]
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

		// Token: 0x06009CC3 RID: 40131 RVA: 0x0016764F File Offset: 0x0016584F
		[NullableContext(1)]
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

		// Token: 0x06009CC4 RID: 40132 RVA: 0x00167664 File Offset: 0x00165864
		[NullableContext(1)]
		public new IOpenAirWall_SetValue ToSetValue()
		{
			return new IOpenAirWall_SetValue
			{
				Type = this.Type,
				HitEffectData = this.HitEffectData,
				HitCd = this.HitCd,
				AirWallEffectData = this.AirWallEffectData,
				VectorArrayAirWallEffectData = this.VectorArrayAirWallEffectData,
				AirWallEffectHeight = this.AirWallEffectHeight,
				AirWallEffectThickness = this.AirWallEffectThickness,
				CollisionPreset = this.CollisionPreset
			};
		}

		// Token: 0x170030E5 RID: 12517
		// (get) Token: 0x06009CC5 RID: 40133 RVA: 0x001676D6 File Offset: 0x001658D6
		// (set) Token: 0x06009CC6 RID: 40134 RVA: 0x00167701 File Offset: 0x00165901
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

		// Token: 0x170030E6 RID: 12518
		// (get) Token: 0x06009CC7 RID: 40135 RVA: 0x0016770F File Offset: 0x0016590F
		// (set) Token: 0x06009CC8 RID: 40136 RVA: 0x00167736 File Offset: 0x00165936
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

		// Token: 0x170030E7 RID: 12519
		// (get) Token: 0x06009CC9 RID: 40137 RVA: 0x00167744 File Offset: 0x00165944
		// (set) Token: 0x06009CCA RID: 40138 RVA: 0x0016777E File Offset: 0x0016597E
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

		// Token: 0x170030E8 RID: 12520
		// (get) Token: 0x06009CCB RID: 40139 RVA: 0x0016778C File Offset: 0x0016598C
		// (set) Token: 0x06009CCC RID: 40140 RVA: 0x001677B3 File Offset: 0x001659B3
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

		// Token: 0x170030E9 RID: 12521
		// (get) Token: 0x06009CCD RID: 40141 RVA: 0x001677C1 File Offset: 0x001659C1
		// (set) Token: 0x06009CCE RID: 40142 RVA: 0x001677E8 File Offset: 0x001659E8
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

		// Token: 0x170030EA RID: 12522
		// (get) Token: 0x06009CCF RID: 40143 RVA: 0x001677F8 File Offset: 0x001659F8
		// (set) Token: 0x06009CD0 RID: 40144 RVA: 0x00167832 File Offset: 0x00165A32
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

		// Token: 0x170030EB RID: 12523
		// (get) Token: 0x06009CD1 RID: 40145 RVA: 0x00167840 File Offset: 0x00165A40
		// (set) Token: 0x06009CD2 RID: 40146 RVA: 0x0016787A File Offset: 0x00165A7A
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

		// Token: 0x170030EC RID: 12524
		// (get) Token: 0x06009CD3 RID: 40147 RVA: 0x00167888 File Offset: 0x00165A88
		// (set) Token: 0x06009CD4 RID: 40148 RVA: 0x001678B3 File Offset: 0x00165AB3
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

		// Token: 0x04005F02 RID: 24322
		protected new IOpenAirWall FbInstance;

		// Token: 0x04005F03 RID: 24323
		protected new IOpenAirWall_SetValue PocoInterface;
	}
}
