using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FA1 RID: 20385
	public struct ICheckNodeStatus : IFlatbufferObject
	{
		// Token: 0x170091CA RID: 37322
		// (get) Token: 0x0601FC29 RID: 130089 RVA: 0x00469BF8 File Offset: 0x00467DF8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FC2A RID: 130090 RVA: 0x00469C05 File Offset: 0x00467E05
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FC2B RID: 130091 RVA: 0x00469C0C File Offset: 0x00467E0C
		public static ICheckNodeStatus GetRootAsICheckNodeStatus(ByteBuffer _bb)
		{
			return ICheckNodeStatus.GetRootAsICheckNodeStatus(_bb, default(ICheckNodeStatus));
		}

		// Token: 0x0601FC2C RID: 130092 RVA: 0x00469C28 File Offset: 0x00467E28
		public static ICheckNodeStatus GetRootAsICheckNodeStatus(ByteBuffer _bb, ICheckNodeStatus obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FC2D RID: 130093 RVA: 0x00469C45 File Offset: 0x00467E45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FC2E RID: 130094 RVA: 0x00469C54 File Offset: 0x00467E54
		public ICheckNodeStatus __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170091CB RID: 37323
		// (get) Token: 0x0601FC2F RID: 130095 RVA: 0x00469C64 File Offset: 0x00467E64
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

		// Token: 0x170091CC RID: 37324
		// (get) Token: 0x0601FC30 RID: 130096 RVA: 0x00469CA0 File Offset: 0x00467EA0
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

		// Token: 0x170091CD RID: 37325
		// (get) Token: 0x0601FC31 RID: 130097 RVA: 0x00469CDC File Offset: 0x00467EDC
		public ENodeStatusType Status
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ENodeStatusType.NotActive;
				}
				return (ENodeStatusType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FC32 RID: 130098 RVA: 0x00469D18 File Offset: 0x00467F18
		public static Offset<ICheckNodeStatus> CreateICheckNodeStatus(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int NodeId = 0, ENodeStatusType Status = ENodeStatusType.NotActive)
		{
			builder.StartTable(3);
			ICheckNodeStatus.AddNodeId(builder, NodeId);
			ICheckNodeStatus.AddStatus(builder, Status);
			ICheckNodeStatus.AddType(builder, Type);
			return ICheckNodeStatus.EndICheckNodeStatus(builder);
		}

		// Token: 0x0601FC33 RID: 130099 RVA: 0x00469D3C File Offset: 0x00467F3C
		public static void StartICheckNodeStatus(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601FC34 RID: 130100 RVA: 0x00469D45 File Offset: 0x00467F45
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FC35 RID: 130101 RVA: 0x00469D50 File Offset: 0x00467F50
		public static void AddNodeId(FlatBufferBuilder builder, int nodeId)
		{
			builder.AddInt(1, nodeId, 0);
		}

		// Token: 0x0601FC36 RID: 130102 RVA: 0x00469D5B File Offset: 0x00467F5B
		public static void AddStatus(FlatBufferBuilder builder, ENodeStatusType status)
		{
			builder.AddByte(2, (byte)status, 0);
		}

		// Token: 0x0601FC37 RID: 130103 RVA: 0x00469D66 File Offset: 0x00467F66
		public static Offset<ICheckNodeStatus> EndICheckNodeStatus(FlatBufferBuilder builder)
		{
			return new Offset<ICheckNodeStatus>(builder.EndTable());
		}

		// Token: 0x0601FC38 RID: 130104 RVA: 0x00469D74 File Offset: 0x00467F74
		public ICheckNodeStatusT UnPack()
		{
			ICheckNodeStatusT checkNodeStatusT = new ICheckNodeStatusT();
			this.UnPackTo(checkNodeStatusT);
			return checkNodeStatusT;
		}

		// Token: 0x0601FC39 RID: 130105 RVA: 0x00469D8F File Offset: 0x00467F8F
		public void UnPackTo(ICheckNodeStatusT _o)
		{
			_o.Type = this.Type;
			_o.NodeId = this.NodeId;
			_o.Status = this.Status;
		}

		// Token: 0x0601FC3A RID: 130106 RVA: 0x00469DB8 File Offset: 0x00467FB8
		public static Offset<ICheckNodeStatus> Pack(FlatBufferBuilder builder, ICheckNodeStatusT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckNodeStatus>);
			}
			return ICheckNodeStatus.CreateICheckNodeStatus(builder, _o.Type, _o.NodeId, _o.Status);
		}

		// Token: 0x0400DE3F RID: 56895
		private Table __p;
	}
}
