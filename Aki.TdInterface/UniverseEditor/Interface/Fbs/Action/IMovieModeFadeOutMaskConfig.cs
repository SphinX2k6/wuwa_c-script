using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B71 RID: 27505
	public struct IMovieModeFadeOutMaskConfig : IFlatbufferObject
	{
		// Token: 0x1700CC70 RID: 52336
		// (get) Token: 0x060304C4 RID: 197828 RVA: 0x00690191 File Offset: 0x0068E391
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060304C5 RID: 197829 RVA: 0x0069019E File Offset: 0x0068E39E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060304C6 RID: 197830 RVA: 0x006901A8 File Offset: 0x0068E3A8
		public static IMovieModeFadeOutMaskConfig GetRootAsIMovieModeFadeOutMaskConfig(ByteBuffer _bb)
		{
			return IMovieModeFadeOutMaskConfig.GetRootAsIMovieModeFadeOutMaskConfig(_bb, default(IMovieModeFadeOutMaskConfig));
		}

		// Token: 0x060304C7 RID: 197831 RVA: 0x006901C4 File Offset: 0x0068E3C4
		public static IMovieModeFadeOutMaskConfig GetRootAsIMovieModeFadeOutMaskConfig(ByteBuffer _bb, IMovieModeFadeOutMaskConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060304C8 RID: 197832 RVA: 0x006901E1 File Offset: 0x0068E3E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060304C9 RID: 197833 RVA: 0x006901F0 File Offset: 0x0068E3F0
		public IMovieModeFadeOutMaskConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC71 RID: 52337
		// (get) Token: 0x060304CA RID: 197834 RVA: 0x00690200 File Offset: 0x0068E400
		public bool IsEnableMask
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CC72 RID: 52338
		// (get) Token: 0x060304CB RID: 197835 RVA: 0x00690240 File Offset: 0x0068E440
		public float TransitionTime
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

		// Token: 0x1700CC73 RID: 52339
		// (get) Token: 0x060304CC RID: 197836 RVA: 0x00690280 File Offset: 0x0068E480
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060304CD RID: 197837 RVA: 0x006902BC File Offset: 0x0068E4BC
		public static Offset<IMovieModeFadeOutMaskConfig> CreateIMovieModeFadeOutMaskConfig(FlatBufferBuilder builder, bool IsEnableMask = false, float TransitionTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			IMovieModeFadeOutMaskConfig.AddTransitionTime(builder, TransitionTime);
			IMovieModeFadeOutMaskConfig.AddNullMask(builder, NullMask);
			IMovieModeFadeOutMaskConfig.AddIsEnableMask(builder, IsEnableMask);
			return IMovieModeFadeOutMaskConfig.EndIMovieModeFadeOutMaskConfig(builder);
		}

		// Token: 0x060304CE RID: 197838 RVA: 0x006902E0 File Offset: 0x0068E4E0
		public static void StartIMovieModeFadeOutMaskConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060304CF RID: 197839 RVA: 0x006902E9 File Offset: 0x0068E4E9
		public static void AddIsEnableMask(FlatBufferBuilder builder, bool isEnableMask)
		{
			builder.AddBool(0, isEnableMask, false);
		}

		// Token: 0x060304D0 RID: 197840 RVA: 0x006902F4 File Offset: 0x0068E4F4
		public static void AddTransitionTime(FlatBufferBuilder builder, float transitionTime)
		{
			builder.AddFloat(1, transitionTime, 0.0);
		}

		// Token: 0x060304D1 RID: 197841 RVA: 0x00690307 File Offset: 0x0068E507
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060304D2 RID: 197842 RVA: 0x00690312 File Offset: 0x0068E512
		public static Offset<IMovieModeFadeOutMaskConfig> EndIMovieModeFadeOutMaskConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMovieModeFadeOutMaskConfig>(builder.EndTable());
		}

		// Token: 0x060304D3 RID: 197843 RVA: 0x00690320 File Offset: 0x0068E520
		public IMovieModeFadeOutMaskConfigT UnPack()
		{
			IMovieModeFadeOutMaskConfigT movieModeFadeOutMaskConfigT = new IMovieModeFadeOutMaskConfigT();
			this.UnPackTo(movieModeFadeOutMaskConfigT);
			return movieModeFadeOutMaskConfigT;
		}

		// Token: 0x060304D4 RID: 197844 RVA: 0x0069033B File Offset: 0x0068E53B
		public void UnPackTo(IMovieModeFadeOutMaskConfigT _o)
		{
			_o.IsEnableMask = this.IsEnableMask;
			_o.TransitionTime = this.TransitionTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060304D5 RID: 197845 RVA: 0x00690364 File Offset: 0x0068E564
		public static Offset<IMovieModeFadeOutMaskConfig> Pack(FlatBufferBuilder builder, IMovieModeFadeOutMaskConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMovieModeFadeOutMaskConfig>);
			}
			return IMovieModeFadeOutMaskConfig.CreateIMovieModeFadeOutMaskConfig(builder, _o.IsEnableMask, _o.TransitionTime, _o.NullMask);
		}

		// Token: 0x0401142A RID: 70698
		private Table __p;
	}
}
