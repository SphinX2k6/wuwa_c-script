using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200575D RID: 22365
	public struct IPointGroupByLayer : IFlatbufferObject
	{
		// Token: 0x1700A6D4 RID: 42708
		// (get) Token: 0x060257A5 RID: 153509 RVA: 0x0052BB47 File Offset: 0x00529D47
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060257A6 RID: 153510 RVA: 0x0052BB54 File Offset: 0x00529D54
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060257A7 RID: 153511 RVA: 0x0052BB5C File Offset: 0x00529D5C
		public static IPointGroupByLayer GetRootAsIPointGroupByLayer(ByteBuffer _bb)
		{
			return IPointGroupByLayer.GetRootAsIPointGroupByLayer(_bb, default(IPointGroupByLayer));
		}

		// Token: 0x060257A8 RID: 153512 RVA: 0x0052BB78 File Offset: 0x00529D78
		public static IPointGroupByLayer GetRootAsIPointGroupByLayer(ByteBuffer _bb, IPointGroupByLayer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060257A9 RID: 153513 RVA: 0x0052BB95 File Offset: 0x00529D95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060257AA RID: 153514 RVA: 0x0052BBA4 File Offset: 0x00529DA4
		public IPointGroupByLayer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A6D5 RID: 42709
		// (get) Token: 0x060257AB RID: 153515 RVA: 0x0052BBB4 File Offset: 0x00529DB4
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

		// Token: 0x1700A6D6 RID: 42710
		// (get) Token: 0x060257AC RID: 153516 RVA: 0x0052BBF0 File Offset: 0x00529DF0
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

		// Token: 0x060257AD RID: 153517 RVA: 0x0052BC50 File Offset: 0x00529E50
		public IParkourPointLayerConfig? Layers(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IParkourPointLayerConfig?(default(IParkourPointLayerConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A6D7 RID: 42711
		// (get) Token: 0x060257AE RID: 153518 RVA: 0x0052BCB0 File Offset: 0x00529EB0
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

		// Token: 0x060257AF RID: 153519 RVA: 0x0052BCDB File Offset: 0x00529EDB
		public static Offset<IPointGroupByLayer> CreateIPointGroupByLayer(FlatBufferBuilder builder, EPointGroupGenerateType Type = EPointGroupGenerateType.Layer, Offset<IVectorInfo> SpaceOffset = default(Offset<IVectorInfo>), VectorOffset LayersOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IPointGroupByLayer.AddLayers(builder, LayersOffset);
			IPointGroupByLayer.AddSpace(builder, SpaceOffset);
			IPointGroupByLayer.AddType(builder, Type);
			return IPointGroupByLayer.EndIPointGroupByLayer(builder);
		}

		// Token: 0x060257B0 RID: 153520 RVA: 0x0052BCFF File Offset: 0x00529EFF
		public static void StartIPointGroupByLayer(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060257B1 RID: 153521 RVA: 0x0052BD08 File Offset: 0x00529F08
		public static void AddType(FlatBufferBuilder builder, EPointGroupGenerateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060257B2 RID: 153522 RVA: 0x0052BD13 File Offset: 0x00529F13
		public static void AddSpace(FlatBufferBuilder builder, Offset<IVectorInfo> spaceOffset)
		{
			builder.AddOffset(1, spaceOffset.Value, 0);
		}

		// Token: 0x060257B3 RID: 153523 RVA: 0x0052BD23 File Offset: 0x00529F23
		public static void AddLayers(FlatBufferBuilder builder, VectorOffset layersOffset)
		{
			builder.AddOffset(2, layersOffset.Value, 0);
		}

		// Token: 0x060257B4 RID: 153524 RVA: 0x0052BD34 File Offset: 0x00529F34
		public static VectorOffset CreateLayersVector(FlatBufferBuilder builder, Offset<IParkourPointLayerConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060257B5 RID: 153525 RVA: 0x0052BD74 File Offset: 0x00529F74
		public static VectorOffset CreateLayersVectorBlock(FlatBufferBuilder builder, Offset<IParkourPointLayerConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IParkourPointLayerConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060257B6 RID: 153526 RVA: 0x0052BD8E File Offset: 0x00529F8E
		public static VectorOffset CreateLayersVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IParkourPointLayerConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IParkourPointLayerConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060257B7 RID: 153527 RVA: 0x0052BDAC File Offset: 0x00529FAC
		public static VectorOffset CreateLayersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IParkourPointLayerConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060257B8 RID: 153528 RVA: 0x0052BDC5 File Offset: 0x00529FC5
		public static void StartLayersVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060257B9 RID: 153529 RVA: 0x0052BDD0 File Offset: 0x00529FD0
		public static Offset<IPointGroupByLayer> EndIPointGroupByLayer(FlatBufferBuilder builder)
		{
			return new Offset<IPointGroupByLayer>(builder.EndTable());
		}

		// Token: 0x060257BA RID: 153530 RVA: 0x0052BDE0 File Offset: 0x00529FE0
		public IPointGroupByLayerT UnPack()
		{
			IPointGroupByLayerT pointGroupByLayerT = new IPointGroupByLayerT();
			this.UnPackTo(pointGroupByLayerT);
			return pointGroupByLayerT;
		}

		// Token: 0x060257BB RID: 153531 RVA: 0x0052BDFC File Offset: 0x00529FFC
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

		// Token: 0x060257BC RID: 153532 RVA: 0x0052BE98 File Offset: 0x0052A098
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

		// Token: 0x0400EBFD RID: 60413
		private Table __p;
	}
}
