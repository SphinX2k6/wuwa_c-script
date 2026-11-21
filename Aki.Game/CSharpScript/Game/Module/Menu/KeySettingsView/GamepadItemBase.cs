using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.KeySettingsView
{
	// Token: 0x02004443 RID: 17475
	[NullableContext(1)]
	[Nullable(0)]
	public class GamepadItemBase : UiPanelBase
	{
		// Token: 0x0602C169 RID: 180585 RVA: 0x00C60CB0 File Offset: 0x00C5EEB0
		protected void AddKeySprite(string keyName, UUISprite keySprite)
		{
			this.KeySpriteMap.Add(keyName, keySprite);
		}

		// Token: 0x0602C16A RID: 180586 RVA: 0x00C60CC0 File Offset: 0x00C5EEC0
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

		// Token: 0x0602C16B RID: 180587 RVA: 0x00C60D54 File Offset: 0x00C5EF54
		public void SetAllKeyDisable()
		{
			foreach (UUISprite uuisprite in this.VisibleKeySpriteMap.Values)
			{
				uuisprite.SetUIActive(false);
			}
		}

		// Token: 0x0602C16C RID: 180588 RVA: 0x00C60DAC File Offset: 0x00C5EFAC
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

		// Token: 0x0602C16D RID: 180589 RVA: 0x00C60DEF File Offset: 0x00C5EFEF
		protected override void OnBeforeDestroy()
		{
			this.KeySpriteMap.Clear();
			this.VisibleKeySpriteMap.Clear();
		}

		// Token: 0x04017C03 RID: 97283
		private readonly Dictionary<string, UUISprite> KeySpriteMap = new Dictionary<string, UUISprite>();

		// Token: 0x04017C04 RID: 97284
		private readonly Dictionary<string, UUISprite> VisibleKeySpriteMap = new Dictionary<string, UUISprite>();
	}
}
