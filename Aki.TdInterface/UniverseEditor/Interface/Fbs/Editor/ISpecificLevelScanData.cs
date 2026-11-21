using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D0C RID: 19724
	public struct ISpecificLevelScanData : IFlatbufferObject
	{
		// Token: 0x17008D25 RID: 36133
		// (get) Token: 0x0601E865 RID: 125029 RVA: 0x004460D5 File Offset: 0x004442D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E866 RID: 125030 RVA: 0x004460E2 File Offset: 0x004442E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E867 RID: 125031 RVA: 0x004460EC File Offset: 0x004442EC
		public static ISpecificLevelScanData GetRootAsISpecificLevelScanData(ByteBuffer _bb)
		{
			return ISpecificLevelScanData.GetRootAsISpecificLevelScanData(_bb, default(ISpecificLevelScanData));
		}

		// Token: 0x0601E868 RID: 125032 RVA: 0x00446108 File Offset: 0x00444308
		public static ISpecificLevelScanData GetRootAsISpecificLevelScanData(ByteBuffer _bb, ISpecificLevelScanData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E869 RID: 125033 RVA: 0x00446125 File Offset: 0x00444325
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E86A RID: 125034 RVA: 0x00446134 File Offset: 0x00444334
		public ISpecificLevelScanData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D26 RID: 36134
		// (get) Token: 0x0601E86B RID: 125035 RVA: 0x00446144 File Offset: 0x00444344
		public bool IsEnable
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601E86C RID: 125036 RVA: 0x00446184 File Offset: 0x00444384
		public int LevelIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008D27 RID: 36135
		// (get) Token: 0x0601E86D RID: 125037 RVA: 0x004461C4 File Offset: 0x004443C4
		public int LevelIdsLength
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

		// Token: 0x0601E86E RID: 125038 RVA: 0x004461EF File Offset: 0x004443EF
		public Span<int> GetLevelIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0601E86F RID: 125039 RVA: 0x004461FE File Offset: 0x004443FE
		public int[] GetLevelIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0601E870 RID: 125040 RVA: 0x0044620C File Offset: 0x0044440C
		public static Offset<ISpecificLevelScanData> CreateISpecificLevelScanData(FlatBufferBuilder builder, bool IsEnable = false, VectorOffset LevelIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISpecificLevelScanData.AddLevelIds(builder, LevelIdsOffset);
			ISpecificLevelScanData.AddIsEnable(builder, IsEnable);
			return ISpecificLevelScanData.EndISpecificLevelScanData(builder);
		}

		// Token: 0x0601E871 RID: 125041 RVA: 0x00446229 File Offset: 0x00444429
		public static void StartISpecificLevelScanData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601E872 RID: 125042 RVA: 0x00446232 File Offset: 0x00444432
		public static void AddIsEnable(FlatBufferBuilder builder, bool isEnable)
		{
			builder.AddBool(0, isEnable, false);
		}

		// Token: 0x0601E873 RID: 125043 RVA: 0x0044623D File Offset: 0x0044443D
		public static void AddLevelIds(FlatBufferBuilder builder, VectorOffset levelIdsOffset)
		{
			builder.AddOffset(1, levelIdsOffset.Value, 0);
		}

		// Token: 0x0601E874 RID: 125044 RVA: 0x00446250 File Offset: 0x00444450
		public static VectorOffset CreateLevelIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E875 RID: 125045 RVA: 0x00446287 File Offset: 0x00444487
		public static VectorOffset CreateLevelIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E876 RID: 125046 RVA: 0x004462A1 File Offset: 0x004444A1
		public static VectorOffset CreateLevelIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E877 RID: 125047 RVA: 0x004462BF File Offset: 0x004444BF
		public static VectorOffset CreateLevelIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E878 RID: 125048 RVA: 0x004462D8 File Offset: 0x004444D8
		public static void StartLevelIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E879 RID: 125049 RVA: 0x004462E3 File Offset: 0x004444E3
		public static Offset<ISpecificLevelScanData> EndISpecificLevelScanData(FlatBufferBuilder builder)
		{
			return new Offset<ISpecificLevelScanData>(builder.EndTable());
		}

		// Token: 0x0601E87A RID: 125050 RVA: 0x004462F0 File Offset: 0x004444F0
		public ISpecificLevelScanDataT UnPack()
		{
			ISpecificLevelScanDataT specificLevelScanDataT = new ISpecificLevelScanDataT();
			this.UnPackTo(specificLevelScanDataT);
			return specificLevelScanDataT;
		}

		// Token: 0x0601E87B RID: 125051 RVA: 0x0044630C File Offset: 0x0044450C
		public void UnPackTo(ISpecificLevelScanDataT _o)
		{
			_o.IsEnable = this.IsEnable;
			_o.LevelIds = new List<int>();
			for (int i = 0; i < this.LevelIdsLength; i++)
			{
				_o.LevelIds.Add(this.LevelIds(i));
			}
		}

		// Token: 0x0601E87C RID: 125052 RVA: 0x00446354 File Offset: 0x00444554
		public static Offset<ISpecificLevelScanData> Pack(FlatBufferBuilder builder, ISpecificLevelScanDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpecificLevelScanData>);
			}
			VectorOffset levelIdsOffset = default(VectorOffset);
			if (_o.LevelIds != null)
			{
				int[] data = _o.LevelIds.ToArray();
				levelIdsOffset = ISpecificLevelScanData.CreateLevelIdsVector(builder, data);
			}
			return ISpecificLevelScanData.CreateISpecificLevelScanData(builder, _o.IsEnable, levelIdsOffset);
		}

		// Token: 0x0400D8CC RID: 55500
		private Table __p;
	}
}
