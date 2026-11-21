using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Playback;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.GameMainView.DangoBrawl.Item
{
	// Token: 0x020049EB RID: 18923
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlBattleLogItem : GridProxyAbstract<DangoBrawlBattleLogInfo>
	{
		// Token: 0x0602F6C0 RID: 194240 RVA: 0x00D39CE4 File Offset: 0x00D37EE4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602F6C1 RID: 194241 RVA: 0x00D39DB0 File Offset: 0x00D37FB0
		protected override void OnStart()
		{
			base.OnStart();
			this.DpsTickHandle = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnDpsTick), 100f, 1f, null, null, true);
		}

		// Token: 0x0602F6C2 RID: 194242 RVA: 0x00D39DE1 File Offset: 0x00D37FE1
		protected override void OnBeforeDestroy()
		{
			if (this.DpsTickHandle != null)
			{
				if (TimerSystem.GameplayTimeInstance.Has(this.DpsTickHandle))
				{
					TimerSystem.GameplayTimeInstance.Remove(this.DpsTickHandle);
				}
				this.DpsTickHandle = null;
			}
			base.OnBeforeDestroy();
		}

		// Token: 0x0602F6C3 RID: 194243 RVA: 0x00D39E1C File Offset: 0x00D3801C
		private void OnDpsTick(float delta)
		{
			if (this.CurData == null)
			{
				return;
			}
			if (!base.IsUiActiveInHierarchy())
			{
				return;
			}
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(false);
			DangoBrawlFightingClock dangoBrawlFightingClock = (battleManager != null) ? battleManager.FightingClock : null;
			if (dangoBrawlFightingClock == null)
			{
				return;
			}
			this.SetNumText(this.CurData, dangoBrawlFightingClock.FightingElapsed);
		}

		// Token: 0x0602F6C4 RID: 194244 RVA: 0x00D39E6C File Offset: 0x00D3806C
		private void SetNumText(DangoBrawlBattleLogInfo data, float elapsedMs)
		{
			UUIText text = base.GetText(4);
			if (text == null)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.Value);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x0602F6C5 RID: 194245 RVA: 0x00D39EA8 File Offset: 0x00D380A8
		public override void Refresh(DangoBrawlBattleLogInfo data, bool isSelected, int gridIndex)
		{
			this.CurData = data;
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(false);
			DangoBrawlFightingClock dangoBrawlFightingClock = (battleManager != null) ? battleManager.FightingClock : null;
			this.SetNumText(data, (dangoBrawlFightingClock != null) ? dangoBrawlFightingClock.FightingElapsed : 0f);
			UUISprite sprite = base.GetSprite(2);
			if (sprite != null)
			{
				sprite.SetFillAmount(data.DamagePercent);
			}
			if (sprite != null)
			{
				UUIItem uuiitem = sprite;
				bool isHeal = data.IsHeal;
				FColor? fcolor = new FColor?(sprite.changeColor);
				uuiitem.SetChangeColor(isHeal, fcolor);
			}
			string path = "";
			string textStringId = "";
			bool flag = false;
			string path2 = "";
			switch (data.Source)
			{
			case EDangoBrawlDamageSource.Weapon:
			case EDangoBrawlDamageSource.Heal:
			{
				DangoBrawlItem? itemConfigById = DangoBrawlConfig.Instance.GetItemConfigById(data.ConfigId);
				if (itemConfigById != null)
				{
					path = itemConfigById.Value.IconHandBook;
					textStringId = itemConfigById.Value.Name;
					DangoBrawlItemQuality? itemQualityConfigById = DangoBrawlConfig.Instance.GetItemQualityConfigById(itemConfigById.Value.Quality);
					if (itemQualityConfigById != null)
					{
						flag = true;
						path2 = itemQualityConfigById.Value.HandBookSmallItemIcon;
					}
				}
				break;
			}
			case EDangoBrawlDamageSource.BuffTick:
			case EDangoBrawlDamageSource.BuffWeaponDamage:
			{
				DangoBrawlBuff? buffConfigById = DangoBrawlConfig.Instance.GetBuffConfigById(data.ConfigId);
				if (buffConfigById != null)
				{
					path = buffConfigById.Value.Icon;
					textStringId = buffConfigById.Value.Name;
				}
				break;
			}
			case EDangoBrawlDamageSource.Reflect:
				textStringId = "DangoBrawlBuff_Name_04";
				path = UiResourceConfig.Instance.GetResourcePath("T_BuffIcon_02_a");
				break;
			case EDangoBrawlDamageSource.Lifesteal:
				textStringId = "DangoBrawlBuff_Name_03";
				path = UiResourceConfig.Instance.GetResourcePath("T_BuffIcon_07_a");
				break;
			}
			base.SetTextureByPath(path, base.GetTexture(1), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), textStringId, Array.Empty<object>());
			UUITexture texture = base.GetTexture(0);
			if (texture != null)
			{
				texture.SetUIActive(flag);
			}
			if (flag)
			{
				base.SetTextureByPath(path2, texture, null, null);
			}
		}

		// Token: 0x0401920D RID: 102925
		private const float DPS_TICK_INTERVAL = 100f;

		// Token: 0x0401920E RID: 102926
		[Nullable(2)]
		private DangoBrawlBattleLogInfo CurData;

		// Token: 0x0401920F RID: 102927
		[Nullable(2)]
		private TimerHandle DpsTickHandle;

		// Token: 0x0200A686 RID: 42630
		[NullableContext(0)]
		private enum EComp
		{
			// Token: 0x040337B0 RID: 210864
			TexQuality,
			// Token: 0x040337B1 RID: 210865
			TexIcon,
			// Token: 0x040337B2 RID: 210866
			Bar,
			// Token: 0x040337B3 RID: 210867
			TxtItemName,
			// Token: 0x040337B4 RID: 210868
			TxtNum
		}
	}
}
