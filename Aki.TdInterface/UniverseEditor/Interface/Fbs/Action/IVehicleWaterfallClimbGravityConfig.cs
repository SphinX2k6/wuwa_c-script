using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007538 RID: 30008
	public struct IVehicleWaterfallClimbGravityConfig : IFlatbufferObject
	{
		// Token: 0x1700E3B5 RID: 58293
		// (get) Token: 0x06036992 RID: 223634 RVA: 0x0076B072 File Offset: 0x00769272
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036993 RID: 223635 RVA: 0x0076B07F File Offset: 0x0076927F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036994 RID: 223636 RVA: 0x0076B088 File Offset: 0x00769288
		public static IVehicleWaterfallClimbGravityConfig GetRootAsIVehicleWaterfallClimbGravityConfig(ByteBuffer _bb)
		{
			return IVehicleWaterfallClimbGravityConfig.GetRootAsIVehicleWaterfallClimbGravityConfig(_bb, default(IVehicleWaterfallClimbGravityConfig));
		}

		// Token: 0x06036995 RID: 223637 RVA: 0x0076B0A4 File Offset: 0x007692A4
		public static IVehicleWaterfallClimbGravityConfig GetRootAsIVehicleWaterfallClimbGravityConfig(ByteBuffer _bb, IVehicleWaterfallClimbGravityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036996 RID: 223638 RVA: 0x0076B0C1 File Offset: 0x007692C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036997 RID: 223639 RVA: 0x0076B0D0 File Offset: 0x007692D0
		public IVehicleWaterfallClimbGravityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E3B6 RID: 58294
		// (get) Token: 0x06036998 RID: 223640 RVA: 0x0076B0E0 File Offset: 0x007692E0
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

		// Token: 0x1700E3B7 RID: 58295
		// (get) Token: 0x06036999 RID: 223641 RVA: 0x0076B11C File Offset: 0x0076931C
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

		// Token: 0x0603699A RID: 223642 RVA: 0x0076B158 File Offset: 0x00769358
		public static Offset<IVehicleWaterfallClimbGravityConfig> CreateIVehicleWaterfallClimbGravityConfig(FlatBufferBuilder builder, int SafePositionEntityId = 0, EWorldAxisType GravityDirection = EWorldAxisType.PositiveX)
		{
			builder.StartTable(2);
			IVehicleWaterfallClimbGravityConfig.AddSafePositionEntityId(builder, SafePositionEntityId);
			IVehicleWaterfallClimbGravityConfig.AddGravityDirection(builder, GravityDirection);
			return IVehicleWaterfallClimbGravityConfig.EndIVehicleWaterfallClimbGravityConfig(builder);
		}

		// Token: 0x0603699B RID: 223643 RVA: 0x0076B175 File Offset: 0x00769375
		public static void StartIVehicleWaterfallClimbGravityConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603699C RID: 223644 RVA: 0x0076B17E File Offset: 0x0076937E
		public static void AddSafePositionEntityId(FlatBufferBuilder builder, int safePositionEntityId)
		{
			builder.AddInt(0, safePositionEntityId, 0);
		}

		// Token: 0x0603699D RID: 223645 RVA: 0x0076B189 File Offset: 0x00769389
		public static void AddGravityDirection(FlatBufferBuilder builder, EWorldAxisType gravityDirection)
		{
			builder.AddByte(1, (byte)gravityDirection, 0);
		}

		// Token: 0x0603699E RID: 223646 RVA: 0x0076B194 File Offset: 0x00769394
		public static Offset<IVehicleWaterfallClimbGravityConfig> EndIVehicleWaterfallClimbGravityConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleWaterfallClimbGravityConfig>(builder.EndTable());
		}

		// Token: 0x0603699F RID: 223647 RVA: 0x0076B1A4 File Offset: 0x007693A4
		public IVehicleWaterfallClimbGravityConfigT UnPack()
		{
			IVehicleWaterfallClimbGravityConfigT vehicleWaterfallClimbGravityConfigT = new IVehicleWaterfallClimbGravityConfigT();
			this.UnPackTo(vehicleWaterfallClimbGravityConfigT);
			return vehicleWaterfallClimbGravityConfigT;
		}

		// Token: 0x060369A0 RID: 223648 RVA: 0x0076B1BF File Offset: 0x007693BF
		public void UnPackTo(IVehicleWaterfallClimbGravityConfigT _o)
		{
			_o.SafePositionEntityId = this.SafePositionEntityId;
			_o.GravityDirection = this.GravityDirection;
		}

		// Token: 0x060369A1 RID: 223649 RVA: 0x0076B1DC File Offset: 0x007693DC
		public static Offset<IVehicleWaterfallClimbGravityConfig> Pack(FlatBufferBuilder builder, IVehicleWaterfallClimbGravityConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleWaterfallClimbGravityConfig>);
			}
			return IVehicleWaterfallClimbGravityConfig.CreateIVehicleWaterfallClimbGravityConfig(builder, _o.SafePositionEntityId, _o.GravityDirection);
		}

		// Token: 0x0401242B RID: 74795
		private Table __p;
	}
}
