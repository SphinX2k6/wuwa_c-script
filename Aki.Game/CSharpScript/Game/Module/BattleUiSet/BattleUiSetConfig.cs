using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.BattleUiSet
{
	// Token: 0x02004E41 RID: 20033
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiSetConfig : ConfigBase
	{
		// Token: 0x06032634 RID: 206388 RVA: 0x00E21D98 File Offset: 0x00E1FF98
		[NullableContext(2)]
		public static IReadOnlyList<MobileBattleUiSet> GetMobileBattleUiSetConfigList(int panelIndex)
		{
			return ConfigMobileBattleUiSetByPanelIndex.GetConfigList(panelIndex, true);
		}

		// Token: 0x17006246 RID: 25158
		// (get) Token: 0x06032635 RID: 206389 RVA: 0x00E21DA1 File Offset: 0x00E1FFA1
		public static BattleUiSetConfig Instance
		{
			get
			{
				return BattleUiSetConfig._Instance;
			}
		}

		// Token: 0x06032636 RID: 206390 RVA: 0x00E21DA8 File Offset: 0x00E1FFA8
		public static BattleUiSetConfig GetOrCreateInstance()
		{
			if (BattleUiSetConfig._Instance == null)
			{
				BattleUiSetConfig.CreateInstance();
			}
			return BattleUiSetConfig._Instance;
		}

		// Token: 0x06032637 RID: 206391 RVA: 0x00E21DBC File Offset: 0x00E1FFBC
		public static bool CreateInstance()
		{
			if (BattleUiSetConfig._Instance != null)
			{
				return true;
			}
			BattleUiSetConfig._Instance = new BattleUiSetConfig();
			return true;
		}

		// Token: 0x06032638 RID: 206392 RVA: 0x00E21DD2 File Offset: 0x00E1FFD2
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06032639 RID: 206393 RVA: 0x00E21DD4 File Offset: 0x00E1FFD4
		public static void ResetStaticDefaultValue()
		{
			BattleUiSetConfig._Instance = null;
		}

		// Token: 0x0603263A RID: 206394 RVA: 0x00E21DDC File Offset: 0x00E1FFDC
		static BattleUiSetConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BattleUiSetConfig.CreateStaticDefaultValue), new Action(BattleUiSetConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401AB8D RID: 109453
		[Nullable(2)]
		private static BattleUiSetConfig _Instance;
	}
}
