using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001CD1 RID: 7377
[NullableContext(2)]
[Nullable(0)]
public class RoleTowerSettleRightPanel : UiPanelBase
{
	// Token: 0x06012440 RID: 74816 RVA: 0x00562618 File Offset: 0x00560818
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUITexture)),
			new ValueTuple<int, Type>(8, typeof(UUITexture)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnClickLook))
		};
	}

	// Token: 0x06012441 RID: 74817 RVA: 0x0056278C File Offset: 0x0056098C
	protected override void OnStart()
	{
		this.BuffList = new GenericScrollViewNew<RoleTowerSettleTokenItem, RoleTowerBuffDetailItemData>(base.GetScrollViewWithScrollbar(1), delegate()
		{
			RoleTowerSettleTokenItem roleTowerSettleTokenItem = new RoleTowerSettleTokenItem();
			roleTowerSettleTokenItem.SetClickCallback(new Action<int>(this.OnClickBuffItem));
			return roleTowerSettleTokenItem;
		}, null, false, null);
		this.UpgradeList = new GenericScrollViewNew<RoleTowerSettleUpgradeItem, RoleTowerFeatureData>(base.GetScrollViewWithScrollbar(10), () => new RoleTowerSettleUpgradeItem(), null, false, null);
		this.EchoExpSetter = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.SetEchoExpFill));
	}

	// Token: 0x06012442 RID: 74818 RVA: 0x00562806 File Offset: 0x00560A06
	protected override void OnBeforeDestroy()
	{
		this.KillEchoExpTweener();
		this.PendingEchoExpAnim = null;
		DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.SetEchoExpFill));
		this.EchoExpSetter = null;
	}

	// Token: 0x06012443 RID: 74819 RVA: 0x0056282D File Offset: 0x00560A2D
	public void Refresh(bool playEchoAnim = true)
	{
		this.RefreshBuffs();
		this.RefreshEcho(playEchoAnim);
	}

	// Token: 0x06012444 RID: 74820 RVA: 0x0056283C File Offset: 0x00560A3C
	private void RefreshBuffs()
	{
		IReadOnlyList<RoleTowerTokenCount> lastSettleGainTokens = RoleTowerModel.Instance.GetLastSettleGainTokens();
		bool flag = lastSettleGainTokens.Count > 0;
		UUIItem item = base.GetItem(0);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		if (!flag)
		{
			GenericScrollViewNew<RoleTowerSettleTokenItem, RoleTowerBuffDetailItemData> buffList = this.BuffList;
			if (buffList == null)
			{
				return;
			}
			buffList.RefreshByData(new List<RoleTowerBuffDetailItemData>(), null, false);
			return;
		}
		else
		{
			List<RoleTowerBuffDetailItemData> list = new List<RoleTowerBuffDetailItemData>();
			foreach (RoleTowerTokenCount roleTowerTokenCount in lastSettleGainTokens)
			{
				list.Add(new RoleTowerBuffDetailItemData
				{
					TokenId = roleTowerTokenCount.TokenId,
					Count = roleTowerTokenCount.Count
				});
			}
			GenericScrollViewNew<RoleTowerSettleTokenItem, RoleTowerBuffDetailItemData> buffList2 = this.BuffList;
			if (buffList2 == null)
			{
				return;
			}
			buffList2.RefreshByData(list, null, false);
			return;
		}
	}

	// Token: 0x06012445 RID: 74821 RVA: 0x00562900 File Offset: 0x00560B00
	private void OnClickBuffItem(int tokenId)
	{
		RoleTowerModel.Instance.OpenBuffDetailView(tokenId);
	}

	// Token: 0x06012446 RID: 74822 RVA: 0x00562910 File Offset: 0x00560B10
	private void RefreshEcho(bool playEchoAnim)
	{
		int curEchoLevel = RoleTowerModel.Instance.GetCurEchoLevel();
		int curEchoExp = RoleTowerModel.Instance.GetCurEchoExp();
		int lastSettleEchoOldLevel = RoleTowerModel.Instance.GetLastSettleEchoOldLevel();
		int lastSettleEchoOldExp = RoleTowerModel.Instance.GetLastSettleEchoOldExp();
		bool flag = curEchoLevel > lastSettleEchoOldLevel;
		bool flag2 = curEchoLevel >= RoleTowerModel.Instance.GetMaxEchoLevelIndex();
		UUIItem item = base.GetItem(12);
		if (item != null)
		{
			item.SetUIActive(flag && !flag2);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(13), flag ? "RoleTowerSettleEchoUpgradeDes" : "RoleTowerSettleEchoNoUpgradeDes", new <>z__ReadOnlyArray<object>(new object[]
		{
			lastSettleEchoOldLevel,
			curEchoLevel
		}));
		if (flag)
		{
			UUIText text = base.GetText(4);
			if (text != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Lv ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(lastSettleEchoOldLevel);
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			UUIText text2 = base.GetText(5);
			if (text2 != null)
			{
				text2.SetUIActive(true);
			}
			UUIText text3 = base.GetText(5);
			if (text3 != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Lv ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(curEchoLevel);
				text3.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
		}
		else
		{
			UUIText text4 = base.GetText(4);
			if (text4 != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Lv ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(curEchoLevel);
				text4.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			UUIText text5 = base.GetText(5);
			if (text5 != null)
			{
				text5.SetUIActive(false);
			}
		}
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		RoleTowerFeatureData roleTowerFeatureData = null;
		foreach (RoleTowerEchoLevel roleTowerEchoLevel in RoleTowerModel.Instance.GetEchoLevelCfgList())
		{
			dictionary[roleTowerEchoLevel.LevelIndex] = roleTowerEchoLevel.Exp;
			if (roleTowerEchoLevel.LevelIndex == curEchoLevel)
			{
				roleTowerFeatureData = new RoleTowerFeatureData
				{
					Desc = roleTowerEchoLevel.Desc,
					DescParams = roleTowerEchoLevel.DescParam()
				};
			}
		}
		int num2;
		int num = dictionary.TryGetValue(curEchoLevel, out num2) ? num2 : 0;
		int value = RoleTowerSettleRightPanel.ComputeAddExp(dictionary, lastSettleEchoOldLevel, lastSettleEchoOldExp, curEchoLevel, curEchoExp);
		UUIText text6 = base.GetText(9);
		if (text6 != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendLiteral("+");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			text6.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		bool flag3 = lastSettleEchoOldLevel >= RoleTowerModel.Instance.GetMaxEchoLevelIndex();
		int num4;
		int num3 = dictionary.TryGetValue(lastSettleEchoOldLevel, out num4) ? num4 : 0;
		this.KillEchoExpTweener();
		this.PendingEchoExpAnim = null;
		if (flag2 && flag3)
		{
			UUIText text7 = base.GetText(6);
			if (text7 != null)
			{
				text7.SetText("-/-", true);
			}
			UUITexture texture = base.GetTexture(7);
			if (texture != null)
			{
				texture.SetFillAmount(0f);
			}
			UUITexture texture2 = base.GetTexture(8);
			if (texture2 != null)
			{
				texture2.SetUIActive(true);
			}
			UUITexture texture3 = base.GetTexture(8);
			if (texture3 != null)
			{
				texture3.SetFillAmount(1f);
			}
		}
		else if (flag2)
		{
			UUIText text8 = base.GetText(6);
			if (text8 != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(value);
				defaultInterpolatedStringHandler.AppendLiteral("/-");
				text8.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			float oldFill = (num3 > 0) ? Math.Clamp((float)lastSettleEchoOldExp / (float)num3, 0f, 1f) : 0f;
			UUITexture texture4 = base.GetTexture(8);
			if (texture4 != null)
			{
				texture4.SetUIActive(true);
			}
			UUITexture texture5 = base.GetTexture(8);
			if (texture5 != null)
			{
				texture5.SetFillAmount(oldFill);
			}
			if (playEchoAnim)
			{
				this.SetEchoExpFill(oldFill);
				this.PendingEchoExpAnim = delegate()
				{
					this.PlayEchoExpTween(oldFill, 1f, null);
				};
			}
			else
			{
				this.SetEchoExpFill(1f);
			}
		}
		else
		{
			UUIText text9 = base.GetText(6);
			if (text9 != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(curEchoExp);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(num);
				text9.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			this.RefreshEchoExpBar(flag, curEchoExp, lastSettleEchoOldExp, num, num3, playEchoAnim);
		}
		List<RoleTowerFeatureData> list = new List<RoleTowerFeatureData>();
		if (flag && roleTowerFeatureData != null && !string.IsNullOrEmpty(roleTowerFeatureData.Desc))
		{
			list.Add(roleTowerFeatureData);
		}
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(10);
		if (scrollViewWithScrollbar != null)
		{
			UUIItem uuiitem = scrollViewWithScrollbar.RootUIComp.Get();
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(list.Count > 0);
			}
		}
		GenericScrollViewNew<RoleTowerSettleUpgradeItem, RoleTowerFeatureData> upgradeList = this.UpgradeList;
		if (upgradeList == null)
		{
			return;
		}
		upgradeList.RefreshByData(list, null, false);
	}

	// Token: 0x06012447 RID: 74823 RVA: 0x00562DA0 File Offset: 0x00560FA0
	private void RefreshEchoExpBar(bool hasUpgrade, int curExp, int oldExp, int needExp, int oldNeed, bool playEchoAnim)
	{
		float curFill = (needExp > 0) ? Math.Clamp((float)curExp / (float)needExp, 0f, 1f) : 0f;
		if (!hasUpgrade)
		{
			float oldFill = (needExp > 0) ? Math.Clamp((float)oldExp / (float)needExp, 0f, 1f) : 0f;
			UUITexture texture = base.GetTexture(8);
			if (texture != null)
			{
				texture.SetUIActive(true);
			}
			UUITexture texture2 = base.GetTexture(8);
			if (texture2 != null)
			{
				texture2.SetFillAmount(oldFill);
			}
			if (!playEchoAnim)
			{
				this.SetEchoExpFill(curFill);
				return;
			}
			this.SetEchoExpFill(oldFill);
			this.PendingEchoExpAnim = delegate()
			{
				this.PlayEchoExpTween(oldFill, curFill, null);
			};
			return;
		}
		else
		{
			if (!playEchoAnim)
			{
				UUITexture texture3 = base.GetTexture(8);
				if (texture3 != null)
				{
					texture3.SetUIActive(false);
				}
				this.SetEchoExpFill(curFill);
				return;
			}
			float oldLevelFill = (oldNeed > 0) ? Math.Clamp((float)oldExp / (float)oldNeed, 0f, 1f) : 0f;
			UUITexture texture4 = base.GetTexture(8);
			if (texture4 != null)
			{
				texture4.SetUIActive(true);
			}
			UUITexture texture5 = base.GetTexture(8);
			if (texture5 != null)
			{
				texture5.SetFillAmount(oldLevelFill);
			}
			this.SetEchoExpFill(oldLevelFill);
			Action <>9__2;
			this.PendingEchoExpAnim = delegate()
			{
				RoleTowerSettleRightPanel <>4__this = this;
				float oldLevelFill = oldLevelFill;
				float end = 1f;
				Action onComplete;
				if ((onComplete = <>9__2) == null)
				{
					onComplete = (<>9__2 = delegate()
					{
						UUITexture texture6 = this.GetTexture(8);
						if (texture6 != null)
						{
							texture6.SetUIActive(false);
						}
						this.PlayEchoExpTween(0f, curFill, null);
					});
				}
				<>4__this.PlayEchoExpTween(oldLevelFill, end, onComplete);
			};
			return;
		}
	}

	// Token: 0x06012448 RID: 74824 RVA: 0x00562F0F File Offset: 0x0056110F
	public void PlayEchoExpAnim()
	{
		Action pendingEchoExpAnim = this.PendingEchoExpAnim;
		this.PendingEchoExpAnim = null;
		if (pendingEchoExpAnim == null)
		{
			return;
		}
		pendingEchoExpAnim();
	}

	// Token: 0x06012449 RID: 74825 RVA: 0x00562F28 File Offset: 0x00561128
	private void PlayEchoExpTween(float start, float end, Action onComplete)
	{
		this.KillEchoExpTweener();
		this.SetEchoExpFill(start);
		this.EchoExpTweener = ULTweenBPLibrary.FloatTo(GlobalData.World, this.EchoExpSetter, start, end, 0.5f, 0f, LTweenEase.Linear);
		this.EchoExpTweener.OnCompleteCallBack.Bind(delegate()
		{
			this.EchoExpTweener = null;
			Action onComplete2 = onComplete;
			if (onComplete2 == null)
			{
				return;
			}
			onComplete2();
		});
	}

	// Token: 0x0601244A RID: 74826 RVA: 0x00562F95 File Offset: 0x00561195
	private void SetEchoExpFill(float value)
	{
		UUITexture texture = base.GetTexture(7);
		if (texture == null)
		{
			return;
		}
		texture.SetFillAmount(value);
	}

	// Token: 0x0601244B RID: 74827 RVA: 0x00562FA9 File Offset: 0x005611A9
	private void KillEchoExpTweener()
	{
		if (this.EchoExpTweener != null)
		{
			this.EchoExpTweener.Kill(false);
			this.EchoExpTweener = null;
		}
	}

	// Token: 0x0601244C RID: 74828 RVA: 0x00562FC8 File Offset: 0x005611C8
	[NullableContext(1)]
	private static int ComputeAddExp(Dictionary<int, int> levelExp, int oldLevel, int oldExp, int curLevel, int curExp)
	{
		if (curLevel <= oldLevel)
		{
			return Math.Max(0, curExp - oldExp);
		}
		int num = 0;
		int num2;
		if (levelExp.TryGetValue(oldLevel, out num2))
		{
			num += Math.Max(0, num2 - oldExp);
		}
		for (int i = oldLevel + 1; i < curLevel; i++)
		{
			int num3;
			if (levelExp.TryGetValue(i, out num3))
			{
				num += num3;
			}
		}
		return num + curExp;
	}

	// Token: 0x0601244D RID: 74829 RVA: 0x00563020 File Offset: 0x00561220
	private void OnClickLook()
	{
		RoleTowerModel.Instance.OpenStarEchoView(ERoleTowerStarEchoTab.Echo, false);
	}

	// Token: 0x04009F7E RID: 40830
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<RoleTowerSettleTokenItem, RoleTowerBuffDetailItemData> BuffList;

	// Token: 0x04009F7F RID: 40831
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<RoleTowerSettleUpgradeItem, RoleTowerFeatureData> UpgradeList;

	// Token: 0x04009F80 RID: 40832
	private const float ECHO_EXP_TWEEN_TIME = 0.5f;

	// Token: 0x04009F81 RID: 40833
	private ULTweener EchoExpTweener;

	// Token: 0x04009F82 RID: 40834
	private FLTweenFloatSetterDynamic EchoExpSetter;

	// Token: 0x04009F83 RID: 40835
	private Action PendingEchoExpAnim;

	// Token: 0x02007FC3 RID: 32707
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402954F RID: 169295
		public const int PnlBuffOffset = 0;

		// Token: 0x04029550 RID: 169296
		public const int BuffItemScroll = 1;

		// Token: 0x04029551 RID: 169297
		public const int UiItemItemBaseA = 2;

		// Token: 0x04029552 RID: 169298
		public const int BtnLook = 3;

		// Token: 0x04029553 RID: 169299
		public const int TxtCurrLevel = 4;

		// Token: 0x04029554 RID: 169300
		public const int TxtNextLevel = 5;

		// Token: 0x04029555 RID: 169301
		public const int TxtAllExp = 6;

		// Token: 0x04029556 RID: 169302
		public const int TexFillY = 7;

		// Token: 0x04029557 RID: 169303
		public const int TexFillW = 8;

		// Token: 0x04029558 RID: 169304
		public const int TxtAddExp = 9;

		// Token: 0x04029559 RID: 169305
		public const int UpgradeDescScroll = 10;

		// Token: 0x0402955A RID: 169306
		public const int UiItemNewLevelBuffDesc = 11;

		// Token: 0x0402955B RID: 169307
		public const int ArrowItem = 12;

		// Token: 0x0402955C RID: 169308
		public const int TxtEchoTip = 13;
	}
}
