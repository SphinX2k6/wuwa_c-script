using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D2E RID: 32046
	public struct IVehicleWaterfallClimbGravityConfig : IFlatbufferObject
	{
		// Token: 0x1700EFDF RID: 61407
		// (get) Token: 0x06039DA8 RID: 236968 RVA: 0x007CE31A File Offset: 0x007CC51A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039DA9 RID: 236969 RVA: 0x007CE327 File Offset: 0x007CC527
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039DAA RID: 236970 RVA: 0x007CE330 File Offset: 0x007CC530
		public static IVehicleWaterfallClimbGravityConfig GetRootAsIVehicleWaterfallClimbGravityConfig(ByteBuffer _bb)
		{
			return IVehicleWaterfallClimbGravityConfig.GetRootAsIVehicleWaterfallClimbGravityConfig(_bb, default(IVehicleWaterfallClimbGravityConfig));
		}

		// Token: 0x06039DAB RID: 236971 RVA: 0x007CE34C File Offset: 0x007CC54C
		public static IVehicleWaterfallClimbGravityConfig GetRootAsIVehicleWaterfallClimbGravityConfig(ByteBuffer _bb, IVehicleWaterfallClimbGravityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039DAC RID: 236972 RVA: 0x007CE369 File Offset: 0x007CC569
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039DAD RID: 236973 RVA: 0x007CE378 File Offset: 0x007CC578
		public IVehicleWaterfallClimbGravityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EFE0 RID: 61408
		// (get) Token: 0x06039DAE RID: 236974 RVA: 0x007CE388 File Offset: 0x007CC588
		public int SafePositionEntityId
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

		// Token: 0x1700EFE1 RID: 61409
		// (get) Token: 0x06039DAF RID: 236975 RVA: 0x007CE3C4 File Offset: 0x007CC5C4
		public EWorldAxisType GravityDirection
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EWorldAxisType.PositiveX;
				}
				return (EWorldAxisType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039DB0 RID: 236976 RVA: 0x007CE400 File Offset: 0x007CC600
		public static Offset<IVehicleWaterfallClimbGravityConfig> CreateIVehicleWaterfallClimbGravityConfig(FlatBufferBuilder builder, int SafePositionEntityId = 0, EWorldAxisType GravityDirection = EWorldAxisType.PositiveX)
		{
			builder.StartTable(2);
			IVehicleWaterfallClimbGravityConfig.AddSafePositionEntityId(builder, SafePositionEntityId);
			IVehicleWaterfallClimbGravityConfig.AddGravityDirection(builder, GravityDirection);
			return IVehicleWaterfallClimbGravityConfig.EndIVehicleWaterfallClimbGravityConfig(builder);
		}

		// Token: 0x06039DB1 RID: 236977 RVA: 0x007CE41D File Offset: 0x007CC61D
		public static void StartIVehicleWaterfallClimbGravityConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06039DB2 RID: 236978 RVA: 0x007CE426 File Offset: 0x007CC626
		public static void AddSafePositionEntityId(FlatBufferBuilder builder, int safePositionEntityId)
		{
			builder.AddInt(0, safePositionEntityId, 0);
		}

		// Token: 0x06039DB3 RID: 236979 RVA: 0x007CE431 File Offset: 0x007CC631
		public static void AddGravityDirection(FlatBufferBuilder builder, EWorldAxisType gravityDirection)
		{
			builder.AddByte(1, (byte)gravityDirection, 0);
		}

		// Token: 0x06039DB4 RID: 236980 RVA: 0x007CE43C File Offset: 0x007CC63C
		public static Offset<IVehicleWaterfallClimbGravityConfig> EndIVehicleWaterfallClimbGravityConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleWaterfallClimbGravityConfig>(builder.EndTable());
		}

		// Token: 0x06039DB5 RID: 236981 RVA: 0x007CE44C File Offset: 0x007CC64C
		public IVehicleWaterfallClimbGravityConfigT UnPack()
		{
			IVehicleWaterfallClimbGravityConfigT vehicleWaterfallClimbGravityConfigT = new IVehicleWaterfallClimbGravityConfigT();
			this.UnPackTo(vehicleWaterfallClimbGravityConfigT);
			return vehicleWaterfallClimbGravityConfigT;
		}

		// Token: 0x06039DB6 RID: 236982 RVA: 0x007CE467 File Offset: 0x007CC667
		public void UnPackTo(IVehicleWaterfallClimbGravityConfigT _o)
		{
			_o.SafePositionEntityId = this.SafePositionEntityId;
			_o.GravityDirection = this.GravityDirection;
		}

		// Token: 0x06039DB7 RID: 236983 RVA: 0x007CE484 File Offset: 0x007CC684
		public static Offset<IVehicleWaterfallClimbGravityConfig> Pack(FlatBufferBuilder builder, IVehicleWaterfallClimbGravityConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleWaterfallClimbGravityConfig>);
			}
			return IVehicleWaterfallClimbGravityConfig.CreateIVehicleWaterfallClimbGravityConfig(builder, _o.SafePositionEntityId, _o.GravityDirection);
		}

		// Token: 0x0401345C RID: 78940
		private Table __p;
	}
}
