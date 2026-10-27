using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003BFE RID: 15358
	public struct ICombinationTriggerShape : IFlatbufferObject
	{
		// Token: 0x17006978 RID: 27000
		// (get) Token: 0x06015239 RID: 86585 RVA: 0x003100A7 File Offset: 0x0030E2A7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601523A RID: 86586 RVA: 0x003100B4 File Offset: 0x0030E2B4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601523B RID: 86587 RVA: 0x003100BC File Offset: 0x0030E2BC
		public static ICombinationTriggerShape GetRootAsICombinationTriggerShape(ByteBuffer _bb)
		{
			return ICombinationTriggerShape.GetRootAsICombinationTriggerShape(_bb, default(ICombinationTriggerShape));
		}

		// Token: 0x0601523C RID: 86588 RVA: 0x003100D8 File Offset: 0x0030E2D8
		public static ICombinationTriggerShape GetRootAsICombinationTriggerShape(ByteBuffer _bb, ICombinationTriggerShape obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601523D RID: 86589 RVA: 0x003100F5 File Offset: 0x0030E2F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601523E RID: 86590 RVA: 0x00310104 File Offset: 0x0030E304
		public ICombinationTriggerShape __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006979 RID: 27001
		// (get) Token: 0x0601523F RID: 86591 RVA: 0x00310114 File Offset: 0x0030E314
		public ETriggerShape Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETriggerShape.Box;
				}
				return (ETriggerShape)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015240 RID: 86592 RVA: 0x00310150 File Offset: 0x0030E350
		public TCombinationTriggerShape CombinationShapesType(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return TCombinationTriggerShape.NONE;
			}
			return (TCombinationTriggerShape)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700697A RID: 27002
		// (get) Token: 0x06015241 RID: 86593 RVA: 0x00310190 File Offset: 0x0030E390
		public int CombinationShapesTypeLength
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

		// Token: 0x06015242 RID: 86594 RVA: 0x003101BB File Offset: 0x0030E3BB
		public Span<TCombinationTriggerShape> GetCombinationShapesTypeBytes()
		{
			return this.__p.__vector_as_span<TCombinationTriggerShape>(6, 1);
		}

		// Token: 0x06015243 RID: 86595 RVA: 0x003101CC File Offset: 0x0030E3CC
		public TCombinationTriggerShape[] GetCombinationShapesTypeArray()
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TCombinationTriggerShape[] array = new TCombinationTriggerShape[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TCombinationTriggerShape)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06015244 RID: 86596 RVA: 0x00310238 File Offset: 0x0030E438
		public TTable? CombinationShapes<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700697B RID: 27003
		// (get) Token: 0x06015245 RID: 86597 RVA: 0x00310280 File Offset: 0x0030E480
		public int CombinationShapesLength
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

		// Token: 0x06015246 RID: 86598 RVA: 0x003102AB File Offset: 0x0030E4AB
		public static Offset<ICombinationTriggerShape> CreateICombinationTriggerShape(FlatBufferBuilder builder, ETriggerShape Type = ETriggerShape.Box, VectorOffset CombinationShapes_typeOffset = default(VectorOffset), VectorOffset CombinationShapesOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ICombinationTriggerShape.AddCombinationShapes(builder, CombinationShapesOffset);
			ICombinationTriggerShape.AddCombinationShapesType(builder, CombinationShapes_typeOffset);
			ICombinationTriggerShape.AddType(builder, Type);
			return ICombinationTriggerShape.EndICombinationTriggerShape(builder);
		}

		// Token: 0x06015247 RID: 86599 RVA: 0x003102CF File Offset: 0x0030E4CF
		public static void StartICombinationTriggerShape(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06015248 RID: 86600 RVA: 0x003102D8 File Offset: 0x0030E4D8
		public static void AddType(FlatBufferBuilder builder, ETriggerShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015249 RID: 86601 RVA: 0x003102E3 File Offset: 0x0030E4E3
		public static void AddCombinationShapesType(FlatBufferBuilder builder, VectorOffset combinationShapesTypeOffset)
		{
			builder.AddOffset(1, combinationShapesTypeOffset.Value, 0);
		}

		// Token: 0x0601524A RID: 86602 RVA: 0x003102F4 File Offset: 0x0030E4F4
		public static VectorOffset CreateCombinationShapesTypeVector(FlatBufferBuilder builder, TCombinationTriggerShape[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601524B RID: 86603 RVA: 0x0031032B File Offset: 0x0030E52B
		public static VectorOffset CreateCombinationShapesTypeVectorBlock(FlatBufferBuilder builder, TCombinationTriggerShape[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TCombinationTriggerShape>(data);
			return builder.EndVector();
		}

		// Token: 0x0601524C RID: 86604 RVA: 0x00310345 File Offset: 0x0030E545
		public static VectorOffset CreateCombinationShapesTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TCombinationTriggerShape> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TCombinationTriggerShape>(data);
			return builder.EndVector();
		}

		// Token: 0x0601524D RID: 86605 RVA: 0x00310363 File Offset: 0x0030E563
		public static VectorOffset CreateCombinationShapesTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TCombinationTriggerShape>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601524E RID: 86606 RVA: 0x0031037C File Offset: 0x0030E57C
		public static void StartCombinationShapesTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601524F RID: 86607 RVA: 0x00310387 File Offset: 0x0030E587
		public static void AddCombinationShapes(FlatBufferBuilder builder, VectorOffset combinationShapesOffset)
		{
			builder.AddOffset(2, combinationShapesOffset.Value, 0);
		}

		// Token: 0x06015250 RID: 86608 RVA: 0x00310398 File Offset: 0x0030E598
		public static VectorOffset CreateCombinationShapesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06015251 RID: 86609 RVA: 0x003103CF File Offset: 0x0030E5CF
		public static VectorOffset CreateCombinationShapesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06015252 RID: 86610 RVA: 0x003103E9 File Offset: 0x0030E5E9
		public static VectorOffset CreateCombinationShapesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06015253 RID: 86611 RVA: 0x00310407 File Offset: 0x0030E607
		public static VectorOffset CreateCombinationShapesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06015254 RID: 86612 RVA: 0x00310420 File Offset: 0x0030E620
		public static void StartCombinationShapesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06015255 RID: 86613 RVA: 0x0031042B File Offset: 0x0030E62B
		public static Offset<ICombinationTriggerShape> EndICombinationTriggerShape(FlatBufferBuilder builder)
		{
			return new Offset<ICombinationTriggerShape>(builder.EndTable());
		}

		// Token: 0x06015256 RID: 86614 RVA: 0x00310438 File Offset: 0x0030E638
		public ICombinationTriggerShapeT UnPack()
		{
			ICombinationTriggerShapeT combinationTriggerShapeT = new ICombinationTriggerShapeT();
			this.UnPackTo(combinationTriggerShapeT);
			return combinationTriggerShapeT;
		}

		// Token: 0x06015257 RID: 86615 RVA: 0x00310454 File Offset: 0x0030E654
		public void UnPackTo(ICombinationTriggerShapeT _o)
		{
			_o.Type = this.Type;
			_o.CombinationShapes = new List<TCombinationTriggerShapeUnion>();
			for (int i = 0; i < this.CombinationShapesLength; i++)
			{
				TCombinationTriggerShapeUnion tcombinationTriggerShapeUnion = new TCombinationTriggerShapeUnion();
				tcombinationTriggerShapeUnion.Type = this.CombinationShapesType(i);
				switch (this.CombinationShapesType(i))
				{
				case TCombinationTriggerShape.IBoxTriggerShape:
					tcombinationTriggerShapeUnion.Value = ((this.CombinationShapes<IBoxTriggerShape>(i) != null) ? this.CombinationShapes<IBoxTriggerShape>(i).Value.UnPack() : null);
					break;
				case TCombinationTriggerShape.ISphereTriggerShape:
					tcombinationTriggerShapeUnion.Value = ((this.CombinationShapes<ISphereTriggerShape>(i) != null) ? this.CombinationShapes<ISphereTriggerShape>(i).Value.UnPack() : null);
					break;
				case TCombinationTriggerShape.IHollowSphereTriggerShape:
					tcombinationTriggerShapeUnion.Value = ((this.CombinationShapes<IHollowSphereTriggerShape>(i) != null) ? this.CombinationShapes<IHollowSphereTriggerShape>(i).Value.UnPack() : null);
					break;
				case TCombinationTriggerShape.ICylinderTriggerShape:
					tcombinationTriggerShapeUnion.Value = ((this.CombinationShapes<ICylinderTriggerShape>(i) != null) ? this.CombinationShapes<ICylinderTriggerShape>(i).Value.UnPack() : null);
					break;
				case TCombinationTriggerShape.IHollowCylinderTriggerShape:
					tcombinationTriggerShapeUnion.Value = ((this.CombinationShapes<IHollowCylinderTriggerShape>(i) != null) ? this.CombinationShapes<IHollowCylinderTriggerShape>(i).Value.UnPack() : null);
					break;
				case TCombinationTriggerShape.IConeTriggerShape:
					tcombinationTriggerShapeUnion.Value = ((this.CombinationShapes<IConeTriggerShape>(i) != null) ? this.CombinationShapes<IConeTriggerShape>(i).Value.UnPack() : null);
					break;
				case TCombinationTriggerShape.IVolumeTriggerShape:
					tcombinationTriggerShapeUnion.Value = ((this.CombinationShapes<IVolumeTriggerShape>(i) != null) ? this.CombinationShapes<IVolumeTriggerShape>(i).Value.UnPack() : null);
					break;
				case TCombinationTriggerShape.IActorRefVolume:
					tcombinationTriggerShapeUnion.Value = ((this.CombinationShapes<IActorRefVolume>(i) != null) ? this.CombinationShapes<IActorRefVolume>(i).Value.UnPack() : null);
					break;
				case TCombinationTriggerShape.IActorCollisionTriggerShape:
					tcombinationTriggerShapeUnion.Value = ((this.CombinationShapes<IActorCollisionTriggerShape>(i) != null) ? this.CombinationShapes<IActorCollisionTriggerShape>(i).Value.UnPack() : null);
					break;
				case TCombinationTriggerShape.ICombinationTriggerShape:
					tcombinationTriggerShapeUnion.Value = ((this.CombinationShapes<ICombinationTriggerShape>(i) != null) ? this.CombinationShapes<ICombinationTriggerShape>(i).Value.UnPack() : null);
					break;
				case TCombinationTriggerShape.ISpotlightTriggerShape:
					tcombinationTriggerShapeUnion.Value = ((this.CombinationShapes<ISpotlightTriggerShape>(i) != null) ? this.CombinationShapes<ISpotlightTriggerShape>(i).Value.UnPack() : null);
					break;
				}
				_o.CombinationShapes.Add(tcombinationTriggerShapeUnion);
			}
		}

		// Token: 0x06015258 RID: 86616 RVA: 0x00310758 File Offset: 0x0030E958
		public static Offset<ICombinationTriggerShape> Pack(FlatBufferBuilder builder, ICombinationTriggerShapeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICombinationTriggerShape>);
			}
			VectorOffset combinationShapes_typeOffset = default(VectorOffset);
			if (_o.CombinationShapes != null)
			{
				TCombinationTriggerShape[] array = new TCombinationTriggerShape[_o.CombinationShapes.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.CombinationShapes[i].Type;
				}
				combinationShapes_typeOffset = ICombinationTriggerShape.CreateCombinationShapesTypeVector(builder, array);
			}
			VectorOffset combinationShapesOffset = default(VectorOffset);
			if (_o.CombinationShapes != null)
			{
				int[] array2 = new int[_o.CombinationShapes.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TCombinationTriggerShapeUnion.Pack(builder, _o.CombinationShapes[j]);
				}
				combinationShapesOffset = ICombinationTriggerShape.CreateCombinationShapesVector(builder, array2);
			}
			return ICombinationTriggerShape.CreateICombinationTriggerShape(builder, _o.Type, combinationShapes_typeOffset, combinationShapesOffset);
		}

		// Token: 0x0400B1D0 RID: 45520
		private Table __p;
	}
}
