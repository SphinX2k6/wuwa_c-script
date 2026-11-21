using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FAA RID: 4010
	public struct PhantomBattleCardGroupInfo : IFlatbufferObject
	{
		// Token: 0x1700261F RID: 9759
		// (get) Token: 0x0600ABE1 RID: 44001 RVA: 0x002C9EB4 File Offset: 0x002C80B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600ABE2 RID: 44002 RVA: 0x002C9EC1 File Offset: 0x002C80C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600ABE3 RID: 44003 RVA: 0x002C9EC8 File Offset: 0x002C80C8
		public static PhantomBattleCardGroupInfo GetRootAsPhantomBattleCardGroupInfo(ByteBuffer _bb)
		{
			return PhantomBattleCardGroupInfo.GetRootAsPhantomBattleCardGroupInfo(_bb, default(PhantomBattleCardGroupInfo));
		}

		// Token: 0x0600ABE4 RID: 44004 RVA: 0x002C9EE4 File Offset: 0x002C80E4
		public static PhantomBattleCardGroupInfo GetRootAsPhantomBattleCardGroupInfo(ByteBuffer _bb, PhantomBattleCardGroupInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600ABE5 RID: 44005 RVA: 0x002C9F01 File Offset: 0x002C8101
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600ABE6 RID: 44006 RVA: 0x002C9F10 File Offset: 0x002C8110
		public PhantomBattleCardGroupInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002620 RID: 9760
		// (get) Token: 0x0600ABE7 RID: 44007 RVA: 0x002C9F20 File Offset: 0x002C8120
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

		// Token: 0x17002621 RID: 9761
		// (get) Token: 0x0600ABE8 RID: 44008 RVA: 0x002C9F5C File Offset: 0x002C815C
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

		// Token: 0x0600ABE9 RID: 44009 RVA: 0x002C9F93 File Offset: 0x002C8193
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600ABEA RID: 44010 RVA: 0x002C9FA2 File Offset: 0x002C81A2
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002622 RID: 9762
		// (get) Token: 0x0600ABEB RID: 44011 RVA: 0x002C9FBC File Offset: 0x002C81BC
		public bool CoreSlotLocked
		{
			get
			{
				int num = this.__p.__offset(8);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002623 RID: 9763
		// (get) Token: 0x0600ABEC RID: 44012 RVA: 0x002C9FFC File Offset: 0x002C81FC
		public int CoreCardCountLimit
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002624 RID: 9764
		// (get) Token: 0x0600ABED RID: 44013 RVA: 0x002CA03C File Offset: 0x002C823C
		public int FieldCardCountLimit
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002625 RID: 9765
		// (get) Token: 0x0600ABEE RID: 44014 RVA: 0x002CA07C File Offset: 0x002C827C
		public int ItemCardCountLimit
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002626 RID: 9766
		// (get) Token: 0x0600ABEF RID: 44015 RVA: 0x002CA0BC File Offset: 0x002C82BC
		public int NormalCardCountLimit
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002627 RID: 9767
		// (get) Token: 0x0600ABF0 RID: 44016 RVA: 0x002CA0FC File Offset: 0x002C82FC
		public int ElementCountLimit
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005566 RID: 21862
		private Table __p;
	}
}
