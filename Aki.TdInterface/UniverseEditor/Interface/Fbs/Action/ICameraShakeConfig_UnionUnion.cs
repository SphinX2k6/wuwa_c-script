using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062A6 RID: 25254
	public class ICameraShakeConfig_UnionUnion
	{
		// Token: 0x1700BC81 RID: 48257
		// (get) Token: 0x0602BA21 RID: 178721 RVA: 0x00601A11 File Offset: 0x005FFC11
		// (set) Token: 0x0602BA22 RID: 178722 RVA: 0x00601A19 File Offset: 0x005FFC19
		public ICameraShakeConfig_Union Type { get; set; }

		// Token: 0x1700BC82 RID: 48258
		// (get) Token: 0x0602BA23 RID: 178723 RVA: 0x00601A22 File Offset: 0x005FFC22
		// (set) Token: 0x0602BA24 RID: 178724 RVA: 0x00601A2A File Offset: 0x005FFC2A
		public object Value { get; set; }

		// Token: 0x0602BA25 RID: 178725 RVA: 0x00601A33 File Offset: 0x005FFC33
		public ICameraShakeConfig_UnionUnion()
		{
			this.Type = ICameraShakeConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602BA26 RID: 178726 RVA: 0x00601A49 File Offset: 0x005FFC49
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602BA27 RID: 178727 RVA: 0x00601A5B File Offset: 0x005FFC5B
		public ICameraShakeConfigT AsICameraShakeConfig()
		{
			return this.As<ICameraShakeConfigT>();
		}

		// Token: 0x0602BA28 RID: 178728 RVA: 0x00601A63 File Offset: 0x005FFC63
		public static ICameraShakeConfig_UnionUnion FromICameraShakeConfig(ICameraShakeConfigT _icamerashakeconfig)
		{
			return new ICameraShakeConfig_UnionUnion
			{
				Type = ICameraShakeConfig_Union.ICameraShakeConfig,
				Value = _icamerashakeconfig
			};
		}

		// Token: 0x0602BA29 RID: 178729 RVA: 0x00601A78 File Offset: 0x005FFC78
		public IConstantCameraShakeT AsIConstantCameraShake()
		{
			return this.As<IConstantCameraShakeT>();
		}

		// Token: 0x0602BA2A RID: 178730 RVA: 0x00601A80 File Offset: 0x005FFC80
		public static ICameraShakeConfig_UnionUnion FromIConstantCameraShake(IConstantCameraShakeT _iconstantcamerashake)
		{
			return new ICameraShakeConfig_UnionUnion
			{
				Type = ICameraShakeConfig_Union.IConstantCameraShake,
				Value = _iconstantcamerashake
			};
		}

		// Token: 0x0602BA2B RID: 178731 RVA: 0x00601A95 File Offset: 0x005FFC95
		public ILinearOverRangeCameraShakeT AsILinearOverRangeCameraShake()
		{
			return this.As<ILinearOverRangeCameraShakeT>();
		}

		// Token: 0x0602BA2C RID: 178732 RVA: 0x00601A9D File Offset: 0x005FFC9D
		public static ICameraShakeConfig_UnionUnion FromILinearOverRangeCameraShake(ILinearOverRangeCameraShakeT _ilinearoverrangecamerashake)
		{
			return new ICameraShakeConfig_UnionUnion
			{
				Type = ICameraShakeConfig_Union.ILinearOverRangeCameraShake,
				Value = _ilinearoverrangecamerashake
			};
		}

		// Token: 0x0602BA2D RID: 178733 RVA: 0x00601AB4 File Offset: 0x005FFCB4
		public static int Pack(FlatBufferBuilder builder, ICameraShakeConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ICameraShakeConfig_Union.ICameraShakeConfig:
				return ICameraShakeConfig.Pack(builder, _o.AsICameraShakeConfig()).Value;
			case ICameraShakeConfig_Union.IConstantCameraShake:
				return IConstantCameraShake.Pack(builder, _o.AsIConstantCameraShake()).Value;
			case ICameraShakeConfig_Union.ILinearOverRangeCameraShake:
				return ILinearOverRangeCameraShake.Pack(builder, _o.AsILinearOverRangeCameraShake()).Value;
			default:
				return 0;
			}
		}
	}
}
