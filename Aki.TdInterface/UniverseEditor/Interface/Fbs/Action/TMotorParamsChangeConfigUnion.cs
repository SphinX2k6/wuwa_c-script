using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007720 RID: 30496
	public class TMotorParamsChangeConfigUnion
	{
		// Token: 0x1700E659 RID: 58969
		// (get) Token: 0x060376E8 RID: 227048 RVA: 0x0078175E File Offset: 0x0077F95E
		// (set) Token: 0x060376E9 RID: 227049 RVA: 0x00781766 File Offset: 0x0077F966
		public TMotorParamsChangeConfig Type { get; set; }

		// Token: 0x1700E65A RID: 58970
		// (get) Token: 0x060376EA RID: 227050 RVA: 0x0078176F File Offset: 0x0077F96F
		// (set) Token: 0x060376EB RID: 227051 RVA: 0x00781777 File Offset: 0x0077F977
		public object Value { get; set; }

		// Token: 0x060376EC RID: 227052 RVA: 0x00781780 File Offset: 0x0077F980
		public TMotorParamsChangeConfigUnion()
		{
			this.Type = TMotorParamsChangeConfig.NONE;
			this.Value = null;
		}

		// Token: 0x060376ED RID: 227053 RVA: 0x00781796 File Offset: 0x0077F996
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060376EE RID: 227054 RVA: 0x007817A8 File Offset: 0x0077F9A8
		public IMotorSpeedDownConfigT AsIMotorSpeedDownConfig()
		{
			return this.As<IMotorSpeedDownConfigT>();
		}

		// Token: 0x060376EF RID: 227055 RVA: 0x007817B0 File Offset: 0x0077F9B0
		public static TMotorParamsChangeConfigUnion FromIMotorSpeedDownConfig(IMotorSpeedDownConfigT _imotorspeeddownconfig)
		{
			return new TMotorParamsChangeConfigUnion
			{
				Type = TMotorParamsChangeConfig.IMotorSpeedDownConfig,
				Value = _imotorspeeddownconfig
			};
		}

		// Token: 0x060376F0 RID: 227056 RVA: 0x007817C5 File Offset: 0x0077F9C5
		public IMotorSpeedUpConfigT AsIMotorSpeedUpConfig()
		{
			return this.As<IMotorSpeedUpConfigT>();
		}

		// Token: 0x060376F1 RID: 227057 RVA: 0x007817CD File Offset: 0x0077F9CD
		public static TMotorParamsChangeConfigUnion FromIMotorSpeedUpConfig(IMotorSpeedUpConfigT _imotorspeedupconfig)
		{
			return new TMotorParamsChangeConfigUnion
			{
				Type = TMotorParamsChangeConfig.IMotorSpeedUpConfig,
				Value = _imotorspeedupconfig
			};
		}

		// Token: 0x060376F2 RID: 227058 RVA: 0x007817E4 File Offset: 0x0077F9E4
		public static int Pack(FlatBufferBuilder builder, TMotorParamsChangeConfigUnion _o)
		{
			TMotorParamsChangeConfig type = _o.Type;
			if (type == TMotorParamsChangeConfig.IMotorSpeedDownConfig)
			{
				return IMotorSpeedDownConfig.Pack(builder, _o.AsIMotorSpeedDownConfig()).Value;
			}
			if (type != TMotorParamsChangeConfig.IMotorSpeedUpConfig)
			{
				return 0;
			}
			return IMotorSpeedUpConfig.Pack(builder, _o.AsIMotorSpeedUpConfig()).Value;
		}
	}
}
