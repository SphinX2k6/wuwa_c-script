using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E2F RID: 15919
	public struct IBvbFetchHandCard : IFlatbufferObject
	{
		// Token: 0x17006B8C RID: 27532
		// (get) Token: 0x060156C6 RID: 87750 RVA: 0x00317BE9 File Offset: 0x00315DE9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060156C7 RID: 87751 RVA: 0x00317BF6 File Offset: 0x00315DF6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060156C8 RID: 87752 RVA: 0x00317C00 File Offset: 0x00315E00
		public static IBvbFetchHandCard GetRootAsIBvbFetchHandCard(ByteBuffer _bb)
		{
			return IBvbFetchHandCard.GetRootAsIBvbFetchHandCard(_bb, default(IBvbFetchHandCard));
		}

		// Token: 0x060156C9 RID: 87753 RVA: 0x00317C1C File Offset: 0x00315E1C
		public static IBvbFetchHandCard GetRootAsIBvbFetchHandCard(ByteBuffer _bb, IBvbFetchHandCard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060156CA RID: 87754 RVA: 0x00317C39 File Offset: 0x00315E39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060156CB RID: 87755 RVA: 0x00317C48 File Offset: 0x00315E48
		public IBvbFetchHandCard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B8D RID: 27533
		// (get) Token: 0x060156CC RID: 87756 RVA: 0x00317C58 File Offset: 0x00315E58
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

		// Token: 0x17006B8E RID: 27534
		// (get) Token: 0x060156CD RID: 87757 RVA: 0x00317C94 File Offset: 0x00315E94
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

		// Token: 0x060156CE RID: 87758 RVA: 0x00317CF1 File Offset: 0x00315EF1
		public static Offset<IBvbFetchHandCard> CreateIBvbFetchHandCard(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar, Offset<IBvbCardFilterGroup> ConditionOffset = default(Offset<IBvbCardFilterGroup>))
		{
			builder.StartTable(2);
			IBvbFetchHandCard.AddCondition(builder, ConditionOffset);
			IBvbFetchHandCard.AddType(builder, Type);
			return IBvbFetchHandCard.EndIBvbFetchHandCard(builder);
		}

		// Token: 0x060156CF RID: 87759 RVA: 0x00317D0E File Offset: 0x00315F0E
		public static void StartIBvbFetchHandCard(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060156D0 RID: 87760 RVA: 0x00317D17 File Offset: 0x00315F17
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060156D1 RID: 87761 RVA: 0x00317D22 File Offset: 0x00315F22
		public static void AddCondition(FlatBufferBuilder builder, Offset<IBvbCardFilterGroup> conditionOffset)
		{
			builder.AddOffset(1, conditionOffset.Value, 0);
		}

		// Token: 0x060156D2 RID: 87762 RVA: 0x00317D32 File Offset: 0x00315F32
		public static Offset<IBvbFetchHandCard> EndIBvbFetchHandCard(FlatBufferBuilder builder)
		{
			return new Offset<IBvbFetchHandCard>(builder.EndTable());
		}

		// Token: 0x060156D3 RID: 87763 RVA: 0x00317D40 File Offset: 0x00315F40
		public IBvbFetchHandCardT UnPack()
		{
			IBvbFetchHandCardT bvbFetchHandCardT = new IBvbFetchHandCardT();
			this.UnPackTo(bvbFetchHandCardT);
			return bvbFetchHandCardT;
		}

		// Token: 0x060156D4 RID: 87764 RVA: 0x00317D5C File Offset: 0x00315F5C
		public void UnPackTo(IBvbFetchHandCardT _o)
		{
			_o.Type = this.Type;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
		}

		// Token: 0x060156D5 RID: 87765 RVA: 0x00317DA4 File Offset: 0x00315FA4
		public static Offset<IBvbFetchHandCard> Pack(FlatBufferBuilder builder, IBvbFetchHandCardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbFetchHandCard>);
			}
			Offset<IBvbCardFilterGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IBvbCardFilterGroup>) : IBvbCardFilterGroup.Pack(builder, _o.Condition);
			return IBvbFetchHandCard.CreateIBvbFetchHandCard(builder, _o.Type, conditionOffset);
		}

		// Token: 0x0400B7FB RID: 47099
		private Table __p;
	}
}
