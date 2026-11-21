using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005163 RID: 20835
	public struct IOpenDateConditon : IFlatbufferObject
	{
		// Token: 0x17009540 RID: 38208
		// (get) Token: 0x06020C5F RID: 134239 RVA: 0x00489D2C File Offset: 0x00487F2C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020C60 RID: 134240 RVA: 0x00489D39 File Offset: 0x00487F39
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020C61 RID: 134241 RVA: 0x00489D40 File Offset: 0x00487F40
		public static IOpenDateConditon GetRootAsIOpenDateConditon(ByteBuffer _bb)
		{
			return IOpenDateConditon.GetRootAsIOpenDateConditon(_bb, default(IOpenDateConditon));
		}

		// Token: 0x06020C62 RID: 134242 RVA: 0x00489D5C File Offset: 0x00487F5C
		public static IOpenDateConditon GetRootAsIOpenDateConditon(ByteBuffer _bb, IOpenDateConditon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020C63 RID: 134243 RVA: 0x00489D79 File Offset: 0x00487F79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020C64 RID: 134244 RVA: 0x00489D88 File Offset: 0x00487F88
		public IOpenDateConditon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009541 RID: 38209
		// (get) Token: 0x06020C65 RID: 134245 RVA: 0x00489D98 File Offset: 0x00487F98
		public EAccessQuestCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAccessQuestCondition.ExploreLevel;
				}
				return (EAccessQuestCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009542 RID: 38210
		// (get) Token: 0x06020C66 RID: 134246 RVA: 0x00489DD4 File Offset: 0x00487FD4
		public int DateId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009543 RID: 38211
		// (get) Token: 0x06020C67 RID: 134247 RVA: 0x00489E10 File Offset: 0x00488010
		public EQuestOpenDateType OpenType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EQuestOpenDateType.AfterBeginTime;
				}
				return (EQuestOpenDateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009544 RID: 38212
		// (get) Token: 0x06020C68 RID: 134248 RVA: 0x00489E4C File Offset: 0x0048804C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020C69 RID: 134249 RVA: 0x00489E89 File Offset: 0x00488089
		public static Offset<IOpenDateConditon> CreateIOpenDateConditon(FlatBufferBuilder builder, EAccessQuestCondition Type = EAccessQuestCondition.ExploreLevel, int DateId = 0, EQuestOpenDateType OpenType = EQuestOpenDateType.AfterBeginTime, byte NullMask = 0)
		{
			builder.StartTable(4);
			IOpenDateConditon.AddDateId(builder, DateId);
			IOpenDateConditon.AddNullMask(builder, NullMask);
			IOpenDateConditon.AddOpenType(builder, OpenType);
			IOpenDateConditon.AddType(builder, Type);
			return IOpenDateConditon.EndIOpenDateConditon(builder);
		}

		// Token: 0x06020C6A RID: 134250 RVA: 0x00489EB5 File Offset: 0x004880B5
		public static void StartIOpenDateConditon(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06020C6B RID: 134251 RVA: 0x00489EBE File Offset: 0x004880BE
		public static void AddType(FlatBufferBuilder builder, EAccessQuestCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020C6C RID: 134252 RVA: 0x00489EC9 File Offset: 0x004880C9
		public static void AddDateId(FlatBufferBuilder builder, int dateId)
		{
			builder.AddInt(1, dateId, 0);
		}

		// Token: 0x06020C6D RID: 134253 RVA: 0x00489ED4 File Offset: 0x004880D4
		public static void AddOpenType(FlatBufferBuilder builder, EQuestOpenDateType openType)
		{
			builder.AddByte(2, (byte)openType, 0);
		}

		// Token: 0x06020C6E RID: 134254 RVA: 0x00489EDF File Offset: 0x004880DF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06020C6F RID: 134255 RVA: 0x00489EEA File Offset: 0x004880EA
		public static Offset<IOpenDateConditon> EndIOpenDateConditon(FlatBufferBuilder builder)
		{
			return new Offset<IOpenDateConditon>(builder.EndTable());
		}

		// Token: 0x06020C70 RID: 134256 RVA: 0x00489EF8 File Offset: 0x004880F8
		public IOpenDateConditonT UnPack()
		{
			IOpenDateConditonT openDateConditonT = new IOpenDateConditonT();
			this.UnPackTo(openDateConditonT);
			return openDateConditonT;
		}

		// Token: 0x06020C71 RID: 134257 RVA: 0x00489F13 File Offset: 0x00488113
		public void UnPackTo(IOpenDateConditonT _o)
		{
			_o.Type = this.Type;
			_o.DateId = this.DateId;
			_o.OpenType = this.OpenType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06020C72 RID: 134258 RVA: 0x00489F48 File Offset: 0x00488148
		public static Offset<IOpenDateConditon> Pack(FlatBufferBuilder builder, IOpenDateConditonT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenDateConditon>);
			}
			return IOpenDateConditon.CreateIOpenDateConditon(builder, _o.Type, _o.DateId, _o.OpenType, _o.NullMask);
		}

		// Token: 0x0400E140 RID: 57664
		private Table __p;
	}
}
