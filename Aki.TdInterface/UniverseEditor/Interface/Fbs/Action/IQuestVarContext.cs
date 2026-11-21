using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007579 RID: 30073
	public struct IQuestVarContext : IFlatbufferObject
	{
		// Token: 0x1700DD26 RID: 56614
		// (get) Token: 0x06034BD7 RID: 216023 RVA: 0x007177F2 File Offset: 0x007159F2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034BD8 RID: 216024 RVA: 0x007177FF File Offset: 0x007159FF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034BD9 RID: 216025 RVA: 0x00717808 File Offset: 0x00715A08
		public static IQuestVarContext GetRootAsIQuestVarContext(ByteBuffer _bb)
		{
			return IQuestVarContext.GetRootAsIQuestVarContext(_bb, default(IQuestVarContext));
		}

		// Token: 0x06034BDA RID: 216026 RVA: 0x00717824 File Offset: 0x00715A24
		public static IQuestVarContext GetRootAsIQuestVarContext(ByteBuffer _bb, IQuestVarContext obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034BDB RID: 216027 RVA: 0x00717841 File Offset: 0x00715A41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034BDC RID: 216028 RVA: 0x00717850 File Offset: 0x00715A50
		public IQuestVarContext __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DD27 RID: 56615
		// (get) Token: 0x06034BDD RID: 216029 RVA: 0x00717860 File Offset: 0x00715A60
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

		// Token: 0x1700DD28 RID: 56616
		// (get) Token: 0x06034BDE RID: 216030 RVA: 0x0071789C File Offset: 0x00715A9C
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

		// Token: 0x06034BDF RID: 216031 RVA: 0x007178D8 File Offset: 0x00715AD8
		public static Offset<IQuestVarContext> CreateIQuestVarContext(FlatBufferBuilder builder, EVarContext Type = EVarContext.None, int Id = 0)
		{
			builder.StartTable(2);
			IQuestVarContext.AddId(builder, Id);
			IQuestVarContext.AddType(builder, Type);
			return IQuestVarContext.EndIQuestVarContext(builder);
		}

		// Token: 0x06034BE0 RID: 216032 RVA: 0x007178F5 File Offset: 0x00715AF5
		public static void StartIQuestVarContext(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06034BE1 RID: 216033 RVA: 0x007178FE File Offset: 0x00715AFE
		public static void AddType(FlatBufferBuilder builder, EVarContext type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034BE2 RID: 216034 RVA: 0x00717909 File Offset: 0x00715B09
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06034BE3 RID: 216035 RVA: 0x00717914 File Offset: 0x00715B14
		public static Offset<IQuestVarContext> EndIQuestVarContext(FlatBufferBuilder builder)
		{
			return new Offset<IQuestVarContext>(builder.EndTable());
		}

		// Token: 0x06034BE4 RID: 216036 RVA: 0x00717924 File Offset: 0x00715B24
		public IQuestVarContextT UnPack()
		{
			IQuestVarContextT questVarContextT = new IQuestVarContextT();
			this.UnPackTo(questVarContextT);
			return questVarContextT;
		}

		// Token: 0x06034BE5 RID: 216037 RVA: 0x0071793F File Offset: 0x00715B3F
		public void UnPackTo(IQuestVarContextT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x06034BE6 RID: 216038 RVA: 0x0071795C File Offset: 0x00715B5C
		public static Offset<IQuestVarContext> Pack(FlatBufferBuilder builder, IQuestVarContextT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestVarContext>);
			}
			return IQuestVarContext.CreateIQuestVarContext(builder, _o.Type, _o.Id);
		}

		// Token: 0x04012759 RID: 75609
		private Table __p;
	}
}
