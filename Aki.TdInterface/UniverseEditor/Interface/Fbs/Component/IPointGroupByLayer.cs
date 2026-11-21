using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D64 RID: 23908
	public struct IPointGroupByLayer : IFlatbufferObject
	{
		// Token: 0x1700AFF8 RID: 45048
		// (get) Token: 0x06027CC5 RID: 163013 RVA: 0x00571CD3 File Offset: 0x0056FED3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027CC6 RID: 163014 RVA: 0x00571CE0 File Offset: 0x0056FEE0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027CC7 RID: 163015 RVA: 0x00571CE8 File Offset: 0x0056FEE8
		public static IPointGroupByLayer GetRootAsIPointGroupByLayer(ByteBuffer _bb)
		{
			return IPointGroupByLayer.GetRootAsIPointGroupByLayer(_bb, default(IPointGroupByLayer));
		}

		// Token: 0x06027CC8 RID: 163016 RVA: 0x00571D04 File Offset: 0x0056FF04
		public static IPointGroupByLayer GetRootAsIPointGroupByLayer(ByteBuffer _bb, IPointGroupByLayer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027CC9 RID: 163017 RVA: 0x00571D21 File Offset: 0x0056FF21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027CCA RID: 163018 RVA: 0x00571D30 File Offset: 0x0056FF30
		public IPointGroupByLayer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AFF9 RID: 45049
		// (get) Token: 0x06027CCB RID: 163019 RVA: 0x00571D40 File Offset: 0x0056FF40
		public EPointGroupGenerateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPointGroupGenerateType.Layer;
				}
				return (EPointGroupGenerateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AFFA RID: 45050
		// (get) Token: 0x06027CCC RID: 163020 RVA: 0x00571D7C File Offset: 0x0056FF7C
		public IVectorInfo? Space
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

		// Token: 0x06027CCD RID: 163021 RVA: 0x00571DDC File Offset: 0x0056FFDC
		public IParkourPointLayerConfig? Layers(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IParkourPointLayerConfig?(default(IParkourPointLayerConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AFFB RID: 45051
		// (get) Token: 0x06027CCE RID: 163022 RVA: 0x00571E3C File Offset: 0x0057003C
		public int LayersLength
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

		// Token: 0x06027CCF RID: 163023 RVA: 0x00571E67 File Offset: 0x00570067
		public static Offset<IPointGroupByLayer> CreateIPointGroupByLayer(FlatBufferBuilder builder, EPointGroupGenerateType Type = EPointGroupGenerateType.Layer, Offset<IVectorInfo> SpaceOffset = default(Offset<IVectorInfo>), VectorOffset LayersOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IPointGroupByLayer.AddLayers(builder, LayersOffset);
			IPointGroupByLayer.AddSpace(builder, SpaceOffset);
			IPointGroupByLayer.AddType(builder, Type);
			return IPointGroupByLayer.EndIPointGroupByLayer(builder);
		}

		// Token: 0x06027CD0 RID: 163024 RVA: 0x00571E8B File Offset: 0x0057008B
		public static void StartIPointGroupByLayer(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06027CD1 RID: 163025 RVA: 0x00571E94 File Offset: 0x00570094
		public static void AddType(FlatBufferBuilder builder, EPointGroupGenerateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027CD2 RID: 163026 RVA: 0x00571E9F File Offset: 0x0057009F
		public static void AddSpace(FlatBufferBuilder builder, Offset<IVectorInfo> spaceOffset)
		{
			builder.AddOffset(1, spaceOffset.Value, 0);
		}

		// Token: 0x06027CD3 RID: 163027 RVA: 0x00571EAF File Offset: 0x005700AF
		public static void AddLayers(FlatBufferBuilder builder, VectorOffset layersOffset)
		{
			builder.AddOffset(2, layersOffset.Value, 0);
		}

		// Token: 0x06027CD4 RID: 163028 RVA: 0x00571EC0 File Offset: 0x005700C0
		public static VectorOffset CreateLayersVector(FlatBufferBuilder builder, Offset<IParkourPointLayerConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027CD5 RID: 163029 RVA: 0x00571F00 File Offset: 0x00570100
		public static VectorOffset CreateLayersVectorBlock(FlatBufferBuilder builder, Offset<IParkourPointLayerConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IParkourPointLayerConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027CD6 RID: 163030 RVA: 0x00571F1A File Offset: 0x0057011A
		public static VectorOffset CreateLayersVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IParkourPointLayerConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IParkourPointLayerConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027CD7 RID: 163031 RVA: 0x00571F38 File Offset: 0x00570138
		public static VectorOffset CreateLayersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IParkourPointLayerConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027CD8 RID: 163032 RVA: 0x00571F51 File Offset: 0x00570151
		public static void StartLayersVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027CD9 RID: 163033 RVA: 0x00571F5C File Offset: 0x0057015C
		public static Offset<IPointGroupByLayer> EndIPointGroupByLayer(FlatBufferBuilder builder)
		{
			return new Offset<IPointGroupByLayer>(builder.EndTable());
		}

		// Token: 0x06027CDA RID: 163034 RVA: 0x00571F6C File Offset: 0x0057016C
		public IPointGroupByLayerT UnPack()
		{
			IPointGroupByLayerT pointGroupByLayerT = new IPointGroupByLayerT();
			this.UnPackTo(pointGroupByLayerT);
			return pointGroupByLayerT;
		}

		// Token: 0x06027CDB RID: 163035 RVA: 0x00571F88 File Offset: 0x00570188
		public void UnPackTo(IPointGroupByLayerT _o)
		{
			_o.Type = this.Type;
			_o.Space = ((this.Space != null) ? this.Space.Value.UnPack() : null);
			_o.Layers = new List<IParkourPointLayerConfigT>();
			for (int i = 0; i < this.LayersLength; i++)
			{
				_o.Layers.Add((this.Layers(i) != null) ? this.Layers(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06027CDC RID: 163036 RVA: 0x00572024 File Offset: 0x00570224
		public static Offset<IPointGroupByLayer> Pack(FlatBufferBuilder builder, IPointGroupByLayerT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPointGroupByLayer>);
			}
			Offset<IVectorInfo> spaceOffset = (_o.Space == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Space);
			VectorOffset layersOffset = default(VectorOffset);
			if (_o.Layers != null)
			{
				Offset<IParkourPointLayerConfig>[] array = new Offset<IParkourPointLayerConfig>[_o.Layers.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IParkourPointLayerConfig.Pack(builder, _o.Layers[i]);
				}
				layersOffset = IPointGroupByLayer.CreateLayersVector(builder, array);
			}
			return IPointGroupByLayer.CreateIPointGroupByLayer(builder, _o.Type, spaceOffset, layersOffset);
		}

		// Token: 0x0400F8E8 RID: 63720
		private Table __p;
	}
}
