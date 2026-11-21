using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078D5 RID: 30933
	public struct ISignalBreakGameplay : IFlatbufferObject
	{
		// Token: 0x1700E2FD RID: 58109
		// (get) Token: 0x06036767 RID: 223079 RVA: 0x0074AD0B File Offset: 0x00748F0B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036768 RID: 223080 RVA: 0x0074AD18 File Offset: 0x00748F18
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036769 RID: 223081 RVA: 0x0074AD20 File Offset: 0x00748F20
		public static ISignalBreakGameplay GetRootAsISignalBreakGameplay(ByteBuffer _bb)
		{
			return ISignalBreakGameplay.GetRootAsISignalBreakGameplay(_bb, default(ISignalBreakGameplay));
		}

		// Token: 0x0603676A RID: 223082 RVA: 0x0074AD3C File Offset: 0x00748F3C
		public static ISignalBreakGameplay GetRootAsISignalBreakGameplay(ByteBuffer _bb, ISignalBreakGameplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603676B RID: 223083 RVA: 0x0074AD59 File Offset: 0x00748F59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603676C RID: 223084 RVA: 0x0074AD68 File Offset: 0x00748F68
		public ISignalBreakGameplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E2FE RID: 58110
		// (get) Token: 0x0603676D RID: 223085 RVA: 0x0074AD78 File Offset: 0x00748F78
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

		// Token: 0x1700E2FF RID: 58111
		// (get) Token: 0x0603676E RID: 223086 RVA: 0x0074ADB4 File Offset: 0x00748FB4
		public string SignalBreakId
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

		// Token: 0x0603676F RID: 223087 RVA: 0x0074ADEB File Offset: 0x00748FEB
		public Span<byte> GetSignalBreakIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06036770 RID: 223088 RVA: 0x0074ADFA File Offset: 0x00748FFA
		public byte[] GetSignalBreakIdArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06036771 RID: 223089 RVA: 0x0074AE08 File Offset: 0x00749008
		public static Offset<ISignalBreakGameplay> CreateISignalBreakGameplay(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, StringOffset SignalBreakIdOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ISignalBreakGameplay.AddSignalBreakId(builder, SignalBreakIdOffset);
			ISignalBreakGameplay.AddType(builder, Type);
			return ISignalBreakGameplay.EndISignalBreakGameplay(builder);
		}

		// Token: 0x06036772 RID: 223090 RVA: 0x0074AE25 File Offset: 0x00749025
		public static void StartISignalBreakGameplay(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06036773 RID: 223091 RVA: 0x0074AE2E File Offset: 0x0074902E
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036774 RID: 223092 RVA: 0x0074AE39 File Offset: 0x00749039
		public static void AddSignalBreakId(FlatBufferBuilder builder, StringOffset signalBreakIdOffset)
		{
			builder.AddOffset(1, signalBreakIdOffset.Value, 0);
		}

		// Token: 0x06036775 RID: 223093 RVA: 0x0074AE49 File Offset: 0x00749049
		public static Offset<ISignalBreakGameplay> EndISignalBreakGameplay(FlatBufferBuilder builder)
		{
			return new Offset<ISignalBreakGameplay>(builder.EndTable());
		}

		// Token: 0x06036776 RID: 223094 RVA: 0x0074AE58 File Offset: 0x00749058
		public ISignalBreakGameplayT UnPack()
		{
			ISignalBreakGameplayT signalBreakGameplayT = new ISignalBreakGameplayT();
			this.UnPackTo(signalBreakGameplayT);
			return signalBreakGameplayT;
		}

		// Token: 0x06036777 RID: 223095 RVA: 0x0074AE73 File Offset: 0x00749073
		public void UnPackTo(ISignalBreakGameplayT _o)
		{
			_o.Type = this.Type;
			_o.SignalBreakId = this.SignalBreakId;
		}

		// Token: 0x06036778 RID: 223096 RVA: 0x0074AE90 File Offset: 0x00749090
		public static Offset<ISignalBreakGameplay> Pack(FlatBufferBuilder builder, ISignalBreakGameplayT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISignalBreakGameplay>);
			}
			StringOffset signalBreakIdOffset = (_o.SignalBreakId == null) ? default(StringOffset) : builder.CreateString(_o.SignalBreakId);
			return ISignalBreakGameplay.CreateISignalBreakGameplay(builder, _o.Type, signalBreakIdOffset);
		}

		// Token: 0x04012B85 RID: 76677
		private Table __p;
	}
}
