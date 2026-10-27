using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FD7 RID: 28631
	public struct ISetDataLayerTransitions : IFlatbufferObject
	{
		// Token: 0x1700D48C RID: 54412
		// (get) Token: 0x060329B1 RID: 207281 RVA: 0x006D3EEC File Offset: 0x006D20EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060329B2 RID: 207282 RVA: 0x006D3EF9 File Offset: 0x006D20F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060329B3 RID: 207283 RVA: 0x006D3F00 File Offset: 0x006D2100
		public static ISetDataLayerTransitions GetRootAsISetDataLayerTransitions(ByteBuffer _bb)
		{
			return ISetDataLayerTransitions.GetRootAsISetDataLayerTransitions(_bb, default(ISetDataLayerTransitions));
		}

		// Token: 0x060329B4 RID: 207284 RVA: 0x006D3F1C File Offset: 0x006D211C
		public static ISetDataLayerTransitions GetRootAsISetDataLayerTransitions(ByteBuffer _bb, ISetDataLayerTransitions obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060329B5 RID: 207285 RVA: 0x006D3F39 File Offset: 0x006D2139
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060329B6 RID: 207286 RVA: 0x006D3F48 File Offset: 0x006D2148
		public ISetDataLayerTransitions __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D48D RID: 54413
		// (get) Token: 0x060329B7 RID: 207287 RVA: 0x006D3F58 File Offset: 0x006D2158
		public IActorRef? VolumeActor
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D48E RID: 54414
		// (get) Token: 0x060329B8 RID: 207288 RVA: 0x006D3FB8 File Offset: 0x006D21B8
		public string MaterialDataForEnable
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060329B9 RID: 207289 RVA: 0x006D3FEF File Offset: 0x006D21EF
		public Span<byte> GetMaterialDataForEnableBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060329BA RID: 207290 RVA: 0x006D3FFE File Offset: 0x006D21FE
		public byte[] GetMaterialDataForEnableArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700D48F RID: 54415
		// (get) Token: 0x060329BB RID: 207291 RVA: 0x006D400C File Offset: 0x006D220C
		public string MaterialDataForDisable
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060329BC RID: 207292 RVA: 0x006D4043 File Offset: 0x006D2243
		public Span<byte> GetMaterialDataForDisableBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060329BD RID: 207293 RVA: 0x006D4052 File Offset: 0x006D2252
		public byte[] GetMaterialDataForDisableArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700D490 RID: 54416
		// (get) Token: 0x060329BE RID: 207294 RVA: 0x006D4060 File Offset: 0x006D2260
		public string VolumeEnterSeq
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060329BF RID: 207295 RVA: 0x006D4098 File Offset: 0x006D2298
		public Span<byte> GetVolumeEnterSeqBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060329C0 RID: 207296 RVA: 0x006D40A8 File Offset: 0x006D22A8
		public byte[] GetVolumeEnterSeqArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700D491 RID: 54417
		// (get) Token: 0x060329C1 RID: 207297 RVA: 0x006D40B8 File Offset: 0x006D22B8
		public string VolumeOutSeq
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060329C2 RID: 207298 RVA: 0x006D40F0 File Offset: 0x006D22F0
		public Span<byte> GetVolumeOutSeqBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060329C3 RID: 207299 RVA: 0x006D4100 File Offset: 0x006D2300
		public byte[] GetVolumeOutSeqArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x060329C4 RID: 207300 RVA: 0x006D410F File Offset: 0x006D230F
		public static Offset<ISetDataLayerTransitions> CreateISetDataLayerTransitions(FlatBufferBuilder builder, Offset<IActorRef> VolumeActorOffset = default(Offset<IActorRef>), StringOffset MaterialDataForEnableOffset = default(StringOffset), StringOffset MaterialDataForDisableOffset = default(StringOffset), StringOffset VolumeEnterSeqOffset = default(StringOffset), StringOffset VolumeOutSeqOffset = default(StringOffset))
		{
			builder.StartTable(5);
			ISetDataLayerTransitions.AddVolumeOutSeq(builder, VolumeOutSeqOffset);
			ISetDataLayerTransitions.AddVolumeEnterSeq(builder, VolumeEnterSeqOffset);
			ISetDataLayerTransitions.AddMaterialDataForDisable(builder, MaterialDataForDisableOffset);
			ISetDataLayerTransitions.AddMaterialDataForEnable(builder, MaterialDataForEnableOffset);
			ISetDataLayerTransitions.AddVolumeActor(builder, VolumeActorOffset);
			return ISetDataLayerTransitions.EndISetDataLayerTransitions(builder);
		}

		// Token: 0x060329C5 RID: 207301 RVA: 0x006D4143 File Offset: 0x006D2343
		public static void StartISetDataLayerTransitions(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060329C6 RID: 207302 RVA: 0x006D414C File Offset: 0x006D234C
		public static void AddVolumeActor(FlatBufferBuilder builder, Offset<IActorRef> volumeActorOffset)
		{
			builder.AddOffset(0, volumeActorOffset.Value, 0);
		}

		// Token: 0x060329C7 RID: 207303 RVA: 0x006D415C File Offset: 0x006D235C
		public static void AddMaterialDataForEnable(FlatBufferBuilder builder, StringOffset materialDataForEnableOffset)
		{
			builder.AddOffset(1, materialDataForEnableOffset.Value, 0);
		}

		// Token: 0x060329C8 RID: 207304 RVA: 0x006D416C File Offset: 0x006D236C
		public static void AddMaterialDataForDisable(FlatBufferBuilder builder, StringOffset materialDataForDisableOffset)
		{
			builder.AddOffset(2, materialDataForDisableOffset.Value, 0);
		}

		// Token: 0x060329C9 RID: 207305 RVA: 0x006D417C File Offset: 0x006D237C
		public static void AddVolumeEnterSeq(FlatBufferBuilder builder, StringOffset volumeEnterSeqOffset)
		{
			builder.AddOffset(3, volumeEnterSeqOffset.Value, 0);
		}

		// Token: 0x060329CA RID: 207306 RVA: 0x006D418C File Offset: 0x006D238C
		public static void AddVolumeOutSeq(FlatBufferBuilder builder, StringOffset volumeOutSeqOffset)
		{
			builder.AddOffset(4, volumeOutSeqOffset.Value, 0);
		}

		// Token: 0x060329CB RID: 207307 RVA: 0x006D419C File Offset: 0x006D239C
		public static Offset<ISetDataLayerTransitions> EndISetDataLayerTransitions(FlatBufferBuilder builder)
		{
			return new Offset<ISetDataLayerTransitions>(builder.EndTable());
		}

		// Token: 0x060329CC RID: 207308 RVA: 0x006D41AC File Offset: 0x006D23AC
		public ISetDataLayerTransitionsT UnPack()
		{
			ISetDataLayerTransitionsT setDataLayerTransitionsT = new ISetDataLayerTransitionsT();
			this.UnPackTo(setDataLayerTransitionsT);
			return setDataLayerTransitionsT;
		}

		// Token: 0x060329CD RID: 207309 RVA: 0x006D41C8 File Offset: 0x006D23C8
		public void UnPackTo(ISetDataLayerTransitionsT _o)
		{
			_o.VolumeActor = ((this.VolumeActor != null) ? this.VolumeActor.Value.UnPack() : null);
			_o.MaterialDataForEnable = this.MaterialDataForEnable;
			_o.MaterialDataForDisable = this.MaterialDataForDisable;
			_o.VolumeEnterSeq = this.VolumeEnterSeq;
			_o.VolumeOutSeq = this.VolumeOutSeq;
		}

		// Token: 0x060329CE RID: 207310 RVA: 0x006D4234 File Offset: 0x006D2434
		public static Offset<ISetDataLayerTransitions> Pack(FlatBufferBuilder builder, ISetDataLayerTransitionsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetDataLayerTransitions>);
			}
			Offset<IActorRef> volumeActorOffset = (_o.VolumeActor == null) ? default(Offset<IActorRef>) : IActorRef.Pack(builder, _o.VolumeActor);
			StringOffset materialDataForEnableOffset = (_o.MaterialDataForEnable == null) ? default(StringOffset) : builder.CreateString(_o.MaterialDataForEnable);
			StringOffset materialDataForDisableOffset = (_o.MaterialDataForDisable == null) ? default(StringOffset) : builder.CreateString(_o.MaterialDataForDisable);
			StringOffset volumeEnterSeqOffset = (_o.VolumeEnterSeq == null) ? default(StringOffset) : builder.CreateString(_o.VolumeEnterSeq);
			StringOffset volumeOutSeqOffset = (_o.VolumeOutSeq == null) ? default(StringOffset) : builder.CreateString(_o.VolumeOutSeq);
			return ISetDataLayerTransitions.CreateISetDataLayerTransitions(builder, volumeActorOffset, materialDataForEnableOffset, materialDataForDisableOffset, volumeEnterSeqOffset, volumeOutSeqOffset);
		}

		// Token: 0x040119E2 RID: 72162
		private Table __p;
	}
}
