using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.HonamiStory;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D59 RID: 23897
	public class HonamiStoryMonsterLevelItem : StateExtraItemBase
	{
		// Token: 0x0603CAAE RID: 248494 RVA: 0x00E8FF58 File Offset: 0x00E8E158
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

		// Token: 0x0603CAAF RID: 248495 RVA: 0x00E90064 File Offset: 0x00E8E264
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

		// Token: 0x0603CAB0 RID: 248496 RVA: 0x00E9010F File Offset: 0x00E8E30F
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnHonamiStoryPowerLevelUpdate, new Action<int, int>(this.OnRefreshPlayerLevel));
			EventSystem.Instance.Remove(EEventName.OnHonamiStoryPollutionUpdate, new Action<int>(this.OnRefreshPollutionLevel));
		}

		// Token: 0x0603CAB1 RID: 248497 RVA: 0x00E9014C File Offset: 0x00E8E34C
		private void OnRefreshPollutionLevel(int monsterEnhanceLevel)
		{
			int newLevel = this.OriginLevel + monsterEnhanceLevel + HonamiStoryModel.Instance.MonsterBaseEnhanceLevel;
			this.RefreshLevel(newLevel, this.PlayerLevel, false);
		}

		// Token: 0x0603CAB2 RID: 248498 RVA: 0x00E9017B File Offset: 0x00E8E37B
		private void OnRefreshPlayerLevel(int oldValue, int newValue)
		{
			this.RefreshLevel(this.CurrentLevel, newValue, false);
		}

		// Token: 0x0603CAB3 RID: 248499 RVA: 0x00E9018C File Offset: 0x00E8E38C
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

		// Token: 0x0603CAB4 RID: 248500 RVA: 0x00E901EC File Offset: 0x00E8E3EC
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

		// Token: 0x0603CAB5 RID: 248501 RVA: 0x00E90268 File Offset: 0x00E8E468
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

		// Token: 0x0401F99C RID: 129436
		private int OriginLevel;

		// Token: 0x0401F99D RID: 129437
		private int PlayerLevel;

		// Token: 0x0401F99E RID: 129438
		private int CurrentLevel;

		// Token: 0x0401F99F RID: 129439
		private HonamiStoryMonsterLevelItem.ELevelStateType CurrentState;

		// Token: 0x0200C00A RID: 49162
		private enum ELevelStateType
		{
			// Token: 0x04039F31 RID: 237361
			Safe,
			// Token: 0x04039F32 RID: 237362
			Normal,
			// Token: 0x04039F33 RID: 237363
			Danger
		}

		// Token: 0x0200C00B RID: 49163
		private enum EComponentType
		{
			// Token: 0x04039F35 RID: 237365
			LevelText,
			// Token: 0x04039F36 RID: 237366
			LevelBgSprite,
			// Token: 0x04039F37 RID: 237367
			LevelIconSprite,
			// Token: 0x04039F38 RID: 237368
			LevelCircleSprite
		}
	}
}
