using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001711 RID: 5905
[NullableContext(2)]
[Nullable(0)]
public abstract class BlackScreenViewBase : UiPanelBase
{
	// Token: 0x17000E02 RID: 3586
	// (get) Token: 0x0600A975 RID: 43381 RVA: 0x00262679 File Offset: 0x00260879
	public CustomPromise ShowPromise
	{
		get
		{
			return this.ShowPromiseInternal;
		}
	}

	// Token: 0x0600A976 RID: 43382 RVA: 0x00262681 File Offset: 0x00260881
	protected void CreateShowPromise()
	{
		this.ShowPromiseInternal = new CustomPromise();
	}

	// Token: 0x0600A977 RID: 43383 RVA: 0x0026268E File Offset: 0x0026088E
	protected void FinishShowPromise()
	{
		this.ShowPromiseInternal.SetResult();
	}

	// Token: 0x17000E03 RID: 3587
	// (get) Token: 0x0600A978 RID: 43384 RVA: 0x0026269B File Offset: 0x0026089B
	public CustomPromise HidePromise
	{
		get
		{
			return this.HidePromiseInternal;
		}
	}

	// Token: 0x0600A979 RID: 43385 RVA: 0x002626A3 File Offset: 0x002608A3
	protected void CreateHidePromise()
	{
		this.HidePromiseInternal = new CustomPromise();
	}

	// Token: 0x0600A97A RID: 43386 RVA: 0x002626B0 File Offset: 0x002608B0
	protected void FinishHidePromise()
	{
		this.HidePromiseInternal.SetResult();
	}

	// Token: 0x0600A97B RID: 43387 RVA: 0x002626BD File Offset: 0x002608BD
	protected void ResetPromiseData()
	{
		this.ShowPromiseInternal = null;
		this.HidePromiseInternal = null;
	}

	// Token: 0x0600A97C RID: 43388
	[NullableContext(1)]
	public abstract void ShowTemp(string showAnimType, string colorType);

	// Token: 0x0600A97D RID: 43389
	[NullableContext(1)]
	public abstract void HideTemp(string hideAnimType);

	// Token: 0x04004D44 RID: 19780
	private CustomPromise ShowPromiseInternal;

	// Token: 0x04004D45 RID: 19781
	private CustomPromise HidePromiseInternal;
}
