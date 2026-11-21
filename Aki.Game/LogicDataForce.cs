using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002354 RID: 9044
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataForce.LogicDataForce_C")]
public class LogicDataForce : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700224B RID: 8779
	// (get) Token: 0x06016440 RID: 91200 RVA: 0x0067E6D0 File Offset: 0x0067C8D0
	// (set) Token: 0x06016441 RID: 91201 RVA: 0x0067E6E0 File Offset: 0x0067C8E0
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float ForceBase
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataForce.__PropertyOffset_ForceBase);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataForce.__PropertyOffset_ForceBase) = value;
		}
	}

	// Token: 0x1700224C RID: 8780
	// (get) Token: 0x06016442 RID: 91202 RVA: 0x0067E6F1 File Offset: 0x0067C8F1
	// (set) Token: 0x06016443 RID: 91203 RVA: 0x0067E701 File Offset: 0x0067C901
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float ForceDampingRatio
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataForce.__PropertyOffset_ForceDampingRatio);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataForce.__PropertyOffset_ForceDampingRatio) = value;
		}
	}

	// Token: 0x1700224D RID: 8781
	// (get) Token: 0x06016444 RID: 91204 RVA: 0x0067E712 File Offset: 0x0067C912
	// (set) Token: 0x06016445 RID: 91205 RVA: 0x0067E722 File Offset: 0x0067C922
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float InnerRadius
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataForce.__PropertyOffset_InnerRadius);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataForce.__PropertyOffset_InnerRadius) = value;
		}
	}

	// Token: 0x1700224E RID: 8782
	// (get) Token: 0x06016446 RID: 91206 RVA: 0x0067E733 File Offset: 0x0067C933
	// (set) Token: 0x06016447 RID: 91207 RVA: 0x0067E743 File Offset: 0x0067C943
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float OuterRadius
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataForce.__PropertyOffset_OuterRadius);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataForce.__PropertyOffset_OuterRadius) = value;
		}
	}

	// Token: 0x1700224F RID: 8783
	// (get) Token: 0x06016448 RID: 91208 RVA: 0x0067E754 File Offset: 0x0067C954
	// (set) Token: 0x06016449 RID: 91209 RVA: 0x0067E764 File Offset: 0x0067C964
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int LimitWeight
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataForce.__PropertyOffset_LimitWeight);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataForce.__PropertyOffset_LimitWeight) = value;
		}
	}

	// Token: 0x17002250 RID: 8784
	// (get) Token: 0x0601644A RID: 91210 RVA: 0x0067E775 File Offset: 0x0067C975
	// (set) Token: 0x0601644B RID: 91211 RVA: 0x0067E785 File Offset: 0x0067C985
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool ConstantForce
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataForce.__PropertyOffset_ConstantForce) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataForce.__PropertyOffset_ConstantForce) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002251 RID: 8785
	// (get) Token: 0x0601644C RID: 91212 RVA: 0x0067E796 File Offset: 0x0067C996
	// (set) Token: 0x0601644D RID: 91213 RVA: 0x0067E7A6 File Offset: 0x0067C9A6
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool TowardsBullet
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataForce.__PropertyOffset_TowardsBullet) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataForce.__PropertyOffset_TowardsBullet) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002252 RID: 8786
	// (get) Token: 0x0601644E RID: 91214 RVA: 0x0067E7B7 File Offset: 0x0067C9B7
	// (set) Token: 0x0601644F RID: 91215 RVA: 0x0067E7C7 File Offset: 0x0067C9C7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool HaveTopArea
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataForce.__PropertyOffset_HaveTopArea) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataForce.__PropertyOffset_HaveTopArea) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002253 RID: 8787
	// (get) Token: 0x06016450 RID: 91216 RVA: 0x0067E7D8 File Offset: 0x0067C9D8
	// (set) Token: 0x06016451 RID: 91217 RVA: 0x0067E7E8 File Offset: 0x0067C9E8
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float TopAreaHeight
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataForce.__PropertyOffset_TopAreaHeight);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataForce.__PropertyOffset_TopAreaHeight) = value;
		}
	}

	// Token: 0x17002254 RID: 8788
	// (get) Token: 0x06016452 RID: 91218 RVA: 0x0067E7F9 File Offset: 0x0067C9F9
	// (set) Token: 0x06016453 RID: 91219 RVA: 0x0067E809 File Offset: 0x0067CA09
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float ContinueTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataForce.__PropertyOffset_ContinueTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataForce.__PropertyOffset_ContinueTime) = value;
		}
	}

	// Token: 0x17002255 RID: 8789
	// (get) Token: 0x06016454 RID: 91220 RVA: 0x0067E81A File Offset: 0x0067CA1A
	// (set) Token: 0x06016455 RID: 91221 RVA: 0x0067E82E File Offset: 0x0067CA2E
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UCurveFloat ContinueTimeCurve
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + LogicDataForce.__PropertyOffset_ContinueTimeCurve);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + LogicDataForce.__PropertyOffset_ContinueTimeCurve, value);
		}
	}

	// Token: 0x17002256 RID: 8790
	// (get) Token: 0x06016456 RID: 91222 RVA: 0x0067E843 File Offset: 0x0067CA43
	// (set) Token: 0x06016457 RID: 91223 RVA: 0x0067E853 File Offset: 0x0067CA53
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsLaunching
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataForce.__PropertyOffset_IsLaunching) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataForce.__PropertyOffset_IsLaunching) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002257 RID: 8791
	// (get) Token: 0x06016458 RID: 91224 RVA: 0x0067E864 File Offset: 0x0067CA64
	// (set) Token: 0x06016459 RID: 91225 RVA: 0x0067E874 File Offset: 0x0067CA74
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool ForceHorizontal
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataForce.__PropertyOffset_ForceHorizontal) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataForce.__PropertyOffset_ForceHorizontal) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002258 RID: 8792
	// (get) Token: 0x0601645A RID: 91226 RVA: 0x0067E888 File Offset: 0x0067CA88
	// (set) Token: 0x0601645B RID: 91227 RVA: 0x0067E8C1 File Offset: 0x0067CAC1
	[UProperty(EPropertyFlags.CPF_None)]
	public FGameplayTagContainer WorkHaveTag
	{
		get
		{
			base.FastCheckIsValid();
			FGameplayTagContainer result;
			if ((result = this._WorkHaveTag) == null)
			{
				result = (this._WorkHaveTag = new FGameplayTagContainer(base.NativePtr + (IntPtr)LogicDataForce.__PropertyOffset_WorkHaveTag, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)LogicDataForce.__PropertyOffset_WorkHaveTag, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17002259 RID: 8793
	// (get) Token: 0x0601645C RID: 91228 RVA: 0x0067E8E9 File Offset: 0x0067CAE9
	// (set) Token: 0x0601645D RID: 91229 RVA: 0x0067E8F9 File Offset: 0x0067CAF9
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsResetOnLast
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataForce.__PropertyOffset_IsResetOnLast) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataForce.__PropertyOffset_IsResetOnLast) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700225A RID: 8794
	// (get) Token: 0x0601645E RID: 91230 RVA: 0x0067E90A File Offset: 0x0067CB0A
	// (set) Token: 0x0601645F RID: 91231 RVA: 0x0067E91A File Offset: 0x0067CB1A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int Group
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataForce.__PropertyOffset_Group);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataForce.__PropertyOffset_Group) = value;
		}
	}

	// Token: 0x1700225B RID: 8795
	// (get) Token: 0x06016460 RID: 91232 RVA: 0x0067E92B File Offset: 0x0067CB2B
	// (set) Token: 0x06016461 RID: 91233 RVA: 0x0067E93B File Offset: 0x0067CB3B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float ImmuneStopDuration
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataForce.__PropertyOffset_ImmuneStopDuration);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataForce.__PropertyOffset_ImmuneStopDuration) = value;
		}
	}

	// Token: 0x06016462 RID: 91234 RVA: 0x0067E94C File Offset: 0x0067CB4C
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataForce._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataForce.LogicDataForce_C");
		}
		return LogicDataForce._ClassPtr;
	}

	// Token: 0x06016463 RID: 91235 RVA: 0x0067E970 File Offset: 0x0067CB70
	public LogicDataForce() : this(BuiltinUtils.AllocNativeUObject(LogicDataForce.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06016464 RID: 91236 RVA: 0x0067E998 File Offset: 0x0067CB98
	public LogicDataForce(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataForce.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06016465 RID: 91237 RVA: 0x0067E9CB File Offset: 0x0067CBCB
	protected LogicDataForce(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400BBF0 RID: 48112
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataForce.LogicDataForce_C";

	// Token: 0x0400BBF1 RID: 48113
	private static IntPtr _ClassPtr;

	// Token: 0x0400BBF2 RID: 48114
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400BBF3 RID: 48115
	private static int __PropertyOffset_ForceBase;

	// Token: 0x0400BBF4 RID: 48116
	private static int __PropertyOffset_ForceDampingRatio;

	// Token: 0x0400BBF5 RID: 48117
	private static int __PropertyOffset_InnerRadius;

	// Token: 0x0400BBF6 RID: 48118
	private static int __PropertyOffset_OuterRadius;

	// Token: 0x0400BBF7 RID: 48119
	private static int __PropertyOffset_LimitWeight;

	// Token: 0x0400BBF8 RID: 48120
	private static int __PropertyOffset_ConstantForce;

	// Token: 0x0400BBF9 RID: 48121
	private static int __PropertyOffset_TowardsBullet;

	// Token: 0x0400BBFA RID: 48122
	private static int __PropertyOffset_HaveTopArea;

	// Token: 0x0400BBFB RID: 48123
	private static int __PropertyOffset_TopAreaHeight;

	// Token: 0x0400BBFC RID: 48124
	private static int __PropertyOffset_ContinueTime;

	// Token: 0x0400BBFD RID: 48125
	private static int __PropertyOffset_ContinueTimeCurve;

	// Token: 0x0400BBFE RID: 48126
	private static int __PropertyOffset_IsLaunching;

	// Token: 0x0400BBFF RID: 48127
	private static int __PropertyOffset_ForceHorizontal;

	// Token: 0x0400BC00 RID: 48128
	private static int __PropertyOffset_WorkHaveTag;

	// Token: 0x0400BC01 RID: 48129
	[Nullable(2)]
	private FGameplayTagContainer _WorkHaveTag;

	// Token: 0x0400BC02 RID: 48130
	private static int __PropertyOffset_IsResetOnLast;

	// Token: 0x0400BC03 RID: 48131
	private static int __PropertyOffset_Group;

	// Token: 0x0400BC04 RID: 48132
	private static int __PropertyOffset_ImmuneStopDuration;
}
