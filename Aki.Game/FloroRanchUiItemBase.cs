using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001BAA RID: 7082
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchUiItemBase : UiPanelBase
{
	// Token: 0x0600D2F6 RID: 54006 RVA: 0x003084C8 File Offset: 0x003066C8
	[NullableContext(2)]
	public FloroRanchEntityBase GetEntity()
	{
		return this.Entity;
	}

	// Token: 0x0600D2F7 RID: 54007 RVA: 0x003084D0 File Offset: 0x003066D0
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

	// Token: 0x0600D2F8 RID: 54008 RVA: 0x0030854C File Offset: 0x0030674C
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

	// Token: 0x0600D2F9 RID: 54009 RVA: 0x0030858C File Offset: 0x0030678C
	public virtual UniTask ShowUiItem()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600D2FA RID: 54010 RVA: 0x00308593 File Offset: 0x00306793
	public virtual UniTask HideUiItem()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600D2FB RID: 54011 RVA: 0x0030859A File Offset: 0x0030679A
	public virtual UniTask RefreshItem()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600D2FC RID: 54012 RVA: 0x003085A1 File Offset: 0x003067A1
	public virtual UniTask PlayShowAnim()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600D2FD RID: 54013 RVA: 0x003085A8 File Offset: 0x003067A8
	public virtual UniTask PlayNormalAnim()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600D2FE RID: 54014 RVA: 0x003085AF File Offset: 0x003067AF
	public virtual UniTask PlayHideAnim()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600D2FF RID: 54015 RVA: 0x003085B6 File Offset: 0x003067B6
	public virtual void Pause()
	{
	}

	// Token: 0x0600D300 RID: 54016 RVA: 0x003085B8 File Offset: 0x003067B8
	public virtual void Resume()
	{
	}

	// Token: 0x0600D301 RID: 54017 RVA: 0x003085BA File Offset: 0x003067BA
	public virtual UniTask MoveToItem(UUIItem targetItem)
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600D302 RID: 54018 RVA: 0x003085C1 File Offset: 0x003067C1
	public virtual UniTask MoveToOriginalPosition()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600D303 RID: 54019 RVA: 0x003085C8 File Offset: 0x003067C8
	public virtual void MoveToOriginalPositionImmediate()
	{
	}

	// Token: 0x0600D304 RID: 54020 RVA: 0x003085CC File Offset: 0x003067CC
	public virtual FTransform? GetRewardPopTransform()
	{
		return null;
	}

	// Token: 0x0600D305 RID: 54021 RVA: 0x003085E2 File Offset: 0x003067E2
	public virtual UniTask PlayEatAnim()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600D306 RID: 54022 RVA: 0x003085E9 File Offset: 0x003067E9
	public virtual UniTask PlayBeEatAnim()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600D307 RID: 54023 RVA: 0x003085F0 File Offset: 0x003067F0
	public virtual UniTask PlaySacrificeAnim()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600D308 RID: 54024 RVA: 0x003085F7 File Offset: 0x003067F7
	public virtual UniTask PlayFusionHideAnim()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600D309 RID: 54025 RVA: 0x003085FE File Offset: 0x003067FE
	public virtual UniTask PlayFusionShowAnim()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600D30A RID: 54026 RVA: 0x00308605 File Offset: 0x00306805
	public virtual UniTask PlayEvolveUpAnim()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600D30B RID: 54027 RVA: 0x0030860C File Offset: 0x0030680C
	public virtual UniTask PlaySkillAnim()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600D30C RID: 54028 RVA: 0x00308613 File Offset: 0x00306813
	public virtual void ShowCoinNiagara(long count)
	{
	}

	// Token: 0x0600D30D RID: 54029 RVA: 0x00308618 File Offset: 0x00306818
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

	// Token: 0x0600D30E RID: 54030 RVA: 0x0030866E File Offset: 0x0030686E
	public void SetLayerTop()
	{
		UUIItem originalItem = this.GetOriginalItem();
		if (originalItem == null)
		{
			return;
		}
		originalItem.SetHierarchyIndex(99);
	}

	// Token: 0x0600D30F RID: 54031 RVA: 0x00308682 File Offset: 0x00306882
	public void BindEntityChangedCallback(Action<int> callback)
	{
		this.OnEntityChangedCallback = callback;
	}

	// Token: 0x040060AF RID: 24751
	[Nullable(2)]
	protected FloroRanchEntityBase Entity;

	// Token: 0x040060B0 RID: 24752
	public bool CanBindEntity = true;

	// Token: 0x040060B1 RID: 24753
	protected Action<int> OnEntityChangedCallback = delegate(int point)
	{
	};
}
