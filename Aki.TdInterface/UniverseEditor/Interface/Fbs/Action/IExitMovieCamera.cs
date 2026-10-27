using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006723 RID: 26403
	public struct IExitMovieCamera : IFlatbufferObject
	{
		// Token: 0x1700C41E RID: 50206
		// (get) Token: 0x0602DEDF RID: 188127 RVA: 0x0064776B File Offset: 0x0064596B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DEE0 RID: 188128 RVA: 0x00647778 File Offset: 0x00645978
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DEE1 RID: 188129 RVA: 0x00647780 File Offset: 0x00645980
		public static IExitMovieCamera GetRootAsIExitMovieCamera(ByteBuffer _bb)
		{
			return IExitMovieCamera.GetRootAsIExitMovieCamera(_bb, default(IExitMovieCamera));
		}

		// Token: 0x0602DEE2 RID: 188130 RVA: 0x0064779C File Offset: 0x0064599C
		public static IExitMovieCamera GetRootAsIExitMovieCamera(ByteBuffer _bb, IExitMovieCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DEE3 RID: 188131 RVA: 0x006477B9 File Offset: 0x006459B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DEE4 RID: 188132 RVA: 0x006477C8 File Offset: 0x006459C8
		public IExitMovieCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602DEE5 RID: 188133 RVA: 0x006477D8 File Offset: 0x006459D8
		public static void StartIExitMovieCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602DEE6 RID: 188134 RVA: 0x006477E1 File Offset: 0x006459E1
		public static Offset<IExitMovieCamera> EndIExitMovieCamera(FlatBufferBuilder builder)
		{
			return new Offset<IExitMovieCamera>(builder.EndTable());
		}

		// Token: 0x0602DEE7 RID: 188135 RVA: 0x006477F0 File Offset: 0x006459F0
		public IExitMovieCameraT UnPack()
		{
			IExitMovieCameraT exitMovieCameraT = new IExitMovieCameraT();
			this.UnPackTo(exitMovieCameraT);
			return exitMovieCameraT;
		}

		// Token: 0x0602DEE8 RID: 188136 RVA: 0x0064780B File Offset: 0x00645A0B
		public void UnPackTo(IExitMovieCameraT _o)
		{
		}

		// Token: 0x0602DEE9 RID: 188137 RVA: 0x00647810 File Offset: 0x00645A10
		public static Offset<IExitMovieCamera> Pack(FlatBufferBuilder builder, IExitMovieCameraT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExitMovieCamera>);
			}
			IExitMovieCamera.StartIExitMovieCamera(builder);
			return IExitMovieCamera.EndIExitMovieCamera(builder);
		}

		// Token: 0x04010E0A RID: 69130
		private Table __p;
	}
}
