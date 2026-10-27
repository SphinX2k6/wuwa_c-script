using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A87 RID: 14983
	public struct IColor : IFlatbufferObject
	{
		// Token: 0x17006699 RID: 26265
		// (get) Token: 0x06014505 RID: 83205 RVA: 0x002F6E59 File Offset: 0x002F5059
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014506 RID: 83206 RVA: 0x002F6E66 File Offset: 0x002F5066
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014507 RID: 83207 RVA: 0x002F6E70 File Offset: 0x002F5070
		public static IColor GetRootAsIColor(ByteBuffer _bb)
		{
			return IColor.GetRootAsIColor(_bb, default(IColor));
		}

		// Token: 0x06014508 RID: 83208 RVA: 0x002F6E8C File Offset: 0x002F508C
		public static IColor GetRootAsIColor(ByteBuffer _bb, IColor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014509 RID: 83209 RVA: 0x002F6EA9 File Offset: 0x002F50A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601450A RID: 83210 RVA: 0x002F6EB8 File Offset: 0x002F50B8
		public IColor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700669A RID: 26266
		// (get) Token: 0x0601450B RID: 83211 RVA: 0x002F6EC8 File Offset: 0x002F50C8
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

		// Token: 0x1700669B RID: 26267
		// (get) Token: 0x0601450C RID: 83212 RVA: 0x002F6F08 File Offset: 0x002F5108
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

		// Token: 0x1700669C RID: 26268
		// (get) Token: 0x0601450D RID: 83213 RVA: 0x002F6F48 File Offset: 0x002F5148
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

		// Token: 0x1700669D RID: 26269
		// (get) Token: 0x0601450E RID: 83214 RVA: 0x002F6F88 File Offset: 0x002F5188
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

		// Token: 0x1700669E RID: 26270
		// (get) Token: 0x0601450F RID: 83215 RVA: 0x002F6FCC File Offset: 0x002F51CC
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

		// Token: 0x06014510 RID: 83216 RVA: 0x002F7009 File Offset: 0x002F5209
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

		// Token: 0x06014511 RID: 83217 RVA: 0x002F703D File Offset: 0x002F523D
		public static void StartIColor(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06014512 RID: 83218 RVA: 0x002F7046 File Offset: 0x002F5246
		public static void AddR(FlatBufferBuilder builder, float r)
		{
			builder.AddFloat(0, r, 0.0);
		}

		// Token: 0x06014513 RID: 83219 RVA: 0x002F7059 File Offset: 0x002F5259
		public static void AddG(FlatBufferBuilder builder, float g)
		{
			builder.AddFloat(1, g, 0.0);
		}

		// Token: 0x06014514 RID: 83220 RVA: 0x002F706C File Offset: 0x002F526C
		public static void AddB(FlatBufferBuilder builder, float b)
		{
			builder.AddFloat(2, b, 0.0);
		}

		// Token: 0x06014515 RID: 83221 RVA: 0x002F707F File Offset: 0x002F527F
		public static void AddA(FlatBufferBuilder builder, float a)
		{
			builder.AddFloat(3, a, 0.0);
		}

		// Token: 0x06014516 RID: 83222 RVA: 0x002F7092 File Offset: 0x002F5292
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06014517 RID: 83223 RVA: 0x002F709D File Offset: 0x002F529D
		public static Offset<IColor> EndIColor(FlatBufferBuilder builder)
		{
			return new Offset<IColor>(builder.EndTable());
		}

		// Token: 0x06014518 RID: 83224 RVA: 0x002F70AC File Offset: 0x002F52AC
		public IColorT UnPack()
		{
			IColorT colorT = new IColorT();
			this.UnPackTo(colorT);
			return colorT;
		}

		// Token: 0x06014519 RID: 83225 RVA: 0x002F70C7 File Offset: 0x002F52C7
		public void UnPackTo(IColorT _o)
		{
			_o.R = this.R;
			_o.G = this.G;
			_o.B = this.B;
			_o.A = this.A;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601451A RID: 83226 RVA: 0x002F7108 File Offset: 0x002F5308
		public static Offset<IColor> Pack(FlatBufferBuilder builder, IColorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IColor>);
			}
			return IColor.CreateIColor(builder, _o.R, _o.G, _o.B, _o.A, _o.NullMask);
		}

		// Token: 0x0400AF00 RID: 44800
		private Table __p;
	}
}
