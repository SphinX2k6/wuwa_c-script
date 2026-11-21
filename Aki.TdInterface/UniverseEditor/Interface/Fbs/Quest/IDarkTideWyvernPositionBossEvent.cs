using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041FF RID: 16895
	public struct IDarkTideWyvernPositionBossEvent : IFlatbufferObject
	{
		// Token: 0x17007308 RID: 29448
		// (get) Token: 0x06017728 RID: 96040 RVA: 0x0035970C File Offset: 0x0035790C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017729 RID: 96041 RVA: 0x00359719 File Offset: 0x00357919
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601772A RID: 96042 RVA: 0x00359720 File Offset: 0x00357920
		public static IDarkTideWyvernPositionBossEvent GetRootAsIDarkTideWyvernPositionBossEvent(ByteBuffer _bb)
		{
			return IDarkTideWyvernPositionBossEvent.GetRootAsIDarkTideWyvernPositionBossEvent(_bb, default(IDarkTideWyvernPositionBossEvent));
		}

		// Token: 0x0601772B RID: 96043 RVA: 0x0035973C File Offset: 0x0035793C
		public static IDarkTideWyvernPositionBossEvent GetRootAsIDarkTideWyvernPositionBossEvent(ByteBuffer _bb, IDarkTideWyvernPositionBossEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601772C RID: 96044 RVA: 0x00359759 File Offset: 0x00357959
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601772D RID: 96045 RVA: 0x00359768 File Offset: 0x00357968
		public IDarkTideWyvernPositionBossEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007309 RID: 29449
		// (get) Token: 0x0601772E RID: 96046 RVA: 0x00359778 File Offset: 0x00357978
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

		// Token: 0x0601772F RID: 96047 RVA: 0x003597B4 File Offset: 0x003579B4
		public static Offset<IDarkTideWyvernPositionBossEvent> CreateIDarkTideWyvernPositionBossEvent(FlatBufferBuilder builder, EDarkTideBossEventType Type = EDarkTideBossEventType.XinjilemuChase)
		{
			builder.StartTable(1);
			IDarkTideWyvernPositionBossEvent.AddType(builder, Type);
			return IDarkTideWyvernPositionBossEvent.EndIDarkTideWyvernPositionBossEvent(builder);
		}

		// Token: 0x06017730 RID: 96048 RVA: 0x003597CA File Offset: 0x003579CA
		public static void StartIDarkTideWyvernPositionBossEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06017731 RID: 96049 RVA: 0x003597D3 File Offset: 0x003579D3
		public static void AddType(FlatBufferBuilder builder, EDarkTideBossEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017732 RID: 96050 RVA: 0x003597DE File Offset: 0x003579DE
		public static Offset<IDarkTideWyvernPositionBossEvent> EndIDarkTideWyvernPositionBossEvent(FlatBufferBuilder builder)
		{
			return new Offset<IDarkTideWyvernPositionBossEvent>(builder.EndTable());
		}

		// Token: 0x06017733 RID: 96051 RVA: 0x003597EC File Offset: 0x003579EC
		public IDarkTideWyvernPositionBossEventT UnPack()
		{
			IDarkTideWyvernPositionBossEventT darkTideWyvernPositionBossEventT = new IDarkTideWyvernPositionBossEventT();
			this.UnPackTo(darkTideWyvernPositionBossEventT);
			return darkTideWyvernPositionBossEventT;
		}

		// Token: 0x06017734 RID: 96052 RVA: 0x00359807 File Offset: 0x00357A07
		public void UnPackTo(IDarkTideWyvernPositionBossEventT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06017735 RID: 96053 RVA: 0x00359818 File Offset: 0x00357A18
		public static Offset<IDarkTideWyvernPositionBossEvent> Pack(FlatBufferBuilder builder, IDarkTideWyvernPositionBossEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDarkTideWyvernPositionBossEvent>);
			}
			return IDarkTideWyvernPositionBossEvent.CreateIDarkTideWyvernPositionBossEvent(builder, _o.Type);
		}

		// Token: 0x0400C0DA RID: 49370
		private Table __p;
	}
}
