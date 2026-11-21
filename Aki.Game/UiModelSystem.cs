using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200221E RID: 8734
[NullableContext(1)]
[Nullable(0)]
public class UiModelSystem : Singleton
{
	// Token: 0x060157C9 RID: 88009 RVA: 0x0063D974 File Offset: 0x0063BB74
	public UiModelBase CreateUiModelByUseWay(EUiModelUseWay useWay, AActor actor)
	{
		UiModelCreateData createData = UiModelCreateDataPreDefine.GetUiModelCreateDataPreDefine()[useWay];
		return this.CreateUiModelByCreateData(createData, actor, useWay);
	}

	// Token: 0x060157CA RID: 88010 RVA: 0x0063D998 File Offset: 0x0063BB98
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

	// Token: 0x17002095 RID: 8341
	// (get) Token: 0x060157CB RID: 88011 RVA: 0x0063DA31 File Offset: 0x0063BC31
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

	// Token: 0x060157CC RID: 88012 RVA: 0x0063DA54 File Offset: 0x0063BC54
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060157CD RID: 88013 RVA: 0x0063DA56 File Offset: 0x0063BC56
	public static void ResetStaticDefaultValue()
	{
		UiModelSystem instance = UiModelSystem._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		UiModelSystem._instance = null;
	}

	// Token: 0x060157CE RID: 88014 RVA: 0x0063DA6F File Offset: 0x0063BC6F
	static UiModelSystem()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiModelSystem.CreateStaticDefaultValue), new Action(UiModelSystem.ResetStaticDefaultValue));
	}

	// Token: 0x0400B5F0 RID: 46576
	private int UiModelIncrementId;

	// Token: 0x0400B5F1 RID: 46577
	[Nullable(2)]
	private static UiModelSystem _instance;
}
