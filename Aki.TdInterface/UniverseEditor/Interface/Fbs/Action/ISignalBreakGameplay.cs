using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007109 RID: 28937
	public struct ISignalBreakGameplay : IFlatbufferObject
	{
		// Token: 0x1700D71A RID: 55066
		// (get) Token: 0x060334C5 RID: 210117 RVA: 0x006EA6FF File Offset: 0x006E88FF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060334C6 RID: 210118 RVA: 0x006EA70C File Offset: 0x006E890C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060334C7 RID: 210119 RVA: 0x006EA714 File Offset: 0x006E8914
		public static ISignalBreakGameplay GetRootAsISignalBreakGameplay(ByteBuffer _bb)
		{
			return ISignalBreakGameplay.GetRootAsISignalBreakGameplay(_bb, default(ISignalBreakGameplay));
		}

		// Token: 0x060334C8 RID: 210120 RVA: 0x006EA730 File Offset: 0x006E8930
		public static ISignalBreakGameplay GetRootAsISignalBreakGameplay(ByteBuffer _bb, ISignalBreakGameplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060334C9 RID: 210121 RVA: 0x006EA74D File Offset: 0x006E894D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060334CA RID: 210122 RVA: 0x006EA75C File Offset: 0x006E895C
		public ISignalBreakGameplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D71B RID: 55067
		// (get) Token: 0x060334CB RID: 210123 RVA: 0x006EA76C File Offset: 0x006E896C
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

		// Token: 0x1700D71C RID: 55068
		// (get) Token: 0x060334CC RID: 210124 RVA: 0x006EA7A8 File Offset: 0x006E89A8
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

		// Token: 0x060334CD RID: 210125 RVA: 0x006EA7DF File Offset: 0x006E89DF
		public Span<byte> GetSignalBreakIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060334CE RID: 210126 RVA: 0x006EA7EE File Offset: 0x006E89EE
		public byte[] GetSignalBreakIdArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060334CF RID: 210127 RVA: 0x006EA7FC File Offset: 0x006E89FC
		public static Offset<ISignalBreakGameplay> CreateISignalBreakGameplay(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, StringOffset SignalBreakIdOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ISignalBreakGameplay.AddSignalBreakId(builder, SignalBreakIdOffset);
			ISignalBreakGameplay.AddType(builder, Type);
			return ISignalBreakGameplay.EndISignalBreakGameplay(builder);
		}

		// Token: 0x060334D0 RID: 210128 RVA: 0x006EA819 File Offset: 0x006E8A19
		public static void StartISignalBreakGameplay(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060334D1 RID: 210129 RVA: 0x006EA822 File Offset: 0x006E8A22
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060334D2 RID: 210130 RVA: 0x006EA82D File Offset: 0x006E8A2D
		public static void AddSignalBreakId(FlatBufferBuilder builder, StringOffset signalBreakIdOffset)
		{
			builder.AddOffset(1, signalBreakIdOffset.Value, 0);
		}

		// Token: 0x060334D3 RID: 210131 RVA: 0x006EA83D File Offset: 0x006E8A3D
		public static Offset<ISignalBreakGameplay> EndISignalBreakGameplay(FlatBufferBuilder builder)
		{
			return new Offset<ISignalBreakGameplay>(builder.EndTable());
		}

		// Token: 0x060334D4 RID: 210132 RVA: 0x006EA84C File Offset: 0x006E8A4C
		public ISignalBreakGameplayT UnPack()
		{
			ISignalBreakGameplayT signalBreakGameplayT = new ISignalBreakGameplayT();
			this.UnPackTo(signalBreakGameplayT);
			return signalBreakGameplayT;
		}

		// Token: 0x060334D5 RID: 210133 RVA: 0x006EA867 File Offset: 0x006E8A67
		public void UnPackTo(ISignalBreakGameplayT _o)
		{
			_o.Type = this.Type;
			_o.SignalBreakId = this.SignalBreakId;
		}

		// Token: 0x060334D6 RID: 210134 RVA: 0x006EA884 File Offset: 0x006E8A84
		public static Offset<ISignalBreakGameplay> Pack(FlatBufferBuilder builder, ISignalBreakGameplayT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISignalBreakGameplay>);
			}
			StringOffset signalBreakIdOffset = (_o.SignalBreakId == null) ? default(StringOffset) : builder.CreateString(_o.SignalBreakId);
			return ISignalBreakGameplay.CreateISignalBreakGameplay(builder, _o.Type, signalBreakIdOffset);
		}

		// Token: 0x04011B97 RID: 72599
		private Table __p;
	}
}
