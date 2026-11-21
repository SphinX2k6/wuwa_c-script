using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C7E RID: 3198
	public struct Contrast : IFlatbufferObject
	{
		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06005EFA RID: 24314 RVA: 0x0021EE7D File Offset: 0x0021D07D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005EFB RID: 24315 RVA: 0x0021EE8A File Offset: 0x0021D08A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005EFC RID: 24316 RVA: 0x0021EE94 File Offset: 0x0021D094
		public static Contrast GetRootAsContrast(ByteBuffer _bb)
		{
			return Contrast.GetRootAsContrast(_bb, default(Contrast));
		}

		// Token: 0x06005EFD RID: 24317 RVA: 0x0021EEB0 File Offset: 0x0021D0B0
		public static Contrast GetRootAsContrast(ByteBuffer _bb, Contrast obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005EFE RID: 24318 RVA: 0x0021EECD File Offset: 0x0021D0CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005EFF RID: 24319 RVA: 0x0021EEDC File Offset: 0x0021D0DC
		public Contrast __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06005F00 RID: 24320 RVA: 0x0021EEEC File Offset: 0x0021D0EC
		public int Id
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

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06005F01 RID: 24321 RVA: 0x0021EF28 File Offset: 0x0021D128
		public string BaseString
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

		// Token: 0x06005F02 RID: 24322 RVA: 0x0021EF5F File Offset: 0x0021D15F
		public Span<byte> GetBaseStringBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005F03 RID: 24323 RVA: 0x0021EF6E File Offset: 0x0021D16E
		public byte[] GetBaseStringArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06005F04 RID: 24324 RVA: 0x0021EF88 File Offset: 0x0021D188
		public int TargetInt
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

		// Token: 0x0400519F RID: 20895
		private Table __p;
	}
}
