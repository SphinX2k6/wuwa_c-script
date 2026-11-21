using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B22 RID: 19234
	public struct ITeleportToCurQuestTrackPosition : IFlatbufferObject
	{
		// Token: 0x170086E0 RID: 34528
		// (get) Token: 0x0601D018 RID: 118808 RVA: 0x00413E74 File Offset: 0x00412074
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D019 RID: 118809 RVA: 0x00413E81 File Offset: 0x00412081
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D01A RID: 118810 RVA: 0x00413E88 File Offset: 0x00412088
		public static ITeleportToCurQuestTrackPosition GetRootAsITeleportToCurQuestTrackPosition(ByteBuffer _bb)
		{
			return ITeleportToCurQuestTrackPosition.GetRootAsITeleportToCurQuestTrackPosition(_bb, default(ITeleportToCurQuestTrackPosition));
		}

		// Token: 0x0601D01B RID: 118811 RVA: 0x00413EA4 File Offset: 0x004120A4
		public static ITeleportToCurQuestTrackPosition GetRootAsITeleportToCurQuestTrackPosition(ByteBuffer _bb, ITeleportToCurQuestTrackPosition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D01C RID: 118812 RVA: 0x00413EC1 File Offset: 0x004120C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D01D RID: 118813 RVA: 0x00413ED0 File Offset: 0x004120D0
		public ITeleportToCurQuestTrackPosition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170086E1 RID: 34529
		// (get) Token: 0x0601D01E RID: 118814 RVA: 0x00413EE0 File Offset: 0x004120E0
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170086E2 RID: 34530
		// (get) Token: 0x0601D01F RID: 118815 RVA: 0x00413F1C File Offset: 0x0041211C
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

		// Token: 0x170086E3 RID: 34531
		// (get) Token: 0x0601D020 RID: 118816 RVA: 0x00413F58 File Offset: 0x00412158
		public int NodeIndex
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170086E4 RID: 34532
		// (get) Token: 0x0601D021 RID: 118817 RVA: 0x00413F94 File Offset: 0x00412194
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D022 RID: 118818 RVA: 0x00413FD1 File Offset: 0x004121D1
		public static Offset<ITeleportToCurQuestTrackPosition> CreateITeleportToCurQuestTrackPosition(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int NodeId = 0, int NodeIndex = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			ITeleportToCurQuestTrackPosition.AddNodeIndex(builder, NodeIndex);
			ITeleportToCurQuestTrackPosition.AddNodeId(builder, NodeId);
			ITeleportToCurQuestTrackPosition.AddNullMask(builder, NullMask);
			ITeleportToCurQuestTrackPosition.AddType(builder, Type);
			return ITeleportToCurQuestTrackPosition.EndITeleportToCurQuestTrackPosition(builder);
		}

		// Token: 0x0601D023 RID: 118819 RVA: 0x00413FFD File Offset: 0x004121FD
		public static void StartITeleportToCurQuestTrackPosition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601D024 RID: 118820 RVA: 0x00414006 File Offset: 0x00412206
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D025 RID: 118821 RVA: 0x00414011 File Offset: 0x00412211
		public static void AddNodeId(FlatBufferBuilder builder, int nodeId)
		{
			builder.AddInt(1, nodeId, 0);
		}

		// Token: 0x0601D026 RID: 118822 RVA: 0x0041401C File Offset: 0x0041221C
		public static void AddNodeIndex(FlatBufferBuilder builder, int nodeIndex)
		{
			builder.AddInt(2, nodeIndex, 0);
		}

		// Token: 0x0601D027 RID: 118823 RVA: 0x00414027 File Offset: 0x00412227
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601D028 RID: 118824 RVA: 0x00414032 File Offset: 0x00412232
		public static Offset<ITeleportToCurQuestTrackPosition> EndITeleportToCurQuestTrackPosition(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportToCurQuestTrackPosition>(builder.EndTable());
		}

		// Token: 0x0601D029 RID: 118825 RVA: 0x00414040 File Offset: 0x00412240
		public ITeleportToCurQuestTrackPositionT UnPack()
		{
			ITeleportToCurQuestTrackPositionT teleportToCurQuestTrackPositionT = new ITeleportToCurQuestTrackPositionT();
			this.UnPackTo(teleportToCurQuestTrackPositionT);
			return teleportToCurQuestTrackPositionT;
		}

		// Token: 0x0601D02A RID: 118826 RVA: 0x0041405B File Offset: 0x0041225B
		public void UnPackTo(ITeleportToCurQuestTrackPositionT _o)
		{
			_o.Type = this.Type;
			_o.NodeId = this.NodeId;
			_o.NodeIndex = this.NodeIndex;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601D02B RID: 118827 RVA: 0x00414090 File Offset: 0x00412290
		public static Offset<ITeleportToCurQuestTrackPosition> Pack(FlatBufferBuilder builder, ITeleportToCurQuestTrackPositionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportToCurQuestTrackPosition>);
			}
			return ITeleportToCurQuestTrackPosition.CreateITeleportToCurQuestTrackPosition(builder, _o.Type, _o.NodeId, _o.NodeIndex, _o.NullMask);
		}

		// Token: 0x0400D2B7 RID: 53943
		private Table __p;
	}
}
