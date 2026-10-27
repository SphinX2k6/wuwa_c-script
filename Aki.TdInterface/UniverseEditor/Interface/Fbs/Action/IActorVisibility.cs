using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006110 RID: 24848
	public struct IActorVisibility : IFlatbufferObject
	{
		// Token: 0x1700B71B RID: 46875
		// (get) Token: 0x0602A73F RID: 173887 RVA: 0x005D9091 File Offset: 0x005D7291
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A740 RID: 173888 RVA: 0x005D909E File Offset: 0x005D729E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A741 RID: 173889 RVA: 0x005D90A8 File Offset: 0x005D72A8
		public static IActorVisibility GetRootAsIActorVisibility(ByteBuffer _bb)
		{
			return IActorVisibility.GetRootAsIActorVisibility(_bb, default(IActorVisibility));
		}

		// Token: 0x0602A742 RID: 173890 RVA: 0x005D90C4 File Offset: 0x005D72C4
		public static IActorVisibility GetRootAsIActorVisibility(ByteBuffer _bb, IActorVisibility obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A743 RID: 173891 RVA: 0x005D90E1 File Offset: 0x005D72E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A744 RID: 173892 RVA: 0x005D90F0 File Offset: 0x005D72F0
		public IActorVisibility __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B71C RID: 46876
		// (get) Token: 0x0602A745 RID: 173893 RVA: 0x005D9100 File Offset: 0x005D7300
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

		// Token: 0x1700B71D RID: 46877
		// (get) Token: 0x0602A746 RID: 173894 RVA: 0x005D913C File Offset: 0x005D733C
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

		// Token: 0x1700B71E RID: 46878
		// (get) Token: 0x0602A747 RID: 173895 RVA: 0x005D9178 File Offset: 0x005D7378
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

		// Token: 0x1700B71F RID: 46879
		// (get) Token: 0x0602A748 RID: 173896 RVA: 0x005D91D8 File Offset: 0x005D73D8
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

		// Token: 0x1700B720 RID: 46880
		// (get) Token: 0x0602A749 RID: 173897 RVA: 0x005D921C File Offset: 0x005D741C
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

		// Token: 0x1700B721 RID: 46881
		// (get) Token: 0x0602A74A RID: 173898 RVA: 0x005D9260 File Offset: 0x005D7460
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

		// Token: 0x0602A74B RID: 173899 RVA: 0x005D929D File Offset: 0x005D749D
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

		// Token: 0x0602A74C RID: 173900 RVA: 0x005D92D9 File Offset: 0x005D74D9
		public static void StartIActorVisibility(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602A74D RID: 173901 RVA: 0x005D92E2 File Offset: 0x005D74E2
		public static void AddActorIndex(FlatBufferBuilder builder, int actorIndex)
		{
			builder.AddInt(0, actorIndex, 0);
		}

		// Token: 0x0602A74E RID: 173902 RVA: 0x005D92ED File Offset: 0x005D74ED
		public static void AddPlayMode(FlatBufferBuilder builder, EActorVisibilityPlayMode playMode)
		{
			builder.AddByte(1, (byte)playMode, 0);
		}

		// Token: 0x0602A74F RID: 173903 RVA: 0x005D92F8 File Offset: 0x005D74F8
		public static void AddEffect(FlatBufferBuilder builder, Offset<IActorVisibilityEffectDefault> effectOffset)
		{
			builder.AddOffset(2, effectOffset.Value, 0);
		}

		// Token: 0x0602A750 RID: 173904 RVA: 0x005D9308 File Offset: 0x005D7508
		public static void AddFadeDuration(FlatBufferBuilder builder, float fadeDuration)
		{
			builder.AddFloat(3, fadeDuration, 0.0);
		}

		// Token: 0x0602A751 RID: 173905 RVA: 0x005D931B File Offset: 0x005D751B
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(4, delayTime, 0.0);
		}

		// Token: 0x0602A752 RID: 173906 RVA: 0x005D932E File Offset: 0x005D752E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602A753 RID: 173907 RVA: 0x005D9339 File Offset: 0x005D7539
		public static Offset<IActorVisibility> EndIActorVisibility(FlatBufferBuilder builder)
		{
			return new Offset<IActorVisibility>(builder.EndTable());
		}

		// Token: 0x0602A754 RID: 173908 RVA: 0x005D9348 File Offset: 0x005D7548
		public IActorVisibilityT UnPack()
		{
			IActorVisibilityT actorVisibilityT = new IActorVisibilityT();
			this.UnPackTo(actorVisibilityT);
			return actorVisibilityT;
		}

		// Token: 0x0602A755 RID: 173909 RVA: 0x005D9364 File Offset: 0x005D7564
		public void UnPackTo(IActorVisibilityT _o)
		{
			_o.ActorIndex = this.ActorIndex;
			_o.PlayMode = this.PlayMode;
			_o.Effect = ((this.Effect != null) ? this.Effect.Value.UnPack() : null);
			_o.FadeDuration = this.FadeDuration;
			_o.DelayTime = this.DelayTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A756 RID: 173910 RVA: 0x005D93DC File Offset: 0x005D75DC
		public static Offset<IActorVisibility> Pack(FlatBufferBuilder builder, IActorVisibilityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorVisibility>);
			}
			Offset<IActorVisibilityEffectDefault> effectOffset = (_o.Effect == null) ? default(Offset<IActorVisibilityEffectDefault>) : IActorVisibilityEffectDefault.Pack(builder, _o.Effect);
			return IActorVisibility.CreateIActorVisibility(builder, _o.ActorIndex, _o.PlayMode, effectOffset, _o.FadeDuration, _o.DelayTime, _o.NullMask);
		}

		// Token: 0x040104D9 RID: 66777
		private Table __p;
	}
}
