using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A84 RID: 14980
	public struct IBvbRemainEvolveTimeThisTurn : IFlatbufferObject
	{
		// Token: 0x17006696 RID: 26262
		// (get) Token: 0x060144F3 RID: 83187 RVA: 0x002F6CE1 File Offset: 0x002F4EE1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060144F4 RID: 83188 RVA: 0x002F6CEE File Offset: 0x002F4EEE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060144F5 RID: 83189 RVA: 0x002F6CF8 File Offset: 0x002F4EF8
		public static IBvbRemainEvolveTimeThisTurn GetRootAsIBvbRemainEvolveTimeThisTurn(ByteBuffer _bb)
		{
			return IBvbRemainEvolveTimeThisTurn.GetRootAsIBvbRemainEvolveTimeThisTurn(_bb, default(IBvbRemainEvolveTimeThisTurn));
		}

		// Token: 0x060144F6 RID: 83190 RVA: 0x002F6D14 File Offset: 0x002F4F14
		public static IBvbRemainEvolveTimeThisTurn GetRootAsIBvbRemainEvolveTimeThisTurn(ByteBuffer _bb, IBvbRemainEvolveTimeThisTurn obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060144F7 RID: 83191 RVA: 0x002F6D31 File Offset: 0x002F4F31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060144F8 RID: 83192 RVA: 0x002F6D40 File Offset: 0x002F4F40
		public IBvbRemainEvolveTimeThisTurn __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006697 RID: 26263
		// (get) Token: 0x060144F9 RID: 83193 RVA: 0x002F6D50 File Offset: 0x002F4F50
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

		// Token: 0x060144FA RID: 83194 RVA: 0x002F6D8C File Offset: 0x002F4F8C
		public static Offset<IBvbRemainEvolveTimeThisTurn> CreateIBvbRemainEvolveTimeThisTurn(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar)
		{
			builder.StartTable(1);
			IBvbRemainEvolveTimeThisTurn.AddType(builder, Type);
			return IBvbRemainEvolveTimeThisTurn.EndIBvbRemainEvolveTimeThisTurn(builder);
		}

		// Token: 0x060144FB RID: 83195 RVA: 0x002F6DA2 File Offset: 0x002F4FA2
		public static void StartIBvbRemainEvolveTimeThisTurn(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060144FC RID: 83196 RVA: 0x002F6DAB File Offset: 0x002F4FAB
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060144FD RID: 83197 RVA: 0x002F6DB6 File Offset: 0x002F4FB6
		public static Offset<IBvbRemainEvolveTimeThisTurn> EndIBvbRemainEvolveTimeThisTurn(FlatBufferBuilder builder)
		{
			return new Offset<IBvbRemainEvolveTimeThisTurn>(builder.EndTable());
		}

		// Token: 0x060144FE RID: 83198 RVA: 0x002F6DC4 File Offset: 0x002F4FC4
		public IBvbRemainEvolveTimeThisTurnT UnPack()
		{
			IBvbRemainEvolveTimeThisTurnT bvbRemainEvolveTimeThisTurnT = new IBvbRemainEvolveTimeThisTurnT();
			this.UnPackTo(bvbRemainEvolveTimeThisTurnT);
			return bvbRemainEvolveTimeThisTurnT;
		}

		// Token: 0x060144FF RID: 83199 RVA: 0x002F6DDF File Offset: 0x002F4FDF
		public void UnPackTo(IBvbRemainEvolveTimeThisTurnT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06014500 RID: 83200 RVA: 0x002F6DF0 File Offset: 0x002F4FF0
		public static Offset<IBvbRemainEvolveTimeThisTurn> Pack(FlatBufferBuilder builder, IBvbRemainEvolveTimeThisTurnT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbRemainEvolveTimeThisTurn>);
			}
			return IBvbRemainEvolveTimeThisTurn.CreateIBvbRemainEvolveTimeThisTurn(builder, _o.Type);
		}

		// Token: 0x0400AEFE RID: 44798
		private Table __p;
	}
}
