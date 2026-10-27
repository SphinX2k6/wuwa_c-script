using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066D2 RID: 26322
	public struct IEnterSpecMovieCamera : IFlatbufferObject
	{
		// Token: 0x1700C38B RID: 50059
		// (get) Token: 0x0602DC17 RID: 187415 RVA: 0x006423A5 File Offset: 0x006405A5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DC18 RID: 187416 RVA: 0x006423B2 File Offset: 0x006405B2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DC19 RID: 187417 RVA: 0x006423BC File Offset: 0x006405BC
		public static IEnterSpecMovieCamera GetRootAsIEnterSpecMovieCamera(ByteBuffer _bb)
		{
			return IEnterSpecMovieCamera.GetRootAsIEnterSpecMovieCamera(_bb, default(IEnterSpecMovieCamera));
		}

		// Token: 0x0602DC1A RID: 187418 RVA: 0x006423D8 File Offset: 0x006405D8
		public static IEnterSpecMovieCamera GetRootAsIEnterSpecMovieCamera(ByteBuffer _bb, IEnterSpecMovieCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DC1B RID: 187419 RVA: 0x006423F5 File Offset: 0x006405F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DC1C RID: 187420 RVA: 0x00642404 File Offset: 0x00640604
		public IEnterSpecMovieCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C38C RID: 50060
		// (get) Token: 0x0602DC1D RID: 187421 RVA: 0x00642414 File Offset: 0x00640614
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

		// Token: 0x1700C38D RID: 50061
		// (get) Token: 0x0602DC1E RID: 187422 RVA: 0x00642450 File Offset: 0x00640650
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

		// Token: 0x0602DC1F RID: 187423 RVA: 0x00642487 File Offset: 0x00640687
		public Span<byte> GetRowNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602DC20 RID: 187424 RVA: 0x00642496 File Offset: 0x00640696
		public byte[] GetRowNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602DC21 RID: 187425 RVA: 0x006424A4 File Offset: 0x006406A4
		public static Offset<IEnterSpecMovieCamera> CreateIEnterSpecMovieCamera(FlatBufferBuilder builder, EMovieCameraType Type = EMovieCameraType.Common, StringOffset RowNameOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IEnterSpecMovieCamera.AddRowName(builder, RowNameOffset);
			IEnterSpecMovieCamera.AddType(builder, Type);
			return IEnterSpecMovieCamera.EndIEnterSpecMovieCamera(builder);
		}

		// Token: 0x0602DC22 RID: 187426 RVA: 0x006424C1 File Offset: 0x006406C1
		public static void StartIEnterSpecMovieCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602DC23 RID: 187427 RVA: 0x006424CA File Offset: 0x006406CA
		public static void AddType(FlatBufferBuilder builder, EMovieCameraType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DC24 RID: 187428 RVA: 0x006424D5 File Offset: 0x006406D5
		public static void AddRowName(FlatBufferBuilder builder, StringOffset rowNameOffset)
		{
			builder.AddOffset(1, rowNameOffset.Value, 0);
		}

		// Token: 0x0602DC25 RID: 187429 RVA: 0x006424E5 File Offset: 0x006406E5
		public static Offset<IEnterSpecMovieCamera> EndIEnterSpecMovieCamera(FlatBufferBuilder builder)
		{
			return new Offset<IEnterSpecMovieCamera>(builder.EndTable());
		}

		// Token: 0x0602DC26 RID: 187430 RVA: 0x006424F4 File Offset: 0x006406F4
		public IEnterSpecMovieCameraT UnPack()
		{
			IEnterSpecMovieCameraT enterSpecMovieCameraT = new IEnterSpecMovieCameraT();
			this.UnPackTo(enterSpecMovieCameraT);
			return enterSpecMovieCameraT;
		}

		// Token: 0x0602DC27 RID: 187431 RVA: 0x0064250F File Offset: 0x0064070F
		public void UnPackTo(IEnterSpecMovieCameraT _o)
		{
			_o.Type = this.Type;
			_o.RowName = this.RowName;
		}

		// Token: 0x0602DC28 RID: 187432 RVA: 0x0064252C File Offset: 0x0064072C
		public static Offset<IEnterSpecMovieCamera> Pack(FlatBufferBuilder builder, IEnterSpecMovieCameraT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnterSpecMovieCamera>);
			}
			StringOffset rowNameOffset = (_o.RowName == null) ? default(StringOffset) : builder.CreateString(_o.RowName);
			return IEnterSpecMovieCamera.CreateIEnterSpecMovieCamera(builder, _o.Type, rowNameOffset);
		}

		// Token: 0x04010D9B RID: 69019
		private Table __p;
	}
}
