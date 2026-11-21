using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200753D RID: 30013
	public struct IPromptQuestChapterUI : IFlatbufferObject
	{
		// Token: 0x1700DCCD RID: 56525
		// (get) Token: 0x06034A1B RID: 215579 RVA: 0x00714E31 File Offset: 0x00713031
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034A1C RID: 215580 RVA: 0x00714E3E File Offset: 0x0071303E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034A1D RID: 215581 RVA: 0x00714E48 File Offset: 0x00713048
		public static IPromptQuestChapterUI GetRootAsIPromptQuestChapterUI(ByteBuffer _bb)
		{
			return IPromptQuestChapterUI.GetRootAsIPromptQuestChapterUI(_bb, default(IPromptQuestChapterUI));
		}

		// Token: 0x06034A1E RID: 215582 RVA: 0x00714E64 File Offset: 0x00713064
		public static IPromptQuestChapterUI GetRootAsIPromptQuestChapterUI(ByteBuffer _bb, IPromptQuestChapterUI obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034A1F RID: 215583 RVA: 0x00714E81 File Offset: 0x00713081
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034A20 RID: 215584 RVA: 0x00714E90 File Offset: 0x00713090
		public IPromptQuestChapterUI __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DCCE RID: 56526
		// (get) Token: 0x06034A21 RID: 215585 RVA: 0x00714EA0 File Offset: 0x007130A0
		public EQuestChapterState ChapterState
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EQuestChapterState.Start;
				}
				return (EQuestChapterState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DCCF RID: 56527
		// (get) Token: 0x06034A22 RID: 215586 RVA: 0x00714EDC File Offset: 0x007130DC
		public int QuestId
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

		// Token: 0x1700DCD0 RID: 56528
		// (get) Token: 0x06034A23 RID: 215587 RVA: 0x00714F18 File Offset: 0x00713118
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034A24 RID: 215588 RVA: 0x00714F54 File Offset: 0x00713154
		public static Offset<IPromptQuestChapterUI> CreateIPromptQuestChapterUI(FlatBufferBuilder builder, EQuestChapterState ChapterState = EQuestChapterState.Start, int QuestId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IPromptQuestChapterUI.AddQuestId(builder, QuestId);
			IPromptQuestChapterUI.AddNullMask(builder, NullMask);
			IPromptQuestChapterUI.AddChapterState(builder, ChapterState);
			return IPromptQuestChapterUI.EndIPromptQuestChapterUI(builder);
		}

		// Token: 0x06034A25 RID: 215589 RVA: 0x00714F78 File Offset: 0x00713178
		public static void StartIPromptQuestChapterUI(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06034A26 RID: 215590 RVA: 0x00714F81 File Offset: 0x00713181
		public static void AddChapterState(FlatBufferBuilder builder, EQuestChapterState chapterState)
		{
			builder.AddByte(0, (byte)chapterState, 0);
		}

		// Token: 0x06034A27 RID: 215591 RVA: 0x00714F8C File Offset: 0x0071318C
		public static void AddQuestId(FlatBufferBuilder builder, int questId)
		{
			builder.AddInt(1, questId, 0);
		}

		// Token: 0x06034A28 RID: 215592 RVA: 0x00714F97 File Offset: 0x00713197
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06034A29 RID: 215593 RVA: 0x00714FA2 File Offset: 0x007131A2
		public static Offset<IPromptQuestChapterUI> EndIPromptQuestChapterUI(FlatBufferBuilder builder)
		{
			return new Offset<IPromptQuestChapterUI>(builder.EndTable());
		}

		// Token: 0x06034A2A RID: 215594 RVA: 0x00714FB0 File Offset: 0x007131B0
		public IPromptQuestChapterUIT UnPack()
		{
			IPromptQuestChapterUIT promptQuestChapterUIT = new IPromptQuestChapterUIT();
			this.UnPackTo(promptQuestChapterUIT);
			return promptQuestChapterUIT;
		}

		// Token: 0x06034A2B RID: 215595 RVA: 0x00714FCB File Offset: 0x007131CB
		public void UnPackTo(IPromptQuestChapterUIT _o)
		{
			_o.ChapterState = this.ChapterState;
			_o.QuestId = this.QuestId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06034A2C RID: 215596 RVA: 0x00714FF4 File Offset: 0x007131F4
		public static Offset<IPromptQuestChapterUI> Pack(FlatBufferBuilder builder, IPromptQuestChapterUIT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPromptQuestChapterUI>);
			}
			return IPromptQuestChapterUI.CreateIPromptQuestChapterUI(builder, _o.ChapterState, _o.QuestId, _o.NullMask);
		}

		// Token: 0x0401271B RID: 75547
		private Table __p;
	}
}
