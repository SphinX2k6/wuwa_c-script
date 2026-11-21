using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004445 RID: 17477
	public struct IQuestPlayerHitStatisticsType : IFlatbufferObject
	{
		// Token: 0x1700792E RID: 31022
		// (get) Token: 0x060190FB RID: 102651 RVA: 0x00393460 File Offset: 0x00391660
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060190FC RID: 102652 RVA: 0x0039346D File Offset: 0x0039166D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060190FD RID: 102653 RVA: 0x00393474 File Offset: 0x00391674
		public static IQuestPlayerHitStatisticsType GetRootAsIQuestPlayerHitStatisticsType(ByteBuffer _bb)
		{
			return IQuestPlayerHitStatisticsType.GetRootAsIQuestPlayerHitStatisticsType(_bb, default(IQuestPlayerHitStatisticsType));
		}

		// Token: 0x060190FE RID: 102654 RVA: 0x00393490 File Offset: 0x00391690
		public static IQuestPlayerHitStatisticsType GetRootAsIQuestPlayerHitStatisticsType(ByteBuffer _bb, IQuestPlayerHitStatisticsType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060190FF RID: 102655 RVA: 0x003934AD File Offset: 0x003916AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019100 RID: 102656 RVA: 0x003934BC File Offset: 0x003916BC
		public IQuestPlayerHitStatisticsType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700792F RID: 31023
		// (get) Token: 0x06019101 RID: 102657 RVA: 0x003934CC File Offset: 0x003916CC
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

		// Token: 0x06019102 RID: 102658 RVA: 0x00393508 File Offset: 0x00391708
		public static Offset<IQuestPlayerHitStatisticsType> CreateIQuestPlayerHitStatisticsType(FlatBufferBuilder builder, EPlayerHitStatisticsType Type = EPlayerHitStatisticsType.HitCount)
		{
			builder.StartTable(1);
			IQuestPlayerHitStatisticsType.AddType(builder, Type);
			return IQuestPlayerHitStatisticsType.EndIQuestPlayerHitStatisticsType(builder);
		}

		// Token: 0x06019103 RID: 102659 RVA: 0x0039351E File Offset: 0x0039171E
		public static void StartIQuestPlayerHitStatisticsType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019104 RID: 102660 RVA: 0x00393527 File Offset: 0x00391727
		public static void AddType(FlatBufferBuilder builder, EPlayerHitStatisticsType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019105 RID: 102661 RVA: 0x00393532 File Offset: 0x00391732
		public static Offset<IQuestPlayerHitStatisticsType> EndIQuestPlayerHitStatisticsType(FlatBufferBuilder builder)
		{
			return new Offset<IQuestPlayerHitStatisticsType>(builder.EndTable());
		}

		// Token: 0x06019106 RID: 102662 RVA: 0x00393540 File Offset: 0x00391740
		public IQuestPlayerHitStatisticsTypeT UnPack()
		{
			IQuestPlayerHitStatisticsTypeT questPlayerHitStatisticsTypeT = new IQuestPlayerHitStatisticsTypeT();
			this.UnPackTo(questPlayerHitStatisticsTypeT);
			return questPlayerHitStatisticsTypeT;
		}

		// Token: 0x06019107 RID: 102663 RVA: 0x0039355B File Offset: 0x0039175B
		public void UnPackTo(IQuestPlayerHitStatisticsTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06019108 RID: 102664 RVA: 0x0039356C File Offset: 0x0039176C
		public static Offset<IQuestPlayerHitStatisticsType> Pack(FlatBufferBuilder builder, IQuestPlayerHitStatisticsTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestPlayerHitStatisticsType>);
			}
			return IQuestPlayerHitStatisticsType.CreateIQuestPlayerHitStatisticsType(builder, _o.Type);
		}

		// Token: 0x0400C502 RID: 50434
		private Table __p;
	}
}
