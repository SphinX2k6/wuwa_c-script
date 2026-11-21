using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D73 RID: 28019
	public struct IEntityVarContext : IFlatbufferObject
	{
		// Token: 0x1700CD92 RID: 52626
		// (get) Token: 0x0603058B RID: 198027 RVA: 0x00691DA4 File Offset: 0x0068FFA4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603058C RID: 198028 RVA: 0x00691DB1 File Offset: 0x0068FFB1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603058D RID: 198029 RVA: 0x00691DB8 File Offset: 0x0068FFB8
		public static IEntityVarContext GetRootAsIEntityVarContext(ByteBuffer _bb)
		{
			return IEntityVarContext.GetRootAsIEntityVarContext(_bb, default(IEntityVarContext));
		}

		// Token: 0x0603058E RID: 198030 RVA: 0x00691DD4 File Offset: 0x0068FFD4
		public static IEntityVarContext GetRootAsIEntityVarContext(ByteBuffer _bb, IEntityVarContext obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603058F RID: 198031 RVA: 0x00691DF1 File Offset: 0x0068FFF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030590 RID: 198032 RVA: 0x00691E00 File Offset: 0x00690000
		public IEntityVarContext __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD93 RID: 52627
		// (get) Token: 0x06030591 RID: 198033 RVA: 0x00691E10 File Offset: 0x00690010
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

		// Token: 0x1700CD94 RID: 52628
		// (get) Token: 0x06030592 RID: 198034 RVA: 0x00691E4C File Offset: 0x0069004C
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

		// Token: 0x1700CD95 RID: 52629
		// (get) Token: 0x06030593 RID: 198035 RVA: 0x00691E88 File Offset: 0x00690088
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

		// Token: 0x1700CD96 RID: 52630
		// (get) Token: 0x06030594 RID: 198036 RVA: 0x00691EC4 File Offset: 0x006900C4
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

		// Token: 0x06030595 RID: 198037 RVA: 0x00691F01 File Offset: 0x00690101
		public static Offset<IEntityVarContext> CreateIEntityVarContext(FlatBufferBuilder builder, EVarContext Type = EVarContext.None, int Id = 0, EEntityVarMatchType MatchType = EEntityVarMatchType.EntityId, byte NullMask = 0)
		{
			builder.StartTable(4);
			IEntityVarContext.AddId(builder, Id);
			IEntityVarContext.AddNullMask(builder, NullMask);
			IEntityVarContext.AddMatchType(builder, MatchType);
			IEntityVarContext.AddType(builder, Type);
			return IEntityVarContext.EndIEntityVarContext(builder);
		}

		// Token: 0x06030596 RID: 198038 RVA: 0x00691F2D File Offset: 0x0069012D
		public static void StartIEntityVarContext(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06030597 RID: 198039 RVA: 0x00691F36 File Offset: 0x00690136
		public static void AddType(FlatBufferBuilder builder, EVarContext type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030598 RID: 198040 RVA: 0x00691F41 File Offset: 0x00690141
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06030599 RID: 198041 RVA: 0x00691F4C File Offset: 0x0069014C
		public static void AddMatchType(FlatBufferBuilder builder, EEntityVarMatchType matchType)
		{
			builder.AddByte(2, (byte)matchType, 0);
		}

		// Token: 0x0603059A RID: 198042 RVA: 0x00691F57 File Offset: 0x00690157
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0603059B RID: 198043 RVA: 0x00691F62 File Offset: 0x00690162
		public static Offset<IEntityVarContext> EndIEntityVarContext(FlatBufferBuilder builder)
		{
			return new Offset<IEntityVarContext>(builder.EndTable());
		}

		// Token: 0x0603059C RID: 198044 RVA: 0x00691F70 File Offset: 0x00690170
		public IEntityVarContextT UnPack()
		{
			IEntityVarContextT entityVarContextT = new IEntityVarContextT();
			this.UnPackTo(entityVarContextT);
			return entityVarContextT;
		}

		// Token: 0x0603059D RID: 198045 RVA: 0x00691F8B File Offset: 0x0069018B
		public void UnPackTo(IEntityVarContextT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.MatchType = this.MatchType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603059E RID: 198046 RVA: 0x00691FC0 File Offset: 0x006901C0
		public static Offset<IEntityVarContext> Pack(FlatBufferBuilder builder, IEntityVarContextT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityVarContext>);
			}
			return IEntityVarContext.CreateIEntityVarContext(builder, _o.Type, _o.Id, _o.MatchType, _o.NullMask);
		}

		// Token: 0x04011BF8 RID: 72696
		private Table __p;
	}
}
