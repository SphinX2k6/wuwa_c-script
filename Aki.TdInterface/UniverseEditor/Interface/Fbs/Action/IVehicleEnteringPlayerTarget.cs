using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007508 RID: 29960
	public struct IVehicleEnteringPlayerTarget : IFlatbufferObject
	{
		// Token: 0x1700E358 RID: 58200
		// (get) Token: 0x060367C2 RID: 223170 RVA: 0x00766D30 File Offset: 0x00764F30
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060367C3 RID: 223171 RVA: 0x00766D3D File Offset: 0x00764F3D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060367C4 RID: 223172 RVA: 0x00766D44 File Offset: 0x00764F44
		public static IVehicleEnteringPlayerTarget GetRootAsIVehicleEnteringPlayerTarget(ByteBuffer _bb)
		{
			return IVehicleEnteringPlayerTarget.GetRootAsIVehicleEnteringPlayerTarget(_bb, default(IVehicleEnteringPlayerTarget));
		}

		// Token: 0x060367C5 RID: 223173 RVA: 0x00766D60 File Offset: 0x00764F60
		public static IVehicleEnteringPlayerTarget GetRootAsIVehicleEnteringPlayerTarget(ByteBuffer _bb, IVehicleEnteringPlayerTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060367C6 RID: 223174 RVA: 0x00766D7D File Offset: 0x00764F7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060367C7 RID: 223175 RVA: 0x00766D8C File Offset: 0x00764F8C
		public IVehicleEnteringPlayerTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E359 RID: 58201
		// (get) Token: 0x060367C8 RID: 223176 RVA: 0x00766D9C File Offset: 0x00764F9C
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

		// Token: 0x1700E35A RID: 58202
		// (get) Token: 0x060367C9 RID: 223177 RVA: 0x00766DD8 File Offset: 0x00764FD8
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

		// Token: 0x1700E35B RID: 58203
		// (get) Token: 0x060367CA RID: 223178 RVA: 0x00766E14 File Offset: 0x00765014
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

		// Token: 0x060367CB RID: 223179 RVA: 0x00766E50 File Offset: 0x00765050
		public static Offset<IVehicleEnteringPlayerTarget> CreateIVehicleEnteringPlayerTarget(FlatBufferBuilder builder, EVehicleEnteringTarget Type = EVehicleEnteringTarget.Player, int TargetVehicle = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IVehicleEnteringPlayerTarget.AddTargetVehicle(builder, TargetVehicle);
			IVehicleEnteringPlayerTarget.AddNullMask(builder, NullMask);
			IVehicleEnteringPlayerTarget.AddType(builder, Type);
			return IVehicleEnteringPlayerTarget.EndIVehicleEnteringPlayerTarget(builder);
		}

		// Token: 0x060367CC RID: 223180 RVA: 0x00766E74 File Offset: 0x00765074
		public static void StartIVehicleEnteringPlayerTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060367CD RID: 223181 RVA: 0x00766E7D File Offset: 0x0076507D
		public static void AddType(FlatBufferBuilder builder, EVehicleEnteringTarget type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060367CE RID: 223182 RVA: 0x00766E88 File Offset: 0x00765088
		public static void AddTargetVehicle(FlatBufferBuilder builder, int targetVehicle)
		{
			builder.AddInt(1, targetVehicle, 0);
		}

		// Token: 0x060367CF RID: 223183 RVA: 0x00766E93 File Offset: 0x00765093
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060367D0 RID: 223184 RVA: 0x00766E9E File Offset: 0x0076509E
		public static Offset<IVehicleEnteringPlayerTarget> EndIVehicleEnteringPlayerTarget(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleEnteringPlayerTarget>(builder.EndTable());
		}

		// Token: 0x060367D1 RID: 223185 RVA: 0x00766EAC File Offset: 0x007650AC
		public IVehicleEnteringPlayerTargetT UnPack()
		{
			IVehicleEnteringPlayerTargetT vehicleEnteringPlayerTargetT = new IVehicleEnteringPlayerTargetT();
			this.UnPackTo(vehicleEnteringPlayerTargetT);
			return vehicleEnteringPlayerTargetT;
		}

		// Token: 0x060367D2 RID: 223186 RVA: 0x00766EC7 File Offset: 0x007650C7
		public void UnPackTo(IVehicleEnteringPlayerTargetT _o)
		{
			_o.Type = this.Type;
			_o.TargetVehicle = this.TargetVehicle;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060367D3 RID: 223187 RVA: 0x00766EF0 File Offset: 0x007650F0
		public static Offset<IVehicleEnteringPlayerTarget> Pack(FlatBufferBuilder builder, IVehicleEnteringPlayerTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleEnteringPlayerTarget>);
			}
			return IVehicleEnteringPlayerTarget.CreateIVehicleEnteringPlayerTarget(builder, _o.Type, _o.TargetVehicle, _o.NullMask);
		}

		// Token: 0x040123EF RID: 74735
		private Table __p;
	}
}
