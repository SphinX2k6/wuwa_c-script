using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DF8 RID: 28152
	public struct IQuestActionContext : IFlatbufferObject
	{
		// Token: 0x1700D1D2 RID: 53714
		// (get) Token: 0x06031BA9 RID: 203689 RVA: 0x006BBC4C File Offset: 0x006B9E4C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031BAA RID: 203690 RVA: 0x006BBC59 File Offset: 0x006B9E59
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031BAB RID: 203691 RVA: 0x006BBC60 File Offset: 0x006B9E60
		public static IQuestActionContext GetRootAsIQuestActionContext(ByteBuffer _bb)
		{
			return IQuestActionContext.GetRootAsIQuestActionContext(_bb, default(IQuestActionContext));
		}

		// Token: 0x06031BAC RID: 203692 RVA: 0x006BBC7C File Offset: 0x006B9E7C
		public static IQuestActionContext GetRootAsIQuestActionContext(ByteBuffer _bb, IQuestActionContext obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031BAD RID: 203693 RVA: 0x006BBC99 File Offset: 0x006B9E99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031BAE RID: 203694 RVA: 0x006BBCA8 File Offset: 0x006B9EA8
		public IQuestActionContext __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D1D3 RID: 53715
		// (get) Token: 0x06031BAF RID: 203695 RVA: 0x006BBCB8 File Offset: 0x006B9EB8
		public string Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031BB0 RID: 203696 RVA: 0x006BBCEF File Offset: 0x006B9EEF
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06031BB1 RID: 203697 RVA: 0x006BBCFE File Offset: 0x006B9EFE
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700D1D4 RID: 53716
		// (get) Token: 0x06031BB2 RID: 203698 RVA: 0x006BBD0C File Offset: 0x006B9F0C
		public bool IsChildQuestOfDungeon
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D1D5 RID: 53717
		// (get) Token: 0x06031BB3 RID: 203699 RVA: 0x006BBD4C File Offset: 0x006B9F4C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031BB4 RID: 203700 RVA: 0x006BBD88 File Offset: 0x006B9F88
		public static Offset<IQuestActionContext> CreateIQuestActionContext(FlatBufferBuilder builder, StringOffset TypeOffset = default(StringOffset), bool IsChildQuestOfDungeon = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IQuestActionContext.AddType(builder, TypeOffset);
			IQuestActionContext.AddNullMask(builder, NullMask);
			IQuestActionContext.AddIsChildQuestOfDungeon(builder, IsChildQuestOfDungeon);
			return IQuestActionContext.EndIQuestActionContext(builder);
		}

		// Token: 0x06031BB5 RID: 203701 RVA: 0x006BBDAC File Offset: 0x006B9FAC
		public static void StartIQuestActionContext(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06031BB6 RID: 203702 RVA: 0x006BBDB5 File Offset: 0x006B9FB5
		public static void AddType(FlatBufferBuilder builder, StringOffset typeOffset)
		{
			builder.AddOffset(0, typeOffset.Value, 0);
		}

		// Token: 0x06031BB7 RID: 203703 RVA: 0x006BBDC5 File Offset: 0x006B9FC5
		public static void AddIsChildQuestOfDungeon(FlatBufferBuilder builder, bool isChildQuestOfDungeon)
		{
			builder.AddBool(1, isChildQuestOfDungeon, false);
		}

		// Token: 0x06031BB8 RID: 203704 RVA: 0x006BBDD0 File Offset: 0x006B9FD0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06031BB9 RID: 203705 RVA: 0x006BBDDB File Offset: 0x006B9FDB
		public static Offset<IQuestActionContext> EndIQuestActionContext(FlatBufferBuilder builder)
		{
			return new Offset<IQuestActionContext>(builder.EndTable());
		}

		// Token: 0x06031BBA RID: 203706 RVA: 0x006BBDE8 File Offset: 0x006B9FE8
		public IQuestActionContextT UnPack()
		{
			IQuestActionContextT questActionContextT = new IQuestActionContextT();
			this.UnPackTo(questActionContextT);
			return questActionContextT;
		}

		// Token: 0x06031BBB RID: 203707 RVA: 0x006BBE03 File Offset: 0x006BA003
		public void UnPackTo(IQuestActionContextT _o)
		{
			_o.Type = this.Type;
			_o.IsChildQuestOfDungeon = this.IsChildQuestOfDungeon;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06031BBC RID: 203708 RVA: 0x006BBE2C File Offset: 0x006BA02C
		public static Offset<IQuestActionContext> Pack(FlatBufferBuilder builder, IQuestActionContextT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestActionContext>);
			}
			StringOffset typeOffset = (_o.Type == null) ? default(StringOffset) : builder.CreateString(_o.Type);
			return IQuestActionContext.CreateIQuestActionContext(builder, typeOffset, _o.IsChildQuestOfDungeon, _o.NullMask);
		}

		// Token: 0x040117D6 RID: 71638
		private Table __p;
	}
}
