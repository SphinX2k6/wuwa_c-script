using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiNavigation.Enum;
using AkiClient.Game.Aki.Data.UiNavigation.Struct;
using CSharpScript.Game.Module.UiNavigation;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200221F RID: 8735
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Module/UiNavigation/New/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/UiNavigation/New/TsUiNavigationBehaviorListener.TsUiNavigationBehaviorListener_C")]
public class TsUiNavigationBehaviorListener : UUINavigationBehaviour, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002096 RID: 8342
	// (get) Token: 0x060157D0 RID: 88016 RVA: 0x0063DA96 File Offset: 0x0063BC96
	// (set) Token: 0x060157D1 RID: 88017 RVA: 0x0063DAAA File Offset: 0x0063BCAA
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string GroupName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsUiNavigationBehaviorListener.__PropertyOffset_GroupName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsUiNavigationBehaviorListener.__PropertyOffset_GroupName)), value);
		}
	}

	// Token: 0x17002097 RID: 8343
	// (get) Token: 0x060157D2 RID: 88018 RVA: 0x0063DAC0 File Offset: 0x0063BCC0
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<string> TagArray
	{
		get
		{
			base.FastCheckIsValid();
			TArray<string> result;
			if ((result = this._TagArray) == null)
			{
				result = (this._TagArray = new TArray<string>(base.NativePtr + (IntPtr)TsUiNavigationBehaviorListener.__PropertyOffset_TagArray, this));
			}
			return result;
		}
	}

	// Token: 0x17002098 RID: 8344
	// (get) Token: 0x060157D3 RID: 88019 RVA: 0x0063DAF9 File Offset: 0x0063BCF9
	// (set) Token: 0x060157D4 RID: 88020 RVA: 0x0063DB09 File Offset: 0x0063BD09
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int ExitTagPriority
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsUiNavigationBehaviorListener.__PropertyOffset_ExitTagPriority);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsUiNavigationBehaviorListener.__PropertyOffset_ExitTagPriority) = value;
		}
	}

	// Token: 0x17002099 RID: 8345
	// (get) Token: 0x060157D5 RID: 88021 RVA: 0x0063DB1C File Offset: 0x0063BD1C
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<int> ShieldHotKeyIndexArray
	{
		get
		{
			base.FastCheckIsValid();
			TArray<int> result;
			if ((result = this._ShieldHotKeyIndexArray) == null)
			{
				result = (this._ShieldHotKeyIndexArray = new TArray<int>(base.NativePtr + (IntPtr)TsUiNavigationBehaviorListener.__PropertyOffset_ShieldHotKeyIndexArray, this));
			}
			return result;
		}
	}

	// Token: 0x1700209A RID: 8346
	// (get) Token: 0x060157D6 RID: 88022 RVA: 0x0063DB55 File Offset: 0x0063BD55
	// (set) Token: 0x060157D7 RID: 88023 RVA: 0x0063DB69 File Offset: 0x0063BD69
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe AActor ScrollViewActor
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + TsUiNavigationBehaviorListener.__PropertyOffset_ScrollViewActor);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsUiNavigationBehaviorListener.__PropertyOffset_ScrollViewActor, value);
		}
	}

	// Token: 0x1700209B RID: 8347
	// (get) Token: 0x060157D8 RID: 88024 RVA: 0x0063DB7E File Offset: 0x0063BD7E
	// (set) Token: 0x060157D9 RID: 88025 RVA: 0x0063DB92 File Offset: 0x0063BD92
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe AUIBaseActor GridBaseActor
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<AUIBaseActor>(base.NativePtr / (IntPtr)sizeof(void*) + TsUiNavigationBehaviorListener.__PropertyOffset_GridBaseActor);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsUiNavigationBehaviorListener.__PropertyOffset_GridBaseActor, value);
		}
	}

	// Token: 0x1700209C RID: 8348
	// (get) Token: 0x060157DA RID: 88026 RVA: 0x0063DBA7 File Offset: 0x0063BDA7
	// (set) Token: 0x060157DB RID: 88027 RVA: 0x0063DBBB File Offset: 0x0063BDBB
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe AActor LayoutActor
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + TsUiNavigationBehaviorListener.__PropertyOffset_LayoutActor);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsUiNavigationBehaviorListener.__PropertyOffset_LayoutActor, value);
		}
	}

	// Token: 0x1700209D RID: 8349
	// (get) Token: 0x060157DC RID: 88028 RVA: 0x0063DBD0 File Offset: 0x0063BDD0
	[UProperty(EPropertyFlags.CPF_None)]
	public TMap<EHotKeyNameStateType, string> HotKeyTipsTextIdMap
	{
		get
		{
			base.FastCheckIsValid();
			TMap<EHotKeyNameStateType, string> result;
			if ((result = this._HotKeyTipsTextIdMap) == null)
			{
				result = (this._HotKeyTipsTextIdMap = new TMap<EHotKeyNameStateType, string>(base.NativePtr + (IntPtr)TsUiNavigationBehaviorListener.__PropertyOffset_HotKeyTipsTextIdMap, this));
			}
			return result;
		}
	}

	// Token: 0x1700209E RID: 8350
	// (get) Token: 0x060157DD RID: 88029 RVA: 0x0063DC09 File Offset: 0x0063BE09
	// (set) Token: 0x060157DE RID: 88030 RVA: 0x0063DC1D File Offset: 0x0063BE1D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector2D ClickPivot
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsUiNavigationBehaviorListener.__PropertyOffset_ClickPivot);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsUiNavigationBehaviorListener.__PropertyOffset_ClickPivot) = value;
		}
	}

	// Token: 0x1700209F RID: 8351
	// (get) Token: 0x060157DF RID: 88031 RVA: 0x0063DC32 File Offset: 0x0063BE32
	// (set) Token: 0x060157E0 RID: 88032 RVA: 0x0063DC46 File Offset: 0x0063BE46
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe AActor InsideGroupActor
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + TsUiNavigationBehaviorListener.__PropertyOffset_InsideGroupActor);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsUiNavigationBehaviorListener.__PropertyOffset_InsideGroupActor, value);
		}
	}

	// Token: 0x170020A0 RID: 8352
	// (get) Token: 0x060157E1 RID: 88033 RVA: 0x0063DC5C File Offset: 0x0063BE5C
	[UProperty(EPropertyFlags.CPF_None)]
	public TMap<string, AActor> InsideActorMap
	{
		get
		{
			base.FastCheckIsValid();
			TMap<string, AActor> result;
			if ((result = this._InsideActorMap) == null)
			{
				result = (this._InsideActorMap = new TMap<string, AActor>(base.NativePtr + (IntPtr)TsUiNavigationBehaviorListener.__PropertyOffset_InsideActorMap, this));
			}
			return result;
		}
	}

	// Token: 0x170020A1 RID: 8353
	// (get) Token: 0x060157E2 RID: 88034 RVA: 0x0063DC95 File Offset: 0x0063BE95
	// (set) Token: 0x060157E3 RID: 88035 RVA: 0x0063DCA5 File Offset: 0x0063BEA5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float ScrollbarIndex
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsUiNavigationBehaviorListener.__PropertyOffset_ScrollbarIndex);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsUiNavigationBehaviorListener.__PropertyOffset_ScrollbarIndex) = value;
		}
	}

	// Token: 0x170020A2 RID: 8354
	// (get) Token: 0x060157E4 RID: 88036 RVA: 0x0063DCB6 File Offset: 0x0063BEB6
	// (set) Token: 0x060157E5 RID: 88037 RVA: 0x0063DCCA File Offset: 0x0063BECA
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string InteractiveTag
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsUiNavigationBehaviorListener.__PropertyOffset_InteractiveTag)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsUiNavigationBehaviorListener.__PropertyOffset_InteractiveTag)), value);
		}
	}

	// Token: 0x170020A3 RID: 8355
	// (get) Token: 0x060157E6 RID: 88038 RVA: 0x0063DCE0 File Offset: 0x0063BEE0
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<string> InteractiveParam
	{
		get
		{
			base.FastCheckIsValid();
			TArray<string> result;
			if ((result = this._InteractiveParam) == null)
			{
				result = (this._InteractiveParam = new TArray<string>(base.NativePtr + (IntPtr)TsUiNavigationBehaviorListener.__PropertyOffset_InteractiveParam, this));
			}
			return result;
		}
	}

	// Token: 0x170020A4 RID: 8356
	// (get) Token: 0x060157E7 RID: 88039 RVA: 0x0063DD19 File Offset: 0x0063BF19
	// (set) Token: 0x060157E8 RID: 88040 RVA: 0x0063DD2D File Offset: 0x0063BF2D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string DynamicTag
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsUiNavigationBehaviorListener.__PropertyOffset_DynamicTag)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsUiNavigationBehaviorListener.__PropertyOffset_DynamicTag)), value);
		}
	}

	// Token: 0x170020A5 RID: 8357
	// (get) Token: 0x060157E9 RID: 88041 RVA: 0x0063DD42 File Offset: 0x0063BF42
	// (set) Token: 0x060157EA RID: 88042 RVA: 0x0063DD52 File Offset: 0x0063BF52
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool OpenAdsorbed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsUiNavigationBehaviorListener.__PropertyOffset_OpenAdsorbed) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsUiNavigationBehaviorListener.__PropertyOffset_OpenAdsorbed) = (value ? 1 : 0);
		}
	}

	// Token: 0x170020A6 RID: 8358
	// (get) Token: 0x060157EB RID: 88043 RVA: 0x0063DD63 File Offset: 0x0063BF63
	// (set) Token: 0x060157EC RID: 88044 RVA: 0x0063DD73 File Offset: 0x0063BF73
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float AdsorbedDistance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsUiNavigationBehaviorListener.__PropertyOffset_AdsorbedDistance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsUiNavigationBehaviorListener.__PropertyOffset_AdsorbedDistance) = value;
		}
	}

	// Token: 0x170020A7 RID: 8359
	// (get) Token: 0x060157ED RID: 88045 RVA: 0x0063DD84 File Offset: 0x0063BF84
	// (set) Token: 0x060157EE RID: 88046 RVA: 0x0063DD98 File Offset: 0x0063BF98
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector2D AdsorbedPivot
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsUiNavigationBehaviorListener.__PropertyOffset_AdsorbedPivot);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsUiNavigationBehaviorListener.__PropertyOffset_AdsorbedPivot) = value;
		}
	}

	// Token: 0x170020A8 RID: 8360
	// (get) Token: 0x060157EF RID: 88047 RVA: 0x0063DDAD File Offset: 0x0063BFAD
	// (set) Token: 0x060157F0 RID: 88048 RVA: 0x0063DDBD File Offset: 0x0063BFBD
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsUseDrag
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsUiNavigationBehaviorListener.__PropertyOffset_IsUseDrag) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsUiNavigationBehaviorListener.__PropertyOffset_IsUseDrag) = (value ? 1 : 0);
		}
	}

	// Token: 0x170020A9 RID: 8361
	// (get) Token: 0x060157F1 RID: 88049 RVA: 0x0063DDCE File Offset: 0x0063BFCE
	// (set) Token: 0x060157F2 RID: 88050 RVA: 0x0063DDDE File Offset: 0x0063BFDE
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsUsePool
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsUiNavigationBehaviorListener.__PropertyOffset_IsUsePool) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsUiNavigationBehaviorListener.__PropertyOffset_IsUsePool) = (value ? 1 : 0);
		}
	}

	// Token: 0x170020AA RID: 8362
	// (get) Token: 0x060157F3 RID: 88051 RVA: 0x0063DDEF File Offset: 0x0063BFEF
	// (set) Token: 0x060157F4 RID: 88052 RVA: 0x0063DDFF File Offset: 0x0063BFFF
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float NavigateTolerance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsUiNavigationBehaviorListener.__PropertyOffset_NavigateTolerance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsUiNavigationBehaviorListener.__PropertyOffset_NavigateTolerance) = value;
		}
	}

	// Token: 0x170020AB RID: 8363
	// (get) Token: 0x060157F5 RID: 88053 RVA: 0x0063DE10 File Offset: 0x0063C010
	// (set) Token: 0x060157F6 RID: 88054 RVA: 0x0063DE20 File Offset: 0x0063C020
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float NavigateToleranceReverse
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsUiNavigationBehaviorListener.__PropertyOffset_NavigateToleranceReverse);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsUiNavigationBehaviorListener.__PropertyOffset_NavigateToleranceReverse) = value;
		}
	}

	// Token: 0x060157F7 RID: 88055 RVA: 0x0063DE34 File Offset: 0x0063C034
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void AwakeBP()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsUiNavigationBehaviorListener) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AwakeBP"), TsUiNavigationBehaviorListener.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.AwakeBP_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x060157F8 RID: 88056 RVA: 0x0063DE8D File Offset: 0x0063C08D
	protected virtual void AwakeBP_Implementation()
	{
		if (GlobalData.GameInstance == null)
		{
			return;
		}
		this.InstanceId = UiNavigationGlobalData.GetListenerInstanceId();
		this.AwakeInit();
	}

	// Token: 0x060157F9 RID: 88057 RVA: 0x0063DEA8 File Offset: 0x0063C0A8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void StartBP()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsUiNavigationBehaviorListener) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("StartBP"), TsUiNavigationBehaviorListener.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.StartBP_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x060157FA RID: 88058 RVA: 0x0063DF01 File Offset: 0x0063C101
	protected virtual void StartBP_Implementation()
	{
		if (GlobalData.GameInstance == null)
		{
			return;
		}
		this.StartInit();
	}

	// Token: 0x060157FB RID: 88059 RVA: 0x0063DF14 File Offset: 0x0063C114
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void OnNotifyNavigationEnterBP(ULGUIPointerEventData eventData)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsUiNavigationBehaviorListener) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnNotifyNavigationEnterBP"), TsUiNavigationBehaviorListener.StaticClass(), out intPtr, out num))
		{
			this.OnNotifyNavigationEnterBP_Implementation(eventData);
			return;
		}
		UUINavigationBehaviour.__OnNotifyNavigationEnterBP_FunctionParams* ptr = stackalloc UUINavigationBehaviour.__OnNotifyNavigationEnterBP_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UUINavigationBehaviour.__OnNotifyNavigationEnterBP_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->eventData) = ((eventData != null) ? eventData.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x060157FC RID: 88060 RVA: 0x0063DFB0 File Offset: 0x0063C1B0
	[NullableContext(2)]
	protected virtual void OnNotifyNavigationEnterBP_Implementation(ULGUIPointerEventData eventData)
	{
		if (GlobalData.GameInstance == null)
		{
			return;
		}
		if (StringUtils.IsBlank(this.GroupName))
		{
			return;
		}
		TsUiNavigationPanelConfig panelConfig = this.PanelConfig;
		if (panelConfig == null || !panelConfig.IsAllowNavigate())
		{
			return;
		}
		if (eventData == null)
		{
			return;
		}
		if (!this.GetNavigationComponent().HandlePointerEnter(eventData))
		{
			return;
		}
		this.SetListenerInNavigation();
	}

	// Token: 0x060157FD RID: 88061 RVA: 0x0063E004 File Offset: 0x0063C204
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void OnNotifyNavigationSelectBP(ULGUIPointerEventData eventData)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsUiNavigationBehaviorListener) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnNotifyNavigationSelectBP"), TsUiNavigationBehaviorListener.StaticClass(), out intPtr, out num))
		{
			this.OnNotifyNavigationSelectBP_Implementation(eventData);
			return;
		}
		UUINavigationBehaviour.__OnNotifyNavigationSelectBP_FunctionParams* ptr = stackalloc UUINavigationBehaviour.__OnNotifyNavigationSelectBP_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UUINavigationBehaviour.__OnNotifyNavigationSelectBP_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->eventData) = ((eventData != null) ? eventData.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x060157FE RID: 88062 RVA: 0x0063E0A0 File Offset: 0x0063C2A0
	[NullableContext(2)]
	protected virtual void OnNotifyNavigationSelectBP_Implementation(ULGUIPointerEventData eventData)
	{
		if (GlobalData.GameInstance == null)
		{
			return;
		}
		if (StringUtils.IsBlank(this.GroupName))
		{
			return;
		}
		TsUiNavigationPanelConfig panelConfig = this.PanelConfig;
		if (panelConfig == null || !panelConfig.IsAllowNavigate())
		{
			return;
		}
		if (eventData == null)
		{
			return;
		}
		if (!this.GetNavigationComponent().HandlePointerSelect(eventData))
		{
			UiNavigationLogic.UpdateSameNavigationListener(this);
			return;
		}
		this.SetListenerInNavigation();
	}

	// Token: 0x060157FF RID: 88063 RVA: 0x0063E0FC File Offset: 0x0063C2FC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool OnCheckCanSetNavigationBP()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsUiNavigationBehaviorListener) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnCheckCanSetNavigationBP"), TsUiNavigationBehaviorListener.StaticClass(), out intPtr, out num))
		{
			return this.OnCheckCanSetNavigationBP_Implementation();
		}
		UUINavigationBehaviour.__OnCheckCanSetNavigationBP_FunctionParams* ptr = stackalloc UUINavigationBehaviour.__OnCheckCanSetNavigationBP_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UUINavigationBehaviour.__OnCheckCanSetNavigationBP_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06015800 RID: 88064 RVA: 0x0063E188 File Offset: 0x0063C388
	protected virtual bool OnCheckCanSetNavigationBP_Implementation()
	{
		if (this.ScrollProxy == null)
		{
			return this.InNavigation;
		}
		if (!this.ScrollProxy.HasLoopScrollView())
		{
			return this.InNavigation;
		}
		int loopScrollViewNavigationIndex = this.ScrollProxy.GetLoopScrollViewNavigationIndex();
		if (loopScrollViewNavigationIndex == -1)
		{
			return this.InNavigation;
		}
		if (UiNavigationGlobalData.IsAllowLoopScrollInteractHighlight)
		{
			return loopScrollViewNavigationIndex == base.LoopScrollViewGridIndex && this.InNavigation;
		}
		return loopScrollViewNavigationIndex != base.LoopScrollViewGridIndex && this.InNavigation;
	}

	// Token: 0x06015801 RID: 88065 RVA: 0x0063E1FC File Offset: 0x0063C3FC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool OnCheckLoopScrollChangeNavigationBP()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsUiNavigationBehaviorListener) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnCheckLoopScrollChangeNavigationBP"), TsUiNavigationBehaviorListener.StaticClass(), out intPtr, out num))
		{
			return this.OnCheckLoopScrollChangeNavigationBP_Implementation();
		}
		UUINavigationBehaviour.__OnCheckLoopScrollChangeNavigationBP_FunctionParams* ptr = stackalloc UUINavigationBehaviour.__OnCheckLoopScrollChangeNavigationBP_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UUINavigationBehaviour.__OnCheckLoopScrollChangeNavigationBP_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06015802 RID: 88066 RVA: 0x0063E286 File Offset: 0x0063C486
	protected virtual bool OnCheckLoopScrollChangeNavigationBP_Implementation()
	{
		return this.ScrollProxy != null && this.ScrollProxy.CheckLoopScrollChangeNavigation();
	}

	// Token: 0x06015803 RID: 88067 RVA: 0x0063E2A0 File Offset: 0x0063C4A0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void OnEnableBP()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsUiNavigationBehaviorListener) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnEnableBP"), TsUiNavigationBehaviorListener.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.OnEnableBP_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06015804 RID: 88068 RVA: 0x0063E2F9 File Offset: 0x0063C4F9
	protected virtual void OnEnableBP_Implementation()
	{
		if (GlobalData.GameInstance == null)
		{
			return;
		}
		this.TryReStartInit();
		UiNavigationViewManager.Instance.RefreshCurrentHotKey();
		this.RefreshPanelConfig();
		this.TryFindScrollbar();
	}

	// Token: 0x06015805 RID: 88069 RVA: 0x0063E320 File Offset: 0x0063C520
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void OnDisableBP()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsUiNavigationBehaviorListener) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnDisableBP"), TsUiNavigationBehaviorListener.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.OnDisableBP_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06015806 RID: 88070 RVA: 0x0063E379 File Offset: 0x0063C579
	protected virtual void OnDisableBP_Implementation()
	{
		if (GlobalData.GameInstance == null)
		{
			return;
		}
		UiNavigationViewManager.Instance.RefreshCurrentHotKey();
		this.DisActiveHandle();
	}

	// Token: 0x06015807 RID: 88071 RVA: 0x0063E394 File Offset: 0x0063C594
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void OnNotifyInteractiveBP()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsUiNavigationBehaviorListener) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnNotifyInteractiveBP"), TsUiNavigationBehaviorListener.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.OnNotifyInteractiveBP_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06015808 RID: 88072 RVA: 0x0063E3ED File Offset: 0x0063C5ED
	protected virtual void OnNotifyInteractiveBP_Implementation()
	{
		if (GlobalData.GameInstance == null)
		{
			return;
		}
		this.GetNavigationComponent().SetIsInteractive(true);
		UiNavigationViewManager.Instance.RefreshCurrentHotKey();
	}

	// Token: 0x06015809 RID: 88073 RVA: 0x0063E410 File Offset: 0x0063C610
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void OnNotifyNotInteractiveBP()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsUiNavigationBehaviorListener) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnNotifyNotInteractiveBP"), TsUiNavigationBehaviorListener.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.OnNotifyNotInteractiveBP_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601580A RID: 88074 RVA: 0x0063E469 File Offset: 0x0063C669
	protected virtual void OnNotifyNotInteractiveBP_Implementation()
	{
		if (GlobalData.GameInstance == null)
		{
			return;
		}
		this.GetNavigationComponent().SetIsInteractive(false);
		UiNavigationViewManager.Instance.RefreshCurrentHotKey();
		this.DisActiveHandle();
	}

	// Token: 0x0601580B RID: 88075 RVA: 0x0063E490 File Offset: 0x0063C690
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void OnPreDestroyBP()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsUiNavigationBehaviorListener) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnPreDestroyBP"), TsUiNavigationBehaviorListener.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.OnPreDestroyBP_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601580C RID: 88076 RVA: 0x0063E4EC File Offset: 0x0063C6EC
	protected virtual void OnPreDestroyBP_Implementation()
	{
		if (GlobalData.GameInstance == null)
		{
			return;
		}
		this.DisActiveHandle();
		this.UnBindLoopScrollView();
		this.UnRegisterListenerToPanel();
		NavigationSelectableBase navigationComponent = this.NavigationComponent;
		if (navigationComponent != null)
		{
			navigationComponent.Clear();
		}
		this.PanelConfig = null;
		this.LayoutBase = null;
		this.ScrollProxy = null;
	}

	// Token: 0x0601580D RID: 88077 RVA: 0x0063E53C File Offset: 0x0063C73C
	private void AwakeInit()
	{
		if (this.IsAwakeCalled)
		{
			return;
		}
		this.InNavigation = false;
		this.ModeModule = new UiNavigationModeModule(this);
		this.CursorModule = new UiNavigationCursorModule(this.Cursor);
		this.ChildTagMap = new Dictionary<string, TsUiNavigationBehaviorListener>();
		this.CreateNavigationComponent();
		this.RegisterListenerToPanel();
		this.IsAwakeCalled = true;
	}

	// Token: 0x0601580E RID: 88078 RVA: 0x0063E594 File Offset: 0x0063C794
	private void StartInit()
	{
		if (this.IsStartCalled)
		{
			return;
		}
		this.SetTextChangeComponent();
		this.InitInsideGroupActor();
		this.NotifyParentListener(this);
		this.RegisterListenerToPanel();
		this.InitScrollViewAndLayout();
		UiNavigationViewManager.Instance.RefreshCurrentHotKey();
		this.RefreshPanelConfig();
		this.IsStartCalled = true;
	}

	// Token: 0x0601580F RID: 88079 RVA: 0x0063E5E0 File Offset: 0x0063C7E0
	private unsafe void TryReStartInit()
	{
		if (!this.IsUsePool)
		{
			return;
		}
		if (!this.IsStartCalled)
		{
			return;
		}
		if (this.PanelConfig == null)
		{
			return;
		}
		UUIItem uuiitem = this.PanelConfig.RootUIComp.Get();
		if (this.PanelConfig.IsValid() && uuiitem != null && uuiitem.IsValid())
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.UiNavigation;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "可能存在从对象池获取的情况[TsUiNavigationBehaviorListener]";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("GroupName", this.GroupName);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Name", base.RootUIComp.Get().displayName);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		this.IsStartCalled = false;
		this.ScrollProxy = null;
		this.IsInitLayout = false;
		this.PanelConfig = null;
		this.StartInit();
	}

	// Token: 0x06015810 RID: 88080 RVA: 0x0063E6C4 File Offset: 0x0063C8C4
	private void InitScrollViewAndLayout()
	{
		this.InitScrollView();
		this.InitLayout();
	}

	// Token: 0x06015811 RID: 88081 RVA: 0x0063E6D4 File Offset: 0x0063C8D4
	private void InitAnimController()
	{
		if (this.IsInitAnimController)
		{
			return;
		}
		this.IsInitAnimController = true;
		if (this.ScrollProxy != null)
		{
			this.AnimController = this.ScrollProxy.GetInturnAnimController();
		}
		if (this.LayoutBase != null)
		{
			UUILayoutBase layoutBase = this.LayoutBase;
			this.AnimController = (((layoutBase != null) ? layoutBase.GetOwner().GetComponentByClass(UUIInturnAnimController.StaticClass()) : null) as UUIInturnAnimController);
		}
	}

	// Token: 0x06015812 RID: 88082 RVA: 0x0063E740 File Offset: 0x0063C940
	private void InitScrollView()
	{
		if (this.ScrollViewActor == null)
		{
			return;
		}
		if (this.ScrollProxy != null)
		{
			return;
		}
		this.ScrollProxy = new UiNavigationScrollProxy();
		this.ScrollProxy.InitScrollView(this.ScrollViewActor, this);
		this.DynamicGridActor = this.ScrollProxy.GetDynamicGridActor();
		this.BindLoopScrollView();
		if (this.ScrollProxy.ScrollView != null)
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.UiNavigation;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "找不到滚动列表组件";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("节点", base.RootUIComp.Get().displayName);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x06015813 RID: 88083 RVA: 0x0063E7E0 File Offset: 0x0063C9E0
	private void InitLayout()
	{
		if (this.LayoutActor == null)
		{
			return;
		}
		if (this.IsInitLayout)
		{
			return;
		}
		this.LayoutBase = (this.LayoutActor.GetComponentByClass(UUILayoutBase.StaticClass()) as UUILayoutBase);
		this.IsInitLayout = true;
		if (this.LayoutBase != null)
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.UiNavigation;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "找不到循环滚动列表组件";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("节点", base.RootUIComp.Get().displayName);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x06015814 RID: 88084 RVA: 0x0063E86B File Offset: 0x0063CA6B
	private void TryFindScrollbar()
	{
		if (this.PanelConfig == null)
		{
			return;
		}
		this.PanelConfig.TryFindScrollbar();
	}

	// Token: 0x06015815 RID: 88085 RVA: 0x0063E881 File Offset: 0x0063CA81
	private void DisActiveHandle()
	{
		if (this.PanelConfig == null)
		{
			return;
		}
		if (this.InNavigation)
		{
			this.InNavigation = false;
			this.PanelConfig.ReFindNavigation();
		}
		if (this.IsFocusScrollbar)
		{
			this.PanelConfig.ReFindScrollbar();
		}
	}

	// Token: 0x06015816 RID: 88086 RVA: 0x0063E8B9 File Offset: 0x0063CAB9
	private void SetTextChangeComponent()
	{
		AActor owner = base.GetOwner();
		this.TextChangeComponent = (((owner != null) ? owner.GetComponentByClass(TsUiNavigationTextChangeListener.StaticClass()) : null) as TsUiNavigationTextChangeListener);
	}

	// Token: 0x06015817 RID: 88087 RVA: 0x0063E8E4 File Offset: 0x0063CAE4
	private void NotifyParentListener(TsUiNavigationBehaviorListener listener)
	{
		TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = UiNavigationLogic.FindUpNavigationListener(base.GetOwner());
		if (tsUiNavigationBehaviorListener == null)
		{
			return;
		}
		tsUiNavigationBehaviorListener.RegisterChildListener(listener);
	}

	// Token: 0x06015818 RID: 88088 RVA: 0x0063E908 File Offset: 0x0063CB08
	public void RegisterChildListener(TsUiNavigationBehaviorListener listener)
	{
		TArray<string> tagArray = listener.TagArray;
		if (tagArray != null)
		{
			int i = 0;
			int num = tagArray.Num();
			while (i < num)
			{
				string text = tagArray.Get(i);
				if (text != null)
				{
					this.ChildTagMap[text] = listener;
				}
				i++;
			}
		}
		this.NotifyParentListener(listener);
	}

	// Token: 0x06015819 RID: 88089 RVA: 0x0063E951 File Offset: 0x0063CB51
	private void InitInsideGroupActor()
	{
		if (this.InsideGroupActor != null)
		{
			return;
		}
		this.InsideGroupActor = base.GetOwner();
	}

	// Token: 0x0601581A RID: 88090 RVA: 0x0063E968 File Offset: 0x0063CB68
	private void BindLoopScrollView()
	{
		if (this.ScrollProxy == null)
		{
			return;
		}
		UUISelectableComponent selectableComponent = this.GetSelectableComponent();
		this.ScrollProxy.BindScrollView(selectableComponent);
	}

	// Token: 0x0601581B RID: 88091 RVA: 0x0063E994 File Offset: 0x0063CB94
	private void UnBindLoopScrollView()
	{
		if (this.ScrollProxy == null)
		{
			return;
		}
		UUISelectableComponent selectableComponent = this.GetSelectableComponent();
		this.ScrollProxy.UnBindScrollView(selectableComponent);
	}

	// Token: 0x0601581C RID: 88092 RVA: 0x0063E9BD File Offset: 0x0063CBBD
	public bool HasNormalScrollView()
	{
		return this.ScrollProxy != null && this.ScrollProxy.HasNormalScrollView();
	}

	// Token: 0x0601581D RID: 88093 RVA: 0x0063E9D4 File Offset: 0x0063CBD4
	public bool HasLoopScrollView()
	{
		return this.ScrollProxy != null && this.ScrollProxy.HasLoopScrollView();
	}

	// Token: 0x0601581E RID: 88094 RVA: 0x0063E9EB File Offset: 0x0063CBEB
	public bool HasDynamicScrollView()
	{
		return this.ScrollProxy != null && this.ScrollProxy.HasDynamicScrollView();
	}

	// Token: 0x0601581F RID: 88095 RVA: 0x0063EA02 File Offset: 0x0063CC02
	public bool HasMultiTemplateScrollView()
	{
		return this.ScrollProxy != null && this.ScrollProxy.HasMultiTemplateScrollView();
	}

	// Token: 0x06015820 RID: 88096 RVA: 0x0063EA19 File Offset: 0x0063CC19
	private void RegisterListenerToPanel()
	{
		if (this.PanelConfig != null)
		{
			return;
		}
		this.PanelConfig = UiNavigationLogic.FindUiNavigationPanelConfig(base.GetOwner());
		if (this.PanelConfig == null)
		{
			return;
		}
		this.PanelConfig.RegisterNavigationListener(this);
		this.PanelConfig.DynamicListenerConfigHandle(this);
	}

	// Token: 0x06015821 RID: 88097 RVA: 0x0063EA56 File Offset: 0x0063CC56
	private void UnRegisterListenerToPanel()
	{
		if (this.PanelConfig == null)
		{
			return;
		}
		this.PanelConfig.UnRegisterNavigationListener(this);
	}

	// Token: 0x06015822 RID: 88098 RVA: 0x0063EA6D File Offset: 0x0063CC6D
	private void RefreshPanelConfig()
	{
		if (StringUtils.IsBlank(this.GroupName))
		{
			return;
		}
		if (this.PanelConfig == null)
		{
			return;
		}
		this.PanelConfig.FindNavigationInNoneState();
	}

	// Token: 0x06015823 RID: 88099 RVA: 0x0063EA94 File Offset: 0x0063CC94
	private void CreateNavigationComponent()
	{
		if (this.NavigationComponent != null)
		{
			return;
		}
		List<string> list = new List<string>();
		if (this.InteractiveParam != null)
		{
			int i = 0;
			int num = this.InteractiveParam.Num();
			while (i < num)
			{
				string text = this.InteractiveParam.Get(i);
				if (!string.IsNullOrEmpty(text))
				{
					list.Add(text);
				}
				i++;
			}
		}
		this.NavigationComponent = NavigationSelectableCreator.CreateNavigationBehavior(base.GetOwner(), this.InteractiveTag, list);
		NavigationSelectableBase navigationComponent = this.NavigationComponent;
		if (navigationComponent != null)
		{
			navigationComponent.SetListener(this);
		}
		NavigationSelectableBase navigationComponent2 = this.NavigationComponent;
		if (navigationComponent2 == null)
		{
			return;
		}
		navigationComponent2.Init();
	}

	// Token: 0x06015824 RID: 88100 RVA: 0x0063EB26 File Offset: 0x0063CD26
	public NavigationSelectableBase GetNavigationComponent()
	{
		if (this.NavigationComponent == null)
		{
			this.CreateNavigationComponent();
		}
		return this.NavigationComponent;
	}

	// Token: 0x06015825 RID: 88101 RVA: 0x0063EB3C File Offset: 0x0063CD3C
	[NullableContext(2)]
	public UUISelectableComponent GetSelectableComponent()
	{
		return this.GetBehaviorComponent() as UUISelectableComponent;
	}

	// Token: 0x06015826 RID: 88102 RVA: 0x0063EB49 File Offset: 0x0063CD49
	public ULGUIBehaviour GetBehaviorComponent()
	{
		return this.GetNavigationComponent().GetSelectable();
	}

	// Token: 0x06015827 RID: 88103 RVA: 0x0063EB56 File Offset: 0x0063CD56
	[NullableContext(2)]
	public USceneComponent GetSceneComponent()
	{
		return this.GetBehaviorComponent().GetRootComponent();
	}

	// Token: 0x06015828 RID: 88104 RVA: 0x0063EB64 File Offset: 0x0063CD64
	[return: Nullable(2)]
	public TsUiNavigationBehaviorListener GetChildListenerByTag(string tag)
	{
		TsUiNavigationBehaviorListener result;
		if (this.ChildTagMap == null || !this.ChildTagMap.TryGetValue(tag, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x06015829 RID: 88105 RVA: 0x0063EB8C File Offset: 0x0063CD8C
	public bool IsScrollOrLayoutActor()
	{
		this.InitScrollViewAndLayout();
		UiNavigationScrollProxy scrollProxy = this.ScrollProxy;
		return ((scrollProxy != null) ? scrollProxy.ScrollView : null) != null || this.LayoutBase != null;
	}

	// Token: 0x0601582A RID: 88106 RVA: 0x0063EBB3 File Offset: 0x0063CDB3
	[NullableContext(2)]
	public AActor GetScrollOrLayoutActor()
	{
		if (this.ScrollViewActor != null)
		{
			return this.ScrollViewActor;
		}
		if (this.LayoutActor != null)
		{
			return this.LayoutActor;
		}
		return null;
	}

	// Token: 0x0601582B RID: 88107 RVA: 0x0063EBD4 File Offset: 0x0063CDD4
	public bool IsScrollOrLayoutActive()
	{
		this.InitScrollViewAndLayout();
		if (this.ScrollProxy != null)
		{
			return this.ScrollProxy.IsScrollViewActive();
		}
		return this.LayoutBase != null && this.LayoutBase.RootUIComp.Get().IsUIActiveInHierarchy();
	}

	// Token: 0x0601582C RID: 88108 RVA: 0x0063EC1D File Offset: 0x0063CE1D
	public bool IsInScrollOrLayoutAnimation()
	{
		this.InitAnimController();
		UUIInturnAnimController animController = this.AnimController;
		return animController != null && animController.IsPlaying();
	}

	// Token: 0x0601582D RID: 88109 RVA: 0x0063EC36 File Offset: 0x0063CE36
	public bool IsInNormalScrollDisplayByGridActor()
	{
		return !this.HasNormalScrollView() || this.GridBaseActor == null || this.ScrollProxy.IsInNormalScrollDisplayByGridActor(this.GridBaseActor);
	}

	// Token: 0x0601582E RID: 88110 RVA: 0x0063EC5D File Offset: 0x0063CE5D
	public bool IsInLoopScrollDisplay()
	{
		return this.ScrollProxy == null || this.ScrollProxy.IsInLoopScrollDisplay(base.LoopScrollViewGridIndex);
	}

	// Token: 0x0601582F RID: 88111 RVA: 0x0063EC7A File Offset: 0x0063CE7A
	public bool IsInLoopScrollDisplayByGridActor()
	{
		return this.ScrollProxy == null || this.ScrollProxy.IsInLoopScrollDisplayByGridActor(this.GridBaseActor);
	}

	// Token: 0x06015830 RID: 88112 RVA: 0x0063EC97 File Offset: 0x0063CE97
	public bool IsInDynScrollDisplay()
	{
		return this.ScrollProxy == null || this.ScrollProxy.IsInDynScrollDisplay(this.GridBaseActor);
	}

	// Token: 0x06015831 RID: 88113 RVA: 0x0063ECB4 File Offset: 0x0063CEB4
	public bool IsInScrollDisplayByGridActor()
	{
		return this.ScrollProxy == null || this.ScrollProxy.IsScrollDisplayByGridActor(this.GridBaseActor);
	}

	// Token: 0x06015832 RID: 88114 RVA: 0x0063ECD4 File Offset: 0x0063CED4
	public bool IsInScrollOrLayoutCanFocus()
	{
		NavigationSelectableBase navigationComponent = this.GetNavigationComponent();
		return navigationComponent != null && navigationComponent.CanFocusInScrollOrLayout();
	}

	// Token: 0x06015833 RID: 88115 RVA: 0x0063ECF4 File Offset: 0x0063CEF4
	public bool IsCanFocus()
	{
		NavigationSelectableBase navigationComponent = this.GetNavigationComponent();
		return navigationComponent != null && navigationComponent.CanFocus();
	}

	// Token: 0x06015834 RID: 88116 RVA: 0x0063ED13 File Offset: 0x0063CF13
	public bool IsRegisterToPanelConfig()
	{
		return this.IsStartCalled;
	}

	// Token: 0x06015835 RID: 88117 RVA: 0x0063ED1C File Offset: 0x0063CF1C
	public bool IsListenerActive()
	{
		NavigationSelectableBase navigationComponent = this.GetNavigationComponent();
		return navigationComponent != null && navigationComponent.IsActive();
	}

	// Token: 0x06015836 RID: 88118 RVA: 0x0063ED3C File Offset: 0x0063CF3C
	public bool IsIgnoreScrollOrLayoutCheckInSwitchGroup()
	{
		NavigationSelectableBase navigationComponent = this.GetNavigationComponent();
		return navigationComponent != null && navigationComponent.IsIgnoreScrollOrLayoutCheckInSwitchGroup();
	}

	// Token: 0x06015837 RID: 88119 RVA: 0x0063ED5B File Offset: 0x0063CF5B
	public void ResetNavigationState()
	{
		this.InNavigation = false;
		TsUiNavigationPanelConfig panelConfig = this.PanelConfig;
		if (panelConfig != null)
		{
			UiNavigationViewHandle viewHandle = panelConfig.ViewHandle;
			if (viewHandle != null)
			{
				viewHandle.ResetNavigationDirty(this.InstanceId);
			}
		}
		this.UpdateNavigationState();
		this.UpdateLoopNavigationIndex(-1);
		this.NotifyUnFocusListener();
	}

	// Token: 0x06015838 RID: 88120 RVA: 0x0063ED99 File Offset: 0x0063CF99
	public void ActiveNavigationState(bool isSameListener)
	{
		this.InNavigation = true;
		this.UpdateNavigationState();
		this.UpdateLoopNavigationIndex(base.LoopScrollViewGridIndex);
		this.NotifyFocusListener(isSameListener);
	}

	// Token: 0x06015839 RID: 88121 RVA: 0x0063EDBC File Offset: 0x0063CFBC
	private void UpdateNavigationState()
	{
		ULGUIBehaviour behaviorComponent = this.GetBehaviorComponent();
		if (behaviorComponent != null && behaviorComponent.IsValid())
		{
			UUISelectableComponent uuiselectableComponent = behaviorComponent as UUISelectableComponent;
			if (uuiselectableComponent != null)
			{
				uuiselectableComponent.SetSelectionState(uuiselectableComponent.GetSelectionState());
				uuiselectableComponent.ApplySelectionState(true);
			}
		}
	}

	// Token: 0x0601583A RID: 88122 RVA: 0x0063EDF8 File Offset: 0x0063CFF8
	private void UpdateLoopNavigationIndex(int gridIndex)
	{
		if (this.ScrollViewActor == null)
		{
			return;
		}
		if (this.ScrollProxy == null)
		{
			return;
		}
		this.ScrollProxy.SetLoopScrollViewNavigationIndex(gridIndex);
	}

	// Token: 0x0601583B RID: 88123 RVA: 0x0063EE18 File Offset: 0x0063D018
	private void NotifyUnFocusListener()
	{
		UUISelectableComponent uuiselectableComponent = this.GetBehaviorComponent() as UUISelectableComponent;
		if (uuiselectableComponent != null)
		{
			uuiselectableComponent.NotifyUnFocusListener();
		}
	}

	// Token: 0x0601583C RID: 88124 RVA: 0x0063EE3C File Offset: 0x0063D03C
	private void NotifyFocusListener(bool isSameListener)
	{
		NavigationSelectableBase navigationComponent = this.GetNavigationComponent();
		navigationComponent.NotifyFocusListener(isSameListener);
		UUISelectableComponent uuiselectableComponent = navigationComponent.GetSelectable() as UUISelectableComponent;
		if (uuiselectableComponent != null)
		{
			uuiselectableComponent.NotifyFocusListener();
		}
	}

	// Token: 0x0601583D RID: 88125 RVA: 0x0063EE6C File Offset: 0x0063D06C
	private void SetListenerInNavigation()
	{
		if (UiNavigationGlobalData.IsAllowCrossNavigationGroup)
		{
			UiNavigationGlobalData.IsAllowCrossNavigationGroup = false;
			TsUiNavigationPanelConfig panelConfig = this.PanelConfig;
			if (panelConfig == null)
			{
				return;
			}
			panelConfig.NotifyListenerFocus(this);
			return;
		}
		else
		{
			if (this.InNavigation && this.IsInLoopScrollDisplay())
			{
				return;
			}
			TsUiNavigationPanelConfig panelConfig2 = this.PanelConfig;
			if (panelConfig2 == null)
			{
				return;
			}
			panelConfig2.NotifyListenerFocus(this);
			return;
		}
	}

	// Token: 0x0601583E RID: 88126 RVA: 0x0063EEBA File Offset: 0x0063D0BA
	[NullableContext(2)]
	public NavigationGroup GetNavigationGroup()
	{
		TsUiNavigationPanelConfig panelConfig = this.PanelConfig;
		if (panelConfig == null)
		{
			return null;
		}
		return panelConfig.GetNavigationGroup(this.GroupName);
	}

	// Token: 0x0601583F RID: 88127 RVA: 0x0063EED4 File Offset: 0x0063D0D4
	public bool IsSelectedToggle()
	{
		UUIExtendToggle uuiextendToggle = this.GetSelectableComponent() as UUIExtendToggle;
		return uuiextendToggle != null && uuiextendToggle.ToggleState == EToggleState.ETT_Checked;
	}

	// Token: 0x06015840 RID: 88128 RVA: 0x0063EEFB File Offset: 0x0063D0FB
	public void NotifyTextChangeByComponent(string notifyText)
	{
		if (this.PanelConfig == null)
		{
			return;
		}
		this.PanelConfig.UpdateHotKeyTextForce(this.TagArray, notifyText);
	}

	// Token: 0x06015841 RID: 88129 RVA: 0x0063EF18 File Offset: 0x0063D118
	public string GetTipsTextIdByState()
	{
		return this.GetNavigationComponent().GetTipsTextId();
	}

	// Token: 0x06015842 RID: 88130 RVA: 0x0063EF25 File Offset: 0x0063D125
	public TsUiNavigationTextChangeListener GetTextChangeComponent()
	{
		return this.TextChangeComponent;
	}

	// Token: 0x170020AC RID: 8364
	// (get) Token: 0x06015843 RID: 88131 RVA: 0x0063EF30 File Offset: 0x0063D130
	// (set) Token: 0x06015844 RID: 88132 RVA: 0x0063EF69 File Offset: 0x0063D169
	[UProperty(EPropertyFlags.CPF_None)]
	public SNavigationMode NavigationMode
	{
		get
		{
			base.FastCheckIsValid();
			SNavigationMode result;
			if ((result = this._NavigationMode) == null)
			{
				result = (this._NavigationMode = new SNavigationMode(base.NativePtr + (IntPtr)TsUiNavigationBehaviorListener.__PropertyOffset_NavigationMode, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(SNavigationMode.StaticStruct(), base.NativePtr + (IntPtr)TsUiNavigationBehaviorListener.__PropertyOffset_NavigationMode, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x06015845 RID: 88133 RVA: 0x0063EF94 File Offset: 0x0063D194
	[NullableContext(2)]
	public USceneComponent FindNavigation(ELGUINavigationDirection direction)
	{
		if (direction == ELGUINavigationDirection.None)
		{
			return this.GetSceneComponent();
		}
		if (direction == ELGUINavigationDirection.Prev)
		{
			USceneComponent usceneComponent = this.ModeModule.FindActorByDirection(ELGUINavigationDirection.Left, true);
			if (usceneComponent != null && usceneComponent != this.GetSceneComponent())
			{
				return usceneComponent;
			}
			return this.ModeModule.FindActorByDirection(ELGUINavigationDirection.Up, true);
		}
		else
		{
			if (direction != ELGUINavigationDirection.Next)
			{
				return this.ModeModule.FindActorByDirection(direction, true);
			}
			USceneComponent usceneComponent2 = this.ModeModule.FindActorByDirection(ELGUINavigationDirection.Right, true);
			if (usceneComponent2 != null && usceneComponent2 != this.GetSceneComponent())
			{
				return usceneComponent2;
			}
			return this.ModeModule.FindActorByDirection(ELGUINavigationDirection.Down, true);
		}
	}

	// Token: 0x170020AD RID: 8365
	// (get) Token: 0x06015846 RID: 88134 RVA: 0x0063F014 File Offset: 0x0063D214
	// (set) Token: 0x06015847 RID: 88135 RVA: 0x0063F04D File Offset: 0x0063D24D
	[UProperty(EPropertyFlags.CPF_None)]
	public SNavigationCursor Cursor
	{
		get
		{
			base.FastCheckIsValid();
			SNavigationCursor result;
			if ((result = this._Cursor) == null)
			{
				result = (this._Cursor = new SNavigationCursor(base.NativePtr + (IntPtr)TsUiNavigationBehaviorListener.__PropertyOffset_Cursor, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(SNavigationCursor.StaticStruct(), base.NativePtr + (IntPtr)TsUiNavigationBehaviorListener.__PropertyOffset_Cursor, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x06015848 RID: 88136 RVA: 0x0063F075 File Offset: 0x0063D275
	public FVector2D GetCursorOffset()
	{
		return this.CursorModule.GetCursorOffset();
	}

	// Token: 0x06015849 RID: 88137 RVA: 0x0063F082 File Offset: 0x0063D282
	public int GetCursorRotation()
	{
		return this.CursorModule.GetCursorRotation();
	}

	// Token: 0x0601584A RID: 88138 RVA: 0x0063F08F File Offset: 0x0063D28F
	public FVector2D GetBoundOffset()
	{
		return this.CursorModule.GetBoundOffset();
	}

	// Token: 0x0601584B RID: 88139 RVA: 0x0063F09C File Offset: 0x0063D29C
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsUiNavigationBehaviorListener._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/UiNavigation/New/TsUiNavigationBehaviorListener.TsUiNavigationBehaviorListener_C");
		}
		return TsUiNavigationBehaviorListener._ClassPtr;
	}

	// Token: 0x0601584C RID: 88140 RVA: 0x0063F0C0 File Offset: 0x0063D2C0
	public TsUiNavigationBehaviorListener() : this(BuiltinUtils.AllocNativeUObject(TsUiNavigationBehaviorListener.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601584D RID: 88141 RVA: 0x0063F0E8 File Offset: 0x0063D2E8
	public TsUiNavigationBehaviorListener(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiNavigationBehaviorListener.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601584E RID: 88142 RVA: 0x0063F11B File Offset: 0x0063D31B
	protected TsUiNavigationBehaviorListener(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601584F RID: 88143 RVA: 0x0063F124 File Offset: 0x0063D324
	protected virtual void __CPPCALL_AwakeBP_Implementation()
	{
		this.AwakeBP_Implementation();
	}

	// Token: 0x06015850 RID: 88144 RVA: 0x0063F12C File Offset: 0x0063D32C
	protected virtual void __CPPCALL_StartBP_Implementation()
	{
		this.StartBP_Implementation();
	}

	// Token: 0x06015851 RID: 88145 RVA: 0x0063F134 File Offset: 0x0063D334
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_OnNotifyNavigationEnterBP_Implementation(UUINavigationBehaviour.__OnNotifyNavigationEnterBP_FunctionParams* __Params)
	{
		ULGUIPointerEventData orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIPointerEventData>(__Params->eventData);
		this.OnNotifyNavigationEnterBP_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x06015852 RID: 88146 RVA: 0x0063F154 File Offset: 0x0063D354
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_OnNotifyNavigationSelectBP_Implementation(UUINavigationBehaviour.__OnNotifyNavigationSelectBP_FunctionParams* __Params)
	{
		ULGUIPointerEventData orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIPointerEventData>(__Params->eventData);
		this.OnNotifyNavigationSelectBP_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x06015853 RID: 88147 RVA: 0x0063F174 File Offset: 0x0063D374
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_OnCheckCanSetNavigationBP_Implementation(UUINavigationBehaviour.__OnCheckCanSetNavigationBP_FunctionParams* __Params)
	{
		__Params->__Result = this.OnCheckCanSetNavigationBP_Implementation();
	}

	// Token: 0x06015854 RID: 88148 RVA: 0x0063F182 File Offset: 0x0063D382
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_OnCheckLoopScrollChangeNavigationBP_Implementation(UUINavigationBehaviour.__OnCheckLoopScrollChangeNavigationBP_FunctionParams* __Params)
	{
		__Params->__Result = this.OnCheckLoopScrollChangeNavigationBP_Implementation();
	}

	// Token: 0x06015855 RID: 88149 RVA: 0x0063F190 File Offset: 0x0063D390
	protected virtual void __CPPCALL_OnEnableBP_Implementation()
	{
		this.OnEnableBP_Implementation();
	}

	// Token: 0x06015856 RID: 88150 RVA: 0x0063F198 File Offset: 0x0063D398
	protected virtual void __CPPCALL_OnDisableBP_Implementation()
	{
		this.OnDisableBP_Implementation();
	}

	// Token: 0x06015857 RID: 88151 RVA: 0x0063F1A0 File Offset: 0x0063D3A0
	protected virtual void __CPPCALL_OnNotifyInteractiveBP_Implementation()
	{
		this.OnNotifyInteractiveBP_Implementation();
	}

	// Token: 0x06015858 RID: 88152 RVA: 0x0063F1A8 File Offset: 0x0063D3A8
	protected virtual void __CPPCALL_OnNotifyNotInteractiveBP_Implementation()
	{
		this.OnNotifyNotInteractiveBP_Implementation();
	}

	// Token: 0x06015859 RID: 88153 RVA: 0x0063F1B0 File Offset: 0x0063D3B0
	protected virtual void __CPPCALL_OnPreDestroyBP_Implementation()
	{
		this.OnPreDestroyBP_Implementation();
	}

	// Token: 0x0400B5F2 RID: 46578
	[Nullable(2)]
	public UiNavigationScrollProxy ScrollProxy;

	// Token: 0x0400B5F3 RID: 46579
	[Nullable(2)]
	private UUILayoutBase LayoutBase;

	// Token: 0x0400B5F4 RID: 46580
	[Nullable(2)]
	private TsUiNavigationTextChangeListener TextChangeComponent;

	// Token: 0x0400B5F5 RID: 46581
	[Nullable(2)]
	public TsUiNavigationPanelConfig PanelConfig;

	// Token: 0x0400B5F6 RID: 46582
	private bool InNavigation;

	// Token: 0x0400B5F7 RID: 46583
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<string, TsUiNavigationBehaviorListener> ChildTagMap;

	// Token: 0x0400B5F8 RID: 46584
	[Nullable(2)]
	private NavigationSelectableBase NavigationComponent;

	// Token: 0x0400B5F9 RID: 46585
	private bool IsAwakeCalled;

	// Token: 0x0400B5FA RID: 46586
	private bool IsStartCalled;

	// Token: 0x0400B5FB RID: 46587
	private bool IsInitLayout;

	// Token: 0x0400B5FC RID: 46588
	public bool IsFocusScrollbar;

	// Token: 0x0400B5FD RID: 46589
	[Nullable(2)]
	private UUIInturnAnimController AnimController;

	// Token: 0x0400B5FE RID: 46590
	private bool IsInitAnimController;

	// Token: 0x0400B5FF RID: 46591
	[Nullable(2)]
	public AActor DynamicGridActor;

	// Token: 0x0400B600 RID: 46592
	public int InstanceId;

	// Token: 0x0400B601 RID: 46593
	[Nullable(2)]
	public UiNavigationModeModule ModeModule;

	// Token: 0x0400B602 RID: 46594
	[Nullable(2)]
	private UiNavigationCursorModule CursorModule;

	// Token: 0x0400B603 RID: 46595
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/UiNavigation/New/TsUiNavigationBehaviorListener.TsUiNavigationBehaviorListener_C";

	// Token: 0x0400B604 RID: 46596
	private static IntPtr _ClassPtr;

	// Token: 0x0400B605 RID: 46597
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B606 RID: 46598
	private static int __PropertyOffset_GroupName;

	// Token: 0x0400B607 RID: 46599
	private static int __PropertyOffset_TagArray;

	// Token: 0x0400B608 RID: 46600
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<string> _TagArray;

	// Token: 0x0400B609 RID: 46601
	private static int __PropertyOffset_ExitTagPriority;

	// Token: 0x0400B60A RID: 46602
	private static int __PropertyOffset_ShieldHotKeyIndexArray;

	// Token: 0x0400B60B RID: 46603
	[Nullable(2)]
	private TArray<int> _ShieldHotKeyIndexArray;

	// Token: 0x0400B60C RID: 46604
	private static int __PropertyOffset_ScrollViewActor;

	// Token: 0x0400B60D RID: 46605
	private static int __PropertyOffset_GridBaseActor;

	// Token: 0x0400B60E RID: 46606
	private static int __PropertyOffset_LayoutActor;

	// Token: 0x0400B60F RID: 46607
	private static int __PropertyOffset_HotKeyTipsTextIdMap;

	// Token: 0x0400B610 RID: 46608
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TMap<EHotKeyNameStateType, string> _HotKeyTipsTextIdMap;

	// Token: 0x0400B611 RID: 46609
	private static int __PropertyOffset_ClickPivot;

	// Token: 0x0400B612 RID: 46610
	private static int __PropertyOffset_InsideGroupActor;

	// Token: 0x0400B613 RID: 46611
	private static int __PropertyOffset_InsideActorMap;

	// Token: 0x0400B614 RID: 46612
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private TMap<string, AActor> _InsideActorMap;

	// Token: 0x0400B615 RID: 46613
	private static int __PropertyOffset_ScrollbarIndex;

	// Token: 0x0400B616 RID: 46614
	private static int __PropertyOffset_InteractiveTag;

	// Token: 0x0400B617 RID: 46615
	private static int __PropertyOffset_InteractiveParam;

	// Token: 0x0400B618 RID: 46616
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<string> _InteractiveParam;

	// Token: 0x0400B619 RID: 46617
	private static int __PropertyOffset_DynamicTag;

	// Token: 0x0400B61A RID: 46618
	private static int __PropertyOffset_OpenAdsorbed;

	// Token: 0x0400B61B RID: 46619
	private static int __PropertyOffset_AdsorbedDistance;

	// Token: 0x0400B61C RID: 46620
	private static int __PropertyOffset_AdsorbedPivot;

	// Token: 0x0400B61D RID: 46621
	private static int __PropertyOffset_IsUseDrag;

	// Token: 0x0400B61E RID: 46622
	private static int __PropertyOffset_IsUsePool;

	// Token: 0x0400B61F RID: 46623
	private static int __PropertyOffset_NavigateTolerance;

	// Token: 0x0400B620 RID: 46624
	private static int __PropertyOffset_NavigateToleranceReverse;

	// Token: 0x0400B621 RID: 46625
	private static int __PropertyOffset_NavigationMode;

	// Token: 0x0400B622 RID: 46626
	[Nullable(2)]
	private SNavigationMode _NavigationMode;

	// Token: 0x0400B623 RID: 46627
	private static int __PropertyOffset_Cursor;

	// Token: 0x0400B624 RID: 46628
	[Nullable(2)]
	private SNavigationCursor _Cursor;
}
