using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A7C RID: 31356
	public struct ITalkCommonEffect : IFlatbufferObject
	{
		// Token: 0x1700E5A8 RID: 58792
		// (get) Token: 0x0603743B RID: 226363 RVA: 0x007613BA File Offset: 0x0075F5BA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603743C RID: 226364 RVA: 0x007613C7 File Offset: 0x0075F5C7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603743D RID: 226365 RVA: 0x007613D0 File Offset: 0x0075F5D0
		public static ITalkCommonEffect GetRootAsITalkCommonEffect(ByteBuffer _bb)
		{
			return ITalkCommonEffect.GetRootAsITalkCommonEffect(_bb, default(ITalkCommonEffect));
		}

		// Token: 0x0603743E RID: 226366 RVA: 0x007613EC File Offset: 0x0075F5EC
		public static ITalkCommonEffect GetRootAsITalkCommonEffect(ByteBuffer _bb, ITalkCommonEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603743F RID: 226367 RVA: 0x00761409 File Offset: 0x0075F609
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06037440 RID: 226368 RVA: 0x00761418 File Offset: 0x0075F618
		public ITalkCommonEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E5A9 RID: 58793
		// (get) Token: 0x06037441 RID: 226369 RVA: 0x00761428 File Offset: 0x0075F628
		public ETalkEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETalkEffectType.Effect;
				}
				return (ETalkEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E5AA RID: 58794
		// (get) Token: 0x06037442 RID: 226370 RVA: 0x00761464 File Offset: 0x0075F664
		public string Path
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

		// Token: 0x06037443 RID: 226371 RVA: 0x0076149B File Offset: 0x0075F69B
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06037444 RID: 226372 RVA: 0x007614AA File Offset: 0x0075F6AA
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700E5AB RID: 58795
		// (get) Token: 0x06037445 RID: 226373 RVA: 0x007614B8 File Offset: 0x0075F6B8
		public IAbsolutePos2? Pos2
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IAbsolutePos2?(default(IAbsolutePos2).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E5AC RID: 58796
		// (get) Token: 0x06037446 RID: 226374 RVA: 0x00761518 File Offset: 0x0075F718
		public bool StartFromLoop
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E5AD RID: 58797
		// (get) Token: 0x06037447 RID: 226375 RVA: 0x00761558 File Offset: 0x0075F758
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06037448 RID: 226376 RVA: 0x00761595 File Offset: 0x0075F795
		public static Offset<ITalkCommonEffect> CreateITalkCommonEffect(FlatBufferBuilder builder, ETalkEffectType Type = ETalkEffectType.Effect, StringOffset PathOffset = default(StringOffset), Offset<IAbsolutePos2> Pos2Offset = default(Offset<IAbsolutePos2>), bool StartFromLoop = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			ITalkCommonEffect.AddPos2(builder, Pos2Offset);
			ITalkCommonEffect.AddPath(builder, PathOffset);
			ITalkCommonEffect.AddNullMask(builder, NullMask);
			ITalkCommonEffect.AddStartFromLoop(builder, StartFromLoop);
			ITalkCommonEffect.AddType(builder, Type);
			return ITalkCommonEffect.EndITalkCommonEffect(builder);
		}

		// Token: 0x06037449 RID: 226377 RVA: 0x007615C9 File Offset: 0x0075F7C9
		public static void StartITalkCommonEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0603744A RID: 226378 RVA: 0x007615D2 File Offset: 0x0075F7D2
		public static void AddType(FlatBufferBuilder builder, ETalkEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603744B RID: 226379 RVA: 0x007615DD File Offset: 0x0075F7DD
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(1, pathOffset.Value, 0);
		}

		// Token: 0x0603744C RID: 226380 RVA: 0x007615ED File Offset: 0x0075F7ED
		public static void AddPos2(FlatBufferBuilder builder, Offset<IAbsolutePos2> pos2Offset)
		{
			builder.AddOffset(2, pos2Offset.Value, 0);
		}

		// Token: 0x0603744D RID: 226381 RVA: 0x007615FD File Offset: 0x0075F7FD
		public static void AddStartFromLoop(FlatBufferBuilder builder, bool startFromLoop)
		{
			builder.AddBool(3, startFromLoop, false);
		}

		// Token: 0x0603744E RID: 226382 RVA: 0x00761608 File Offset: 0x0075F808
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0603744F RID: 226383 RVA: 0x00761613 File Offset: 0x0075F813
		public static Offset<ITalkCommonEffect> EndITalkCommonEffect(FlatBufferBuilder builder)
		{
			return new Offset<ITalkCommonEffect>(builder.EndTable());
		}

		// Token: 0x06037450 RID: 226384 RVA: 0x00761620 File Offset: 0x0075F820
		public ITalkCommonEffectT UnPack()
		{
			ITalkCommonEffectT talkCommonEffectT = new ITalkCommonEffectT();
			this.UnPackTo(talkCommonEffectT);
			return talkCommonEffectT;
		}

		// Token: 0x06037451 RID: 226385 RVA: 0x0076163C File Offset: 0x0075F83C
		public void UnPackTo(ITalkCommonEffectT _o)
		{
			_o.Type = this.Type;
			_o.Path = this.Path;
			_o.Pos2 = ((this.Pos2 != null) ? this.Pos2.Value.UnPack() : null);
			_o.StartFromLoop = this.StartFromLoop;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06037452 RID: 226386 RVA: 0x007616A8 File Offset: 0x0075F8A8
		public static Offset<ITalkCommonEffect> Pack(FlatBufferBuilder builder, ITalkCommonEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkCommonEffect>);
			}
			StringOffset pathOffset = (_o.Path == null) ? default(StringOffset) : builder.CreateString(_o.Path);
			Offset<IAbsolutePos2> pos2Offset = (_o.Pos2 == null) ? default(Offset<IAbsolutePos2>) : IAbsolutePos2.Pack(builder, _o.Pos2);
			return ITalkCommonEffect.CreateITalkCommonEffect(builder, _o.Type, pathOffset, pos2Offset, _o.StartFromLoop, _o.NullMask);
		}

		// Token: 0x04012DBE RID: 77246
		private Table __p;
	}
}
