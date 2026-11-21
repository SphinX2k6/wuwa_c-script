using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060D3 RID: 24787
	public struct ITrafficNavigationConfig : IFlatbufferObject
	{
		// Token: 0x1700B841 RID: 47169
		// (get) Token: 0x06029F26 RID: 171814 RVA: 0x005B95B2 File Offset: 0x005B77B2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029F27 RID: 171815 RVA: 0x005B95BF File Offset: 0x005B77BF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029F28 RID: 171816 RVA: 0x005B95C8 File Offset: 0x005B77C8
		public static ITrafficNavigationConfig GetRootAsITrafficNavigationConfig(ByteBuffer _bb)
		{
			return ITrafficNavigationConfig.GetRootAsITrafficNavigationConfig(_bb, default(ITrafficNavigationConfig));
		}

		// Token: 0x06029F29 RID: 171817 RVA: 0x005B95E4 File Offset: 0x005B77E4
		public static ITrafficNavigationConfig GetRootAsITrafficNavigationConfig(ByteBuffer _bb, ITrafficNavigationConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029F2A RID: 171818 RVA: 0x005B9601 File Offset: 0x005B7801
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029F2B RID: 171819 RVA: 0x005B9610 File Offset: 0x005B7810
		public ITrafficNavigationConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B842 RID: 47170
		// (get) Token: 0x06029F2C RID: 171820 RVA: 0x005B9620 File Offset: 0x005B7820
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

		// Token: 0x1700B843 RID: 47171
		// (get) Token: 0x06029F2D RID: 171821 RVA: 0x005B965C File Offset: 0x005B785C
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

		// Token: 0x1700B844 RID: 47172
		// (get) Token: 0x06029F2E RID: 171822 RVA: 0x005B96BC File Offset: 0x005B78BC
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

		// Token: 0x06029F2F RID: 171823 RVA: 0x005B96F8 File Offset: 0x005B78F8
		public TTable? BoundingVolume<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06029F30 RID: 171824 RVA: 0x005B9740 File Offset: 0x005B7940
		public IActorCollisionTriggerShape BoundingVolumeAsIActorCollisionTriggerShape()
		{
			return this.BoundingVolume<IActorCollisionTriggerShape>().Value;
		}

		// Token: 0x06029F31 RID: 171825 RVA: 0x005B975C File Offset: 0x005B795C
		public IActorRefVolume BoundingVolumeAsIActorRefVolume()
		{
			return this.BoundingVolume<IActorRefVolume>().Value;
		}

		// Token: 0x06029F32 RID: 171826 RVA: 0x005B9778 File Offset: 0x005B7978
		public IBoxTriggerShape BoundingVolumeAsIBoxTriggerShape()
		{
			return this.BoundingVolume<IBoxTriggerShape>().Value;
		}

		// Token: 0x06029F33 RID: 171827 RVA: 0x005B9794 File Offset: 0x005B7994
		public ICombinationTriggerShape BoundingVolumeAsICombinationTriggerShape()
		{
			return this.BoundingVolume<ICombinationTriggerShape>().Value;
		}

		// Token: 0x06029F34 RID: 171828 RVA: 0x005B97B0 File Offset: 0x005B79B0
		public IConeTriggerShape BoundingVolumeAsIConeTriggerShape()
		{
			return this.BoundingVolume<IConeTriggerShape>().Value;
		}

		// Token: 0x06029F35 RID: 171829 RVA: 0x005B97CC File Offset: 0x005B79CC
		public ICylinderTriggerShape BoundingVolumeAsICylinderTriggerShape()
		{
			return this.BoundingVolume<ICylinderTriggerShape>().Value;
		}

		// Token: 0x06029F36 RID: 171830 RVA: 0x005B97E8 File Offset: 0x005B79E8
		public IHollowCylinderTriggerShape BoundingVolumeAsIHollowCylinderTriggerShape()
		{
			return this.BoundingVolume<IHollowCylinderTriggerShape>().Value;
		}

		// Token: 0x06029F37 RID: 171831 RVA: 0x005B9804 File Offset: 0x005B7A04
		public IHollowSphereTriggerShape BoundingVolumeAsIHollowSphereTriggerShape()
		{
			return this.BoundingVolume<IHollowSphereTriggerShape>().Value;
		}

		// Token: 0x06029F38 RID: 171832 RVA: 0x005B9820 File Offset: 0x005B7A20
		public ISphereTriggerShape BoundingVolumeAsISphereTriggerShape()
		{
			return this.BoundingVolume<ISphereTriggerShape>().Value;
		}

		// Token: 0x06029F39 RID: 171833 RVA: 0x005B983C File Offset: 0x005B7A3C
		public ISpotlightTriggerShape BoundingVolumeAsISpotlightTriggerShape()
		{
			return this.BoundingVolume<ISpotlightTriggerShape>().Value;
		}

		// Token: 0x06029F3A RID: 171834 RVA: 0x005B9858 File Offset: 0x005B7A58
		public IVolumeTriggerShape BoundingVolumeAsIVolumeTriggerShape()
		{
			return this.BoundingVolume<IVolumeTriggerShape>().Value;
		}

		// Token: 0x1700B845 RID: 47173
		// (get) Token: 0x06029F3B RID: 171835 RVA: 0x005B9874 File Offset: 0x005B7A74
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

		// Token: 0x1700B846 RID: 47174
		// (get) Token: 0x06029F3C RID: 171836 RVA: 0x005B98B8 File Offset: 0x005B7AB8
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

		// Token: 0x1700B847 RID: 47175
		// (get) Token: 0x06029F3D RID: 171837 RVA: 0x005B98FC File Offset: 0x005B7AFC
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

		// Token: 0x06029F3E RID: 171838 RVA: 0x005B9934 File Offset: 0x005B7B34
		public Span<byte> GetMaxSpeedCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06029F3F RID: 171839 RVA: 0x005B9944 File Offset: 0x005B7B44
		public byte[] GetMaxSpeedCurveArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x1700B848 RID: 47176
		// (get) Token: 0x06029F40 RID: 171840 RVA: 0x005B9954 File Offset: 0x005B7B54
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

		// Token: 0x06029F41 RID: 171841 RVA: 0x005B998C File Offset: 0x005B7B8C
		public Span<byte> GetHitEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06029F42 RID: 171842 RVA: 0x005B999C File Offset: 0x005B7B9C
		public byte[] GetHitEffectArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x06029F43 RID: 171843 RVA: 0x005B99AC File Offset: 0x005B7BAC
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

		// Token: 0x06029F44 RID: 171844 RVA: 0x005B9A03 File Offset: 0x005B7C03
		public static void StartITrafficNavigationConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06029F45 RID: 171845 RVA: 0x005B9A0C File Offset: 0x005B7C0C
		public static void AddType(FlatBufferBuilder builder, ERoadNetworkNavigationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029F46 RID: 171846 RVA: 0x005B9A17 File Offset: 0x005B7C17
		public static void AddSize(FlatBufferBuilder builder, Offset<IVectorInfo> sizeOffset)
		{
			builder.AddOffset(1, sizeOffset.Value, 0);
		}

		// Token: 0x06029F47 RID: 171847 RVA: 0x005B9A27 File Offset: 0x005B7C27
		public static void AddBoundingVolumeType(FlatBufferBuilder builder, TTriggerShape boundingVolumeType)
		{
			builder.AddByte(2, (byte)boundingVolumeType, 0);
		}

		// Token: 0x06029F48 RID: 171848 RVA: 0x005B9A32 File Offset: 0x005B7C32
		public static void AddBoundingVolume(FlatBufferBuilder builder, int boundingVolumeOffset)
		{
			builder.AddOffset(3, boundingVolumeOffset, 0);
		}

		// Token: 0x06029F49 RID: 171849 RVA: 0x005B9A3D File Offset: 0x005B7C3D
		public static void AddMaxSpeed(FlatBufferBuilder builder, float maxSpeed)
		{
			builder.AddFloat(4, maxSpeed, 0.0);
		}

		// Token: 0x06029F4A RID: 171850 RVA: 0x005B9A50 File Offset: 0x005B7C50
		public static void AddAcceleration(FlatBufferBuilder builder, float acceleration)
		{
			builder.AddFloat(5, acceleration, 0.0);
		}

		// Token: 0x06029F4B RID: 171851 RVA: 0x005B9A63 File Offset: 0x005B7C63
		public static void AddMaxSpeedCurve(FlatBufferBuilder builder, StringOffset maxSpeedCurveOffset)
		{
			builder.AddOffset(6, maxSpeedCurveOffset.Value, 0);
		}

		// Token: 0x06029F4C RID: 171852 RVA: 0x005B9A73 File Offset: 0x005B7C73
		public static void AddHitEffect(FlatBufferBuilder builder, StringOffset hitEffectOffset)
		{
			builder.AddOffset(7, hitEffectOffset.Value, 0);
		}

		// Token: 0x06029F4D RID: 171853 RVA: 0x005B9A83 File Offset: 0x005B7C83
		public static Offset<ITrafficNavigationConfig> EndITrafficNavigationConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITrafficNavigationConfig>(builder.EndTable());
		}

		// Token: 0x06029F4E RID: 171854 RVA: 0x005B9A90 File Offset: 0x005B7C90
		public ITrafficNavigationConfigT UnPack()
		{
			ITrafficNavigationConfigT trafficNavigationConfigT = new ITrafficNavigationConfigT();
			this.UnPackTo(trafficNavigationConfigT);
			return trafficNavigationConfigT;
		}

		// Token: 0x06029F4F RID: 171855 RVA: 0x005B9AAC File Offset: 0x005B7CAC
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

		// Token: 0x06029F50 RID: 171856 RVA: 0x005B9E08 File Offset: 0x005B8008
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

		// Token: 0x0400FE8B RID: 65163
		private Table __p;
	}
}
