using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x020051FD RID: 20989
	public class RealmBetweenPhantomCardItem : GridProxyAbstract<int>, IStaticVariableResetter
	{
		// Token: 0x0603444A RID: 214090 RVA: 0x00E9F142 File Offset: 0x00E9D342
		static RealmBetweenPhantomCardItem()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RealmBetweenPhantomCardItem.CreateStaticDefaultValue), new Action(RealmBetweenPhantomCardItem.ResetStaticDefaultValue));
		}

		// Token: 0x0603444B RID: 214091 RVA: 0x00E9F161 File Offset: 0x00E9D361
		public static void CreateStaticDefaultValue()
		{
			RealmBetweenPhantomCardItem.LastClickTimestamp = 0.0;
		}

		// Token: 0x0603444C RID: 214092 RVA: 0x00E9F171 File Offset: 0x00E9D371
		public static void ResetStaticDefaultValue()
		{
			RealmBetweenPhantomCardItem.LastClickTimestamp = 0.0;
		}

		// Token: 0x0603444D RID: 214093 RVA: 0x00E9F181 File Offset: 0x00E9D381
		[NullableContext(1)]
		public RealmBetweenPhantomCardItem(ActivityRealmBetweenData activityData)
		{
			this.ActivityData = activityData;
		}

		// Token: 0x0603444E RID: 214094 RVA: 0x00E9F190 File Offset: 0x00E9D390
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
				new ValueTuple<int, Type>(6, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClickItem))
			};
		}

		// Token: 0x0603444F RID: 214095 RVA: 0x00E9F268 File Offset: 0x00E9D468
		public override void Refresh(int phantomId, bool isSelected, int gridIndex)
		{
			this.PhantomId = phantomId;
			RealmBetweenPhantomGain value = ActivityRealmBetweenConfig.Instance.GetPhantomConfig(this.PhantomId).Value;
			bool flag;
			this.ActivityData.PhantomDataMap.TryGetValue(phantomId, out flag);
			IReadOnlyList<Aki.Config.PhantomItem> phantomItemConfigListByMonsterId = InventoryConfig.Instance.GetPhantomItemConfigListByMonsterId(phantomId);
			Aki.Config.PhantomItem? phantomItem = (phantomItemConfigListByMonsterId != null) ? new Aki.Config.PhantomItem?(phantomItemConfigListByMonsterId[0]) : null;
			if (phantomItem != null)
			{
				PhantomSkill? phantomSkillBySkillId = PhantomBattleConfig.Instance.GetPhantomSkillBySkillId(phantomItem.Value.SkillId);
				base.SetTextureByPath(((phantomSkillBySkillId != null) ? phantomSkillBySkillId.GetValueOrDefault().BattleViewIcon : null) ?? string.Empty, base.GetTexture(5), null, null);
				this.RefreshTexture(phantomItem.Value.Rarity);
			}
			base.GetItem(1).SetUIActive(!flag);
			base.GetItem(2).SetUIActive(flag);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), value.Name, Array.Empty<object>());
			UUIText text = base.GetText(6);
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

		// Token: 0x06034450 RID: 214096 RVA: 0x00E9F3C8 File Offset: 0x00E9D5C8
		private void RefreshTexture(int rarity)
		{
			string resourceId;
			if (!ActivityRealmBetweenDefine.RealmBetweenMonsterTexture.TryGetValue(rarity, out resourceId))
			{
				return;
			}
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			if (string.IsNullOrEmpty(resourcePath))
			{
				return;
			}
			base.SetTextureByPath(resourcePath, base.GetTexture(3), null, null);
		}

		// Token: 0x06034451 RID: 214097 RVA: 0x00E9F412 File Offset: 0x00E9D612
		private void TryUnlockItem()
		{
		}

		// Token: 0x06034452 RID: 214098 RVA: 0x00E9F414 File Offset: 0x00E9D614
		private void OnClickItem()
		{
			double systemNow = Time.Instance.SystemNow;
			if (systemNow - RealmBetweenPhantomCardItem.LastClickTimestamp < 3000.0)
			{
				return;
			}
			RealmBetweenPhantomCardItem.LastClickTimestamp = systemNow;
			RealmBetweenPhantomGain? phantomConfig = ActivityRealmBetweenConfig.Instance.GetPhantomConfig(this.PhantomId);
			if (phantomConfig == null)
			{
				return;
			}
			if (GameModeController.Instance.IsInInstance())
			{
				GenericPromptController.Instance.ShowPromptByCode("DungeonDetection", Array.Empty<object>());
				return;
			}
			AdventureGuideModel.Instance.SetFromManualDetect(true);
			AdventureGuideController.Instance.RequestForDetection(DetectionType.NormalMonster, Array.Empty<int>(), phantomConfig.Value.MonsterInfoId);
		}

		// Token: 0x0401BBE5 RID: 113637
		private const int CLICK_COOLDOWN_MS = 3000;

		// Token: 0x0401BBE6 RID: 113638
		protected int PhantomId;

		// Token: 0x0401BBE7 RID: 113639
		private static double LastClickTimestamp;

		// Token: 0x0401BBE8 RID: 113640
		[Nullable(1)]
		protected ActivityRealmBetweenData ActivityData;
	}
}
