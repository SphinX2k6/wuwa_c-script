using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A7B RID: 14971
	public struct IBvbPlayerHp : IFlatbufferObject
	{
		// Token: 0x1700668D RID: 26253
		// (get) Token: 0x060144BD RID: 83133 RVA: 0x002F6879 File Offset: 0x002F4A79
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060144BE RID: 83134 RVA: 0x002F6886 File Offset: 0x002F4A86
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060144BF RID: 83135 RVA: 0x002F6890 File Offset: 0x002F4A90
		public static IBvbPlayerHp GetRootAsIBvbPlayerHp(ByteBuffer _bb)
		{
			return IBvbPlayerHp.GetRootAsIBvbPlayerHp(_bb, default(IBvbPlayerHp));
		}

		// Token: 0x060144C0 RID: 83136 RVA: 0x002F68AC File Offset: 0x002F4AAC
		public static IBvbPlayerHp GetRootAsIBvbPlayerHp(ByteBuffer _bb, IBvbPlayerHp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060144C1 RID: 83137 RVA: 0x002F68C9 File Offset: 0x002F4AC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060144C2 RID: 83138 RVA: 0x002F68D8 File Offset: 0x002F4AD8
		public IBvbPlayerHp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700668E RID: 26254
		// (get) Token: 0x060144C3 RID: 83139 RVA: 0x002F68E8 File Offset: 0x002F4AE8
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

		// Token: 0x060144C4 RID: 83140 RVA: 0x002F6924 File Offset: 0x002F4B24
		public static Offset<IBvbPlayerHp> CreateIBvbPlayerHp(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar)
		{
			builder.StartTable(1);
			IBvbPlayerHp.AddType(builder, Type);
			return IBvbPlayerHp.EndIBvbPlayerHp(builder);
		}

		// Token: 0x060144C5 RID: 83141 RVA: 0x002F693A File Offset: 0x002F4B3A
		public static void StartIBvbPlayerHp(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060144C6 RID: 83142 RVA: 0x002F6943 File Offset: 0x002F4B43
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060144C7 RID: 83143 RVA: 0x002F694E File Offset: 0x002F4B4E
		public static Offset<IBvbPlayerHp> EndIBvbPlayerHp(FlatBufferBuilder builder)
		{
			return new Offset<IBvbPlayerHp>(builder.EndTable());
		}

		// Token: 0x060144C8 RID: 83144 RVA: 0x002F695C File Offset: 0x002F4B5C
		public IBvbPlayerHpT UnPack()
		{
			IBvbPlayerHpT bvbPlayerHpT = new IBvbPlayerHpT();
			this.UnPackTo(bvbPlayerHpT);
			return bvbPlayerHpT;
		}

		// Token: 0x060144C9 RID: 83145 RVA: 0x002F6977 File Offset: 0x002F4B77
		public void UnPackTo(IBvbPlayerHpT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060144CA RID: 83146 RVA: 0x002F6988 File Offset: 0x002F4B88
		public static Offset<IBvbPlayerHp> Pack(FlatBufferBuilder builder, IBvbPlayerHpT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbPlayerHp>);
			}
			return IBvbPlayerHp.CreateIBvbPlayerHp(builder, _o.Type);
		}

		// Token: 0x0400AEF8 RID: 44792
		private Table __p;
	}
}
