using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200489B RID: 18587
	public struct IQuestAreaConflictSelector : IFlatbufferObject
	{
		// Token: 0x170086CB RID: 34507
		// (get) Token: 0x0601D01A RID: 118810 RVA: 0x00418FAF File Offset: 0x004171AF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D01B RID: 118811 RVA: 0x00418FBC File Offset: 0x004171BC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D01C RID: 118812 RVA: 0x00418FC4 File Offset: 0x004171C4
		public static IQuestAreaConflictSelector GetRootAsIQuestAreaConflictSelector(ByteBuffer _bb)
		{
			return IQuestAreaConflictSelector.GetRootAsIQuestAreaConflictSelector(_bb, default(IQuestAreaConflictSelector));
		}

		// Token: 0x0601D01D RID: 118813 RVA: 0x00418FE0 File Offset: 0x004171E0
		public static IQuestAreaConflictSelector GetRootAsIQuestAreaConflictSelector(ByteBuffer _bb, IQuestAreaConflictSelector obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D01E RID: 118814 RVA: 0x00418FFD File Offset: 0x004171FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D01F RID: 118815 RVA: 0x0041900C File Offset: 0x0041720C
		public IQuestAreaConflictSelector __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170086CC RID: 34508
		// (get) Token: 0x0601D020 RID: 118816 RVA: 0x0041901C File Offset: 0x0041721C
		public EAreaConflictSelector Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAreaConflictSelector.Quest;
				}
				return (EAreaConflictSelector)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170086CD RID: 34509
		// (get) Token: 0x0601D021 RID: 118817 RVA: 0x00419058 File Offset: 0x00417258
		public int Id
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

		// Token: 0x0601D022 RID: 118818 RVA: 0x00419094 File Offset: 0x00417294
		public static Offset<IQuestAreaConflictSelector> CreateIQuestAreaConflictSelector(FlatBufferBuilder builder, EAreaConflictSelector Type = EAreaConflictSelector.Quest, int Id = 0)
		{
			builder.StartTable(2);
			IQuestAreaConflictSelector.AddId(builder, Id);
			IQuestAreaConflictSelector.AddType(builder, Type);
			return IQuestAreaConflictSelector.EndIQuestAreaConflictSelector(builder);
		}

		// Token: 0x0601D023 RID: 118819 RVA: 0x004190B1 File Offset: 0x004172B1
		public static void StartIQuestAreaConflictSelector(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D024 RID: 118820 RVA: 0x004190BA File Offset: 0x004172BA
		public static void AddType(FlatBufferBuilder builder, EAreaConflictSelector type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D025 RID: 118821 RVA: 0x004190C5 File Offset: 0x004172C5
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0601D026 RID: 118822 RVA: 0x004190D0 File Offset: 0x004172D0
		public static Offset<IQuestAreaConflictSelector> EndIQuestAreaConflictSelector(FlatBufferBuilder builder)
		{
			return new Offset<IQuestAreaConflictSelector>(builder.EndTable());
		}

		// Token: 0x0601D027 RID: 118823 RVA: 0x004190E0 File Offset: 0x004172E0
		public IQuestAreaConflictSelectorT UnPack()
		{
			IQuestAreaConflictSelectorT questAreaConflictSelectorT = new IQuestAreaConflictSelectorT();
			this.UnPackTo(questAreaConflictSelectorT);
			return questAreaConflictSelectorT;
		}

		// Token: 0x0601D028 RID: 118824 RVA: 0x004190FB File Offset: 0x004172FB
		public void UnPackTo(IQuestAreaConflictSelectorT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0601D029 RID: 118825 RVA: 0x00419118 File Offset: 0x00417318
		public static Offset<IQuestAreaConflictSelector> Pack(FlatBufferBuilder builder, IQuestAreaConflictSelectorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestAreaConflictSelector>);
			}
			return IQuestAreaConflictSelector.CreateIQuestAreaConflictSelector(builder, _o.Type, _o.Id);
		}

		// Token: 0x0400CE88 RID: 52872
		private Table __p;
	}
}
