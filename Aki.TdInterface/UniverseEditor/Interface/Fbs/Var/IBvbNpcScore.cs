using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A78 RID: 14968
	public struct IBvbNpcScore : IFlatbufferObject
	{
		// Token: 0x1700668A RID: 26250
		// (get) Token: 0x060144AB RID: 83115 RVA: 0x002F6701 File Offset: 0x002F4901
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060144AC RID: 83116 RVA: 0x002F670E File Offset: 0x002F490E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060144AD RID: 83117 RVA: 0x002F6718 File Offset: 0x002F4918
		public static IBvbNpcScore GetRootAsIBvbNpcScore(ByteBuffer _bb)
		{
			return IBvbNpcScore.GetRootAsIBvbNpcScore(_bb, default(IBvbNpcScore));
		}

		// Token: 0x060144AE RID: 83118 RVA: 0x002F6734 File Offset: 0x002F4934
		public static IBvbNpcScore GetRootAsIBvbNpcScore(ByteBuffer _bb, IBvbNpcScore obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060144AF RID: 83119 RVA: 0x002F6751 File Offset: 0x002F4951
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060144B0 RID: 83120 RVA: 0x002F6760 File Offset: 0x002F4960
		public IBvbNpcScore __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700668B RID: 26251
		// (get) Token: 0x060144B1 RID: 83121 RVA: 0x002F6770 File Offset: 0x002F4970
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

		// Token: 0x060144B2 RID: 83122 RVA: 0x002F67AC File Offset: 0x002F49AC
		public static Offset<IBvbNpcScore> CreateIBvbNpcScore(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar)
		{
			builder.StartTable(1);
			IBvbNpcScore.AddType(builder, Type);
			return IBvbNpcScore.EndIBvbNpcScore(builder);
		}

		// Token: 0x060144B3 RID: 83123 RVA: 0x002F67C2 File Offset: 0x002F49C2
		public static void StartIBvbNpcScore(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060144B4 RID: 83124 RVA: 0x002F67CB File Offset: 0x002F49CB
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060144B5 RID: 83125 RVA: 0x002F67D6 File Offset: 0x002F49D6
		public static Offset<IBvbNpcScore> EndIBvbNpcScore(FlatBufferBuilder builder)
		{
			return new Offset<IBvbNpcScore>(builder.EndTable());
		}

		// Token: 0x060144B6 RID: 83126 RVA: 0x002F67E4 File Offset: 0x002F49E4
		public IBvbNpcScoreT UnPack()
		{
			IBvbNpcScoreT bvbNpcScoreT = new IBvbNpcScoreT();
			this.UnPackTo(bvbNpcScoreT);
			return bvbNpcScoreT;
		}

		// Token: 0x060144B7 RID: 83127 RVA: 0x002F67FF File Offset: 0x002F49FF
		public void UnPackTo(IBvbNpcScoreT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060144B8 RID: 83128 RVA: 0x002F6810 File Offset: 0x002F4A10
		public static Offset<IBvbNpcScore> Pack(FlatBufferBuilder builder, IBvbNpcScoreT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbNpcScore>);
			}
			return IBvbNpcScore.CreateIBvbNpcScore(builder, _o.Type);
		}

		// Token: 0x0400AEF6 RID: 44790
		private Table __p;
	}
}
