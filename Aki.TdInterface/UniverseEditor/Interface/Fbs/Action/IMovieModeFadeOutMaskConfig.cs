using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072B7 RID: 29367
	public struct IMovieModeFadeOutMaskConfig : IFlatbufferObject
	{
		// Token: 0x1700D755 RID: 55125
		// (get) Token: 0x0603331C RID: 209692 RVA: 0x006E87B1 File Offset: 0x006E69B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603331D RID: 209693 RVA: 0x006E87BE File Offset: 0x006E69BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603331E RID: 209694 RVA: 0x006E87C8 File Offset: 0x006E69C8
		public static IMovieModeFadeOutMaskConfig GetRootAsIMovieModeFadeOutMaskConfig(ByteBuffer _bb)
		{
			return IMovieModeFadeOutMaskConfig.GetRootAsIMovieModeFadeOutMaskConfig(_bb, default(IMovieModeFadeOutMaskConfig));
		}

		// Token: 0x0603331F RID: 209695 RVA: 0x006E87E4 File Offset: 0x006E69E4
		public static IMovieModeFadeOutMaskConfig GetRootAsIMovieModeFadeOutMaskConfig(ByteBuffer _bb, IMovieModeFadeOutMaskConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033320 RID: 209696 RVA: 0x006E8801 File Offset: 0x006E6A01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033321 RID: 209697 RVA: 0x006E8810 File Offset: 0x006E6A10
		public IMovieModeFadeOutMaskConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D756 RID: 55126
		// (get) Token: 0x06033322 RID: 209698 RVA: 0x006E8820 File Offset: 0x006E6A20
		public bool IsEnableMask
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D757 RID: 55127
		// (get) Token: 0x06033323 RID: 209699 RVA: 0x006E8860 File Offset: 0x006E6A60
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

		// Token: 0x1700D758 RID: 55128
		// (get) Token: 0x06033324 RID: 209700 RVA: 0x006E88A0 File Offset: 0x006E6AA0
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

		// Token: 0x06033325 RID: 209701 RVA: 0x006E88DC File Offset: 0x006E6ADC
		public static Offset<IMovieModeFadeOutMaskConfig> CreateIMovieModeFadeOutMaskConfig(FlatBufferBuilder builder, bool IsEnableMask = false, float TransitionTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			IMovieModeFadeOutMaskConfig.AddTransitionTime(builder, TransitionTime);
			IMovieModeFadeOutMaskConfig.AddNullMask(builder, NullMask);
			IMovieModeFadeOutMaskConfig.AddIsEnableMask(builder, IsEnableMask);
			return IMovieModeFadeOutMaskConfig.EndIMovieModeFadeOutMaskConfig(builder);
		}

		// Token: 0x06033326 RID: 209702 RVA: 0x006E8900 File Offset: 0x006E6B00
		public static void StartIMovieModeFadeOutMaskConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06033327 RID: 209703 RVA: 0x006E8909 File Offset: 0x006E6B09
		public static void AddIsEnableMask(FlatBufferBuilder builder, bool isEnableMask)
		{
			builder.AddBool(0, isEnableMask, false);
		}

		// Token: 0x06033328 RID: 209704 RVA: 0x006E8914 File Offset: 0x006E6B14
		public static void AddTransitionTime(FlatBufferBuilder builder, float transitionTime)
		{
			builder.AddFloat(1, transitionTime, 0.0);
		}

		// Token: 0x06033329 RID: 209705 RVA: 0x006E8927 File Offset: 0x006E6B27
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0603332A RID: 209706 RVA: 0x006E8932 File Offset: 0x006E6B32
		public static Offset<IMovieModeFadeOutMaskConfig> EndIMovieModeFadeOutMaskConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMovieModeFadeOutMaskConfig>(builder.EndTable());
		}

		// Token: 0x0603332B RID: 209707 RVA: 0x006E8940 File Offset: 0x006E6B40
		public IMovieModeFadeOutMaskConfigT UnPack()
		{
			IMovieModeFadeOutMaskConfigT movieModeFadeOutMaskConfigT = new IMovieModeFadeOutMaskConfigT();
			this.UnPackTo(movieModeFadeOutMaskConfigT);
			return movieModeFadeOutMaskConfigT;
		}

		// Token: 0x0603332C RID: 209708 RVA: 0x006E895B File Offset: 0x006E6B5B
		public void UnPackTo(IMovieModeFadeOutMaskConfigT _o)
		{
			_o.IsEnableMask = this.IsEnableMask;
			_o.TransitionTime = this.TransitionTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603332D RID: 209709 RVA: 0x006E8984 File Offset: 0x006E6B84
		public static Offset<IMovieModeFadeOutMaskConfig> Pack(FlatBufferBuilder builder, IMovieModeFadeOutMaskConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMovieModeFadeOutMaskConfig>);
			}
			return IMovieModeFadeOutMaskConfig.CreateIMovieModeFadeOutMaskConfig(builder, _o.IsEnableMask, _o.TransitionTime, _o.NullMask);
		}

		// Token: 0x04012353 RID: 74579
		private Table __p;
	}
}
