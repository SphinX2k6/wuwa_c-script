using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068B3 RID: 26803
	public struct IBvbEndTurn : IFlatbufferObject
	{
		// Token: 0x1700C4FF RID: 50431
		// (get) Token: 0x0602DD51 RID: 187729 RVA: 0x00643686 File Offset: 0x00641886
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DD52 RID: 187730 RVA: 0x00643693 File Offset: 0x00641893
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DD53 RID: 187731 RVA: 0x0064369C File Offset: 0x0064189C
		public static IBvbEndTurn GetRootAsIBvbEndTurn(ByteBuffer _bb)
		{
			return IBvbEndTurn.GetRootAsIBvbEndTurn(_bb, default(IBvbEndTurn));
		}

		// Token: 0x0602DD54 RID: 187732 RVA: 0x006436B8 File Offset: 0x006418B8
		public static IBvbEndTurn GetRootAsIBvbEndTurn(ByteBuffer _bb, IBvbEndTurn obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DD55 RID: 187733 RVA: 0x006436D5 File Offset: 0x006418D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DD56 RID: 187734 RVA: 0x006436E4 File Offset: 0x006418E4
		public IBvbEndTurn __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C500 RID: 50432
		// (get) Token: 0x0602DD57 RID: 187735 RVA: 0x006436F4 File Offset: 0x006418F4
		public EBvbPlayerOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBvbPlayerOperationType.BvbDeploy;
				}
				return (EBvbPlayerOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DD58 RID: 187736 RVA: 0x00643730 File Offset: 0x00641930
		public static Offset<IBvbEndTurn> CreateIBvbEndTurn(FlatBufferBuilder builder, EBvbPlayerOperationType Type = EBvbPlayerOperationType.BvbDeploy)
		{
			builder.StartTable(1);
			IBvbEndTurn.AddType(builder, Type);
			return IBvbEndTurn.EndIBvbEndTurn(builder);
		}

		// Token: 0x0602DD59 RID: 187737 RVA: 0x00643746 File Offset: 0x00641946
		public static void StartIBvbEndTurn(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602DD5A RID: 187738 RVA: 0x0064374F File Offset: 0x0064194F
		public static void AddType(FlatBufferBuilder builder, EBvbPlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DD5B RID: 187739 RVA: 0x0064375A File Offset: 0x0064195A
		public static Offset<IBvbEndTurn> EndIBvbEndTurn(FlatBufferBuilder builder)
		{
			return new Offset<IBvbEndTurn>(builder.EndTable());
		}

		// Token: 0x0602DD5C RID: 187740 RVA: 0x00643768 File Offset: 0x00641968
		public IBvbEndTurnT UnPack()
		{
			IBvbEndTurnT bvbEndTurnT = new IBvbEndTurnT();
			this.UnPackTo(bvbEndTurnT);
			return bvbEndTurnT;
		}

		// Token: 0x0602DD5D RID: 187741 RVA: 0x00643783 File Offset: 0x00641983
		public void UnPackTo(IBvbEndTurnT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602DD5E RID: 187742 RVA: 0x00643794 File Offset: 0x00641994
		public static Offset<IBvbEndTurn> Pack(FlatBufferBuilder builder, IBvbEndTurnT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbEndTurn>);
			}
			return IBvbEndTurn.CreateIBvbEndTurn(builder, _o.Type);
		}

		// Token: 0x040115A2 RID: 71074
		private Table __p;
	}
}
