using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E5C RID: 15964
	public struct IBvbPlayerScore : IFlatbufferObject
	{
		// Token: 0x17006BC3 RID: 27587
		// (get) Token: 0x060157FD RID: 88061 RVA: 0x00319D55 File Offset: 0x00317F55
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060157FE RID: 88062 RVA: 0x00319D62 File Offset: 0x00317F62
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060157FF RID: 88063 RVA: 0x00319D6C File Offset: 0x00317F6C
		public static IBvbPlayerScore GetRootAsIBvbPlayerScore(ByteBuffer _bb)
		{
			return IBvbPlayerScore.GetRootAsIBvbPlayerScore(_bb, default(IBvbPlayerScore));
		}

		// Token: 0x06015800 RID: 88064 RVA: 0x00319D88 File Offset: 0x00317F88
		public static IBvbPlayerScore GetRootAsIBvbPlayerScore(ByteBuffer _bb, IBvbPlayerScore obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015801 RID: 88065 RVA: 0x00319DA5 File Offset: 0x00317FA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015802 RID: 88066 RVA: 0x00319DB4 File Offset: 0x00317FB4
		public IBvbPlayerScore __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006BC4 RID: 27588
		// (get) Token: 0x06015803 RID: 88067 RVA: 0x00319DC4 File Offset: 0x00317FC4
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

		// Token: 0x06015804 RID: 88068 RVA: 0x00319E00 File Offset: 0x00318000
		public static Offset<IBvbPlayerScore> CreateIBvbPlayerScore(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar)
		{
			builder.StartTable(1);
			IBvbPlayerScore.AddType(builder, Type);
			return IBvbPlayerScore.EndIBvbPlayerScore(builder);
		}

		// Token: 0x06015805 RID: 88069 RVA: 0x00319E16 File Offset: 0x00318016
		public static void StartIBvbPlayerScore(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06015806 RID: 88070 RVA: 0x00319E1F File Offset: 0x0031801F
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015807 RID: 88071 RVA: 0x00319E2A File Offset: 0x0031802A
		public static Offset<IBvbPlayerScore> EndIBvbPlayerScore(FlatBufferBuilder builder)
		{
			return new Offset<IBvbPlayerScore>(builder.EndTable());
		}

		// Token: 0x06015808 RID: 88072 RVA: 0x00319E38 File Offset: 0x00318038
		public IBvbPlayerScoreT UnPack()
		{
			IBvbPlayerScoreT bvbPlayerScoreT = new IBvbPlayerScoreT();
			this.UnPackTo(bvbPlayerScoreT);
			return bvbPlayerScoreT;
		}

		// Token: 0x06015809 RID: 88073 RVA: 0x00319E53 File Offset: 0x00318053
		public void UnPackTo(IBvbPlayerScoreT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601580A RID: 88074 RVA: 0x00319E64 File Offset: 0x00318064
		public static Offset<IBvbPlayerScore> Pack(FlatBufferBuilder builder, IBvbPlayerScoreT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbPlayerScore>);
			}
			return IBvbPlayerScore.CreateIBvbPlayerScore(builder, _o.Type);
		}

		// Token: 0x0400B81E RID: 47134
		private Table __p;
	}
}
