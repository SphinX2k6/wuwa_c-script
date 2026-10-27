using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DD6 RID: 15830
	public struct IDisableTrackAnim : IFlatbufferObject
	{
		// Token: 0x17006D52 RID: 27986
		// (get) Token: 0x060161AD RID: 90541 RVA: 0x00331F4A File Offset: 0x0033014A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060161AE RID: 90542 RVA: 0x00331F57 File Offset: 0x00330157
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060161AF RID: 90543 RVA: 0x00331F60 File Offset: 0x00330160
		public static IDisableTrackAnim GetRootAsIDisableTrackAnim(ByteBuffer _bb)
		{
			return IDisableTrackAnim.GetRootAsIDisableTrackAnim(_bb, default(IDisableTrackAnim));
		}

		// Token: 0x060161B0 RID: 90544 RVA: 0x00331F7C File Offset: 0x0033017C
		public static IDisableTrackAnim GetRootAsIDisableTrackAnim(ByteBuffer _bb, IDisableTrackAnim obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060161B1 RID: 90545 RVA: 0x00331F99 File Offset: 0x00330199
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060161B2 RID: 90546 RVA: 0x00331FA8 File Offset: 0x003301A8
		public IDisableTrackAnim __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D53 RID: 27987
		// (get) Token: 0x060161B3 RID: 90547 RVA: 0x00331FB8 File Offset: 0x003301B8
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

		// Token: 0x060161B4 RID: 90548 RVA: 0x00332015 File Offset: 0x00330215
		public static Offset<IDisableTrackAnim> CreateIDisableTrackAnim(FlatBufferBuilder builder, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(1);
			IDisableTrackAnim.AddCondition(builder, ConditionOffset);
			return IDisableTrackAnim.EndIDisableTrackAnim(builder);
		}

		// Token: 0x060161B5 RID: 90549 RVA: 0x0033202B File Offset: 0x0033022B
		public static void StartIDisableTrackAnim(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060161B6 RID: 90550 RVA: 0x00332034 File Offset: 0x00330234
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x060161B7 RID: 90551 RVA: 0x00332044 File Offset: 0x00330244
		public static Offset<IDisableTrackAnim> EndIDisableTrackAnim(FlatBufferBuilder builder)
		{
			return new Offset<IDisableTrackAnim>(builder.EndTable());
		}

		// Token: 0x060161B8 RID: 90552 RVA: 0x00332054 File Offset: 0x00330254
		public IDisableTrackAnimT UnPack()
		{
			IDisableTrackAnimT disableTrackAnimT = new IDisableTrackAnimT();
			this.UnPackTo(disableTrackAnimT);
			return disableTrackAnimT;
		}

		// Token: 0x060161B9 RID: 90553 RVA: 0x00332070 File Offset: 0x00330270
		public void UnPackTo(IDisableTrackAnimT _o)
		{
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
		}

		// Token: 0x060161BA RID: 90554 RVA: 0x003320AC File Offset: 0x003302AC
		public static Offset<IDisableTrackAnim> Pack(FlatBufferBuilder builder, IDisableTrackAnimT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableTrackAnim>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			return IDisableTrackAnim.CreateIDisableTrackAnim(builder, conditionOffset);
		}

		// Token: 0x0400B71E RID: 46878
		private Table __p;
	}
}
