using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.PathLine.PathLine_Bullet;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200235F RID: 9055
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataSplineMovement.LogicDataSplineMovement_C")]
public class LogicDataSplineMovement : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002296 RID: 8854
	// (get) Token: 0x06016502 RID: 91394 RVA: 0x0067FB88 File Offset: 0x0067DD88
	// (set) Token: 0x06016503 RID: 91395 RVA: 0x0067FB98 File Offset: 0x0067DD98
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Duration
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_Duration);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_Duration) = value;
		}
	}

	// Token: 0x17002297 RID: 8855
	// (get) Token: 0x06016504 RID: 91396 RVA: 0x0067FBAC File Offset: 0x0067DDAC
	// (set) Token: 0x06016505 RID: 91397 RVA: 0x0067FBE5 File Offset: 0x0067DDE5
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<UEffectModelBase> EffectOnReach
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<UEffectModelBase> result;
			if ((result = this._EffectOnReach) == null)
			{
				result = (this._EffectOnReach = new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_EffectOnReach, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_EffectOnReach, 1);
		}
	}

	// Token: 0x17002298 RID: 8856
	// (get) Token: 0x06016506 RID: 91398 RVA: 0x0067FC0A File Offset: 0x0067DE0A
	// (set) Token: 0x06016507 RID: 91399 RVA: 0x0067FC1A File Offset: 0x0067DE1A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsDestroyReach
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_IsDestroyReach) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_IsDestroyReach) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002299 RID: 8857
	// (get) Token: 0x06016508 RID: 91400 RVA: 0x0067FC2B File Offset: 0x0067DE2B
	// (set) Token: 0x06016509 RID: 91401 RVA: 0x0067FC3B File Offset: 0x0067DE3B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsForwardTangent
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_IsForwardTangent) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_IsForwardTangent) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700229A RID: 8858
	// (get) Token: 0x0601650A RID: 91402 RVA: 0x0067FC4C File Offset: 0x0067DE4C
	// (set) Token: 0x0601650B RID: 91403 RVA: 0x0067FC5C File Offset: 0x0067DE5C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsSummonOnReach
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_IsSummonOnReach) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_IsSummonOnReach) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700229B RID: 8859
	// (get) Token: 0x0601650C RID: 91404 RVA: 0x0067FC6D File Offset: 0x0067DE6D
	// (set) Token: 0x0601650D RID: 91405 RVA: 0x0067FC7D File Offset: 0x0067DE7D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Rotate
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_Rotate);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_Rotate) = value;
		}
	}

	// Token: 0x1700229C RID: 8860
	// (get) Token: 0x0601650E RID: 91406 RVA: 0x0067FC8E File Offset: 0x0067DE8E
	// (set) Token: 0x0601650F RID: 91407 RVA: 0x0067FC9E File Offset: 0x0067DE9E
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Length
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_Length);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_Length) = value;
		}
	}

	// Token: 0x1700229D RID: 8861
	// (get) Token: 0x06016510 RID: 91408 RVA: 0x0067FCAF File Offset: 0x0067DEAF
	// (set) Token: 0x06016511 RID: 91409 RVA: 0x0067FCBF File Offset: 0x0067DEBF
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Height
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_Height);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_Height) = value;
		}
	}

	// Token: 0x1700229E RID: 8862
	// (get) Token: 0x06016512 RID: 91410 RVA: 0x0067FCD0 File Offset: 0x0067DED0
	// (set) Token: 0x06016513 RID: 91411 RVA: 0x0067FCE0 File Offset: 0x0067DEE0
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MaxSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_MaxSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_MaxSpeed) = value;
		}
	}

	// Token: 0x1700229F RID: 8863
	// (get) Token: 0x06016514 RID: 91412 RVA: 0x0067FCF1 File Offset: 0x0067DEF1
	// (set) Token: 0x06016515 RID: 91413 RVA: 0x0067FD01 File Offset: 0x0067DF01
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MinSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_MinSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_MinSpeed) = value;
		}
	}

	// Token: 0x170022A0 RID: 8864
	// (get) Token: 0x06016516 RID: 91414 RVA: 0x0067FD12 File Offset: 0x0067DF12
	// (set) Token: 0x06016517 RID: 91415 RVA: 0x0067FD22 File Offset: 0x0067DF22
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float SelfHeight
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_SelfHeight);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_SelfHeight) = value;
		}
	}

	// Token: 0x170022A1 RID: 8865
	// (get) Token: 0x06016518 RID: 91416 RVA: 0x0067FD33 File Offset: 0x0067DF33
	// (set) Token: 0x06016519 RID: 91417 RVA: 0x0067FD43 File Offset: 0x0067DF43
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float SelfLength
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_SelfLength);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_SelfLength) = value;
		}
	}

	// Token: 0x170022A2 RID: 8866
	// (get) Token: 0x0601651A RID: 91418 RVA: 0x0067FD54 File Offset: 0x0067DF54
	// (set) Token: 0x0601651B RID: 91419 RVA: 0x0067FD64 File Offset: 0x0067DF64
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float SelfRotate
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_SelfRotate);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_SelfRotate) = value;
		}
	}

	// Token: 0x170022A3 RID: 8867
	// (get) Token: 0x0601651C RID: 91420 RVA: 0x0067FD78 File Offset: 0x0067DF78
	// (set) Token: 0x0601651D RID: 91421 RVA: 0x0067FDB1 File Offset: 0x0067DFB1
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftClassPtr<BP_BasePathLineBullet_C> SplineTrace
	{
		get
		{
			base.FastCheckIsValid();
			TSoftClassPtr<BP_BasePathLineBullet_C> result;
			if ((result = this._SplineTrace) == null)
			{
				result = (this._SplineTrace = new TSoftClassPtr<BP_BasePathLineBullet_C>(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_SplineTrace, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_SplineTrace, 1);
		}
	}

	// Token: 0x170022A4 RID: 8868
	// (get) Token: 0x0601651E RID: 91422 RVA: 0x0067FDD6 File Offset: 0x0067DFD6
	// (set) Token: 0x0601651F RID: 91423 RVA: 0x0067FDE6 File Offset: 0x0067DFE6
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool UseTargetLocation
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_UseTargetLocation) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_UseTargetLocation) = (value ? 1 : 0);
		}
	}

	// Token: 0x06016520 RID: 91424 RVA: 0x0067FDF7 File Offset: 0x0067DFF7
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataSplineMovement._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataSplineMovement.LogicDataSplineMovement_C");
		}
		return LogicDataSplineMovement._ClassPtr;
	}

	// Token: 0x06016521 RID: 91425 RVA: 0x0067FE1C File Offset: 0x0067E01C
	public LogicDataSplineMovement() : this(BuiltinUtils.AllocNativeUObject(LogicDataSplineMovement.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06016522 RID: 91426 RVA: 0x0067FE44 File Offset: 0x0067E044
	public LogicDataSplineMovement(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataSplineMovement.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06016523 RID: 91427 RVA: 0x0067FE77 File Offset: 0x0067E077
	protected LogicDataSplineMovement(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400BC73 RID: 48243
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataSplineMovement.LogicDataSplineMovement_C";

	// Token: 0x0400BC74 RID: 48244
	private static IntPtr _ClassPtr;

	// Token: 0x0400BC75 RID: 48245
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400BC76 RID: 48246
	private static int __PropertyOffset_Duration;

	// Token: 0x0400BC77 RID: 48247
	private static int __PropertyOffset_EffectOnReach;

	// Token: 0x0400BC78 RID: 48248
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UEffectModelBase> _EffectOnReach;

	// Token: 0x0400BC79 RID: 48249
	private static int __PropertyOffset_IsDestroyReach;

	// Token: 0x0400BC7A RID: 48250
	private static int __PropertyOffset_IsForwardTangent;

	// Token: 0x0400BC7B RID: 48251
	private static int __PropertyOffset_IsSummonOnReach;

	// Token: 0x0400BC7C RID: 48252
	private static int __PropertyOffset_Rotate;

	// Token: 0x0400BC7D RID: 48253
	private static int __PropertyOffset_Length;

	// Token: 0x0400BC7E RID: 48254
	private static int __PropertyOffset_Height;

	// Token: 0x0400BC7F RID: 48255
	private static int __PropertyOffset_MaxSpeed;

	// Token: 0x0400BC80 RID: 48256
	private static int __PropertyOffset_MinSpeed;

	// Token: 0x0400BC81 RID: 48257
	private static int __PropertyOffset_SelfHeight;

	// Token: 0x0400BC82 RID: 48258
	private static int __PropertyOffset_SelfLength;

	// Token: 0x0400BC83 RID: 48259
	private static int __PropertyOffset_SelfRotate;

	// Token: 0x0400BC84 RID: 48260
	private static int __PropertyOffset_SplineTrace;

	// Token: 0x0400BC85 RID: 48261
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftClassPtr<BP_BasePathLineBullet_C> _SplineTrace;

	// Token: 0x0400BC86 RID: 48262
	private static int __PropertyOffset_UseTargetLocation;
}
