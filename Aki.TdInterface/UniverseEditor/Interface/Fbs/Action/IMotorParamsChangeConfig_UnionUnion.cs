using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007259 RID: 29273
	public class IMotorParamsChangeConfig_UnionUnion
	{
		// Token: 0x1700D6A5 RID: 54949
		// (get) Token: 0x06033002 RID: 208898 RVA: 0x006E26FD File Offset: 0x006E08FD
		// (set) Token: 0x06033003 RID: 208899 RVA: 0x006E2705 File Offset: 0x006E0905
		public IMotorParamsChangeConfig_Union Type { get; set; }

		// Token: 0x1700D6A6 RID: 54950
		// (get) Token: 0x06033004 RID: 208900 RVA: 0x006E270E File Offset: 0x006E090E
		// (set) Token: 0x06033005 RID: 208901 RVA: 0x006E2716 File Offset: 0x006E0916
		public object Value { get; set; }

		// Token: 0x06033006 RID: 208902 RVA: 0x006E271F File Offset: 0x006E091F
		public IMotorParamsChangeConfig_UnionUnion()
		{
			this.Type = IMotorParamsChangeConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06033007 RID: 208903 RVA: 0x006E2735 File Offset: 0x006E0935
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06033008 RID: 208904 RVA: 0x006E2747 File Offset: 0x006E0947
		public IMotorParamsChangeConfigT AsIMotorParamsChangeConfig()
		{
			return this.As<IMotorParamsChangeConfigT>();
		}

		// Token: 0x06033009 RID: 208905 RVA: 0x006E274F File Offset: 0x006E094F
		public static IMotorParamsChangeConfig_UnionUnion FromIMotorParamsChangeConfig(IMotorParamsChangeConfigT _imotorparamschangeconfig)
		{
			return new IMotorParamsChangeConfig_UnionUnion
			{
				Type = IMotorParamsChangeConfig_Union.IMotorParamsChangeConfig,
				Value = _imotorparamschangeconfig
			};
		}

		// Token: 0x0603300A RID: 208906 RVA: 0x006E2764 File Offset: 0x006E0964
		public IMotorSpeedUpConfigT AsIMotorSpeedUpConfig()
		{
			return this.As<IMotorSpeedUpConfigT>();
		}

		// Token: 0x0603300B RID: 208907 RVA: 0x006E276C File Offset: 0x006E096C
		public static IMotorParamsChangeConfig_UnionUnion FromIMotorSpeedUpConfig(IMotorSpeedUpConfigT _imotorspeedupconfig)
		{
			return new IMotorParamsChangeConfig_UnionUnion
			{
				Type = IMotorParamsChangeConfig_Union.IMotorSpeedUpConfig,
				Value = _imotorspeedupconfig
			};
		}

		// Token: 0x0603300C RID: 208908 RVA: 0x006E2781 File Offset: 0x006E0981
		public IMotorSpeedDownConfigT AsIMotorSpeedDownConfig()
		{
			return this.As<IMotorSpeedDownConfigT>();
		}

		// Token: 0x0603300D RID: 208909 RVA: 0x006E2789 File Offset: 0x006E0989
		public static IMotorParamsChangeConfig_UnionUnion FromIMotorSpeedDownConfig(IMotorSpeedDownConfigT _imotorspeeddownconfig)
		{
			return new IMotorParamsChangeConfig_UnionUnion
			{
				Type = IMotorParamsChangeConfig_Union.IMotorSpeedDownConfig,
				Value = _imotorspeeddownconfig
			};
		}

		// Token: 0x0603300E RID: 208910 RVA: 0x006E27A0 File Offset: 0x006E09A0
		public static int Pack(FlatBufferBuilder builder, IMotorParamsChangeConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IMotorParamsChangeConfig_Union.IMotorParamsChangeConfig:
				return IMotorParamsChangeConfig.Pack(builder, _o.AsIMotorParamsChangeConfig()).Value;
			case IMotorParamsChangeConfig_Union.IMotorSpeedUpConfig:
				return IMotorSpeedUpConfig.Pack(builder, _o.AsIMotorSpeedUpConfig()).Value;
			case IMotorParamsChangeConfig_Union.IMotorSpeedDownConfig:
				return IMotorSpeedDownConfig.Pack(builder, _o.AsIMotorSpeedDownConfig()).Value;
			default:
				return 0;
			}
		}
	}
}
