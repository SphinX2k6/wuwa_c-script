using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020021AF RID: 8623
[UClass("/Game/Aki/TypeScript/Game/Module/UiComponent/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/UiComponent/TsUiAutoPlayLevelSequenceComponent.TsUiAutoPlayLevelSequenceComponent_C")]
public class TsUiAutoPlayLevelSequenceComponent : ULGUIBehaviour, IUnrealUObject, IUnrealObject
{
	// Token: 0x06015374 RID: 86900 RVA: 0x0062B9A0 File Offset: 0x00629BA0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void AwakeBP()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsUiAutoPlayLevelSequenceComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AwakeBP"), TsUiAutoPlayLevelSequenceComponent.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.AwakeBP_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06015375 RID: 86901 RVA: 0x0062B9F9 File Offset: 0x00629BF9
	protected virtual void AwakeBP_Implementation()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(base.RootUIComp);
		this.PlayState = new EPlayState?(EPlayState.None);
	}

	// Token: 0x06015376 RID: 86902 RVA: 0x0062BA20 File Offset: 0x00629C20
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void OnUIActiveInHierarchyBP(bool activeOrInactive)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsUiAutoPlayLevelSequenceComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnUIActiveInHierarchyBP"), TsUiAutoPlayLevelSequenceComponent.StaticClass(), out intPtr, out num))
		{
			this.OnUIActiveInHierarchyBP_Implementation(activeOrInactive);
			return;
		}
		ULGUIBehaviour.__OnUIActiveInHierarchyBP_FunctionParams* ptr = stackalloc ULGUIBehaviour.__OnUIActiveInHierarchyBP_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(ULGUIBehaviour.__OnUIActiveInHierarchyBP_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->activeOrInactive = activeOrInactive;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06015377 RID: 86903 RVA: 0x0062BAAC File Offset: 0x00629CAC
	protected virtual void OnUIActiveInHierarchyBP_Implementation(bool activeOrInactive)
	{
		this.PlayState = new EPlayState?(activeOrInactive ? EPlayState.Play : EPlayState.Stop);
		if (this.PlayState.GetValueOrDefault() == EPlayState.Stop)
		{
			this.TryRefresh();
		}
	}

	// Token: 0x06015378 RID: 86904 RVA: 0x0062BAD4 File Offset: 0x00629CD4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void OnPreDestroyBP()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsUiAutoPlayLevelSequenceComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnPreDestroyBP"), TsUiAutoPlayLevelSequenceComponent.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.OnPreDestroyBP_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06015379 RID: 86905 RVA: 0x0062BB2D File Offset: 0x00629D2D
	protected virtual void OnPreDestroyBP_Implementation()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.LevelSequencePlayer = null;
	}

	// Token: 0x0601537A RID: 86906 RVA: 0x0062BB48 File Offset: 0x00629D48
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void UpdateBP(float DeltaTime)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsUiAutoPlayLevelSequenceComponent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("UpdateBP"), TsUiAutoPlayLevelSequenceComponent.StaticClass(), out intPtr, out num))
		{
			this.UpdateBP_Implementation(DeltaTime);
			return;
		}
		ULGUIBehaviour.__UpdateBP_FunctionParams* ptr = stackalloc ULGUIBehaviour.__UpdateBP_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(ULGUIBehaviour.__UpdateBP_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->DeltaTime = DeltaTime;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601537B RID: 86907 RVA: 0x0062BBD4 File Offset: 0x00629DD4
	protected virtual void UpdateBP_Implementation(float DeltaTime)
	{
		this.TryRefresh();
	}

	// Token: 0x0601537C RID: 86908 RVA: 0x0062BBDC File Offset: 0x00629DDC
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

	// Token: 0x0601537D RID: 86909 RVA: 0x0062BC48 File Offset: 0x00629E48
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

	// Token: 0x0601537E RID: 86910 RVA: 0x0062BD0C File Offset: 0x00629F0C
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

	// Token: 0x0601537F RID: 86911 RVA: 0x0062BD80 File Offset: 0x00629F80
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsUiAutoPlayLevelSequenceComponent._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/UiComponent/TsUiAutoPlayLevelSequenceComponent.TsUiAutoPlayLevelSequenceComponent_C");
		}
		return TsUiAutoPlayLevelSequenceComponent._ClassPtr;
	}

	// Token: 0x06015380 RID: 86912 RVA: 0x0062BDA4 File Offset: 0x00629FA4
	public TsUiAutoPlayLevelSequenceComponent() : this(BuiltinUtils.AllocNativeUObject(TsUiAutoPlayLevelSequenceComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06015381 RID: 86913 RVA: 0x0062BDCC File Offset: 0x00629FCC
	[NullableContext(1)]
	public TsUiAutoPlayLevelSequenceComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiAutoPlayLevelSequenceComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06015382 RID: 86914 RVA: 0x0062BDFF File Offset: 0x00629FFF
	protected TsUiAutoPlayLevelSequenceComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06015383 RID: 86915 RVA: 0x0062BE08 File Offset: 0x0062A008
	protected virtual void __CPPCALL_AwakeBP_Implementation()
	{
		this.AwakeBP_Implementation();
	}

	// Token: 0x06015384 RID: 86916 RVA: 0x0062BE10 File Offset: 0x0062A010
	protected unsafe virtual void __CPPCALL_OnUIActiveInHierarchyBP_Implementation(ULGUIBehaviour.__OnUIActiveInHierarchyBP_FunctionParams* __Params)
	{
		this.OnUIActiveInHierarchyBP_Implementation(__Params->activeOrInactive);
	}

	// Token: 0x06015385 RID: 86917 RVA: 0x0062BE1E File Offset: 0x0062A01E
	protected virtual void __CPPCALL_OnPreDestroyBP_Implementation()
	{
		this.OnPreDestroyBP_Implementation();
	}

	// Token: 0x06015386 RID: 86918 RVA: 0x0062BE26 File Offset: 0x0062A026
	protected unsafe virtual void __CPPCALL_UpdateBP_Implementation(ULGUIBehaviour.__UpdateBP_FunctionParams* __Params)
	{
		this.UpdateBP_Implementation(__Params->DeltaTime);
	}

	// Token: 0x0400B3E9 RID: 46057
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400B3EA RID: 46058
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<string> AutoPlayList;

	// Token: 0x0400B3EB RID: 46059
	private EPlayState? PlayState;

	// Token: 0x0400B3EC RID: 46060
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/UiComponent/TsUiAutoPlayLevelSequenceComponent.TsUiAutoPlayLevelSequenceComponent_C";

	// Token: 0x0400B3ED RID: 46061
	private static IntPtr _ClassPtr;

	// Token: 0x0400B3EE RID: 46062
	private static IntPtr _ClassDefaultObjectPtr;
}
