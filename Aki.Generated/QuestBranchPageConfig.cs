using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200104E RID: 4174
	public struct QuestBranchPageConfig : IFlatbufferObject
	{
		// Token: 0x17002C02 RID: 11266
		// (get) Token: 0x0600BB4E RID: 47950 RVA: 0x002EB934 File Offset: 0x002E9B34
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BB4F RID: 47951 RVA: 0x002EB941 File Offset: 0x002E9B41
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BB50 RID: 47952 RVA: 0x002EB948 File Offset: 0x002E9B48
		public static QuestBranchPageConfig GetRootAsQuestBranchPageConfig(ByteBuffer _bb)
		{
			return QuestBranchPageConfig.GetRootAsQuestBranchPageConfig(_bb, default(QuestBranchPageConfig));
		}

		// Token: 0x0600BB51 RID: 47953 RVA: 0x002EB964 File Offset: 0x002E9B64
		public static QuestBranchPageConfig GetRootAsQuestBranchPageConfig(ByteBuffer _bb, QuestBranchPageConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BB52 RID: 47954 RVA: 0x002EB981 File Offset: 0x002E9B81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BB53 RID: 47955 RVA: 0x002EB990 File Offset: 0x002E9B90
		public QuestBranchPageConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C03 RID: 11267
		// (get) Token: 0x0600BB54 RID: 47956 RVA: 0x002EB9A0 File Offset: 0x002E9BA0
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

		// Token: 0x0600BB55 RID: 47957 RVA: 0x002EB9DC File Offset: 0x002E9BDC
		public int Branch(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002C04 RID: 11268
		// (get) Token: 0x0600BB56 RID: 47958 RVA: 0x002EBA1C File Offset: 0x002E9C1C
		public int BranchLength
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

		// Token: 0x0600BB57 RID: 47959 RVA: 0x002EBA47 File Offset: 0x002E9C47
		public Span<int> GetBranchBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600BB58 RID: 47960 RVA: 0x002EBA56 File Offset: 0x002E9C56
		public int[] GetBranchArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600BB59 RID: 47961 RVA: 0x002EBA70 File Offset: 0x002E9C70
		public IntVector2D? QuestNodes(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IntVector2D?(default(IntVector2D).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002C05 RID: 11269
		// (get) Token: 0x0600BB5A RID: 47962 RVA: 0x002EBAD0 File Offset: 0x002E9CD0
		public int QuestNodesLength
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

		// Token: 0x0600BB5B RID: 47963 RVA: 0x002EBAFB File Offset: 0x002E9CFB
		[NullableContext(1)]
		public int[] Branch()
		{
			return this.GetBranchArray();
		}

		// Token: 0x0600BB5C RID: 47964 RVA: 0x002EBB03 File Offset: 0x002E9D03
		[NullableContext(1)]
		public IEnumerable<int> BranchIter()
		{
			QuestBranchPageConfig.<BranchIter>d__19 <BranchIter>d__ = new QuestBranchPageConfig.<BranchIter>d__19(-2);
			<BranchIter>d__.<>3__<>4__this = this;
			return <BranchIter>d__;
		}

		// Token: 0x0600BB5D RID: 47965 RVA: 0x002EBB18 File Offset: 0x002E9D18
		[NullableContext(1)]
		public IntVector2D[] QuestNodes()
		{
			return this.QuestNodesIter().ToArray<IntVector2D>();
		}

		// Token: 0x0600BB5E RID: 47966 RVA: 0x002EBB25 File Offset: 0x002E9D25
		[NullableContext(1)]
		public IEnumerable<IntVector2D> QuestNodesIter()
		{
			QuestBranchPageConfig.<QuestNodesIter>d__21 <QuestNodesIter>d__ = new QuestBranchPageConfig.<QuestNodesIter>d__21(-2);
			<QuestNodesIter>d__.<>3__<>4__this = this;
			return <QuestNodesIter>d__;
		}

		// Token: 0x0400561C RID: 22044
		private Table __p;
	}
}
