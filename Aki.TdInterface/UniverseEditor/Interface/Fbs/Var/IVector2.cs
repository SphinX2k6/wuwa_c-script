using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B26 RID: 15142
	public struct IVector2 : IFlatbufferObject
	{
		// Token: 0x170067DA RID: 26586
		// (get) Token: 0x06014AD3 RID: 84691 RVA: 0x0030211A File Offset: 0x0030031A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014AD4 RID: 84692 RVA: 0x00302127 File Offset: 0x00300327
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014AD5 RID: 84693 RVA: 0x00302130 File Offset: 0x00300330
		public static IVector2 GetRootAsIVector2(ByteBuffer _bb)
		{
			return IVector2.GetRootAsIVector2(_bb, default(IVector2));
		}

		// Token: 0x06014AD6 RID: 84694 RVA: 0x0030214C File Offset: 0x0030034C
		public static IVector2 GetRootAsIVector2(ByteBuffer _bb, IVector2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014AD7 RID: 84695 RVA: 0x00302169 File Offset: 0x00300369
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014AD8 RID: 84696 RVA: 0x00302178 File Offset: 0x00300378
		public IVector2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170067DB RID: 26587
		// (get) Token: 0x06014AD9 RID: 84697 RVA: 0x00302188 File Offset: 0x00300388
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

		// Token: 0x170067DC RID: 26588
		// (get) Token: 0x06014ADA RID: 84698 RVA: 0x003021C8 File Offset: 0x003003C8
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

		// Token: 0x170067DD RID: 26589
		// (get) Token: 0x06014ADB RID: 84699 RVA: 0x00302208 File Offset: 0x00300408
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

		// Token: 0x06014ADC RID: 84700 RVA: 0x00302244 File Offset: 0x00300444
		public static Offset<IVector2> CreateIVector2(FlatBufferBuilder builder, float X = 0f, float Y = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			IVector2.AddY(builder, Y);
			IVector2.AddX(builder, X);
			IVector2.AddNullMask(builder, NullMask);
			return IVector2.EndIVector2(builder);
		}

		// Token: 0x06014ADD RID: 84701 RVA: 0x00302268 File Offset: 0x00300468
		public static void StartIVector2(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06014ADE RID: 84702 RVA: 0x00302271 File Offset: 0x00300471
		public static void AddX(FlatBufferBuilder builder, float x)
		{
			builder.AddFloat(0, x, 0.0);
		}

		// Token: 0x06014ADF RID: 84703 RVA: 0x00302284 File Offset: 0x00300484
		public static void AddY(FlatBufferBuilder builder, float y)
		{
			builder.AddFloat(1, y, 0.0);
		}

		// Token: 0x06014AE0 RID: 84704 RVA: 0x00302297 File Offset: 0x00300497
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06014AE1 RID: 84705 RVA: 0x003022A2 File Offset: 0x003004A2
		public static Offset<IVector2> EndIVector2(FlatBufferBuilder builder)
		{
			return new Offset<IVector2>(builder.EndTable());
		}

		// Token: 0x06014AE2 RID: 84706 RVA: 0x003022B0 File Offset: 0x003004B0
		public IVector2T UnPack()
		{
			IVector2T vector2T = new IVector2T();
			this.UnPackTo(vector2T);
			return vector2T;
		}

		// Token: 0x06014AE3 RID: 84707 RVA: 0x003022CB File Offset: 0x003004CB
		public void UnPackTo(IVector2T _o)
		{
			_o.X = this.X;
			_o.Y = this.Y;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06014AE4 RID: 84708 RVA: 0x003022F4 File Offset: 0x003004F4
		public static Offset<IVector2> Pack(FlatBufferBuilder builder, IVector2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IVector2>);
			}
			return IVector2.CreateIVector2(builder, _o.X, _o.Y, _o.NullMask);
		}

		// Token: 0x0400AFFE RID: 45054
		private Table __p;
	}
}
