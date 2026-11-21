using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020047EE RID: 18414
	public struct IAreaExportData : IFlatbufferObject
	{
		// Token: 0x1700806B RID: 32875
		// (get) Token: 0x0601B31B RID: 111387 RVA: 0x003DAAE6 File Offset: 0x003D8CE6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B31C RID: 111388 RVA: 0x003DAAF3 File Offset: 0x003D8CF3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B31D RID: 111389 RVA: 0x003DAAFC File Offset: 0x003D8CFC
		public static IAreaExportData GetRootAsIAreaExportData(ByteBuffer _bb)
		{
			return IAreaExportData.GetRootAsIAreaExportData(_bb, default(IAreaExportData));
		}

		// Token: 0x0601B31E RID: 111390 RVA: 0x003DAB18 File Offset: 0x003D8D18
		public static IAreaExportData GetRootAsIAreaExportData(ByteBuffer _bb, IAreaExportData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B31F RID: 111391 RVA: 0x003DAB35 File Offset: 0x003D8D35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B320 RID: 111392 RVA: 0x003DAB44 File Offset: 0x003D8D44
		public IAreaExportData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700806C RID: 32876
		// (get) Token: 0x0601B321 RID: 111393 RVA: 0x003DAB54 File Offset: 0x003D8D54
		public string Id
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

		// Token: 0x0601B322 RID: 111394 RVA: 0x003DAB8B File Offset: 0x003D8D8B
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601B323 RID: 111395 RVA: 0x003DAB9A File Offset: 0x003D8D9A
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700806D RID: 32877
		// (get) Token: 0x0601B324 RID: 111396 RVA: 0x003DABA8 File Offset: 0x003D8DA8
		public string NameStringKey
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B325 RID: 111397 RVA: 0x003DABDF File Offset: 0x003D8DDF
		public Span<byte> GetNameStringKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601B326 RID: 111398 RVA: 0x003DABEE File Offset: 0x003D8DEE
		public byte[] GetNameStringKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700806E RID: 32878
		// (get) Token: 0x0601B327 RID: 111399 RVA: 0x003DABFC File Offset: 0x003D8DFC
		public string Name
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B328 RID: 111400 RVA: 0x003DAC33 File Offset: 0x003D8E33
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601B329 RID: 111401 RVA: 0x003DAC42 File Offset: 0x003D8E42
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700806F RID: 32879
		// (get) Token: 0x0601B32A RID: 111402 RVA: 0x003DAC50 File Offset: 0x003D8E50
		public IAreaOccupationData? Data
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IAreaOccupationData?(default(IAreaOccupationData).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601B32B RID: 111403 RVA: 0x003DACAE File Offset: 0x003D8EAE
		public static Offset<IAreaExportData> CreateIAreaExportData(FlatBufferBuilder builder, StringOffset IdOffset = default(StringOffset), StringOffset NameStringKeyOffset = default(StringOffset), StringOffset NameOffset = default(StringOffset), Offset<IAreaOccupationData> DataOffset = default(Offset<IAreaOccupationData>))
		{
			builder.StartTable(4);
			IAreaExportData.AddData(builder, DataOffset);
			IAreaExportData.AddName(builder, NameOffset);
			IAreaExportData.AddNameStringKey(builder, NameStringKeyOffset);
			IAreaExportData.AddId(builder, IdOffset);
			return IAreaExportData.EndIAreaExportData(builder);
		}

		// Token: 0x0601B32C RID: 111404 RVA: 0x003DACDA File Offset: 0x003D8EDA
		public static void StartIAreaExportData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601B32D RID: 111405 RVA: 0x003DACE3 File Offset: 0x003D8EE3
		public static void AddId(FlatBufferBuilder builder, StringOffset idOffset)
		{
			builder.AddOffset(0, idOffset.Value, 0);
		}

		// Token: 0x0601B32E RID: 111406 RVA: 0x003DACF3 File Offset: 0x003D8EF3
		public static void AddNameStringKey(FlatBufferBuilder builder, StringOffset nameStringKeyOffset)
		{
			builder.AddOffset(1, nameStringKeyOffset.Value, 0);
		}

		// Token: 0x0601B32F RID: 111407 RVA: 0x003DAD03 File Offset: 0x003D8F03
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(2, nameOffset.Value, 0);
		}

		// Token: 0x0601B330 RID: 111408 RVA: 0x003DAD13 File Offset: 0x003D8F13
		public static void AddData(FlatBufferBuilder builder, Offset<IAreaOccupationData> dataOffset)
		{
			builder.AddOffset(3, dataOffset.Value, 0);
		}

		// Token: 0x0601B331 RID: 111409 RVA: 0x003DAD23 File Offset: 0x003D8F23
		public static Offset<IAreaExportData> EndIAreaExportData(FlatBufferBuilder builder)
		{
			return new Offset<IAreaExportData>(builder.EndTable());
		}

		// Token: 0x0601B332 RID: 111410 RVA: 0x003DAD30 File Offset: 0x003D8F30
		public IAreaExportDataT UnPack()
		{
			IAreaExportDataT areaExportDataT = new IAreaExportDataT();
			this.UnPackTo(areaExportDataT);
			return areaExportDataT;
		}

		// Token: 0x0601B333 RID: 111411 RVA: 0x003DAD4C File Offset: 0x003D8F4C
		public void UnPackTo(IAreaExportDataT _o)
		{
			_o.Id = this.Id;
			_o.NameStringKey = this.NameStringKey;
			_o.Name = this.Name;
			_o.Data = ((this.Data != null) ? this.Data.Value.UnPack() : null);
		}

		// Token: 0x0601B334 RID: 111412 RVA: 0x003DADAC File Offset: 0x003D8FAC
		public static Offset<IAreaExportData> Pack(FlatBufferBuilder builder, IAreaExportDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAreaExportData>);
			}
			StringOffset idOffset = (_o.Id == null) ? default(StringOffset) : builder.CreateString(_o.Id);
			StringOffset nameStringKeyOffset = (_o.NameStringKey == null) ? default(StringOffset) : builder.CreateString(_o.NameStringKey);
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			Offset<IAreaOccupationData> dataOffset = (_o.Data == null) ? default(Offset<IAreaOccupationData>) : IAreaOccupationData.Pack(builder, _o.Data);
			return IAreaExportData.CreateIAreaExportData(builder, idOffset, nameStringKeyOffset, nameOffset, dataOffset);
		}

		// Token: 0x0400CBDC RID: 52188
		private Table __p;
	}
}
