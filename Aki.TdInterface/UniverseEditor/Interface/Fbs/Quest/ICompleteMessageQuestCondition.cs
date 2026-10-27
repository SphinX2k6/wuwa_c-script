using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DA9 RID: 15785
	public struct ICompleteMessageQuestCondition : IFlatbufferObject
	{
		// Token: 0x17006C9B RID: 27803
		// (get) Token: 0x06015F2C RID: 89900 RVA: 0x0032B740 File Offset: 0x00329940
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015F2D RID: 89901 RVA: 0x0032B74D File Offset: 0x0032994D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015F2E RID: 89902 RVA: 0x0032B754 File Offset: 0x00329954
		public static ICompleteMessageQuestCondition GetRootAsICompleteMessageQuestCondition(ByteBuffer _bb)
		{
			return ICompleteMessageQuestCondition.GetRootAsICompleteMessageQuestCondition(_bb, default(ICompleteMessageQuestCondition));
		}

		// Token: 0x06015F2F RID: 89903 RVA: 0x0032B770 File Offset: 0x00329970
		public static ICompleteMessageQuestCondition GetRootAsICompleteMessageQuestCondition(ByteBuffer _bb, ICompleteMessageQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015F30 RID: 89904 RVA: 0x0032B78D File Offset: 0x0032998D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015F31 RID: 89905 RVA: 0x0032B79C File Offset: 0x0032999C
		public ICompleteMessageQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006C9C RID: 27804
		// (get) Token: 0x06015F32 RID: 89906 RVA: 0x0032B7AC File Offset: 0x003299AC
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

		// Token: 0x06015F33 RID: 89907 RVA: 0x0032B7E8 File Offset: 0x003299E8
		public static Offset<ICompleteMessageQuestCondition> CreateICompleteMessageQuestCondition(FlatBufferBuilder builder, EPhoneMessageProgressType Type = EPhoneMessageProgressType.CompleteMessage)
		{
			builder.StartTable(1);
			ICompleteMessageQuestCondition.AddType(builder, Type);
			return ICompleteMessageQuestCondition.EndICompleteMessageQuestCondition(builder);
		}

		// Token: 0x06015F34 RID: 89908 RVA: 0x0032B7FE File Offset: 0x003299FE
		public static void StartICompleteMessageQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06015F35 RID: 89909 RVA: 0x0032B807 File Offset: 0x00329A07
		public static void AddType(FlatBufferBuilder builder, EPhoneMessageProgressType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015F36 RID: 89910 RVA: 0x0032B812 File Offset: 0x00329A12
		public static Offset<ICompleteMessageQuestCondition> EndICompleteMessageQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICompleteMessageQuestCondition>(builder.EndTable());
		}

		// Token: 0x06015F37 RID: 89911 RVA: 0x0032B820 File Offset: 0x00329A20
		public ICompleteMessageQuestConditionT UnPack()
		{
			ICompleteMessageQuestConditionT completeMessageQuestConditionT = new ICompleteMessageQuestConditionT();
			this.UnPackTo(completeMessageQuestConditionT);
			return completeMessageQuestConditionT;
		}

		// Token: 0x06015F38 RID: 89912 RVA: 0x0032B83B File Offset: 0x00329A3B
		public void UnPackTo(ICompleteMessageQuestConditionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06015F39 RID: 89913 RVA: 0x0032B84C File Offset: 0x00329A4C
		public static Offset<ICompleteMessageQuestCondition> Pack(FlatBufferBuilder builder, ICompleteMessageQuestConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompleteMessageQuestCondition>);
			}
			return ICompleteMessageQuestCondition.CreateICompleteMessageQuestCondition(builder, _o.Type);
		}

		// Token: 0x0400B6BB RID: 46779
		private Table __p;
	}
}
