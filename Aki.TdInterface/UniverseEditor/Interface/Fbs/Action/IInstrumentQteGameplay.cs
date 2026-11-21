using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200702B RID: 28715
	public struct IInstrumentQteGameplay : IFlatbufferObject
	{
		// Token: 0x1700D241 RID: 53825
		// (get) Token: 0x06031C36 RID: 203830 RVA: 0x006BCB96 File Offset: 0x006BAD96
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031C37 RID: 203831 RVA: 0x006BCBA3 File Offset: 0x006BADA3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031C38 RID: 203832 RVA: 0x006BCBAC File Offset: 0x006BADAC
		public static IInstrumentQteGameplay GetRootAsIInstrumentQteGameplay(ByteBuffer _bb)
		{
			return IInstrumentQteGameplay.GetRootAsIInstrumentQteGameplay(_bb, default(IInstrumentQteGameplay));
		}

		// Token: 0x06031C39 RID: 203833 RVA: 0x006BCBC8 File Offset: 0x006BADC8
		public static IInstrumentQteGameplay GetRootAsIInstrumentQteGameplay(ByteBuffer _bb, IInstrumentQteGameplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031C3A RID: 203834 RVA: 0x006BCBE5 File Offset: 0x006BADE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031C3B RID: 203835 RVA: 0x006BCBF4 File Offset: 0x006BADF4
		public IInstrumentQteGameplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D242 RID: 53826
		// (get) Token: 0x06031C3C RID: 203836 RVA: 0x006BCC04 File Offset: 0x006BAE04
		public ESimpleGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESimpleGameplayType.Cipher;
				}
				return (ESimpleGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D243 RID: 53827
		// (get) Token: 0x06031C3D RID: 203837 RVA: 0x006BCC40 File Offset: 0x006BAE40
		public EInstrumentType InstrumentType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EInstrumentType.ChineseZither;
				}
				return (EInstrumentType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D244 RID: 53828
		// (get) Token: 0x06031C3E RID: 203838 RVA: 0x006BCC7C File Offset: 0x006BAE7C
		public int Id
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031C3F RID: 203839 RVA: 0x006BCCB8 File Offset: 0x006BAEB8
		public static Offset<IInstrumentQteGameplay> CreateIInstrumentQteGameplay(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, EInstrumentType InstrumentType = EInstrumentType.ChineseZither, int Id = 0)
		{
			builder.StartTable(3);
			IInstrumentQteGameplay.AddId(builder, Id);
			IInstrumentQteGameplay.AddInstrumentType(builder, InstrumentType);
			IInstrumentQteGameplay.AddType(builder, Type);
			return IInstrumentQteGameplay.EndIInstrumentQteGameplay(builder);
		}

		// Token: 0x06031C40 RID: 203840 RVA: 0x006BCCDC File Offset: 0x006BAEDC
		public static void StartIInstrumentQteGameplay(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06031C41 RID: 203841 RVA: 0x006BCCE5 File Offset: 0x006BAEE5
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031C42 RID: 203842 RVA: 0x006BCCF0 File Offset: 0x006BAEF0
		public static void AddInstrumentType(FlatBufferBuilder builder, EInstrumentType instrumentType)
		{
			builder.AddByte(1, (byte)instrumentType, 0);
		}

		// Token: 0x06031C43 RID: 203843 RVA: 0x006BCCFB File Offset: 0x006BAEFB
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(2, id, 0);
		}

		// Token: 0x06031C44 RID: 203844 RVA: 0x006BCD06 File Offset: 0x006BAF06
		public static Offset<IInstrumentQteGameplay> EndIInstrumentQteGameplay(FlatBufferBuilder builder)
		{
			return new Offset<IInstrumentQteGameplay>(builder.EndTable());
		}

		// Token: 0x06031C45 RID: 203845 RVA: 0x006BCD14 File Offset: 0x006BAF14
		public IInstrumentQteGameplayT UnPack()
		{
			IInstrumentQteGameplayT instrumentQteGameplayT = new IInstrumentQteGameplayT();
			this.UnPackTo(instrumentQteGameplayT);
			return instrumentQteGameplayT;
		}

		// Token: 0x06031C46 RID: 203846 RVA: 0x006BCD2F File Offset: 0x006BAF2F
		public void UnPackTo(IInstrumentQteGameplayT _o)
		{
			_o.Type = this.Type;
			_o.InstrumentType = this.InstrumentType;
			_o.Id = this.Id;
		}

		// Token: 0x06031C47 RID: 203847 RVA: 0x006BCD58 File Offset: 0x006BAF58
		public static Offset<IInstrumentQteGameplay> Pack(FlatBufferBuilder builder, IInstrumentQteGameplayT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInstrumentQteGameplay>);
			}
			return IInstrumentQteGameplay.CreateIInstrumentQteGameplay(builder, _o.Type, _o.InstrumentType, _o.Id);
		}

		// Token: 0x04011F6A RID: 73578
		private Table __p;
	}
}
