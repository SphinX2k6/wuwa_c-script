using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049F5 RID: 18933
	public struct IRollBlockHintStepRoll : IFlatbufferObject
	{
		// Token: 0x170084BF RID: 33983
		// (get) Token: 0x0601C624 RID: 116260 RVA: 0x00402A05 File Offset: 0x00400C05
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C625 RID: 116261 RVA: 0x00402A12 File Offset: 0x00400C12
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C626 RID: 116262 RVA: 0x00402A1C File Offset: 0x00400C1C
		public static IRollBlockHintStepRoll GetRootAsIRollBlockHintStepRoll(ByteBuffer _bb)
		{
			return IRollBlockHintStepRoll.GetRootAsIRollBlockHintStepRoll(_bb, default(IRollBlockHintStepRoll));
		}

		// Token: 0x0601C627 RID: 116263 RVA: 0x00402A38 File Offset: 0x00400C38
		public static IRollBlockHintStepRoll GetRootAsIRollBlockHintStepRoll(ByteBuffer _bb, IRollBlockHintStepRoll obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C628 RID: 116264 RVA: 0x00402A55 File Offset: 0x00400C55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C629 RID: 116265 RVA: 0x00402A64 File Offset: 0x00400C64
		public IRollBlockHintStepRoll __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170084C0 RID: 33984
		// (get) Token: 0x0601C62A RID: 116266 RVA: 0x00402A74 File Offset: 0x00400C74
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

		// Token: 0x170084C1 RID: 33985
		// (get) Token: 0x0601C62B RID: 116267 RVA: 0x00402AB0 File Offset: 0x00400CB0
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

		// Token: 0x170084C2 RID: 33986
		// (get) Token: 0x0601C62C RID: 116268 RVA: 0x00402AEC File Offset: 0x00400CEC
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

		// Token: 0x0601C62D RID: 116269 RVA: 0x00402B28 File Offset: 0x00400D28
		public static Offset<IRollBlockHintStepRoll> CreateIRollBlockHintStepRoll(FlatBufferBuilder builder, ERollBlockHintStepType Type = ERollBlockHintStepType.Roll, int BlockId = 0, ERollBlockLayType Direction = ERollBlockLayType.Left)
		{
			builder.StartTable(3);
			IRollBlockHintStepRoll.AddBlockId(builder, BlockId);
			IRollBlockHintStepRoll.AddDirection(builder, Direction);
			IRollBlockHintStepRoll.AddType(builder, Type);
			return IRollBlockHintStepRoll.EndIRollBlockHintStepRoll(builder);
		}

		// Token: 0x0601C62E RID: 116270 RVA: 0x00402B4C File Offset: 0x00400D4C
		public static void StartIRollBlockHintStepRoll(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601C62F RID: 116271 RVA: 0x00402B55 File Offset: 0x00400D55
		public static void AddType(FlatBufferBuilder builder, ERollBlockHintStepType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C630 RID: 116272 RVA: 0x00402B60 File Offset: 0x00400D60
		public static void AddBlockId(FlatBufferBuilder builder, int blockId)
		{
			builder.AddInt(1, blockId, 0);
		}

		// Token: 0x0601C631 RID: 116273 RVA: 0x00402B6B File Offset: 0x00400D6B
		public static void AddDirection(FlatBufferBuilder builder, ERollBlockLayType direction)
		{
			builder.AddByte(2, (byte)direction, 0);
		}

		// Token: 0x0601C632 RID: 116274 RVA: 0x00402B76 File Offset: 0x00400D76
		public static Offset<IRollBlockHintStepRoll> EndIRollBlockHintStepRoll(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockHintStepRoll>(builder.EndTable());
		}

		// Token: 0x0601C633 RID: 116275 RVA: 0x00402B84 File Offset: 0x00400D84
		public IRollBlockHintStepRollT UnPack()
		{
			IRollBlockHintStepRollT rollBlockHintStepRollT = new IRollBlockHintStepRollT();
			this.UnPackTo(rollBlockHintStepRollT);
			return rollBlockHintStepRollT;
		}

		// Token: 0x0601C634 RID: 116276 RVA: 0x00402B9F File Offset: 0x00400D9F
		public void UnPackTo(IRollBlockHintStepRollT _o)
		{
			_o.Type = this.Type;
			_o.BlockId = this.BlockId;
			_o.Direction = this.Direction;
		}

		// Token: 0x0601C635 RID: 116277 RVA: 0x00402BC8 File Offset: 0x00400DC8
		public static Offset<IRollBlockHintStepRoll> Pack(FlatBufferBuilder builder, IRollBlockHintStepRollT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockHintStepRoll>);
			}
			return IRollBlockHintStepRoll.CreateIRollBlockHintStepRoll(builder, _o.Type, _o.BlockId, _o.Direction);
		}

		// Token: 0x0400D075 RID: 53365
		private Table __p;
	}
}
