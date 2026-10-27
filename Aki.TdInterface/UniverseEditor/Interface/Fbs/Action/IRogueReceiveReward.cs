using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EE8 RID: 28392
	public struct IRogueReceiveReward : IFlatbufferObject
	{
		// Token: 0x1700D33C RID: 54076
		// (get) Token: 0x060322C5 RID: 205509 RVA: 0x006C7E6F File Offset: 0x006C606F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060322C6 RID: 205510 RVA: 0x006C7E7C File Offset: 0x006C607C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060322C7 RID: 205511 RVA: 0x006C7E84 File Offset: 0x006C6084
		public static IRogueReceiveReward GetRootAsIRogueReceiveReward(ByteBuffer _bb)
		{
			return IRogueReceiveReward.GetRootAsIRogueReceiveReward(_bb, default(IRogueReceiveReward));
		}

		// Token: 0x060322C8 RID: 205512 RVA: 0x006C7EA0 File Offset: 0x006C60A0
		public static IRogueReceiveReward GetRootAsIRogueReceiveReward(ByteBuffer _bb, IRogueReceiveReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060322C9 RID: 205513 RVA: 0x006C7EBD File Offset: 0x006C60BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060322CA RID: 205514 RVA: 0x006C7ECC File Offset: 0x006C60CC
		public IRogueReceiveReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D33D RID: 54077
		// (get) Token: 0x060322CB RID: 205515 RVA: 0x006C7EDC File Offset: 0x006C60DC
		public ERogueRewardReceiveType RogueRewardReceiveType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERogueRewardReceiveType.ReceiveByCount;
				}
				return (ERogueRewardReceiveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D33E RID: 54078
		// (get) Token: 0x060322CC RID: 205516 RVA: 0x006C7F18 File Offset: 0x006C6118
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060322CD RID: 205517 RVA: 0x006C7F54 File Offset: 0x006C6154
		public static Offset<IRogueReceiveReward> CreateIRogueReceiveReward(FlatBufferBuilder builder, ERogueRewardReceiveType RogueRewardReceiveType = ERogueRewardReceiveType.ReceiveByCount, byte NullMask = 0)
		{
			builder.StartTable(2);
			IRogueReceiveReward.AddNullMask(builder, NullMask);
			IRogueReceiveReward.AddRogueRewardReceiveType(builder, RogueRewardReceiveType);
			return IRogueReceiveReward.EndIRogueReceiveReward(builder);
		}

		// Token: 0x060322CE RID: 205518 RVA: 0x006C7F71 File Offset: 0x006C6171
		public static void StartIRogueReceiveReward(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060322CF RID: 205519 RVA: 0x006C7F7A File Offset: 0x006C617A
		public static void AddRogueRewardReceiveType(FlatBufferBuilder builder, ERogueRewardReceiveType rogueRewardReceiveType)
		{
			builder.AddByte(0, (byte)rogueRewardReceiveType, 0);
		}

		// Token: 0x060322D0 RID: 205520 RVA: 0x006C7F85 File Offset: 0x006C6185
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x060322D1 RID: 205521 RVA: 0x006C7F90 File Offset: 0x006C6190
		public static Offset<IRogueReceiveReward> EndIRogueReceiveReward(FlatBufferBuilder builder)
		{
			return new Offset<IRogueReceiveReward>(builder.EndTable());
		}

		// Token: 0x060322D2 RID: 205522 RVA: 0x006C7FA0 File Offset: 0x006C61A0
		public IRogueReceiveRewardT UnPack()
		{
			IRogueReceiveRewardT rogueReceiveRewardT = new IRogueReceiveRewardT();
			this.UnPackTo(rogueReceiveRewardT);
			return rogueReceiveRewardT;
		}

		// Token: 0x060322D3 RID: 205523 RVA: 0x006C7FBB File Offset: 0x006C61BB
		public void UnPackTo(IRogueReceiveRewardT _o)
		{
			_o.RogueRewardReceiveType = this.RogueRewardReceiveType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060322D4 RID: 205524 RVA: 0x006C7FD8 File Offset: 0x006C61D8
		public static Offset<IRogueReceiveReward> Pack(FlatBufferBuilder builder, IRogueReceiveRewardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRogueReceiveReward>);
			}
			return IRogueReceiveReward.CreateIRogueReceiveReward(builder, _o.RogueRewardReceiveType, _o.NullMask);
		}

		// Token: 0x040118DD RID: 71901
		private Table __p;
	}
}
