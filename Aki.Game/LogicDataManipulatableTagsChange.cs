using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002357 RID: 9047
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataManipulatableTagsChange.LogicDataManipulatableTagsChange_C")]
public class LogicDataManipulatableTagsChange : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002264 RID: 8804
	// (get) Token: 0x0601647E RID: 91262 RVA: 0x0067ECDC File Offset: 0x0067CEDC
	// (set) Token: 0x0601647F RID: 91263 RVA: 0x0067ED15 File Offset: 0x0067CF15
	[UProperty(EPropertyFlags.CPF_None)]
	public FGameplayTagContainer ExistTagsCondition
	{
		get
		{
			base.FastCheckIsValid();
			FGameplayTagContainer result;
			if ((result = this._ExistTagsCondition) == null)
			{
				result = (this._ExistTagsCondition = new FGameplayTagContainer(base.NativePtr + (IntPtr)LogicDataManipulatableTagsChange.__PropertyOffset_ExistTagsCondition, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)LogicDataManipulatableTagsChange.__PropertyOffset_ExistTagsCondition, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002265 RID: 8805
	// (get) Token: 0x06016480 RID: 91264 RVA: 0x0067ED40 File Offset: 0x0067CF40
	// (set) Token: 0x06016481 RID: 91265 RVA: 0x0067ED79 File Offset: 0x0067CF79
	[UProperty(EPropertyFlags.CPF_None)]
	public FGameplayTagContainer UnExistTagsCondition
	{
		get
		{
			base.FastCheckIsValid();
			FGameplayTagContainer result;
			if ((result = this._UnExistTagsCondition) == null)
			{
				result = (this._UnExistTagsCondition = new FGameplayTagContainer(base.NativePtr + (IntPtr)LogicDataManipulatableTagsChange.__PropertyOffset_UnExistTagsCondition, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)LogicDataManipulatableTagsChange.__PropertyOffset_UnExistTagsCondition, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002266 RID: 8806
	// (get) Token: 0x06016482 RID: 91266 RVA: 0x0067EDA4 File Offset: 0x0067CFA4
	// (set) Token: 0x06016483 RID: 91267 RVA: 0x0067EDDD File Offset: 0x0067CFDD
	[UProperty(EPropertyFlags.CPF_None)]
	public FGameplayTagContainer AddTags
	{
		get
		{
			base.FastCheckIsValid();
			FGameplayTagContainer result;
			if ((result = this._AddTags) == null)
			{
				result = (this._AddTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)LogicDataManipulatableTagsChange.__PropertyOffset_AddTags, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)LogicDataManipulatableTagsChange.__PropertyOffset_AddTags, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002267 RID: 8807
	// (get) Token: 0x06016484 RID: 91268 RVA: 0x0067EE08 File Offset: 0x0067D008
	// (set) Token: 0x06016485 RID: 91269 RVA: 0x0067EE41 File Offset: 0x0067D041
	[UProperty(EPropertyFlags.CPF_None)]
	public FGameplayTagContainer RemoveTags
	{
		get
		{
			base.FastCheckIsValid();
			FGameplayTagContainer result;
			if ((result = this._RemoveTags) == null)
			{
				result = (this._RemoveTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)LogicDataManipulatableTagsChange.__PropertyOffset_RemoveTags, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)LogicDataManipulatableTagsChange.__PropertyOffset_RemoveTags, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x06016486 RID: 91270 RVA: 0x0067EE69 File Offset: 0x0067D069
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataManipulatableTagsChange._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataManipulatableTagsChange.LogicDataManipulatableTagsChange_C");
		}
		return LogicDataManipulatableTagsChange._ClassPtr;
	}

	// Token: 0x06016487 RID: 91271 RVA: 0x0067EE90 File Offset: 0x0067D090
	public LogicDataManipulatableTagsChange() : this(BuiltinUtils.AllocNativeUObject(LogicDataManipulatableTagsChange.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06016488 RID: 91272 RVA: 0x0067EEB8 File Offset: 0x0067D0B8
	public LogicDataManipulatableTagsChange(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataManipulatableTagsChange.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06016489 RID: 91273 RVA: 0x0067EEEB File Offset: 0x0067D0EB
	protected LogicDataManipulatableTagsChange(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400BC17 RID: 48151
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataManipulatableTagsChange.LogicDataManipulatableTagsChange_C";

	// Token: 0x0400BC18 RID: 48152
	private static IntPtr _ClassPtr;

	// Token: 0x0400BC19 RID: 48153
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400BC1A RID: 48154
	private static int __PropertyOffset_ExistTagsCondition;

	// Token: 0x0400BC1B RID: 48155
	[Nullable(2)]
	private FGameplayTagContainer _ExistTagsCondition;

	// Token: 0x0400BC1C RID: 48156
	private static int __PropertyOffset_UnExistTagsCondition;

	// Token: 0x0400BC1D RID: 48157
	[Nullable(2)]
	private FGameplayTagContainer _UnExistTagsCondition;

	// Token: 0x0400BC1E RID: 48158
	private static int __PropertyOffset_AddTags;

	// Token: 0x0400BC1F RID: 48159
	[Nullable(2)]
	private FGameplayTagContainer _AddTags;

	// Token: 0x0400BC20 RID: 48160
	private static int __PropertyOffset_RemoveTags;

	// Token: 0x0400BC21 RID: 48161
	[Nullable(2)]
	private FGameplayTagContainer _RemoveTags;
}
