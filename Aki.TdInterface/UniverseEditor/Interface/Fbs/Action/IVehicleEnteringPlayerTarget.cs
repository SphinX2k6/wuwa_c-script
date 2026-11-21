using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CFE RID: 31998
	public struct IVehicleEnteringPlayerTarget : IFlatbufferObject
	{
		// Token: 0x1700EF82 RID: 61314
		// (get) Token: 0x06039BD7 RID: 236503 RVA: 0x007C9F80 File Offset: 0x007C8180
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039BD8 RID: 236504 RVA: 0x007C9F8D File Offset: 0x007C818D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039BD9 RID: 236505 RVA: 0x007C9F94 File Offset: 0x007C8194
		public static IVehicleEnteringPlayerTarget GetRootAsIVehicleEnteringPlayerTarget(ByteBuffer _bb)
		{
			return IVehicleEnteringPlayerTarget.GetRootAsIVehicleEnteringPlayerTarget(_bb, default(IVehicleEnteringPlayerTarget));
		}

		// Token: 0x06039BDA RID: 236506 RVA: 0x007C9FB0 File Offset: 0x007C81B0
		public static IVehicleEnteringPlayerTarget GetRootAsIVehicleEnteringPlayerTarget(ByteBuffer _bb, IVehicleEnteringPlayerTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039BDB RID: 236507 RVA: 0x007C9FCD File Offset: 0x007C81CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039BDC RID: 236508 RVA: 0x007C9FDC File Offset: 0x007C81DC
		public IVehicleEnteringPlayerTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EF83 RID: 61315
		// (get) Token: 0x06039BDD RID: 236509 RVA: 0x007C9FEC File Offset: 0x007C81EC
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

		// Token: 0x1700EF84 RID: 61316
		// (get) Token: 0x06039BDE RID: 236510 RVA: 0x007CA028 File Offset: 0x007C8228
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

		// Token: 0x1700EF85 RID: 61317
		// (get) Token: 0x06039BDF RID: 236511 RVA: 0x007CA064 File Offset: 0x007C8264
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

		// Token: 0x06039BE0 RID: 236512 RVA: 0x007CA0A0 File Offset: 0x007C82A0
		public static Offset<IVehicleEnteringPlayerTarget> CreateIVehicleEnteringPlayerTarget(FlatBufferBuilder builder, EVehicleEnteringTarget Type = EVehicleEnteringTarget.Player, int TargetVehicle = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IVehicleEnteringPlayerTarget.AddTargetVehicle(builder, TargetVehicle);
			IVehicleEnteringPlayerTarget.AddNullMask(builder, NullMask);
			IVehicleEnteringPlayerTarget.AddType(builder, Type);
			return IVehicleEnteringPlayerTarget.EndIVehicleEnteringPlayerTarget(builder);
		}

		// Token: 0x06039BE1 RID: 236513 RVA: 0x007CA0C4 File Offset: 0x007C82C4
		public static void StartIVehicleEnteringPlayerTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06039BE2 RID: 236514 RVA: 0x007CA0CD File Offset: 0x007C82CD
		public static void AddType(FlatBufferBuilder builder, EVehicleEnteringTarget type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039BE3 RID: 236515 RVA: 0x007CA0D8 File Offset: 0x007C82D8
		public static void AddTargetVehicle(FlatBufferBuilder builder, int targetVehicle)
		{
			builder.AddInt(1, targetVehicle, 0);
		}

		// Token: 0x06039BE4 RID: 236516 RVA: 0x007CA0E3 File Offset: 0x007C82E3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06039BE5 RID: 236517 RVA: 0x007CA0EE File Offset: 0x007C82EE
		public static Offset<IVehicleEnteringPlayerTarget> EndIVehicleEnteringPlayerTarget(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleEnteringPlayerTarget>(builder.EndTable());
		}

		// Token: 0x06039BE6 RID: 236518 RVA: 0x007CA0FC File Offset: 0x007C82FC
		public IVehicleEnteringPlayerTargetT UnPack()
		{
			IVehicleEnteringPlayerTargetT vehicleEnteringPlayerTargetT = new IVehicleEnteringPlayerTargetT();
			this.UnPackTo(vehicleEnteringPlayerTargetT);
			return vehicleEnteringPlayerTargetT;
		}

		// Token: 0x06039BE7 RID: 236519 RVA: 0x007CA117 File Offset: 0x007C8317
		public void UnPackTo(IVehicleEnteringPlayerTargetT _o)
		{
			_o.Type = this.Type;
			_o.TargetVehicle = this.TargetVehicle;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06039BE8 RID: 236520 RVA: 0x007CA140 File Offset: 0x007C8340
		public static Offset<IVehicleEnteringPlayerTarget> Pack(FlatBufferBuilder builder, IVehicleEnteringPlayerTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleEnteringPlayerTarget>);
			}
			return IVehicleEnteringPlayerTarget.CreateIVehicleEnteringPlayerTarget(builder, _o.Type, _o.TargetVehicle, _o.NullMask);
		}

		// Token: 0x04013420 RID: 78880
		private Table __p;
	}
}
