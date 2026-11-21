using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02004C67 RID: 19559
	public class BattleUiEnvironmentKeyData
	{
		// Token: 0x06030CA4 RID: 199844 RVA: 0x00D9AD27 File Offset: 0x00D98F27
		public EEnvironmentKey GetCurEnvironmentalKey()
		{
			return this.EnvironmentKey;
		}

		// Token: 0x06030CA5 RID: 199845 RVA: 0x00D9AD2F File Offset: 0x00D98F2F
		[NullableContext(2)]
		public string GetCurKeyText()
		{
			return BattleUiEnvironmentKeyData.KeyTexts[(int)this.EnvironmentKey];
		}

		// Token: 0x06030CA6 RID: 199846 RVA: 0x00D9AD44 File Offset: 0x00D98F44
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

		// Token: 0x06030CA7 RID: 199847 RVA: 0x00D9AD88 File Offset: 0x00D98F88
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

		// Token: 0x06030CA8 RID: 199848 RVA: 0x00D9AE00 File Offset: 0x00D99000
		private void DispatchKeyChangedEvent()
		{
			EventSystem.Instance.Emit(EEventName.BattleUiEnvironmentKeyChanged);
		}

		// Token: 0x06030CA9 RID: 199849 RVA: 0x00D9AE14 File Offset: 0x00D99014
		public void OnLeaveLevel()
		{
			this.EnvironmentKey = EEnvironmentKey.None;
			for (int i = 1; i < 10; i++)
			{
				this.KeyVisibleList[i] = false;
			}
		}

		// Token: 0x06030CAA RID: 199850 RVA: 0x00D9AE42 File Offset: 0x00D99042
		public void Clear()
		{
		}

		// Token: 0x04019DC4 RID: 105924
		private EEnvironmentKey EnvironmentKey;

		// Token: 0x04019DC5 RID: 105925
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

		// Token: 0x04019DC6 RID: 105926
		[Nullable(1)]
		private readonly List<bool> KeyVisibleList = new List<bool>();
	}
}
