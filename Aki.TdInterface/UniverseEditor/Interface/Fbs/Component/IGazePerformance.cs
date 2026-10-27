using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052F4 RID: 21236
	public struct IGazePerformance : IFlatbufferObject
	{
		// Token: 0x17009BDB RID: 39899
		// (get) Token: 0x06022AB8 RID: 142008 RVA: 0x004CE283 File Offset: 0x004CC483
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022AB9 RID: 142009 RVA: 0x004CE290 File Offset: 0x004CC490
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022ABA RID: 142010 RVA: 0x004CE298 File Offset: 0x004CC498
		public static IGazePerformance GetRootAsIGazePerformance(ByteBuffer _bb)
		{
			return IGazePerformance.GetRootAsIGazePerformance(_bb, default(IGazePerformance));
		}

		// Token: 0x06022ABB RID: 142011 RVA: 0x004CE2B4 File Offset: 0x004CC4B4
		public static IGazePerformance GetRootAsIGazePerformance(ByteBuffer _bb, IGazePerformance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022ABC RID: 142012 RVA: 0x004CE2D1 File Offset: 0x004CC4D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022ABD RID: 142013 RVA: 0x004CE2E0 File Offset: 0x004CC4E0
		public IGazePerformance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009BDC RID: 39900
		// (get) Token: 0x06022ABE RID: 142014 RVA: 0x004CE2F0 File Offset: 0x004CC4F0
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

		// Token: 0x17009BDD RID: 39901
		// (get) Token: 0x06022ABF RID: 142015 RVA: 0x004CE330 File Offset: 0x004CC530
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

		// Token: 0x17009BDE RID: 39902
		// (get) Token: 0x06022AC0 RID: 142016 RVA: 0x004CE370 File Offset: 0x004CC570
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

		// Token: 0x17009BDF RID: 39903
		// (get) Token: 0x06022AC1 RID: 142017 RVA: 0x004CE3B0 File Offset: 0x004CC5B0
		public bool LockCamera
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009BE0 RID: 39904
		// (get) Token: 0x06022AC2 RID: 142018 RVA: 0x004CE3F0 File Offset: 0x004CC5F0
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

		// Token: 0x06022AC3 RID: 142019 RVA: 0x004CE42D File Offset: 0x004CC62D
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

		// Token: 0x06022AC4 RID: 142020 RVA: 0x004CE461 File Offset: 0x004CC661
		public static void StartIGazePerformance(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06022AC5 RID: 142021 RVA: 0x004CE46A File Offset: 0x004CC66A
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(0, fadeInTime, 0.0);
		}

		// Token: 0x06022AC6 RID: 142022 RVA: 0x004CE47D File Offset: 0x004CC67D
		public static void AddStayTime(FlatBufferBuilder builder, float stayTime)
		{
			builder.AddFloat(1, stayTime, 0.0);
		}

		// Token: 0x06022AC7 RID: 142023 RVA: 0x004CE490 File Offset: 0x004CC690
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(2, fadeOutTime, 0.0);
		}

		// Token: 0x06022AC8 RID: 142024 RVA: 0x004CE4A3 File Offset: 0x004CC6A3
		public static void AddLockCamera(FlatBufferBuilder builder, bool lockCamera)
		{
			builder.AddBool(3, lockCamera, false);
		}

		// Token: 0x06022AC9 RID: 142025 RVA: 0x004CE4AE File Offset: 0x004CC6AE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06022ACA RID: 142026 RVA: 0x004CE4B9 File Offset: 0x004CC6B9
		public static Offset<IGazePerformance> EndIGazePerformance(FlatBufferBuilder builder)
		{
			return new Offset<IGazePerformance>(builder.EndTable());
		}

		// Token: 0x06022ACB RID: 142027 RVA: 0x004CE4C8 File Offset: 0x004CC6C8
		public IGazePerformanceT UnPack()
		{
			IGazePerformanceT gazePerformanceT = new IGazePerformanceT();
			this.UnPackTo(gazePerformanceT);
			return gazePerformanceT;
		}

		// Token: 0x06022ACC RID: 142028 RVA: 0x004CE4E3 File Offset: 0x004CC6E3
		public void UnPackTo(IGazePerformanceT _o)
		{
			_o.FadeInTime = this.FadeInTime;
			_o.StayTime = this.StayTime;
			_o.FadeOutTime = this.FadeOutTime;
			_o.LockCamera = this.LockCamera;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06022ACD RID: 142029 RVA: 0x004CE524 File Offset: 0x004CC724
		public static Offset<IGazePerformance> Pack(FlatBufferBuilder builder, IGazePerformanceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGazePerformance>);
			}
			return IGazePerformance.CreateIGazePerformance(builder, _o.FadeInTime, _o.StayTime, _o.FadeOutTime, _o.LockCamera, _o.NullMask);
		}

		// Token: 0x0400E497 RID: 58519
		private Table __p;
	}
}
