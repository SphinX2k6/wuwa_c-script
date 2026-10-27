using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E10 RID: 3600
	public struct MonsterCommunicationGroup : IFlatbufferObject
	{
		// Token: 0x17001F3C RID: 7996
		// (get) Token: 0x06009493 RID: 38035 RVA: 0x00286894 File Offset: 0x00284A94
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009494 RID: 38036 RVA: 0x002868A1 File Offset: 0x00284AA1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009495 RID: 38037 RVA: 0x002868A8 File Offset: 0x00284AA8
		public static MonsterCommunicationGroup GetRootAsMonsterCommunicationGroup(ByteBuffer _bb)
		{
			return MonsterCommunicationGroup.GetRootAsMonsterCommunicationGroup(_bb, default(MonsterCommunicationGroup));
		}

		// Token: 0x06009496 RID: 38038 RVA: 0x002868C4 File Offset: 0x00284AC4
		public static MonsterCommunicationGroup GetRootAsMonsterCommunicationGroup(ByteBuffer _bb, MonsterCommunicationGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009497 RID: 38039 RVA: 0x002868E1 File Offset: 0x00284AE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009498 RID: 38040 RVA: 0x002868F0 File Offset: 0x00284AF0
		public MonsterCommunicationGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001F3D RID: 7997
		// (get) Token: 0x06009499 RID: 38041 RVA: 0x00286900 File Offset: 0x00284B00
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

		// Token: 0x17001F3E RID: 7998
		// (get) Token: 0x0600949A RID: 38042 RVA: 0x0028693C File Offset: 0x00284B3C
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

		// Token: 0x0600949B RID: 38043 RVA: 0x00286973 File Offset: 0x00284B73
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600949C RID: 38044 RVA: 0x00286982 File Offset: 0x00284B82
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F3F RID: 7999
		// (get) Token: 0x0600949D RID: 38045 RVA: 0x0028699C File Offset: 0x00284B9C
		public string Desc
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

		// Token: 0x0600949E RID: 38046 RVA: 0x002869D3 File Offset: 0x00284BD3
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600949F RID: 38047 RVA: 0x002869E2 File Offset: 0x00284BE2
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004EB5 RID: 20149
		private Table __p;
	}
}
