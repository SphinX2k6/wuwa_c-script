using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066A8 RID: 26280
	public struct IEnterCommonMovieCamera : IFlatbufferObject
	{
		// Token: 0x1700C344 RID: 49988
		// (get) Token: 0x0602DAD5 RID: 187093 RVA: 0x00640017 File Offset: 0x0063E217
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DAD6 RID: 187094 RVA: 0x00640024 File Offset: 0x0063E224
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DAD7 RID: 187095 RVA: 0x0064002C File Offset: 0x0063E22C
		public static IEnterCommonMovieCamera GetRootAsIEnterCommonMovieCamera(ByteBuffer _bb)
		{
			return IEnterCommonMovieCamera.GetRootAsIEnterCommonMovieCamera(_bb, default(IEnterCommonMovieCamera));
		}

		// Token: 0x0602DAD8 RID: 187096 RVA: 0x00640048 File Offset: 0x0063E248
		public static IEnterCommonMovieCamera GetRootAsIEnterCommonMovieCamera(ByteBuffer _bb, IEnterCommonMovieCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DAD9 RID: 187097 RVA: 0x00640065 File Offset: 0x0063E265
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DADA RID: 187098 RVA: 0x00640074 File Offset: 0x0063E274
		public IEnterCommonMovieCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C345 RID: 49989
		// (get) Token: 0x0602DADB RID: 187099 RVA: 0x00640084 File Offset: 0x0063E284
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

		// Token: 0x1700C346 RID: 49990
		// (get) Token: 0x0602DADC RID: 187100 RVA: 0x006400C0 File Offset: 0x0063E2C0
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

		// Token: 0x0602DADD RID: 187101 RVA: 0x006400F7 File Offset: 0x0063E2F7
		public Span<byte> GetRowNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602DADE RID: 187102 RVA: 0x00640106 File Offset: 0x0063E306
		public byte[] GetRowNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700C347 RID: 49991
		// (get) Token: 0x0602DADF RID: 187103 RVA: 0x00640114 File Offset: 0x0063E314
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

		// Token: 0x1700C348 RID: 49992
		// (get) Token: 0x0602DAE0 RID: 187104 RVA: 0x00640150 File Offset: 0x0063E350
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

		// Token: 0x0602DAE1 RID: 187105 RVA: 0x0064018D File Offset: 0x0063E38D
		public static Offset<IEnterCommonMovieCamera> CreateIEnterCommonMovieCamera(FlatBufferBuilder builder, EMovieCameraType Type = EMovieCameraType.Common, StringOffset RowNameOffset = default(StringOffset), int SpecElementIndex = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IEnterCommonMovieCamera.AddSpecElementIndex(builder, SpecElementIndex);
			IEnterCommonMovieCamera.AddRowName(builder, RowNameOffset);
			IEnterCommonMovieCamera.AddNullMask(builder, NullMask);
			IEnterCommonMovieCamera.AddType(builder, Type);
			return IEnterCommonMovieCamera.EndIEnterCommonMovieCamera(builder);
		}

		// Token: 0x0602DAE2 RID: 187106 RVA: 0x006401B9 File Offset: 0x0063E3B9
		public static void StartIEnterCommonMovieCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602DAE3 RID: 187107 RVA: 0x006401C2 File Offset: 0x0063E3C2
		public static void AddType(FlatBufferBuilder builder, EMovieCameraType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DAE4 RID: 187108 RVA: 0x006401CD File Offset: 0x0063E3CD
		public static void AddRowName(FlatBufferBuilder builder, StringOffset rowNameOffset)
		{
			builder.AddOffset(1, rowNameOffset.Value, 0);
		}

		// Token: 0x0602DAE5 RID: 187109 RVA: 0x006401DD File Offset: 0x0063E3DD
		public static void AddSpecElementIndex(FlatBufferBuilder builder, int specElementIndex)
		{
			builder.AddInt(2, specElementIndex, 0);
		}

		// Token: 0x0602DAE6 RID: 187110 RVA: 0x006401E8 File Offset: 0x0063E3E8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602DAE7 RID: 187111 RVA: 0x006401F3 File Offset: 0x0063E3F3
		public static Offset<IEnterCommonMovieCamera> EndIEnterCommonMovieCamera(FlatBufferBuilder builder)
		{
			return new Offset<IEnterCommonMovieCamera>(builder.EndTable());
		}

		// Token: 0x0602DAE8 RID: 187112 RVA: 0x00640200 File Offset: 0x0063E400
		public IEnterCommonMovieCameraT UnPack()
		{
			IEnterCommonMovieCameraT enterCommonMovieCameraT = new IEnterCommonMovieCameraT();
			this.UnPackTo(enterCommonMovieCameraT);
			return enterCommonMovieCameraT;
		}

		// Token: 0x0602DAE9 RID: 187113 RVA: 0x0064021B File Offset: 0x0063E41B
		public void UnPackTo(IEnterCommonMovieCameraT _o)
		{
			_o.Type = this.Type;
			_o.RowName = this.RowName;
			_o.SpecElementIndex = this.SpecElementIndex;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602DAEA RID: 187114 RVA: 0x00640250 File Offset: 0x0063E450
		public static Offset<IEnterCommonMovieCamera> Pack(FlatBufferBuilder builder, IEnterCommonMovieCameraT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnterCommonMovieCamera>);
			}
			StringOffset rowNameOffset = (_o.RowName == null) ? default(StringOffset) : builder.CreateString(_o.RowName);
			return IEnterCommonMovieCamera.CreateIEnterCommonMovieCamera(builder, _o.Type, rowNameOffset, _o.SpecElementIndex, _o.NullMask);
		}

		// Token: 0x04010D60 RID: 68960
		private Table __p;
	}
}
