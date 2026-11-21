using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B1C RID: 19228
	public struct ITeleportToCurDungeonTrackPosition : IFlatbufferObject
	{
		// Token: 0x170086CC RID: 34508
		// (get) Token: 0x0601CFD8 RID: 118744 RVA: 0x004137B1 File Offset: 0x004119B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CFD9 RID: 118745 RVA: 0x004137BE File Offset: 0x004119BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CFDA RID: 118746 RVA: 0x004137C8 File Offset: 0x004119C8
		public static ITeleportToCurDungeonTrackPosition GetRootAsITeleportToCurDungeonTrackPosition(ByteBuffer _bb)
		{
			return ITeleportToCurDungeonTrackPosition.GetRootAsITeleportToCurDungeonTrackPosition(_bb, default(ITeleportToCurDungeonTrackPosition));
		}

		// Token: 0x0601CFDB RID: 118747 RVA: 0x004137E4 File Offset: 0x004119E4
		public static ITeleportToCurDungeonTrackPosition GetRootAsITeleportToCurDungeonTrackPosition(ByteBuffer _bb, ITeleportToCurDungeonTrackPosition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CFDC RID: 118748 RVA: 0x00413801 File Offset: 0x00411A01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CFDD RID: 118749 RVA: 0x00413810 File Offset: 0x00411A10
		public ITeleportToCurDungeonTrackPosition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170086CD RID: 34509
		// (get) Token: 0x0601CFDE RID: 118750 RVA: 0x00413820 File Offset: 0x00411A20
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

		// Token: 0x170086CE RID: 34510
		// (get) Token: 0x0601CFDF RID: 118751 RVA: 0x0041385C File Offset: 0x00411A5C
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

		// Token: 0x170086CF RID: 34511
		// (get) Token: 0x0601CFE0 RID: 118752 RVA: 0x00413898 File Offset: 0x00411A98
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

		// Token: 0x170086D0 RID: 34512
		// (get) Token: 0x0601CFE1 RID: 118753 RVA: 0x004138D4 File Offset: 0x00411AD4
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

		// Token: 0x0601CFE2 RID: 118754 RVA: 0x00413911 File Offset: 0x00411B11
		public static Offset<ITeleportToCurDungeonTrackPosition> CreateITeleportToCurDungeonTrackPosition(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int NodeId = 0, int NodeIndex = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			ITeleportToCurDungeonTrackPosition.AddNodeIndex(builder, NodeIndex);
			ITeleportToCurDungeonTrackPosition.AddNodeId(builder, NodeId);
			ITeleportToCurDungeonTrackPosition.AddNullMask(builder, NullMask);
			ITeleportToCurDungeonTrackPosition.AddType(builder, Type);
			return ITeleportToCurDungeonTrackPosition.EndITeleportToCurDungeonTrackPosition(builder);
		}

		// Token: 0x0601CFE3 RID: 118755 RVA: 0x0041393D File Offset: 0x00411B3D
		public static void StartITeleportToCurDungeonTrackPosition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601CFE4 RID: 118756 RVA: 0x00413946 File Offset: 0x00411B46
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CFE5 RID: 118757 RVA: 0x00413951 File Offset: 0x00411B51
		public static void AddNodeId(FlatBufferBuilder builder, int nodeId)
		{
			builder.AddInt(1, nodeId, 0);
		}

		// Token: 0x0601CFE6 RID: 118758 RVA: 0x0041395C File Offset: 0x00411B5C
		public static void AddNodeIndex(FlatBufferBuilder builder, int nodeIndex)
		{
			builder.AddInt(2, nodeIndex, 0);
		}

		// Token: 0x0601CFE7 RID: 118759 RVA: 0x00413967 File Offset: 0x00411B67
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601CFE8 RID: 118760 RVA: 0x00413972 File Offset: 0x00411B72
		public static Offset<ITeleportToCurDungeonTrackPosition> EndITeleportToCurDungeonTrackPosition(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportToCurDungeonTrackPosition>(builder.EndTable());
		}

		// Token: 0x0601CFE9 RID: 118761 RVA: 0x00413980 File Offset: 0x00411B80
		public ITeleportToCurDungeonTrackPositionT UnPack()
		{
			ITeleportToCurDungeonTrackPositionT teleportToCurDungeonTrackPositionT = new ITeleportToCurDungeonTrackPositionT();
			this.UnPackTo(teleportToCurDungeonTrackPositionT);
			return teleportToCurDungeonTrackPositionT;
		}

		// Token: 0x0601CFEA RID: 118762 RVA: 0x0041399B File Offset: 0x00411B9B
		public void UnPackTo(ITeleportToCurDungeonTrackPositionT _o)
		{
			_o.Type = this.Type;
			_o.NodeId = this.NodeId;
			_o.NodeIndex = this.NodeIndex;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601CFEB RID: 118763 RVA: 0x004139D0 File Offset: 0x00411BD0
		public static Offset<ITeleportToCurDungeonTrackPosition> Pack(FlatBufferBuilder builder, ITeleportToCurDungeonTrackPositionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportToCurDungeonTrackPosition>);
			}
			return ITeleportToCurDungeonTrackPosition.CreateITeleportToCurDungeonTrackPosition(builder, _o.Type, _o.NodeId, _o.NodeIndex, _o.NullMask);
		}

		// Token: 0x0400D2AC RID: 53932
		private Table __p;
	}
}
