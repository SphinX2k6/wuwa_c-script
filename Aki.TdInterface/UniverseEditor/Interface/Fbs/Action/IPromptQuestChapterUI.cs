using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DC2 RID: 28098
	public struct IPromptQuestChapterUI : IFlatbufferObject
	{
		// Token: 0x1700D185 RID: 53637
		// (get) Token: 0x06031A1F RID: 203295 RVA: 0x006B9749 File Offset: 0x006B7949
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031A20 RID: 203296 RVA: 0x006B9756 File Offset: 0x006B7956
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031A21 RID: 203297 RVA: 0x006B9760 File Offset: 0x006B7960
		public static IPromptQuestChapterUI GetRootAsIPromptQuestChapterUI(ByteBuffer _bb)
		{
			return IPromptQuestChapterUI.GetRootAsIPromptQuestChapterUI(_bb, default(IPromptQuestChapterUI));
		}

		// Token: 0x06031A22 RID: 203298 RVA: 0x006B977C File Offset: 0x006B797C
		public static IPromptQuestChapterUI GetRootAsIPromptQuestChapterUI(ByteBuffer _bb, IPromptQuestChapterUI obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031A23 RID: 203299 RVA: 0x006B9799 File Offset: 0x006B7999
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031A24 RID: 203300 RVA: 0x006B97A8 File Offset: 0x006B79A8
		public IPromptQuestChapterUI __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D186 RID: 53638
		// (get) Token: 0x06031A25 RID: 203301 RVA: 0x006B97B8 File Offset: 0x006B79B8
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

		// Token: 0x1700D187 RID: 53639
		// (get) Token: 0x06031A26 RID: 203302 RVA: 0x006B97F4 File Offset: 0x006B79F4
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

		// Token: 0x1700D188 RID: 53640
		// (get) Token: 0x06031A27 RID: 203303 RVA: 0x006B9830 File Offset: 0x006B7A30
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

		// Token: 0x06031A28 RID: 203304 RVA: 0x006B986C File Offset: 0x006B7A6C
		public static Offset<IPromptQuestChapterUI> CreateIPromptQuestChapterUI(FlatBufferBuilder builder, EQuestChapterState ChapterState = EQuestChapterState.Start, int QuestId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IPromptQuestChapterUI.AddQuestId(builder, QuestId);
			IPromptQuestChapterUI.AddNullMask(builder, NullMask);
			IPromptQuestChapterUI.AddChapterState(builder, ChapterState);
			return IPromptQuestChapterUI.EndIPromptQuestChapterUI(builder);
		}

		// Token: 0x06031A29 RID: 203305 RVA: 0x006B9890 File Offset: 0x006B7A90
		public static void StartIPromptQuestChapterUI(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06031A2A RID: 203306 RVA: 0x006B9899 File Offset: 0x006B7A99
		public static void AddChapterState(FlatBufferBuilder builder, EQuestChapterState chapterState)
		{
			builder.AddByte(0, (byte)chapterState, 0);
		}

		// Token: 0x06031A2B RID: 203307 RVA: 0x006B98A4 File Offset: 0x006B7AA4
		public static void AddQuestId(FlatBufferBuilder builder, int questId)
		{
			builder.AddInt(1, questId, 0);
		}

		// Token: 0x06031A2C RID: 203308 RVA: 0x006B98AF File Offset: 0x006B7AAF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06031A2D RID: 203309 RVA: 0x006B98BA File Offset: 0x006B7ABA
		public static Offset<IPromptQuestChapterUI> EndIPromptQuestChapterUI(FlatBufferBuilder builder)
		{
			return new Offset<IPromptQuestChapterUI>(builder.EndTable());
		}

		// Token: 0x06031A2E RID: 203310 RVA: 0x006B98C8 File Offset: 0x006B7AC8
		public IPromptQuestChapterUIT UnPack()
		{
			IPromptQuestChapterUIT promptQuestChapterUIT = new IPromptQuestChapterUIT();
			this.UnPackTo(promptQuestChapterUIT);
			return promptQuestChapterUIT;
		}

		// Token: 0x06031A2F RID: 203311 RVA: 0x006B98E3 File Offset: 0x006B7AE3
		public void UnPackTo(IPromptQuestChapterUIT _o)
		{
			_o.ChapterState = this.ChapterState;
			_o.QuestId = this.QuestId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06031A30 RID: 203312 RVA: 0x006B990C File Offset: 0x006B7B0C
		public static Offset<IPromptQuestChapterUI> Pack(FlatBufferBuilder builder, IPromptQuestChapterUIT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPromptQuestChapterUI>);
			}
			return IPromptQuestChapterUI.CreateIPromptQuestChapterUI(builder, _o.ChapterState, _o.QuestId, _o.NullMask);
		}

		// Token: 0x0401179F RID: 71583
		private Table __p;
	}
}
