using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002DF4 RID: 11764
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataCameraModify.LogicDataCameraModify_C")]
public class LogicDataCameraModify : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170021D0 RID: 8656
	// (get) Token: 0x06018B49 RID: 101193 RVA: 0x00657FC8 File Offset: 0x006561C8
	// (set) Token: 0x06018B4A RID: 101194 RVA: 0x00657FD8 File Offset: 0x006561D8
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

	// Token: 0x170021D1 RID: 8657
	// (get) Token: 0x06018B4B RID: 101195 RVA: 0x00657FE9 File Offset: 0x006561E9
	// (set) Token: 0x06018B4C RID: 101196 RVA: 0x00657FFD File Offset: 0x006561FD
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

	// Token: 0x170021D2 RID: 8658
	// (get) Token: 0x06018B4D RID: 101197 RVA: 0x00658012 File Offset: 0x00656212
	// (set) Token: 0x06018B4E RID: 101198 RVA: 0x00658022 File Offset: 0x00656222
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

	// Token: 0x170021D3 RID: 8659
	// (get) Token: 0x06018B4F RID: 101199 RVA: 0x00658033 File Offset: 0x00656233
	// (set) Token: 0x06018B50 RID: 101200 RVA: 0x00658043 File Offset: 0x00656243
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

	// Token: 0x170021D4 RID: 8660
	// (get) Token: 0x06018B51 RID: 101201 RVA: 0x00658054 File Offset: 0x00656254
	// (set) Token: 0x06018B52 RID: 101202 RVA: 0x00658064 File Offset: 0x00656264
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

	// Token: 0x170021D5 RID: 8661
	// (get) Token: 0x06018B53 RID: 101203 RVA: 0x00658075 File Offset: 0x00656275
	// (set) Token: 0x06018B54 RID: 101204 RVA: 0x00658085 File Offset: 0x00656285
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

	// Token: 0x170021D6 RID: 8662
	// (get) Token: 0x06018B55 RID: 101205 RVA: 0x00658098 File Offset: 0x00656298
	// (set) Token: 0x06018B56 RID: 101206 RVA: 0x006580D1 File Offset: 0x006562D1
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

	// Token: 0x170021D7 RID: 8663
	// (get) Token: 0x06018B57 RID: 101207 RVA: 0x006580F9 File Offset: 0x006562F9
	// (set) Token: 0x06018B58 RID: 101208 RVA: 0x00658109 File Offset: 0x00656309
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

	// Token: 0x170021D8 RID: 8664
	// (get) Token: 0x06018B59 RID: 101209 RVA: 0x0065811A File Offset: 0x0065631A
	// (set) Token: 0x06018B5A RID: 101210 RVA: 0x0065812E File Offset: 0x0065632E
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

	// Token: 0x170021D9 RID: 8665
	// (get) Token: 0x06018B5B RID: 101211 RVA: 0x00658144 File Offset: 0x00656344
	// (set) Token: 0x06018B5C RID: 101212 RVA: 0x0065817D File Offset: 0x0065637D
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

	// Token: 0x06018B5D RID: 101213 RVA: 0x0065818B File Offset: 0x0065638B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataCameraModify._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataCameraModify.LogicDataCameraModify_C");
		}
		return LogicDataCameraModify._ClassPtr;
	}

	// Token: 0x06018B5E RID: 101214 RVA: 0x006581B0 File Offset: 0x006563B0
	public LogicDataCameraModify() : this(BuiltinUtils.AllocNativeUObject(LogicDataCameraModify.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06018B5F RID: 101215 RVA: 0x006581D8 File Offset: 0x006563D8
	public LogicDataCameraModify(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataCameraModify.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06018B60 RID: 101216 RVA: 0x0065820B File Offset: 0x0065640B
	protected LogicDataCameraModify(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400B841 RID: 47169
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataCameraModify.LogicDataCameraModify_C";

	// Token: 0x0400B842 RID: 47170
	private static IntPtr _ClassPtr;

	// Token: 0x0400B843 RID: 47171
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B844 RID: 47172
	private static int __PropertyOffset_Player;

	// Token: 0x0400B845 RID: 47173
	private static int __PropertyOffset_Tag;

	// Token: 0x0400B846 RID: 47174
	private static int __PropertyOffset_Duration;

	// Token: 0x0400B847 RID: 47175
	private static int __PropertyOffset_BlendIn;

	// Token: 0x0400B848 RID: 47176
	private static int __PropertyOffset_BlendOut;

	// Token: 0x0400B849 RID: 47177
	private static int __PropertyOffset_BlendOutInterrupt;

	// Token: 0x0400B84A RID: 47178
	private static int __PropertyOffset_ModifierSettings;

	// Token: 0x0400B84B RID: 47179
	[Nullable(2)]
	private SCameraModifier_Settings _ModifierSettings;

	// Token: 0x0400B84C RID: 47180
	private static int __PropertyOffset_ClientType;

	// Token: 0x0400B84D RID: 47181
	private static int __PropertyOffset_CameraAttachSocket;

	// Token: 0x0400B84E RID: 47182
	private static int __PropertyOffset_Conditions;

	// Token: 0x0400B84F RID: 47183
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<SCameraModifier_Condition> _Conditions;
}
