using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007195 RID: 29077
	public struct IMaskTransition : IFlatbufferObject
	{
		// Token: 0x1700D4D6 RID: 54486
		// (get) Token: 0x060328C7 RID: 207047 RVA: 0x006D4A2E File Offset: 0x006D2C2E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060328C8 RID: 207048 RVA: 0x006D4A3B File Offset: 0x006D2C3B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060328C9 RID: 207049 RVA: 0x006D4A44 File Offset: 0x006D2C44
		public static IMaskTransition GetRootAsIMaskTransition(ByteBuffer _bb)
		{
			return IMaskTransition.GetRootAsIMaskTransition(_bb, default(IMaskTransition));
		}

		// Token: 0x060328CA RID: 207050 RVA: 0x006D4A60 File Offset: 0x006D2C60
		public static IMaskTransition GetRootAsIMaskTransition(ByteBuffer _bb, IMaskTransition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060328CB RID: 207051 RVA: 0x006D4A7D File Offset: 0x006D2C7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060328CC RID: 207052 RVA: 0x006D4A8C File Offset: 0x006D2C8C
		public IMaskTransition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D4D7 RID: 54487
		// (get) Token: 0x060328CD RID: 207053 RVA: 0x006D4A9C File Offset: 0x006D2C9C
		public ELevelSequenceTransition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELevelSequenceTransition.Camera;
				}
				return (ELevelSequenceTransition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D4D8 RID: 54488
		// (get) Token: 0x060328CE RID: 207054 RVA: 0x006D4AD8 File Offset: 0x006D2CD8
		public float Duration
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D4D9 RID: 54489
		// (get) Token: 0x060328CF RID: 207055 RVA: 0x006D4B18 File Offset: 0x006D2D18
		public ETransitionMask Mask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ETransitionMask.BlackMask;
				}
				return (ETransitionMask)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D4DA RID: 54490
		// (get) Token: 0x060328D0 RID: 207056 RVA: 0x006D4B54 File Offset: 0x006D2D54
		public IEaseData? FadeIn
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IEaseData?(default(IEaseData).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D4DB RID: 54491
		// (get) Token: 0x060328D1 RID: 207057 RVA: 0x006D4BB4 File Offset: 0x006D2DB4
		public IEaseData? FadeOut
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IEaseData?(default(IEaseData).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D4DC RID: 54492
		// (get) Token: 0x060328D2 RID: 207058 RVA: 0x006D4C14 File Offset: 0x006D2E14
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

		// Token: 0x060328D3 RID: 207059 RVA: 0x006D4C51 File Offset: 0x006D2E51
		public static Offset<IMaskTransition> CreateIMaskTransition(FlatBufferBuilder builder, ELevelSequenceTransition Type = ELevelSequenceTransition.Camera, float Duration = 0f, ETransitionMask Mask = ETransitionMask.BlackMask, Offset<IEaseData> FadeInOffset = default(Offset<IEaseData>), Offset<IEaseData> FadeOutOffset = default(Offset<IEaseData>), byte NullMask = 0)
		{
			builder.StartTable(6);
			IMaskTransition.AddFadeOut(builder, FadeOutOffset);
			IMaskTransition.AddFadeIn(builder, FadeInOffset);
			IMaskTransition.AddDuration(builder, Duration);
			IMaskTransition.AddNullMask(builder, NullMask);
			IMaskTransition.AddMask(builder, Mask);
			IMaskTransition.AddType(builder, Type);
			return IMaskTransition.EndIMaskTransition(builder);
		}

		// Token: 0x060328D4 RID: 207060 RVA: 0x006D4C8D File Offset: 0x006D2E8D
		public static void StartIMaskTransition(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060328D5 RID: 207061 RVA: 0x006D4C96 File Offset: 0x006D2E96
		public static void AddType(FlatBufferBuilder builder, ELevelSequenceTransition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060328D6 RID: 207062 RVA: 0x006D4CA1 File Offset: 0x006D2EA1
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(1, duration, 0.0);
		}

		// Token: 0x060328D7 RID: 207063 RVA: 0x006D4CB4 File Offset: 0x006D2EB4
		public static void AddMask(FlatBufferBuilder builder, ETransitionMask mask)
		{
			builder.AddByte(2, (byte)mask, 0);
		}

		// Token: 0x060328D8 RID: 207064 RVA: 0x006D4CBF File Offset: 0x006D2EBF
		public static void AddFadeIn(FlatBufferBuilder builder, Offset<IEaseData> fadeInOffset)
		{
			builder.AddOffset(3, fadeInOffset.Value, 0);
		}

		// Token: 0x060328D9 RID: 207065 RVA: 0x006D4CCF File Offset: 0x006D2ECF
		public static void AddFadeOut(FlatBufferBuilder builder, Offset<IEaseData> fadeOutOffset)
		{
			builder.AddOffset(4, fadeOutOffset.Value, 0);
		}

		// Token: 0x060328DA RID: 207066 RVA: 0x006D4CDF File Offset: 0x006D2EDF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060328DB RID: 207067 RVA: 0x006D4CEA File Offset: 0x006D2EEA
		public static Offset<IMaskTransition> EndIMaskTransition(FlatBufferBuilder builder)
		{
			return new Offset<IMaskTransition>(builder.EndTable());
		}

		// Token: 0x060328DC RID: 207068 RVA: 0x006D4CF8 File Offset: 0x006D2EF8
		public IMaskTransitionT UnPack()
		{
			IMaskTransitionT maskTransitionT = new IMaskTransitionT();
			this.UnPackTo(maskTransitionT);
			return maskTransitionT;
		}

		// Token: 0x060328DD RID: 207069 RVA: 0x006D4D14 File Offset: 0x006D2F14
		public void UnPackTo(IMaskTransitionT _o)
		{
			_o.Type = this.Type;
			_o.Duration = this.Duration;
			_o.Mask = this.Mask;
			_o.FadeIn = ((this.FadeIn != null) ? this.FadeIn.Value.UnPack() : null);
			_o.FadeOut = ((this.FadeOut != null) ? this.FadeOut.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060328DE RID: 207070 RVA: 0x006D4DB0 File Offset: 0x006D2FB0
		public static Offset<IMaskTransition> Pack(FlatBufferBuilder builder, IMaskTransitionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMaskTransition>);
			}
			Offset<IEaseData> fadeInOffset = (_o.FadeIn == null) ? default(Offset<IEaseData>) : IEaseData.Pack(builder, _o.FadeIn);
			Offset<IEaseData> fadeOutOffset = (_o.FadeOut == null) ? default(Offset<IEaseData>) : IEaseData.Pack(builder, _o.FadeOut);
			return IMaskTransition.CreateIMaskTransition(builder, _o.Type, _o.Duration, _o.Mask, fadeInOffset, fadeOutOffset, _o.NullMask);
		}

		// Token: 0x0401218F RID: 74127
		private Table __p;
	}
}
