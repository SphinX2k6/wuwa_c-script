using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004ACF RID: 19151
	public struct ICheckNodeStatus : IFlatbufferObject
	{
		// Token: 0x17008AD8 RID: 35544
		// (get) Token: 0x0601E12A RID: 123178 RVA: 0x0043814C File Offset: 0x0043634C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E12B RID: 123179 RVA: 0x00438159 File Offset: 0x00436359
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E12C RID: 123180 RVA: 0x00438160 File Offset: 0x00436360
		public static ICheckNodeStatus GetRootAsICheckNodeStatus(ByteBuffer _bb)
		{
			return ICheckNodeStatus.GetRootAsICheckNodeStatus(_bb, default(ICheckNodeStatus));
		}

		// Token: 0x0601E12D RID: 123181 RVA: 0x0043817C File Offset: 0x0043637C
		public static ICheckNodeStatus GetRootAsICheckNodeStatus(ByteBuffer _bb, ICheckNodeStatus obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E12E RID: 123182 RVA: 0x00438199 File Offset: 0x00436399
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E12F RID: 123183 RVA: 0x004381A8 File Offset: 0x004363A8
		public ICheckNodeStatus __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008AD9 RID: 35545
		// (get) Token: 0x0601E130 RID: 123184 RVA: 0x004381B8 File Offset: 0x004363B8
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

		// Token: 0x17008ADA RID: 35546
		// (get) Token: 0x0601E131 RID: 123185 RVA: 0x004381F4 File Offset: 0x004363F4
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

		// Token: 0x17008ADB RID: 35547
		// (get) Token: 0x0601E132 RID: 123186 RVA: 0x00438230 File Offset: 0x00436430
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

		// Token: 0x0601E133 RID: 123187 RVA: 0x0043826C File Offset: 0x0043646C
		public static Offset<ICheckNodeStatus> CreateICheckNodeStatus(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int NodeId = 0, ENodeStatusType Status = ENodeStatusType.NotActive)
		{
			builder.StartTable(3);
			ICheckNodeStatus.AddNodeId(builder, NodeId);
			ICheckNodeStatus.AddStatus(builder, Status);
			ICheckNodeStatus.AddType(builder, Type);
			return ICheckNodeStatus.EndICheckNodeStatus(builder);
		}

		// Token: 0x0601E134 RID: 123188 RVA: 0x00438290 File Offset: 0x00436490
		public static void StartICheckNodeStatus(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601E135 RID: 123189 RVA: 0x00438299 File Offset: 0x00436499
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E136 RID: 123190 RVA: 0x004382A4 File Offset: 0x004364A4
		public static void AddNodeId(FlatBufferBuilder builder, int nodeId)
		{
			builder.AddInt(1, nodeId, 0);
		}

		// Token: 0x0601E137 RID: 123191 RVA: 0x004382AF File Offset: 0x004364AF
		public static void AddStatus(FlatBufferBuilder builder, ENodeStatusType status)
		{
			builder.AddByte(2, (byte)status, 0);
		}

		// Token: 0x0601E138 RID: 123192 RVA: 0x004382BA File Offset: 0x004364BA
		public static Offset<ICheckNodeStatus> EndICheckNodeStatus(FlatBufferBuilder builder)
		{
			return new Offset<ICheckNodeStatus>(builder.EndTable());
		}

		// Token: 0x0601E139 RID: 123193 RVA: 0x004382C8 File Offset: 0x004364C8
		public ICheckNodeStatusT UnPack()
		{
			ICheckNodeStatusT checkNodeStatusT = new ICheckNodeStatusT();
			this.UnPackTo(checkNodeStatusT);
			return checkNodeStatusT;
		}

		// Token: 0x0601E13A RID: 123194 RVA: 0x004382E3 File Offset: 0x004364E3
		public void UnPackTo(ICheckNodeStatusT _o)
		{
			_o.Type = this.Type;
			_o.NodeId = this.NodeId;
			_o.Status = this.Status;
		}

		// Token: 0x0601E13B RID: 123195 RVA: 0x0043830C File Offset: 0x0043650C
		public static Offset<ICheckNodeStatus> Pack(FlatBufferBuilder builder, ICheckNodeStatusT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckNodeStatus>);
			}
			return ICheckNodeStatus.CreateICheckNodeStatus(builder, _o.Type, _o.NodeId, _o.Status);
		}

		// Token: 0x0400D357 RID: 54103
		private Table __p;
	}
}
