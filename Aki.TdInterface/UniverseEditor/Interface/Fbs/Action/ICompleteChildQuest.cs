using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B21 RID: 27425
	public struct ICompleteChildQuest : IFlatbufferObject
	{
		// Token: 0x1700C961 RID: 51553
		// (get) Token: 0x0602F2BE RID: 193214 RVA: 0x0066E6B0 File Offset: 0x0066C8B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F2BF RID: 193215 RVA: 0x0066E6BD File Offset: 0x0066C8BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F2C0 RID: 193216 RVA: 0x0066E6C4 File Offset: 0x0066C8C4
		public static ICompleteChildQuest GetRootAsICompleteChildQuest(ByteBuffer _bb)
		{
			return ICompleteChildQuest.GetRootAsICompleteChildQuest(_bb, default(ICompleteChildQuest));
		}

		// Token: 0x0602F2C1 RID: 193217 RVA: 0x0066E6E0 File Offset: 0x0066C8E0
		public static ICompleteChildQuest GetRootAsICompleteChildQuest(ByteBuffer _bb, ICompleteChildQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F2C2 RID: 193218 RVA: 0x0066E6FD File Offset: 0x0066C8FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F2C3 RID: 193219 RVA: 0x0066E70C File Offset: 0x0066C90C
		public ICompleteChildQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C962 RID: 51554
		// (get) Token: 0x0602F2C4 RID: 193220 RVA: 0x0066E71C File Offset: 0x0066C91C
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

		// Token: 0x1700C963 RID: 51555
		// (get) Token: 0x0602F2C5 RID: 193221 RVA: 0x0066E758 File Offset: 0x0066C958
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

		// Token: 0x0602F2C6 RID: 193222 RVA: 0x0066E794 File Offset: 0x0066C994
		public static Offset<ICompleteChildQuest> CreateICompleteChildQuest(FlatBufferBuilder builder, int QuestId = 0, int NodeId = 0)
		{
			builder.StartTable(2);
			ICompleteChildQuest.AddNodeId(builder, NodeId);
			ICompleteChildQuest.AddQuestId(builder, QuestId);
			return ICompleteChildQuest.EndICompleteChildQuest(builder);
		}

		// Token: 0x0602F2C7 RID: 193223 RVA: 0x0066E7B1 File Offset: 0x0066C9B1
		public static void StartICompleteChildQuest(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F2C8 RID: 193224 RVA: 0x0066E7BA File Offset: 0x0066C9BA
		public static void AddQuestId(FlatBufferBuilder builder, int questId)
		{
			builder.AddInt(0, questId, 0);
		}

		// Token: 0x0602F2C9 RID: 193225 RVA: 0x0066E7C5 File Offset: 0x0066C9C5
		public static void AddNodeId(FlatBufferBuilder builder, int nodeId)
		{
			builder.AddInt(1, nodeId, 0);
		}

		// Token: 0x0602F2CA RID: 193226 RVA: 0x0066E7D0 File Offset: 0x0066C9D0
		public static Offset<ICompleteChildQuest> EndICompleteChildQuest(FlatBufferBuilder builder)
		{
			return new Offset<ICompleteChildQuest>(builder.EndTable());
		}

		// Token: 0x0602F2CB RID: 193227 RVA: 0x0066E7E0 File Offset: 0x0066C9E0
		public ICompleteChildQuestT UnPack()
		{
			ICompleteChildQuestT completeChildQuestT = new ICompleteChildQuestT();
			this.UnPackTo(completeChildQuestT);
			return completeChildQuestT;
		}

		// Token: 0x0602F2CC RID: 193228 RVA: 0x0066E7FB File Offset: 0x0066C9FB
		public void UnPackTo(ICompleteChildQuestT _o)
		{
			_o.QuestId = this.QuestId;
			_o.NodeId = this.NodeId;
		}

		// Token: 0x0602F2CD RID: 193229 RVA: 0x0066E818 File Offset: 0x0066CA18
		public static Offset<ICompleteChildQuest> Pack(FlatBufferBuilder builder, ICompleteChildQuestT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompleteChildQuest>);
			}
			return ICompleteChildQuest.CreateICompleteChildQuest(builder, _o.QuestId, _o.NodeId);
		}

		// Token: 0x040118FC RID: 71932
		private Table __p;
	}
}
