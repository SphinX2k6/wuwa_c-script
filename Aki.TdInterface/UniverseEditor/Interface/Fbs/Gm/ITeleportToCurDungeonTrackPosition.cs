using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046B4 RID: 18100
	public struct ITeleportToCurDungeonTrackPosition : IFlatbufferObject
	{
		// Token: 0x1700808B RID: 32907
		// (get) Token: 0x0601B803 RID: 112643 RVA: 0x003E7515 File Offset: 0x003E5715
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B804 RID: 112644 RVA: 0x003E7522 File Offset: 0x003E5722
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B805 RID: 112645 RVA: 0x003E752C File Offset: 0x003E572C
		public static ITeleportToCurDungeonTrackPosition GetRootAsITeleportToCurDungeonTrackPosition(ByteBuffer _bb)
		{
			return ITeleportToCurDungeonTrackPosition.GetRootAsITeleportToCurDungeonTrackPosition(_bb, default(ITeleportToCurDungeonTrackPosition));
		}

		// Token: 0x0601B806 RID: 112646 RVA: 0x003E7548 File Offset: 0x003E5748
		public static ITeleportToCurDungeonTrackPosition GetRootAsITeleportToCurDungeonTrackPosition(ByteBuffer _bb, ITeleportToCurDungeonTrackPosition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B807 RID: 112647 RVA: 0x003E7565 File Offset: 0x003E5765
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B808 RID: 112648 RVA: 0x003E7574 File Offset: 0x003E5774
		public ITeleportToCurDungeonTrackPosition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700808C RID: 32908
		// (get) Token: 0x0601B809 RID: 112649 RVA: 0x003E7584 File Offset: 0x003E5784
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

		// Token: 0x1700808D RID: 32909
		// (get) Token: 0x0601B80A RID: 112650 RVA: 0x003E75C0 File Offset: 0x003E57C0
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

		// Token: 0x1700808E RID: 32910
		// (get) Token: 0x0601B80B RID: 112651 RVA: 0x003E75FC File Offset: 0x003E57FC
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

		// Token: 0x1700808F RID: 32911
		// (get) Token: 0x0601B80C RID: 112652 RVA: 0x003E7638 File Offset: 0x003E5838
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

		// Token: 0x0601B80D RID: 112653 RVA: 0x003E7675 File Offset: 0x003E5875
		public static Offset<ITeleportToCurDungeonTrackPosition> CreateITeleportToCurDungeonTrackPosition(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int NodeId = 0, int NodeIndex = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			ITeleportToCurDungeonTrackPosition.AddNodeIndex(builder, NodeIndex);
			ITeleportToCurDungeonTrackPosition.AddNodeId(builder, NodeId);
			ITeleportToCurDungeonTrackPosition.AddNullMask(builder, NullMask);
			ITeleportToCurDungeonTrackPosition.AddType(builder, Type);
			return ITeleportToCurDungeonTrackPosition.EndITeleportToCurDungeonTrackPosition(builder);
		}

		// Token: 0x0601B80E RID: 112654 RVA: 0x003E76A1 File Offset: 0x003E58A1
		public static void StartITeleportToCurDungeonTrackPosition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601B80F RID: 112655 RVA: 0x003E76AA File Offset: 0x003E58AA
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B810 RID: 112656 RVA: 0x003E76B5 File Offset: 0x003E58B5
		public static void AddNodeId(FlatBufferBuilder builder, int nodeId)
		{
			builder.AddInt(1, nodeId, 0);
		}

		// Token: 0x0601B811 RID: 112657 RVA: 0x003E76C0 File Offset: 0x003E58C0
		public static void AddNodeIndex(FlatBufferBuilder builder, int nodeIndex)
		{
			builder.AddInt(2, nodeIndex, 0);
		}

		// Token: 0x0601B812 RID: 112658 RVA: 0x003E76CB File Offset: 0x003E58CB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601B813 RID: 112659 RVA: 0x003E76D6 File Offset: 0x003E58D6
		public static Offset<ITeleportToCurDungeonTrackPosition> EndITeleportToCurDungeonTrackPosition(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportToCurDungeonTrackPosition>(builder.EndTable());
		}

		// Token: 0x0601B814 RID: 112660 RVA: 0x003E76E4 File Offset: 0x003E58E4
		public ITeleportToCurDungeonTrackPositionT UnPack()
		{
			ITeleportToCurDungeonTrackPositionT teleportToCurDungeonTrackPositionT = new ITeleportToCurDungeonTrackPositionT();
			this.UnPackTo(teleportToCurDungeonTrackPositionT);
			return teleportToCurDungeonTrackPositionT;
		}

		// Token: 0x0601B815 RID: 112661 RVA: 0x003E76FF File Offset: 0x003E58FF
		public void UnPackTo(ITeleportToCurDungeonTrackPositionT _o)
		{
			_o.Type = this.Type;
			_o.NodeId = this.NodeId;
			_o.NodeIndex = this.NodeIndex;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601B816 RID: 112662 RVA: 0x003E7734 File Offset: 0x003E5934
		public static Offset<ITeleportToCurDungeonTrackPosition> Pack(FlatBufferBuilder builder, ITeleportToCurDungeonTrackPositionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportToCurDungeonTrackPosition>);
			}
			return ITeleportToCurDungeonTrackPosition.CreateITeleportToCurDungeonTrackPosition(builder, _o.Type, _o.NodeId, _o.NodeIndex, _o.NullMask);
		}

		// Token: 0x0400C87D RID: 51325
		private Table __p;
	}
}
