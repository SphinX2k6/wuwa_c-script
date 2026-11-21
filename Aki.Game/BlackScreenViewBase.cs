using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02000BC9 RID: 3017
[NullableContext(2)]
[Nullable(0)]
public abstract class BlackScreenViewBase : UiPanelBase
{
	// Token: 0x17000E23 RID: 3619
	// (get) Token: 0x06007D57 RID: 32087 RVA: 0x0026CBC8 File Offset: 0x0026ADC8
	public CustomPromise ShowPromise
	{
		get
		{
			return this.ShowPromiseInternal;
		}
	}

	// Token: 0x06007D58 RID: 32088 RVA: 0x0026CBD0 File Offset: 0x0026ADD0
	protected void CreateShowPromise()
	{
		this.ShowPromiseInternal = new CustomPromise();
	}

	// Token: 0x06007D59 RID: 32089 RVA: 0x0026CBDD File Offset: 0x0026ADDD
	protected void FinishShowPromise()
	{
		this.ShowPromiseInternal.SetResult();
	}

	// Token: 0x17000E24 RID: 3620
	// (get) Token: 0x06007D5A RID: 32090 RVA: 0x0026CBEA File Offset: 0x0026ADEA
	public CustomPromise HidePromise
	{
		get
		{
			return this.HidePromiseInternal;
		}
	}

	// Token: 0x06007D5B RID: 32091 RVA: 0x0026CBF2 File Offset: 0x0026ADF2
	protected void CreateHidePromise()
	{
		this.HidePromiseInternal = new CustomPromise();
	}

	// Token: 0x06007D5C RID: 32092 RVA: 0x0026CBFF File Offset: 0x0026ADFF
	protected void FinishHidePromise()
	{
		this.HidePromiseInternal.SetResult();
	}

	// Token: 0x06007D5D RID: 32093 RVA: 0x0026CC0C File Offset: 0x0026AE0C
	protected void ResetPromiseData()
	{
		this.ShowPromiseInternal = null;
		this.HidePromiseInternal = null;
	}

	// Token: 0x06007D5E RID: 32094
	[NullableContext(1)]
	public abstract void ShowTemp(string showAnimType, string colorType);

	// Token: 0x06007D5F RID: 32095
	[NullableContext(1)]
	public abstract void HideTemp(string hideAnimType);

	// Token: 0x06007D60 RID: 32096 RVA: 0x0026CC1C File Offset: 0x0026AE1C
	public virtual void CompleteShowImmediately()
	{
	}

	// Token: 0x04004DEC RID: 19948
	private CustomPromise ShowPromiseInternal;

	// Token: 0x04004DED RID: 19949
	private CustomPromise HidePromiseInternal;
}
