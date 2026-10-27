using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D57 RID: 23895
	public class BattleHonamiStoryRoleSuitItem : UiPanelBase
	{
		// Token: 0x0603CAA3 RID: 248483 RVA: 0x00E8FBE8 File Offset: 0x00E8DDE8
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

		// Token: 0x0603CAA4 RID: 248484 RVA: 0x00E8FC30 File Offset: 0x00E8DE30
		protected override void OnBeforeCreateImplement()
		{
			this.LevelPlaySequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.LevelPlaySequence);
		}

		// Token: 0x0603CAA5 RID: 248485 RVA: 0x00E8FC4C File Offset: 0x00E8DE4C
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

		// Token: 0x0603CAA6 RID: 248486 RVA: 0x00E8FCBC File Offset: 0x00E8DEBC
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

		// Token: 0x0401F99B RID: 129435
		[Nullable(2)]
		private UiBehaviorLevelSequence LevelPlaySequence;

		// Token: 0x0200C008 RID: 49160
		private enum EComponentType
		{
			// Token: 0x04039F25 RID: 237349
			Sprite
		}
	}
}
