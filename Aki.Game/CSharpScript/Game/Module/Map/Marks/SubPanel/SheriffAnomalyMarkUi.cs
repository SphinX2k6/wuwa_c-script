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
	// Token: 0x020044A9 RID: 17577
	public class SheriffAnomalyMarkUi : UiPanelBase
	{
		// Token: 0x0602C5CE RID: 181710 RVA: 0x00C79660 File Offset: 0x00C77860
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

		// Token: 0x0602C5CF RID: 181711 RVA: 0x00C7978F File Offset: 0x00C7798F
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

		// Token: 0x0602C5D0 RID: 181712 RVA: 0x00C797B9 File Offset: 0x00C779B9
		protected override void OnAfterShow()
		{
		}

		// Token: 0x0602C5D1 RID: 181713 RVA: 0x00C797BC File Offset: 0x00C779BC
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

		// Token: 0x0602C5D2 RID: 181714 RVA: 0x00C79824 File Offset: 0x00C77A24
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

		// Token: 0x0602C5D3 RID: 181715 RVA: 0x00C798D8 File Offset: 0x00C77AD8
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

		// Token: 0x0602C5D4 RID: 181716 RVA: 0x00C7991C File Offset: 0x00C77B1C
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

		// Token: 0x0602C5D5 RID: 181717 RVA: 0x00C799A0 File Offset: 0x00C77BA0
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

		// Token: 0x0602C5D6 RID: 181718 RVA: 0x00C79A60 File Offset: 0x00C77C60
		private void RefreshBg(bool isCompleted)
		{
			string resourceId = isCompleted ? "SP_SkyEyeMapDone" : "SP_SkyEyeMapUndone";
			base.TrySetSpriteByPath(UiResourceConfig.Instance.GetResourcePath(resourceId), base.GetSprite(6), false, null, null);
		}

		// Token: 0x0602C5D7 RID: 181719 RVA: 0x00C79AA0 File Offset: 0x00C77CA0
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

		// Token: 0x0602C5D8 RID: 181720 RVA: 0x00C79AEF File Offset: 0x00C77CEF
		protected override void OnBeforeDestroyImplement()
		{
			UiSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.Clear();
		}

		// Token: 0x04017E06 RID: 97798
		[Nullable(2)]
		private UiSequencePlayer LevelSequencePlayer;

		// Token: 0x04017E07 RID: 97799
		private int MarkId;

		// Token: 0x04017E08 RID: 97800
		private ESheriffAnomalyState CurrentState;

		// Token: 0x04017E09 RID: 97801
		private int CurrentProgress;

		// Token: 0x0200A172 RID: 41330
		private static class EComponent
		{
			// Token: 0x04032223 RID: 205347
			public const int Item = 0;

			// Token: 0x04032224 RID: 205348
			public const int SprCriminal = 1;

			// Token: 0x04032225 RID: 205349
			public const int PnlDone = 2;

			// Token: 0x04032226 RID: 205350
			public const int PnlLock = 3;

			// Token: 0x04032227 RID: 205351
			public const int TextName = 4;

			// Token: 0x04032228 RID: 205352
			public const int TextProgress = 5;

			// Token: 0x04032229 RID: 205353
			public const int SprBg = 6;

			// Token: 0x0403222A RID: 205354
			public const int TextUnknown = 7;
		}
	}
}
