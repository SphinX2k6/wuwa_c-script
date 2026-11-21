using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FD9 RID: 4057
	public struct PhantomPlanParam : IFlatbufferObject
	{
		// Token: 0x1700279D RID: 10141
		// (get) Token: 0x0600AFFF RID: 45055 RVA: 0x002D3042 File Offset: 0x002D1242
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B000 RID: 45056 RVA: 0x002D304F File Offset: 0x002D124F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B001 RID: 45057 RVA: 0x002D3058 File Offset: 0x002D1258
		public static PhantomPlanParam GetRootAsPhantomPlanParam(ByteBuffer _bb)
		{
			return PhantomPlanParam.GetRootAsPhantomPlanParam(_bb, default(PhantomPlanParam));
		}

		// Token: 0x0600B002 RID: 45058 RVA: 0x002D3074 File Offset: 0x002D1274
		public static PhantomPlanParam GetRootAsPhantomPlanParam(ByteBuffer _bb, PhantomPlanParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B003 RID: 45059 RVA: 0x002D3091 File Offset: 0x002D1291
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B004 RID: 45060 RVA: 0x002D30A0 File Offset: 0x002D12A0
		public PhantomPlanParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700279E RID: 10142
		// (get) Token: 0x0600B005 RID: 45061 RVA: 0x002D30B0 File Offset: 0x002D12B0
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

		// Token: 0x1700279F RID: 10143
		// (get) Token: 0x0600B006 RID: 45062 RVA: 0x002D30EC File Offset: 0x002D12EC
		public int SkillBranchId
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

		// Token: 0x170027A0 RID: 10144
		// (get) Token: 0x0600B007 RID: 45063 RVA: 0x002D3128 File Offset: 0x002D1328
		public string SkillBranchText
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

		// Token: 0x0600B008 RID: 45064 RVA: 0x002D315F File Offset: 0x002D135F
		public Span<byte> GetSkillBranchTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B009 RID: 45065 RVA: 0x002D316E File Offset: 0x002D136E
		public byte[] GetSkillBranchTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0400559E RID: 21918
		private Table __p;
	}
}
