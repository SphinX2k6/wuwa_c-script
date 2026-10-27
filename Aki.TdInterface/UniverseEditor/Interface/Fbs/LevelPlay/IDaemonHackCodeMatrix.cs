using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004452 RID: 17490
	public struct IDaemonHackCodeMatrix : IFlatbufferObject
	{
		// Token: 0x17007B46 RID: 31558
		// (get) Token: 0x0601A082 RID: 106626 RVA: 0x003B863F File Offset: 0x003B683F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A083 RID: 106627 RVA: 0x003B864C File Offset: 0x003B684C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A084 RID: 106628 RVA: 0x003B8654 File Offset: 0x003B6854
		public static IDaemonHackCodeMatrix GetRootAsIDaemonHackCodeMatrix(ByteBuffer _bb)
		{
			return IDaemonHackCodeMatrix.GetRootAsIDaemonHackCodeMatrix(_bb, default(IDaemonHackCodeMatrix));
		}

		// Token: 0x0601A085 RID: 106629 RVA: 0x003B8670 File Offset: 0x003B6870
		public static IDaemonHackCodeMatrix GetRootAsIDaemonHackCodeMatrix(ByteBuffer _bb, IDaemonHackCodeMatrix obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A086 RID: 106630 RVA: 0x003B868D File Offset: 0x003B688D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A087 RID: 106631 RVA: 0x003B869C File Offset: 0x003B689C
		public IDaemonHackCodeMatrix __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007B47 RID: 31559
		// (get) Token: 0x0601A088 RID: 106632 RVA: 0x003B86AC File Offset: 0x003B68AC
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

		// Token: 0x0601A089 RID: 106633 RVA: 0x003B86E8 File Offset: 0x003B68E8
		public IDaemonHackPresetCode? PresetCodes(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IDaemonHackPresetCode?(default(IDaemonHackPresetCode).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007B48 RID: 31560
		// (get) Token: 0x0601A08A RID: 106634 RVA: 0x003B8748 File Offset: 0x003B6948
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

		// Token: 0x0601A08B RID: 106635 RVA: 0x003B8773 File Offset: 0x003B6973
		public static Offset<IDaemonHackCodeMatrix> CreateIDaemonHackCodeMatrix(FlatBufferBuilder builder, int MatrixSize = 0, VectorOffset PresetCodesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IDaemonHackCodeMatrix.AddPresetCodes(builder, PresetCodesOffset);
			IDaemonHackCodeMatrix.AddMatrixSize(builder, MatrixSize);
			return IDaemonHackCodeMatrix.EndIDaemonHackCodeMatrix(builder);
		}

		// Token: 0x0601A08C RID: 106636 RVA: 0x003B8790 File Offset: 0x003B6990
		public static void StartIDaemonHackCodeMatrix(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601A08D RID: 106637 RVA: 0x003B8799 File Offset: 0x003B6999
		public static void AddMatrixSize(FlatBufferBuilder builder, int matrixSize)
		{
			builder.AddInt(0, matrixSize, 0);
		}

		// Token: 0x0601A08E RID: 106638 RVA: 0x003B87A4 File Offset: 0x003B69A4
		public static void AddPresetCodes(FlatBufferBuilder builder, VectorOffset presetCodesOffset)
		{
			builder.AddOffset(1, presetCodesOffset.Value, 0);
		}

		// Token: 0x0601A08F RID: 106639 RVA: 0x003B87B4 File Offset: 0x003B69B4
		public static VectorOffset CreatePresetCodesVector(FlatBufferBuilder builder, Offset<IDaemonHackPresetCode>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A090 RID: 106640 RVA: 0x003B87F4 File Offset: 0x003B69F4
		public static VectorOffset CreatePresetCodesVectorBlock(FlatBufferBuilder builder, Offset<IDaemonHackPresetCode>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDaemonHackPresetCode>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A091 RID: 106641 RVA: 0x003B880E File Offset: 0x003B6A0E
		public static VectorOffset CreatePresetCodesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDaemonHackPresetCode>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDaemonHackPresetCode>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A092 RID: 106642 RVA: 0x003B882C File Offset: 0x003B6A2C
		public static VectorOffset CreatePresetCodesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDaemonHackPresetCode>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A093 RID: 106643 RVA: 0x003B8845 File Offset: 0x003B6A45
		public static void StartPresetCodesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A094 RID: 106644 RVA: 0x003B8850 File Offset: 0x003B6A50
		public static Offset<IDaemonHackCodeMatrix> EndIDaemonHackCodeMatrix(FlatBufferBuilder builder)
		{
			return new Offset<IDaemonHackCodeMatrix>(builder.EndTable());
		}

		// Token: 0x0601A095 RID: 106645 RVA: 0x003B8860 File Offset: 0x003B6A60
		public IDaemonHackCodeMatrixT UnPack()
		{
			IDaemonHackCodeMatrixT daemonHackCodeMatrixT = new IDaemonHackCodeMatrixT();
			this.UnPackTo(daemonHackCodeMatrixT);
			return daemonHackCodeMatrixT;
		}

		// Token: 0x0601A096 RID: 106646 RVA: 0x003B887C File Offset: 0x003B6A7C
		public void UnPackTo(IDaemonHackCodeMatrixT _o)
		{
			_o.MatrixSize = this.MatrixSize;
			_o.PresetCodes = new List<IDaemonHackPresetCodeT>();
			for (int i = 0; i < this.PresetCodesLength; i++)
			{
				_o.PresetCodes.Add((this.PresetCodes(i) != null) ? this.PresetCodes(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601A097 RID: 106647 RVA: 0x003B88E8 File Offset: 0x003B6AE8
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

		// Token: 0x0400C427 RID: 50215
		private Table __p;
	}
}
