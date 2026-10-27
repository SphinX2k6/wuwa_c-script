using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007085 RID: 28805
	public struct ISetTargetElementalAbility : IFlatbufferObject
	{
		// Token: 0x1700D60C RID: 54796
		// (get) Token: 0x06033006 RID: 208902 RVA: 0x006E12B9 File Offset: 0x006DF4B9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033007 RID: 208903 RVA: 0x006E12C6 File Offset: 0x006DF4C6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033008 RID: 208904 RVA: 0x006E12D0 File Offset: 0x006DF4D0
		public static ISetTargetElementalAbility GetRootAsISetTargetElementalAbility(ByteBuffer _bb)
		{
			return ISetTargetElementalAbility.GetRootAsISetTargetElementalAbility(_bb, default(ISetTargetElementalAbility));
		}

		// Token: 0x06033009 RID: 208905 RVA: 0x006E12EC File Offset: 0x006DF4EC
		public static ISetTargetElementalAbility GetRootAsISetTargetElementalAbility(ByteBuffer _bb, ISetTargetElementalAbility obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603300A RID: 208906 RVA: 0x006E1309 File Offset: 0x006DF509
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603300B RID: 208907 RVA: 0x006E1318 File Offset: 0x006DF518
		public ISetTargetElementalAbility __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D60D RID: 54797
		// (get) Token: 0x0603300C RID: 208908 RVA: 0x006E1328 File Offset: 0x006DF528
		public TTargetEntity TargetType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TTargetEntity.NONE;
				}
				return (TTargetEntity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603300D RID: 208909 RVA: 0x006E1364 File Offset: 0x006DF564
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603300E RID: 208910 RVA: 0x006E13A8 File Offset: 0x006DF5A8
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x0603300F RID: 208911 RVA: 0x006E13C4 File Offset: 0x006DF5C4
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x06033010 RID: 208912 RVA: 0x006E13E0 File Offset: 0x006DF5E0
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x06033011 RID: 208913 RVA: 0x006E13FC File Offset: 0x006DF5FC
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x06033012 RID: 208914 RVA: 0x006E1418 File Offset: 0x006DF618
		public IVehicleEntity TargetAsIVehicleEntity()
		{
			return this.Target<IVehicleEntity>().Value;
		}

		// Token: 0x1700D60E RID: 54798
		// (get) Token: 0x06033013 RID: 208915 RVA: 0x006E1434 File Offset: 0x006DF634
		public EElementalType ElementalType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EElementalType.Fire;
				}
				return (EElementalType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D60F RID: 54799
		// (get) Token: 0x06033014 RID: 208916 RVA: 0x006E1470 File Offset: 0x006DF670
		public EElementalOpType OpType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EElementalOpType.Grant;
				}
				return (EElementalOpType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D610 RID: 54800
		// (get) Token: 0x06033015 RID: 208917 RVA: 0x006E14B0 File Offset: 0x006DF6B0
		public int Priority
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033016 RID: 208918 RVA: 0x006E14ED File Offset: 0x006DF6ED
		public static Offset<ISetTargetElementalAbility> CreateISetTargetElementalAbility(FlatBufferBuilder builder, TTargetEntity Target_type = TTargetEntity.NONE, int TargetOffset = 0, EElementalType ElementalType = EElementalType.Fire, EElementalOpType OpType = EElementalOpType.Grant, int Priority = 0)
		{
			builder.StartTable(5);
			ISetTargetElementalAbility.AddPriority(builder, Priority);
			ISetTargetElementalAbility.AddTarget(builder, TargetOffset);
			ISetTargetElementalAbility.AddOpType(builder, OpType);
			ISetTargetElementalAbility.AddElementalType(builder, ElementalType);
			ISetTargetElementalAbility.AddTargetType(builder, Target_type);
			return ISetTargetElementalAbility.EndISetTargetElementalAbility(builder);
		}

		// Token: 0x06033017 RID: 208919 RVA: 0x006E1521 File Offset: 0x006DF721
		public static void StartISetTargetElementalAbility(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06033018 RID: 208920 RVA: 0x006E152A File Offset: 0x006DF72A
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(0, (byte)targetType, 0);
		}

		// Token: 0x06033019 RID: 208921 RVA: 0x006E1535 File Offset: 0x006DF735
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(1, targetOffset, 0);
		}

		// Token: 0x0603301A RID: 208922 RVA: 0x006E1540 File Offset: 0x006DF740
		public static void AddElementalType(FlatBufferBuilder builder, EElementalType elementalType)
		{
			builder.AddByte(2, (byte)elementalType, 0);
		}

		// Token: 0x0603301B RID: 208923 RVA: 0x006E154B File Offset: 0x006DF74B
		public static void AddOpType(FlatBufferBuilder builder, EElementalOpType opType)
		{
			builder.AddByte(3, (byte)opType, 0);
		}

		// Token: 0x0603301C RID: 208924 RVA: 0x006E1556 File Offset: 0x006DF756
		public static void AddPriority(FlatBufferBuilder builder, int priority)
		{
			builder.AddInt(4, priority, 0);
		}

		// Token: 0x0603301D RID: 208925 RVA: 0x006E1561 File Offset: 0x006DF761
		public static Offset<ISetTargetElementalAbility> EndISetTargetElementalAbility(FlatBufferBuilder builder)
		{
			return new Offset<ISetTargetElementalAbility>(builder.EndTable());
		}

		// Token: 0x0603301E RID: 208926 RVA: 0x006E1570 File Offset: 0x006DF770
		public ISetTargetElementalAbilityT UnPack()
		{
			ISetTargetElementalAbilityT setTargetElementalAbilityT = new ISetTargetElementalAbilityT();
			this.UnPackTo(setTargetElementalAbilityT);
			return setTargetElementalAbilityT;
		}

		// Token: 0x0603301F RID: 208927 RVA: 0x006E158C File Offset: 0x006DF78C
		public void UnPackTo(ISetTargetElementalAbilityT _o)
		{
			_o.Target = new TTargetEntityUnion();
			_o.Target.Type = this.TargetType;
			switch (this.TargetType)
			{
			case TTargetEntity.IPlayerEntity:
				_o.Target.Value = ((this.Target<IPlayerEntity>() != null) ? this.Target<IPlayerEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ISelfEntity:
				_o.Target.Value = ((this.Target<ISelfEntity>() != null) ? this.Target<ISelfEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITargetEntity:
				_o.Target.Value = ((this.Target<ITargetEntity>() != null) ? this.Target<ITargetEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITriggeredEntity:
				_o.Target.Value = ((this.Target<ITriggeredEntity>() != null) ? this.Target<ITriggeredEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.IVehicleEntity:
				_o.Target.Value = ((this.Target<IVehicleEntity>() != null) ? this.Target<IVehicleEntity>().Value.UnPack() : null);
				break;
			}
			_o.ElementalType = this.ElementalType;
			_o.OpType = this.OpType;
			_o.Priority = this.Priority;
		}

		// Token: 0x06033020 RID: 208928 RVA: 0x006E1720 File Offset: 0x006DF920
		public static Offset<ISetTargetElementalAbility> Pack(FlatBufferBuilder builder, ISetTargetElementalAbilityT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetTargetElementalAbility>);
			}
			TTargetEntity target_type = (_o.Target == null) ? TTargetEntity.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.Target);
			return ISetTargetElementalAbility.CreateISetTargetElementalAbility(builder, target_type, targetOffset, _o.ElementalType, _o.OpType, _o.Priority);
		}

		// Token: 0x04011AEA RID: 72426
		private Table __p;
	}
}
