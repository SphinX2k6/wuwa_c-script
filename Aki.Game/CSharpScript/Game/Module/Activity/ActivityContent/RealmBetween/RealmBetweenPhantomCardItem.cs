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
	// Token: 0x0200627F RID: 25215
	public class RealmBetweenPhantomCardItem : GridProxyAbstract<int>, IStaticVariableResetter
	{
		// Token: 0x0603F789 RID: 259977 RVA: 0x00F581E6 File Offset: 0x00F563E6
		static RealmBetweenPhantomCardItem()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RealmBetweenPhantomCardItem.CreateStaticDefaultValue), new Action(RealmBetweenPhantomCardItem.ResetStaticDefaultValue));
		}

		// Token: 0x0603F78A RID: 259978 RVA: 0x00F58205 File Offset: 0x00F56405
		public static void CreateStaticDefaultValue()
		{
			RealmBetweenPhantomCardItem.LastClickTimestamp = 0.0;
		}

		// Token: 0x0603F78B RID: 259979 RVA: 0x00F58215 File Offset: 0x00F56415
		public static void ResetStaticDefaultValue()
		{
			RealmBetweenPhantomCardItem.LastClickTimestamp = 0.0;
		}

		// Token: 0x0603F78C RID: 259980 RVA: 0x00F58225 File Offset: 0x00F56425
		[NullableContext(1)]
		public RealmBetweenPhantomCardItem(ActivityRealmBetweenData activityData)
		{
			this.ActivityData = activityData;
		}

		// Token: 0x0603F78D RID: 259981 RVA: 0x00F58234 File Offset: 0x00F56434
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

		// Token: 0x0603F78E RID: 259982 RVA: 0x00F5830C File Offset: 0x00F5650C
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

		// Token: 0x0603F78F RID: 259983 RVA: 0x00F5846C File Offset: 0x00F5666C
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

		// Token: 0x0603F790 RID: 259984 RVA: 0x00F584B6 File Offset: 0x00F566B6
		private void TryUnlockItem()
		{
		}

		// Token: 0x0603F791 RID: 259985 RVA: 0x00F584B8 File Offset: 0x00F566B8
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

		// Token: 0x040212B6 RID: 135862
		private const int CLICK_COOLDOWN_MS = 3000;

		// Token: 0x040212B7 RID: 135863
		protected int PhantomId;

		// Token: 0x040212B8 RID: 135864
		private static double LastClickTimestamp;

		// Token: 0x040212B9 RID: 135865
		[Nullable(1)]
		protected ActivityRealmBetweenData ActivityData;
	}
}
