using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common;

// Token: 0x02000E6B RID: 3691
[NullableContext(1)]
[Nullable(0)]
public class CommonSuccessData
{
	// Token: 0x060093BB RID: 37819 RVA: 0x002BF317 File Offset: 0x002BD517
	public void SetTitleText(string text)
	{
		this.TitleText = text;
	}

	// Token: 0x060093BC RID: 37820 RVA: 0x002BF320 File Offset: 0x002BD520
	public void SetSubTitleText(string text)
	{
		this.SubTitleText = text;
	}

	// Token: 0x060093BD RID: 37821 RVA: 0x002BF329 File Offset: 0x002BD529
	public void SetClickText(string text)
	{
		this.ClickText = text;
	}

	// Token: 0x060093BE RID: 37822 RVA: 0x002BF332 File Offset: 0x002BD532
	public string GetTitleText()
	{
		return this.TitleText;
	}

	// Token: 0x060093BF RID: 37823 RVA: 0x002BF33A File Offset: 0x002BD53A
	public string GetSubTitleText()
	{
		return this.SubTitleText;
	}

	// Token: 0x060093C0 RID: 37824 RVA: 0x002BF342 File Offset: 0x002BD542
	public string GetClickText()
	{
		return this.ClickText;
	}

	// Token: 0x060093C1 RID: 37825 RVA: 0x002BF34A File Offset: 0x002BD54A
	public void SetClickFunction(Action clickFunction)
	{
		this.ClickFunction = clickFunction;
	}

	// Token: 0x060093C2 RID: 37826 RVA: 0x002BF353 File Offset: 0x002BD553
	[NullableContext(2)]
	public Action GetClickFunction()
	{
		return this.ClickFunction;
	}

	// Token: 0x060093C3 RID: 37827 RVA: 0x002BF35C File Offset: 0x002BD55C
	public void SetAudioId(string audioId)
	{
		Audio? audioPath = AudioConfig.Instance.GetAudioPath(audioId);
		if (audioPath != null)
		{
			this.AudioPath = audioPath.Value.Path;
		}
	}

	// Token: 0x060093C4 RID: 37828 RVA: 0x002BF393 File Offset: 0x002BD593
	public string GetAudioPath()
	{
		return this.AudioPath;
	}

	// Token: 0x060093C5 RID: 37829 RVA: 0x002BF39B File Offset: 0x002BD59B
	public void SetNeedDelay(bool needDelay)
	{
		this.NeedDelay = needDelay;
	}

	// Token: 0x060093C6 RID: 37830 RVA: 0x002BF3A4 File Offset: 0x002BD5A4
	public bool GetNeedDelay()
	{
		return this.NeedDelay;
	}

	// Token: 0x040056E8 RID: 22248
	private string TitleText = "";

	// Token: 0x040056E9 RID: 22249
	private string SubTitleText = "";

	// Token: 0x040056EA RID: 22250
	private string ClickText = "";

	// Token: 0x040056EB RID: 22251
	[Nullable(2)]
	private Action ClickFunction;

	// Token: 0x040056EC RID: 22252
	private string AudioPath = "";

	// Token: 0x040056ED RID: 22253
	private bool NeedDelay = true;
}
