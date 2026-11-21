using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200443C RID: 17468
	public struct IQuestPlayerBeDamage : IFlatbufferObject
	{
		// Token: 0x17007917 RID: 30999
		// (get) Token: 0x0601908E RID: 102542 RVA: 0x003925B0 File Offset: 0x003907B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601908F RID: 102543 RVA: 0x003925BD File Offset: 0x003907BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019090 RID: 102544 RVA: 0x003925C4 File Offset: 0x003907C4
		public static IQuestPlayerBeDamage GetRootAsIQuestPlayerBeDamage(ByteBuffer _bb)
		{
			return IQuestPlayerBeDamage.GetRootAsIQuestPlayerBeDamage(_bb, default(IQuestPlayerBeDamage));
		}

		// Token: 0x06019091 RID: 102545 RVA: 0x003925E0 File Offset: 0x003907E0
		public static IQuestPlayerBeDamage GetRootAsIQuestPlayerBeDamage(ByteBuffer _bb, IQuestPlayerBeDamage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019092 RID: 102546 RVA: 0x003925FD File Offset: 0x003907FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019093 RID: 102547 RVA: 0x0039260C File Offset: 0x0039080C
		public IQuestPlayerBeDamage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007918 RID: 31000
		// (get) Token: 0x06019094 RID: 102548 RVA: 0x0039261C File Offset: 0x0039081C
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

		// Token: 0x17007919 RID: 31001
		// (get) Token: 0x06019095 RID: 102549 RVA: 0x00392658 File Offset: 0x00390858
		public EPlayerDamageInfoType StatisticsType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EPlayerDamageInfoType.DamagePoint;
				}
				return (EPlayerDamageInfoType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019096 RID: 102550 RVA: 0x00392694 File Offset: 0x00390894
		public static Offset<IQuestPlayerBeDamage> CreateIQuestPlayerBeDamage(FlatBufferBuilder builder, EPlayerHitStatisticsType Type = EPlayerHitStatisticsType.HitCount, EPlayerDamageInfoType StatisticsType = EPlayerDamageInfoType.DamagePoint)
		{
			builder.StartTable(2);
			IQuestPlayerBeDamage.AddStatisticsType(builder, StatisticsType);
			IQuestPlayerBeDamage.AddType(builder, Type);
			return IQuestPlayerBeDamage.EndIQuestPlayerBeDamage(builder);
		}

		// Token: 0x06019097 RID: 102551 RVA: 0x003926B1 File Offset: 0x003908B1
		public static void StartIQuestPlayerBeDamage(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06019098 RID: 102552 RVA: 0x003926BA File Offset: 0x003908BA
		public static void AddType(FlatBufferBuilder builder, EPlayerHitStatisticsType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019099 RID: 102553 RVA: 0x003926C5 File Offset: 0x003908C5
		public static void AddStatisticsType(FlatBufferBuilder builder, EPlayerDamageInfoType statisticsType)
		{
			builder.AddByte(1, (byte)statisticsType, 0);
		}

		// Token: 0x0601909A RID: 102554 RVA: 0x003926D0 File Offset: 0x003908D0
		public static Offset<IQuestPlayerBeDamage> EndIQuestPlayerBeDamage(FlatBufferBuilder builder)
		{
			return new Offset<IQuestPlayerBeDamage>(builder.EndTable());
		}

		// Token: 0x0601909B RID: 102555 RVA: 0x003926E0 File Offset: 0x003908E0
		public IQuestPlayerBeDamageT UnPack()
		{
			IQuestPlayerBeDamageT questPlayerBeDamageT = new IQuestPlayerBeDamageT();
			this.UnPackTo(questPlayerBeDamageT);
			return questPlayerBeDamageT;
		}

		// Token: 0x0601909C RID: 102556 RVA: 0x003926FB File Offset: 0x003908FB
		public void UnPackTo(IQuestPlayerBeDamageT _o)
		{
			_o.Type = this.Type;
			_o.StatisticsType = this.StatisticsType;
		}

		// Token: 0x0601909D RID: 102557 RVA: 0x00392718 File Offset: 0x00390918
		public static Offset<IQuestPlayerBeDamage> Pack(FlatBufferBuilder builder, IQuestPlayerBeDamageT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestPlayerBeDamage>);
			}
			return IQuestPlayerBeDamage.CreateIQuestPlayerBeDamage(builder, _o.Type, _o.StatisticsType);
		}

		// Token: 0x0400C4F5 RID: 50421
		private Table __p;
	}
}
