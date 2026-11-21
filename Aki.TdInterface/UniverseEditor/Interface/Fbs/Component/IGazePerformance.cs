using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005877 RID: 22647
	public struct IGazePerformance : IFlatbufferObject
	{
		// Token: 0x1700A40C RID: 41996
		// (get) Token: 0x06024B52 RID: 150354 RVA: 0x0050ADAF File Offset: 0x00508FAF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024B53 RID: 150355 RVA: 0x0050ADBC File Offset: 0x00508FBC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024B54 RID: 150356 RVA: 0x0050ADC4 File Offset: 0x00508FC4
		public static IGazePerformance GetRootAsIGazePerformance(ByteBuffer _bb)
		{
			return IGazePerformance.GetRootAsIGazePerformance(_bb, default(IGazePerformance));
		}

		// Token: 0x06024B55 RID: 150357 RVA: 0x0050ADE0 File Offset: 0x00508FE0
		public static IGazePerformance GetRootAsIGazePerformance(ByteBuffer _bb, IGazePerformance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024B56 RID: 150358 RVA: 0x0050ADFD File Offset: 0x00508FFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024B57 RID: 150359 RVA: 0x0050AE0C File Offset: 0x0050900C
		public IGazePerformance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A40D RID: 41997
		// (get) Token: 0x06024B58 RID: 150360 RVA: 0x0050AE1C File Offset: 0x0050901C
		public float FadeInTime
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A40E RID: 41998
		// (get) Token: 0x06024B59 RID: 150361 RVA: 0x0050AE5C File Offset: 0x0050905C
		public float StayTime
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A40F RID: 41999
		// (get) Token: 0x06024B5A RID: 150362 RVA: 0x0050AE9C File Offset: 0x0050909C
		public float FadeOutTime
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A410 RID: 42000
		// (get) Token: 0x06024B5B RID: 150363 RVA: 0x0050AEDC File Offset: 0x005090DC
		public bool LockCamera
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A411 RID: 42001
		// (get) Token: 0x06024B5C RID: 150364 RVA: 0x0050AF1C File Offset: 0x0050911C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024B5D RID: 150365 RVA: 0x0050AF59 File Offset: 0x00509159
		public static Offset<IGazePerformance> CreateIGazePerformance(FlatBufferBuilder builder, float FadeInTime = 0f, float StayTime = 0f, float FadeOutTime = 0f, bool LockCamera = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			IGazePerformance.AddFadeOutTime(builder, FadeOutTime);
			IGazePerformance.AddStayTime(builder, StayTime);
			IGazePerformance.AddFadeInTime(builder, FadeInTime);
			IGazePerformance.AddNullMask(builder, NullMask);
			IGazePerformance.AddLockCamera(builder, LockCamera);
			return IGazePerformance.EndIGazePerformance(builder);
		}

		// Token: 0x06024B5E RID: 150366 RVA: 0x0050AF8D File Offset: 0x0050918D
		public static void StartIGazePerformance(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06024B5F RID: 150367 RVA: 0x0050AF96 File Offset: 0x00509196
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(0, fadeInTime, 0.0);
		}

		// Token: 0x06024B60 RID: 150368 RVA: 0x0050AFA9 File Offset: 0x005091A9
		public static void AddStayTime(FlatBufferBuilder builder, float stayTime)
		{
			builder.AddFloat(1, stayTime, 0.0);
		}

		// Token: 0x06024B61 RID: 150369 RVA: 0x0050AFBC File Offset: 0x005091BC
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(2, fadeOutTime, 0.0);
		}

		// Token: 0x06024B62 RID: 150370 RVA: 0x0050AFCF File Offset: 0x005091CF
		public static void AddLockCamera(FlatBufferBuilder builder, bool lockCamera)
		{
			builder.AddBool(3, lockCamera, false);
		}

		// Token: 0x06024B63 RID: 150371 RVA: 0x0050AFDA File Offset: 0x005091DA
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06024B64 RID: 150372 RVA: 0x0050AFE5 File Offset: 0x005091E5
		public static Offset<IGazePerformance> EndIGazePerformance(FlatBufferBuilder builder)
		{
			return new Offset<IGazePerformance>(builder.EndTable());
		}

		// Token: 0x06024B65 RID: 150373 RVA: 0x0050AFF4 File Offset: 0x005091F4
		public IGazePerformanceT UnPack()
		{
			IGazePerformanceT gazePerformanceT = new IGazePerformanceT();
			this.UnPackTo(gazePerformanceT);
			return gazePerformanceT;
		}

		// Token: 0x06024B66 RID: 150374 RVA: 0x0050B00F File Offset: 0x0050920F
		public void UnPackTo(IGazePerformanceT _o)
		{
			_o.FadeInTime = this.FadeInTime;
			_o.StayTime = this.StayTime;
			_o.FadeOutTime = this.FadeOutTime;
			_o.LockCamera = this.LockCamera;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06024B67 RID: 150375 RVA: 0x0050B050 File Offset: 0x00509250
		public static Offset<IGazePerformance> Pack(FlatBufferBuilder builder, IGazePerformanceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGazePerformance>);
			}
			return IGazePerformance.CreateIGazePerformance(builder, _o.FadeInTime, _o.StayTime, _o.FadeOutTime, _o.LockCamera, _o.NullMask);
		}

		// Token: 0x0400F0C3 RID: 61635
		private Table __p;
	}
}
