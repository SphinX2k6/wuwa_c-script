using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x0200438C RID: 17292
	public struct IAreaExportData : IFlatbufferObject
	{
		// Token: 0x17007A36 RID: 31286
		// (get) Token: 0x06019B8D RID: 105357 RVA: 0x003AF0BE File Offset: 0x003AD2BE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019B8E RID: 105358 RVA: 0x003AF0CB File Offset: 0x003AD2CB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019B8F RID: 105359 RVA: 0x003AF0D4 File Offset: 0x003AD2D4
		public static IAreaExportData GetRootAsIAreaExportData(ByteBuffer _bb)
		{
			return IAreaExportData.GetRootAsIAreaExportData(_bb, default(IAreaExportData));
		}

		// Token: 0x06019B90 RID: 105360 RVA: 0x003AF0F0 File Offset: 0x003AD2F0
		public static IAreaExportData GetRootAsIAreaExportData(ByteBuffer _bb, IAreaExportData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019B91 RID: 105361 RVA: 0x003AF10D File Offset: 0x003AD30D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019B92 RID: 105362 RVA: 0x003AF11C File Offset: 0x003AD31C
		public IAreaExportData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007A37 RID: 31287
		// (get) Token: 0x06019B93 RID: 105363 RVA: 0x003AF12C File Offset: 0x003AD32C
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

		// Token: 0x06019B94 RID: 105364 RVA: 0x003AF163 File Offset: 0x003AD363
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06019B95 RID: 105365 RVA: 0x003AF172 File Offset: 0x003AD372
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17007A38 RID: 31288
		// (get) Token: 0x06019B96 RID: 105366 RVA: 0x003AF180 File Offset: 0x003AD380
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

		// Token: 0x06019B97 RID: 105367 RVA: 0x003AF1B7 File Offset: 0x003AD3B7
		public Span<byte> GetNameStringKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06019B98 RID: 105368 RVA: 0x003AF1C6 File Offset: 0x003AD3C6
		public byte[] GetNameStringKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17007A39 RID: 31289
		// (get) Token: 0x06019B99 RID: 105369 RVA: 0x003AF1D4 File Offset: 0x003AD3D4
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

		// Token: 0x06019B9A RID: 105370 RVA: 0x003AF20B File Offset: 0x003AD40B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06019B9B RID: 105371 RVA: 0x003AF21A File Offset: 0x003AD41A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17007A3A RID: 31290
		// (get) Token: 0x06019B9C RID: 105372 RVA: 0x003AF228 File Offset: 0x003AD428
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

		// Token: 0x06019B9D RID: 105373 RVA: 0x003AF286 File Offset: 0x003AD486
		public static Offset<IAreaExportData> CreateIAreaExportData(FlatBufferBuilder builder, StringOffset IdOffset = default(StringOffset), StringOffset NameStringKeyOffset = default(StringOffset), StringOffset NameOffset = default(StringOffset), Offset<IAreaOccupationData> DataOffset = default(Offset<IAreaOccupationData>))
		{
			builder.StartTable(4);
			IAreaExportData.AddData(builder, DataOffset);
			IAreaExportData.AddName(builder, NameOffset);
			IAreaExportData.AddNameStringKey(builder, NameStringKeyOffset);
			IAreaExportData.AddId(builder, IdOffset);
			return IAreaExportData.EndIAreaExportData(builder);
		}

		// Token: 0x06019B9E RID: 105374 RVA: 0x003AF2B2 File Offset: 0x003AD4B2
		public static void StartIAreaExportData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06019B9F RID: 105375 RVA: 0x003AF2BB File Offset: 0x003AD4BB
		public static void AddId(FlatBufferBuilder builder, StringOffset idOffset)
		{
			builder.AddOffset(0, idOffset.Value, 0);
		}

		// Token: 0x06019BA0 RID: 105376 RVA: 0x003AF2CB File Offset: 0x003AD4CB
		public static void AddNameStringKey(FlatBufferBuilder builder, StringOffset nameStringKeyOffset)
		{
			builder.AddOffset(1, nameStringKeyOffset.Value, 0);
		}

		// Token: 0x06019BA1 RID: 105377 RVA: 0x003AF2DB File Offset: 0x003AD4DB
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(2, nameOffset.Value, 0);
		}

		// Token: 0x06019BA2 RID: 105378 RVA: 0x003AF2EB File Offset: 0x003AD4EB
		public static void AddData(FlatBufferBuilder builder, Offset<IAreaOccupationData> dataOffset)
		{
			builder.AddOffset(3, dataOffset.Value, 0);
		}

		// Token: 0x06019BA3 RID: 105379 RVA: 0x003AF2FB File Offset: 0x003AD4FB
		public static Offset<IAreaExportData> EndIAreaExportData(FlatBufferBuilder builder)
		{
			return new Offset<IAreaExportData>(builder.EndTable());
		}

		// Token: 0x06019BA4 RID: 105380 RVA: 0x003AF308 File Offset: 0x003AD508
		public IAreaExportDataT UnPack()
		{
			IAreaExportDataT areaExportDataT = new IAreaExportDataT();
			this.UnPackTo(areaExportDataT);
			return areaExportDataT;
		}

		// Token: 0x06019BA5 RID: 105381 RVA: 0x003AF324 File Offset: 0x003AD524
		public void UnPackTo(IAreaExportDataT _o)
		{
			_o.Id = this.Id;
			_o.NameStringKey = this.NameStringKey;
			_o.Name = this.Name;
			_o.Data = ((this.Data != null) ? this.Data.Value.UnPack() : null);
		}

		// Token: 0x06019BA6 RID: 105382 RVA: 0x003AF384 File Offset: 0x003AD584
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

		// Token: 0x0400C1BD RID: 49597
		private Table __p;
	}
}
