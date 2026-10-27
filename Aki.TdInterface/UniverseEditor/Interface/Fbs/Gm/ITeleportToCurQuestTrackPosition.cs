using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046BA RID: 18106
	public struct ITeleportToCurQuestTrackPosition : IFlatbufferObject
	{
		// Token: 0x1700809F RID: 32927
		// (get) Token: 0x0601B843 RID: 112707 RVA: 0x003E7BD8 File Offset: 0x003E5DD8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B844 RID: 112708 RVA: 0x003E7BE5 File Offset: 0x003E5DE5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B845 RID: 112709 RVA: 0x003E7BEC File Offset: 0x003E5DEC
		public static ITeleportToCurQuestTrackPosition GetRootAsITeleportToCurQuestTrackPosition(ByteBuffer _bb)
		{
			return ITeleportToCurQuestTrackPosition.GetRootAsITeleportToCurQuestTrackPosition(_bb, default(ITeleportToCurQuestTrackPosition));
		}

		// Token: 0x0601B846 RID: 112710 RVA: 0x003E7C08 File Offset: 0x003E5E08
		public static ITeleportToCurQuestTrackPosition GetRootAsITeleportToCurQuestTrackPosition(ByteBuffer _bb, ITeleportToCurQuestTrackPosition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B847 RID: 112711 RVA: 0x003E7C25 File Offset: 0x003E5E25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B848 RID: 112712 RVA: 0x003E7C34 File Offset: 0x003E5E34
		public ITeleportToCurQuestTrackPosition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170080A0 RID: 32928
		// (get) Token: 0x0601B849 RID: 112713 RVA: 0x003E7C44 File Offset: 0x003E5E44
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

		// Token: 0x170080A1 RID: 32929
		// (get) Token: 0x0601B84A RID: 112714 RVA: 0x003E7C80 File Offset: 0x003E5E80
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

		// Token: 0x170080A2 RID: 32930
		// (get) Token: 0x0601B84B RID: 112715 RVA: 0x003E7CBC File Offset: 0x003E5EBC
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

		// Token: 0x170080A3 RID: 32931
		// (get) Token: 0x0601B84C RID: 112716 RVA: 0x003E7CF8 File Offset: 0x003E5EF8
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

		// Token: 0x0601B84D RID: 112717 RVA: 0x003E7D35 File Offset: 0x003E5F35
		public static Offset<ITeleportToCurQuestTrackPosition> CreateITeleportToCurQuestTrackPosition(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int NodeId = 0, int NodeIndex = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			ITeleportToCurQuestTrackPosition.AddNodeIndex(builder, NodeIndex);
			ITeleportToCurQuestTrackPosition.AddNodeId(builder, NodeId);
			ITeleportToCurQuestTrackPosition.AddNullMask(builder, NullMask);
			ITeleportToCurQuestTrackPosition.AddType(builder, Type);
			return ITeleportToCurQuestTrackPosition.EndITeleportToCurQuestTrackPosition(builder);
		}

		// Token: 0x0601B84E RID: 112718 RVA: 0x003E7D61 File Offset: 0x003E5F61
		public static void StartITeleportToCurQuestTrackPosition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601B84F RID: 112719 RVA: 0x003E7D6A File Offset: 0x003E5F6A
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B850 RID: 112720 RVA: 0x003E7D75 File Offset: 0x003E5F75
		public static void AddNodeId(FlatBufferBuilder builder, int nodeId)
		{
			builder.AddInt(1, nodeId, 0);
		}

		// Token: 0x0601B851 RID: 112721 RVA: 0x003E7D80 File Offset: 0x003E5F80
		public static void AddNodeIndex(FlatBufferBuilder builder, int nodeIndex)
		{
			builder.AddInt(2, nodeIndex, 0);
		}

		// Token: 0x0601B852 RID: 112722 RVA: 0x003E7D8B File Offset: 0x003E5F8B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601B853 RID: 112723 RVA: 0x003E7D96 File Offset: 0x003E5F96
		public static Offset<ITeleportToCurQuestTrackPosition> EndITeleportToCurQuestTrackPosition(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportToCurQuestTrackPosition>(builder.EndTable());
		}

		// Token: 0x0601B854 RID: 112724 RVA: 0x003E7DA4 File Offset: 0x003E5FA4
		public ITeleportToCurQuestTrackPositionT UnPack()
		{
			ITeleportToCurQuestTrackPositionT teleportToCurQuestTrackPositionT = new ITeleportToCurQuestTrackPositionT();
			this.UnPackTo(teleportToCurQuestTrackPositionT);
			return teleportToCurQuestTrackPositionT;
		}

		// Token: 0x0601B855 RID: 112725 RVA: 0x003E7DBF File Offset: 0x003E5FBF
		public void UnPackTo(ITeleportToCurQuestTrackPositionT _o)
		{
			_o.Type = this.Type;
			_o.NodeId = this.NodeId;
			_o.NodeIndex = this.NodeIndex;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601B856 RID: 112726 RVA: 0x003E7DF4 File Offset: 0x003E5FF4
		public static Offset<ITeleportToCurQuestTrackPosition> Pack(FlatBufferBuilder builder, ITeleportToCurQuestTrackPositionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportToCurQuestTrackPosition>);
			}
			return ITeleportToCurQuestTrackPosition.CreateITeleportToCurQuestTrackPosition(builder, _o.Type, _o.NodeId, _o.NodeIndex, _o.NullMask);
		}

		// Token: 0x0400C888 RID: 51336
		private Table __p;
	}
}
