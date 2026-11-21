using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F46 RID: 32582
	public class TMotorParamsChangeConfigUnion
	{
		// Token: 0x1700F2A7 RID: 62119
		// (get) Token: 0x0603AC11 RID: 240657 RVA: 0x007E6512 File Offset: 0x007E4712
		// (set) Token: 0x0603AC12 RID: 240658 RVA: 0x007E651A File Offset: 0x007E471A
		public TMotorParamsChangeConfig Type { get; set; }

		// Token: 0x1700F2A8 RID: 62120
		// (get) Token: 0x0603AC13 RID: 240659 RVA: 0x007E6523 File Offset: 0x007E4723
		// (set) Token: 0x0603AC14 RID: 240660 RVA: 0x007E652B File Offset: 0x007E472B
		public object Value { get; set; }

		// Token: 0x0603AC15 RID: 240661 RVA: 0x007E6534 File Offset: 0x007E4734
		public TMotorParamsChangeConfigUnion()
		{
			this.Type = TMotorParamsChangeConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0603AC16 RID: 240662 RVA: 0x007E654A File Offset: 0x007E474A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AC17 RID: 240663 RVA: 0x007E655C File Offset: 0x007E475C
		public IMotorSpeedDownConfigT AsIMotorSpeedDownConfig()
		{
			return this.As<IMotorSpeedDownConfigT>();
		}

		// Token: 0x0603AC18 RID: 240664 RVA: 0x007E6564 File Offset: 0x007E4764
		public static TMotorParamsChangeConfigUnion FromIMotorSpeedDownConfig(IMotorSpeedDownConfigT _imotorspeeddownconfig)
		{
			return new TMotorParamsChangeConfigUnion
			{
				Type = TMotorParamsChangeConfig.IMotorSpeedDownConfig,
				Value = _imotorspeeddownconfig
			};
		}

		// Token: 0x0603AC19 RID: 240665 RVA: 0x007E6579 File Offset: 0x007E4779
		public IMotorSpeedUpConfigT AsIMotorSpeedUpConfig()
		{
			return this.As<IMotorSpeedUpConfigT>();
		}

		// Token: 0x0603AC1A RID: 240666 RVA: 0x007E6581 File Offset: 0x007E4781
		public static TMotorParamsChangeConfigUnion FromIMotorSpeedUpConfig(IMotorSpeedUpConfigT _imotorspeedupconfig)
		{
			return new TMotorParamsChangeConfigUnion
			{
				Type = TMotorParamsChangeConfig.IMotorSpeedUpConfig,
				Value = _imotorspeedupconfig
			};
		}

		// Token: 0x0603AC1B RID: 240667 RVA: 0x007E6598 File Offset: 0x007E4798
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
