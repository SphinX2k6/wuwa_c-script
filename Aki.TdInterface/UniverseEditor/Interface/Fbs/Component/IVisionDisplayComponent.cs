using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006157 RID: 24919
	public struct IVisionDisplayComponent : IFlatbufferObject
	{
		// Token: 0x1700B997 RID: 47511
		// (get) Token: 0x0602A4A6 RID: 173222 RVA: 0x005C5234 File Offset: 0x005C3434
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A4A7 RID: 173223 RVA: 0x005C5241 File Offset: 0x005C3441
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A4A8 RID: 173224 RVA: 0x005C5248 File Offset: 0x005C3448
		public static IVisionDisplayComponent GetRootAsIVisionDisplayComponent(ByteBuffer _bb)
		{
			return IVisionDisplayComponent.GetRootAsIVisionDisplayComponent(_bb, default(IVisionDisplayComponent));
		}

		// Token: 0x0602A4A9 RID: 173225 RVA: 0x005C5264 File Offset: 0x005C3464
		public static IVisionDisplayComponent GetRootAsIVisionDisplayComponent(ByteBuffer _bb, IVisionDisplayComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A4AA RID: 173226 RVA: 0x005C5281 File Offset: 0x005C3481
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A4AB RID: 173227 RVA: 0x005C5290 File Offset: 0x005C3490
		public IVisionDisplayComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B998 RID: 47512
		// (get) Token: 0x0602A4AC RID: 173228 RVA: 0x005C52A0 File Offset: 0x005C34A0
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B999 RID: 47513
		// (get) Token: 0x0602A4AD RID: 173229 RVA: 0x005C52E0 File Offset: 0x005C34E0
		public bool IsNeedInView
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B99A RID: 47514
		// (get) Token: 0x0602A4AE RID: 173230 RVA: 0x005C5320 File Offset: 0x005C3520
		public bool IsBanOcclusion
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B99B RID: 47515
		// (get) Token: 0x0602A4AF RID: 173231 RVA: 0x005C5360 File Offset: 0x005C3560
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

		// Token: 0x1700B99C RID: 47516
		// (get) Token: 0x0602A4B0 RID: 173232 RVA: 0x005C53A0 File Offset: 0x005C35A0
		public bool IsBornInTargetPoint
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B99D RID: 47517
		// (get) Token: 0x0602A4B1 RID: 173233 RVA: 0x005C53E0 File Offset: 0x005C35E0
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

		// Token: 0x1700B99E RID: 47518
		// (get) Token: 0x0602A4B2 RID: 173234 RVA: 0x005C5440 File Offset: 0x005C3640
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

		// Token: 0x0602A4B3 RID: 173235 RVA: 0x005C5480 File Offset: 0x005C3680
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

		// Token: 0x0602A4B4 RID: 173236 RVA: 0x005C54CF File Offset: 0x005C36CF
		public static void StartIVisionDisplayComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602A4B5 RID: 173237 RVA: 0x005C54D8 File Offset: 0x005C36D8
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602A4B6 RID: 173238 RVA: 0x005C54E3 File Offset: 0x005C36E3
		public static void AddIsNeedInView(FlatBufferBuilder builder, bool isNeedInView)
		{
			builder.AddBool(1, isNeedInView, false);
		}

		// Token: 0x0602A4B7 RID: 173239 RVA: 0x005C54EE File Offset: 0x005C36EE
		public static void AddIsBanOcclusion(FlatBufferBuilder builder, bool isBanOcclusion)
		{
			builder.AddBool(2, isBanOcclusion, false);
		}

		// Token: 0x0602A4B8 RID: 173240 RVA: 0x005C54F9 File Offset: 0x005C36F9
		public static void AddViewEntityId(FlatBufferBuilder builder, int viewEntityId)
		{
			builder.AddInt(3, viewEntityId, 0);
		}

		// Token: 0x0602A4B9 RID: 173241 RVA: 0x005C5504 File Offset: 0x005C3704
		public static void AddIsBornInTargetPoint(FlatBufferBuilder builder, bool isBornInTargetPoint)
		{
			builder.AddBool(4, isBornInTargetPoint, false);
		}

		// Token: 0x0602A4BA RID: 173242 RVA: 0x005C550F File Offset: 0x005C370F
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(5, conditionOffset.Value, 0);
		}

		// Token: 0x0602A4BB RID: 173243 RVA: 0x005C551F File Offset: 0x005C371F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0602A4BC RID: 173244 RVA: 0x005C552A File Offset: 0x005C372A
		public static Offset<IVisionDisplayComponent> EndIVisionDisplayComponent(FlatBufferBuilder builder)
		{
			return new Offset<IVisionDisplayComponent>(builder.EndTable());
		}

		// Token: 0x0602A4BD RID: 173245 RVA: 0x005C5538 File Offset: 0x005C3738
		public IVisionDisplayComponentT UnPack()
		{
			IVisionDisplayComponentT visionDisplayComponentT = new IVisionDisplayComponentT();
			this.UnPackTo(visionDisplayComponentT);
			return visionDisplayComponentT;
		}

		// Token: 0x0602A4BE RID: 173246 RVA: 0x005C5554 File Offset: 0x005C3754
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

		// Token: 0x0602A4BF RID: 173247 RVA: 0x005C55D8 File Offset: 0x005C37D8
		public static Offset<IVisionDisplayComponent> Pack(FlatBufferBuilder builder, IVisionDisplayComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisionDisplayComponent>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			return IVisionDisplayComponent.CreateIVisionDisplayComponent(builder, _o.Disabled, _o.IsNeedInView, _o.IsBanOcclusion, _o.ViewEntityId, _o.IsBornInTargetPoint, conditionOffset, _o.NullMask);
		}

		// Token: 0x0400FF74 RID: 65396
		private Table __p;
	}
}
