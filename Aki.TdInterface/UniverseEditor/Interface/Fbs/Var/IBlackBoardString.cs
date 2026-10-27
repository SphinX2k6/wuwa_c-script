using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A1B RID: 14875
	public struct IBlackBoardString : IFlatbufferObject
	{
		// Token: 0x170065F6 RID: 26102
		// (get) Token: 0x060141BF RID: 82367 RVA: 0x002F147E File Offset: 0x002EF67E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060141C0 RID: 82368 RVA: 0x002F148B File Offset: 0x002EF68B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060141C1 RID: 82369 RVA: 0x002F1494 File Offset: 0x002EF694
		public static IBlackBoardString GetRootAsIBlackBoardString(ByteBuffer _bb)
		{
			return IBlackBoardString.GetRootAsIBlackBoardString(_bb, default(IBlackBoardString));
		}

		// Token: 0x060141C2 RID: 82370 RVA: 0x002F14B0 File Offset: 0x002EF6B0
		public static IBlackBoardString GetRootAsIBlackBoardString(ByteBuffer _bb, IBlackBoardString obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060141C3 RID: 82371 RVA: 0x002F14CD File Offset: 0x002EF6CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060141C4 RID: 82372 RVA: 0x002F14DC File Offset: 0x002EF6DC
		public IBlackBoardString __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170065F7 RID: 26103
		// (get) Token: 0x060141C5 RID: 82373 RVA: 0x002F14EC File Offset: 0x002EF6EC
		public EBlackBoardType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBlackBoardType.Boolean;
				}
				return (EBlackBoardType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170065F8 RID: 26104
		// (get) Token: 0x060141C6 RID: 82374 RVA: 0x002F1528 File Offset: 0x002EF728
		public string Key
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

		// Token: 0x060141C7 RID: 82375 RVA: 0x002F155F File Offset: 0x002EF75F
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060141C8 RID: 82376 RVA: 0x002F156E File Offset: 0x002EF76E
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x170065F9 RID: 26105
		// (get) Token: 0x060141C9 RID: 82377 RVA: 0x002F157C File Offset: 0x002EF77C
		public string Value
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

		// Token: 0x060141CA RID: 82378 RVA: 0x002F15B3 File Offset: 0x002EF7B3
		public Span<byte> GetValueBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060141CB RID: 82379 RVA: 0x002F15C2 File Offset: 0x002EF7C2
		public byte[] GetValueArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x060141CC RID: 82380 RVA: 0x002F15D0 File Offset: 0x002EF7D0
		public static Offset<IBlackBoardString> CreateIBlackBoardString(FlatBufferBuilder builder, EBlackBoardType Type = EBlackBoardType.Boolean, StringOffset KeyOffset = default(StringOffset), StringOffset ValueOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IBlackBoardString.AddValue(builder, ValueOffset);
			IBlackBoardString.AddKey(builder, KeyOffset);
			IBlackBoardString.AddType(builder, Type);
			return IBlackBoardString.EndIBlackBoardString(builder);
		}

		// Token: 0x060141CD RID: 82381 RVA: 0x002F15F4 File Offset: 0x002EF7F4
		public static void StartIBlackBoardString(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060141CE RID: 82382 RVA: 0x002F15FD File Offset: 0x002EF7FD
		public static void AddType(FlatBufferBuilder builder, EBlackBoardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060141CF RID: 82383 RVA: 0x002F1608 File Offset: 0x002EF808
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(1, keyOffset.Value, 0);
		}

		// Token: 0x060141D0 RID: 82384 RVA: 0x002F1618 File Offset: 0x002EF818
		public static void AddValue(FlatBufferBuilder builder, StringOffset valueOffset)
		{
			builder.AddOffset(2, valueOffset.Value, 0);
		}

		// Token: 0x060141D1 RID: 82385 RVA: 0x002F1628 File Offset: 0x002EF828
		public static Offset<IBlackBoardString> EndIBlackBoardString(FlatBufferBuilder builder)
		{
			return new Offset<IBlackBoardString>(builder.EndTable());
		}

		// Token: 0x060141D2 RID: 82386 RVA: 0x002F1638 File Offset: 0x002EF838
		public IBlackBoardStringT UnPack()
		{
			IBlackBoardStringT blackBoardStringT = new IBlackBoardStringT();
			this.UnPackTo(blackBoardStringT);
			return blackBoardStringT;
		}

		// Token: 0x060141D3 RID: 82387 RVA: 0x002F1653 File Offset: 0x002EF853
		public void UnPackTo(IBlackBoardStringT _o)
		{
			_o.Type = this.Type;
			_o.Key = this.Key;
			_o.Value = this.Value;
		}

		// Token: 0x060141D4 RID: 82388 RVA: 0x002F167C File Offset: 0x002EF87C
		public static Offset<IBlackBoardString> Pack(FlatBufferBuilder builder, IBlackBoardStringT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBlackBoardString>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			StringOffset valueOffset = (_o.Value == null) ? default(StringOffset) : builder.CreateString(_o.Value);
			return IBlackBoardString.CreateIBlackBoardString(builder, _o.Type, keyOffset, valueOffset);
		}

		// Token: 0x0400AE88 RID: 44680
		private Table __p;
	}
}
