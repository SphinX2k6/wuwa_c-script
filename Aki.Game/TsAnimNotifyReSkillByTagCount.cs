using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001CE RID: 462
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyReSkillByTagCount.TsAnimNotifyReSkillByTagCount_C")]
public class TsAnimNotifyReSkillByTagCount : TsAnimNotifyReSkillEvent, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700049A RID: 1178
	// (get) Token: 0x06001CD0 RID: 7376 RVA: 0x000922AB File Offset: 0x000904AB
	// (set) Token: 0x06001CD1 RID: 7377 RVA: 0x000922BF File Offset: 0x000904BF
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

	// Token: 0x1700049B RID: 1179
	// (get) Token: 0x06001CD2 RID: 7378 RVA: 0x000922D4 File Offset: 0x000904D4
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

	// Token: 0x1700049C RID: 1180
	// (get) Token: 0x06001CD3 RID: 7379 RVA: 0x0009230D File Offset: 0x0009050D
	// (set) Token: 0x06001CD4 RID: 7380 RVA: 0x00092321 File Offset: 0x00090521
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

	// Token: 0x06001CD5 RID: 7381 RVA: 0x00092338 File Offset: 0x00090538
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNotifyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UAnimNotify.__GetNotifyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UAnimNotify.__GetNotifyName_FunctionParams*)ptr + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L);
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

	// Token: 0x06001CD6 RID: 7382 RVA: 0x000923B3 File Offset: 0x000905B3
	protected override string GetNotifyName_Implementation()
	{
		return "根据Tag层数添加子弹";
	}

	// Token: 0x06001CD7 RID: 7383 RVA: 0x000923BC File Offset: 0x000905BC
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

	// Token: 0x06001CD8 RID: 7384 RVA: 0x000924A0 File Offset: 0x000906A0
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyReSkillByTagCount._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyReSkillByTagCount.TsAnimNotifyReSkillByTagCount_C");
		}
		return TsAnimNotifyReSkillByTagCount._ClassPtr;
	}

	// Token: 0x06001CD9 RID: 7385 RVA: 0x000924C4 File Offset: 0x000906C4
	public TsAnimNotifyReSkillByTagCount() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyReSkillByTagCount.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001CDA RID: 7386 RVA: 0x000924EC File Offset: 0x000906EC
	public TsAnimNotifyReSkillByTagCount(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyReSkillByTagCount.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001CDB RID: 7387 RVA: 0x0009251F File Offset: 0x0009071F
	protected TsAnimNotifyReSkillByTagCount(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001CDC RID: 7388 RVA: 0x00092528 File Offset: 0x00090728
	[NullableContext(0)]
	protected unsafe override void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400120B RID: 4619
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyReSkillByTagCount.TsAnimNotifyReSkillByTagCount_C";

	// Token: 0x0400120C RID: 4620
	private static IntPtr _ClassPtr;

	// Token: 0x0400120D RID: 4621
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400120E RID: 4622
	private static int __PropertyOffset_层数Tag;

	// Token: 0x0400120F RID: 4623
	private static int __PropertyOffset_子弹数组Tag条件;

	// Token: 0x04001210 RID: 4624
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<string> _子弹数组Tag条件;

	// Token: 0x04001211 RID: 4625
	private static int __PropertyOffset_子弹数据名Tag条件;
}
