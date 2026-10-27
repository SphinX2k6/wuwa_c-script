using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200590B RID: 22795
	public struct IShowcaseDeliveryReward : IFlatbufferObject
	{
		// Token: 0x1700AADD RID: 43741
		// (get) Token: 0x06026860 RID: 157792 RVA: 0x0054EA68 File Offset: 0x0054CC68
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026861 RID: 157793 RVA: 0x0054EA75 File Offset: 0x0054CC75
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026862 RID: 157794 RVA: 0x0054EA7C File Offset: 0x0054CC7C
		public static IShowcaseDeliveryReward GetRootAsIShowcaseDeliveryReward(ByteBuffer _bb)
		{
			return IShowcaseDeliveryReward.GetRootAsIShowcaseDeliveryReward(_bb, default(IShowcaseDeliveryReward));
		}

		// Token: 0x06026863 RID: 157795 RVA: 0x0054EA98 File Offset: 0x0054CC98
		public static IShowcaseDeliveryReward GetRootAsIShowcaseDeliveryReward(ByteBuffer _bb, IShowcaseDeliveryReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026864 RID: 157796 RVA: 0x0054EAB5 File Offset: 0x0054CCB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026865 RID: 157797 RVA: 0x0054EAC4 File Offset: 0x0054CCC4
		public IShowcaseDeliveryReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AADE RID: 43742
		// (get) Token: 0x06026866 RID: 157798 RVA: 0x0054EAD4 File Offset: 0x0054CCD4
		public int AchievedDollCount
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AADF RID: 43743
		// (get) Token: 0x06026867 RID: 157799 RVA: 0x0054EB10 File Offset: 0x0054CD10
		public int DropId
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

		// Token: 0x06026868 RID: 157800 RVA: 0x0054EB4C File Offset: 0x0054CD4C
		public static Offset<IShowcaseDeliveryReward> CreateIShowcaseDeliveryReward(FlatBufferBuilder builder, int AchievedDollCount = 0, int DropId = 0)
		{
			builder.StartTable(2);
			IShowcaseDeliveryReward.AddDropId(builder, DropId);
			IShowcaseDeliveryReward.AddAchievedDollCount(builder, AchievedDollCount);
			return IShowcaseDeliveryReward.EndIShowcaseDeliveryReward(builder);
		}

		// Token: 0x06026869 RID: 157801 RVA: 0x0054EB69 File Offset: 0x0054CD69
		public static void StartIShowcaseDeliveryReward(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602686A RID: 157802 RVA: 0x0054EB72 File Offset: 0x0054CD72
		public static void AddAchievedDollCount(FlatBufferBuilder builder, int achievedDollCount)
		{
			builder.AddInt(0, achievedDollCount, 0);
		}

		// Token: 0x0602686B RID: 157803 RVA: 0x0054EB7D File Offset: 0x0054CD7D
		public static void AddDropId(FlatBufferBuilder builder, int dropId)
		{
			builder.AddInt(1, dropId, 0);
		}

		// Token: 0x0602686C RID: 157804 RVA: 0x0054EB88 File Offset: 0x0054CD88
		public static Offset<IShowcaseDeliveryReward> EndIShowcaseDeliveryReward(FlatBufferBuilder builder)
		{
			return new Offset<IShowcaseDeliveryReward>(builder.EndTable());
		}

		// Token: 0x0602686D RID: 157805 RVA: 0x0054EB98 File Offset: 0x0054CD98
		public IShowcaseDeliveryRewardT UnPack()
		{
			IShowcaseDeliveryRewardT showcaseDeliveryRewardT = new IShowcaseDeliveryRewardT();
			this.UnPackTo(showcaseDeliveryRewardT);
			return showcaseDeliveryRewardT;
		}

		// Token: 0x0602686E RID: 157806 RVA: 0x0054EBB3 File Offset: 0x0054CDB3
		public void UnPackTo(IShowcaseDeliveryRewardT _o)
		{
			_o.AchievedDollCount = this.AchievedDollCount;
			_o.DropId = this.DropId;
		}

		// Token: 0x0602686F RID: 157807 RVA: 0x0054EBD0 File Offset: 0x0054CDD0
		public static Offset<IShowcaseDeliveryReward> Pack(FlatBufferBuilder builder, IShowcaseDeliveryRewardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowcaseDeliveryReward>);
			}
			return IShowcaseDeliveryReward.CreateIShowcaseDeliveryReward(builder, _o.AchievedDollCount, _o.DropId);
		}

		// Token: 0x0400EEAD RID: 61101
		private Table __p;
	}
}
