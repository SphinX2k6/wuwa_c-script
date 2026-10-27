using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C67 RID: 23655
	public class TMotorAutoEjectConfigUnion
	{
		// Token: 0x1700B222 RID: 45602
		// (get) Token: 0x06028895 RID: 166037 RVA: 0x00593206 File Offset: 0x00591406
		// (set) Token: 0x06028896 RID: 166038 RVA: 0x0059320E File Offset: 0x0059140E
		public TMotorAutoEjectConfig Type { get; set; }

		// Token: 0x1700B223 RID: 45603
		// (get) Token: 0x06028897 RID: 166039 RVA: 0x00593217 File Offset: 0x00591417
		// (set) Token: 0x06028898 RID: 166040 RVA: 0x0059321F File Offset: 0x0059141F
		public object Value { get; set; }

		// Token: 0x06028899 RID: 166041 RVA: 0x00593228 File Offset: 0x00591428
		public TMotorAutoEjectConfigUnion()
		{
			this.Type = TMotorAutoEjectConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0602889A RID: 166042 RVA: 0x0059323E File Offset: 0x0059143E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602889B RID: 166043 RVA: 0x00593250 File Offset: 0x00591450
		public IMotorAutoEjectNextHookConfigT AsIMotorAutoEjectNextHookConfig()
		{
			return this.As<IMotorAutoEjectNextHookConfigT>();
		}

		// Token: 0x0602889C RID: 166044 RVA: 0x00593258 File Offset: 0x00591458
		public static TMotorAutoEjectConfigUnion FromIMotorAutoEjectNextHookConfig(IMotorAutoEjectNextHookConfigT _imotorautoejectnexthookconfig)
		{
			return new TMotorAutoEjectConfigUnion
			{
				Type = TMotorAutoEjectConfig.IMotorAutoEjectNextHookConfig,
				Value = _imotorautoejectnexthookconfig
			};
		}

		// Token: 0x0602889D RID: 166045 RVA: 0x0059326D File Offset: 0x0059146D
		public IMotorAutoEjectPositionEntityConfigT AsIMotorAutoEjectPositionEntityConfig()
		{
			return this.As<IMotorAutoEjectPositionEntityConfigT>();
		}

		// Token: 0x0602889E RID: 166046 RVA: 0x00593275 File Offset: 0x00591475
		public static TMotorAutoEjectConfigUnion FromIMotorAutoEjectPositionEntityConfig(IMotorAutoEjectPositionEntityConfigT _imotorautoejectpositionentityconfig)
		{
			return new TMotorAutoEjectConfigUnion
			{
				Type = TMotorAutoEjectConfig.IMotorAutoEjectPositionEntityConfig,
				Value = _imotorautoejectpositionentityconfig
			};
		}

		// Token: 0x0602889F RID: 166047 RVA: 0x0059328C File Offset: 0x0059148C
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
