using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D3F RID: 23871
	[NullableContext(1)]
	[Nullable(0)]
	public class ChargingDeviceHeadState : HeadStateViewBase
	{
		// Token: 0x0603C8CD RID: 248013 RVA: 0x00E87ABC File Offset: 0x00E85CBC
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

		// Token: 0x0603C8CE RID: 248014 RVA: 0x00E87B48 File Offset: 0x00E85D48
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

		// Token: 0x0603C8CF RID: 248015 RVA: 0x00E87B86 File Offset: 0x00E85D86
		protected override string GetResourceId()
		{
			return "UiItem_HpClean";
		}

		// Token: 0x0603C8D0 RID: 248016 RVA: 0x00E87B90 File Offset: 0x00E85D90
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

		// Token: 0x0603C8D1 RID: 248017 RVA: 0x00E87C06 File Offset: 0x00E85E06
		protected override void BindCallback()
		{
			base.BindCallback();
			this.HeadStateData.BindOnProgressControlDataChange(new Action<SceneItemProgressControlComponent.TProgressData>(this.OnProgressControlDataChange));
		}

		// Token: 0x0603C8D2 RID: 248018 RVA: 0x00E87C25 File Offset: 0x00E85E25
		public void OnProgressControlDataChange(SceneItemProgressControlComponent.TProgressData progressData)
		{
			if (progressData.ProgressCtrlType == EProgressBarControlType.ChargingDevice)
			{
				this.SetProgress(progressData.CurrentValue / progressData.MaxValue);
			}
		}

		// Token: 0x0603C8D3 RID: 248019 RVA: 0x00E87C44 File Offset: 0x00E85E44
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

		// Token: 0x0401F8B0 RID: 129200
		private float BarFullWidth;

		// Token: 0x0401F8B1 RID: 129201
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401F8B2 RID: 129202
		private bool PlayedFullSequence;

		// Token: 0x0200BFE1 RID: 49121
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04039E30 RID: 237104
			TxtProgress,
			// Token: 0x04039E31 RID: 237105
			BarProgress,
			// Token: 0x04039E32 RID: 237106
			TexHandle
		}
	}
}
