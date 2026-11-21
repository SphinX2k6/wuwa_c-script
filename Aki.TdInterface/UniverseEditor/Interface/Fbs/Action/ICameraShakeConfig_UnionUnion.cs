using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006917 RID: 26903
	public class ICameraShakeConfig_UnionUnion
	{
		// Token: 0x1700C609 RID: 50697
		// (get) Token: 0x0602E182 RID: 188802 RVA: 0x0064C819 File Offset: 0x0064AA19
		// (set) Token: 0x0602E183 RID: 188803 RVA: 0x0064C821 File Offset: 0x0064AA21
		public ICameraShakeConfig_Union Type { get; set; }

		// Token: 0x1700C60A RID: 50698
		// (get) Token: 0x0602E184 RID: 188804 RVA: 0x0064C82A File Offset: 0x0064AA2A
		// (set) Token: 0x0602E185 RID: 188805 RVA: 0x0064C832 File Offset: 0x0064AA32
		public object Value { get; set; }

		// Token: 0x0602E186 RID: 188806 RVA: 0x0064C83B File Offset: 0x0064AA3B
		public ICameraShakeConfig_UnionUnion()
		{
			this.Type = ICameraShakeConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602E187 RID: 188807 RVA: 0x0064C851 File Offset: 0x0064AA51
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602E188 RID: 188808 RVA: 0x0064C863 File Offset: 0x0064AA63
		public ICameraShakeConfigT AsICameraShakeConfig()
		{
			return this.As<ICameraShakeConfigT>();
		}

		// Token: 0x0602E189 RID: 188809 RVA: 0x0064C86B File Offset: 0x0064AA6B
		public static ICameraShakeConfig_UnionUnion FromICameraShakeConfig(ICameraShakeConfigT _icamerashakeconfig)
		{
			return new ICameraShakeConfig_UnionUnion
			{
				Type = ICameraShakeConfig_Union.ICameraShakeConfig,
				Value = _icamerashakeconfig
			};
		}

		// Token: 0x0602E18A RID: 188810 RVA: 0x0064C880 File Offset: 0x0064AA80
		public IConstantCameraShakeT AsIConstantCameraShake()
		{
			return this.As<IConstantCameraShakeT>();
		}

		// Token: 0x0602E18B RID: 188811 RVA: 0x0064C888 File Offset: 0x0064AA88
		public static ICameraShakeConfig_UnionUnion FromIConstantCameraShake(IConstantCameraShakeT _iconstantcamerashake)
		{
			return new ICameraShakeConfig_UnionUnion
			{
				Type = ICameraShakeConfig_Union.IConstantCameraShake,
				Value = _iconstantcamerashake
			};
		}

		// Token: 0x0602E18C RID: 188812 RVA: 0x0064C89D File Offset: 0x0064AA9D
		public ILinearOverRangeCameraShakeT AsILinearOverRangeCameraShake()
		{
			return this.As<ILinearOverRangeCameraShakeT>();
		}

		// Token: 0x0602E18D RID: 188813 RVA: 0x0064C8A5 File Offset: 0x0064AAA5
		public static ICameraShakeConfig_UnionUnion FromILinearOverRangeCameraShake(ILinearOverRangeCameraShakeT _ilinearoverrangecamerashake)
		{
			return new ICameraShakeConfig_UnionUnion
			{
				Type = ICameraShakeConfig_Union.ILinearOverRangeCameraShake,
				Value = _ilinearoverrangecamerashake
			};
		}

		// Token: 0x0602E18E RID: 188814 RVA: 0x0064C8BC File Offset: 0x0064AABC
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
