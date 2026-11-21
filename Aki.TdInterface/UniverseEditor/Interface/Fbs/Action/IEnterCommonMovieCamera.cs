using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D22 RID: 27938
	public struct IEnterCommonMovieCamera : IFlatbufferObject
	{
		// Token: 0x1700CCF5 RID: 52469
		// (get) Token: 0x060302F2 RID: 197362 RVA: 0x0068D2CB File Offset: 0x0068B4CB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060302F3 RID: 197363 RVA: 0x0068D2D8 File Offset: 0x0068B4D8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060302F4 RID: 197364 RVA: 0x0068D2E0 File Offset: 0x0068B4E0
		public static IEnterCommonMovieCamera GetRootAsIEnterCommonMovieCamera(ByteBuffer _bb)
		{
			return IEnterCommonMovieCamera.GetRootAsIEnterCommonMovieCamera(_bb, default(IEnterCommonMovieCamera));
		}

		// Token: 0x060302F5 RID: 197365 RVA: 0x0068D2FC File Offset: 0x0068B4FC
		public static IEnterCommonMovieCamera GetRootAsIEnterCommonMovieCamera(ByteBuffer _bb, IEnterCommonMovieCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060302F6 RID: 197366 RVA: 0x0068D319 File Offset: 0x0068B519
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060302F7 RID: 197367 RVA: 0x0068D328 File Offset: 0x0068B528
		public IEnterCommonMovieCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CCF6 RID: 52470
		// (get) Token: 0x060302F8 RID: 197368 RVA: 0x0068D338 File Offset: 0x0068B538
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

		// Token: 0x1700CCF7 RID: 52471
		// (get) Token: 0x060302F9 RID: 197369 RVA: 0x0068D374 File Offset: 0x0068B574
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

		// Token: 0x060302FA RID: 197370 RVA: 0x0068D3AB File Offset: 0x0068B5AB
		public Span<byte> GetRowNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060302FB RID: 197371 RVA: 0x0068D3BA File Offset: 0x0068B5BA
		public byte[] GetRowNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700CCF8 RID: 52472
		// (get) Token: 0x060302FC RID: 197372 RVA: 0x0068D3C8 File Offset: 0x0068B5C8
		public int SpecElementIndex
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CCF9 RID: 52473
		// (get) Token: 0x060302FD RID: 197373 RVA: 0x0068D404 File Offset: 0x0068B604
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060302FE RID: 197374 RVA: 0x0068D441 File Offset: 0x0068B641
		public static Offset<IEnterCommonMovieCamera> CreateIEnterCommonMovieCamera(FlatBufferBuilder builder, EMovieCameraType Type = EMovieCameraType.Common, StringOffset RowNameOffset = default(StringOffset), int SpecElementIndex = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IEnterCommonMovieCamera.AddSpecElementIndex(builder, SpecElementIndex);
			IEnterCommonMovieCamera.AddRowName(builder, RowNameOffset);
			IEnterCommonMovieCamera.AddNullMask(builder, NullMask);
			IEnterCommonMovieCamera.AddType(builder, Type);
			return IEnterCommonMovieCamera.EndIEnterCommonMovieCamera(builder);
		}

		// Token: 0x060302FF RID: 197375 RVA: 0x0068D46D File Offset: 0x0068B66D
		public static void StartIEnterCommonMovieCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06030300 RID: 197376 RVA: 0x0068D476 File Offset: 0x0068B676
		public static void AddType(FlatBufferBuilder builder, EMovieCameraType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030301 RID: 197377 RVA: 0x0068D481 File Offset: 0x0068B681
		public static void AddRowName(FlatBufferBuilder builder, StringOffset rowNameOffset)
		{
			builder.AddOffset(1, rowNameOffset.Value, 0);
		}

		// Token: 0x06030302 RID: 197378 RVA: 0x0068D491 File Offset: 0x0068B691
		public static void AddSpecElementIndex(FlatBufferBuilder builder, int specElementIndex)
		{
			builder.AddInt(2, specElementIndex, 0);
		}

		// Token: 0x06030303 RID: 197379 RVA: 0x0068D49C File Offset: 0x0068B69C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06030304 RID: 197380 RVA: 0x0068D4A7 File Offset: 0x0068B6A7
		public static Offset<IEnterCommonMovieCamera> EndIEnterCommonMovieCamera(FlatBufferBuilder builder)
		{
			return new Offset<IEnterCommonMovieCamera>(builder.EndTable());
		}

		// Token: 0x06030305 RID: 197381 RVA: 0x0068D4B4 File Offset: 0x0068B6B4
		public IEnterCommonMovieCameraT UnPack()
		{
			IEnterCommonMovieCameraT enterCommonMovieCameraT = new IEnterCommonMovieCameraT();
			this.UnPackTo(enterCommonMovieCameraT);
			return enterCommonMovieCameraT;
		}

		// Token: 0x06030306 RID: 197382 RVA: 0x0068D4CF File Offset: 0x0068B6CF
		public void UnPackTo(IEnterCommonMovieCameraT _o)
		{
			_o.Type = this.Type;
			_o.RowName = this.RowName;
			_o.SpecElementIndex = this.SpecElementIndex;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06030307 RID: 197383 RVA: 0x0068D504 File Offset: 0x0068B704
		public static Offset<IEnterCommonMovieCamera> Pack(FlatBufferBuilder builder, IEnterCommonMovieCameraT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnterCommonMovieCamera>);
			}
			StringOffset rowNameOffset = (_o.RowName == null) ? default(StringOffset) : builder.CreateString(_o.RowName);
			return IEnterCommonMovieCamera.CreateIEnterCommonMovieCamera(builder, _o.Type, rowNameOffset, _o.SpecElementIndex, _o.NullMask);
		}

		// Token: 0x04011B86 RID: 72582
		private Table __p;
	}
}
