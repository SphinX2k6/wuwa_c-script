using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007529 RID: 29993
	public struct IVehiclePlayerMotor : IFlatbufferObject
	{
		// Token: 0x1700E39A RID: 58266
		// (get) Token: 0x0603690B RID: 223499 RVA: 0x00769F64 File Offset: 0x00768164
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603690C RID: 223500 RVA: 0x00769F71 File Offset: 0x00768171
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603690D RID: 223501 RVA: 0x00769F78 File Offset: 0x00768178
		public static IVehiclePlayerMotor GetRootAsIVehiclePlayerMotor(ByteBuffer _bb)
		{
			return IVehiclePlayerMotor.GetRootAsIVehiclePlayerMotor(_bb, default(IVehiclePlayerMotor));
		}

		// Token: 0x0603690E RID: 223502 RVA: 0x00769F94 File Offset: 0x00768194
		public static IVehiclePlayerMotor GetRootAsIVehiclePlayerMotor(ByteBuffer _bb, IVehiclePlayerMotor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603690F RID: 223503 RVA: 0x00769FB1 File Offset: 0x007681B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036910 RID: 223504 RVA: 0x00769FC0 File Offset: 0x007681C0
		public IVehiclePlayerMotor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E39B RID: 58267
		// (get) Token: 0x06036911 RID: 223505 RVA: 0x00769FD0 File Offset: 0x007681D0
		public ETargetVehicle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetVehicle.Current;
				}
				return (ETargetVehicle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E39C RID: 58268
		// (get) Token: 0x06036912 RID: 223506 RVA: 0x0076A00C File Offset: 0x0076820C
		public int SummonPositionEntityId
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

		// Token: 0x1700E39D RID: 58269
		// (get) Token: 0x06036913 RID: 223507 RVA: 0x0076A048 File Offset: 0x00768248
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

		// Token: 0x06036914 RID: 223508 RVA: 0x0076A084 File Offset: 0x00768284
		public static Offset<IVehiclePlayerMotor> CreateIVehiclePlayerMotor(FlatBufferBuilder builder, ETargetVehicle Type = ETargetVehicle.Current, int SummonPositionEntityId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IVehiclePlayerMotor.AddSummonPositionEntityId(builder, SummonPositionEntityId);
			IVehiclePlayerMotor.AddNullMask(builder, NullMask);
			IVehiclePlayerMotor.AddType(builder, Type);
			return IVehiclePlayerMotor.EndIVehiclePlayerMotor(builder);
		}

		// Token: 0x06036915 RID: 223509 RVA: 0x0076A0A8 File Offset: 0x007682A8
		public static void StartIVehiclePlayerMotor(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06036916 RID: 223510 RVA: 0x0076A0B1 File Offset: 0x007682B1
		public static void AddType(FlatBufferBuilder builder, ETargetVehicle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036917 RID: 223511 RVA: 0x0076A0BC File Offset: 0x007682BC
		public static void AddSummonPositionEntityId(FlatBufferBuilder builder, int summonPositionEntityId)
		{
			builder.AddInt(1, summonPositionEntityId, 0);
		}

		// Token: 0x06036918 RID: 223512 RVA: 0x0076A0C7 File Offset: 0x007682C7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06036919 RID: 223513 RVA: 0x0076A0D2 File Offset: 0x007682D2
		public static Offset<IVehiclePlayerMotor> EndIVehiclePlayerMotor(FlatBufferBuilder builder)
		{
			return new Offset<IVehiclePlayerMotor>(builder.EndTable());
		}

		// Token: 0x0603691A RID: 223514 RVA: 0x0076A0E0 File Offset: 0x007682E0
		public IVehiclePlayerMotorT UnPack()
		{
			IVehiclePlayerMotorT vehiclePlayerMotorT = new IVehiclePlayerMotorT();
			this.UnPackTo(vehiclePlayerMotorT);
			return vehiclePlayerMotorT;
		}

		// Token: 0x0603691B RID: 223515 RVA: 0x0076A0FB File Offset: 0x007682FB
		public void UnPackTo(IVehiclePlayerMotorT _o)
		{
			_o.Type = this.Type;
			_o.SummonPositionEntityId = this.SummonPositionEntityId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603691C RID: 223516 RVA: 0x0076A124 File Offset: 0x00768324
		public static Offset<IVehiclePlayerMotor> Pack(FlatBufferBuilder builder, IVehiclePlayerMotorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehiclePlayerMotor>);
			}
			return IVehiclePlayerMotor.CreateIVehiclePlayerMotor(builder, _o.Type, _o.SummonPositionEntityId, _o.NullMask);
		}

		// Token: 0x0401241B RID: 74779
		private Table __p;
	}
}
