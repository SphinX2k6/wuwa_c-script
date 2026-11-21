using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200435B RID: 17243
	public struct ILowMemorySceneSwitch : IFlatbufferObject
	{
		// Token: 0x17007649 RID: 30281
		// (get) Token: 0x06018550 RID: 99664 RVA: 0x003786E6 File Offset: 0x003768E6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018551 RID: 99665 RVA: 0x003786F3 File Offset: 0x003768F3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018552 RID: 99666 RVA: 0x003786FC File Offset: 0x003768FC
		public static ILowMemorySceneSwitch GetRootAsILowMemorySceneSwitch(ByteBuffer _bb)
		{
			return ILowMemorySceneSwitch.GetRootAsILowMemorySceneSwitch(_bb, default(ILowMemorySceneSwitch));
		}

		// Token: 0x06018553 RID: 99667 RVA: 0x00378718 File Offset: 0x00376918
		public static ILowMemorySceneSwitch GetRootAsILowMemorySceneSwitch(ByteBuffer _bb, ILowMemorySceneSwitch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018554 RID: 99668 RVA: 0x00378735 File Offset: 0x00376935
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018555 RID: 99669 RVA: 0x00378744 File Offset: 0x00376944
		public ILowMemorySceneSwitch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700764A RID: 30282
		// (get) Token: 0x06018556 RID: 99670 RVA: 0x00378754 File Offset: 0x00376954
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

		// Token: 0x06018557 RID: 99671 RVA: 0x00378790 File Offset: 0x00376990
		public TOperation OperationsType(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return TOperation.NONE;
			}
			return (TOperation)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700764B RID: 30283
		// (get) Token: 0x06018558 RID: 99672 RVA: 0x003787D0 File Offset: 0x003769D0
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

		// Token: 0x06018559 RID: 99673 RVA: 0x003787FB File Offset: 0x003769FB
		public Span<TOperation> GetOperationsTypeBytes()
		{
			return this.__p.__vector_as_span<TOperation>(6, 1);
		}

		// Token: 0x0601855A RID: 99674 RVA: 0x0037880C File Offset: 0x00376A0C
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

		// Token: 0x0601855B RID: 99675 RVA: 0x00378878 File Offset: 0x00376A78
		public TTable? Operations<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700764C RID: 30284
		// (get) Token: 0x0601855C RID: 99676 RVA: 0x003788C0 File Offset: 0x00376AC0
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

		// Token: 0x0601855D RID: 99677 RVA: 0x003788EB File Offset: 0x00376AEB
		public static Offset<ILowMemorySceneSwitch> CreateILowMemorySceneSwitch(FlatBufferBuilder builder, ESpecialProcess Type = ESpecialProcess.LowMemorySceneSwitch, VectorOffset Operations_typeOffset = default(VectorOffset), VectorOffset OperationsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ILowMemorySceneSwitch.AddOperations(builder, OperationsOffset);
			ILowMemorySceneSwitch.AddOperationsType(builder, Operations_typeOffset);
			ILowMemorySceneSwitch.AddType(builder, Type);
			return ILowMemorySceneSwitch.EndILowMemorySceneSwitch(builder);
		}

		// Token: 0x0601855E RID: 99678 RVA: 0x0037890F File Offset: 0x00376B0F
		public static void StartILowMemorySceneSwitch(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601855F RID: 99679 RVA: 0x00378918 File Offset: 0x00376B18
		public static void AddType(FlatBufferBuilder builder, ESpecialProcess type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018560 RID: 99680 RVA: 0x00378923 File Offset: 0x00376B23
		public static void AddOperationsType(FlatBufferBuilder builder, VectorOffset operationsTypeOffset)
		{
			builder.AddOffset(1, operationsTypeOffset.Value, 0);
		}

		// Token: 0x06018561 RID: 99681 RVA: 0x00378934 File Offset: 0x00376B34
		public static VectorOffset CreateOperationsTypeVector(FlatBufferBuilder builder, TOperation[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06018562 RID: 99682 RVA: 0x0037896B File Offset: 0x00376B6B
		public static VectorOffset CreateOperationsTypeVectorBlock(FlatBufferBuilder builder, TOperation[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TOperation>(data);
			return builder.EndVector();
		}

		// Token: 0x06018563 RID: 99683 RVA: 0x00378985 File Offset: 0x00376B85
		public static VectorOffset CreateOperationsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TOperation> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TOperation>(data);
			return builder.EndVector();
		}

		// Token: 0x06018564 RID: 99684 RVA: 0x003789A3 File Offset: 0x00376BA3
		public static VectorOffset CreateOperationsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TOperation>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018565 RID: 99685 RVA: 0x003789BC File Offset: 0x00376BBC
		public static void StartOperationsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06018566 RID: 99686 RVA: 0x003789C7 File Offset: 0x00376BC7
		public static void AddOperations(FlatBufferBuilder builder, VectorOffset operationsOffset)
		{
			builder.AddOffset(2, operationsOffset.Value, 0);
		}

		// Token: 0x06018567 RID: 99687 RVA: 0x003789D8 File Offset: 0x00376BD8
		public static VectorOffset CreateOperationsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06018568 RID: 99688 RVA: 0x00378A0F File Offset: 0x00376C0F
		public static VectorOffset CreateOperationsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018569 RID: 99689 RVA: 0x00378A29 File Offset: 0x00376C29
		public static VectorOffset CreateOperationsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601856A RID: 99690 RVA: 0x00378A47 File Offset: 0x00376C47
		public static VectorOffset CreateOperationsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601856B RID: 99691 RVA: 0x00378A60 File Offset: 0x00376C60
		public static void StartOperationsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601856C RID: 99692 RVA: 0x00378A6B File Offset: 0x00376C6B
		public static Offset<ILowMemorySceneSwitch> EndILowMemorySceneSwitch(FlatBufferBuilder builder)
		{
			return new Offset<ILowMemorySceneSwitch>(builder.EndTable());
		}

		// Token: 0x0601856D RID: 99693 RVA: 0x00378A78 File Offset: 0x00376C78
		public ILowMemorySceneSwitchT UnPack()
		{
			ILowMemorySceneSwitchT lowMemorySceneSwitchT = new ILowMemorySceneSwitchT();
			this.UnPackTo(lowMemorySceneSwitchT);
			return lowMemorySceneSwitchT;
		}

		// Token: 0x0601856E RID: 99694 RVA: 0x00378A94 File Offset: 0x00376C94
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

		// Token: 0x0601856F RID: 99695 RVA: 0x00378B68 File Offset: 0x00376D68
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

		// Token: 0x0400C301 RID: 49921
		private Table __p;
	}
}
