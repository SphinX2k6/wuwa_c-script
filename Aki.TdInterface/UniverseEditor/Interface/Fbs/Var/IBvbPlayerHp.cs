using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E56 RID: 15958
	public struct IBvbPlayerHp : IFlatbufferObject
	{
		// Token: 0x17006BBD RID: 27581
		// (get) Token: 0x060157D9 RID: 88025 RVA: 0x00319A65 File Offset: 0x00317C65
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060157DA RID: 88026 RVA: 0x00319A72 File Offset: 0x00317C72
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060157DB RID: 88027 RVA: 0x00319A7C File Offset: 0x00317C7C
		public static IBvbPlayerHp GetRootAsIBvbPlayerHp(ByteBuffer _bb)
		{
			return IBvbPlayerHp.GetRootAsIBvbPlayerHp(_bb, default(IBvbPlayerHp));
		}

		// Token: 0x060157DC RID: 88028 RVA: 0x00319A98 File Offset: 0x00317C98
		public static IBvbPlayerHp GetRootAsIBvbPlayerHp(ByteBuffer _bb, IBvbPlayerHp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060157DD RID: 88029 RVA: 0x00319AB5 File Offset: 0x00317CB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060157DE RID: 88030 RVA: 0x00319AC4 File Offset: 0x00317CC4
		public IBvbPlayerHp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006BBE RID: 27582
		// (get) Token: 0x060157DF RID: 88031 RVA: 0x00319AD4 File Offset: 0x00317CD4
		public ESystemVarName Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESystemVarName.CommonHotFixVar;
				}
				return (ESystemVarName)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060157E0 RID: 88032 RVA: 0x00319B10 File Offset: 0x00317D10
		public static Offset<IBvbPlayerHp> CreateIBvbPlayerHp(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar)
		{
			builder.StartTable(1);
			IBvbPlayerHp.AddType(builder, Type);
			return IBvbPlayerHp.EndIBvbPlayerHp(builder);
		}

		// Token: 0x060157E1 RID: 88033 RVA: 0x00319B26 File Offset: 0x00317D26
		public static void StartIBvbPlayerHp(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060157E2 RID: 88034 RVA: 0x00319B2F File Offset: 0x00317D2F
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060157E3 RID: 88035 RVA: 0x00319B3A File Offset: 0x00317D3A
		public static Offset<IBvbPlayerHp> EndIBvbPlayerHp(FlatBufferBuilder builder)
		{
			return new Offset<IBvbPlayerHp>(builder.EndTable());
		}

		// Token: 0x060157E4 RID: 88036 RVA: 0x00319B48 File Offset: 0x00317D48
		public IBvbPlayerHpT UnPack()
		{
			IBvbPlayerHpT bvbPlayerHpT = new IBvbPlayerHpT();
			this.UnPackTo(bvbPlayerHpT);
			return bvbPlayerHpT;
		}

		// Token: 0x060157E5 RID: 88037 RVA: 0x00319B63 File Offset: 0x00317D63
		public void UnPackTo(IBvbPlayerHpT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060157E6 RID: 88038 RVA: 0x00319B74 File Offset: 0x00317D74
		public static Offset<IBvbPlayerHp> Pack(FlatBufferBuilder builder, IBvbPlayerHpT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbPlayerHp>);
			}
			return IBvbPlayerHp.CreateIBvbPlayerHp(builder, _o.Type);
		}

		// Token: 0x0400B81A RID: 47130
		private Table __p;
	}
}
