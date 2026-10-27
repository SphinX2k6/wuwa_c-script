using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064B6 RID: 25782
	public struct ICompleteChildQuest : IFlatbufferObject
	{
		// Token: 0x1700BFD4 RID: 49108
		// (get) Token: 0x0602CB3A RID: 183098 RVA: 0x00622983 File Offset: 0x00620B83
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CB3B RID: 183099 RVA: 0x00622990 File Offset: 0x00620B90
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CB3C RID: 183100 RVA: 0x00622998 File Offset: 0x00620B98
		public static ICompleteChildQuest GetRootAsICompleteChildQuest(ByteBuffer _bb)
		{
			return ICompleteChildQuest.GetRootAsICompleteChildQuest(_bb, default(ICompleteChildQuest));
		}

		// Token: 0x0602CB3D RID: 183101 RVA: 0x006229B4 File Offset: 0x00620BB4
		public static ICompleteChildQuest GetRootAsICompleteChildQuest(ByteBuffer _bb, ICompleteChildQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CB3E RID: 183102 RVA: 0x006229D1 File Offset: 0x00620BD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CB3F RID: 183103 RVA: 0x006229E0 File Offset: 0x00620BE0
		public ICompleteChildQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BFD5 RID: 49109
		// (get) Token: 0x0602CB40 RID: 183104 RVA: 0x006229F0 File Offset: 0x00620BF0
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

		// Token: 0x1700BFD6 RID: 49110
		// (get) Token: 0x0602CB41 RID: 183105 RVA: 0x00622A2C File Offset: 0x00620C2C
		public int NodeId
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

		// Token: 0x0602CB42 RID: 183106 RVA: 0x00622A68 File Offset: 0x00620C68
		public static Offset<ICompleteChildQuest> CreateICompleteChildQuest(FlatBufferBuilder builder, int QuestId = 0, int NodeId = 0)
		{
			builder.StartTable(2);
			ICompleteChildQuest.AddNodeId(builder, NodeId);
			ICompleteChildQuest.AddQuestId(builder, QuestId);
			return ICompleteChildQuest.EndICompleteChildQuest(builder);
		}

		// Token: 0x0602CB43 RID: 183107 RVA: 0x00622A85 File Offset: 0x00620C85
		public static void StartICompleteChildQuest(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602CB44 RID: 183108 RVA: 0x00622A8E File Offset: 0x00620C8E
		public static void AddQuestId(FlatBufferBuilder builder, int questId)
		{
			builder.AddInt(0, questId, 0);
		}

		// Token: 0x0602CB45 RID: 183109 RVA: 0x00622A99 File Offset: 0x00620C99
		public static void AddNodeId(FlatBufferBuilder builder, int nodeId)
		{
			builder.AddInt(1, nodeId, 0);
		}

		// Token: 0x0602CB46 RID: 183110 RVA: 0x00622AA4 File Offset: 0x00620CA4
		public static Offset<ICompleteChildQuest> EndICompleteChildQuest(FlatBufferBuilder builder)
		{
			return new Offset<ICompleteChildQuest>(builder.EndTable());
		}

		// Token: 0x0602CB47 RID: 183111 RVA: 0x00622AB4 File Offset: 0x00620CB4
		public ICompleteChildQuestT UnPack()
		{
			ICompleteChildQuestT completeChildQuestT = new ICompleteChildQuestT();
			this.UnPackTo(completeChildQuestT);
			return completeChildQuestT;
		}

		// Token: 0x0602CB48 RID: 183112 RVA: 0x00622ACF File Offset: 0x00620CCF
		public void UnPackTo(ICompleteChildQuestT _o)
		{
			_o.QuestId = this.QuestId;
			_o.NodeId = this.NodeId;
		}

		// Token: 0x0602CB49 RID: 183113 RVA: 0x00622AEC File Offset: 0x00620CEC
		public static Offset<ICompleteChildQuest> Pack(FlatBufferBuilder builder, ICompleteChildQuestT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompleteChildQuest>);
			}
			return ICompleteChildQuest.CreateICompleteChildQuest(builder, _o.QuestId, _o.NodeId);
		}

		// Token: 0x04010AE6 RID: 68326
		private Table __p;
	}
}
