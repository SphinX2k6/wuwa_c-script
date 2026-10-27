using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.BattleUiSet
{
	// Token: 0x02005E5C RID: 24156
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiSetConfig : ConfigBase
	{
		// Token: 0x0603D6A4 RID: 251556 RVA: 0x00ED0828 File Offset: 0x00ECEA28
		[NullableContext(2)]
		public static IReadOnlyList<MobileBattleUiSet> GetMobileBattleUiSetConfigList(int panelIndex)
		{
			return ConfigMobileBattleUiSetByPanelIndex.GetConfigList(panelIndex, true);
		}

		// Token: 0x17008E74 RID: 36468
		// (get) Token: 0x0603D6A5 RID: 251557 RVA: 0x00ED0831 File Offset: 0x00ECEA31
		public static BattleUiSetConfig Instance
		{
			get
			{
				return BattleUiSetConfig._Instance;
			}
		}

		// Token: 0x0603D6A6 RID: 251558 RVA: 0x00ED0838 File Offset: 0x00ECEA38
		public static BattleUiSetConfig GetOrCreateInstance()
		{
			if (BattleUiSetConfig._Instance == null)
			{
				BattleUiSetConfig.CreateInstance();
			}
			return BattleUiSetConfig._Instance;
		}

		// Token: 0x0603D6A7 RID: 251559 RVA: 0x00ED084C File Offset: 0x00ECEA4C
		public static bool CreateInstance()
		{
			if (BattleUiSetConfig._Instance != null)
			{
				return true;
			}
			BattleUiSetConfig._Instance = new BattleUiSetConfig();
			return true;
		}

		// Token: 0x0603D6A8 RID: 251560 RVA: 0x00ED0862 File Offset: 0x00ECEA62
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603D6A9 RID: 251561 RVA: 0x00ED0864 File Offset: 0x00ECEA64
		public static void ResetStaticDefaultValue()
		{
			BattleUiSetConfig._Instance = null;
		}

		// Token: 0x0603D6AA RID: 251562 RVA: 0x00ED086C File Offset: 0x00ECEA6C
		static BattleUiSetConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BattleUiSetConfig.CreateStaticDefaultValue), new Action(BattleUiSetConfig.ResetStaticDefaultValue));
		}

		// Token: 0x040200C6 RID: 131270
		[Nullable(2)]
		private static BattleUiSetConfig _Instance;
	}
}
