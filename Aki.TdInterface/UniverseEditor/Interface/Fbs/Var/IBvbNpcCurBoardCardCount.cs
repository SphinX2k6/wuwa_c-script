using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A6C RID: 14956
	public struct IBvbNpcCurBoardCardCount : IFlatbufferObject
	{
		// Token: 0x1700667E RID: 26238
		// (get) Token: 0x06014463 RID: 83043 RVA: 0x002F6121 File Offset: 0x002F4321
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014464 RID: 83044 RVA: 0x002F612E File Offset: 0x002F432E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014465 RID: 83045 RVA: 0x002F6138 File Offset: 0x002F4338
		public static IBvbNpcCurBoardCardCount GetRootAsIBvbNpcCurBoardCardCount(ByteBuffer _bb)
		{
			return IBvbNpcCurBoardCardCount.GetRootAsIBvbNpcCurBoardCardCount(_bb, default(IBvbNpcCurBoardCardCount));
		}

		// Token: 0x06014466 RID: 83046 RVA: 0x002F6154 File Offset: 0x002F4354
		public static IBvbNpcCurBoardCardCount GetRootAsIBvbNpcCurBoardCardCount(ByteBuffer _bb, IBvbNpcCurBoardCardCount obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014467 RID: 83047 RVA: 0x002F6171 File Offset: 0x002F4371
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014468 RID: 83048 RVA: 0x002F6180 File Offset: 0x002F4380
		public IBvbNpcCurBoardCardCount __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700667F RID: 26239
		// (get) Token: 0x06014469 RID: 83049 RVA: 0x002F6190 File Offset: 0x002F4390
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

		// Token: 0x0601446A RID: 83050 RVA: 0x002F61CC File Offset: 0x002F43CC
		public static Offset<IBvbNpcCurBoardCardCount> CreateIBvbNpcCurBoardCardCount(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar)
		{
			builder.StartTable(1);
			IBvbNpcCurBoardCardCount.AddType(builder, Type);
			return IBvbNpcCurBoardCardCount.EndIBvbNpcCurBoardCardCount(builder);
		}

		// Token: 0x0601446B RID: 83051 RVA: 0x002F61E2 File Offset: 0x002F43E2
		public static void StartIBvbNpcCurBoardCardCount(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601446C RID: 83052 RVA: 0x002F61EB File Offset: 0x002F43EB
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601446D RID: 83053 RVA: 0x002F61F6 File Offset: 0x002F43F6
		public static Offset<IBvbNpcCurBoardCardCount> EndIBvbNpcCurBoardCardCount(FlatBufferBuilder builder)
		{
			return new Offset<IBvbNpcCurBoardCardCount>(builder.EndTable());
		}

		// Token: 0x0601446E RID: 83054 RVA: 0x002F6204 File Offset: 0x002F4404
		public IBvbNpcCurBoardCardCountT UnPack()
		{
			IBvbNpcCurBoardCardCountT bvbNpcCurBoardCardCountT = new IBvbNpcCurBoardCardCountT();
			this.UnPackTo(bvbNpcCurBoardCardCountT);
			return bvbNpcCurBoardCardCountT;
		}

		// Token: 0x0601446F RID: 83055 RVA: 0x002F621F File Offset: 0x002F441F
		public void UnPackTo(IBvbNpcCurBoardCardCountT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06014470 RID: 83056 RVA: 0x002F6230 File Offset: 0x002F4430
		public static Offset<IBvbNpcCurBoardCardCount> Pack(FlatBufferBuilder builder, IBvbNpcCurBoardCardCountT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbNpcCurBoardCardCount>);
			}
			return IBvbNpcCurBoardCardCount.CreateIBvbNpcCurBoardCardCount(builder, _o.Type);
		}

		// Token: 0x0400AEEE RID: 44782
		private Table __p;
	}
}
