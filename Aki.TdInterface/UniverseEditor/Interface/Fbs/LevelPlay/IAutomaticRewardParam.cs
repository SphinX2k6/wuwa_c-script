using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200489C RID: 18588
	public struct IAutomaticRewardParam : IFlatbufferObject
	{
		// Token: 0x17008141 RID: 33089
		// (get) Token: 0x0601B753 RID: 112467 RVA: 0x003E2CB4 File Offset: 0x003E0EB4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B754 RID: 112468 RVA: 0x003E2CC1 File Offset: 0x003E0EC1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B755 RID: 112469 RVA: 0x003E2CC8 File Offset: 0x003E0EC8
		public static IAutomaticRewardParam GetRootAsIAutomaticRewardParam(ByteBuffer _bb)
		{
			return IAutomaticRewardParam.GetRootAsIAutomaticRewardParam(_bb, default(IAutomaticRewardParam));
		}

		// Token: 0x0601B756 RID: 112470 RVA: 0x003E2CE4 File Offset: 0x003E0EE4
		public static IAutomaticRewardParam GetRootAsIAutomaticRewardParam(ByteBuffer _bb, IAutomaticRewardParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B757 RID: 112471 RVA: 0x003E2D01 File Offset: 0x003E0F01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B758 RID: 112472 RVA: 0x003E2D10 File Offset: 0x003E0F10
		public IAutomaticRewardParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008142 RID: 33090
		// (get) Token: 0x0601B759 RID: 112473 RVA: 0x003E2D20 File Offset: 0x003E0F20
		public ELevelPlayRewardType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELevelPlayRewardType.None;
				}
				return (ELevelPlayRewardType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008143 RID: 33091
		// (get) Token: 0x0601B75A RID: 112474 RVA: 0x003E2D5C File Offset: 0x003E0F5C
		public int RewardId
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

		// Token: 0x17008144 RID: 33092
		// (get) Token: 0x0601B75B RID: 112475 RVA: 0x003E2D98 File Offset: 0x003E0F98
		public int FirstRewardId
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

		// Token: 0x17008145 RID: 33093
		// (get) Token: 0x0601B75C RID: 112476 RVA: 0x003E2DD4 File Offset: 0x003E0FD4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B75D RID: 112477 RVA: 0x003E2E11 File Offset: 0x003E1011
		public static Offset<IAutomaticRewardParam> CreateIAutomaticRewardParam(FlatBufferBuilder builder, ELevelPlayRewardType Type = ELevelPlayRewardType.None, int RewardId = 0, int FirstRewardId = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IAutomaticRewardParam.AddFirstRewardId(builder, FirstRewardId);
			IAutomaticRewardParam.AddRewardId(builder, RewardId);
			IAutomaticRewardParam.AddNullMask(builder, NullMask);
			IAutomaticRewardParam.AddType(builder, Type);
			return IAutomaticRewardParam.EndIAutomaticRewardParam(builder);
		}

		// Token: 0x0601B75E RID: 112478 RVA: 0x003E2E3D File Offset: 0x003E103D
		public static void StartIAutomaticRewardParam(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601B75F RID: 112479 RVA: 0x003E2E46 File Offset: 0x003E1046
		public static void AddType(FlatBufferBuilder builder, ELevelPlayRewardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B760 RID: 112480 RVA: 0x003E2E51 File Offset: 0x003E1051
		public static void AddRewardId(FlatBufferBuilder builder, int rewardId)
		{
			builder.AddInt(1, rewardId, 0);
		}

		// Token: 0x0601B761 RID: 112481 RVA: 0x003E2E5C File Offset: 0x003E105C
		public static void AddFirstRewardId(FlatBufferBuilder builder, int firstRewardId)
		{
			builder.AddInt(2, firstRewardId, 0);
		}

		// Token: 0x0601B762 RID: 112482 RVA: 0x003E2E67 File Offset: 0x003E1067
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601B763 RID: 112483 RVA: 0x003E2E72 File Offset: 0x003E1072
		public static Offset<IAutomaticRewardParam> EndIAutomaticRewardParam(FlatBufferBuilder builder)
		{
			return new Offset<IAutomaticRewardParam>(builder.EndTable());
		}

		// Token: 0x0601B764 RID: 112484 RVA: 0x003E2E80 File Offset: 0x003E1080
		public IAutomaticRewardParamT UnPack()
		{
			IAutomaticRewardParamT automaticRewardParamT = new IAutomaticRewardParamT();
			this.UnPackTo(automaticRewardParamT);
			return automaticRewardParamT;
		}

		// Token: 0x0601B765 RID: 112485 RVA: 0x003E2E9B File Offset: 0x003E109B
		public void UnPackTo(IAutomaticRewardParamT _o)
		{
			_o.Type = this.Type;
			_o.RewardId = this.RewardId;
			_o.FirstRewardId = this.FirstRewardId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601B766 RID: 112486 RVA: 0x003E2ED0 File Offset: 0x003E10D0
		public static Offset<IAutomaticRewardParam> Pack(FlatBufferBuilder builder, IAutomaticRewardParamT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAutomaticRewardParam>);
			}
			return IAutomaticRewardParam.CreateIAutomaticRewardParam(builder, _o.Type, _o.RewardId, _o.FirstRewardId, _o.NullMask);
		}

		// Token: 0x0400CE2E RID: 52782
		private Table __p;
	}
}
