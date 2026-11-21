using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F28 RID: 16168
	public struct IVector2 : IFlatbufferObject
	{
		// Token: 0x17006D75 RID: 28021
		// (get) Token: 0x06015F7D RID: 89981 RVA: 0x003283AA File Offset: 0x003265AA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015F7E RID: 89982 RVA: 0x003283B7 File Offset: 0x003265B7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015F7F RID: 89983 RVA: 0x003283C0 File Offset: 0x003265C0
		public static IVector2 GetRootAsIVector2(ByteBuffer _bb)
		{
			return IVector2.GetRootAsIVector2(_bb, default(IVector2));
		}

		// Token: 0x06015F80 RID: 89984 RVA: 0x003283DC File Offset: 0x003265DC
		public static IVector2 GetRootAsIVector2(ByteBuffer _bb, IVector2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015F81 RID: 89985 RVA: 0x003283F9 File Offset: 0x003265F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015F82 RID: 89986 RVA: 0x00328408 File Offset: 0x00326608
		public IVector2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D76 RID: 28022
		// (get) Token: 0x06015F83 RID: 89987 RVA: 0x00328418 File Offset: 0x00326618
		public float X
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006D77 RID: 28023
		// (get) Token: 0x06015F84 RID: 89988 RVA: 0x00328458 File Offset: 0x00326658
		public float Y
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

		// Token: 0x17006D78 RID: 28024
		// (get) Token: 0x06015F85 RID: 89989 RVA: 0x00328498 File Offset: 0x00326698
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

		// Token: 0x06015F86 RID: 89990 RVA: 0x003284D4 File Offset: 0x003266D4
		public static Offset<IVector2> CreateIVector2(FlatBufferBuilder builder, float X = 0f, float Y = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			IVector2.AddY(builder, Y);
			IVector2.AddX(builder, X);
			IVector2.AddNullMask(builder, NullMask);
			return IVector2.EndIVector2(builder);
		}

		// Token: 0x06015F87 RID: 89991 RVA: 0x003284F8 File Offset: 0x003266F8
		public static void StartIVector2(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06015F88 RID: 89992 RVA: 0x00328501 File Offset: 0x00326701
		public static void AddX(FlatBufferBuilder builder, float x)
		{
			builder.AddFloat(0, x, 0.0);
		}

		// Token: 0x06015F89 RID: 89993 RVA: 0x00328514 File Offset: 0x00326714
		public static void AddY(FlatBufferBuilder builder, float y)
		{
			builder.AddFloat(1, y, 0.0);
		}

		// Token: 0x06015F8A RID: 89994 RVA: 0x00328527 File Offset: 0x00326727
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06015F8B RID: 89995 RVA: 0x00328532 File Offset: 0x00326732
		public static Offset<IVector2> EndIVector2(FlatBufferBuilder builder)
		{
			return new Offset<IVector2>(builder.EndTable());
		}

		// Token: 0x06015F8C RID: 89996 RVA: 0x00328540 File Offset: 0x00326740
		public IVector2T UnPack()
		{
			IVector2T vector2T = new IVector2T();
			this.UnPackTo(vector2T);
			return vector2T;
		}

		// Token: 0x06015F8D RID: 89997 RVA: 0x0032855B File Offset: 0x0032675B
		public void UnPackTo(IVector2T _o)
		{
			_o.X = this.X;
			_o.Y = this.Y;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06015F8E RID: 89998 RVA: 0x00328584 File Offset: 0x00326784
		public static Offset<IVector2> Pack(FlatBufferBuilder builder, IVector2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IVector2>);
			}
			return IVector2.CreateIVector2(builder, _o.X, _o.Y, _o.NullMask);
		}

		// Token: 0x0400B96B RID: 47467
		private Table __p;
	}
}
