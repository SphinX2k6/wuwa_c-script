using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200104C RID: 4172
	public struct QuestBranchComponentGroup : IFlatbufferObject
	{
		// Token: 0x17002BF4 RID: 11252
		// (get) Token: 0x0600BB19 RID: 47897 RVA: 0x002EB2FC File Offset: 0x002E94FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BB1A RID: 47898 RVA: 0x002EB309 File Offset: 0x002E9509
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BB1B RID: 47899 RVA: 0x002EB310 File Offset: 0x002E9510
		public static QuestBranchComponentGroup GetRootAsQuestBranchComponentGroup(ByteBuffer _bb)
		{
			return QuestBranchComponentGroup.GetRootAsQuestBranchComponentGroup(_bb, default(QuestBranchComponentGroup));
		}

		// Token: 0x0600BB1C RID: 47900 RVA: 0x002EB32C File Offset: 0x002E952C
		public static QuestBranchComponentGroup GetRootAsQuestBranchComponentGroup(ByteBuffer _bb, QuestBranchComponentGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BB1D RID: 47901 RVA: 0x002EB349 File Offset: 0x002E9549
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BB1E RID: 47902 RVA: 0x002EB358 File Offset: 0x002E9558
		public QuestBranchComponentGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002BF5 RID: 11253
		// (get) Token: 0x0600BB1F RID: 47903 RVA: 0x002EB368 File Offset: 0x002E9568
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

		// Token: 0x0600BB20 RID: 47904 RVA: 0x002EB3A4 File Offset: 0x002E95A4
		public int BranchComponents(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002BF6 RID: 11254
		// (get) Token: 0x0600BB21 RID: 47905 RVA: 0x002EB3E4 File Offset: 0x002E95E4
		public int BranchComponentsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600BB22 RID: 47906 RVA: 0x002EB40F File Offset: 0x002E960F
		public Span<int> GetBranchComponentsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600BB23 RID: 47907 RVA: 0x002EB41E File Offset: 0x002E961E
		public int[] GetBranchComponentsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600BB24 RID: 47908 RVA: 0x002EB438 File Offset: 0x002E9638
		public int ShownArea(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002BF7 RID: 11255
		// (get) Token: 0x0600BB25 RID: 47909 RVA: 0x002EB478 File Offset: 0x002E9678
		public int ShownAreaLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600BB26 RID: 47910 RVA: 0x002EB4A3 File Offset: 0x002E96A3
		public Span<int> GetShownAreaBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600BB27 RID: 47911 RVA: 0x002EB4B2 File Offset: 0x002E96B2
		public int[] GetShownAreaArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17002BF8 RID: 11256
		// (get) Token: 0x0600BB28 RID: 47912 RVA: 0x002EB4CC File Offset: 0x002E96CC
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

		// Token: 0x0600BB29 RID: 47913 RVA: 0x002EB509 File Offset: 0x002E9709
		[NullableContext(1)]
		public int[] BranchComponents()
		{
			return this.GetBranchComponentsArray();
		}

		// Token: 0x0600BB2A RID: 47914 RVA: 0x002EB511 File Offset: 0x002E9711
		[NullableContext(1)]
		public IEnumerable<int> BranchComponentsIter()
		{
			QuestBranchComponentGroup.<BranchComponentsIter>d__23 <BranchComponentsIter>d__ = new QuestBranchComponentGroup.<BranchComponentsIter>d__23(-2);
			<BranchComponentsIter>d__.<>3__<>4__this = this;
			return <BranchComponentsIter>d__;
		}

		// Token: 0x0600BB2B RID: 47915 RVA: 0x002EB526 File Offset: 0x002E9726
		[NullableContext(1)]
		public int[] ShownArea()
		{
			return this.GetShownAreaArray();
		}

		// Token: 0x0600BB2C RID: 47916 RVA: 0x002EB52E File Offset: 0x002E972E
		[NullableContext(1)]
		public IEnumerable<int> ShownAreaIter()
		{
			QuestBranchComponentGroup.<ShownAreaIter>d__25 <ShownAreaIter>d__ = new QuestBranchComponentGroup.<ShownAreaIter>d__25(-2);
			<ShownAreaIter>d__.<>3__<>4__this = this;
			return <ShownAreaIter>d__;
		}

		// Token: 0x0400561A RID: 22042
		private Table __p;
	}
}
