using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006978 RID: 27000
	public struct IInstrumentQteGameplay : IFlatbufferObject
	{
		// Token: 0x1700C83E RID: 51262
		// (get) Token: 0x0602F266 RID: 193126 RVA: 0x0066C6AE File Offset: 0x0066A8AE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F267 RID: 193127 RVA: 0x0066C6BB File Offset: 0x0066A8BB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F268 RID: 193128 RVA: 0x0066C6C4 File Offset: 0x0066A8C4
		public static IInstrumentQteGameplay GetRootAsIInstrumentQteGameplay(ByteBuffer _bb)
		{
			return IInstrumentQteGameplay.GetRootAsIInstrumentQteGameplay(_bb, default(IInstrumentQteGameplay));
		}

		// Token: 0x0602F269 RID: 193129 RVA: 0x0066C6E0 File Offset: 0x0066A8E0
		public static IInstrumentQteGameplay GetRootAsIInstrumentQteGameplay(ByteBuffer _bb, IInstrumentQteGameplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F26A RID: 193130 RVA: 0x0066C6FD File Offset: 0x0066A8FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F26B RID: 193131 RVA: 0x0066C70C File Offset: 0x0066A90C
		public IInstrumentQteGameplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C83F RID: 51263
		// (get) Token: 0x0602F26C RID: 193132 RVA: 0x0066C71C File Offset: 0x0066A91C
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

		// Token: 0x1700C840 RID: 51264
		// (get) Token: 0x0602F26D RID: 193133 RVA: 0x0066C758 File Offset: 0x0066A958
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

		// Token: 0x1700C841 RID: 51265
		// (get) Token: 0x0602F26E RID: 193134 RVA: 0x0066C794 File Offset: 0x0066A994
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

		// Token: 0x0602F26F RID: 193135 RVA: 0x0066C7D0 File Offset: 0x0066A9D0
		public static Offset<IInstrumentQteGameplay> CreateIInstrumentQteGameplay(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, EInstrumentType InstrumentType = EInstrumentType.ChineseZither, int Id = 0)
		{
			builder.StartTable(3);
			IInstrumentQteGameplay.AddId(builder, Id);
			IInstrumentQteGameplay.AddInstrumentType(builder, InstrumentType);
			IInstrumentQteGameplay.AddType(builder, Type);
			return IInstrumentQteGameplay.EndIInstrumentQteGameplay(builder);
		}

		// Token: 0x0602F270 RID: 193136 RVA: 0x0066C7F4 File Offset: 0x0066A9F4
		public static void StartIInstrumentQteGameplay(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602F271 RID: 193137 RVA: 0x0066C7FD File Offset: 0x0066A9FD
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F272 RID: 193138 RVA: 0x0066C808 File Offset: 0x0066AA08
		public static void AddInstrumentType(FlatBufferBuilder builder, EInstrumentType instrumentType)
		{
			builder.AddByte(1, (byte)instrumentType, 0);
		}

		// Token: 0x0602F273 RID: 193139 RVA: 0x0066C813 File Offset: 0x0066AA13
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(2, id, 0);
		}

		// Token: 0x0602F274 RID: 193140 RVA: 0x0066C81E File Offset: 0x0066AA1E
		public static Offset<IInstrumentQteGameplay> EndIInstrumentQteGameplay(FlatBufferBuilder builder)
		{
			return new Offset<IInstrumentQteGameplay>(builder.EndTable());
		}

		// Token: 0x0602F275 RID: 193141 RVA: 0x0066C82C File Offset: 0x0066AA2C
		public IInstrumentQteGameplayT UnPack()
		{
			IInstrumentQteGameplayT instrumentQteGameplayT = new IInstrumentQteGameplayT();
			this.UnPackTo(instrumentQteGameplayT);
			return instrumentQteGameplayT;
		}

		// Token: 0x0602F276 RID: 193142 RVA: 0x0066C847 File Offset: 0x0066AA47
		public void UnPackTo(IInstrumentQteGameplayT _o)
		{
			_o.Type = this.Type;
			_o.InstrumentType = this.InstrumentType;
			_o.Id = this.Id;
		}

		// Token: 0x0602F277 RID: 193143 RVA: 0x0066C870 File Offset: 0x0066AA70
		public static Offset<IInstrumentQteGameplay> Pack(FlatBufferBuilder builder, IInstrumentQteGameplayT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInstrumentQteGameplay>);
			}
			return IInstrumentQteGameplay.CreateIInstrumentQteGameplay(builder, _o.Type, _o.InstrumentType, _o.Id);
		}

		// Token: 0x040110FE RID: 69886
		private Table __p;
	}
}
