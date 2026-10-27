using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002C56 RID: 11350
[UClass("/Game/Aki/TypeScript/Game/Module/UiComponent/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/UiComponent/TsUiAutoPlayLevelSequenceComponent.TsUiAutoPlayLevelSequenceComponent_C")]
public class TsUiAutoPlayLevelSequenceComponent : ULGUIBehaviour, IUnrealUObject, IUnrealObject
{
	// Token: 0x06017AFE RID: 97022 RVA: 0x00605F00 File Offset: 0x00604100
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

	// Token: 0x06017AFF RID: 97023 RVA: 0x00605F70 File Offset: 0x00604170
	protected virtual void AwakeBP_Implementation()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(base.RootUIComp);
		this.PlayState = new EPlayState?(EPlayState.None);
	}

	// Token: 0x06017B00 RID: 97024 RVA: 0x00605F94 File Offset: 0x00604194
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void OnUIActiveInHierarchyBP(bool activeOrInactive)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnUIActiveInHierarchyBP"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		ULGUIBehaviour.__OnUIActiveInHierarchyBP_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((ULGUIBehaviour.__OnUIActiveInHierarchyBP_FunctionParams*)ptr + 15L / (long)sizeof(ULGUIBehaviour.__OnUIActiveInHierarchyBP_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->activeOrInactive = activeOrInactive;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06017B01 RID: 97025 RVA: 0x0060600A File Offset: 0x0060420A
	protected virtual void OnUIActiveInHierarchyBP_Implementation(bool activeOrInactive)
	{
		this.PlayState = new EPlayState?(activeOrInactive ? EPlayState.Play : EPlayState.Stop);
		if (this.PlayState.GetValueOrDefault() == EPlayState.Stop)
		{
			this.TryRefresh();
		}
	}

	// Token: 0x06017B02 RID: 97026 RVA: 0x00606034 File Offset: 0x00604234
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

	// Token: 0x06017B03 RID: 97027 RVA: 0x006060A4 File Offset: 0x006042A4
	protected virtual void OnPreDestroyBP_Implementation()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.LevelSequencePlayer = null;
	}

	// Token: 0x06017B04 RID: 97028 RVA: 0x006060C0 File Offset: 0x006042C0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void UpdateBP(float DeltaTime)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("UpdateBP"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		ULGUIBehaviour.__UpdateBP_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((ULGUIBehaviour.__UpdateBP_FunctionParams*)ptr + 15L / (long)sizeof(ULGUIBehaviour.__UpdateBP_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->DeltaTime = DeltaTime;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06017B05 RID: 97029 RVA: 0x00606136 File Offset: 0x00604336
	protected virtual void UpdateBP_Implementation(float DeltaTime)
	{
		this.TryRefresh();
	}

	// Token: 0x06017B06 RID: 97030 RVA: 0x00606140 File Offset: 0x00604340
	private void TryRefresh()
	{
		EPlayState? playState = this.PlayState;
		EPlayState eplayState = EPlayState.None;
		if (playState.GetValueOrDefault() == eplayState & playState != null)
		{
			return;
		}
		if (this.PlayState.GetValueOrDefault() == EPlayState.Play)
		{
			this.TryPlay();
			this.PlayState = new EPlayState?(EPlayState.None);
			return;
		}
		if (this.PlayState.GetValueOrDefault() == EPlayState.Stop)
		{
			this.TryStop();
			this.PlayState = new EPlayState?(EPlayState.None);
		}
	}

	// Token: 0x06017B07 RID: 97031 RVA: 0x006061AC File Offset: 0x006043AC
	private void TryPlay()
	{
		AUIBaseActor auibaseActor = base.GetOwner() as AUIBaseActor;
		if (auibaseActor == null)
		{
			return;
		}
		TMap<string, FSequenceInfo> levelSequences = auibaseActor.GetUIItem().LevelSequences;
		if (this.AutoPlayList == null)
		{
			this.AutoPlayList = new List<string>();
		}
		this.AutoPlayList.Clear();
		foreach (KeyValuePair<string, FSequenceInfo> keyValuePair in levelSequences)
		{
			string text;
			FSequenceInfo fsequenceInfo;
			keyValuePair.Deconstruct(out text, out fsequenceInfo);
			string text2 = text;
			if (fsequenceInfo.PlaySetting.bAutoPlay)
			{
				this.LevelSequencePlayer.PlaySequencePurely(text2, false, false, null, null, false);
				this.AutoPlayList.Add(text2);
			}
		}
	}

	// Token: 0x06017B08 RID: 97032 RVA: 0x00606268 File Offset: 0x00604468
	private void TryStop()
	{
		if (this.AutoPlayList == null)
		{
			return;
		}
		AUIBaseActor auibaseActor = base.GetOwner() as AUIBaseActor;
		if (auibaseActor == null)
		{
			return;
		}
		foreach (string name in this.AutoPlayList)
		{
			auibaseActor.StopSequenceByKey(name);
		}
		this.AutoPlayList = null;
	}

	// Token: 0x06017B09 RID: 97033 RVA: 0x006062DC File Offset: 0x006044DC
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsUiAutoPlayLevelSequenceComponent._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/UiComponent/TsUiAutoPlayLevelSequenceComponent.TsUiAutoPlayLevelSequenceComponent_C");
		}
		return TsUiAutoPlayLevelSequenceComponent._ClassPtr;
	}

	// Token: 0x06017B0A RID: 97034 RVA: 0x00606300 File Offset: 0x00604500
	public TsUiAutoPlayLevelSequenceComponent() : this(BuiltinUtils.AllocNativeUObject(TsUiAutoPlayLevelSequenceComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06017B0B RID: 97035 RVA: 0x00606328 File Offset: 0x00604528
	[NullableContext(1)]
	public TsUiAutoPlayLevelSequenceComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiAutoPlayLevelSequenceComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06017B0C RID: 97036 RVA: 0x0060635B File Offset: 0x0060455B
	protected TsUiAutoPlayLevelSequenceComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06017B0D RID: 97037 RVA: 0x00606364 File Offset: 0x00604564
	protected virtual void __CPPCALL_AwakeBP_Implementation()
	{
		this.AwakeBP_Implementation();
	}

	// Token: 0x06017B0E RID: 97038 RVA: 0x0060636C File Offset: 0x0060456C
	protected unsafe virtual void __CPPCALL_OnUIActiveInHierarchyBP_Implementation(ULGUIBehaviour.__OnUIActiveInHierarchyBP_FunctionParams* __Params)
	{
		this.OnUIActiveInHierarchyBP_Implementation(__Params->activeOrInactive);
	}

	// Token: 0x06017B0F RID: 97039 RVA: 0x0060637A File Offset: 0x0060457A
	protected virtual void __CPPCALL_OnPreDestroyBP_Implementation()
	{
		this.OnPreDestroyBP_Implementation();
	}

	// Token: 0x06017B10 RID: 97040 RVA: 0x00606382 File Offset: 0x00604582
	protected unsafe virtual void __CPPCALL_UpdateBP_Implementation(ULGUIBehaviour.__UpdateBP_FunctionParams* __Params)
	{
		this.UpdateBP_Implementation(__Params->DeltaTime);
	}

	// Token: 0x0400B07B RID: 45179
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400B07C RID: 45180
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<string> AutoPlayList;

	// Token: 0x0400B07D RID: 45181
	private EPlayState? PlayState;

	// Token: 0x0400B07E RID: 45182
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/UiComponent/TsUiAutoPlayLevelSequenceComponent.TsUiAutoPlayLevelSequenceComponent_C";

	// Token: 0x0400B07F RID: 45183
	private static IntPtr _ClassPtr;

	// Token: 0x0400B080 RID: 45184
	private static IntPtr _ClassDefaultObjectPtr;
}
