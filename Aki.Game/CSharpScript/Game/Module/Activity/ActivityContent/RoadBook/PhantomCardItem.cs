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
	// Token: 0x020061DD RID: 25053
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomCardItem : GridProxyAbstract<int>
	{
		// Token: 0x0603F412 RID: 259090 RVA: 0x00F48BDA File Offset: 0x00F46DDA
		public PhantomCardItem(ActivityRoadBookData activityBaseData)
		{
			this.ActivityBaseData = activityBaseData;
		}

		// Token: 0x0603F413 RID: 259091 RVA: 0x00F48BEC File Offset: 0x00F46DEC
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

		// Token: 0x0603F414 RID: 259092 RVA: 0x00F48D1C File Offset: 0x00F46F1C
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

		// Token: 0x0603F415 RID: 259093 RVA: 0x00F48E7C File Offset: 0x00F4707C
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

		// Token: 0x0603F416 RID: 259094 RVA: 0x00F49015 File Offset: 0x00F47215
		private void TryUnlockItem()
		{
		}

		// Token: 0x0603F417 RID: 259095 RVA: 0x00F49018 File Offset: 0x00F47218
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

		// Token: 0x04020FB2 RID: 135090
		protected int PhantomId;

		// Token: 0x04020FB3 RID: 135091
		private double LastClickTimestamp;

		// Token: 0x04020FB4 RID: 135092
		protected ActivityRoadBookData ActivityBaseData;
	}
}
