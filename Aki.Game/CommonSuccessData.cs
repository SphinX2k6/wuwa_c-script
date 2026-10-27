using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common;

// Token: 0x020019AD RID: 6573
[NullableContext(1)]
[Nullable(0)]
public class CommonSuccessData
{
	// Token: 0x0600BFB1 RID: 49073 RVA: 0x002B4387 File Offset: 0x002B2587
	public void SetTitleText(string text)
	{
		this.TitleText = text;
	}

	// Token: 0x0600BFB2 RID: 49074 RVA: 0x002B4390 File Offset: 0x002B2590
	public void SetSubTitleText(string text)
	{
		this.SubTitleText = text;
	}

	// Token: 0x0600BFB3 RID: 49075 RVA: 0x002B4399 File Offset: 0x002B2599
	public void SetClickText(string text)
	{
		this.ClickText = text;
	}

	// Token: 0x0600BFB4 RID: 49076 RVA: 0x002B43A2 File Offset: 0x002B25A2
	public string GetTitleText()
	{
		return this.TitleText;
	}

	// Token: 0x0600BFB5 RID: 49077 RVA: 0x002B43AA File Offset: 0x002B25AA
	public string GetSubTitleText()
	{
		return this.SubTitleText;
	}

	// Token: 0x0600BFB6 RID: 49078 RVA: 0x002B43B2 File Offset: 0x002B25B2
	public string GetClickText()
	{
		return this.ClickText;
	}

	// Token: 0x0600BFB7 RID: 49079 RVA: 0x002B43BA File Offset: 0x002B25BA
	public void SetClickFunction(Action clickFunction)
	{
		this.ClickFunction = clickFunction;
	}

	// Token: 0x0600BFB8 RID: 49080 RVA: 0x002B43C3 File Offset: 0x002B25C3
	[NullableContext(2)]
	public Action GetClickFunction()
	{
		return this.ClickFunction;
	}

	// Token: 0x0600BFB9 RID: 49081 RVA: 0x002B43CC File Offset: 0x002B25CC
	public void SetAudioId(string audioId)
	{
		Audio? audioPath = AudioConfig.Instance.GetAudioPath(audioId);
		if (audioPath != null)
		{
			this.AudioPath = audioPath.Value.Path;
		}
	}

	// Token: 0x0600BFBA RID: 49082 RVA: 0x002B4403 File Offset: 0x002B2603
	public string GetAudioPath()
	{
		return this.AudioPath;
	}

	// Token: 0x0600BFBB RID: 49083 RVA: 0x002B440B File Offset: 0x002B260B
	public void SetNeedDelay(bool needDelay)
	{
		this.NeedDelay = needDelay;
	}

	// Token: 0x0600BFBC RID: 49084 RVA: 0x002B4414 File Offset: 0x002B2614
	public bool GetNeedDelay()
	{
		return this.NeedDelay;
	}

	// Token: 0x04005636 RID: 22070
	private string TitleText = "";

	// Token: 0x04005637 RID: 22071
	private string SubTitleText = "";

	// Token: 0x04005638 RID: 22072
	private string ClickText = "";

	// Token: 0x04005639 RID: 22073
	[Nullable(2)]
	private Action ClickFunction;

	// Token: 0x0400563A RID: 22074
	private string AudioPath = "";

	// Token: 0x0400563B RID: 22075
	private bool NeedDelay = true;
}
