using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E41 RID: 15937
	public struct IBvbMaxRound : IFlatbufferObject
	{
		// Token: 0x17006BA8 RID: 27560
		// (get) Token: 0x0601575B RID: 87899 RVA: 0x0031901D File Offset: 0x0031721D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601575C RID: 87900 RVA: 0x0031902A File Offset: 0x0031722A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601575D RID: 87901 RVA: 0x00319034 File Offset: 0x00317234
		public static IBvbMaxRound GetRootAsIBvbMaxRound(ByteBuffer _bb)
		{
			return IBvbMaxRound.GetRootAsIBvbMaxRound(_bb, default(IBvbMaxRound));
		}

		// Token: 0x0601575E RID: 87902 RVA: 0x00319050 File Offset: 0x00317250
		public static IBvbMaxRound GetRootAsIBvbMaxRound(ByteBuffer _bb, IBvbMaxRound obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601575F RID: 87903 RVA: 0x0031906D File Offset: 0x0031726D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015760 RID: 87904 RVA: 0x0031907C File Offset: 0x0031727C
		public IBvbMaxRound __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006BA9 RID: 27561
		// (get) Token: 0x06015761 RID: 87905 RVA: 0x0031908C File Offset: 0x0031728C
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

		// Token: 0x06015762 RID: 87906 RVA: 0x003190C8 File Offset: 0x003172C8
		public static Offset<IBvbMaxRound> CreateIBvbMaxRound(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar)
		{
			builder.StartTable(1);
			IBvbMaxRound.AddType(builder, Type);
			return IBvbMaxRound.EndIBvbMaxRound(builder);
		}

		// Token: 0x06015763 RID: 87907 RVA: 0x003190DE File Offset: 0x003172DE
		public static void StartIBvbMaxRound(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06015764 RID: 87908 RVA: 0x003190E7 File Offset: 0x003172E7
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015765 RID: 87909 RVA: 0x003190F2 File Offset: 0x003172F2
		public static Offset<IBvbMaxRound> EndIBvbMaxRound(FlatBufferBuilder builder)
		{
			return new Offset<IBvbMaxRound>(builder.EndTable());
		}

		// Token: 0x06015766 RID: 87910 RVA: 0x00319100 File Offset: 0x00317300
		public IBvbMaxRoundT UnPack()
		{
			IBvbMaxRoundT bvbMaxRoundT = new IBvbMaxRoundT();
			this.UnPackTo(bvbMaxRoundT);
			return bvbMaxRoundT;
		}

		// Token: 0x06015767 RID: 87911 RVA: 0x0031911B File Offset: 0x0031731B
		public void UnPackTo(IBvbMaxRoundT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06015768 RID: 87912 RVA: 0x0031912C File Offset: 0x0031732C
		public static Offset<IBvbMaxRound> Pack(FlatBufferBuilder builder, IBvbMaxRoundT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbMaxRound>);
			}
			return IBvbMaxRound.CreateIBvbMaxRound(builder, _o.Type);
		}

		// Token: 0x0400B80C RID: 47116
		private Table __p;
	}
}
