using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003DF3 RID: 15859
	public struct IBlackBoardInt : IFlatbufferObject
	{
		// Token: 0x17006B1F RID: 27423
		// (get) Token: 0x060154BF RID: 87231 RVA: 0x003143B2 File Offset: 0x003125B2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060154C0 RID: 87232 RVA: 0x003143BF File Offset: 0x003125BF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060154C1 RID: 87233 RVA: 0x003143C8 File Offset: 0x003125C8
		public static IBlackBoardInt GetRootAsIBlackBoardInt(ByteBuffer _bb)
		{
			return IBlackBoardInt.GetRootAsIBlackBoardInt(_bb, default(IBlackBoardInt));
		}

		// Token: 0x060154C2 RID: 87234 RVA: 0x003143E4 File Offset: 0x003125E4
		public static IBlackBoardInt GetRootAsIBlackBoardInt(ByteBuffer _bb, IBlackBoardInt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060154C3 RID: 87235 RVA: 0x00314401 File Offset: 0x00312601
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060154C4 RID: 87236 RVA: 0x00314410 File Offset: 0x00312610
		public IBlackBoardInt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B20 RID: 27424
		// (get) Token: 0x060154C5 RID: 87237 RVA: 0x00314420 File Offset: 0x00312620
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

		// Token: 0x17006B21 RID: 27425
		// (get) Token: 0x060154C6 RID: 87238 RVA: 0x0031445C File Offset: 0x0031265C
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

		// Token: 0x060154C7 RID: 87239 RVA: 0x00314493 File Offset: 0x00312693
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060154C8 RID: 87240 RVA: 0x003144A2 File Offset: 0x003126A2
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17006B22 RID: 27426
		// (get) Token: 0x060154C9 RID: 87241 RVA: 0x003144B0 File Offset: 0x003126B0
		public int Value
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

		// Token: 0x060154CA RID: 87242 RVA: 0x003144EC File Offset: 0x003126EC
		public static Offset<IBlackBoardInt> CreateIBlackBoardInt(FlatBufferBuilder builder, EBlackBoardType Type = EBlackBoardType.Boolean, StringOffset KeyOffset = default(StringOffset), int Value = 0)
		{
			builder.StartTable(3);
			IBlackBoardInt.AddValue(builder, Value);
			IBlackBoardInt.AddKey(builder, KeyOffset);
			IBlackBoardInt.AddType(builder, Type);
			return IBlackBoardInt.EndIBlackBoardInt(builder);
		}

		// Token: 0x060154CB RID: 87243 RVA: 0x00314510 File Offset: 0x00312710
		public static void StartIBlackBoardInt(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060154CC RID: 87244 RVA: 0x00314519 File Offset: 0x00312719
		public static void AddType(FlatBufferBuilder builder, EBlackBoardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060154CD RID: 87245 RVA: 0x00314524 File Offset: 0x00312724
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(1, keyOffset.Value, 0);
		}

		// Token: 0x060154CE RID: 87246 RVA: 0x00314534 File Offset: 0x00312734
		public static void AddValue(FlatBufferBuilder builder, int value)
		{
			builder.AddInt(2, value, 0);
		}

		// Token: 0x060154CF RID: 87247 RVA: 0x0031453F File Offset: 0x0031273F
		public static Offset<IBlackBoardInt> EndIBlackBoardInt(FlatBufferBuilder builder)
		{
			return new Offset<IBlackBoardInt>(builder.EndTable());
		}

		// Token: 0x060154D0 RID: 87248 RVA: 0x0031454C File Offset: 0x0031274C
		public IBlackBoardIntT UnPack()
		{
			IBlackBoardIntT blackBoardIntT = new IBlackBoardIntT();
			this.UnPackTo(blackBoardIntT);
			return blackBoardIntT;
		}

		// Token: 0x060154D1 RID: 87249 RVA: 0x00314567 File Offset: 0x00312767
		public void UnPackTo(IBlackBoardIntT _o)
		{
			_o.Type = this.Type;
			_o.Key = this.Key;
			_o.Value = this.Value;
		}

		// Token: 0x060154D2 RID: 87250 RVA: 0x00314590 File Offset: 0x00312790
		public static Offset<IBlackBoardInt> Pack(FlatBufferBuilder builder, IBlackBoardIntT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBlackBoardInt>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			return IBlackBoardInt.CreateIBlackBoardInt(builder, _o.Type, keyOffset, _o.Value);
		}

		// Token: 0x0400B7A6 RID: 47014
		private Table __p;
	}
}
