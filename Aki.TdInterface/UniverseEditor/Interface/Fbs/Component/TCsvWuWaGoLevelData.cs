using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200621F RID: 25119
	public struct TCsvWuWaGoLevelData : IFlatbufferObject
	{
		// Token: 0x1700BB27 RID: 47911
		// (get) Token: 0x0602AC5D RID: 175197 RVA: 0x005D7B16 File Offset: 0x005D5D16
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602AC5E RID: 175198 RVA: 0x005D7B23 File Offset: 0x005D5D23
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602AC5F RID: 175199 RVA: 0x005D7B2C File Offset: 0x005D5D2C
		public static TCsvWuWaGoLevelData GetRootAsTCsvWuWaGoLevelData(ByteBuffer _bb)
		{
			return TCsvWuWaGoLevelData.GetRootAsTCsvWuWaGoLevelData(_bb, default(TCsvWuWaGoLevelData));
		}

		// Token: 0x0602AC60 RID: 175200 RVA: 0x005D7B48 File Offset: 0x005D5D48
		public static TCsvWuWaGoLevelData GetRootAsTCsvWuWaGoLevelData(ByteBuffer _bb, TCsvWuWaGoLevelData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602AC61 RID: 175201 RVA: 0x005D7B65 File Offset: 0x005D5D65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602AC62 RID: 175202 RVA: 0x005D7B74 File Offset: 0x005D5D74
		public TCsvWuWaGoLevelData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BB28 RID: 47912
		// (get) Token: 0x0602AC63 RID: 175203 RVA: 0x005D7B84 File Offset: 0x005D5D84
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

		// Token: 0x0602AC64 RID: 175204 RVA: 0x005D7BBB File Offset: 0x005D5DBB
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602AC65 RID: 175205 RVA: 0x005D7BCA File Offset: 0x005D5DCA
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0602AC66 RID: 175206 RVA: 0x005D7BD8 File Offset: 0x005D5DD8
		public IWuWaGoGridData? GridDatas(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IWuWaGoGridData?(default(IWuWaGoGridData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700BB29 RID: 47913
		// (get) Token: 0x0602AC67 RID: 175207 RVA: 0x005D7C38 File Offset: 0x005D5E38
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

		// Token: 0x0602AC68 RID: 175208 RVA: 0x005D7C64 File Offset: 0x005D5E64
		public IWuWaGoRoleInfo? RoleList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IWuWaGoRoleInfo?(default(IWuWaGoRoleInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700BB2A RID: 47914
		// (get) Token: 0x0602AC69 RID: 175209 RVA: 0x005D7CC4 File Offset: 0x005D5EC4
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

		// Token: 0x0602AC6A RID: 175210 RVA: 0x005D7CEF File Offset: 0x005D5EEF
		public static Offset<TCsvWuWaGoLevelData> CreateTCsvWuWaGoLevelData(FlatBufferBuilder builder, StringOffset KeyOffset = default(StringOffset), VectorOffset GridDatasOffset = default(VectorOffset), VectorOffset RoleListOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			TCsvWuWaGoLevelData.AddRoleList(builder, RoleListOffset);
			TCsvWuWaGoLevelData.AddGridDatas(builder, GridDatasOffset);
			TCsvWuWaGoLevelData.AddKey(builder, KeyOffset);
			return TCsvWuWaGoLevelData.EndTCsvWuWaGoLevelData(builder);
		}

		// Token: 0x0602AC6B RID: 175211 RVA: 0x005D7D13 File Offset: 0x005D5F13
		public static void StartTCsvWuWaGoLevelData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602AC6C RID: 175212 RVA: 0x005D7D1C File Offset: 0x005D5F1C
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(0, keyOffset.Value, 0);
		}

		// Token: 0x0602AC6D RID: 175213 RVA: 0x005D7D2C File Offset: 0x005D5F2C
		public static void AddGridDatas(FlatBufferBuilder builder, VectorOffset gridDatasOffset)
		{
			builder.AddOffset(1, gridDatasOffset.Value, 0);
		}

		// Token: 0x0602AC6E RID: 175214 RVA: 0x005D7D3C File Offset: 0x005D5F3C
		public static VectorOffset CreateGridDatasVector(FlatBufferBuilder builder, Offset<IWuWaGoGridData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602AC6F RID: 175215 RVA: 0x005D7D7C File Offset: 0x005D5F7C
		public static VectorOffset CreateGridDatasVectorBlock(FlatBufferBuilder builder, Offset<IWuWaGoGridData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IWuWaGoGridData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602AC70 RID: 175216 RVA: 0x005D7D96 File Offset: 0x005D5F96
		public static VectorOffset CreateGridDatasVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IWuWaGoGridData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IWuWaGoGridData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602AC71 RID: 175217 RVA: 0x005D7DB4 File Offset: 0x005D5FB4
		public static VectorOffset CreateGridDatasVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IWuWaGoGridData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602AC72 RID: 175218 RVA: 0x005D7DCD File Offset: 0x005D5FCD
		public static void StartGridDatasVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602AC73 RID: 175219 RVA: 0x005D7DD8 File Offset: 0x005D5FD8
		public static void AddRoleList(FlatBufferBuilder builder, VectorOffset roleListOffset)
		{
			builder.AddOffset(2, roleListOffset.Value, 0);
		}

		// Token: 0x0602AC74 RID: 175220 RVA: 0x005D7DE8 File Offset: 0x005D5FE8
		public static VectorOffset CreateRoleListVector(FlatBufferBuilder builder, Offset<IWuWaGoRoleInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602AC75 RID: 175221 RVA: 0x005D7E28 File Offset: 0x005D6028
		public static VectorOffset CreateRoleListVectorBlock(FlatBufferBuilder builder, Offset<IWuWaGoRoleInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IWuWaGoRoleInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602AC76 RID: 175222 RVA: 0x005D7E42 File Offset: 0x005D6042
		public static VectorOffset CreateRoleListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IWuWaGoRoleInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IWuWaGoRoleInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602AC77 RID: 175223 RVA: 0x005D7E60 File Offset: 0x005D6060
		public static VectorOffset CreateRoleListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IWuWaGoRoleInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602AC78 RID: 175224 RVA: 0x005D7E79 File Offset: 0x005D6079
		public static void StartRoleListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602AC79 RID: 175225 RVA: 0x005D7E84 File Offset: 0x005D6084
		public static Offset<TCsvWuWaGoLevelData> EndTCsvWuWaGoLevelData(FlatBufferBuilder builder)
		{
			return new Offset<TCsvWuWaGoLevelData>(builder.EndTable());
		}

		// Token: 0x0602AC7A RID: 175226 RVA: 0x005D7E94 File Offset: 0x005D6094
		public TCsvWuWaGoLevelDataT UnPack()
		{
			TCsvWuWaGoLevelDataT tcsvWuWaGoLevelDataT = new TCsvWuWaGoLevelDataT();
			this.UnPackTo(tcsvWuWaGoLevelDataT);
			return tcsvWuWaGoLevelDataT;
		}

		// Token: 0x0602AC7B RID: 175227 RVA: 0x005D7EB0 File Offset: 0x005D60B0
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

		// Token: 0x0602AC7C RID: 175228 RVA: 0x005D7F70 File Offset: 0x005D6170
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

		// Token: 0x040100C0 RID: 65728
		private Table __p;
	}
}
