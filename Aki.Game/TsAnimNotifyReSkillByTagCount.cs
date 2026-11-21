using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001D2 RID: 466
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyReSkillByTagCount.TsAnimNotifyReSkillByTagCount_C")]
public class TsAnimNotifyReSkillByTagCount : TsAnimNotifyReSkillEvent, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004BC RID: 1212
	// (get) Token: 0x06001D6D RID: 7533 RVA: 0x00098FD3 File Offset: 0x000971D3
	// (set) Token: 0x06001D6E RID: 7534 RVA: 0x00098FE7 File Offset: 0x000971E7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FGameplayTag 层数Tag
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyReSkillByTagCount.__PropertyOffset_层数Tag);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyReSkillByTagCount.__PropertyOffset_层数Tag) = value;
		}
	}

	// Token: 0x170004BD RID: 1213
	// (get) Token: 0x06001D6F RID: 7535 RVA: 0x00098FFC File Offset: 0x000971FC
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<string> 子弹数组Tag条件
	{
		get
		{
			base.FastCheckIsValid();
			TArray<string> result;
			if ((result = this._子弹数组Tag条件) == null)
			{
				result = (this._子弹数组Tag条件 = new TArray<string>(base.NativePtr + (IntPtr)TsAnimNotifyReSkillByTagCount.__PropertyOffset_子弹数组Tag条件, this));
			}
			return result;
		}
	}

	// Token: 0x170004BE RID: 1214
	// (get) Token: 0x06001D70 RID: 7536 RVA: 0x00099035 File Offset: 0x00097235
	// (set) Token: 0x06001D71 RID: 7537 RVA: 0x00099049 File Offset: 0x00097249
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string 子弹数据名Tag条件
	{
		[NullableContext(2)]
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyReSkillByTagCount.__PropertyOffset_子弹数据名Tag条件)));
		}
		[NullableContext(2)]
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyReSkillByTagCount.__PropertyOffset_子弹数据名Tag条件)), value);
		}
	}

	// Token: 0x06001D72 RID: 7538 RVA: 0x00099060 File Offset: 0x00097260
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyReSkillByTagCount) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyReSkillByTagCount.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotify.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotify.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x06001D73 RID: 7539 RVA: 0x000990F0 File Offset: 0x000972F0
	protected override string GetNotifyName_Implementation()
	{
		return "根据Tag层数添加子弹";
	}

	// Token: 0x06001D74 RID: 7540 RVA: 0x000990F8 File Offset: 0x000972F8
	protected override bool CanCreateBullet(AActor owner, UAnimSequenceBase animation, int index)
	{
		FGameplayTag 层数Tag = this.层数Tag;
		if (StringUtils.IsNothing(this.层数Tag.TagName.ToString()))
		{
			return true;
		}
		BaseTagComponent component = (owner as TsBaseCharacter).GetEntityNoBlueprint().GetComponent<BaseTagComponent>();
		if (component == null || !component.Valid)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.HCW;
			string message = "动画Character没有Tag组件";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("AnimSequence", UKismetSystemLibrary.GetPathName(animation));
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		int tagId = this.层数Tag.TagId();
		if (!base.使用子弹id数组)
		{
			int tagCount = component.GetTagCount(tagId);
			string 子弹数据名Tag条件 = this.子弹数据名Tag条件;
			return BulletUtil.TagStackCountCondition(tagCount, 子弹数据名Tag条件);
		}
		int num = this.子弹数组Tag条件.Num();
		if (index < num)
		{
			int tagCount2 = component.GetTagCount(tagId);
			string stackCountConditionConf = this.子弹数组Tag条件.Get(index);
			return BulletUtil.TagStackCountCondition(tagCount2, stackCountConditionConf);
		}
		return true;
	}

	// Token: 0x06001D75 RID: 7541 RVA: 0x000991DC File Offset: 0x000973DC
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyReSkillByTagCount._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyReSkillByTagCount.TsAnimNotifyReSkillByTagCount_C");
		}
		return TsAnimNotifyReSkillByTagCount._ClassPtr;
	}

	// Token: 0x06001D76 RID: 7542 RVA: 0x00099200 File Offset: 0x00097400
	public TsAnimNotifyReSkillByTagCount() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyReSkillByTagCount.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001D77 RID: 7543 RVA: 0x00099228 File Offset: 0x00097428
	public TsAnimNotifyReSkillByTagCount(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyReSkillByTagCount.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001D78 RID: 7544 RVA: 0x0009925B File Offset: 0x0009745B
	protected TsAnimNotifyReSkillByTagCount(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001D79 RID: 7545 RVA: 0x00099264 File Offset: 0x00097464
	[NullableContext(0)]
	protected unsafe override void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400124E RID: 4686
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyReSkillByTagCount.TsAnimNotifyReSkillByTagCount_C";

	// Token: 0x0400124F RID: 4687
	private static IntPtr _ClassPtr;

	// Token: 0x04001250 RID: 4688
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001251 RID: 4689
	private static int __PropertyOffset_层数Tag;

	// Token: 0x04001252 RID: 4690
	private static int __PropertyOffset_子弹数组Tag条件;

	// Token: 0x04001253 RID: 4691
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<string> _子弹数组Tag条件;

	// Token: 0x04001254 RID: 4692
	private static int __PropertyOffset_子弹数据名Tag条件;
}
