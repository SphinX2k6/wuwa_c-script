using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002CC5 RID: 11461
[NullableContext(1)]
[Nullable(0)]
public class UiModelSystem : Singleton
{
	// Token: 0x06017F50 RID: 98128 RVA: 0x00617CB4 File Offset: 0x00615EB4
	public UiModelBase CreateUiModelByUseWay(EUiModelUseWay useWay, AActor actor)
	{
		UiModelCreateData createData = UiModelCreateDataPreDefine.GetUiModelCreateDataPreDefine()[useWay];
		return this.CreateUiModelByCreateData(createData, actor, useWay);
	}

	// Token: 0x06017F51 RID: 98129 RVA: 0x00617CD8 File Offset: 0x00615ED8
	public UiModelBase CreateUiModelByCreateData(UiModelCreateData createData, AActor actor, EUiModelUseWay useWay)
	{
		int i = this.UiModelIncrementId;
		this.UiModelIncrementId = i + 1;
		UiModelBase uiModelBase = new UiModelBase(i, useWay);
		foreach (Type componentType in createData.Components)
		{
			uiModelBase.AddComponent(componentType);
		}
		UiModelDataComponent uiModelDataComponent = uiModelBase.CheckGetComponent<UiModelDataComponent>();
		if (uiModelDataComponent != null)
		{
			uiModelDataComponent.ModelType = new EUiModelType?(createData.ModelType);
			uiModelDataComponent.ModelActorType = new EUiModelActorType?(createData.ModelActorType);
			uiModelDataComponent.ModelUseWay = new EUiModelUseWay?(createData.ModelUseWay);
		}
		UiModelActorComponent uiModelActorComponent = uiModelBase.CheckGetComponent<UiModelActorComponent>();
		if (uiModelActorComponent != null)
		{
			uiModelActorComponent.Actor = actor;
		}
		return uiModelBase;
	}

	// Token: 0x17002044 RID: 8260
	// (get) Token: 0x06017F52 RID: 98130 RVA: 0x00617D71 File Offset: 0x00615F71
	public static UiModelSystem Instance
	{
		get
		{
			if (UiModelSystem._instance == null)
			{
				UiModelSystem._instance = new UiModelSystem();
				UiModelSystem._instance.OnInit();
			}
			return UiModelSystem._instance;
		}
	}

	// Token: 0x06017F53 RID: 98131 RVA: 0x00617D94 File Offset: 0x00615F94
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06017F54 RID: 98132 RVA: 0x00617D96 File Offset: 0x00615F96
	public static void ResetStaticDefaultValue()
	{
		UiModelSystem instance = UiModelSystem._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		UiModelSystem._instance = null;
	}

	// Token: 0x06017F55 RID: 98133 RVA: 0x00617DAF File Offset: 0x00615FAF
	static UiModelSystem()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiModelSystem.CreateStaticDefaultValue), new Action(UiModelSystem.ResetStaticDefaultValue));
	}

	// Token: 0x0400B285 RID: 45701
	private int UiModelIncrementId;

	// Token: 0x0400B286 RID: 45702
	[Nullable(2)]
	private static UiModelSystem _instance;
}
