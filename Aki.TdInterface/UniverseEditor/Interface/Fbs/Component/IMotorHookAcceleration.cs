using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055B4 RID: 21940
	public struct IMotorHookAcceleration : IFlatbufferObject
	{
		// Token: 0x1700A21B RID: 41499
		// (get) Token: 0x06024561 RID: 148833 RVA: 0x00504204 File Offset: 0x00502404
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024562 RID: 148834 RVA: 0x00504211 File Offset: 0x00502411
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024563 RID: 148835 RVA: 0x00504218 File Offset: 0x00502418
		public static IMotorHookAcceleration GetRootAsIMotorHookAcceleration(ByteBuffer _bb)
		{
			return IMotorHookAcceleration.GetRootAsIMotorHookAcceleration(_bb, default(IMotorHookAcceleration));
		}

		// Token: 0x06024564 RID: 148836 RVA: 0x00504234 File Offset: 0x00502434
		public static IMotorHookAcceleration GetRootAsIMotorHookAcceleration(ByteBuffer _bb, IMotorHookAcceleration obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024565 RID: 148837 RVA: 0x00504251 File Offset: 0x00502451
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024566 RID: 148838 RVA: 0x00504260 File Offset: 0x00502460
		public IMotorHookAcceleration __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A21C RID: 41500
		// (get) Token: 0x06024567 RID: 148839 RVA: 0x00504270 File Offset: 0x00502470
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

		// Token: 0x1700A21D RID: 41501
		// (get) Token: 0x06024568 RID: 148840 RVA: 0x005042AC File Offset: 0x005024AC
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

		// Token: 0x06024569 RID: 148841 RVA: 0x005042E3 File Offset: 0x005024E3
		public Span<byte> GetSpeedSampleCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602456A RID: 148842 RVA: 0x005042F2 File Offset: 0x005024F2
		public byte[] GetSpeedSampleCurveArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602456B RID: 148843 RVA: 0x00504300 File Offset: 0x00502500
		public static Offset<IMotorHookAcceleration> CreateIMotorHookAcceleration(FlatBufferBuilder builder, int MaxSpeed = 0, StringOffset SpeedSampleCurveOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IMotorHookAcceleration.AddSpeedSampleCurve(builder, SpeedSampleCurveOffset);
			IMotorHookAcceleration.AddMaxSpeed(builder, MaxSpeed);
			return IMotorHookAcceleration.EndIMotorHookAcceleration(builder);
		}

		// Token: 0x0602456C RID: 148844 RVA: 0x0050431D File Offset: 0x0050251D
		public static void StartIMotorHookAcceleration(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602456D RID: 148845 RVA: 0x00504326 File Offset: 0x00502526
		public static void AddMaxSpeed(FlatBufferBuilder builder, int maxSpeed)
		{
			builder.AddInt(0, maxSpeed, 0);
		}

		// Token: 0x0602456E RID: 148846 RVA: 0x00504331 File Offset: 0x00502531
		public static void AddSpeedSampleCurve(FlatBufferBuilder builder, StringOffset speedSampleCurveOffset)
		{
			builder.AddOffset(1, speedSampleCurveOffset.Value, 0);
		}

		// Token: 0x0602456F RID: 148847 RVA: 0x00504341 File Offset: 0x00502541
		public static Offset<IMotorHookAcceleration> EndIMotorHookAcceleration(FlatBufferBuilder builder)
		{
			return new Offset<IMotorHookAcceleration>(builder.EndTable());
		}

		// Token: 0x06024570 RID: 148848 RVA: 0x00504350 File Offset: 0x00502550
		public IMotorHookAccelerationT UnPack()
		{
			IMotorHookAccelerationT motorHookAccelerationT = new IMotorHookAccelerationT();
			this.UnPackTo(motorHookAccelerationT);
			return motorHookAccelerationT;
		}

		// Token: 0x06024571 RID: 148849 RVA: 0x0050436B File Offset: 0x0050256B
		public void UnPackTo(IMotorHookAccelerationT _o)
		{
			_o.MaxSpeed = this.MaxSpeed;
			_o.SpeedSampleCurve = this.SpeedSampleCurve;
		}

		// Token: 0x06024572 RID: 148850 RVA: 0x00504388 File Offset: 0x00502588
		public static Offset<IMotorHookAcceleration> Pack(FlatBufferBuilder builder, IMotorHookAccelerationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorHookAcceleration>);
			}
			StringOffset speedSampleCurveOffset = (_o.SpeedSampleCurve == null) ? default(StringOffset) : builder.CreateString(_o.SpeedSampleCurve);
			return IMotorHookAcceleration.CreateIMotorHookAcceleration(builder, _o.MaxSpeed, speedSampleCurveOffset);
		}

		// Token: 0x0400E8F4 RID: 59636
		private Table __p;
	}
}
