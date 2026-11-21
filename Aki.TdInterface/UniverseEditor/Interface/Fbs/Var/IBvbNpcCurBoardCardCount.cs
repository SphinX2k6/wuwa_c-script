using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E47 RID: 15943
	public struct IBvbNpcCurBoardCardCount : IFlatbufferObject
	{
		// Token: 0x17006BAE RID: 27566
		// (get) Token: 0x0601577F RID: 87935 RVA: 0x0031930D File Offset: 0x0031750D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015780 RID: 87936 RVA: 0x0031931A File Offset: 0x0031751A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015781 RID: 87937 RVA: 0x00319324 File Offset: 0x00317524
		public static IBvbNpcCurBoardCardCount GetRootAsIBvbNpcCurBoardCardCount(ByteBuffer _bb)
		{
			return IBvbNpcCurBoardCardCount.GetRootAsIBvbNpcCurBoardCardCount(_bb, default(IBvbNpcCurBoardCardCount));
		}

		// Token: 0x06015782 RID: 87938 RVA: 0x00319340 File Offset: 0x00317540
		public static IBvbNpcCurBoardCardCount GetRootAsIBvbNpcCurBoardCardCount(ByteBuffer _bb, IBvbNpcCurBoardCardCount obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015783 RID: 87939 RVA: 0x0031935D File Offset: 0x0031755D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015784 RID: 87940 RVA: 0x0031936C File Offset: 0x0031756C
		public IBvbNpcCurBoardCardCount __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006BAF RID: 27567
		// (get) Token: 0x06015785 RID: 87941 RVA: 0x0031937C File Offset: 0x0031757C
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

		// Token: 0x06015786 RID: 87942 RVA: 0x003193B8 File Offset: 0x003175B8
		public static Offset<IBvbNpcCurBoardCardCount> CreateIBvbNpcCurBoardCardCount(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar)
		{
			builder.StartTable(1);
			IBvbNpcCurBoardCardCount.AddType(builder, Type);
			return IBvbNpcCurBoardCardCount.EndIBvbNpcCurBoardCardCount(builder);
		}

		// Token: 0x06015787 RID: 87943 RVA: 0x003193CE File Offset: 0x003175CE
		public static void StartIBvbNpcCurBoardCardCount(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06015788 RID: 87944 RVA: 0x003193D7 File Offset: 0x003175D7
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015789 RID: 87945 RVA: 0x003193E2 File Offset: 0x003175E2
		public static Offset<IBvbNpcCurBoardCardCount> EndIBvbNpcCurBoardCardCount(FlatBufferBuilder builder)
		{
			return new Offset<IBvbNpcCurBoardCardCount>(builder.EndTable());
		}

		// Token: 0x0601578A RID: 87946 RVA: 0x003193F0 File Offset: 0x003175F0
		public IBvbNpcCurBoardCardCountT UnPack()
		{
			IBvbNpcCurBoardCardCountT bvbNpcCurBoardCardCountT = new IBvbNpcCurBoardCardCountT();
			this.UnPackTo(bvbNpcCurBoardCardCountT);
			return bvbNpcCurBoardCardCountT;
		}

		// Token: 0x0601578B RID: 87947 RVA: 0x0031940B File Offset: 0x0031760B
		public void UnPackTo(IBvbNpcCurBoardCardCountT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601578C RID: 87948 RVA: 0x0031941C File Offset: 0x0031761C
		public static Offset<IBvbNpcCurBoardCardCount> Pack(FlatBufferBuilder builder, IBvbNpcCurBoardCardCountT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbNpcCurBoardCardCount>);
			}
			return IBvbNpcCurBoardCardCount.CreateIBvbNpcCurBoardCardCount(builder, _o.Type);
		}

		// Token: 0x0400B810 RID: 47120
		private Table __p;
	}
}
