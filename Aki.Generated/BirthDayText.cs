using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C13 RID: 3091
	public struct BirthDayText : IFlatbufferObject
	{
		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x0600531C RID: 21276 RVA: 0x00204138 File Offset: 0x00202338
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600531D RID: 21277 RVA: 0x00204145 File Offset: 0x00202345
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600531E RID: 21278 RVA: 0x0020414C File Offset: 0x0020234C
		public static BirthDayText GetRootAsBirthDayText(ByteBuffer _bb)
		{
			return BirthDayText.GetRootAsBirthDayText(_bb, default(BirthDayText));
		}

		// Token: 0x0600531F RID: 21279 RVA: 0x00204168 File Offset: 0x00202368
		public static BirthDayText GetRootAsBirthDayText(ByteBuffer _bb, BirthDayText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005320 RID: 21280 RVA: 0x00204185 File Offset: 0x00202385
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005321 RID: 21281 RVA: 0x00204194 File Offset: 0x00202394
		public BirthDayText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06005322 RID: 21282 RVA: 0x002041A4 File Offset: 0x002023A4
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

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06005323 RID: 21283 RVA: 0x002041E0 File Offset: 0x002023E0
		public int Date
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

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06005324 RID: 21284 RVA: 0x0020421C File Offset: 0x0020241C
		public int DateType
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

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06005325 RID: 21285 RVA: 0x00204258 File Offset: 0x00202458
		public string TextId
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

		// Token: 0x06005326 RID: 21286 RVA: 0x00204290 File Offset: 0x00202490
		public Span<byte> GetTextIdBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005327 RID: 21287 RVA: 0x002042A0 File Offset: 0x002024A0
		public byte[] GetTextIdArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0400510E RID: 20750
		private Table __p;
	}
}
