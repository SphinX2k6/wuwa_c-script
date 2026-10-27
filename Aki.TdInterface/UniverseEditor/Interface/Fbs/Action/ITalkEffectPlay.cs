using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072B0 RID: 29360
	public struct ITalkEffectPlay : IFlatbufferObject
	{
		// Token: 0x1700D9BF RID: 55743
		// (get) Token: 0x0603417B RID: 213371 RVA: 0x00700744 File Offset: 0x006FE944
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603417C RID: 213372 RVA: 0x00700751 File Offset: 0x006FE951
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603417D RID: 213373 RVA: 0x00700758 File Offset: 0x006FE958
		public static ITalkEffectPlay GetRootAsITalkEffectPlay(ByteBuffer _bb)
		{
			return ITalkEffectPlay.GetRootAsITalkEffectPlay(_bb, default(ITalkEffectPlay));
		}

		// Token: 0x0603417E RID: 213374 RVA: 0x00700774 File Offset: 0x006FE974
		public static ITalkEffectPlay GetRootAsITalkEffectPlay(ByteBuffer _bb, ITalkEffectPlay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603417F RID: 213375 RVA: 0x00700791 File Offset: 0x006FE991
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034180 RID: 213376 RVA: 0x007007A0 File Offset: 0x006FE9A0
		public ITalkEffectPlay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D9C0 RID: 55744
		// (get) Token: 0x06034181 RID: 213377 RVA: 0x007007B0 File Offset: 0x006FE9B0
		public ETalkEffectActionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETalkEffectActionType.Play;
				}
				return (ETalkEffectActionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D9C1 RID: 55745
		// (get) Token: 0x06034182 RID: 213378 RVA: 0x007007EC File Offset: 0x006FE9EC
		public ITalkCommonEffect? Effect
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ITalkCommonEffect?(default(ITalkCommonEffect).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D9C2 RID: 55746
		// (get) Token: 0x06034183 RID: 213379 RVA: 0x0070084C File Offset: 0x006FEA4C
		public bool KeepPlay
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D9C3 RID: 55747
		// (get) Token: 0x06034184 RID: 213380 RVA: 0x0070088C File Offset: 0x006FEA8C
		public string EffectKey
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034185 RID: 213381 RVA: 0x007008C4 File Offset: 0x006FEAC4
		public Span<byte> GetEffectKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06034186 RID: 213382 RVA: 0x007008D4 File Offset: 0x006FEAD4
		public byte[] GetEffectKeyArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700D9C4 RID: 55748
		// (get) Token: 0x06034187 RID: 213383 RVA: 0x007008E4 File Offset: 0x006FEAE4
		public float DelayTime
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D9C5 RID: 55749
		// (get) Token: 0x06034188 RID: 213384 RVA: 0x00700928 File Offset: 0x006FEB28
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

		// Token: 0x06034189 RID: 213385 RVA: 0x00700965 File Offset: 0x006FEB65
		public static Offset<ITalkEffectPlay> CreateITalkEffectPlay(FlatBufferBuilder builder, ETalkEffectActionType Type = ETalkEffectActionType.Play, Offset<ITalkCommonEffect> EffectOffset = default(Offset<ITalkCommonEffect>), bool KeepPlay = false, StringOffset EffectKeyOffset = default(StringOffset), float DelayTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(6);
			ITalkEffectPlay.AddDelayTime(builder, DelayTime);
			ITalkEffectPlay.AddEffectKey(builder, EffectKeyOffset);
			ITalkEffectPlay.AddEffect(builder, EffectOffset);
			ITalkEffectPlay.AddNullMask(builder, NullMask);
			ITalkEffectPlay.AddKeepPlay(builder, KeepPlay);
			ITalkEffectPlay.AddType(builder, Type);
			return ITalkEffectPlay.EndITalkEffectPlay(builder);
		}

		// Token: 0x0603418A RID: 213386 RVA: 0x007009A1 File Offset: 0x006FEBA1
		public static void StartITalkEffectPlay(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0603418B RID: 213387 RVA: 0x007009AA File Offset: 0x006FEBAA
		public static void AddType(FlatBufferBuilder builder, ETalkEffectActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603418C RID: 213388 RVA: 0x007009B5 File Offset: 0x006FEBB5
		public static void AddEffect(FlatBufferBuilder builder, Offset<ITalkCommonEffect> effectOffset)
		{
			builder.AddOffset(1, effectOffset.Value, 0);
		}

		// Token: 0x0603418D RID: 213389 RVA: 0x007009C5 File Offset: 0x006FEBC5
		public static void AddKeepPlay(FlatBufferBuilder builder, bool keepPlay)
		{
			builder.AddBool(2, keepPlay, false);
		}

		// Token: 0x0603418E RID: 213390 RVA: 0x007009D0 File Offset: 0x006FEBD0
		public static void AddEffectKey(FlatBufferBuilder builder, StringOffset effectKeyOffset)
		{
			builder.AddOffset(3, effectKeyOffset.Value, 0);
		}

		// Token: 0x0603418F RID: 213391 RVA: 0x007009E0 File Offset: 0x006FEBE0
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(4, delayTime, 0.0);
		}

		// Token: 0x06034190 RID: 213392 RVA: 0x007009F3 File Offset: 0x006FEBF3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06034191 RID: 213393 RVA: 0x007009FE File Offset: 0x006FEBFE
		public static Offset<ITalkEffectPlay> EndITalkEffectPlay(FlatBufferBuilder builder)
		{
			return new Offset<ITalkEffectPlay>(builder.EndTable());
		}

		// Token: 0x06034192 RID: 213394 RVA: 0x00700A0C File Offset: 0x006FEC0C
		public ITalkEffectPlayT UnPack()
		{
			ITalkEffectPlayT talkEffectPlayT = new ITalkEffectPlayT();
			this.UnPackTo(talkEffectPlayT);
			return talkEffectPlayT;
		}

		// Token: 0x06034193 RID: 213395 RVA: 0x00700A28 File Offset: 0x006FEC28
		public void UnPackTo(ITalkEffectPlayT _o)
		{
			_o.Type = this.Type;
			_o.Effect = ((this.Effect != null) ? this.Effect.Value.UnPack() : null);
			_o.KeepPlay = this.KeepPlay;
			_o.EffectKey = this.EffectKey;
			_o.DelayTime = this.DelayTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06034194 RID: 213396 RVA: 0x00700AA0 File Offset: 0x006FECA0
		public static Offset<ITalkEffectPlay> Pack(FlatBufferBuilder builder, ITalkEffectPlayT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkEffectPlay>);
			}
			Offset<ITalkCommonEffect> effectOffset = (_o.Effect == null) ? default(Offset<ITalkCommonEffect>) : ITalkCommonEffect.Pack(builder, _o.Effect);
			StringOffset effectKeyOffset = (_o.EffectKey == null) ? default(StringOffset) : builder.CreateString(_o.EffectKey);
			return ITalkEffectPlay.CreateITalkEffectPlay(builder, _o.Type, effectOffset, _o.KeepPlay, effectKeyOffset, _o.DelayTime, _o.NullMask);
		}

		// Token: 0x04011DCA RID: 73162
		private Table __p;
	}
}
