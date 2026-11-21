using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x020021FA RID: 8698
[NullableContext(2)]
[Nullable(0)]
public class UiMotorDecorationComponent : UiModelComponentBase
{
	// Token: 0x06015684 RID: 87684 RVA: 0x00637A9D File Offset: 0x00635C9D
	protected override void OnInit()
	{
		this.ModelDataComponent = base.Owner.CheckGetComponent<UiModelDataComponent>();
		this.InitDecorationSkeletalObserver();
	}

	// Token: 0x06015685 RID: 87685 RVA: 0x00637AB8 File Offset: 0x00635CB8
	protected override void OnStart()
	{
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.BeforeUiModelLoadStart, new Action(this.OnBeforeMotorModelLoad));
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnMotorModelReady));
	}

	// Token: 0x06015686 RID: 87686 RVA: 0x00637B0C File Offset: 0x00635D0C
	protected override void OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.BeforeUiModelLoadStart, new Action(this.OnBeforeMotorModelLoad));
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnMotorModelReady));
		this.RemoveAllDecorationSkeletalObserver();
	}

	// Token: 0x06015687 RID: 87687 RVA: 0x00637B63 File Offset: 0x00635D63
	public bool IsMotorModelLoaded()
	{
		UiModelDataComponent modelDataComponent = this.ModelDataComponent;
		return modelDataComponent != null && modelDataComponent.GetModelLoadState() == EUiModelLoadState.LoadComplete;
	}

	// Token: 0x06015688 RID: 87688 RVA: 0x00637B7C File Offset: 0x00635D7C
	public SkeletalObserverHandle GetDecorationHandle(int decorationPart, int index)
	{
		List<SkeletalObserverHandle> list;
		if (this.MotorDecorationMap.TryGetValue(decorationPart, out list) && index >= 0 && index < list.Count)
		{
			return list[index];
		}
		return null;
	}

	// Token: 0x06015689 RID: 87689 RVA: 0x00637BB0 File Offset: 0x00635DB0
	public void InitDecorationSkeletalObserver()
	{
		foreach (int key in MotorcycleDiyDefine.MOTORCYCLE_DIY_DECORATION_PART)
		{
			SkeletalObserverHandle item = SkeletalObserverManager.NewSkeletalObserver(EUiModelUseWay.MotorDecorationOnMotor);
			this.MotorDecorationMap[key] = new List<SkeletalObserverHandle>
			{
				item
			};
		}
	}

	// Token: 0x0601568A RID: 87690 RVA: 0x00637BF8 File Offset: 0x00635DF8
	public void RemoveAllDecorationSkeletalObserver()
	{
		foreach (List<SkeletalObserverHandle> list in this.MotorDecorationMap.Values)
		{
			foreach (SkeletalObserverHandle skeletalObserverHandle in list)
			{
				SkeletalObserverManager.DestroySkeletalObserver(skeletalObserverHandle);
			}
		}
		this.MotorDecorationMap.Clear();
	}

	// Token: 0x0601568B RID: 87691 RVA: 0x00637C8C File Offset: 0x00635E8C
	public void RemoveDecorationSkeletalObserver(int decorationPart, int? index = null)
	{
		List<SkeletalObserverHandle> list;
		if (!this.MotorDecorationMap.TryGetValue(decorationPart, out list))
		{
			return;
		}
		if (index != null)
		{
			int value = index.Value;
			if (value >= 0 && value < list.Count)
			{
				SkeletalObserverManager.DestroySkeletalObserver(list[value]);
				list.RemoveAt(value);
				return;
			}
		}
		else
		{
			foreach (SkeletalObserverHandle skeletalObserverHandle in list)
			{
				SkeletalObserverManager.DestroySkeletalObserver(skeletalObserverHandle);
			}
			this.MotorDecorationMap.Remove(decorationPart);
		}
	}

	// Token: 0x0601568C RID: 87692 RVA: 0x00637D28 File Offset: 0x00635F28
	public void ShowAllDecoration(bool isShow)
	{
		if (isShow && !this.IsMotorModelLoaded())
		{
			return;
		}
		foreach (List<SkeletalObserverHandle> list in this.MotorDecorationMap.Values)
		{
			foreach (SkeletalObserverHandle skeletalObserverHandle in list)
			{
				if (((skeletalObserverHandle != null) ? skeletalObserverHandle.Model : null) != null)
				{
					UiModelUtil.Instance.SetVisible(skeletalObserverHandle.Model, isShow);
				}
			}
		}
	}

	// Token: 0x0601568D RID: 87693 RVA: 0x00637DDC File Offset: 0x00635FDC
	public void AddDecorationMesh(int decorationPart, int decorationId)
	{
		SkeletalObserverHandle item = SkeletalObserverManager.NewSkeletalObserver(EUiModelUseWay.MotorDecorationOnMotor);
		List<SkeletalObserverHandle> list;
		if (!this.MotorDecorationMap.TryGetValue(decorationPart, out list))
		{
			list = new List<SkeletalObserverHandle>();
			this.MotorDecorationMap[decorationPart] = list;
		}
		list.Add(item);
	}

	// Token: 0x0601568E RID: 87694 RVA: 0x00637E1B File Offset: 0x0063601B
	private void OnBeforeMotorModelLoad()
	{
		this.ShowAllDecoration(false);
	}

	// Token: 0x0601568F RID: 87695 RVA: 0x00637E24 File Offset: 0x00636024
	private void OnMotorModelReady()
	{
		this.ShowAllDecoration(true);
	}

	// Token: 0x0400B571 RID: 46449
	[Nullable(1)]
	private readonly Dictionary<int, List<SkeletalObserverHandle>> MotorDecorationMap = new Dictionary<int, List<SkeletalObserverHandle>>();

	// Token: 0x0400B572 RID: 46450
	private UiModelDataComponent ModelDataComponent;
}
