using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.UiComponent.UiHomeButton;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

// Token: 0x020021B3 RID: 8627
[NullableContext(1)]
[Nullable(0)]
public class UiBehaviourHomeBtn : IUiBehavior
{
	// Token: 0x060153AF RID: 86959 RVA: 0x0062C4B8 File Offset: 0x0062A6B8
	public void SetViewInfo(UiViewBase baseView)
	{
		this.CurrentView = baseView;
	}

	// Token: 0x060153B0 RID: 86960 RVA: 0x0062C4C1 File Offset: 0x0062A6C1
	public UniTask OnUiCreateAsync()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x060153B1 RID: 86961 RVA: 0x0062C4C8 File Offset: 0x0062A6C8
	public void OnUiStart()
	{
		if (this.CurrentView == null)
		{
			return;
		}
		HomeBtnController.Instance.CreateHomeBtnFromView(this.CurrentView);
	}

	// Token: 0x060153B2 RID: 86962 RVA: 0x0062C4E3 File Offset: 0x0062A6E3
	public void OnUiShow()
	{
	}

	// Token: 0x060153B3 RID: 86963 RVA: 0x0062C4E5 File Offset: 0x0062A6E5
	public void OnUiHide()
	{
	}

	// Token: 0x060153B4 RID: 86964 RVA: 0x0062C4E7 File Offset: 0x0062A6E7
	public void OnDestroy()
	{
		if (this.CurrentView == null)
		{
			return;
		}
		HomeBtnController.Instance.RemoveExtraCallback(this.CurrentView.ViewInfo.Name);
	}

	// Token: 0x060153B5 RID: 86965 RVA: 0x0062C50C File Offset: 0x0062A70C
	public void AddExtraAsyncCallback(Func<UniTask> callback)
	{
		if (this.CurrentView == null)
		{
			return;
		}
		HomeBtnController.Instance.AddExtraAsyncCallback(this.CurrentView.ViewInfo.Name, callback);
	}

	// Token: 0x060153B6 RID: 86966 RVA: 0x0062C532 File Offset: 0x0062A732
	public void AddExtraCallback(Action callback)
	{
		if (this.CurrentView == null)
		{
			return;
		}
		HomeBtnController.Instance.AddExtraCallback(this.CurrentView.ViewInfo.Name, callback);
	}

	// Token: 0x0400B401 RID: 46081
	[Nullable(2)]
	private UiViewBase CurrentView;
}
