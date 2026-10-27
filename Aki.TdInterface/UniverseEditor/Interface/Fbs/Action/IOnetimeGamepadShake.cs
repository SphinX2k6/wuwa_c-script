using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BEE RID: 27630
	public struct IOnetimeGamepadShake : IFlatbufferObject
	{
		// Token: 0x1700CD60 RID: 52576
		// (get) Token: 0x060308D0 RID: 198864 RVA: 0x006972C1 File Offset: 0x006954C1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060308D1 RID: 198865 RVA: 0x006972CE File Offset: 0x006954CE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060308D2 RID: 198866 RVA: 0x006972D8 File Offset: 0x006954D8
		public static IOnetimeGamepadShake GetRootAsIOnetimeGamepadShake(ByteBuffer _bb)
		{
			return IOnetimeGamepadShake.GetRootAsIOnetimeGamepadShake(_bb, default(IOnetimeGamepadShake));
		}

		// Token: 0x060308D3 RID: 198867 RVA: 0x006972F4 File Offset: 0x006954F4
		public static IOnetimeGamepadShake GetRootAsIOnetimeGamepadShake(ByteBuffer _bb, IOnetimeGamepadShake obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060308D4 RID: 198868 RVA: 0x00697311 File Offset: 0x00695511
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060308D5 RID: 198869 RVA: 0x00697320 File Offset: 0x00695520
		public IOnetimeGamepadShake __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD61 RID: 52577
		// (get) Token: 0x060308D6 RID: 198870 RVA: 0x00697330 File Offset: 0x00695530
		public EGamepadShakeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGamepadShakeType.Onetime;
				}
				return (EGamepadShakeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CD62 RID: 52578
		// (get) Token: 0x060308D7 RID: 198871 RVA: 0x0069736C File Offset: 0x0069556C
		public bool IsIgnoreTimeDilation
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CD63 RID: 52579
		// (get) Token: 0x060308D8 RID: 198872 RVA: 0x006973AC File Offset: 0x006955AC
		public string GamepadShakeTag
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

		// Token: 0x060308D9 RID: 198873 RVA: 0x006973E3 File Offset: 0x006955E3
		public Span<byte> GetGamepadShakeTagBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060308DA RID: 198874 RVA: 0x006973F2 File Offset: 0x006955F2
		public byte[] GetGamepadShakeTagArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700CD64 RID: 52580
		// (get) Token: 0x060308DB RID: 198875 RVA: 0x00697400 File Offset: 0x00695600
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060308DC RID: 198876 RVA: 0x0069743D File Offset: 0x0069563D
		public static Offset<IOnetimeGamepadShake> CreateIOnetimeGamepadShake(FlatBufferBuilder builder, EGamepadShakeType Type = EGamepadShakeType.Onetime, bool IsIgnoreTimeDilation = false, StringOffset GamepadShakeTagOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IOnetimeGamepadShake.AddGamepadShakeTag(builder, GamepadShakeTagOffset);
			IOnetimeGamepadShake.AddNullMask(builder, NullMask);
			IOnetimeGamepadShake.AddIsIgnoreTimeDilation(builder, IsIgnoreTimeDilation);
			IOnetimeGamepadShake.AddType(builder, Type);
			return IOnetimeGamepadShake.EndIOnetimeGamepadShake(builder);
		}

		// Token: 0x060308DD RID: 198877 RVA: 0x00697469 File Offset: 0x00695669
		public static void StartIOnetimeGamepadShake(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060308DE RID: 198878 RVA: 0x00697472 File Offset: 0x00695672
		public static void AddType(FlatBufferBuilder builder, EGamepadShakeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060308DF RID: 198879 RVA: 0x0069747D File Offset: 0x0069567D
		public static void AddIsIgnoreTimeDilation(FlatBufferBuilder builder, bool isIgnoreTimeDilation)
		{
			builder.AddBool(1, isIgnoreTimeDilation, false);
		}

		// Token: 0x060308E0 RID: 198880 RVA: 0x00697488 File Offset: 0x00695688
		public static void AddGamepadShakeTag(FlatBufferBuilder builder, StringOffset gamepadShakeTagOffset)
		{
			builder.AddOffset(2, gamepadShakeTagOffset.Value, 0);
		}

		// Token: 0x060308E1 RID: 198881 RVA: 0x00697498 File Offset: 0x00695698
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060308E2 RID: 198882 RVA: 0x006974A3 File Offset: 0x006956A3
		public static Offset<IOnetimeGamepadShake> EndIOnetimeGamepadShake(FlatBufferBuilder builder)
		{
			return new Offset<IOnetimeGamepadShake>(builder.EndTable());
		}

		// Token: 0x060308E3 RID: 198883 RVA: 0x006974B0 File Offset: 0x006956B0
		public IOnetimeGamepadShakeT UnPack()
		{
			IOnetimeGamepadShakeT onetimeGamepadShakeT = new IOnetimeGamepadShakeT();
			this.UnPackTo(onetimeGamepadShakeT);
			return onetimeGamepadShakeT;
		}

		// Token: 0x060308E4 RID: 198884 RVA: 0x006974CB File Offset: 0x006956CB
		public void UnPackTo(IOnetimeGamepadShakeT _o)
		{
			_o.Type = this.Type;
			_o.IsIgnoreTimeDilation = this.IsIgnoreTimeDilation;
			_o.GamepadShakeTag = this.GamepadShakeTag;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060308E5 RID: 198885 RVA: 0x00697500 File Offset: 0x00695700
		public static Offset<IOnetimeGamepadShake> Pack(FlatBufferBuilder builder, IOnetimeGamepadShakeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOnetimeGamepadShake>);
			}
			StringOffset gamepadShakeTagOffset = (_o.GamepadShakeTag == null) ? default(StringOffset) : builder.CreateString(_o.GamepadShakeTag);
			return IOnetimeGamepadShake.CreateIOnetimeGamepadShake(builder, _o.Type, _o.IsIgnoreTimeDilation, gamepadShakeTagOffset, _o.NullMask);
		}

		// Token: 0x040114DD RID: 70877
		private Table __p;
	}
}
