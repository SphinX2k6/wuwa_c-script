using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AC6 RID: 23238
	public struct ITrafficNavigationConfig : IFlatbufferObject
	{
		// Token: 0x1700AF05 RID: 44805
		// (get) Token: 0x060279A0 RID: 162208 RVA: 0x005722CA File Offset: 0x005704CA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060279A1 RID: 162209 RVA: 0x005722D7 File Offset: 0x005704D7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060279A2 RID: 162210 RVA: 0x005722E0 File Offset: 0x005704E0
		public static ITrafficNavigationConfig GetRootAsITrafficNavigationConfig(ByteBuffer _bb)
		{
			return ITrafficNavigationConfig.GetRootAsITrafficNavigationConfig(_bb, default(ITrafficNavigationConfig));
		}

		// Token: 0x060279A3 RID: 162211 RVA: 0x005722FC File Offset: 0x005704FC
		public static ITrafficNavigationConfig GetRootAsITrafficNavigationConfig(ByteBuffer _bb, ITrafficNavigationConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060279A4 RID: 162212 RVA: 0x00572319 File Offset: 0x00570519
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060279A5 RID: 162213 RVA: 0x00572328 File Offset: 0x00570528
		public ITrafficNavigationConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AF06 RID: 44806
		// (get) Token: 0x060279A6 RID: 162214 RVA: 0x00572338 File Offset: 0x00570538
		public ERoadNetworkNavigationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERoadNetworkNavigationType.Traffic;
				}
				return (ERoadNetworkNavigationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AF07 RID: 44807
		// (get) Token: 0x060279A7 RID: 162215 RVA: 0x00572374 File Offset: 0x00570574
		public IVectorInfo? Size
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AF08 RID: 44808
		// (get) Token: 0x060279A8 RID: 162216 RVA: 0x005723D4 File Offset: 0x005705D4
		public TTriggerShape BoundingVolumeType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TTriggerShape.NONE;
				}
				return (TTriggerShape)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060279A9 RID: 162217 RVA: 0x00572410 File Offset: 0x00570610
		public TTable? BoundingVolume<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060279AA RID: 162218 RVA: 0x00572458 File Offset: 0x00570658
		public IActorCollisionTriggerShape BoundingVolumeAsIActorCollisionTriggerShape()
		{
			return this.BoundingVolume<IActorCollisionTriggerShape>().Value;
		}

		// Token: 0x060279AB RID: 162219 RVA: 0x00572474 File Offset: 0x00570674
		public IActorRefVolume BoundingVolumeAsIActorRefVolume()
		{
			return this.BoundingVolume<IActorRefVolume>().Value;
		}

		// Token: 0x060279AC RID: 162220 RVA: 0x00572490 File Offset: 0x00570690
		public IBoxTriggerShape BoundingVolumeAsIBoxTriggerShape()
		{
			return this.BoundingVolume<IBoxTriggerShape>().Value;
		}

		// Token: 0x060279AD RID: 162221 RVA: 0x005724AC File Offset: 0x005706AC
		public ICombinationTriggerShape BoundingVolumeAsICombinationTriggerShape()
		{
			return this.BoundingVolume<ICombinationTriggerShape>().Value;
		}

		// Token: 0x060279AE RID: 162222 RVA: 0x005724C8 File Offset: 0x005706C8
		public IConeTriggerShape BoundingVolumeAsIConeTriggerShape()
		{
			return this.BoundingVolume<IConeTriggerShape>().Value;
		}

		// Token: 0x060279AF RID: 162223 RVA: 0x005724E4 File Offset: 0x005706E4
		public ICylinderTriggerShape BoundingVolumeAsICylinderTriggerShape()
		{
			return this.BoundingVolume<ICylinderTriggerShape>().Value;
		}

		// Token: 0x060279B0 RID: 162224 RVA: 0x00572500 File Offset: 0x00570700
		public IHollowCylinderTriggerShape BoundingVolumeAsIHollowCylinderTriggerShape()
		{
			return this.BoundingVolume<IHollowCylinderTriggerShape>().Value;
		}

		// Token: 0x060279B1 RID: 162225 RVA: 0x0057251C File Offset: 0x0057071C
		public IHollowSphereTriggerShape BoundingVolumeAsIHollowSphereTriggerShape()
		{
			return this.BoundingVolume<IHollowSphereTriggerShape>().Value;
		}

		// Token: 0x060279B2 RID: 162226 RVA: 0x00572538 File Offset: 0x00570738
		public ISphereTriggerShape BoundingVolumeAsISphereTriggerShape()
		{
			return this.BoundingVolume<ISphereTriggerShape>().Value;
		}

		// Token: 0x060279B3 RID: 162227 RVA: 0x00572554 File Offset: 0x00570754
		public ISpotlightTriggerShape BoundingVolumeAsISpotlightTriggerShape()
		{
			return this.BoundingVolume<ISpotlightTriggerShape>().Value;
		}

		// Token: 0x060279B4 RID: 162228 RVA: 0x00572570 File Offset: 0x00570770
		public IVolumeTriggerShape BoundingVolumeAsIVolumeTriggerShape()
		{
			return this.BoundingVolume<IVolumeTriggerShape>().Value;
		}

		// Token: 0x1700AF09 RID: 44809
		// (get) Token: 0x060279B5 RID: 162229 RVA: 0x0057258C File Offset: 0x0057078C
		public float MaxSpeed
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AF0A RID: 44810
		// (get) Token: 0x060279B6 RID: 162230 RVA: 0x005725D0 File Offset: 0x005707D0
		public float Acceleration
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AF0B RID: 44811
		// (get) Token: 0x060279B7 RID: 162231 RVA: 0x00572614 File Offset: 0x00570814
		public string MaxSpeedCurve
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060279B8 RID: 162232 RVA: 0x0057264C File Offset: 0x0057084C
		public Span<byte> GetMaxSpeedCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060279B9 RID: 162233 RVA: 0x0057265C File Offset: 0x0057085C
		public byte[] GetMaxSpeedCurveArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x1700AF0C RID: 44812
		// (get) Token: 0x060279BA RID: 162234 RVA: 0x0057266C File Offset: 0x0057086C
		public string HitEffect
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060279BB RID: 162235 RVA: 0x005726A4 File Offset: 0x005708A4
		public Span<byte> GetHitEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060279BC RID: 162236 RVA: 0x005726B4 File Offset: 0x005708B4
		public byte[] GetHitEffectArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x060279BD RID: 162237 RVA: 0x005726C4 File Offset: 0x005708C4
		public static Offset<ITrafficNavigationConfig> CreateITrafficNavigationConfig(FlatBufferBuilder builder, ERoadNetworkNavigationType Type = ERoadNetworkNavigationType.Traffic, Offset<IVectorInfo> SizeOffset = default(Offset<IVectorInfo>), TTriggerShape BoundingVolume_type = TTriggerShape.NONE, int BoundingVolumeOffset = 0, float MaxSpeed = 0f, float Acceleration = 0f, StringOffset MaxSpeedCurveOffset = default(StringOffset), StringOffset HitEffectOffset = default(StringOffset))
		{
			builder.StartTable(8);
			ITrafficNavigationConfig.AddHitEffect(builder, HitEffectOffset);
			ITrafficNavigationConfig.AddMaxSpeedCurve(builder, MaxSpeedCurveOffset);
			ITrafficNavigationConfig.AddAcceleration(builder, Acceleration);
			ITrafficNavigationConfig.AddMaxSpeed(builder, MaxSpeed);
			ITrafficNavigationConfig.AddBoundingVolume(builder, BoundingVolumeOffset);
			ITrafficNavigationConfig.AddSize(builder, SizeOffset);
			ITrafficNavigationConfig.AddBoundingVolumeType(builder, BoundingVolume_type);
			ITrafficNavigationConfig.AddType(builder, Type);
			return ITrafficNavigationConfig.EndITrafficNavigationConfig(builder);
		}

		// Token: 0x060279BE RID: 162238 RVA: 0x0057271B File Offset: 0x0057091B
		public static void StartITrafficNavigationConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x060279BF RID: 162239 RVA: 0x00572724 File Offset: 0x00570924
		public static void AddType(FlatBufferBuilder builder, ERoadNetworkNavigationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060279C0 RID: 162240 RVA: 0x0057272F File Offset: 0x0057092F
		public static void AddSize(FlatBufferBuilder builder, Offset<IVectorInfo> sizeOffset)
		{
			builder.AddOffset(1, sizeOffset.Value, 0);
		}

		// Token: 0x060279C1 RID: 162241 RVA: 0x0057273F File Offset: 0x0057093F
		public static void AddBoundingVolumeType(FlatBufferBuilder builder, TTriggerShape boundingVolumeType)
		{
			builder.AddByte(2, (byte)boundingVolumeType, 0);
		}

		// Token: 0x060279C2 RID: 162242 RVA: 0x0057274A File Offset: 0x0057094A
		public static void AddBoundingVolume(FlatBufferBuilder builder, int boundingVolumeOffset)
		{
			builder.AddOffset(3, boundingVolumeOffset, 0);
		}

		// Token: 0x060279C3 RID: 162243 RVA: 0x00572755 File Offset: 0x00570955
		public static void AddMaxSpeed(FlatBufferBuilder builder, float maxSpeed)
		{
			builder.AddFloat(4, maxSpeed, 0.0);
		}

		// Token: 0x060279C4 RID: 162244 RVA: 0x00572768 File Offset: 0x00570968
		public static void AddAcceleration(FlatBufferBuilder builder, float acceleration)
		{
			builder.AddFloat(5, acceleration, 0.0);
		}

		// Token: 0x060279C5 RID: 162245 RVA: 0x0057277B File Offset: 0x0057097B
		public static void AddMaxSpeedCurve(FlatBufferBuilder builder, StringOffset maxSpeedCurveOffset)
		{
			builder.AddOffset(6, maxSpeedCurveOffset.Value, 0);
		}

		// Token: 0x060279C6 RID: 162246 RVA: 0x0057278B File Offset: 0x0057098B
		public static void AddHitEffect(FlatBufferBuilder builder, StringOffset hitEffectOffset)
		{
			builder.AddOffset(7, hitEffectOffset.Value, 0);
		}

		// Token: 0x060279C7 RID: 162247 RVA: 0x0057279B File Offset: 0x0057099B
		public static Offset<ITrafficNavigationConfig> EndITrafficNavigationConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITrafficNavigationConfig>(builder.EndTable());
		}

		// Token: 0x060279C8 RID: 162248 RVA: 0x005727A8 File Offset: 0x005709A8
		public ITrafficNavigationConfigT UnPack()
		{
			ITrafficNavigationConfigT trafficNavigationConfigT = new ITrafficNavigationConfigT();
			this.UnPackTo(trafficNavigationConfigT);
			return trafficNavigationConfigT;
		}

		// Token: 0x060279C9 RID: 162249 RVA: 0x005727C4 File Offset: 0x005709C4
		public void UnPackTo(ITrafficNavigationConfigT _o)
		{
			_o.Type = this.Type;
			_o.Size = ((this.Size != null) ? this.Size.Value.UnPack() : null);
			_o.BoundingVolume = new TTriggerShapeUnion();
			_o.BoundingVolume.Type = this.BoundingVolumeType;
			switch (this.BoundingVolumeType)
			{
			case TTriggerShape.IActorCollisionTriggerShape:
				_o.BoundingVolume.Value = ((this.BoundingVolume<IActorCollisionTriggerShape>() != null) ? this.BoundingVolume<IActorCollisionTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.IActorRefVolume:
				_o.BoundingVolume.Value = ((this.BoundingVolume<IActorRefVolume>() != null) ? this.BoundingVolume<IActorRefVolume>().Value.UnPack() : null);
				break;
			case TTriggerShape.IBoxTriggerShape:
				_o.BoundingVolume.Value = ((this.BoundingVolume<IBoxTriggerShape>() != null) ? this.BoundingVolume<IBoxTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.ICombinationTriggerShape:
				_o.BoundingVolume.Value = ((this.BoundingVolume<ICombinationTriggerShape>() != null) ? this.BoundingVolume<ICombinationTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.IConeTriggerShape:
				_o.BoundingVolume.Value = ((this.BoundingVolume<IConeTriggerShape>() != null) ? this.BoundingVolume<IConeTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.ICylinderTriggerShape:
				_o.BoundingVolume.Value = ((this.BoundingVolume<ICylinderTriggerShape>() != null) ? this.BoundingVolume<ICylinderTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.IHollowCylinderTriggerShape:
				_o.BoundingVolume.Value = ((this.BoundingVolume<IHollowCylinderTriggerShape>() != null) ? this.BoundingVolume<IHollowCylinderTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.IHollowSphereTriggerShape:
				_o.BoundingVolume.Value = ((this.BoundingVolume<IHollowSphereTriggerShape>() != null) ? this.BoundingVolume<IHollowSphereTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.ISphereTriggerShape:
				_o.BoundingVolume.Value = ((this.BoundingVolume<ISphereTriggerShape>() != null) ? this.BoundingVolume<ISphereTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.ISpotlightTriggerShape:
				_o.BoundingVolume.Value = ((this.BoundingVolume<ISpotlightTriggerShape>() != null) ? this.BoundingVolume<ISpotlightTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.IVolumeTriggerShape:
				_o.BoundingVolume.Value = ((this.BoundingVolume<IVolumeTriggerShape>() != null) ? this.BoundingVolume<IVolumeTriggerShape>().Value.UnPack() : null);
				break;
			}
			_o.MaxSpeed = this.MaxSpeed;
			_o.Acceleration = this.Acceleration;
			_o.MaxSpeedCurve = this.MaxSpeedCurve;
			_o.HitEffect = this.HitEffect;
		}

		// Token: 0x060279CA RID: 162250 RVA: 0x00572B20 File Offset: 0x00570D20
		public static Offset<ITrafficNavigationConfig> Pack(FlatBufferBuilder builder, ITrafficNavigationConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrafficNavigationConfig>);
			}
			Offset<IVectorInfo> sizeOffset = (_o.Size == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Size);
			TTriggerShape boundingVolume_type = (_o.BoundingVolume == null) ? TTriggerShape.NONE : _o.BoundingVolume.Type;
			int boundingVolumeOffset = (_o.BoundingVolume == null) ? 0 : TTriggerShapeUnion.Pack(builder, _o.BoundingVolume);
			StringOffset maxSpeedCurveOffset = (_o.MaxSpeedCurve == null) ? default(StringOffset) : builder.CreateString(_o.MaxSpeedCurve);
			StringOffset hitEffectOffset = (_o.HitEffect == null) ? default(StringOffset) : builder.CreateString(_o.HitEffect);
			return ITrafficNavigationConfig.CreateITrafficNavigationConfig(builder, _o.Type, sizeOffset, boundingVolume_type, boundingVolumeOffset, _o.MaxSpeed, _o.Acceleration, maxSpeedCurveOffset, hitEffectOffset);
		}

		// Token: 0x0400F192 RID: 61842
		private Table __p;
	}
}
