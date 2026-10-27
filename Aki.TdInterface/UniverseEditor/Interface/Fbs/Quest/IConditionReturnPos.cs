using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DAF RID: 15791
	public struct IConditionReturnPos : IFlatbufferObject
	{
		// Token: 0x17006CB1 RID: 27825
		// (get) Token: 0x06015F72 RID: 89970 RVA: 0x0032BFF2 File Offset: 0x0032A1F2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015F73 RID: 89971 RVA: 0x0032BFFF File Offset: 0x0032A1FF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015F74 RID: 89972 RVA: 0x0032C008 File Offset: 0x0032A208
		public static IConditionReturnPos GetRootAsIConditionReturnPos(ByteBuffer _bb)
		{
			return IConditionReturnPos.GetRootAsIConditionReturnPos(_bb, default(IConditionReturnPos));
		}

		// Token: 0x06015F75 RID: 89973 RVA: 0x0032C024 File Offset: 0x0032A224
		public static IConditionReturnPos GetRootAsIConditionReturnPos(ByteBuffer _bb, IConditionReturnPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015F76 RID: 89974 RVA: 0x0032C041 File Offset: 0x0032A241
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015F77 RID: 89975 RVA: 0x0032C050 File Offset: 0x0032A250
		public IConditionReturnPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006CB2 RID: 27826
		// (get) Token: 0x06015F78 RID: 89976 RVA: 0x0032C060 File Offset: 0x0032A260
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17006CB3 RID: 27827
		// (get) Token: 0x06015F79 RID: 89977 RVA: 0x0032C0C0 File Offset: 0x0032A2C0
		public TFastReturnPos PosType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TFastReturnPos.NONE;
				}
				return (TFastReturnPos)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015F7A RID: 89978 RVA: 0x0032C0FC File Offset: 0x0032A2FC
		public TTable? Pos<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06015F7B RID: 89979 RVA: 0x0032C140 File Offset: 0x0032A340
		public IFastReturnEntityPos PosAsIFastReturnEntityPos()
		{
			return this.Pos<IFastReturnEntityPos>().Value;
		}

		// Token: 0x06015F7C RID: 89980 RVA: 0x0032C15C File Offset: 0x0032A35C
		public IFastReturnGravityEntityPos PosAsIFastReturnGravityEntityPos()
		{
			return this.Pos<IFastReturnGravityEntityPos>().Value;
		}

		// Token: 0x06015F7D RID: 89981 RVA: 0x0032C177 File Offset: 0x0032A377
		public static Offset<IConditionReturnPos> CreateIConditionReturnPos(FlatBufferBuilder builder, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), TFastReturnPos Pos_type = TFastReturnPos.NONE, int PosOffset = 0)
		{
			builder.StartTable(3);
			IConditionReturnPos.AddPos(builder, PosOffset);
			IConditionReturnPos.AddCondition(builder, ConditionOffset);
			IConditionReturnPos.AddPosType(builder, Pos_type);
			return IConditionReturnPos.EndIConditionReturnPos(builder);
		}

		// Token: 0x06015F7E RID: 89982 RVA: 0x0032C19B File Offset: 0x0032A39B
		public static void StartIConditionReturnPos(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06015F7F RID: 89983 RVA: 0x0032C1A4 File Offset: 0x0032A3A4
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x06015F80 RID: 89984 RVA: 0x0032C1B4 File Offset: 0x0032A3B4
		public static void AddPosType(FlatBufferBuilder builder, TFastReturnPos posType)
		{
			builder.AddByte(1, (byte)posType, 0);
		}

		// Token: 0x06015F81 RID: 89985 RVA: 0x0032C1BF File Offset: 0x0032A3BF
		public static void AddPos(FlatBufferBuilder builder, int posOffset)
		{
			builder.AddOffset(2, posOffset, 0);
		}

		// Token: 0x06015F82 RID: 89986 RVA: 0x0032C1CA File Offset: 0x0032A3CA
		public static Offset<IConditionReturnPos> EndIConditionReturnPos(FlatBufferBuilder builder)
		{
			return new Offset<IConditionReturnPos>(builder.EndTable());
		}

		// Token: 0x06015F83 RID: 89987 RVA: 0x0032C1D8 File Offset: 0x0032A3D8
		public IConditionReturnPosT UnPack()
		{
			IConditionReturnPosT conditionReturnPosT = new IConditionReturnPosT();
			this.UnPackTo(conditionReturnPosT);
			return conditionReturnPosT;
		}

		// Token: 0x06015F84 RID: 89988 RVA: 0x0032C1F4 File Offset: 0x0032A3F4
		public void UnPackTo(IConditionReturnPosT _o)
		{
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.Pos = new TFastReturnPosUnion();
			_o.Pos.Type = this.PosType;
			TFastReturnPos posType = this.PosType;
			if (posType == TFastReturnPos.IFastReturnEntityPos)
			{
				_o.Pos.Value = ((this.Pos<IFastReturnEntityPos>() != null) ? this.Pos<IFastReturnEntityPos>().Value.UnPack() : null);
				return;
			}
			if (posType != TFastReturnPos.IFastReturnGravityEntityPos)
			{
				return;
			}
			_o.Pos.Value = ((this.Pos<IFastReturnGravityEntityPos>() != null) ? this.Pos<IFastReturnGravityEntityPos>().Value.UnPack() : null);
		}

		// Token: 0x06015F85 RID: 89989 RVA: 0x0032C2CC File Offset: 0x0032A4CC
		public static Offset<IConditionReturnPos> Pack(FlatBufferBuilder builder, IConditionReturnPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConditionReturnPos>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			TFastReturnPos pos_type = (_o.Pos == null) ? TFastReturnPos.NONE : _o.Pos.Type;
			int posOffset = (_o.Pos == null) ? 0 : TFastReturnPosUnion.Pack(builder, _o.Pos);
			return IConditionReturnPos.CreateIConditionReturnPos(builder, conditionOffset, pos_type, posOffset);
		}

		// Token: 0x0400B6C7 RID: 46791
		private Table __p;
	}
}
