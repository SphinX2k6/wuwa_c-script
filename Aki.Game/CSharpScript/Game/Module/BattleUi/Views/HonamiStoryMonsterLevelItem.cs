using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.HonamiStory;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D3B RID: 19771
	public class HonamiStoryMonsterLevelItem : StateExtraItemBase
	{
		// Token: 0x06031A07 RID: 203271 RVA: 0x00DE070C File Offset: 0x00DDE90C
		[NullableContext(1)]
		protected override void OnInitExtraParams(ExtraItemParams param)
		{
			int honamiStoryLevel = ((HonamiStoryLevelItemParams)param).HonamiStoryLevel;
			int powerLevel = HonamiStoryModel.Instance.PlayerData.PowerLevel;
			this.OriginLevel = honamiStoryLevel;
			int pollutionLevel = HonamiStoryModel.Instance.PollutionLevel;
			Dictionary<int, IHonamiStoryPollution> pollutionLevelMap = HonamiStoryModel.Instance.PollutionLevelMap;
			int? num;
			if (pollutionLevelMap == null)
			{
				num = null;
			}
			else
			{
				IHonamiStoryPollution valueOrDefault = pollutionLevelMap.GetValueOrDefault(pollutionLevel);
				num = ((valueOrDefault != null) ? new int?(valueOrDefault.MonsterEnhanceLevel) : null);
			}
			int? num2 = num;
			int valueOrDefault2 = num2.GetValueOrDefault();
			int newLevel = honamiStoryLevel + valueOrDefault2 + HonamiStoryModel.Instance.MonsterBaseEnhanceLevel;
			this.RefreshLevel(newLevel, powerLevel, true);
			if (!EventSystem.Instance.Has(EEventName.OnHonamiStoryPowerLevelUpdate, new Action<int, int>(this.OnRefreshPlayerLevel)))
			{
				EventSystem.Instance.Add(EEventName.OnHonamiStoryPowerLevelUpdate, new Action<int, int>(this.OnRefreshPlayerLevel));
			}
			if (!EventSystem.Instance.Has(EEventName.OnHonamiStoryPollutionUpdate, new Action<int>(this.OnRefreshPollutionLevel)))
			{
				EventSystem.Instance.Add<int>(EEventName.OnHonamiStoryPollutionUpdate, new Action<int>(this.OnRefreshPollutionLevel));
			}
		}

		// Token: 0x06031A08 RID: 203272 RVA: 0x00DE0818 File Offset: 0x00DDEA18
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031A09 RID: 203273 RVA: 0x00DE08C3 File Offset: 0x00DDEAC3
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnHonamiStoryPowerLevelUpdate, new Action<int, int>(this.OnRefreshPlayerLevel));
			EventSystem.Instance.Remove(EEventName.OnHonamiStoryPollutionUpdate, new Action<int>(this.OnRefreshPollutionLevel));
		}

		// Token: 0x06031A0A RID: 203274 RVA: 0x00DE0900 File Offset: 0x00DDEB00
		private void OnRefreshPollutionLevel(int monsterEnhanceLevel)
		{
			int newLevel = this.OriginLevel + monsterEnhanceLevel + HonamiStoryModel.Instance.MonsterBaseEnhanceLevel;
			this.RefreshLevel(newLevel, this.PlayerLevel, false);
		}

		// Token: 0x06031A0B RID: 203275 RVA: 0x00DE092F File Offset: 0x00DDEB2F
		private void OnRefreshPlayerLevel(int oldValue, int newValue)
		{
			this.RefreshLevel(this.CurrentLevel, newValue, false);
		}

		// Token: 0x06031A0C RID: 203276 RVA: 0x00DE0940 File Offset: 0x00DDEB40
		private void RefreshLevel(int newLevel, int playerLevel, bool isInit = false)
		{
			this.PlayerLevel = playerLevel;
			HonamiStoryMonsterLevelItem.ELevelStateType levelState = this.GetLevelState(newLevel, playerLevel);
			if (isInit || this.CurrentState != levelState)
			{
				this.RefreshLevelState(levelState);
				this.CurrentState = levelState;
			}
			if (isInit || this.CurrentLevel != newLevel)
			{
				base.GetText(0).SetText(newLevel.ToString(), true);
				this.CurrentLevel = newLevel;
			}
		}

		// Token: 0x06031A0D RID: 203277 RVA: 0x00DE09A0 File Offset: 0x00DDEBA0
		private void RefreshLevelState(HonamiStoryMonsterLevelItem.ELevelStateType state)
		{
			string hexStr = "#a5f3cbff";
			string hexStr2 = "#a5f3cb99";
			if (state == HonamiStoryMonsterLevelItem.ELevelStateType.Normal)
			{
				hexStr = "#f8dc97ff";
				hexStr2 = "#fae8bd99";
			}
			else if (state == HonamiStoryMonsterLevelItem.ELevelStateType.Danger)
			{
				hexStr = "#f47d89ff";
				hexStr2 = "#90586099";
			}
			base.GetText(0).SetColor(FColor.FromHex(hexStr));
			FColor color = FColor.FromHex(hexStr2);
			base.GetSprite(1).SetColor(color);
			base.GetSprite(2).SetColor(color);
			base.GetSprite(3).SetColor(color);
		}

		// Token: 0x06031A0E RID: 203278 RVA: 0x00DE0A1C File Offset: 0x00DDEC1C
		private HonamiStoryMonsterLevelItem.ELevelStateType GetLevelState(int newLevel, int playerLevel)
		{
			int num = playerLevel - newLevel;
			if (num > HonamiStoryModel.Instance.MonsterLevelSafeOffset)
			{
				return HonamiStoryMonsterLevelItem.ELevelStateType.Safe;
			}
			if (num < HonamiStoryModel.Instance.MonsterLevelDangerOffset)
			{
				return HonamiStoryMonsterLevelItem.ELevelStateType.Danger;
			}
			return HonamiStoryMonsterLevelItem.ELevelStateType.Normal;
		}

		// Token: 0x0401A455 RID: 107605
		private int OriginLevel;

		// Token: 0x0401A456 RID: 107606
		private int PlayerLevel;

		// Token: 0x0401A457 RID: 107607
		private int CurrentLevel;

		// Token: 0x0401A458 RID: 107608
		private HonamiStoryMonsterLevelItem.ELevelStateType CurrentState;

		// Token: 0x0200AA10 RID: 43536
		private enum ELevelStateType
		{
			// Token: 0x040348F3 RID: 215283
			Safe,
			// Token: 0x040348F4 RID: 215284
			Normal,
			// Token: 0x040348F5 RID: 215285
			Danger
		}

		// Token: 0x0200AA11 RID: 43537
		private enum EComponentType
		{
			// Token: 0x040348F7 RID: 215287
			LevelText,
			// Token: 0x040348F8 RID: 215288
			LevelBgSprite,
			// Token: 0x040348F9 RID: 215289
			LevelIconSprite,
			// Token: 0x040348FA RID: 215290
			LevelCircleSprite
		}
	}
}
