using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02002CA1 RID: 11425
[NullableContext(2)]
[Nullable(0)]
public class UiMotorDecorationComponent : UiModelComponentBase
{
	// Token: 0x06017E10 RID: 97808 RVA: 0x00611F19 File Offset: 0x00610119
	protected override void OnInit()
	{
		this.ModelDataComponent = base.Owner.CheckGetComponent<UiModelDataComponent>();
		this.InitDecorationSkeletalObserver();
	}

	// Token: 0x06017E11 RID: 97809 RVA: 0x00611F34 File Offset: 0x00610134
	protected override void OnStart()
	{
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.BeforeUiModelLoadStart, new Action(this.OnBeforeMotorModelLoad));
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnMotorModelReady));
	}

	// Token: 0x06017E12 RID: 97810 RVA: 0x00611F88 File Offset: 0x00610188
	protected override void OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.BeforeUiModelLoadStart, new Action(this.OnBeforeMotorModelLoad));
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnMotorModelReady));
		this.RemoveAllDecorationSkeletalObserver();
	}

	// Token: 0x06017E13 RID: 97811 RVA: 0x00611FDF File Offset: 0x006101DF
	public bool IsMotorModelLoaded()
	{
		UiModelDataComponent modelDataComponent = this.ModelDataComponent;
		return modelDataComponent != null && modelDataComponent.GetModelLoadState() == EUiModelLoadState.LoadComplete;
	}

	// Token: 0x06017E14 RID: 97812 RVA: 0x00611FF8 File Offset: 0x006101F8
	public SkeletalObserverHandle GetDecorationHandle(int decorationPart, int index)
	{
		List<SkeletalObserverHandle> list;
		if (this.MotorDecorationMap.TryGetValue(decorationPart, out list) && index >= 0 && index < list.Count)
		{
			return list[index];
		}
		return null;
	}

	// Token: 0x06017E15 RID: 97813 RVA: 0x0061202C File Offset: 0x0061022C
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

	// Token: 0x06017E16 RID: 97814 RVA: 0x00612074 File Offset: 0x00610274
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

	// Token: 0x06017E17 RID: 97815 RVA: 0x00612108 File Offset: 0x00610308
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

	// Token: 0x06017E18 RID: 97816 RVA: 0x006121A4 File Offset: 0x006103A4
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

	// Token: 0x06017E19 RID: 97817 RVA: 0x00612258 File Offset: 0x00610458
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

	// Token: 0x06017E1A RID: 97818 RVA: 0x00612297 File Offset: 0x00610497
	private void OnBeforeMotorModelLoad()
	{
		this.ShowAllDecoration(false);
	}

	// Token: 0x06017E1B RID: 97819 RVA: 0x006122A0 File Offset: 0x006104A0
	private void OnMotorModelReady()
	{
		this.ShowAllDecoration(true);
	}

	// Token: 0x0400B206 RID: 45574
	[Nullable(1)]
	private readonly Dictionary<int, List<SkeletalObserverHandle>> MotorDecorationMap = new Dictionary<int, List<SkeletalObserverHandle>>();

	// Token: 0x0400B207 RID: 45575
	private UiModelDataComponent ModelDataComponent;
}
