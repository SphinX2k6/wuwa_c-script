using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072A7 RID: 29351
	public struct ITalkCommonEffect : IFlatbufferObject
	{
		// Token: 0x1700D9AF RID: 55727
		// (get) Token: 0x06034137 RID: 213303 RVA: 0x0070001E File Offset: 0x006FE21E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034138 RID: 213304 RVA: 0x0070002B File Offset: 0x006FE22B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034139 RID: 213305 RVA: 0x00700034 File Offset: 0x006FE234
		public static ITalkCommonEffect GetRootAsITalkCommonEffect(ByteBuffer _bb)
		{
			return ITalkCommonEffect.GetRootAsITalkCommonEffect(_bb, default(ITalkCommonEffect));
		}

		// Token: 0x0603413A RID: 213306 RVA: 0x00700050 File Offset: 0x006FE250
		public static ITalkCommonEffect GetRootAsITalkCommonEffect(ByteBuffer _bb, ITalkCommonEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603413B RID: 213307 RVA: 0x0070006D File Offset: 0x006FE26D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603413C RID: 213308 RVA: 0x0070007C File Offset: 0x006FE27C
		public ITalkCommonEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D9B0 RID: 55728
		// (get) Token: 0x0603413D RID: 213309 RVA: 0x0070008C File Offset: 0x006FE28C
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

		// Token: 0x1700D9B1 RID: 55729
		// (get) Token: 0x0603413E RID: 213310 RVA: 0x007000C8 File Offset: 0x006FE2C8
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

		// Token: 0x0603413F RID: 213311 RVA: 0x007000FF File Offset: 0x006FE2FF
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06034140 RID: 213312 RVA: 0x0070010E File Offset: 0x006FE30E
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700D9B2 RID: 55730
		// (get) Token: 0x06034141 RID: 213313 RVA: 0x0070011C File Offset: 0x006FE31C
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

		// Token: 0x1700D9B3 RID: 55731
		// (get) Token: 0x06034142 RID: 213314 RVA: 0x0070017C File Offset: 0x006FE37C
		public bool StartFromLoop
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D9B4 RID: 55732
		// (get) Token: 0x06034143 RID: 213315 RVA: 0x007001BC File Offset: 0x006FE3BC
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

		// Token: 0x06034144 RID: 213316 RVA: 0x007001F9 File Offset: 0x006FE3F9
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

		// Token: 0x06034145 RID: 213317 RVA: 0x0070022D File Offset: 0x006FE42D
		public static void StartITalkCommonEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06034146 RID: 213318 RVA: 0x00700236 File Offset: 0x006FE436
		public static void AddType(FlatBufferBuilder builder, ETalkEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034147 RID: 213319 RVA: 0x00700241 File Offset: 0x006FE441
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(1, pathOffset.Value, 0);
		}

		// Token: 0x06034148 RID: 213320 RVA: 0x00700251 File Offset: 0x006FE451
		public static void AddPos2(FlatBufferBuilder builder, Offset<IAbsolutePos2> pos2Offset)
		{
			builder.AddOffset(2, pos2Offset.Value, 0);
		}

		// Token: 0x06034149 RID: 213321 RVA: 0x00700261 File Offset: 0x006FE461
		public static void AddStartFromLoop(FlatBufferBuilder builder, bool startFromLoop)
		{
			builder.AddBool(3, startFromLoop, false);
		}

		// Token: 0x0603414A RID: 213322 RVA: 0x0070026C File Offset: 0x006FE46C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0603414B RID: 213323 RVA: 0x00700277 File Offset: 0x006FE477
		public static Offset<ITalkCommonEffect> EndITalkCommonEffect(FlatBufferBuilder builder)
		{
			return new Offset<ITalkCommonEffect>(builder.EndTable());
		}

		// Token: 0x0603414C RID: 213324 RVA: 0x00700284 File Offset: 0x006FE484
		public ITalkCommonEffectT UnPack()
		{
			ITalkCommonEffectT talkCommonEffectT = new ITalkCommonEffectT();
			this.UnPackTo(talkCommonEffectT);
			return talkCommonEffectT;
		}

		// Token: 0x0603414D RID: 213325 RVA: 0x007002A0 File Offset: 0x006FE4A0
		public void UnPackTo(ITalkCommonEffectT _o)
		{
			_o.Type = this.Type;
			_o.Path = this.Path;
			_o.Pos2 = ((this.Pos2 != null) ? this.Pos2.Value.UnPack() : null);
			_o.StartFromLoop = this.StartFromLoop;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603414E RID: 213326 RVA: 0x0070030C File Offset: 0x006FE50C
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

		// Token: 0x04011DBB RID: 73147
		private Table __p;
	}
}
