using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001069 RID: 4201
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchUiItemBase : UiPanelBase
{
	// Token: 0x0600A707 RID: 42759 RVA: 0x003135A8 File Offset: 0x003117A8
	[NullableContext(2)]
	public FloroRanchEntityBase GetEntity()
	{
		return this.Entity;
	}

	// Token: 0x0600A708 RID: 42760 RVA: 0x003135B0 File Offset: 0x003117B0
	public void BindData(FloroRanchEntityBase entity)
	{
		if (!this.CanBindEntity)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanchGamePlay;
			ELogAuthor author = ELogAuthor.BB;
			string message = base.GetType().Name + " 已经绑定了数据";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entity", entity.Info());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.Entity = entity;
		this.CanBindEntity = false;
		Action<int> onEntityChangedCallback = this.OnEntityChangedCallback;
		if (onEntityChangedCallback == null)
		{
			return;
		}
		onEntityChangedCallback(entity.GetPoint());
	}

	// Token: 0x0600A709 RID: 42761 RVA: 0x0031362C File Offset: 0x0031182C
	public void UnbindData()
	{
		if (this.Entity != null)
		{
			int point = this.Entity.GetPoint();
			this.Entity = null;
			this.CanBindEntity = true;
			Action<int> onEntityChangedCallback = this.OnEntityChangedCallback;
			if (onEntityChangedCallback == null)
			{
				return;
			}
			onEntityChangedCallback(point);
		}
	}

	// Token: 0x0600A70A RID: 42762 RVA: 0x0031366C File Offset: 0x0031186C
	public virtual UniTask ShowUiItem()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600A70B RID: 42763 RVA: 0x00313673 File Offset: 0x00311873
	public virtual UniTask HideUiItem()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600A70C RID: 42764 RVA: 0x0031367A File Offset: 0x0031187A
	public virtual UniTask RefreshItem()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600A70D RID: 42765 RVA: 0x00313681 File Offset: 0x00311881
	public virtual UniTask PlayShowAnim()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600A70E RID: 42766 RVA: 0x00313688 File Offset: 0x00311888
	public virtual UniTask PlayNormalAnim()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600A70F RID: 42767 RVA: 0x0031368F File Offset: 0x0031188F
	public virtual UniTask PlayHideAnim()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600A710 RID: 42768 RVA: 0x00313696 File Offset: 0x00311896
	public virtual void Pause()
	{
	}

	// Token: 0x0600A711 RID: 42769 RVA: 0x00313698 File Offset: 0x00311898
	public virtual void Resume()
	{
	}

	// Token: 0x0600A712 RID: 42770 RVA: 0x0031369A File Offset: 0x0031189A
	public virtual UniTask MoveToItem(UUIItem targetItem)
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600A713 RID: 42771 RVA: 0x003136A1 File Offset: 0x003118A1
	public virtual UniTask MoveToOriginalPosition()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600A714 RID: 42772 RVA: 0x003136A8 File Offset: 0x003118A8
	public virtual void MoveToOriginalPositionImmediate()
	{
	}

	// Token: 0x0600A715 RID: 42773 RVA: 0x003136AC File Offset: 0x003118AC
	public virtual FTransform? GetRewardPopTransform()
	{
		return null;
	}

	// Token: 0x0600A716 RID: 42774 RVA: 0x003136C2 File Offset: 0x003118C2
	public virtual UniTask PlayEatAnim()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600A717 RID: 42775 RVA: 0x003136C9 File Offset: 0x003118C9
	public virtual UniTask PlayBeEatAnim()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600A718 RID: 42776 RVA: 0x003136D0 File Offset: 0x003118D0
	public virtual UniTask PlaySacrificeAnim()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600A719 RID: 42777 RVA: 0x003136D7 File Offset: 0x003118D7
	public virtual UniTask PlayFusionHideAnim()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600A71A RID: 42778 RVA: 0x003136DE File Offset: 0x003118DE
	public virtual UniTask PlayFusionShowAnim()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600A71B RID: 42779 RVA: 0x003136E5 File Offset: 0x003118E5
	public virtual UniTask PlayEvolveUpAnim()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600A71C RID: 42780 RVA: 0x003136EC File Offset: 0x003118EC
	public virtual UniTask PlaySkillAnim()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600A71D RID: 42781 RVA: 0x003136F3 File Offset: 0x003118F3
	public virtual void ShowCoinNiagara(long count)
	{
	}

	// Token: 0x0600A71E RID: 42782 RVA: 0x003136F8 File Offset: 0x003118F8
	public void ResetLayer()
	{
		FloroRanchEntityBase entity = this.Entity;
		int? num;
		if (entity == null)
		{
			num = null;
		}
		else
		{
			FloroRanchEntityDataComponent floroRanchEntityDataComponent = entity.CheckGetComponent<FloroRanchEntityDataComponent>();
			num = ((floroRanchEntityDataComponent != null) ? new int?(floroRanchEntityDataComponent.Point) : null);
		}
		int? num2 = num;
		int valueOrDefault = num2.GetValueOrDefault(-1);
		this.GetOriginalItem().SetHierarchyIndex(valueOrDefault);
	}

	// Token: 0x0600A71F RID: 42783 RVA: 0x0031374E File Offset: 0x0031194E
	public void SetLayerTop()
	{
		UUIItem originalItem = this.GetOriginalItem();
		if (originalItem == null)
		{
			return;
		}
		originalItem.SetHierarchyIndex(99);
	}

	// Token: 0x0600A720 RID: 42784 RVA: 0x00313762 File Offset: 0x00311962
	public void BindEntityChangedCallback(Action<int> callback)
	{
		this.OnEntityChangedCallback = callback;
	}

	// Token: 0x0400617E RID: 24958
	[Nullable(2)]
	protected FloroRanchEntityBase Entity;

	// Token: 0x0400617F RID: 24959
	public bool CanBindEntity = true;

	// Token: 0x04006180 RID: 24960
	protected Action<int> OnEntityChangedCallback = delegate(int point)
	{
	};
}
