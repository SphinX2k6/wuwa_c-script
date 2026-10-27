using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067CB RID: 26571
	public struct IFixedCameraConfig : IFlatbufferObject
	{
		// Token: 0x1700C538 RID: 50488
		// (get) Token: 0x0602E403 RID: 189443 RVA: 0x00650E49 File Offset: 0x0064F049
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E404 RID: 189444 RVA: 0x00650E56 File Offset: 0x0064F056
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E405 RID: 189445 RVA: 0x00650E60 File Offset: 0x0064F060
		public static IFixedCameraConfig GetRootAsIFixedCameraConfig(ByteBuffer _bb)
		{
			return IFixedCameraConfig.GetRootAsIFixedCameraConfig(_bb, default(IFixedCameraConfig));
		}

		// Token: 0x0602E406 RID: 189446 RVA: 0x00650E7C File Offset: 0x0064F07C
		public static IFixedCameraConfig GetRootAsIFixedCameraConfig(ByteBuffer _bb, IFixedCameraConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E407 RID: 189447 RVA: 0x00650E99 File Offset: 0x0064F099
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E408 RID: 189448 RVA: 0x00650EA8 File Offset: 0x0064F0A8
		public IFixedCameraConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C539 RID: 50489
		// (get) Token: 0x0602E409 RID: 189449 RVA: 0x00650EB8 File Offset: 0x0064F0B8
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

		// Token: 0x1700C53A RID: 50490
		// (get) Token: 0x0602E40A RID: 189450 RVA: 0x00650EF8 File Offset: 0x0064F0F8
		public float FadeOutTime
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

		// Token: 0x1700C53B RID: 50491
		// (get) Token: 0x0602E40B RID: 189451 RVA: 0x00650F38 File Offset: 0x0064F138
		public float Fov
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

		// Token: 0x1700C53C RID: 50492
		// (get) Token: 0x0602E40C RID: 189452 RVA: 0x00650F78 File Offset: 0x0064F178
		public bool IsDisableCollision
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C53D RID: 50493
		// (get) Token: 0x0602E40D RID: 189453 RVA: 0x00650FB8 File Offset: 0x0064F1B8
		public bool IsDisableDither
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C53E RID: 50494
		// (get) Token: 0x0602E40E RID: 189454 RVA: 0x00650FF8 File Offset: 0x0064F1F8
		public IVectorInfo? CenterPos
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C53F RID: 50495
		// (get) Token: 0x0602E40F RID: 189455 RVA: 0x00651058 File Offset: 0x0064F258
		public IVectorInfo? CenterRot
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

		// Token: 0x1700C540 RID: 50496
		// (get) Token: 0x0602E410 RID: 189456 RVA: 0x006510B8 File Offset: 0x0064F2B8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E411 RID: 189457 RVA: 0x006510F8 File Offset: 0x0064F2F8
		public static Offset<IFixedCameraConfig> CreateIFixedCameraConfig(FlatBufferBuilder builder, float FadeInTime = 0f, float FadeOutTime = 0f, float Fov = 0f, bool IsDisableCollision = false, bool IsDisableDither = false, Offset<IVectorInfo> CenterPosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> CenterRotOffset = default(Offset<IVectorInfo>), byte NullMask = 0)
		{
			builder.StartTable(8);
			IFixedCameraConfig.AddCenterRot(builder, CenterRotOffset);
			IFixedCameraConfig.AddCenterPos(builder, CenterPosOffset);
			IFixedCameraConfig.AddFov(builder, Fov);
			IFixedCameraConfig.AddFadeOutTime(builder, FadeOutTime);
			IFixedCameraConfig.AddFadeInTime(builder, FadeInTime);
			IFixedCameraConfig.AddNullMask(builder, NullMask);
			IFixedCameraConfig.AddIsDisableDither(builder, IsDisableDither);
			IFixedCameraConfig.AddIsDisableCollision(builder, IsDisableCollision);
			return IFixedCameraConfig.EndIFixedCameraConfig(builder);
		}

		// Token: 0x0602E412 RID: 189458 RVA: 0x0065114F File Offset: 0x0064F34F
		public static void StartIFixedCameraConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0602E413 RID: 189459 RVA: 0x00651158 File Offset: 0x0064F358
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(0, fadeInTime, 0.0);
		}

		// Token: 0x0602E414 RID: 189460 RVA: 0x0065116B File Offset: 0x0064F36B
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(1, fadeOutTime, 0.0);
		}

		// Token: 0x0602E415 RID: 189461 RVA: 0x0065117E File Offset: 0x0064F37E
		public static void AddFov(FlatBufferBuilder builder, float fov)
		{
			builder.AddFloat(2, fov, 0.0);
		}

		// Token: 0x0602E416 RID: 189462 RVA: 0x00651191 File Offset: 0x0064F391
		public static void AddIsDisableCollision(FlatBufferBuilder builder, bool isDisableCollision)
		{
			builder.AddBool(3, isDisableCollision, false);
		}

		// Token: 0x0602E417 RID: 189463 RVA: 0x0065119C File Offset: 0x0064F39C
		public static void AddIsDisableDither(FlatBufferBuilder builder, bool isDisableDither)
		{
			builder.AddBool(4, isDisableDither, false);
		}

		// Token: 0x0602E418 RID: 189464 RVA: 0x006511A7 File Offset: 0x0064F3A7
		public static void AddCenterPos(FlatBufferBuilder builder, Offset<IVectorInfo> centerPosOffset)
		{
			builder.AddOffset(5, centerPosOffset.Value, 0);
		}

		// Token: 0x0602E419 RID: 189465 RVA: 0x006511B7 File Offset: 0x0064F3B7
		public static void AddCenterRot(FlatBufferBuilder builder, Offset<IVectorInfo> centerRotOffset)
		{
			builder.AddOffset(6, centerRotOffset.Value, 0);
		}

		// Token: 0x0602E41A RID: 189466 RVA: 0x006511C7 File Offset: 0x0064F3C7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0602E41B RID: 189467 RVA: 0x006511D2 File Offset: 0x0064F3D2
		public static Offset<IFixedCameraConfig> EndIFixedCameraConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFixedCameraConfig>(builder.EndTable());
		}

		// Token: 0x0602E41C RID: 189468 RVA: 0x006511E0 File Offset: 0x0064F3E0
		public IFixedCameraConfigT UnPack()
		{
			IFixedCameraConfigT fixedCameraConfigT = new IFixedCameraConfigT();
			this.UnPackTo(fixedCameraConfigT);
			return fixedCameraConfigT;
		}

		// Token: 0x0602E41D RID: 189469 RVA: 0x006511FC File Offset: 0x0064F3FC
		public void UnPackTo(IFixedCameraConfigT _o)
		{
			_o.FadeInTime = this.FadeInTime;
			_o.FadeOutTime = this.FadeOutTime;
			_o.Fov = this.Fov;
			_o.IsDisableCollision = this.IsDisableCollision;
			_o.IsDisableDither = this.IsDisableDither;
			_o.CenterPos = ((this.CenterPos != null) ? this.CenterPos.Value.UnPack() : null);
			_o.CenterRot = ((this.CenterRot != null) ? this.CenterRot.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602E41E RID: 189470 RVA: 0x006512B0 File Offset: 0x0064F4B0
		public static Offset<IFixedCameraConfig> Pack(FlatBufferBuilder builder, IFixedCameraConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFixedCameraConfig>);
			}
			Offset<IVectorInfo> centerPosOffset = (_o.CenterPos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.CenterPos);
			Offset<IVectorInfo> centerRotOffset = (_o.CenterRot == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.CenterRot);
			return IFixedCameraConfig.CreateIFixedCameraConfig(builder, _o.FadeInTime, _o.FadeOutTime, _o.Fov, _o.IsDisableCollision, _o.IsDisableDither, centerPosOffset, centerRotOffset, _o.NullMask);
		}

		// Token: 0x04010EE3 RID: 69347
		private Table __p;
	}
}
