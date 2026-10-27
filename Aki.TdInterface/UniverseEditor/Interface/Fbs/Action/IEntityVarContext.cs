using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066F3 RID: 26355
	public struct IEntityVarContext : IFlatbufferObject
	{
		// Token: 0x1700C3DC RID: 50140
		// (get) Token: 0x0602DD4E RID: 187726 RVA: 0x00644830 File Offset: 0x00642A30
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DD4F RID: 187727 RVA: 0x0064483D File Offset: 0x00642A3D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DD50 RID: 187728 RVA: 0x00644844 File Offset: 0x00642A44
		public static IEntityVarContext GetRootAsIEntityVarContext(ByteBuffer _bb)
		{
			return IEntityVarContext.GetRootAsIEntityVarContext(_bb, default(IEntityVarContext));
		}

		// Token: 0x0602DD51 RID: 187729 RVA: 0x00644860 File Offset: 0x00642A60
		public static IEntityVarContext GetRootAsIEntityVarContext(ByteBuffer _bb, IEntityVarContext obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DD52 RID: 187730 RVA: 0x0064487D File Offset: 0x00642A7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DD53 RID: 187731 RVA: 0x0064488C File Offset: 0x00642A8C
		public IEntityVarContext __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C3DD RID: 50141
		// (get) Token: 0x0602DD54 RID: 187732 RVA: 0x0064489C File Offset: 0x00642A9C
		public EVarContext Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVarContext.None;
				}
				return (EVarContext)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C3DE RID: 50142
		// (get) Token: 0x0602DD55 RID: 187733 RVA: 0x006448D8 File Offset: 0x00642AD8
		public int Id
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

		// Token: 0x1700C3DF RID: 50143
		// (get) Token: 0x0602DD56 RID: 187734 RVA: 0x00644914 File Offset: 0x00642B14
		public EEntityVarMatchType MatchType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EEntityVarMatchType.EntityId;
				}
				return (EEntityVarMatchType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C3E0 RID: 50144
		// (get) Token: 0x0602DD57 RID: 187735 RVA: 0x00644950 File Offset: 0x00642B50
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

		// Token: 0x0602DD58 RID: 187736 RVA: 0x0064498D File Offset: 0x00642B8D
		public static Offset<IEntityVarContext> CreateIEntityVarContext(FlatBufferBuilder builder, EVarContext Type = EVarContext.None, int Id = 0, EEntityVarMatchType MatchType = EEntityVarMatchType.EntityId, byte NullMask = 0)
		{
			builder.StartTable(4);
			IEntityVarContext.AddId(builder, Id);
			IEntityVarContext.AddNullMask(builder, NullMask);
			IEntityVarContext.AddMatchType(builder, MatchType);
			IEntityVarContext.AddType(builder, Type);
			return IEntityVarContext.EndIEntityVarContext(builder);
		}

		// Token: 0x0602DD59 RID: 187737 RVA: 0x006449B9 File Offset: 0x00642BB9
		public static void StartIEntityVarContext(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602DD5A RID: 187738 RVA: 0x006449C2 File Offset: 0x00642BC2
		public static void AddType(FlatBufferBuilder builder, EVarContext type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DD5B RID: 187739 RVA: 0x006449CD File Offset: 0x00642BCD
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0602DD5C RID: 187740 RVA: 0x006449D8 File Offset: 0x00642BD8
		public static void AddMatchType(FlatBufferBuilder builder, EEntityVarMatchType matchType)
		{
			builder.AddByte(2, (byte)matchType, 0);
		}

		// Token: 0x0602DD5D RID: 187741 RVA: 0x006449E3 File Offset: 0x00642BE3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602DD5E RID: 187742 RVA: 0x006449EE File Offset: 0x00642BEE
		public static Offset<IEntityVarContext> EndIEntityVarContext(FlatBufferBuilder builder)
		{
			return new Offset<IEntityVarContext>(builder.EndTable());
		}

		// Token: 0x0602DD5F RID: 187743 RVA: 0x006449FC File Offset: 0x00642BFC
		public IEntityVarContextT UnPack()
		{
			IEntityVarContextT entityVarContextT = new IEntityVarContextT();
			this.UnPackTo(entityVarContextT);
			return entityVarContextT;
		}

		// Token: 0x0602DD60 RID: 187744 RVA: 0x00644A17 File Offset: 0x00642C17
		public void UnPackTo(IEntityVarContextT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.MatchType = this.MatchType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602DD61 RID: 187745 RVA: 0x00644A4C File Offset: 0x00642C4C
		public static Offset<IEntityVarContext> Pack(FlatBufferBuilder builder, IEntityVarContextT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityVarContext>);
			}
			return IEntityVarContext.CreateIEntityVarContext(builder, _o.Type, _o.Id, _o.MatchType, _o.NullMask);
		}

		// Token: 0x04010DC9 RID: 69065
		private Table __p;
	}
}
