using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007352 RID: 29522
	public struct IOnetimeGamepadShake : IFlatbufferObject
	{
		// Token: 0x1700D86C RID: 55404
		// (get) Token: 0x060337EC RID: 210924 RVA: 0x006F0BC1 File Offset: 0x006EEDC1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060337ED RID: 210925 RVA: 0x006F0BCE File Offset: 0x006EEDCE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060337EE RID: 210926 RVA: 0x006F0BD8 File Offset: 0x006EEDD8
		public static IOnetimeGamepadShake GetRootAsIOnetimeGamepadShake(ByteBuffer _bb)
		{
			return IOnetimeGamepadShake.GetRootAsIOnetimeGamepadShake(_bb, default(IOnetimeGamepadShake));
		}

		// Token: 0x060337EF RID: 210927 RVA: 0x006F0BF4 File Offset: 0x006EEDF4
		public static IOnetimeGamepadShake GetRootAsIOnetimeGamepadShake(ByteBuffer _bb, IOnetimeGamepadShake obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060337F0 RID: 210928 RVA: 0x006F0C11 File Offset: 0x006EEE11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060337F1 RID: 210929 RVA: 0x006F0C20 File Offset: 0x006EEE20
		public IOnetimeGamepadShake __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D86D RID: 55405
		// (get) Token: 0x060337F2 RID: 210930 RVA: 0x006F0C30 File Offset: 0x006EEE30
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

		// Token: 0x1700D86E RID: 55406
		// (get) Token: 0x060337F3 RID: 210931 RVA: 0x006F0C6C File Offset: 0x006EEE6C
		public bool IsIgnoreTimeDilation
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D86F RID: 55407
		// (get) Token: 0x060337F4 RID: 210932 RVA: 0x006F0CAC File Offset: 0x006EEEAC
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

		// Token: 0x060337F5 RID: 210933 RVA: 0x006F0CE3 File Offset: 0x006EEEE3
		public Span<byte> GetGamepadShakeTagBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060337F6 RID: 210934 RVA: 0x006F0CF2 File Offset: 0x006EEEF2
		public byte[] GetGamepadShakeTagArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700D870 RID: 55408
		// (get) Token: 0x060337F7 RID: 210935 RVA: 0x006F0D00 File Offset: 0x006EEF00
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

		// Token: 0x060337F8 RID: 210936 RVA: 0x006F0D3D File Offset: 0x006EEF3D
		public static Offset<IOnetimeGamepadShake> CreateIOnetimeGamepadShake(FlatBufferBuilder builder, EGamepadShakeType Type = EGamepadShakeType.Onetime, bool IsIgnoreTimeDilation = false, StringOffset GamepadShakeTagOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IOnetimeGamepadShake.AddGamepadShakeTag(builder, GamepadShakeTagOffset);
			IOnetimeGamepadShake.AddNullMask(builder, NullMask);
			IOnetimeGamepadShake.AddIsIgnoreTimeDilation(builder, IsIgnoreTimeDilation);
			IOnetimeGamepadShake.AddType(builder, Type);
			return IOnetimeGamepadShake.EndIOnetimeGamepadShake(builder);
		}

		// Token: 0x060337F9 RID: 210937 RVA: 0x006F0D69 File Offset: 0x006EEF69
		public static void StartIOnetimeGamepadShake(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060337FA RID: 210938 RVA: 0x006F0D72 File Offset: 0x006EEF72
		public static void AddType(FlatBufferBuilder builder, EGamepadShakeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060337FB RID: 210939 RVA: 0x006F0D7D File Offset: 0x006EEF7D
		public static void AddIsIgnoreTimeDilation(FlatBufferBuilder builder, bool isIgnoreTimeDilation)
		{
			builder.AddBool(1, isIgnoreTimeDilation, false);
		}

		// Token: 0x060337FC RID: 210940 RVA: 0x006F0D88 File Offset: 0x006EEF88
		public static void AddGamepadShakeTag(FlatBufferBuilder builder, StringOffset gamepadShakeTagOffset)
		{
			builder.AddOffset(2, gamepadShakeTagOffset.Value, 0);
		}

		// Token: 0x060337FD RID: 210941 RVA: 0x006F0D98 File Offset: 0x006EEF98
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060337FE RID: 210942 RVA: 0x006F0DA3 File Offset: 0x006EEFA3
		public static Offset<IOnetimeGamepadShake> EndIOnetimeGamepadShake(FlatBufferBuilder builder)
		{
			return new Offset<IOnetimeGamepadShake>(builder.EndTable());
		}

		// Token: 0x060337FF RID: 210943 RVA: 0x006F0DB0 File Offset: 0x006EEFB0
		public IOnetimeGamepadShakeT UnPack()
		{
			IOnetimeGamepadShakeT onetimeGamepadShakeT = new IOnetimeGamepadShakeT();
			this.UnPackTo(onetimeGamepadShakeT);
			return onetimeGamepadShakeT;
		}

		// Token: 0x06033800 RID: 210944 RVA: 0x006F0DCB File Offset: 0x006EEFCB
		public void UnPackTo(IOnetimeGamepadShakeT _o)
		{
			_o.Type = this.Type;
			_o.IsIgnoreTimeDilation = this.IsIgnoreTimeDilation;
			_o.GamepadShakeTag = this.GamepadShakeTag;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06033801 RID: 210945 RVA: 0x006F0E00 File Offset: 0x006EF000
		public static Offset<IOnetimeGamepadShake> Pack(FlatBufferBuilder builder, IOnetimeGamepadShakeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOnetimeGamepadShake>);
			}
			StringOffset gamepadShakeTagOffset = (_o.GamepadShakeTag == null) ? default(StringOffset) : builder.CreateString(_o.GamepadShakeTag);
			return IOnetimeGamepadShake.CreateIOnetimeGamepadShake(builder, _o.Type, _o.IsIgnoreTimeDilation, gamepadShakeTagOffset, _o.NullMask);
		}

		// Token: 0x0401242C RID: 74796
		private Table __p;
	}
}
