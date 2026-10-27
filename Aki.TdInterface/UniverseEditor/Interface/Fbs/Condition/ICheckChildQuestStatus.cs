using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200499D RID: 18845
	public struct ICheckChildQuestStatus : IFlatbufferObject
	{
		// Token: 0x1700882D RID: 34861
		// (get) Token: 0x0601D654 RID: 120404 RVA: 0x004249C0 File Offset: 0x00422BC0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D655 RID: 120405 RVA: 0x004249CD File Offset: 0x00422BCD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D656 RID: 120406 RVA: 0x004249D4 File Offset: 0x00422BD4
		public static ICheckChildQuestStatus GetRootAsICheckChildQuestStatus(ByteBuffer _bb)
		{
			return ICheckChildQuestStatus.GetRootAsICheckChildQuestStatus(_bb, default(ICheckChildQuestStatus));
		}

		// Token: 0x0601D657 RID: 120407 RVA: 0x004249F0 File Offset: 0x00422BF0
		public static ICheckChildQuestStatus GetRootAsICheckChildQuestStatus(ByteBuffer _bb, ICheckChildQuestStatus obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D658 RID: 120408 RVA: 0x00424A0D File Offset: 0x00422C0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D659 RID: 120409 RVA: 0x00424A1C File Offset: 0x00422C1C
		public ICheckChildQuestStatus __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700882E RID: 34862
		// (get) Token: 0x0601D65A RID: 120410 RVA: 0x00424A2C File Offset: 0x00422C2C
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

		// Token: 0x1700882F RID: 34863
		// (get) Token: 0x0601D65B RID: 120411 RVA: 0x00424A68 File Offset: 0x00422C68
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

		// Token: 0x17008830 RID: 34864
		// (get) Token: 0x0601D65C RID: 120412 RVA: 0x00424AA4 File Offset: 0x00422CA4
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

		// Token: 0x0601D65D RID: 120413 RVA: 0x00424AE0 File Offset: 0x00422CE0
		public static Offset<ICheckChildQuestStatus> CreateICheckChildQuestStatus(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int NodeId = 0, EQuestNodeStatusType Status = EQuestNodeStatusType.CqnsNotActive)
		{
			builder.StartTable(3);
			ICheckChildQuestStatus.AddNodeId(builder, NodeId);
			ICheckChildQuestStatus.AddStatus(builder, Status);
			ICheckChildQuestStatus.AddType(builder, Type);
			return ICheckChildQuestStatus.EndICheckChildQuestStatus(builder);
		}

		// Token: 0x0601D65E RID: 120414 RVA: 0x00424B04 File Offset: 0x00422D04
		public static void StartICheckChildQuestStatus(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601D65F RID: 120415 RVA: 0x00424B0D File Offset: 0x00422D0D
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D660 RID: 120416 RVA: 0x00424B18 File Offset: 0x00422D18
		public static void AddNodeId(FlatBufferBuilder builder, int nodeId)
		{
			builder.AddInt(1, nodeId, 0);
		}

		// Token: 0x0601D661 RID: 120417 RVA: 0x00424B23 File Offset: 0x00422D23
		public static void AddStatus(FlatBufferBuilder builder, EQuestNodeStatusType status)
		{
			builder.AddByte(2, (byte)status, 0);
		}

		// Token: 0x0601D662 RID: 120418 RVA: 0x00424B2E File Offset: 0x00422D2E
		public static Offset<ICheckChildQuestStatus> EndICheckChildQuestStatus(FlatBufferBuilder builder)
		{
			return new Offset<ICheckChildQuestStatus>(builder.EndTable());
		}

		// Token: 0x0601D663 RID: 120419 RVA: 0x00424B3C File Offset: 0x00422D3C
		public ICheckChildQuestStatusT UnPack()
		{
			ICheckChildQuestStatusT checkChildQuestStatusT = new ICheckChildQuestStatusT();
			this.UnPackTo(checkChildQuestStatusT);
			return checkChildQuestStatusT;
		}

		// Token: 0x0601D664 RID: 120420 RVA: 0x00424B57 File Offset: 0x00422D57
		public void UnPackTo(ICheckChildQuestStatusT _o)
		{
			_o.Type = this.Type;
			_o.NodeId = this.NodeId;
			_o.Status = this.Status;
		}

		// Token: 0x0601D665 RID: 120421 RVA: 0x00424B80 File Offset: 0x00422D80
		public static Offset<ICheckChildQuestStatus> Pack(FlatBufferBuilder builder, ICheckChildQuestStatusT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckChildQuestStatus>);
			}
			return ICheckChildQuestStatus.CreateICheckChildQuestStatus(builder, _o.Type, _o.NodeId, _o.Status);
		}

		// Token: 0x0400D1B4 RID: 53684
		private Table __p;
	}
}
