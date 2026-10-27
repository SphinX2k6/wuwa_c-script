using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064C8 RID: 25800
	public struct IContinualGamepadShake : IFlatbufferObject
	{
		// Token: 0x1700BFFB RID: 49147
		// (get) Token: 0x0602CBFE RID: 183294 RVA: 0x00626A41 File Offset: 0x00624C41
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CBFF RID: 183295 RVA: 0x00626A4E File Offset: 0x00624C4E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CC00 RID: 183296 RVA: 0x00626A58 File Offset: 0x00624C58
		public static IContinualGamepadShake GetRootAsIContinualGamepadShake(ByteBuffer _bb)
		{
			return IContinualGamepadShake.GetRootAsIContinualGamepadShake(_bb, default(IContinualGamepadShake));
		}

		// Token: 0x0602CC01 RID: 183297 RVA: 0x00626A74 File Offset: 0x00624C74
		public static IContinualGamepadShake GetRootAsIContinualGamepadShake(ByteBuffer _bb, IContinualGamepadShake obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CC02 RID: 183298 RVA: 0x00626A91 File Offset: 0x00624C91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CC03 RID: 183299 RVA: 0x00626AA0 File Offset: 0x00624CA0
		public IContinualGamepadShake __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BFFC RID: 49148
		// (get) Token: 0x0602CC04 RID: 183300 RVA: 0x00626AB0 File Offset: 0x00624CB0
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

		// Token: 0x1700BFFD RID: 49149
		// (get) Token: 0x0602CC05 RID: 183301 RVA: 0x00626AEC File Offset: 0x00624CEC
		public bool IsIgnoreTimeDilation
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BFFE RID: 49150
		// (get) Token: 0x0602CC06 RID: 183302 RVA: 0x00626B2C File Offset: 0x00624D2C
		public float Duration
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BFFF RID: 49151
		// (get) Token: 0x0602CC07 RID: 183303 RVA: 0x00626B6C File Offset: 0x00624D6C
		public bool IsLoop
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C000 RID: 49152
		// (get) Token: 0x0602CC08 RID: 183304 RVA: 0x00626BAC File Offset: 0x00624DAC
		public string GamepadShakeTag
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

		// Token: 0x0602CC09 RID: 183305 RVA: 0x00626BE4 File Offset: 0x00624DE4
		public Span<byte> GetGamepadShakeTagBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0602CC0A RID: 183306 RVA: 0x00626BF4 File Offset: 0x00624DF4
		public byte[] GetGamepadShakeTagArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700C001 RID: 49153
		// (get) Token: 0x0602CC0B RID: 183307 RVA: 0x00626C04 File Offset: 0x00624E04
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CC0C RID: 183308 RVA: 0x00626C41 File Offset: 0x00624E41
		public static Offset<IContinualGamepadShake> CreateIContinualGamepadShake(FlatBufferBuilder builder, EGamepadShakeType Type = EGamepadShakeType.Onetime, bool IsIgnoreTimeDilation = false, float Duration = 0f, bool IsLoop = false, StringOffset GamepadShakeTagOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			IContinualGamepadShake.AddGamepadShakeTag(builder, GamepadShakeTagOffset);
			IContinualGamepadShake.AddDuration(builder, Duration);
			IContinualGamepadShake.AddNullMask(builder, NullMask);
			IContinualGamepadShake.AddIsLoop(builder, IsLoop);
			IContinualGamepadShake.AddIsIgnoreTimeDilation(builder, IsIgnoreTimeDilation);
			IContinualGamepadShake.AddType(builder, Type);
			return IContinualGamepadShake.EndIContinualGamepadShake(builder);
		}

		// Token: 0x0602CC0D RID: 183309 RVA: 0x00626C7D File Offset: 0x00624E7D
		public static void StartIContinualGamepadShake(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602CC0E RID: 183310 RVA: 0x00626C86 File Offset: 0x00624E86
		public static void AddType(FlatBufferBuilder builder, EGamepadShakeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CC0F RID: 183311 RVA: 0x00626C91 File Offset: 0x00624E91
		public static void AddIsIgnoreTimeDilation(FlatBufferBuilder builder, bool isIgnoreTimeDilation)
		{
			builder.AddBool(1, isIgnoreTimeDilation, false);
		}

		// Token: 0x0602CC10 RID: 183312 RVA: 0x00626C9C File Offset: 0x00624E9C
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(2, duration, 0.0);
		}

		// Token: 0x0602CC11 RID: 183313 RVA: 0x00626CAF File Offset: 0x00624EAF
		public static void AddIsLoop(FlatBufferBuilder builder, bool isLoop)
		{
			builder.AddBool(3, isLoop, false);
		}

		// Token: 0x0602CC12 RID: 183314 RVA: 0x00626CBA File Offset: 0x00624EBA
		public static void AddGamepadShakeTag(FlatBufferBuilder builder, StringOffset gamepadShakeTagOffset)
		{
			builder.AddOffset(4, gamepadShakeTagOffset.Value, 0);
		}

		// Token: 0x0602CC13 RID: 183315 RVA: 0x00626CCA File Offset: 0x00624ECA
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602CC14 RID: 183316 RVA: 0x00626CD5 File Offset: 0x00624ED5
		public static Offset<IContinualGamepadShake> EndIContinualGamepadShake(FlatBufferBuilder builder)
		{
			return new Offset<IContinualGamepadShake>(builder.EndTable());
		}

		// Token: 0x0602CC15 RID: 183317 RVA: 0x00626CE4 File Offset: 0x00624EE4
		public IContinualGamepadShakeT UnPack()
		{
			IContinualGamepadShakeT continualGamepadShakeT = new IContinualGamepadShakeT();
			this.UnPackTo(continualGamepadShakeT);
			return continualGamepadShakeT;
		}

		// Token: 0x0602CC16 RID: 183318 RVA: 0x00626D00 File Offset: 0x00624F00
		public void UnPackTo(IContinualGamepadShakeT _o)
		{
			_o.Type = this.Type;
			_o.IsIgnoreTimeDilation = this.IsIgnoreTimeDilation;
			_o.Duration = this.Duration;
			_o.IsLoop = this.IsLoop;
			_o.GamepadShakeTag = this.GamepadShakeTag;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602CC17 RID: 183319 RVA: 0x00626D58 File Offset: 0x00624F58
		public static Offset<IContinualGamepadShake> Pack(FlatBufferBuilder builder, IContinualGamepadShakeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IContinualGamepadShake>);
			}
			StringOffset gamepadShakeTagOffset = (_o.GamepadShakeTag == null) ? default(StringOffset) : builder.CreateString(_o.GamepadShakeTag);
			return IContinualGamepadShake.CreateIContinualGamepadShake(builder, _o.Type, _o.IsIgnoreTimeDilation, _o.Duration, _o.IsLoop, gamepadShakeTagOffset, _o.NullMask);
		}

		// Token: 0x04010AFC RID: 68348
		private Table __p;
	}
}
