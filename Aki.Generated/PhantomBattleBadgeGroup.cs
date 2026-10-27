using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EBD RID: 3773
	public struct PhantomBattleBadgeGroup : IFlatbufferObject
	{
		// Token: 0x1700253B RID: 9531
		// (get) Token: 0x0600A46D RID: 42093 RVA: 0x002A9D71 File Offset: 0x002A7F71
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A46E RID: 42094 RVA: 0x002A9D7E File Offset: 0x002A7F7E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A46F RID: 42095 RVA: 0x002A9D88 File Offset: 0x002A7F88
		public static PhantomBattleBadgeGroup GetRootAsPhantomBattleBadgeGroup(ByteBuffer _bb)
		{
			return PhantomBattleBadgeGroup.GetRootAsPhantomBattleBadgeGroup(_bb, default(PhantomBattleBadgeGroup));
		}

		// Token: 0x0600A470 RID: 42096 RVA: 0x002A9DA4 File Offset: 0x002A7FA4
		public static PhantomBattleBadgeGroup GetRootAsPhantomBattleBadgeGroup(ByteBuffer _bb, PhantomBattleBadgeGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A471 RID: 42097 RVA: 0x002A9DC1 File Offset: 0x002A7FC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A472 RID: 42098 RVA: 0x002A9DD0 File Offset: 0x002A7FD0
		public PhantomBattleBadgeGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700253C RID: 9532
		// (get) Token: 0x0600A473 RID: 42099 RVA: 0x002A9DE0 File Offset: 0x002A7FE0
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

		// Token: 0x1700253D RID: 9533
		// (get) Token: 0x0600A474 RID: 42100 RVA: 0x002A9E1C File Offset: 0x002A801C
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

		// Token: 0x1700253E RID: 9534
		// (get) Token: 0x0600A475 RID: 42101 RVA: 0x002A9E58 File Offset: 0x002A8058
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

		// Token: 0x0600A476 RID: 42102 RVA: 0x002A9E8F File Offset: 0x002A808F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A477 RID: 42103 RVA: 0x002A9E9E File Offset: 0x002A809E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700253F RID: 9535
		// (get) Token: 0x0600A478 RID: 42104 RVA: 0x002A9EB8 File Offset: 0x002A80B8
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

		// Token: 0x0600A479 RID: 42105 RVA: 0x002A9EF8 File Offset: 0x002A80F8
		public int PhantomBattleSkillId(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002540 RID: 9536
		// (get) Token: 0x0600A47A RID: 42106 RVA: 0x002A9F38 File Offset: 0x002A8138
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

		// Token: 0x0600A47B RID: 42107 RVA: 0x002A9F64 File Offset: 0x002A8164
		public Span<int> GetPhantomBattleSkillIdBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600A47C RID: 42108 RVA: 0x002A9F74 File Offset: 0x002A8174
		public int[] GetPhantomBattleSkillIdArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600A47D RID: 42109 RVA: 0x002A9F8C File Offset: 0x002A818C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PhantomBattleSkillIdIter()或GetPhantomBattleSkillIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PhantomBattleSkillId()
		{
			PhantomBattleBadgeGroup phantomBattleBadgeGroup = this;
			return phantomBattleBadgeGroup.GetPhantomBattleSkillIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A47E RID: 42110 RVA: 0x002A9FB0 File Offset: 0x002A81B0
		[NullableContext(1)]
		public readonly IEnumerable<int> PhantomBattleSkillIdIter()
		{
			PhantomBattleBadgeGroup.<PhantomBattleSkillIdIter>d__24 <PhantomBattleSkillIdIter>d__ = new PhantomBattleBadgeGroup.<PhantomBattleSkillIdIter>d__24(-2);
			<PhantomBattleSkillIdIter>d__.<>3__<>4__this = this;
			return <PhantomBattleSkillIdIter>d__;
		}

		// Token: 0x04004F78 RID: 20344
		private Table __p;
	}
}
