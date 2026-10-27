using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AB7 RID: 15031
	public struct IQuestBranchPageId : IFlatbufferObject
	{
		// Token: 0x1700671E RID: 26398
		// (get) Token: 0x060146F8 RID: 83704 RVA: 0x002FA84C File Offset: 0x002F8A4C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060146F9 RID: 83705 RVA: 0x002FA859 File Offset: 0x002F8A59
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060146FA RID: 83706 RVA: 0x002FA860 File Offset: 0x002F8A60
		public static IQuestBranchPageId GetRootAsIQuestBranchPageId(ByteBuffer _bb)
		{
			return IQuestBranchPageId.GetRootAsIQuestBranchPageId(_bb, default(IQuestBranchPageId));
		}

		// Token: 0x060146FB RID: 83707 RVA: 0x002FA87C File Offset: 0x002F8A7C
		public static IQuestBranchPageId GetRootAsIQuestBranchPageId(ByteBuffer _bb, IQuestBranchPageId obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060146FC RID: 83708 RVA: 0x002FA899 File Offset: 0x002F8A99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060146FD RID: 83709 RVA: 0x002FA8A8 File Offset: 0x002F8AA8
		public IQuestBranchPageId __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700671F RID: 26399
		// (get) Token: 0x060146FE RID: 83710 RVA: 0x002FA8B8 File Offset: 0x002F8AB8
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

		// Token: 0x17006720 RID: 26400
		// (get) Token: 0x060146FF RID: 83711 RVA: 0x002FA8F4 File Offset: 0x002F8AF4
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

		// Token: 0x06014700 RID: 83712 RVA: 0x002FA930 File Offset: 0x002F8B30
		public static Offset<IQuestBranchPageId> CreateIQuestBranchPageId(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar, int QuestBranchPageId = 0)
		{
			builder.StartTable(2);
			IQuestBranchPageId.AddQuestBranchPageId(builder, QuestBranchPageId);
			IQuestBranchPageId.AddType(builder, Type);
			return IQuestBranchPageId.EndIQuestBranchPageId(builder);
		}

		// Token: 0x06014701 RID: 83713 RVA: 0x002FA94D File Offset: 0x002F8B4D
		public static void StartIQuestBranchPageId(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06014702 RID: 83714 RVA: 0x002FA956 File Offset: 0x002F8B56
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014703 RID: 83715 RVA: 0x002FA961 File Offset: 0x002F8B61
		public static void AddQuestBranchPageId(FlatBufferBuilder builder, int questBranchPageId)
		{
			builder.AddInt(1, questBranchPageId, 0);
		}

		// Token: 0x06014704 RID: 83716 RVA: 0x002FA96C File Offset: 0x002F8B6C
		public static Offset<IQuestBranchPageId> EndIQuestBranchPageId(FlatBufferBuilder builder)
		{
			return new Offset<IQuestBranchPageId>(builder.EndTable());
		}

		// Token: 0x06014705 RID: 83717 RVA: 0x002FA97C File Offset: 0x002F8B7C
		public IQuestBranchPageIdT UnPack()
		{
			IQuestBranchPageIdT questBranchPageIdT = new IQuestBranchPageIdT();
			this.UnPackTo(questBranchPageIdT);
			return questBranchPageIdT;
		}

		// Token: 0x06014706 RID: 83718 RVA: 0x002FA997 File Offset: 0x002F8B97
		public void UnPackTo(IQuestBranchPageIdT _o)
		{
			_o.Type = this.Type;
			_o.QuestBranchPageId = this.QuestBranchPageId;
		}

		// Token: 0x06014707 RID: 83719 RVA: 0x002FA9B4 File Offset: 0x002F8BB4
		public static Offset<IQuestBranchPageId> Pack(FlatBufferBuilder builder, IQuestBranchPageIdT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestBranchPageId>);
			}
			return IQuestBranchPageId.CreateIQuestBranchPageId(builder, _o.Type, _o.QuestBranchPageId);
		}

		// Token: 0x0400AF55 RID: 44885
		private Table __p;
	}
}
