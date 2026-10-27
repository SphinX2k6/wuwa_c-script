using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BC4 RID: 23492
	public struct IWuWaGoLevelData : IFlatbufferObject
	{
		// Token: 0x1700B17C RID: 45436
		// (get) Token: 0x060283C1 RID: 164801 RVA: 0x0058722D File Offset: 0x0058542D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060283C2 RID: 164802 RVA: 0x0058723A File Offset: 0x0058543A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060283C3 RID: 164803 RVA: 0x00587244 File Offset: 0x00585444
		public static IWuWaGoLevelData GetRootAsIWuWaGoLevelData(ByteBuffer _bb)
		{
			return IWuWaGoLevelData.GetRootAsIWuWaGoLevelData(_bb, default(IWuWaGoLevelData));
		}

		// Token: 0x060283C4 RID: 164804 RVA: 0x00587260 File Offset: 0x00585460
		public static IWuWaGoLevelData GetRootAsIWuWaGoLevelData(ByteBuffer _bb, IWuWaGoLevelData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060283C5 RID: 164805 RVA: 0x0058727D File Offset: 0x0058547D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060283C6 RID: 164806 RVA: 0x0058728C File Offset: 0x0058548C
		public IWuWaGoLevelData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B17D RID: 45437
		// (get) Token: 0x060283C7 RID: 164807 RVA: 0x0058729C File Offset: 0x0058549C
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

		// Token: 0x060283C8 RID: 164808 RVA: 0x005872D3 File Offset: 0x005854D3
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060283C9 RID: 164809 RVA: 0x005872E2 File Offset: 0x005854E2
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x060283CA RID: 164810 RVA: 0x005872F0 File Offset: 0x005854F0
		public IWuWaGoGridData? GridDatas(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IWuWaGoGridData?(default(IWuWaGoGridData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B17E RID: 45438
		// (get) Token: 0x060283CB RID: 164811 RVA: 0x00587350 File Offset: 0x00585550
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

		// Token: 0x060283CC RID: 164812 RVA: 0x0058737C File Offset: 0x0058557C
		public IWuWaGoRoleInfo? RoleInfos(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IWuWaGoRoleInfo?(default(IWuWaGoRoleInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B17F RID: 45439
		// (get) Token: 0x060283CD RID: 164813 RVA: 0x005873DC File Offset: 0x005855DC
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

		// Token: 0x060283CE RID: 164814 RVA: 0x00587407 File Offset: 0x00585607
		public static Offset<IWuWaGoLevelData> CreateIWuWaGoLevelData(FlatBufferBuilder builder, StringOffset KeyOffset = default(StringOffset), VectorOffset GridDatasOffset = default(VectorOffset), VectorOffset RoleInfosOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IWuWaGoLevelData.AddRoleInfos(builder, RoleInfosOffset);
			IWuWaGoLevelData.AddGridDatas(builder, GridDatasOffset);
			IWuWaGoLevelData.AddKey(builder, KeyOffset);
			return IWuWaGoLevelData.EndIWuWaGoLevelData(builder);
		}

		// Token: 0x060283CF RID: 164815 RVA: 0x0058742B File Offset: 0x0058562B
		public static void StartIWuWaGoLevelData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060283D0 RID: 164816 RVA: 0x00587434 File Offset: 0x00585634
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(0, keyOffset.Value, 0);
		}

		// Token: 0x060283D1 RID: 164817 RVA: 0x00587444 File Offset: 0x00585644
		public static void AddGridDatas(FlatBufferBuilder builder, VectorOffset gridDatasOffset)
		{
			builder.AddOffset(1, gridDatasOffset.Value, 0);
		}

		// Token: 0x060283D2 RID: 164818 RVA: 0x00587454 File Offset: 0x00585654
		public static VectorOffset CreateGridDatasVector(FlatBufferBuilder builder, Offset<IWuWaGoGridData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060283D3 RID: 164819 RVA: 0x00587494 File Offset: 0x00585694
		public static VectorOffset CreateGridDatasVectorBlock(FlatBufferBuilder builder, Offset<IWuWaGoGridData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IWuWaGoGridData>>(data);
			return builder.EndVector();
		}

		// Token: 0x060283D4 RID: 164820 RVA: 0x005874AE File Offset: 0x005856AE
		public static VectorOffset CreateGridDatasVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IWuWaGoGridData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IWuWaGoGridData>>(data);
			return builder.EndVector();
		}

		// Token: 0x060283D5 RID: 164821 RVA: 0x005874CC File Offset: 0x005856CC
		public static VectorOffset CreateGridDatasVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IWuWaGoGridData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060283D6 RID: 164822 RVA: 0x005874E5 File Offset: 0x005856E5
		public static void StartGridDatasVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060283D7 RID: 164823 RVA: 0x005874F0 File Offset: 0x005856F0
		public static void AddRoleInfos(FlatBufferBuilder builder, VectorOffset roleInfosOffset)
		{
			builder.AddOffset(2, roleInfosOffset.Value, 0);
		}

		// Token: 0x060283D8 RID: 164824 RVA: 0x00587500 File Offset: 0x00585700
		public static VectorOffset CreateRoleInfosVector(FlatBufferBuilder builder, Offset<IWuWaGoRoleInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060283D9 RID: 164825 RVA: 0x00587540 File Offset: 0x00585740
		public static VectorOffset CreateRoleInfosVectorBlock(FlatBufferBuilder builder, Offset<IWuWaGoRoleInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IWuWaGoRoleInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060283DA RID: 164826 RVA: 0x0058755A File Offset: 0x0058575A
		public static VectorOffset CreateRoleInfosVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IWuWaGoRoleInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IWuWaGoRoleInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060283DB RID: 164827 RVA: 0x00587578 File Offset: 0x00585778
		public static VectorOffset CreateRoleInfosVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IWuWaGoRoleInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060283DC RID: 164828 RVA: 0x00587591 File Offset: 0x00585791
		public static void StartRoleInfosVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060283DD RID: 164829 RVA: 0x0058759C File Offset: 0x0058579C
		public static Offset<IWuWaGoLevelData> EndIWuWaGoLevelData(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoLevelData>(builder.EndTable());
		}

		// Token: 0x060283DE RID: 164830 RVA: 0x005875AC File Offset: 0x005857AC
		public IWuWaGoLevelDataT UnPack()
		{
			IWuWaGoLevelDataT wuWaGoLevelDataT = new IWuWaGoLevelDataT();
			this.UnPackTo(wuWaGoLevelDataT);
			return wuWaGoLevelDataT;
		}

		// Token: 0x060283DF RID: 164831 RVA: 0x005875C8 File Offset: 0x005857C8
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

		// Token: 0x060283E0 RID: 164832 RVA: 0x00587688 File Offset: 0x00585888
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

		// Token: 0x0400F33D RID: 62269
		private Table __p;
	}
}
