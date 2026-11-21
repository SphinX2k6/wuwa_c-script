using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DA3 RID: 28067
	public struct IExitMovieCamera : IFlatbufferObject
	{
		// Token: 0x1700CDD4 RID: 52692
		// (get) Token: 0x06030725 RID: 198437 RVA: 0x00694EAF File Offset: 0x006930AF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030726 RID: 198438 RVA: 0x00694EBC File Offset: 0x006930BC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030727 RID: 198439 RVA: 0x00694EC4 File Offset: 0x006930C4
		public static IExitMovieCamera GetRootAsIExitMovieCamera(ByteBuffer _bb)
		{
			return IExitMovieCamera.GetRootAsIExitMovieCamera(_bb, default(IExitMovieCamera));
		}

		// Token: 0x06030728 RID: 198440 RVA: 0x00694EE0 File Offset: 0x006930E0
		public static IExitMovieCamera GetRootAsIExitMovieCamera(ByteBuffer _bb, IExitMovieCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030729 RID: 198441 RVA: 0x00694EFD File Offset: 0x006930FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603072A RID: 198442 RVA: 0x00694F0C File Offset: 0x0069310C
		public IExitMovieCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0603072B RID: 198443 RVA: 0x00694F1C File Offset: 0x0069311C
		public static void StartIExitMovieCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0603072C RID: 198444 RVA: 0x00694F25 File Offset: 0x00693125
		public static Offset<IExitMovieCamera> EndIExitMovieCamera(FlatBufferBuilder builder)
		{
			return new Offset<IExitMovieCamera>(builder.EndTable());
		}

		// Token: 0x0603072D RID: 198445 RVA: 0x00694F34 File Offset: 0x00693134
		public IExitMovieCameraT UnPack()
		{
			IExitMovieCameraT exitMovieCameraT = new IExitMovieCameraT();
			this.UnPackTo(exitMovieCameraT);
			return exitMovieCameraT;
		}

		// Token: 0x0603072E RID: 198446 RVA: 0x00694F4F File Offset: 0x0069314F
		public void UnPackTo(IExitMovieCameraT _o)
		{
		}

		// Token: 0x0603072F RID: 198447 RVA: 0x00694F54 File Offset: 0x00693154
		public static Offset<IExitMovieCamera> Pack(FlatBufferBuilder builder, IExitMovieCameraT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExitMovieCamera>);
			}
			IExitMovieCamera.StartIExitMovieCamera(builder);
			return IExitMovieCamera.EndIExitMovieCamera(builder);
		}

		// Token: 0x04011C3C RID: 72764
		private Table __p;
	}
}
