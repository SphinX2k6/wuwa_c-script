using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002DF9 RID: 11769
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataForce.LogicDataForce_C")]
public class LogicDataForce : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170021E7 RID: 8679
	// (get) Token: 0x06018B8B RID: 101259 RVA: 0x0065864C File Offset: 0x0065684C
	// (set) Token: 0x06018B8C RID: 101260 RVA: 0x0065865C File Offset: 0x0065685C
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

	// Token: 0x170021E8 RID: 8680
	// (get) Token: 0x06018B8D RID: 101261 RVA: 0x0065866D File Offset: 0x0065686D
	// (set) Token: 0x06018B8E RID: 101262 RVA: 0x0065867D File Offset: 0x0065687D
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

	// Token: 0x170021E9 RID: 8681
	// (get) Token: 0x06018B8F RID: 101263 RVA: 0x0065868E File Offset: 0x0065688E
	// (set) Token: 0x06018B90 RID: 101264 RVA: 0x0065869E File Offset: 0x0065689E
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

	// Token: 0x170021EA RID: 8682
	// (get) Token: 0x06018B91 RID: 101265 RVA: 0x006586AF File Offset: 0x006568AF
	// (set) Token: 0x06018B92 RID: 101266 RVA: 0x006586BF File Offset: 0x006568BF
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

	// Token: 0x170021EB RID: 8683
	// (get) Token: 0x06018B93 RID: 101267 RVA: 0x006586D0 File Offset: 0x006568D0
	// (set) Token: 0x06018B94 RID: 101268 RVA: 0x006586E0 File Offset: 0x006568E0
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

	// Token: 0x170021EC RID: 8684
	// (get) Token: 0x06018B95 RID: 101269 RVA: 0x006586F1 File Offset: 0x006568F1
	// (set) Token: 0x06018B96 RID: 101270 RVA: 0x00658701 File Offset: 0x00656901
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

	// Token: 0x170021ED RID: 8685
	// (get) Token: 0x06018B97 RID: 101271 RVA: 0x00658712 File Offset: 0x00656912
	// (set) Token: 0x06018B98 RID: 101272 RVA: 0x00658722 File Offset: 0x00656922
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

	// Token: 0x170021EE RID: 8686
	// (get) Token: 0x06018B99 RID: 101273 RVA: 0x00658733 File Offset: 0x00656933
	// (set) Token: 0x06018B9A RID: 101274 RVA: 0x00658743 File Offset: 0x00656943
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

	// Token: 0x170021EF RID: 8687
	// (get) Token: 0x06018B9B RID: 101275 RVA: 0x00658754 File Offset: 0x00656954
	// (set) Token: 0x06018B9C RID: 101276 RVA: 0x00658764 File Offset: 0x00656964
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

	// Token: 0x170021F0 RID: 8688
	// (get) Token: 0x06018B9D RID: 101277 RVA: 0x00658775 File Offset: 0x00656975
	// (set) Token: 0x06018B9E RID: 101278 RVA: 0x00658785 File Offset: 0x00656985
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

	// Token: 0x170021F1 RID: 8689
	// (get) Token: 0x06018B9F RID: 101279 RVA: 0x00658796 File Offset: 0x00656996
	// (set) Token: 0x06018BA0 RID: 101280 RVA: 0x006587AA File Offset: 0x006569AA
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

	// Token: 0x170021F2 RID: 8690
	// (get) Token: 0x06018BA1 RID: 101281 RVA: 0x006587BF File Offset: 0x006569BF
	// (set) Token: 0x06018BA2 RID: 101282 RVA: 0x006587CF File Offset: 0x006569CF
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

	// Token: 0x170021F3 RID: 8691
	// (get) Token: 0x06018BA3 RID: 101283 RVA: 0x006587E0 File Offset: 0x006569E0
	// (set) Token: 0x06018BA4 RID: 101284 RVA: 0x006587F0 File Offset: 0x006569F0
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

	// Token: 0x170021F4 RID: 8692
	// (get) Token: 0x06018BA5 RID: 101285 RVA: 0x00658804 File Offset: 0x00656A04
	// (set) Token: 0x06018BA6 RID: 101286 RVA: 0x0065883D File Offset: 0x00656A3D
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

	// Token: 0x170021F5 RID: 8693
	// (get) Token: 0x06018BA7 RID: 101287 RVA: 0x00658865 File Offset: 0x00656A65
	// (set) Token: 0x06018BA8 RID: 101288 RVA: 0x00658875 File Offset: 0x00656A75
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

	// Token: 0x170021F6 RID: 8694
	// (get) Token: 0x06018BA9 RID: 101289 RVA: 0x00658886 File Offset: 0x00656A86
	// (set) Token: 0x06018BAA RID: 101290 RVA: 0x00658896 File Offset: 0x00656A96
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

	// Token: 0x170021F7 RID: 8695
	// (get) Token: 0x06018BAB RID: 101291 RVA: 0x006588A7 File Offset: 0x00656AA7
	// (set) Token: 0x06018BAC RID: 101292 RVA: 0x006588B7 File Offset: 0x00656AB7
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

	// Token: 0x06018BAD RID: 101293 RVA: 0x006588C8 File Offset: 0x00656AC8
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataForce._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataForce.LogicDataForce_C");
		}
		return LogicDataForce._ClassPtr;
	}

	// Token: 0x06018BAE RID: 101294 RVA: 0x006588EC File Offset: 0x00656AEC
	public LogicDataForce() : this(BuiltinUtils.AllocNativeUObject(LogicDataForce.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06018BAF RID: 101295 RVA: 0x00658914 File Offset: 0x00656B14
	public LogicDataForce(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataForce.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06018BB0 RID: 101296 RVA: 0x00658947 File Offset: 0x00656B47
	protected LogicDataForce(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400B86A RID: 47210
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataForce.LogicDataForce_C";

	// Token: 0x0400B86B RID: 47211
	private static IntPtr _ClassPtr;

	// Token: 0x0400B86C RID: 47212
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B86D RID: 47213
	private static int __PropertyOffset_ForceBase;

	// Token: 0x0400B86E RID: 47214
	private static int __PropertyOffset_ForceDampingRatio;

	// Token: 0x0400B86F RID: 47215
	private static int __PropertyOffset_InnerRadius;

	// Token: 0x0400B870 RID: 47216
	private static int __PropertyOffset_OuterRadius;

	// Token: 0x0400B871 RID: 47217
	private static int __PropertyOffset_LimitWeight;

	// Token: 0x0400B872 RID: 47218
	private static int __PropertyOffset_ConstantForce;

	// Token: 0x0400B873 RID: 47219
	private static int __PropertyOffset_TowardsBullet;

	// Token: 0x0400B874 RID: 47220
	private static int __PropertyOffset_HaveTopArea;

	// Token: 0x0400B875 RID: 47221
	private static int __PropertyOffset_TopAreaHeight;

	// Token: 0x0400B876 RID: 47222
	private static int __PropertyOffset_ContinueTime;

	// Token: 0x0400B877 RID: 47223
	private static int __PropertyOffset_ContinueTimeCurve;

	// Token: 0x0400B878 RID: 47224
	private static int __PropertyOffset_IsLaunching;

	// Token: 0x0400B879 RID: 47225
	private static int __PropertyOffset_ForceHorizontal;

	// Token: 0x0400B87A RID: 47226
	private static int __PropertyOffset_WorkHaveTag;

	// Token: 0x0400B87B RID: 47227
	[Nullable(2)]
	private FGameplayTagContainer _WorkHaveTag;

	// Token: 0x0400B87C RID: 47228
	private static int __PropertyOffset_IsResetOnLast;

	// Token: 0x0400B87D RID: 47229
	private static int __PropertyOffset_Group;

	// Token: 0x0400B87E RID: 47230
	private static int __PropertyOffset_ImmuneStopDuration;
}
