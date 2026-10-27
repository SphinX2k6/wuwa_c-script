using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006242 RID: 25154
	public struct IBvbEndTurn : IFlatbufferObject
	{
		// Token: 0x1700BB77 RID: 47991
		// (get) Token: 0x0602B5F0 RID: 177648 RVA: 0x005F887E File Offset: 0x005F6A7E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B5F1 RID: 177649 RVA: 0x005F888B File Offset: 0x005F6A8B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B5F2 RID: 177650 RVA: 0x005F8894 File Offset: 0x005F6A94
		public static IBvbEndTurn GetRootAsIBvbEndTurn(ByteBuffer _bb)
		{
			return IBvbEndTurn.GetRootAsIBvbEndTurn(_bb, default(IBvbEndTurn));
		}

		// Token: 0x0602B5F3 RID: 177651 RVA: 0x005F88B0 File Offset: 0x005F6AB0
		public static IBvbEndTurn GetRootAsIBvbEndTurn(ByteBuffer _bb, IBvbEndTurn obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B5F4 RID: 177652 RVA: 0x005F88CD File Offset: 0x005F6ACD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B5F5 RID: 177653 RVA: 0x005F88DC File Offset: 0x005F6ADC
		public IBvbEndTurn __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BB78 RID: 47992
		// (get) Token: 0x0602B5F6 RID: 177654 RVA: 0x005F88EC File Offset: 0x005F6AEC
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

		// Token: 0x0602B5F7 RID: 177655 RVA: 0x005F8928 File Offset: 0x005F6B28
		public static Offset<IBvbEndTurn> CreateIBvbEndTurn(FlatBufferBuilder builder, EBvbPlayerOperationType Type = EBvbPlayerOperationType.BvbDeploy)
		{
			builder.StartTable(1);
			IBvbEndTurn.AddType(builder, Type);
			return IBvbEndTurn.EndIBvbEndTurn(builder);
		}

		// Token: 0x0602B5F8 RID: 177656 RVA: 0x005F893E File Offset: 0x005F6B3E
		public static void StartIBvbEndTurn(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B5F9 RID: 177657 RVA: 0x005F8947 File Offset: 0x005F6B47
		public static void AddType(FlatBufferBuilder builder, EBvbPlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B5FA RID: 177658 RVA: 0x005F8952 File Offset: 0x005F6B52
		public static Offset<IBvbEndTurn> EndIBvbEndTurn(FlatBufferBuilder builder)
		{
			return new Offset<IBvbEndTurn>(builder.EndTable());
		}

		// Token: 0x0602B5FB RID: 177659 RVA: 0x005F8960 File Offset: 0x005F6B60
		public IBvbEndTurnT UnPack()
		{
			IBvbEndTurnT bvbEndTurnT = new IBvbEndTurnT();
			this.UnPackTo(bvbEndTurnT);
			return bvbEndTurnT;
		}

		// Token: 0x0602B5FC RID: 177660 RVA: 0x005F897B File Offset: 0x005F6B7B
		public void UnPackTo(IBvbEndTurnT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B5FD RID: 177661 RVA: 0x005F898C File Offset: 0x005F6B8C
		public static Offset<IBvbEndTurn> Pack(FlatBufferBuilder builder, IBvbEndTurnT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbEndTurn>);
			}
			return IBvbEndTurn.CreateIBvbEndTurn(builder, _o.Type);
		}

		// Token: 0x0401078D RID: 67469
		private Table __p;
	}
}
