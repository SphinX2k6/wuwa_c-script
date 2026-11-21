using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001060 RID: 4192
	public struct QuestTimePointConfig : IFlatbufferObject
	{
		// Token: 0x17002C7A RID: 11386
		// (get) Token: 0x0600BCB5 RID: 48309 RVA: 0x002EE4F3 File Offset: 0x002EC6F3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BCB6 RID: 48310 RVA: 0x002EE500 File Offset: 0x002EC700
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BCB7 RID: 48311 RVA: 0x002EE508 File Offset: 0x002EC708
		public static QuestTimePointConfig GetRootAsQuestTimePointConfig(ByteBuffer _bb)
		{
			return QuestTimePointConfig.GetRootAsQuestTimePointConfig(_bb, default(QuestTimePointConfig));
		}

		// Token: 0x0600BCB8 RID: 48312 RVA: 0x002EE524 File Offset: 0x002EC724
		public static QuestTimePointConfig GetRootAsQuestTimePointConfig(ByteBuffer _bb, QuestTimePointConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BCB9 RID: 48313 RVA: 0x002EE541 File Offset: 0x002EC741
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BCBA RID: 48314 RVA: 0x002EE550 File Offset: 0x002EC750
		public QuestTimePointConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C7B RID: 11387
		// (get) Token: 0x0600BCBB RID: 48315 RVA: 0x002EE560 File Offset: 0x002EC760
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

		// Token: 0x17002C7C RID: 11388
		// (get) Token: 0x0600BCBC RID: 48316 RVA: 0x002EE59C File Offset: 0x002EC79C
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

		// Token: 0x0600BCBD RID: 48317 RVA: 0x002EE5D3 File Offset: 0x002EC7D3
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600BCBE RID: 48318 RVA: 0x002EE5E2 File Offset: 0x002EC7E2
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C7D RID: 11389
		// (get) Token: 0x0600BCBF RID: 48319 RVA: 0x002EE5FC File Offset: 0x002EC7FC
		public string NameBottom
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

		// Token: 0x0600BCC0 RID: 48320 RVA: 0x002EE633 File Offset: 0x002EC833
		public Span<byte> GetNameBottomBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600BCC1 RID: 48321 RVA: 0x002EE642 File Offset: 0x002EC842
		public byte[] GetNameBottomArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C7E RID: 11390
		// (get) Token: 0x0600BCC2 RID: 48322 RVA: 0x002EE65C File Offset: 0x002EC85C
		public int UnlockCondition
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

		// Token: 0x17002C7F RID: 11391
		// (get) Token: 0x0600BCC3 RID: 48323 RVA: 0x002EE69C File Offset: 0x002EC89C
		public int QuestId
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

		// Token: 0x17002C80 RID: 11392
		// (get) Token: 0x0600BCC4 RID: 48324 RVA: 0x002EE6DC File Offset: 0x002EC8DC
		public string ScreenEffect
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BCC5 RID: 48325 RVA: 0x002EE714 File Offset: 0x002EC914
		public Span<byte> GetScreenEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600BCC6 RID: 48326 RVA: 0x002EE724 File Offset: 0x002EC924
		public byte[] GetScreenEffectArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C81 RID: 11393
		// (get) Token: 0x0600BCC7 RID: 48327 RVA: 0x002EE73C File Offset: 0x002EC93C
		public int BranchPage
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

		// Token: 0x0600BCC8 RID: 48328 RVA: 0x002EE77C File Offset: 0x002EC97C
		public int ComponentGroup(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002C82 RID: 11394
		// (get) Token: 0x0600BCC9 RID: 48329 RVA: 0x002EE7BC File Offset: 0x002EC9BC
		public int ComponentGroupLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600BCCA RID: 48330 RVA: 0x002EE7E8 File Offset: 0x002EC9E8
		public Span<int> GetComponentGroupBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600BCCB RID: 48331 RVA: 0x002EE7F8 File Offset: 0x002EC9F8
		public int[] GetComponentGroupArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x17002C83 RID: 11395
		// (get) Token: 0x0600BCCC RID: 48332 RVA: 0x002EE810 File Offset: 0x002ECA10
		public int Sort
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002C84 RID: 11396
		// (get) Token: 0x0600BCCD RID: 48333 RVA: 0x002EE850 File Offset: 0x002ECA50
		public string Title
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BCCE RID: 48334 RVA: 0x002EE888 File Offset: 0x002ECA88
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600BCCF RID: 48335 RVA: 0x002EE898 File Offset: 0x002ECA98
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C85 RID: 11397
		// (get) Token: 0x0600BCD0 RID: 48336 RVA: 0x002EE8B0 File Offset: 0x002ECAB0
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BCD1 RID: 48337 RVA: 0x002EE8E8 File Offset: 0x002ECAE8
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600BCD2 RID: 48338 RVA: 0x002EE8F8 File Offset: 0x002ECAF8
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C86 RID: 11398
		// (get) Token: 0x0600BCD3 RID: 48339 RVA: 0x002EE910 File Offset: 0x002ECB10
		public bool IsBranchNode
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600BCD4 RID: 48340 RVA: 0x002EE950 File Offset: 0x002ECB50
		[NullableContext(1)]
		public int[] ComponentGroup()
		{
			return this.GetComponentGroupArray();
		}

		// Token: 0x0600BCD5 RID: 48341 RVA: 0x002EE958 File Offset: 0x002ECB58
		[NullableContext(1)]
		public IEnumerable<int> ComponentGroupIter()
		{
			QuestTimePointConfig.<ComponentGroupIter>d__46 <ComponentGroupIter>d__ = new QuestTimePointConfig.<ComponentGroupIter>d__46(-2);
			<ComponentGroupIter>d__.<>3__<>4__this = this;
			return <ComponentGroupIter>d__;
		}

		// Token: 0x0400562E RID: 22062
		private Table __p;
	}
}
