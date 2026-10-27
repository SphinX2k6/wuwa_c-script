using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064A1 RID: 25761
	public struct ICommonTipMissionComplete : IFlatbufferObject
	{
		// Token: 0x1700BFB2 RID: 49074
		// (get) Token: 0x0602CA5C RID: 182876 RVA: 0x00621286 File Offset: 0x0061F486
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CA5D RID: 182877 RVA: 0x00621293 File Offset: 0x0061F493
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CA5E RID: 182878 RVA: 0x0062129C File Offset: 0x0061F49C
		public static ICommonTipMissionComplete GetRootAsICommonTipMissionComplete(ByteBuffer _bb)
		{
			return ICommonTipMissionComplete.GetRootAsICommonTipMissionComplete(_bb, default(ICommonTipMissionComplete));
		}

		// Token: 0x0602CA5F RID: 182879 RVA: 0x006212B8 File Offset: 0x0061F4B8
		public static ICommonTipMissionComplete GetRootAsICommonTipMissionComplete(ByteBuffer _bb, ICommonTipMissionComplete obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CA60 RID: 182880 RVA: 0x006212D5 File Offset: 0x0061F4D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CA61 RID: 182881 RVA: 0x006212E4 File Offset: 0x0061F4E4
		public ICommonTipMissionComplete __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BFB3 RID: 49075
		// (get) Token: 0x0602CA62 RID: 182882 RVA: 0x006212F4 File Offset: 0x0061F4F4
		public ECommonTipType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return (ECommonTipType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BFB4 RID: 49076
		// (get) Token: 0x0602CA63 RID: 182883 RVA: 0x00621330 File Offset: 0x0061F530
		public string TidMainText
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CA64 RID: 182884 RVA: 0x00621367 File Offset: 0x0061F567
		public Span<byte> GetTidMainTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602CA65 RID: 182885 RVA: 0x00621376 File Offset: 0x0061F576
		public byte[] GetTidMainTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700BFB5 RID: 49077
		// (get) Token: 0x0602CA66 RID: 182886 RVA: 0x00621384 File Offset: 0x0061F584
		public string TidSubText
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CA67 RID: 182887 RVA: 0x006213BB File Offset: 0x0061F5BB
		public Span<byte> GetTidSubTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602CA68 RID: 182888 RVA: 0x006213CA File Offset: 0x0061F5CA
		public byte[] GetTidSubTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0602CA69 RID: 182889 RVA: 0x006213D8 File Offset: 0x0061F5D8
		public static Offset<ICommonTipMissionComplete> CreateICommonTipMissionComplete(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset TidMainTextOffset = default(StringOffset), StringOffset TidSubTextOffset = default(StringOffset))
		{
			builder.StartTable(3);
			ICommonTipMissionComplete.AddTidSubText(builder, TidSubTextOffset);
			ICommonTipMissionComplete.AddTidMainText(builder, TidMainTextOffset);
			ICommonTipMissionComplete.AddType(builder, Type);
			return ICommonTipMissionComplete.EndICommonTipMissionComplete(builder);
		}

		// Token: 0x0602CA6A RID: 182890 RVA: 0x006213FC File Offset: 0x0061F5FC
		public static void StartICommonTipMissionComplete(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602CA6B RID: 182891 RVA: 0x00621405 File Offset: 0x0061F605
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CA6C RID: 182892 RVA: 0x00621410 File Offset: 0x0061F610
		public static void AddTidMainText(FlatBufferBuilder builder, StringOffset tidMainTextOffset)
		{
			builder.AddOffset(1, tidMainTextOffset.Value, 0);
		}

		// Token: 0x0602CA6D RID: 182893 RVA: 0x00621420 File Offset: 0x0061F620
		public static void AddTidSubText(FlatBufferBuilder builder, StringOffset tidSubTextOffset)
		{
			builder.AddOffset(2, tidSubTextOffset.Value, 0);
		}

		// Token: 0x0602CA6E RID: 182894 RVA: 0x00621430 File Offset: 0x0061F630
		public static Offset<ICommonTipMissionComplete> EndICommonTipMissionComplete(FlatBufferBuilder builder)
		{
			return new Offset<ICommonTipMissionComplete>(builder.EndTable());
		}

		// Token: 0x0602CA6F RID: 182895 RVA: 0x00621440 File Offset: 0x0061F640
		public ICommonTipMissionCompleteT UnPack()
		{
			ICommonTipMissionCompleteT commonTipMissionCompleteT = new ICommonTipMissionCompleteT();
			this.UnPackTo(commonTipMissionCompleteT);
			return commonTipMissionCompleteT;
		}

		// Token: 0x0602CA70 RID: 182896 RVA: 0x0062145B File Offset: 0x0061F65B
		public void UnPackTo(ICommonTipMissionCompleteT _o)
		{
			_o.Type = this.Type;
			_o.TidMainText = this.TidMainText;
			_o.TidSubText = this.TidSubText;
		}

		// Token: 0x0602CA71 RID: 182897 RVA: 0x00621484 File Offset: 0x0061F684
		public static Offset<ICommonTipMissionComplete> Pack(FlatBufferBuilder builder, ICommonTipMissionCompleteT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonTipMissionComplete>);
			}
			StringOffset tidMainTextOffset = (_o.TidMainText == null) ? default(StringOffset) : builder.CreateString(_o.TidMainText);
			StringOffset tidSubTextOffset = (_o.TidSubText == null) ? default(StringOffset) : builder.CreateString(_o.TidSubText);
			return ICommonTipMissionComplete.CreateICommonTipMissionComplete(builder, _o.Type, tidMainTextOffset, tidSubTextOffset);
		}

		// Token: 0x04010AAE RID: 68270
		private Table __p;
	}
}
