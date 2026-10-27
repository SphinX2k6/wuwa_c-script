using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200614F RID: 24911
	public struct IAdjustFixedCameraOrthogonalConfig : IFlatbufferObject
	{
		// Token: 0x1700B8C7 RID: 47303
		// (get) Token: 0x0602AC2E RID: 175150 RVA: 0x005E51D4 File Offset: 0x005E33D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602AC2F RID: 175151 RVA: 0x005E51E1 File Offset: 0x005E33E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602AC30 RID: 175152 RVA: 0x005E51E8 File Offset: 0x005E33E8
		public static IAdjustFixedCameraOrthogonalConfig GetRootAsIAdjustFixedCameraOrthogonalConfig(ByteBuffer _bb)
		{
			return IAdjustFixedCameraOrthogonalConfig.GetRootAsIAdjustFixedCameraOrthogonalConfig(_bb, default(IAdjustFixedCameraOrthogonalConfig));
		}

		// Token: 0x0602AC31 RID: 175153 RVA: 0x005E5204 File Offset: 0x005E3404
		public static IAdjustFixedCameraOrthogonalConfig GetRootAsIAdjustFixedCameraOrthogonalConfig(ByteBuffer _bb, IAdjustFixedCameraOrthogonalConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602AC32 RID: 175154 RVA: 0x005E5221 File Offset: 0x005E3421
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602AC33 RID: 175155 RVA: 0x005E5230 File Offset: 0x005E3430
		public IAdjustFixedCameraOrthogonalConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B8C8 RID: 47304
		// (get) Token: 0x0602AC34 RID: 175156 RVA: 0x005E5240 File Offset: 0x005E3440
		public IVectorInfo? BasePoint
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

		// Token: 0x1700B8C9 RID: 47305
		// (get) Token: 0x0602AC35 RID: 175157 RVA: 0x005E52A0 File Offset: 0x005E34A0
		public float FadeInTime
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

		// Token: 0x1700B8CA RID: 47306
		// (get) Token: 0x0602AC36 RID: 175158 RVA: 0x005E52E0 File Offset: 0x005E34E0
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

		// Token: 0x1700B8CB RID: 47307
		// (get) Token: 0x0602AC37 RID: 175159 RVA: 0x005E5320 File Offset: 0x005E3520
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602AC38 RID: 175160 RVA: 0x005E535D File Offset: 0x005E355D
		public static Offset<IAdjustFixedCameraOrthogonalConfig> CreateIAdjustFixedCameraOrthogonalConfig(FlatBufferBuilder builder, Offset<IVectorInfo> BasePointOffset = default(Offset<IVectorInfo>), float FadeInTime = 0f, float FadeOutTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			IAdjustFixedCameraOrthogonalConfig.AddFadeOutTime(builder, FadeOutTime);
			IAdjustFixedCameraOrthogonalConfig.AddFadeInTime(builder, FadeInTime);
			IAdjustFixedCameraOrthogonalConfig.AddBasePoint(builder, BasePointOffset);
			IAdjustFixedCameraOrthogonalConfig.AddNullMask(builder, NullMask);
			return IAdjustFixedCameraOrthogonalConfig.EndIAdjustFixedCameraOrthogonalConfig(builder);
		}

		// Token: 0x0602AC39 RID: 175161 RVA: 0x005E5389 File Offset: 0x005E3589
		public static void StartIAdjustFixedCameraOrthogonalConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602AC3A RID: 175162 RVA: 0x005E5392 File Offset: 0x005E3592
		public static void AddBasePoint(FlatBufferBuilder builder, Offset<IVectorInfo> basePointOffset)
		{
			builder.AddOffset(0, basePointOffset.Value, 0);
		}

		// Token: 0x0602AC3B RID: 175163 RVA: 0x005E53A2 File Offset: 0x005E35A2
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(1, fadeInTime, 0.0);
		}

		// Token: 0x0602AC3C RID: 175164 RVA: 0x005E53B5 File Offset: 0x005E35B5
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(2, fadeOutTime, 0.0);
		}

		// Token: 0x0602AC3D RID: 175165 RVA: 0x005E53C8 File Offset: 0x005E35C8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602AC3E RID: 175166 RVA: 0x005E53D3 File Offset: 0x005E35D3
		public static Offset<IAdjustFixedCameraOrthogonalConfig> EndIAdjustFixedCameraOrthogonalConfig(FlatBufferBuilder builder)
		{
			return new Offset<IAdjustFixedCameraOrthogonalConfig>(builder.EndTable());
		}

		// Token: 0x0602AC3F RID: 175167 RVA: 0x005E53E0 File Offset: 0x005E35E0
		public IAdjustFixedCameraOrthogonalConfigT UnPack()
		{
			IAdjustFixedCameraOrthogonalConfigT adjustFixedCameraOrthogonalConfigT = new IAdjustFixedCameraOrthogonalConfigT();
			this.UnPackTo(adjustFixedCameraOrthogonalConfigT);
			return adjustFixedCameraOrthogonalConfigT;
		}

		// Token: 0x0602AC40 RID: 175168 RVA: 0x005E53FC File Offset: 0x005E35FC
		public void UnPackTo(IAdjustFixedCameraOrthogonalConfigT _o)
		{
			_o.BasePoint = ((this.BasePoint != null) ? this.BasePoint.Value.UnPack() : null);
			_o.FadeInTime = this.FadeInTime;
			_o.FadeOutTime = this.FadeOutTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602AC41 RID: 175169 RVA: 0x005E545C File Offset: 0x005E365C
		public static Offset<IAdjustFixedCameraOrthogonalConfig> Pack(FlatBufferBuilder builder, IAdjustFixedCameraOrthogonalConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAdjustFixedCameraOrthogonalConfig>);
			}
			Offset<IVectorInfo> basePointOffset = (_o.BasePoint == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.BasePoint);
			return IAdjustFixedCameraOrthogonalConfig.CreateIAdjustFixedCameraOrthogonalConfig(builder, basePointOffset, _o.FadeInTime, _o.FadeOutTime, _o.NullMask);
		}

		// Token: 0x040105BE RID: 67006
		private Table __p;
	}
}
