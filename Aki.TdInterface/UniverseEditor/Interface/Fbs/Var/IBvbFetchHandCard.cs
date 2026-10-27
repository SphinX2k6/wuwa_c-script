using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A54 RID: 14932
	public struct IBvbFetchHandCard : IFlatbufferObject
	{
		// Token: 0x1700665C RID: 26204
		// (get) Token: 0x060143AA RID: 82858 RVA: 0x002F49FD File Offset: 0x002F2BFD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060143AB RID: 82859 RVA: 0x002F4A0A File Offset: 0x002F2C0A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060143AC RID: 82860 RVA: 0x002F4A14 File Offset: 0x002F2C14
		public static IBvbFetchHandCard GetRootAsIBvbFetchHandCard(ByteBuffer _bb)
		{
			return IBvbFetchHandCard.GetRootAsIBvbFetchHandCard(_bb, default(IBvbFetchHandCard));
		}

		// Token: 0x060143AD RID: 82861 RVA: 0x002F4A30 File Offset: 0x002F2C30
		public static IBvbFetchHandCard GetRootAsIBvbFetchHandCard(ByteBuffer _bb, IBvbFetchHandCard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060143AE RID: 82862 RVA: 0x002F4A4D File Offset: 0x002F2C4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060143AF RID: 82863 RVA: 0x002F4A5C File Offset: 0x002F2C5C
		public IBvbFetchHandCard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700665D RID: 26205
		// (get) Token: 0x060143B0 RID: 82864 RVA: 0x002F4A6C File Offset: 0x002F2C6C
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

		// Token: 0x1700665E RID: 26206
		// (get) Token: 0x060143B1 RID: 82865 RVA: 0x002F4AA8 File Offset: 0x002F2CA8
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

		// Token: 0x060143B2 RID: 82866 RVA: 0x002F4B05 File Offset: 0x002F2D05
		public static Offset<IBvbFetchHandCard> CreateIBvbFetchHandCard(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar, Offset<IBvbCardFilterGroup> ConditionOffset = default(Offset<IBvbCardFilterGroup>))
		{
			builder.StartTable(2);
			IBvbFetchHandCard.AddCondition(builder, ConditionOffset);
			IBvbFetchHandCard.AddType(builder, Type);
			return IBvbFetchHandCard.EndIBvbFetchHandCard(builder);
		}

		// Token: 0x060143B3 RID: 82867 RVA: 0x002F4B22 File Offset: 0x002F2D22
		public static void StartIBvbFetchHandCard(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060143B4 RID: 82868 RVA: 0x002F4B2B File Offset: 0x002F2D2B
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060143B5 RID: 82869 RVA: 0x002F4B36 File Offset: 0x002F2D36
		public static void AddCondition(FlatBufferBuilder builder, Offset<IBvbCardFilterGroup> conditionOffset)
		{
			builder.AddOffset(1, conditionOffset.Value, 0);
		}

		// Token: 0x060143B6 RID: 82870 RVA: 0x002F4B46 File Offset: 0x002F2D46
		public static Offset<IBvbFetchHandCard> EndIBvbFetchHandCard(FlatBufferBuilder builder)
		{
			return new Offset<IBvbFetchHandCard>(builder.EndTable());
		}

		// Token: 0x060143B7 RID: 82871 RVA: 0x002F4B54 File Offset: 0x002F2D54
		public IBvbFetchHandCardT UnPack()
		{
			IBvbFetchHandCardT bvbFetchHandCardT = new IBvbFetchHandCardT();
			this.UnPackTo(bvbFetchHandCardT);
			return bvbFetchHandCardT;
		}

		// Token: 0x060143B8 RID: 82872 RVA: 0x002F4B70 File Offset: 0x002F2D70
		public void UnPackTo(IBvbFetchHandCardT _o)
		{
			_o.Type = this.Type;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
		}

		// Token: 0x060143B9 RID: 82873 RVA: 0x002F4BB8 File Offset: 0x002F2DB8
		public static Offset<IBvbFetchHandCard> Pack(FlatBufferBuilder builder, IBvbFetchHandCardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbFetchHandCard>);
			}
			Offset<IBvbCardFilterGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IBvbCardFilterGroup>) : IBvbCardFilterGroup.Pack(builder, _o.Condition);
			return IBvbFetchHandCard.CreateIBvbFetchHandCard(builder, _o.Type, conditionOffset);
		}

		// Token: 0x0400AED9 RID: 44761
		private Table __p;
	}
}
