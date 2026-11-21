using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E4B RID: 28235
	public struct IFixedCameraConfig : IFlatbufferObject
	{
		// Token: 0x1700CEEE RID: 52974
		// (get) Token: 0x06030C49 RID: 199753 RVA: 0x0069E58D File Offset: 0x0069C78D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030C4A RID: 199754 RVA: 0x0069E59A File Offset: 0x0069C79A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030C4B RID: 199755 RVA: 0x0069E5A4 File Offset: 0x0069C7A4
		public static IFixedCameraConfig GetRootAsIFixedCameraConfig(ByteBuffer _bb)
		{
			return IFixedCameraConfig.GetRootAsIFixedCameraConfig(_bb, default(IFixedCameraConfig));
		}

		// Token: 0x06030C4C RID: 199756 RVA: 0x0069E5C0 File Offset: 0x0069C7C0
		public static IFixedCameraConfig GetRootAsIFixedCameraConfig(ByteBuffer _bb, IFixedCameraConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030C4D RID: 199757 RVA: 0x0069E5DD File Offset: 0x0069C7DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030C4E RID: 199758 RVA: 0x0069E5EC File Offset: 0x0069C7EC
		public IFixedCameraConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CEEF RID: 52975
		// (get) Token: 0x06030C4F RID: 199759 RVA: 0x0069E5FC File Offset: 0x0069C7FC
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

		// Token: 0x1700CEF0 RID: 52976
		// (get) Token: 0x06030C50 RID: 199760 RVA: 0x0069E63C File Offset: 0x0069C83C
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

		// Token: 0x1700CEF1 RID: 52977
		// (get) Token: 0x06030C51 RID: 199761 RVA: 0x0069E67C File Offset: 0x0069C87C
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

		// Token: 0x1700CEF2 RID: 52978
		// (get) Token: 0x06030C52 RID: 199762 RVA: 0x0069E6BC File Offset: 0x0069C8BC
		public bool IsDisableCollision
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CEF3 RID: 52979
		// (get) Token: 0x06030C53 RID: 199763 RVA: 0x0069E6FC File Offset: 0x0069C8FC
		public bool IsDisableDither
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CEF4 RID: 52980
		// (get) Token: 0x06030C54 RID: 199764 RVA: 0x0069E73C File Offset: 0x0069C93C
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

		// Token: 0x1700CEF5 RID: 52981
		// (get) Token: 0x06030C55 RID: 199765 RVA: 0x0069E79C File Offset: 0x0069C99C
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

		// Token: 0x1700CEF6 RID: 52982
		// (get) Token: 0x06030C56 RID: 199766 RVA: 0x0069E7FC File Offset: 0x0069C9FC
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

		// Token: 0x06030C57 RID: 199767 RVA: 0x0069E83C File Offset: 0x0069CA3C
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

		// Token: 0x06030C58 RID: 199768 RVA: 0x0069E893 File Offset: 0x0069CA93
		public static void StartIFixedCameraConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06030C59 RID: 199769 RVA: 0x0069E89C File Offset: 0x0069CA9C
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(0, fadeInTime, 0.0);
		}

		// Token: 0x06030C5A RID: 199770 RVA: 0x0069E8AF File Offset: 0x0069CAAF
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(1, fadeOutTime, 0.0);
		}

		// Token: 0x06030C5B RID: 199771 RVA: 0x0069E8C2 File Offset: 0x0069CAC2
		public static void AddFov(FlatBufferBuilder builder, float fov)
		{
			builder.AddFloat(2, fov, 0.0);
		}

		// Token: 0x06030C5C RID: 199772 RVA: 0x0069E8D5 File Offset: 0x0069CAD5
		public static void AddIsDisableCollision(FlatBufferBuilder builder, bool isDisableCollision)
		{
			builder.AddBool(3, isDisableCollision, false);
		}

		// Token: 0x06030C5D RID: 199773 RVA: 0x0069E8E0 File Offset: 0x0069CAE0
		public static void AddIsDisableDither(FlatBufferBuilder builder, bool isDisableDither)
		{
			builder.AddBool(4, isDisableDither, false);
		}

		// Token: 0x06030C5E RID: 199774 RVA: 0x0069E8EB File Offset: 0x0069CAEB
		public static void AddCenterPos(FlatBufferBuilder builder, Offset<IVectorInfo> centerPosOffset)
		{
			builder.AddOffset(5, centerPosOffset.Value, 0);
		}

		// Token: 0x06030C5F RID: 199775 RVA: 0x0069E8FB File Offset: 0x0069CAFB
		public static void AddCenterRot(FlatBufferBuilder builder, Offset<IVectorInfo> centerRotOffset)
		{
			builder.AddOffset(6, centerRotOffset.Value, 0);
		}

		// Token: 0x06030C60 RID: 199776 RVA: 0x0069E90B File Offset: 0x0069CB0B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06030C61 RID: 199777 RVA: 0x0069E916 File Offset: 0x0069CB16
		public static Offset<IFixedCameraConfig> EndIFixedCameraConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFixedCameraConfig>(builder.EndTable());
		}

		// Token: 0x06030C62 RID: 199778 RVA: 0x0069E924 File Offset: 0x0069CB24
		public IFixedCameraConfigT UnPack()
		{
			IFixedCameraConfigT fixedCameraConfigT = new IFixedCameraConfigT();
			this.UnPackTo(fixedCameraConfigT);
			return fixedCameraConfigT;
		}

		// Token: 0x06030C63 RID: 199779 RVA: 0x0069E940 File Offset: 0x0069CB40
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

		// Token: 0x06030C64 RID: 199780 RVA: 0x0069E9F4 File Offset: 0x0069CBF4
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

		// Token: 0x04011D15 RID: 72981
		private Table __p;
	}
}
