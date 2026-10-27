using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CC1 RID: 23745
	public class TTeleCtrlTriggerConfigUnion
	{
		// Token: 0x1700B25E RID: 45662
		// (get) Token: 0x06028A51 RID: 166481 RVA: 0x00595B08 File Offset: 0x00593D08
		// (set) Token: 0x06028A52 RID: 166482 RVA: 0x00595B10 File Offset: 0x00593D10
		public TTeleCtrlTriggerConfig Type { get; set; }

		// Token: 0x1700B25F RID: 45663
		// (get) Token: 0x06028A53 RID: 166483 RVA: 0x00595B19 File Offset: 0x00593D19
		// (set) Token: 0x06028A54 RID: 166484 RVA: 0x00595B21 File Offset: 0x00593D21
		public object Value { get; set; }

		// Token: 0x06028A55 RID: 166485 RVA: 0x00595B2A File Offset: 0x00593D2A
		public TTeleCtrlTriggerConfigUnion()
		{
			this.Type = TTeleCtrlTriggerConfig.NONE;
			this.Value = null;
		}

		// Token: 0x06028A56 RID: 166486 RVA: 0x00595B40 File Offset: 0x00593D40
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028A57 RID: 166487 RVA: 0x00595B52 File Offset: 0x00593D52
		public IMechascoutExplosiveBarrelTriggerConfigT AsIMechascoutExplosiveBarrelTriggerConfig()
		{
			return this.As<IMechascoutExplosiveBarrelTriggerConfigT>();
		}

		// Token: 0x06028A58 RID: 166488 RVA: 0x00595B5A File Offset: 0x00593D5A
		public static TTeleCtrlTriggerConfigUnion FromIMechascoutExplosiveBarrelTriggerConfig(IMechascoutExplosiveBarrelTriggerConfigT _imechascoutexplosivebarreltriggerconfig)
		{
			return new TTeleCtrlTriggerConfigUnion
			{
				Type = TTeleCtrlTriggerConfig.IMechascoutExplosiveBarrelTriggerConfig,
				Value = _imechascoutexplosivebarreltriggerconfig
			};
		}

		// Token: 0x06028A59 RID: 166489 RVA: 0x00595B6F File Offset: 0x00593D6F
		public IMechascoutJavelinTriggerConfigT AsIMechascoutJavelinTriggerConfig()
		{
			return this.As<IMechascoutJavelinTriggerConfigT>();
		}

		// Token: 0x06028A5A RID: 166490 RVA: 0x00595B77 File Offset: 0x00593D77
		public static TTeleCtrlTriggerConfigUnion FromIMechascoutJavelinTriggerConfig(IMechascoutJavelinTriggerConfigT _imechascoutjavelintriggerconfig)
		{
			return new TTeleCtrlTriggerConfigUnion
			{
				Type = TTeleCtrlTriggerConfig.IMechascoutJavelinTriggerConfig,
				Value = _imechascoutjavelintriggerconfig
			};
		}

		// Token: 0x06028A5B RID: 166491 RVA: 0x00595B8C File Offset: 0x00593D8C
		public static int Pack(FlatBufferBuilder builder, TTeleCtrlTriggerConfigUnion _o)
		{
			TTeleCtrlTriggerConfig type = _o.Type;
			if (type == TTeleCtrlTriggerConfig.IMechascoutExplosiveBarrelTriggerConfig)
			{
				return IMechascoutExplosiveBarrelTriggerConfig.Pack(builder, _o.AsIMechascoutExplosiveBarrelTriggerConfig()).Value;
			}
			if (type != TTeleCtrlTriggerConfig.IMechascoutJavelinTriggerConfig)
			{
				return 0;
			}
			return IMechascoutJavelinTriggerConfig.Pack(builder, _o.AsIMechascoutJavelinTriggerConfig()).Value;
		}
	}
}
