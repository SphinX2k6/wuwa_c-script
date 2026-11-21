using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020027E9 RID: 10217
[NullableContext(1)]
[Nullable(0)]
public class UeComponentTickManageComponent : EntityComponent
{
	// Token: 0x1700293D RID: 10557
	// (get) Token: 0x06019B52 RID: 105298 RVA: 0x007EAC64 File Offset: 0x007E8E64
	public override Type[] Dependencies
	{
		get
		{
			return new Type[]
			{
				typeof(BaseActorComponent)
			};
		}
	}

	// Token: 0x06019B53 RID: 105299 RVA: 0x007EAC7C File Offset: 0x007E8E7C
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

	// Token: 0x06019B54 RID: 105300 RVA: 0x007EACD4 File Offset: 0x007E8ED4
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

	// Token: 0x06019B55 RID: 105301 RVA: 0x007EAE04 File Offset: 0x007E9004
	protected override void OnTick(float delta)
	{
		float customTimeDilation = base.Entity.GetComponent<BaseCharacterComponent>().Actor.CustomTimeDilation;
		float num = delta * 0.001f * customTimeDilation;
		foreach (UActorComponent uactorComponent in this.UeActorComps)
		{
			uactorComponent.KuroTickComponentOutside(num);
		}
	}

	// Token: 0x06019B56 RID: 105302 RVA: 0x007EAE78 File Offset: 0x007E9078
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		UeComponentTickManageComponent ueComponentTickManageComponent = (UeComponentTickManageComponent)componentTemplate;
		return (ueComponentTickManageComponent.Classes == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.Classes), "Classes")) && (ueComponentTickManageComponent.UeActorComps == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.UeActorComps), "UeActorComps"));
	}

	// Token: 0x1700293E RID: 10558
	// (get) Token: 0x06019B57 RID: 105303 RVA: 0x007EAEDC File Offset: 0x007E90DC
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700293F RID: 10559
	// (get) Token: 0x06019B58 RID: 105304 RVA: 0x007EAEDF File Offset: 0x007E90DF
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400E182 RID: 57730
	[Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	private readonly List<TWeakObjectPtr<UClass>> Classes = new List<TWeakObjectPtr<UClass>>();

	// Token: 0x0400E183 RID: 57731
	private readonly List<UActorComponent> UeActorComps = new List<UActorComponent>();
}
