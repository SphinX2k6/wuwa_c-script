using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006772 RID: 26482
	public struct IActorVisibility : IFlatbufferObject
	{
		// Token: 0x1700C086 RID: 49286
		// (get) Token: 0x0602CE20 RID: 183840 RVA: 0x00623039 File Offset: 0x00621239
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CE21 RID: 183841 RVA: 0x00623046 File Offset: 0x00621246
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CE22 RID: 183842 RVA: 0x00623050 File Offset: 0x00621250
		public static IActorVisibility GetRootAsIActorVisibility(ByteBuffer _bb)
		{
			return IActorVisibility.GetRootAsIActorVisibility(_bb, default(IActorVisibility));
		}

		// Token: 0x0602CE23 RID: 183843 RVA: 0x0062306C File Offset: 0x0062126C
		public static IActorVisibility GetRootAsIActorVisibility(ByteBuffer _bb, IActorVisibility obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CE24 RID: 183844 RVA: 0x00623089 File Offset: 0x00621289
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CE25 RID: 183845 RVA: 0x00623098 File Offset: 0x00621298
		public IActorVisibility __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C087 RID: 49287
		// (get) Token: 0x0602CE26 RID: 183846 RVA: 0x006230A8 File Offset: 0x006212A8
		public int ActorIndex
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C088 RID: 49288
		// (get) Token: 0x0602CE27 RID: 183847 RVA: 0x006230E4 File Offset: 0x006212E4
		public EActorVisibilityPlayMode PlayMode
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EActorVisibilityPlayMode.FadeIn;
				}
				return (EActorVisibilityPlayMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C089 RID: 49289
		// (get) Token: 0x0602CE28 RID: 183848 RVA: 0x00623120 File Offset: 0x00621320
		public IActorVisibilityEffectDefault? Effect
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IActorVisibilityEffectDefault?(default(IActorVisibilityEffectDefault).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C08A RID: 49290
		// (get) Token: 0x0602CE29 RID: 183849 RVA: 0x00623180 File Offset: 0x00621380
		public float FadeDuration
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C08B RID: 49291
		// (get) Token: 0x0602CE2A RID: 183850 RVA: 0x006231C4 File Offset: 0x006213C4
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

		// Token: 0x1700C08C RID: 49292
		// (get) Token: 0x0602CE2B RID: 183851 RVA: 0x00623208 File Offset: 0x00621408
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

		// Token: 0x0602CE2C RID: 183852 RVA: 0x00623245 File Offset: 0x00621445
		public static Offset<IActorVisibility> CreateIActorVisibility(FlatBufferBuilder builder, int ActorIndex = 0, EActorVisibilityPlayMode PlayMode = EActorVisibilityPlayMode.FadeIn, Offset<IActorVisibilityEffectDefault> EffectOffset = default(Offset<IActorVisibilityEffectDefault>), float FadeDuration = 0f, float DelayTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(6);
			IActorVisibility.AddDelayTime(builder, DelayTime);
			IActorVisibility.AddFadeDuration(builder, FadeDuration);
			IActorVisibility.AddEffect(builder, EffectOffset);
			IActorVisibility.AddActorIndex(builder, ActorIndex);
			IActorVisibility.AddNullMask(builder, NullMask);
			IActorVisibility.AddPlayMode(builder, PlayMode);
			return IActorVisibility.EndIActorVisibility(builder);
		}

		// Token: 0x0602CE2D RID: 183853 RVA: 0x00623281 File Offset: 0x00621481
		public static void StartIActorVisibility(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602CE2E RID: 183854 RVA: 0x0062328A File Offset: 0x0062148A
		public static void AddActorIndex(FlatBufferBuilder builder, int actorIndex)
		{
			builder.AddInt(0, actorIndex, 0);
		}

		// Token: 0x0602CE2F RID: 183855 RVA: 0x00623295 File Offset: 0x00621495
		public static void AddPlayMode(FlatBufferBuilder builder, EActorVisibilityPlayMode playMode)
		{
			builder.AddByte(1, (byte)playMode, 0);
		}

		// Token: 0x0602CE30 RID: 183856 RVA: 0x006232A0 File Offset: 0x006214A0
		public static void AddEffect(FlatBufferBuilder builder, Offset<IActorVisibilityEffectDefault> effectOffset)
		{
			builder.AddOffset(2, effectOffset.Value, 0);
		}

		// Token: 0x0602CE31 RID: 183857 RVA: 0x006232B0 File Offset: 0x006214B0
		public static void AddFadeDuration(FlatBufferBuilder builder, float fadeDuration)
		{
			builder.AddFloat(3, fadeDuration, 0.0);
		}

		// Token: 0x0602CE32 RID: 183858 RVA: 0x006232C3 File Offset: 0x006214C3
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(4, delayTime, 0.0);
		}

		// Token: 0x0602CE33 RID: 183859 RVA: 0x006232D6 File Offset: 0x006214D6
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602CE34 RID: 183860 RVA: 0x006232E1 File Offset: 0x006214E1
		public static Offset<IActorVisibility> EndIActorVisibility(FlatBufferBuilder builder)
		{
			return new Offset<IActorVisibility>(builder.EndTable());
		}

		// Token: 0x0602CE35 RID: 183861 RVA: 0x006232F0 File Offset: 0x006214F0
		public IActorVisibilityT UnPack()
		{
			IActorVisibilityT actorVisibilityT = new IActorVisibilityT();
			this.UnPackTo(actorVisibilityT);
			return actorVisibilityT;
		}

		// Token: 0x0602CE36 RID: 183862 RVA: 0x0062330C File Offset: 0x0062150C
		public void UnPackTo(IActorVisibilityT _o)
		{
			_o.ActorIndex = this.ActorIndex;
			_o.PlayMode = this.PlayMode;
			_o.Effect = ((this.Effect != null) ? this.Effect.Value.UnPack() : null);
			_o.FadeDuration = this.FadeDuration;
			_o.DelayTime = this.DelayTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602CE37 RID: 183863 RVA: 0x00623384 File Offset: 0x00621584
		public static Offset<IActorVisibility> Pack(FlatBufferBuilder builder, IActorVisibilityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorVisibility>);
			}
			Offset<IActorVisibilityEffectDefault> effectOffset = (_o.Effect == null) ? default(Offset<IActorVisibilityEffectDefault>) : IActorVisibilityEffectDefault.Pack(builder, _o.Effect);
			return IActorVisibility.CreateIActorVisibility(builder, _o.ActorIndex, _o.PlayMode, effectOffset, _o.FadeDuration, _o.DelayTime, _o.NullMask);
		}

		// Token: 0x040112DD RID: 70365
		private Table __p;
	}
}
