using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D01 RID: 32001
	public struct IVehicleEnteringTarget : IFlatbufferObject
	{
		// Token: 0x1700EF89 RID: 61321
		// (get) Token: 0x06039BF1 RID: 236529 RVA: 0x007CA210 File Offset: 0x007C8410
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039BF2 RID: 236530 RVA: 0x007CA21D File Offset: 0x007C841D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039BF3 RID: 236531 RVA: 0x007CA224 File Offset: 0x007C8424
		public static IVehicleEnteringTarget GetRootAsIVehicleEnteringTarget(ByteBuffer _bb)
		{
			return IVehicleEnteringTarget.GetRootAsIVehicleEnteringTarget(_bb, default(IVehicleEnteringTarget));
		}

		// Token: 0x06039BF4 RID: 236532 RVA: 0x007CA240 File Offset: 0x007C8440
		public static IVehicleEnteringTarget GetRootAsIVehicleEnteringTarget(ByteBuffer _bb, IVehicleEnteringTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039BF5 RID: 236533 RVA: 0x007CA25D File Offset: 0x007C845D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039BF6 RID: 236534 RVA: 0x007CA26C File Offset: 0x007C846C
		public IVehicleEnteringTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EF8A RID: 61322
		// (get) Token: 0x06039BF7 RID: 236535 RVA: 0x007CA27C File Offset: 0x007C847C
		public EVehicleEnteringTarget Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVehicleEnteringTarget.Player;
				}
				return (EVehicleEnteringTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700EF8B RID: 61323
		// (get) Token: 0x06039BF8 RID: 236536 RVA: 0x007CA2B8 File Offset: 0x007C84B8
		public int TargetVehicle
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700EF8C RID: 61324
		// (get) Token: 0x06039BF9 RID: 236537 RVA: 0x007CA2F4 File Offset: 0x007C84F4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039BFA RID: 236538 RVA: 0x007CA330 File Offset: 0x007C8530
		public static Offset<IVehicleEnteringTarget> CreateIVehicleEnteringTarget(FlatBufferBuilder builder, EVehicleEnteringTarget Type = EVehicleEnteringTarget.Player, int TargetVehicle = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IVehicleEnteringTarget.AddTargetVehicle(builder, TargetVehicle);
			IVehicleEnteringTarget.AddNullMask(builder, NullMask);
			IVehicleEnteringTarget.AddType(builder, Type);
			return IVehicleEnteringTarget.EndIVehicleEnteringTarget(builder);
		}

		// Token: 0x06039BFB RID: 236539 RVA: 0x007CA354 File Offset: 0x007C8554
		public static void StartIVehicleEnteringTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06039BFC RID: 236540 RVA: 0x007CA35D File Offset: 0x007C855D
		public static void AddType(FlatBufferBuilder builder, EVehicleEnteringTarget type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039BFD RID: 236541 RVA: 0x007CA368 File Offset: 0x007C8568
		public static void AddTargetVehicle(FlatBufferBuilder builder, int targetVehicle)
		{
			builder.AddInt(1, targetVehicle, 0);
		}

		// Token: 0x06039BFE RID: 236542 RVA: 0x007CA373 File Offset: 0x007C8573
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06039BFF RID: 236543 RVA: 0x007CA37E File Offset: 0x007C857E
		public static Offset<IVehicleEnteringTarget> EndIVehicleEnteringTarget(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleEnteringTarget>(builder.EndTable());
		}

		// Token: 0x06039C00 RID: 236544 RVA: 0x007CA38C File Offset: 0x007C858C
		public IVehicleEnteringTargetT UnPack()
		{
			IVehicleEnteringTargetT vehicleEnteringTargetT = new IVehicleEnteringTargetT();
			this.UnPackTo(vehicleEnteringTargetT);
			return vehicleEnteringTargetT;
		}

		// Token: 0x06039C01 RID: 236545 RVA: 0x007CA3A7 File Offset: 0x007C85A7
		public void UnPackTo(IVehicleEnteringTargetT _o)
		{
			_o.Type = this.Type;
			_o.TargetVehicle = this.TargetVehicle;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06039C02 RID: 236546 RVA: 0x007CA3D0 File Offset: 0x007C85D0
		public static Offset<IVehicleEnteringTarget> Pack(FlatBufferBuilder builder, IVehicleEnteringTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleEnteringTarget>);
			}
			return IVehicleEnteringTarget.CreateIVehicleEnteringTarget(builder, _o.Type, _o.TargetVehicle, _o.NullMask);
		}

		// Token: 0x04013424 RID: 78884
		private Table __p;
	}
}
