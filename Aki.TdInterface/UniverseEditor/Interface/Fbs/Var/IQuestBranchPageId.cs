using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EB9 RID: 16057
	public struct IQuestBranchPageId : IFlatbufferObject
	{
		// Token: 0x17006CB9 RID: 27833
		// (get) Token: 0x06015BA2 RID: 88994 RVA: 0x00320ADC File Offset: 0x0031ECDC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015BA3 RID: 88995 RVA: 0x00320AE9 File Offset: 0x0031ECE9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015BA4 RID: 88996 RVA: 0x00320AF0 File Offset: 0x0031ECF0
		public static IQuestBranchPageId GetRootAsIQuestBranchPageId(ByteBuffer _bb)
		{
			return IQuestBranchPageId.GetRootAsIQuestBranchPageId(_bb, default(IQuestBranchPageId));
		}

		// Token: 0x06015BA5 RID: 88997 RVA: 0x00320B0C File Offset: 0x0031ED0C
		public static IQuestBranchPageId GetRootAsIQuestBranchPageId(ByteBuffer _bb, IQuestBranchPageId obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015BA6 RID: 88998 RVA: 0x00320B29 File Offset: 0x0031ED29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015BA7 RID: 88999 RVA: 0x00320B38 File Offset: 0x0031ED38
		public IQuestBranchPageId __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006CBA RID: 27834
		// (get) Token: 0x06015BA8 RID: 89000 RVA: 0x00320B48 File Offset: 0x0031ED48
		public ESystemVarName Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESystemVarName.CommonHotFixVar;
				}
				return (ESystemVarName)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006CBB RID: 27835
		// (get) Token: 0x06015BA9 RID: 89001 RVA: 0x00320B84 File Offset: 0x0031ED84
		public int QuestBranchPageId
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

		// Token: 0x06015BAA RID: 89002 RVA: 0x00320BC0 File Offset: 0x0031EDC0
		public static Offset<IQuestBranchPageId> CreateIQuestBranchPageId(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar, int QuestBranchPageId = 0)
		{
			builder.StartTable(2);
			IQuestBranchPageId.AddQuestBranchPageId(builder, QuestBranchPageId);
			IQuestBranchPageId.AddType(builder, Type);
			return IQuestBranchPageId.EndIQuestBranchPageId(builder);
		}

		// Token: 0x06015BAB RID: 89003 RVA: 0x00320BDD File Offset: 0x0031EDDD
		public static void StartIQuestBranchPageId(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06015BAC RID: 89004 RVA: 0x00320BE6 File Offset: 0x0031EDE6
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015BAD RID: 89005 RVA: 0x00320BF1 File Offset: 0x0031EDF1
		public static void AddQuestBranchPageId(FlatBufferBuilder builder, int questBranchPageId)
		{
			builder.AddInt(1, questBranchPageId, 0);
		}

		// Token: 0x06015BAE RID: 89006 RVA: 0x00320BFC File Offset: 0x0031EDFC
		public static Offset<IQuestBranchPageId> EndIQuestBranchPageId(FlatBufferBuilder builder)
		{
			return new Offset<IQuestBranchPageId>(builder.EndTable());
		}

		// Token: 0x06015BAF RID: 89007 RVA: 0x00320C0C File Offset: 0x0031EE0C
		public IQuestBranchPageIdT UnPack()
		{
			IQuestBranchPageIdT questBranchPageIdT = new IQuestBranchPageIdT();
			this.UnPackTo(questBranchPageIdT);
			return questBranchPageIdT;
		}

		// Token: 0x06015BB0 RID: 89008 RVA: 0x00320C27 File Offset: 0x0031EE27
		public void UnPackTo(IQuestBranchPageIdT _o)
		{
			_o.Type = this.Type;
			_o.QuestBranchPageId = this.QuestBranchPageId;
		}

		// Token: 0x06015BB1 RID: 89009 RVA: 0x00320C44 File Offset: 0x0031EE44
		public static Offset<IQuestBranchPageId> Pack(FlatBufferBuilder builder, IQuestBranchPageIdT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestBranchPageId>);
			}
			return IQuestBranchPageId.CreateIQuestBranchPageId(builder, _o.Type, _o.QuestBranchPageId);
		}

		// Token: 0x0400B8C2 RID: 47298
		private Table __p;
	}
}
