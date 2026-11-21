using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E23 RID: 15907
	public struct IBvbCurRound : IFlatbufferObject
	{
		// Token: 0x17006B78 RID: 27512
		// (get) Token: 0x06015666 RID: 87654 RVA: 0x0031731C File Offset: 0x0031551C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015667 RID: 87655 RVA: 0x00317329 File Offset: 0x00315529
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015668 RID: 87656 RVA: 0x00317330 File Offset: 0x00315530
		public static IBvbCurRound GetRootAsIBvbCurRound(ByteBuffer _bb)
		{
			return IBvbCurRound.GetRootAsIBvbCurRound(_bb, default(IBvbCurRound));
		}

		// Token: 0x06015669 RID: 87657 RVA: 0x0031734C File Offset: 0x0031554C
		public static IBvbCurRound GetRootAsIBvbCurRound(ByteBuffer _bb, IBvbCurRound obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601566A RID: 87658 RVA: 0x00317369 File Offset: 0x00315569
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601566B RID: 87659 RVA: 0x00317378 File Offset: 0x00315578
		public IBvbCurRound __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B79 RID: 27513
		// (get) Token: 0x0601566C RID: 87660 RVA: 0x00317388 File Offset: 0x00315588
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

		// Token: 0x0601566D RID: 87661 RVA: 0x003173C4 File Offset: 0x003155C4
		public static Offset<IBvbCurRound> CreateIBvbCurRound(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar)
		{
			builder.StartTable(1);
			IBvbCurRound.AddType(builder, Type);
			return IBvbCurRound.EndIBvbCurRound(builder);
		}

		// Token: 0x0601566E RID: 87662 RVA: 0x003173DA File Offset: 0x003155DA
		public static void StartIBvbCurRound(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601566F RID: 87663 RVA: 0x003173E3 File Offset: 0x003155E3
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015670 RID: 87664 RVA: 0x003173EE File Offset: 0x003155EE
		public static Offset<IBvbCurRound> EndIBvbCurRound(FlatBufferBuilder builder)
		{
			return new Offset<IBvbCurRound>(builder.EndTable());
		}

		// Token: 0x06015671 RID: 87665 RVA: 0x003173FC File Offset: 0x003155FC
		public IBvbCurRoundT UnPack()
		{
			IBvbCurRoundT bvbCurRoundT = new IBvbCurRoundT();
			this.UnPackTo(bvbCurRoundT);
			return bvbCurRoundT;
		}

		// Token: 0x06015672 RID: 87666 RVA: 0x00317417 File Offset: 0x00315617
		public void UnPackTo(IBvbCurRoundT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06015673 RID: 87667 RVA: 0x00317428 File Offset: 0x00315628
		public static Offset<IBvbCurRound> Pack(FlatBufferBuilder builder, IBvbCurRoundT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbCurRound>);
			}
			return IBvbCurRound.CreateIBvbCurRound(builder, _o.Type);
		}

		// Token: 0x0400B7EF RID: 47087
		private Table __p;
	}
}
