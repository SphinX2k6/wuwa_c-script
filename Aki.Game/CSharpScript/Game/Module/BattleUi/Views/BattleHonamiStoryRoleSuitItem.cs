using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D39 RID: 19769
	public class BattleHonamiStoryRoleSuitItem : UiPanelBase
	{
		// Token: 0x060319FC RID: 203260 RVA: 0x00DE039C File Offset: 0x00DDE59C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060319FD RID: 203261 RVA: 0x00DE03E4 File Offset: 0x00DDE5E4
		protected override void OnBeforeCreateImplement()
		{
			this.LevelPlaySequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.LevelPlaySequence);
		}

		// Token: 0x060319FE RID: 203262 RVA: 0x00DE0400 File Offset: 0x00DDE600
		[NullableContext(2)]
		public void Refresh(HonamiStoryWeaponSuitActiveData suitData, int suitPluginType)
		{
			HonamiStoryPluginSubType value = HonamiStoryConfig.Instance.GetPluginSubType(suitPluginType).Value;
			string path = value.ActiveSpritePath;
			if (suitData != null)
			{
				int num = suitData.CurCount - suitData.NeedCount;
				if (num >= 0)
				{
					path = value.ActiveAllSpritePath;
				}
				else if (num == -1)
				{
					path = value.ActiveOneSpritePath;
				}
			}
			this.SetSpriteByPath(path, base.GetSprite(0), true, null, null);
		}

		// Token: 0x060319FF RID: 203263 RVA: 0x00DE0470 File Offset: 0x00DDE670
		public void PlayBurst()
		{
			UiBehaviorLevelSequence levelPlaySequence = this.LevelPlaySequence;
			if (levelPlaySequence != null)
			{
				levelPlaySequence.StopPrevSequence(false, true);
			}
			UiBehaviorLevelSequence levelPlaySequence2 = this.LevelPlaySequence;
			if (levelPlaySequence2 == null)
			{
				return;
			}
			levelPlaySequence2.PlaySequence("Burst", false, null);
		}

		// Token: 0x0401A454 RID: 107604
		[Nullable(2)]
		private UiBehaviorLevelSequence LevelPlaySequence;

		// Token: 0x0200AA0E RID: 43534
		private enum EComponentType
		{
			// Token: 0x040348E7 RID: 215271
			Sprite
		}
	}
}
