using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F1D RID: 16157
	public struct ILowMemorySceneSwitch : IFlatbufferObject
	{
		// Token: 0x1700705A RID: 28762
		// (get) Token: 0x06016EF8 RID: 93944 RVA: 0x0034F4BE File Offset: 0x0034D6BE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016EF9 RID: 93945 RVA: 0x0034F4CB File Offset: 0x0034D6CB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016EFA RID: 93946 RVA: 0x0034F4D4 File Offset: 0x0034D6D4
		public static ILowMemorySceneSwitch GetRootAsILowMemorySceneSwitch(ByteBuffer _bb)
		{
			return ILowMemorySceneSwitch.GetRootAsILowMemorySceneSwitch(_bb, default(ILowMemorySceneSwitch));
		}

		// Token: 0x06016EFB RID: 93947 RVA: 0x0034F4F0 File Offset: 0x0034D6F0
		public static ILowMemorySceneSwitch GetRootAsILowMemorySceneSwitch(ByteBuffer _bb, ILowMemorySceneSwitch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016EFC RID: 93948 RVA: 0x0034F50D File Offset: 0x0034D70D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016EFD RID: 93949 RVA: 0x0034F51C File Offset: 0x0034D71C
		public ILowMemorySceneSwitch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700705B RID: 28763
		// (get) Token: 0x06016EFE RID: 93950 RVA: 0x0034F52C File Offset: 0x0034D72C
		public ESpecialProcess Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpecialProcess.LowMemorySceneSwitch;
				}
				return (ESpecialProcess)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016EFF RID: 93951 RVA: 0x0034F568 File Offset: 0x0034D768
		public TOperation OperationsType(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return TOperation.NONE;
			}
			return (TOperation)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700705C RID: 28764
		// (get) Token: 0x06016F00 RID: 93952 RVA: 0x0034F5A8 File Offset: 0x0034D7A8
		public int OperationsTypeLength
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

		// Token: 0x06016F01 RID: 93953 RVA: 0x0034F5D3 File Offset: 0x0034D7D3
		public Span<TOperation> GetOperationsTypeBytes()
		{
			return this.__p.__vector_as_span<TOperation>(6, 1);
		}

		// Token: 0x06016F02 RID: 93954 RVA: 0x0034F5E4 File Offset: 0x0034D7E4
		public TOperation[] GetOperationsTypeArray()
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TOperation[] array = new TOperation[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TOperation)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06016F03 RID: 93955 RVA: 0x0034F650 File Offset: 0x0034D850
		public TTable? Operations<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700705D RID: 28765
		// (get) Token: 0x06016F04 RID: 93956 RVA: 0x0034F698 File Offset: 0x0034D898
		public int OperationsLength
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

		// Token: 0x06016F05 RID: 93957 RVA: 0x0034F6C3 File Offset: 0x0034D8C3
		public static Offset<ILowMemorySceneSwitch> CreateILowMemorySceneSwitch(FlatBufferBuilder builder, ESpecialProcess Type = ESpecialProcess.LowMemorySceneSwitch, VectorOffset Operations_typeOffset = default(VectorOffset), VectorOffset OperationsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ILowMemorySceneSwitch.AddOperations(builder, OperationsOffset);
			ILowMemorySceneSwitch.AddOperationsType(builder, Operations_typeOffset);
			ILowMemorySceneSwitch.AddType(builder, Type);
			return ILowMemorySceneSwitch.EndILowMemorySceneSwitch(builder);
		}

		// Token: 0x06016F06 RID: 93958 RVA: 0x0034F6E7 File Offset: 0x0034D8E7
		public static void StartILowMemorySceneSwitch(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06016F07 RID: 93959 RVA: 0x0034F6F0 File Offset: 0x0034D8F0
		public static void AddType(FlatBufferBuilder builder, ESpecialProcess type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016F08 RID: 93960 RVA: 0x0034F6FB File Offset: 0x0034D8FB
		public static void AddOperationsType(FlatBufferBuilder builder, VectorOffset operationsTypeOffset)
		{
			builder.AddOffset(1, operationsTypeOffset.Value, 0);
		}

		// Token: 0x06016F09 RID: 93961 RVA: 0x0034F70C File Offset: 0x0034D90C
		public static VectorOffset CreateOperationsTypeVector(FlatBufferBuilder builder, TOperation[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06016F0A RID: 93962 RVA: 0x0034F743 File Offset: 0x0034D943
		public static VectorOffset CreateOperationsTypeVectorBlock(FlatBufferBuilder builder, TOperation[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TOperation>(data);
			return builder.EndVector();
		}

		// Token: 0x06016F0B RID: 93963 RVA: 0x0034F75D File Offset: 0x0034D95D
		public static VectorOffset CreateOperationsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TOperation> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TOperation>(data);
			return builder.EndVector();
		}

		// Token: 0x06016F0C RID: 93964 RVA: 0x0034F77B File Offset: 0x0034D97B
		public static VectorOffset CreateOperationsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TOperation>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016F0D RID: 93965 RVA: 0x0034F794 File Offset: 0x0034D994
		public static void StartOperationsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06016F0E RID: 93966 RVA: 0x0034F79F File Offset: 0x0034D99F
		public static void AddOperations(FlatBufferBuilder builder, VectorOffset operationsOffset)
		{
			builder.AddOffset(2, operationsOffset.Value, 0);
		}

		// Token: 0x06016F0F RID: 93967 RVA: 0x0034F7B0 File Offset: 0x0034D9B0
		public static VectorOffset CreateOperationsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06016F10 RID: 93968 RVA: 0x0034F7E7 File Offset: 0x0034D9E7
		public static VectorOffset CreateOperationsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06016F11 RID: 93969 RVA: 0x0034F801 File Offset: 0x0034DA01
		public static VectorOffset CreateOperationsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06016F12 RID: 93970 RVA: 0x0034F81F File Offset: 0x0034DA1F
		public static VectorOffset CreateOperationsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016F13 RID: 93971 RVA: 0x0034F838 File Offset: 0x0034DA38
		public static void StartOperationsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016F14 RID: 93972 RVA: 0x0034F843 File Offset: 0x0034DA43
		public static Offset<ILowMemorySceneSwitch> EndILowMemorySceneSwitch(FlatBufferBuilder builder)
		{
			return new Offset<ILowMemorySceneSwitch>(builder.EndTable());
		}

		// Token: 0x06016F15 RID: 93973 RVA: 0x0034F850 File Offset: 0x0034DA50
		public ILowMemorySceneSwitchT UnPack()
		{
			ILowMemorySceneSwitchT lowMemorySceneSwitchT = new ILowMemorySceneSwitchT();
			this.UnPackTo(lowMemorySceneSwitchT);
			return lowMemorySceneSwitchT;
		}

		// Token: 0x06016F16 RID: 93974 RVA: 0x0034F86C File Offset: 0x0034DA6C
		public void UnPackTo(ILowMemorySceneSwitchT _o)
		{
			_o.Type = this.Type;
			_o.Operations = new List<TOperationUnion>();
			for (int i = 0; i < this.OperationsLength; i++)
			{
				TOperationUnion toperationUnion = new TOperationUnion();
				toperationUnion.Type = this.OperationsType(i);
				TOperation toperation = this.OperationsType(i);
				if (toperation != TOperation.IAssignLoadingBackground)
				{
					if (toperation == TOperation.IDisableHLOD)
					{
						toperationUnion.Value = ((this.Operations<IDisableHLOD>(i) != null) ? this.Operations<IDisableHLOD>(i).Value.UnPack() : null);
					}
				}
				else
				{
					toperationUnion.Value = ((this.Operations<IAssignLoadingBackground>(i) != null) ? this.Operations<IAssignLoadingBackground>(i).Value.UnPack() : null);
				}
				_o.Operations.Add(toperationUnion);
			}
		}

		// Token: 0x06016F17 RID: 93975 RVA: 0x0034F940 File Offset: 0x0034DB40
		public static Offset<ILowMemorySceneSwitch> Pack(FlatBufferBuilder builder, ILowMemorySceneSwitchT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILowMemorySceneSwitch>);
			}
			VectorOffset operations_typeOffset = default(VectorOffset);
			if (_o.Operations != null)
			{
				TOperation[] array = new TOperation[_o.Operations.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.Operations[i].Type;
				}
				operations_typeOffset = ILowMemorySceneSwitch.CreateOperationsTypeVector(builder, array);
			}
			VectorOffset operationsOffset = default(VectorOffset);
			if (_o.Operations != null)
			{
				int[] array2 = new int[_o.Operations.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TOperationUnion.Pack(builder, _o.Operations[j]);
				}
				operationsOffset = ILowMemorySceneSwitch.CreateOperationsVector(builder, array2);
			}
			return ILowMemorySceneSwitch.CreateILowMemorySceneSwitch(builder, _o.Type, operations_typeOffset, operationsOffset);
		}

		// Token: 0x0400B924 RID: 47396
		private Table __p;
	}
}
