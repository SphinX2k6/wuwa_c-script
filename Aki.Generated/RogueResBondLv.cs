using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FEF RID: 4079
	public struct RogueResBondLv : IFlatbufferObject
	{
		// Token: 0x17002FB9 RID: 12217
		// (get) Token: 0x0600C0C2 RID: 49346 RVA: 0x002E8F8A File Offset: 0x002E718A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C0C3 RID: 49347 RVA: 0x002E8F97 File Offset: 0x002E7197
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C0C4 RID: 49348 RVA: 0x002E8FA0 File Offset: 0x002E71A0
		public static RogueResBondLv GetRootAsRogueResBondLv(ByteBuffer _bb)
		{
			return RogueResBondLv.GetRootAsRogueResBondLv(_bb, default(RogueResBondLv));
		}

		// Token: 0x0600C0C5 RID: 49349 RVA: 0x002E8FBC File Offset: 0x002E71BC
		public static RogueResBondLv GetRootAsRogueResBondLv(ByteBuffer _bb, RogueResBondLv obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C0C6 RID: 49350 RVA: 0x002E8FD9 File Offset: 0x002E71D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C0C7 RID: 49351 RVA: 0x002E8FE8 File Offset: 0x002E71E8
		public RogueResBondLv __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002FBA RID: 12218
		// (get) Token: 0x0600C0C8 RID: 49352 RVA: 0x002E8FF8 File Offset: 0x002E71F8
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

		// Token: 0x17002FBB RID: 12219
		// (get) Token: 0x0600C0C9 RID: 49353 RVA: 0x002E9034 File Offset: 0x002E7234
		public int Lv
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

		// Token: 0x17002FBC RID: 12220
		// (get) Token: 0x0600C0CA RID: 49354 RVA: 0x002E9070 File Offset: 0x002E7270
		public string LvColor
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

		// Token: 0x0600C0CB RID: 49355 RVA: 0x002E90A7 File Offset: 0x002E72A7
		public Span<byte> GetLvColorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C0CC RID: 49356 RVA: 0x002E90B6 File Offset: 0x002E72B6
		public byte[] GetLvColorArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040050D6 RID: 20694
		private Table __p;
	}
}
