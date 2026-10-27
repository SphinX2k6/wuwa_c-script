using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002DFC RID: 11772
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataManipulatableTagsChange.LogicDataManipulatableTagsChange_C")]
public class LogicDataManipulatableTagsChange : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002200 RID: 8704
	// (get) Token: 0x06018BC9 RID: 101321 RVA: 0x00658C58 File Offset: 0x00656E58
	// (set) Token: 0x06018BCA RID: 101322 RVA: 0x00658C91 File Offset: 0x00656E91
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

	// Token: 0x17002201 RID: 8705
	// (get) Token: 0x06018BCB RID: 101323 RVA: 0x00658CBC File Offset: 0x00656EBC
	// (set) Token: 0x06018BCC RID: 101324 RVA: 0x00658CF5 File Offset: 0x00656EF5
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

	// Token: 0x17002202 RID: 8706
	// (get) Token: 0x06018BCD RID: 101325 RVA: 0x00658D20 File Offset: 0x00656F20
	// (set) Token: 0x06018BCE RID: 101326 RVA: 0x00658D59 File Offset: 0x00656F59
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

	// Token: 0x17002203 RID: 8707
	// (get) Token: 0x06018BCF RID: 101327 RVA: 0x00658D84 File Offset: 0x00656F84
	// (set) Token: 0x06018BD0 RID: 101328 RVA: 0x00658DBD File Offset: 0x00656FBD
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

	// Token: 0x06018BD1 RID: 101329 RVA: 0x00658DE5 File Offset: 0x00656FE5
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataManipulatableTagsChange._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataManipulatableTagsChange.LogicDataManipulatableTagsChange_C");
		}
		return LogicDataManipulatableTagsChange._ClassPtr;
	}

	// Token: 0x06018BD2 RID: 101330 RVA: 0x00658E0C File Offset: 0x0065700C
	public LogicDataManipulatableTagsChange() : this(BuiltinUtils.AllocNativeUObject(LogicDataManipulatableTagsChange.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06018BD3 RID: 101331 RVA: 0x00658E34 File Offset: 0x00657034
	public LogicDataManipulatableTagsChange(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataManipulatableTagsChange.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06018BD4 RID: 101332 RVA: 0x00658E67 File Offset: 0x00657067
	protected LogicDataManipulatableTagsChange(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400B891 RID: 47249
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataManipulatableTagsChange.LogicDataManipulatableTagsChange_C";

	// Token: 0x0400B892 RID: 47250
	private static IntPtr _ClassPtr;

	// Token: 0x0400B893 RID: 47251
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B894 RID: 47252
	private static int __PropertyOffset_ExistTagsCondition;

	// Token: 0x0400B895 RID: 47253
	[Nullable(2)]
	private FGameplayTagContainer _ExistTagsCondition;

	// Token: 0x0400B896 RID: 47254
	private static int __PropertyOffset_UnExistTagsCondition;

	// Token: 0x0400B897 RID: 47255
	[Nullable(2)]
	private FGameplayTagContainer _UnExistTagsCondition;

	// Token: 0x0400B898 RID: 47256
	private static int __PropertyOffset_AddTags;

	// Token: 0x0400B899 RID: 47257
	[Nullable(2)]
	private FGameplayTagContainer _AddTags;

	// Token: 0x0400B89A RID: 47258
	private static int __PropertyOffset_RemoveTags;

	// Token: 0x0400B89B RID: 47259
	[Nullable(2)]
	private FGameplayTagContainer _RemoveTags;
}
