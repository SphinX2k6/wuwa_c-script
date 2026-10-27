using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.BaseCharacter.Tools;
using UnrealEngine;
using UnrealEngine.Extension;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000123 RID: 291
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCounterAttack.TsAnimNotifyStateCounterAttack_C")]
public class TsAnimNotifyStateCounterAttack : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170002D5 RID: 725
	// (get) Token: 0x06001190 RID: 4496 RVA: 0x000627F7 File Offset: 0x000609F7
	// (set) Token: 0x06001191 RID: 4497 RVA: 0x0006280B File Offset: 0x00060A0B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe CounterAttackCameraData 弹反摄像机预设
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<CounterAttackCameraData>(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateCounterAttack.__PropertyOffset_弹反摄像机预设);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateCounterAttack.__PropertyOffset_弹反摄像机预设, value);
		}
	}

	// Token: 0x170002D6 RID: 726
	// (get) Token: 0x06001192 RID: 4498 RVA: 0x00062820 File Offset: 0x00060A20
	// (set) Token: 0x06001193 RID: 4499 RVA: 0x00062834 File Offset: 0x00060A34
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe CounterAttackEffectData 弹反特效预设
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<CounterAttackEffectData>(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateCounterAttack.__PropertyOffset_弹反特效预设);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateCounterAttack.__PropertyOffset_弹反特效预设, value);
		}
	}

	// Token: 0x170002D7 RID: 727
	// (get) Token: 0x06001194 RID: 4500 RVA: 0x0006284C File Offset: 0x00060A4C
	// (set) Token: 0x06001195 RID: 4501 RVA: 0x00062885 File Offset: 0x00060A85
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	public SCounterAttack 弹反设置
	{
		[NullableContext(1)]
		get
		{
			base.FastCheckIsValid();
			SCounterAttack result;
			if ((result = this._弹反设置) == null)
			{
				result = (this._弹反设置 = new SCounterAttack(base.NativePtr + (IntPtr)TsAnimNotifyStateCounterAttack.__PropertyOffset_弹反设置, this));
			}
			return result;
		}
		[NullableContext(1)]
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(SCounterAttack.StaticStruct(), base.NativePtr + (IntPtr)TsAnimNotifyStateCounterAttack.__PropertyOffset_弹反设置, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x170002D8 RID: 728
	// (get) Token: 0x06001196 RID: 4502 RVA: 0x000628AD File Offset: 0x00060AAD
	// (set) Token: 0x06001197 RID: 4503 RVA: 0x000628C1 File Offset: 0x00060AC1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName 生成子弹ID
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateCounterAttack.__PropertyOffset_生成子弹ID);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateCounterAttack.__PropertyOffset_生成子弹ID) = value;
		}
	}

	// Token: 0x06001198 RID: 4504 RVA: 0x000628D8 File Offset: 0x00060AD8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyBegin"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
			ptr2->TotalDuration = totalDuration;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06001199 RID: 4505 RVA: 0x00062980 File Offset: 0x00060B80
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Battle;
		ELogAuthor author = ELogAuthor.HCW;
		string message = "CounterAttack Begin";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Owner", owner);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (owner is TsBaseCharacter)
		{
			CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
			Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
			if (entity == null || !entity.Valid)
			{
				return false;
			}
			BaseBuffComponent component = entity.GetComponent<BaseBuffComponent>();
			this.AnMessageId = ((component != null) ? component.CreateAnimNotifyContent(animation.GetName(), base.exportIndex) : null);
			CharacterSkillComponent component2 = entity.GetComponent<CharacterSkillComponent>();
			CharacterHitComponent component3 = entity.GetComponent<CharacterHitComponent>();
			if (component2 == null || !component2.Valid || (component3 == null || !component3.Valid))
			{
				return false;
			}
			if (this.弹反设置 == null)
			{
				return false;
			}
			component3.SetCounterAttackAnsInfo(this.AnMessageId, base.exportIndex);
			if (this.弹反摄像机预设 != null || this.弹反特效预设 != null)
			{
				SCounterAttack scounterAttack = new SCounterAttack(this.弹反设置.弹反部位, this.弹反设置.无弹反动作效果, this.弹反设置.有弹反动作效果, this.弹反设置.削韧倍率, this.弹反设置.最大触发距离, this.弹反设置.最大触发夹角, this.弹反设置.被弹反者应用BuffID, this.弹反设置.攻击者应用BuffID, this.弹反设置.受击动画忽略Buff检测, this.弹反设置.检测Buff列表, this.弹反设置.ANS期间被弹反者生效的BuffID, this.弹反设置.结束事件Tag, this.弹反设置.QTE弹刀忽略角度距离检测);
				if (this.弹反摄像机预设 != null)
				{
					scounterAttack.无弹反动作效果.摄像机设置 = this.弹反摄像机预设.CameraData;
					scounterAttack.无弹反动作效果.攻击者顿帧 = this.弹反摄像机预设.AttackerTimeScale;
					scounterAttack.无弹反动作效果.被击者顿帧 = this.弹反摄像机预设.VictimTimeScale;
					scounterAttack.无弹反动作效果.震屏 = this.弹反摄像机预设.CameraShake;
					scounterAttack.有弹反动作效果.摄像机设置 = this.弹反摄像机预设.CameraData;
					scounterAttack.有弹反动作效果.攻击者顿帧 = this.弹反摄像机预设.AttackerTimeScale;
					scounterAttack.有弹反动作效果.被击者顿帧 = this.弹反摄像机预设.VictimTimeScale;
					scounterAttack.有弹反动作效果.震屏 = this.弹反摄像机预设.CameraShake;
				}
				if (this.弹反特效预设 != null)
				{
					scounterAttack.无弹反动作效果.特效DA = this.弹反特效预设.EffectDA;
					scounterAttack.无弹反动作效果.特效Offset = this.弹反特效预设.Offset;
					scounterAttack.无弹反动作效果.特效Scale = this.弹反特效预设.Scale;
					scounterAttack.有弹反动作效果.特效DA = this.弹反特效预设.EffectDA;
					scounterAttack.有弹反动作效果.特效Offset = this.弹反特效预设.Offset;
					scounterAttack.有弹反动作效果.特效Scale = this.弹反特效预设.Scale;
				}
				component3.SetCounterAttackInfo(scounterAttack);
				component3.SetCounterAttackEndTime(totalDuration);
				return true;
			}
			this.SkillId = component2.GetCurrentMontageCorrespondingSkillId();
			component3.SetCounterAttackInfo(this.弹反设置);
			component3.SetCounterAttackEndTime(totalDuration);
		}
		return true;
	}

	// Token: 0x0600119A RID: 4506 RVA: 0x00062CB4 File Offset: 0x00060EB4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyEnd"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0600119B RID: 4507 RVA: 0x00062D54 File Offset: 0x00060F54
	protected unsafe virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Battle;
		ELogAuthor author = ELogAuthor.HCW;
		string message = "CounterAttack End";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Owner", owner);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
			Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
			if (entity == null || !entity.Valid)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Battle;
				ELogAuthor author2 = ELogAuthor.HCW;
				string message2 = "CounterAttack End entity not valid";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Owner", tsBaseCharacter);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return false;
			}
			CharacterSkillComponent component = entity.GetComponent<CharacterSkillComponent>();
			CharacterHitComponent component2 = entity.GetComponent<CharacterHitComponent>();
			if (component == null || !component.Valid || (component2 == null || !component2.Valid))
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.Battle;
				ELogAuthor author3 = ELogAuthor.HCW;
				string message3 = "CounterAttack End skillComp or hitComp not valid";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Owner", tsBaseCharacter);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SkillComp", (component != null) ? new bool?(component.Valid) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("HitComp", (component2 != null) ? new bool?(component2.Valid) : null);
				instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return false;
			}
			bool hadTriggerCounterAttack = component2.HadTriggerCounterAttack;
			component2.CounterAttackEnd();
			if (hadTriggerCounterAttack)
			{
				return true;
			}
			if (FNameUtil.IsNothing(this.生成子弹ID))
			{
				return false;
			}
			BulletUtil.CreateBulletFromAN(tsBaseCharacter, this.生成子弹ID.ToString(), null, this.SkillId, false, this.AnMessageId, null, null, null);
			return true;
		}
		else
		{
			if (FNameUtil.IsNothing(this.生成子弹ID))
			{
				return false;
			}
			BP_EWorldType worldType = UKuroRenderingRuntimeBPPluginBPLibrary.GetWorldType(owner.GetWorld());
			if (worldType != BP_EWorldType.Editor && worldType != BP_EWorldType.EditorPreview)
			{
				return false;
			}
			ResourceSystem.Instance.LoadTypeAsync("BPL_BulletPreview", delegate
			{
				AActor aactor = null;
				BPL_BulletPreview_C.ShowBulletPreview(UKismetSystemLibrary.GetPathName(UKismetSystemLibrary.GetOuterObject(this)), this.生成子弹ID, owner, meshComp, owner.GetWorld(), ref aactor);
			}, "js_undefined");
			return false;
		}
	}

	// Token: 0x0600119C RID: 4508 RVA: 0x00062FC0 File Offset: 0x000611C0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNotifyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UAnimNotifyState.__GetNotifyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UAnimNotifyState.__GetNotifyName_FunctionParams*)ptr + 15L / (long)sizeof(UAnimNotifyState.__GetNotifyName_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		string result = FString.ToString((void*)(&ptr2->__Result));
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return result;
	}

	// Token: 0x0600119D RID: 4509 RVA: 0x0006303B File Offset: 0x0006123B
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "弹反配置";
	}

	// Token: 0x0600119E RID: 4510 RVA: 0x00063042 File Offset: 0x00061242
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateCounterAttack._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCounterAttack.TsAnimNotifyStateCounterAttack_C");
		}
		return TsAnimNotifyStateCounterAttack._ClassPtr;
	}

	// Token: 0x0600119F RID: 4511 RVA: 0x00063068 File Offset: 0x00061268
	public TsAnimNotifyStateCounterAttack() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateCounterAttack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060011A0 RID: 4512 RVA: 0x00063090 File Offset: 0x00061290
	[NullableContext(1)]
	public TsAnimNotifyStateCounterAttack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateCounterAttack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060011A1 RID: 4513 RVA: 0x000630C3 File Offset: 0x000612C3
	protected TsAnimNotifyStateCounterAttack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060011A2 RID: 4514 RVA: 0x000630CC File Offset: 0x000612CC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060011A3 RID: 4515 RVA: 0x00063108 File Offset: 0x00061308
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060011A4 RID: 4516 RVA: 0x0006313B File Offset: 0x0006133B
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000D1C RID: 3356
	private long? AnMessageId;

	// Token: 0x04000D1D RID: 3357
	private int SkillId;

	// Token: 0x04000D1E RID: 3358
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCounterAttack.TsAnimNotifyStateCounterAttack_C";

	// Token: 0x04000D1F RID: 3359
	private static IntPtr _ClassPtr;

	// Token: 0x04000D20 RID: 3360
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000D21 RID: 3361
	private static int __PropertyOffset_弹反摄像机预设;

	// Token: 0x04000D22 RID: 3362
	private static int __PropertyOffset_弹反特效预设;

	// Token: 0x04000D23 RID: 3363
	private static int __PropertyOffset_弹反设置;

	// Token: 0x04000D24 RID: 3364
	private SCounterAttack _弹反设置;

	// Token: 0x04000D25 RID: 3365
	private static int __PropertyOffset_生成子弹ID;
}
