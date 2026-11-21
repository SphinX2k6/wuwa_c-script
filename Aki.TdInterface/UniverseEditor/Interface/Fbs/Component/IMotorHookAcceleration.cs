using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B52 RID: 23378
	public struct IMotorHookAcceleration : IFlatbufferObject
	{
		// Token: 0x1700AAA3 RID: 43683
		// (get) Token: 0x0602676E RID: 157550 RVA: 0x0054477C File Offset: 0x0054297C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602676F RID: 157551 RVA: 0x00544789 File Offset: 0x00542989
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026770 RID: 157552 RVA: 0x00544790 File Offset: 0x00542990
		public static IMotorHookAcceleration GetRootAsIMotorHookAcceleration(ByteBuffer _bb)
		{
			return IMotorHookAcceleration.GetRootAsIMotorHookAcceleration(_bb, default(IMotorHookAcceleration));
		}

		// Token: 0x06026771 RID: 157553 RVA: 0x005447AC File Offset: 0x005429AC
		public static IMotorHookAcceleration GetRootAsIMotorHookAcceleration(ByteBuffer _bb, IMotorHookAcceleration obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026772 RID: 157554 RVA: 0x005447C9 File Offset: 0x005429C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026773 RID: 157555 RVA: 0x005447D8 File Offset: 0x005429D8
		public IMotorHookAcceleration __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AAA4 RID: 43684
		// (get) Token: 0x06026774 RID: 157556 RVA: 0x005447E8 File Offset: 0x005429E8
		public int MaxSpeed
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

		// Token: 0x1700AAA5 RID: 43685
		// (get) Token: 0x06026775 RID: 157557 RVA: 0x00544824 File Offset: 0x00542A24
		public string SpeedSampleCurve
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026776 RID: 157558 RVA: 0x0054485B File Offset: 0x00542A5B
		public Span<byte> GetSpeedSampleCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06026777 RID: 157559 RVA: 0x0054486A File Offset: 0x00542A6A
		public byte[] GetSpeedSampleCurveArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06026778 RID: 157560 RVA: 0x00544878 File Offset: 0x00542A78
		public static Offset<IMotorHookAcceleration> CreateIMotorHookAcceleration(FlatBufferBuilder builder, int MaxSpeed = 0, StringOffset SpeedSampleCurveOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IMotorHookAcceleration.AddSpeedSampleCurve(builder, SpeedSampleCurveOffset);
			IMotorHookAcceleration.AddMaxSpeed(builder, MaxSpeed);
			return IMotorHookAcceleration.EndIMotorHookAcceleration(builder);
		}

		// Token: 0x06026779 RID: 157561 RVA: 0x00544895 File Offset: 0x00542A95
		public static void StartIMotorHookAcceleration(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602677A RID: 157562 RVA: 0x0054489E File Offset: 0x00542A9E
		public static void AddMaxSpeed(FlatBufferBuilder builder, int maxSpeed)
		{
			builder.AddInt(0, maxSpeed, 0);
		}

		// Token: 0x0602677B RID: 157563 RVA: 0x005448A9 File Offset: 0x00542AA9
		public static void AddSpeedSampleCurve(FlatBufferBuilder builder, StringOffset speedSampleCurveOffset)
		{
			builder.AddOffset(1, speedSampleCurveOffset.Value, 0);
		}

		// Token: 0x0602677C RID: 157564 RVA: 0x005448B9 File Offset: 0x00542AB9
		public static Offset<IMotorHookAcceleration> EndIMotorHookAcceleration(FlatBufferBuilder builder)
		{
			return new Offset<IMotorHookAcceleration>(builder.EndTable());
		}

		// Token: 0x0602677D RID: 157565 RVA: 0x005448C8 File Offset: 0x00542AC8
		public IMotorHookAccelerationT UnPack()
		{
			IMotorHookAccelerationT motorHookAccelerationT = new IMotorHookAccelerationT();
			this.UnPackTo(motorHookAccelerationT);
			return motorHookAccelerationT;
		}

		// Token: 0x0602677E RID: 157566 RVA: 0x005448E3 File Offset: 0x00542AE3
		public void UnPackTo(IMotorHookAccelerationT _o)
		{
			_o.MaxSpeed = this.MaxSpeed;
			_o.SpeedSampleCurve = this.SpeedSampleCurve;
		}

		// Token: 0x0602677F RID: 157567 RVA: 0x00544900 File Offset: 0x00542B00
		public static Offset<IMotorHookAcceleration> Pack(FlatBufferBuilder builder, IMotorHookAccelerationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorHookAcceleration>);
			}
			StringOffset speedSampleCurveOffset = (_o.SpeedSampleCurve == null) ? default(StringOffset) : builder.CreateString(_o.SpeedSampleCurve);
			return IMotorHookAcceleration.CreateIMotorHookAcceleration(builder, _o.MaxSpeed, speedSampleCurveOffset);
		}

		// Token: 0x0400F556 RID: 62806
		private Table __p;
	}
}
