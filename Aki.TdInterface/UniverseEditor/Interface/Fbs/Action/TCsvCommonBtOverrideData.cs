using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007698 RID: 30360
	public struct TCsvCommonBtOverrideData : IFlatbufferObject
	{
		// Token: 0x1700E5F9 RID: 58873
		// (get) Token: 0x060373D8 RID: 226264 RVA: 0x0077C6EA File Offset: 0x0077A8EA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060373D9 RID: 226265 RVA: 0x0077C6F7 File Offset: 0x0077A8F7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060373DA RID: 226266 RVA: 0x0077C700 File Offset: 0x0077A900
		public static TCsvCommonBtOverrideData GetRootAsTCsvCommonBtOverrideData(ByteBuffer _bb)
		{
			return TCsvCommonBtOverrideData.GetRootAsTCsvCommonBtOverrideData(_bb, default(TCsvCommonBtOverrideData));
		}

		// Token: 0x060373DB RID: 226267 RVA: 0x0077C71C File Offset: 0x0077A91C
		public static TCsvCommonBtOverrideData GetRootAsTCsvCommonBtOverrideData(ByteBuffer _bb, TCsvCommonBtOverrideData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060373DC RID: 226268 RVA: 0x0077C739 File Offset: 0x0077A939
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060373DD RID: 226269 RVA: 0x0077C748 File Offset: 0x0077A948
		public TCsvCommonBtOverrideData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E5FA RID: 58874
		// (get) Token: 0x060373DE RID: 226270 RVA: 0x0077C758 File Offset: 0x0077A958
		public int Id
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

		// Token: 0x1700E5FB RID: 58875
		// (get) Token: 0x060373DF RID: 226271 RVA: 0x0077C794 File Offset: 0x0077A994
		public ICommonBtOverride? Data
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ICommonBtOverride?(default(ICommonBtOverride).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060373E0 RID: 226272 RVA: 0x0077C7F1 File Offset: 0x0077A9F1
		public static Offset<TCsvCommonBtOverrideData> CreateTCsvCommonBtOverrideData(FlatBufferBuilder builder, int Id = 0, Offset<ICommonBtOverride> DataOffset = default(Offset<ICommonBtOverride>))
		{
			builder.StartTable(2);
			TCsvCommonBtOverrideData.AddData(builder, DataOffset);
			TCsvCommonBtOverrideData.AddId(builder, Id);
			return TCsvCommonBtOverrideData.EndTCsvCommonBtOverrideData(builder);
		}

		// Token: 0x060373E1 RID: 226273 RVA: 0x0077C80E File Offset: 0x0077AA0E
		public static void StartTCsvCommonBtOverrideData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060373E2 RID: 226274 RVA: 0x0077C817 File Offset: 0x0077AA17
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x060373E3 RID: 226275 RVA: 0x0077C822 File Offset: 0x0077AA22
		public static void AddData(FlatBufferBuilder builder, Offset<ICommonBtOverride> dataOffset)
		{
			builder.AddOffset(1, dataOffset.Value, 0);
		}

		// Token: 0x060373E4 RID: 226276 RVA: 0x0077C832 File Offset: 0x0077AA32
		public static Offset<TCsvCommonBtOverrideData> EndTCsvCommonBtOverrideData(FlatBufferBuilder builder)
		{
			return new Offset<TCsvCommonBtOverrideData>(builder.EndTable());
		}

		// Token: 0x060373E5 RID: 226277 RVA: 0x0077C840 File Offset: 0x0077AA40
		public TCsvCommonBtOverrideDataT UnPack()
		{
			TCsvCommonBtOverrideDataT tcsvCommonBtOverrideDataT = new TCsvCommonBtOverrideDataT();
			this.UnPackTo(tcsvCommonBtOverrideDataT);
			return tcsvCommonBtOverrideDataT;
		}

		// Token: 0x060373E6 RID: 226278 RVA: 0x0077C85C File Offset: 0x0077AA5C
		public void UnPackTo(TCsvCommonBtOverrideDataT _o)
		{
			_o.Id = this.Id;
			_o.Data = ((this.Data != null) ? this.Data.Value.UnPack() : null);
		}

		// Token: 0x060373E7 RID: 226279 RVA: 0x0077C8A4 File Offset: 0x0077AAA4
		public static Offset<TCsvCommonBtOverrideData> Pack(FlatBufferBuilder builder, TCsvCommonBtOverrideDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<TCsvCommonBtOverrideData>);
			}
			Offset<ICommonBtOverride> dataOffset = (_o.Data == null) ? default(Offset<ICommonBtOverride>) : ICommonBtOverride.Pack(builder, _o.Data);
			return TCsvCommonBtOverrideData.CreateTCsvCommonBtOverrideData(builder, _o.Id, dataOffset);
		}

		// Token: 0x040126C4 RID: 75460
		private Table __p;
	}
}
