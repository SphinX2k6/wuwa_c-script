using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AB9 RID: 19129
	public struct IFinishCurTrackDungeonNode : IFlatbufferObject
	{
		// Token: 0x17008602 RID: 34306
		// (get) Token: 0x0601CC3E RID: 117822 RVA: 0x0040D9CC File Offset: 0x0040BBCC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CC3F RID: 117823 RVA: 0x0040D9D9 File Offset: 0x0040BBD9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CC40 RID: 117824 RVA: 0x0040D9E0 File Offset: 0x0040BBE0
		public static IFinishCurTrackDungeonNode GetRootAsIFinishCurTrackDungeonNode(ByteBuffer _bb)
		{
			return IFinishCurTrackDungeonNode.GetRootAsIFinishCurTrackDungeonNode(_bb, default(IFinishCurTrackDungeonNode));
		}

		// Token: 0x0601CC41 RID: 117825 RVA: 0x0040D9FC File Offset: 0x0040BBFC
		public static IFinishCurTrackDungeonNode GetRootAsIFinishCurTrackDungeonNode(ByteBuffer _bb, IFinishCurTrackDungeonNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CC42 RID: 117826 RVA: 0x0040DA19 File Offset: 0x0040BC19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CC43 RID: 117827 RVA: 0x0040DA28 File Offset: 0x0040BC28
		public IFinishCurTrackDungeonNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008603 RID: 34307
		// (get) Token: 0x0601CC44 RID: 117828 RVA: 0x0040DA38 File Offset: 0x0040BC38
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

		// Token: 0x17008604 RID: 34308
		// (get) Token: 0x0601CC45 RID: 117829 RVA: 0x0040DA74 File Offset: 0x0040BC74
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

		// Token: 0x17008605 RID: 34309
		// (get) Token: 0x0601CC46 RID: 117830 RVA: 0x0040DAB0 File Offset: 0x0040BCB0
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

		// Token: 0x17008606 RID: 34310
		// (get) Token: 0x0601CC47 RID: 117831 RVA: 0x0040DAEC File Offset: 0x0040BCEC
		public bool IsComplete
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008607 RID: 34311
		// (get) Token: 0x0601CC48 RID: 117832 RVA: 0x0040DB2C File Offset: 0x0040BD2C
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

		// Token: 0x0601CC49 RID: 117833 RVA: 0x0040DB69 File Offset: 0x0040BD69
		public static Offset<IFinishCurTrackDungeonNode> CreateIFinishCurTrackDungeonNode(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int NodeId = 0, int NodeIndex = 0, bool IsComplete = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			IFinishCurTrackDungeonNode.AddNodeIndex(builder, NodeIndex);
			IFinishCurTrackDungeonNode.AddNodeId(builder, NodeId);
			IFinishCurTrackDungeonNode.AddNullMask(builder, NullMask);
			IFinishCurTrackDungeonNode.AddIsComplete(builder, IsComplete);
			IFinishCurTrackDungeonNode.AddType(builder, Type);
			return IFinishCurTrackDungeonNode.EndIFinishCurTrackDungeonNode(builder);
		}

		// Token: 0x0601CC4A RID: 117834 RVA: 0x0040DB9D File Offset: 0x0040BD9D
		public static void StartIFinishCurTrackDungeonNode(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601CC4B RID: 117835 RVA: 0x0040DBA6 File Offset: 0x0040BDA6
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CC4C RID: 117836 RVA: 0x0040DBB1 File Offset: 0x0040BDB1
		public static void AddNodeId(FlatBufferBuilder builder, int nodeId)
		{
			builder.AddInt(1, nodeId, 0);
		}

		// Token: 0x0601CC4D RID: 117837 RVA: 0x0040DBBC File Offset: 0x0040BDBC
		public static void AddNodeIndex(FlatBufferBuilder builder, int nodeIndex)
		{
			builder.AddInt(2, nodeIndex, 0);
		}

		// Token: 0x0601CC4E RID: 117838 RVA: 0x0040DBC7 File Offset: 0x0040BDC7
		public static void AddIsComplete(FlatBufferBuilder builder, bool isComplete)
		{
			builder.AddBool(3, isComplete, false);
		}

		// Token: 0x0601CC4F RID: 117839 RVA: 0x0040DBD2 File Offset: 0x0040BDD2
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601CC50 RID: 117840 RVA: 0x0040DBDD File Offset: 0x0040BDDD
		public static Offset<IFinishCurTrackDungeonNode> EndIFinishCurTrackDungeonNode(FlatBufferBuilder builder)
		{
			return new Offset<IFinishCurTrackDungeonNode>(builder.EndTable());
		}

		// Token: 0x0601CC51 RID: 117841 RVA: 0x0040DBEC File Offset: 0x0040BDEC
		public IFinishCurTrackDungeonNodeT UnPack()
		{
			IFinishCurTrackDungeonNodeT finishCurTrackDungeonNodeT = new IFinishCurTrackDungeonNodeT();
			this.UnPackTo(finishCurTrackDungeonNodeT);
			return finishCurTrackDungeonNodeT;
		}

		// Token: 0x0601CC52 RID: 117842 RVA: 0x0040DC07 File Offset: 0x0040BE07
		public void UnPackTo(IFinishCurTrackDungeonNodeT _o)
		{
			_o.Type = this.Type;
			_o.NodeId = this.NodeId;
			_o.NodeIndex = this.NodeIndex;
			_o.IsComplete = this.IsComplete;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601CC53 RID: 117843 RVA: 0x0040DC48 File Offset: 0x0040BE48
		public static Offset<IFinishCurTrackDungeonNode> Pack(FlatBufferBuilder builder, IFinishCurTrackDungeonNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFinishCurTrackDungeonNode>);
			}
			return IFinishCurTrackDungeonNode.CreateIFinishCurTrackDungeonNode(builder, _o.Type, _o.NodeId, _o.NodeIndex, _o.IsComplete, _o.NullMask);
		}

		// Token: 0x0400D1FB RID: 53755
		private Table __p;
	}
}
