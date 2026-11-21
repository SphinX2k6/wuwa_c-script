using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041F0 RID: 16880
	public struct IDarkTideHecatePollutionBossEvent : IFlatbufferObject
	{
		// Token: 0x170072F8 RID: 29432
		// (get) Token: 0x060176D0 RID: 95952 RVA: 0x00358F19 File Offset: 0x00357119
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060176D1 RID: 95953 RVA: 0x00358F26 File Offset: 0x00357126
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060176D2 RID: 95954 RVA: 0x00358F30 File Offset: 0x00357130
		public static IDarkTideHecatePollutionBossEvent GetRootAsIDarkTideHecatePollutionBossEvent(ByteBuffer _bb)
		{
			return IDarkTideHecatePollutionBossEvent.GetRootAsIDarkTideHecatePollutionBossEvent(_bb, default(IDarkTideHecatePollutionBossEvent));
		}

		// Token: 0x060176D3 RID: 95955 RVA: 0x00358F4C File Offset: 0x0035714C
		public static IDarkTideHecatePollutionBossEvent GetRootAsIDarkTideHecatePollutionBossEvent(ByteBuffer _bb, IDarkTideHecatePollutionBossEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060176D4 RID: 95956 RVA: 0x00358F69 File Offset: 0x00357169
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060176D5 RID: 95957 RVA: 0x00358F78 File Offset: 0x00357178
		public IDarkTideHecatePollutionBossEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170072F9 RID: 29433
		// (get) Token: 0x060176D6 RID: 95958 RVA: 0x00358F88 File Offset: 0x00357188
		public EDarkTideBossEventType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDarkTideBossEventType.XinjilemuChase;
				}
				return (EDarkTideBossEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060176D7 RID: 95959 RVA: 0x00358FC4 File Offset: 0x003571C4
		public static Offset<IDarkTideHecatePollutionBossEvent> CreateIDarkTideHecatePollutionBossEvent(FlatBufferBuilder builder, EDarkTideBossEventType Type = EDarkTideBossEventType.XinjilemuChase)
		{
			builder.StartTable(1);
			IDarkTideHecatePollutionBossEvent.AddType(builder, Type);
			return IDarkTideHecatePollutionBossEvent.EndIDarkTideHecatePollutionBossEvent(builder);
		}

		// Token: 0x060176D8 RID: 95960 RVA: 0x00358FDA File Offset: 0x003571DA
		public static void StartIDarkTideHecatePollutionBossEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060176D9 RID: 95961 RVA: 0x00358FE3 File Offset: 0x003571E3
		public static void AddType(FlatBufferBuilder builder, EDarkTideBossEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060176DA RID: 95962 RVA: 0x00358FEE File Offset: 0x003571EE
		public static Offset<IDarkTideHecatePollutionBossEvent> EndIDarkTideHecatePollutionBossEvent(FlatBufferBuilder builder)
		{
			return new Offset<IDarkTideHecatePollutionBossEvent>(builder.EndTable());
		}

		// Token: 0x060176DB RID: 95963 RVA: 0x00358FFC File Offset: 0x003571FC
		public IDarkTideHecatePollutionBossEventT UnPack()
		{
			IDarkTideHecatePollutionBossEventT darkTideHecatePollutionBossEventT = new IDarkTideHecatePollutionBossEventT();
			this.UnPackTo(darkTideHecatePollutionBossEventT);
			return darkTideHecatePollutionBossEventT;
		}

		// Token: 0x060176DC RID: 95964 RVA: 0x00359017 File Offset: 0x00357217
		public void UnPackTo(IDarkTideHecatePollutionBossEventT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060176DD RID: 95965 RVA: 0x00359028 File Offset: 0x00357228
		public static Offset<IDarkTideHecatePollutionBossEvent> Pack(FlatBufferBuilder builder, IDarkTideHecatePollutionBossEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDarkTideHecatePollutionBossEvent>);
			}
			return IDarkTideHecatePollutionBossEvent.CreateIDarkTideHecatePollutionBossEvent(builder, _o.Type);
		}

		// Token: 0x0400C0CB RID: 49355
		private Table __p;
	}
}
