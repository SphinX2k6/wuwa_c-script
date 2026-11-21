using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007573 RID: 30067
	public struct IQuestActionContext : IFlatbufferObject
	{
		// Token: 0x1700DD1A RID: 56602
		// (get) Token: 0x06034BA5 RID: 215973 RVA: 0x00717334 File Offset: 0x00715534
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034BA6 RID: 215974 RVA: 0x00717341 File Offset: 0x00715541
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034BA7 RID: 215975 RVA: 0x00717348 File Offset: 0x00715548
		public static IQuestActionContext GetRootAsIQuestActionContext(ByteBuffer _bb)
		{
			return IQuestActionContext.GetRootAsIQuestActionContext(_bb, default(IQuestActionContext));
		}

		// Token: 0x06034BA8 RID: 215976 RVA: 0x00717364 File Offset: 0x00715564
		public static IQuestActionContext GetRootAsIQuestActionContext(ByteBuffer _bb, IQuestActionContext obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034BA9 RID: 215977 RVA: 0x00717381 File Offset: 0x00715581
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034BAA RID: 215978 RVA: 0x00717390 File Offset: 0x00715590
		public IQuestActionContext __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DD1B RID: 56603
		// (get) Token: 0x06034BAB RID: 215979 RVA: 0x007173A0 File Offset: 0x007155A0
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

		// Token: 0x06034BAC RID: 215980 RVA: 0x007173D7 File Offset: 0x007155D7
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06034BAD RID: 215981 RVA: 0x007173E6 File Offset: 0x007155E6
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700DD1C RID: 56604
		// (get) Token: 0x06034BAE RID: 215982 RVA: 0x007173F4 File Offset: 0x007155F4
		public bool IsChildQuestOfDungeon
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DD1D RID: 56605
		// (get) Token: 0x06034BAF RID: 215983 RVA: 0x00717434 File Offset: 0x00715634
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

		// Token: 0x06034BB0 RID: 215984 RVA: 0x00717470 File Offset: 0x00715670
		public static Offset<IQuestActionContext> CreateIQuestActionContext(FlatBufferBuilder builder, StringOffset TypeOffset = default(StringOffset), bool IsChildQuestOfDungeon = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IQuestActionContext.AddType(builder, TypeOffset);
			IQuestActionContext.AddNullMask(builder, NullMask);
			IQuestActionContext.AddIsChildQuestOfDungeon(builder, IsChildQuestOfDungeon);
			return IQuestActionContext.EndIQuestActionContext(builder);
		}

		// Token: 0x06034BB1 RID: 215985 RVA: 0x00717494 File Offset: 0x00715694
		public static void StartIQuestActionContext(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06034BB2 RID: 215986 RVA: 0x0071749D File Offset: 0x0071569D
		public static void AddType(FlatBufferBuilder builder, StringOffset typeOffset)
		{
			builder.AddOffset(0, typeOffset.Value, 0);
		}

		// Token: 0x06034BB3 RID: 215987 RVA: 0x007174AD File Offset: 0x007156AD
		public static void AddIsChildQuestOfDungeon(FlatBufferBuilder builder, bool isChildQuestOfDungeon)
		{
			builder.AddBool(1, isChildQuestOfDungeon, false);
		}

		// Token: 0x06034BB4 RID: 215988 RVA: 0x007174B8 File Offset: 0x007156B8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06034BB5 RID: 215989 RVA: 0x007174C3 File Offset: 0x007156C3
		public static Offset<IQuestActionContext> EndIQuestActionContext(FlatBufferBuilder builder)
		{
			return new Offset<IQuestActionContext>(builder.EndTable());
		}

		// Token: 0x06034BB6 RID: 215990 RVA: 0x007174D0 File Offset: 0x007156D0
		public IQuestActionContextT UnPack()
		{
			IQuestActionContextT questActionContextT = new IQuestActionContextT();
			this.UnPackTo(questActionContextT);
			return questActionContextT;
		}

		// Token: 0x06034BB7 RID: 215991 RVA: 0x007174EB File Offset: 0x007156EB
		public void UnPackTo(IQuestActionContextT _o)
		{
			_o.Type = this.Type;
			_o.IsChildQuestOfDungeon = this.IsChildQuestOfDungeon;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06034BB8 RID: 215992 RVA: 0x00717514 File Offset: 0x00715714
		public static Offset<IQuestActionContext> Pack(FlatBufferBuilder builder, IQuestActionContextT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestActionContext>);
			}
			StringOffset typeOffset = (_o.Type == null) ? default(StringOffset) : builder.CreateString(_o.Type);
			return IQuestActionContext.CreateIQuestActionContext(builder, typeOffset, _o.IsChildQuestOfDungeon, _o.NullMask);
		}

		// Token: 0x04012752 RID: 75602
		private Table __p;
	}
}
