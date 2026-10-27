using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.GameMainView.TrapDefense;
using CSharpScript.Game.Module.TrapDefense;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001D4A RID: 7498
public class TrapDefenseRoundTips : UiViewBase
{
	// Token: 0x0600E372 RID: 58226 RVA: 0x0035701E File Offset: 0x0035521E
	[NullableContext(1)]
	public TrapDefenseRoundTips(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E373 RID: 58227 RVA: 0x00357028 File Offset: 0x00355228
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIArtText)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x0600E374 RID: 58228 RVA: 0x00357084 File Offset: 0x00355284
	protected override void OnStart()
	{
		this.Data = (this.OpenParam as ITrapDefenseRoundTipsData);
		UUIArtText artText = base.GetArtText(0);
		if (artText != null)
		{
			artText.SetText(this.Data.Round.ToString());
		}
		TrapDefenseWave? currentBatchData = TrapDefenseModel.Instance.GetCurrentBatchData();
		bool flag = !StringUtils.IsBlank(currentBatchData.Value.WaveWarningTips);
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		if (flag)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), currentBatchData.Value.WaveWarningTips, Array.Empty<object>());
		}
		this.StartTimer();
	}

	// Token: 0x0600E375 RID: 58229 RVA: 0x0035712C File Offset: 0x0035532C
	protected override void OnBeforeDestroy()
	{
		ITrapDefenseRoundTipsData data = this.Data;
		Action action = (data != null) ? data.Callback : null;
		if (action != null)
		{
			action();
		}
		this.StopTimer();
	}

	// Token: 0x0600E376 RID: 58230 RVA: 0x0035715B File Offset: 0x0035535B
	private void StartTimer()
	{
		this.TimerHandle = TimerSystem.Instance.Delay(delegate(float delta)
		{
			this.TimerHandle = null;
			base.CloseMe(null);
		}, 3000f, null, null, true, 1f);
	}

	// Token: 0x0600E377 RID: 58231 RVA: 0x00357186 File Offset: 0x00355386
	private void StopTimer()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.Instance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x04006901 RID: 26881
	[Nullable(2)]
	protected ITrapDefenseRoundTipsData Data;

	// Token: 0x04006902 RID: 26882
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x02008364 RID: 33636
	private static class EComponentDefine
	{
		// Token: 0x0402AD51 RID: 175441
		public const int CurrentRoundNum = 0;

		// Token: 0x0402AD52 RID: 175442
		public const int EnemyItem = 1;

		// Token: 0x0402AD53 RID: 175443
		public const int WarningTips = 2;
	}
}
