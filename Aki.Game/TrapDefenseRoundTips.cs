using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.GameMainView.TrapDefense;
using CSharpScript.Game.Module.TrapDefense;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200120C RID: 4620
public class TrapDefenseRoundTips : UiViewBase
{
	// Token: 0x0600B78F RID: 46991 RVA: 0x00362A4E File Offset: 0x00360C4E
	[NullableContext(1)]
	public TrapDefenseRoundTips(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600B790 RID: 46992 RVA: 0x00362A58 File Offset: 0x00360C58
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIArtText)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x0600B791 RID: 46993 RVA: 0x00362AB4 File Offset: 0x00360CB4
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

	// Token: 0x0600B792 RID: 46994 RVA: 0x00362B5C File Offset: 0x00360D5C
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

	// Token: 0x0600B793 RID: 46995 RVA: 0x00362B8B File Offset: 0x00360D8B
	private void StartTimer()
	{
		this.TimerHandle = TimerSystem.Instance.Delay(delegate(float delta)
		{
			this.TimerHandle = null;
			base.CloseMe(null);
		}, 3000f, null, null, true, 1f);
	}

	// Token: 0x0600B794 RID: 46996 RVA: 0x00362BB6 File Offset: 0x00360DB6
	private void StopTimer()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.Instance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x040069E0 RID: 27104
	[Nullable(2)]
	protected ITrapDefenseRoundTipsData Data;

	// Token: 0x040069E1 RID: 27105
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x020074ED RID: 29933
	private static class EComponentDefine
	{
		// Token: 0x04026079 RID: 155769
		public const int CurrentRoundNum = 0;

		// Token: 0x0402607A RID: 155770
		public const int EnemyItem = 1;

		// Token: 0x0402607B RID: 155771
		public const int WarningTips = 2;
	}
}
