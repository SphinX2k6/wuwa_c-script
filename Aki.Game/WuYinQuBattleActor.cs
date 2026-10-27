using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Battle;
using CSharpScript.Game.Manager;
using CSharpScript.Game.Render;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02003457 RID: 13399
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Render/Battle/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Battle/WuYinQuBattleActor.WuYinQuBattleActor_C")]
public class WuYinQuBattleActor : AKuroWuYinQuActorBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170027A9 RID: 10153
	// (get) Token: 0x0601CED6 RID: 118486 RVA: 0x0080F6BA File Offset: 0x0080D8BA
	// (set) Token: 0x0601CED7 RID: 118487 RVA: 0x0080F6CE File Offset: 0x0080D8CE
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string 当前状态
	{
		[NullableContext(1)]
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)WuYinQuBattleActor.__PropertyOffset_当前状态)));
		}
		[NullableContext(1)]
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)WuYinQuBattleActor.__PropertyOffset_当前状态)), value);
		}
	}

	// Token: 0x170027AA RID: 10154
	// (get) Token: 0x0601CED8 RID: 118488 RVA: 0x0080F6E3 File Offset: 0x0080D8E3
	// (set) Token: 0x0601CED9 RID: 118489 RVA: 0x0080F6F7 File Offset: 0x0080D8F7
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string 是否已经初始化
	{
		[NullableContext(1)]
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)WuYinQuBattleActor.__PropertyOffset_是否已经初始化)));
		}
		[NullableContext(1)]
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)WuYinQuBattleActor.__PropertyOffset_是否已经初始化)), value);
		}
	}

	// Token: 0x170027AB RID: 10155
	// (get) Token: 0x0601CEDA RID: 118490 RVA: 0x0080F70C File Offset: 0x0080D90C
	// (set) Token: 0x0601CEDB RID: 118491 RVA: 0x0080F720 File Offset: 0x0080D920
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe AKuroLevelSequenceActor ReferenceKuroLevelSequence
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<AKuroLevelSequenceActor>(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_ReferenceKuroLevelSequence);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_ReferenceKuroLevelSequence, value);
		}
	}

	// Token: 0x170027AC RID: 10156
	// (get) Token: 0x0601CEDC RID: 118492 RVA: 0x0080F735 File Offset: 0x0080D935
	// (set) Token: 0x0601CEDD RID: 118493 RVA: 0x0080F749 File Offset: 0x0080D949
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe USceneComponent Root
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_Root);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_Root, value);
		}
	}

	// Token: 0x170027AD RID: 10157
	// (get) Token: 0x0601CEDE RID: 118494 RVA: 0x0080F75E File Offset: 0x0080D95E
	// (set) Token: 0x0601CEDF RID: 118495 RVA: 0x0080F772 File Offset: 0x0080D972
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UBoxComponent IdleInnerBox1
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_IdleInnerBox1);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_IdleInnerBox1, value);
		}
	}

	// Token: 0x170027AE RID: 10158
	// (get) Token: 0x0601CEE0 RID: 118496 RVA: 0x0080F787 File Offset: 0x0080D987
	// (set) Token: 0x0601CEE1 RID: 118497 RVA: 0x0080F79B File Offset: 0x0080D99B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UBoxComponent IdleInnerBox2
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_IdleInnerBox2);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_IdleInnerBox2, value);
		}
	}

	// Token: 0x170027AF RID: 10159
	// (get) Token: 0x0601CEE2 RID: 118498 RVA: 0x0080F7B0 File Offset: 0x0080D9B0
	// (set) Token: 0x0601CEE3 RID: 118499 RVA: 0x0080F7C4 File Offset: 0x0080D9C4
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UKuroPostProcessComponent IdleInnerPostProcess
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_IdleInnerPostProcess);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_IdleInnerPostProcess, value);
		}
	}

	// Token: 0x170027B0 RID: 10160
	// (get) Token: 0x0601CEE4 RID: 118500 RVA: 0x0080F7D9 File Offset: 0x0080D9D9
	// (set) Token: 0x0601CEE5 RID: 118501 RVA: 0x0080F7ED File Offset: 0x0080D9ED
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UBoxComponent IdleOuterBox1
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_IdleOuterBox1);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_IdleOuterBox1, value);
		}
	}

	// Token: 0x170027B1 RID: 10161
	// (get) Token: 0x0601CEE6 RID: 118502 RVA: 0x0080F802 File Offset: 0x0080DA02
	// (set) Token: 0x0601CEE7 RID: 118503 RVA: 0x0080F816 File Offset: 0x0080DA16
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UBoxComponent IdleOuterBox2
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_IdleOuterBox2);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_IdleOuterBox2, value);
		}
	}

	// Token: 0x170027B2 RID: 10162
	// (get) Token: 0x0601CEE8 RID: 118504 RVA: 0x0080F82B File Offset: 0x0080DA2B
	// (set) Token: 0x0601CEE9 RID: 118505 RVA: 0x0080F83F File Offset: 0x0080DA3F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UKuroPostProcessComponent IdleOuterPostProcess
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_IdleOuterPostProcess);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_IdleOuterPostProcess, value);
		}
	}

	// Token: 0x170027B3 RID: 10163
	// (get) Token: 0x0601CEEA RID: 118506 RVA: 0x0080F854 File Offset: 0x0080DA54
	// (set) Token: 0x0601CEEB RID: 118507 RVA: 0x0080F868 File Offset: 0x0080DA68
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UBoxComponent FightingPhase1Box1
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_FightingPhase1Box1);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_FightingPhase1Box1, value);
		}
	}

	// Token: 0x170027B4 RID: 10164
	// (get) Token: 0x0601CEEC RID: 118508 RVA: 0x0080F87D File Offset: 0x0080DA7D
	// (set) Token: 0x0601CEED RID: 118509 RVA: 0x0080F891 File Offset: 0x0080DA91
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UBoxComponent FightingPhase1Box2
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_FightingPhase1Box2);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_FightingPhase1Box2, value);
		}
	}

	// Token: 0x170027B5 RID: 10165
	// (get) Token: 0x0601CEEE RID: 118510 RVA: 0x0080F8A6 File Offset: 0x0080DAA6
	// (set) Token: 0x0601CEEF RID: 118511 RVA: 0x0080F8BA File Offset: 0x0080DABA
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UKuroPostProcessComponent FightingPhase1PostProcess
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_FightingPhase1PostProcess);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_FightingPhase1PostProcess, value);
		}
	}

	// Token: 0x170027B6 RID: 10166
	// (get) Token: 0x0601CEF0 RID: 118512 RVA: 0x0080F8CF File Offset: 0x0080DACF
	// (set) Token: 0x0601CEF1 RID: 118513 RVA: 0x0080F8E3 File Offset: 0x0080DAE3
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UBoxComponent FightingPhase2Box1
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_FightingPhase2Box1);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_FightingPhase2Box1, value);
		}
	}

	// Token: 0x170027B7 RID: 10167
	// (get) Token: 0x0601CEF2 RID: 118514 RVA: 0x0080F8F8 File Offset: 0x0080DAF8
	// (set) Token: 0x0601CEF3 RID: 118515 RVA: 0x0080F90C File Offset: 0x0080DB0C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UBoxComponent FightingPhase2Box2
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_FightingPhase2Box2);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_FightingPhase2Box2, value);
		}
	}

	// Token: 0x170027B8 RID: 10168
	// (get) Token: 0x0601CEF4 RID: 118516 RVA: 0x0080F921 File Offset: 0x0080DB21
	// (set) Token: 0x0601CEF5 RID: 118517 RVA: 0x0080F935 File Offset: 0x0080DB35
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UKuroPostProcessComponent FightingPhase2PostProcess
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_FightingPhase2PostProcess);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_FightingPhase2PostProcess, value);
		}
	}

	// Token: 0x170027B9 RID: 10169
	// (get) Token: 0x0601CEF6 RID: 118518 RVA: 0x0080F94A File Offset: 0x0080DB4A
	// (set) Token: 0x0601CEF7 RID: 118519 RVA: 0x0080F95E File Offset: 0x0080DB5E
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UBoxComponent FightingPhase3Box1
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_FightingPhase3Box1);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_FightingPhase3Box1, value);
		}
	}

	// Token: 0x170027BA RID: 10170
	// (get) Token: 0x0601CEF8 RID: 118520 RVA: 0x0080F973 File Offset: 0x0080DB73
	// (set) Token: 0x0601CEF9 RID: 118521 RVA: 0x0080F987 File Offset: 0x0080DB87
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UBoxComponent FightingPhase3Box2
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_FightingPhase3Box2);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_FightingPhase3Box2, value);
		}
	}

	// Token: 0x170027BB RID: 10171
	// (get) Token: 0x0601CEFA RID: 118522 RVA: 0x0080F99C File Offset: 0x0080DB9C
	// (set) Token: 0x0601CEFB RID: 118523 RVA: 0x0080F9B0 File Offset: 0x0080DBB0
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UKuroPostProcessComponent FightingPhase3PostProcess
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_FightingPhase3PostProcess);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_FightingPhase3PostProcess, value);
		}
	}

	// Token: 0x170027BC RID: 10172
	// (get) Token: 0x0601CEFC RID: 118524 RVA: 0x0080F9C5 File Offset: 0x0080DBC5
	// (set) Token: 0x0601CEFD RID: 118525 RVA: 0x0080F9D9 File Offset: 0x0080DBD9
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe PDA_WuYinQuBattleData_C WuYinQuFightingData
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<PDA_WuYinQuBattleData_C>(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_WuYinQuFightingData);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_WuYinQuFightingData, value);
		}
	}

	// Token: 0x0601CEFE RID: 118526 RVA: 0x0080F9F0 File Offset: 0x0080DBF0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void 手动初始化()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("手动初始化"), out num);
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

	// Token: 0x0601CEFF RID: 118527 RVA: 0x0080FA60 File Offset: 0x0080DC60
	protected void 手动初始化_Implementation()
	{
		RenderModuleController.Instance.AddWuYinQuBattleActor(this);
	}

	// Token: 0x0601CF00 RID: 118528 RVA: 0x0080FA70 File Offset: 0x0080DC70
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void 显示Debug线框()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("显示Debug线框"), out num);
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

	// Token: 0x0601CF01 RID: 118529 RVA: 0x0080FAE0 File Offset: 0x0080DCE0
	protected void 显示Debug线框_Implementation()
	{
		RoleTriggerController.Instance.DebugTestWorldDone();
		this.IdleOuterBox1.LineThickness = 20f;
		this.IdleOuterBox1.ShapeColor = new FColor(0, 223, 83, byte.MaxValue);
		this.IdleOuterBox1.SetHiddenInGame(false, false);
		this.IdleOuterBox2.LineThickness = 10f;
		this.IdleOuterBox2.ShapeColor = new FColor(0, 223, 83, byte.MaxValue);
		this.IdleOuterBox2.SetHiddenInGame(false, false);
		this.IdleInnerBox1.LineThickness = 20f;
		this.IdleInnerBox1.ShapeColor = new FColor(0, 223, 83, byte.MaxValue);
		this.IdleInnerBox1.SetHiddenInGame(false, false);
		this.IdleInnerBox2.LineThickness = 10f;
		this.IdleInnerBox2.ShapeColor = new FColor(0, 223, 83, byte.MaxValue);
		this.IdleInnerBox2.SetHiddenInGame(false, false);
	}

	// Token: 0x0601CF02 RID: 118530 RVA: 0x0080FBE0 File Offset: 0x0080DDE0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void 切换到清空状态()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("切换到清空状态"), out num);
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

	// Token: 0x0601CF03 RID: 118531 RVA: 0x0080FC50 File Offset: 0x0080DE50
	protected void 切换到清空状态_Implementation()
	{
		RenderModuleController.Instance.SetBattleState(this.GetKey(), EWuYinQuState.Nothing, false);
	}

	// Token: 0x0601CF04 RID: 118532 RVA: 0x0080FC64 File Offset: 0x0080DE64
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void 切换到静止状态()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("切换到静止状态"), out num);
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

	// Token: 0x0601CF05 RID: 118533 RVA: 0x0080FCD4 File Offset: 0x0080DED4
	protected void 切换到静止状态_Implementation()
	{
		RenderModuleController.Instance.SetBattleState(this.GetKey(), EWuYinQuState.StateIdle, false);
	}

	// Token: 0x0601CF06 RID: 118534 RVA: 0x0080FCE8 File Offset: 0x0080DEE8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void 切换到战斗阶段1()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("切换到战斗阶段1"), out num);
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

	// Token: 0x0601CF07 RID: 118535 RVA: 0x0080FD58 File Offset: 0x0080DF58
	protected void 切换到战斗阶段1_Implementation()
	{
		RenderModuleController.Instance.SetBattleState(this.GetKey(), EWuYinQuState.StateFighting1, false);
	}

	// Token: 0x0601CF08 RID: 118536 RVA: 0x0080FD6C File Offset: 0x0080DF6C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void 切换到战斗阶段2()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("切换到战斗阶段2"), out num);
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

	// Token: 0x0601CF09 RID: 118537 RVA: 0x0080FDDC File Offset: 0x0080DFDC
	protected void 切换到战斗阶段2_Implementation()
	{
		RenderModuleController.Instance.SetBattleState(this.GetKey(), EWuYinQuState.StateFighting2, false);
	}

	// Token: 0x0601CF0A RID: 118538 RVA: 0x0080FDF0 File Offset: 0x0080DFF0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void 切换到战斗阶段3()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("切换到战斗阶段3"), out num);
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

	// Token: 0x0601CF0B RID: 118539 RVA: 0x0080FE60 File Offset: 0x0080E060
	protected void 切换到战斗阶段3_Implementation()
	{
		RenderModuleController.Instance.SetBattleState(this.GetKey(), EWuYinQuState.StateFighting3, false);
	}

	// Token: 0x0601CF0C RID: 118540 RVA: 0x0080FE74 File Offset: 0x0080E074
	public unsafe void ChangeState(EWuYinQuState state, bool instantTransition = false)
	{
		if (!this.IsInit)
		{
			Log.Instance.Error(ELogModule.RenderBattle, ELogAuthor.HCS, "没有初始化WuYinQuBattle: key:" + base.Key.ToString(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (this.CurrentBattleState != state)
		{
			this.LastBattleState = this.CurrentBattleState;
			this.CurrentBattleState = state;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderBattle;
			ELogAuthor author = ELogAuthor.HCS;
			string message = "BOSS战切换状态 from:";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("fromState", this.LastBattleState);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("toState", this.CurrentBattleState);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (state == EWuYinQuState.StateIdle)
			{
				if (instantTransition)
				{
					this.StateMachine.Switch(EWuYinQuBattleState.Idle);
				}
				else
				{
					this.StateMachine.Switch(EWuYinQuBattleState.FightingToIdle);
				}
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.RenderBattle;
				ELogAuthor author2 = ELogAuthor.HCS;
				string message2 = "切换Fighting to Idle:";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Key", base.Key);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Instant", instantTransition);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				return;
			}
			if (state == EWuYinQuState.StateFighting1)
			{
				if (instantTransition)
				{
					this.StateMachine.Switch(EWuYinQuBattleState.Fighting1);
				}
				else
				{
					this.StateMachine.Switch(EWuYinQuBattleState.IdleToFighting);
				}
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.RenderBattle;
				ELogAuthor author3 = ELogAuthor.HCS;
				string message3 = "切换Idle To Fighting1:";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("Key", base.Key);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("Instant", instantTransition);
				instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
				return;
			}
			if (state == EWuYinQuState.StateFighting2)
			{
				if (instantTransition)
				{
					this.StateMachine.Switch(EWuYinQuBattleState.Fighting2);
				}
				else
				{
					this.StateMachine.Switch(EWuYinQuBattleState.FightingToFighting);
				}
				Log instance4 = Log.Instance;
				ELogModule module4 = ELogModule.RenderBattle;
				ELogAuthor author4 = ELogAuthor.HCS;
				string message4 = "切换Fighting1 to Fighting2:";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("Key", base.Key);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("Instant", instantTransition);
				instance4.Info(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 2));
				return;
			}
			if (state == EWuYinQuState.StateFighting3)
			{
				if (instantTransition)
				{
					this.StateMachine.Switch(EWuYinQuBattleState.Fighting3);
				}
				else
				{
					this.StateMachine.Switch(EWuYinQuBattleState.FightingToFighting);
				}
				Log instance5 = Log.Instance;
				ELogModule module5 = ELogModule.RenderBattle;
				ELogAuthor author5 = ELogAuthor.HCS;
				string message5 = "切换Fighting2 to Fighting3:";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray5 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 0) = new ValueTuple<string, object>("Key", base.Key);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 1) = new ValueTuple<string, object>("Instant", instantTransition);
				instance5.Info(module5, author5, message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray5, 2));
			}
		}
	}

	// Token: 0x0601CF0D RID: 118541 RVA: 0x0081016C File Offset: 0x0080E36C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveBeginPlay()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveBeginPlay"), out num);
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

	// Token: 0x0601CF0E RID: 118542 RVA: 0x008101DC File Offset: 0x0080E3DC
	protected virtual void ReceiveBeginPlay_Implementation()
	{
		if (ModelManager.Instance.IsInit)
		{
			RenderModuleController.Instance.AddWuYinQuBattleActor(this);
			return;
		}
		RenderModuleController.Instance.AddWuYinQuBattleActorWaiting(this);
	}

	// Token: 0x0601CF0F RID: 118543 RVA: 0x00810204 File Offset: 0x0080E404
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveEndPlay(EEndPlayReason endPlayReason)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveEndPlay"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		AActor.__ReceiveEndPlay_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((AActor.__ReceiveEndPlay_FunctionParams*)ptr + 15L / (long)sizeof(AActor.__ReceiveEndPlay_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(byte*)(&ptr2->EndPlayReason) = (byte)endPlayReason;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601CF10 RID: 118544 RVA: 0x00810280 File Offset: 0x0080E480
	protected virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.RenderBattle;
		ELogAuthor author = ELogAuthor.HCS;
		string message = "Receive End Play Battle Actor:";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Key", base.Key);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		RenderModuleController.Instance.RemoveWuYinQuBattleActor(this);
		this.IsInit = false;
		this.是否已经初始化 = "无";
		this.CurrentBattleState = EWuYinQuState.StateIdle;
		this.LastBattleState = EWuYinQuState.StateIdle;
		if (this.IdleInnerPostProcessTrigger != null)
		{
			this.IdleInnerPostProcessTrigger.Dispose();
		}
		if (this.IdleOuterPostProcessTrigger != null)
		{
			this.IdleOuterPostProcessTrigger.Dispose();
		}
		if (this.FightingPhase1PostProcessTrigger != null)
		{
			this.FightingPhase1PostProcessTrigger.Dispose();
		}
		if (this.FightingPhase2PostProcessTrigger != null)
		{
			this.FightingPhase2PostProcessTrigger.Dispose();
		}
		if (this.FightingPhase3PostProcessTrigger != null)
		{
			this.FightingPhase3PostProcessTrigger.Dispose();
		}
	}

	// Token: 0x0601CF11 RID: 118545 RVA: 0x00810349 File Offset: 0x0080E549
	public AKuroLevelSequenceActor GetKuroLevelSequenceActor()
	{
		AKuroLevelSequenceActor referenceKuroLevelSequence = this.ReferenceKuroLevelSequence;
		if (referenceKuroLevelSequence != null && referenceKuroLevelSequence.IsValid())
		{
			return this.ReferenceKuroLevelSequence;
		}
		return null;
	}

	// Token: 0x0601CF12 RID: 118546 RVA: 0x00810367 File Offset: 0x0080E567
	public EWuYinQuState GetCurrentBattleState()
	{
		return this.CurrentBattleState;
	}

	// Token: 0x0601CF13 RID: 118547 RVA: 0x0081036F File Offset: 0x0080E56F
	public EWuYinQuState GetLastBattleState()
	{
		return this.LastBattleState;
	}

	// Token: 0x0601CF14 RID: 118548 RVA: 0x00810377 File Offset: 0x0080E577
	public bool IsInitialize()
	{
		return this.IsInit;
	}

	// Token: 0x0601CF15 RID: 118549 RVA: 0x00810380 File Offset: 0x0080E580
	[NullableContext(1)]
	public string GetKey()
	{
		if (this.StringKey == null)
		{
			this.StringKey = base.Key.ToString();
		}
		return this.StringKey;
	}

	// Token: 0x0601CF16 RID: 118550 RVA: 0x008103B8 File Offset: 0x0080E5B8
	public void Tick(float delta)
	{
		if (!this.IsInit)
		{
			return;
		}
		this.StateMachine.Update(delta);
		if (this.IdleInnerPostProcessTrigger != null)
		{
			this.IdleInnerPostProcessTrigger.Tick(delta);
		}
		if (this.IdleOuterPostProcessTrigger != null)
		{
			this.IdleOuterPostProcessTrigger.Tick(delta);
		}
		if (this.FightingPhase1PostProcessTrigger != null)
		{
			this.FightingPhase1PostProcessTrigger.Tick(delta);
		}
		if (this.FightingPhase2PostProcessTrigger != null)
		{
			this.FightingPhase2PostProcessTrigger.Tick(delta);
		}
		if (this.FightingPhase3PostProcessTrigger != null)
		{
			this.FightingPhase3PostProcessTrigger.Tick(delta);
		}
	}

	// Token: 0x0601CF17 RID: 118551 RVA: 0x00810440 File Offset: 0x0080E640
	public bool Init()
	{
		if (this.IsInit)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderBattle;
			ELogAuthor author = ELogAuthor.HCS;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
			defaultInterpolatedStringHandler.AppendLiteral("已经初始化过了 handleId: Key:");
			defaultInterpolatedStringHandler.AppendFormatted<FName>(base.Key);
			instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		PDA_WuYinQuBattleData_C wuYinQuFightingData = this.WuYinQuFightingData;
		if (wuYinQuFightingData == null || !wuYinQuFightingData.IsValid())
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.RenderBattle;
			ELogAuthor author2 = ELogAuthor.HCS;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 1);
			defaultInterpolatedStringHandler.AppendLiteral("无音区战斗数据无效 handleId: Key:");
			defaultInterpolatedStringHandler.AppendFormatted<FName>(base.Key);
			instance2.Error(module2, author2, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		this.CurrentBattleState = EWuYinQuState.StateIdle;
		this.LastBattleState = EWuYinQuState.StateIdle;
		this.StateMachine = new StateMachine<WuYinQuBattleActor, EWuYinQuBattleState>(this, null);
		this.StateMachine.AddState<WuYinQuBattleStateIdle>(EWuYinQuBattleState.Idle, null);
		this.StateMachine.AddState<WuYinQuBattleStateFighting1>(EWuYinQuBattleState.Fighting1, null);
		this.StateMachine.AddState<WuYinQuBattleStateFighting2>(EWuYinQuBattleState.Fighting2, null);
		this.StateMachine.AddState<WuYinQuBattleStateFighting3>(EWuYinQuBattleState.Fighting3, null);
		this.StateMachine.AddState<WuYinQuBattleStateIdleToFighting>(EWuYinQuBattleState.IdleToFighting, null);
		this.StateMachine.AddState<WuYinQuBattleStateFightingToFighting>(EWuYinQuBattleState.FightingToFighting, null);
		this.StateMachine.AddState<WuYinQuBattleStateFightingToIdle>(EWuYinQuBattleState.FightingToIdle, null);
		this.InitComponents();
		this.StateMachine.Start(EWuYinQuBattleState.Idle);
		this.IsInit = true;
		this.是否已经初始化 = "已经初始化";
		Log instance3 = Log.Instance;
		ELogModule module3 = ELogModule.RenderBattle;
		ELogAuthor author3 = ELogAuthor.HCS;
		string message = "初始化无音区状态成功:";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Key", this.GetKey());
		instance3.Info(module3, author3, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return true;
	}

	// Token: 0x0601CF18 RID: 118552 RVA: 0x008105BC File Offset: 0x0080E7BC
	private void InitComponents()
	{
		this.IdleInnerPostProcess.BlendWeight = 0f;
		this.IdleInnerPostProcess.bUnbound = true;
		this.IdleOuterPostProcess.BlendWeight = 0f;
		this.IdleOuterPostProcess.bUnbound = true;
		this.FightingPhase1PostProcess.BlendWeight = 0f;
		this.FightingPhase1PostProcess.bUnbound = true;
		this.FightingPhase2PostProcess.BlendWeight = 0f;
		this.FightingPhase2PostProcess.bUnbound = true;
		this.FightingPhase3PostProcess.BlendWeight = 0f;
		this.FightingPhase3PostProcess.bUnbound = true;
		PDA_WuYinQuBattleData_C wuYinQuFightingData = this.WuYinQuFightingData;
		bool flag;
		if (wuYinQuFightingData == null)
		{
			flag = false;
		}
		else
		{
			PDA_WuYinQuBattleIdleData_C wuYinQuIdleData = wuYinQuFightingData.WuYinQuIdleData;
			flag = ((wuYinQuIdleData != null) ? new bool?(wuYinQuIdleData.IsValid()) : null).GetValueOrDefault();
		}
		if (flag)
		{
			this.IdleInnerPostProcess.WeatherDataAsset = this.WuYinQuFightingData.WuYinQuIdleData.AtmosInnerData;
			UKuroWeatherDataAsset weatherDataAsset = this.IdleInnerPostProcess.WeatherDataAsset;
			if (weatherDataAsset != null && weatherDataAsset.IsValid())
			{
				float triggerInnerSize = this.WuYinQuFightingData.TriggerInnerSize;
				FVectorDouble newScale3D = new FVectorDouble((double)(triggerInnerSize + WuYinQuBattleConfig.TriggerThreshold.X), (double)(triggerInnerSize + WuYinQuBattleConfig.TriggerThreshold.Y), (double)(triggerInnerSize + WuYinQuBattleConfig.TriggerThreshold.Z));
				this.IdleInnerBox1.D_SetRelativeScale3D(new FVectorDouble((double)triggerInnerSize, (double)triggerInnerSize, (double)triggerInnerSize));
				this.IdleInnerBox2.D_SetRelativeScale3D(newScale3D);
				this.IdleInnerPostProcessTrigger = new PostProcessTrigger();
				this.IdleInnerPostProcessTrigger.Init(this.IdleInnerBox1, this.IdleInnerBox2, this.IdleInnerPostProcess, 3.5, EWuYinQuState.StateIdle, this.GetKey());
			}
			this.IdleOuterPostProcess.WeatherDataAsset = this.WuYinQuFightingData.WuYinQuIdleData.AtmosOuterData;
			UKuroWeatherDataAsset weatherDataAsset2 = this.IdleOuterPostProcess.WeatherDataAsset;
			if (weatherDataAsset2 != null && weatherDataAsset2.IsValid())
			{
				float triggerOuterSize = this.WuYinQuFightingData.TriggerOuterSize;
				FVectorDouble newScale3D2 = new FVectorDouble((double)(triggerOuterSize + WuYinQuBattleConfig.TriggerThreshold.X), (double)(triggerOuterSize + WuYinQuBattleConfig.TriggerThreshold.Y), (double)(triggerOuterSize + WuYinQuBattleConfig.TriggerThreshold.Z));
				this.IdleOuterBox1.D_SetRelativeScale3D(new FVectorDouble((double)triggerOuterSize, (double)triggerOuterSize, (double)triggerOuterSize));
				this.IdleOuterBox2.D_SetRelativeScale3D(newScale3D2);
				this.IdleOuterPostProcessTrigger = new PostProcessTrigger();
				this.IdleOuterPostProcessTrigger.Init(this.IdleOuterBox1, this.IdleOuterBox2, this.IdleOuterPostProcess, 3.5, EWuYinQuState.StateIdle, this.GetKey());
			}
		}
		PDA_WuYinQuBattleData_C wuYinQuFightingData2 = this.WuYinQuFightingData;
		bool flag2;
		if (wuYinQuFightingData2 == null)
		{
			flag2 = false;
		}
		else
		{
			PDA_WuYinQuBattleFightingData_C wuYinQuFightingData3 = wuYinQuFightingData2.WuYinQuFightingData1;
			flag2 = ((wuYinQuFightingData3 != null) ? new bool?(wuYinQuFightingData3.IsValid()) : null).GetValueOrDefault();
		}
		if (flag2)
		{
			this.FightingPhase1PostProcess.WeatherDataAsset = this.WuYinQuFightingData.WuYinQuFightingData1.AtmosFightingData;
			UKuroWeatherDataAsset weatherDataAsset3 = this.FightingPhase1PostProcess.WeatherDataAsset;
			if (weatherDataAsset3 != null && weatherDataAsset3.IsValid())
			{
				float triggerOuterSize2 = this.WuYinQuFightingData.TriggerOuterSize;
				FVectorDouble newScale3D3 = new FVectorDouble((double)(triggerOuterSize2 + WuYinQuBattleConfig.TriggerThreshold.X), (double)(triggerOuterSize2 + WuYinQuBattleConfig.TriggerThreshold.Y), (double)(triggerOuterSize2 + WuYinQuBattleConfig.TriggerThreshold.Z));
				this.FightingPhase1Box1.D_SetRelativeScale3D(new FVectorDouble((double)triggerOuterSize2, (double)triggerOuterSize2, (double)triggerOuterSize2));
				this.FightingPhase1Box2.D_SetRelativeScale3D(newScale3D3);
				this.FightingPhase1PostProcessTrigger = new PostProcessTrigger();
				this.FightingPhase1PostProcessTrigger.Init(this.FightingPhase1Box1, this.FightingPhase1Box2, this.FightingPhase1PostProcess, 3.5, EWuYinQuState.StateFighting1, this.GetKey());
			}
		}
		PDA_WuYinQuBattleData_C wuYinQuFightingData4 = this.WuYinQuFightingData;
		bool flag3;
		if (wuYinQuFightingData4 == null)
		{
			flag3 = false;
		}
		else
		{
			PDA_WuYinQuBattleFightingData_C wuYinQuFightingData5 = wuYinQuFightingData4.WuYinQuFightingData2;
			flag3 = ((wuYinQuFightingData5 != null) ? new bool?(wuYinQuFightingData5.IsValid()) : null).GetValueOrDefault();
		}
		if (flag3)
		{
			this.FightingPhase2PostProcess.WeatherDataAsset = this.WuYinQuFightingData.WuYinQuFightingData2.AtmosFightingData;
			UKuroWeatherDataAsset weatherDataAsset4 = this.FightingPhase2PostProcess.WeatherDataAsset;
			if (weatherDataAsset4 != null && weatherDataAsset4.IsValid())
			{
				float triggerOuterSize3 = this.WuYinQuFightingData.TriggerOuterSize;
				FVectorDouble newScale3D4 = new FVectorDouble((double)(triggerOuterSize3 + WuYinQuBattleConfig.TriggerThreshold.X), (double)(triggerOuterSize3 + WuYinQuBattleConfig.TriggerThreshold.Y), (double)(triggerOuterSize3 + WuYinQuBattleConfig.TriggerThreshold.Z));
				this.FightingPhase2Box1.D_SetRelativeScale3D(new FVectorDouble((double)triggerOuterSize3, (double)triggerOuterSize3, (double)triggerOuterSize3));
				this.FightingPhase2Box2.D_SetRelativeScale3D(newScale3D4);
				this.FightingPhase2PostProcessTrigger = new PostProcessTrigger();
				this.FightingPhase2PostProcessTrigger.Init(this.FightingPhase2Box1, this.FightingPhase2Box2, this.FightingPhase2PostProcess, 3.5, EWuYinQuState.StateFighting2, this.GetKey());
			}
		}
		PDA_WuYinQuBattleData_C wuYinQuFightingData6 = this.WuYinQuFightingData;
		bool flag4;
		if (wuYinQuFightingData6 == null)
		{
			flag4 = false;
		}
		else
		{
			PDA_WuYinQuBattleFightingData_C wuYinQuFightingData7 = wuYinQuFightingData6.WuYinQuFightingData3;
			flag4 = ((wuYinQuFightingData7 != null) ? new bool?(wuYinQuFightingData7.IsValid()) : null).GetValueOrDefault();
		}
		if (flag4)
		{
			this.FightingPhase3PostProcess.WeatherDataAsset = this.WuYinQuFightingData.WuYinQuFightingData3.AtmosFightingData;
			UKuroWeatherDataAsset weatherDataAsset5 = this.FightingPhase3PostProcess.WeatherDataAsset;
			if (weatherDataAsset5 != null && weatherDataAsset5.IsValid())
			{
				float triggerOuterSize4 = this.WuYinQuFightingData.TriggerOuterSize;
				FVectorDouble newScale3D5 = new FVectorDouble((double)(triggerOuterSize4 + WuYinQuBattleConfig.TriggerThreshold.X), (double)(triggerOuterSize4 + WuYinQuBattleConfig.TriggerThreshold.Y), (double)(triggerOuterSize4 + WuYinQuBattleConfig.TriggerThreshold.Z));
				this.FightingPhase3Box1.D_SetRelativeScale3D(new FVectorDouble((double)triggerOuterSize4, (double)triggerOuterSize4, (double)triggerOuterSize4));
				this.FightingPhase3Box2.D_SetRelativeScale3D(newScale3D5);
				this.FightingPhase3PostProcessTrigger = new PostProcessTrigger();
				this.FightingPhase3PostProcessTrigger.Init(this.FightingPhase3Box1, this.FightingPhase3Box2, this.FightingPhase3PostProcess, 3.5, EWuYinQuState.StateFighting3, this.GetKey());
			}
		}
	}

	// Token: 0x0601CF19 RID: 118553 RVA: 0x00810B45 File Offset: 0x0080ED45
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (WuYinQuBattleActor._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Battle/WuYinQuBattleActor.WuYinQuBattleActor_C");
		}
		return WuYinQuBattleActor._ClassPtr;
	}

	// Token: 0x0601CF1A RID: 118554 RVA: 0x00810B6C File Offset: 0x0080ED6C
	public WuYinQuBattleActor() : this(BuiltinUtils.AllocNativeUObject(WuYinQuBattleActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601CF1B RID: 118555 RVA: 0x00810B94 File Offset: 0x0080ED94
	[NullableContext(1)]
	public WuYinQuBattleActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(WuYinQuBattleActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CF1C RID: 118556 RVA: 0x00810BC7 File Offset: 0x0080EDC7
	protected WuYinQuBattleActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601CF1D RID: 118557 RVA: 0x00810BDE File Offset: 0x0080EDDE
	protected virtual void __CPPCALL_手动初始化_Implementation()
	{
		this.手动初始化_Implementation();
	}

	// Token: 0x0601CF1E RID: 118558 RVA: 0x00810BE6 File Offset: 0x0080EDE6
	protected virtual void __CPPCALL_显示Debug线框_Implementation()
	{
		this.显示Debug线框_Implementation();
	}

	// Token: 0x0601CF1F RID: 118559 RVA: 0x00810BEE File Offset: 0x0080EDEE
	protected virtual void __CPPCALL_切换到清空状态_Implementation()
	{
		this.切换到清空状态_Implementation();
	}

	// Token: 0x0601CF20 RID: 118560 RVA: 0x00810BF6 File Offset: 0x0080EDF6
	protected virtual void __CPPCALL_切换到静止状态_Implementation()
	{
		this.切换到静止状态_Implementation();
	}

	// Token: 0x0601CF21 RID: 118561 RVA: 0x00810BFE File Offset: 0x0080EDFE
	protected virtual void __CPPCALL_切换到战斗阶段1_Implementation()
	{
		this.切换到战斗阶段1_Implementation();
	}

	// Token: 0x0601CF22 RID: 118562 RVA: 0x00810C06 File Offset: 0x0080EE06
	protected virtual void __CPPCALL_切换到战斗阶段2_Implementation()
	{
		this.切换到战斗阶段2_Implementation();
	}

	// Token: 0x0601CF23 RID: 118563 RVA: 0x00810C0E File Offset: 0x0080EE0E
	protected virtual void __CPPCALL_切换到战斗阶段3_Implementation()
	{
		this.切换到战斗阶段3_Implementation();
	}

	// Token: 0x0601CF24 RID: 118564 RVA: 0x00810C16 File Offset: 0x0080EE16
	protected virtual void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		this.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601CF25 RID: 118565 RVA: 0x00810C20 File Offset: 0x0080EE20
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		this.ReceiveEndPlay_Implementation(endPlayReason);
	}

	// Token: 0x0400E421 RID: 58401
	private EWuYinQuState CurrentBattleState = EWuYinQuState.Nothing;

	// Token: 0x0400E422 RID: 58402
	private EWuYinQuState LastBattleState = EWuYinQuState.Nothing;

	// Token: 0x0400E423 RID: 58403
	private bool IsInit;

	// Token: 0x0400E424 RID: 58404
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private StateMachine<WuYinQuBattleActor, EWuYinQuBattleState> StateMachine;

	// Token: 0x0400E425 RID: 58405
	private PostProcessTrigger IdleInnerPostProcessTrigger;

	// Token: 0x0400E426 RID: 58406
	private PostProcessTrigger IdleOuterPostProcessTrigger;

	// Token: 0x0400E427 RID: 58407
	private PostProcessTrigger FightingPhase1PostProcessTrigger;

	// Token: 0x0400E428 RID: 58408
	private PostProcessTrigger FightingPhase2PostProcessTrigger;

	// Token: 0x0400E429 RID: 58409
	private PostProcessTrigger FightingPhase3PostProcessTrigger;

	// Token: 0x0400E42A RID: 58410
	private string StringKey;

	// Token: 0x0400E42B RID: 58411
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Battle/WuYinQuBattleActor.WuYinQuBattleActor_C";

	// Token: 0x0400E42C RID: 58412
	private static IntPtr _ClassPtr;

	// Token: 0x0400E42D RID: 58413
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E42E RID: 58414
	private static int __PropertyOffset_当前状态;

	// Token: 0x0400E42F RID: 58415
	private static int __PropertyOffset_是否已经初始化;

	// Token: 0x0400E430 RID: 58416
	private static int __PropertyOffset_ReferenceKuroLevelSequence;

	// Token: 0x0400E431 RID: 58417
	private static int __PropertyOffset_Root;

	// Token: 0x0400E432 RID: 58418
	private static int __PropertyOffset_IdleInnerBox1;

	// Token: 0x0400E433 RID: 58419
	private static int __PropertyOffset_IdleInnerBox2;

	// Token: 0x0400E434 RID: 58420
	private static int __PropertyOffset_IdleInnerPostProcess;

	// Token: 0x0400E435 RID: 58421
	private static int __PropertyOffset_IdleOuterBox1;

	// Token: 0x0400E436 RID: 58422
	private static int __PropertyOffset_IdleOuterBox2;

	// Token: 0x0400E437 RID: 58423
	private static int __PropertyOffset_IdleOuterPostProcess;

	// Token: 0x0400E438 RID: 58424
	private static int __PropertyOffset_FightingPhase1Box1;

	// Token: 0x0400E439 RID: 58425
	private static int __PropertyOffset_FightingPhase1Box2;

	// Token: 0x0400E43A RID: 58426
	private static int __PropertyOffset_FightingPhase1PostProcess;

	// Token: 0x0400E43B RID: 58427
	private static int __PropertyOffset_FightingPhase2Box1;

	// Token: 0x0400E43C RID: 58428
	private static int __PropertyOffset_FightingPhase2Box2;

	// Token: 0x0400E43D RID: 58429
	private static int __PropertyOffset_FightingPhase2PostProcess;

	// Token: 0x0400E43E RID: 58430
	private static int __PropertyOffset_FightingPhase3Box1;

	// Token: 0x0400E43F RID: 58431
	private static int __PropertyOffset_FightingPhase3Box2;

	// Token: 0x0400E440 RID: 58432
	private static int __PropertyOffset_FightingPhase3PostProcess;

	// Token: 0x0400E441 RID: 58433
	private static int __PropertyOffset_WuYinQuFightingData;
}
