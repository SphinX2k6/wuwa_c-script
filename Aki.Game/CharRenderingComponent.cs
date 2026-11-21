using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.Vehicle.Motor.Diy.HeadLight.Common.Component;
using AkiClient.Game.Aki.Render.RuntimeBP.Character;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Components;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialContainer;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc;
using AkiClient.Game.Aki.Render.RuntimeBP.DecalShadow;
using AkiClient.Game.Aki.Render.RuntimeBP.Interaction;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Render;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020029D5 RID: 10709
[UClass("/Game/Aki/TypeScript/Game/Render/Character/Manager/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Character/Manager/CharRenderingComponent.CharRenderingComponent_C")]
public class CharRenderingComponent : UKuroCharRenderingComponent, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002B6C RID: 11116
	// (get) Token: 0x0601ACBA RID: 109754 RVA: 0x0083A618 File Offset: 0x00838818
	// (set) Token: 0x0601ACBB RID: 109755 RVA: 0x0083A62C File Offset: 0x0083882C
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe PDA_InteractionPlayerConfig_C InteractionConfig
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<PDA_InteractionPlayerConfig_C>(base.NativePtr / (IntPtr)sizeof(void*) + CharRenderingComponent.__PropertyOffset_InteractionConfig);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + CharRenderingComponent.__PropertyOffset_InteractionConfig, value);
		}
	}

	// Token: 0x17002B6D RID: 11117
	// (get) Token: 0x0601ACBC RID: 109756 RVA: 0x0083A641 File Offset: 0x00838841
	// (set) Token: 0x0601ACBD RID: 109757 RVA: 0x0083A655 File Offset: 0x00838855
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe PDA_DecalShadowConfig_C DecalShadowConfig
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<PDA_DecalShadowConfig_C>(base.NativePtr / (IntPtr)sizeof(void*) + CharRenderingComponent.__PropertyOffset_DecalShadowConfig);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + CharRenderingComponent.__PropertyOffset_DecalShadowConfig, value);
		}
	}

	// Token: 0x17002B6E RID: 11118
	// (get) Token: 0x0601ACBE RID: 109758 RVA: 0x0083A66A File Offset: 0x0083886A
	// (set) Token: 0x0601ACBF RID: 109759 RVA: 0x0083A67A File Offset: 0x0083887A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool MonsterUseBodyEffect
	{
		get
		{
			return *(base.NativePtr + (IntPtr)CharRenderingComponent.__PropertyOffset_MonsterUseBodyEffect) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)CharRenderingComponent.__PropertyOffset_MonsterUseBodyEffect) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002B6F RID: 11119
	// (get) Token: 0x0601ACC0 RID: 109760 RVA: 0x0083A68B File Offset: 0x0083888B
	// (set) Token: 0x0601ACC1 RID: 109761 RVA: 0x0083A69B File Offset: 0x0083889B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool UseProxy
	{
		get
		{
			return *(base.NativePtr + (IntPtr)CharRenderingComponent.__PropertyOffset_UseProxy) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)CharRenderingComponent.__PropertyOffset_UseProxy) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002B70 RID: 11120
	// (get) Token: 0x0601ACC2 RID: 109762 RVA: 0x0083A6AC File Offset: 0x008388AC
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<UMaterialInterface> ProxyMaterialsOverride
	{
		[NullableContext(1)]
		get
		{
			base.FastCheckIsValid();
			TArray<UMaterialInterface> result;
			if ((result = this._ProxyMaterialsOverride) == null)
			{
				result = (this._ProxyMaterialsOverride = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)CharRenderingComponent.__PropertyOffset_ProxyMaterialsOverride, this));
			}
			return result;
		}
	}

	// Token: 0x17002B71 RID: 11121
	// (get) Token: 0x0601ACC3 RID: 109763 RVA: 0x0083A6E5 File Offset: 0x008388E5
	// (set) Token: 0x0601ACC4 RID: 109764 RVA: 0x0083A6F5 File Offset: 0x008388F5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool ProxyRenderInMainPass
	{
		get
		{
			return *(base.NativePtr + (IntPtr)CharRenderingComponent.__PropertyOffset_ProxyRenderInMainPass) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)CharRenderingComponent.__PropertyOffset_ProxyRenderInMainPass) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002B72 RID: 11122
	// (get) Token: 0x0601ACC5 RID: 109765 RVA: 0x0083A706 File Offset: 0x00838906
	// (set) Token: 0x0601ACC6 RID: 109766 RVA: 0x0083A716 File Offset: 0x00838916
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool ProxyRenderShadow
	{
		get
		{
			return *(base.NativePtr + (IntPtr)CharRenderingComponent.__PropertyOffset_ProxyRenderShadow) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)CharRenderingComponent.__PropertyOffset_ProxyRenderShadow) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002B73 RID: 11123
	// (get) Token: 0x0601ACC7 RID: 109767 RVA: 0x0083A727 File Offset: 0x00838927
	// (set) Token: 0x0601ACC8 RID: 109768 RVA: 0x0083A737 File Offset: 0x00838937
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool ProxyRenderTrail
	{
		get
		{
			return *(base.NativePtr + (IntPtr)CharRenderingComponent.__PropertyOffset_ProxyRenderTrail) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)CharRenderingComponent.__PropertyOffset_ProxyRenderTrail) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002B74 RID: 11124
	// (get) Token: 0x0601ACC9 RID: 109769 RVA: 0x0083A748 File Offset: 0x00838948
	// (set) Token: 0x0601ACCA RID: 109770 RVA: 0x0083A758 File Offset: 0x00838958
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float DitherRemap
	{
		get
		{
			return *(base.NativePtr + (IntPtr)CharRenderingComponent.__PropertyOffset_DitherRemap);
		}
		set
		{
			*(base.NativePtr + (IntPtr)CharRenderingComponent.__PropertyOffset_DitherRemap) = value;
		}
	}

	// Token: 0x0601ACCB RID: 109771 RVA: 0x0083A769 File Offset: 0x00838969
	private void PreBodyInfoRuntimeInitEvent(FName bodyName)
	{
		this.PreBodyInfoRuntimeInit(bodyName);
	}

	// Token: 0x0601ACCC RID: 109772 RVA: 0x0083A772 File Offset: 0x00838972
	private void PostBodyInfoRuntimeInitEvent(FName bodyName)
	{
		this.PostBodyInfoRuntimeInit(bodyName);
	}

	// Token: 0x0601ACCD RID: 109773 RVA: 0x0083A77C File Offset: 0x0083897C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual float QuickInitAndAddData(UObject data, [Nullable(2)] ASkeletalMeshActor meshActor = null)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("QuickInitAndAddData"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			return this.QuickInitAndAddData_Implementation(data, meshActor);
		}
		CharRenderingComponent.__QuickInitAndAddData_FunctionParams* ptr = stackalloc CharRenderingComponent.__QuickInitAndAddData_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__QuickInitAndAddData_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->data) = ((data != null) ? data.NativePtr : ((IntPtr)0));
		*(&ptr->meshActor) = ((meshActor != null) ? meshActor.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		float _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0601ACCE RID: 109774 RVA: 0x0083A834 File Offset: 0x00838A34
	[NullableContext(1)]
	protected float QuickInitAndAddData_Implementation(UObject data, [Nullable(2)] ASkeletalMeshActor meshActor = null)
	{
		RenderStats.Init();
		if (!this.CheckInit())
		{
			this.Init(ECharacterRenderingType.Sequence);
		}
		if (!(base.GetOwner() is TsBaseCharacter) && meshActor != null)
		{
			this.AddComponentByCase(ECharacterControllerCaseType.BodyCase0, meshActor.SkeletalMeshComponent);
		}
		int num = this.AddMaterialControllerData(data);
		this.SequenceHandleIds.Add(num);
		return (float)num;
	}

	// Token: 0x0601ACCF RID: 109775 RVA: 0x0083A888 File Offset: 0x00838A88
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual float QuickInitAndAddDataWithMeshComponent(UObject data, [Nullable(2)] UMeshComponent meshComponent = null)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("QuickInitAndAddDataWithMeshComponent"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			return this.QuickInitAndAddDataWithMeshComponent_Implementation(data, meshComponent);
		}
		CharRenderingComponent.__QuickInitAndAddDataWithMeshComponent_FunctionParams* ptr = stackalloc CharRenderingComponent.__QuickInitAndAddDataWithMeshComponent_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__QuickInitAndAddDataWithMeshComponent_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->data) = ((data != null) ? data.NativePtr : ((IntPtr)0));
		*(&ptr->meshComponent) = ((meshComponent != null) ? meshComponent.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		float _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0601ACD0 RID: 109776 RVA: 0x0083A940 File Offset: 0x00838B40
	[NullableContext(1)]
	protected float QuickInitAndAddDataWithMeshComponent_Implementation(UObject data, [Nullable(2)] UMeshComponent meshComponent = null)
	{
		RenderStats.Init();
		if (!this.CheckInit())
		{
			this.Init(ECharacterRenderingType.Sequence);
		}
		if (!(base.GetOwner() is TsBaseCharacter) && meshComponent != null)
		{
			this.AddComponentByCase(ECharacterControllerCaseType.BodyCase0, meshComponent);
		}
		int num = this.AddMaterialControllerData(data);
		this.SequenceHandleIds.Add(num);
		return (float)num;
	}

	// Token: 0x0601ACD1 RID: 109777 RVA: 0x0083A990 File Offset: 0x00838B90
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual float QuickInitAndAddDataGroup(UObject data, [Nullable(2)] ASkeletalMeshActor meshActor = null)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("QuickInitAndAddDataGroup"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			return this.QuickInitAndAddDataGroup_Implementation(data, meshActor);
		}
		CharRenderingComponent.__QuickInitAndAddDataGroup_FunctionParams* ptr = stackalloc CharRenderingComponent.__QuickInitAndAddDataGroup_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__QuickInitAndAddDataGroup_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->data) = ((data != null) ? data.NativePtr : ((IntPtr)0));
		*(&ptr->meshActor) = ((meshActor != null) ? meshActor.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		float _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0601ACD2 RID: 109778 RVA: 0x0083AA48 File Offset: 0x00838C48
	[NullableContext(1)]
	protected float QuickInitAndAddDataGroup_Implementation(UObject data, [Nullable(2)] ASkeletalMeshActor meshActor = null)
	{
		RenderStats.Init();
		if (!this.CheckInit())
		{
			this.Init(ECharacterRenderingType.Sequence);
		}
		if (!(base.GetOwner() is TsBaseCharacter) && meshActor != null)
		{
			this.AddComponentByCase(ECharacterControllerCaseType.BodyCase0, meshActor.SkeletalMeshComponent);
		}
		int num = this.AddMaterialControllerDataGroup(data);
		this.SequenceHandleIds.Add(num);
		return (float)num;
	}

	// Token: 0x0601ACD3 RID: 109779 RVA: 0x0083AA9C File Offset: 0x00838C9C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual float QuickInitAndAddDataGroupWithMeshComponent(UObject data, [Nullable(2)] UMeshComponent meshComponent = null)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("QuickInitAndAddDataGroupWithMeshComponent"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			return this.QuickInitAndAddDataGroupWithMeshComponent_Implementation(data, meshComponent);
		}
		CharRenderingComponent.__QuickInitAndAddDataGroupWithMeshComponent_FunctionParams* ptr = stackalloc CharRenderingComponent.__QuickInitAndAddDataGroupWithMeshComponent_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__QuickInitAndAddDataGroupWithMeshComponent_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->data) = ((data != null) ? data.NativePtr : ((IntPtr)0));
		*(&ptr->meshComponent) = ((meshComponent != null) ? meshComponent.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		float _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0601ACD4 RID: 109780 RVA: 0x0083AB54 File Offset: 0x00838D54
	[NullableContext(1)]
	protected float QuickInitAndAddDataGroupWithMeshComponent_Implementation(UObject data, [Nullable(2)] UMeshComponent meshComponent = null)
	{
		RenderStats.Init();
		if (!this.CheckInit())
		{
			this.Init(ECharacterRenderingType.Sequence);
		}
		if (!(base.GetOwner() is TsBaseCharacter) && meshComponent != null)
		{
			this.AddComponentByCase(ECharacterControllerCaseType.BodyCase0, meshComponent);
		}
		int num = this.AddMaterialControllerDataGroup(data);
		this.SequenceHandleIds.Add(num);
		return (float)num;
	}

	// Token: 0x0601ACD5 RID: 109781 RVA: 0x0083ABA4 File Offset: 0x00838DA4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void Init(ECharacterRenderingType renderType)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("Init"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			this.Init_Implementation(renderType);
			return;
		}
		CharRenderingComponent.__Init_FunctionParams* ptr = stackalloc CharRenderingComponent.__Init_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__Init_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->renderType) = (byte)renderType;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601ACD6 RID: 109782 RVA: 0x0083AC34 File Offset: 0x00838E34
	protected unsafe void Init_Implementation(ECharacterRenderingType renderType)
	{
		if (!this.IsValid())
		{
			return;
		}
		bool flag = false;
		this.CachedOwner = base.GetOwner();
		this.CachedOwnerName = this.CachedOwner.GetName();
		TsBaseCharacter tsBaseCharacter = this.CachedOwner as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			this.CachedOwnerEntity = tsBaseCharacter.GetEntityNoBlueprint();
		}
		if (this.IsInit)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderCharacter;
			ELogAuthor author = ELogAuthor.MY;
			string message = "材质控制器已初始化";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Actor", this.CachedOwnerName);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			flag = true;
		}
		if (renderType == ECharacterRenderingType.Error)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.RenderCharacter;
			ELogAuthor author2 = ELogAuthor.MY;
			string message2 = "错误：初始化参数错误. 初始化类型不应为Error";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Actor", this.CachedOwnerName);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			flag = true;
		}
		if (!flag)
		{
			if (renderType == ECharacterRenderingType.Effect)
			{
				this.IsUiUpdate = GlobalData.IsUiSceneOpen;
			}
			if (renderType == ECharacterRenderingType.Npc)
			{
				TsBaseCharacter tsBaseCharacter2 = this.CachedOwner as TsBaseCharacter;
				if (tsBaseCharacter2 != null && tsBaseCharacter2.Mesh != null)
				{
					tsBaseCharacter2.Mesh.IsSpecialForLocalLightShadow = true;
				}
			}
			this.DeltaTime = 0f;
			this.IsOnMobile = (UKuroRenderingRuntimeBPPluginBPLibrary.GetWorldFeatureLevel(GlobalData.World) == KuroFeatureLevel.ES3_1);
			this.AllRenderComps = new List<CharRenderBase>();
			this.AllRenderCompsMap = new Dictionary<int, CharRenderBase>();
			this.IsInit = false;
			this.IsStartInvoke = false;
			this.RenderType = new ECharacterRenderingType?(renderType);
			this.TempRemoveList = new List<int>();
			this.SequenceHandleIds = new List<int>();
			this.IsDebug = false;
			foreach (CharRenderBase charRenderBase in this.GetRenderComps())
			{
				if (this.AllRenderCompsMap.ContainsKey(charRenderBase.GetComponentId()))
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.RenderCharacter;
					ELogAuthor author3 = ELogAuthor.MY;
					string message3 = "错误:重复添加渲染模块 ID";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Actor", this.CachedOwnerName);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("渲染模块ID", charRenderBase.GetComponentId());
					instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				else
				{
					this.AllRenderCompsMap[charRenderBase.GetComponentId()] = charRenderBase;
					this.AllRenderComps.Add(charRenderBase);
					charRenderBase.Awake(this);
				}
			}
			this.IsInit = true;
			this.IsStartInvoke = false;
			this.IndexCount = 0;
			this.AllMaterialControlRuntimeDataGroupMap = new Dictionary<int, CharMaterialControlRuntimeDataGroup>();
			this.InvokeStart();
		}
	}

	// Token: 0x0601ACD7 RID: 109783 RVA: 0x0083AE88 File Offset: 0x00839088
	[NullableContext(1)]
	[return: Nullable(2)]
	private unsafe CharRenderBase AddRenderCompDynamic(CharRenderBase comp)
	{
		if (!this.IsInit)
		{
			return null;
		}
		if (this.AllRenderCompsMap.ContainsKey(comp.GetComponentId()))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderCharacter;
			ELogAuthor author = ELogAuthor.MY;
			string message = "错误:动态重复添加渲染模块 ID";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Actor", this.CachedOwnerName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("渲染模块ID", comp.GetComponentId());
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}
		comp.Awake(this);
		this.AllRenderCompsMap[comp.GetComponentId()] = comp;
		this.AllRenderComps.Add(comp);
		try
		{
			comp.Start();
		}
		catch
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.RenderCharacter;
			ELogAuthor author2 = ELogAuthor.LSY;
			string message2 = "错误:动态添加组件初始化错误:";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Actor", base.GetOwner());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("组件ID", comp.GetComponentId());
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return null;
		}
		if (!comp.GetIsInitSuc())
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.RenderCharacter;
			ELogAuthor author3 = ELogAuthor.LSY;
			string message3 = "错误:动态添加组件初始化错误:";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("Actor", base.GetOwner());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("组件ID", comp.GetComponentId());
			instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
			return null;
		}
		return comp;
	}

	// Token: 0x0601ACD8 RID: 109784 RVA: 0x0083B02C File Offset: 0x0083922C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetLogicOwner(AActor owner)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetLogicOwner"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			this.SetLogicOwner_Implementation(owner);
			return;
		}
		CharRenderingComponent.__SetLogicOwner_FunctionParams* ptr = stackalloc CharRenderingComponent.__SetLogicOwner_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__SetLogicOwner_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->owner) = ((owner != null) ? owner.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601ACD9 RID: 109785 RVA: 0x0083B0C6 File Offset: 0x008392C6
	[NullableContext(2)]
	protected void SetLogicOwner_Implementation(AActor owner)
	{
		this.LogicOwner = owner;
		if (this.LogicOwner != null)
		{
			this.IsLogicOwnerTsEffectActor = (this.LogicOwner is AEffectSystemActor);
		}
	}

	// Token: 0x0601ACDA RID: 109786 RVA: 0x0083B0EC File Offset: 0x008392EC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void AddComponent(string skelName, UMeshComponent skeletalComp)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AddComponent"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			this.AddComponent_Implementation(skelName, skeletalComp);
			return;
		}
		CharRenderingComponent.__AddComponent_FunctionParams* ptr = stackalloc CharRenderingComponent.__AddComponent_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__AddComponent_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		FString.CopyFrom((void*)(&ptr->skelName), skelName);
		*(&ptr->skeletalComp) = ((skeletalComp != null) ? skeletalComp.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601ACDB RID: 109787 RVA: 0x0083B194 File Offset: 0x00839394
	[NullableContext(1)]
	protected void AddComponent_Implementation(string skelName, UMeshComponent skeletalComp)
	{
		if (this.IsInDebugMode)
		{
			Log.Instance.Warn(ELogModule.RenderCharacter, ELogAuthor.ZJF, "【DEPRECATED】请使用AddComponentByCase接口", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		this.AddComponentInner(skelName, skeletalComp, false);
	}

	// Token: 0x0601ACDC RID: 109788 RVA: 0x0083B1D0 File Offset: 0x008393D0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void AddComponentWithEmptyMaterial(string skelName, UMeshComponent skeletalComp)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AddComponentWithEmptyMaterial"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			this.AddComponentWithEmptyMaterial_Implementation(skelName, skeletalComp);
			return;
		}
		CharRenderingComponent.__AddComponentWithEmptyMaterial_FunctionParams* ptr = stackalloc CharRenderingComponent.__AddComponentWithEmptyMaterial_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__AddComponentWithEmptyMaterial_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		FString.CopyFrom((void*)(&ptr->skelName), skelName);
		*(&ptr->skeletalComp) = ((skeletalComp != null) ? skeletalComp.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601ACDD RID: 109789 RVA: 0x0083B278 File Offset: 0x00839478
	[NullableContext(1)]
	protected void AddComponentWithEmptyMaterial_Implementation(string skelName, UMeshComponent skeletalComp)
	{
		this.AddComponentInner(skelName, skeletalComp, true);
	}

	// Token: 0x0601ACDE RID: 109790 RVA: 0x0083B284 File Offset: 0x00839484
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void RemoveComponent(string skelName)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("RemoveComponent"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			this.RemoveComponent_Implementation(skelName);
			return;
		}
		CharRenderingComponent.__RemoveComponent_FunctionParams* ptr = stackalloc CharRenderingComponent.__RemoveComponent_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__RemoveComponent_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		FString.CopyFrom((void*)(&ptr->skelName), skelName);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601ACDF RID: 109791 RVA: 0x0083B318 File Offset: 0x00839518
	[NullableContext(1)]
	protected void RemoveComponent_Implementation(string skelName)
	{
		if (this.IsInDebugMode)
		{
			Log.Instance.Warn(ELogModule.RenderCharacter, ELogAuthor.ZJF, "【DEPRECATED】请使用RemoveComponentByCase接口", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		this.RemoveComponentInner(skelName);
	}

	// Token: 0x0601ACE0 RID: 109792 RVA: 0x0083B350 File Offset: 0x00839550
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void AddComponentByCase(ECharacterControllerCaseType caseType, UMeshComponent skeletalComp)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AddComponentByCase"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			this.AddComponentByCase_Implementation(caseType, skeletalComp);
			return;
		}
		CharRenderingComponent.__AddComponentByCase_FunctionParams* ptr = stackalloc CharRenderingComponent.__AddComponentByCase_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__AddComponentByCase_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->caseType) = (byte)caseType;
		*(&ptr->skeletalComp) = ((skeletalComp != null) ? skeletalComp.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601ACE1 RID: 109793 RVA: 0x0083B3F4 File Offset: 0x008395F4
	[NullableContext(2)]
	protected void AddComponentByCase_Implementation(ECharacterControllerCaseType caseType, UMeshComponent skeletalComp)
	{
		if (skeletalComp == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderCharacter;
			ELogAuthor author = ELogAuthor.MY;
			string message = "添加的MeshComponent是失效的";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Actor", this.CachedOwner);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		string text = RenderConfig.MaterialControlAllCaseArray[(int)caseType];
		if (text != null)
		{
			this.AddComponentInner(text, skeletalComp, false);
		}
	}

	// Token: 0x0601ACE2 RID: 109794 RVA: 0x0083B448 File Offset: 0x00839648
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void RemoveComponentByCase(ECharacterControllerCaseType caseType)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("RemoveComponentByCase"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			this.RemoveComponentByCase_Implementation(caseType);
			return;
		}
		CharRenderingComponent.__RemoveComponentByCase_FunctionParams* ptr = stackalloc CharRenderingComponent.__RemoveComponentByCase_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__RemoveComponentByCase_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->caseType) = (byte)caseType;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601ACE3 RID: 109795 RVA: 0x0083B4D8 File Offset: 0x008396D8
	protected void RemoveComponentByCase_Implementation(ECharacterControllerCaseType caseType)
	{
		string text = RenderConfig.MaterialControlAllCaseArray[(int)caseType];
		if (text != null)
		{
			this.RemoveComponentInner(text);
		}
	}

	// Token: 0x0601ACE4 RID: 109796 RVA: 0x0083B4F8 File Offset: 0x008396F8
	[NullableContext(1)]
	public void AddComponentInner(string skelName, UMeshComponent skeletalComp, bool useEmptyMaterial)
	{
		if (this.UseMaterialContainerV2)
		{
			this.AddComponentInnerV2(skelName, skeletalComp, useEmptyMaterial);
		}
		else
		{
			CharMaterialContainer charMaterialContainer = this.GetComponent(1) as CharMaterialContainer;
			CharMaterialController charMaterialController = this.GetComponent(2) as CharMaterialController;
			bool flag = false;
			if (charMaterialController != null)
			{
				charMaterialController.RemoveSkeletalMeshMaterialControllerData(skelName);
			}
			if (charMaterialContainer != null)
			{
				charMaterialContainer.RemoveSkeletalComponent(skelName);
				flag = charMaterialContainer.AddSkeletalComponent((USkeletalMeshComponent)skeletalComp, skelName, useEmptyMaterial);
			}
			if (!flag)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderCharacter;
				ELogAuthor author = ELogAuthor.MY;
				string message = "添加的MeshComponent是失效的!";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Actor", this.CachedOwner);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}
		this.AddComponentForDecalShadow(skelName, skeletalComp);
	}

	// Token: 0x0601ACE5 RID: 109797 RVA: 0x0083B590 File Offset: 0x00839790
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void AddComponentInnerV2(string skelName, UMeshComponent skeletalComp, bool useEmptyMaterial)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AddComponentInnerV2"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			this.AddComponentInnerV2_Implementation(skelName, skeletalComp, useEmptyMaterial);
			return;
		}
		CharRenderingComponent.__AddComponentInnerV2_FunctionParams* ptr = stackalloc CharRenderingComponent.__AddComponentInnerV2_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__AddComponentInnerV2_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		FString.CopyFrom((void*)(&ptr->skelName), skelName);
		*(&ptr->skeletalComp) = ((skeletalComp != null) ? skeletalComp.NativePtr : ((IntPtr)0));
		ptr->useEmptyMaterial = useEmptyMaterial;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601ACE6 RID: 109798 RVA: 0x0083B640 File Offset: 0x00839840
	[NullableContext(1)]
	protected void AddComponentInnerV2_Implementation(string skelName, UMeshComponent skeletalComp, bool useEmptyMaterial)
	{
		CharMaterialContainerV2 charMaterialContainerV = this.GetComponent(13) as CharMaterialContainerV2;
		if (charMaterialContainerV != null)
		{
			charMaterialContainerV.RemoveSkeletalComponent(skelName);
			charMaterialContainerV.AddSkeletalComponent((USkeletalMeshComponent)skeletalComp, skelName, useEmptyMaterial);
		}
	}

	// Token: 0x0601ACE7 RID: 109799 RVA: 0x0083B674 File Offset: 0x00839874
	[NullableContext(1)]
	public void RemoveComponentInner(string skelName)
	{
		if (this.UseMaterialContainerV2)
		{
			this.RemoveComponentInnerV2(skelName);
		}
		else
		{
			CharMaterialContainer charMaterialContainer = this.GetComponent(1) as CharMaterialContainer;
			CharMaterialController charMaterialController = this.GetComponent(2) as CharMaterialController;
			if (charMaterialController != null)
			{
				charMaterialController.RemoveSkeletalMeshMaterialControllerData(skelName);
			}
			if (charMaterialContainer != null && !charMaterialContainer.RemoveSkeletalComponent(skelName))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderCharacter;
				ELogAuthor author = ELogAuthor.MY;
				string message = "无法找到要删除的MeshComponent";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Actor", base.GetOwner());
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}
		this.RemoveComponentFromDecalShadow(skelName);
	}

	// Token: 0x0601ACE8 RID: 109800 RVA: 0x0083B6F8 File Offset: 0x008398F8
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void RemoveComponentInnerV2(string skelName)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("RemoveComponentInnerV2"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			this.RemoveComponentInnerV2_Implementation(skelName);
			return;
		}
		CharRenderingComponent.__RemoveComponentInnerV2_FunctionParams* ptr = stackalloc CharRenderingComponent.__RemoveComponentInnerV2_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__RemoveComponentInnerV2_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		FString.CopyFrom((void*)(&ptr->skelName), skelName);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601ACE9 RID: 109801 RVA: 0x0083B78C File Offset: 0x0083998C
	[NullableContext(1)]
	protected void RemoveComponentInnerV2_Implementation(string skelName)
	{
		CharMaterialContainerV2 charMaterialContainerV = this.GetComponent(13) as CharMaterialContainerV2;
		if (charMaterialContainerV != null)
		{
			charMaterialContainerV.RemoveSkeletalComponent(skelName);
		}
	}

	// Token: 0x0601ACEA RID: 109802 RVA: 0x0083B7B4 File Offset: 0x008399B4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	[return: Nullable(2)]
	public unsafe virtual USkeletalMeshComponent GetSkeletalMeshComponent(string skelName)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetSkeletalMeshComponent"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			return this.GetSkeletalMeshComponent_Implementation(skelName);
		}
		CharRenderingComponent.__GetSkeletalMeshComponent_FunctionParams* ptr = stackalloc CharRenderingComponent.__GetSkeletalMeshComponent_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__GetSkeletalMeshComponent_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		FString.CopyFrom((void*)(&ptr->skelName), skelName);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(ptr->__Result);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return orCreateUObjectByNativePointer;
	}

	// Token: 0x0601ACEB RID: 109803 RVA: 0x0083B854 File Offset: 0x00839A54
	[NullableContext(1)]
	[return: Nullable(2)]
	protected USkeletalMeshComponent GetSkeletalMeshComponent_Implementation(string skelName)
	{
		if (this.UseMaterialContainerV2)
		{
			CharMaterialContainerV2 charMaterialContainerV = this.GetComponent(13) as CharMaterialContainerV2;
			if (charMaterialContainerV != null)
			{
				return charMaterialContainerV.GetSkeletalComponent(skelName);
			}
		}
		else
		{
			CharMaterialContainer charMaterialContainer = this.GetComponent(1) as CharMaterialContainer;
			if (charMaterialContainer != null)
			{
				CharBodyInfo charBodyInfo = (charMaterialContainer.AllBodyInfoList != null && charMaterialContainer.AllBodyInfoList.ContainsKey(skelName)) ? charMaterialContainer.AllBodyInfoList[skelName] : null;
				if (charBodyInfo == null)
				{
					return null;
				}
				return charBodyInfo.SkeletalComp;
			}
		}
		return null;
	}

	// Token: 0x0601ACEC RID: 109804 RVA: 0x0083B8C4 File Offset: 0x00839AC4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual FName GetSkeletalMeshComponentBodyName(USkeletalMeshComponent skeletalComp)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetSkeletalMeshComponentBodyName"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			return this.GetSkeletalMeshComponentBodyName_Implementation(skeletalComp);
		}
		CharRenderingComponent.__GetSkeletalMeshComponentBodyName_FunctionParams* ptr = stackalloc CharRenderingComponent.__GetSkeletalMeshComponentBodyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__GetSkeletalMeshComponentBodyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->skeletalComp) = ((skeletalComp != null) ? skeletalComp.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		FName _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0601ACED RID: 109805 RVA: 0x0083B964 File Offset: 0x00839B64
	[NullableContext(1)]
	protected FName GetSkeletalMeshComponentBodyName_Implementation(USkeletalMeshComponent skeletalComp)
	{
		if (this.UseMaterialContainerV2)
		{
			CharMaterialContainerV2 charMaterialContainerV = this.GetComponent(13) as CharMaterialContainerV2;
			if (charMaterialContainerV != null)
			{
				return charMaterialContainerV.GetSkeletalMeshComponentBodyName(skeletalComp);
			}
		}
		return FName.NAME_None;
	}

	// Token: 0x0601ACEE RID: 109806 RVA: 0x0083B998 File Offset: 0x00839B98
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual bool CheckInit()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("CheckInit"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			return this.CheckInit_Implementation();
		}
		CharRenderingComponent.__CheckInit_FunctionParams* ptr = stackalloc CharRenderingComponent.__CheckInit_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__CheckInit_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0601ACEF RID: 109807 RVA: 0x0083BA22 File Offset: 0x00839C22
	protected bool CheckInit_Implementation()
	{
		return this.IsInit;
	}

	// Token: 0x0601ACF0 RID: 109808 RVA: 0x0083BA2C File Offset: 0x00839C2C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetDebug(bool value)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetDebug"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			this.SetDebug_Implementation(value);
			return;
		}
		CharRenderingComponent.__SetDebug_FunctionParams* ptr = stackalloc CharRenderingComponent.__SetDebug_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__SetDebug_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->value = value;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601ACF1 RID: 109809 RVA: 0x0083BAB8 File Offset: 0x00839CB8
	protected void SetDebug_Implementation(bool value)
	{
		this.IsDebug = value;
	}

	// Token: 0x0601ACF2 RID: 109810 RVA: 0x0083BAC4 File Offset: 0x00839CC4
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual PD_MaterialDebug_C GetDebugInfo()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetDebugInfo"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			return this.GetDebugInfo_Implementation();
		}
		CharRenderingComponent.__GetDebugInfo_FunctionParams* ptr = stackalloc CharRenderingComponent.__GetDebugInfo_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__GetDebugInfo_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		PD_MaterialDebug_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<PD_MaterialDebug_C>(ptr->__Result);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return orCreateUObjectByNativePointer;
	}

	// Token: 0x0601ACF3 RID: 109811 RVA: 0x0083BB54 File Offset: 0x00839D54
	[NullableContext(2)]
	protected PD_MaterialDebug_C GetDebugInfo_Implementation()
	{
		CharMaterialController charMaterialController = this.GetComponent(2) as CharMaterialController;
		if (charMaterialController == null)
		{
			return null;
		}
		if (this.IsDebug)
		{
			charMaterialController.EnableDebug = true;
			return charMaterialController.DebugInfo;
		}
		charMaterialController.EnableDebug = false;
		return null;
	}

	// Token: 0x0601ACF4 RID: 109812 RVA: 0x0083BB91 File Offset: 0x00839D91
	[NullableContext(2)]
	public CharRenderBase GetComponent(int componentId)
	{
		if (this.IsInit && this.AllRenderCompsMap.ContainsKey(componentId))
		{
			return this.AllRenderCompsMap[componentId];
		}
		return null;
	}

	// Token: 0x0601ACF5 RID: 109813 RVA: 0x0083BBB7 File Offset: 0x00839DB7
	public void Tick(float delta)
	{
		this.Update(delta);
	}

	// Token: 0x0601ACF6 RID: 109814 RVA: 0x0083BBC0 File Offset: 0x00839DC0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveEndPlay(EEndPlayReason endPlayReason)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveEndPlay"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			this.ReceiveEndPlay_Implementation(endPlayReason);
			return;
		}
		UActorComponent.__ReceiveEndPlay_FunctionParams* ptr = stackalloc UActorComponent.__ReceiveEndPlay_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UActorComponent.__ReceiveEndPlay_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(byte*)(&ptr->EndPlayReason) = (byte)endPlayReason;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601ACF7 RID: 109815 RVA: 0x0083BC4F File Offset: 0x00839E4F
	protected virtual void ReceiveEndPlay_Implementation(EEndPlayReason endPlayReason)
	{
		if (endPlayReason != EEndPlayReason.EndPlayInEditor)
		{
			this.Destroy();
		}
	}

	// Token: 0x0601ACF8 RID: 109816 RVA: 0x0083BC5B File Offset: 0x00839E5B
	public float GetDeltaTime()
	{
		return this.DeltaTime;
	}

	// Token: 0x0601ACF9 RID: 109817 RVA: 0x0083BC64 File Offset: 0x00839E64
	[NullableContext(1)]
	public float GetTimeDilation(LogicalTimeDilationOut outVal)
	{
		float num = RenderModuleController.Instance.IsGamePaused ? 0f : RenderModuleController.Instance.GlobalTimeDilation;
		if (num == 0f)
		{
			return 0f;
		}
		if (this.LogicOwner != null && this.IsLogicOwnerTsEffectActor)
		{
			AEffectSystemActor aeffectSystemActor = (AEffectSystemActor)this.LogicOwner;
			num *= aeffectSystemActor.GetTimeScale();
		}
		else
		{
			Entity cachedOwnerEntity = this.CachedOwnerEntity;
			CharacterTimeScaleComponent characterTimeScaleComponent = (cachedOwnerEntity != null) ? cachedOwnerEntity.GetComponent<CharacterTimeScaleComponent>() : null;
			if (characterTimeScaleComponent != null)
			{
				float num2 = this.CachedOwnerEntity.TimeDilation * characterTimeScaleComponent.CurrentTimeScale;
				if (num2 > 1f)
				{
					num *= num2;
				}
				outVal.LogicalTimeDilation = num2;
			}
		}
		return num;
	}

	// Token: 0x0601ACFA RID: 109818 RVA: 0x0083BD04 File Offset: 0x00839F04
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual bool GetInWater(float depthThreshold = 2f)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetInWater"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			return this.GetInWater_Implementation(depthThreshold);
		}
		CharRenderingComponent.__GetInWater_FunctionParams* ptr = stackalloc CharRenderingComponent.__GetInWater_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__GetInWater_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->depthThreshold = depthThreshold;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0601ACFB RID: 109819 RVA: 0x0083BD96 File Offset: 0x00839F96
	protected bool GetInWater_Implementation(float depthThreshold = 2f)
	{
		CharSceneInteraction charSceneInteraction = this.GetComponent(5) as CharSceneInteraction;
		return charSceneInteraction != null && charSceneInteraction.GetInWater(depthThreshold);
	}

	// Token: 0x0601ACFC RID: 109820 RVA: 0x0083BDB0 File Offset: 0x00839FB0
	public float GetWaterHitLocationZ()
	{
		CharSceneInteraction charSceneInteraction = this.GetComponent(5) as CharSceneInteraction;
		if (charSceneInteraction != null)
		{
			return (float)charSceneInteraction.GetWaterHitLocationZ();
		}
		return 0f;
	}

	// Token: 0x0601ACFD RID: 109821 RVA: 0x0083BDDC File Offset: 0x00839FDC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual bool GetInAudioShr()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetInAudioShr"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			return this.GetInAudioShr_Implementation();
		}
		CharRenderingComponent.__GetInAudioShr_FunctionParams* ptr = stackalloc CharRenderingComponent.__GetInAudioShr_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__GetInAudioShr_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0601ACFE RID: 109822 RVA: 0x0083BE68 File Offset: 0x0083A068
	protected bool GetInAudioShr_Implementation()
	{
		CharSceneInteraction charSceneInteraction = this.GetComponent(5) as CharSceneInteraction;
		return charSceneInteraction != null && charSceneInteraction.GetInAudioShr();
	}

	// Token: 0x0601ACFF RID: 109823 RVA: 0x0083BE90 File Offset: 0x0083A090
	public FName GetAudioShrTag()
	{
		CharSceneInteraction charSceneInteraction = this.GetComponent(5) as CharSceneInteraction;
		if (charSceneInteraction == null)
		{
			return FNameUtil.NONE;
		}
		return charSceneInteraction.GetAudioShrTag();
	}

	// Token: 0x0601AD00 RID: 109824 RVA: 0x0083BEB9 File Offset: 0x0083A0B9
	public ECharacterRenderingType? GetRenderType()
	{
		return this.RenderType;
	}

	// Token: 0x0601AD01 RID: 109825 RVA: 0x0083BEC4 File Offset: 0x0083A0C4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void ResetAllRenderingState()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ResetAllRenderingState"), CharRenderingComponent.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ResetAllRenderingState_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601AD02 RID: 109826 RVA: 0x0083BF20 File Offset: 0x0083A120
	protected void ResetAllRenderingState_Implementation()
	{
		foreach (CharRenderBase charRenderBase in this.AllRenderComps)
		{
			if (charRenderBase.GetIsInitSuc())
			{
				charRenderBase.OnResetRenderState();
			}
		}
		foreach (int p in this.AllMaterialControlRuntimeDataGroupMap.Keys)
		{
			EventSystem.Instance.EmitWithTarget<int>(this, EEventName.OnRemoveMaterialControllerGroup, p);
		}
		Dictionary<int, CharMaterialControlRuntimeDataGroup> allMaterialControlRuntimeDataGroupMap = this.AllMaterialControlRuntimeDataGroupMap;
		if (allMaterialControlRuntimeDataGroupMap == null)
		{
			return;
		}
		allMaterialControlRuntimeDataGroupMap.Clear();
	}

	// Token: 0x0601AD03 RID: 109827 RVA: 0x0083BFDC File Offset: 0x0083A1DC
	public void PreBodyInfoRuntimeInit(FName bodyName)
	{
		foreach (CharRenderBase charRenderBase in this.AllRenderComps)
		{
			if (charRenderBase.GetIsInitSuc())
			{
				charRenderBase.PreBodyInfoRuntimeInit(bodyName);
			}
		}
	}

	// Token: 0x0601AD04 RID: 109828 RVA: 0x0083C038 File Offset: 0x0083A238
	public void PostBodyInfoRuntimeInit(FName bodyName)
	{
		foreach (CharRenderBase charRenderBase in this.AllRenderComps)
		{
			if (charRenderBase.GetIsInitSuc())
			{
				charRenderBase.PostBodyInfoRuntimeInit(bodyName);
			}
		}
	}

	// Token: 0x0601AD05 RID: 109829 RVA: 0x0083C094 File Offset: 0x0083A294
	public void ResetAllRenderingStateForDebug()
	{
		CharMaterialController charMaterialController = this.GetComponent(2) as CharMaterialController;
		if (charMaterialController != null && charMaterialController.AllMaterialControlRuntimeDataMap.Count > 0)
		{
			charMaterialController.PrintCurrentInfo();
			this.ResetAllRenderingState();
		}
	}

	// Token: 0x0601AD06 RID: 109830 RVA: 0x0083C0CC File Offset: 0x0083A2CC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual int AddMaterialControllerDataGroup(UObject data)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AddMaterialControllerDataGroup"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			return this.AddMaterialControllerDataGroup_Implementation(data);
		}
		CharRenderingComponent.__AddMaterialControllerDataGroup_FunctionParams* ptr = stackalloc CharRenderingComponent.__AddMaterialControllerDataGroup_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__AddMaterialControllerDataGroup_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->data) = ((data != null) ? data.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		int _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0601AD07 RID: 109831 RVA: 0x0083C16C File Offset: 0x0083A36C
	[NullableContext(2)]
	protected int AddMaterialControllerDataGroup_Implementation(UObject data)
	{
		return (int)this.AddMaterialControllerDataGroupWithAnimObject(data, null);
	}

	// Token: 0x0601AD08 RID: 109832 RVA: 0x0083C178 File Offset: 0x0083A378
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual float AddMaterialControllerDataGroupWithAnimObject(UObject data, USkeletalMeshComponent animObject = null)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AddMaterialControllerDataGroupWithAnimObject"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			return this.AddMaterialControllerDataGroupWithAnimObject_Implementation(data, animObject);
		}
		CharRenderingComponent.__AddMaterialControllerDataGroupWithAnimObject_FunctionParams* ptr = stackalloc CharRenderingComponent.__AddMaterialControllerDataGroupWithAnimObject_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__AddMaterialControllerDataGroupWithAnimObject_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->data) = ((data != null) ? data.NativePtr : ((IntPtr)0));
		*(&ptr->animObject) = ((animObject != null) ? animObject.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		float _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0601AD09 RID: 109833 RVA: 0x0083C230 File Offset: 0x0083A430
	[NullableContext(2)]
	protected unsafe float AddMaterialControllerDataGroupWithAnimObject_Implementation(UObject data, USkeletalMeshComponent animObject = null)
	{
		PD_CharacterControllerDataGroup_C pd_CharacterControllerDataGroup_C = data as PD_CharacterControllerDataGroup_C;
		if (pd_CharacterControllerDataGroup_C == null)
		{
			return -1f;
		}
		int num = this.IndexCount + 1;
		this.IndexCount = num;
		int num2 = num;
		int num3;
		if (this.UseMaterialContainerV2)
		{
			num3 = (this.GetComponent(14) as CharMaterialControllerV2).GetEffectCount();
		}
		else
		{
			num3 = (this.GetComponent(2) as CharMaterialController).AllMaterialControlRuntimeDataMap.Count;
		}
		if (num3 > 20)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderCharacter;
			ELogAuthor author = ELogAuthor.MY;
			string message = "材质控制器添加失败，超过单个角色的材质控制器队列数量，检查是否进行了材质控制器移除和材质控制器特效的持续时间";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Actor", base.GetOwner());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("添加的材质控制器名称", data);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ID", num2);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}
		if (pd_CharacterControllerDataGroup_C.CleanOriginEffect)
		{
			this.CleanOriginEffect();
		}
		CharMaterialControlRuntimeDataGroup charMaterialControlRuntimeDataGroup = new CharMaterialControlRuntimeDataGroup();
		charMaterialControlRuntimeDataGroup.Init(this, pd_CharacterControllerDataGroup_C, animObject);
		this.AllMaterialControlRuntimeDataGroupMap[num2] = charMaterialControlRuntimeDataGroup;
		EventSystem.Instance.EmitWithTarget<UObject, int>(this, EEventName.OnAddMaterialControllerGroup, data, num2);
		return (float)num2;
	}

	// Token: 0x0601AD0A RID: 109834 RVA: 0x0083C354 File Offset: 0x0083A554
	public void CleanOriginEffect()
	{
		CharMaterialControllerV2 charMaterialControllerV = this.GetComponent(14) as CharMaterialControllerV2;
		if (charMaterialControllerV != null)
		{
			charMaterialControllerV.CleanOriginEffectByOtherData();
		}
	}

	// Token: 0x0601AD0B RID: 109835 RVA: 0x0083C378 File Offset: 0x0083A578
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void RemoveMaterialControllerDataGroup(int handle)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("RemoveMaterialControllerDataGroup"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			this.RemoveMaterialControllerDataGroup_Implementation(handle);
			return;
		}
		CharRenderingComponent.__RemoveMaterialControllerDataGroup_FunctionParams* ptr = stackalloc CharRenderingComponent.__RemoveMaterialControllerDataGroup_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__RemoveMaterialControllerDataGroup_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->handle = handle;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AD0C RID: 109836 RVA: 0x0083C404 File Offset: 0x0083A604
	protected void RemoveMaterialControllerDataGroup_Implementation(int handle)
	{
		CharMaterialControlRuntimeDataGroup charMaterialControlRuntimeDataGroup;
		if (this.AllMaterialControlRuntimeDataGroupMap.TryGetValue(handle, out charMaterialControlRuntimeDataGroup))
		{
			charMaterialControlRuntimeDataGroup.EndState();
		}
	}

	// Token: 0x0601AD0D RID: 109837 RVA: 0x0083C428 File Offset: 0x0083A628
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void RemoveMaterialControllerDataGroupWithEnding(int handle)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("RemoveMaterialControllerDataGroupWithEnding"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			this.RemoveMaterialControllerDataGroupWithEnding_Implementation(handle);
			return;
		}
		CharRenderingComponent.__RemoveMaterialControllerDataGroupWithEnding_FunctionParams* ptr = stackalloc CharRenderingComponent.__RemoveMaterialControllerDataGroupWithEnding_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__RemoveMaterialControllerDataGroupWithEnding_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->handle = handle;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AD0E RID: 109838 RVA: 0x0083C4B4 File Offset: 0x0083A6B4
	protected void RemoveMaterialControllerDataGroupWithEnding_Implementation(int handle)
	{
		CharMaterialControlRuntimeDataGroup charMaterialControlRuntimeDataGroup;
		if (this.AllMaterialControlRuntimeDataGroupMap.TryGetValue(handle, out charMaterialControlRuntimeDataGroup))
		{
			charMaterialControlRuntimeDataGroup.EndStateWithEnding();
		}
	}

	// Token: 0x0601AD0F RID: 109839 RVA: 0x0083C4D7 File Offset: 0x0083A6D7
	[NullableContext(2)]
	public AActor GetCachedOwner()
	{
		return this.CachedOwner;
	}

	// Token: 0x0601AD10 RID: 109840 RVA: 0x0083C4DF File Offset: 0x0083A6DF
	[NullableContext(1)]
	public string GetCachedOwnerName()
	{
		return this.CachedOwnerName;
	}

	// Token: 0x0601AD11 RID: 109841 RVA: 0x0083C4E7 File Offset: 0x0083A6E7
	[NullableContext(2)]
	public Entity GetCachedOwnerEntity()
	{
		return this.CachedOwnerEntity;
	}

	// Token: 0x0601AD12 RID: 109842 RVA: 0x0083C4F0 File Offset: 0x0083A6F0
	[NullableContext(2)]
	private int AddMaterialControllerDataInner(PD_CharacterControllerData_C data, UObject userData = null, USkeletalMeshComponent animObject = null)
	{
		if (data == null)
		{
			return -1;
		}
		if (data.CleanOriginEffect)
		{
			this.CleanOriginEffect();
		}
		int num;
		if (this.UseMaterialContainerV2)
		{
			num = this.AddMaterialControllerDataInnerV2(data, userData, animObject);
		}
		else
		{
			CharMaterialController charMaterialController = this.GetComponent(2) as CharMaterialController;
			if (charMaterialController == null)
			{
				return -1;
			}
			if (CharRenderingComponent.DisableForDebug)
			{
				this.ResetAllRenderingStateForDebug();
				return -1;
			}
			num = charMaterialController.AddMaterialControllerData(data, userData);
		}
		EventSystem.Instance.EmitWithTarget<PD_CharacterControllerData_C, UObject, int>(this, EEventName.OnAddMaterialController, data, userData, num);
		return num;
	}

	// Token: 0x0601AD13 RID: 109843 RVA: 0x0083C565 File Offset: 0x0083A765
	public void OnRemoveMaterialController(int handle)
	{
	}

	// Token: 0x0601AD14 RID: 109844 RVA: 0x0083C568 File Offset: 0x0083A768
	[NullableContext(2)]
	private int AddMaterialControllerDataInnerV2([Nullable(1)] PD_CharacterControllerData_C data, UObject userData = null, USkeletalMeshComponent animObject = null)
	{
		CharMaterialControllerV2 charMaterialControllerV = this.GetComponent(14) as CharMaterialControllerV2;
		if (charMaterialControllerV == null)
		{
			return -1;
		}
		return charMaterialControllerV.AddMaterialControllerData(data, userData, animObject);
	}

	// Token: 0x0601AD15 RID: 109845 RVA: 0x0083C594 File Offset: 0x0083A794
	[NullableContext(2)]
	public int AddMaterialControllerDataWithUserData(UObject data, UObject userData)
	{
		PD_CharacterControllerData_C data2 = data as PD_CharacterControllerData_C;
		return this.AddMaterialControllerDataInner(data2, userData, null);
	}

	// Token: 0x0601AD16 RID: 109846 RVA: 0x0083C5B4 File Offset: 0x0083A7B4
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual float AddMaterialControllerDataWithAnimObject(UObject data, USkeletalMeshComponent animObject, UObject userData = null)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AddMaterialControllerDataWithAnimObject"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			return this.AddMaterialControllerDataWithAnimObject_Implementation(data, animObject, userData);
		}
		CharRenderingComponent.__AddMaterialControllerDataWithAnimObject_FunctionParams* ptr = stackalloc CharRenderingComponent.__AddMaterialControllerDataWithAnimObject_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__AddMaterialControllerDataWithAnimObject_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->data) = ((data != null) ? data.NativePtr : ((IntPtr)0));
		*(&ptr->animObject) = ((animObject != null) ? animObject.NativePtr : ((IntPtr)0));
		*(&ptr->userData) = ((userData != null) ? userData.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		float _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0601AD17 RID: 109847 RVA: 0x0083C680 File Offset: 0x0083A880
	[NullableContext(2)]
	protected float AddMaterialControllerDataWithAnimObject_Implementation(UObject data, USkeletalMeshComponent animObject, UObject userData = null)
	{
		PD_CharacterControllerData_C data2 = data as PD_CharacterControllerData_C;
		return (float)this.AddMaterialControllerDataInner(data2, userData, animObject);
	}

	// Token: 0x0601AD18 RID: 109848 RVA: 0x0083C6A0 File Offset: 0x0083A8A0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual int AddMaterialControllerData(UObject data)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AddMaterialControllerData"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			return this.AddMaterialControllerData_Implementation(data);
		}
		CharRenderingComponent.__AddMaterialControllerData_FunctionParams* ptr = stackalloc CharRenderingComponent.__AddMaterialControllerData_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__AddMaterialControllerData_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->data) = ((data != null) ? data.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		int _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0601AD19 RID: 109849 RVA: 0x0083C740 File Offset: 0x0083A940
	[NullableContext(2)]
	protected int AddMaterialControllerData_Implementation(UObject data)
	{
		PD_CharacterControllerData_C data2 = data as PD_CharacterControllerData_C;
		return this.AddMaterialControllerDataInner(data2, null, null);
	}

	// Token: 0x0601AD1A RID: 109850 RVA: 0x0083C760 File Offset: 0x0083A960
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void RemoveMaterialControllerData(int handle)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("RemoveMaterialControllerData"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			this.RemoveMaterialControllerData_Implementation(handle);
			return;
		}
		CharRenderingComponent.__RemoveMaterialControllerData_FunctionParams* ptr = stackalloc CharRenderingComponent.__RemoveMaterialControllerData_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__RemoveMaterialControllerData_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->handle = handle;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AD1B RID: 109851 RVA: 0x0083C7EC File Offset: 0x0083A9EC
	protected void RemoveMaterialControllerData_Implementation(int handle)
	{
		if (this.UseMaterialContainerV2)
		{
			CharMaterialControllerV2 charMaterialControllerV = this.GetComponent(14) as CharMaterialControllerV2;
			if (charMaterialControllerV == null)
			{
				return;
			}
			charMaterialControllerV.RemoveMaterialControllerData(handle);
			return;
		}
		else
		{
			CharMaterialController charMaterialController = this.GetComponent(2) as CharMaterialController;
			if (charMaterialController == null)
			{
				return;
			}
			charMaterialController.RemoveMaterialControllerData(handle);
			return;
		}
	}

	// Token: 0x0601AD1C RID: 109852 RVA: 0x0083C838 File Offset: 0x0083AA38
	public void RemoveAllUnloopedEffects()
	{
		CharMaterialContainerV2 charMaterialContainerV = this.GetComponent(13) as CharMaterialContainerV2;
		if (charMaterialContainerV == null)
		{
			return;
		}
		charMaterialContainerV.RemoveAllUnloopedEffects();
	}

	// Token: 0x0601AD1D RID: 109853 RVA: 0x0083C860 File Offset: 0x0083AA60
	public void UpdateMaterialEffectsOnly()
	{
		if (this.UseMaterialContainerV2)
		{
			CharMaterialContainerV2 charMaterialContainerV = this.GetComponent(13) as CharMaterialContainerV2;
			if (charMaterialContainerV == null)
			{
				return;
			}
			charMaterialContainerV.UpdateEffectsOnly();
		}
	}

	// Token: 0x0601AD1E RID: 109854 RVA: 0x0083C890 File Offset: 0x0083AA90
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetEffectPause(int handle, bool paused)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetEffectPause"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			this.SetEffectPause_Implementation(handle, paused);
			return;
		}
		CharRenderingComponent.__SetEffectPause_FunctionParams* ptr = stackalloc CharRenderingComponent.__SetEffectPause_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__SetEffectPause_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->handle = handle;
		ptr->paused = paused;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AD1F RID: 109855 RVA: 0x0083C924 File Offset: 0x0083AB24
	protected void SetEffectPause_Implementation(int handle, bool paused)
	{
		if (this.UseMaterialContainerV2)
		{
			CharMaterialContainerV2 charMaterialContainerV = this.GetComponent(13) as CharMaterialContainerV2;
			if (charMaterialContainerV == null)
			{
				return;
			}
			charMaterialContainerV.SetEffectPause(handle, paused);
		}
	}

	// Token: 0x0601AD20 RID: 109856 RVA: 0x0083C954 File Offset: 0x0083AB54
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void RemoveMaterialControllerDataWithEnding(int handle)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("RemoveMaterialControllerDataWithEnding"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			this.RemoveMaterialControllerDataWithEnding_Implementation(handle);
			return;
		}
		CharRenderingComponent.__RemoveMaterialControllerDataWithEnding_FunctionParams* ptr = stackalloc CharRenderingComponent.__RemoveMaterialControllerDataWithEnding_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__RemoveMaterialControllerDataWithEnding_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->handle = handle;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AD21 RID: 109857 RVA: 0x0083C9E0 File Offset: 0x0083ABE0
	protected void RemoveMaterialControllerDataWithEnding_Implementation(int handle)
	{
		if (this.UseMaterialContainerV2)
		{
			CharMaterialControllerV2 charMaterialControllerV = this.GetComponent(14) as CharMaterialControllerV2;
			if (charMaterialControllerV == null)
			{
				return;
			}
			charMaterialControllerV.RemoveMaterialControllerDataWithEnding(handle);
			return;
		}
		else
		{
			CharMaterialController charMaterialController = this.GetComponent(2) as CharMaterialController;
			if (charMaterialController == null)
			{
				return;
			}
			charMaterialController.RemoveMaterialControllerDataWithEnding(handle);
			return;
		}
	}

	// Token: 0x0601AD22 RID: 109858 RVA: 0x0083CA2C File Offset: 0x0083AC2C
	public unsafe void UpdateNpcDitherComponent()
	{
		if (!this.IsInit)
		{
			return;
		}
		ECharacterRenderingType? renderType = this.RenderType;
		ECharacterRenderingType echaracterRenderingType = ECharacterRenderingType.Npc;
		if (!(renderType.GetValueOrDefault() == echaracterRenderingType & renderType != null))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderCharacter;
			ELogAuthor author = ELogAuthor.LSY;
			string message = "NPC更新不是NPC类型";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Owner", this.CachedOwnerName);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item = "EntityId";
			Entity cachedOwnerEntity = this.CachedOwnerEntity;
			ptr = new ValueTuple<string, object>(item, (cachedOwnerEntity != null) ? new int?(cachedOwnerEntity.Id) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("实际类型", this.RenderType);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		CharDitherEffect charDitherEffect = this.GetComponent(3) as CharDitherEffect;
		if (charDitherEffect == null)
		{
			return;
		}
		charDitherEffect.UpdateNpcDitherComponent();
	}

	// Token: 0x0601AD23 RID: 109859 RVA: 0x0083CB18 File Offset: 0x0083AD18
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetDitherEffect(float ditherRate, ECharacterDitherType ditherType)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetDitherEffect"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			this.SetDitherEffect_Implementation(ditherRate, ditherType);
			return;
		}
		CharRenderingComponent.__SetDitherEffect_FunctionParams* ptr = stackalloc CharRenderingComponent.__SetDitherEffect_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__SetDitherEffect_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->ditherRate = ditherRate;
		*(&ptr->ditherType) = (byte)ditherType;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AD24 RID: 109860 RVA: 0x0083CBB0 File Offset: 0x0083ADB0
	protected void SetDitherEffect_Implementation(float ditherRate, ECharacterDitherType ditherType)
	{
		CharDitherEffect charDitherEffect = this.GetComponent(3) as CharDitherEffect;
		if (charDitherEffect == null)
		{
			return;
		}
		float num = ditherRate;
		if (ditherType == ECharacterDitherType.Fight)
		{
			this.FightDitherRateCache = ditherRate;
			num = (this.DisableFightDither ? 1f : ditherRate);
		}
		num = (CharRenderingComponent.GlobalDisableDitherEffect ? 1f : num);
		num = MathUtils.Instance.Clamp(num / (1f - this.DitherRemap), 0f, 1f);
		try
		{
			charDitherEffect.SetDitherEffect(num, ditherType);
			this.SetBodyEffectOpacity(charDitherEffect.GetDitherRate());
			this.SetDecalShadowOpacity(charDitherEffect.GetDitherRate());
			this.SetRealTimeShadowOpacity(charDitherEffect.GetDitherRate());
		}
		catch (Exception ex)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Render;
			ELogAuthor author = ELogAuthor.LSY;
			string message = "CharacterRenderingComponent.SetDitherEffect执行异常";
			Exception error = ex;
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("error", ex.Message);
			instance.ErrorWithStack(module, author, message, error, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
	}

	// Token: 0x0601AD25 RID: 109861 RVA: 0x0083CC90 File Offset: 0x0083AE90
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetDisableFightDither(bool disable)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetDisableFightDither"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			this.SetDisableFightDither_Implementation(disable);
			return;
		}
		CharRenderingComponent.__SetDisableFightDither_FunctionParams* ptr = stackalloc CharRenderingComponent.__SetDisableFightDither_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__SetDisableFightDither_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->disable = disable;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AD26 RID: 109862 RVA: 0x0083CD1C File Offset: 0x0083AF1C
	protected void SetDisableFightDither_Implementation(bool disable)
	{
		this.DisableFightDither = disable;
		this.SetDitherEffect(this.FightDitherRateCache, ECharacterDitherType.Fight);
	}

	// Token: 0x0601AD27 RID: 109863 RVA: 0x0083CD34 File Offset: 0x0083AF34
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void SetDitherApplyAll()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetDitherApplyAll"), CharRenderingComponent.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.SetDitherApplyAll_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601AD28 RID: 109864 RVA: 0x0083CD90 File Offset: 0x0083AF90
	protected void SetDitherApplyAll_Implementation()
	{
		CharDitherEffect charDitherEffect = this.GetComponent(3) as CharDitherEffect;
		if (charDitherEffect == null)
		{
			return;
		}
		charDitherEffect.SetDitherMask(Array.Empty<EKuroCharMeshPart>(), false);
	}

	// Token: 0x0601AD29 RID: 109865 RVA: 0x0083CDBC File Offset: 0x0083AFBC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void SetDitherApplyHeadsOnly()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetDitherApplyHeadsOnly"), CharRenderingComponent.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.SetDitherApplyHeadsOnly_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601AD2A RID: 109866 RVA: 0x0083CE18 File Offset: 0x0083B018
	protected void SetDitherApplyHeadsOnly_Implementation()
	{
		CharDitherEffect charDitherEffect = this.GetComponent(3) as CharDitherEffect;
		if (charDitherEffect == null)
		{
			return;
		}
		charDitherEffect.SetDitherMask(RenderConfig.MeshPartsHeadArray, true);
	}

	// Token: 0x0601AD2B RID: 109867 RVA: 0x0083CE44 File Offset: 0x0083B044
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetDitherUseHeadMaskHideEffect(bool enable)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetDitherUseHeadMaskHideEffect"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			this.SetDitherUseHeadMaskHideEffect_Implementation(enable);
			return;
		}
		CharRenderingComponent.__SetDitherUseHeadMaskHideEffect_FunctionParams* ptr = stackalloc CharRenderingComponent.__SetDitherUseHeadMaskHideEffect_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__SetDitherUseHeadMaskHideEffect_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->enable = enable;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AD2C RID: 109868 RVA: 0x0083CED0 File Offset: 0x0083B0D0
	protected void SetDitherUseHeadMaskHideEffect_Implementation(bool enable)
	{
		CharMaterialContainerV2 charMaterialContainerV = this.GetComponent(13) as CharMaterialContainerV2;
		if (charMaterialContainerV == null)
		{
			return;
		}
		charMaterialContainerV.EnableTickGetHeadPosInAllMeshes(enable);
	}

	// Token: 0x0601AD2D RID: 109869 RVA: 0x0083CEF8 File Offset: 0x0083B0F8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void TempRemoveDither()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("TempRemoveDither"), CharRenderingComponent.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.TempRemoveDither_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601AD2E RID: 109870 RVA: 0x0083CF54 File Offset: 0x0083B154
	protected void TempRemoveDither_Implementation()
	{
		CharDitherEffect charDitherEffect = this.GetComponent(3) as CharDitherEffect;
		if (charDitherEffect == null)
		{
			return;
		}
		charDitherEffect.TempRemoveDither();
	}

	// Token: 0x0601AD2F RID: 109871 RVA: 0x0083CF78 File Offset: 0x0083B178
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void TempRecoverDither()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("TempRecoverDither"), CharRenderingComponent.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.TempRecoverDither_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601AD30 RID: 109872 RVA: 0x0083CFD4 File Offset: 0x0083B1D4
	protected void TempRecoverDither_Implementation()
	{
		CharDitherEffect charDitherEffect = this.GetComponent(3) as CharDitherEffect;
		if (charDitherEffect == null)
		{
			return;
		}
		charDitherEffect.TempRecoverDither();
	}

	// Token: 0x0601AD31 RID: 109873 RVA: 0x0083CFF8 File Offset: 0x0083B1F8
	public void RegisterBodyEffect(int handle)
	{
		if (!this.IsInit)
		{
			return;
		}
		CharBodyEffect charBodyEffect = this.GetComponent(9) as CharBodyEffect;
		if (charBodyEffect == null)
		{
			charBodyEffect = (this.AddRenderCompDynamic(new CharBodyEffect()) as CharBodyEffect);
			if (charBodyEffect == null)
			{
				return;
			}
		}
		charBodyEffect.RegisterEffect(handle);
	}

	// Token: 0x0601AD32 RID: 109874 RVA: 0x0083D03C File Offset: 0x0083B23C
	public void UnregisterBodyEffect(int handle)
	{
		CharBodyEffect charBodyEffect = this.GetComponent(9) as CharBodyEffect;
		if (charBodyEffect == null)
		{
			return;
		}
		charBodyEffect.UnregisterEffect(handle);
	}

	// Token: 0x0601AD33 RID: 109875 RVA: 0x0083D064 File Offset: 0x0083B264
	protected void SetBodyEffectOpacity(float opacity)
	{
		CharBodyEffect charBodyEffect = this.GetComponent(9) as CharBodyEffect;
		if (charBodyEffect == null)
		{
			return;
		}
		charBodyEffect.SetOpacity(opacity, ECharBodyEffectOpacityType.Default);
	}

	// Token: 0x0601AD34 RID: 109876 RVA: 0x0083D08C File Offset: 0x0083B28C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual float GetOpacityConsiderVisibility()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetOpacityConsiderVisibility"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			return this.GetOpacityConsiderVisibility_Implementation();
		}
		CharRenderingComponent.__GetOpacityConsiderVisibility_FunctionParams* ptr = stackalloc CharRenderingComponent.__GetOpacityConsiderVisibility_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__GetOpacityConsiderVisibility_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		float _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0601AD35 RID: 109877 RVA: 0x0083D118 File Offset: 0x0083B318
	protected float GetOpacityConsiderVisibility_Implementation()
	{
		CharBodyEffect charBodyEffect = this.GetComponent(9) as CharBodyEffect;
		if (charBodyEffect == null)
		{
			return 1f;
		}
		return charBodyEffect.GetOpacityConsiderVisibility();
	}

	// Token: 0x0601AD36 RID: 109878 RVA: 0x0083D144 File Offset: 0x0083B344
	[NullableContext(2)]
	public void AddInteraction(PDA_InteractionPlayerConfig_C data, float updateInternalScale = 1f)
	{
		if (data == null)
		{
			return;
		}
		CharSceneInteraction charSceneInteraction = this.GetComponent(5) as CharSceneInteraction;
		if (charSceneInteraction != null && !charSceneInteraction.GetIsPossed())
		{
			charSceneInteraction.PossCharacter(data, updateInternalScale);
		}
		CharGrassInteraction charGrassInteraction = this.GetComponent(11) as CharGrassInteraction;
		if (charGrassInteraction != null)
		{
			charGrassInteraction.SetConfig(data);
		}
		if (!this.OnRoleGoDownFinishEventAdded && this.CachedOwnerEntity != null)
		{
			this.RemoveInteractionOnRoleGoDownFinish = new Action(this.RemoveInteraction);
			EventSystem.Instance.AddWithTarget(this.CachedOwnerEntity, EEventName.OnRoleGoDownFinish, this.RemoveInteractionOnRoleGoDownFinish);
			this.OnRoleGoDownFinishEventAdded = true;
		}
	}

	// Token: 0x0601AD37 RID: 109879 RVA: 0x0083D1D4 File Offset: 0x0083B3D4
	public void RemoveInteraction()
	{
		CharSceneInteraction charSceneInteraction = this.GetComponent(5) as CharSceneInteraction;
		if (charSceneInteraction != null)
		{
			charSceneInteraction.UnpossCharacter();
		}
		CharGrassInteraction charGrassInteraction = this.GetComponent(11) as CharGrassInteraction;
		if (charGrassInteraction != null)
		{
			charGrassInteraction.SetEnabled(false);
		}
	}

	// Token: 0x0601AD38 RID: 109880 RVA: 0x0083D20F File Offset: 0x0083B40F
	[NullableContext(2)]
	public void AddMotorExtraCompInner(PD_MotorExtraComponentData_C data)
	{
		if (this.MotorExtraComp == null || !this.MotorExtraComp.IsValid())
		{
			this.MotorExtraComp = new BP_MotorExtraComponent_C();
		}
		BP_MotorExtraComponent_C motorExtraComp = this.MotorExtraComp;
		if (motorExtraComp == null)
		{
			return;
		}
		motorExtraComp.AddAllMotorExtraComponent_Func(data, base.GetOwner());
	}

	// Token: 0x0601AD39 RID: 109881 RVA: 0x0083D248 File Offset: 0x0083B448
	[NullableContext(2)]
	public void AddMotorExtraComp(UObject data)
	{
		PD_MotorExtraComponentData_C data2 = data as PD_MotorExtraComponentData_C;
		this.AddMotorExtraCompInner(data2);
	}

	// Token: 0x0601AD3A RID: 109882 RVA: 0x0083D263 File Offset: 0x0083B463
	public void RemoveMotorExtraComp()
	{
		if (this.MotorExtraComp != null && this.MotorExtraComp.IsValid())
		{
			this.MotorExtraComp.RemoveAllMotorExtraComponent_Func();
		}
	}

	// Token: 0x0601AD3B RID: 109883 RVA: 0x0083D288 File Offset: 0x0083B488
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetMaterialPropertyFloat(ECharacterBodySpecifiedType bodyType, float sectionIndex, ECharacterSlotSpecifiedType slotType, string propertyName, float value)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetMaterialPropertyFloat"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			this.SetMaterialPropertyFloat_Implementation(bodyType, sectionIndex, slotType, propertyName, value);
			return;
		}
		CharRenderingComponent.__SetMaterialPropertyFloat_FunctionParams* ptr = stackalloc CharRenderingComponent.__SetMaterialPropertyFloat_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__SetMaterialPropertyFloat_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->bodyType) = (byte)bodyType;
		ptr->sectionIndex = sectionIndex;
		*(&ptr->slotType) = (byte)slotType;
		FString.CopyFrom((void*)(&ptr->propertyName), propertyName);
		ptr->value = value;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AD3C RID: 109884 RVA: 0x0083D344 File Offset: 0x0083B544
	[NullableContext(1)]
	protected void SetMaterialPropertyFloat_Implementation(ECharacterBodySpecifiedType bodyType, float sectionIndex, ECharacterSlotSpecifiedType slotType, string propertyName, float value)
	{
		CharPropertyModifier charPropertyModifier = this.GetComponent(6) as CharPropertyModifier;
		if (charPropertyModifier == null)
		{
			return;
		}
		charPropertyModifier.SetPropertyFloat(bodyType, (int)sectionIndex, slotType, FNameUtil.GetDynamicFName(propertyName), value);
	}

	// Token: 0x0601AD3D RID: 109885 RVA: 0x0083D378 File Offset: 0x0083B578
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetMaterialPropertyColor(ECharacterBodySpecifiedType bodyType, float sectionIndex, ECharacterSlotSpecifiedType slotType, string propertyName, FLinearColor value)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetMaterialPropertyColor"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			this.SetMaterialPropertyColor_Implementation(bodyType, sectionIndex, slotType, propertyName, value);
			return;
		}
		CharRenderingComponent.__SetMaterialPropertyColor_FunctionParams* ptr = stackalloc CharRenderingComponent.__SetMaterialPropertyColor_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__SetMaterialPropertyColor_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->bodyType) = (byte)bodyType;
		ptr->sectionIndex = sectionIndex;
		*(&ptr->slotType) = (byte)slotType;
		FString.CopyFrom((void*)(&ptr->propertyName), propertyName);
		ptr->value = value;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AD3E RID: 109886 RVA: 0x0083D434 File Offset: 0x0083B634
	[NullableContext(1)]
	protected void SetMaterialPropertyColor_Implementation(ECharacterBodySpecifiedType bodyType, float sectionIndex, ECharacterSlotSpecifiedType slotType, string propertyName, FLinearColor value)
	{
		CharPropertyModifier charPropertyModifier = this.GetComponent(6) as CharPropertyModifier;
		if (charPropertyModifier == null)
		{
			return;
		}
		charPropertyModifier.SetPropertyColor(bodyType, (int)sectionIndex, slotType, FNameUtil.GetDynamicFName(propertyName), value);
	}

	// Token: 0x0601AD3F RID: 109887 RVA: 0x0083D468 File Offset: 0x0083B668
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetMaterialPropertyFloatV2(FName name, float value, EKuroCharBodySpecifiedType bodyType, EKuroCharSlotSpecifiedType slotType, EKuroCharMeshPart meshPart)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetMaterialPropertyFloatV2"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			this.SetMaterialPropertyFloatV2_Implementation(name, value, bodyType, slotType, meshPart);
			return;
		}
		CharRenderingComponent.__SetMaterialPropertyFloatV2_FunctionParams* ptr = stackalloc CharRenderingComponent.__SetMaterialPropertyFloatV2_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__SetMaterialPropertyFloatV2_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->name = name;
		ptr->value = value;
		*(&ptr->bodyType) = (byte)bodyType;
		*(&ptr->slotType) = (byte)slotType;
		*(&ptr->meshPart) = (byte)meshPart;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AD40 RID: 109888 RVA: 0x0083D520 File Offset: 0x0083B720
	protected void SetMaterialPropertyFloatV2_Implementation(FName name, float value, EKuroCharBodySpecifiedType bodyType, EKuroCharSlotSpecifiedType slotType, EKuroCharMeshPart meshPart)
	{
		CharMaterialContainerV2 charMaterialContainerV = this.GetComponent(13) as CharMaterialContainerV2;
		if (charMaterialContainerV == null)
		{
			return;
		}
		charMaterialContainerV.SetFloatUpdateParamPermanent(name, value, bodyType, slotType, new EKuroCharMeshPart?(meshPart));
	}

	// Token: 0x0601AD41 RID: 109889 RVA: 0x0083D554 File Offset: 0x0083B754
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void AddFloatUpdateParamPermanentByIndexV2(FName name, float value, FName bodyName, float materialIndex)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AddFloatUpdateParamPermanentByIndexV2"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			this.AddFloatUpdateParamPermanentByIndexV2_Implementation(name, value, bodyName, materialIndex);
			return;
		}
		CharRenderingComponent.__AddFloatUpdateParamPermanentByIndexV2_FunctionParams* ptr = stackalloc CharRenderingComponent.__AddFloatUpdateParamPermanentByIndexV2_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__AddFloatUpdateParamPermanentByIndexV2_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->name = name;
		ptr->value = value;
		ptr->bodyName = bodyName;
		ptr->materialIndex = materialIndex;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AD42 RID: 109890 RVA: 0x0083D5FC File Offset: 0x0083B7FC
	protected void AddFloatUpdateParamPermanentByIndexV2_Implementation(FName name, float value, FName bodyName, float materialIndex)
	{
		CharMaterialContainerV2 charMaterialContainerV = this.GetComponent(13) as CharMaterialContainerV2;
		if (charMaterialContainerV == null)
		{
			return;
		}
		charMaterialContainerV.AddFloatUpdateParamPermanentByIndex(name, value, bodyName, (int)materialIndex);
	}

	// Token: 0x0601AD43 RID: 109891 RVA: 0x0083D628 File Offset: 0x0083B828
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetMaterialPropertyColorV2(FName name, FLinearColor value, EKuroCharBodySpecifiedType bodyType, EKuroCharSlotSpecifiedType slotType, EKuroCharMeshPart meshPart)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetMaterialPropertyColorV2"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			this.SetMaterialPropertyColorV2_Implementation(name, value, bodyType, slotType, meshPart);
			return;
		}
		CharRenderingComponent.__SetMaterialPropertyColorV2_FunctionParams* ptr = stackalloc CharRenderingComponent.__SetMaterialPropertyColorV2_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__SetMaterialPropertyColorV2_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->name = name;
		ptr->value = value;
		*(&ptr->bodyType) = (byte)bodyType;
		*(&ptr->slotType) = (byte)slotType;
		*(&ptr->meshPart) = (byte)meshPart;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AD44 RID: 109892 RVA: 0x0083D6E0 File Offset: 0x0083B8E0
	protected void SetMaterialPropertyColorV2_Implementation(FName name, FLinearColor value, EKuroCharBodySpecifiedType bodyType, EKuroCharSlotSpecifiedType slotType, EKuroCharMeshPart meshPart)
	{
		CharMaterialContainerV2 charMaterialContainerV = this.GetComponent(13) as CharMaterialContainerV2;
		if (charMaterialContainerV == null)
		{
			return;
		}
		charMaterialContainerV.SetColorUpdateParamPermanent(name, value, bodyType, slotType, new EKuroCharMeshPart?(meshPart));
	}

	// Token: 0x0601AD45 RID: 109893 RVA: 0x0083D714 File Offset: 0x0083B914
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetMaterialReplaceV2(UMaterialInterface material, EKuroCharBodySpecifiedType bodyType, EKuroCharSlotSpecifiedType slotType, EKuroCharMeshPart meshPart)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetMaterialReplaceV2"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			this.SetMaterialReplaceV2_Implementation(material, bodyType, slotType, meshPart);
			return;
		}
		CharRenderingComponent.__SetMaterialReplaceV2_FunctionParams* ptr = stackalloc CharRenderingComponent.__SetMaterialReplaceV2_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__SetMaterialReplaceV2_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->material) = ((material != null) ? material.NativePtr : ((IntPtr)0));
		*(&ptr->bodyType) = (byte)bodyType;
		*(&ptr->slotType) = (byte)slotType;
		*(&ptr->meshPart) = (byte)meshPart;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AD46 RID: 109894 RVA: 0x0083D7D0 File Offset: 0x0083B9D0
	[NullableContext(1)]
	protected void SetMaterialReplaceV2_Implementation(UMaterialInterface material, EKuroCharBodySpecifiedType bodyType, EKuroCharSlotSpecifiedType slotType, EKuroCharMeshPart meshPart)
	{
		CharMaterialContainerV2 charMaterialContainerV = this.GetComponent(13) as CharMaterialContainerV2;
		if (charMaterialContainerV == null)
		{
			return;
		}
		charMaterialContainerV.SetExternalMaterialReplace(material, bodyType, slotType, new EKuroCharMeshPart?(meshPart));
	}

	// Token: 0x0601AD47 RID: 109895 RVA: 0x0083D800 File Offset: 0x0083BA00
	[NullableContext(1)]
	public void SetMaterialReplaceV2ByIndex(UMaterialInterface material, FName bodyName, int materialIndex)
	{
		CharMaterialContainerV2 charMaterialContainerV = this.GetComponent(13) as CharMaterialContainerV2;
		if (charMaterialContainerV == null)
		{
			return;
		}
		charMaterialContainerV.SetExternalMaterialReplaceByIndex(material, bodyName, materialIndex);
	}

	// Token: 0x0601AD48 RID: 109896 RVA: 0x0083D828 File Offset: 0x0083BA28
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void RemoveExternalMaterialReplaceV2(EKuroCharBodySpecifiedType bodyType, EKuroCharSlotSpecifiedType slotType, EKuroCharMeshPart meshPart)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("RemoveExternalMaterialReplaceV2"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			this.RemoveExternalMaterialReplaceV2_Implementation(bodyType, slotType, meshPart);
			return;
		}
		CharRenderingComponent.__RemoveExternalMaterialReplaceV2_FunctionParams* ptr = stackalloc CharRenderingComponent.__RemoveExternalMaterialReplaceV2_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__RemoveExternalMaterialReplaceV2_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->bodyType) = (byte)bodyType;
		*(&ptr->slotType) = (byte)slotType;
		*(&ptr->meshPart) = (byte)meshPart;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AD49 RID: 109897 RVA: 0x0083D8CC File Offset: 0x0083BACC
	protected void RemoveExternalMaterialReplaceV2_Implementation(EKuroCharBodySpecifiedType bodyType, EKuroCharSlotSpecifiedType slotType, EKuroCharMeshPart meshPart)
	{
		CharMaterialContainerV2 charMaterialContainerV = this.GetComponent(13) as CharMaterialContainerV2;
		if (charMaterialContainerV == null)
		{
			return;
		}
		charMaterialContainerV.RemoveExternalMaterialReplace(bodyType, slotType, new EKuroCharMeshPart?(meshPart));
	}

	// Token: 0x0601AD4A RID: 109898 RVA: 0x0083D8FC File Offset: 0x0083BAFC
	public void RemoveExternalMaterialReplaceV2ByIndex(FName bodyName, int materialIndex)
	{
		CharMaterialContainerV2 charMaterialContainerV = this.GetComponent(13) as CharMaterialContainerV2;
		if (charMaterialContainerV == null)
		{
			return;
		}
		charMaterialContainerV.RemoveExternalMaterialReplaceByIndex(bodyName, materialIndex);
	}

	// Token: 0x0601AD4B RID: 109899 RVA: 0x0083D924 File Offset: 0x0083BB24
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetStarScarEnergy(float value)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetStarScarEnergy"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			this.SetStarScarEnergy_Implementation(value);
			return;
		}
		CharRenderingComponent.__SetStarScarEnergy_FunctionParams* ptr = stackalloc CharRenderingComponent.__SetStarScarEnergy_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__SetStarScarEnergy_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->value = value;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AD4C RID: 109900 RVA: 0x0083D9B0 File Offset: 0x0083BBB0
	protected void SetStarScarEnergy_Implementation(float value)
	{
		if (this.UseMaterialContainerV2)
		{
			CharMaterialContainerV2 charMaterialContainerV = this.GetComponent(13) as CharMaterialContainerV2;
			if (charMaterialContainerV == null)
			{
				return;
			}
			charMaterialContainerV.SetFloatUpdateParamPermanent(RenderConfig.StarScarEnergyControl, value, EKuroCharBodySpecifiedType.Body, EKuroCharSlotSpecifiedType.Body, new EKuroCharMeshPart?(EKuroCharMeshPart.Star));
			return;
		}
		else
		{
			CharMaterialContainer charMaterialContainer = this.GetComponent(1) as CharMaterialContainer;
			if (charMaterialContainer == null)
			{
				return;
			}
			charMaterialContainer.SetStarScarEnergy(value);
			return;
		}
	}

	// Token: 0x0601AD4D RID: 109901 RVA: 0x0083DA08 File Offset: 0x0083BC08
	public void SetNoWater(bool value)
	{
		if (this.UseMaterialContainerV2)
		{
			CharMaterialContainerV2 charMaterialContainerV = this.GetComponent(13) as CharMaterialContainerV2;
			if (charMaterialContainerV == null)
			{
				return;
			}
			charMaterialContainerV.SetNoWater(value);
			return;
		}
		else
		{
			CharMaterialContainer charMaterialContainer = this.GetComponent(1) as CharMaterialContainer;
			if (charMaterialContainer == null)
			{
				return;
			}
			charMaterialContainer.SetNoWater(value);
			return;
		}
	}

	// Token: 0x0601AD4E RID: 109902 RVA: 0x0083DA50 File Offset: 0x0083BC50
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetCapsuleDither(float value)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetCapsuleDither"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			this.SetCapsuleDither_Implementation(value);
			return;
		}
		CharRenderingComponent.__SetCapsuleDither_FunctionParams* ptr = stackalloc CharRenderingComponent.__SetCapsuleDither_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__SetCapsuleDither_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->value = value;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AD4F RID: 109903 RVA: 0x0083DADC File Offset: 0x0083BCDC
	protected void SetCapsuleDither_Implementation(float value)
	{
	}

	// Token: 0x0601AD50 RID: 109904 RVA: 0x0083DAE0 File Offset: 0x0083BCE0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetDecalShadowEnabled(bool enable)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetDecalShadowEnabled"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			this.SetDecalShadowEnabled_Implementation(enable);
			return;
		}
		CharRenderingComponent.__SetDecalShadowEnabled_FunctionParams* ptr = stackalloc CharRenderingComponent.__SetDecalShadowEnabled_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__SetDecalShadowEnabled_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->enable = enable;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AD51 RID: 109905 RVA: 0x0083DB6C File Offset: 0x0083BD6C
	protected void SetDecalShadowEnabled_Implementation(bool enable)
	{
		CharDecalShadow charDecalShadow = this.GetComponent(10) as CharDecalShadow;
		if (charDecalShadow == null)
		{
			return;
		}
		if (enable)
		{
			charDecalShadow.EnableDecalShadow();
			return;
		}
		charDecalShadow.DisableDecalShadow();
	}

	// Token: 0x0601AD52 RID: 109906 RVA: 0x0083DB9C File Offset: 0x0083BD9C
	public void SetRealTimeShadowEnabled(bool enable)
	{
		CharDecalShadow charDecalShadow = this.GetComponent(10) as CharDecalShadow;
		if (charDecalShadow == null)
		{
			return;
		}
		if (enable)
		{
			charDecalShadow.EnableRealTimeShadow();
			return;
		}
		charDecalShadow.DisableRealTimeShadow();
	}

	// Token: 0x0601AD53 RID: 109907 RVA: 0x0083DBCC File Offset: 0x0083BDCC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void DisableAllShadowByDecalShadowComponent()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("DisableAllShadowByDecalShadowComponent"), CharRenderingComponent.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.DisableAllShadowByDecalShadowComponent_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601AD54 RID: 109908 RVA: 0x0083DC28 File Offset: 0x0083BE28
	protected void DisableAllShadowByDecalShadowComponent_Implementation()
	{
		CharDecalShadow charDecalShadow = this.GetComponent(10) as CharDecalShadow;
		if (charDecalShadow == null)
		{
			return;
		}
		charDecalShadow.DisableAllShadow();
	}

	// Token: 0x0601AD55 RID: 109909 RVA: 0x0083DC50 File Offset: 0x0083BE50
	[NullableContext(1)]
	protected void AddComponentForDecalShadow(string name, UPrimitiveComponent comp)
	{
		CharDecalShadow charDecalShadow = this.GetComponent(10) as CharDecalShadow;
		if (charDecalShadow == null)
		{
			return;
		}
		charDecalShadow.AddPrimitiveComponent(name, comp);
	}

	// Token: 0x0601AD56 RID: 109910 RVA: 0x0083DC78 File Offset: 0x0083BE78
	[NullableContext(1)]
	protected void RemoveComponentFromDecalShadow(string name)
	{
		CharDecalShadow charDecalShadow = this.GetComponent(10) as CharDecalShadow;
		if (charDecalShadow == null)
		{
			return;
		}
		charDecalShadow.RemovePrimitiveComponent(name);
	}

	// Token: 0x0601AD57 RID: 109911 RVA: 0x0083DCA0 File Offset: 0x0083BEA0
	protected void SetDecalShadowOpacity(float opacity)
	{
		CharDecalShadow charDecalShadow = this.GetComponent(10) as CharDecalShadow;
		if (charDecalShadow == null)
		{
			return;
		}
		charDecalShadow.SetDecalShadowOpacity(opacity);
	}

	// Token: 0x0601AD58 RID: 109912 RVA: 0x0083DCC8 File Offset: 0x0083BEC8
	protected void SetRealTimeShadowOpacity(float opacity)
	{
		CharDecalShadow charDecalShadow = this.GetComponent(10) as CharDecalShadow;
		if (charDecalShadow == null)
		{
			return;
		}
		charDecalShadow.SetRealTimeShadowOpacity(opacity);
	}

	// Token: 0x0601AD59 RID: 109913 RVA: 0x0083DCF0 File Offset: 0x0083BEF0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetShouldCastShadow(bool castShadow)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetShouldCastShadow"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			this.SetShouldCastShadow_Implementation(castShadow);
			return;
		}
		CharRenderingComponent.__SetShouldCastShadow_FunctionParams* ptr = stackalloc CharRenderingComponent.__SetShouldCastShadow_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__SetShouldCastShadow_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->castShadow = castShadow;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AD5A RID: 109914 RVA: 0x0083DD7C File Offset: 0x0083BF7C
	protected void SetShouldCastShadow_Implementation(bool castShadow)
	{
		CharDecalShadow charDecalShadow = this.GetComponent(10) as CharDecalShadow;
		if (charDecalShadow == null)
		{
			return;
		}
		charDecalShadow.SetShouldCastShadow(castShadow);
	}

	// Token: 0x0601AD5B RID: 109915 RVA: 0x0083DDA4 File Offset: 0x0083BFA4
	public void Update(float delta)
	{
		if (!this.CanUpdate)
		{
			return;
		}
		if (!this.IsValid())
		{
			return;
		}
		if (CharRenderingComponent.DisableForDebug)
		{
			this.ResetAllRenderingStateForDebug();
		}
		this.DeltaTime = delta;
		if (this.IsInit)
		{
			foreach (CharMaterialControlRuntimeDataGroup charMaterialControlRuntimeDataGroup in this.AllMaterialControlRuntimeDataGroupMap.Values)
			{
				if (!charMaterialControlRuntimeDataGroup.IsDead)
				{
					LogicalTimeDilationOut outVal = new LogicalTimeDilationOut
					{
						LogicalTimeDilation = 1f
					};
					charMaterialControlRuntimeDataGroup.BeforeUpdateState(delta, this.GetTimeDilation(outVal));
				}
			}
			foreach (CharRenderBase charRenderBase in this.AllRenderComps)
			{
				if (charRenderBase.GetIsInitSuc())
				{
					charRenderBase.Update();
				}
			}
			foreach (CharRenderBase charRenderBase2 in this.AllRenderComps)
			{
				if (charRenderBase2.GetIsInitSuc())
				{
					charRenderBase2.LateUpdate();
				}
			}
			this.DataGroupAfterUpdate(delta);
		}
		base.UpdateHitMesh(delta);
	}

	// Token: 0x0601AD5C RID: 109916 RVA: 0x0083DEF4 File Offset: 0x0083C0F4
	public unsafe void DataGroupAfterUpdate(float delta)
	{
		foreach (int num in this.AllMaterialControlRuntimeDataGroupMap.Keys)
		{
			CharMaterialControlRuntimeDataGroup charMaterialControlRuntimeDataGroup = this.AllMaterialControlRuntimeDataGroupMap[num];
			charMaterialControlRuntimeDataGroup.AfterUpdateState(delta);
			if (charMaterialControlRuntimeDataGroup.IsDead)
			{
				this.TempRemoveList.Add(num);
			}
		}
		if (this.TempRemoveList != null && this.TempRemoveList.Count > 0)
		{
			for (int i = 0; i < this.TempRemoveList.Count; i++)
			{
				int num2 = this.TempRemoveList[i];
				this.AllMaterialControlRuntimeDataGroupMap.Remove(num2);
				GlobalData.BpEventManager.材质播放结束时.Broadcast(num2);
				EventSystem.Instance.EmitWithTarget<int>(this, EEventName.OnRemoveMaterialControllerGroup, num2);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderCharacter;
				ELogAuthor author = ELogAuthor.ZJF;
				string message = "移除材质控制器组:";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Actor", base.GetOwner());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ID", num2);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			this.TempRemoveList.Clear();
		}
	}

	// Token: 0x0601AD5D RID: 109917 RVA: 0x0083E04C File Offset: 0x0083C24C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetEffectProgress(float progress, int handleId)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetEffectProgress"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			this.SetEffectProgress_Implementation(progress, handleId);
			return;
		}
		CharRenderingComponent.__SetEffectProgress_FunctionParams* ptr = stackalloc CharRenderingComponent.__SetEffectProgress_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__SetEffectProgress_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->progress = progress;
		ptr->handleId = handleId;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AD5E RID: 109918 RVA: 0x0083E0E0 File Offset: 0x0083C2E0
	protected void SetEffectProgress_Implementation(float progress, int handleId)
	{
		if (this.UseMaterialContainerV2)
		{
			CharMaterialControllerV2 charMaterialControllerV = this.GetComponent(14) as CharMaterialControllerV2;
			if (charMaterialControllerV == null)
			{
				return;
			}
			charMaterialControllerV.SetEffectProgress(progress, handleId);
			return;
		}
		else
		{
			CharMaterialController charMaterialController = this.GetComponent(2) as CharMaterialController;
			if (charMaterialController == null)
			{
				return;
			}
			charMaterialController.SetEffectProgress(progress, handleId);
			return;
		}
	}

	// Token: 0x0601AD5F RID: 109919 RVA: 0x0083E12C File Offset: 0x0083C32C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetEffectGroupProgress(float progress, int groupHandleId)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetEffectGroupProgress"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			this.SetEffectGroupProgress_Implementation(progress, groupHandleId);
			return;
		}
		CharRenderingComponent.__SetEffectGroupProgress_FunctionParams* ptr = stackalloc CharRenderingComponent.__SetEffectGroupProgress_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__SetEffectGroupProgress_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->progress = progress;
		ptr->groupHandleId = groupHandleId;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AD60 RID: 109920 RVA: 0x0083E1C0 File Offset: 0x0083C3C0
	protected void SetEffectGroupProgress_Implementation(float progress, int groupHandleId)
	{
		CharMaterialControlRuntimeDataGroup charMaterialControlRuntimeDataGroup;
		if (this.AllMaterialControlRuntimeDataGroupMap.TryGetValue(groupHandleId, out charMaterialControlRuntimeDataGroup))
		{
			charMaterialControlRuntimeDataGroup.SetEffectProgress(progress);
		}
	}

	// Token: 0x0601AD61 RID: 109921 RVA: 0x0083E1E4 File Offset: 0x0083C3E4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void RefreshMaterialController()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("RefreshMaterialController"), CharRenderingComponent.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.RefreshMaterialController_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601AD62 RID: 109922 RVA: 0x0083E240 File Offset: 0x0083C440
	protected void RefreshMaterialController_Implementation()
	{
		if (this.UseMaterialContainerV2)
		{
			CharMaterialContainerV2 charMaterialContainerV = this.GetComponent(13) as CharMaterialContainerV2;
			if (charMaterialContainerV == null)
			{
				return;
			}
			charMaterialContainerV.ForceUpdateOnce();
		}
	}

	// Token: 0x0601AD63 RID: 109923 RVA: 0x0083E270 File Offset: 0x0083C470
	public bool IsMaterialControllerDataValid(int handleId)
	{
		if (this.UseMaterialContainerV2)
		{
			CharMaterialControllerV2 charMaterialControllerV = this.GetComponent(14) as CharMaterialControllerV2;
			return charMaterialControllerV != null && charMaterialControllerV.GetRuntimeMaterialControllerValid(handleId);
		}
		CharMaterialController charMaterialController = this.GetComponent(2) as CharMaterialController;
		return charMaterialController != null && charMaterialController.GetRuntimeMaterialControllerValid(handleId);
	}

	// Token: 0x0601AD64 RID: 109924 RVA: 0x0083E2BC File Offset: 0x0083C4BC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void Destroy()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("Destroy"), CharRenderingComponent.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.Destroy_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601AD65 RID: 109925 RVA: 0x0083E318 File Offset: 0x0083C518
	protected void Destroy_Implementation()
	{
		if (!this.IsInit)
		{
			return;
		}
		this.ResetAllRenderingState();
		foreach (CharRenderBase charRenderBase in this.AllRenderComps)
		{
			charRenderBase.Destroy();
		}
		this.AllRenderComps = new List<CharRenderBase>();
		this.AllRenderCompsMap.Clear();
		this.IsInit = false;
		this.IsStartInvoke = false;
		this.RenderType = new ECharacterRenderingType?(ECharacterRenderingType.Error);
		if (this.CachedOwnerEntity != null && this.RemoveInteractionOnRoleGoDownFinish != null)
		{
			EventSystem.Instance.RemoveWithTarget(this.CachedOwnerEntity, EEventName.OnRoleGoDownFinish, this.RemoveInteractionOnRoleGoDownFinish);
			this.OnRoleGoDownFinishEventAdded = false;
		}
		if (!RenderModuleController.Instance.RemoveCharRenderShell(this))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderCharacter;
			ELogAuthor author = ELogAuthor.MY;
			string message = "材质控制器销毁失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Actor", base.GetOwner());
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
	}

	// Token: 0x0601AD66 RID: 109926 RVA: 0x0083E414 File Offset: 0x0083C614
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void OnFinalizedLevelSequence()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnFinalizedLevelSequence"), CharRenderingComponent.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.OnFinalizedLevelSequence_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601AD67 RID: 109927 RVA: 0x0083E470 File Offset: 0x0083C670
	protected void OnFinalizedLevelSequence_Implementation()
	{
		foreach (int handle in this.SequenceHandleIds)
		{
			this.RemoveMaterialControllerData(handle);
			this.RemoveMaterialControllerDataGroup(handle);
		}
		this.SequenceHandleIds = new List<int>();
		USkeletalMeshComponent mesh = ((ACharacter)base.GetOwner()).Mesh;
		mesh.SetCustomPrimitiveDataFloat(0, 0f);
		mesh.SetCustomPrimitiveDataFloat(1, 0f);
		mesh.ExposeToCinematicsCustomLightFactor = 0f;
		mesh.ExposeToCinematicsCustomLightYaw = 0f;
	}

	// Token: 0x0601AD68 RID: 109928 RVA: 0x0083E514 File Offset: 0x0083C714
	[NullableContext(1)]
	private CharRenderBase[] GetRenderComps()
	{
		this.UseMaterialContainerV2 = RenderConfig.UseMaterialContainerV2;
		return RenderUtil.GetRenderComps(this.RenderType.Value, this.UseMaterialContainerV2, this.MonsterUseBodyEffect);
	}

	// Token: 0x0601AD69 RID: 109929 RVA: 0x0083E540 File Offset: 0x0083C740
	private unsafe void InvokeStart()
	{
		if (!this.IsStartInvoke)
		{
			this.IsStartInvoke = true;
			foreach (CharRenderBase charRenderBase in this.AllRenderComps)
			{
				try
				{
					charRenderBase.Start();
				}
				catch
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.RenderCharacter;
					ELogAuthor author = ELogAuthor.LSY;
					string message = "错误:组件初始化错误:";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Actor", base.GetOwner());
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("组件ID", charRenderBase.GetComponentId());
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
			}
			foreach (CharRenderBase charRenderBase2 in this.AllRenderComps)
			{
				if (!charRenderBase2.GetIsInitSuc())
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.RenderCharacter;
					ELogAuthor author2 = ELogAuthor.MY;
					string message2 = "错误:组件初始化错误:";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Actor", base.GetOwner());
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("组件ID", charRenderBase2.GetComponentId());
					instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				}
			}
			if (!this.IsRecord && Info.Instance.IsGameRunning())
			{
				RenderModuleController.Instance.AddCharRenderShell(this);
			}
			if (this.UseProxy)
			{
				TsBaseCharacter tsBaseCharacter = this.CachedOwner as TsBaseCharacter;
				if (tsBaseCharacter != null && tsBaseCharacter.Mesh != null)
				{
					this.AddProxy(tsBaseCharacter.Mesh);
				}
			}
			UKuroMaterialControllerComponent sureMaterialController = base.GetSureMaterialController();
			if (sureMaterialController != null)
			{
				FKuroMaterialControllerPreBodyInfoRuntimeReInit fkuroMaterialControllerPreBodyInfoRuntimeReInit = DelegateUtils.ToManualReleaseDelegate<FKuroMaterialControllerPreBodyInfoRuntimeReInit>(new Action<FName>(this.PreBodyInfoRuntimeInitEvent));
				sureMaterialController.RegisterPreBodyInfoRuntimeInitEvent(fkuroMaterialControllerPreBodyInfoRuntimeReInit);
			}
			if (sureMaterialController == null)
			{
				return;
			}
			FKuroMaterialControllerPostBodyInfoRuntimeReInit fkuroMaterialControllerPostBodyInfoRuntimeReInit = DelegateUtils.ToManualReleaseDelegate<FKuroMaterialControllerPostBodyInfoRuntimeReInit>(new Action<FName>(this.PostBodyInfoRuntimeInitEvent));
			sureMaterialController.RegisterPostBodyInfoRuntimeInitEvent(fkuroMaterialControllerPostBodyInfoRuntimeReInit);
		}
	}

	// Token: 0x0601AD6A RID: 109930 RVA: 0x0083E754 File Offset: 0x0083C954
	[NullableContext(1)]
	private void AddProxy(USkeletalMeshComponent comp)
	{
		if (this.CachedOwner == null)
		{
			return;
		}
		AActor cachedOwner = this.CachedOwner;
		TSubclassOf<UActorComponent> @class = USkeletalMeshComponent.StaticClass();
		bool bManualAttachment = false;
		FTransform ftransform = new FTransform();
		this.Proxy = (USkeletalMeshComponent)cachedOwner.AddComponentByClass(@class, bManualAttachment, ftransform, false, new FName("Proxy"));
		this.Proxy.SetSkeletalMesh(comp.SkeletalMesh, true);
		this.Proxy.SetMasterPoseComponent(comp, false);
		this.Proxy.bUseBoundsFromMasterPoseComponent = true;
		this.Proxy.SetRenderInMainPass(this.ProxyRenderInMainPass);
		this.Proxy.SetCastShadow(this.ProxyRenderShadow);
		this.Proxy.SetRenderKuroTrail(this.ProxyRenderTrail);
		this.Proxy.K2_AttachToComponent(comp, null, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.KeepRelative, true, true);
		if (this.ProxyMaterialsOverride != null && this.ProxyMaterialsOverride.Num() > 0)
		{
			int i = 0;
			int num = this.ProxyMaterialsOverride.Num();
			while (i < num)
			{
				this.Proxy.SetMaterial(i, this.ProxyMaterialsOverride.Get(i));
				i++;
			}
		}
	}

	// Token: 0x0601AD6B RID: 109931 RVA: 0x0083E85C File Offset: 0x0083CA5C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual bool ShouldTickAfterGoDown()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ShouldTickAfterGoDown"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			return this.ShouldTickAfterGoDown_Implementation();
		}
		CharRenderingComponent.__ShouldTickAfterGoDown_FunctionParams* ptr = stackalloc CharRenderingComponent.__ShouldTickAfterGoDown_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__ShouldTickAfterGoDown_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0601AD6C RID: 109932 RVA: 0x0083E8E8 File Offset: 0x0083CAE8
	protected bool ShouldTickAfterGoDown_Implementation()
	{
		if (this.UseMaterialContainerV2)
		{
			CharMaterialContainerV2 charMaterialContainerV = this.GetComponent(13) as CharMaterialContainerV2;
			if (charMaterialContainerV != null)
			{
				return charMaterialContainerV.GetAnyUnloopEffect();
			}
		}
		return false;
	}

	// Token: 0x17002B75 RID: 11125
	// (get) Token: 0x0601AD6D RID: 109933 RVA: 0x0083E918 File Offset: 0x0083CB18
	private bool IsInDebugMode
	{
		get
		{
			if (!Info.Instance.IsGameRunning())
			{
				this.IsInDebugModeInternal = new bool?(WorldModel.Instance.IsStandalone || this.IsRecord || GlobalData.IsPlayInEditor);
			}
			else if (this.IsInDebugModeInternal == null)
			{
				this.IsInDebugModeInternal = new bool?(GameModeModel.Instance.IsSilentLogin || WorldModel.Instance.IsStandalone || this.IsRecord || GlobalData.IsPlayInEditor);
			}
			return this.IsInDebugModeInternal.Value;
		}
	}

	// Token: 0x17002B76 RID: 11126
	// (get) Token: 0x0601AD6E RID: 109934 RVA: 0x0083E9A5 File Offset: 0x0083CBA5
	private bool IsRecord
	{
		get
		{
			if (this.IsRecordInternal == null)
			{
				this.IsRecordInternal = new bool?(base.GetOwner() is AKuroRecordCharacter);
			}
			return this.IsRecordInternal.Value;
		}
	}

	// Token: 0x0601AD6F RID: 109935 RVA: 0x0083E9D8 File Offset: 0x0083CBD8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void ReceiveBeginPlay()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveBeginPlay"), CharRenderingComponent.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ReceiveBeginPlay_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601AD70 RID: 109936 RVA: 0x0083EA31 File Offset: 0x0083CC31
	protected virtual void ReceiveBeginPlay_Implementation()
	{
		base.SetComponentTickEnabled(this.IsRecord);
	}

	// Token: 0x0601AD71 RID: 109937 RVA: 0x0083EA40 File Offset: 0x0083CC40
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTick(float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTick"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			this.ReceiveTick_Implementation(deltaSeconds);
			return;
		}
		UActorComponent.__ReceiveTick_FunctionParams* ptr = stackalloc UActorComponent.__ReceiveTick_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UActorComponent.__ReceiveTick_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->DeltaSeconds = deltaSeconds;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AD72 RID: 109938 RVA: 0x0083EACC File Offset: 0x0083CCCC
	protected virtual void ReceiveTick_Implementation(float deltaSeconds)
	{
		if (this.IsRecord)
		{
			this.Update(deltaSeconds);
		}
	}

	// Token: 0x0601AD73 RID: 109939 RVA: 0x0083EAE0 File Offset: 0x0083CCE0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ReceiveSeqTick(float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(CharRenderingComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveSeqTick"), CharRenderingComponent.StaticClass(), out intPtr, out num))
		{
			this.ReceiveSeqTick_Implementation(deltaSeconds);
			return;
		}
		CharRenderingComponent.__ReceiveSeqTick_FunctionParams* ptr = stackalloc CharRenderingComponent.__ReceiveSeqTick_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(CharRenderingComponent.__ReceiveSeqTick_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->deltaSeconds = deltaSeconds;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AD74 RID: 109940 RVA: 0x0083EB6C File Offset: 0x0083CD6C
	protected void ReceiveSeqTick_Implementation(float deltaSeconds)
	{
		if (Info.Instance.IsGameRunning())
		{
			return;
		}
		this.Update(deltaSeconds);
	}

	// Token: 0x0601AD75 RID: 109941 RVA: 0x0083EB84 File Offset: 0x0083CD84
	[NullableContext(1)]
	public void AddHitMeshInfoByPath(string dataPath, FName? hitPart, Vector impactPoint, Rotator hitRotator)
	{
		FTransformDouble transform = UKismetMathLibrary.MakeTransformDouble(impactPoint.ToUeVector(false), hitRotator.ToUeRotator(), Vector.OneVector);
		ResourceSystem.Instance.LoadAsync<PDA_HitMeshData_C>(dataPath, delegate([Nullable(2)] PDA_HitMeshData_C asset, string _)
		{
			if (asset != null)
			{
				UKuroCharRenderingComponent <>4__this = this;
				USkeletalMesh hitSkeletalMesh = asset.HitSkeletalMesh;
				FName socket = hitPart ?? FName.NAME_None;
				float lastTime = asset.LastTime;
				FTransform hitSkeletalMeshTransform = asset.HitSkeletalMeshTransform;
				<>4__this.AddHitMeshOnSocket(hitSkeletalMesh, transform, socket, lastTime, hitSkeletalMeshTransform);
			}
		}, 100, "js_undefined");
	}

	// Token: 0x0601AD76 RID: 109942 RVA: 0x0083EBE2 File Offset: 0x0083CDE2
	static CharRenderingComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CharRenderingComponent.CreateStaticDefaultValue), new Action(CharRenderingComponent.ResetStaticDefaultValue));
	}

	// Token: 0x0601AD77 RID: 109943 RVA: 0x0083EC01 File Offset: 0x0083CE01
	public static void CreateStaticDefaultValue()
	{
		CharRenderingComponent.GlobalDisableDitherEffect = false;
		CharRenderingComponent.MotionMeshShadingRate = new EMaterialShadingRate[]
		{
			EMaterialShadingRate.MSR_2x2,
			EMaterialShadingRate.MSR_4x4
		};
		CharRenderingComponent.MotionVelocitySquared = new int[]
		{
			40000,
			250000
		};
		CharRenderingComponent.DisableForDebug = false;
	}

	// Token: 0x0601AD78 RID: 109944 RVA: 0x0083EC3D File Offset: 0x0083CE3D
	public static void ResetStaticDefaultValue()
	{
		CharRenderingComponent.GlobalDisableDitherEffect = false;
		CharRenderingComponent.MotionMeshShadingRate = null;
		CharRenderingComponent.MotionVelocitySquared = null;
		CharRenderingComponent.DisableForDebug = false;
	}

	// Token: 0x0601AD79 RID: 109945 RVA: 0x0083EC57 File Offset: 0x0083CE57
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (CharRenderingComponent._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Character/Manager/CharRenderingComponent.CharRenderingComponent_C");
		}
		return CharRenderingComponent._ClassPtr;
	}

	// Token: 0x0601AD7A RID: 109946 RVA: 0x0083EC7C File Offset: 0x0083CE7C
	public CharRenderingComponent() : this(BuiltinUtils.AllocNativeUObject(CharRenderingComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601AD7B RID: 109947 RVA: 0x0083ECA4 File Offset: 0x0083CEA4
	[NullableContext(1)]
	public CharRenderingComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CharRenderingComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601AD7C RID: 109948 RVA: 0x0083ECD7 File Offset: 0x0083CED7
	protected CharRenderingComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601AD7D RID: 109949 RVA: 0x0083ED04 File Offset: 0x0083CF04
	protected unsafe virtual void __CPPCALL_QuickInitAndAddData_Implementation(CharRenderingComponent.__QuickInitAndAddData_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->data);
		ASkeletalMeshActor orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<ASkeletalMeshActor>(__Params->meshActor);
		__Params->__Result = this.QuickInitAndAddData_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601AD7E RID: 109950 RVA: 0x0083ED38 File Offset: 0x0083CF38
	protected unsafe virtual void __CPPCALL_QuickInitAndAddDataWithMeshComponent_Implementation(CharRenderingComponent.__QuickInitAndAddDataWithMeshComponent_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->data);
		UMeshComponent orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMeshComponent>(__Params->meshComponent);
		__Params->__Result = this.QuickInitAndAddDataWithMeshComponent_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601AD7F RID: 109951 RVA: 0x0083ED6C File Offset: 0x0083CF6C
	protected unsafe virtual void __CPPCALL_QuickInitAndAddDataGroup_Implementation(CharRenderingComponent.__QuickInitAndAddDataGroup_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->data);
		ASkeletalMeshActor orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<ASkeletalMeshActor>(__Params->meshActor);
		__Params->__Result = this.QuickInitAndAddDataGroup_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601AD80 RID: 109952 RVA: 0x0083EDA0 File Offset: 0x0083CFA0
	protected unsafe virtual void __CPPCALL_QuickInitAndAddDataGroupWithMeshComponent_Implementation(CharRenderingComponent.__QuickInitAndAddDataGroupWithMeshComponent_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->data);
		UMeshComponent orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMeshComponent>(__Params->meshComponent);
		__Params->__Result = this.QuickInitAndAddDataGroupWithMeshComponent_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601AD81 RID: 109953 RVA: 0x0083EDD4 File Offset: 0x0083CFD4
	protected unsafe virtual void __CPPCALL_Init_Implementation(CharRenderingComponent.__Init_FunctionParams* __Params)
	{
		ECharacterRenderingType renderType = (ECharacterRenderingType)__Params->renderType;
		this.Init_Implementation(renderType);
	}

	// Token: 0x0601AD82 RID: 109954 RVA: 0x0083EDF0 File Offset: 0x0083CFF0
	protected unsafe virtual void __CPPCALL_SetLogicOwner_Implementation(CharRenderingComponent.__SetLogicOwner_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->owner);
		this.SetLogicOwner_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601AD83 RID: 109955 RVA: 0x0083EE10 File Offset: 0x0083D010
	protected unsafe virtual void __CPPCALL_AddComponent_Implementation(CharRenderingComponent.__AddComponent_FunctionParams* __Params)
	{
		string skelName = FString.ToString((void*)(&__Params->skelName));
		UMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMeshComponent>(__Params->skeletalComp);
		this.AddComponent_Implementation(skelName, orCreateUObjectByNativePointer);
	}

	// Token: 0x0601AD84 RID: 109956 RVA: 0x0083EE40 File Offset: 0x0083D040
	protected unsafe virtual void __CPPCALL_AddComponentWithEmptyMaterial_Implementation(CharRenderingComponent.__AddComponentWithEmptyMaterial_FunctionParams* __Params)
	{
		string skelName = FString.ToString((void*)(&__Params->skelName));
		UMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMeshComponent>(__Params->skeletalComp);
		this.AddComponentWithEmptyMaterial_Implementation(skelName, orCreateUObjectByNativePointer);
	}

	// Token: 0x0601AD85 RID: 109957 RVA: 0x0083EE70 File Offset: 0x0083D070
	protected unsafe virtual void __CPPCALL_RemoveComponent_Implementation(CharRenderingComponent.__RemoveComponent_FunctionParams* __Params)
	{
		string skelName = FString.ToString((void*)(&__Params->skelName));
		this.RemoveComponent_Implementation(skelName);
	}

	// Token: 0x0601AD86 RID: 109958 RVA: 0x0083EE94 File Offset: 0x0083D094
	protected unsafe virtual void __CPPCALL_AddComponentByCase_Implementation(CharRenderingComponent.__AddComponentByCase_FunctionParams* __Params)
	{
		ECharacterControllerCaseType caseType = (ECharacterControllerCaseType)__Params->caseType;
		UMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMeshComponent>(__Params->skeletalComp);
		this.AddComponentByCase_Implementation(caseType, orCreateUObjectByNativePointer);
	}

	// Token: 0x0601AD87 RID: 109959 RVA: 0x0083EEBC File Offset: 0x0083D0BC
	protected unsafe virtual void __CPPCALL_RemoveComponentByCase_Implementation(CharRenderingComponent.__RemoveComponentByCase_FunctionParams* __Params)
	{
		ECharacterControllerCaseType caseType = (ECharacterControllerCaseType)__Params->caseType;
		this.RemoveComponentByCase_Implementation(caseType);
	}

	// Token: 0x0601AD88 RID: 109960 RVA: 0x0083EED8 File Offset: 0x0083D0D8
	protected unsafe virtual void __CPPCALL_AddComponentInnerV2_Implementation(CharRenderingComponent.__AddComponentInnerV2_FunctionParams* __Params)
	{
		string skelName = FString.ToString((void*)(&__Params->skelName));
		UMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMeshComponent>(__Params->skeletalComp);
		this.AddComponentInnerV2_Implementation(skelName, orCreateUObjectByNativePointer, __Params->useEmptyMaterial);
	}

	// Token: 0x0601AD89 RID: 109961 RVA: 0x0083EF0C File Offset: 0x0083D10C
	protected unsafe virtual void __CPPCALL_RemoveComponentInnerV2_Implementation(CharRenderingComponent.__RemoveComponentInnerV2_FunctionParams* __Params)
	{
		string skelName = FString.ToString((void*)(&__Params->skelName));
		this.RemoveComponentInnerV2_Implementation(skelName);
	}

	// Token: 0x0601AD8A RID: 109962 RVA: 0x0083EF30 File Offset: 0x0083D130
	protected unsafe virtual void __CPPCALL_GetSkeletalMeshComponent_Implementation(CharRenderingComponent.__GetSkeletalMeshComponent_FunctionParams* __Params)
	{
		string skelName = FString.ToString((void*)(&__Params->skelName));
		ref IntPtr ptr = ref *(&__Params->__Result);
		USkeletalMeshComponent skeletalMeshComponent_Implementation = this.GetSkeletalMeshComponent_Implementation(skelName);
		ptr = ((skeletalMeshComponent_Implementation != null) ? skeletalMeshComponent_Implementation.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0601AD8B RID: 109963 RVA: 0x0083EF68 File Offset: 0x0083D168
	protected unsafe virtual void __CPPCALL_GetSkeletalMeshComponentBodyName_Implementation(CharRenderingComponent.__GetSkeletalMeshComponentBodyName_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->skeletalComp);
		__Params->__Result = this.GetSkeletalMeshComponentBodyName_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601AD8C RID: 109964 RVA: 0x0083EF8E File Offset: 0x0083D18E
	protected unsafe virtual void __CPPCALL_CheckInit_Implementation(CharRenderingComponent.__CheckInit_FunctionParams* __Params)
	{
		__Params->__Result = this.CheckInit_Implementation();
	}

	// Token: 0x0601AD8D RID: 109965 RVA: 0x0083EF9C File Offset: 0x0083D19C
	protected unsafe virtual void __CPPCALL_SetDebug_Implementation(CharRenderingComponent.__SetDebug_FunctionParams* __Params)
	{
		this.SetDebug_Implementation(__Params->value);
	}

	// Token: 0x0601AD8E RID: 109966 RVA: 0x0083EFAA File Offset: 0x0083D1AA
	protected unsafe virtual void __CPPCALL_GetDebugInfo_Implementation(CharRenderingComponent.__GetDebugInfo_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		PD_MaterialDebug_C debugInfo_Implementation = this.GetDebugInfo_Implementation();
		ptr = ((debugInfo_Implementation != null) ? debugInfo_Implementation.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0601AD8F RID: 109967 RVA: 0x0083EFC8 File Offset: 0x0083D1C8
	protected unsafe virtual void __CPPCALL_ReceiveEndPlay_Implementation(UActorComponent.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		this.ReceiveEndPlay_Implementation(endPlayReason);
	}

	// Token: 0x0601AD90 RID: 109968 RVA: 0x0083EFE8 File Offset: 0x0083D1E8
	protected unsafe virtual void __CPPCALL_GetInWater_Implementation(CharRenderingComponent.__GetInWater_FunctionParams* __Params)
	{
		__Params->__Result = this.GetInWater_Implementation(__Params->depthThreshold);
	}

	// Token: 0x0601AD91 RID: 109969 RVA: 0x0083EFFC File Offset: 0x0083D1FC
	protected unsafe virtual void __CPPCALL_GetInAudioShr_Implementation(CharRenderingComponent.__GetInAudioShr_FunctionParams* __Params)
	{
		__Params->__Result = this.GetInAudioShr_Implementation();
	}

	// Token: 0x0601AD92 RID: 109970 RVA: 0x0083F00A File Offset: 0x0083D20A
	protected virtual void __CPPCALL_ResetAllRenderingState_Implementation()
	{
		this.ResetAllRenderingState_Implementation();
	}

	// Token: 0x0601AD93 RID: 109971 RVA: 0x0083F014 File Offset: 0x0083D214
	protected unsafe virtual void __CPPCALL_AddMaterialControllerDataGroup_Implementation(CharRenderingComponent.__AddMaterialControllerDataGroup_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->data);
		__Params->__Result = this.AddMaterialControllerDataGroup_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601AD94 RID: 109972 RVA: 0x0083F03C File Offset: 0x0083D23C
	protected unsafe virtual void __CPPCALL_AddMaterialControllerDataGroupWithAnimObject_Implementation(CharRenderingComponent.__AddMaterialControllerDataGroupWithAnimObject_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->data);
		USkeletalMeshComponent orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->animObject);
		__Params->__Result = this.AddMaterialControllerDataGroupWithAnimObject_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601AD95 RID: 109973 RVA: 0x0083F06F File Offset: 0x0083D26F
	protected unsafe virtual void __CPPCALL_RemoveMaterialControllerDataGroup_Implementation(CharRenderingComponent.__RemoveMaterialControllerDataGroup_FunctionParams* __Params)
	{
		this.RemoveMaterialControllerDataGroup_Implementation(__Params->handle);
	}

	// Token: 0x0601AD96 RID: 109974 RVA: 0x0083F07D File Offset: 0x0083D27D
	protected unsafe virtual void __CPPCALL_RemoveMaterialControllerDataGroupWithEnding_Implementation(CharRenderingComponent.__RemoveMaterialControllerDataGroupWithEnding_FunctionParams* __Params)
	{
		this.RemoveMaterialControllerDataGroupWithEnding_Implementation(__Params->handle);
	}

	// Token: 0x0601AD97 RID: 109975 RVA: 0x0083F08C File Offset: 0x0083D28C
	protected unsafe virtual void __CPPCALL_AddMaterialControllerDataWithAnimObject_Implementation(CharRenderingComponent.__AddMaterialControllerDataWithAnimObject_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->data);
		USkeletalMeshComponent orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->animObject);
		UObject orCreateUObjectByNativePointer3 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->userData);
		__Params->__Result = this.AddMaterialControllerDataWithAnimObject_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, orCreateUObjectByNativePointer3);
	}

	// Token: 0x0601AD98 RID: 109976 RVA: 0x0083F0CC File Offset: 0x0083D2CC
	protected unsafe virtual void __CPPCALL_AddMaterialControllerData_Implementation(CharRenderingComponent.__AddMaterialControllerData_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->data);
		__Params->__Result = this.AddMaterialControllerData_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601AD99 RID: 109977 RVA: 0x0083F0F2 File Offset: 0x0083D2F2
	protected unsafe virtual void __CPPCALL_RemoveMaterialControllerData_Implementation(CharRenderingComponent.__RemoveMaterialControllerData_FunctionParams* __Params)
	{
		this.RemoveMaterialControllerData_Implementation(__Params->handle);
	}

	// Token: 0x0601AD9A RID: 109978 RVA: 0x0083F100 File Offset: 0x0083D300
	protected unsafe virtual void __CPPCALL_SetEffectPause_Implementation(CharRenderingComponent.__SetEffectPause_FunctionParams* __Params)
	{
		this.SetEffectPause_Implementation(__Params->handle, __Params->paused);
	}

	// Token: 0x0601AD9B RID: 109979 RVA: 0x0083F114 File Offset: 0x0083D314
	protected unsafe virtual void __CPPCALL_RemoveMaterialControllerDataWithEnding_Implementation(CharRenderingComponent.__RemoveMaterialControllerDataWithEnding_FunctionParams* __Params)
	{
		this.RemoveMaterialControllerDataWithEnding_Implementation(__Params->handle);
	}

	// Token: 0x0601AD9C RID: 109980 RVA: 0x0083F124 File Offset: 0x0083D324
	protected unsafe virtual void __CPPCALL_SetDitherEffect_Implementation(CharRenderingComponent.__SetDitherEffect_FunctionParams* __Params)
	{
		ECharacterDitherType ditherType = (ECharacterDitherType)__Params->ditherType;
		this.SetDitherEffect_Implementation(__Params->ditherRate, ditherType);
	}

	// Token: 0x0601AD9D RID: 109981 RVA: 0x0083F145 File Offset: 0x0083D345
	protected unsafe virtual void __CPPCALL_SetDisableFightDither_Implementation(CharRenderingComponent.__SetDisableFightDither_FunctionParams* __Params)
	{
		this.SetDisableFightDither_Implementation(__Params->disable);
	}

	// Token: 0x0601AD9E RID: 109982 RVA: 0x0083F153 File Offset: 0x0083D353
	protected virtual void __CPPCALL_SetDitherApplyAll_Implementation()
	{
		this.SetDitherApplyAll_Implementation();
	}

	// Token: 0x0601AD9F RID: 109983 RVA: 0x0083F15B File Offset: 0x0083D35B
	protected virtual void __CPPCALL_SetDitherApplyHeadsOnly_Implementation()
	{
		this.SetDitherApplyHeadsOnly_Implementation();
	}

	// Token: 0x0601ADA0 RID: 109984 RVA: 0x0083F163 File Offset: 0x0083D363
	protected unsafe virtual void __CPPCALL_SetDitherUseHeadMaskHideEffect_Implementation(CharRenderingComponent.__SetDitherUseHeadMaskHideEffect_FunctionParams* __Params)
	{
		this.SetDitherUseHeadMaskHideEffect_Implementation(__Params->enable);
	}

	// Token: 0x0601ADA1 RID: 109985 RVA: 0x0083F171 File Offset: 0x0083D371
	protected virtual void __CPPCALL_TempRemoveDither_Implementation()
	{
		this.TempRemoveDither_Implementation();
	}

	// Token: 0x0601ADA2 RID: 109986 RVA: 0x0083F179 File Offset: 0x0083D379
	protected virtual void __CPPCALL_TempRecoverDither_Implementation()
	{
		this.TempRecoverDither_Implementation();
	}

	// Token: 0x0601ADA3 RID: 109987 RVA: 0x0083F181 File Offset: 0x0083D381
	protected unsafe virtual void __CPPCALL_GetOpacityConsiderVisibility_Implementation(CharRenderingComponent.__GetOpacityConsiderVisibility_FunctionParams* __Params)
	{
		__Params->__Result = this.GetOpacityConsiderVisibility_Implementation();
	}

	// Token: 0x0601ADA4 RID: 109988 RVA: 0x0083F190 File Offset: 0x0083D390
	protected unsafe virtual void __CPPCALL_SetMaterialPropertyFloat_Implementation(CharRenderingComponent.__SetMaterialPropertyFloat_FunctionParams* __Params)
	{
		ECharacterBodySpecifiedType bodyType = (ECharacterBodySpecifiedType)__Params->bodyType;
		ECharacterSlotSpecifiedType slotType = (ECharacterSlotSpecifiedType)__Params->slotType;
		string propertyName = FString.ToString((void*)(&__Params->propertyName));
		this.SetMaterialPropertyFloat_Implementation(bodyType, __Params->sectionIndex, slotType, propertyName, __Params->value);
	}

	// Token: 0x0601ADA5 RID: 109989 RVA: 0x0083F1D0 File Offset: 0x0083D3D0
	protected unsafe virtual void __CPPCALL_SetMaterialPropertyColor_Implementation(CharRenderingComponent.__SetMaterialPropertyColor_FunctionParams* __Params)
	{
		ECharacterBodySpecifiedType bodyType = (ECharacterBodySpecifiedType)__Params->bodyType;
		ECharacterSlotSpecifiedType slotType = (ECharacterSlotSpecifiedType)__Params->slotType;
		string propertyName = FString.ToString((void*)(&__Params->propertyName));
		this.SetMaterialPropertyColor_Implementation(bodyType, __Params->sectionIndex, slotType, propertyName, __Params->value);
	}

	// Token: 0x0601ADA6 RID: 109990 RVA: 0x0083F210 File Offset: 0x0083D410
	protected unsafe virtual void __CPPCALL_SetMaterialPropertyFloatV2_Implementation(CharRenderingComponent.__SetMaterialPropertyFloatV2_FunctionParams* __Params)
	{
		EKuroCharBodySpecifiedType bodyType = (EKuroCharBodySpecifiedType)__Params->bodyType;
		EKuroCharSlotSpecifiedType slotType = (EKuroCharSlotSpecifiedType)__Params->slotType;
		EKuroCharMeshPart meshPart = (EKuroCharMeshPart)__Params->meshPart;
		this.SetMaterialPropertyFloatV2_Implementation(__Params->name, __Params->value, bodyType, slotType, meshPart);
	}

	// Token: 0x0601ADA7 RID: 109991 RVA: 0x0083F247 File Offset: 0x0083D447
	protected unsafe virtual void __CPPCALL_AddFloatUpdateParamPermanentByIndexV2_Implementation(CharRenderingComponent.__AddFloatUpdateParamPermanentByIndexV2_FunctionParams* __Params)
	{
		this.AddFloatUpdateParamPermanentByIndexV2_Implementation(__Params->name, __Params->value, __Params->bodyName, __Params->materialIndex);
	}

	// Token: 0x0601ADA8 RID: 109992 RVA: 0x0083F268 File Offset: 0x0083D468
	protected unsafe virtual void __CPPCALL_SetMaterialPropertyColorV2_Implementation(CharRenderingComponent.__SetMaterialPropertyColorV2_FunctionParams* __Params)
	{
		EKuroCharBodySpecifiedType bodyType = (EKuroCharBodySpecifiedType)__Params->bodyType;
		EKuroCharSlotSpecifiedType slotType = (EKuroCharSlotSpecifiedType)__Params->slotType;
		EKuroCharMeshPart meshPart = (EKuroCharMeshPart)__Params->meshPart;
		this.SetMaterialPropertyColorV2_Implementation(__Params->name, __Params->value, bodyType, slotType, meshPart);
	}

	// Token: 0x0601ADA9 RID: 109993 RVA: 0x0083F2A0 File Offset: 0x0083D4A0
	protected unsafe virtual void __CPPCALL_SetMaterialReplaceV2_Implementation(CharRenderingComponent.__SetMaterialReplaceV2_FunctionParams* __Params)
	{
		UMaterialInterface orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInterface>(__Params->material);
		EKuroCharBodySpecifiedType bodyType = (EKuroCharBodySpecifiedType)__Params->bodyType;
		EKuroCharSlotSpecifiedType slotType = (EKuroCharSlotSpecifiedType)__Params->slotType;
		EKuroCharMeshPart meshPart = (EKuroCharMeshPart)__Params->meshPart;
		this.SetMaterialReplaceV2_Implementation(orCreateUObjectByNativePointer, bodyType, slotType, meshPart);
	}

	// Token: 0x0601ADAA RID: 109994 RVA: 0x0083F2D8 File Offset: 0x0083D4D8
	protected unsafe virtual void __CPPCALL_RemoveExternalMaterialReplaceV2_Implementation(CharRenderingComponent.__RemoveExternalMaterialReplaceV2_FunctionParams* __Params)
	{
		EKuroCharBodySpecifiedType bodyType = (EKuroCharBodySpecifiedType)__Params->bodyType;
		EKuroCharSlotSpecifiedType slotType = (EKuroCharSlotSpecifiedType)__Params->slotType;
		EKuroCharMeshPart meshPart = (EKuroCharMeshPart)__Params->meshPart;
		this.RemoveExternalMaterialReplaceV2_Implementation(bodyType, slotType, meshPart);
	}

	// Token: 0x0601ADAB RID: 109995 RVA: 0x0083F303 File Offset: 0x0083D503
	protected unsafe virtual void __CPPCALL_SetStarScarEnergy_Implementation(CharRenderingComponent.__SetStarScarEnergy_FunctionParams* __Params)
	{
		this.SetStarScarEnergy_Implementation(__Params->value);
	}

	// Token: 0x0601ADAC RID: 109996 RVA: 0x0083F311 File Offset: 0x0083D511
	protected unsafe virtual void __CPPCALL_SetCapsuleDither_Implementation(CharRenderingComponent.__SetCapsuleDither_FunctionParams* __Params)
	{
		this.SetCapsuleDither_Implementation(__Params->value);
	}

	// Token: 0x0601ADAD RID: 109997 RVA: 0x0083F31F File Offset: 0x0083D51F
	protected unsafe virtual void __CPPCALL_SetDecalShadowEnabled_Implementation(CharRenderingComponent.__SetDecalShadowEnabled_FunctionParams* __Params)
	{
		this.SetDecalShadowEnabled_Implementation(__Params->enable);
	}

	// Token: 0x0601ADAE RID: 109998 RVA: 0x0083F32D File Offset: 0x0083D52D
	protected virtual void __CPPCALL_DisableAllShadowByDecalShadowComponent_Implementation()
	{
		this.DisableAllShadowByDecalShadowComponent_Implementation();
	}

	// Token: 0x0601ADAF RID: 109999 RVA: 0x0083F335 File Offset: 0x0083D535
	protected unsafe virtual void __CPPCALL_SetShouldCastShadow_Implementation(CharRenderingComponent.__SetShouldCastShadow_FunctionParams* __Params)
	{
		this.SetShouldCastShadow_Implementation(__Params->castShadow);
	}

	// Token: 0x0601ADB0 RID: 110000 RVA: 0x0083F343 File Offset: 0x0083D543
	protected unsafe virtual void __CPPCALL_SetEffectProgress_Implementation(CharRenderingComponent.__SetEffectProgress_FunctionParams* __Params)
	{
		this.SetEffectProgress_Implementation(__Params->progress, __Params->handleId);
	}

	// Token: 0x0601ADB1 RID: 110001 RVA: 0x0083F357 File Offset: 0x0083D557
	protected unsafe virtual void __CPPCALL_SetEffectGroupProgress_Implementation(CharRenderingComponent.__SetEffectGroupProgress_FunctionParams* __Params)
	{
		this.SetEffectGroupProgress_Implementation(__Params->progress, __Params->groupHandleId);
	}

	// Token: 0x0601ADB2 RID: 110002 RVA: 0x0083F36B File Offset: 0x0083D56B
	protected virtual void __CPPCALL_RefreshMaterialController_Implementation()
	{
		this.RefreshMaterialController_Implementation();
	}

	// Token: 0x0601ADB3 RID: 110003 RVA: 0x0083F373 File Offset: 0x0083D573
	protected virtual void __CPPCALL_Destroy_Implementation()
	{
		this.Destroy_Implementation();
	}

	// Token: 0x0601ADB4 RID: 110004 RVA: 0x0083F37B File Offset: 0x0083D57B
	protected virtual void __CPPCALL_OnFinalizedLevelSequence_Implementation()
	{
		this.OnFinalizedLevelSequence_Implementation();
	}

	// Token: 0x0601ADB5 RID: 110005 RVA: 0x0083F383 File Offset: 0x0083D583
	protected unsafe virtual void __CPPCALL_ShouldTickAfterGoDown_Implementation(CharRenderingComponent.__ShouldTickAfterGoDown_FunctionParams* __Params)
	{
		__Params->__Result = this.ShouldTickAfterGoDown_Implementation();
	}

	// Token: 0x0601ADB6 RID: 110006 RVA: 0x0083F391 File Offset: 0x0083D591
	protected virtual void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		this.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601ADB7 RID: 110007 RVA: 0x0083F399 File Offset: 0x0083D599
	protected unsafe virtual void __CPPCALL_ReceiveTick_Implementation(UActorComponent.__ReceiveTick_FunctionParams* __Params)
	{
		this.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x0601ADB8 RID: 110008 RVA: 0x0083F3A7 File Offset: 0x0083D5A7
	protected unsafe virtual void __CPPCALL_ReceiveSeqTick_Implementation(CharRenderingComponent.__ReceiveSeqTick_FunctionParams* __Params)
	{
		this.ReceiveSeqTick_Implementation(__Params->deltaSeconds);
	}

	// Token: 0x0400E925 RID: 59685
	public ECharacterRenderingType? RenderType;

	// Token: 0x0400E926 RID: 59686
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<CharRenderBase> AllRenderComps;

	// Token: 0x0400E927 RID: 59687
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, CharRenderBase> AllRenderCompsMap;

	// Token: 0x0400E928 RID: 59688
	public bool IsInit;

	// Token: 0x0400E929 RID: 59689
	public bool IsStartInvoke;

	// Token: 0x0400E92A RID: 59690
	public float DeltaTime;

	// Token: 0x0400E92B RID: 59691
	public bool IsOnMobile;

	// Token: 0x0400E92C RID: 59692
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, CharMaterialControlRuntimeDataGroup> AllMaterialControlRuntimeDataGroupMap;

	// Token: 0x0400E92D RID: 59693
	public int IndexCount;

	// Token: 0x0400E92E RID: 59694
	[Nullable(2)]
	private List<int> TempRemoveList;

	// Token: 0x0400E92F RID: 59695
	[Nullable(2)]
	private List<int> SequenceHandleIds;

	// Token: 0x0400E930 RID: 59696
	private bool IsDebug;

	// Token: 0x0400E931 RID: 59697
	[Nullable(2)]
	private AActor CachedOwner;

	// Token: 0x0400E932 RID: 59698
	[Nullable(1)]
	private string CachedOwnerName = "";

	// Token: 0x0400E933 RID: 59699
	[Nullable(2)]
	private Entity CachedOwnerEntity;

	// Token: 0x0400E934 RID: 59700
	[Nullable(2)]
	protected AActor LogicOwner;

	// Token: 0x0400E935 RID: 59701
	protected bool IsLogicOwnerTsEffectActor;

	// Token: 0x0400E936 RID: 59702
	public bool IsUiUpdate;

	// Token: 0x0400E937 RID: 59703
	public bool UseMaterialContainerV2 = true;

	// Token: 0x0400E938 RID: 59704
	public bool CanUpdate = true;

	// Token: 0x0400E939 RID: 59705
	[Nullable(1)]
	public static int[] MotionVelocitySquared;

	// Token: 0x0400E93A RID: 59706
	[Nullable(1)]
	public static EMaterialShadingRate[] MotionMeshShadingRate;

	// Token: 0x0400E93B RID: 59707
	public static bool DisableForDebug;

	// Token: 0x0400E93C RID: 59708
	[Nullable(2)]
	private USkeletalMeshComponent Proxy;

	// Token: 0x0400E93D RID: 59709
	[Nullable(2)]
	private BP_MotorExtraComponent_C MotorExtraComp;

	// Token: 0x0400E93E RID: 59710
	private bool DisableFightDither;

	// Token: 0x0400E93F RID: 59711
	private float FightDitherRateCache = 1f;

	// Token: 0x0400E940 RID: 59712
	public static bool GlobalDisableDitherEffect;

	// Token: 0x0400E941 RID: 59713
	protected bool OnRoleGoDownFinishEventAdded;

	// Token: 0x0400E942 RID: 59714
	[Nullable(2)]
	protected Action RemoveInteractionOnRoleGoDownFinish;

	// Token: 0x0400E943 RID: 59715
	private bool? IsInDebugModeInternal;

	// Token: 0x0400E944 RID: 59716
	private bool? IsRecordInternal;

	// Token: 0x0400E945 RID: 59717
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Character/Manager/CharRenderingComponent.CharRenderingComponent_C";

	// Token: 0x0400E946 RID: 59718
	private static IntPtr _ClassPtr;

	// Token: 0x0400E947 RID: 59719
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E948 RID: 59720
	private static int __PropertyOffset_InteractionConfig;

	// Token: 0x0400E949 RID: 59721
	private static int __PropertyOffset_DecalShadowConfig;

	// Token: 0x0400E94A RID: 59722
	private static int __PropertyOffset_MonsterUseBodyEffect;

	// Token: 0x0400E94B RID: 59723
	private static int __PropertyOffset_UseProxy;

	// Token: 0x0400E94C RID: 59724
	private static int __PropertyOffset_ProxyMaterialsOverride;

	// Token: 0x0400E94D RID: 59725
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<UMaterialInterface> _ProxyMaterialsOverride;

	// Token: 0x0400E94E RID: 59726
	private static int __PropertyOffset_ProxyRenderInMainPass;

	// Token: 0x0400E94F RID: 59727
	private static int __PropertyOffset_ProxyRenderShadow;

	// Token: 0x0400E950 RID: 59728
	private static int __PropertyOffset_ProxyRenderTrail;

	// Token: 0x0400E951 RID: 59729
	private static int __PropertyOffset_DitherRemap;

	// Token: 0x020089E4 RID: 35300
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __QuickInitAndAddData_FunctionParams
	{
		// Token: 0x0402BE0B RID: 179723
		[FieldOffset(0)]
		public IntPtr data;

		// Token: 0x0402BE0C RID: 179724
		[FieldOffset(8)]
		public IntPtr meshActor;

		// Token: 0x0402BE0D RID: 179725
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x020089E5 RID: 35301
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __QuickInitAndAddDataWithMeshComponent_FunctionParams
	{
		// Token: 0x0402BE0E RID: 179726
		[FieldOffset(0)]
		public IntPtr data;

		// Token: 0x0402BE0F RID: 179727
		[FieldOffset(8)]
		public IntPtr meshComponent;

		// Token: 0x0402BE10 RID: 179728
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x020089E6 RID: 35302
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __QuickInitAndAddDataGroup_FunctionParams
	{
		// Token: 0x0402BE11 RID: 179729
		[FieldOffset(0)]
		public IntPtr data;

		// Token: 0x0402BE12 RID: 179730
		[FieldOffset(8)]
		public IntPtr meshActor;

		// Token: 0x0402BE13 RID: 179731
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x020089E7 RID: 35303
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __QuickInitAndAddDataGroupWithMeshComponent_FunctionParams
	{
		// Token: 0x0402BE14 RID: 179732
		[FieldOffset(0)]
		public IntPtr data;

		// Token: 0x0402BE15 RID: 179733
		[FieldOffset(8)]
		public IntPtr meshComponent;

		// Token: 0x0402BE16 RID: 179734
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x020089E8 RID: 35304
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __Init_FunctionParams
	{
		// Token: 0x0402BE17 RID: 179735
		[FieldOffset(0)]
		public byte renderType;
	}

	// Token: 0x020089E9 RID: 35305
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SetLogicOwner_FunctionParams
	{
		// Token: 0x0402BE18 RID: 179736
		[FieldOffset(0)]
		public IntPtr owner;
	}

	// Token: 0x020089EA RID: 35306
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __AddComponent_FunctionParams
	{
		// Token: 0x0402BE19 RID: 179737
		[FieldOffset(0)]
		public FString skelName;

		// Token: 0x0402BE1A RID: 179738
		[FieldOffset(16)]
		public IntPtr skeletalComp;
	}

	// Token: 0x020089EB RID: 35307
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __AddComponentWithEmptyMaterial_FunctionParams
	{
		// Token: 0x0402BE1B RID: 179739
		[FieldOffset(0)]
		public FString skelName;

		// Token: 0x0402BE1C RID: 179740
		[FieldOffset(16)]
		public IntPtr skeletalComp;
	}

	// Token: 0x020089EC RID: 35308
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __RemoveComponent_FunctionParams
	{
		// Token: 0x0402BE1D RID: 179741
		[FieldOffset(0)]
		public FString skelName;
	}

	// Token: 0x020089ED RID: 35309
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __AddComponentByCase_FunctionParams
	{
		// Token: 0x0402BE1E RID: 179742
		[FieldOffset(0)]
		public byte caseType;

		// Token: 0x0402BE1F RID: 179743
		[FieldOffset(8)]
		public IntPtr skeletalComp;
	}

	// Token: 0x020089EE RID: 35310
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __RemoveComponentByCase_FunctionParams
	{
		// Token: 0x0402BE20 RID: 179744
		[FieldOffset(0)]
		public byte caseType;
	}

	// Token: 0x020089EF RID: 35311
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __AddComponentInnerV2_FunctionParams
	{
		// Token: 0x0402BE21 RID: 179745
		[FieldOffset(0)]
		public FString skelName;

		// Token: 0x0402BE22 RID: 179746
		[FieldOffset(16)]
		public IntPtr skeletalComp;

		// Token: 0x0402BE23 RID: 179747
		[FieldOffset(24)]
		public bool useEmptyMaterial;
	}

	// Token: 0x020089F0 RID: 35312
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __RemoveComponentInnerV2_FunctionParams
	{
		// Token: 0x0402BE24 RID: 179748
		[FieldOffset(0)]
		public FString skelName;
	}

	// Token: 0x020089F1 RID: 35313
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetSkeletalMeshComponent_FunctionParams
	{
		// Token: 0x0402BE25 RID: 179749
		[FieldOffset(0)]
		public FString skelName;

		// Token: 0x0402BE26 RID: 179750
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x020089F2 RID: 35314
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetSkeletalMeshComponentBodyName_FunctionParams
	{
		// Token: 0x0402BE27 RID: 179751
		[FieldOffset(0)]
		public IntPtr skeletalComp;

		// Token: 0x0402BE28 RID: 179752
		[FieldOffset(8)]
		public FName __Result;
	}

	// Token: 0x020089F3 RID: 35315
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __CheckInit_FunctionParams
	{
		// Token: 0x0402BE29 RID: 179753
		[FieldOffset(0)]
		public bool __Result;
	}

	// Token: 0x020089F4 RID: 35316
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __SetDebug_FunctionParams
	{
		// Token: 0x0402BE2A RID: 179754
		[FieldOffset(0)]
		public bool value;
	}

	// Token: 0x020089F5 RID: 35317
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __GetDebugInfo_FunctionParams
	{
		// Token: 0x0402BE2B RID: 179755
		[FieldOffset(0)]
		public IntPtr __Result;
	}

	// Token: 0x020089F6 RID: 35318
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __GetInWater_FunctionParams
	{
		// Token: 0x0402BE2C RID: 179756
		[FieldOffset(0)]
		public float depthThreshold;

		// Token: 0x0402BE2D RID: 179757
		[FieldOffset(4)]
		public bool __Result;
	}

	// Token: 0x020089F7 RID: 35319
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __GetInAudioShr_FunctionParams
	{
		// Token: 0x0402BE2E RID: 179758
		[FieldOffset(0)]
		public bool __Result;
	}

	// Token: 0x020089F8 RID: 35320
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __AddMaterialControllerDataGroup_FunctionParams
	{
		// Token: 0x0402BE2F RID: 179759
		[FieldOffset(0)]
		public IntPtr data;

		// Token: 0x0402BE30 RID: 179760
		[FieldOffset(8)]
		public int __Result;
	}

	// Token: 0x020089F9 RID: 35321
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __AddMaterialControllerDataGroupWithAnimObject_FunctionParams
	{
		// Token: 0x0402BE31 RID: 179761
		[FieldOffset(0)]
		public IntPtr data;

		// Token: 0x0402BE32 RID: 179762
		[FieldOffset(8)]
		public IntPtr animObject;

		// Token: 0x0402BE33 RID: 179763
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x020089FA RID: 35322
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __RemoveMaterialControllerDataGroup_FunctionParams
	{
		// Token: 0x0402BE34 RID: 179764
		[FieldOffset(0)]
		public int handle;
	}

	// Token: 0x020089FB RID: 35323
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __RemoveMaterialControllerDataGroupWithEnding_FunctionParams
	{
		// Token: 0x0402BE35 RID: 179765
		[FieldOffset(0)]
		public int handle;
	}

	// Token: 0x020089FC RID: 35324
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __AddMaterialControllerDataWithAnimObject_FunctionParams
	{
		// Token: 0x0402BE36 RID: 179766
		[FieldOffset(0)]
		public IntPtr data;

		// Token: 0x0402BE37 RID: 179767
		[FieldOffset(8)]
		public IntPtr animObject;

		// Token: 0x0402BE38 RID: 179768
		[FieldOffset(16)]
		public IntPtr userData;

		// Token: 0x0402BE39 RID: 179769
		[FieldOffset(24)]
		public float __Result;
	}

	// Token: 0x020089FD RID: 35325
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __AddMaterialControllerData_FunctionParams
	{
		// Token: 0x0402BE3A RID: 179770
		[FieldOffset(0)]
		public IntPtr data;

		// Token: 0x0402BE3B RID: 179771
		[FieldOffset(8)]
		public int __Result;
	}

	// Token: 0x020089FE RID: 35326
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __RemoveMaterialControllerData_FunctionParams
	{
		// Token: 0x0402BE3C RID: 179772
		[FieldOffset(0)]
		public int handle;
	}

	// Token: 0x020089FF RID: 35327
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SetEffectPause_FunctionParams
	{
		// Token: 0x0402BE3D RID: 179773
		[FieldOffset(0)]
		public int handle;

		// Token: 0x0402BE3E RID: 179774
		[FieldOffset(4)]
		public bool paused;
	}

	// Token: 0x02008A00 RID: 35328
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __RemoveMaterialControllerDataWithEnding_FunctionParams
	{
		// Token: 0x0402BE3F RID: 179775
		[FieldOffset(0)]
		public int handle;
	}

	// Token: 0x02008A01 RID: 35329
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SetDitherEffect_FunctionParams
	{
		// Token: 0x0402BE40 RID: 179776
		[FieldOffset(0)]
		public float ditherRate;

		// Token: 0x0402BE41 RID: 179777
		[FieldOffset(4)]
		public byte ditherType;
	}

	// Token: 0x02008A02 RID: 35330
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __SetDisableFightDither_FunctionParams
	{
		// Token: 0x0402BE42 RID: 179778
		[FieldOffset(0)]
		public bool disable;
	}

	// Token: 0x02008A03 RID: 35331
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __SetDitherUseHeadMaskHideEffect_FunctionParams
	{
		// Token: 0x0402BE43 RID: 179779
		[FieldOffset(0)]
		public bool enable;
	}

	// Token: 0x02008A04 RID: 35332
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __GetOpacityConsiderVisibility_FunctionParams
	{
		// Token: 0x0402BE44 RID: 179780
		[FieldOffset(0)]
		public float __Result;
	}

	// Token: 0x02008A05 RID: 35333
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SetMaterialPropertyFloat_FunctionParams
	{
		// Token: 0x0402BE45 RID: 179781
		[FieldOffset(0)]
		public byte bodyType;

		// Token: 0x0402BE46 RID: 179782
		[FieldOffset(4)]
		public float sectionIndex;

		// Token: 0x0402BE47 RID: 179783
		[FieldOffset(8)]
		public byte slotType;

		// Token: 0x0402BE48 RID: 179784
		[FieldOffset(16)]
		public FString propertyName;

		// Token: 0x0402BE49 RID: 179785
		[FieldOffset(32)]
		public float value;
	}

	// Token: 0x02008A06 RID: 35334
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __SetMaterialPropertyColor_FunctionParams
	{
		// Token: 0x0402BE4A RID: 179786
		[FieldOffset(0)]
		public byte bodyType;

		// Token: 0x0402BE4B RID: 179787
		[FieldOffset(4)]
		public float sectionIndex;

		// Token: 0x0402BE4C RID: 179788
		[FieldOffset(8)]
		public byte slotType;

		// Token: 0x0402BE4D RID: 179789
		[FieldOffset(16)]
		public FString propertyName;

		// Token: 0x0402BE4E RID: 179790
		[FieldOffset(32)]
		public FLinearColor value;
	}

	// Token: 0x02008A07 RID: 35335
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 20)]
	protected ref struct __SetMaterialPropertyFloatV2_FunctionParams
	{
		// Token: 0x0402BE4F RID: 179791
		[FieldOffset(0)]
		public FName name;

		// Token: 0x0402BE50 RID: 179792
		[FieldOffset(12)]
		public float value;

		// Token: 0x0402BE51 RID: 179793
		[FieldOffset(16)]
		public byte bodyType;

		// Token: 0x0402BE52 RID: 179794
		[FieldOffset(17)]
		public byte slotType;

		// Token: 0x0402BE53 RID: 179795
		[FieldOffset(18)]
		public byte meshPart;
	}

	// Token: 0x02008A08 RID: 35336
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __AddFloatUpdateParamPermanentByIndexV2_FunctionParams
	{
		// Token: 0x0402BE54 RID: 179796
		[FieldOffset(0)]
		public FName name;

		// Token: 0x0402BE55 RID: 179797
		[FieldOffset(12)]
		public float value;

		// Token: 0x0402BE56 RID: 179798
		[FieldOffset(16)]
		public FName bodyName;

		// Token: 0x0402BE57 RID: 179799
		[FieldOffset(28)]
		public float materialIndex;
	}

	// Token: 0x02008A09 RID: 35337
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __SetMaterialPropertyColorV2_FunctionParams
	{
		// Token: 0x0402BE58 RID: 179800
		[FieldOffset(0)]
		public FName name;

		// Token: 0x0402BE59 RID: 179801
		[FieldOffset(12)]
		public FLinearColor value;

		// Token: 0x0402BE5A RID: 179802
		[FieldOffset(28)]
		public byte bodyType;

		// Token: 0x0402BE5B RID: 179803
		[FieldOffset(29)]
		public byte slotType;

		// Token: 0x0402BE5C RID: 179804
		[FieldOffset(30)]
		public byte meshPart;
	}

	// Token: 0x02008A0A RID: 35338
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetMaterialReplaceV2_FunctionParams
	{
		// Token: 0x0402BE5D RID: 179805
		[FieldOffset(0)]
		public IntPtr material;

		// Token: 0x0402BE5E RID: 179806
		[FieldOffset(8)]
		public byte bodyType;

		// Token: 0x0402BE5F RID: 179807
		[FieldOffset(9)]
		public byte slotType;

		// Token: 0x0402BE60 RID: 179808
		[FieldOffset(10)]
		public byte meshPart;
	}

	// Token: 0x02008A0B RID: 35339
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 3)]
	protected ref struct __RemoveExternalMaterialReplaceV2_FunctionParams
	{
		// Token: 0x0402BE61 RID: 179809
		[FieldOffset(0)]
		public byte bodyType;

		// Token: 0x0402BE62 RID: 179810
		[FieldOffset(1)]
		public byte slotType;

		// Token: 0x0402BE63 RID: 179811
		[FieldOffset(2)]
		public byte meshPart;
	}

	// Token: 0x02008A0C RID: 35340
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __SetStarScarEnergy_FunctionParams
	{
		// Token: 0x0402BE64 RID: 179812
		[FieldOffset(0)]
		public float value;
	}

	// Token: 0x02008A0D RID: 35341
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __SetCapsuleDither_FunctionParams
	{
		// Token: 0x0402BE65 RID: 179813
		[FieldOffset(0)]
		public float value;
	}

	// Token: 0x02008A0E RID: 35342
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __SetDecalShadowEnabled_FunctionParams
	{
		// Token: 0x0402BE66 RID: 179814
		[FieldOffset(0)]
		public bool enable;
	}

	// Token: 0x02008A0F RID: 35343
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __SetShouldCastShadow_FunctionParams
	{
		// Token: 0x0402BE67 RID: 179815
		[FieldOffset(0)]
		public bool castShadow;
	}

	// Token: 0x02008A10 RID: 35344
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SetEffectProgress_FunctionParams
	{
		// Token: 0x0402BE68 RID: 179816
		[FieldOffset(0)]
		public float progress;

		// Token: 0x0402BE69 RID: 179817
		[FieldOffset(4)]
		public int handleId;
	}

	// Token: 0x02008A11 RID: 35345
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SetEffectGroupProgress_FunctionParams
	{
		// Token: 0x0402BE6A RID: 179818
		[FieldOffset(0)]
		public float progress;

		// Token: 0x0402BE6B RID: 179819
		[FieldOffset(4)]
		public int groupHandleId;
	}

	// Token: 0x02008A12 RID: 35346
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __ShouldTickAfterGoDown_FunctionParams
	{
		// Token: 0x0402BE6C RID: 179820
		[FieldOffset(0)]
		public bool __Result;
	}

	// Token: 0x02008A13 RID: 35347
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __ReceiveSeqTick_FunctionParams
	{
		// Token: 0x0402BE6D RID: 179821
		[FieldOffset(0)]
		public float deltaSeconds;
	}
}
