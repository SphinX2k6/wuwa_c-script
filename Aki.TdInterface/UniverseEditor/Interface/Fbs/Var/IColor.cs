using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E62 RID: 15970
	public struct IColor : IFlatbufferObject
	{
		// Token: 0x17006BC9 RID: 27593
		// (get) Token: 0x06015821 RID: 88097 RVA: 0x0031A045 File Offset: 0x00318245
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015822 RID: 88098 RVA: 0x0031A052 File Offset: 0x00318252
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015823 RID: 88099 RVA: 0x0031A05C File Offset: 0x0031825C
		public static IColor GetRootAsIColor(ByteBuffer _bb)
		{
			return IColor.GetRootAsIColor(_bb, default(IColor));
		}

		// Token: 0x06015824 RID: 88100 RVA: 0x0031A078 File Offset: 0x00318278
		public static IColor GetRootAsIColor(ByteBuffer _bb, IColor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015825 RID: 88101 RVA: 0x0031A095 File Offset: 0x00318295
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015826 RID: 88102 RVA: 0x0031A0A4 File Offset: 0x003182A4
		public IColor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006BCA RID: 27594
		// (get) Token: 0x06015827 RID: 88103 RVA: 0x0031A0B4 File Offset: 0x003182B4
		public float R
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

		// Token: 0x17006BCB RID: 27595
		// (get) Token: 0x06015828 RID: 88104 RVA: 0x0031A0F4 File Offset: 0x003182F4
		public float G
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

		// Token: 0x17006BCC RID: 27596
		// (get) Token: 0x06015829 RID: 88105 RVA: 0x0031A134 File Offset: 0x00318334
		public float B
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006BCD RID: 27597
		// (get) Token: 0x0601582A RID: 88106 RVA: 0x0031A174 File Offset: 0x00318374
		public float A
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006BCE RID: 27598
		// (get) Token: 0x0601582B RID: 88107 RVA: 0x0031A1B8 File Offset: 0x003183B8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601582C RID: 88108 RVA: 0x0031A1F5 File Offset: 0x003183F5
		public static Offset<IColor> CreateIColor(FlatBufferBuilder builder, float R = 0f, float G = 0f, float B = 0f, float A = 0f, byte NullMask = 0)
		{
			builder.StartTable(5);
			IColor.AddA(builder, A);
			IColor.AddB(builder, B);
			IColor.AddG(builder, G);
			IColor.AddR(builder, R);
			IColor.AddNullMask(builder, NullMask);
			return IColor.EndIColor(builder);
		}

		// Token: 0x0601582D RID: 88109 RVA: 0x0031A229 File Offset: 0x00318429
		public static void StartIColor(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601582E RID: 88110 RVA: 0x0031A232 File Offset: 0x00318432
		public static void AddR(FlatBufferBuilder builder, float r)
		{
			builder.AddFloat(0, r, 0.0);
		}

		// Token: 0x0601582F RID: 88111 RVA: 0x0031A245 File Offset: 0x00318445
		public static void AddG(FlatBufferBuilder builder, float g)
		{
			builder.AddFloat(1, g, 0.0);
		}

		// Token: 0x06015830 RID: 88112 RVA: 0x0031A258 File Offset: 0x00318458
		public static void AddB(FlatBufferBuilder builder, float b)
		{
			builder.AddFloat(2, b, 0.0);
		}

		// Token: 0x06015831 RID: 88113 RVA: 0x0031A26B File Offset: 0x0031846B
		public static void AddA(FlatBufferBuilder builder, float a)
		{
			builder.AddFloat(3, a, 0.0);
		}

		// Token: 0x06015832 RID: 88114 RVA: 0x0031A27E File Offset: 0x0031847E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06015833 RID: 88115 RVA: 0x0031A289 File Offset: 0x00318489
		public static Offset<IColor> EndIColor(FlatBufferBuilder builder)
		{
			return new Offset<IColor>(builder.EndTable());
		}

		// Token: 0x06015834 RID: 88116 RVA: 0x0031A298 File Offset: 0x00318498
		public IColorT UnPack()
		{
			IColorT colorT = new IColorT();
			this.UnPackTo(colorT);
			return colorT;
		}

		// Token: 0x06015835 RID: 88117 RVA: 0x0031A2B3 File Offset: 0x003184B3
		public void UnPackTo(IColorT _o)
		{
			_o.R = this.R;
			_o.G = this.G;
			_o.B = this.B;
			_o.A = this.A;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06015836 RID: 88118 RVA: 0x0031A2F4 File Offset: 0x003184F4
		public static Offset<IColor> Pack(FlatBufferBuilder builder, IColorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IColor>);
			}
			return IColor.CreateIColor(builder, _o.R, _o.G, _o.B, _o.A, _o.NullMask);
		}

		// Token: 0x0400B822 RID: 47138
		private Table __p;
	}
}
