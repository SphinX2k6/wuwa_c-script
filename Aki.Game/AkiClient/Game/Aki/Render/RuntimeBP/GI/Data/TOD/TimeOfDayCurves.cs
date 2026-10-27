using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.Data.TOD
{
	// Token: 0x02003D6E RID: 15726
	[NullableContext(2)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/Data/TOD/TimeOfDayCurves.TimeOfDayCurves")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class TimeOfDayCurves : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602697F RID: 158079 RVA: 0x009791C0 File Offset: 0x009773C0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (TimeOfDayCurves._ScriptStructPtr != 0) ? TimeOfDayCurves._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/GI/Data/TOD/TimeOfDayCurves.TimeOfDayCurves", ref TimeOfDayCurves._ScriptStructPtr);
		}

		// Token: 0x17005322 RID: 21282
		// (get) Token: 0x06026980 RID: 158080 RVA: 0x009791E4 File Offset: 0x009773E4
		// (set) Token: 0x06026981 RID: 158081 RVA: 0x009791F8 File Offset: 0x009773F8
		public unsafe UCurveLinearColor SkyUpperColorCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveLinearColor>(base.NativePtr / (IntPtr)sizeof(void*) + TimeOfDayCurves.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TimeOfDayCurves.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17005323 RID: 21283
		// (get) Token: 0x06026982 RID: 158082 RVA: 0x0097920D File Offset: 0x0097740D
		// (set) Token: 0x06026983 RID: 158083 RVA: 0x00979221 File Offset: 0x00977421
		public unsafe UCurveLinearColor SkyLowerColorCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveLinearColor>(base.NativePtr / (IntPtr)sizeof(void*) + TimeOfDayCurves.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TimeOfDayCurves.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005324 RID: 21284
		// (get) Token: 0x06026984 RID: 158084 RVA: 0x00979236 File Offset: 0x00977436
		// (set) Token: 0x06026985 RID: 158085 RVA: 0x0097924A File Offset: 0x0097744A
		public unsafe UCurveLinearColor CloudsUpperColorCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveLinearColor>(base.NativePtr / (IntPtr)sizeof(void*) + TimeOfDayCurves.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TimeOfDayCurves.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005325 RID: 21285
		// (get) Token: 0x06026986 RID: 158086 RVA: 0x0097925F File Offset: 0x0097745F
		// (set) Token: 0x06026987 RID: 158087 RVA: 0x00979273 File Offset: 0x00977473
		public unsafe UCurveLinearColor CloudsLowerColorCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveLinearColor>(base.NativePtr / (IntPtr)sizeof(void*) + TimeOfDayCurves.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TimeOfDayCurves.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005326 RID: 21286
		// (get) Token: 0x06026988 RID: 158088 RVA: 0x00979288 File Offset: 0x00977488
		// (set) Token: 0x06026989 RID: 158089 RVA: 0x0097929C File Offset: 0x0097749C
		public unsafe UCurveLinearColor CloudsBackgroundCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveLinearColor>(base.NativePtr / (IntPtr)sizeof(void*) + TimeOfDayCurves.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TimeOfDayCurves.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17005327 RID: 21287
		// (get) Token: 0x0602698A RID: 158090 RVA: 0x009792B1 File Offset: 0x009774B1
		// (set) Token: 0x0602698B RID: 158091 RVA: 0x009792C5 File Offset: 0x009774C5
		public unsafe UCurveLinearColor CloudsSecondaryColorCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveLinearColor>(base.NativePtr / (IntPtr)sizeof(void*) + TimeOfDayCurves.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TimeOfDayCurves.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17005328 RID: 21288
		// (get) Token: 0x0602698C RID: 158092 RVA: 0x009792DA File Offset: 0x009774DA
		// (set) Token: 0x0602698D RID: 158093 RVA: 0x009792EE File Offset: 0x009774EE
		public unsafe UCurveLinearColor SunColorCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveLinearColor>(base.NativePtr / (IntPtr)sizeof(void*) + TimeOfDayCurves.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TimeOfDayCurves.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17005329 RID: 21289
		// (get) Token: 0x0602698E RID: 158094 RVA: 0x00979303 File Offset: 0x00977503
		// (set) Token: 0x0602698F RID: 158095 RVA: 0x00979317 File Offset: 0x00977517
		public unsafe UCurveLinearColor MoonColorCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveLinearColor>(base.NativePtr / (IntPtr)sizeof(void*) + TimeOfDayCurves.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TimeOfDayCurves.__PropertyOffset_7, value);
			}
		}

		// Token: 0x1700532A RID: 21290
		// (get) Token: 0x06026990 RID: 158096 RVA: 0x0097932C File Offset: 0x0097752C
		// (set) Token: 0x06026991 RID: 158097 RVA: 0x00979340 File Offset: 0x00977540
		public unsafe UCurveLinearColor StarsColorCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveLinearColor>(base.NativePtr / (IntPtr)sizeof(void*) + TimeOfDayCurves.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TimeOfDayCurves.__PropertyOffset_8, value);
			}
		}

		// Token: 0x1700532B RID: 21291
		// (get) Token: 0x06026992 RID: 158098 RVA: 0x00979355 File Offset: 0x00977555
		// (set) Token: 0x06026993 RID: 158099 RVA: 0x00979369 File Offset: 0x00977569
		public unsafe UCurveLinearColor FogColorCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveLinearColor>(base.NativePtr / (IntPtr)sizeof(void*) + TimeOfDayCurves.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TimeOfDayCurves.__PropertyOffset_9, value);
			}
		}

		// Token: 0x06026994 RID: 158100 RVA: 0x0097937E File Offset: 0x0097757E
		public TimeOfDayCurves()
		{
		}

		// Token: 0x06026995 RID: 158101 RVA: 0x00979388 File Offset: 0x00977588
		[NullableContext(1)]
		public TimeOfDayCurves(UCurveLinearColor SkyUpperColorCurve, UCurveLinearColor SkyLowerColorCurve, UCurveLinearColor CloudsUpperColorCurve, UCurveLinearColor CloudsLowerColorCurve, UCurveLinearColor CloudsBackgroundCurve, UCurveLinearColor CloudsSecondaryColorCurve, UCurveLinearColor SunColorCurve, UCurveLinearColor MoonColorCurve, UCurveLinearColor StarsColorCurve, UCurveLinearColor FogColorCurve)
		{
			this.SkyUpperColorCurve = SkyUpperColorCurve;
			this.SkyLowerColorCurve = SkyLowerColorCurve;
			this.CloudsUpperColorCurve = CloudsUpperColorCurve;
			this.CloudsLowerColorCurve = CloudsLowerColorCurve;
			this.CloudsBackgroundCurve = CloudsBackgroundCurve;
			this.CloudsSecondaryColorCurve = CloudsSecondaryColorCurve;
			this.SunColorCurve = SunColorCurve;
			this.MoonColorCurve = MoonColorCurve;
			this.StarsColorCurve = StarsColorCurve;
			this.FogColorCurve = FogColorCurve;
		}

		// Token: 0x06026996 RID: 158102 RVA: 0x009793E8 File Offset: 0x009775E8
		protected override IntPtr GetUStructPtr()
		{
			return TimeOfDayCurves.StaticStruct();
		}

		// Token: 0x06026997 RID: 158103 RVA: 0x009793F4 File Offset: 0x009775F4
		public TimeOfDayCurves(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026998 RID: 158104 RVA: 0x009793FE File Offset: 0x009775FE
		public TimeOfDayCurves(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026999 RID: 158105 RVA: 0x00979409 File Offset: 0x00977609
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new TimeOfDayCurves(Pointer, false, true);
		}

		// Token: 0x0602699A RID: 158106 RVA: 0x00979413 File Offset: 0x00977613
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new TimeOfDayCurves(Pointer, MemoryOwner);
		}

		// Token: 0x04013655 RID: 79445
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/Data/TOD/TimeOfDayCurves.TimeOfDayCurves";

		// Token: 0x04013656 RID: 79446
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013657 RID: 79447
		internal static int __PropertyOffset_0;

		// Token: 0x04013658 RID: 79448
		internal static int __PropertyOffset_1;

		// Token: 0x04013659 RID: 79449
		internal static int __PropertyOffset_2;

		// Token: 0x0401365A RID: 79450
		internal static int __PropertyOffset_3;

		// Token: 0x0401365B RID: 79451
		internal static int __PropertyOffset_4;

		// Token: 0x0401365C RID: 79452
		internal static int __PropertyOffset_5;

		// Token: 0x0401365D RID: 79453
		internal static int __PropertyOffset_6;

		// Token: 0x0401365E RID: 79454
		internal static int __PropertyOffset_7;

		// Token: 0x0401365F RID: 79455
		internal static int __PropertyOffset_8;

		// Token: 0x04013660 RID: 79456
		internal static int __PropertyOffset_9;
	}
}
