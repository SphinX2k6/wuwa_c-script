using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067B4 RID: 26548
	public struct IAdjustFixedCameraOrthogonalConfig : IFlatbufferObject
	{
		// Token: 0x1700C237 RID: 49719
		// (get) Token: 0x0602D327 RID: 185127 RVA: 0x0062F3B0 File Offset: 0x0062D5B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D328 RID: 185128 RVA: 0x0062F3BD File Offset: 0x0062D5BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D329 RID: 185129 RVA: 0x0062F3C4 File Offset: 0x0062D5C4
		public static IAdjustFixedCameraOrthogonalConfig GetRootAsIAdjustFixedCameraOrthogonalConfig(ByteBuffer _bb)
		{
			return IAdjustFixedCameraOrthogonalConfig.GetRootAsIAdjustFixedCameraOrthogonalConfig(_bb, default(IAdjustFixedCameraOrthogonalConfig));
		}

		// Token: 0x0602D32A RID: 185130 RVA: 0x0062F3E0 File Offset: 0x0062D5E0
		public static IAdjustFixedCameraOrthogonalConfig GetRootAsIAdjustFixedCameraOrthogonalConfig(ByteBuffer _bb, IAdjustFixedCameraOrthogonalConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D32B RID: 185131 RVA: 0x0062F3FD File Offset: 0x0062D5FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D32C RID: 185132 RVA: 0x0062F40C File Offset: 0x0062D60C
		public IAdjustFixedCameraOrthogonalConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C238 RID: 49720
		// (get) Token: 0x0602D32D RID: 185133 RVA: 0x0062F41C File Offset: 0x0062D61C
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

		// Token: 0x1700C239 RID: 49721
		// (get) Token: 0x0602D32E RID: 185134 RVA: 0x0062F47C File Offset: 0x0062D67C
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

		// Token: 0x1700C23A RID: 49722
		// (get) Token: 0x0602D32F RID: 185135 RVA: 0x0062F4BC File Offset: 0x0062D6BC
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

		// Token: 0x1700C23B RID: 49723
		// (get) Token: 0x0602D330 RID: 185136 RVA: 0x0062F4FC File Offset: 0x0062D6FC
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

		// Token: 0x0602D331 RID: 185137 RVA: 0x0062F539 File Offset: 0x0062D739
		public static Offset<IAdjustFixedCameraOrthogonalConfig> CreateIAdjustFixedCameraOrthogonalConfig(FlatBufferBuilder builder, Offset<IVectorInfo> BasePointOffset = default(Offset<IVectorInfo>), float FadeInTime = 0f, float FadeOutTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			IAdjustFixedCameraOrthogonalConfig.AddFadeOutTime(builder, FadeOutTime);
			IAdjustFixedCameraOrthogonalConfig.AddFadeInTime(builder, FadeInTime);
			IAdjustFixedCameraOrthogonalConfig.AddBasePoint(builder, BasePointOffset);
			IAdjustFixedCameraOrthogonalConfig.AddNullMask(builder, NullMask);
			return IAdjustFixedCameraOrthogonalConfig.EndIAdjustFixedCameraOrthogonalConfig(builder);
		}

		// Token: 0x0602D332 RID: 185138 RVA: 0x0062F565 File Offset: 0x0062D765
		public static void StartIAdjustFixedCameraOrthogonalConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602D333 RID: 185139 RVA: 0x0062F56E File Offset: 0x0062D76E
		public static void AddBasePoint(FlatBufferBuilder builder, Offset<IVectorInfo> basePointOffset)
		{
			builder.AddOffset(0, basePointOffset.Value, 0);
		}

		// Token: 0x0602D334 RID: 185140 RVA: 0x0062F57E File Offset: 0x0062D77E
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(1, fadeInTime, 0.0);
		}

		// Token: 0x0602D335 RID: 185141 RVA: 0x0062F591 File Offset: 0x0062D791
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(2, fadeOutTime, 0.0);
		}

		// Token: 0x0602D336 RID: 185142 RVA: 0x0062F5A4 File Offset: 0x0062D7A4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602D337 RID: 185143 RVA: 0x0062F5AF File Offset: 0x0062D7AF
		public static Offset<IAdjustFixedCameraOrthogonalConfig> EndIAdjustFixedCameraOrthogonalConfig(FlatBufferBuilder builder)
		{
			return new Offset<IAdjustFixedCameraOrthogonalConfig>(builder.EndTable());
		}

		// Token: 0x0602D338 RID: 185144 RVA: 0x0062F5BC File Offset: 0x0062D7BC
		public IAdjustFixedCameraOrthogonalConfigT UnPack()
		{
			IAdjustFixedCameraOrthogonalConfigT adjustFixedCameraOrthogonalConfigT = new IAdjustFixedCameraOrthogonalConfigT();
			this.UnPackTo(adjustFixedCameraOrthogonalConfigT);
			return adjustFixedCameraOrthogonalConfigT;
		}

		// Token: 0x0602D339 RID: 185145 RVA: 0x0062F5D8 File Offset: 0x0062D7D8
		public void UnPackTo(IAdjustFixedCameraOrthogonalConfigT _o)
		{
			_o.BasePoint = ((this.BasePoint != null) ? this.BasePoint.Value.UnPack() : null);
			_o.FadeInTime = this.FadeInTime;
			_o.FadeOutTime = this.FadeOutTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602D33A RID: 185146 RVA: 0x0062F638 File Offset: 0x0062D838
		public static Offset<IAdjustFixedCameraOrthogonalConfig> Pack(FlatBufferBuilder builder, IAdjustFixedCameraOrthogonalConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAdjustFixedCameraOrthogonalConfig>);
			}
			Offset<IVectorInfo> basePointOffset = (_o.BasePoint == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.BasePoint);
			return IAdjustFixedCameraOrthogonalConfig.CreateIAdjustFixedCameraOrthogonalConfig(builder, basePointOffset, _o.FadeInTime, _o.FadeOutTime, _o.NullMask);
		}

		// Token: 0x040113C5 RID: 70597
		private Table __p;
	}
}
