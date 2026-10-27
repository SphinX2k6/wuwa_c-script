using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.Sequence;

// Token: 0x02002976 RID: 10614
[NullableContext(1)]
[Nullable(0)]
public class SubtitleInfo
{
	// Token: 0x17001D84 RID: 7556
	// (get) Token: 0x06015F35 RID: 89909 RVA: 0x00588C54 File Offset: 0x00586E54
	[Nullable(2)]
	public ITalkItem CurrentConfig
	{
		[NullableContext(2)]
		get
		{
			return this.CurSubConfig.Subtitles;
		}
	}

	// Token: 0x17001D85 RID: 7557
	// (get) Token: 0x06015F36 RID: 89910 RVA: 0x00588C61 File Offset: 0x00586E61
	public float CurrentDelayTime
	{
		get
		{
			return this.CurSubConfig.AudioDelay;
		}
	}

	// Token: 0x17001D86 RID: 7558
	// (get) Token: 0x06015F37 RID: 89911 RVA: 0x00588C6E File Offset: 0x00586E6E
	public float CurrentAutoPlayDelayTime
	{
		get
		{
			return this.CurSubConfig.AutoPlayDelay;
		}
	}

	// Token: 0x17001D87 RID: 7559
	// (get) Token: 0x06015F38 RID: 89912 RVA: 0x00588C7B File Offset: 0x00586E7B
	public float CurrentAudioTransitionDuration
	{
		get
		{
			return this.CurSubConfig.AudioTransitionDuration;
		}
	}

	// Token: 0x06015F39 RID: 89913 RVA: 0x00588C88 File Offset: 0x00586E88
	public bool HasSubtitle()
	{
		return this.CurSubConfig.Subtitles != null;
	}

	// Token: 0x06015F3A RID: 89914 RVA: 0x00588C98 File Offset: 0x00586E98
	public void SetCurrentSubtitle(PlotSubtitleConfig subtitleInfo)
	{
		this.CurSubConfig.CopyFrom(subtitleInfo);
		this.InitSubtitle();
	}

	// Token: 0x06015F3B RID: 89915 RVA: 0x00588CAC File Offset: 0x00586EAC
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

	// Token: 0x06015F3C RID: 89916 RVA: 0x00588D48 File Offset: 0x00586F48
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

	// Token: 0x0400A340 RID: 41792
	private readonly PlotSubtitleConfig CurSubConfig = new PlotSubtitleConfig();

	// Token: 0x0400A341 RID: 41793
	public bool HasOption;

	// Token: 0x0400A342 RID: 41794
	public bool ShowAllText;

	// Token: 0x0400A343 RID: 41795
	public bool ShowOption;

	// Token: 0x0400A344 RID: 41796
	public bool Skip;

	// Token: 0x0400A345 RID: 41797
	public double EnableSkipTime;

	// Token: 0x0400A346 RID: 41798
	public bool NeedDelay;

	// Token: 0x0400A347 RID: 41799
	public bool StartFinish;
}
