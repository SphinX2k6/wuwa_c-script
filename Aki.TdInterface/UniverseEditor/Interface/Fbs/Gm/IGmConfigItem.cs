using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004660 RID: 18016
	public struct IGmConfigItem : IFlatbufferObject
	{
		// Token: 0x17007FD7 RID: 32727
		// (get) Token: 0x0601B53B RID: 111931 RVA: 0x003E2EF7 File Offset: 0x003E10F7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B53C RID: 111932 RVA: 0x003E2F04 File Offset: 0x003E1104
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B53D RID: 111933 RVA: 0x003E2F0C File Offset: 0x003E110C
		public static IGmConfigItem GetRootAsIGmConfigItem(ByteBuffer _bb)
		{
			return IGmConfigItem.GetRootAsIGmConfigItem(_bb, default(IGmConfigItem));
		}

		// Token: 0x0601B53E RID: 111934 RVA: 0x003E2F28 File Offset: 0x003E1128
		public static IGmConfigItem GetRootAsIGmConfigItem(ByteBuffer _bb, IGmConfigItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B53F RID: 111935 RVA: 0x003E2F45 File Offset: 0x003E1145
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B540 RID: 111936 RVA: 0x003E2F54 File Offset: 0x003E1154
		public IGmConfigItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007FD8 RID: 32728
		// (get) Token: 0x0601B541 RID: 111937 RVA: 0x003E2F64 File Offset: 0x003E1164
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

		// Token: 0x0601B542 RID: 111938 RVA: 0x003E2F9B File Offset: 0x003E119B
		public Span<byte> GetCnNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601B543 RID: 111939 RVA: 0x003E2FAA File Offset: 0x003E11AA
		public byte[] GetCnNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17007FD9 RID: 32729
		// (get) Token: 0x0601B544 RID: 111940 RVA: 0x003E2FB8 File Offset: 0x003E11B8
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

		// Token: 0x17007FDA RID: 32730
		// (get) Token: 0x0601B545 RID: 111941 RVA: 0x003E2FF4 File Offset: 0x003E11F4
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

		// Token: 0x17007FDB RID: 32731
		// (get) Token: 0x0601B546 RID: 111942 RVA: 0x003E3030 File Offset: 0x003E1230
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

		// Token: 0x17007FDC RID: 32732
		// (get) Token: 0x0601B547 RID: 111943 RVA: 0x003E3070 File Offset: 0x003E1270
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

		// Token: 0x0601B548 RID: 111944 RVA: 0x003E30A8 File Offset: 0x003E12A8
		public Span<byte> GetCodeBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0601B549 RID: 111945 RVA: 0x003E30B8 File Offset: 0x003E12B8
		public byte[] GetCodeArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x17007FDD RID: 32733
		// (get) Token: 0x0601B54A RID: 111946 RVA: 0x003E30C8 File Offset: 0x003E12C8
		public bool Hide
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007FDE RID: 32734
		// (get) Token: 0x0601B54B RID: 111947 RVA: 0x003E3108 File Offset: 0x003E1308
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

		// Token: 0x0601B54C RID: 111948 RVA: 0x003E3148 File Offset: 0x003E1348
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

		// Token: 0x0601B54D RID: 111949 RVA: 0x003E3197 File Offset: 0x003E1397
		public static void StartIGmConfigItem(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601B54E RID: 111950 RVA: 0x003E31A0 File Offset: 0x003E13A0
		public static void AddCnName(FlatBufferBuilder builder, StringOffset cnNameOffset)
		{
			builder.AddOffset(0, cnNameOffset.Value, 0);
		}

		// Token: 0x0601B54F RID: 111951 RVA: 0x003E31B0 File Offset: 0x003E13B0
		public static void AddGmType(FlatBufferBuilder builder, EGmType gmType)
		{
			builder.AddByte(1, (byte)gmType, 0);
		}

		// Token: 0x0601B550 RID: 111952 RVA: 0x003E31BB File Offset: 0x003E13BB
		public static void AddGmSubType(FlatBufferBuilder builder, EGmSubType gmSubType)
		{
			builder.AddByte(2, (byte)gmSubType, 0);
		}

		// Token: 0x0601B551 RID: 111953 RVA: 0x003E31C6 File Offset: 0x003E13C6
		public static void AddParseType(FlatBufferBuilder builder, TParseType parseType)
		{
			builder.AddByte(3, (byte)parseType, 0);
		}

		// Token: 0x0601B552 RID: 111954 RVA: 0x003E31D1 File Offset: 0x003E13D1
		public static void AddCode(FlatBufferBuilder builder, StringOffset codeOffset)
		{
			builder.AddOffset(4, codeOffset.Value, 0);
		}

		// Token: 0x0601B553 RID: 111955 RVA: 0x003E31E1 File Offset: 0x003E13E1
		public static void AddHide(FlatBufferBuilder builder, bool hide)
		{
			builder.AddBool(5, hide, false);
		}

		// Token: 0x0601B554 RID: 111956 RVA: 0x003E31EC File Offset: 0x003E13EC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0601B555 RID: 111957 RVA: 0x003E31F7 File Offset: 0x003E13F7
		public static Offset<IGmConfigItem> EndIGmConfigItem(FlatBufferBuilder builder)
		{
			return new Offset<IGmConfigItem>(builder.EndTable());
		}

		// Token: 0x0601B556 RID: 111958 RVA: 0x003E3204 File Offset: 0x003E1404
		public IGmConfigItemT UnPack()
		{
			IGmConfigItemT gmConfigItemT = new IGmConfigItemT();
			this.UnPackTo(gmConfigItemT);
			return gmConfigItemT;
		}

		// Token: 0x0601B557 RID: 111959 RVA: 0x003E3220 File Offset: 0x003E1420
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

		// Token: 0x0601B558 RID: 111960 RVA: 0x003E3284 File Offset: 0x003E1484
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

		// Token: 0x0400C815 RID: 51221
		private Table __p;
	}
}
