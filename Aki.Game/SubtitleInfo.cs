using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.Sequence;

// Token: 0x02001EF1 RID: 7921
[NullableContext(1)]
[Nullable(0)]
public class SubtitleInfo
{
	// Token: 0x17001DDD RID: 7645
	// (get) Token: 0x0601393B RID: 80187 RVA: 0x005B3C7B File Offset: 0x005B1E7B
	[Nullable(2)]
	public ITalkItem CurrentConfig
	{
		[NullableContext(2)]
		get
		{
			return this.CurSubConfig.Subtitles;
		}
	}

	// Token: 0x17001DDE RID: 7646
	// (get) Token: 0x0601393C RID: 80188 RVA: 0x005B3C88 File Offset: 0x005B1E88
	public float CurrentDelayTime
	{
		get
		{
			return this.CurSubConfig.AudioDelay;
		}
	}

	// Token: 0x17001DDF RID: 7647
	// (get) Token: 0x0601393D RID: 80189 RVA: 0x005B3C95 File Offset: 0x005B1E95
	public float CurrentAutoPlayDelayTime
	{
		get
		{
			return this.CurSubConfig.AutoPlayDelay;
		}
	}

	// Token: 0x17001DE0 RID: 7648
	// (get) Token: 0x0601393E RID: 80190 RVA: 0x005B3CA2 File Offset: 0x005B1EA2
	public float CurrentAudioTransitionDuration
	{
		get
		{
			return this.CurSubConfig.AudioTransitionDuration;
		}
	}

	// Token: 0x0601393F RID: 80191 RVA: 0x005B3CAF File Offset: 0x005B1EAF
	public bool HasSubtitle()
	{
		return this.CurSubConfig.Subtitles != null;
	}

	// Token: 0x06013940 RID: 80192 RVA: 0x005B3CBF File Offset: 0x005B1EBF
	public void SetCurrentSubtitle(PlotSubtitleConfig subtitleInfo)
	{
		this.CurSubConfig.CopyFrom(subtitleInfo);
		this.InitSubtitle();
	}

	// Token: 0x06013941 RID: 80193 RVA: 0x005B3CD4 File Offset: 0x005B1ED4
	private void InitSubtitle()
	{
		if (!this.HasSubtitle())
		{
			return;
		}
		List<ITalkOption> options = this.CurrentConfig.Options;
		this.HasOption = (((options != null) ? options.Count : 0) > 0 || this.CurrentConfig.Type.GetValueOrDefault() == ETalkItemType.SystemOption);
		this.ShowAllText = false;
		this.ShowOption = false;
		this.EnableSkipTime = TimeUtil.Instance.GetServerTimeStamp() + (double)this.CurSubConfig.GuardTime;
		this.NeedDelay = (this.CurSubConfig.AutoPlayDelay > 0f);
		this.StartFinish = false;
	}

	// Token: 0x06013942 RID: 80194 RVA: 0x005B3D70 File Offset: 0x005B1F70
	public void Clear()
	{
		this.CurSubConfig.Clear();
		this.HasOption = false;
		this.ShowAllText = false;
		this.ShowOption = false;
		this.Skip = false;
		this.EnableSkipTime = 0.0;
		this.NeedDelay = false;
		this.StartFinish = false;
	}

	// Token: 0x0400A72A RID: 42794
	private readonly PlotSubtitleConfig CurSubConfig = new PlotSubtitleConfig();

	// Token: 0x0400A72B RID: 42795
	public bool HasOption;

	// Token: 0x0400A72C RID: 42796
	public bool ShowAllText;

	// Token: 0x0400A72D RID: 42797
	public bool ShowOption;

	// Token: 0x0400A72E RID: 42798
	public bool Skip;

	// Token: 0x0400A72F RID: 42799
	public double EnableSkipTime;

	// Token: 0x0400A730 RID: 42800
	public bool NeedDelay;

	// Token: 0x0400A731 RID: 42801
	public bool StartFinish;
}
