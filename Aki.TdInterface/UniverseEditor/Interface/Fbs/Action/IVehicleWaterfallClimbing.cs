using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200753B RID: 30011
	public struct IVehicleWaterfallClimbing : IFlatbufferObject
	{
		// Token: 0x1700E3BA RID: 58298
		// (get) Token: 0x060369A8 RID: 223656 RVA: 0x0076B272 File Offset: 0x00769472
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060369A9 RID: 223657 RVA: 0x0076B27F File Offset: 0x0076947F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060369AA RID: 223658 RVA: 0x0076B288 File Offset: 0x00769488
		public static IVehicleWaterfallClimbing GetRootAsIVehicleWaterfallClimbing(ByteBuffer _bb)
		{
			return IVehicleWaterfallClimbing.GetRootAsIVehicleWaterfallClimbing(_bb, default(IVehicleWaterfallClimbing));
		}

		// Token: 0x060369AB RID: 223659 RVA: 0x0076B2A4 File Offset: 0x007694A4
		public static IVehicleWaterfallClimbing GetRootAsIVehicleWaterfallClimbing(ByteBuffer _bb, IVehicleWaterfallClimbing obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060369AC RID: 223660 RVA: 0x0076B2C1 File Offset: 0x007694C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060369AD RID: 223661 RVA: 0x0076B2D0 File Offset: 0x007694D0
		public IVehicleWaterfallClimbing __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E3BB RID: 58299
		// (get) Token: 0x060369AE RID: 223662 RVA: 0x0076B2E0 File Offset: 0x007694E0
		public int SplineEntityId
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

		// Token: 0x1700E3BC RID: 58300
		// (get) Token: 0x060369AF RID: 223663 RVA: 0x0076B31C File Offset: 0x0076951C
		public IVehicleWaterfallClimbGravityConfig? ChangeGravity
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVehicleWaterfallClimbGravityConfig?(default(IVehicleWaterfallClimbGravityConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060369B0 RID: 223664 RVA: 0x0076B379 File Offset: 0x00769579
		public static Offset<IVehicleWaterfallClimbing> CreateIVehicleWaterfallClimbing(FlatBufferBuilder builder, int SplineEntityId = 0, Offset<IVehicleWaterfallClimbGravityConfig> ChangeGravityOffset = default(Offset<IVehicleWaterfallClimbGravityConfig>))
		{
			builder.StartTable(2);
			IVehicleWaterfallClimbing.AddChangeGravity(builder, ChangeGravityOffset);
			IVehicleWaterfallClimbing.AddSplineEntityId(builder, SplineEntityId);
			return IVehicleWaterfallClimbing.EndIVehicleWaterfallClimbing(builder);
		}

		// Token: 0x060369B1 RID: 223665 RVA: 0x0076B396 File Offset: 0x00769596
		public static void StartIVehicleWaterfallClimbing(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060369B2 RID: 223666 RVA: 0x0076B39F File Offset: 0x0076959F
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(0, splineEntityId, 0);
		}

		// Token: 0x060369B3 RID: 223667 RVA: 0x0076B3AA File Offset: 0x007695AA
		public static void AddChangeGravity(FlatBufferBuilder builder, Offset<IVehicleWaterfallClimbGravityConfig> changeGravityOffset)
		{
			builder.AddOffset(1, changeGravityOffset.Value, 0);
		}

		// Token: 0x060369B4 RID: 223668 RVA: 0x0076B3BA File Offset: 0x007695BA
		public static Offset<IVehicleWaterfallClimbing> EndIVehicleWaterfallClimbing(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleWaterfallClimbing>(builder.EndTable());
		}

		// Token: 0x060369B5 RID: 223669 RVA: 0x0076B3C8 File Offset: 0x007695C8
		public IVehicleWaterfallClimbingT UnPack()
		{
			IVehicleWaterfallClimbingT vehicleWaterfallClimbingT = new IVehicleWaterfallClimbingT();
			this.UnPackTo(vehicleWaterfallClimbingT);
			return vehicleWaterfallClimbingT;
		}

		// Token: 0x060369B6 RID: 223670 RVA: 0x0076B3E4 File Offset: 0x007695E4
		public void UnPackTo(IVehicleWaterfallClimbingT _o)
		{
			_o.SplineEntityId = this.SplineEntityId;
			_o.ChangeGravity = ((this.ChangeGravity != null) ? this.ChangeGravity.Value.UnPack() : null);
		}

		// Token: 0x060369B7 RID: 223671 RVA: 0x0076B42C File Offset: 0x0076962C
		public static Offset<IVehicleWaterfallClimbing> Pack(FlatBufferBuilder builder, IVehicleWaterfallClimbingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleWaterfallClimbing>);
			}
			Offset<IVehicleWaterfallClimbGravityConfig> changeGravityOffset = (_o.ChangeGravity == null) ? default(Offset<IVehicleWaterfallClimbGravityConfig>) : IVehicleWaterfallClimbGravityConfig.Pack(builder, _o.ChangeGravity);
			return IVehicleWaterfallClimbing.CreateIVehicleWaterfallClimbing(builder, _o.SplineEntityId, changeGravityOffset);
		}

		// Token: 0x0401242E RID: 74798
		private Table __p;
	}
}
