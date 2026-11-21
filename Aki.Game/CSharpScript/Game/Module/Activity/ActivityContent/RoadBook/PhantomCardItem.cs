using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x0200515B RID: 20827
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomCardItem : GridProxyAbstract<int>
	{
		// Token: 0x060340D3 RID: 213203 RVA: 0x00E8FB32 File Offset: 0x00E8DD32
		public PhantomCardItem(ActivityRoadBookData activityBaseData)
		{
			this.ActivityBaseData = activityBaseData;
		}

		// Token: 0x060340D4 RID: 213204 RVA: 0x00E8FB44 File Offset: 0x00E8DD44
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUITexture)),
				new ValueTuple<int, Type>(4, typeof(UUITexture)),
				new ValueTuple<int, Type>(5, typeof(UUITexture)),
				new ValueTuple<int, Type>(6, typeof(UUITexture)),
				new ValueTuple<int, Type>(7, typeof(UUITexture)),
				new ValueTuple<int, Type>(8, typeof(UUITexture)),
				new ValueTuple<int, Type>(9, typeof(UUIText)),
				new ValueTuple<int, Type>(10, typeof(UUISprite))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClickItem))
			};
		}

		// Token: 0x060340D5 RID: 213205 RVA: 0x00E8FC74 File Offset: 0x00E8DE74
		public override void Refresh(int phantomId, bool isSelected, int gridIndex)
		{
			this.PhantomId = phantomId;
			RoadBookPhantomGain value = ActivityRoadBookConfig.Instance.GetPhantomConfig(this.PhantomId).Value;
			bool flag;
			this.ActivityBaseData.PhantomDataMap.TryGetValue(phantomId, out flag);
			IReadOnlyList<Aki.Config.PhantomItem> phantomItemConfigListByMonsterId = InventoryConfig.Instance.GetPhantomItemConfigListByMonsterId(phantomId);
			Aki.Config.PhantomItem? phantomItem = (phantomItemConfigListByMonsterId != null) ? new Aki.Config.PhantomItem?(phantomItemConfigListByMonsterId[0]) : null;
			if (phantomItem != null)
			{
				PhantomSkill? phantomSkillBySkillId = PhantomBattleConfig.Instance.GetPhantomSkillBySkillId(phantomItem.Value.SkillId);
				base.SetTextureByPath(((phantomSkillBySkillId != null) ? phantomSkillBySkillId.GetValueOrDefault().BattleViewIcon : null) ?? string.Empty, base.GetTexture(8), null, null);
				this.RefreshTexture(phantomItem.Value.Rarity);
			}
			base.GetItem(1).SetUIActive(!flag);
			base.GetItem(2).SetUIActive(flag);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(9), value.Name, Array.Empty<object>());
			UUIText text = base.GetText(9);
			if (text != null)
			{
				text.SetColor(FColor.FromHex(flag ? "#2B2D2E" : "#515155"));
			}
			base.SetTextureShowUntilLoaded(value.TexPhantom, base.GetTexture(4), null);
			if (flag)
			{
				this.TryUnlockItem();
			}
		}

		// Token: 0x060340D6 RID: 213206 RVA: 0x00E8FDD4 File Offset: 0x00E8DFD4
		private void RefreshTexture(int rarity)
		{
			int cost = PhantomBattleConfig.Instance.GetPhantomRareConfig(rarity).Value.Cost;
			int num = 0;
			switch (cost)
			{
			case 1:
				num = 0;
				break;
			case 3:
				num = 1;
				break;
			case 4:
				num = 2;
				break;
			}
			UiResourceConfig instance = UiResourceConfig.Instance;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 1);
			defaultInterpolatedStringHandler.AppendLiteral("T_TheMeMapChipBg");
			defaultInterpolatedStringHandler.AppendFormatted<int>((num < 2) ? 1 : 2);
			string resourcePath = instance.GetResourcePath(defaultInterpolatedStringHandler.ToStringAndClear());
			base.SetTextureByPath(resourcePath, base.GetTexture(3), null, null);
			UiResourceConfig instance2 = UiResourceConfig.Instance;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
			defaultInterpolatedStringHandler.AppendLiteral("T_TheMeMapChipTop");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			base.SetTextureByPath(instance2.GetResourcePath(defaultInterpolatedStringHandler.ToStringAndClear()), base.GetTexture(5), null, null);
			UiResourceConfig instance3 = UiResourceConfig.Instance;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 1);
			defaultInterpolatedStringHandler.AppendLiteral("T_TheMeMapDisk");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			base.SetTextureByPath(instance3.GetResourcePath(defaultInterpolatedStringHandler.ToStringAndClear()), base.GetTexture(6), null, null);
			UiResourceConfig instance4 = UiResourceConfig.Instance;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
			defaultInterpolatedStringHandler.AppendLiteral("T_TheMeMapCalipers");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			base.SetTextureByPath(instance4.GetResourcePath(defaultInterpolatedStringHandler.ToStringAndClear()), base.GetTexture(7), null, null);
			string hexStr;
			ActivityRoadBookDefine.RoadBookPhantomColorText.TryGetValue(num + 1, out hexStr);
			base.GetSprite(10).SetColor(FColor.FromHex(hexStr));
		}

		// Token: 0x060340D7 RID: 213207 RVA: 0x00E8FF6D File Offset: 0x00E8E16D
		private void TryUnlockItem()
		{
		}

		// Token: 0x060340D8 RID: 213208 RVA: 0x00E8FF70 File Offset: 0x00E8E170
		private void OnClickItem()
		{
			double systemNow = Time.Instance.SystemNow;
			if (systemNow - this.LastClickTimestamp < 3000.0)
			{
				return;
			}
			this.LastClickTimestamp = systemNow;
			RoadBookPhantomGain value = ActivityRoadBookConfig.Instance.GetPhantomConfig(this.PhantomId).Value;
			if (GameModeController.Instance.IsInInstance())
			{
				GenericPromptController.Instance.ShowPromptByCode("DungeonDetection", Array.Empty<object>());
				return;
			}
			AdventureGuideModel.Instance.SetFromManualDetect(true);
			AdventureGuideController.Instance.RequestForDetection(DetectionType.NormalMonster, Array.Empty<int>(), value.MonsterInfoId);
		}

		// Token: 0x0401B8E1 RID: 112865
		protected int PhantomId;

		// Token: 0x0401B8E2 RID: 112866
		private double LastClickTimestamp;

		// Token: 0x0401B8E3 RID: 112867
		protected ActivityRoadBookData ActivityBaseData;
	}
}
