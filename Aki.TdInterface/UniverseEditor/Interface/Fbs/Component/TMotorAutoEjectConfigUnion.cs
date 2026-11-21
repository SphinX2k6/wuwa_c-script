using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200628F RID: 25231
	public class TMotorAutoEjectConfigUnion
	{
		// Token: 0x1700BB76 RID: 47990
		// (get) Token: 0x0602AEB1 RID: 175793 RVA: 0x005DB56A File Offset: 0x005D976A
		// (set) Token: 0x0602AEB2 RID: 175794 RVA: 0x005DB572 File Offset: 0x005D9772
		public TMotorAutoEjectConfig Type { get; set; }

		// Token: 0x1700BB77 RID: 47991
		// (get) Token: 0x0602AEB3 RID: 175795 RVA: 0x005DB57B File Offset: 0x005D977B
		// (set) Token: 0x0602AEB4 RID: 175796 RVA: 0x005DB583 File Offset: 0x005D9783
		public object Value { get; set; }

		// Token: 0x0602AEB5 RID: 175797 RVA: 0x005DB58C File Offset: 0x005D978C
		public TMotorAutoEjectConfigUnion()
		{
			this.Type = TMotorAutoEjectConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0602AEB6 RID: 175798 RVA: 0x005DB5A2 File Offset: 0x005D97A2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AEB7 RID: 175799 RVA: 0x005DB5B4 File Offset: 0x005D97B4
		public IMotorAutoEjectNextHookConfigT AsIMotorAutoEjectNextHookConfig()
		{
			return this.As<IMotorAutoEjectNextHookConfigT>();
		}

		// Token: 0x0602AEB8 RID: 175800 RVA: 0x005DB5BC File Offset: 0x005D97BC
		public static TMotorAutoEjectConfigUnion FromIMotorAutoEjectNextHookConfig(IMotorAutoEjectNextHookConfigT _imotorautoejectnexthookconfig)
		{
			return new TMotorAutoEjectConfigUnion
			{
				Type = TMotorAutoEjectConfig.IMotorAutoEjectNextHookConfig,
				Value = _imotorautoejectnexthookconfig
			};
		}

		// Token: 0x0602AEB9 RID: 175801 RVA: 0x005DB5D1 File Offset: 0x005D97D1
		public IMotorAutoEjectPositionEntityConfigT AsIMotorAutoEjectPositionEntityConfig()
		{
			return this.As<IMotorAutoEjectPositionEntityConfigT>();
		}

		// Token: 0x0602AEBA RID: 175802 RVA: 0x005DB5D9 File Offset: 0x005D97D9
		public static TMotorAutoEjectConfigUnion FromIMotorAutoEjectPositionEntityConfig(IMotorAutoEjectPositionEntityConfigT _imotorautoejectpositionentityconfig)
		{
			return new TMotorAutoEjectConfigUnion
			{
				Type = TMotorAutoEjectConfig.IMotorAutoEjectPositionEntityConfig,
				Value = _imotorautoejectpositionentityconfig
			};
		}

		// Token: 0x0602AEBB RID: 175803 RVA: 0x005DB5F0 File Offset: 0x005D97F0
		public static int Pack(FlatBufferBuilder builder, TMotorAutoEjectConfigUnion _o)
		{
			TMotorAutoEjectConfig type = _o.Type;
			if (type == TMotorAutoEjectConfig.IMotorAutoEjectNextHookConfig)
			{
				return IMotorAutoEjectNextHookConfig.Pack(builder, _o.AsIMotorAutoEjectNextHookConfig()).Value;
			}
			if (type != TMotorAutoEjectConfig.IMotorAutoEjectPositionEntityConfig)
			{
				return 0;
			}
			return IMotorAutoEjectPositionEntityConfig.Pack(builder, _o.AsIMotorAutoEjectPositionEntityConfig()).Value;
		}
	}
}
