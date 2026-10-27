using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EBC RID: 20156
	public struct IAttachTargetComponent : IFlatbufferObject
	{
		// Token: 0x17009097 RID: 37015
		// (get) Token: 0x0601FBDA RID: 130010 RVA: 0x0046B18D File Offset: 0x0046938D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FBDB RID: 130011 RVA: 0x0046B19A File Offset: 0x0046939A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FBDC RID: 130012 RVA: 0x0046B1A4 File Offset: 0x004693A4
		public static IAttachTargetComponent GetRootAsIAttachTargetComponent(ByteBuffer _bb)
		{
			return IAttachTargetComponent.GetRootAsIAttachTargetComponent(_bb, default(IAttachTargetComponent));
		}

		// Token: 0x0601FBDD RID: 130013 RVA: 0x0046B1C0 File Offset: 0x004693C0
		public static IAttachTargetComponent GetRootAsIAttachTargetComponent(ByteBuffer _bb, IAttachTargetComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FBDE RID: 130014 RVA: 0x0046B1DD File Offset: 0x004693DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FBDF RID: 130015 RVA: 0x0046B1EC File Offset: 0x004693EC
		public IAttachTargetComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009098 RID: 37016
		// (get) Token: 0x0601FBE0 RID: 130016 RVA: 0x0046B1FC File Offset: 0x004693FC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009099 RID: 37017
		// (get) Token: 0x0601FBE1 RID: 130017 RVA: 0x0046B23C File Offset: 0x0046943C
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

		// Token: 0x0601FBE2 RID: 130018 RVA: 0x0046B278 File Offset: 0x00469478
		public TTable? AttachTarget<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601FBE3 RID: 130019 RVA: 0x0046B2BC File Offset: 0x004694BC
		public IActorAttachTarget AttachTargetAsIActorAttachTarget()
		{
			return this.AttachTarget<IActorAttachTarget>().Value;
		}

		// Token: 0x0601FBE4 RID: 130020 RVA: 0x0046B2D8 File Offset: 0x004694D8
		public IDynamicAttachTarget AttachTargetAsIDynamicAttachTarget()
		{
			return this.AttachTarget<IDynamicAttachTarget>().Value;
		}

		// Token: 0x0601FBE5 RID: 130021 RVA: 0x0046B2F4 File Offset: 0x004694F4
		public IEntityAttachTarget AttachTargetAsIEntityAttachTarget()
		{
			return this.AttachTarget<IEntityAttachTarget>().Value;
		}

		// Token: 0x0601FBE6 RID: 130022 RVA: 0x0046B310 File Offset: 0x00469510
		public IPlayerAttachTarget AttachTargetAsIPlayerAttachTarget()
		{
			return this.AttachTarget<IPlayerAttachTarget>().Value;
		}

		// Token: 0x0601FBE7 RID: 130023 RVA: 0x0046B32C File Offset: 0x0046952C
		public IPointAttachTarget AttachTargetAsIPointAttachTarget()
		{
			return this.AttachTarget<IPointAttachTarget>().Value;
		}

		// Token: 0x1700909A RID: 37018
		// (get) Token: 0x0601FBE8 RID: 130024 RVA: 0x0046B348 File Offset: 0x00469548
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

		// Token: 0x1700909B RID: 37019
		// (get) Token: 0x0601FBE9 RID: 130025 RVA: 0x0046B388 File Offset: 0x00469588
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

		// Token: 0x1700909C RID: 37020
		// (get) Token: 0x0601FBEA RID: 130026 RVA: 0x0046B3C8 File Offset: 0x004695C8
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

		// Token: 0x0601FBEB RID: 130027 RVA: 0x0046B408 File Offset: 0x00469608
		public TTable? AttachTiming<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601FBEC RID: 130028 RVA: 0x0046B450 File Offset: 0x00469650
		public IDefaultAttachTiming AttachTimingAsIDefaultAttachTiming()
		{
			return this.AttachTiming<IDefaultAttachTiming>().Value;
		}

		// Token: 0x0601FBED RID: 130029 RVA: 0x0046B46C File Offset: 0x0046966C
		public IOnMoveWithSplineEndAttachTiming AttachTimingAsIOnMoveWithSplineEndAttachTiming()
		{
			return this.AttachTiming<IOnMoveWithSplineEndAttachTiming>().Value;
		}

		// Token: 0x1700909D RID: 37021
		// (get) Token: 0x0601FBEE RID: 130030 RVA: 0x0046B488 File Offset: 0x00469688
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

		// Token: 0x0601FBEF RID: 130031 RVA: 0x0046B4C8 File Offset: 0x004696C8
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

		// Token: 0x0601FBF0 RID: 130032 RVA: 0x0046B51F File Offset: 0x0046971F
		public static void StartIAttachTargetComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0601FBF1 RID: 130033 RVA: 0x0046B528 File Offset: 0x00469728
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0601FBF2 RID: 130034 RVA: 0x0046B533 File Offset: 0x00469733
		public static void AddAttachTargetType(FlatBufferBuilder builder, TAttachTarget attachTargetType)
		{
			builder.AddByte(1, (byte)attachTargetType, 0);
		}

		// Token: 0x0601FBF3 RID: 130035 RVA: 0x0046B53E File Offset: 0x0046973E
		public static void AddAttachTarget(FlatBufferBuilder builder, int attachTargetOffset)
		{
			builder.AddOffset(2, attachTargetOffset, 0);
		}

		// Token: 0x0601FBF4 RID: 130036 RVA: 0x0046B549 File Offset: 0x00469749
		public static void AddPosRule(FlatBufferBuilder builder, EAttachRuleType posRule)
		{
			builder.AddByte(3, (byte)posRule, 0);
		}

		// Token: 0x0601FBF5 RID: 130037 RVA: 0x0046B554 File Offset: 0x00469754
		public static void AddRotRule(FlatBufferBuilder builder, EAttachRuleType rotRule)
		{
			builder.AddByte(4, (byte)rotRule, 0);
		}

		// Token: 0x0601FBF6 RID: 130038 RVA: 0x0046B55F File Offset: 0x0046975F
		public static void AddAttachTimingType(FlatBufferBuilder builder, TAttachTiming attachTimingType)
		{
			builder.AddByte(5, (byte)attachTimingType, 0);
		}

		// Token: 0x0601FBF7 RID: 130039 RVA: 0x0046B56A File Offset: 0x0046976A
		public static void AddAttachTiming(FlatBufferBuilder builder, int attachTimingOffset)
		{
			builder.AddOffset(6, attachTimingOffset, 0);
		}

		// Token: 0x0601FBF8 RID: 130040 RVA: 0x0046B575 File Offset: 0x00469775
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0601FBF9 RID: 130041 RVA: 0x0046B580 File Offset: 0x00469780
		public static Offset<IAttachTargetComponent> EndIAttachTargetComponent(FlatBufferBuilder builder)
		{
			return new Offset<IAttachTargetComponent>(builder.EndTable());
		}

		// Token: 0x0601FBFA RID: 130042 RVA: 0x0046B590 File Offset: 0x00469790
		public IAttachTargetComponentT UnPack()
		{
			IAttachTargetComponentT attachTargetComponentT = new IAttachTargetComponentT();
			this.UnPackTo(attachTargetComponentT);
			return attachTargetComponentT;
		}

		// Token: 0x0601FBFB RID: 130043 RVA: 0x0046B5AC File Offset: 0x004697AC
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
			TAttachTiming attachTimingType = this.AttachTimingType;
			if (attachTimingType != TAttachTiming.IDefaultAttachTiming)
			{
				if (attachTimingType == TAttachTiming.IOnMoveWithSplineEndAttachTiming)
				{
					_o.AttachTiming.Value = ((this.AttachTiming<IOnMoveWithSplineEndAttachTiming>() != null) ? this.AttachTiming<IOnMoveWithSplineEndAttachTiming>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.AttachTiming.Value = ((this.AttachTiming<IDefaultAttachTiming>() != null) ? this.AttachTiming<IDefaultAttachTiming>().Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601FBFC RID: 130044 RVA: 0x0046B7EC File Offset: 0x004699EC
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

		// Token: 0x0400DCA3 RID: 56483
		private Table __p;
	}
}
