using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ACB RID: 23243
	public struct IMechHookAcceleration : IFlatbufferObject
	{
		// Token: 0x1700A973 RID: 43379
		// (get) Token: 0x0602621B RID: 156187 RVA: 0x005397FF File Offset: 0x005379FF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602621C RID: 156188 RVA: 0x0053980C File Offset: 0x00537A0C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602621D RID: 156189 RVA: 0x00539814 File Offset: 0x00537A14
		public static IMechHookAcceleration GetRootAsIMechHookAcceleration(ByteBuffer _bb)
		{
			return IMechHookAcceleration.GetRootAsIMechHookAcceleration(_bb, default(IMechHookAcceleration));
		}

		// Token: 0x0602621E RID: 156190 RVA: 0x00539830 File Offset: 0x00537A30
		public static IMechHookAcceleration GetRootAsIMechHookAcceleration(ByteBuffer _bb, IMechHookAcceleration obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602621F RID: 156191 RVA: 0x0053984D File Offset: 0x00537A4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026220 RID: 156192 RVA: 0x0053985C File Offset: 0x00537A5C
		public IMechHookAcceleration __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A974 RID: 43380
		// (get) Token: 0x06026221 RID: 156193 RVA: 0x0053986C File Offset: 0x00537A6C
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

		// Token: 0x1700A975 RID: 43381
		// (get) Token: 0x06026222 RID: 156194 RVA: 0x005398A8 File Offset: 0x00537AA8
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

		// Token: 0x06026223 RID: 156195 RVA: 0x005398DF File Offset: 0x00537ADF
		public Span<byte> GetSpeedSampleCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06026224 RID: 156196 RVA: 0x005398EE File Offset: 0x00537AEE
		public byte[] GetSpeedSampleCurveArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06026225 RID: 156197 RVA: 0x005398FC File Offset: 0x00537AFC
		public static Offset<IMechHookAcceleration> CreateIMechHookAcceleration(FlatBufferBuilder builder, int MaxSpeed = 0, StringOffset SpeedSampleCurveOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IMechHookAcceleration.AddSpeedSampleCurve(builder, SpeedSampleCurveOffset);
			IMechHookAcceleration.AddMaxSpeed(builder, MaxSpeed);
			return IMechHookAcceleration.EndIMechHookAcceleration(builder);
		}

		// Token: 0x06026226 RID: 156198 RVA: 0x00539919 File Offset: 0x00537B19
		public static void StartIMechHookAcceleration(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06026227 RID: 156199 RVA: 0x00539922 File Offset: 0x00537B22
		public static void AddMaxSpeed(FlatBufferBuilder builder, int maxSpeed)
		{
			builder.AddInt(0, maxSpeed, 0);
		}

		// Token: 0x06026228 RID: 156200 RVA: 0x0053992D File Offset: 0x00537B2D
		public static void AddSpeedSampleCurve(FlatBufferBuilder builder, StringOffset speedSampleCurveOffset)
		{
			builder.AddOffset(1, speedSampleCurveOffset.Value, 0);
		}

		// Token: 0x06026229 RID: 156201 RVA: 0x0053993D File Offset: 0x00537B3D
		public static Offset<IMechHookAcceleration> EndIMechHookAcceleration(FlatBufferBuilder builder)
		{
			return new Offset<IMechHookAcceleration>(builder.EndTable());
		}

		// Token: 0x0602622A RID: 156202 RVA: 0x0053994C File Offset: 0x00537B4C
		public IMechHookAccelerationT UnPack()
		{
			IMechHookAccelerationT mechHookAccelerationT = new IMechHookAccelerationT();
			this.UnPackTo(mechHookAccelerationT);
			return mechHookAccelerationT;
		}

		// Token: 0x0602622B RID: 156203 RVA: 0x00539967 File Offset: 0x00537B67
		public void UnPackTo(IMechHookAccelerationT _o)
		{
			_o.MaxSpeed = this.MaxSpeed;
			_o.SpeedSampleCurve = this.SpeedSampleCurve;
		}

		// Token: 0x0602622C RID: 156204 RVA: 0x00539984 File Offset: 0x00537B84
		public static Offset<IMechHookAcceleration> Pack(FlatBufferBuilder builder, IMechHookAccelerationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechHookAcceleration>);
			}
			StringOffset speedSampleCurveOffset = (_o.SpeedSampleCurve == null) ? default(StringOffset) : builder.CreateString(_o.SpeedSampleCurve);
			return IMechHookAcceleration.CreateIMechHookAcceleration(builder, _o.MaxSpeed, speedSampleCurveOffset);
		}

		// Token: 0x0400F47F RID: 62591
		private Table __p;
	}
}
