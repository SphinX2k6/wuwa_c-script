using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FA2 RID: 4002
	public struct PhantomBattleBadgeGroup : IFlatbufferObject
	{
		// Token: 0x170025A1 RID: 9633
		// (get) Token: 0x0600AA8E RID: 43662 RVA: 0x002C701A File Offset: 0x002C521A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AA8F RID: 43663 RVA: 0x002C7027 File Offset: 0x002C5227
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AA90 RID: 43664 RVA: 0x002C7030 File Offset: 0x002C5230
		public static PhantomBattleBadgeGroup GetRootAsPhantomBattleBadgeGroup(ByteBuffer _bb)
		{
			return PhantomBattleBadgeGroup.GetRootAsPhantomBattleBadgeGroup(_bb, default(PhantomBattleBadgeGroup));
		}

		// Token: 0x0600AA91 RID: 43665 RVA: 0x002C704C File Offset: 0x002C524C
		public static PhantomBattleBadgeGroup GetRootAsPhantomBattleBadgeGroup(ByteBuffer _bb, PhantomBattleBadgeGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AA92 RID: 43666 RVA: 0x002C7069 File Offset: 0x002C5269
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AA93 RID: 43667 RVA: 0x002C7078 File Offset: 0x002C5278
		public PhantomBattleBadgeGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170025A2 RID: 9634
		// (get) Token: 0x0600AA94 RID: 43668 RVA: 0x002C7088 File Offset: 0x002C5288
		public int GroupId
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

		// Token: 0x170025A3 RID: 9635
		// (get) Token: 0x0600AA95 RID: 43669 RVA: 0x002C70C4 File Offset: 0x002C52C4
		public int ActivityId
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

		// Token: 0x170025A4 RID: 9636
		// (get) Token: 0x0600AA96 RID: 43670 RVA: 0x002C7100 File Offset: 0x002C5300
		public string Name
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

		// Token: 0x0600AA97 RID: 43671 RVA: 0x002C7137 File Offset: 0x002C5337
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600AA98 RID: 43672 RVA: 0x002C7146 File Offset: 0x002C5346
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170025A5 RID: 9637
		// (get) Token: 0x0600AA99 RID: 43673 RVA: 0x002C7160 File Offset: 0x002C5360
		public int Num
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

		// Token: 0x0600AA9A RID: 43674 RVA: 0x002C71A0 File Offset: 0x002C53A0
		public int PhantomBattleSkillId(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170025A6 RID: 9638
		// (get) Token: 0x0600AA9B RID: 43675 RVA: 0x002C71E0 File Offset: 0x002C53E0
		public int PhantomBattleSkillIdLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600AA9C RID: 43676 RVA: 0x002C720C File Offset: 0x002C540C
		public Span<int> GetPhantomBattleSkillIdBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600AA9D RID: 43677 RVA: 0x002C721C File Offset: 0x002C541C
		public int[] GetPhantomBattleSkillIdArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600AA9E RID: 43678 RVA: 0x002C7234 File Offset: 0x002C5434
		[NullableContext(1)]
		public int[] PhantomBattleSkillId()
		{
			return this.GetPhantomBattleSkillIdArray();
		}

		// Token: 0x0600AA9F RID: 43679 RVA: 0x002C723C File Offset: 0x002C543C
		[NullableContext(1)]
		public IEnumerable<int> PhantomBattleSkillIdIter()
		{
			PhantomBattleBadgeGroup.<PhantomBattleSkillIdIter>d__24 <PhantomBattleSkillIdIter>d__ = new PhantomBattleBadgeGroup.<PhantomBattleSkillIdIter>d__24(-2);
			<PhantomBattleSkillIdIter>d__.<>3__<>4__this = this;
			return <PhantomBattleSkillIdIter>d__;
		}

		// Token: 0x0400555D RID: 21853
		private Table __p;
	}
}
