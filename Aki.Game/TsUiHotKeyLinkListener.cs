using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002CCE RID: 11470
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Module/UiNavigation/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/UiNavigation/TsUiHotKeyLinkListener.TsUiHotKeyLinkListener_C")]
public class TsUiHotKeyLinkListener : ULGUIBehaviour, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002071 RID: 8305
	// (get) Token: 0x060180EC RID: 98540 RVA: 0x0061E298 File Offset: 0x0061C498
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

	// Token: 0x060180ED RID: 98541 RVA: 0x0061E2D1 File Offset: 0x0061C4D1
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsUiHotKeyLinkListener._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/UiNavigation/TsUiHotKeyLinkListener.TsUiHotKeyLinkListener_C");
		}
		return TsUiHotKeyLinkListener._ClassPtr;
	}

	// Token: 0x060180EE RID: 98542 RVA: 0x0061E2F8 File Offset: 0x0061C4F8
	public TsUiHotKeyLinkListener() : this(BuiltinUtils.AllocNativeUObject(TsUiHotKeyLinkListener.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060180EF RID: 98543 RVA: 0x0061E320 File Offset: 0x0061C520
	public TsUiHotKeyLinkListener(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiHotKeyLinkListener.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060180F0 RID: 98544 RVA: 0x0061E353 File Offset: 0x0061C553
	protected TsUiHotKeyLinkListener(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400B2FB RID: 45819
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/UiNavigation/TsUiHotKeyLinkListener.TsUiHotKeyLinkListener_C";

	// Token: 0x0400B2FC RID: 45820
	private static IntPtr _ClassPtr;

	// Token: 0x0400B2FD RID: 45821
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B2FE RID: 45822
	private static int __PropertyOffset_ActorList;

	// Token: 0x0400B2FF RID: 45823
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<AActor> _ActorList;
}
