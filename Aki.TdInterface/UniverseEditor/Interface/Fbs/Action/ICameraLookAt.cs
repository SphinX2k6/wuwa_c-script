using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200628D RID: 25229
	public struct ICameraLookAt : IFlatbufferObject
	{
		// Token: 0x1700BC22 RID: 48162
		// (get) Token: 0x0602B903 RID: 178435 RVA: 0x005FF53C File Offset: 0x005FD73C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B904 RID: 178436 RVA: 0x005FF549 File Offset: 0x005FD749
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B905 RID: 178437 RVA: 0x005FF550 File Offset: 0x005FD750
		public static ICameraLookAt GetRootAsICameraLookAt(ByteBuffer _bb)
		{
			return ICameraLookAt.GetRootAsICameraLookAt(_bb, default(ICameraLookAt));
		}

		// Token: 0x0602B906 RID: 178438 RVA: 0x005FF56C File Offset: 0x005FD76C
		public static ICameraLookAt GetRootAsICameraLookAt(ByteBuffer _bb, ICameraLookAt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B907 RID: 178439 RVA: 0x005FF589 File Offset: 0x005FD789
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B908 RID: 178440 RVA: 0x005FF598 File Offset: 0x005FD798
		public ICameraLookAt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC23 RID: 48163
		// (get) Token: 0x0602B909 RID: 178441 RVA: 0x005FF5A8 File Offset: 0x005FD7A8
		public IVectorInfo? Pos
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700BC24 RID: 48164
		// (get) Token: 0x0602B90A RID: 178442 RVA: 0x005FF608 File Offset: 0x005FD808
		public int PosEntityId
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

		// Token: 0x1700BC25 RID: 48165
		// (get) Token: 0x0602B90B RID: 178443 RVA: 0x005FF644 File Offset: 0x005FD844
		public float FadeInTime
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

		// Token: 0x1700BC26 RID: 48166
		// (get) Token: 0x0602B90C RID: 178444 RVA: 0x005FF684 File Offset: 0x005FD884
		public float StayTime
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BC27 RID: 48167
		// (get) Token: 0x0602B90D RID: 178445 RVA: 0x005FF6C8 File Offset: 0x005FD8C8
		public float FadeOutTime
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BC28 RID: 48168
		// (get) Token: 0x0602B90E RID: 178446 RVA: 0x005FF70C File Offset: 0x005FD90C
		public bool LockCamera
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BC29 RID: 48169
		// (get) Token: 0x0602B90F RID: 178447 RVA: 0x005FF74C File Offset: 0x005FD94C
		public IVectorInfo? CameraPos
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700BC2A RID: 48170
		// (get) Token: 0x0602B910 RID: 178448 RVA: 0x005FF7AC File Offset: 0x005FD9AC
		public int CameraPosEntityId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BC2B RID: 48171
		// (get) Token: 0x0602B911 RID: 178449 RVA: 0x005FF7EC File Offset: 0x005FD9EC
		public bool IsLockCameraPos
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BC2C RID: 48172
		// (get) Token: 0x0602B912 RID: 178450 RVA: 0x005FF82C File Offset: 0x005FDA2C
		public int Fov
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BC2D RID: 48173
		// (get) Token: 0x0602B913 RID: 178451 RVA: 0x005FF86C File Offset: 0x005FDA6C
		public int ArmLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BC2E RID: 48174
		// (get) Token: 0x0602B914 RID: 178452 RVA: 0x005FF8AC File Offset: 0x005FDAAC
		public bool BanInput
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BC2F RID: 48175
		// (get) Token: 0x0602B915 RID: 178453 RVA: 0x005FF8EC File Offset: 0x005FDAEC
		public bool HideUi
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BC30 RID: 48176
		// (get) Token: 0x0602B916 RID: 178454 RVA: 0x005FF92C File Offset: 0x005FDB2C
		public bool CancelBuffer
		{
			get
			{
				int num = this.__p.__offset(30);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BC31 RID: 48177
		// (get) Token: 0x0602B917 RID: 178455 RVA: 0x005FF96C File Offset: 0x005FDB6C
		public bool CancelBlendOut
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BC32 RID: 48178
		// (get) Token: 0x0602B918 RID: 178456 RVA: 0x005FF9AC File Offset: 0x005FDBAC
		public bool DisableCameraOffSet
		{
			get
			{
				int num = this.__p.__offset(34);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BC33 RID: 48179
		// (get) Token: 0x0602B919 RID: 178457 RVA: 0x005FF9EC File Offset: 0x005FDBEC
		public ushort NullMask
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetUshort(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B91A RID: 178458 RVA: 0x005FFA2C File Offset: 0x005FDC2C
		public static Offset<ICameraLookAt> CreateICameraLookAt(FlatBufferBuilder builder, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), int PosEntityId = 0, float FadeInTime = 0f, float StayTime = 0f, float FadeOutTime = 0f, bool LockCamera = false, Offset<IVectorInfo> CameraPosOffset = default(Offset<IVectorInfo>), int CameraPosEntityId = 0, bool IsLockCameraPos = false, int Fov = 0, int ArmLength = 0, bool BanInput = false, bool HideUi = false, bool CancelBuffer = false, bool CancelBlendOut = false, bool DisableCameraOffSet = false, ushort NullMask = 0)
		{
			builder.StartTable(17);
			ICameraLookAt.AddArmLength(builder, ArmLength);
			ICameraLookAt.AddFov(builder, Fov);
			ICameraLookAt.AddCameraPosEntityId(builder, CameraPosEntityId);
			ICameraLookAt.AddCameraPos(builder, CameraPosOffset);
			ICameraLookAt.AddFadeOutTime(builder, FadeOutTime);
			ICameraLookAt.AddStayTime(builder, StayTime);
			ICameraLookAt.AddFadeInTime(builder, FadeInTime);
			ICameraLookAt.AddPosEntityId(builder, PosEntityId);
			ICameraLookAt.AddPos(builder, PosOffset);
			ICameraLookAt.AddNullMask(builder, NullMask);
			ICameraLookAt.AddDisableCameraOffSet(builder, DisableCameraOffSet);
			ICameraLookAt.AddCancelBlendOut(builder, CancelBlendOut);
			ICameraLookAt.AddCancelBuffer(builder, CancelBuffer);
			ICameraLookAt.AddHideUi(builder, HideUi);
			ICameraLookAt.AddBanInput(builder, BanInput);
			ICameraLookAt.AddIsLockCameraPos(builder, IsLockCameraPos);
			ICameraLookAt.AddLockCamera(builder, LockCamera);
			return ICameraLookAt.EndICameraLookAt(builder);
		}

		// Token: 0x0602B91B RID: 178459 RVA: 0x005FFACC File Offset: 0x005FDCCC
		public static void StartICameraLookAt(FlatBufferBuilder builder)
		{
			builder.StartTable(17);
		}

		// Token: 0x0602B91C RID: 178460 RVA: 0x005FFAD6 File Offset: 0x005FDCD6
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(0, posOffset.Value, 0);
		}

		// Token: 0x0602B91D RID: 178461 RVA: 0x005FFAE6 File Offset: 0x005FDCE6
		public static void AddPosEntityId(FlatBufferBuilder builder, int posEntityId)
		{
			builder.AddInt(1, posEntityId, 0);
		}

		// Token: 0x0602B91E RID: 178462 RVA: 0x005FFAF1 File Offset: 0x005FDCF1
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(2, fadeInTime, 0.0);
		}

		// Token: 0x0602B91F RID: 178463 RVA: 0x005FFB04 File Offset: 0x005FDD04
		public static void AddStayTime(FlatBufferBuilder builder, float stayTime)
		{
			builder.AddFloat(3, stayTime, 0.0);
		}

		// Token: 0x0602B920 RID: 178464 RVA: 0x005FFB17 File Offset: 0x005FDD17
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(4, fadeOutTime, 0.0);
		}

		// Token: 0x0602B921 RID: 178465 RVA: 0x005FFB2A File Offset: 0x005FDD2A
		public static void AddLockCamera(FlatBufferBuilder builder, bool lockCamera)
		{
			builder.AddBool(5, lockCamera, false);
		}

		// Token: 0x0602B922 RID: 178466 RVA: 0x005FFB35 File Offset: 0x005FDD35
		public static void AddCameraPos(FlatBufferBuilder builder, Offset<IVectorInfo> cameraPosOffset)
		{
			builder.AddOffset(6, cameraPosOffset.Value, 0);
		}

		// Token: 0x0602B923 RID: 178467 RVA: 0x005FFB45 File Offset: 0x005FDD45
		public static void AddCameraPosEntityId(FlatBufferBuilder builder, int cameraPosEntityId)
		{
			builder.AddInt(7, cameraPosEntityId, 0);
		}

		// Token: 0x0602B924 RID: 178468 RVA: 0x005FFB50 File Offset: 0x005FDD50
		public static void AddIsLockCameraPos(FlatBufferBuilder builder, bool isLockCameraPos)
		{
			builder.AddBool(8, isLockCameraPos, false);
		}

		// Token: 0x0602B925 RID: 178469 RVA: 0x005FFB5B File Offset: 0x005FDD5B
		public static void AddFov(FlatBufferBuilder builder, int fov)
		{
			builder.AddInt(9, fov, 0);
		}

		// Token: 0x0602B926 RID: 178470 RVA: 0x005FFB67 File Offset: 0x005FDD67
		public static void AddArmLength(FlatBufferBuilder builder, int armLength)
		{
			builder.AddInt(10, armLength, 0);
		}

		// Token: 0x0602B927 RID: 178471 RVA: 0x005FFB73 File Offset: 0x005FDD73
		public static void AddBanInput(FlatBufferBuilder builder, bool banInput)
		{
			builder.AddBool(11, banInput, false);
		}

		// Token: 0x0602B928 RID: 178472 RVA: 0x005FFB7F File Offset: 0x005FDD7F
		public static void AddHideUi(FlatBufferBuilder builder, bool hideUi)
		{
			builder.AddBool(12, hideUi, false);
		}

		// Token: 0x0602B929 RID: 178473 RVA: 0x005FFB8B File Offset: 0x005FDD8B
		public static void AddCancelBuffer(FlatBufferBuilder builder, bool cancelBuffer)
		{
			builder.AddBool(13, cancelBuffer, false);
		}

		// Token: 0x0602B92A RID: 178474 RVA: 0x005FFB97 File Offset: 0x005FDD97
		public static void AddCancelBlendOut(FlatBufferBuilder builder, bool cancelBlendOut)
		{
			builder.AddBool(14, cancelBlendOut, false);
		}

		// Token: 0x0602B92B RID: 178475 RVA: 0x005FFBA3 File Offset: 0x005FDDA3
		public static void AddDisableCameraOffSet(FlatBufferBuilder builder, bool disableCameraOffSet)
		{
			builder.AddBool(15, disableCameraOffSet, false);
		}

		// Token: 0x0602B92C RID: 178476 RVA: 0x005FFBAF File Offset: 0x005FDDAF
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(16, nullMask, 0);
		}

		// Token: 0x0602B92D RID: 178477 RVA: 0x005FFBBB File Offset: 0x005FDDBB
		public static Offset<ICameraLookAt> EndICameraLookAt(FlatBufferBuilder builder)
		{
			return new Offset<ICameraLookAt>(builder.EndTable());
		}

		// Token: 0x0602B92E RID: 178478 RVA: 0x005FFBC8 File Offset: 0x005FDDC8
		public ICameraLookAtT UnPack()
		{
			ICameraLookAtT cameraLookAtT = new ICameraLookAtT();
			this.UnPackTo(cameraLookAtT);
			return cameraLookAtT;
		}

		// Token: 0x0602B92F RID: 178479 RVA: 0x005FFBE4 File Offset: 0x005FDDE4
		public void UnPackTo(ICameraLookAtT _o)
		{
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.PosEntityId = this.PosEntityId;
			_o.FadeInTime = this.FadeInTime;
			_o.StayTime = this.StayTime;
			_o.FadeOutTime = this.FadeOutTime;
			_o.LockCamera = this.LockCamera;
			_o.CameraPos = ((this.CameraPos != null) ? this.CameraPos.Value.UnPack() : null);
			_o.CameraPosEntityId = this.CameraPosEntityId;
			_o.IsLockCameraPos = this.IsLockCameraPos;
			_o.Fov = this.Fov;
			_o.ArmLength = this.ArmLength;
			_o.BanInput = this.BanInput;
			_o.HideUi = this.HideUi;
			_o.CancelBuffer = this.CancelBuffer;
			_o.CancelBlendOut = this.CancelBlendOut;
			_o.DisableCameraOffSet = this.DisableCameraOffSet;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602B930 RID: 178480 RVA: 0x005FFD04 File Offset: 0x005FDF04
		public static Offset<ICameraLookAt> Pack(FlatBufferBuilder builder, ICameraLookAtT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICameraLookAt>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			Offset<IVectorInfo> cameraPosOffset = (_o.CameraPos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.CameraPos);
			return ICameraLookAt.CreateICameraLookAt(builder, posOffset, _o.PosEntityId, _o.FadeInTime, _o.StayTime, _o.FadeOutTime, _o.LockCamera, cameraPosOffset, _o.CameraPosEntityId, _o.IsLockCameraPos, _o.Fov, _o.ArmLength, _o.BanInput, _o.HideUi, _o.CancelBuffer, _o.CancelBlendOut, _o.DisableCameraOffSet, _o.NullMask);
		}

		// Token: 0x04010801 RID: 67585
		private Table __p;
	}
}
