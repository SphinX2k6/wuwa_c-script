using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005894 RID: 22676
	public struct IRtSize : IFlatbufferObject
	{
		// Token: 0x1700A9B4 RID: 43444
		// (get) Token: 0x060263A8 RID: 156584 RVA: 0x005450FB File Offset: 0x005432FB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060263A9 RID: 156585 RVA: 0x00545108 File Offset: 0x00543308
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060263AA RID: 156586 RVA: 0x00545110 File Offset: 0x00543310
		public static IRtSize GetRootAsIRtSize(ByteBuffer _bb)
		{
			return IRtSize.GetRootAsIRtSize(_bb, default(IRtSize));
		}

		// Token: 0x060263AB RID: 156587 RVA: 0x0054512C File Offset: 0x0054332C
		public static IRtSize GetRootAsIRtSize(ByteBuffer _bb, IRtSize obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060263AC RID: 156588 RVA: 0x00545149 File Offset: 0x00543349
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060263AD RID: 156589 RVA: 0x00545158 File Offset: 0x00543358
		public IRtSize __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A9B5 RID: 43445
		// (get) Token: 0x060263AE RID: 156590 RVA: 0x00545168 File Offset: 0x00543368
		public int Length
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A9B6 RID: 43446
		// (get) Token: 0x060263AF RID: 156591 RVA: 0x005451A4 File Offset: 0x005433A4
		public int Width
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060263B0 RID: 156592 RVA: 0x005451E0 File Offset: 0x005433E0
		public static Offset<IRtSize> CreateIRtSize(FlatBufferBuilder builder, int Length = 0, int Width = 0)
		{
			builder.StartTable(2);
			IRtSize.AddWidth(builder, Width);
			IRtSize.AddLength(builder, Length);
			return IRtSize.EndIRtSize(builder);
		}

		// Token: 0x060263B1 RID: 156593 RVA: 0x005451FD File Offset: 0x005433FD
		public static void StartIRtSize(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060263B2 RID: 156594 RVA: 0x00545206 File Offset: 0x00543406
		public static void AddLength(FlatBufferBuilder builder, int length)
		{
			builder.AddInt(0, length, 0);
		}

		// Token: 0x060263B3 RID: 156595 RVA: 0x00545211 File Offset: 0x00543411
		public static void AddWidth(FlatBufferBuilder builder, int width)
		{
			builder.AddInt(1, width, 0);
		}

		// Token: 0x060263B4 RID: 156596 RVA: 0x0054521C File Offset: 0x0054341C
		public static Offset<IRtSize> EndIRtSize(FlatBufferBuilder builder)
		{
			return new Offset<IRtSize>(builder.EndTable());
		}

		// Token: 0x060263B5 RID: 156597 RVA: 0x0054522C File Offset: 0x0054342C
		public IRtSizeT UnPack()
		{
			IRtSizeT rtSizeT = new IRtSizeT();
			this.UnPackTo(rtSizeT);
			return rtSizeT;
		}

		// Token: 0x060263B6 RID: 156598 RVA: 0x00545247 File Offset: 0x00543447
		public void UnPackTo(IRtSizeT _o)
		{
			_o.Length = this.Length;
			_o.Width = this.Width;
		}

		// Token: 0x060263B7 RID: 156599 RVA: 0x00545264 File Offset: 0x00543464
		public static Offset<IRtSize> Pack(FlatBufferBuilder builder, IRtSizeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRtSize>);
			}
			return IRtSize.CreateIRtSize(builder, _o.Length, _o.Width);
		}

		// Token: 0x0400EDF1 RID: 60913
		private Table __p;
	}
}
