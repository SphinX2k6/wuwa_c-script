using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004004 RID: 16388
	public struct IQuestPlayerHitStatisticsType : IFlatbufferObject
	{
		// Token: 0x1700732C RID: 29484
		// (get) Token: 0x06017A62 RID: 96866 RVA: 0x0036966C File Offset: 0x0036786C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017A63 RID: 96867 RVA: 0x00369679 File Offset: 0x00367879
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017A64 RID: 96868 RVA: 0x00369680 File Offset: 0x00367880
		public static IQuestPlayerHitStatisticsType GetRootAsIQuestPlayerHitStatisticsType(ByteBuffer _bb)
		{
			return IQuestPlayerHitStatisticsType.GetRootAsIQuestPlayerHitStatisticsType(_bb, default(IQuestPlayerHitStatisticsType));
		}

		// Token: 0x06017A65 RID: 96869 RVA: 0x0036969C File Offset: 0x0036789C
		public static IQuestPlayerHitStatisticsType GetRootAsIQuestPlayerHitStatisticsType(ByteBuffer _bb, IQuestPlayerHitStatisticsType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017A66 RID: 96870 RVA: 0x003696B9 File Offset: 0x003678B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017A67 RID: 96871 RVA: 0x003696C8 File Offset: 0x003678C8
		public IQuestPlayerHitStatisticsType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700732D RID: 29485
		// (get) Token: 0x06017A68 RID: 96872 RVA: 0x003696D8 File Offset: 0x003678D8
		public EPlayerHitStatisticsType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPlayerHitStatisticsType.HitCount;
				}
				return (EPlayerHitStatisticsType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017A69 RID: 96873 RVA: 0x00369714 File Offset: 0x00367914
		public static Offset<IQuestPlayerHitStatisticsType> CreateIQuestPlayerHitStatisticsType(FlatBufferBuilder builder, EPlayerHitStatisticsType Type = EPlayerHitStatisticsType.HitCount)
		{
			builder.StartTable(1);
			IQuestPlayerHitStatisticsType.AddType(builder, Type);
			return IQuestPlayerHitStatisticsType.EndIQuestPlayerHitStatisticsType(builder);
		}

		// Token: 0x06017A6A RID: 96874 RVA: 0x0036972A File Offset: 0x0036792A
		public static void StartIQuestPlayerHitStatisticsType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06017A6B RID: 96875 RVA: 0x00369733 File Offset: 0x00367933
		public static void AddType(FlatBufferBuilder builder, EPlayerHitStatisticsType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017A6C RID: 96876 RVA: 0x0036973E File Offset: 0x0036793E
		public static Offset<IQuestPlayerHitStatisticsType> EndIQuestPlayerHitStatisticsType(FlatBufferBuilder builder)
		{
			return new Offset<IQuestPlayerHitStatisticsType>(builder.EndTable());
		}

		// Token: 0x06017A6D RID: 96877 RVA: 0x0036974C File Offset: 0x0036794C
		public IQuestPlayerHitStatisticsTypeT UnPack()
		{
			IQuestPlayerHitStatisticsTypeT questPlayerHitStatisticsTypeT = new IQuestPlayerHitStatisticsTypeT();
			this.UnPackTo(questPlayerHitStatisticsTypeT);
			return questPlayerHitStatisticsTypeT;
		}

		// Token: 0x06017A6E RID: 96878 RVA: 0x00369767 File Offset: 0x00367967
		public void UnPackTo(IQuestPlayerHitStatisticsTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06017A6F RID: 96879 RVA: 0x00369778 File Offset: 0x00367978
		public static Offset<IQuestPlayerHitStatisticsType> Pack(FlatBufferBuilder builder, IQuestPlayerHitStatisticsTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestPlayerHitStatisticsType>);
			}
			return IQuestPlayerHitStatisticsType.CreateIQuestPlayerHitStatisticsType(builder, _o.Type);
		}

		// Token: 0x0400BB1B RID: 47899
		private Table __p;
	}
}
