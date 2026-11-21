using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077A0 RID: 30624
	public struct ISetDataLayerTransitions : IFlatbufferObject
	{
		// Token: 0x1700E060 RID: 57440
		// (get) Token: 0x06035C17 RID: 220183 RVA: 0x00733B30 File Offset: 0x00731D30
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035C18 RID: 220184 RVA: 0x00733B3D File Offset: 0x00731D3D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035C19 RID: 220185 RVA: 0x00733B44 File Offset: 0x00731D44
		public static ISetDataLayerTransitions GetRootAsISetDataLayerTransitions(ByteBuffer _bb)
		{
			return ISetDataLayerTransitions.GetRootAsISetDataLayerTransitions(_bb, default(ISetDataLayerTransitions));
		}

		// Token: 0x06035C1A RID: 220186 RVA: 0x00733B60 File Offset: 0x00731D60
		public static ISetDataLayerTransitions GetRootAsISetDataLayerTransitions(ByteBuffer _bb, ISetDataLayerTransitions obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035C1B RID: 220187 RVA: 0x00733B7D File Offset: 0x00731D7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035C1C RID: 220188 RVA: 0x00733B8C File Offset: 0x00731D8C
		public ISetDataLayerTransitions __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E061 RID: 57441
		// (get) Token: 0x06035C1D RID: 220189 RVA: 0x00733B9C File Offset: 0x00731D9C
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

		// Token: 0x1700E062 RID: 57442
		// (get) Token: 0x06035C1E RID: 220190 RVA: 0x00733BFC File Offset: 0x00731DFC
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

		// Token: 0x06035C1F RID: 220191 RVA: 0x00733C33 File Offset: 0x00731E33
		public Span<byte> GetMaterialDataForEnableBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06035C20 RID: 220192 RVA: 0x00733C42 File Offset: 0x00731E42
		public byte[] GetMaterialDataForEnableArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700E063 RID: 57443
		// (get) Token: 0x06035C21 RID: 220193 RVA: 0x00733C50 File Offset: 0x00731E50
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

		// Token: 0x06035C22 RID: 220194 RVA: 0x00733C87 File Offset: 0x00731E87
		public Span<byte> GetMaterialDataForDisableBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06035C23 RID: 220195 RVA: 0x00733C96 File Offset: 0x00731E96
		public byte[] GetMaterialDataForDisableArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700E064 RID: 57444
		// (get) Token: 0x06035C24 RID: 220196 RVA: 0x00733CA4 File Offset: 0x00731EA4
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

		// Token: 0x06035C25 RID: 220197 RVA: 0x00733CDC File Offset: 0x00731EDC
		public Span<byte> GetVolumeEnterSeqBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06035C26 RID: 220198 RVA: 0x00733CEC File Offset: 0x00731EEC
		public byte[] GetVolumeEnterSeqArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700E065 RID: 57445
		// (get) Token: 0x06035C27 RID: 220199 RVA: 0x00733CFC File Offset: 0x00731EFC
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

		// Token: 0x06035C28 RID: 220200 RVA: 0x00733D34 File Offset: 0x00731F34
		public Span<byte> GetVolumeOutSeqBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06035C29 RID: 220201 RVA: 0x00733D44 File Offset: 0x00731F44
		public byte[] GetVolumeOutSeqArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x06035C2A RID: 220202 RVA: 0x00733D53 File Offset: 0x00731F53
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

		// Token: 0x06035C2B RID: 220203 RVA: 0x00733D87 File Offset: 0x00731F87
		public static void StartISetDataLayerTransitions(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06035C2C RID: 220204 RVA: 0x00733D90 File Offset: 0x00731F90
		public static void AddVolumeActor(FlatBufferBuilder builder, Offset<IActorRef> volumeActorOffset)
		{
			builder.AddOffset(0, volumeActorOffset.Value, 0);
		}

		// Token: 0x06035C2D RID: 220205 RVA: 0x00733DA0 File Offset: 0x00731FA0
		public static void AddMaterialDataForEnable(FlatBufferBuilder builder, StringOffset materialDataForEnableOffset)
		{
			builder.AddOffset(1, materialDataForEnableOffset.Value, 0);
		}

		// Token: 0x06035C2E RID: 220206 RVA: 0x00733DB0 File Offset: 0x00731FB0
		public static void AddMaterialDataForDisable(FlatBufferBuilder builder, StringOffset materialDataForDisableOffset)
		{
			builder.AddOffset(2, materialDataForDisableOffset.Value, 0);
		}

		// Token: 0x06035C2F RID: 220207 RVA: 0x00733DC0 File Offset: 0x00731FC0
		public static void AddVolumeEnterSeq(FlatBufferBuilder builder, StringOffset volumeEnterSeqOffset)
		{
			builder.AddOffset(3, volumeEnterSeqOffset.Value, 0);
		}

		// Token: 0x06035C30 RID: 220208 RVA: 0x00733DD0 File Offset: 0x00731FD0
		public static void AddVolumeOutSeq(FlatBufferBuilder builder, StringOffset volumeOutSeqOffset)
		{
			builder.AddOffset(4, volumeOutSeqOffset.Value, 0);
		}

		// Token: 0x06035C31 RID: 220209 RVA: 0x00733DE0 File Offset: 0x00731FE0
		public static Offset<ISetDataLayerTransitions> EndISetDataLayerTransitions(FlatBufferBuilder builder)
		{
			return new Offset<ISetDataLayerTransitions>(builder.EndTable());
		}

		// Token: 0x06035C32 RID: 220210 RVA: 0x00733DF0 File Offset: 0x00731FF0
		public ISetDataLayerTransitionsT UnPack()
		{
			ISetDataLayerTransitionsT setDataLayerTransitionsT = new ISetDataLayerTransitionsT();
			this.UnPackTo(setDataLayerTransitionsT);
			return setDataLayerTransitionsT;
		}

		// Token: 0x06035C33 RID: 220211 RVA: 0x00733E0C File Offset: 0x0073200C
		public void UnPackTo(ISetDataLayerTransitionsT _o)
		{
			_o.VolumeActor = ((this.VolumeActor != null) ? this.VolumeActor.Value.UnPack() : null);
			_o.MaterialDataForEnable = this.MaterialDataForEnable;
			_o.MaterialDataForDisable = this.MaterialDataForDisable;
			_o.VolumeEnterSeq = this.VolumeEnterSeq;
			_o.VolumeOutSeq = this.VolumeOutSeq;
		}

		// Token: 0x06035C34 RID: 220212 RVA: 0x00733E78 File Offset: 0x00732078
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

		// Token: 0x040129C7 RID: 76231
		private Table __p;
	}
}
