using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DFE RID: 28158
	public struct IQuestVarContext : IFlatbufferObject
	{
		// Token: 0x1700D1DE RID: 53726
		// (get) Token: 0x06031BDB RID: 203739 RVA: 0x006BC10A File Offset: 0x006BA30A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031BDC RID: 203740 RVA: 0x006BC117 File Offset: 0x006BA317
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031BDD RID: 203741 RVA: 0x006BC120 File Offset: 0x006BA320
		public static IQuestVarContext GetRootAsIQuestVarContext(ByteBuffer _bb)
		{
			return IQuestVarContext.GetRootAsIQuestVarContext(_bb, default(IQuestVarContext));
		}

		// Token: 0x06031BDE RID: 203742 RVA: 0x006BC13C File Offset: 0x006BA33C
		public static IQuestVarContext GetRootAsIQuestVarContext(ByteBuffer _bb, IQuestVarContext obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031BDF RID: 203743 RVA: 0x006BC159 File Offset: 0x006BA359
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031BE0 RID: 203744 RVA: 0x006BC168 File Offset: 0x006BA368
		public IQuestVarContext __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D1DF RID: 53727
		// (get) Token: 0x06031BE1 RID: 203745 RVA: 0x006BC178 File Offset: 0x006BA378
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

		// Token: 0x1700D1E0 RID: 53728
		// (get) Token: 0x06031BE2 RID: 203746 RVA: 0x006BC1B4 File Offset: 0x006BA3B4
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

		// Token: 0x06031BE3 RID: 203747 RVA: 0x006BC1F0 File Offset: 0x006BA3F0
		public static Offset<IQuestVarContext> CreateIQuestVarContext(FlatBufferBuilder builder, EVarContext Type = EVarContext.None, int Id = 0)
		{
			builder.StartTable(2);
			IQuestVarContext.AddId(builder, Id);
			IQuestVarContext.AddType(builder, Type);
			return IQuestVarContext.EndIQuestVarContext(builder);
		}

		// Token: 0x06031BE4 RID: 203748 RVA: 0x006BC20D File Offset: 0x006BA40D
		public static void StartIQuestVarContext(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031BE5 RID: 203749 RVA: 0x006BC216 File Offset: 0x006BA416
		public static void AddType(FlatBufferBuilder builder, EVarContext type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031BE6 RID: 203750 RVA: 0x006BC221 File Offset: 0x006BA421
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06031BE7 RID: 203751 RVA: 0x006BC22C File Offset: 0x006BA42C
		public static Offset<IQuestVarContext> EndIQuestVarContext(FlatBufferBuilder builder)
		{
			return new Offset<IQuestVarContext>(builder.EndTable());
		}

		// Token: 0x06031BE8 RID: 203752 RVA: 0x006BC23C File Offset: 0x006BA43C
		public IQuestVarContextT UnPack()
		{
			IQuestVarContextT questVarContextT = new IQuestVarContextT();
			this.UnPackTo(questVarContextT);
			return questVarContextT;
		}

		// Token: 0x06031BE9 RID: 203753 RVA: 0x006BC257 File Offset: 0x006BA457
		public void UnPackTo(IQuestVarContextT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x06031BEA RID: 203754 RVA: 0x006BC274 File Offset: 0x006BA474
		public static Offset<IQuestVarContext> Pack(FlatBufferBuilder builder, IQuestVarContextT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestVarContext>);
			}
			return IQuestVarContext.CreateIQuestVarContext(builder, _o.Type, _o.Id);
		}

		// Token: 0x040117DD RID: 71645
		private Table __p;
	}
}
