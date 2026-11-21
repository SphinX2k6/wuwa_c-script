using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041C6 RID: 16838
	public struct IConditionReturnPos : IFlatbufferObject
	{
		// Token: 0x1700726B RID: 29291
		// (get) Token: 0x060174AA RID: 95402 RVA: 0x0035331E File Offset: 0x0035151E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060174AB RID: 95403 RVA: 0x0035332B File Offset: 0x0035152B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060174AC RID: 95404 RVA: 0x00353334 File Offset: 0x00351534
		public static IConditionReturnPos GetRootAsIConditionReturnPos(ByteBuffer _bb)
		{
			return IConditionReturnPos.GetRootAsIConditionReturnPos(_bb, default(IConditionReturnPos));
		}

		// Token: 0x060174AD RID: 95405 RVA: 0x00353350 File Offset: 0x00351550
		public static IConditionReturnPos GetRootAsIConditionReturnPos(ByteBuffer _bb, IConditionReturnPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060174AE RID: 95406 RVA: 0x0035336D File Offset: 0x0035156D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060174AF RID: 95407 RVA: 0x0035337C File Offset: 0x0035157C
		public IConditionReturnPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700726C RID: 29292
		// (get) Token: 0x060174B0 RID: 95408 RVA: 0x0035338C File Offset: 0x0035158C
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

		// Token: 0x1700726D RID: 29293
		// (get) Token: 0x060174B1 RID: 95409 RVA: 0x003533EC File Offset: 0x003515EC
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

		// Token: 0x060174B2 RID: 95410 RVA: 0x00353428 File Offset: 0x00351628
		public TTable? Pos<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060174B3 RID: 95411 RVA: 0x0035346C File Offset: 0x0035166C
		public IFastReturnEntityPos PosAsIFastReturnEntityPos()
		{
			return this.Pos<IFastReturnEntityPos>().Value;
		}

		// Token: 0x060174B4 RID: 95412 RVA: 0x00353488 File Offset: 0x00351688
		public IFastReturnGravityEntityPos PosAsIFastReturnGravityEntityPos()
		{
			return this.Pos<IFastReturnGravityEntityPos>().Value;
		}

		// Token: 0x060174B5 RID: 95413 RVA: 0x003534A3 File Offset: 0x003516A3
		public static Offset<IConditionReturnPos> CreateIConditionReturnPos(FlatBufferBuilder builder, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), TFastReturnPos Pos_type = TFastReturnPos.NONE, int PosOffset = 0)
		{
			builder.StartTable(3);
			IConditionReturnPos.AddPos(builder, PosOffset);
			IConditionReturnPos.AddCondition(builder, ConditionOffset);
			IConditionReturnPos.AddPosType(builder, Pos_type);
			return IConditionReturnPos.EndIConditionReturnPos(builder);
		}

		// Token: 0x060174B6 RID: 95414 RVA: 0x003534C7 File Offset: 0x003516C7
		public static void StartIConditionReturnPos(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060174B7 RID: 95415 RVA: 0x003534D0 File Offset: 0x003516D0
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x060174B8 RID: 95416 RVA: 0x003534E0 File Offset: 0x003516E0
		public static void AddPosType(FlatBufferBuilder builder, TFastReturnPos posType)
		{
			builder.AddByte(1, (byte)posType, 0);
		}

		// Token: 0x060174B9 RID: 95417 RVA: 0x003534EB File Offset: 0x003516EB
		public static void AddPos(FlatBufferBuilder builder, int posOffset)
		{
			builder.AddOffset(2, posOffset, 0);
		}

		// Token: 0x060174BA RID: 95418 RVA: 0x003534F6 File Offset: 0x003516F6
		public static Offset<IConditionReturnPos> EndIConditionReturnPos(FlatBufferBuilder builder)
		{
			return new Offset<IConditionReturnPos>(builder.EndTable());
		}

		// Token: 0x060174BB RID: 95419 RVA: 0x00353504 File Offset: 0x00351704
		public IConditionReturnPosT UnPack()
		{
			IConditionReturnPosT conditionReturnPosT = new IConditionReturnPosT();
			this.UnPackTo(conditionReturnPosT);
			return conditionReturnPosT;
		}

		// Token: 0x060174BC RID: 95420 RVA: 0x00353520 File Offset: 0x00351720
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

		// Token: 0x060174BD RID: 95421 RVA: 0x003535F8 File Offset: 0x003517F8
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

		// Token: 0x0400C074 RID: 49268
		private Table __p;
	}
}
