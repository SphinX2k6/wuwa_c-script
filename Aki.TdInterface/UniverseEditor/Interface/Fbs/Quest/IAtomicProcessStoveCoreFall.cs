using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D1F RID: 15647
	public struct IAtomicProcessStoveCoreFall : IFlatbufferObject
	{
		// Token: 0x17006B53 RID: 27475
		// (get) Token: 0x06015973 RID: 88435 RVA: 0x0031E1E2 File Offset: 0x0031C3E2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015974 RID: 88436 RVA: 0x0031E1EF File Offset: 0x0031C3EF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015975 RID: 88437 RVA: 0x0031E1F8 File Offset: 0x0031C3F8
		public static IAtomicProcessStoveCoreFall GetRootAsIAtomicProcessStoveCoreFall(ByteBuffer _bb)
		{
			return IAtomicProcessStoveCoreFall.GetRootAsIAtomicProcessStoveCoreFall(_bb, default(IAtomicProcessStoveCoreFall));
		}

		// Token: 0x06015976 RID: 88438 RVA: 0x0031E214 File Offset: 0x0031C414
		public static IAtomicProcessStoveCoreFall GetRootAsIAtomicProcessStoveCoreFall(ByteBuffer _bb, IAtomicProcessStoveCoreFall obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015977 RID: 88439 RVA: 0x0031E231 File Offset: 0x0031C431
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015978 RID: 88440 RVA: 0x0031E240 File Offset: 0x0031C440
		public IAtomicProcessStoveCoreFall __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B54 RID: 27476
		// (get) Token: 0x06015979 RID: 88441 RVA: 0x0031E250 File Offset: 0x0031C450
		public EAtomicProcess Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAtomicProcess.StoveCoreFall;
				}
				return (EAtomicProcess)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601597A RID: 88442 RVA: 0x0031E28C File Offset: 0x0031C48C
		public int SplineEntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17006B55 RID: 27477
		// (get) Token: 0x0601597B RID: 88443 RVA: 0x0031E2CC File Offset: 0x0031C4CC
		public int SplineEntityIdsLength
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

		// Token: 0x0601597C RID: 88444 RVA: 0x0031E2F7 File Offset: 0x0031C4F7
		public Span<int> GetSplineEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0601597D RID: 88445 RVA: 0x0031E306 File Offset: 0x0031C506
		public int[] GetSplineEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0601597E RID: 88446 RVA: 0x0031E314 File Offset: 0x0031C514
		public static Offset<IAtomicProcessStoveCoreFall> CreateIAtomicProcessStoveCoreFall(FlatBufferBuilder builder, EAtomicProcess Type = EAtomicProcess.StoveCoreFall, VectorOffset SplineEntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IAtomicProcessStoveCoreFall.AddSplineEntityIds(builder, SplineEntityIdsOffset);
			IAtomicProcessStoveCoreFall.AddType(builder, Type);
			return IAtomicProcessStoveCoreFall.EndIAtomicProcessStoveCoreFall(builder);
		}

		// Token: 0x0601597F RID: 88447 RVA: 0x0031E331 File Offset: 0x0031C531
		public static void StartIAtomicProcessStoveCoreFall(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06015980 RID: 88448 RVA: 0x0031E33A File Offset: 0x0031C53A
		public static void AddType(FlatBufferBuilder builder, EAtomicProcess type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015981 RID: 88449 RVA: 0x0031E345 File Offset: 0x0031C545
		public static void AddSplineEntityIds(FlatBufferBuilder builder, VectorOffset splineEntityIdsOffset)
		{
			builder.AddOffset(1, splineEntityIdsOffset.Value, 0);
		}

		// Token: 0x06015982 RID: 88450 RVA: 0x0031E358 File Offset: 0x0031C558
		public static VectorOffset CreateSplineEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06015983 RID: 88451 RVA: 0x0031E38F File Offset: 0x0031C58F
		public static VectorOffset CreateSplineEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06015984 RID: 88452 RVA: 0x0031E3A9 File Offset: 0x0031C5A9
		public static VectorOffset CreateSplineEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06015985 RID: 88453 RVA: 0x0031E3C7 File Offset: 0x0031C5C7
		public static VectorOffset CreateSplineEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06015986 RID: 88454 RVA: 0x0031E3E0 File Offset: 0x0031C5E0
		public static void StartSplineEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06015987 RID: 88455 RVA: 0x0031E3EB File Offset: 0x0031C5EB
		public static Offset<IAtomicProcessStoveCoreFall> EndIAtomicProcessStoveCoreFall(FlatBufferBuilder builder)
		{
			return new Offset<IAtomicProcessStoveCoreFall>(builder.EndTable());
		}

		// Token: 0x06015988 RID: 88456 RVA: 0x0031E3F8 File Offset: 0x0031C5F8
		public IAtomicProcessStoveCoreFallT UnPack()
		{
			IAtomicProcessStoveCoreFallT atomicProcessStoveCoreFallT = new IAtomicProcessStoveCoreFallT();
			this.UnPackTo(atomicProcessStoveCoreFallT);
			return atomicProcessStoveCoreFallT;
		}

		// Token: 0x06015989 RID: 88457 RVA: 0x0031E414 File Offset: 0x0031C614
		public void UnPackTo(IAtomicProcessStoveCoreFallT _o)
		{
			_o.Type = this.Type;
			_o.SplineEntityIds = new List<int>();
			for (int i = 0; i < this.SplineEntityIdsLength; i++)
			{
				_o.SplineEntityIds.Add(this.SplineEntityIds(i));
			}
		}

		// Token: 0x0601598A RID: 88458 RVA: 0x0031E45C File Offset: 0x0031C65C
		public static Offset<IAtomicProcessStoveCoreFall> Pack(FlatBufferBuilder builder, IAtomicProcessStoveCoreFallT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAtomicProcessStoveCoreFall>);
			}
			VectorOffset splineEntityIdsOffset = default(VectorOffset);
			if (_o.SplineEntityIds != null)
			{
				int[] data = _o.SplineEntityIds.ToArray();
				splineEntityIdsOffset = IAtomicProcessStoveCoreFall.CreateSplineEntityIdsVector(builder, data);
			}
			return IAtomicProcessStoveCoreFall.CreateIAtomicProcessStoveCoreFall(builder, _o.Type, splineEntityIdsOffset);
		}

		// Token: 0x0400B5D6 RID: 46550
		private Table __p;
	}
}
