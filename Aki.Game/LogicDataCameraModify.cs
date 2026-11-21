using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200234F RID: 9039
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataCameraModify.LogicDataCameraModify_C")]
public class LogicDataCameraModify : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002234 RID: 8756
	// (get) Token: 0x060163FE RID: 91134 RVA: 0x0067E04C File Offset: 0x0067C24C
	// (set) Token: 0x060163FF RID: 91135 RVA: 0x0067E05C File Offset: 0x0067C25C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EBulletCameraModifyPlayer Player
	{
		get
		{
			return (EBulletCameraModifyPlayer)(*(base.NativePtr + (IntPtr)LogicDataCameraModify.__PropertyOffset_Player));
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataCameraModify.__PropertyOffset_Player) = (byte)value;
		}
	}

	// Token: 0x17002235 RID: 8757
	// (get) Token: 0x06016400 RID: 91136 RVA: 0x0067E06D File Offset: 0x0067C26D
	// (set) Token: 0x06016401 RID: 91137 RVA: 0x0067E081 File Offset: 0x0067C281
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FGameplayTag Tag
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataCameraModify.__PropertyOffset_Tag);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataCameraModify.__PropertyOffset_Tag) = value;
		}
	}

	// Token: 0x17002236 RID: 8758
	// (get) Token: 0x06016402 RID: 91138 RVA: 0x0067E096 File Offset: 0x0067C296
	// (set) Token: 0x06016403 RID: 91139 RVA: 0x0067E0A6 File Offset: 0x0067C2A6
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Duration
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataCameraModify.__PropertyOffset_Duration);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataCameraModify.__PropertyOffset_Duration) = value;
		}
	}

	// Token: 0x17002237 RID: 8759
	// (get) Token: 0x06016404 RID: 91140 RVA: 0x0067E0B7 File Offset: 0x0067C2B7
	// (set) Token: 0x06016405 RID: 91141 RVA: 0x0067E0C7 File Offset: 0x0067C2C7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float BlendIn
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataCameraModify.__PropertyOffset_BlendIn);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataCameraModify.__PropertyOffset_BlendIn) = value;
		}
	}

	// Token: 0x17002238 RID: 8760
	// (get) Token: 0x06016406 RID: 91142 RVA: 0x0067E0D8 File Offset: 0x0067C2D8
	// (set) Token: 0x06016407 RID: 91143 RVA: 0x0067E0E8 File Offset: 0x0067C2E8
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float BlendOut
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataCameraModify.__PropertyOffset_BlendOut);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataCameraModify.__PropertyOffset_BlendOut) = value;
		}
	}

	// Token: 0x17002239 RID: 8761
	// (get) Token: 0x06016408 RID: 91144 RVA: 0x0067E0F9 File Offset: 0x0067C2F9
	// (set) Token: 0x06016409 RID: 91145 RVA: 0x0067E109 File Offset: 0x0067C309
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float BlendOutInterrupt
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataCameraModify.__PropertyOffset_BlendOutInterrupt);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataCameraModify.__PropertyOffset_BlendOutInterrupt) = value;
		}
	}

	// Token: 0x1700223A RID: 8762
	// (get) Token: 0x0601640A RID: 91146 RVA: 0x0067E11C File Offset: 0x0067C31C
	// (set) Token: 0x0601640B RID: 91147 RVA: 0x0067E155 File Offset: 0x0067C355
	[UProperty(EPropertyFlags.CPF_None)]
	public SCameraModifier_Settings ModifierSettings
	{
		get
		{
			base.FastCheckIsValid();
			SCameraModifier_Settings result;
			if ((result = this._ModifierSettings) == null)
			{
				result = (this._ModifierSettings = new SCameraModifier_Settings(base.NativePtr + (IntPtr)LogicDataCameraModify.__PropertyOffset_ModifierSettings, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(SCameraModifier_Settings.StaticStruct(), base.NativePtr + (IntPtr)LogicDataCameraModify.__PropertyOffset_ModifierSettings, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x1700223B RID: 8763
	// (get) Token: 0x0601640C RID: 91148 RVA: 0x0067E17D File Offset: 0x0067C37D
	// (set) Token: 0x0601640D RID: 91149 RVA: 0x0067E18D File Offset: 0x0067C38D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe ECameraAnsEffectiveClientType ClientType
	{
		get
		{
			return (ECameraAnsEffectiveClientType)(*(base.NativePtr + (IntPtr)LogicDataCameraModify.__PropertyOffset_ClientType));
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataCameraModify.__PropertyOffset_ClientType) = (byte)value;
		}
	}

	// Token: 0x1700223C RID: 8764
	// (get) Token: 0x0601640E RID: 91150 RVA: 0x0067E19E File Offset: 0x0067C39E
	// (set) Token: 0x0601640F RID: 91151 RVA: 0x0067E1B2 File Offset: 0x0067C3B2
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string CameraAttachSocket
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)LogicDataCameraModify.__PropertyOffset_CameraAttachSocket)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)LogicDataCameraModify.__PropertyOffset_CameraAttachSocket)), value);
		}
	}

	// Token: 0x1700223D RID: 8765
	// (get) Token: 0x06016410 RID: 91152 RVA: 0x0067E1C8 File Offset: 0x0067C3C8
	// (set) Token: 0x06016411 RID: 91153 RVA: 0x0067E201 File Offset: 0x0067C401
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<SCameraModifier_Condition> Conditions
	{
		get
		{
			base.FastCheckIsValid();
			TArray<SCameraModifier_Condition> result;
			if ((result = this._Conditions) == null)
			{
				result = (this._Conditions = new TArray<SCameraModifier_Condition>(base.NativePtr + (IntPtr)LogicDataCameraModify.__PropertyOffset_Conditions, this));
			}
			return result;
		}
		set
		{
			this.Conditions.CopyAssign(value);
		}
	}

	// Token: 0x06016412 RID: 91154 RVA: 0x0067E20F File Offset: 0x0067C40F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataCameraModify._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataCameraModify.LogicDataCameraModify_C");
		}
		return LogicDataCameraModify._ClassPtr;
	}

	// Token: 0x06016413 RID: 91155 RVA: 0x0067E234 File Offset: 0x0067C434
	public LogicDataCameraModify() : this(BuiltinUtils.AllocNativeUObject(LogicDataCameraModify.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06016414 RID: 91156 RVA: 0x0067E25C File Offset: 0x0067C45C
	public LogicDataCameraModify(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataCameraModify.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06016415 RID: 91157 RVA: 0x0067E28F File Offset: 0x0067C48F
	protected LogicDataCameraModify(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400BBC7 RID: 48071
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataCameraModify.LogicDataCameraModify_C";

	// Token: 0x0400BBC8 RID: 48072
	private static IntPtr _ClassPtr;

	// Token: 0x0400BBC9 RID: 48073
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400BBCA RID: 48074
	private static int __PropertyOffset_Player;

	// Token: 0x0400BBCB RID: 48075
	private static int __PropertyOffset_Tag;

	// Token: 0x0400BBCC RID: 48076
	private static int __PropertyOffset_Duration;

	// Token: 0x0400BBCD RID: 48077
	private static int __PropertyOffset_BlendIn;

	// Token: 0x0400BBCE RID: 48078
	private static int __PropertyOffset_BlendOut;

	// Token: 0x0400BBCF RID: 48079
	private static int __PropertyOffset_BlendOutInterrupt;

	// Token: 0x0400BBD0 RID: 48080
	private static int __PropertyOffset_ModifierSettings;

	// Token: 0x0400BBD1 RID: 48081
	[Nullable(2)]
	private SCameraModifier_Settings _ModifierSettings;

	// Token: 0x0400BBD2 RID: 48082
	private static int __PropertyOffset_ClientType;

	// Token: 0x0400BBD3 RID: 48083
	private static int __PropertyOffset_CameraAttachSocket;

	// Token: 0x0400BBD4 RID: 48084
	private static int __PropertyOffset_Conditions;

	// Token: 0x0400BBD5 RID: 48085
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<SCameraModifier_Condition> _Conditions;
}
