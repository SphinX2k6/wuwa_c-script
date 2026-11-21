using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E53 RID: 15955
	public struct IBvbNpcScore : IFlatbufferObject
	{
		// Token: 0x17006BBA RID: 27578
		// (get) Token: 0x060157C7 RID: 88007 RVA: 0x003198ED File Offset: 0x00317AED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060157C8 RID: 88008 RVA: 0x003198FA File Offset: 0x00317AFA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060157C9 RID: 88009 RVA: 0x00319904 File Offset: 0x00317B04
		public static IBvbNpcScore GetRootAsIBvbNpcScore(ByteBuffer _bb)
		{
			return IBvbNpcScore.GetRootAsIBvbNpcScore(_bb, default(IBvbNpcScore));
		}

		// Token: 0x060157CA RID: 88010 RVA: 0x00319920 File Offset: 0x00317B20
		public static IBvbNpcScore GetRootAsIBvbNpcScore(ByteBuffer _bb, IBvbNpcScore obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060157CB RID: 88011 RVA: 0x0031993D File Offset: 0x00317B3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060157CC RID: 88012 RVA: 0x0031994C File Offset: 0x00317B4C
		public IBvbNpcScore __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006BBB RID: 27579
		// (get) Token: 0x060157CD RID: 88013 RVA: 0x0031995C File Offset: 0x00317B5C
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

		// Token: 0x060157CE RID: 88014 RVA: 0x00319998 File Offset: 0x00317B98
		public static Offset<IBvbNpcScore> CreateIBvbNpcScore(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar)
		{
			builder.StartTable(1);
			IBvbNpcScore.AddType(builder, Type);
			return IBvbNpcScore.EndIBvbNpcScore(builder);
		}

		// Token: 0x060157CF RID: 88015 RVA: 0x003199AE File Offset: 0x00317BAE
		public static void StartIBvbNpcScore(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060157D0 RID: 88016 RVA: 0x003199B7 File Offset: 0x00317BB7
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060157D1 RID: 88017 RVA: 0x003199C2 File Offset: 0x00317BC2
		public static Offset<IBvbNpcScore> EndIBvbNpcScore(FlatBufferBuilder builder)
		{
			return new Offset<IBvbNpcScore>(builder.EndTable());
		}

		// Token: 0x060157D2 RID: 88018 RVA: 0x003199D0 File Offset: 0x00317BD0
		public IBvbNpcScoreT UnPack()
		{
			IBvbNpcScoreT bvbNpcScoreT = new IBvbNpcScoreT();
			this.UnPackTo(bvbNpcScoreT);
			return bvbNpcScoreT;
		}

		// Token: 0x060157D3 RID: 88019 RVA: 0x003199EB File Offset: 0x00317BEB
		public void UnPackTo(IBvbNpcScoreT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060157D4 RID: 88020 RVA: 0x003199FC File Offset: 0x00317BFC
		public static Offset<IBvbNpcScore> Pack(FlatBufferBuilder builder, IBvbNpcScoreT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbNpcScore>);
			}
			return IBvbNpcScore.CreateIBvbNpcScore(builder, _o.Type);
		}

		// Token: 0x0400B818 RID: 47128
		private Table __p;
	}
}
