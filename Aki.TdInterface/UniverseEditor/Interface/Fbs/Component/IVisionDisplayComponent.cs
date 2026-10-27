using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B41 RID: 23361
	public struct IVisionDisplayComponent : IFlatbufferObject
	{
		// Token: 0x1700B04F RID: 45135
		// (get) Token: 0x06027EE2 RID: 163554 RVA: 0x0057D7A4 File Offset: 0x0057B9A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027EE3 RID: 163555 RVA: 0x0057D7B1 File Offset: 0x0057B9B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027EE4 RID: 163556 RVA: 0x0057D7B8 File Offset: 0x0057B9B8
		public static IVisionDisplayComponent GetRootAsIVisionDisplayComponent(ByteBuffer _bb)
		{
			return IVisionDisplayComponent.GetRootAsIVisionDisplayComponent(_bb, default(IVisionDisplayComponent));
		}

		// Token: 0x06027EE5 RID: 163557 RVA: 0x0057D7D4 File Offset: 0x0057B9D4
		public static IVisionDisplayComponent GetRootAsIVisionDisplayComponent(ByteBuffer _bb, IVisionDisplayComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027EE6 RID: 163558 RVA: 0x0057D7F1 File Offset: 0x0057B9F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027EE7 RID: 163559 RVA: 0x0057D800 File Offset: 0x0057BA00
		public IVisionDisplayComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B050 RID: 45136
		// (get) Token: 0x06027EE8 RID: 163560 RVA: 0x0057D810 File Offset: 0x0057BA10
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B051 RID: 45137
		// (get) Token: 0x06027EE9 RID: 163561 RVA: 0x0057D850 File Offset: 0x0057BA50
		public bool IsNeedInView
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B052 RID: 45138
		// (get) Token: 0x06027EEA RID: 163562 RVA: 0x0057D890 File Offset: 0x0057BA90
		public bool IsBanOcclusion
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B053 RID: 45139
		// (get) Token: 0x06027EEB RID: 163563 RVA: 0x0057D8D0 File Offset: 0x0057BAD0
		public int ViewEntityId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B054 RID: 45140
		// (get) Token: 0x06027EEC RID: 163564 RVA: 0x0057D910 File Offset: 0x0057BB10
		public bool IsBornInTargetPoint
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B055 RID: 45141
		// (get) Token: 0x06027EED RID: 163565 RVA: 0x0057D950 File Offset: 0x0057BB50
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B056 RID: 45142
		// (get) Token: 0x06027EEE RID: 163566 RVA: 0x0057D9B0 File Offset: 0x0057BBB0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027EEF RID: 163567 RVA: 0x0057D9F0 File Offset: 0x0057BBF0
		public static Offset<IVisionDisplayComponent> CreateIVisionDisplayComponent(FlatBufferBuilder builder, bool Disabled = false, bool IsNeedInView = false, bool IsBanOcclusion = false, int ViewEntityId = 0, bool IsBornInTargetPoint = false, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), byte NullMask = 0)
		{
			builder.StartTable(7);
			IVisionDisplayComponent.AddCondition(builder, ConditionOffset);
			IVisionDisplayComponent.AddViewEntityId(builder, ViewEntityId);
			IVisionDisplayComponent.AddNullMask(builder, NullMask);
			IVisionDisplayComponent.AddIsBornInTargetPoint(builder, IsBornInTargetPoint);
			IVisionDisplayComponent.AddIsBanOcclusion(builder, IsBanOcclusion);
			IVisionDisplayComponent.AddIsNeedInView(builder, IsNeedInView);
			IVisionDisplayComponent.AddDisabled(builder, Disabled);
			return IVisionDisplayComponent.EndIVisionDisplayComponent(builder);
		}

		// Token: 0x06027EF0 RID: 163568 RVA: 0x0057DA3F File Offset: 0x0057BC3F
		public static void StartIVisionDisplayComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06027EF1 RID: 163569 RVA: 0x0057DA48 File Offset: 0x0057BC48
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06027EF2 RID: 163570 RVA: 0x0057DA53 File Offset: 0x0057BC53
		public static void AddIsNeedInView(FlatBufferBuilder builder, bool isNeedInView)
		{
			builder.AddBool(1, isNeedInView, false);
		}

		// Token: 0x06027EF3 RID: 163571 RVA: 0x0057DA5E File Offset: 0x0057BC5E
		public static void AddIsBanOcclusion(FlatBufferBuilder builder, bool isBanOcclusion)
		{
			builder.AddBool(2, isBanOcclusion, false);
		}

		// Token: 0x06027EF4 RID: 163572 RVA: 0x0057DA69 File Offset: 0x0057BC69
		public static void AddViewEntityId(FlatBufferBuilder builder, int viewEntityId)
		{
			builder.AddInt(3, viewEntityId, 0);
		}

		// Token: 0x06027EF5 RID: 163573 RVA: 0x0057DA74 File Offset: 0x0057BC74
		public static void AddIsBornInTargetPoint(FlatBufferBuilder builder, bool isBornInTargetPoint)
		{
			builder.AddBool(4, isBornInTargetPoint, false);
		}

		// Token: 0x06027EF6 RID: 163574 RVA: 0x0057DA7F File Offset: 0x0057BC7F
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(5, conditionOffset.Value, 0);
		}

		// Token: 0x06027EF7 RID: 163575 RVA: 0x0057DA8F File Offset: 0x0057BC8F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06027EF8 RID: 163576 RVA: 0x0057DA9A File Offset: 0x0057BC9A
		public static Offset<IVisionDisplayComponent> EndIVisionDisplayComponent(FlatBufferBuilder builder)
		{
			return new Offset<IVisionDisplayComponent>(builder.EndTable());
		}

		// Token: 0x06027EF9 RID: 163577 RVA: 0x0057DAA8 File Offset: 0x0057BCA8
		public IVisionDisplayComponentT UnPack()
		{
			IVisionDisplayComponentT visionDisplayComponentT = new IVisionDisplayComponentT();
			this.UnPackTo(visionDisplayComponentT);
			return visionDisplayComponentT;
		}

		// Token: 0x06027EFA RID: 163578 RVA: 0x0057DAC4 File Offset: 0x0057BCC4
		public void UnPackTo(IVisionDisplayComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.IsNeedInView = this.IsNeedInView;
			_o.IsBanOcclusion = this.IsBanOcclusion;
			_o.ViewEntityId = this.ViewEntityId;
			_o.IsBornInTargetPoint = this.IsBornInTargetPoint;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027EFB RID: 163579 RVA: 0x0057DB48 File Offset: 0x0057BD48
		public static Offset<IVisionDisplayComponent> Pack(FlatBufferBuilder builder, IVisionDisplayComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisionDisplayComponent>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			return IVisionDisplayComponent.CreateIVisionDisplayComponent(builder, _o.Disabled, _o.IsNeedInView, _o.IsBanOcclusion, _o.ViewEntityId, _o.IsBornInTargetPoint, conditionOffset, _o.NullMask);
		}

		// Token: 0x0400F26E RID: 62062
		private Table __p;
	}
}
