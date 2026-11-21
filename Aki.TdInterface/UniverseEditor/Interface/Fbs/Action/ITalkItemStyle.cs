using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AD3 RID: 31443
	public struct ITalkItemStyle : IFlatbufferObject
	{
		// Token: 0x1700E9B7 RID: 59831
		// (get) Token: 0x060382E0 RID: 230112 RVA: 0x0078F9C6 File Offset: 0x0078DBC6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060382E1 RID: 230113 RVA: 0x0078F9D3 File Offset: 0x0078DBD3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060382E2 RID: 230114 RVA: 0x0078F9DC File Offset: 0x0078DBDC
		public static ITalkItemStyle GetRootAsITalkItemStyle(ByteBuffer _bb)
		{
			return ITalkItemStyle.GetRootAsITalkItemStyle(_bb, default(ITalkItemStyle));
		}

		// Token: 0x060382E3 RID: 230115 RVA: 0x0078F9F8 File Offset: 0x0078DBF8
		public static ITalkItemStyle GetRootAsITalkItemStyle(ByteBuffer _bb, ITalkItemStyle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060382E4 RID: 230116 RVA: 0x0078FA15 File Offset: 0x0078DC15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060382E5 RID: 230117 RVA: 0x0078FA24 File Offset: 0x0078DC24
		public ITalkItemStyle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E9B8 RID: 59832
		// (get) Token: 0x060382E6 RID: 230118 RVA: 0x0078FA34 File Offset: 0x0078DC34
		public ETalkItemStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETalkItemStyle.InnerVoice;
				}
				return (ETalkItemStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060382E7 RID: 230119 RVA: 0x0078FA70 File Offset: 0x0078DC70
		public static Offset<ITalkItemStyle> CreateITalkItemStyle(FlatBufferBuilder builder, ETalkItemStyle Type = ETalkItemStyle.InnerVoice)
		{
			builder.StartTable(1);
			ITalkItemStyle.AddType(builder, Type);
			return ITalkItemStyle.EndITalkItemStyle(builder);
		}

		// Token: 0x060382E8 RID: 230120 RVA: 0x0078FA86 File Offset: 0x0078DC86
		public static void StartITalkItemStyle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060382E9 RID: 230121 RVA: 0x0078FA8F File Offset: 0x0078DC8F
		public static void AddType(FlatBufferBuilder builder, ETalkItemStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060382EA RID: 230122 RVA: 0x0078FA9A File Offset: 0x0078DC9A
		public static Offset<ITalkItemStyle> EndITalkItemStyle(FlatBufferBuilder builder)
		{
			return new Offset<ITalkItemStyle>(builder.EndTable());
		}

		// Token: 0x060382EB RID: 230123 RVA: 0x0078FAA8 File Offset: 0x0078DCA8
		public ITalkItemStyleT UnPack()
		{
			ITalkItemStyleT talkItemStyleT = new ITalkItemStyleT();
			this.UnPackTo(talkItemStyleT);
			return talkItemStyleT;
		}

		// Token: 0x060382EC RID: 230124 RVA: 0x0078FAC3 File Offset: 0x0078DCC3
		public void UnPackTo(ITalkItemStyleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060382ED RID: 230125 RVA: 0x0078FAD4 File Offset: 0x0078DCD4
		public static Offset<ITalkItemStyle> Pack(FlatBufferBuilder builder, ITalkItemStyleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkItemStyle>);
			}
			return ITalkItemStyle.CreateITalkItemStyle(builder, _o.Type);
		}

		// Token: 0x04012FDF RID: 77791
		private Table __p;
	}
}
