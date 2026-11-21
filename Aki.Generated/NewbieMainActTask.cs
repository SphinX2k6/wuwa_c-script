using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F69 RID: 3945
	public struct NewbieMainActTask : IFlatbufferObject
	{
		// Token: 0x1700236D RID: 9069
		// (get) Token: 0x0600A4AA RID: 42154 RVA: 0x002B9D0D File Offset: 0x002B7F0D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A4AB RID: 42155 RVA: 0x002B9D1A File Offset: 0x002B7F1A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A4AC RID: 42156 RVA: 0x002B9D24 File Offset: 0x002B7F24
		public static NewbieMainActTask GetRootAsNewbieMainActTask(ByteBuffer _bb)
		{
			return NewbieMainActTask.GetRootAsNewbieMainActTask(_bb, default(NewbieMainActTask));
		}

		// Token: 0x0600A4AD RID: 42157 RVA: 0x002B9D40 File Offset: 0x002B7F40
		public static NewbieMainActTask GetRootAsNewbieMainActTask(ByteBuffer _bb, NewbieMainActTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A4AE RID: 42158 RVA: 0x002B9D5D File Offset: 0x002B7F5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A4AF RID: 42159 RVA: 0x002B9D6C File Offset: 0x002B7F6C
		public NewbieMainActTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700236E RID: 9070
		// (get) Token: 0x0600A4B0 RID: 42160 RVA: 0x002B9D7C File Offset: 0x002B7F7C
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

		// Token: 0x1700236F RID: 9071
		// (get) Token: 0x0600A4B1 RID: 42161 RVA: 0x002B9DB8 File Offset: 0x002B7FB8
		public int TabId
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

		// Token: 0x17002370 RID: 9072
		// (get) Token: 0x0600A4B2 RID: 42162 RVA: 0x002B9DF4 File Offset: 0x002B7FF4
		public int QuestId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A4B3 RID: 42163 RVA: 0x002B9E30 File Offset: 0x002B8030
		public int Quest(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002371 RID: 9073
		// (get) Token: 0x0600A4B4 RID: 42164 RVA: 0x002B9E70 File Offset: 0x002B8070
		public int QuestLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A4B5 RID: 42165 RVA: 0x002B9E9C File Offset: 0x002B809C
		public Span<int> GetQuestBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600A4B6 RID: 42166 RVA: 0x002B9EAC File Offset: 0x002B80AC
		public int[] GetQuestArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17002372 RID: 9074
		// (get) Token: 0x0600A4B7 RID: 42167 RVA: 0x002B9EC4 File Offset: 0x002B80C4
		public int QuestType
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

		// Token: 0x17002373 RID: 9075
		// (get) Token: 0x0600A4B8 RID: 42168 RVA: 0x002B9F04 File Offset: 0x002B8104
		public int Act
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

		// Token: 0x0600A4B9 RID: 42169 RVA: 0x002B9F41 File Offset: 0x002B8141
		[NullableContext(1)]
		public int[] Quest()
		{
			return this.GetQuestArray();
		}

		// Token: 0x0600A4BA RID: 42170 RVA: 0x002B9F49 File Offset: 0x002B8149
		[NullableContext(1)]
		public IEnumerable<int> QuestIter()
		{
			NewbieMainActTask.<QuestIter>d__24 <QuestIter>d__ = new NewbieMainActTask.<QuestIter>d__24(-2);
			<QuestIter>d__.<>3__<>4__this = this;
			return <QuestIter>d__;
		}

		// Token: 0x04005517 RID: 21783
		private Table __p;
	}
}
