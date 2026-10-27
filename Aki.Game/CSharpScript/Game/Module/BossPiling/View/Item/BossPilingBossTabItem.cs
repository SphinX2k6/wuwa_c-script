using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.BossPiling.View.Item
{
	// Token: 0x02005C1C RID: 23580
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class BossPilingBossTabItem : GridProxyAbstract<BossPilingLevelInfo>
	{
		// Token: 0x0603B94B RID: 244043 RVA: 0x00E35BB8 File Offset: 0x00E33DB8
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

		// Token: 0x0603B94C RID: 244044 RVA: 0x00E35D50 File Offset: 0x00E33F50
		protected override void OnStart()
		{
			base.GetExtendToggle(0).OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChange));
			base.GetExtendToggle(0).OnUndeterminedClicked.Add(new Action(this.OnUndeterminedClickToggle));
			this.Layout = new GenericLayout<BossPilingBossAchievementStar, bool>(base.GetHorizontalLayout(2), new Func<BossPilingBossAchievementStar>(this.CreateStar), null, false, true);
		}

		// Token: 0x0603B94D RID: 244045 RVA: 0x00E35DB8 File Offset: 0x00E33FB8
		protected override void OnBeforeDestroy()
		{
			base.GetExtendToggle(0).OnStateChange.Remove(new Action<EToggleState>(this.OnToggleStateChange));
			base.GetExtendToggle(0).OnUndeterminedClicked.Remove(new Action(this.OnUndeterminedClickToggle));
		}

		// Token: 0x0603B94E RID: 244046 RVA: 0x00E35DF4 File Offset: 0x00E33FF4
		public override void Refresh(BossPilingLevelInfo data, bool isSelected, int gridIndex)
		{
			this.CurrentData = data;
			this.UpdateInfo(false);
		}

		// Token: 0x0603B94F RID: 244047 RVA: 0x00E35E04 File Offset: 0x00E34004
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

		// Token: 0x0603B950 RID: 244048 RVA: 0x00E35E38 File Offset: 0x00E34038
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

		// Token: 0x0603B951 RID: 244049 RVA: 0x00E36064 File Offset: 0x00E34264
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

		// Token: 0x0603B952 RID: 244050 RVA: 0x00E360AD File Offset: 0x00E342AD
		private void SetSelected(bool bSelectOn, bool bFireEvent = false)
		{
			base.GetExtendToggle(0).SetToggleState(bSelectOn ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, bFireEvent, false, false);
		}

		// Token: 0x0603B953 RID: 244051 RVA: 0x00E360C6 File Offset: 0x00E342C6
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

		// Token: 0x0603B954 RID: 244052 RVA: 0x00E36101 File Offset: 0x00E34301
		private BossPilingBossAchievementStar CreateStar()
		{
			return new BossPilingBossAchievementStar();
		}

		// Token: 0x0603B955 RID: 244053 RVA: 0x00E36108 File Offset: 0x00E34308
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

		// Token: 0x0603B956 RID: 244054 RVA: 0x00E36138 File Offset: 0x00E34338
		private void OnUndeterminedClickToggle()
		{
			if (!this.CheckIsUnlock())
			{
				string configTextByKey = PublicUtil.Instance.GetConfigTextByKey("BossPilingActivity_Main03");
				string remainTimeText = ActivityModel.Instance.GetRemainTimeText((long)this.CurrentData.UnlockTime, configTextByKey);
				ScrollingTipsController.Instance.ShowTipsByText(remainTimeText);
			}
		}

		// Token: 0x0401F058 RID: 127064
		protected int CurrentId;

		// Token: 0x0401F059 RID: 127065
		protected BossPilingLevelInfo CurrentData;

		// Token: 0x0401F05A RID: 127066
		[Nullable(2)]
		public Func<int, bool> IsSelectOnCb;

		// Token: 0x0401F05B RID: 127067
		[Nullable(2)]
		public Action<int> OnToggleStateChangeFunction;

		// Token: 0x0401F05C RID: 127068
		protected GenericLayout<BossPilingBossAchievementStar, bool> Layout;

		// Token: 0x0200BE08 RID: 48648
		[NullableContext(0)]
		private enum EDefine
		{
			// Token: 0x040394CE RID: 234702
			ToggleSelf,
			// Token: 0x040394CF RID: 234703
			BossName,
			// Token: 0x040394D0 RID: 234704
			PanelStar,
			// Token: 0x040394D1 RID: 234705
			StarItem,
			// Token: 0x040394D2 RID: 234706
			SpriteScoreIcon,
			// Token: 0x040394D3 RID: 234707
			TexBoss,
			// Token: 0x040394D4 RID: 234708
			RedDot,
			// Token: 0x040394D5 RID: 234709
			SpriteToggleBg,
			// Token: 0x040394D6 RID: 234710
			PanelContent,
			// Token: 0x040394D7 RID: 234711
			PanelBossNone,
			// Token: 0x040394D8 RID: 234712
			TxtTime
		}
	}
}
