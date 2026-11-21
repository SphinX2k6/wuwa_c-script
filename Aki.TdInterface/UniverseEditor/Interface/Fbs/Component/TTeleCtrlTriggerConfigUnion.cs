using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062F2 RID: 25330
	public class TTeleCtrlTriggerConfigUnion
	{
		// Token: 0x1700BBB8 RID: 48056
		// (get) Token: 0x0602B099 RID: 176281 RVA: 0x005DE27C File Offset: 0x005DC47C
		// (set) Token: 0x0602B09A RID: 176282 RVA: 0x005DE284 File Offset: 0x005DC484
		public TTeleCtrlTriggerConfig Type { get; set; }

		// Token: 0x1700BBB9 RID: 48057
		// (get) Token: 0x0602B09B RID: 176283 RVA: 0x005DE28D File Offset: 0x005DC48D
		// (set) Token: 0x0602B09C RID: 176284 RVA: 0x005DE295 File Offset: 0x005DC495
		public object Value { get; set; }

		// Token: 0x0602B09D RID: 176285 RVA: 0x005DE29E File Offset: 0x005DC49E
		public TTeleCtrlTriggerConfigUnion()
		{
			this.Type = TTeleCtrlTriggerConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0602B09E RID: 176286 RVA: 0x005DE2B4 File Offset: 0x005DC4B4
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B09F RID: 176287 RVA: 0x005DE2C6 File Offset: 0x005DC4C6
		public IMechascoutExplosiveBarrelTriggerConfigT AsIMechascoutExplosiveBarrelTriggerConfig()
		{
			return this.As<IMechascoutExplosiveBarrelTriggerConfigT>();
		}

		// Token: 0x0602B0A0 RID: 176288 RVA: 0x005DE2CE File Offset: 0x005DC4CE
		public static TTeleCtrlTriggerConfigUnion FromIMechascoutExplosiveBarrelTriggerConfig(IMechascoutExplosiveBarrelTriggerConfigT _imechascoutexplosivebarreltriggerconfig)
		{
			return new TTeleCtrlTriggerConfigUnion
			{
				Type = TTeleCtrlTriggerConfig.IMechascoutExplosiveBarrelTriggerConfig,
				Value = _imechascoutexplosivebarreltriggerconfig
			};
		}

		// Token: 0x0602B0A1 RID: 176289 RVA: 0x005DE2E3 File Offset: 0x005DC4E3
		public IMechascoutJavelinTriggerConfigT AsIMechascoutJavelinTriggerConfig()
		{
			return this.As<IMechascoutJavelinTriggerConfigT>();
		}

		// Token: 0x0602B0A2 RID: 176290 RVA: 0x005DE2EB File Offset: 0x005DC4EB
		public static TTeleCtrlTriggerConfigUnion FromIMechascoutJavelinTriggerConfig(IMechascoutJavelinTriggerConfigT _imechascoutjavelintriggerconfig)
		{
			return new TTeleCtrlTriggerConfigUnion
			{
				Type = TTeleCtrlTriggerConfig.IMechascoutJavelinTriggerConfig,
				Value = _imechascoutjavelintriggerconfig
			};
		}

		// Token: 0x0602B0A3 RID: 176291 RVA: 0x005DE300 File Offset: 0x005DC500
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
