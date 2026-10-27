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

// Token: 0x02002CC6 RID: 11462
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Module/UiNavigation/New/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/UiNavigation/New/TsUiNavigationBehaviorListener.TsUiNavigationBehaviorListener_C")]
public class TsUiNavigationBehaviorListener : UUINavigationBehaviour, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002045 RID: 8261
	// (get) Token: 0x06017F57 RID: 98135 RVA: 0x00617DD6 File Offset: 0x00615FD6
	// (set) Token: 0x06017F58 RID: 98136 RVA: 0x00617DEA File Offset: 0x00615FEA
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

	// Token: 0x17002046 RID: 8262
	// (get) Token: 0x06017F59 RID: 98137 RVA: 0x00617E00 File Offset: 0x00616000
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

	// Token: 0x17002047 RID: 8263
	// (get) Token: 0x06017F5A RID: 98138 RVA: 0x00617E39 File Offset: 0x00616039
	// (set) Token: 0x06017F5B RID: 98139 RVA: 0x00617E49 File Offset: 0x00616049
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

	// Token: 0x17002048 RID: 8264
	// (get) Token: 0x06017F5C RID: 98140 RVA: 0x00617E5C File Offset: 0x0061605C
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

	// Token: 0x17002049 RID: 8265
	// (get) Token: 0x06017F5D RID: 98141 RVA: 0x00617E95 File Offset: 0x00616095
	// (set) Token: 0x06017F5E RID: 98142 RVA: 0x00617EA9 File Offset: 0x006160A9
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

	// Token: 0x1700204A RID: 8266
	// (get) Token: 0x06017F5F RID: 98143 RVA: 0x00617EBE File Offset: 0x006160BE
	// (set) Token: 0x06017F60 RID: 98144 RVA: 0x00617ED2 File Offset: 0x006160D2
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

	// Token: 0x1700204B RID: 8267
	// (get) Token: 0x06017F61 RID: 98145 RVA: 0x00617EE7 File Offset: 0x006160E7
	// (set) Token: 0x06017F62 RID: 98146 RVA: 0x00617EFB File Offset: 0x006160FB
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

	// Token: 0x1700204C RID: 8268
	// (get) Token: 0x06017F63 RID: 98147 RVA: 0x00617F10 File Offset: 0x00616110
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

	// Token: 0x1700204D RID: 8269
	// (get) Token: 0x06017F64 RID: 98148 RVA: 0x00617F49 File Offset: 0x00616149
	// (set) Token: 0x06017F65 RID: 98149 RVA: 0x00617F5D File Offset: 0x0061615D
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

	// Token: 0x1700204E RID: 8270
	// (get) Token: 0x06017F66 RID: 98150 RVA: 0x00617F72 File Offset: 0x00616172
	// (set) Token: 0x06017F67 RID: 98151 RVA: 0x00617F86 File Offset: 0x00616186
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

	// Token: 0x1700204F RID: 8271
	// (get) Token: 0x06017F68 RID: 98152 RVA: 0x00617F9C File Offset: 0x0061619C
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

	// Token: 0x17002050 RID: 8272
	// (get) Token: 0x06017F69 RID: 98153 RVA: 0x00617FD5 File Offset: 0x006161D5
	// (set) Token: 0x06017F6A RID: 98154 RVA: 0x00617FE5 File Offset: 0x006161E5
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

	// Token: 0x17002051 RID: 8273
	// (get) Token: 0x06017F6B RID: 98155 RVA: 0x00617FF6 File Offset: 0x006161F6
	// (set) Token: 0x06017F6C RID: 98156 RVA: 0x0061800A File Offset: 0x0061620A
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

	// Token: 0x17002052 RID: 8274
	// (get) Token: 0x06017F6D RID: 98157 RVA: 0x00618020 File Offset: 0x00616220
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

	// Token: 0x17002053 RID: 8275
	// (get) Token: 0x06017F6E RID: 98158 RVA: 0x00618059 File Offset: 0x00616259
	// (set) Token: 0x06017F6F RID: 98159 RVA: 0x0061806D File Offset: 0x0061626D
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

	// Token: 0x17002054 RID: 8276
	// (get) Token: 0x06017F70 RID: 98160 RVA: 0x00618082 File Offset: 0x00616282
	// (set) Token: 0x06017F71 RID: 98161 RVA: 0x00618092 File Offset: 0x00616292
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

	// Token: 0x17002055 RID: 8277
	// (get) Token: 0x06017F72 RID: 98162 RVA: 0x006180A3 File Offset: 0x006162A3
	// (set) Token: 0x06017F73 RID: 98163 RVA: 0x006180B3 File Offset: 0x006162B3
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

	// Token: 0x17002056 RID: 8278
	// (get) Token: 0x06017F74 RID: 98164 RVA: 0x006180C4 File Offset: 0x006162C4
	// (set) Token: 0x06017F75 RID: 98165 RVA: 0x006180D8 File Offset: 0x006162D8
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

	// Token: 0x17002057 RID: 8279
	// (get) Token: 0x06017F76 RID: 98166 RVA: 0x006180ED File Offset: 0x006162ED
	// (set) Token: 0x06017F77 RID: 98167 RVA: 0x006180FD File Offset: 0x006162FD
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

	// Token: 0x17002058 RID: 8280
	// (get) Token: 0x06017F78 RID: 98168 RVA: 0x0061810E File Offset: 0x0061630E
	// (set) Token: 0x06017F79 RID: 98169 RVA: 0x0061811E File Offset: 0x0061631E
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

	// Token: 0x17002059 RID: 8281
	// (get) Token: 0x06017F7A RID: 98170 RVA: 0x0061812F File Offset: 0x0061632F
	// (set) Token: 0x06017F7B RID: 98171 RVA: 0x0061813F File Offset: 0x0061633F
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

	// Token: 0x1700205A RID: 8282
	// (get) Token: 0x06017F7C RID: 98172 RVA: 0x00618150 File Offset: 0x00616350
	// (set) Token: 0x06017F7D RID: 98173 RVA: 0x00618160 File Offset: 0x00616360
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

	// Token: 0x06017F7E RID: 98174 RVA: 0x00618174 File Offset: 0x00616374
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void AwakeBP()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AwakeBP"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x06017F7F RID: 98175 RVA: 0x006181E4 File Offset: 0x006163E4
	protected virtual void AwakeBP_Implementation()
	{
		if (GlobalData.GameInstance == null)
		{
			return;
		}
		this.InstanceId = UiNavigationGlobalData.GetListenerInstanceId();
		this.AwakeInit();
	}

	// Token: 0x06017F80 RID: 98176 RVA: 0x00618200 File Offset: 0x00616400
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void StartBP()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("StartBP"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x06017F81 RID: 98177 RVA: 0x00618270 File Offset: 0x00616470
	protected virtual void StartBP_Implementation()
	{
		if (GlobalData.GameInstance == null)
		{
			return;
		}
		this.StartInit();
	}

	// Token: 0x06017F82 RID: 98178 RVA: 0x00618280 File Offset: 0x00616480
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void OnNotifyNavigationEnterBP(ULGUIPointerEventData eventData)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnNotifyNavigationEnterBP"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UUINavigationBehaviour.__OnNotifyNavigationEnterBP_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UUINavigationBehaviour.__OnNotifyNavigationEnterBP_FunctionParams*)ptr + 15L / (long)sizeof(UUINavigationBehaviour.__OnNotifyNavigationEnterBP_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->eventData) = ((eventData != null) ? eventData.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06017F83 RID: 98179 RVA: 0x00618304 File Offset: 0x00616504
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

	// Token: 0x06017F84 RID: 98180 RVA: 0x00618358 File Offset: 0x00616558
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void OnNotifyNavigationSelectBP(ULGUIPointerEventData eventData)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnNotifyNavigationSelectBP"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UUINavigationBehaviour.__OnNotifyNavigationSelectBP_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UUINavigationBehaviour.__OnNotifyNavigationSelectBP_FunctionParams*)ptr + 15L / (long)sizeof(UUINavigationBehaviour.__OnNotifyNavigationSelectBP_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->eventData) = ((eventData != null) ? eventData.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06017F85 RID: 98181 RVA: 0x006183DC File Offset: 0x006165DC
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

	// Token: 0x06017F86 RID: 98182 RVA: 0x00618438 File Offset: 0x00616638
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool OnCheckCanSetNavigationBP()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnCheckCanSetNavigationBP"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UUINavigationBehaviour.__OnCheckCanSetNavigationBP_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UUINavigationBehaviour.__OnCheckCanSetNavigationBP_FunctionParams*)ptr + 15L / (long)sizeof(UUINavigationBehaviour.__OnCheckCanSetNavigationBP_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06017F87 RID: 98183 RVA: 0x006184B0 File Offset: 0x006166B0
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

	// Token: 0x06017F88 RID: 98184 RVA: 0x00618524 File Offset: 0x00616724
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool OnCheckLoopScrollChangeNavigationBP()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnCheckLoopScrollChangeNavigationBP"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UUINavigationBehaviour.__OnCheckLoopScrollChangeNavigationBP_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UUINavigationBehaviour.__OnCheckLoopScrollChangeNavigationBP_FunctionParams*)ptr + 15L / (long)sizeof(UUINavigationBehaviour.__OnCheckLoopScrollChangeNavigationBP_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06017F89 RID: 98185 RVA: 0x00618599 File Offset: 0x00616799
	protected virtual bool OnCheckLoopScrollChangeNavigationBP_Implementation()
	{
		return this.ScrollProxy != null && this.ScrollProxy.CheckLoopScrollChangeNavigation();
	}

	// Token: 0x06017F8A RID: 98186 RVA: 0x006185B0 File Offset: 0x006167B0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void OnEnableBP()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnEnableBP"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x06017F8B RID: 98187 RVA: 0x00618620 File Offset: 0x00616820
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

	// Token: 0x06017F8C RID: 98188 RVA: 0x00618648 File Offset: 0x00616848
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void OnDisableBP()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnDisableBP"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x06017F8D RID: 98189 RVA: 0x006186B8 File Offset: 0x006168B8
	protected virtual void OnDisableBP_Implementation()
	{
		if (GlobalData.GameInstance == null)
		{
			return;
		}
		UiNavigationViewManager.Instance.RefreshCurrentHotKey();
		this.DisActiveHandle();
	}

	// Token: 0x06017F8E RID: 98190 RVA: 0x006186D4 File Offset: 0x006168D4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void OnNotifyInteractiveBP()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnNotifyInteractiveBP"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x06017F8F RID: 98191 RVA: 0x00618744 File Offset: 0x00616944
	protected virtual void OnNotifyInteractiveBP_Implementation()
	{
		if (GlobalData.GameInstance == null)
		{
			return;
		}
		this.GetNavigationComponent().SetIsInteractive(true);
		UiNavigationViewManager.Instance.RefreshCurrentHotKey();
	}

	// Token: 0x06017F90 RID: 98192 RVA: 0x00618764 File Offset: 0x00616964
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void OnNotifyNotInteractiveBP()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnNotifyNotInteractiveBP"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x06017F91 RID: 98193 RVA: 0x006187D4 File Offset: 0x006169D4
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

	// Token: 0x06017F92 RID: 98194 RVA: 0x006187FC File Offset: 0x006169FC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void OnPreDestroyBP()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnPreDestroyBP"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x06017F93 RID: 98195 RVA: 0x0061886C File Offset: 0x00616A6C
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

	// Token: 0x06017F94 RID: 98196 RVA: 0x006188BC File Offset: 0x00616ABC
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

	// Token: 0x06017F95 RID: 98197 RVA: 0x00618914 File Offset: 0x00616B14
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

	// Token: 0x06017F96 RID: 98198 RVA: 0x00618960 File Offset: 0x00616B60
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

	// Token: 0x06017F97 RID: 98199 RVA: 0x00618A44 File Offset: 0x00616C44
	private void InitScrollViewAndLayout()
	{
		this.InitScrollView();
		this.InitLayout();
	}

	// Token: 0x06017F98 RID: 98200 RVA: 0x00618A54 File Offset: 0x00616C54
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

	// Token: 0x06017F99 RID: 98201 RVA: 0x00618AC0 File Offset: 0x00616CC0
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

	// Token: 0x06017F9A RID: 98202 RVA: 0x00618B60 File Offset: 0x00616D60
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

	// Token: 0x06017F9B RID: 98203 RVA: 0x00618BEB File Offset: 0x00616DEB
	private void TryFindScrollbar()
	{
		if (this.PanelConfig == null)
		{
			return;
		}
		this.PanelConfig.TryFindScrollbar();
	}

	// Token: 0x06017F9C RID: 98204 RVA: 0x00618C01 File Offset: 0x00616E01
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

	// Token: 0x06017F9D RID: 98205 RVA: 0x00618C39 File Offset: 0x00616E39
	private void SetTextChangeComponent()
	{
		AActor owner = base.GetOwner();
		this.TextChangeComponent = (((owner != null) ? owner.GetComponentByClass(TsUiNavigationTextChangeListener.StaticClass()) : null) as TsUiNavigationTextChangeListener);
	}

	// Token: 0x06017F9E RID: 98206 RVA: 0x00618C64 File Offset: 0x00616E64
	private void NotifyParentListener(TsUiNavigationBehaviorListener listener)
	{
		TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = UiNavigationLogic.FindUpNavigationListener(base.GetOwner());
		if (tsUiNavigationBehaviorListener == null)
		{
			return;
		}
		tsUiNavigationBehaviorListener.RegisterChildListener(listener);
	}

	// Token: 0x06017F9F RID: 98207 RVA: 0x00618C88 File Offset: 0x00616E88
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

	// Token: 0x06017FA0 RID: 98208 RVA: 0x00618CD1 File Offset: 0x00616ED1
	private void InitInsideGroupActor()
	{
		if (this.InsideGroupActor != null)
		{
			return;
		}
		this.InsideGroupActor = base.GetOwner();
	}

	// Token: 0x06017FA1 RID: 98209 RVA: 0x00618CE8 File Offset: 0x00616EE8
	private void BindLoopScrollView()
	{
		if (this.ScrollProxy == null)
		{
			return;
		}
		UUISelectableComponent selectableComponent = this.GetSelectableComponent();
		this.ScrollProxy.BindScrollView(selectableComponent);
	}

	// Token: 0x06017FA2 RID: 98210 RVA: 0x00618D14 File Offset: 0x00616F14
	private void UnBindLoopScrollView()
	{
		if (this.ScrollProxy == null)
		{
			return;
		}
		UUISelectableComponent selectableComponent = this.GetSelectableComponent();
		this.ScrollProxy.UnBindScrollView(selectableComponent);
	}

	// Token: 0x06017FA3 RID: 98211 RVA: 0x00618D3D File Offset: 0x00616F3D
	public bool HasNormalScrollView()
	{
		return this.ScrollProxy != null && this.ScrollProxy.HasNormalScrollView();
	}

	// Token: 0x06017FA4 RID: 98212 RVA: 0x00618D54 File Offset: 0x00616F54
	public bool HasLoopScrollView()
	{
		return this.ScrollProxy != null && this.ScrollProxy.HasLoopScrollView();
	}

	// Token: 0x06017FA5 RID: 98213 RVA: 0x00618D6B File Offset: 0x00616F6B
	public bool HasDynamicScrollView()
	{
		return this.ScrollProxy != null && this.ScrollProxy.HasDynamicScrollView();
	}

	// Token: 0x06017FA6 RID: 98214 RVA: 0x00618D82 File Offset: 0x00616F82
	public bool HasMultiTemplateScrollView()
	{
		return this.ScrollProxy != null && this.ScrollProxy.HasMultiTemplateScrollView();
	}

	// Token: 0x06017FA7 RID: 98215 RVA: 0x00618D99 File Offset: 0x00616F99
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

	// Token: 0x06017FA8 RID: 98216 RVA: 0x00618DD6 File Offset: 0x00616FD6
	private void UnRegisterListenerToPanel()
	{
		if (this.PanelConfig == null)
		{
			return;
		}
		this.PanelConfig.UnRegisterNavigationListener(this);
	}

	// Token: 0x06017FA9 RID: 98217 RVA: 0x00618DED File Offset: 0x00616FED
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

	// Token: 0x06017FAA RID: 98218 RVA: 0x00618E14 File Offset: 0x00617014
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

	// Token: 0x06017FAB RID: 98219 RVA: 0x00618EA6 File Offset: 0x006170A6
	public NavigationSelectableBase GetNavigationComponent()
	{
		if (this.NavigationComponent == null)
		{
			this.CreateNavigationComponent();
		}
		return this.NavigationComponent;
	}

	// Token: 0x06017FAC RID: 98220 RVA: 0x00618EBC File Offset: 0x006170BC
	[NullableContext(2)]
	public UUISelectableComponent GetSelectableComponent()
	{
		return this.GetBehaviorComponent() as UUISelectableComponent;
	}

	// Token: 0x06017FAD RID: 98221 RVA: 0x00618EC9 File Offset: 0x006170C9
	public ULGUIBehaviour GetBehaviorComponent()
	{
		return this.GetNavigationComponent().GetSelectable();
	}

	// Token: 0x06017FAE RID: 98222 RVA: 0x00618ED6 File Offset: 0x006170D6
	[NullableContext(2)]
	public USceneComponent GetSceneComponent()
	{
		return this.GetBehaviorComponent().GetRootComponent();
	}

	// Token: 0x06017FAF RID: 98223 RVA: 0x00618EE4 File Offset: 0x006170E4
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

	// Token: 0x06017FB0 RID: 98224 RVA: 0x00618F0C File Offset: 0x0061710C
	public bool IsScrollOrLayoutActor()
	{
		this.InitScrollViewAndLayout();
		UiNavigationScrollProxy scrollProxy = this.ScrollProxy;
		return ((scrollProxy != null) ? scrollProxy.ScrollView : null) != null || this.LayoutBase != null;
	}

	// Token: 0x06017FB1 RID: 98225 RVA: 0x00618F33 File Offset: 0x00617133
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

	// Token: 0x06017FB2 RID: 98226 RVA: 0x00618F54 File Offset: 0x00617154
	public bool IsScrollOrLayoutActive()
	{
		this.InitScrollViewAndLayout();
		if (this.ScrollProxy != null)
		{
			return this.ScrollProxy.IsScrollViewActive();
		}
		return this.LayoutBase != null && this.LayoutBase.RootUIComp.Get().IsUIActiveInHierarchy();
	}

	// Token: 0x06017FB3 RID: 98227 RVA: 0x00618F9D File Offset: 0x0061719D
	public bool IsInScrollOrLayoutAnimation()
	{
		this.InitAnimController();
		UUIInturnAnimController animController = this.AnimController;
		return animController != null && animController.IsPlaying();
	}

	// Token: 0x06017FB4 RID: 98228 RVA: 0x00618FB6 File Offset: 0x006171B6
	public bool IsInNormalScrollDisplayByGridActor()
	{
		return !this.HasNormalScrollView() || this.GridBaseActor == null || this.ScrollProxy.IsInNormalScrollDisplayByGridActor(this.GridBaseActor);
	}

	// Token: 0x06017FB5 RID: 98229 RVA: 0x00618FDD File Offset: 0x006171DD
	public bool IsInLoopScrollDisplay()
	{
		return this.ScrollProxy == null || this.ScrollProxy.IsInLoopScrollDisplay(base.LoopScrollViewGridIndex);
	}

	// Token: 0x06017FB6 RID: 98230 RVA: 0x00618FFA File Offset: 0x006171FA
	public bool IsInLoopScrollDisplayByGridActor()
	{
		return this.ScrollProxy == null || this.ScrollProxy.IsInLoopScrollDisplayByGridActor(this.GridBaseActor);
	}

	// Token: 0x06017FB7 RID: 98231 RVA: 0x00619017 File Offset: 0x00617217
	public bool IsInDynScrollDisplay()
	{
		return this.ScrollProxy == null || this.ScrollProxy.IsInDynScrollDisplay(this.GridBaseActor);
	}

	// Token: 0x06017FB8 RID: 98232 RVA: 0x00619034 File Offset: 0x00617234
	public bool IsInScrollDisplayByGridActor()
	{
		return this.ScrollProxy == null || this.ScrollProxy.IsScrollDisplayByGridActor(this.GridBaseActor);
	}

	// Token: 0x06017FB9 RID: 98233 RVA: 0x00619054 File Offset: 0x00617254
	public bool IsInScrollOrLayoutCanFocus()
	{
		NavigationSelectableBase navigationComponent = this.GetNavigationComponent();
		return navigationComponent != null && navigationComponent.CanFocusInScrollOrLayout();
	}

	// Token: 0x06017FBA RID: 98234 RVA: 0x00619074 File Offset: 0x00617274
	public bool IsCanFocus()
	{
		NavigationSelectableBase navigationComponent = this.GetNavigationComponent();
		return navigationComponent != null && navigationComponent.CanFocus();
	}

	// Token: 0x06017FBB RID: 98235 RVA: 0x00619093 File Offset: 0x00617293
	public bool IsRegisterToPanelConfig()
	{
		return this.IsStartCalled;
	}

	// Token: 0x06017FBC RID: 98236 RVA: 0x0061909C File Offset: 0x0061729C
	public bool IsListenerActive()
	{
		NavigationSelectableBase navigationComponent = this.GetNavigationComponent();
		return navigationComponent != null && navigationComponent.IsActive();
	}

	// Token: 0x06017FBD RID: 98237 RVA: 0x006190BC File Offset: 0x006172BC
	public bool IsIgnoreScrollOrLayoutCheckInSwitchGroup()
	{
		NavigationSelectableBase navigationComponent = this.GetNavigationComponent();
		return navigationComponent != null && navigationComponent.IsIgnoreScrollOrLayoutCheckInSwitchGroup();
	}

	// Token: 0x06017FBE RID: 98238 RVA: 0x006190DB File Offset: 0x006172DB
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

	// Token: 0x06017FBF RID: 98239 RVA: 0x00619119 File Offset: 0x00617319
	public void ActiveNavigationState(bool isSameListener)
	{
		this.InNavigation = true;
		this.UpdateNavigationState();
		this.UpdateLoopNavigationIndex(base.LoopScrollViewGridIndex);
		this.NotifyFocusListener(isSameListener);
	}

	// Token: 0x06017FC0 RID: 98240 RVA: 0x0061913C File Offset: 0x0061733C
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

	// Token: 0x06017FC1 RID: 98241 RVA: 0x00619178 File Offset: 0x00617378
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

	// Token: 0x06017FC2 RID: 98242 RVA: 0x00619198 File Offset: 0x00617398
	private void NotifyUnFocusListener()
	{
		UUISelectableComponent uuiselectableComponent = this.GetBehaviorComponent() as UUISelectableComponent;
		if (uuiselectableComponent != null)
		{
			uuiselectableComponent.NotifyUnFocusListener();
		}
	}

	// Token: 0x06017FC3 RID: 98243 RVA: 0x006191BC File Offset: 0x006173BC
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

	// Token: 0x06017FC4 RID: 98244 RVA: 0x006191EC File Offset: 0x006173EC
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

	// Token: 0x06017FC5 RID: 98245 RVA: 0x0061923A File Offset: 0x0061743A
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

	// Token: 0x06017FC6 RID: 98246 RVA: 0x00619254 File Offset: 0x00617454
	public bool IsSelectedToggle()
	{
		UUIExtendToggle uuiextendToggle = this.GetSelectableComponent() as UUIExtendToggle;
		return uuiextendToggle != null && uuiextendToggle.ToggleState == EToggleState.ETT_Checked;
	}

	// Token: 0x06017FC7 RID: 98247 RVA: 0x0061927B File Offset: 0x0061747B
	public void NotifyTextChangeByComponent(string notifyText)
	{
		if (this.PanelConfig == null)
		{
			return;
		}
		this.PanelConfig.UpdateHotKeyTextForce(this.TagArray, notifyText);
	}

	// Token: 0x06017FC8 RID: 98248 RVA: 0x00619298 File Offset: 0x00617498
	public string GetTipsTextIdByState()
	{
		return this.GetNavigationComponent().GetTipsTextId();
	}

	// Token: 0x06017FC9 RID: 98249 RVA: 0x006192A5 File Offset: 0x006174A5
	public TsUiNavigationTextChangeListener GetTextChangeComponent()
	{
		return this.TextChangeComponent;
	}

	// Token: 0x1700205B RID: 8283
	// (get) Token: 0x06017FCA RID: 98250 RVA: 0x006192B0 File Offset: 0x006174B0
	// (set) Token: 0x06017FCB RID: 98251 RVA: 0x006192E9 File Offset: 0x006174E9
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

	// Token: 0x06017FCC RID: 98252 RVA: 0x00619314 File Offset: 0x00617514
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

	// Token: 0x1700205C RID: 8284
	// (get) Token: 0x06017FCD RID: 98253 RVA: 0x00619394 File Offset: 0x00617594
	// (set) Token: 0x06017FCE RID: 98254 RVA: 0x006193CD File Offset: 0x006175CD
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

	// Token: 0x06017FCF RID: 98255 RVA: 0x006193F5 File Offset: 0x006175F5
	public FVector2D GetCursorOffset()
	{
		return this.CursorModule.GetCursorOffset();
	}

	// Token: 0x06017FD0 RID: 98256 RVA: 0x00619402 File Offset: 0x00617602
	public int GetCursorRotation()
	{
		return this.CursorModule.GetCursorRotation();
	}

	// Token: 0x06017FD1 RID: 98257 RVA: 0x0061940F File Offset: 0x0061760F
	public FVector2D GetBoundOffset()
	{
		return this.CursorModule.GetBoundOffset();
	}

	// Token: 0x06017FD2 RID: 98258 RVA: 0x0061941C File Offset: 0x0061761C
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsUiNavigationBehaviorListener._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/UiNavigation/New/TsUiNavigationBehaviorListener.TsUiNavigationBehaviorListener_C");
		}
		return TsUiNavigationBehaviorListener._ClassPtr;
	}

	// Token: 0x06017FD3 RID: 98259 RVA: 0x00619440 File Offset: 0x00617640
	public TsUiNavigationBehaviorListener() : this(BuiltinUtils.AllocNativeUObject(TsUiNavigationBehaviorListener.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06017FD4 RID: 98260 RVA: 0x00619468 File Offset: 0x00617668
	public TsUiNavigationBehaviorListener(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiNavigationBehaviorListener.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06017FD5 RID: 98261 RVA: 0x0061949B File Offset: 0x0061769B
	protected TsUiNavigationBehaviorListener(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06017FD6 RID: 98262 RVA: 0x006194A4 File Offset: 0x006176A4
	protected virtual void __CPPCALL_AwakeBP_Implementation()
	{
		this.AwakeBP_Implementation();
	}

	// Token: 0x06017FD7 RID: 98263 RVA: 0x006194AC File Offset: 0x006176AC
	protected virtual void __CPPCALL_StartBP_Implementation()
	{
		this.StartBP_Implementation();
	}

	// Token: 0x06017FD8 RID: 98264 RVA: 0x006194B4 File Offset: 0x006176B4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_OnNotifyNavigationEnterBP_Implementation(UUINavigationBehaviour.__OnNotifyNavigationEnterBP_FunctionParams* __Params)
	{
		ULGUIPointerEventData orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIPointerEventData>(__Params->eventData);
		this.OnNotifyNavigationEnterBP_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x06017FD9 RID: 98265 RVA: 0x006194D4 File Offset: 0x006176D4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_OnNotifyNavigationSelectBP_Implementation(UUINavigationBehaviour.__OnNotifyNavigationSelectBP_FunctionParams* __Params)
	{
		ULGUIPointerEventData orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIPointerEventData>(__Params->eventData);
		this.OnNotifyNavigationSelectBP_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x06017FDA RID: 98266 RVA: 0x006194F4 File Offset: 0x006176F4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_OnCheckCanSetNavigationBP_Implementation(UUINavigationBehaviour.__OnCheckCanSetNavigationBP_FunctionParams* __Params)
	{
		__Params->__Result = this.OnCheckCanSetNavigationBP_Implementation();
	}

	// Token: 0x06017FDB RID: 98267 RVA: 0x00619502 File Offset: 0x00617702
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_OnCheckLoopScrollChangeNavigationBP_Implementation(UUINavigationBehaviour.__OnCheckLoopScrollChangeNavigationBP_FunctionParams* __Params)
	{
		__Params->__Result = this.OnCheckLoopScrollChangeNavigationBP_Implementation();
	}

	// Token: 0x06017FDC RID: 98268 RVA: 0x00619510 File Offset: 0x00617710
	protected virtual void __CPPCALL_OnEnableBP_Implementation()
	{
		this.OnEnableBP_Implementation();
	}

	// Token: 0x06017FDD RID: 98269 RVA: 0x00619518 File Offset: 0x00617718
	protected virtual void __CPPCALL_OnDisableBP_Implementation()
	{
		this.OnDisableBP_Implementation();
	}

	// Token: 0x06017FDE RID: 98270 RVA: 0x00619520 File Offset: 0x00617720
	protected virtual void __CPPCALL_OnNotifyInteractiveBP_Implementation()
	{
		this.OnNotifyInteractiveBP_Implementation();
	}

	// Token: 0x06017FDF RID: 98271 RVA: 0x00619528 File Offset: 0x00617728
	protected virtual void __CPPCALL_OnNotifyNotInteractiveBP_Implementation()
	{
		this.OnNotifyNotInteractiveBP_Implementation();
	}

	// Token: 0x06017FE0 RID: 98272 RVA: 0x00619530 File Offset: 0x00617730
	protected virtual void __CPPCALL_OnPreDestroyBP_Implementation()
	{
		this.OnPreDestroyBP_Implementation();
	}

	// Token: 0x0400B287 RID: 45703
	[Nullable(2)]
	public UiNavigationScrollProxy ScrollProxy;

	// Token: 0x0400B288 RID: 45704
	[Nullable(2)]
	private UUILayoutBase LayoutBase;

	// Token: 0x0400B289 RID: 45705
	[Nullable(2)]
	private TsUiNavigationTextChangeListener TextChangeComponent;

	// Token: 0x0400B28A RID: 45706
	[Nullable(2)]
	public TsUiNavigationPanelConfig PanelConfig;

	// Token: 0x0400B28B RID: 45707
	private bool InNavigation;

	// Token: 0x0400B28C RID: 45708
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<string, TsUiNavigationBehaviorListener> ChildTagMap;

	// Token: 0x0400B28D RID: 45709
	[Nullable(2)]
	private NavigationSelectableBase NavigationComponent;

	// Token: 0x0400B28E RID: 45710
	private bool IsAwakeCalled;

	// Token: 0x0400B28F RID: 45711
	private bool IsStartCalled;

	// Token: 0x0400B290 RID: 45712
	private bool IsInitLayout;

	// Token: 0x0400B291 RID: 45713
	public bool IsFocusScrollbar;

	// Token: 0x0400B292 RID: 45714
	[Nullable(2)]
	private UUIInturnAnimController AnimController;

	// Token: 0x0400B293 RID: 45715
	private bool IsInitAnimController;

	// Token: 0x0400B294 RID: 45716
	[Nullable(2)]
	public AActor DynamicGridActor;

	// Token: 0x0400B295 RID: 45717
	public int InstanceId;

	// Token: 0x0400B296 RID: 45718
	[Nullable(2)]
	public UiNavigationModeModule ModeModule;

	// Token: 0x0400B297 RID: 45719
	[Nullable(2)]
	private UiNavigationCursorModule CursorModule;

	// Token: 0x0400B298 RID: 45720
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/UiNavigation/New/TsUiNavigationBehaviorListener.TsUiNavigationBehaviorListener_C";

	// Token: 0x0400B299 RID: 45721
	private static IntPtr _ClassPtr;

	// Token: 0x0400B29A RID: 45722
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B29B RID: 45723
	private static int __PropertyOffset_GroupName;

	// Token: 0x0400B29C RID: 45724
	private static int __PropertyOffset_TagArray;

	// Token: 0x0400B29D RID: 45725
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<string> _TagArray;

	// Token: 0x0400B29E RID: 45726
	private static int __PropertyOffset_ExitTagPriority;

	// Token: 0x0400B29F RID: 45727
	private static int __PropertyOffset_ShieldHotKeyIndexArray;

	// Token: 0x0400B2A0 RID: 45728
	[Nullable(2)]
	private TArray<int> _ShieldHotKeyIndexArray;

	// Token: 0x0400B2A1 RID: 45729
	private static int __PropertyOffset_ScrollViewActor;

	// Token: 0x0400B2A2 RID: 45730
	private static int __PropertyOffset_GridBaseActor;

	// Token: 0x0400B2A3 RID: 45731
	private static int __PropertyOffset_LayoutActor;

	// Token: 0x0400B2A4 RID: 45732
	private static int __PropertyOffset_HotKeyTipsTextIdMap;

	// Token: 0x0400B2A5 RID: 45733
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TMap<EHotKeyNameStateType, string> _HotKeyTipsTextIdMap;

	// Token: 0x0400B2A6 RID: 45734
	private static int __PropertyOffset_ClickPivot;

	// Token: 0x0400B2A7 RID: 45735
	private static int __PropertyOffset_InsideGroupActor;

	// Token: 0x0400B2A8 RID: 45736
	private static int __PropertyOffset_InsideActorMap;

	// Token: 0x0400B2A9 RID: 45737
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private TMap<string, AActor> _InsideActorMap;

	// Token: 0x0400B2AA RID: 45738
	private static int __PropertyOffset_ScrollbarIndex;

	// Token: 0x0400B2AB RID: 45739
	private static int __PropertyOffset_InteractiveTag;

	// Token: 0x0400B2AC RID: 45740
	private static int __PropertyOffset_InteractiveParam;

	// Token: 0x0400B2AD RID: 45741
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<string> _InteractiveParam;

	// Token: 0x0400B2AE RID: 45742
	private static int __PropertyOffset_DynamicTag;

	// Token: 0x0400B2AF RID: 45743
	private static int __PropertyOffset_OpenAdsorbed;

	// Token: 0x0400B2B0 RID: 45744
	private static int __PropertyOffset_AdsorbedDistance;

	// Token: 0x0400B2B1 RID: 45745
	private static int __PropertyOffset_AdsorbedPivot;

	// Token: 0x0400B2B2 RID: 45746
	private static int __PropertyOffset_IsUseDrag;

	// Token: 0x0400B2B3 RID: 45747
	private static int __PropertyOffset_IsUsePool;

	// Token: 0x0400B2B4 RID: 45748
	private static int __PropertyOffset_NavigateTolerance;

	// Token: 0x0400B2B5 RID: 45749
	private static int __PropertyOffset_NavigateToleranceReverse;

	// Token: 0x0400B2B6 RID: 45750
	private static int __PropertyOffset_NavigationMode;

	// Token: 0x0400B2B7 RID: 45751
	[Nullable(2)]
	private SNavigationMode _NavigationMode;

	// Token: 0x0400B2B8 RID: 45752
	private static int __PropertyOffset_Cursor;

	// Token: 0x0400B2B9 RID: 45753
	[Nullable(2)]
	private SNavigationCursor _Cursor;
}
