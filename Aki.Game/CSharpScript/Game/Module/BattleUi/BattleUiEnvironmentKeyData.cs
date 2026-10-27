using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02005C86 RID: 23686
	public class BattleUiEnvironmentKeyData
	{
		// Token: 0x0603BD56 RID: 245078 RVA: 0x00E4A7AB File Offset: 0x00E489AB
		public EEnvironmentKey GetCurEnvironmentalKey()
		{
			return this.EnvironmentKey;
		}

		// Token: 0x0603BD57 RID: 245079 RVA: 0x00E4A7B3 File Offset: 0x00E489B3
		[NullableContext(2)]
		public string GetCurKeyText()
		{
			return BattleUiEnvironmentKeyData.KeyTexts[(int)this.EnvironmentKey];
		}

		// Token: 0x0603BD58 RID: 245080 RVA: 0x00E4A7C8 File Offset: 0x00E489C8
		public void Init()
		{
			this.EnvironmentKey = EEnvironmentKey.None;
			this.KeyVisibleList.Clear();
			this.KeyVisibleList.Add(true);
			for (int i = 1; i < 10; i++)
			{
				this.KeyVisibleList.Add(false);
			}
		}

		// Token: 0x0603BD59 RID: 245081 RVA: 0x00E4A80C File Offset: 0x00E48A0C
		public void SetEnvironmentKeyVisible(EEnvironmentKey key, bool visible)
		{
			if (this.KeyVisibleList[(int)key] == visible)
			{
				return;
			}
			this.KeyVisibleList[(int)key] = visible;
			if (visible)
			{
				if (this.EnvironmentKey < key)
				{
					this.EnvironmentKey = key;
					this.DispatchKeyChangedEvent();
				}
				return;
			}
			if (this.EnvironmentKey > key)
			{
				return;
			}
			for (int i = key - EEnvironmentKey.SilentArea; i >= 0; i--)
			{
				if (this.KeyVisibleList[i])
				{
					this.EnvironmentKey = (EEnvironmentKey)i;
					this.DispatchKeyChangedEvent();
					return;
				}
			}
		}

		// Token: 0x0603BD5A RID: 245082 RVA: 0x00E4A884 File Offset: 0x00E48A84
		private void DispatchKeyChangedEvent()
		{
			EventSystem.Instance.Emit(EEventName.BattleUiEnvironmentKeyChanged);
		}

		// Token: 0x0603BD5B RID: 245083 RVA: 0x00E4A898 File Offset: 0x00E48A98
		public void OnLeaveLevel()
		{
			this.EnvironmentKey = EEnvironmentKey.None;
			for (int i = 1; i < 10; i++)
			{
				this.KeyVisibleList[i] = false;
			}
		}

		// Token: 0x0603BD5C RID: 245084 RVA: 0x00E4A8C6 File Offset: 0x00E48AC6
		public void Clear()
		{
		}

		// Token: 0x0401F30E RID: 127758
		private EEnvironmentKey EnvironmentKey;

		// Token: 0x0401F30F RID: 127759
		[Nullable(new byte[]
		{
			1,
			2
		})]
		[StaticVariableRuleIgnore]
		private static readonly IReadOnlyList<string> KeyTexts = new <>z__ReadOnlyArray<string>(new string[]
		{
			null,
			"HotKeyText_SilentAreaTips_Name",
			"HotKeyText_EnvironmentBuffTips_Name",
			"HotKeyText_SilentAreaTips_Name",
			"HotKeyText_RogueInfoTips_Name",
			"HotKeyText_VisionLevelTips_Name",
			"HotKeyText_TowerTokenTips_Name",
			"HotKeyText_RogueInfoTips_Name",
			"HotKeyText_MoraleTokenTips_Name",
			"HotKeyText_MoraleAreaSum_Name"
		});

		// Token: 0x0401F310 RID: 127760
		[Nullable(1)]
		private readonly List<bool> KeyVisibleList = new List<bool>();
	}
}
