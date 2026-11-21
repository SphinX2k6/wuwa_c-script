using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.BossPiling.View.Item
{
	// Token: 0x02004BFC RID: 19452
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class BossPilingBossTabItem : GridProxyAbstract<BossPilingLevelInfo>
	{
		// Token: 0x06030896 RID: 198806 RVA: 0x00D85F14 File Offset: 0x00D84114
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06030897 RID: 198807 RVA: 0x00D860AC File Offset: 0x00D842AC
		protected override void OnStart()
		{
			base.GetExtendToggle(0).OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChange));
			base.GetExtendToggle(0).OnUndeterminedClicked.Add(new Action(this.OnUndeterminedClickToggle));
			this.Layout = new GenericLayout<BossPilingBossAchievementStar, bool>(base.GetHorizontalLayout(2), new Func<BossPilingBossAchievementStar>(this.CreateStar), null, false, true);
		}

		// Token: 0x06030898 RID: 198808 RVA: 0x00D86114 File Offset: 0x00D84314
		protected override void OnBeforeDestroy()
		{
			base.GetExtendToggle(0).OnStateChange.Remove(new Action<EToggleState>(this.OnToggleStateChange));
			base.GetExtendToggle(0).OnUndeterminedClicked.Remove(new Action(this.OnUndeterminedClickToggle));
		}

		// Token: 0x06030899 RID: 198809 RVA: 0x00D86150 File Offset: 0x00D84350
		public override void Refresh(BossPilingLevelInfo data, bool isSelected, int gridIndex)
		{
			this.CurrentData = data;
			this.UpdateInfo(false);
		}

		// Token: 0x0603089A RID: 198810 RVA: 0x00D86160 File Offset: 0x00D84360
		public bool OnTick()
		{
			if (this.CurrentData == null)
			{
				return false;
			}
			if (this.CurrentData.IsUnlock)
			{
				return false;
			}
			if (this.CheckIsUnlock())
			{
				this.UpdateInfo(true);
				return false;
			}
			this.RefreshRemainTime();
			return true;
		}

		// Token: 0x0603089B RID: 198811 RVA: 0x00D86194 File Offset: 0x00D84394
		protected void UpdateInfo(bool isUnlock = false)
		{
			bool flag = this.CurrentData.Id != this.CurrentId;
			this.CurrentId = this.CurrentData.Id;
			BossPilingLevels value = BossPilingConfig.Instance.GetLevelInfo(this.CurrentId).Value;
			bool flag2 = this.CheckIsUnlock();
			UUIItem item = base.GetItem(9);
			if (item != null)
			{
				item.SetUIActive(!flag2);
			}
			UUIItem item2 = base.GetItem(8);
			if (item2 != null)
			{
				item2.SetUIActive(flag2);
			}
			UUISprite sprite = base.GetSprite(7);
			if (sprite != null)
			{
				sprite.SetUIActive(flag2);
			}
			if (flag2)
			{
				UUIText text = base.GetText(1);
				if (text != null)
				{
					text.ShowTextNew(value.LevelName);
				}
				BossPilingActivityData activityData = BossPilingModel.Instance.GetActivityData();
				List<int> starAchievement = activityData.GetStarAchievement(this.CurrentId);
				if (flag || isUnlock)
				{
					List<bool> list = new List<bool>();
					for (int i = 0; i < starAchievement[1]; i++)
					{
						list.Add(i < starAchievement[0]);
					}
					this.Layout.RefreshByData(list, null, true);
				}
				bool flag3 = this.IsSelectOnCb != null && this.IsSelectOnCb(this.CurrentId);
				if (flag3)
				{
					activityData.ClearLevelRedDotById(this.CurrentData.Id);
				}
				UUIItem item3 = base.GetItem(6);
				if (item3 != null)
				{
					item3.SetUIActive(activityData.CheckLevelRedDotById(this.CurrentData.Id));
				}
				this.SetSelected(flag3, false);
				base.SetTextureByPath(value.ToggleUnlock, base.GetTexture(5), null, null);
				string valueOrDefault = BossPilingDefine.BossPilingScoreTexMap.GetValueOrDefault(starAchievement[0]);
				UUISprite sprite2 = base.GetSprite(4);
				if (sprite2 != null)
				{
					sprite2.SetUIActive(valueOrDefault != null);
				}
				if (valueOrDefault != null)
				{
					string resourcePath = UiResourceConfig.Instance.GetResourcePath(valueOrDefault);
					this.SetSpriteByPath(resourcePath, base.GetSprite(4), false, null, null);
				}
				return;
			}
			this.RefreshRemainTime();
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnDetermined, false, false, false);
			base.SetTextureByPath(value.ToggleLock, base.GetTexture(5), null, null);
			UUIItem item4 = base.GetItem(6);
			if (item4 == null)
			{
				return;
			}
			item4.SetUIActive(false);
		}

		// Token: 0x0603089C RID: 198812 RVA: 0x00D863C0 File Offset: 0x00D845C0
		protected void RefreshRemainTime()
		{
			string configTextByKey = PublicUtil.Instance.GetConfigTextByKey("BossPilingActivity_Main03");
			string remainTimeText = ActivityModel.Instance.GetRemainTimeText((long)this.CurrentData.UnlockTime, configTextByKey);
			UUIText text = base.GetText(10);
			if (text == null)
			{
				return;
			}
			text.SetText(remainTimeText, true);
		}

		// Token: 0x0603089D RID: 198813 RVA: 0x00D86409 File Offset: 0x00D84609
		private void SetSelected(bool bSelectOn, bool bFireEvent = false)
		{
			base.GetExtendToggle(0).SetToggleState(bSelectOn ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, bFireEvent, false, false);
		}

		// Token: 0x0603089E RID: 198814 RVA: 0x00D86422 File Offset: 0x00D84622
		private bool CheckIsUnlock()
		{
			if (this.CurrentData.IsUnlock)
			{
				return true;
			}
			bool flag = (double)this.CurrentData.UnlockTime <= TimeUtil.Instance.GetServerTime();
			if (flag)
			{
				this.CurrentData.IsUnlock = true;
			}
			return flag;
		}

		// Token: 0x0603089F RID: 198815 RVA: 0x00D8645D File Offset: 0x00D8465D
		private BossPilingBossAchievementStar CreateStar()
		{
			return new BossPilingBossAchievementStar();
		}

		// Token: 0x060308A0 RID: 198816 RVA: 0x00D86464 File Offset: 0x00D84664
		private void OnToggleStateChange(EToggleState state)
		{
			if (this.OnToggleStateChangeFunction != null)
			{
				UUIItem item = base.GetItem(6);
				if (item != null)
				{
					item.SetUIActive(false);
				}
				this.OnToggleStateChangeFunction(this.CurrentId);
			}
		}

		// Token: 0x060308A1 RID: 198817 RVA: 0x00D86494 File Offset: 0x00D84694
		private void OnUndeterminedClickToggle()
		{
			if (!this.CheckIsUnlock())
			{
				string configTextByKey = PublicUtil.Instance.GetConfigTextByKey("BossPilingActivity_Main03");
				string remainTimeText = ActivityModel.Instance.GetRemainTimeText((long)this.CurrentData.UnlockTime, configTextByKey);
				ScrollingTipsController.Instance.ShowTipsByText(remainTimeText);
			}
		}

		// Token: 0x04019B09 RID: 105225
		protected int CurrentId;

		// Token: 0x04019B0A RID: 105226
		protected BossPilingLevelInfo CurrentData;

		// Token: 0x04019B0B RID: 105227
		[Nullable(2)]
		public Func<int, bool> IsSelectOnCb;

		// Token: 0x04019B0C RID: 105228
		[Nullable(2)]
		public Action<int> OnToggleStateChangeFunction;

		// Token: 0x04019B0D RID: 105229
		protected GenericLayout<BossPilingBossAchievementStar, bool> Layout;

		// Token: 0x0200A810 RID: 43024
		[NullableContext(0)]
		private enum EDefine
		{
			// Token: 0x04033E91 RID: 212625
			ToggleSelf,
			// Token: 0x04033E92 RID: 212626
			BossName,
			// Token: 0x04033E93 RID: 212627
			PanelStar,
			// Token: 0x04033E94 RID: 212628
			StarItem,
			// Token: 0x04033E95 RID: 212629
			SpriteScoreIcon,
			// Token: 0x04033E96 RID: 212630
			TexBoss,
			// Token: 0x04033E97 RID: 212631
			RedDot,
			// Token: 0x04033E98 RID: 212632
			SpriteToggleBg,
			// Token: 0x04033E99 RID: 212633
			PanelContent,
			// Token: 0x04033E9A RID: 212634
			PanelBossNone,
			// Token: 0x04033E9B RID: 212635
			TxtTime
		}
	}
}
