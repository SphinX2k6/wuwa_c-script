using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C00 RID: 23552
	public struct TCsvWuWaGoLevelData : IFlatbufferObject
	{
		// Token: 0x1700B1D9 RID: 45529
		// (get) Token: 0x0602866D RID: 165485 RVA: 0x0058FBCE File Offset: 0x0058DDCE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602866E RID: 165486 RVA: 0x0058FBDB File Offset: 0x0058DDDB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602866F RID: 165487 RVA: 0x0058FBE4 File Offset: 0x0058DDE4
		public static TCsvWuWaGoLevelData GetRootAsTCsvWuWaGoLevelData(ByteBuffer _bb)
		{
			return TCsvWuWaGoLevelData.GetRootAsTCsvWuWaGoLevelData(_bb, default(TCsvWuWaGoLevelData));
		}

		// Token: 0x06028670 RID: 165488 RVA: 0x0058FC00 File Offset: 0x0058DE00
		public static TCsvWuWaGoLevelData GetRootAsTCsvWuWaGoLevelData(ByteBuffer _bb, TCsvWuWaGoLevelData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028671 RID: 165489 RVA: 0x0058FC1D File Offset: 0x0058DE1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028672 RID: 165490 RVA: 0x0058FC2C File Offset: 0x0058DE2C
		public TCsvWuWaGoLevelData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B1DA RID: 45530
		// (get) Token: 0x06028673 RID: 165491 RVA: 0x0058FC3C File Offset: 0x0058DE3C
		public string Key
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028674 RID: 165492 RVA: 0x0058FC73 File Offset: 0x0058DE73
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06028675 RID: 165493 RVA: 0x0058FC82 File Offset: 0x0058DE82
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06028676 RID: 165494 RVA: 0x0058FC90 File Offset: 0x0058DE90
		public IWuWaGoGridData? GridDatas(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IWuWaGoGridData?(default(IWuWaGoGridData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B1DB RID: 45531
		// (get) Token: 0x06028677 RID: 165495 RVA: 0x0058FCF0 File Offset: 0x0058DEF0
		public int GridDatasLength
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

		// Token: 0x06028678 RID: 165496 RVA: 0x0058FD1C File Offset: 0x0058DF1C
		public IWuWaGoRoleInfo? RoleList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IWuWaGoRoleInfo?(default(IWuWaGoRoleInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B1DC RID: 45532
		// (get) Token: 0x06028679 RID: 165497 RVA: 0x0058FD7C File Offset: 0x0058DF7C
		public int RoleListLength
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

		// Token: 0x0602867A RID: 165498 RVA: 0x0058FDA7 File Offset: 0x0058DFA7
		public static Offset<TCsvWuWaGoLevelData> CreateTCsvWuWaGoLevelData(FlatBufferBuilder builder, StringOffset KeyOffset = default(StringOffset), VectorOffset GridDatasOffset = default(VectorOffset), VectorOffset RoleListOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			TCsvWuWaGoLevelData.AddRoleList(builder, RoleListOffset);
			TCsvWuWaGoLevelData.AddGridDatas(builder, GridDatasOffset);
			TCsvWuWaGoLevelData.AddKey(builder, KeyOffset);
			return TCsvWuWaGoLevelData.EndTCsvWuWaGoLevelData(builder);
		}

		// Token: 0x0602867B RID: 165499 RVA: 0x0058FDCB File Offset: 0x0058DFCB
		public static void StartTCsvWuWaGoLevelData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602867C RID: 165500 RVA: 0x0058FDD4 File Offset: 0x0058DFD4
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(0, keyOffset.Value, 0);
		}

		// Token: 0x0602867D RID: 165501 RVA: 0x0058FDE4 File Offset: 0x0058DFE4
		public static void AddGridDatas(FlatBufferBuilder builder, VectorOffset gridDatasOffset)
		{
			builder.AddOffset(1, gridDatasOffset.Value, 0);
		}

		// Token: 0x0602867E RID: 165502 RVA: 0x0058FDF4 File Offset: 0x0058DFF4
		public static VectorOffset CreateGridDatasVector(FlatBufferBuilder builder, Offset<IWuWaGoGridData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602867F RID: 165503 RVA: 0x0058FE34 File Offset: 0x0058E034
		public static VectorOffset CreateGridDatasVectorBlock(FlatBufferBuilder builder, Offset<IWuWaGoGridData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IWuWaGoGridData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028680 RID: 165504 RVA: 0x0058FE4E File Offset: 0x0058E04E
		public static VectorOffset CreateGridDatasVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IWuWaGoGridData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IWuWaGoGridData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028681 RID: 165505 RVA: 0x0058FE6C File Offset: 0x0058E06C
		public static VectorOffset CreateGridDatasVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IWuWaGoGridData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028682 RID: 165506 RVA: 0x0058FE85 File Offset: 0x0058E085
		public static void StartGridDatasVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028683 RID: 165507 RVA: 0x0058FE90 File Offset: 0x0058E090
		public static void AddRoleList(FlatBufferBuilder builder, VectorOffset roleListOffset)
		{
			builder.AddOffset(2, roleListOffset.Value, 0);
		}

		// Token: 0x06028684 RID: 165508 RVA: 0x0058FEA0 File Offset: 0x0058E0A0
		public static VectorOffset CreateRoleListVector(FlatBufferBuilder builder, Offset<IWuWaGoRoleInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06028685 RID: 165509 RVA: 0x0058FEE0 File Offset: 0x0058E0E0
		public static VectorOffset CreateRoleListVectorBlock(FlatBufferBuilder builder, Offset<IWuWaGoRoleInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IWuWaGoRoleInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028686 RID: 165510 RVA: 0x0058FEFA File Offset: 0x0058E0FA
		public static VectorOffset CreateRoleListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IWuWaGoRoleInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IWuWaGoRoleInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028687 RID: 165511 RVA: 0x0058FF18 File Offset: 0x0058E118
		public static VectorOffset CreateRoleListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IWuWaGoRoleInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028688 RID: 165512 RVA: 0x0058FF31 File Offset: 0x0058E131
		public static void StartRoleListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028689 RID: 165513 RVA: 0x0058FF3C File Offset: 0x0058E13C
		public static Offset<TCsvWuWaGoLevelData> EndTCsvWuWaGoLevelData(FlatBufferBuilder builder)
		{
			return new Offset<TCsvWuWaGoLevelData>(builder.EndTable());
		}

		// Token: 0x0602868A RID: 165514 RVA: 0x0058FF4C File Offset: 0x0058E14C
		public TCsvWuWaGoLevelDataT UnPack()
		{
			TCsvWuWaGoLevelDataT tcsvWuWaGoLevelDataT = new TCsvWuWaGoLevelDataT();
			this.UnPackTo(tcsvWuWaGoLevelDataT);
			return tcsvWuWaGoLevelDataT;
		}

		// Token: 0x0602868B RID: 165515 RVA: 0x0058FF68 File Offset: 0x0058E168
		public void UnPackTo(TCsvWuWaGoLevelDataT _o)
		{
			_o.Key = this.Key;
			_o.GridDatas = new List<IWuWaGoGridDataT>();
			for (int i = 0; i < this.GridDatasLength; i++)
			{
				_o.GridDatas.Add((this.GridDatas(i) != null) ? this.GridDatas(i).Value.UnPack() : null);
			}
			_o.RoleList = new List<IWuWaGoRoleInfoT>();
			for (int j = 0; j < this.RoleListLength; j++)
			{
				_o.RoleList.Add((this.RoleList(j) != null) ? this.RoleList(j).Value.UnPack() : null);
			}
		}

		// Token: 0x0602868C RID: 165516 RVA: 0x00590028 File Offset: 0x0058E228
		public static Offset<TCsvWuWaGoLevelData> Pack(FlatBufferBuilder builder, TCsvWuWaGoLevelDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<TCsvWuWaGoLevelData>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			VectorOffset gridDatasOffset = default(VectorOffset);
			if (_o.GridDatas != null)
			{
				Offset<IWuWaGoGridData>[] array = new Offset<IWuWaGoGridData>[_o.GridDatas.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IWuWaGoGridData.Pack(builder, _o.GridDatas[i]);
				}
				gridDatasOffset = TCsvWuWaGoLevelData.CreateGridDatasVector(builder, array);
			}
			VectorOffset roleListOffset = default(VectorOffset);
			if (_o.RoleList != null)
			{
				Offset<IWuWaGoRoleInfo>[] array2 = new Offset<IWuWaGoRoleInfo>[_o.RoleList.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IWuWaGoRoleInfo.Pack(builder, _o.RoleList[j]);
				}
				roleListOffset = TCsvWuWaGoLevelData.CreateRoleListVector(builder, array2);
			}
			return TCsvWuWaGoLevelData.CreateTCsvWuWaGoLevelData(builder, keyOffset, gridDatasOffset, roleListOffset);
		}

		// Token: 0x0400F3A5 RID: 62373
		private Table __p;
	}
}
