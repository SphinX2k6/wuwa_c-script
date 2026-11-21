using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200400A RID: 16394
	public struct ICombinationTriggerShape : IFlatbufferObject
	{
		// Token: 0x17006F20 RID: 28448
		// (get) Token: 0x0601672F RID: 91951 RVA: 0x00336C2F File Offset: 0x00334E2F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016730 RID: 91952 RVA: 0x00336C3C File Offset: 0x00334E3C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016731 RID: 91953 RVA: 0x00336C44 File Offset: 0x00334E44
		public static ICombinationTriggerShape GetRootAsICombinationTriggerShape(ByteBuffer _bb)
		{
			return ICombinationTriggerShape.GetRootAsICombinationTriggerShape(_bb, default(ICombinationTriggerShape));
		}

		// Token: 0x06016732 RID: 91954 RVA: 0x00336C60 File Offset: 0x00334E60
		public static ICombinationTriggerShape GetRootAsICombinationTriggerShape(ByteBuffer _bb, ICombinationTriggerShape obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016733 RID: 91955 RVA: 0x00336C7D File Offset: 0x00334E7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016734 RID: 91956 RVA: 0x00336C8C File Offset: 0x00334E8C
		public ICombinationTriggerShape __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006F21 RID: 28449
		// (get) Token: 0x06016735 RID: 91957 RVA: 0x00336C9C File Offset: 0x00334E9C
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

		// Token: 0x06016736 RID: 91958 RVA: 0x00336CD8 File Offset: 0x00334ED8
		public TCombinationTriggerShape CombinationShapesType(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return TCombinationTriggerShape.NONE;
			}
			return (TCombinationTriggerShape)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17006F22 RID: 28450
		// (get) Token: 0x06016737 RID: 91959 RVA: 0x00336D18 File Offset: 0x00334F18
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

		// Token: 0x06016738 RID: 91960 RVA: 0x00336D43 File Offset: 0x00334F43
		public Span<TCombinationTriggerShape> GetCombinationShapesTypeBytes()
		{
			return this.__p.__vector_as_span<TCombinationTriggerShape>(6, 1);
		}

		// Token: 0x06016739 RID: 91961 RVA: 0x00336D54 File Offset: 0x00334F54
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

		// Token: 0x0601673A RID: 91962 RVA: 0x00336DC0 File Offset: 0x00334FC0
		public TTable? CombinationShapes<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17006F23 RID: 28451
		// (get) Token: 0x0601673B RID: 91963 RVA: 0x00336E08 File Offset: 0x00335008
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

		// Token: 0x0601673C RID: 91964 RVA: 0x00336E33 File Offset: 0x00335033
		public static Offset<ICombinationTriggerShape> CreateICombinationTriggerShape(FlatBufferBuilder builder, ETriggerShape Type = ETriggerShape.Box, VectorOffset CombinationShapes_typeOffset = default(VectorOffset), VectorOffset CombinationShapesOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ICombinationTriggerShape.AddCombinationShapes(builder, CombinationShapesOffset);
			ICombinationTriggerShape.AddCombinationShapesType(builder, CombinationShapes_typeOffset);
			ICombinationTriggerShape.AddType(builder, Type);
			return ICombinationTriggerShape.EndICombinationTriggerShape(builder);
		}

		// Token: 0x0601673D RID: 91965 RVA: 0x00336E57 File Offset: 0x00335057
		public static void StartICombinationTriggerShape(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601673E RID: 91966 RVA: 0x00336E60 File Offset: 0x00335060
		public static void AddType(FlatBufferBuilder builder, ETriggerShape type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601673F RID: 91967 RVA: 0x00336E6B File Offset: 0x0033506B
		public static void AddCombinationShapesType(FlatBufferBuilder builder, VectorOffset combinationShapesTypeOffset)
		{
			builder.AddOffset(1, combinationShapesTypeOffset.Value, 0);
		}

		// Token: 0x06016740 RID: 91968 RVA: 0x00336E7C File Offset: 0x0033507C
		public static VectorOffset CreateCombinationShapesTypeVector(FlatBufferBuilder builder, TCombinationTriggerShape[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06016741 RID: 91969 RVA: 0x00336EB3 File Offset: 0x003350B3
		public static VectorOffset CreateCombinationShapesTypeVectorBlock(FlatBufferBuilder builder, TCombinationTriggerShape[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TCombinationTriggerShape>(data);
			return builder.EndVector();
		}

		// Token: 0x06016742 RID: 91970 RVA: 0x00336ECD File Offset: 0x003350CD
		public static VectorOffset CreateCombinationShapesTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TCombinationTriggerShape> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TCombinationTriggerShape>(data);
			return builder.EndVector();
		}

		// Token: 0x06016743 RID: 91971 RVA: 0x00336EEB File Offset: 0x003350EB
		public static VectorOffset CreateCombinationShapesTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TCombinationTriggerShape>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016744 RID: 91972 RVA: 0x00336F04 File Offset: 0x00335104
		public static void StartCombinationShapesTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06016745 RID: 91973 RVA: 0x00336F0F File Offset: 0x0033510F
		public static void AddCombinationShapes(FlatBufferBuilder builder, VectorOffset combinationShapesOffset)
		{
			builder.AddOffset(2, combinationShapesOffset.Value, 0);
		}

		// Token: 0x06016746 RID: 91974 RVA: 0x00336F20 File Offset: 0x00335120
		public static VectorOffset CreateCombinationShapesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06016747 RID: 91975 RVA: 0x00336F57 File Offset: 0x00335157
		public static VectorOffset CreateCombinationShapesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06016748 RID: 91976 RVA: 0x00336F71 File Offset: 0x00335171
		public static VectorOffset CreateCombinationShapesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06016749 RID: 91977 RVA: 0x00336F8F File Offset: 0x0033518F
		public static VectorOffset CreateCombinationShapesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601674A RID: 91978 RVA: 0x00336FA8 File Offset: 0x003351A8
		public static void StartCombinationShapesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601674B RID: 91979 RVA: 0x00336FB3 File Offset: 0x003351B3
		public static Offset<ICombinationTriggerShape> EndICombinationTriggerShape(FlatBufferBuilder builder)
		{
			return new Offset<ICombinationTriggerShape>(builder.EndTable());
		}

		// Token: 0x0601674C RID: 91980 RVA: 0x00336FC0 File Offset: 0x003351C0
		public ICombinationTriggerShapeT UnPack()
		{
			ICombinationTriggerShapeT combinationTriggerShapeT = new ICombinationTriggerShapeT();
			this.UnPackTo(combinationTriggerShapeT);
			return combinationTriggerShapeT;
		}

		// Token: 0x0601674D RID: 91981 RVA: 0x00336FDC File Offset: 0x003351DC
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

		// Token: 0x0601674E RID: 91982 RVA: 0x003372E0 File Offset: 0x003354E0
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

		// Token: 0x0400BB5B RID: 47963
		private Table __p;
	}
}
