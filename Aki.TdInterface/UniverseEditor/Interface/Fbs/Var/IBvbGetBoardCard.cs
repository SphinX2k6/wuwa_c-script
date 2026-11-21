using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E32 RID: 15922
	public struct IBvbGetBoardCard : IFlatbufferObject
	{
		// Token: 0x17006B91 RID: 27537
		// (get) Token: 0x060156DC RID: 87772 RVA: 0x00317E78 File Offset: 0x00316078
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060156DD RID: 87773 RVA: 0x00317E85 File Offset: 0x00316085
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060156DE RID: 87774 RVA: 0x00317E8C File Offset: 0x0031608C
		public static IBvbGetBoardCard GetRootAsIBvbGetBoardCard(ByteBuffer _bb)
		{
			return IBvbGetBoardCard.GetRootAsIBvbGetBoardCard(_bb, default(IBvbGetBoardCard));
		}

		// Token: 0x060156DF RID: 87775 RVA: 0x00317EA8 File Offset: 0x003160A8
		public static IBvbGetBoardCard GetRootAsIBvbGetBoardCard(ByteBuffer _bb, IBvbGetBoardCard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060156E0 RID: 87776 RVA: 0x00317EC5 File Offset: 0x003160C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060156E1 RID: 87777 RVA: 0x00317ED4 File Offset: 0x003160D4
		public IBvbGetBoardCard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B92 RID: 27538
		// (get) Token: 0x060156E2 RID: 87778 RVA: 0x00317EE4 File Offset: 0x003160E4
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

		// Token: 0x17006B93 RID: 27539
		// (get) Token: 0x060156E3 RID: 87779 RVA: 0x00317F20 File Offset: 0x00316120
		public IBvbCardFilterGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IBvbCardFilterGroup?(default(IBvbCardFilterGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060156E4 RID: 87780 RVA: 0x00317F7D File Offset: 0x0031617D
		public static Offset<IBvbGetBoardCard> CreateIBvbGetBoardCard(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar, Offset<IBvbCardFilterGroup> ConditionOffset = default(Offset<IBvbCardFilterGroup>))
		{
			builder.StartTable(2);
			IBvbGetBoardCard.AddCondition(builder, ConditionOffset);
			IBvbGetBoardCard.AddType(builder, Type);
			return IBvbGetBoardCard.EndIBvbGetBoardCard(builder);
		}

		// Token: 0x060156E5 RID: 87781 RVA: 0x00317F9A File Offset: 0x0031619A
		public static void StartIBvbGetBoardCard(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060156E6 RID: 87782 RVA: 0x00317FA3 File Offset: 0x003161A3
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060156E7 RID: 87783 RVA: 0x00317FAE File Offset: 0x003161AE
		public static void AddCondition(FlatBufferBuilder builder, Offset<IBvbCardFilterGroup> conditionOffset)
		{
			builder.AddOffset(1, conditionOffset.Value, 0);
		}

		// Token: 0x060156E8 RID: 87784 RVA: 0x00317FBE File Offset: 0x003161BE
		public static Offset<IBvbGetBoardCard> EndIBvbGetBoardCard(FlatBufferBuilder builder)
		{
			return new Offset<IBvbGetBoardCard>(builder.EndTable());
		}

		// Token: 0x060156E9 RID: 87785 RVA: 0x00317FCC File Offset: 0x003161CC
		public IBvbGetBoardCardT UnPack()
		{
			IBvbGetBoardCardT bvbGetBoardCardT = new IBvbGetBoardCardT();
			this.UnPackTo(bvbGetBoardCardT);
			return bvbGetBoardCardT;
		}

		// Token: 0x060156EA RID: 87786 RVA: 0x00317FE8 File Offset: 0x003161E8
		public void UnPackTo(IBvbGetBoardCardT _o)
		{
			_o.Type = this.Type;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
		}

		// Token: 0x060156EB RID: 87787 RVA: 0x00318030 File Offset: 0x00316230
		public static Offset<IBvbGetBoardCard> Pack(FlatBufferBuilder builder, IBvbGetBoardCardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbGetBoardCard>);
			}
			Offset<IBvbCardFilterGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IBvbCardFilterGroup>) : IBvbCardFilterGroup.Pack(builder, _o.Condition);
			return IBvbGetBoardCard.CreateIBvbGetBoardCard(builder, _o.Type, conditionOffset);
		}

		// Token: 0x0400B7FE RID: 47102
		private Table __p;
	}
}
