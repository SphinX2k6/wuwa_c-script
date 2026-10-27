using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E19 RID: 3609
	public struct MonsterPerch : IFlatbufferObject
	{
		// Token: 0x17001F86 RID: 8070
		// (get) Token: 0x06009556 RID: 38230 RVA: 0x002881F9 File Offset: 0x002863F9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009557 RID: 38231 RVA: 0x00288206 File Offset: 0x00286406
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009558 RID: 38232 RVA: 0x00288210 File Offset: 0x00286410
		public static MonsterPerch GetRootAsMonsterPerch(ByteBuffer _bb)
		{
			return MonsterPerch.GetRootAsMonsterPerch(_bb, default(MonsterPerch));
		}

		// Token: 0x06009559 RID: 38233 RVA: 0x0028822C File Offset: 0x0028642C
		public static MonsterPerch GetRootAsMonsterPerch(ByteBuffer _bb, MonsterPerch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600955A RID: 38234 RVA: 0x00288249 File Offset: 0x00286449
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600955B RID: 38235 RVA: 0x00288258 File Offset: 0x00286458
		public MonsterPerch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001F87 RID: 8071
		// (get) Token: 0x0600955C RID: 38236 RVA: 0x00288268 File Offset: 0x00286468
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

		// Token: 0x17001F88 RID: 8072
		// (get) Token: 0x0600955D RID: 38237 RVA: 0x002882A4 File Offset: 0x002864A4
		public string PerchDes
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

		// Token: 0x0600955E RID: 38238 RVA: 0x002882DB File Offset: 0x002864DB
		public Span<byte> GetPerchDesBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600955F RID: 38239 RVA: 0x002882EA File Offset: 0x002864EA
		public byte[] GetPerchDesArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004EBE RID: 20158
		private Table __p;
	}
}
