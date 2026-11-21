using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AC8 RID: 19144
	public struct IGmConfigItem : IFlatbufferObject
	{
		// Token: 0x17008618 RID: 34328
		// (get) Token: 0x0601CD10 RID: 118032 RVA: 0x0040F193 File Offset: 0x0040D393
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CD11 RID: 118033 RVA: 0x0040F1A0 File Offset: 0x0040D3A0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CD12 RID: 118034 RVA: 0x0040F1A8 File Offset: 0x0040D3A8
		public static IGmConfigItem GetRootAsIGmConfigItem(ByteBuffer _bb)
		{
			return IGmConfigItem.GetRootAsIGmConfigItem(_bb, default(IGmConfigItem));
		}

		// Token: 0x0601CD13 RID: 118035 RVA: 0x0040F1C4 File Offset: 0x0040D3C4
		public static IGmConfigItem GetRootAsIGmConfigItem(ByteBuffer _bb, IGmConfigItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CD14 RID: 118036 RVA: 0x0040F1E1 File Offset: 0x0040D3E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CD15 RID: 118037 RVA: 0x0040F1F0 File Offset: 0x0040D3F0
		public IGmConfigItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008619 RID: 34329
		// (get) Token: 0x0601CD16 RID: 118038 RVA: 0x0040F200 File Offset: 0x0040D400
		public string CnName
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

		// Token: 0x0601CD17 RID: 118039 RVA: 0x0040F237 File Offset: 0x0040D437
		public Span<byte> GetCnNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601CD18 RID: 118040 RVA: 0x0040F246 File Offset: 0x0040D446
		public byte[] GetCnNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700861A RID: 34330
		// (get) Token: 0x0601CD19 RID: 118041 RVA: 0x0040F254 File Offset: 0x0040D454
		public EGmType GmType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EGmType.Quest;
				}
				return (EGmType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700861B RID: 34331
		// (get) Token: 0x0601CD1A RID: 118042 RVA: 0x0040F290 File Offset: 0x0040D490
		public EGmSubType GmSubType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EGmSubType.Process;
				}
				return (EGmSubType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700861C RID: 34332
		// (get) Token: 0x0601CD1B RID: 118043 RVA: 0x0040F2CC File Offset: 0x0040D4CC
		public TParseType ParseType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TParseType.Client;
				}
				return (TParseType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700861D RID: 34333
		// (get) Token: 0x0601CD1C RID: 118044 RVA: 0x0040F30C File Offset: 0x0040D50C
		public string Code
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CD1D RID: 118045 RVA: 0x0040F344 File Offset: 0x0040D544
		public Span<byte> GetCodeBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0601CD1E RID: 118046 RVA: 0x0040F354 File Offset: 0x0040D554
		public byte[] GetCodeArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700861E RID: 34334
		// (get) Token: 0x0601CD1F RID: 118047 RVA: 0x0040F364 File Offset: 0x0040D564
		public bool Hide
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700861F RID: 34335
		// (get) Token: 0x0601CD20 RID: 118048 RVA: 0x0040F3A4 File Offset: 0x0040D5A4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CD21 RID: 118049 RVA: 0x0040F3E4 File Offset: 0x0040D5E4
		public static Offset<IGmConfigItem> CreateIGmConfigItem(FlatBufferBuilder builder, StringOffset CnNameOffset = default(StringOffset), EGmType GmType = EGmType.Quest, EGmSubType GmSubType = EGmSubType.Process, TParseType ParseType = TParseType.Client, StringOffset CodeOffset = default(StringOffset), bool Hide = false, byte NullMask = 0)
		{
			builder.StartTable(7);
			IGmConfigItem.AddCode(builder, CodeOffset);
			IGmConfigItem.AddCnName(builder, CnNameOffset);
			IGmConfigItem.AddNullMask(builder, NullMask);
			IGmConfigItem.AddHide(builder, Hide);
			IGmConfigItem.AddParseType(builder, ParseType);
			IGmConfigItem.AddGmSubType(builder, GmSubType);
			IGmConfigItem.AddGmType(builder, GmType);
			return IGmConfigItem.EndIGmConfigItem(builder);
		}

		// Token: 0x0601CD22 RID: 118050 RVA: 0x0040F433 File Offset: 0x0040D633
		public static void StartIGmConfigItem(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601CD23 RID: 118051 RVA: 0x0040F43C File Offset: 0x0040D63C
		public static void AddCnName(FlatBufferBuilder builder, StringOffset cnNameOffset)
		{
			builder.AddOffset(0, cnNameOffset.Value, 0);
		}

		// Token: 0x0601CD24 RID: 118052 RVA: 0x0040F44C File Offset: 0x0040D64C
		public static void AddGmType(FlatBufferBuilder builder, EGmType gmType)
		{
			builder.AddByte(1, (byte)gmType, 0);
		}

		// Token: 0x0601CD25 RID: 118053 RVA: 0x0040F457 File Offset: 0x0040D657
		public static void AddGmSubType(FlatBufferBuilder builder, EGmSubType gmSubType)
		{
			builder.AddByte(2, (byte)gmSubType, 0);
		}

		// Token: 0x0601CD26 RID: 118054 RVA: 0x0040F462 File Offset: 0x0040D662
		public static void AddParseType(FlatBufferBuilder builder, TParseType parseType)
		{
			builder.AddByte(3, (byte)parseType, 0);
		}

		// Token: 0x0601CD27 RID: 118055 RVA: 0x0040F46D File Offset: 0x0040D66D
		public static void AddCode(FlatBufferBuilder builder, StringOffset codeOffset)
		{
			builder.AddOffset(4, codeOffset.Value, 0);
		}

		// Token: 0x0601CD28 RID: 118056 RVA: 0x0040F47D File Offset: 0x0040D67D
		public static void AddHide(FlatBufferBuilder builder, bool hide)
		{
			builder.AddBool(5, hide, false);
		}

		// Token: 0x0601CD29 RID: 118057 RVA: 0x0040F488 File Offset: 0x0040D688
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0601CD2A RID: 118058 RVA: 0x0040F493 File Offset: 0x0040D693
		public static Offset<IGmConfigItem> EndIGmConfigItem(FlatBufferBuilder builder)
		{
			return new Offset<IGmConfigItem>(builder.EndTable());
		}

		// Token: 0x0601CD2B RID: 118059 RVA: 0x0040F4A0 File Offset: 0x0040D6A0
		public IGmConfigItemT UnPack()
		{
			IGmConfigItemT gmConfigItemT = new IGmConfigItemT();
			this.UnPackTo(gmConfigItemT);
			return gmConfigItemT;
		}

		// Token: 0x0601CD2C RID: 118060 RVA: 0x0040F4BC File Offset: 0x0040D6BC
		public void UnPackTo(IGmConfigItemT _o)
		{
			_o.CnName = this.CnName;
			_o.GmType = this.GmType;
			_o.GmSubType = this.GmSubType;
			_o.ParseType = this.ParseType;
			_o.Code = this.Code;
			_o.Hide = this.Hide;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601CD2D RID: 118061 RVA: 0x0040F520 File Offset: 0x0040D720
		public static Offset<IGmConfigItem> Pack(FlatBufferBuilder builder, IGmConfigItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGmConfigItem>);
			}
			StringOffset cnNameOffset = (_o.CnName == null) ? default(StringOffset) : builder.CreateString(_o.CnName);
			StringOffset codeOffset = (_o.Code == null) ? default(StringOffset) : builder.CreateString(_o.Code);
			return IGmConfigItem.CreateIGmConfigItem(builder, cnNameOffset, _o.GmType, _o.GmSubType, _o.ParseType, codeOffset, _o.Hide, _o.NullMask);
		}

		// Token: 0x0400D244 RID: 53828
		private Table __p;
	}
}
