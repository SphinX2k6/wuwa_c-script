using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001167 RID: 4455
	public struct TrapDefenseMonsterBody : IFlatbufferObject
	{
		// Token: 0x17003C59 RID: 15449
		// (get) Token: 0x0600E426 RID: 58406 RVA: 0x00339EC3 File Offset: 0x003380C3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E427 RID: 58407 RVA: 0x00339ED0 File Offset: 0x003380D0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E428 RID: 58408 RVA: 0x00339ED8 File Offset: 0x003380D8
		public static TrapDefenseMonsterBody GetRootAsTrapDefenseMonsterBody(ByteBuffer _bb)
		{
			return TrapDefenseMonsterBody.GetRootAsTrapDefenseMonsterBody(_bb, default(TrapDefenseMonsterBody));
		}

		// Token: 0x0600E429 RID: 58409 RVA: 0x00339EF4 File Offset: 0x003380F4
		public static TrapDefenseMonsterBody GetRootAsTrapDefenseMonsterBody(ByteBuffer _bb, TrapDefenseMonsterBody obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E42A RID: 58410 RVA: 0x00339F11 File Offset: 0x00338111
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E42B RID: 58411 RVA: 0x00339F20 File Offset: 0x00338120
		public TrapDefenseMonsterBody __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003C5A RID: 15450
		// (get) Token: 0x0600E42C RID: 58412 RVA: 0x00339F30 File Offset: 0x00338130
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

		// Token: 0x17003C5B RID: 15451
		// (get) Token: 0x0600E42D RID: 58413 RVA: 0x00339F6C File Offset: 0x0033816C
		public string Name
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

		// Token: 0x0600E42E RID: 58414 RVA: 0x00339FA3 File Offset: 0x003381A3
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E42F RID: 58415 RVA: 0x00339FB2 File Offset: 0x003381B2
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040052AD RID: 21165
		private Table __p;
	}
}
