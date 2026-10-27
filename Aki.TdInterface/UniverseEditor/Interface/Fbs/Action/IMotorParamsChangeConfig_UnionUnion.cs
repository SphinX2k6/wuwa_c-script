using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B22 RID: 27426
	public class IMotorParamsChangeConfig_UnionUnion
	{
		// Token: 0x1700CBD6 RID: 52182
		// (get) Token: 0x0603022E RID: 197166 RVA: 0x0068B045 File Offset: 0x00689245
		// (set) Token: 0x0603022F RID: 197167 RVA: 0x0068B04D File Offset: 0x0068924D
		public IMotorParamsChangeConfig_Union Type { get; set; }

		// Token: 0x1700CBD7 RID: 52183
		// (get) Token: 0x06030230 RID: 197168 RVA: 0x0068B056 File Offset: 0x00689256
		// (set) Token: 0x06030231 RID: 197169 RVA: 0x0068B05E File Offset: 0x0068925E
		public object Value { get; set; }

		// Token: 0x06030232 RID: 197170 RVA: 0x0068B067 File Offset: 0x00689267
		public IMotorParamsChangeConfig_UnionUnion()
		{
			this.Type = IMotorParamsChangeConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06030233 RID: 197171 RVA: 0x0068B07D File Offset: 0x0068927D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06030234 RID: 197172 RVA: 0x0068B08F File Offset: 0x0068928F
		public IMotorParamsChangeConfigT AsIMotorParamsChangeConfig()
		{
			return this.As<IMotorParamsChangeConfigT>();
		}

		// Token: 0x06030235 RID: 197173 RVA: 0x0068B097 File Offset: 0x00689297
		public static IMotorParamsChangeConfig_UnionUnion FromIMotorParamsChangeConfig(IMotorParamsChangeConfigT _imotorparamschangeconfig)
		{
			return new IMotorParamsChangeConfig_UnionUnion
			{
				Type = IMotorParamsChangeConfig_Union.IMotorParamsChangeConfig,
				Value = _imotorparamschangeconfig
			};
		}

		// Token: 0x06030236 RID: 197174 RVA: 0x0068B0AC File Offset: 0x006892AC
		public IMotorSpeedUpConfigT AsIMotorSpeedUpConfig()
		{
			return this.As<IMotorSpeedUpConfigT>();
		}

		// Token: 0x06030237 RID: 197175 RVA: 0x0068B0B4 File Offset: 0x006892B4
		public static IMotorParamsChangeConfig_UnionUnion FromIMotorSpeedUpConfig(IMotorSpeedUpConfigT _imotorspeedupconfig)
		{
			return new IMotorParamsChangeConfig_UnionUnion
			{
				Type = IMotorParamsChangeConfig_Union.IMotorSpeedUpConfig,
				Value = _imotorspeedupconfig
			};
		}

		// Token: 0x06030238 RID: 197176 RVA: 0x0068B0C9 File Offset: 0x006892C9
		public IMotorSpeedDownConfigT AsIMotorSpeedDownConfig()
		{
			return this.As<IMotorSpeedDownConfigT>();
		}

		// Token: 0x06030239 RID: 197177 RVA: 0x0068B0D1 File Offset: 0x006892D1
		public static IMotorParamsChangeConfig_UnionUnion FromIMotorSpeedDownConfig(IMotorSpeedDownConfigT _imotorspeeddownconfig)
		{
			return new IMotorParamsChangeConfig_UnionUnion
			{
				Type = IMotorParamsChangeConfig_Union.IMotorSpeedDownConfig,
				Value = _imotorspeeddownconfig
			};
		}

		// Token: 0x0603023A RID: 197178 RVA: 0x0068B0E8 File Offset: 0x006892E8
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
