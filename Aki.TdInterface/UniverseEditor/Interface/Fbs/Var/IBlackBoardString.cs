using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003DF6 RID: 15862
	public struct IBlackBoardString : IFlatbufferObject
	{
		// Token: 0x17006B26 RID: 27430
		// (get) Token: 0x060154DB RID: 87259 RVA: 0x0031466A File Offset: 0x0031286A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060154DC RID: 87260 RVA: 0x00314677 File Offset: 0x00312877
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060154DD RID: 87261 RVA: 0x00314680 File Offset: 0x00312880
		public static IBlackBoardString GetRootAsIBlackBoardString(ByteBuffer _bb)
		{
			return IBlackBoardString.GetRootAsIBlackBoardString(_bb, default(IBlackBoardString));
		}

		// Token: 0x060154DE RID: 87262 RVA: 0x0031469C File Offset: 0x0031289C
		public static IBlackBoardString GetRootAsIBlackBoardString(ByteBuffer _bb, IBlackBoardString obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060154DF RID: 87263 RVA: 0x003146B9 File Offset: 0x003128B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060154E0 RID: 87264 RVA: 0x003146C8 File Offset: 0x003128C8
		public IBlackBoardString __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B27 RID: 27431
		// (get) Token: 0x060154E1 RID: 87265 RVA: 0x003146D8 File Offset: 0x003128D8
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

		// Token: 0x17006B28 RID: 27432
		// (get) Token: 0x060154E2 RID: 87266 RVA: 0x00314714 File Offset: 0x00312914
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

		// Token: 0x060154E3 RID: 87267 RVA: 0x0031474B File Offset: 0x0031294B
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060154E4 RID: 87268 RVA: 0x0031475A File Offset: 0x0031295A
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17006B29 RID: 27433
		// (get) Token: 0x060154E5 RID: 87269 RVA: 0x00314768 File Offset: 0x00312968
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

		// Token: 0x060154E6 RID: 87270 RVA: 0x0031479F File Offset: 0x0031299F
		public Span<byte> GetValueBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060154E7 RID: 87271 RVA: 0x003147AE File Offset: 0x003129AE
		public byte[] GetValueArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x060154E8 RID: 87272 RVA: 0x003147BC File Offset: 0x003129BC
		public static Offset<IBlackBoardString> CreateIBlackBoardString(FlatBufferBuilder builder, EBlackBoardType Type = EBlackBoardType.Boolean, StringOffset KeyOffset = default(StringOffset), StringOffset ValueOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IBlackBoardString.AddValue(builder, ValueOffset);
			IBlackBoardString.AddKey(builder, KeyOffset);
			IBlackBoardString.AddType(builder, Type);
			return IBlackBoardString.EndIBlackBoardString(builder);
		}

		// Token: 0x060154E9 RID: 87273 RVA: 0x003147E0 File Offset: 0x003129E0
		public static void StartIBlackBoardString(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060154EA RID: 87274 RVA: 0x003147E9 File Offset: 0x003129E9
		public static void AddType(FlatBufferBuilder builder, EBlackBoardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060154EB RID: 87275 RVA: 0x003147F4 File Offset: 0x003129F4
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(1, keyOffset.Value, 0);
		}

		// Token: 0x060154EC RID: 87276 RVA: 0x00314804 File Offset: 0x00312A04
		public static void AddValue(FlatBufferBuilder builder, StringOffset valueOffset)
		{
			builder.AddOffset(2, valueOffset.Value, 0);
		}

		// Token: 0x060154ED RID: 87277 RVA: 0x00314814 File Offset: 0x00312A14
		public static Offset<IBlackBoardString> EndIBlackBoardString(FlatBufferBuilder builder)
		{
			return new Offset<IBlackBoardString>(builder.EndTable());
		}

		// Token: 0x060154EE RID: 87278 RVA: 0x00314824 File Offset: 0x00312A24
		public IBlackBoardStringT UnPack()
		{
			IBlackBoardStringT blackBoardStringT = new IBlackBoardStringT();
			this.UnPackTo(blackBoardStringT);
			return blackBoardStringT;
		}

		// Token: 0x060154EF RID: 87279 RVA: 0x0031483F File Offset: 0x00312A3F
		public void UnPackTo(IBlackBoardStringT _o)
		{
			_o.Type = this.Type;
			_o.Key = this.Key;
			_o.Value = this.Value;
		}

		// Token: 0x060154F0 RID: 87280 RVA: 0x00314868 File Offset: 0x00312A68
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

		// Token: 0x0400B7AA RID: 47018
		private Table __p;
	}
}
