using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001010 RID: 4112
	public struct PinballEffect : IFlatbufferObject
	{
		// Token: 0x170029A4 RID: 10660
		// (get) Token: 0x0600B4F0 RID: 46320 RVA: 0x002DE19B File Offset: 0x002DC39B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B4F1 RID: 46321 RVA: 0x002DE1A8 File Offset: 0x002DC3A8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B4F2 RID: 46322 RVA: 0x002DE1B0 File Offset: 0x002DC3B0
		public static PinballEffect GetRootAsPinballEffect(ByteBuffer _bb)
		{
			return PinballEffect.GetRootAsPinballEffect(_bb, default(PinballEffect));
		}

		// Token: 0x0600B4F3 RID: 46323 RVA: 0x002DE1CC File Offset: 0x002DC3CC
		public static PinballEffect GetRootAsPinballEffect(ByteBuffer _bb, PinballEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B4F4 RID: 46324 RVA: 0x002DE1E9 File Offset: 0x002DC3E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B4F5 RID: 46325 RVA: 0x002DE1F8 File Offset: 0x002DC3F8
		public PinballEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170029A5 RID: 10661
		// (get) Token: 0x0600B4F6 RID: 46326 RVA: 0x002DE208 File Offset: 0x002DC408
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

		// Token: 0x170029A6 RID: 10662
		// (get) Token: 0x0600B4F7 RID: 46327 RVA: 0x002DE244 File Offset: 0x002DC444
		public int Type
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

		// Token: 0x170029A7 RID: 10663
		// (get) Token: 0x0600B4F8 RID: 46328 RVA: 0x002DE280 File Offset: 0x002DC480
		public string Param1
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B4F9 RID: 46329 RVA: 0x002DE2B7 File Offset: 0x002DC4B7
		public Span<byte> GetParam1Bytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B4FA RID: 46330 RVA: 0x002DE2C6 File Offset: 0x002DC4C6
		public byte[] GetParam1Array()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170029A8 RID: 10664
		// (get) Token: 0x0600B4FB RID: 46331 RVA: 0x002DE2E0 File Offset: 0x002DC4E0
		public string Param2
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B4FC RID: 46332 RVA: 0x002DE318 File Offset: 0x002DC518
		public Span<byte> GetParam2Bytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B4FD RID: 46333 RVA: 0x002DE328 File Offset: 0x002DC528
		public byte[] GetParam2Array()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170029A9 RID: 10665
		// (get) Token: 0x0600B4FE RID: 46334 RVA: 0x002DE340 File Offset: 0x002DC540
		public string Param3
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B4FF RID: 46335 RVA: 0x002DE378 File Offset: 0x002DC578
		public Span<byte> GetParam3Bytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B500 RID: 46336 RVA: 0x002DE388 File Offset: 0x002DC588
		public byte[] GetParam3Array()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x040055D9 RID: 21977
		private Table __p;
	}
}
