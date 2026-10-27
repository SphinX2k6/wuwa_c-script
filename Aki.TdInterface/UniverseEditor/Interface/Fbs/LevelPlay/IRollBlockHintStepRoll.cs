using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200458D RID: 17805
	public struct IRollBlockHintStepRoll : IFlatbufferObject
	{
		// Token: 0x17007E7E RID: 32382
		// (get) Token: 0x0601AE4F RID: 110159 RVA: 0x003D6769 File Offset: 0x003D4969
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AE50 RID: 110160 RVA: 0x003D6776 File Offset: 0x003D4976
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AE51 RID: 110161 RVA: 0x003D6780 File Offset: 0x003D4980
		public static IRollBlockHintStepRoll GetRootAsIRollBlockHintStepRoll(ByteBuffer _bb)
		{
			return IRollBlockHintStepRoll.GetRootAsIRollBlockHintStepRoll(_bb, default(IRollBlockHintStepRoll));
		}

		// Token: 0x0601AE52 RID: 110162 RVA: 0x003D679C File Offset: 0x003D499C
		public static IRollBlockHintStepRoll GetRootAsIRollBlockHintStepRoll(ByteBuffer _bb, IRollBlockHintStepRoll obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AE53 RID: 110163 RVA: 0x003D67B9 File Offset: 0x003D49B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AE54 RID: 110164 RVA: 0x003D67C8 File Offset: 0x003D49C8
		public IRollBlockHintStepRoll __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E7F RID: 32383
		// (get) Token: 0x0601AE55 RID: 110165 RVA: 0x003D67D8 File Offset: 0x003D49D8
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

		// Token: 0x17007E80 RID: 32384
		// (get) Token: 0x0601AE56 RID: 110166 RVA: 0x003D6814 File Offset: 0x003D4A14
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

		// Token: 0x17007E81 RID: 32385
		// (get) Token: 0x0601AE57 RID: 110167 RVA: 0x003D6850 File Offset: 0x003D4A50
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

		// Token: 0x0601AE58 RID: 110168 RVA: 0x003D688C File Offset: 0x003D4A8C
		public static Offset<IRollBlockHintStepRoll> CreateIRollBlockHintStepRoll(FlatBufferBuilder builder, ERollBlockHintStepType Type = ERollBlockHintStepType.Roll, int BlockId = 0, ERollBlockLayType Direction = ERollBlockLayType.Left)
		{
			builder.StartTable(3);
			IRollBlockHintStepRoll.AddBlockId(builder, BlockId);
			IRollBlockHintStepRoll.AddDirection(builder, Direction);
			IRollBlockHintStepRoll.AddType(builder, Type);
			return IRollBlockHintStepRoll.EndIRollBlockHintStepRoll(builder);
		}

		// Token: 0x0601AE59 RID: 110169 RVA: 0x003D68B0 File Offset: 0x003D4AB0
		public static void StartIRollBlockHintStepRoll(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601AE5A RID: 110170 RVA: 0x003D68B9 File Offset: 0x003D4AB9
		public static void AddType(FlatBufferBuilder builder, ERollBlockHintStepType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AE5B RID: 110171 RVA: 0x003D68C4 File Offset: 0x003D4AC4
		public static void AddBlockId(FlatBufferBuilder builder, int blockId)
		{
			builder.AddInt(1, blockId, 0);
		}

		// Token: 0x0601AE5C RID: 110172 RVA: 0x003D68CF File Offset: 0x003D4ACF
		public static void AddDirection(FlatBufferBuilder builder, ERollBlockLayType direction)
		{
			builder.AddByte(2, (byte)direction, 0);
		}

		// Token: 0x0601AE5D RID: 110173 RVA: 0x003D68DA File Offset: 0x003D4ADA
		public static Offset<IRollBlockHintStepRoll> EndIRollBlockHintStepRoll(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockHintStepRoll>(builder.EndTable());
		}

		// Token: 0x0601AE5E RID: 110174 RVA: 0x003D68E8 File Offset: 0x003D4AE8
		public IRollBlockHintStepRollT UnPack()
		{
			IRollBlockHintStepRollT rollBlockHintStepRollT = new IRollBlockHintStepRollT();
			this.UnPackTo(rollBlockHintStepRollT);
			return rollBlockHintStepRollT;
		}

		// Token: 0x0601AE5F RID: 110175 RVA: 0x003D6903 File Offset: 0x003D4B03
		public void UnPackTo(IRollBlockHintStepRollT _o)
		{
			_o.Type = this.Type;
			_o.BlockId = this.BlockId;
			_o.Direction = this.Direction;
		}

		// Token: 0x0601AE60 RID: 110176 RVA: 0x003D692C File Offset: 0x003D4B2C
		public static Offset<IRollBlockHintStepRoll> Pack(FlatBufferBuilder builder, IRollBlockHintStepRollT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockHintStepRoll>);
			}
			return IRollBlockHintStepRoll.CreateIRollBlockHintStepRoll(builder, _o.Type, _o.BlockId, _o.Direction);
		}

		// Token: 0x0400C646 RID: 50758
		private Table __p;
	}
}
