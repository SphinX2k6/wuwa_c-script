using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046B7 RID: 18103
	public struct ITeleportToCurLevelPlayTrackPosition : IFlatbufferObject
	{
		// Token: 0x17008094 RID: 32916
		// (get) Token: 0x0601B821 RID: 112673 RVA: 0x003E7830 File Offset: 0x003E5A30
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B822 RID: 112674 RVA: 0x003E783D File Offset: 0x003E5A3D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B823 RID: 112675 RVA: 0x003E7844 File Offset: 0x003E5A44
		public static ITeleportToCurLevelPlayTrackPosition GetRootAsITeleportToCurLevelPlayTrackPosition(ByteBuffer _bb)
		{
			return ITeleportToCurLevelPlayTrackPosition.GetRootAsITeleportToCurLevelPlayTrackPosition(_bb, default(ITeleportToCurLevelPlayTrackPosition));
		}

		// Token: 0x0601B824 RID: 112676 RVA: 0x003E7860 File Offset: 0x003E5A60
		public static ITeleportToCurLevelPlayTrackPosition GetRootAsITeleportToCurLevelPlayTrackPosition(ByteBuffer _bb, ITeleportToCurLevelPlayTrackPosition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B825 RID: 112677 RVA: 0x003E787D File Offset: 0x003E5A7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B826 RID: 112678 RVA: 0x003E788C File Offset: 0x003E5A8C
		public ITeleportToCurLevelPlayTrackPosition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008095 RID: 32917
		// (get) Token: 0x0601B827 RID: 112679 RVA: 0x003E789C File Offset: 0x003E5A9C
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

		// Token: 0x17008096 RID: 32918
		// (get) Token: 0x0601B828 RID: 112680 RVA: 0x003E78D8 File Offset: 0x003E5AD8
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

		// Token: 0x17008097 RID: 32919
		// (get) Token: 0x0601B829 RID: 112681 RVA: 0x003E7914 File Offset: 0x003E5B14
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

		// Token: 0x17008098 RID: 32920
		// (get) Token: 0x0601B82A RID: 112682 RVA: 0x003E7950 File Offset: 0x003E5B50
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

		// Token: 0x17008099 RID: 32921
		// (get) Token: 0x0601B82B RID: 112683 RVA: 0x003E7990 File Offset: 0x003E5B90
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

		// Token: 0x0601B82C RID: 112684 RVA: 0x003E79CD File Offset: 0x003E5BCD
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

		// Token: 0x0601B82D RID: 112685 RVA: 0x003E7A01 File Offset: 0x003E5C01
		public static void StartITeleportToCurLevelPlayTrackPosition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601B82E RID: 112686 RVA: 0x003E7A0A File Offset: 0x003E5C0A
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B82F RID: 112687 RVA: 0x003E7A15 File Offset: 0x003E5C15
		public static void AddLevelPlayId(FlatBufferBuilder builder, int levelPlayId)
		{
			builder.AddInt(1, levelPlayId, 0);
		}

		// Token: 0x0601B830 RID: 112688 RVA: 0x003E7A20 File Offset: 0x003E5C20
		public static void AddNodeId(FlatBufferBuilder builder, int nodeId)
		{
			builder.AddInt(2, nodeId, 0);
		}

		// Token: 0x0601B831 RID: 112689 RVA: 0x003E7A2B File Offset: 0x003E5C2B
		public static void AddNodeIndex(FlatBufferBuilder builder, int nodeIndex)
		{
			builder.AddInt(3, nodeIndex, 0);
		}

		// Token: 0x0601B832 RID: 112690 RVA: 0x003E7A36 File Offset: 0x003E5C36
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601B833 RID: 112691 RVA: 0x003E7A41 File Offset: 0x003E5C41
		public static Offset<ITeleportToCurLevelPlayTrackPosition> EndITeleportToCurLevelPlayTrackPosition(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportToCurLevelPlayTrackPosition>(builder.EndTable());
		}

		// Token: 0x0601B834 RID: 112692 RVA: 0x003E7A50 File Offset: 0x003E5C50
		public ITeleportToCurLevelPlayTrackPositionT UnPack()
		{
			ITeleportToCurLevelPlayTrackPositionT teleportToCurLevelPlayTrackPositionT = new ITeleportToCurLevelPlayTrackPositionT();
			this.UnPackTo(teleportToCurLevelPlayTrackPositionT);
			return teleportToCurLevelPlayTrackPositionT;
		}

		// Token: 0x0601B835 RID: 112693 RVA: 0x003E7A6B File Offset: 0x003E5C6B
		public void UnPackTo(ITeleportToCurLevelPlayTrackPositionT _o)
		{
			_o.Type = this.Type;
			_o.LevelPlayId = this.LevelPlayId;
			_o.NodeId = this.NodeId;
			_o.NodeIndex = this.NodeIndex;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601B836 RID: 112694 RVA: 0x003E7AAC File Offset: 0x003E5CAC
		public static Offset<ITeleportToCurLevelPlayTrackPosition> Pack(FlatBufferBuilder builder, ITeleportToCurLevelPlayTrackPositionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportToCurLevelPlayTrackPosition>);
			}
			return ITeleportToCurLevelPlayTrackPosition.CreateITeleportToCurLevelPlayTrackPosition(builder, _o.Type, _o.LevelPlayId, _o.NodeId, _o.NodeIndex, _o.NullMask);
		}

		// Token: 0x0400C882 RID: 51330
		private Table __p;
	}
}
