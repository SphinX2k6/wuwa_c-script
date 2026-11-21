using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068FE RID: 26878
	public struct ICameraLookAt : IFlatbufferObject
	{
		// Token: 0x1700C5AA RID: 50602
		// (get) Token: 0x0602E064 RID: 188516 RVA: 0x0064A344 File Offset: 0x00648544
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E065 RID: 188517 RVA: 0x0064A351 File Offset: 0x00648551
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E066 RID: 188518 RVA: 0x0064A358 File Offset: 0x00648558
		public static ICameraLookAt GetRootAsICameraLookAt(ByteBuffer _bb)
		{
			return ICameraLookAt.GetRootAsICameraLookAt(_bb, default(ICameraLookAt));
		}

		// Token: 0x0602E067 RID: 188519 RVA: 0x0064A374 File Offset: 0x00648574
		public static ICameraLookAt GetRootAsICameraLookAt(ByteBuffer _bb, ICameraLookAt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E068 RID: 188520 RVA: 0x0064A391 File Offset: 0x00648591
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E069 RID: 188521 RVA: 0x0064A3A0 File Offset: 0x006485A0
		public ICameraLookAt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C5AB RID: 50603
		// (get) Token: 0x0602E06A RID: 188522 RVA: 0x0064A3B0 File Offset: 0x006485B0
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

		// Token: 0x1700C5AC RID: 50604
		// (get) Token: 0x0602E06B RID: 188523 RVA: 0x0064A410 File Offset: 0x00648610
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

		// Token: 0x1700C5AD RID: 50605
		// (get) Token: 0x0602E06C RID: 188524 RVA: 0x0064A44C File Offset: 0x0064864C
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

		// Token: 0x1700C5AE RID: 50606
		// (get) Token: 0x0602E06D RID: 188525 RVA: 0x0064A48C File Offset: 0x0064868C
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

		// Token: 0x1700C5AF RID: 50607
		// (get) Token: 0x0602E06E RID: 188526 RVA: 0x0064A4D0 File Offset: 0x006486D0
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

		// Token: 0x1700C5B0 RID: 50608
		// (get) Token: 0x0602E06F RID: 188527 RVA: 0x0064A514 File Offset: 0x00648714
		public bool LockCamera
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C5B1 RID: 50609
		// (get) Token: 0x0602E070 RID: 188528 RVA: 0x0064A554 File Offset: 0x00648754
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

		// Token: 0x1700C5B2 RID: 50610
		// (get) Token: 0x0602E071 RID: 188529 RVA: 0x0064A5B4 File Offset: 0x006487B4
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

		// Token: 0x1700C5B3 RID: 50611
		// (get) Token: 0x0602E072 RID: 188530 RVA: 0x0064A5F4 File Offset: 0x006487F4
		public bool IsLockCameraPos
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C5B4 RID: 50612
		// (get) Token: 0x0602E073 RID: 188531 RVA: 0x0064A634 File Offset: 0x00648834
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

		// Token: 0x1700C5B5 RID: 50613
		// (get) Token: 0x0602E074 RID: 188532 RVA: 0x0064A674 File Offset: 0x00648874
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

		// Token: 0x1700C5B6 RID: 50614
		// (get) Token: 0x0602E075 RID: 188533 RVA: 0x0064A6B4 File Offset: 0x006488B4
		public bool BanInput
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C5B7 RID: 50615
		// (get) Token: 0x0602E076 RID: 188534 RVA: 0x0064A6F4 File Offset: 0x006488F4
		public bool HideUi
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C5B8 RID: 50616
		// (get) Token: 0x0602E077 RID: 188535 RVA: 0x0064A734 File Offset: 0x00648934
		public bool CancelBuffer
		{
			get
			{
				int num = this.__p.__offset(30);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C5B9 RID: 50617
		// (get) Token: 0x0602E078 RID: 188536 RVA: 0x0064A774 File Offset: 0x00648974
		public bool CancelBlendOut
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C5BA RID: 50618
		// (get) Token: 0x0602E079 RID: 188537 RVA: 0x0064A7B4 File Offset: 0x006489B4
		public bool DisableCameraOffSet
		{
			get
			{
				int num = this.__p.__offset(34);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C5BB RID: 50619
		// (get) Token: 0x0602E07A RID: 188538 RVA: 0x0064A7F4 File Offset: 0x006489F4
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

		// Token: 0x0602E07B RID: 188539 RVA: 0x0064A834 File Offset: 0x00648A34
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

		// Token: 0x0602E07C RID: 188540 RVA: 0x0064A8D4 File Offset: 0x00648AD4
		public static void StartICameraLookAt(FlatBufferBuilder builder)
		{
			builder.StartTable(17);
		}

		// Token: 0x0602E07D RID: 188541 RVA: 0x0064A8DE File Offset: 0x00648ADE
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(0, posOffset.Value, 0);
		}

		// Token: 0x0602E07E RID: 188542 RVA: 0x0064A8EE File Offset: 0x00648AEE
		public static void AddPosEntityId(FlatBufferBuilder builder, int posEntityId)
		{
			builder.AddInt(1, posEntityId, 0);
		}

		// Token: 0x0602E07F RID: 188543 RVA: 0x0064A8F9 File Offset: 0x00648AF9
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(2, fadeInTime, 0.0);
		}

		// Token: 0x0602E080 RID: 188544 RVA: 0x0064A90C File Offset: 0x00648B0C
		public static void AddStayTime(FlatBufferBuilder builder, float stayTime)
		{
			builder.AddFloat(3, stayTime, 0.0);
		}

		// Token: 0x0602E081 RID: 188545 RVA: 0x0064A91F File Offset: 0x00648B1F
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(4, fadeOutTime, 0.0);
		}

		// Token: 0x0602E082 RID: 188546 RVA: 0x0064A932 File Offset: 0x00648B32
		public static void AddLockCamera(FlatBufferBuilder builder, bool lockCamera)
		{
			builder.AddBool(5, lockCamera, false);
		}

		// Token: 0x0602E083 RID: 188547 RVA: 0x0064A93D File Offset: 0x00648B3D
		public static void AddCameraPos(FlatBufferBuilder builder, Offset<IVectorInfo> cameraPosOffset)
		{
			builder.AddOffset(6, cameraPosOffset.Value, 0);
		}

		// Token: 0x0602E084 RID: 188548 RVA: 0x0064A94D File Offset: 0x00648B4D
		public static void AddCameraPosEntityId(FlatBufferBuilder builder, int cameraPosEntityId)
		{
			builder.AddInt(7, cameraPosEntityId, 0);
		}

		// Token: 0x0602E085 RID: 188549 RVA: 0x0064A958 File Offset: 0x00648B58
		public static void AddIsLockCameraPos(FlatBufferBuilder builder, bool isLockCameraPos)
		{
			builder.AddBool(8, isLockCameraPos, false);
		}

		// Token: 0x0602E086 RID: 188550 RVA: 0x0064A963 File Offset: 0x00648B63
		public static void AddFov(FlatBufferBuilder builder, int fov)
		{
			builder.AddInt(9, fov, 0);
		}

		// Token: 0x0602E087 RID: 188551 RVA: 0x0064A96F File Offset: 0x00648B6F
		public static void AddArmLength(FlatBufferBuilder builder, int armLength)
		{
			builder.AddInt(10, armLength, 0);
		}

		// Token: 0x0602E088 RID: 188552 RVA: 0x0064A97B File Offset: 0x00648B7B
		public static void AddBanInput(FlatBufferBuilder builder, bool banInput)
		{
			builder.AddBool(11, banInput, false);
		}

		// Token: 0x0602E089 RID: 188553 RVA: 0x0064A987 File Offset: 0x00648B87
		public static void AddHideUi(FlatBufferBuilder builder, bool hideUi)
		{
			builder.AddBool(12, hideUi, false);
		}

		// Token: 0x0602E08A RID: 188554 RVA: 0x0064A993 File Offset: 0x00648B93
		public static void AddCancelBuffer(FlatBufferBuilder builder, bool cancelBuffer)
		{
			builder.AddBool(13, cancelBuffer, false);
		}

		// Token: 0x0602E08B RID: 188555 RVA: 0x0064A99F File Offset: 0x00648B9F
		public static void AddCancelBlendOut(FlatBufferBuilder builder, bool cancelBlendOut)
		{
			builder.AddBool(14, cancelBlendOut, false);
		}

		// Token: 0x0602E08C RID: 188556 RVA: 0x0064A9AB File Offset: 0x00648BAB
		public static void AddDisableCameraOffSet(FlatBufferBuilder builder, bool disableCameraOffSet)
		{
			builder.AddBool(15, disableCameraOffSet, false);
		}

		// Token: 0x0602E08D RID: 188557 RVA: 0x0064A9B7 File Offset: 0x00648BB7
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(16, nullMask, 0);
		}

		// Token: 0x0602E08E RID: 188558 RVA: 0x0064A9C3 File Offset: 0x00648BC3
		public static Offset<ICameraLookAt> EndICameraLookAt(FlatBufferBuilder builder)
		{
			return new Offset<ICameraLookAt>(builder.EndTable());
		}

		// Token: 0x0602E08F RID: 188559 RVA: 0x0064A9D0 File Offset: 0x00648BD0
		public ICameraLookAtT UnPack()
		{
			ICameraLookAtT cameraLookAtT = new ICameraLookAtT();
			this.UnPackTo(cameraLookAtT);
			return cameraLookAtT;
		}

		// Token: 0x0602E090 RID: 188560 RVA: 0x0064A9EC File Offset: 0x00648BEC
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

		// Token: 0x0602E091 RID: 188561 RVA: 0x0064AB0C File Offset: 0x00648D0C
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

		// Token: 0x04011616 RID: 71190
		private Table __p;
	}
}
