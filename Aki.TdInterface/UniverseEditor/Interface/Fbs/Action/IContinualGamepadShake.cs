using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B33 RID: 27443
	public struct IContinualGamepadShake : IFlatbufferObject
	{
		// Token: 0x1700C988 RID: 51592
		// (get) Token: 0x0602F382 RID: 193410 RVA: 0x00672B69 File Offset: 0x00670D69
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F383 RID: 193411 RVA: 0x00672B76 File Offset: 0x00670D76
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F384 RID: 193412 RVA: 0x00672B80 File Offset: 0x00670D80
		public static IContinualGamepadShake GetRootAsIContinualGamepadShake(ByteBuffer _bb)
		{
			return IContinualGamepadShake.GetRootAsIContinualGamepadShake(_bb, default(IContinualGamepadShake));
		}

		// Token: 0x0602F385 RID: 193413 RVA: 0x00672B9C File Offset: 0x00670D9C
		public static IContinualGamepadShake GetRootAsIContinualGamepadShake(ByteBuffer _bb, IContinualGamepadShake obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F386 RID: 193414 RVA: 0x00672BB9 File Offset: 0x00670DB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F387 RID: 193415 RVA: 0x00672BC8 File Offset: 0x00670DC8
		public IContinualGamepadShake __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C989 RID: 51593
		// (get) Token: 0x0602F388 RID: 193416 RVA: 0x00672BD8 File Offset: 0x00670DD8
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

		// Token: 0x1700C98A RID: 51594
		// (get) Token: 0x0602F389 RID: 193417 RVA: 0x00672C14 File Offset: 0x00670E14
		public bool IsIgnoreTimeDilation
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C98B RID: 51595
		// (get) Token: 0x0602F38A RID: 193418 RVA: 0x00672C54 File Offset: 0x00670E54
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

		// Token: 0x1700C98C RID: 51596
		// (get) Token: 0x0602F38B RID: 193419 RVA: 0x00672C94 File Offset: 0x00670E94
		public bool IsLoop
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C98D RID: 51597
		// (get) Token: 0x0602F38C RID: 193420 RVA: 0x00672CD4 File Offset: 0x00670ED4
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

		// Token: 0x0602F38D RID: 193421 RVA: 0x00672D0C File Offset: 0x00670F0C
		public Span<byte> GetGamepadShakeTagBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0602F38E RID: 193422 RVA: 0x00672D1C File Offset: 0x00670F1C
		public byte[] GetGamepadShakeTagArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700C98E RID: 51598
		// (get) Token: 0x0602F38F RID: 193423 RVA: 0x00672D2C File Offset: 0x00670F2C
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

		// Token: 0x0602F390 RID: 193424 RVA: 0x00672D69 File Offset: 0x00670F69
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

		// Token: 0x0602F391 RID: 193425 RVA: 0x00672DA5 File Offset: 0x00670FA5
		public static void StartIContinualGamepadShake(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602F392 RID: 193426 RVA: 0x00672DAE File Offset: 0x00670FAE
		public static void AddType(FlatBufferBuilder builder, EGamepadShakeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F393 RID: 193427 RVA: 0x00672DB9 File Offset: 0x00670FB9
		public static void AddIsIgnoreTimeDilation(FlatBufferBuilder builder, bool isIgnoreTimeDilation)
		{
			builder.AddBool(1, isIgnoreTimeDilation, false);
		}

		// Token: 0x0602F394 RID: 193428 RVA: 0x00672DC4 File Offset: 0x00670FC4
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(2, duration, 0.0);
		}

		// Token: 0x0602F395 RID: 193429 RVA: 0x00672DD7 File Offset: 0x00670FD7
		public static void AddIsLoop(FlatBufferBuilder builder, bool isLoop)
		{
			builder.AddBool(3, isLoop, false);
		}

		// Token: 0x0602F396 RID: 193430 RVA: 0x00672DE2 File Offset: 0x00670FE2
		public static void AddGamepadShakeTag(FlatBufferBuilder builder, StringOffset gamepadShakeTagOffset)
		{
			builder.AddOffset(4, gamepadShakeTagOffset.Value, 0);
		}

		// Token: 0x0602F397 RID: 193431 RVA: 0x00672DF2 File Offset: 0x00670FF2
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602F398 RID: 193432 RVA: 0x00672DFD File Offset: 0x00670FFD
		public static Offset<IContinualGamepadShake> EndIContinualGamepadShake(FlatBufferBuilder builder)
		{
			return new Offset<IContinualGamepadShake>(builder.EndTable());
		}

		// Token: 0x0602F399 RID: 193433 RVA: 0x00672E0C File Offset: 0x0067100C
		public IContinualGamepadShakeT UnPack()
		{
			IContinualGamepadShakeT continualGamepadShakeT = new IContinualGamepadShakeT();
			this.UnPackTo(continualGamepadShakeT);
			return continualGamepadShakeT;
		}

		// Token: 0x0602F39A RID: 193434 RVA: 0x00672E28 File Offset: 0x00671028
		public void UnPackTo(IContinualGamepadShakeT _o)
		{
			_o.Type = this.Type;
			_o.IsIgnoreTimeDilation = this.IsIgnoreTimeDilation;
			_o.Duration = this.Duration;
			_o.IsLoop = this.IsLoop;
			_o.GamepadShakeTag = this.GamepadShakeTag;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602F39B RID: 193435 RVA: 0x00672E80 File Offset: 0x00671080
		public static Offset<IContinualGamepadShake> Pack(FlatBufferBuilder builder, IContinualGamepadShakeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IContinualGamepadShake>);
			}
			StringOffset gamepadShakeTagOffset = (_o.GamepadShakeTag == null) ? default(StringOffset) : builder.CreateString(_o.GamepadShakeTag);
			return IContinualGamepadShake.CreateIContinualGamepadShake(builder, _o.Type, _o.IsIgnoreTimeDilation, _o.Duration, _o.IsLoop, gamepadShakeTagOffset, _o.NullMask);
		}

		// Token: 0x04011912 RID: 71954
		private Table __p;
	}
}
