using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069ED RID: 27117
	public struct ILevelPlayVarContext : IFlatbufferObject
	{
		// Token: 0x1700C92E RID: 51502
		// (get) Token: 0x0602F70D RID: 194317 RVA: 0x00676342 File Offset: 0x00674542
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F70E RID: 194318 RVA: 0x0067634F File Offset: 0x0067454F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F70F RID: 194319 RVA: 0x00676358 File Offset: 0x00674558
		public static ILevelPlayVarContext GetRootAsILevelPlayVarContext(ByteBuffer _bb)
		{
			return ILevelPlayVarContext.GetRootAsILevelPlayVarContext(_bb, default(ILevelPlayVarContext));
		}

		// Token: 0x0602F710 RID: 194320 RVA: 0x00676374 File Offset: 0x00674574
		public static ILevelPlayVarContext GetRootAsILevelPlayVarContext(ByteBuffer _bb, ILevelPlayVarContext obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F711 RID: 194321 RVA: 0x00676391 File Offset: 0x00674591
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F712 RID: 194322 RVA: 0x006763A0 File Offset: 0x006745A0
		public ILevelPlayVarContext __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C92F RID: 51503
		// (get) Token: 0x0602F713 RID: 194323 RVA: 0x006763B0 File Offset: 0x006745B0
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

		// Token: 0x1700C930 RID: 51504
		// (get) Token: 0x0602F714 RID: 194324 RVA: 0x006763EC File Offset: 0x006745EC
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

		// Token: 0x0602F715 RID: 194325 RVA: 0x00676428 File Offset: 0x00674628
		public static Offset<ILevelPlayVarContext> CreateILevelPlayVarContext(FlatBufferBuilder builder, EVarContext Type = EVarContext.None, int Id = 0)
		{
			builder.StartTable(2);
			ILevelPlayVarContext.AddId(builder, Id);
			ILevelPlayVarContext.AddType(builder, Type);
			return ILevelPlayVarContext.EndILevelPlayVarContext(builder);
		}

		// Token: 0x0602F716 RID: 194326 RVA: 0x00676445 File Offset: 0x00674645
		public static void StartILevelPlayVarContext(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F717 RID: 194327 RVA: 0x0067644E File Offset: 0x0067464E
		public static void AddType(FlatBufferBuilder builder, EVarContext type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F718 RID: 194328 RVA: 0x00676459 File Offset: 0x00674659
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0602F719 RID: 194329 RVA: 0x00676464 File Offset: 0x00674664
		public static Offset<ILevelPlayVarContext> EndILevelPlayVarContext(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayVarContext>(builder.EndTable());
		}

		// Token: 0x0602F71A RID: 194330 RVA: 0x00676474 File Offset: 0x00674674
		public ILevelPlayVarContextT UnPack()
		{
			ILevelPlayVarContextT levelPlayVarContextT = new ILevelPlayVarContextT();
			this.UnPackTo(levelPlayVarContextT);
			return levelPlayVarContextT;
		}

		// Token: 0x0602F71B RID: 194331 RVA: 0x0067648F File Offset: 0x0067468F
		public void UnPackTo(ILevelPlayVarContextT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0602F71C RID: 194332 RVA: 0x006764AC File Offset: 0x006746AC
		public static Offset<ILevelPlayVarContext> Pack(FlatBufferBuilder builder, ILevelPlayVarContextT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayVarContext>);
			}
			return ILevelPlayVarContext.CreateILevelPlayVarContext(builder, _o.Type, _o.Id);
		}

		// Token: 0x040111E3 RID: 70115
		private Table __p;
	}
}
