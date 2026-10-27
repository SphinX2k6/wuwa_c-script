using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003279 RID: 12921
[NullableContext(1)]
[Nullable(0)]
public class UeComponentTickManageComponent : EntityComponent, IComponentDependency
{
	// Token: 0x17002697 RID: 9879
	// (get) Token: 0x0601BF64 RID: 114532 RVA: 0x007C3894 File Offset: 0x007C1A94
	public static Type[] Dependencies
	{
		get
		{
			return new Type[]
			{
				typeof(BaseActorComponent)
			};
		}
	}

	// Token: 0x0601BF65 RID: 114533 RVA: 0x007C38AC File Offset: 0x007C1AAC
	[NullableContext(2)]
	protected override bool OnInitData(IEntityArgs args = null)
	{
		CreateEntityData p = args.GetP1<CreateEntityData>();
		object obj = (p != null) ? p.GetParam<UeComponentTickManageComponent>() : null;
		if (obj != null)
		{
			foreach (TWeakObjectPtr<UClass> item in obj as TWeakObjectPtr<UClass>[])
			{
				if (item.IsValid(false, false))
				{
					this.Classes.Add(item);
				}
			}
		}
		return true;
	}

	// Token: 0x0601BF66 RID: 114534 RVA: 0x007C3904 File Offset: 0x007C1B04
	protected override void OnActivate()
	{
		BaseActorComponent component = base.Entity.GetComponent<BaseActorComponent>();
		if (this.Classes.Count > 0)
		{
			using (List<TWeakObjectPtr<UClass>>.Enumerator enumerator = this.Classes.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					TWeakObjectPtr<UClass> weakObjectPtr = enumerator.Current;
					TArray<UActorComponent> tarray = component.Owner.K2_GetComponentsByClass(weakObjectPtr.GetClass<UClass>());
					int num = tarray.Num();
					for (int i = 0; i < num; i++)
					{
						UActorComponent uactorComponent = tarray.Get(i);
						if (!(uactorComponent is USkeletalMeshComponent) && uactorComponent.IsComponentTickEnabled())
						{
							this.UeActorComps.Add(uactorComponent);
							uactorComponent.SetComponentTickEnabled(false);
						}
					}
				}
				return;
			}
		}
		TArray<UActorComponent> tarray2 = component.Owner.K2_GetComponentsByClass(UActorComponent.StaticClass());
		int num2 = tarray2.Num();
		for (int j = 0; j < num2; j++)
		{
			UActorComponent uactorComponent2 = tarray2.Get(j);
			if (!(uactorComponent2 is USkeletalMeshComponent) && uactorComponent2.IsComponentTickEnabled())
			{
				this.UeActorComps.Add(uactorComponent2);
				uactorComponent2.SetComponentTickEnabled(false);
			}
		}
	}

	// Token: 0x0601BF67 RID: 114535 RVA: 0x007C3A34 File Offset: 0x007C1C34
	protected override void OnTick(float delta)
	{
		float customTimeDilation = base.Entity.GetComponent<BaseCharacterComponent>().Actor.CustomTimeDilation;
		float num = delta * 0.001f * customTimeDilation;
		foreach (UActorComponent uactorComponent in this.UeActorComps)
		{
			uactorComponent.KuroTickComponentOutside(num);
		}
	}

	// Token: 0x0601BF68 RID: 114536 RVA: 0x007C3AA8 File Offset: 0x007C1CA8
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		UeComponentTickManageComponent ueComponentTickManageComponent = (UeComponentTickManageComponent)componentTemplate;
		return (!base.CanResetComponentProperty("Classes") || ueComponentTickManageComponent.Classes == null || base.CheckClearObject(EntityComponentSystem.ClearObject<List<TWeakObjectPtr<UClass>>>(this.Classes), "Classes")) && (!base.CanResetComponentProperty("UeActorComps") || ueComponentTickManageComponent.UeActorComps == null || base.CheckClearObject(EntityComponentSystem.ClearObject<List<UActorComponent>>(this.UeActorComps), "UeActorComps"));
	}

	// Token: 0x0400DCE0 RID: 56544
	[Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	private readonly List<TWeakObjectPtr<UClass>> Classes = new List<TWeakObjectPtr<UClass>>();

	// Token: 0x0400DCE1 RID: 56545
	private readonly List<UActorComponent> UeActorComps = new List<UActorComponent>();
}
