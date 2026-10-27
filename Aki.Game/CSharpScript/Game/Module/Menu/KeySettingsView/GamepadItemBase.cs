using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.KeySettingsView
{
	// Token: 0x02005460 RID: 21600
	[NullableContext(1)]
	[Nullable(0)]
	public class GamepadItemBase : UiPanelBase
	{
		// Token: 0x06037220 RID: 225824 RVA: 0x00D11898 File Offset: 0x00D0FA98
		protected void AddKeySprite(string keyName, UUISprite keySprite)
		{
			this.KeySpriteMap.Add(keyName, keySprite);
		}

		// Token: 0x06037221 RID: 225825 RVA: 0x00D118A8 File Offset: 0x00D0FAA8
		public void SetKeysEnable(string[] keyNameList)
		{
			foreach (KeyValuePair<string, UUISprite> keyValuePair in this.VisibleKeySpriteMap)
			{
				string key = keyValuePair.Key;
				UUISprite value = keyValuePair.Value;
				if (Array.IndexOf<string>(keyNameList, key) < 0)
				{
					value.SetUIActive(false);
				}
			}
			foreach (string keyName in keyNameList)
			{
				this.SetKeySpriteVisible(keyName, true);
			}
		}

		// Token: 0x06037222 RID: 225826 RVA: 0x00D1193C File Offset: 0x00D0FB3C
		public void SetAllKeyDisable()
		{
			foreach (UUISprite uuisprite in this.VisibleKeySpriteMap.Values)
			{
				uuisprite.SetUIActive(false);
			}
		}

		// Token: 0x06037223 RID: 225827 RVA: 0x00D11994 File Offset: 0x00D0FB94
		public void SetKeySpriteVisible(string keyName, bool bVisible)
		{
			UUISprite uuisprite;
			if (!this.KeySpriteMap.TryGetValue(keyName, out uuisprite))
			{
				return;
			}
			uuisprite.SetUIActive(bVisible);
			if (bVisible)
			{
				this.VisibleKeySpriteMap[keyName] = uuisprite;
				return;
			}
			this.VisibleKeySpriteMap.Remove(keyName);
		}

		// Token: 0x06037224 RID: 225828 RVA: 0x00D119D7 File Offset: 0x00D0FBD7
		protected override void OnBeforeDestroy()
		{
			this.KeySpriteMap.Clear();
			this.VisibleKeySpriteMap.Clear();
		}

		// Token: 0x0401D16A RID: 119146
		private readonly Dictionary<string, UUISprite> KeySpriteMap = new Dictionary<string, UUISprite>();

		// Token: 0x0401D16B RID: 119147
		private readonly Dictionary<string, UUISprite> VisibleKeySpriteMap = new Dictionary<string, UUISprite>();
	}
}
