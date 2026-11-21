using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053E5 RID: 21477
	public struct IAttachTargetComponent : IFlatbufferObject
	{
		// Token: 0x170097F8 RID: 38904
		// (get) Token: 0x060218DB RID: 137435 RVA: 0x004A0609 File Offset: 0x0049E809
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060218DC RID: 137436 RVA: 0x004A0616 File Offset: 0x0049E816
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060218DD RID: 137437 RVA: 0x004A0620 File Offset: 0x0049E820
		public static IAttachTargetComponent GetRootAsIAttachTargetComponent(ByteBuffer _bb)
		{
			return IAttachTargetComponent.GetRootAsIAttachTargetComponent(_bb, default(IAttachTargetComponent));
		}

		// Token: 0x060218DE RID: 137438 RVA: 0x004A063C File Offset: 0x0049E83C
		public static IAttachTargetComponent GetRootAsIAttachTargetComponent(ByteBuffer _bb, IAttachTargetComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060218DF RID: 137439 RVA: 0x004A0659 File Offset: 0x0049E859
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060218E0 RID: 137440 RVA: 0x004A0668 File Offset: 0x0049E868
		public IAttachTargetComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170097F9 RID: 38905
		// (get) Token: 0x060218E1 RID: 137441 RVA: 0x004A0678 File Offset: 0x0049E878
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170097FA RID: 38906
		// (get) Token: 0x060218E2 RID: 137442 RVA: 0x004A06B8 File Offset: 0x0049E8B8
		public TAttachTarget AttachTargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TAttachTarget.NONE;
				}
				return (TAttachTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060218E3 RID: 137443 RVA: 0x004A06F4 File Offset: 0x0049E8F4
		public TTable? AttachTarget<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060218E4 RID: 137444 RVA: 0x004A0738 File Offset: 0x0049E938
		public IActorAttachTarget AttachTargetAsIActorAttachTarget()
		{
			return this.AttachTarget<IActorAttachTarget>().Value;
		}

		// Token: 0x060218E5 RID: 137445 RVA: 0x004A0754 File Offset: 0x0049E954
		public IDynamicAttachTarget AttachTargetAsIDynamicAttachTarget()
		{
			return this.AttachTarget<IDynamicAttachTarget>().Value;
		}

		// Token: 0x060218E6 RID: 137446 RVA: 0x004A0770 File Offset: 0x0049E970
		public IEntityAttachTarget AttachTargetAsIEntityAttachTarget()
		{
			return this.AttachTarget<IEntityAttachTarget>().Value;
		}

		// Token: 0x060218E7 RID: 137447 RVA: 0x004A078C File Offset: 0x0049E98C
		public IPlayerAttachTarget AttachTargetAsIPlayerAttachTarget()
		{
			return this.AttachTarget<IPlayerAttachTarget>().Value;
		}

		// Token: 0x060218E8 RID: 137448 RVA: 0x004A07A8 File Offset: 0x0049E9A8
		public IPointAttachTarget AttachTargetAsIPointAttachTarget()
		{
			return this.AttachTarget<IPointAttachTarget>().Value;
		}

		// Token: 0x170097FB RID: 38907
		// (get) Token: 0x060218E9 RID: 137449 RVA: 0x004A07C4 File Offset: 0x0049E9C4
		public EAttachRuleType PosRule
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EAttachRuleType.Relatively;
				}
				return (EAttachRuleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170097FC RID: 38908
		// (get) Token: 0x060218EA RID: 137450 RVA: 0x004A0804 File Offset: 0x0049EA04
		public EAttachRuleType RotRule
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return EAttachRuleType.Relatively;
				}
				return (EAttachRuleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170097FD RID: 38909
		// (get) Token: 0x060218EB RID: 137451 RVA: 0x004A0844 File Offset: 0x0049EA44
		public TAttachTiming AttachTimingType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return TAttachTiming.NONE;
				}
				return (TAttachTiming)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060218EC RID: 137452 RVA: 0x004A0884 File Offset: 0x0049EA84
		public TTable? AttachTiming<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060218ED RID: 137453 RVA: 0x004A08CC File Offset: 0x0049EACC
		public IDefaultAttachTiming AttachTimingAsIDefaultAttachTiming()
		{
			return this.AttachTiming<IDefaultAttachTiming>().Value;
		}

		// Token: 0x060218EE RID: 137454 RVA: 0x004A08E8 File Offset: 0x0049EAE8
		public IOnEntityStateChangeAttachTiming AttachTimingAsIOnEntityStateChangeAttachTiming()
		{
			return this.AttachTiming<IOnEntityStateChangeAttachTiming>().Value;
		}

		// Token: 0x060218EF RID: 137455 RVA: 0x004A0904 File Offset: 0x0049EB04
		public IOnMoveWithSplineEndAttachTiming AttachTimingAsIOnMoveWithSplineEndAttachTiming()
		{
			return this.AttachTiming<IOnMoveWithSplineEndAttachTiming>().Value;
		}

		// Token: 0x170097FE RID: 38910
		// (get) Token: 0x060218F0 RID: 137456 RVA: 0x004A0920 File Offset: 0x0049EB20
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060218F1 RID: 137457 RVA: 0x004A0960 File Offset: 0x0049EB60
		public static Offset<IAttachTargetComponent> CreateIAttachTargetComponent(FlatBufferBuilder builder, bool Disabled = false, TAttachTarget AttachTarget_type = TAttachTarget.NONE, int AttachTargetOffset = 0, EAttachRuleType PosRule = EAttachRuleType.Relatively, EAttachRuleType RotRule = EAttachRuleType.Relatively, TAttachTiming AttachTiming_type = TAttachTiming.NONE, int AttachTimingOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(8);
			IAttachTargetComponent.AddAttachTiming(builder, AttachTimingOffset);
			IAttachTargetComponent.AddAttachTarget(builder, AttachTargetOffset);
			IAttachTargetComponent.AddNullMask(builder, NullMask);
			IAttachTargetComponent.AddAttachTimingType(builder, AttachTiming_type);
			IAttachTargetComponent.AddRotRule(builder, RotRule);
			IAttachTargetComponent.AddPosRule(builder, PosRule);
			IAttachTargetComponent.AddAttachTargetType(builder, AttachTarget_type);
			IAttachTargetComponent.AddDisabled(builder, Disabled);
			return IAttachTargetComponent.EndIAttachTargetComponent(builder);
		}

		// Token: 0x060218F2 RID: 137458 RVA: 0x004A09B7 File Offset: 0x0049EBB7
		public static void StartIAttachTargetComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x060218F3 RID: 137459 RVA: 0x004A09C0 File Offset: 0x0049EBC0
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060218F4 RID: 137460 RVA: 0x004A09CB File Offset: 0x0049EBCB
		public static void AddAttachTargetType(FlatBufferBuilder builder, TAttachTarget attachTargetType)
		{
			builder.AddByte(1, (byte)attachTargetType, 0);
		}

		// Token: 0x060218F5 RID: 137461 RVA: 0x004A09D6 File Offset: 0x0049EBD6
		public static void AddAttachTarget(FlatBufferBuilder builder, int attachTargetOffset)
		{
			builder.AddOffset(2, attachTargetOffset, 0);
		}

		// Token: 0x060218F6 RID: 137462 RVA: 0x004A09E1 File Offset: 0x0049EBE1
		public static void AddPosRule(FlatBufferBuilder builder, EAttachRuleType posRule)
		{
			builder.AddByte(3, (byte)posRule, 0);
		}

		// Token: 0x060218F7 RID: 137463 RVA: 0x004A09EC File Offset: 0x0049EBEC
		public static void AddRotRule(FlatBufferBuilder builder, EAttachRuleType rotRule)
		{
			builder.AddByte(4, (byte)rotRule, 0);
		}

		// Token: 0x060218F8 RID: 137464 RVA: 0x004A09F7 File Offset: 0x0049EBF7
		public static void AddAttachTimingType(FlatBufferBuilder builder, TAttachTiming attachTimingType)
		{
			builder.AddByte(5, (byte)attachTimingType, 0);
		}

		// Token: 0x060218F9 RID: 137465 RVA: 0x004A0A02 File Offset: 0x0049EC02
		public static void AddAttachTiming(FlatBufferBuilder builder, int attachTimingOffset)
		{
			builder.AddOffset(6, attachTimingOffset, 0);
		}

		// Token: 0x060218FA RID: 137466 RVA: 0x004A0A0D File Offset: 0x0049EC0D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x060218FB RID: 137467 RVA: 0x004A0A18 File Offset: 0x0049EC18
		public static Offset<IAttachTargetComponent> EndIAttachTargetComponent(FlatBufferBuilder builder)
		{
			return new Offset<IAttachTargetComponent>(builder.EndTable());
		}

		// Token: 0x060218FC RID: 137468 RVA: 0x004A0A28 File Offset: 0x0049EC28
		public IAttachTargetComponentT UnPack()
		{
			IAttachTargetComponentT attachTargetComponentT = new IAttachTargetComponentT();
			this.UnPackTo(attachTargetComponentT);
			return attachTargetComponentT;
		}

		// Token: 0x060218FD RID: 137469 RVA: 0x004A0A44 File Offset: 0x0049EC44
		public void UnPackTo(IAttachTargetComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.AttachTarget = new TAttachTargetUnion();
			_o.AttachTarget.Type = this.AttachTargetType;
			switch (this.AttachTargetType)
			{
			case TAttachTarget.IActorAttachTarget:
				_o.AttachTarget.Value = ((this.AttachTarget<IActorAttachTarget>() != null) ? this.AttachTarget<IActorAttachTarget>().Value.UnPack() : null);
				break;
			case TAttachTarget.IDynamicAttachTarget:
				_o.AttachTarget.Value = ((this.AttachTarget<IDynamicAttachTarget>() != null) ? this.AttachTarget<IDynamicAttachTarget>().Value.UnPack() : null);
				break;
			case TAttachTarget.IEntityAttachTarget:
				_o.AttachTarget.Value = ((this.AttachTarget<IEntityAttachTarget>() != null) ? this.AttachTarget<IEntityAttachTarget>().Value.UnPack() : null);
				break;
			case TAttachTarget.IPlayerAttachTarget:
				_o.AttachTarget.Value = ((this.AttachTarget<IPlayerAttachTarget>() != null) ? this.AttachTarget<IPlayerAttachTarget>().Value.UnPack() : null);
				break;
			case TAttachTarget.IPointAttachTarget:
				_o.AttachTarget.Value = ((this.AttachTarget<IPointAttachTarget>() != null) ? this.AttachTarget<IPointAttachTarget>().Value.UnPack() : null);
				break;
			}
			_o.PosRule = this.PosRule;
			_o.RotRule = this.RotRule;
			_o.AttachTiming = new TAttachTimingUnion();
			_o.AttachTiming.Type = this.AttachTimingType;
			switch (this.AttachTimingType)
			{
			case TAttachTiming.IDefaultAttachTiming:
				_o.AttachTiming.Value = ((this.AttachTiming<IDefaultAttachTiming>() != null) ? this.AttachTiming<IDefaultAttachTiming>().Value.UnPack() : null);
				break;
			case TAttachTiming.IOnEntityStateChangeAttachTiming:
				_o.AttachTiming.Value = ((this.AttachTiming<IOnEntityStateChangeAttachTiming>() != null) ? this.AttachTiming<IOnEntityStateChangeAttachTiming>().Value.UnPack() : null);
				break;
			case TAttachTiming.IOnMoveWithSplineEndAttachTiming:
				_o.AttachTiming.Value = ((this.AttachTiming<IOnMoveWithSplineEndAttachTiming>() != null) ? this.AttachTiming<IOnMoveWithSplineEndAttachTiming>().Value.UnPack() : null);
				break;
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060218FE RID: 137470 RVA: 0x004A0CC8 File Offset: 0x0049EEC8
		public static Offset<IAttachTargetComponent> Pack(FlatBufferBuilder builder, IAttachTargetComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAttachTargetComponent>);
			}
			TAttachTarget attachTarget_type = (_o.AttachTarget == null) ? TAttachTarget.NONE : _o.AttachTarget.Type;
			int attachTargetOffset = (_o.AttachTarget == null) ? 0 : TAttachTargetUnion.Pack(builder, _o.AttachTarget);
			TAttachTiming attachTiming_type = (_o.AttachTiming == null) ? TAttachTiming.NONE : _o.AttachTiming.Type;
			int attachTimingOffset = (_o.AttachTiming == null) ? 0 : TAttachTimingUnion.Pack(builder, _o.AttachTiming);
			return IAttachTargetComponent.CreateIAttachTargetComponent(builder, _o.Disabled, attachTarget_type, attachTargetOffset, _o.PosRule, _o.RotRule, attachTiming_type, attachTimingOffset, _o.NullMask);
		}

		// Token: 0x0400E83F RID: 59455
		private Table __p;
	}
}
