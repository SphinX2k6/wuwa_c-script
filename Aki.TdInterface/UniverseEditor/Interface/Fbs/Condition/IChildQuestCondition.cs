using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B77 RID: 19319
	public struct IChildQuestCondition : IFlatbufferObject
	{
		// Token: 0x17008C34 RID: 35892
		// (get) Token: 0x0601E71B RID: 124699 RVA: 0x00443648 File Offset: 0x00441848
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E71C RID: 124700 RVA: 0x00443655 File Offset: 0x00441855
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E71D RID: 124701 RVA: 0x0044365C File Offset: 0x0044185C
		public static IChildQuestCondition GetRootAsIChildQuestCondition(ByteBuffer _bb)
		{
			return IChildQuestCondition.GetRootAsIChildQuestCondition(_bb, default(IChildQuestCondition));
		}

		// Token: 0x0601E71E RID: 124702 RVA: 0x00443678 File Offset: 0x00441878
		public static IChildQuestCondition GetRootAsIChildQuestCondition(ByteBuffer _bb, IChildQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E71F RID: 124703 RVA: 0x00443695 File Offset: 0x00441895
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E720 RID: 124704 RVA: 0x004436A4 File Offset: 0x004418A4
		public IChildQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008C35 RID: 35893
		// (get) Token: 0x0601E721 RID: 124705 RVA: 0x004436B4 File Offset: 0x004418B4
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

		// Token: 0x17008C36 RID: 35894
		// (get) Token: 0x0601E722 RID: 124706 RVA: 0x004436F0 File Offset: 0x004418F0
		public int ChildQuestId
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

		// Token: 0x0601E723 RID: 124707 RVA: 0x0044372C File Offset: 0x0044192C
		public static Offset<IChildQuestCondition> CreateIChildQuestCondition(FlatBufferBuilder builder, int QuestId = 0, int ChildQuestId = 0)
		{
			builder.StartTable(2);
			IChildQuestCondition.AddChildQuestId(builder, ChildQuestId);
			IChildQuestCondition.AddQuestId(builder, QuestId);
			return IChildQuestCondition.EndIChildQuestCondition(builder);
		}

		// Token: 0x0601E724 RID: 124708 RVA: 0x00443749 File Offset: 0x00441949
		public static void StartIChildQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601E725 RID: 124709 RVA: 0x00443752 File Offset: 0x00441952
		public static void AddQuestId(FlatBufferBuilder builder, int questId)
		{
			builder.AddInt(0, questId, 0);
		}

		// Token: 0x0601E726 RID: 124710 RVA: 0x0044375D File Offset: 0x0044195D
		public static void AddChildQuestId(FlatBufferBuilder builder, int childQuestId)
		{
			builder.AddInt(1, childQuestId, 0);
		}

		// Token: 0x0601E727 RID: 124711 RVA: 0x00443768 File Offset: 0x00441968
		public static Offset<IChildQuestCondition> EndIChildQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IChildQuestCondition>(builder.EndTable());
		}

		// Token: 0x0601E728 RID: 124712 RVA: 0x00443778 File Offset: 0x00441978
		public IChildQuestConditionT UnPack()
		{
			IChildQuestConditionT childQuestConditionT = new IChildQuestConditionT();
			this.UnPackTo(childQuestConditionT);
			return childQuestConditionT;
		}

		// Token: 0x0601E729 RID: 124713 RVA: 0x00443793 File Offset: 0x00441993
		public void UnPackTo(IChildQuestConditionT _o)
		{
			_o.QuestId = this.QuestId;
			_o.ChildQuestId = this.ChildQuestId;
		}

		// Token: 0x0601E72A RID: 124714 RVA: 0x004437B0 File Offset: 0x004419B0
		public static Offset<IChildQuestCondition> Pack(FlatBufferBuilder builder, IChildQuestConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChildQuestCondition>);
			}
			return IChildQuestCondition.CreateIChildQuestCondition(builder, _o.QuestId, _o.ChildQuestId);
		}

		// Token: 0x0400D443 RID: 54339
		private Table __p;
	}
}
