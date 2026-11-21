using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041ED RID: 16877
	public struct IDarkTideHaiweixiaArenaBossEvent : IFlatbufferObject
	{
		// Token: 0x170072F5 RID: 29429
		// (get) Token: 0x060176BE RID: 95934 RVA: 0x00358DA1 File Offset: 0x00356FA1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060176BF RID: 95935 RVA: 0x00358DAE File Offset: 0x00356FAE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060176C0 RID: 95936 RVA: 0x00358DB8 File Offset: 0x00356FB8
		public static IDarkTideHaiweixiaArenaBossEvent GetRootAsIDarkTideHaiweixiaArenaBossEvent(ByteBuffer _bb)
		{
			return IDarkTideHaiweixiaArenaBossEvent.GetRootAsIDarkTideHaiweixiaArenaBossEvent(_bb, default(IDarkTideHaiweixiaArenaBossEvent));
		}

		// Token: 0x060176C1 RID: 95937 RVA: 0x00358DD4 File Offset: 0x00356FD4
		public static IDarkTideHaiweixiaArenaBossEvent GetRootAsIDarkTideHaiweixiaArenaBossEvent(ByteBuffer _bb, IDarkTideHaiweixiaArenaBossEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060176C2 RID: 95938 RVA: 0x00358DF1 File Offset: 0x00356FF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060176C3 RID: 95939 RVA: 0x00358E00 File Offset: 0x00357000
		public IDarkTideHaiweixiaArenaBossEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170072F6 RID: 29430
		// (get) Token: 0x060176C4 RID: 95940 RVA: 0x00358E10 File Offset: 0x00357010
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

		// Token: 0x060176C5 RID: 95941 RVA: 0x00358E4C File Offset: 0x0035704C
		public static Offset<IDarkTideHaiweixiaArenaBossEvent> CreateIDarkTideHaiweixiaArenaBossEvent(FlatBufferBuilder builder, EDarkTideBossEventType Type = EDarkTideBossEventType.XinjilemuChase)
		{
			builder.StartTable(1);
			IDarkTideHaiweixiaArenaBossEvent.AddType(builder, Type);
			return IDarkTideHaiweixiaArenaBossEvent.EndIDarkTideHaiweixiaArenaBossEvent(builder);
		}

		// Token: 0x060176C6 RID: 95942 RVA: 0x00358E62 File Offset: 0x00357062
		public static void StartIDarkTideHaiweixiaArenaBossEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060176C7 RID: 95943 RVA: 0x00358E6B File Offset: 0x0035706B
		public static void AddType(FlatBufferBuilder builder, EDarkTideBossEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060176C8 RID: 95944 RVA: 0x00358E76 File Offset: 0x00357076
		public static Offset<IDarkTideHaiweixiaArenaBossEvent> EndIDarkTideHaiweixiaArenaBossEvent(FlatBufferBuilder builder)
		{
			return new Offset<IDarkTideHaiweixiaArenaBossEvent>(builder.EndTable());
		}

		// Token: 0x060176C9 RID: 95945 RVA: 0x00358E84 File Offset: 0x00357084
		public IDarkTideHaiweixiaArenaBossEventT UnPack()
		{
			IDarkTideHaiweixiaArenaBossEventT darkTideHaiweixiaArenaBossEventT = new IDarkTideHaiweixiaArenaBossEventT();
			this.UnPackTo(darkTideHaiweixiaArenaBossEventT);
			return darkTideHaiweixiaArenaBossEventT;
		}

		// Token: 0x060176CA RID: 95946 RVA: 0x00358E9F File Offset: 0x0035709F
		public void UnPackTo(IDarkTideHaiweixiaArenaBossEventT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060176CB RID: 95947 RVA: 0x00358EB0 File Offset: 0x003570B0
		public static Offset<IDarkTideHaiweixiaArenaBossEvent> Pack(FlatBufferBuilder builder, IDarkTideHaiweixiaArenaBossEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDarkTideHaiweixiaArenaBossEvent>);
			}
			return IDarkTideHaiweixiaArenaBossEvent.CreateIDarkTideHaiweixiaArenaBossEvent(builder, _o.Type);
		}

		// Token: 0x0400C0C9 RID: 49353
		private Table __p;
	}
}
