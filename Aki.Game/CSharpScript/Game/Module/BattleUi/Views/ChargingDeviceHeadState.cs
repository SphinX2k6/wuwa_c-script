using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D21 RID: 19745
	[NullableContext(1)]
	[Nullable(0)]
	public class ChargingDeviceHeadState : HeadStateViewBase
	{
		// Token: 0x06031826 RID: 202790 RVA: 0x00DD825C File Offset: 0x00DD645C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031827 RID: 202791 RVA: 0x00DD82E8 File Offset: 0x00DD64E8
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x06031828 RID: 202792 RVA: 0x00DD8326 File Offset: 0x00DD6526
		protected override string GetResourceId()
		{
			return "UiItem_HpClean";
		}

		// Token: 0x06031829 RID: 202793 RVA: 0x00DD8330 File Offset: 0x00DD6530
		protected override void ActiveBattleHeadState(HeadStateData headStateData)
		{
			base.ActiveBattleHeadState(headStateData);
			UUITexture texture = base.GetTexture(1);
			UUIText text = base.GetText(0);
			float stretchLeft = texture.GetStretchLeft();
			float width = texture.GetParentAsUIItem().GetWidth();
			this.BarFullWidth = width - 2f * stretchLeft;
			texture.SetUIActive(true);
			text.SetUIActive(true);
			SceneItemProgressControlComponent.TProgressData progressControlData = headStateData.GetProgressControlData();
			if (progressControlData.ProgressCtrlType == EProgressBarControlType.ChargingDevice)
			{
				this.SetProgress(progressControlData.CurrentValue / progressControlData.MaxValue);
			}
		}

		// Token: 0x0603182A RID: 202794 RVA: 0x00DD83A6 File Offset: 0x00DD65A6
		protected override void BindCallback()
		{
			base.BindCallback();
			this.HeadStateData.BindOnProgressControlDataChange(new Action<SceneItemProgressControlComponent.TProgressData>(this.OnProgressControlDataChange));
		}

		// Token: 0x0603182B RID: 202795 RVA: 0x00DD83C5 File Offset: 0x00DD65C5
		public void OnProgressControlDataChange(SceneItemProgressControlComponent.TProgressData progressData)
		{
			if (progressData.ProgressCtrlType == EProgressBarControlType.ChargingDevice)
			{
				this.SetProgress(progressData.CurrentValue / progressData.MaxValue);
			}
		}

		// Token: 0x0603182C RID: 202796 RVA: 0x00DD83E4 File Offset: 0x00DD65E4
		private void SetProgress(float progress)
		{
			base.GetTexture(1).SetFillAmount(progress);
			float inX = MathUtils.Instance.Clamp(progress, 0f, 1f) * this.BarFullWidth - this.BarFullWidth / 2f;
			base.GetTexture(2).SetUIRelativeLocation(new FVector(inX, 0f, 0f));
			int value = (int)Math.Round((double)MathUtils.Instance.RangeClamp(progress, 0f, 1f, 0f, 100f));
			UUIText text = base.GetText(0);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			defaultInterpolatedStringHandler.AppendLiteral("%");
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			if (progress >= 1f && !this.PlayedFullSequence)
			{
				LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer != null)
				{
					levelSequencePlayer.PlayLevelSequenceByName("Full", false, null, false);
				}
				this.PlayedFullSequence = true;
			}
		}

		// Token: 0x0401A369 RID: 107369
		private float BarFullWidth;

		// Token: 0x0401A36A RID: 107370
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401A36B RID: 107371
		private bool PlayedFullSequence;

		// Token: 0x0200A9E7 RID: 43495
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x040347F2 RID: 215026
			TxtProgress,
			// Token: 0x040347F3 RID: 215027
			BarProgress,
			// Token: 0x040347F4 RID: 215028
			TexHandle
		}
	}
}
