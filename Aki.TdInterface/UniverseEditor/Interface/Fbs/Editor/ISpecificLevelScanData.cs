using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048A7 RID: 18599
	public struct ISpecificLevelScanData : IFlatbufferObject
	{
		// Token: 0x170086DD RID: 34525
		// (get) Token: 0x0601D078 RID: 118904 RVA: 0x00419939 File Offset: 0x00417B39
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D079 RID: 118905 RVA: 0x00419946 File Offset: 0x00417B46
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D07A RID: 118906 RVA: 0x00419950 File Offset: 0x00417B50
		public static ISpecificLevelScanData GetRootAsISpecificLevelScanData(ByteBuffer _bb)
		{
			return ISpecificLevelScanData.GetRootAsISpecificLevelScanData(_bb, default(ISpecificLevelScanData));
		}

		// Token: 0x0601D07B RID: 118907 RVA: 0x0041996C File Offset: 0x00417B6C
		public static ISpecificLevelScanData GetRootAsISpecificLevelScanData(ByteBuffer _bb, ISpecificLevelScanData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D07C RID: 118908 RVA: 0x00419989 File Offset: 0x00417B89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D07D RID: 118909 RVA: 0x00419998 File Offset: 0x00417B98
		public ISpecificLevelScanData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170086DE RID: 34526
		// (get) Token: 0x0601D07E RID: 118910 RVA: 0x004199A8 File Offset: 0x00417BA8
		public bool IsEnable
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601D07F RID: 118911 RVA: 0x004199E8 File Offset: 0x00417BE8
		public int LevelIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170086DF RID: 34527
		// (get) Token: 0x0601D080 RID: 118912 RVA: 0x00419A28 File Offset: 0x00417C28
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

		// Token: 0x0601D081 RID: 118913 RVA: 0x00419A53 File Offset: 0x00417C53
		public Span<int> GetLevelIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0601D082 RID: 118914 RVA: 0x00419A62 File Offset: 0x00417C62
		public int[] GetLevelIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0601D083 RID: 118915 RVA: 0x00419A70 File Offset: 0x00417C70
		public static Offset<ISpecificLevelScanData> CreateISpecificLevelScanData(FlatBufferBuilder builder, bool IsEnable = false, VectorOffset LevelIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISpecificLevelScanData.AddLevelIds(builder, LevelIdsOffset);
			ISpecificLevelScanData.AddIsEnable(builder, IsEnable);
			return ISpecificLevelScanData.EndISpecificLevelScanData(builder);
		}

		// Token: 0x0601D084 RID: 118916 RVA: 0x00419A8D File Offset: 0x00417C8D
		public static void StartISpecificLevelScanData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D085 RID: 118917 RVA: 0x00419A96 File Offset: 0x00417C96
		public static void AddIsEnable(FlatBufferBuilder builder, bool isEnable)
		{
			builder.AddBool(0, isEnable, false);
		}

		// Token: 0x0601D086 RID: 118918 RVA: 0x00419AA1 File Offset: 0x00417CA1
		public static void AddLevelIds(FlatBufferBuilder builder, VectorOffset levelIdsOffset)
		{
			builder.AddOffset(1, levelIdsOffset.Value, 0);
		}

		// Token: 0x0601D087 RID: 118919 RVA: 0x00419AB4 File Offset: 0x00417CB4
		public static VectorOffset CreateLevelIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D088 RID: 118920 RVA: 0x00419AEB File Offset: 0x00417CEB
		public static VectorOffset CreateLevelIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D089 RID: 118921 RVA: 0x00419B05 File Offset: 0x00417D05
		public static VectorOffset CreateLevelIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D08A RID: 118922 RVA: 0x00419B23 File Offset: 0x00417D23
		public static VectorOffset CreateLevelIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D08B RID: 118923 RVA: 0x00419B3C File Offset: 0x00417D3C
		public static void StartLevelIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D08C RID: 118924 RVA: 0x00419B47 File Offset: 0x00417D47
		public static Offset<ISpecificLevelScanData> EndISpecificLevelScanData(FlatBufferBuilder builder)
		{
			return new Offset<ISpecificLevelScanData>(builder.EndTable());
		}

		// Token: 0x0601D08D RID: 118925 RVA: 0x00419B54 File Offset: 0x00417D54
		public ISpecificLevelScanDataT UnPack()
		{
			ISpecificLevelScanDataT specificLevelScanDataT = new ISpecificLevelScanDataT();
			this.UnPackTo(specificLevelScanDataT);
			return specificLevelScanDataT;
		}

		// Token: 0x0601D08E RID: 118926 RVA: 0x00419B70 File Offset: 0x00417D70
		public void UnPackTo(ISpecificLevelScanDataT _o)
		{
			_o.IsEnable = this.IsEnable;
			_o.LevelIds = new List<int>();
			for (int i = 0; i < this.LevelIdsLength; i++)
			{
				_o.LevelIds.Add(this.LevelIds(i));
			}
		}

		// Token: 0x0601D08F RID: 118927 RVA: 0x00419BB8 File Offset: 0x00417DB8
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

		// Token: 0x0400CE93 RID: 52883
		private Table __p;
	}
}
