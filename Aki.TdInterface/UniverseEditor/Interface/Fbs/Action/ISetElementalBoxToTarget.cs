using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FDA RID: 28634
	public struct ISetElementalBoxToTarget : IFlatbufferObject
	{
		// Token: 0x1700D497 RID: 54423
		// (get) Token: 0x060329DB RID: 207323 RVA: 0x006D43F7 File Offset: 0x006D25F7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060329DC RID: 207324 RVA: 0x006D4404 File Offset: 0x006D2604
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060329DD RID: 207325 RVA: 0x006D440C File Offset: 0x006D260C
		public static ISetElementalBoxToTarget GetRootAsISetElementalBoxToTarget(ByteBuffer _bb)
		{
			return ISetElementalBoxToTarget.GetRootAsISetElementalBoxToTarget(_bb, default(ISetElementalBoxToTarget));
		}

		// Token: 0x060329DE RID: 207326 RVA: 0x006D4428 File Offset: 0x006D2628
		public static ISetElementalBoxToTarget GetRootAsISetElementalBoxToTarget(ByteBuffer _bb, ISetElementalBoxToTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060329DF RID: 207327 RVA: 0x006D4445 File Offset: 0x006D2645
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060329E0 RID: 207328 RVA: 0x006D4454 File Offset: 0x006D2654
		public ISetElementalBoxToTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D498 RID: 54424
		// (get) Token: 0x060329E1 RID: 207329 RVA: 0x006D4464 File Offset: 0x006D2664
		public int ElementalBoxId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D499 RID: 54425
		// (get) Token: 0x060329E2 RID: 207330 RVA: 0x006D44A0 File Offset: 0x006D26A0
		public TTargetEntity TargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TTargetEntity.NONE;
				}
				return (TTargetEntity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060329E3 RID: 207331 RVA: 0x006D44DC File Offset: 0x006D26DC
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060329E4 RID: 207332 RVA: 0x006D4520 File Offset: 0x006D2720
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x060329E5 RID: 207333 RVA: 0x006D453C File Offset: 0x006D273C
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x060329E6 RID: 207334 RVA: 0x006D4558 File Offset: 0x006D2758
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x060329E7 RID: 207335 RVA: 0x006D4574 File Offset: 0x006D2774
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x060329E8 RID: 207336 RVA: 0x006D4590 File Offset: 0x006D2790
		public IVehicleEntity TargetAsIVehicleEntity()
		{
			return this.Target<IVehicleEntity>().Value;
		}

		// Token: 0x060329E9 RID: 207337 RVA: 0x006D45AB File Offset: 0x006D27AB
		public static Offset<ISetElementalBoxToTarget> CreateISetElementalBoxToTarget(FlatBufferBuilder builder, int ElementalBoxId = 0, TTargetEntity Target_type = TTargetEntity.NONE, int TargetOffset = 0)
		{
			builder.StartTable(3);
			ISetElementalBoxToTarget.AddTarget(builder, TargetOffset);
			ISetElementalBoxToTarget.AddElementalBoxId(builder, ElementalBoxId);
			ISetElementalBoxToTarget.AddTargetType(builder, Target_type);
			return ISetElementalBoxToTarget.EndISetElementalBoxToTarget(builder);
		}

		// Token: 0x060329EA RID: 207338 RVA: 0x006D45CF File Offset: 0x006D27CF
		public static void StartISetElementalBoxToTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060329EB RID: 207339 RVA: 0x006D45D8 File Offset: 0x006D27D8
		public static void AddElementalBoxId(FlatBufferBuilder builder, int elementalBoxId)
		{
			builder.AddInt(0, elementalBoxId, 0);
		}

		// Token: 0x060329EC RID: 207340 RVA: 0x006D45E3 File Offset: 0x006D27E3
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x060329ED RID: 207341 RVA: 0x006D45EE File Offset: 0x006D27EE
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x060329EE RID: 207342 RVA: 0x006D45F9 File Offset: 0x006D27F9
		public static Offset<ISetElementalBoxToTarget> EndISetElementalBoxToTarget(FlatBufferBuilder builder)
		{
			return new Offset<ISetElementalBoxToTarget>(builder.EndTable());
		}

		// Token: 0x060329EF RID: 207343 RVA: 0x006D4608 File Offset: 0x006D2808
		public ISetElementalBoxToTargetT UnPack()
		{
			ISetElementalBoxToTargetT setElementalBoxToTargetT = new ISetElementalBoxToTargetT();
			this.UnPackTo(setElementalBoxToTargetT);
			return setElementalBoxToTargetT;
		}

		// Token: 0x060329F0 RID: 207344 RVA: 0x006D4624 File Offset: 0x006D2824
		public void UnPackTo(ISetElementalBoxToTargetT _o)
		{
			_o.ElementalBoxId = this.ElementalBoxId;
			_o.Target = new TTargetEntityUnion();
			_o.Target.Type = this.TargetType;
			switch (this.TargetType)
			{
			case TTargetEntity.IPlayerEntity:
				_o.Target.Value = ((this.Target<IPlayerEntity>() != null) ? this.Target<IPlayerEntity>().Value.UnPack() : null);
				return;
			case TTargetEntity.ISelfEntity:
				_o.Target.Value = ((this.Target<ISelfEntity>() != null) ? this.Target<ISelfEntity>().Value.UnPack() : null);
				return;
			case TTargetEntity.ITargetEntity:
				_o.Target.Value = ((this.Target<ITargetEntity>() != null) ? this.Target<ITargetEntity>().Value.UnPack() : null);
				return;
			case TTargetEntity.ITriggeredEntity:
				_o.Target.Value = ((this.Target<ITriggeredEntity>() != null) ? this.Target<ITriggeredEntity>().Value.UnPack() : null);
				return;
			case TTargetEntity.IVehicleEntity:
				_o.Target.Value = ((this.Target<IVehicleEntity>() != null) ? this.Target<IVehicleEntity>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x060329F1 RID: 207345 RVA: 0x006D4790 File Offset: 0x006D2990
		public static Offset<ISetElementalBoxToTarget> Pack(FlatBufferBuilder builder, ISetElementalBoxToTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetElementalBoxToTarget>);
			}
			TTargetEntity target_type = (_o.Target == null) ? TTargetEntity.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.Target);
			return ISetElementalBoxToTarget.CreateISetElementalBoxToTarget(builder, _o.ElementalBoxId, target_type, targetOffset);
		}

		// Token: 0x040119E8 RID: 72168
		private Table __p;
	}
}
