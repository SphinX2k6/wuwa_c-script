using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200627B RID: 25211
	public struct ICameraGaze : IFlatbufferObject
	{
		// Token: 0x1700BBE5 RID: 48101
		// (get) Token: 0x0602B845 RID: 178245 RVA: 0x005FDDB8 File Offset: 0x005FBFB8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B846 RID: 178246 RVA: 0x005FDDC5 File Offset: 0x005FBFC5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B847 RID: 178247 RVA: 0x005FDDCC File Offset: 0x005FBFCC
		public static ICameraGaze GetRootAsICameraGaze(ByteBuffer _bb)
		{
			return ICameraGaze.GetRootAsICameraGaze(_bb, default(ICameraGaze));
		}

		// Token: 0x0602B848 RID: 178248 RVA: 0x005FDDE8 File Offset: 0x005FBFE8
		public static ICameraGaze GetRootAsICameraGaze(ByteBuffer _bb, ICameraGaze obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B849 RID: 178249 RVA: 0x005FDE05 File Offset: 0x005FC005
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B84A RID: 178250 RVA: 0x005FDE14 File Offset: 0x005FC014
		public ICameraGaze __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BBE6 RID: 48102
		// (get) Token: 0x0602B84B RID: 178251 RVA: 0x005FDE24 File Offset: 0x005FC024
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

		// Token: 0x1700BBE7 RID: 48103
		// (get) Token: 0x0602B84C RID: 178252 RVA: 0x005FDE64 File Offset: 0x005FC064
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

		// Token: 0x1700BBE8 RID: 48104
		// (get) Token: 0x0602B84D RID: 178253 RVA: 0x005FDEA4 File Offset: 0x005FC0A4
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

		// Token: 0x1700BBE9 RID: 48105
		// (get) Token: 0x0602B84E RID: 178254 RVA: 0x005FDEE4 File Offset: 0x005FC0E4
		public bool LockCamera
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BBEA RID: 48106
		// (get) Token: 0x0602B84F RID: 178255 RVA: 0x005FDF24 File Offset: 0x005FC124
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

		// Token: 0x1700BBEB RID: 48107
		// (get) Token: 0x0602B850 RID: 178256 RVA: 0x005FDF64 File Offset: 0x005FC164
		public bool GazeInHook
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BBEC RID: 48108
		// (get) Token: 0x0602B851 RID: 178257 RVA: 0x005FDFA4 File Offset: 0x005FC1A4
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

		// Token: 0x0602B852 RID: 178258 RVA: 0x005FDFE4 File Offset: 0x005FC1E4
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

		// Token: 0x0602B853 RID: 178259 RVA: 0x005FE033 File Offset: 0x005FC233
		public static void StartICameraGaze(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602B854 RID: 178260 RVA: 0x005FE03C File Offset: 0x005FC23C
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(0, fadeInTime, 0.0);
		}

		// Token: 0x0602B855 RID: 178261 RVA: 0x005FE04F File Offset: 0x005FC24F
		public static void AddStayTime(FlatBufferBuilder builder, float stayTime)
		{
			builder.AddFloat(1, stayTime, 0.0);
		}

		// Token: 0x0602B856 RID: 178262 RVA: 0x005FE062 File Offset: 0x005FC262
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(2, fadeOutTime, 0.0);
		}

		// Token: 0x0602B857 RID: 178263 RVA: 0x005FE075 File Offset: 0x005FC275
		public static void AddLockCamera(FlatBufferBuilder builder, bool lockCamera)
		{
			builder.AddBool(3, lockCamera, false);
		}

		// Token: 0x0602B858 RID: 178264 RVA: 0x005FE080 File Offset: 0x005FC280
		public static void AddLockPriority(FlatBufferBuilder builder, int lockPriority)
		{
			builder.AddInt(4, lockPriority, 0);
		}

		// Token: 0x0602B859 RID: 178265 RVA: 0x005FE08B File Offset: 0x005FC28B
		public static void AddGazeInHook(FlatBufferBuilder builder, bool gazeInHook)
		{
			builder.AddBool(5, gazeInHook, false);
		}

		// Token: 0x0602B85A RID: 178266 RVA: 0x005FE096 File Offset: 0x005FC296
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0602B85B RID: 178267 RVA: 0x005FE0A1 File Offset: 0x005FC2A1
		public static Offset<ICameraGaze> EndICameraGaze(FlatBufferBuilder builder)
		{
			return new Offset<ICameraGaze>(builder.EndTable());
		}

		// Token: 0x0602B85C RID: 178268 RVA: 0x005FE0B0 File Offset: 0x005FC2B0
		public ICameraGazeT UnPack()
		{
			ICameraGazeT cameraGazeT = new ICameraGazeT();
			this.UnPackTo(cameraGazeT);
			return cameraGazeT;
		}

		// Token: 0x0602B85D RID: 178269 RVA: 0x005FE0CC File Offset: 0x005FC2CC
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

		// Token: 0x0602B85E RID: 178270 RVA: 0x005FE130 File Offset: 0x005FC330
		public static Offset<ICameraGaze> Pack(FlatBufferBuilder builder, ICameraGazeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICameraGaze>);
			}
			return ICameraGaze.CreateICameraGaze(builder, _o.FadeInTime, _o.StayTime, _o.FadeOutTime, _o.LockCamera, _o.LockPriority, _o.GazeInHook, _o.NullMask);
		}

		// Token: 0x040107DB RID: 67547
		private Table __p;
	}
}
