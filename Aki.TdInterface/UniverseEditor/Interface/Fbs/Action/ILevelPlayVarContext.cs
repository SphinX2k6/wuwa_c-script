using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200709D RID: 28829
	public struct ILevelPlayVarContext : IFlatbufferObject
	{
		// Token: 0x1700D32E RID: 54062
		// (get) Token: 0x060320CD RID: 205005 RVA: 0x006C669A File Offset: 0x006C489A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060320CE RID: 205006 RVA: 0x006C66A7 File Offset: 0x006C48A7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060320CF RID: 205007 RVA: 0x006C66B0 File Offset: 0x006C48B0
		public static ILevelPlayVarContext GetRootAsILevelPlayVarContext(ByteBuffer _bb)
		{
			return ILevelPlayVarContext.GetRootAsILevelPlayVarContext(_bb, default(ILevelPlayVarContext));
		}

		// Token: 0x060320D0 RID: 205008 RVA: 0x006C66CC File Offset: 0x006C48CC
		public static ILevelPlayVarContext GetRootAsILevelPlayVarContext(ByteBuffer _bb, ILevelPlayVarContext obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060320D1 RID: 205009 RVA: 0x006C66E9 File Offset: 0x006C48E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060320D2 RID: 205010 RVA: 0x006C66F8 File Offset: 0x006C48F8
		public ILevelPlayVarContext __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D32F RID: 54063
		// (get) Token: 0x060320D3 RID: 205011 RVA: 0x006C6708 File Offset: 0x006C4908
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

		// Token: 0x1700D330 RID: 54064
		// (get) Token: 0x060320D4 RID: 205012 RVA: 0x006C6744 File Offset: 0x006C4944
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

		// Token: 0x060320D5 RID: 205013 RVA: 0x006C6780 File Offset: 0x006C4980
		public static Offset<ILevelPlayVarContext> CreateILevelPlayVarContext(FlatBufferBuilder builder, EVarContext Type = EVarContext.None, int Id = 0)
		{
			builder.StartTable(2);
			ILevelPlayVarContext.AddId(builder, Id);
			ILevelPlayVarContext.AddType(builder, Type);
			return ILevelPlayVarContext.EndILevelPlayVarContext(builder);
		}

		// Token: 0x060320D6 RID: 205014 RVA: 0x006C679D File Offset: 0x006C499D
		public static void StartILevelPlayVarContext(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060320D7 RID: 205015 RVA: 0x006C67A6 File Offset: 0x006C49A6
		public static void AddType(FlatBufferBuilder builder, EVarContext type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060320D8 RID: 205016 RVA: 0x006C67B1 File Offset: 0x006C49B1
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x060320D9 RID: 205017 RVA: 0x006C67BC File Offset: 0x006C49BC
		public static Offset<ILevelPlayVarContext> EndILevelPlayVarContext(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayVarContext>(builder.EndTable());
		}

		// Token: 0x060320DA RID: 205018 RVA: 0x006C67CC File Offset: 0x006C49CC
		public ILevelPlayVarContextT UnPack()
		{
			ILevelPlayVarContextT levelPlayVarContextT = new ILevelPlayVarContextT();
			this.UnPackTo(levelPlayVarContextT);
			return levelPlayVarContextT;
		}

		// Token: 0x060320DB RID: 205019 RVA: 0x006C67E7 File Offset: 0x006C49E7
		public void UnPackTo(ILevelPlayVarContextT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x060320DC RID: 205020 RVA: 0x006C6804 File Offset: 0x006C4A04
		public static Offset<ILevelPlayVarContext> Pack(FlatBufferBuilder builder, ILevelPlayVarContextT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayVarContext>);
			}
			return ILevelPlayVarContext.CreateILevelPlayVarContext(builder, _o.Type, _o.Id);
		}

		// Token: 0x0401204D RID: 73805
		private Table __p;
	}
}
