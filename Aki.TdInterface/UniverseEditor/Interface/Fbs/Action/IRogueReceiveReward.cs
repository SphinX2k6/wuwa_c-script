using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200766C RID: 30316
	public struct IRogueReceiveReward : IFlatbufferObject
	{
		// Token: 0x1700DE93 RID: 56979
		// (get) Token: 0x06035305 RID: 217861 RVA: 0x00723BA3 File Offset: 0x00721DA3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035306 RID: 217862 RVA: 0x00723BB0 File Offset: 0x00721DB0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035307 RID: 217863 RVA: 0x00723BB8 File Offset: 0x00721DB8
		public static IRogueReceiveReward GetRootAsIRogueReceiveReward(ByteBuffer _bb)
		{
			return IRogueReceiveReward.GetRootAsIRogueReceiveReward(_bb, default(IRogueReceiveReward));
		}

		// Token: 0x06035308 RID: 217864 RVA: 0x00723BD4 File Offset: 0x00721DD4
		public static IRogueReceiveReward GetRootAsIRogueReceiveReward(ByteBuffer _bb, IRogueReceiveReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035309 RID: 217865 RVA: 0x00723BF1 File Offset: 0x00721DF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603530A RID: 217866 RVA: 0x00723C00 File Offset: 0x00721E00
		public IRogueReceiveReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DE94 RID: 56980
		// (get) Token: 0x0603530B RID: 217867 RVA: 0x00723C10 File Offset: 0x00721E10
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

		// Token: 0x1700DE95 RID: 56981
		// (get) Token: 0x0603530C RID: 217868 RVA: 0x00723C4C File Offset: 0x00721E4C
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

		// Token: 0x0603530D RID: 217869 RVA: 0x00723C88 File Offset: 0x00721E88
		public static Offset<IRogueReceiveReward> CreateIRogueReceiveReward(FlatBufferBuilder builder, ERogueRewardReceiveType RogueRewardReceiveType = ERogueRewardReceiveType.ReceiveByCount, byte NullMask = 0)
		{
			builder.StartTable(2);
			IRogueReceiveReward.AddNullMask(builder, NullMask);
			IRogueReceiveReward.AddRogueRewardReceiveType(builder, RogueRewardReceiveType);
			return IRogueReceiveReward.EndIRogueReceiveReward(builder);
		}

		// Token: 0x0603530E RID: 217870 RVA: 0x00723CA5 File Offset: 0x00721EA5
		public static void StartIRogueReceiveReward(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603530F RID: 217871 RVA: 0x00723CAE File Offset: 0x00721EAE
		public static void AddRogueRewardReceiveType(FlatBufferBuilder builder, ERogueRewardReceiveType rogueRewardReceiveType)
		{
			builder.AddByte(0, (byte)rogueRewardReceiveType, 0);
		}

		// Token: 0x06035310 RID: 217872 RVA: 0x00723CB9 File Offset: 0x00721EB9
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x06035311 RID: 217873 RVA: 0x00723CC4 File Offset: 0x00721EC4
		public static Offset<IRogueReceiveReward> EndIRogueReceiveReward(FlatBufferBuilder builder)
		{
			return new Offset<IRogueReceiveReward>(builder.EndTable());
		}

		// Token: 0x06035312 RID: 217874 RVA: 0x00723CD4 File Offset: 0x00721ED4
		public IRogueReceiveRewardT UnPack()
		{
			IRogueReceiveRewardT rogueReceiveRewardT = new IRogueReceiveRewardT();
			this.UnPackTo(rogueReceiveRewardT);
			return rogueReceiveRewardT;
		}

		// Token: 0x06035313 RID: 217875 RVA: 0x00723CEF File Offset: 0x00721EEF
		public void UnPackTo(IRogueReceiveRewardT _o)
		{
			_o.RogueRewardReceiveType = this.RogueRewardReceiveType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06035314 RID: 217876 RVA: 0x00723D0C File Offset: 0x00721F0C
		public static Offset<IRogueReceiveReward> Pack(FlatBufferBuilder builder, IRogueReceiveRewardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRogueReceiveReward>);
			}
			return IRogueReceiveReward.CreateIRogueReceiveReward(builder, _o.RogueRewardReceiveType, _o.NullMask);
		}

		// Token: 0x04012862 RID: 75874
		private Table __p;
	}
}
