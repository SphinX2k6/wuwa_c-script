using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004202 RID: 16898
	public struct IDarkTideXinjilemuChaseBossEvent : IFlatbufferObject
	{
		// Token: 0x1700730B RID: 29451
		// (get) Token: 0x0601773A RID: 96058 RVA: 0x00359881 File Offset: 0x00357A81
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601773B RID: 96059 RVA: 0x0035988E File Offset: 0x00357A8E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601773C RID: 96060 RVA: 0x00359898 File Offset: 0x00357A98
		public static IDarkTideXinjilemuChaseBossEvent GetRootAsIDarkTideXinjilemuChaseBossEvent(ByteBuffer _bb)
		{
			return IDarkTideXinjilemuChaseBossEvent.GetRootAsIDarkTideXinjilemuChaseBossEvent(_bb, default(IDarkTideXinjilemuChaseBossEvent));
		}

		// Token: 0x0601773D RID: 96061 RVA: 0x003598B4 File Offset: 0x00357AB4
		public static IDarkTideXinjilemuChaseBossEvent GetRootAsIDarkTideXinjilemuChaseBossEvent(ByteBuffer _bb, IDarkTideXinjilemuChaseBossEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601773E RID: 96062 RVA: 0x003598D1 File Offset: 0x00357AD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601773F RID: 96063 RVA: 0x003598E0 File Offset: 0x00357AE0
		public IDarkTideXinjilemuChaseBossEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700730C RID: 29452
		// (get) Token: 0x06017740 RID: 96064 RVA: 0x003598F0 File Offset: 0x00357AF0
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

		// Token: 0x06017741 RID: 96065 RVA: 0x0035992C File Offset: 0x00357B2C
		public static Offset<IDarkTideXinjilemuChaseBossEvent> CreateIDarkTideXinjilemuChaseBossEvent(FlatBufferBuilder builder, EDarkTideBossEventType Type = EDarkTideBossEventType.XinjilemuChase)
		{
			builder.StartTable(1);
			IDarkTideXinjilemuChaseBossEvent.AddType(builder, Type);
			return IDarkTideXinjilemuChaseBossEvent.EndIDarkTideXinjilemuChaseBossEvent(builder);
		}

		// Token: 0x06017742 RID: 96066 RVA: 0x00359942 File Offset: 0x00357B42
		public static void StartIDarkTideXinjilemuChaseBossEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06017743 RID: 96067 RVA: 0x0035994B File Offset: 0x00357B4B
		public static void AddType(FlatBufferBuilder builder, EDarkTideBossEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017744 RID: 96068 RVA: 0x00359956 File Offset: 0x00357B56
		public static Offset<IDarkTideXinjilemuChaseBossEvent> EndIDarkTideXinjilemuChaseBossEvent(FlatBufferBuilder builder)
		{
			return new Offset<IDarkTideXinjilemuChaseBossEvent>(builder.EndTable());
		}

		// Token: 0x06017745 RID: 96069 RVA: 0x00359964 File Offset: 0x00357B64
		public IDarkTideXinjilemuChaseBossEventT UnPack()
		{
			IDarkTideXinjilemuChaseBossEventT darkTideXinjilemuChaseBossEventT = new IDarkTideXinjilemuChaseBossEventT();
			this.UnPackTo(darkTideXinjilemuChaseBossEventT);
			return darkTideXinjilemuChaseBossEventT;
		}

		// Token: 0x06017746 RID: 96070 RVA: 0x0035997F File Offset: 0x00357B7F
		public void UnPackTo(IDarkTideXinjilemuChaseBossEventT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06017747 RID: 96071 RVA: 0x00359990 File Offset: 0x00357B90
		public static Offset<IDarkTideXinjilemuChaseBossEvent> Pack(FlatBufferBuilder builder, IDarkTideXinjilemuChaseBossEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDarkTideXinjilemuChaseBossEvent>);
			}
			return IDarkTideXinjilemuChaseBossEvent.CreateIDarkTideXinjilemuChaseBossEvent(builder, _o.Type);
		}

		// Token: 0x0400C0DC RID: 49372
		private Table __p;
	}
}
