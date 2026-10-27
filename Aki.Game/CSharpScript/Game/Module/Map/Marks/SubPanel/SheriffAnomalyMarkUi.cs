using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Sheriff;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.SubPanel
{
	// Token: 0x020054D6 RID: 21718
	public class SheriffAnomalyMarkUi : UiPanelBase
	{
		// Token: 0x06037729 RID: 227113 RVA: 0x00D2BB78 File Offset: 0x00D29D78
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603772A RID: 227114 RVA: 0x00D2BCA7 File Offset: 0x00D29EA7
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new UiSequencePlayer(this.RootItem);
			UUIText text = base.GetText(7);
			if (text == null)
			{
				return;
			}
			text.SetText("?", true);
		}

		// Token: 0x0603772B RID: 227115 RVA: 0x00D2BCD1 File Offset: 0x00D29ED1
		protected override void OnAfterShow()
		{
		}

		// Token: 0x0603772C RID: 227116 RVA: 0x00D2BCD4 File Offset: 0x00D29ED4
		public void SetData(int markId)
		{
			SheriffAnomaly? anomalyConfigByMarkId = SheriffConfig.Instance.GetAnomalyConfigByMarkId(markId);
			SheriffAnomalyInfo anomalyInfo = SheriffModel.Instance.GetAnomalyInfo(anomalyConfigByMarkId.Value.Id);
			int currentProgress = (anomalyInfo != null) ? anomalyInfo.Progress : 0;
			ESheriffAnomalyState currentState = (anomalyInfo != null) ? anomalyInfo.State : ESheriffAnomalyState.Lock;
			this.MarkId = markId;
			this.CurrentProgress = currentProgress;
			this.CurrentState = currentState;
			this.RefreshUi();
		}

		// Token: 0x0603772D RID: 227117 RVA: 0x00D2BD3C File Offset: 0x00D29F3C
		private void RefreshUi()
		{
			SheriffAnomaly? anomalyConfigByMarkId = SheriffConfig.Instance.GetAnomalyConfigByMarkId(this.MarkId);
			if (anomalyConfigByMarkId == null)
			{
				return;
			}
			bool flag = this.CurrentState == ESheriffAnomalyState.Completed;
			bool flag2 = SheriffModel.Instance.GetCriminalInfo(anomalyConfigByMarkId.Value.CriminalId).State >= ESheriffCriminalState.Confirmed;
			this.RefreshCriminal(flag2, anomalyConfigByMarkId.Value);
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(!flag2);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 != null)
			{
				item2.SetUIActive(flag);
			}
			this.RefreshName(flag, anomalyConfigByMarkId.Value);
			this.RefreshProgress(flag, anomalyConfigByMarkId.Value);
			this.RefreshBg(flag);
		}

		// Token: 0x0603772E RID: 227118 RVA: 0x00D2BDF0 File Offset: 0x00D29FF0
		private void RefreshCriminal(bool isKnown, SheriffAnomaly config)
		{
			if (isKnown)
			{
				base.TrySetSpriteByPath(this.GetMarkIcon(config), base.GetSprite(1), false, null, null);
				return;
			}
			UUISprite sprite = base.GetSprite(1);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(false);
		}

		// Token: 0x0603772F RID: 227119 RVA: 0x00D2BE34 File Offset: 0x00D2A034
		private void RefreshName(bool isCompleted, SheriffAnomaly config)
		{
			bool flag = WorldMapModel.Instance.MapScale * 100f > (float)config.TextVisibleScale;
			if (isCompleted || !flag)
			{
				UUIText text = base.GetText(4);
				if (text == null)
				{
					return;
				}
				text.SetUIActive(false);
				return;
			}
			else
			{
				if (this.CurrentState == ESheriffAnomalyState.UnActivated)
				{
					LguiUtil.Instance.TrySetLocalTextNew(base.GetText(4), "Sheriff_Unknow_1", Array.Empty<object>());
					return;
				}
				LguiUtil.Instance.TrySetLocalTextNew(base.GetText(4), config.Name, Array.Empty<object>());
				return;
			}
		}

		// Token: 0x06037730 RID: 227120 RVA: 0x00D2BEB8 File Offset: 0x00D2A0B8
		private void RefreshProgress(bool isCompleted, SheriffAnomaly config)
		{
			bool flag = WorldMapModel.Instance.MapScale * 100f > (float)config.TextVisibleScale;
			if (this.CurrentState == ESheriffAnomalyState.UnActivated || isCompleted || !flag)
			{
				UUIText text = base.GetText(5);
				if (text == null)
				{
					return;
				}
				text.SetUIActive(false);
				return;
			}
			else
			{
				if (this.CurrentState == ESheriffAnomalyState.UnOpened)
				{
					LguiUtil.Instance.TrySetLocalTextNew(base.GetText(5), "FunctionMap_Content_14", Array.Empty<object>());
					return;
				}
				UUIText text2 = base.GetText(5);
				if (text2 != null)
				{
					text2.SetUIActive(true);
				}
				UUIText text3 = base.GetText(5);
				if (text3 == null)
				{
					return;
				}
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.CurrentProgress);
				defaultInterpolatedStringHandler.AppendLiteral("%");
				text3.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
				return;
			}
		}

		// Token: 0x06037731 RID: 227121 RVA: 0x00D2BF78 File Offset: 0x00D2A178
		private void RefreshBg(bool isCompleted)
		{
			string resourceId = isCompleted ? "SP_SkyEyeMapDone" : "SP_SkyEyeMapUndone";
			base.TrySetSpriteByPath(UiResourceConfig.Instance.GetResourcePath(resourceId), base.GetSprite(6), false, null, null);
		}

		// Token: 0x06037732 RID: 227122 RVA: 0x00D2BFB8 File Offset: 0x00D2A1B8
		[NullableContext(2)]
		private string GetMarkIcon(SheriffAnomaly anomaly)
		{
			SheriffCriminalInfo criminalInfo = SheriffModel.Instance.GetCriminalInfo(anomaly.CriminalId);
			if (criminalInfo == null)
			{
				return null;
			}
			SheriffIdentity? identityConfigById = SheriffConfig.Instance.GetIdentityConfigById(criminalInfo.Identity);
			if (identityConfigById == null)
			{
				return null;
			}
			return identityConfigById.GetValueOrDefault().MarkIcon;
		}

		// Token: 0x06037733 RID: 227123 RVA: 0x00D2C007 File Offset: 0x00D2A207
		protected override void OnBeforeDestroyImplement()
		{
			UiSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.Clear();
		}

		// Token: 0x0401D38D RID: 119693
		[Nullable(2)]
		private UiSequencePlayer LevelSequencePlayer;

		// Token: 0x0401D38E RID: 119694
		private int MarkId;

		// Token: 0x0401D38F RID: 119695
		private ESheriffAnomalyState CurrentState;

		// Token: 0x0401D390 RID: 119696
		private int CurrentProgress;

		// Token: 0x0200B743 RID: 46915
		private static class EComponent
		{
			// Token: 0x040377EA RID: 227306
			public const int Item = 0;

			// Token: 0x040377EB RID: 227307
			public const int SprCriminal = 1;

			// Token: 0x040377EC RID: 227308
			public const int PnlDone = 2;

			// Token: 0x040377ED RID: 227309
			public const int PnlLock = 3;

			// Token: 0x040377EE RID: 227310
			public const int TextName = 4;

			// Token: 0x040377EF RID: 227311
			public const int TextProgress = 5;

			// Token: 0x040377F0 RID: 227312
			public const int SprBg = 6;

			// Token: 0x040377F1 RID: 227313
			public const int TextUnknown = 7;
		}
	}
}
