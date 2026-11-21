using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068EC RID: 26860
	public struct ICameraGaze : IFlatbufferObject
	{
		// Token: 0x1700C56D RID: 50541
		// (get) Token: 0x0602DFA6 RID: 188326 RVA: 0x00648BC0 File Offset: 0x00646DC0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DFA7 RID: 188327 RVA: 0x00648BCD File Offset: 0x00646DCD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DFA8 RID: 188328 RVA: 0x00648BD4 File Offset: 0x00646DD4
		public static ICameraGaze GetRootAsICameraGaze(ByteBuffer _bb)
		{
			return ICameraGaze.GetRootAsICameraGaze(_bb, default(ICameraGaze));
		}

		// Token: 0x0602DFA9 RID: 188329 RVA: 0x00648BF0 File Offset: 0x00646DF0
		public static ICameraGaze GetRootAsICameraGaze(ByteBuffer _bb, ICameraGaze obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DFAA RID: 188330 RVA: 0x00648C0D File Offset: 0x00646E0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DFAB RID: 188331 RVA: 0x00648C1C File Offset: 0x00646E1C
		public ICameraGaze __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C56E RID: 50542
		// (get) Token: 0x0602DFAC RID: 188332 RVA: 0x00648C2C File Offset: 0x00646E2C
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

		// Token: 0x1700C56F RID: 50543
		// (get) Token: 0x0602DFAD RID: 188333 RVA: 0x00648C6C File Offset: 0x00646E6C
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

		// Token: 0x1700C570 RID: 50544
		// (get) Token: 0x0602DFAE RID: 188334 RVA: 0x00648CAC File Offset: 0x00646EAC
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

		// Token: 0x1700C571 RID: 50545
		// (get) Token: 0x0602DFAF RID: 188335 RVA: 0x00648CEC File Offset: 0x00646EEC
		public bool LockCamera
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C572 RID: 50546
		// (get) Token: 0x0602DFB0 RID: 188336 RVA: 0x00648D2C File Offset: 0x00646F2C
		public int LockPriority
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C573 RID: 50547
		// (get) Token: 0x0602DFB1 RID: 188337 RVA: 0x00648D6C File Offset: 0x00646F6C
		public bool GazeInHook
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C574 RID: 50548
		// (get) Token: 0x0602DFB2 RID: 188338 RVA: 0x00648DAC File Offset: 0x00646FAC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DFB3 RID: 188339 RVA: 0x00648DEC File Offset: 0x00646FEC
		public static Offset<ICameraGaze> CreateICameraGaze(FlatBufferBuilder builder, float FadeInTime = 0f, float StayTime = 0f, float FadeOutTime = 0f, bool LockCamera = false, int LockPriority = 0, bool GazeInHook = false, byte NullMask = 0)
		{
			builder.StartTable(7);
			ICameraGaze.AddLockPriority(builder, LockPriority);
			ICameraGaze.AddFadeOutTime(builder, FadeOutTime);
			ICameraGaze.AddStayTime(builder, StayTime);
			ICameraGaze.AddFadeInTime(builder, FadeInTime);
			ICameraGaze.AddNullMask(builder, NullMask);
			ICameraGaze.AddGazeInHook(builder, GazeInHook);
			ICameraGaze.AddLockCamera(builder, LockCamera);
			return ICameraGaze.EndICameraGaze(builder);
		}

		// Token: 0x0602DFB4 RID: 188340 RVA: 0x00648E3B File Offset: 0x0064703B
		public static void StartICameraGaze(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602DFB5 RID: 188341 RVA: 0x00648E44 File Offset: 0x00647044
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(0, fadeInTime, 0.0);
		}

		// Token: 0x0602DFB6 RID: 188342 RVA: 0x00648E57 File Offset: 0x00647057
		public static void AddStayTime(FlatBufferBuilder builder, float stayTime)
		{
			builder.AddFloat(1, stayTime, 0.0);
		}

		// Token: 0x0602DFB7 RID: 188343 RVA: 0x00648E6A File Offset: 0x0064706A
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(2, fadeOutTime, 0.0);
		}

		// Token: 0x0602DFB8 RID: 188344 RVA: 0x00648E7D File Offset: 0x0064707D
		public static void AddLockCamera(FlatBufferBuilder builder, bool lockCamera)
		{
			builder.AddBool(3, lockCamera, false);
		}

		// Token: 0x0602DFB9 RID: 188345 RVA: 0x00648E88 File Offset: 0x00647088
		public static void AddLockPriority(FlatBufferBuilder builder, int lockPriority)
		{
			builder.AddInt(4, lockPriority, 0);
		}

		// Token: 0x0602DFBA RID: 188346 RVA: 0x00648E93 File Offset: 0x00647093
		public static void AddGazeInHook(FlatBufferBuilder builder, bool gazeInHook)
		{
			builder.AddBool(5, gazeInHook, false);
		}

		// Token: 0x0602DFBB RID: 188347 RVA: 0x00648E9E File Offset: 0x0064709E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0602DFBC RID: 188348 RVA: 0x00648EA9 File Offset: 0x006470A9
		public static Offset<ICameraGaze> EndICameraGaze(FlatBufferBuilder builder)
		{
			return new Offset<ICameraGaze>(builder.EndTable());
		}

		// Token: 0x0602DFBD RID: 188349 RVA: 0x00648EB8 File Offset: 0x006470B8
		public ICameraGazeT UnPack()
		{
			ICameraGazeT cameraGazeT = new ICameraGazeT();
			this.UnPackTo(cameraGazeT);
			return cameraGazeT;
		}

		// Token: 0x0602DFBE RID: 188350 RVA: 0x00648ED4 File Offset: 0x006470D4
		public void UnPackTo(ICameraGazeT _o)
		{
			_o.FadeInTime = this.FadeInTime;
			_o.StayTime = this.StayTime;
			_o.FadeOutTime = this.FadeOutTime;
			_o.LockCamera = this.LockCamera;
			_o.LockPriority = this.LockPriority;
			_o.GazeInHook = this.GazeInHook;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602DFBF RID: 188351 RVA: 0x00648F38 File Offset: 0x00647138
		public static Offset<ICameraGaze> Pack(FlatBufferBuilder builder, ICameraGazeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICameraGaze>);
			}
			return ICameraGaze.CreateICameraGaze(builder, _o.FadeInTime, _o.StayTime, _o.FadeOutTime, _o.LockCamera, _o.LockPriority, _o.GazeInHook, _o.NullMask);
		}

		// Token: 0x040115F0 RID: 71152
		private Table __p;
	}
}
