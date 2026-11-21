using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A85 RID: 31365
	public struct ITalkEffectPlay : IFlatbufferObject
	{
		// Token: 0x1700E5B8 RID: 58808
		// (get) Token: 0x0603747F RID: 226431 RVA: 0x00761AE0 File Offset: 0x0075FCE0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06037480 RID: 226432 RVA: 0x00761AED File Offset: 0x0075FCED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06037481 RID: 226433 RVA: 0x00761AF4 File Offset: 0x0075FCF4
		public static ITalkEffectPlay GetRootAsITalkEffectPlay(ByteBuffer _bb)
		{
			return ITalkEffectPlay.GetRootAsITalkEffectPlay(_bb, default(ITalkEffectPlay));
		}

		// Token: 0x06037482 RID: 226434 RVA: 0x00761B10 File Offset: 0x0075FD10
		public static ITalkEffectPlay GetRootAsITalkEffectPlay(ByteBuffer _bb, ITalkEffectPlay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06037483 RID: 226435 RVA: 0x00761B2D File Offset: 0x0075FD2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06037484 RID: 226436 RVA: 0x00761B3C File Offset: 0x0075FD3C
		public ITalkEffectPlay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E5B9 RID: 58809
		// (get) Token: 0x06037485 RID: 226437 RVA: 0x00761B4C File Offset: 0x0075FD4C
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

		// Token: 0x1700E5BA RID: 58810
		// (get) Token: 0x06037486 RID: 226438 RVA: 0x00761B88 File Offset: 0x0075FD88
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

		// Token: 0x1700E5BB RID: 58811
		// (get) Token: 0x06037487 RID: 226439 RVA: 0x00761BE8 File Offset: 0x0075FDE8
		public bool KeepPlay
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E5BC RID: 58812
		// (get) Token: 0x06037488 RID: 226440 RVA: 0x00761C28 File Offset: 0x0075FE28
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

		// Token: 0x06037489 RID: 226441 RVA: 0x00761C60 File Offset: 0x0075FE60
		public Span<byte> GetEffectKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0603748A RID: 226442 RVA: 0x00761C70 File Offset: 0x0075FE70
		public byte[] GetEffectKeyArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700E5BD RID: 58813
		// (get) Token: 0x0603748B RID: 226443 RVA: 0x00761C80 File Offset: 0x0075FE80
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

		// Token: 0x1700E5BE RID: 58814
		// (get) Token: 0x0603748C RID: 226444 RVA: 0x00761CC4 File Offset: 0x0075FEC4
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

		// Token: 0x0603748D RID: 226445 RVA: 0x00761D01 File Offset: 0x0075FF01
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

		// Token: 0x0603748E RID: 226446 RVA: 0x00761D3D File Offset: 0x0075FF3D
		public static void StartITalkEffectPlay(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0603748F RID: 226447 RVA: 0x00761D46 File Offset: 0x0075FF46
		public static void AddType(FlatBufferBuilder builder, ETalkEffectActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06037490 RID: 226448 RVA: 0x00761D51 File Offset: 0x0075FF51
		public static void AddEffect(FlatBufferBuilder builder, Offset<ITalkCommonEffect> effectOffset)
		{
			builder.AddOffset(1, effectOffset.Value, 0);
		}

		// Token: 0x06037491 RID: 226449 RVA: 0x00761D61 File Offset: 0x0075FF61
		public static void AddKeepPlay(FlatBufferBuilder builder, bool keepPlay)
		{
			builder.AddBool(2, keepPlay, false);
		}

		// Token: 0x06037492 RID: 226450 RVA: 0x00761D6C File Offset: 0x0075FF6C
		public static void AddEffectKey(FlatBufferBuilder builder, StringOffset effectKeyOffset)
		{
			builder.AddOffset(3, effectKeyOffset.Value, 0);
		}

		// Token: 0x06037493 RID: 226451 RVA: 0x00761D7C File Offset: 0x0075FF7C
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(4, delayTime, 0.0);
		}

		// Token: 0x06037494 RID: 226452 RVA: 0x00761D8F File Offset: 0x0075FF8F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06037495 RID: 226453 RVA: 0x00761D9A File Offset: 0x0075FF9A
		public static Offset<ITalkEffectPlay> EndITalkEffectPlay(FlatBufferBuilder builder)
		{
			return new Offset<ITalkEffectPlay>(builder.EndTable());
		}

		// Token: 0x06037496 RID: 226454 RVA: 0x00761DA8 File Offset: 0x0075FFA8
		public ITalkEffectPlayT UnPack()
		{
			ITalkEffectPlayT talkEffectPlayT = new ITalkEffectPlayT();
			this.UnPackTo(talkEffectPlayT);
			return talkEffectPlayT;
		}

		// Token: 0x06037497 RID: 226455 RVA: 0x00761DC4 File Offset: 0x0075FFC4
		public void UnPackTo(ITalkEffectPlayT _o)
		{
			_o.Type = this.Type;
			_o.Effect = ((this.Effect != null) ? this.Effect.Value.UnPack() : null);
			_o.KeepPlay = this.KeepPlay;
			_o.EffectKey = this.EffectKey;
			_o.DelayTime = this.DelayTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06037498 RID: 226456 RVA: 0x00761E3C File Offset: 0x0076003C
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

		// Token: 0x04012DCD RID: 77261
		private Table __p;
	}
}
