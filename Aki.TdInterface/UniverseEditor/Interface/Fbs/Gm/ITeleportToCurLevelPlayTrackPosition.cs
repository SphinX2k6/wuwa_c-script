using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B1F RID: 19231
	public struct ITeleportToCurLevelPlayTrackPosition : IFlatbufferObject
	{
		// Token: 0x170086D5 RID: 34517
		// (get) Token: 0x0601CFF6 RID: 118774 RVA: 0x00413ACC File Offset: 0x00411CCC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CFF7 RID: 118775 RVA: 0x00413AD9 File Offset: 0x00411CD9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CFF8 RID: 118776 RVA: 0x00413AE0 File Offset: 0x00411CE0
		public static ITeleportToCurLevelPlayTrackPosition GetRootAsITeleportToCurLevelPlayTrackPosition(ByteBuffer _bb)
		{
			return ITeleportToCurLevelPlayTrackPosition.GetRootAsITeleportToCurLevelPlayTrackPosition(_bb, default(ITeleportToCurLevelPlayTrackPosition));
		}

		// Token: 0x0601CFF9 RID: 118777 RVA: 0x00413AFC File Offset: 0x00411CFC
		public static ITeleportToCurLevelPlayTrackPosition GetRootAsITeleportToCurLevelPlayTrackPosition(ByteBuffer _bb, ITeleportToCurLevelPlayTrackPosition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CFFA RID: 118778 RVA: 0x00413B19 File Offset: 0x00411D19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CFFB RID: 118779 RVA: 0x00413B28 File Offset: 0x00411D28
		public ITeleportToCurLevelPlayTrackPosition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170086D6 RID: 34518
		// (get) Token: 0x0601CFFC RID: 118780 RVA: 0x00413B38 File Offset: 0x00411D38
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

		// Token: 0x170086D7 RID: 34519
		// (get) Token: 0x0601CFFD RID: 118781 RVA: 0x00413B74 File Offset: 0x00411D74
		public int LevelPlayId
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

		// Token: 0x170086D8 RID: 34520
		// (get) Token: 0x0601CFFE RID: 118782 RVA: 0x00413BB0 File Offset: 0x00411DB0
		public int NodeId
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

		// Token: 0x170086D9 RID: 34521
		// (get) Token: 0x0601CFFF RID: 118783 RVA: 0x00413BEC File Offset: 0x00411DEC
		public int NodeIndex
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170086DA RID: 34522
		// (get) Token: 0x0601D000 RID: 118784 RVA: 0x00413C2C File Offset: 0x00411E2C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D001 RID: 118785 RVA: 0x00413C69 File Offset: 0x00411E69
		public static Offset<ITeleportToCurLevelPlayTrackPosition> CreateITeleportToCurLevelPlayTrackPosition(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int LevelPlayId = 0, int NodeId = 0, int NodeIndex = 0, byte NullMask = 0)
		{
			builder.StartTable(5);
			ITeleportToCurLevelPlayTrackPosition.AddNodeIndex(builder, NodeIndex);
			ITeleportToCurLevelPlayTrackPosition.AddNodeId(builder, NodeId);
			ITeleportToCurLevelPlayTrackPosition.AddLevelPlayId(builder, LevelPlayId);
			ITeleportToCurLevelPlayTrackPosition.AddNullMask(builder, NullMask);
			ITeleportToCurLevelPlayTrackPosition.AddType(builder, Type);
			return ITeleportToCurLevelPlayTrackPosition.EndITeleportToCurLevelPlayTrackPosition(builder);
		}

		// Token: 0x0601D002 RID: 118786 RVA: 0x00413C9D File Offset: 0x00411E9D
		public static void StartITeleportToCurLevelPlayTrackPosition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601D003 RID: 118787 RVA: 0x00413CA6 File Offset: 0x00411EA6
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D004 RID: 118788 RVA: 0x00413CB1 File Offset: 0x00411EB1
		public static void AddLevelPlayId(FlatBufferBuilder builder, int levelPlayId)
		{
			builder.AddInt(1, levelPlayId, 0);
		}

		// Token: 0x0601D005 RID: 118789 RVA: 0x00413CBC File Offset: 0x00411EBC
		public static void AddNodeId(FlatBufferBuilder builder, int nodeId)
		{
			builder.AddInt(2, nodeId, 0);
		}

		// Token: 0x0601D006 RID: 118790 RVA: 0x00413CC7 File Offset: 0x00411EC7
		public static void AddNodeIndex(FlatBufferBuilder builder, int nodeIndex)
		{
			builder.AddInt(3, nodeIndex, 0);
		}

		// Token: 0x0601D007 RID: 118791 RVA: 0x00413CD2 File Offset: 0x00411ED2
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601D008 RID: 118792 RVA: 0x00413CDD File Offset: 0x00411EDD
		public static Offset<ITeleportToCurLevelPlayTrackPosition> EndITeleportToCurLevelPlayTrackPosition(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportToCurLevelPlayTrackPosition>(builder.EndTable());
		}

		// Token: 0x0601D009 RID: 118793 RVA: 0x00413CEC File Offset: 0x00411EEC
		public ITeleportToCurLevelPlayTrackPositionT UnPack()
		{
			ITeleportToCurLevelPlayTrackPositionT teleportToCurLevelPlayTrackPositionT = new ITeleportToCurLevelPlayTrackPositionT();
			this.UnPackTo(teleportToCurLevelPlayTrackPositionT);
			return teleportToCurLevelPlayTrackPositionT;
		}

		// Token: 0x0601D00A RID: 118794 RVA: 0x00413D07 File Offset: 0x00411F07
		public void UnPackTo(ITeleportToCurLevelPlayTrackPositionT _o)
		{
			_o.Type = this.Type;
			_o.LevelPlayId = this.LevelPlayId;
			_o.NodeId = this.NodeId;
			_o.NodeIndex = this.NodeIndex;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601D00B RID: 118795 RVA: 0x00413D48 File Offset: 0x00411F48
		public static Offset<ITeleportToCurLevelPlayTrackPosition> Pack(FlatBufferBuilder builder, ITeleportToCurLevelPlayTrackPositionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportToCurLevelPlayTrackPosition>);
			}
			return ITeleportToCurLevelPlayTrackPosition.CreateITeleportToCurLevelPlayTrackPosition(builder, _o.Type, _o.LevelPlayId, _o.NodeId, _o.NodeIndex, _o.NullMask);
		}

		// Token: 0x0400D2B1 RID: 53937
		private Table __p;
	}
}
