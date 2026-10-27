using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A73 RID: 27251
	public struct IMaskTransition : IFlatbufferObject
	{
		// Token: 0x1700CA2B RID: 51755
		// (get) Token: 0x0602FBA1 RID: 195489 RVA: 0x0067E96E File Offset: 0x0067CB6E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FBA2 RID: 195490 RVA: 0x0067E97B File Offset: 0x0067CB7B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FBA3 RID: 195491 RVA: 0x0067E984 File Offset: 0x0067CB84
		public static IMaskTransition GetRootAsIMaskTransition(ByteBuffer _bb)
		{
			return IMaskTransition.GetRootAsIMaskTransition(_bb, default(IMaskTransition));
		}

		// Token: 0x0602FBA4 RID: 195492 RVA: 0x0067E9A0 File Offset: 0x0067CBA0
		public static IMaskTransition GetRootAsIMaskTransition(ByteBuffer _bb, IMaskTransition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FBA5 RID: 195493 RVA: 0x0067E9BD File Offset: 0x0067CBBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FBA6 RID: 195494 RVA: 0x0067E9CC File Offset: 0x0067CBCC
		public IMaskTransition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA2C RID: 51756
		// (get) Token: 0x0602FBA7 RID: 195495 RVA: 0x0067E9DC File Offset: 0x0067CBDC
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

		// Token: 0x1700CA2D RID: 51757
		// (get) Token: 0x0602FBA8 RID: 195496 RVA: 0x0067EA18 File Offset: 0x0067CC18
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

		// Token: 0x1700CA2E RID: 51758
		// (get) Token: 0x0602FBA9 RID: 195497 RVA: 0x0067EA58 File Offset: 0x0067CC58
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

		// Token: 0x1700CA2F RID: 51759
		// (get) Token: 0x0602FBAA RID: 195498 RVA: 0x0067EA94 File Offset: 0x0067CC94
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

		// Token: 0x1700CA30 RID: 51760
		// (get) Token: 0x0602FBAB RID: 195499 RVA: 0x0067EAF4 File Offset: 0x0067CCF4
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

		// Token: 0x1700CA31 RID: 51761
		// (get) Token: 0x0602FBAC RID: 195500 RVA: 0x0067EB54 File Offset: 0x0067CD54
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

		// Token: 0x0602FBAD RID: 195501 RVA: 0x0067EB91 File Offset: 0x0067CD91
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

		// Token: 0x0602FBAE RID: 195502 RVA: 0x0067EBCD File Offset: 0x0067CDCD
		public static void StartIMaskTransition(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602FBAF RID: 195503 RVA: 0x0067EBD6 File Offset: 0x0067CDD6
		public static void AddType(FlatBufferBuilder builder, ELevelSequenceTransition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FBB0 RID: 195504 RVA: 0x0067EBE1 File Offset: 0x0067CDE1
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(1, duration, 0.0);
		}

		// Token: 0x0602FBB1 RID: 195505 RVA: 0x0067EBF4 File Offset: 0x0067CDF4
		public static void AddMask(FlatBufferBuilder builder, ETransitionMask mask)
		{
			builder.AddByte(2, (byte)mask, 0);
		}

		// Token: 0x0602FBB2 RID: 195506 RVA: 0x0067EBFF File Offset: 0x0067CDFF
		public static void AddFadeIn(FlatBufferBuilder builder, Offset<IEaseData> fadeInOffset)
		{
			builder.AddOffset(3, fadeInOffset.Value, 0);
		}

		// Token: 0x0602FBB3 RID: 195507 RVA: 0x0067EC0F File Offset: 0x0067CE0F
		public static void AddFadeOut(FlatBufferBuilder builder, Offset<IEaseData> fadeOutOffset)
		{
			builder.AddOffset(4, fadeOutOffset.Value, 0);
		}

		// Token: 0x0602FBB4 RID: 195508 RVA: 0x0067EC1F File Offset: 0x0067CE1F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602FBB5 RID: 195509 RVA: 0x0067EC2A File Offset: 0x0067CE2A
		public static Offset<IMaskTransition> EndIMaskTransition(FlatBufferBuilder builder)
		{
			return new Offset<IMaskTransition>(builder.EndTable());
		}

		// Token: 0x0602FBB6 RID: 195510 RVA: 0x0067EC38 File Offset: 0x0067CE38
		public IMaskTransitionT UnPack()
		{
			IMaskTransitionT maskTransitionT = new IMaskTransitionT();
			this.UnPackTo(maskTransitionT);
			return maskTransitionT;
		}

		// Token: 0x0602FBB7 RID: 195511 RVA: 0x0067EC54 File Offset: 0x0067CE54
		public void UnPackTo(IMaskTransitionT _o)
		{
			_o.Type = this.Type;
			_o.Duration = this.Duration;
			_o.Mask = this.Mask;
			_o.FadeIn = ((this.FadeIn != null) ? this.FadeIn.Value.UnPack() : null);
			_o.FadeOut = ((this.FadeOut != null) ? this.FadeOut.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602FBB8 RID: 195512 RVA: 0x0067ECF0 File Offset: 0x0067CEF0
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

		// Token: 0x04011297 RID: 70295
		private Table __p;
	}
}
