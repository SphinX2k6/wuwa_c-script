using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FFB RID: 16379
	public struct IQuestPlayerBeDamage : IFlatbufferObject
	{
		// Token: 0x17007315 RID: 29461
		// (get) Token: 0x060179F5 RID: 96757 RVA: 0x003687BC File Offset: 0x003669BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060179F6 RID: 96758 RVA: 0x003687C9 File Offset: 0x003669C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060179F7 RID: 96759 RVA: 0x003687D0 File Offset: 0x003669D0
		public static IQuestPlayerBeDamage GetRootAsIQuestPlayerBeDamage(ByteBuffer _bb)
		{
			return IQuestPlayerBeDamage.GetRootAsIQuestPlayerBeDamage(_bb, default(IQuestPlayerBeDamage));
		}

		// Token: 0x060179F8 RID: 96760 RVA: 0x003687EC File Offset: 0x003669EC
		public static IQuestPlayerBeDamage GetRootAsIQuestPlayerBeDamage(ByteBuffer _bb, IQuestPlayerBeDamage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060179F9 RID: 96761 RVA: 0x00368809 File Offset: 0x00366A09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060179FA RID: 96762 RVA: 0x00368818 File Offset: 0x00366A18
		public IQuestPlayerBeDamage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007316 RID: 29462
		// (get) Token: 0x060179FB RID: 96763 RVA: 0x00368828 File Offset: 0x00366A28
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

		// Token: 0x17007317 RID: 29463
		// (get) Token: 0x060179FC RID: 96764 RVA: 0x00368864 File Offset: 0x00366A64
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

		// Token: 0x060179FD RID: 96765 RVA: 0x003688A0 File Offset: 0x00366AA0
		public static Offset<IQuestPlayerBeDamage> CreateIQuestPlayerBeDamage(FlatBufferBuilder builder, EPlayerHitStatisticsType Type = EPlayerHitStatisticsType.HitCount, EPlayerDamageInfoType StatisticsType = EPlayerDamageInfoType.DamagePoint)
		{
			builder.StartTable(2);
			IQuestPlayerBeDamage.AddStatisticsType(builder, StatisticsType);
			IQuestPlayerBeDamage.AddType(builder, Type);
			return IQuestPlayerBeDamage.EndIQuestPlayerBeDamage(builder);
		}

		// Token: 0x060179FE RID: 96766 RVA: 0x003688BD File Offset: 0x00366ABD
		public static void StartIQuestPlayerBeDamage(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060179FF RID: 96767 RVA: 0x003688C6 File Offset: 0x00366AC6
		public static void AddType(FlatBufferBuilder builder, EPlayerHitStatisticsType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017A00 RID: 96768 RVA: 0x003688D1 File Offset: 0x00366AD1
		public static void AddStatisticsType(FlatBufferBuilder builder, EPlayerDamageInfoType statisticsType)
		{
			builder.AddByte(1, (byte)statisticsType, 0);
		}

		// Token: 0x06017A01 RID: 96769 RVA: 0x003688DC File Offset: 0x00366ADC
		public static Offset<IQuestPlayerBeDamage> EndIQuestPlayerBeDamage(FlatBufferBuilder builder)
		{
			return new Offset<IQuestPlayerBeDamage>(builder.EndTable());
		}

		// Token: 0x06017A02 RID: 96770 RVA: 0x003688EC File Offset: 0x00366AEC
		public IQuestPlayerBeDamageT UnPack()
		{
			IQuestPlayerBeDamageT questPlayerBeDamageT = new IQuestPlayerBeDamageT();
			this.UnPackTo(questPlayerBeDamageT);
			return questPlayerBeDamageT;
		}

		// Token: 0x06017A03 RID: 96771 RVA: 0x00368907 File Offset: 0x00366B07
		public void UnPackTo(IQuestPlayerBeDamageT _o)
		{
			_o.Type = this.Type;
			_o.StatisticsType = this.StatisticsType;
		}

		// Token: 0x06017A04 RID: 96772 RVA: 0x00368924 File Offset: 0x00366B24
		public static Offset<IQuestPlayerBeDamage> Pack(FlatBufferBuilder builder, IQuestPlayerBeDamageT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestPlayerBeDamage>);
			}
			return IQuestPlayerBeDamage.CreateIQuestPlayerBeDamage(builder, _o.Type, _o.StatisticsType);
		}

		// Token: 0x0400BB0E RID: 47886
		private Table __p;
	}
}
