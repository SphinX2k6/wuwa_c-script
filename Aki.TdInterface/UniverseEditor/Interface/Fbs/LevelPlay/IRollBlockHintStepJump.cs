using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049EF RID: 18927
	public struct IRollBlockHintStepJump : IFlatbufferObject
	{
		// Token: 0x170084B5 RID: 33973
		// (get) Token: 0x0601C5F8 RID: 116216 RVA: 0x004025FE File Offset: 0x004007FE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C5F9 RID: 116217 RVA: 0x0040260B File Offset: 0x0040080B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C5FA RID: 116218 RVA: 0x00402614 File Offset: 0x00400814
		public static IRollBlockHintStepJump GetRootAsIRollBlockHintStepJump(ByteBuffer _bb)
		{
			return IRollBlockHintStepJump.GetRootAsIRollBlockHintStepJump(_bb, default(IRollBlockHintStepJump));
		}

		// Token: 0x0601C5FB RID: 116219 RVA: 0x00402630 File Offset: 0x00400830
		public static IRollBlockHintStepJump GetRootAsIRollBlockHintStepJump(ByteBuffer _bb, IRollBlockHintStepJump obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C5FC RID: 116220 RVA: 0x0040264D File Offset: 0x0040084D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C5FD RID: 116221 RVA: 0x0040265C File Offset: 0x0040085C
		public IRollBlockHintStepJump __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170084B6 RID: 33974
		// (get) Token: 0x0601C5FE RID: 116222 RVA: 0x0040266C File Offset: 0x0040086C
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

		// Token: 0x170084B7 RID: 33975
		// (get) Token: 0x0601C5FF RID: 116223 RVA: 0x004026A8 File Offset: 0x004008A8
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

		// Token: 0x170084B8 RID: 33976
		// (get) Token: 0x0601C600 RID: 116224 RVA: 0x004026E4 File Offset: 0x004008E4
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

		// Token: 0x0601C601 RID: 116225 RVA: 0x00402720 File Offset: 0x00400920
		public static Offset<IRollBlockHintStepJump> CreateIRollBlockHintStepJump(FlatBufferBuilder builder, ERollBlockHintStepType Type = ERollBlockHintStepType.Roll, int BlockId = 0, ERollBlockLayType Direction = ERollBlockLayType.Left)
		{
			builder.StartTable(3);
			IRollBlockHintStepJump.AddBlockId(builder, BlockId);
			IRollBlockHintStepJump.AddDirection(builder, Direction);
			IRollBlockHintStepJump.AddType(builder, Type);
			return IRollBlockHintStepJump.EndIRollBlockHintStepJump(builder);
		}

		// Token: 0x0601C602 RID: 116226 RVA: 0x00402744 File Offset: 0x00400944
		public static void StartIRollBlockHintStepJump(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601C603 RID: 116227 RVA: 0x0040274D File Offset: 0x0040094D
		public static void AddType(FlatBufferBuilder builder, ERollBlockHintStepType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C604 RID: 116228 RVA: 0x00402758 File Offset: 0x00400958
		public static void AddBlockId(FlatBufferBuilder builder, int blockId)
		{
			builder.AddInt(1, blockId, 0);
		}

		// Token: 0x0601C605 RID: 116229 RVA: 0x00402763 File Offset: 0x00400963
		public static void AddDirection(FlatBufferBuilder builder, ERollBlockLayType direction)
		{
			builder.AddByte(2, (byte)direction, 0);
		}

		// Token: 0x0601C606 RID: 116230 RVA: 0x0040276E File Offset: 0x0040096E
		public static Offset<IRollBlockHintStepJump> EndIRollBlockHintStepJump(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockHintStepJump>(builder.EndTable());
		}

		// Token: 0x0601C607 RID: 116231 RVA: 0x0040277C File Offset: 0x0040097C
		public IRollBlockHintStepJumpT UnPack()
		{
			IRollBlockHintStepJumpT rollBlockHintStepJumpT = new IRollBlockHintStepJumpT();
			this.UnPackTo(rollBlockHintStepJumpT);
			return rollBlockHintStepJumpT;
		}

		// Token: 0x0601C608 RID: 116232 RVA: 0x00402797 File Offset: 0x00400997
		public void UnPackTo(IRollBlockHintStepJumpT _o)
		{
			_o.Type = this.Type;
			_o.BlockId = this.BlockId;
			_o.Direction = this.Direction;
		}

		// Token: 0x0601C609 RID: 116233 RVA: 0x004027C0 File Offset: 0x004009C0
		public static Offset<IRollBlockHintStepJump> Pack(FlatBufferBuilder builder, IRollBlockHintStepJumpT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockHintStepJump>);
			}
			return IRollBlockHintStepJump.CreateIRollBlockHintStepJump(builder, _o.Type, _o.BlockId, _o.Direction);
		}

		// Token: 0x0400D06F RID: 53359
		private Table __p;
	}
}
