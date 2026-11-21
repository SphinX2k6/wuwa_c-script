using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041C0 RID: 16832
	public struct ICompleteMessageQuestCondition : IFlatbufferObject
	{
		// Token: 0x17007255 RID: 29269
		// (get) Token: 0x06017464 RID: 95332 RVA: 0x00352A6C File Offset: 0x00350C6C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017465 RID: 95333 RVA: 0x00352A79 File Offset: 0x00350C79
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017466 RID: 95334 RVA: 0x00352A80 File Offset: 0x00350C80
		public static ICompleteMessageQuestCondition GetRootAsICompleteMessageQuestCondition(ByteBuffer _bb)
		{
			return ICompleteMessageQuestCondition.GetRootAsICompleteMessageQuestCondition(_bb, default(ICompleteMessageQuestCondition));
		}

		// Token: 0x06017467 RID: 95335 RVA: 0x00352A9C File Offset: 0x00350C9C
		public static ICompleteMessageQuestCondition GetRootAsICompleteMessageQuestCondition(ByteBuffer _bb, ICompleteMessageQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017468 RID: 95336 RVA: 0x00352AB9 File Offset: 0x00350CB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017469 RID: 95337 RVA: 0x00352AC8 File Offset: 0x00350CC8
		public ICompleteMessageQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007256 RID: 29270
		// (get) Token: 0x0601746A RID: 95338 RVA: 0x00352AD8 File Offset: 0x00350CD8
		public EPhoneMessageProgressType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPhoneMessageProgressType.CompleteMessage;
				}
				return (EPhoneMessageProgressType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601746B RID: 95339 RVA: 0x00352B14 File Offset: 0x00350D14
		public static Offset<ICompleteMessageQuestCondition> CreateICompleteMessageQuestCondition(FlatBufferBuilder builder, EPhoneMessageProgressType Type = EPhoneMessageProgressType.CompleteMessage)
		{
			builder.StartTable(1);
			ICompleteMessageQuestCondition.AddType(builder, Type);
			return ICompleteMessageQuestCondition.EndICompleteMessageQuestCondition(builder);
		}

		// Token: 0x0601746C RID: 95340 RVA: 0x00352B2A File Offset: 0x00350D2A
		public static void StartICompleteMessageQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601746D RID: 95341 RVA: 0x00352B33 File Offset: 0x00350D33
		public static void AddType(FlatBufferBuilder builder, EPhoneMessageProgressType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601746E RID: 95342 RVA: 0x00352B3E File Offset: 0x00350D3E
		public static Offset<ICompleteMessageQuestCondition> EndICompleteMessageQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICompleteMessageQuestCondition>(builder.EndTable());
		}

		// Token: 0x0601746F RID: 95343 RVA: 0x00352B4C File Offset: 0x00350D4C
		public ICompleteMessageQuestConditionT UnPack()
		{
			ICompleteMessageQuestConditionT completeMessageQuestConditionT = new ICompleteMessageQuestConditionT();
			this.UnPackTo(completeMessageQuestConditionT);
			return completeMessageQuestConditionT;
		}

		// Token: 0x06017470 RID: 95344 RVA: 0x00352B67 File Offset: 0x00350D67
		public void UnPackTo(ICompleteMessageQuestConditionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06017471 RID: 95345 RVA: 0x00352B78 File Offset: 0x00350D78
		public static Offset<ICompleteMessageQuestCondition> Pack(FlatBufferBuilder builder, ICompleteMessageQuestConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompleteMessageQuestCondition>);
			}
			return ICompleteMessageQuestCondition.CreateICompleteMessageQuestCondition(builder, _o.Type);
		}

		// Token: 0x0400C068 RID: 49256
		private Table __p;
	}
}
