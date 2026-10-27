using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E12 RID: 15890
	public struct IEventTypeConfig : IFlatbufferObject
	{
		// Token: 0x17006DD5 RID: 28117
		// (get) Token: 0x060163D2 RID: 91090 RVA: 0x00335D29 File Offset: 0x00333F29
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060163D3 RID: 91091 RVA: 0x00335D36 File Offset: 0x00333F36
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060163D4 RID: 91092 RVA: 0x00335D40 File Offset: 0x00333F40
		public static IEventTypeConfig GetRootAsIEventTypeConfig(ByteBuffer _bb)
		{
			return IEventTypeConfig.GetRootAsIEventTypeConfig(_bb, default(IEventTypeConfig));
		}

		// Token: 0x060163D5 RID: 91093 RVA: 0x00335D5C File Offset: 0x00333F5C
		public static IEventTypeConfig GetRootAsIEventTypeConfig(ByteBuffer _bb, IEventTypeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060163D6 RID: 91094 RVA: 0x00335D79 File Offset: 0x00333F79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060163D7 RID: 91095 RVA: 0x00335D88 File Offset: 0x00333F88
		public IEventTypeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006DD6 RID: 28118
		// (get) Token: 0x060163D8 RID: 91096 RVA: 0x00335D98 File Offset: 0x00333F98
		public ECommonEventType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonEventType.VarValueChange;
				}
				return (ECommonEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060163D9 RID: 91097 RVA: 0x00335DD4 File Offset: 0x00333FD4
		public static Offset<IEventTypeConfig> CreateIEventTypeConfig(FlatBufferBuilder builder, ECommonEventType Type = ECommonEventType.VarValueChange)
		{
			builder.StartTable(1);
			IEventTypeConfig.AddType(builder, Type);
			return IEventTypeConfig.EndIEventTypeConfig(builder);
		}

		// Token: 0x060163DA RID: 91098 RVA: 0x00335DEA File Offset: 0x00333FEA
		public static void StartIEventTypeConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060163DB RID: 91099 RVA: 0x00335DF3 File Offset: 0x00333FF3
		public static void AddType(FlatBufferBuilder builder, ECommonEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060163DC RID: 91100 RVA: 0x00335DFE File Offset: 0x00333FFE
		public static Offset<IEventTypeConfig> EndIEventTypeConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEventTypeConfig>(builder.EndTable());
		}

		// Token: 0x060163DD RID: 91101 RVA: 0x00335E0C File Offset: 0x0033400C
		public IEventTypeConfigT UnPack()
		{
			IEventTypeConfigT eventTypeConfigT = new IEventTypeConfigT();
			this.UnPackTo(eventTypeConfigT);
			return eventTypeConfigT;
		}

		// Token: 0x060163DE RID: 91102 RVA: 0x00335E27 File Offset: 0x00334027
		public void UnPackTo(IEventTypeConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060163DF RID: 91103 RVA: 0x00335E38 File Offset: 0x00334038
		public static Offset<IEventTypeConfig> Pack(FlatBufferBuilder builder, IEventTypeConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEventTypeConfig>);
			}
			return IEventTypeConfig.CreateIEventTypeConfig(builder, _o.Type);
		}

		// Token: 0x0400B786 RID: 46982
		private Table __p;
	}
}
