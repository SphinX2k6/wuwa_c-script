using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061DA RID: 25050
	public struct IWuWaGoLevelData : IFlatbufferObject
	{
		// Token: 0x1700BAC4 RID: 47812
		// (get) Token: 0x0602A985 RID: 174469 RVA: 0x005CECBD File Offset: 0x005CCEBD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A986 RID: 174470 RVA: 0x005CECCA File Offset: 0x005CCECA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A987 RID: 174471 RVA: 0x005CECD4 File Offset: 0x005CCED4
		public static IWuWaGoLevelData GetRootAsIWuWaGoLevelData(ByteBuffer _bb)
		{
			return IWuWaGoLevelData.GetRootAsIWuWaGoLevelData(_bb, default(IWuWaGoLevelData));
		}

		// Token: 0x0602A988 RID: 174472 RVA: 0x005CECF0 File Offset: 0x005CCEF0
		public static IWuWaGoLevelData GetRootAsIWuWaGoLevelData(ByteBuffer _bb, IWuWaGoLevelData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A989 RID: 174473 RVA: 0x005CED0D File Offset: 0x005CCF0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A98A RID: 174474 RVA: 0x005CED1C File Offset: 0x005CCF1C
		public IWuWaGoLevelData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BAC5 RID: 47813
		// (get) Token: 0x0602A98B RID: 174475 RVA: 0x005CED2C File Offset: 0x005CCF2C
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

		// Token: 0x0602A98C RID: 174476 RVA: 0x005CED63 File Offset: 0x005CCF63
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602A98D RID: 174477 RVA: 0x005CED72 File Offset: 0x005CCF72
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0602A98E RID: 174478 RVA: 0x005CED80 File Offset: 0x005CCF80
		public IWuWaGoGridData? GridDatas(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IWuWaGoGridData?(default(IWuWaGoGridData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700BAC6 RID: 47814
		// (get) Token: 0x0602A98F RID: 174479 RVA: 0x005CEDE0 File Offset: 0x005CCFE0
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

		// Token: 0x0602A990 RID: 174480 RVA: 0x005CEE0C File Offset: 0x005CD00C
		public IWuWaGoRoleInfo? RoleInfos(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IWuWaGoRoleInfo?(default(IWuWaGoRoleInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700BAC7 RID: 47815
		// (get) Token: 0x0602A991 RID: 174481 RVA: 0x005CEE6C File Offset: 0x005CD06C
		public int RoleInfosLength
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

		// Token: 0x0602A992 RID: 174482 RVA: 0x005CEE97 File Offset: 0x005CD097
		public static Offset<IWuWaGoLevelData> CreateIWuWaGoLevelData(FlatBufferBuilder builder, StringOffset KeyOffset = default(StringOffset), VectorOffset GridDatasOffset = default(VectorOffset), VectorOffset RoleInfosOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IWuWaGoLevelData.AddRoleInfos(builder, RoleInfosOffset);
			IWuWaGoLevelData.AddGridDatas(builder, GridDatasOffset);
			IWuWaGoLevelData.AddKey(builder, KeyOffset);
			return IWuWaGoLevelData.EndIWuWaGoLevelData(builder);
		}

		// Token: 0x0602A993 RID: 174483 RVA: 0x005CEEBB File Offset: 0x005CD0BB
		public static void StartIWuWaGoLevelData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602A994 RID: 174484 RVA: 0x005CEEC4 File Offset: 0x005CD0C4
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(0, keyOffset.Value, 0);
		}

		// Token: 0x0602A995 RID: 174485 RVA: 0x005CEED4 File Offset: 0x005CD0D4
		public static void AddGridDatas(FlatBufferBuilder builder, VectorOffset gridDatasOffset)
		{
			builder.AddOffset(1, gridDatasOffset.Value, 0);
		}

		// Token: 0x0602A996 RID: 174486 RVA: 0x005CEEE4 File Offset: 0x005CD0E4
		public static VectorOffset CreateGridDatasVector(FlatBufferBuilder builder, Offset<IWuWaGoGridData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A997 RID: 174487 RVA: 0x005CEF24 File Offset: 0x005CD124
		public static VectorOffset CreateGridDatasVectorBlock(FlatBufferBuilder builder, Offset<IWuWaGoGridData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IWuWaGoGridData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A998 RID: 174488 RVA: 0x005CEF3E File Offset: 0x005CD13E
		public static VectorOffset CreateGridDatasVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IWuWaGoGridData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IWuWaGoGridData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A999 RID: 174489 RVA: 0x005CEF5C File Offset: 0x005CD15C
		public static VectorOffset CreateGridDatasVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IWuWaGoGridData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A99A RID: 174490 RVA: 0x005CEF75 File Offset: 0x005CD175
		public static void StartGridDatasVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A99B RID: 174491 RVA: 0x005CEF80 File Offset: 0x005CD180
		public static void AddRoleInfos(FlatBufferBuilder builder, VectorOffset roleInfosOffset)
		{
			builder.AddOffset(2, roleInfosOffset.Value, 0);
		}

		// Token: 0x0602A99C RID: 174492 RVA: 0x005CEF90 File Offset: 0x005CD190
		public static VectorOffset CreateRoleInfosVector(FlatBufferBuilder builder, Offset<IWuWaGoRoleInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A99D RID: 174493 RVA: 0x005CEFD0 File Offset: 0x005CD1D0
		public static VectorOffset CreateRoleInfosVectorBlock(FlatBufferBuilder builder, Offset<IWuWaGoRoleInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IWuWaGoRoleInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A99E RID: 174494 RVA: 0x005CEFEA File Offset: 0x005CD1EA
		public static VectorOffset CreateRoleInfosVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IWuWaGoRoleInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IWuWaGoRoleInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A99F RID: 174495 RVA: 0x005CF008 File Offset: 0x005CD208
		public static VectorOffset CreateRoleInfosVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IWuWaGoRoleInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A9A0 RID: 174496 RVA: 0x005CF021 File Offset: 0x005CD221
		public static void StartRoleInfosVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A9A1 RID: 174497 RVA: 0x005CF02C File Offset: 0x005CD22C
		public static Offset<IWuWaGoLevelData> EndIWuWaGoLevelData(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoLevelData>(builder.EndTable());
		}

		// Token: 0x0602A9A2 RID: 174498 RVA: 0x005CF03C File Offset: 0x005CD23C
		public IWuWaGoLevelDataT UnPack()
		{
			IWuWaGoLevelDataT wuWaGoLevelDataT = new IWuWaGoLevelDataT();
			this.UnPackTo(wuWaGoLevelDataT);
			return wuWaGoLevelDataT;
		}

		// Token: 0x0602A9A3 RID: 174499 RVA: 0x005CF058 File Offset: 0x005CD258
		public void UnPackTo(IWuWaGoLevelDataT _o)
		{
			_o.Key = this.Key;
			_o.GridDatas = new List<IWuWaGoGridDataT>();
			for (int i = 0; i < this.GridDatasLength; i++)
			{
				_o.GridDatas.Add((this.GridDatas(i) != null) ? this.GridDatas(i).Value.UnPack() : null);
			}
			_o.RoleInfos = new List<IWuWaGoRoleInfoT>();
			for (int j = 0; j < this.RoleInfosLength; j++)
			{
				_o.RoleInfos.Add((this.RoleInfos(j) != null) ? this.RoleInfos(j).Value.UnPack() : null);
			}
		}

		// Token: 0x0602A9A4 RID: 174500 RVA: 0x005CF118 File Offset: 0x005CD318
		public static Offset<IWuWaGoLevelData> Pack(FlatBufferBuilder builder, IWuWaGoLevelDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWuWaGoLevelData>);
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
				gridDatasOffset = IWuWaGoLevelData.CreateGridDatasVector(builder, array);
			}
			VectorOffset roleInfosOffset = default(VectorOffset);
			if (_o.RoleInfos != null)
			{
				Offset<IWuWaGoRoleInfo>[] array2 = new Offset<IWuWaGoRoleInfo>[_o.RoleInfos.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IWuWaGoRoleInfo.Pack(builder, _o.RoleInfos[j]);
				}
				roleInfosOffset = IWuWaGoLevelData.CreateRoleInfosVector(builder, array2);
			}
			return IWuWaGoLevelData.CreateIWuWaGoLevelData(builder, keyOffset, gridDatasOffset, roleInfosOffset);
		}

		// Token: 0x04010043 RID: 65603
		private Table __p;
	}
}
