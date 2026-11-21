using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D31 RID: 32049
	public struct IVehicleWaterfallClimbing : IFlatbufferObject
	{
		// Token: 0x1700EFE4 RID: 61412
		// (get) Token: 0x06039DBE RID: 236990 RVA: 0x007CE51A File Offset: 0x007CC71A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039DBF RID: 236991 RVA: 0x007CE527 File Offset: 0x007CC727
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039DC0 RID: 236992 RVA: 0x007CE530 File Offset: 0x007CC730
		public static IVehicleWaterfallClimbing GetRootAsIVehicleWaterfallClimbing(ByteBuffer _bb)
		{
			return IVehicleWaterfallClimbing.GetRootAsIVehicleWaterfallClimbing(_bb, default(IVehicleWaterfallClimbing));
		}

		// Token: 0x06039DC1 RID: 236993 RVA: 0x007CE54C File Offset: 0x007CC74C
		public static IVehicleWaterfallClimbing GetRootAsIVehicleWaterfallClimbing(ByteBuffer _bb, IVehicleWaterfallClimbing obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039DC2 RID: 236994 RVA: 0x007CE569 File Offset: 0x007CC769
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039DC3 RID: 236995 RVA: 0x007CE578 File Offset: 0x007CC778
		public IVehicleWaterfallClimbing __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EFE5 RID: 61413
		// (get) Token: 0x06039DC4 RID: 236996 RVA: 0x007CE588 File Offset: 0x007CC788
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

		// Token: 0x1700EFE6 RID: 61414
		// (get) Token: 0x06039DC5 RID: 236997 RVA: 0x007CE5C4 File Offset: 0x007CC7C4
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

		// Token: 0x06039DC6 RID: 236998 RVA: 0x007CE621 File Offset: 0x007CC821
		public static Offset<IVehicleWaterfallClimbing> CreateIVehicleWaterfallClimbing(FlatBufferBuilder builder, int SplineEntityId = 0, Offset<IVehicleWaterfallClimbGravityConfig> ChangeGravityOffset = default(Offset<IVehicleWaterfallClimbGravityConfig>))
		{
			builder.StartTable(2);
			IVehicleWaterfallClimbing.AddChangeGravity(builder, ChangeGravityOffset);
			IVehicleWaterfallClimbing.AddSplineEntityId(builder, SplineEntityId);
			return IVehicleWaterfallClimbing.EndIVehicleWaterfallClimbing(builder);
		}

		// Token: 0x06039DC7 RID: 236999 RVA: 0x007CE63E File Offset: 0x007CC83E
		public static void StartIVehicleWaterfallClimbing(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06039DC8 RID: 237000 RVA: 0x007CE647 File Offset: 0x007CC847
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(0, splineEntityId, 0);
		}

		// Token: 0x06039DC9 RID: 237001 RVA: 0x007CE652 File Offset: 0x007CC852
		public static void AddChangeGravity(FlatBufferBuilder builder, Offset<IVehicleWaterfallClimbGravityConfig> changeGravityOffset)
		{
			builder.AddOffset(1, changeGravityOffset.Value, 0);
		}

		// Token: 0x06039DCA RID: 237002 RVA: 0x007CE662 File Offset: 0x007CC862
		public static Offset<IVehicleWaterfallClimbing> EndIVehicleWaterfallClimbing(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleWaterfallClimbing>(builder.EndTable());
		}

		// Token: 0x06039DCB RID: 237003 RVA: 0x007CE670 File Offset: 0x007CC870
		public IVehicleWaterfallClimbingT UnPack()
		{
			IVehicleWaterfallClimbingT vehicleWaterfallClimbingT = new IVehicleWaterfallClimbingT();
			this.UnPackTo(vehicleWaterfallClimbingT);
			return vehicleWaterfallClimbingT;
		}

		// Token: 0x06039DCC RID: 237004 RVA: 0x007CE68C File Offset: 0x007CC88C
		public void UnPackTo(IVehicleWaterfallClimbingT _o)
		{
			_o.SplineEntityId = this.SplineEntityId;
			_o.ChangeGravity = ((this.ChangeGravity != null) ? this.ChangeGravity.Value.UnPack() : null);
		}

		// Token: 0x06039DCD RID: 237005 RVA: 0x007CE6D4 File Offset: 0x007CC8D4
		public static Offset<IVehicleWaterfallClimbing> Pack(FlatBufferBuilder builder, IVehicleWaterfallClimbingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleWaterfallClimbing>);
			}
			Offset<IVehicleWaterfallClimbGravityConfig> changeGravityOffset = (_o.ChangeGravity == null) ? default(Offset<IVehicleWaterfallClimbGravityConfig>) : IVehicleWaterfallClimbGravityConfig.Pack(builder, _o.ChangeGravity);
			return IVehicleWaterfallClimbing.CreateIVehicleWaterfallClimbing(builder, _o.SplineEntityId, changeGravityOffset);
		}

		// Token: 0x0401345F RID: 78943
		private Table __p;
	}
}
