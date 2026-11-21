using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E54 RID: 20052
	public struct ICheckChildQuestStatus : IFlatbufferObject
	{
		// Token: 0x17008EE8 RID: 36584
		// (get) Token: 0x0601F079 RID: 127097 RVA: 0x00454E74 File Offset: 0x00453074
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F07A RID: 127098 RVA: 0x00454E81 File Offset: 0x00453081
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F07B RID: 127099 RVA: 0x00454E88 File Offset: 0x00453088
		public static ICheckChildQuestStatus GetRootAsICheckChildQuestStatus(ByteBuffer _bb)
		{
			return ICheckChildQuestStatus.GetRootAsICheckChildQuestStatus(_bb, default(ICheckChildQuestStatus));
		}

		// Token: 0x0601F07C RID: 127100 RVA: 0x00454EA4 File Offset: 0x004530A4
		public static ICheckChildQuestStatus GetRootAsICheckChildQuestStatus(ByteBuffer _bb, ICheckChildQuestStatus obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F07D RID: 127101 RVA: 0x00454EC1 File Offset: 0x004530C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F07E RID: 127102 RVA: 0x00454ED0 File Offset: 0x004530D0
		public ICheckChildQuestStatus __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008EE9 RID: 36585
		// (get) Token: 0x0601F07F RID: 127103 RVA: 0x00454EE0 File Offset: 0x004530E0
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008EEA RID: 36586
		// (get) Token: 0x0601F080 RID: 127104 RVA: 0x00454F1C File Offset: 0x0045311C
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

		// Token: 0x17008EEB RID: 36587
		// (get) Token: 0x0601F081 RID: 127105 RVA: 0x00454F58 File Offset: 0x00453158
		public EQuestNodeStatusType Status
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EQuestNodeStatusType.CqnsNotActive;
				}
				return (EQuestNodeStatusType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F082 RID: 127106 RVA: 0x00454F94 File Offset: 0x00453194
		public static Offset<ICheckChildQuestStatus> CreateICheckChildQuestStatus(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int NodeId = 0, EQuestNodeStatusType Status = EQuestNodeStatusType.CqnsNotActive)
		{
			builder.StartTable(3);
			ICheckChildQuestStatus.AddNodeId(builder, NodeId);
			ICheckChildQuestStatus.AddStatus(builder, Status);
			ICheckChildQuestStatus.AddType(builder, Type);
			return ICheckChildQuestStatus.EndICheckChildQuestStatus(builder);
		}

		// Token: 0x0601F083 RID: 127107 RVA: 0x00454FB8 File Offset: 0x004531B8
		public static void StartICheckChildQuestStatus(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F084 RID: 127108 RVA: 0x00454FC1 File Offset: 0x004531C1
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F085 RID: 127109 RVA: 0x00454FCC File Offset: 0x004531CC
		public static void AddNodeId(FlatBufferBuilder builder, int nodeId)
		{
			builder.AddInt(1, nodeId, 0);
		}

		// Token: 0x0601F086 RID: 127110 RVA: 0x00454FD7 File Offset: 0x004531D7
		public static void AddStatus(FlatBufferBuilder builder, EQuestNodeStatusType status)
		{
			builder.AddByte(2, (byte)status, 0);
		}

		// Token: 0x0601F087 RID: 127111 RVA: 0x00454FE2 File Offset: 0x004531E2
		public static Offset<ICheckChildQuestStatus> EndICheckChildQuestStatus(FlatBufferBuilder builder)
		{
			return new Offset<ICheckChildQuestStatus>(builder.EndTable());
		}

		// Token: 0x0601F088 RID: 127112 RVA: 0x00454FF0 File Offset: 0x004531F0
		public ICheckChildQuestStatusT UnPack()
		{
			ICheckChildQuestStatusT checkChildQuestStatusT = new ICheckChildQuestStatusT();
			this.UnPackTo(checkChildQuestStatusT);
			return checkChildQuestStatusT;
		}

		// Token: 0x0601F089 RID: 127113 RVA: 0x0045500B File Offset: 0x0045320B
		public void UnPackTo(ICheckChildQuestStatusT _o)
		{
			_o.Type = this.Type;
			_o.NodeId = this.NodeId;
			_o.Status = this.Status;
		}

		// Token: 0x0601F08A RID: 127114 RVA: 0x00455034 File Offset: 0x00453234
		public static Offset<ICheckChildQuestStatus> Pack(FlatBufferBuilder builder, ICheckChildQuestStatusT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckChildQuestStatus>);
			}
			return ICheckChildQuestStatus.CreateICheckChildQuestStatus(builder, _o.Type, _o.NodeId, _o.Status);
		}

		// Token: 0x0400DC7C RID: 56444
		private Table __p;
	}
}
