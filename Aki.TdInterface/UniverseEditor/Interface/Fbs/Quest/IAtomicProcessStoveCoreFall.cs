using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004136 RID: 16694
	public struct IAtomicProcessStoveCoreFall : IFlatbufferObject
	{
		// Token: 0x1700710D RID: 28941
		// (get) Token: 0x06016EAB RID: 93867 RVA: 0x0034545A File Offset: 0x0034365A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016EAC RID: 93868 RVA: 0x00345467 File Offset: 0x00343667
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016EAD RID: 93869 RVA: 0x00345470 File Offset: 0x00343670
		public static IAtomicProcessStoveCoreFall GetRootAsIAtomicProcessStoveCoreFall(ByteBuffer _bb)
		{
			return IAtomicProcessStoveCoreFall.GetRootAsIAtomicProcessStoveCoreFall(_bb, default(IAtomicProcessStoveCoreFall));
		}

		// Token: 0x06016EAE RID: 93870 RVA: 0x0034548C File Offset: 0x0034368C
		public static IAtomicProcessStoveCoreFall GetRootAsIAtomicProcessStoveCoreFall(ByteBuffer _bb, IAtomicProcessStoveCoreFall obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016EAF RID: 93871 RVA: 0x003454A9 File Offset: 0x003436A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016EB0 RID: 93872 RVA: 0x003454B8 File Offset: 0x003436B8
		public IAtomicProcessStoveCoreFall __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700710E RID: 28942
		// (get) Token: 0x06016EB1 RID: 93873 RVA: 0x003454C8 File Offset: 0x003436C8
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

		// Token: 0x06016EB2 RID: 93874 RVA: 0x00345504 File Offset: 0x00343704
		public int SplineEntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700710F RID: 28943
		// (get) Token: 0x06016EB3 RID: 93875 RVA: 0x00345544 File Offset: 0x00343744
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

		// Token: 0x06016EB4 RID: 93876 RVA: 0x0034556F File Offset: 0x0034376F
		public Span<int> GetSplineEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06016EB5 RID: 93877 RVA: 0x0034557E File Offset: 0x0034377E
		public int[] GetSplineEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06016EB6 RID: 93878 RVA: 0x0034558C File Offset: 0x0034378C
		public static Offset<IAtomicProcessStoveCoreFall> CreateIAtomicProcessStoveCoreFall(FlatBufferBuilder builder, EAtomicProcess Type = EAtomicProcess.StoveCoreFall, VectorOffset SplineEntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IAtomicProcessStoveCoreFall.AddSplineEntityIds(builder, SplineEntityIdsOffset);
			IAtomicProcessStoveCoreFall.AddType(builder, Type);
			return IAtomicProcessStoveCoreFall.EndIAtomicProcessStoveCoreFall(builder);
		}

		// Token: 0x06016EB7 RID: 93879 RVA: 0x003455A9 File Offset: 0x003437A9
		public static void StartIAtomicProcessStoveCoreFall(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06016EB8 RID: 93880 RVA: 0x003455B2 File Offset: 0x003437B2
		public static void AddType(FlatBufferBuilder builder, EAtomicProcess type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016EB9 RID: 93881 RVA: 0x003455BD File Offset: 0x003437BD
		public static void AddSplineEntityIds(FlatBufferBuilder builder, VectorOffset splineEntityIdsOffset)
		{
			builder.AddOffset(1, splineEntityIdsOffset.Value, 0);
		}

		// Token: 0x06016EBA RID: 93882 RVA: 0x003455D0 File Offset: 0x003437D0
		public static VectorOffset CreateSplineEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06016EBB RID: 93883 RVA: 0x00345607 File Offset: 0x00343807
		public static VectorOffset CreateSplineEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06016EBC RID: 93884 RVA: 0x00345621 File Offset: 0x00343821
		public static VectorOffset CreateSplineEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06016EBD RID: 93885 RVA: 0x0034563F File Offset: 0x0034383F
		public static VectorOffset CreateSplineEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016EBE RID: 93886 RVA: 0x00345658 File Offset: 0x00343858
		public static void StartSplineEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016EBF RID: 93887 RVA: 0x00345663 File Offset: 0x00343863
		public static Offset<IAtomicProcessStoveCoreFall> EndIAtomicProcessStoveCoreFall(FlatBufferBuilder builder)
		{
			return new Offset<IAtomicProcessStoveCoreFall>(builder.EndTable());
		}

		// Token: 0x06016EC0 RID: 93888 RVA: 0x00345670 File Offset: 0x00343870
		public IAtomicProcessStoveCoreFallT UnPack()
		{
			IAtomicProcessStoveCoreFallT atomicProcessStoveCoreFallT = new IAtomicProcessStoveCoreFallT();
			this.UnPackTo(atomicProcessStoveCoreFallT);
			return atomicProcessStoveCoreFallT;
		}

		// Token: 0x06016EC1 RID: 93889 RVA: 0x0034568C File Offset: 0x0034388C
		public void UnPackTo(IAtomicProcessStoveCoreFallT _o)
		{
			_o.Type = this.Type;
			_o.SplineEntityIds = new List<int>();
			for (int i = 0; i < this.SplineEntityIdsLength; i++)
			{
				_o.SplineEntityIds.Add(this.SplineEntityIds(i));
			}
		}

		// Token: 0x06016EC2 RID: 93890 RVA: 0x003456D4 File Offset: 0x003438D4
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

		// Token: 0x0400BF83 RID: 49027
		private Table __p;
	}
}
