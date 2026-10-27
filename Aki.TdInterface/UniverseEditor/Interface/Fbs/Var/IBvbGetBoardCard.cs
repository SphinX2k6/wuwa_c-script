using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A57 RID: 14935
	public struct IBvbGetBoardCard : IFlatbufferObject
	{
		// Token: 0x17006661 RID: 26209
		// (get) Token: 0x060143C0 RID: 82880 RVA: 0x002F4C8C File Offset: 0x002F2E8C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060143C1 RID: 82881 RVA: 0x002F4C99 File Offset: 0x002F2E99
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060143C2 RID: 82882 RVA: 0x002F4CA0 File Offset: 0x002F2EA0
		public static IBvbGetBoardCard GetRootAsIBvbGetBoardCard(ByteBuffer _bb)
		{
			return IBvbGetBoardCard.GetRootAsIBvbGetBoardCard(_bb, default(IBvbGetBoardCard));
		}

		// Token: 0x060143C3 RID: 82883 RVA: 0x002F4CBC File Offset: 0x002F2EBC
		public static IBvbGetBoardCard GetRootAsIBvbGetBoardCard(ByteBuffer _bb, IBvbGetBoardCard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060143C4 RID: 82884 RVA: 0x002F4CD9 File Offset: 0x002F2ED9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060143C5 RID: 82885 RVA: 0x002F4CE8 File Offset: 0x002F2EE8
		public IBvbGetBoardCard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006662 RID: 26210
		// (get) Token: 0x060143C6 RID: 82886 RVA: 0x002F4CF8 File Offset: 0x002F2EF8
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

		// Token: 0x17006663 RID: 26211
		// (get) Token: 0x060143C7 RID: 82887 RVA: 0x002F4D34 File Offset: 0x002F2F34
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

		// Token: 0x060143C8 RID: 82888 RVA: 0x002F4D91 File Offset: 0x002F2F91
		public static Offset<IBvbGetBoardCard> CreateIBvbGetBoardCard(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar, Offset<IBvbCardFilterGroup> ConditionOffset = default(Offset<IBvbCardFilterGroup>))
		{
			builder.StartTable(2);
			IBvbGetBoardCard.AddCondition(builder, ConditionOffset);
			IBvbGetBoardCard.AddType(builder, Type);
			return IBvbGetBoardCard.EndIBvbGetBoardCard(builder);
		}

		// Token: 0x060143C9 RID: 82889 RVA: 0x002F4DAE File Offset: 0x002F2FAE
		public static void StartIBvbGetBoardCard(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060143CA RID: 82890 RVA: 0x002F4DB7 File Offset: 0x002F2FB7
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060143CB RID: 82891 RVA: 0x002F4DC2 File Offset: 0x002F2FC2
		public static void AddCondition(FlatBufferBuilder builder, Offset<IBvbCardFilterGroup> conditionOffset)
		{
			builder.AddOffset(1, conditionOffset.Value, 0);
		}

		// Token: 0x060143CC RID: 82892 RVA: 0x002F4DD2 File Offset: 0x002F2FD2
		public static Offset<IBvbGetBoardCard> EndIBvbGetBoardCard(FlatBufferBuilder builder)
		{
			return new Offset<IBvbGetBoardCard>(builder.EndTable());
		}

		// Token: 0x060143CD RID: 82893 RVA: 0x002F4DE0 File Offset: 0x002F2FE0
		public IBvbGetBoardCardT UnPack()
		{
			IBvbGetBoardCardT bvbGetBoardCardT = new IBvbGetBoardCardT();
			this.UnPackTo(bvbGetBoardCardT);
			return bvbGetBoardCardT;
		}

		// Token: 0x060143CE RID: 82894 RVA: 0x002F4DFC File Offset: 0x002F2FFC
		public void UnPackTo(IBvbGetBoardCardT _o)
		{
			_o.Type = this.Type;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
		}

		// Token: 0x060143CF RID: 82895 RVA: 0x002F4E44 File Offset: 0x002F3044
		public static Offset<IBvbGetBoardCard> Pack(FlatBufferBuilder builder, IBvbGetBoardCardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbGetBoardCard>);
			}
			Offset<IBvbCardFilterGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IBvbCardFilterGroup>) : IBvbCardFilterGroup.Pack(builder, _o.Condition);
			return IBvbGetBoardCard.CreateIBvbGetBoardCard(builder, _o.Type, conditionOffset);
		}

		// Token: 0x0400AEDC RID: 44764
		private Table __p;
	}
}
