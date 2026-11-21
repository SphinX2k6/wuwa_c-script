using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002227 RID: 8743
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Module/UiNavigation/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/UiNavigation/TsUiHotKeyLinkListener.TsUiHotKeyLinkListener_C")]
public class TsUiHotKeyLinkListener : ULGUIBehaviour, IUnrealUObject, IUnrealObject
{
	// Token: 0x170020C4 RID: 8388
	// (get) Token: 0x06015969 RID: 88425 RVA: 0x00643E54 File Offset: 0x00642054
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<AActor> ActorList
	{
		get
		{
			base.FastCheckIsValid();
			TArray<AActor> result;
			if ((result = this._ActorList) == null)
			{
				result = (this._ActorList = new TArray<AActor>(base.NativePtr + (IntPtr)TsUiHotKeyLinkListener.__PropertyOffset_ActorList, this));
			}
			return result;
		}
	}

	// Token: 0x0601596A RID: 88426 RVA: 0x00643E8D File Offset: 0x0064208D
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsUiHotKeyLinkListener._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/UiNavigation/TsUiHotKeyLinkListener.TsUiHotKeyLinkListener_C");
		}
		return TsUiHotKeyLinkListener._ClassPtr;
	}

	// Token: 0x0601596B RID: 88427 RVA: 0x00643EB4 File Offset: 0x006420B4
	public TsUiHotKeyLinkListener() : this(BuiltinUtils.AllocNativeUObject(TsUiHotKeyLinkListener.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601596C RID: 88428 RVA: 0x00643EDC File Offset: 0x006420DC
	public TsUiHotKeyLinkListener(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiHotKeyLinkListener.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601596D RID: 88429 RVA: 0x00643F0F File Offset: 0x0064210F
	protected TsUiHotKeyLinkListener(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400B667 RID: 46695
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/UiNavigation/TsUiHotKeyLinkListener.TsUiHotKeyLinkListener_C";

	// Token: 0x0400B668 RID: 46696
	private static IntPtr _ClassPtr;

	// Token: 0x0400B669 RID: 46697
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B66A RID: 46698
	private static int __PropertyOffset_ActorList;

	// Token: 0x0400B66B RID: 46699
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<AActor> _ActorList;
}
