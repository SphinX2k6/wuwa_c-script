using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006597 RID: 26007
	public struct IDestroyQuest : IFlatbufferObject
	{
		// Token: 0x1700C121 RID: 49441
		// (get) Token: 0x0602D1C9 RID: 184777 RVA: 0x00630181 File Offset: 0x0062E381
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D1CA RID: 184778 RVA: 0x0063018E File Offset: 0x0062E38E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D1CB RID: 184779 RVA: 0x00630198 File Offset: 0x0062E398
		public static IDestroyQuest GetRootAsIDestroyQuest(ByteBuffer _bb)
		{
			return IDestroyQuest.GetRootAsIDestroyQuest(_bb, default(IDestroyQuest));
		}

		// Token: 0x0602D1CC RID: 184780 RVA: 0x006301B4 File Offset: 0x0062E3B4
		public static IDestroyQuest GetRootAsIDestroyQuest(ByteBuffer _bb, IDestroyQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D1CD RID: 184781 RVA: 0x006301D1 File Offset: 0x0062E3D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D1CE RID: 184782 RVA: 0x006301E0 File Offset: 0x0062E3E0
		public IDestroyQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C122 RID: 49442
		// (get) Token: 0x0602D1CF RID: 184783 RVA: 0x006301F0 File Offset: 0x0062E3F0
		public int QuestId
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

		// Token: 0x1700C123 RID: 49443
		// (get) Token: 0x0602D1D0 RID: 184784 RVA: 0x0063022C File Offset: 0x0062E42C
		public bool IsDestroy
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C124 RID: 49444
		// (get) Token: 0x0602D1D1 RID: 184785 RVA: 0x0063026C File Offset: 0x0062E46C
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

		// Token: 0x0602D1D2 RID: 184786 RVA: 0x006302A8 File Offset: 0x0062E4A8
		public static Offset<IDestroyQuest> CreateIDestroyQuest(FlatBufferBuilder builder, int QuestId = 0, bool IsDestroy = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IDestroyQuest.AddQuestId(builder, QuestId);
			IDestroyQuest.AddNullMask(builder, NullMask);
			IDestroyQuest.AddIsDestroy(builder, IsDestroy);
			return IDestroyQuest.EndIDestroyQuest(builder);
		}

		// Token: 0x0602D1D3 RID: 184787 RVA: 0x006302CC File Offset: 0x0062E4CC
		public static void StartIDestroyQuest(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602D1D4 RID: 184788 RVA: 0x006302D5 File Offset: 0x0062E4D5
		public static void AddQuestId(FlatBufferBuilder builder, int questId)
		{
			builder.AddInt(0, questId, 0);
		}

		// Token: 0x0602D1D5 RID: 184789 RVA: 0x006302E0 File Offset: 0x0062E4E0
		public static void AddIsDestroy(FlatBufferBuilder builder, bool isDestroy)
		{
			builder.AddBool(1, isDestroy, false);
		}

		// Token: 0x0602D1D6 RID: 184790 RVA: 0x006302EB File Offset: 0x0062E4EB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602D1D7 RID: 184791 RVA: 0x006302F6 File Offset: 0x0062E4F6
		public static Offset<IDestroyQuest> EndIDestroyQuest(FlatBufferBuilder builder)
		{
			return new Offset<IDestroyQuest>(builder.EndTable());
		}

		// Token: 0x0602D1D8 RID: 184792 RVA: 0x00630304 File Offset: 0x0062E504
		public IDestroyQuestT UnPack()
		{
			IDestroyQuestT destroyQuestT = new IDestroyQuestT();
			this.UnPackTo(destroyQuestT);
			return destroyQuestT;
		}

		// Token: 0x0602D1D9 RID: 184793 RVA: 0x0063031F File Offset: 0x0062E51F
		public void UnPackTo(IDestroyQuestT _o)
		{
			_o.QuestId = this.QuestId;
			_o.IsDestroy = this.IsDestroy;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602D1DA RID: 184794 RVA: 0x00630348 File Offset: 0x0062E548
		public static Offset<IDestroyQuest> Pack(FlatBufferBuilder builder, IDestroyQuestT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDestroyQuest>);
			}
			return IDestroyQuest.CreateIDestroyQuest(builder, _o.QuestId, _o.IsDestroy, _o.NullMask);
		}

		// Token: 0x04010BEF RID: 68591
		private Table __p;
	}
}
