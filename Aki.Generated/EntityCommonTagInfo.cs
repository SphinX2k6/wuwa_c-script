using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D16 RID: 3350
	public struct EntityCommonTagInfo : IFlatbufferObject
	{
		// Token: 0x17000F71 RID: 3953
		// (get) Token: 0x06006F5C RID: 28508 RVA: 0x00242D2E File Offset: 0x00240F2E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006F5D RID: 28509 RVA: 0x00242D3B File Offset: 0x00240F3B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006F5E RID: 28510 RVA: 0x00242D44 File Offset: 0x00240F44
		public static EntityCommonTagInfo GetRootAsEntityCommonTagInfo(ByteBuffer _bb)
		{
			return EntityCommonTagInfo.GetRootAsEntityCommonTagInfo(_bb, default(EntityCommonTagInfo));
		}

		// Token: 0x06006F5F RID: 28511 RVA: 0x00242D60 File Offset: 0x00240F60
		public static EntityCommonTagInfo GetRootAsEntityCommonTagInfo(ByteBuffer _bb, EntityCommonTagInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006F60 RID: 28512 RVA: 0x00242D7D File Offset: 0x00240F7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006F61 RID: 28513 RVA: 0x00242D8C File Offset: 0x00240F8C
		public EntityCommonTagInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F72 RID: 3954
		// (get) Token: 0x06006F62 RID: 28514 RVA: 0x00242D9C File Offset: 0x00240F9C
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

		// Token: 0x17000F73 RID: 3955
		// (get) Token: 0x06006F63 RID: 28515 RVA: 0x00242DD8 File Offset: 0x00240FD8
		public string UglyTagName
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

		// Token: 0x06006F64 RID: 28516 RVA: 0x00242E0F File Offset: 0x0024100F
		public Span<byte> GetUglyTagNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006F65 RID: 28517 RVA: 0x00242E1E File Offset: 0x0024101E
		public byte[] GetUglyTagNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005256 RID: 21078
		private Table __p;
	}
}
