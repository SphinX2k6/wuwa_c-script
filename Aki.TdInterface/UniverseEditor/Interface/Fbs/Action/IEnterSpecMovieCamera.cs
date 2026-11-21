using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D4C RID: 27980
	public struct IEnterSpecMovieCamera : IFlatbufferObject
	{
		// Token: 0x1700CD3C RID: 52540
		// (get) Token: 0x06030434 RID: 197684 RVA: 0x0068F659 File Offset: 0x0068D859
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030435 RID: 197685 RVA: 0x0068F666 File Offset: 0x0068D866
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030436 RID: 197686 RVA: 0x0068F670 File Offset: 0x0068D870
		public static IEnterSpecMovieCamera GetRootAsIEnterSpecMovieCamera(ByteBuffer _bb)
		{
			return IEnterSpecMovieCamera.GetRootAsIEnterSpecMovieCamera(_bb, default(IEnterSpecMovieCamera));
		}

		// Token: 0x06030437 RID: 197687 RVA: 0x0068F68C File Offset: 0x0068D88C
		public static IEnterSpecMovieCamera GetRootAsIEnterSpecMovieCamera(ByteBuffer _bb, IEnterSpecMovieCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030438 RID: 197688 RVA: 0x0068F6A9 File Offset: 0x0068D8A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030439 RID: 197689 RVA: 0x0068F6B8 File Offset: 0x0068D8B8
		public IEnterSpecMovieCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD3D RID: 52541
		// (get) Token: 0x0603043A RID: 197690 RVA: 0x0068F6C8 File Offset: 0x0068D8C8
		public EMovieCameraType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMovieCameraType.Common;
				}
				return (EMovieCameraType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CD3E RID: 52542
		// (get) Token: 0x0603043B RID: 197691 RVA: 0x0068F704 File Offset: 0x0068D904
		public string RowName
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603043C RID: 197692 RVA: 0x0068F73B File Offset: 0x0068D93B
		public Span<byte> GetRowNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0603043D RID: 197693 RVA: 0x0068F74A File Offset: 0x0068D94A
		public byte[] GetRowNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0603043E RID: 197694 RVA: 0x0068F758 File Offset: 0x0068D958
		public static Offset<IEnterSpecMovieCamera> CreateIEnterSpecMovieCamera(FlatBufferBuilder builder, EMovieCameraType Type = EMovieCameraType.Common, StringOffset RowNameOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IEnterSpecMovieCamera.AddRowName(builder, RowNameOffset);
			IEnterSpecMovieCamera.AddType(builder, Type);
			return IEnterSpecMovieCamera.EndIEnterSpecMovieCamera(builder);
		}

		// Token: 0x0603043F RID: 197695 RVA: 0x0068F775 File Offset: 0x0068D975
		public static void StartIEnterSpecMovieCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030440 RID: 197696 RVA: 0x0068F77E File Offset: 0x0068D97E
		public static void AddType(FlatBufferBuilder builder, EMovieCameraType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030441 RID: 197697 RVA: 0x0068F789 File Offset: 0x0068D989
		public static void AddRowName(FlatBufferBuilder builder, StringOffset rowNameOffset)
		{
			builder.AddOffset(1, rowNameOffset.Value, 0);
		}

		// Token: 0x06030442 RID: 197698 RVA: 0x0068F799 File Offset: 0x0068D999
		public static Offset<IEnterSpecMovieCamera> EndIEnterSpecMovieCamera(FlatBufferBuilder builder)
		{
			return new Offset<IEnterSpecMovieCamera>(builder.EndTable());
		}

		// Token: 0x06030443 RID: 197699 RVA: 0x0068F7A8 File Offset: 0x0068D9A8
		public IEnterSpecMovieCameraT UnPack()
		{
			IEnterSpecMovieCameraT enterSpecMovieCameraT = new IEnterSpecMovieCameraT();
			this.UnPackTo(enterSpecMovieCameraT);
			return enterSpecMovieCameraT;
		}

		// Token: 0x06030444 RID: 197700 RVA: 0x0068F7C3 File Offset: 0x0068D9C3
		public void UnPackTo(IEnterSpecMovieCameraT _o)
		{
			_o.Type = this.Type;
			_o.RowName = this.RowName;
		}

		// Token: 0x06030445 RID: 197701 RVA: 0x0068F7E0 File Offset: 0x0068D9E0
		public static Offset<IEnterSpecMovieCamera> Pack(FlatBufferBuilder builder, IEnterSpecMovieCameraT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnterSpecMovieCamera>);
			}
			StringOffset rowNameOffset = (_o.RowName == null) ? default(StringOffset) : builder.CreateString(_o.RowName);
			return IEnterSpecMovieCamera.CreateIEnterSpecMovieCamera(builder, _o.Type, rowNameOffset);
		}

		// Token: 0x04011BC1 RID: 72641
		private Table __p;
	}
}
