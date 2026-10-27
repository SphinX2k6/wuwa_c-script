using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052D0 RID: 21200
	public struct IFoxJumpShapeAndPointsParams : IFlatbufferObject
	{
		// Token: 0x17009B8A RID: 39818
		// (get) Token: 0x06022969 RID: 141673 RVA: 0x004CB655 File Offset: 0x004C9855
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602296A RID: 141674 RVA: 0x004CB662 File Offset: 0x004C9862
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602296B RID: 141675 RVA: 0x004CB66C File Offset: 0x004C986C
		public static IFoxJumpShapeAndPointsParams GetRootAsIFoxJumpShapeAndPointsParams(ByteBuffer _bb)
		{
			return IFoxJumpShapeAndPointsParams.GetRootAsIFoxJumpShapeAndPointsParams(_bb, default(IFoxJumpShapeAndPointsParams));
		}

		// Token: 0x0602296C RID: 141676 RVA: 0x004CB688 File Offset: 0x004C9888
		public static IFoxJumpShapeAndPointsParams GetRootAsIFoxJumpShapeAndPointsParams(ByteBuffer _bb, IFoxJumpShapeAndPointsParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602296D RID: 141677 RVA: 0x004CB6A5 File Offset: 0x004C98A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602296E RID: 141678 RVA: 0x004CB6B4 File Offset: 0x004C98B4
		public IFoxJumpShapeAndPointsParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009B8B RID: 39819
		// (get) Token: 0x0602296F RID: 141679 RVA: 0x004CB6C4 File Offset: 0x004C98C4
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

		// Token: 0x06022970 RID: 141680 RVA: 0x004CB724 File Offset: 0x004C9924
		public IVectorInfo? PointOffsets(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009B8C RID: 39820
		// (get) Token: 0x06022971 RID: 141681 RVA: 0x004CB784 File Offset: 0x004C9984
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

		// Token: 0x06022972 RID: 141682 RVA: 0x004CB7AF File Offset: 0x004C99AF
		public static Offset<IFoxJumpShapeAndPointsParams> CreateIFoxJumpShapeAndPointsParams(FlatBufferBuilder builder, Offset<IBoxTriggerShape> BoxShapeOffset = default(Offset<IBoxTriggerShape>), VectorOffset PointOffsetsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IFoxJumpShapeAndPointsParams.AddPointOffsets(builder, PointOffsetsOffset);
			IFoxJumpShapeAndPointsParams.AddBoxShape(builder, BoxShapeOffset);
			return IFoxJumpShapeAndPointsParams.EndIFoxJumpShapeAndPointsParams(builder);
		}

		// Token: 0x06022973 RID: 141683 RVA: 0x004CB7CC File Offset: 0x004C99CC
		public static void StartIFoxJumpShapeAndPointsParams(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06022974 RID: 141684 RVA: 0x004CB7D5 File Offset: 0x004C99D5
		public static void AddBoxShape(FlatBufferBuilder builder, Offset<IBoxTriggerShape> boxShapeOffset)
		{
			builder.AddOffset(0, boxShapeOffset.Value, 0);
		}

		// Token: 0x06022975 RID: 141685 RVA: 0x004CB7E5 File Offset: 0x004C99E5
		public static void AddPointOffsets(FlatBufferBuilder builder, VectorOffset pointOffsetsOffset)
		{
			builder.AddOffset(1, pointOffsetsOffset.Value, 0);
		}

		// Token: 0x06022976 RID: 141686 RVA: 0x004CB7F8 File Offset: 0x004C99F8
		public static VectorOffset CreatePointOffsetsVector(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022977 RID: 141687 RVA: 0x004CB838 File Offset: 0x004C9A38
		public static VectorOffset CreatePointOffsetsVectorBlock(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022978 RID: 141688 RVA: 0x004CB852 File Offset: 0x004C9A52
		public static VectorOffset CreatePointOffsetsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVectorInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022979 RID: 141689 RVA: 0x004CB870 File Offset: 0x004C9A70
		public static VectorOffset CreatePointOffsetsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVectorInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602297A RID: 141690 RVA: 0x004CB889 File Offset: 0x004C9A89
		public static void StartPointOffsetsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602297B RID: 141691 RVA: 0x004CB894 File Offset: 0x004C9A94
		public static Offset<IFoxJumpShapeAndPointsParams> EndIFoxJumpShapeAndPointsParams(FlatBufferBuilder builder)
		{
			return new Offset<IFoxJumpShapeAndPointsParams>(builder.EndTable());
		}

		// Token: 0x0602297C RID: 141692 RVA: 0x004CB8A4 File Offset: 0x004C9AA4
		public IFoxJumpShapeAndPointsParamsT UnPack()
		{
			IFoxJumpShapeAndPointsParamsT foxJumpShapeAndPointsParamsT = new IFoxJumpShapeAndPointsParamsT();
			this.UnPackTo(foxJumpShapeAndPointsParamsT);
			return foxJumpShapeAndPointsParamsT;
		}

		// Token: 0x0602297D RID: 141693 RVA: 0x004CB8C0 File Offset: 0x004C9AC0
		public void UnPackTo(IFoxJumpShapeAndPointsParamsT _o)
		{
			_o.BoxShape = ((this.BoxShape != null) ? this.BoxShape.Value.UnPack() : null);
			_o.PointOffsets = new List<IVectorInfoT>();
			for (int i = 0; i < this.PointOffsetsLength; i++)
			{
				_o.PointOffsets.Add((this.PointOffsets(i) != null) ? this.PointOffsets(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602297E RID: 141694 RVA: 0x004CB950 File Offset: 0x004C9B50
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

		// Token: 0x0400E464 RID: 58468
		private Table __p;
	}
}
