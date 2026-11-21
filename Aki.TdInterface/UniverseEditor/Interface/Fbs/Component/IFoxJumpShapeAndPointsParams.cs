using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200583B RID: 22587
	public struct IFoxJumpShapeAndPointsParams : IFlatbufferObject
	{
		// Token: 0x1700A393 RID: 41875
		// (get) Token: 0x0602492D RID: 149805 RVA: 0x00506751 File Offset: 0x00504951
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602492E RID: 149806 RVA: 0x0050675E File Offset: 0x0050495E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602492F RID: 149807 RVA: 0x00506768 File Offset: 0x00504968
		public static IFoxJumpShapeAndPointsParams GetRootAsIFoxJumpShapeAndPointsParams(ByteBuffer _bb)
		{
			return IFoxJumpShapeAndPointsParams.GetRootAsIFoxJumpShapeAndPointsParams(_bb, default(IFoxJumpShapeAndPointsParams));
		}

		// Token: 0x06024930 RID: 149808 RVA: 0x00506784 File Offset: 0x00504984
		public static IFoxJumpShapeAndPointsParams GetRootAsIFoxJumpShapeAndPointsParams(ByteBuffer _bb, IFoxJumpShapeAndPointsParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024931 RID: 149809 RVA: 0x005067A1 File Offset: 0x005049A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024932 RID: 149810 RVA: 0x005067B0 File Offset: 0x005049B0
		public IFoxJumpShapeAndPointsParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A394 RID: 41876
		// (get) Token: 0x06024933 RID: 149811 RVA: 0x005067C0 File Offset: 0x005049C0
		public IBoxTriggerShape? BoxShape
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IBoxTriggerShape?(default(IBoxTriggerShape).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06024934 RID: 149812 RVA: 0x00506820 File Offset: 0x00504A20
		public IVectorInfo? PointOffsets(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A395 RID: 41877
		// (get) Token: 0x06024935 RID: 149813 RVA: 0x00506880 File Offset: 0x00504A80
		public int PointOffsetsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06024936 RID: 149814 RVA: 0x005068AB File Offset: 0x00504AAB
		public static Offset<IFoxJumpShapeAndPointsParams> CreateIFoxJumpShapeAndPointsParams(FlatBufferBuilder builder, Offset<IBoxTriggerShape> BoxShapeOffset = default(Offset<IBoxTriggerShape>), VectorOffset PointOffsetsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IFoxJumpShapeAndPointsParams.AddPointOffsets(builder, PointOffsetsOffset);
			IFoxJumpShapeAndPointsParams.AddBoxShape(builder, BoxShapeOffset);
			return IFoxJumpShapeAndPointsParams.EndIFoxJumpShapeAndPointsParams(builder);
		}

		// Token: 0x06024937 RID: 149815 RVA: 0x005068C8 File Offset: 0x00504AC8
		public static void StartIFoxJumpShapeAndPointsParams(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06024938 RID: 149816 RVA: 0x005068D1 File Offset: 0x00504AD1
		public static void AddBoxShape(FlatBufferBuilder builder, Offset<IBoxTriggerShape> boxShapeOffset)
		{
			builder.AddOffset(0, boxShapeOffset.Value, 0);
		}

		// Token: 0x06024939 RID: 149817 RVA: 0x005068E1 File Offset: 0x00504AE1
		public static void AddPointOffsets(FlatBufferBuilder builder, VectorOffset pointOffsetsOffset)
		{
			builder.AddOffset(1, pointOffsetsOffset.Value, 0);
		}

		// Token: 0x0602493A RID: 149818 RVA: 0x005068F4 File Offset: 0x00504AF4
		public static VectorOffset CreatePointOffsetsVector(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602493B RID: 149819 RVA: 0x00506934 File Offset: 0x00504B34
		public static VectorOffset CreatePointOffsetsVectorBlock(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602493C RID: 149820 RVA: 0x0050694E File Offset: 0x00504B4E
		public static VectorOffset CreatePointOffsetsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVectorInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602493D RID: 149821 RVA: 0x0050696C File Offset: 0x00504B6C
		public static VectorOffset CreatePointOffsetsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVectorInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602493E RID: 149822 RVA: 0x00506985 File Offset: 0x00504B85
		public static void StartPointOffsetsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602493F RID: 149823 RVA: 0x00506990 File Offset: 0x00504B90
		public static Offset<IFoxJumpShapeAndPointsParams> EndIFoxJumpShapeAndPointsParams(FlatBufferBuilder builder)
		{
			return new Offset<IFoxJumpShapeAndPointsParams>(builder.EndTable());
		}

		// Token: 0x06024940 RID: 149824 RVA: 0x005069A0 File Offset: 0x00504BA0
		public IFoxJumpShapeAndPointsParamsT UnPack()
		{
			IFoxJumpShapeAndPointsParamsT foxJumpShapeAndPointsParamsT = new IFoxJumpShapeAndPointsParamsT();
			this.UnPackTo(foxJumpShapeAndPointsParamsT);
			return foxJumpShapeAndPointsParamsT;
		}

		// Token: 0x06024941 RID: 149825 RVA: 0x005069BC File Offset: 0x00504BBC
		public void UnPackTo(IFoxJumpShapeAndPointsParamsT _o)
		{
			_o.BoxShape = ((this.BoxShape != null) ? this.BoxShape.Value.UnPack() : null);
			_o.PointOffsets = new List<IVectorInfoT>();
			for (int i = 0; i < this.PointOffsetsLength; i++)
			{
				_o.PointOffsets.Add((this.PointOffsets(i) != null) ? this.PointOffsets(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06024942 RID: 149826 RVA: 0x00506A4C File Offset: 0x00504C4C
		public static Offset<IFoxJumpShapeAndPointsParams> Pack(FlatBufferBuilder builder, IFoxJumpShapeAndPointsParamsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFoxJumpShapeAndPointsParams>);
			}
			Offset<IBoxTriggerShape> boxShapeOffset = (_o.BoxShape == null) ? default(Offset<IBoxTriggerShape>) : IBoxTriggerShape.Pack(builder, _o.BoxShape);
			VectorOffset pointOffsetsOffset = default(VectorOffset);
			if (_o.PointOffsets != null)
			{
				Offset<IVectorInfo>[] array = new Offset<IVectorInfo>[_o.PointOffsets.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IVectorInfo.Pack(builder, _o.PointOffsets[i]);
				}
				pointOffsetsOffset = IFoxJumpShapeAndPointsParams.CreatePointOffsetsVector(builder, array);
			}
			return IFoxJumpShapeAndPointsParams.CreateIFoxJumpShapeAndPointsParams(builder, boxShapeOffset, pointOffsetsOffset);
		}

		// Token: 0x0400F071 RID: 61553
		private Table __p;
	}
}
