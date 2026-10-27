using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059CE RID: 22990
	public struct IStreamingRenderConfig : IFlatbufferObject
	{
		// Token: 0x1700ACB3 RID: 44211
		// (get) Token: 0x06026FD8 RID: 159704 RVA: 0x0055D773 File Offset: 0x0055B973
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026FD9 RID: 159705 RVA: 0x0055D780 File Offset: 0x0055B980
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026FDA RID: 159706 RVA: 0x0055D788 File Offset: 0x0055B988
		public static IStreamingRenderConfig GetRootAsIStreamingRenderConfig(ByteBuffer _bb)
		{
			return IStreamingRenderConfig.GetRootAsIStreamingRenderConfig(_bb, default(IStreamingRenderConfig));
		}

		// Token: 0x06026FDB RID: 159707 RVA: 0x0055D7A4 File Offset: 0x0055B9A4
		public static IStreamingRenderConfig GetRootAsIStreamingRenderConfig(ByteBuffer _bb, IStreamingRenderConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026FDC RID: 159708 RVA: 0x0055D7C1 File Offset: 0x0055B9C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026FDD RID: 159709 RVA: 0x0055D7D0 File Offset: 0x0055B9D0
		public IStreamingRenderConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ACB4 RID: 44212
		// (get) Token: 0x06026FDE RID: 159710 RVA: 0x0055D7E0 File Offset: 0x0055B9E0
		public TPortalViewDistanceConfig ViewDistanceType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TPortalViewDistanceConfig.NONE;
				}
				return (TPortalViewDistanceConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026FDF RID: 159711 RVA: 0x0055D81C File Offset: 0x0055BA1C
		public TTable? ViewDistance<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06026FE0 RID: 159712 RVA: 0x0055D860 File Offset: 0x0055BA60
		public ICustomViewDistance ViewDistanceAsICustomViewDistance()
		{
			return this.ViewDistance<ICustomViewDistance>().Value;
		}

		// Token: 0x06026FE1 RID: 159713 RVA: 0x0055D87C File Offset: 0x0055BA7C
		public IHighViewDistance ViewDistanceAsIHighViewDistance()
		{
			return this.ViewDistance<IHighViewDistance>().Value;
		}

		// Token: 0x06026FE2 RID: 159714 RVA: 0x0055D898 File Offset: 0x0055BA98
		public ILowViewDistance ViewDistanceAsILowViewDistance()
		{
			return this.ViewDistance<ILowViewDistance>().Value;
		}

		// Token: 0x06026FE3 RID: 159715 RVA: 0x0055D8B4 File Offset: 0x0055BAB4
		public IMidViewDistance ViewDistanceAsIMidViewDistance()
		{
			return this.ViewDistance<IMidViewDistance>().Value;
		}

		// Token: 0x06026FE4 RID: 159716 RVA: 0x0055D8D0 File Offset: 0x0055BAD0
		public IActorRef? ForceRenderActors(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700ACB5 RID: 44213
		// (get) Token: 0x06026FE5 RID: 159717 RVA: 0x0055D930 File Offset: 0x0055BB30
		public int ForceRenderActorsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06026FE6 RID: 159718 RVA: 0x0055D95C File Offset: 0x0055BB5C
		public IRenderFlag? SetRenderFlags(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IRenderFlag?(default(IRenderFlag).__assign(this.__p.__vector(num) + j * 2, this.__p.bb));
		}

		// Token: 0x1700ACB6 RID: 44214
		// (get) Token: 0x06026FE7 RID: 159719 RVA: 0x0055D9B4 File Offset: 0x0055BBB4
		public int SetRenderFlagsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700ACB7 RID: 44215
		// (get) Token: 0x06026FE8 RID: 159720 RVA: 0x0055D9E0 File Offset: 0x0055BBE0
		public IStreamingRtEffectRef? RtEffectRef
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IStreamingRtEffectRef?(default(IStreamingRtEffectRef).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700ACB8 RID: 44216
		// (get) Token: 0x06026FE9 RID: 159721 RVA: 0x0055DA40 File Offset: 0x0055BC40
		public IRtSize? RtData
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IRtSize?(default(IRtSize).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700ACB9 RID: 44217
		// (get) Token: 0x06026FEA RID: 159722 RVA: 0x0055DAA0 File Offset: 0x0055BCA0
		public string FallbackCubeMapTexturePath
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

		// Token: 0x06026FEB RID: 159723 RVA: 0x0055DAD8 File Offset: 0x0055BCD8
		public Span<byte> GetFallbackCubeMapTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06026FEC RID: 159724 RVA: 0x0055DAE8 File Offset: 0x0055BCE8
		public byte[] GetFallbackCubeMapTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x1700ACBA RID: 44218
		// (get) Token: 0x06026FED RID: 159725 RVA: 0x0055DAF8 File Offset: 0x0055BCF8
		public string FallbackCubeMapKey
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

		// Token: 0x06026FEE RID: 159726 RVA: 0x0055DB30 File Offset: 0x0055BD30
		public Span<byte> GetFallbackCubeMapKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06026FEF RID: 159727 RVA: 0x0055DB40 File Offset: 0x0055BD40
		public byte[] GetFallbackCubeMapKeyArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x1700ACBB RID: 44219
		// (get) Token: 0x06026FF0 RID: 159728 RVA: 0x0055DB50 File Offset: 0x0055BD50
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026FF1 RID: 159729 RVA: 0x0055DB90 File Offset: 0x0055BD90
		public static Offset<IStreamingRenderConfig> CreateIStreamingRenderConfig(FlatBufferBuilder builder, TPortalViewDistanceConfig ViewDistance_type = TPortalViewDistanceConfig.NONE, int ViewDistanceOffset = 0, VectorOffset ForceRenderActorsOffset = default(VectorOffset), VectorOffset SetRenderFlagsOffset = default(VectorOffset), Offset<IStreamingRtEffectRef> RtEffectRefOffset = default(Offset<IStreamingRtEffectRef>), Offset<IRtSize> RtDataOffset = default(Offset<IRtSize>), StringOffset FallbackCubeMapTexturePathOffset = default(StringOffset), StringOffset FallbackCubeMapKeyOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(9);
			IStreamingRenderConfig.AddFallbackCubeMapKey(builder, FallbackCubeMapKeyOffset);
			IStreamingRenderConfig.AddFallbackCubeMapTexturePath(builder, FallbackCubeMapTexturePathOffset);
			IStreamingRenderConfig.AddRtData(builder, RtDataOffset);
			IStreamingRenderConfig.AddRtEffectRef(builder, RtEffectRefOffset);
			IStreamingRenderConfig.AddSetRenderFlags(builder, SetRenderFlagsOffset);
			IStreamingRenderConfig.AddForceRenderActors(builder, ForceRenderActorsOffset);
			IStreamingRenderConfig.AddViewDistance(builder, ViewDistanceOffset);
			IStreamingRenderConfig.AddNullMask(builder, NullMask);
			IStreamingRenderConfig.AddViewDistanceType(builder, ViewDistance_type);
			return IStreamingRenderConfig.EndIStreamingRenderConfig(builder);
		}

		// Token: 0x06026FF2 RID: 159730 RVA: 0x0055DBF0 File Offset: 0x0055BDF0
		public static void StartIStreamingRenderConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06026FF3 RID: 159731 RVA: 0x0055DBFA File Offset: 0x0055BDFA
		public static void AddViewDistanceType(FlatBufferBuilder builder, TPortalViewDistanceConfig viewDistanceType)
		{
			builder.AddByte(0, (byte)viewDistanceType, 0);
		}

		// Token: 0x06026FF4 RID: 159732 RVA: 0x0055DC05 File Offset: 0x0055BE05
		public static void AddViewDistance(FlatBufferBuilder builder, int viewDistanceOffset)
		{
			builder.AddOffset(1, viewDistanceOffset, 0);
		}

		// Token: 0x06026FF5 RID: 159733 RVA: 0x0055DC10 File Offset: 0x0055BE10
		public static void AddForceRenderActors(FlatBufferBuilder builder, VectorOffset forceRenderActorsOffset)
		{
			builder.AddOffset(2, forceRenderActorsOffset.Value, 0);
		}

		// Token: 0x06026FF6 RID: 159734 RVA: 0x0055DC20 File Offset: 0x0055BE20
		public static VectorOffset CreateForceRenderActorsVector(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026FF7 RID: 159735 RVA: 0x0055DC60 File Offset: 0x0055BE60
		public static VectorOffset CreateForceRenderActorsVectorBlock(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026FF8 RID: 159736 RVA: 0x0055DC7A File Offset: 0x0055BE7A
		public static VectorOffset CreateForceRenderActorsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorRef>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026FF9 RID: 159737 RVA: 0x0055DC98 File Offset: 0x0055BE98
		public static VectorOffset CreateForceRenderActorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorRef>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026FFA RID: 159738 RVA: 0x0055DCB1 File Offset: 0x0055BEB1
		public static void StartForceRenderActorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026FFB RID: 159739 RVA: 0x0055DCBC File Offset: 0x0055BEBC
		public static void AddSetRenderFlags(FlatBufferBuilder builder, VectorOffset setRenderFlagsOffset)
		{
			builder.AddOffset(3, setRenderFlagsOffset.Value, 0);
		}

		// Token: 0x06026FFC RID: 159740 RVA: 0x0055DCCC File Offset: 0x0055BECC
		public static void StartSetRenderFlagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(2, numElems, 1);
		}

		// Token: 0x06026FFD RID: 159741 RVA: 0x0055DCD7 File Offset: 0x0055BED7
		public static void AddRtEffectRef(FlatBufferBuilder builder, Offset<IStreamingRtEffectRef> rtEffectRefOffset)
		{
			builder.AddOffset(4, rtEffectRefOffset.Value, 0);
		}

		// Token: 0x06026FFE RID: 159742 RVA: 0x0055DCE7 File Offset: 0x0055BEE7
		public static void AddRtData(FlatBufferBuilder builder, Offset<IRtSize> rtDataOffset)
		{
			builder.AddOffset(5, rtDataOffset.Value, 0);
		}

		// Token: 0x06026FFF RID: 159743 RVA: 0x0055DCF7 File Offset: 0x0055BEF7
		public static void AddFallbackCubeMapTexturePath(FlatBufferBuilder builder, StringOffset fallbackCubeMapTexturePathOffset)
		{
			builder.AddOffset(6, fallbackCubeMapTexturePathOffset.Value, 0);
		}

		// Token: 0x06027000 RID: 159744 RVA: 0x0055DD07 File Offset: 0x0055BF07
		public static void AddFallbackCubeMapKey(FlatBufferBuilder builder, StringOffset fallbackCubeMapKeyOffset)
		{
			builder.AddOffset(7, fallbackCubeMapKeyOffset.Value, 0);
		}

		// Token: 0x06027001 RID: 159745 RVA: 0x0055DD17 File Offset: 0x0055BF17
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06027002 RID: 159746 RVA: 0x0055DD22 File Offset: 0x0055BF22
		public static Offset<IStreamingRenderConfig> EndIStreamingRenderConfig(FlatBufferBuilder builder)
		{
			return new Offset<IStreamingRenderConfig>(builder.EndTable());
		}

		// Token: 0x06027003 RID: 159747 RVA: 0x0055DD30 File Offset: 0x0055BF30
		public IStreamingRenderConfigT UnPack()
		{
			IStreamingRenderConfigT streamingRenderConfigT = new IStreamingRenderConfigT();
			this.UnPackTo(streamingRenderConfigT);
			return streamingRenderConfigT;
		}

		// Token: 0x06027004 RID: 159748 RVA: 0x0055DD4C File Offset: 0x0055BF4C
		public void UnPackTo(IStreamingRenderConfigT _o)
		{
			_o.ViewDistance = new TPortalViewDistanceConfigUnion();
			_o.ViewDistance.Type = this.ViewDistanceType;
			switch (this.ViewDistanceType)
			{
			case TPortalViewDistanceConfig.ICustomViewDistance:
				_o.ViewDistance.Value = ((this.ViewDistance<ICustomViewDistance>() != null) ? this.ViewDistance<ICustomViewDistance>().Value.UnPack() : null);
				break;
			case TPortalViewDistanceConfig.IHighViewDistance:
				_o.ViewDistance.Value = ((this.ViewDistance<IHighViewDistance>() != null) ? this.ViewDistance<IHighViewDistance>().Value.UnPack() : null);
				break;
			case TPortalViewDistanceConfig.ILowViewDistance:
				_o.ViewDistance.Value = ((this.ViewDistance<ILowViewDistance>() != null) ? this.ViewDistance<ILowViewDistance>().Value.UnPack() : null);
				break;
			case TPortalViewDistanceConfig.IMidViewDistance:
				_o.ViewDistance.Value = ((this.ViewDistance<IMidViewDistance>() != null) ? this.ViewDistance<IMidViewDistance>().Value.UnPack() : null);
				break;
			}
			_o.ForceRenderActors = new List<IActorRefT>();
			for (int i = 0; i < this.ForceRenderActorsLength; i++)
			{
				_o.ForceRenderActors.Add((this.ForceRenderActors(i) != null) ? this.ForceRenderActors(i).Value.UnPack() : null);
			}
			_o.SetRenderFlags = new List<IRenderFlagT>();
			for (int j = 0; j < this.SetRenderFlagsLength; j++)
			{
				_o.SetRenderFlags.Add((this.SetRenderFlags(j) != null) ? this.SetRenderFlags(j).Value.UnPack() : null);
			}
			_o.RtEffectRef = ((this.RtEffectRef != null) ? this.RtEffectRef.Value.UnPack() : null);
			_o.RtData = ((this.RtData != null) ? this.RtData.Value.UnPack() : null);
			_o.FallbackCubeMapTexturePath = this.FallbackCubeMapTexturePath;
			_o.FallbackCubeMapKey = this.FallbackCubeMapKey;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027005 RID: 159749 RVA: 0x0055DFB8 File Offset: 0x0055C1B8
		public static Offset<IStreamingRenderConfig> Pack(FlatBufferBuilder builder, IStreamingRenderConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStreamingRenderConfig>);
			}
			TPortalViewDistanceConfig viewDistance_type = (_o.ViewDistance == null) ? TPortalViewDistanceConfig.NONE : _o.ViewDistance.Type;
			int viewDistanceOffset = (_o.ViewDistance == null) ? 0 : TPortalViewDistanceConfigUnion.Pack(builder, _o.ViewDistance);
			VectorOffset forceRenderActorsOffset = default(VectorOffset);
			if (_o.ForceRenderActors != null)
			{
				Offset<IActorRef>[] array = new Offset<IActorRef>[_o.ForceRenderActors.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActorRef.Pack(builder, _o.ForceRenderActors[i]);
				}
				forceRenderActorsOffset = IStreamingRenderConfig.CreateForceRenderActorsVector(builder, array);
			}
			VectorOffset setRenderFlagsOffset = default(VectorOffset);
			if (_o.SetRenderFlags != null)
			{
				IStreamingRenderConfig.StartSetRenderFlagsVector(builder, _o.SetRenderFlags.Count);
				for (int j = _o.SetRenderFlags.Count - 1; j >= 0; j--)
				{
					IRenderFlag.Pack(builder, _o.SetRenderFlags[j]);
				}
				setRenderFlagsOffset = builder.EndVector();
			}
			Offset<IStreamingRtEffectRef> rtEffectRefOffset = (_o.RtEffectRef == null) ? default(Offset<IStreamingRtEffectRef>) : IStreamingRtEffectRef.Pack(builder, _o.RtEffectRef);
			Offset<IRtSize> rtDataOffset = (_o.RtData == null) ? default(Offset<IRtSize>) : IRtSize.Pack(builder, _o.RtData);
			StringOffset fallbackCubeMapTexturePathOffset = (_o.FallbackCubeMapTexturePath == null) ? default(StringOffset) : builder.CreateString(_o.FallbackCubeMapTexturePath);
			StringOffset fallbackCubeMapKeyOffset = (_o.FallbackCubeMapKey == null) ? default(StringOffset) : builder.CreateString(_o.FallbackCubeMapKey);
			return IStreamingRenderConfig.CreateIStreamingRenderConfig(builder, viewDistance_type, viewDistanceOffset, forceRenderActorsOffset, setRenderFlagsOffset, rtEffectRefOffset, rtDataOffset, fallbackCubeMapTexturePathOffset, fallbackCubeMapKeyOffset, _o.NullMask);
		}

		// Token: 0x0400EFFC RID: 61436
		private Table __p;
	}
}
