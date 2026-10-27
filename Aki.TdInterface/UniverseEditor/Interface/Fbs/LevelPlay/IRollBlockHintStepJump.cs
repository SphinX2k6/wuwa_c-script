using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004587 RID: 17799
	public struct IRollBlockHintStepJump : IFlatbufferObject
	{
		// Token: 0x17007E74 RID: 32372
		// (get) Token: 0x0601AE23 RID: 110115 RVA: 0x003D6362 File Offset: 0x003D4562
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AE24 RID: 110116 RVA: 0x003D636F File Offset: 0x003D456F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AE25 RID: 110117 RVA: 0x003D6378 File Offset: 0x003D4578
		public static IRollBlockHintStepJump GetRootAsIRollBlockHintStepJump(ByteBuffer _bb)
		{
			return IRollBlockHintStepJump.GetRootAsIRollBlockHintStepJump(_bb, default(IRollBlockHintStepJump));
		}

		// Token: 0x0601AE26 RID: 110118 RVA: 0x003D6394 File Offset: 0x003D4594
		public static IRollBlockHintStepJump GetRootAsIRollBlockHintStepJump(ByteBuffer _bb, IRollBlockHintStepJump obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AE27 RID: 110119 RVA: 0x003D63B1 File Offset: 0x003D45B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AE28 RID: 110120 RVA: 0x003D63C0 File Offset: 0x003D45C0
		public IRollBlockHintStepJump __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E75 RID: 32373
		// (get) Token: 0x0601AE29 RID: 110121 RVA: 0x003D63D0 File Offset: 0x003D45D0
		public ERollBlockHintStepType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERollBlockHintStepType.Roll;
				}
				return (ERollBlockHintStepType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007E76 RID: 32374
		// (get) Token: 0x0601AE2A RID: 110122 RVA: 0x003D640C File Offset: 0x003D460C
		public int BlockId
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

		// Token: 0x17007E77 RID: 32375
		// (get) Token: 0x0601AE2B RID: 110123 RVA: 0x003D6448 File Offset: 0x003D4648
		public ERollBlockLayType Direction
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ERollBlockLayType.Left;
				}
				return (ERollBlockLayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601AE2C RID: 110124 RVA: 0x003D6484 File Offset: 0x003D4684
		public static Offset<IRollBlockHintStepJump> CreateIRollBlockHintStepJump(FlatBufferBuilder builder, ERollBlockHintStepType Type = ERollBlockHintStepType.Roll, int BlockId = 0, ERollBlockLayType Direction = ERollBlockLayType.Left)
		{
			builder.StartTable(3);
			IRollBlockHintStepJump.AddBlockId(builder, BlockId);
			IRollBlockHintStepJump.AddDirection(builder, Direction);
			IRollBlockHintStepJump.AddType(builder, Type);
			return IRollBlockHintStepJump.EndIRollBlockHintStepJump(builder);
		}

		// Token: 0x0601AE2D RID: 110125 RVA: 0x003D64A8 File Offset: 0x003D46A8
		public static void StartIRollBlockHintStepJump(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601AE2E RID: 110126 RVA: 0x003D64B1 File Offset: 0x003D46B1
		public static void AddType(FlatBufferBuilder builder, ERollBlockHintStepType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AE2F RID: 110127 RVA: 0x003D64BC File Offset: 0x003D46BC
		public static void AddBlockId(FlatBufferBuilder builder, int blockId)
		{
			builder.AddInt(1, blockId, 0);
		}

		// Token: 0x0601AE30 RID: 110128 RVA: 0x003D64C7 File Offset: 0x003D46C7
		public static void AddDirection(FlatBufferBuilder builder, ERollBlockLayType direction)
		{
			builder.AddByte(2, (byte)direction, 0);
		}

		// Token: 0x0601AE31 RID: 110129 RVA: 0x003D64D2 File Offset: 0x003D46D2
		public static Offset<IRollBlockHintStepJump> EndIRollBlockHintStepJump(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockHintStepJump>(builder.EndTable());
		}

		// Token: 0x0601AE32 RID: 110130 RVA: 0x003D64E0 File Offset: 0x003D46E0
		public IRollBlockHintStepJumpT UnPack()
		{
			IRollBlockHintStepJumpT rollBlockHintStepJumpT = new IRollBlockHintStepJumpT();
			this.UnPackTo(rollBlockHintStepJumpT);
			return rollBlockHintStepJumpT;
		}

		// Token: 0x0601AE33 RID: 110131 RVA: 0x003D64FB File Offset: 0x003D46FB
		public void UnPackTo(IRollBlockHintStepJumpT _o)
		{
			_o.Type = this.Type;
			_o.BlockId = this.BlockId;
			_o.Direction = this.Direction;
		}

		// Token: 0x0601AE34 RID: 110132 RVA: 0x003D6524 File Offset: 0x003D4724
		public static Offset<IRollBlockHintStepJump> Pack(FlatBufferBuilder builder, IRollBlockHintStepJumpT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockHintStepJump>);
			}
			return IRollBlockHintStepJump.CreateIRollBlockHintStepJump(builder, _o.Type, _o.BlockId, _o.Direction);
		}

		// Token: 0x0400C640 RID: 50752
		private Table __p;
	}
}
