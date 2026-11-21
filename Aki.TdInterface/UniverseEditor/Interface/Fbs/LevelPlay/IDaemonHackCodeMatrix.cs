using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048BA RID: 18618
	public struct IDaemonHackCodeMatrix : IFlatbufferObject
	{
		// Token: 0x17008185 RID: 33157
		// (get) Token: 0x0601B853 RID: 112723 RVA: 0x003E484B File Offset: 0x003E2A4B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B854 RID: 112724 RVA: 0x003E4858 File Offset: 0x003E2A58
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B855 RID: 112725 RVA: 0x003E4860 File Offset: 0x003E2A60
		public static IDaemonHackCodeMatrix GetRootAsIDaemonHackCodeMatrix(ByteBuffer _bb)
		{
			return IDaemonHackCodeMatrix.GetRootAsIDaemonHackCodeMatrix(_bb, default(IDaemonHackCodeMatrix));
		}

		// Token: 0x0601B856 RID: 112726 RVA: 0x003E487C File Offset: 0x003E2A7C
		public static IDaemonHackCodeMatrix GetRootAsIDaemonHackCodeMatrix(ByteBuffer _bb, IDaemonHackCodeMatrix obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B857 RID: 112727 RVA: 0x003E4899 File Offset: 0x003E2A99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B858 RID: 112728 RVA: 0x003E48A8 File Offset: 0x003E2AA8
		public IDaemonHackCodeMatrix __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008186 RID: 33158
		// (get) Token: 0x0601B859 RID: 112729 RVA: 0x003E48B8 File Offset: 0x003E2AB8
		public int MatrixSize
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B85A RID: 112730 RVA: 0x003E48F4 File Offset: 0x003E2AF4
		public IDaemonHackPresetCode? PresetCodes(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IDaemonHackPresetCode?(default(IDaemonHackPresetCode).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008187 RID: 33159
		// (get) Token: 0x0601B85B RID: 112731 RVA: 0x003E4954 File Offset: 0x003E2B54
		public int PresetCodesLength
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

		// Token: 0x0601B85C RID: 112732 RVA: 0x003E497F File Offset: 0x003E2B7F
		public static Offset<IDaemonHackCodeMatrix> CreateIDaemonHackCodeMatrix(FlatBufferBuilder builder, int MatrixSize = 0, VectorOffset PresetCodesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IDaemonHackCodeMatrix.AddPresetCodes(builder, PresetCodesOffset);
			IDaemonHackCodeMatrix.AddMatrixSize(builder, MatrixSize);
			return IDaemonHackCodeMatrix.EndIDaemonHackCodeMatrix(builder);
		}

		// Token: 0x0601B85D RID: 112733 RVA: 0x003E499C File Offset: 0x003E2B9C
		public static void StartIDaemonHackCodeMatrix(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601B85E RID: 112734 RVA: 0x003E49A5 File Offset: 0x003E2BA5
		public static void AddMatrixSize(FlatBufferBuilder builder, int matrixSize)
		{
			builder.AddInt(0, matrixSize, 0);
		}

		// Token: 0x0601B85F RID: 112735 RVA: 0x003E49B0 File Offset: 0x003E2BB0
		public static void AddPresetCodes(FlatBufferBuilder builder, VectorOffset presetCodesOffset)
		{
			builder.AddOffset(1, presetCodesOffset.Value, 0);
		}

		// Token: 0x0601B860 RID: 112736 RVA: 0x003E49C0 File Offset: 0x003E2BC0
		public static VectorOffset CreatePresetCodesVector(FlatBufferBuilder builder, Offset<IDaemonHackPresetCode>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B861 RID: 112737 RVA: 0x003E4A00 File Offset: 0x003E2C00
		public static VectorOffset CreatePresetCodesVectorBlock(FlatBufferBuilder builder, Offset<IDaemonHackPresetCode>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDaemonHackPresetCode>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B862 RID: 112738 RVA: 0x003E4A1A File Offset: 0x003E2C1A
		public static VectorOffset CreatePresetCodesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDaemonHackPresetCode>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDaemonHackPresetCode>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B863 RID: 112739 RVA: 0x003E4A38 File Offset: 0x003E2C38
		public static VectorOffset CreatePresetCodesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDaemonHackPresetCode>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B864 RID: 112740 RVA: 0x003E4A51 File Offset: 0x003E2C51
		public static void StartPresetCodesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B865 RID: 112741 RVA: 0x003E4A5C File Offset: 0x003E2C5C
		public static Offset<IDaemonHackCodeMatrix> EndIDaemonHackCodeMatrix(FlatBufferBuilder builder)
		{
			return new Offset<IDaemonHackCodeMatrix>(builder.EndTable());
		}

		// Token: 0x0601B866 RID: 112742 RVA: 0x003E4A6C File Offset: 0x003E2C6C
		public IDaemonHackCodeMatrixT UnPack()
		{
			IDaemonHackCodeMatrixT daemonHackCodeMatrixT = new IDaemonHackCodeMatrixT();
			this.UnPackTo(daemonHackCodeMatrixT);
			return daemonHackCodeMatrixT;
		}

		// Token: 0x0601B867 RID: 112743 RVA: 0x003E4A88 File Offset: 0x003E2C88
		public void UnPackTo(IDaemonHackCodeMatrixT _o)
		{
			_o.MatrixSize = this.MatrixSize;
			_o.PresetCodes = new List<IDaemonHackPresetCodeT>();
			for (int i = 0; i < this.PresetCodesLength; i++)
			{
				_o.PresetCodes.Add((this.PresetCodes(i) != null) ? this.PresetCodes(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601B868 RID: 112744 RVA: 0x003E4AF4 File Offset: 0x003E2CF4
		public static Offset<IDaemonHackCodeMatrix> Pack(FlatBufferBuilder builder, IDaemonHackCodeMatrixT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDaemonHackCodeMatrix>);
			}
			VectorOffset presetCodesOffset = default(VectorOffset);
			if (_o.PresetCodes != null)
			{
				Offset<IDaemonHackPresetCode>[] array = new Offset<IDaemonHackPresetCode>[_o.PresetCodes.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IDaemonHackPresetCode.Pack(builder, _o.PresetCodes[i]);
				}
				presetCodesOffset = IDaemonHackCodeMatrix.CreatePresetCodesVector(builder, array);
			}
			return IDaemonHackCodeMatrix.CreateIDaemonHackCodeMatrix(builder, _o.MatrixSize, presetCodesOffset);
		}

		// Token: 0x0400CE55 RID: 52821
		private Table __p;
	}
}
