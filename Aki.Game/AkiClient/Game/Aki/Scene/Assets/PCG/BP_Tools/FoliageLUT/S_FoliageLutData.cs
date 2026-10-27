using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Scene.Assets.PCG.BP_Tools.FoliageLUT
{
	// Token: 0x02003A71 RID: 14961
	[NullableContext(2)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Scene/Assets/PCG/BP_Tools/FoliageLUT/S_FoliageLutData.S_FoliageLutData")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class S_FoliageLutData : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FAC4 RID: 129732 RVA: 0x008BF245 File Offset: 0x008BD445
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (S_FoliageLutData._ScriptStructPtr != 0) ? S_FoliageLutData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Scene/Assets/PCG/BP_Tools/FoliageLUT/S_FoliageLutData.S_FoliageLutData", ref S_FoliageLutData._ScriptStructPtr);
		}

		// Token: 0x17002C5C RID: 11356
		// (get) Token: 0x0601FAC5 RID: 129733 RVA: 0x008BF269 File Offset: 0x008BD469
		// (set) Token: 0x0601FAC6 RID: 129734 RVA: 0x008BF279 File Offset: 0x008BD479
		public unsafe int FoliageLutIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_FoliageLutData.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_FoliageLutData.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17002C5D RID: 11357
		// (get) Token: 0x0601FAC7 RID: 129735 RVA: 0x008BF28A File Offset: 0x008BD48A
		// (set) Token: 0x0601FAC8 RID: 129736 RVA: 0x008BF29E File Offset: 0x008BD49E
		public unsafe UObject MainWidget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + S_FoliageLutData.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + S_FoliageLutData.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002C5E RID: 11358
		// (get) Token: 0x0601FAC9 RID: 129737 RVA: 0x008BF2B3 File Offset: 0x008BD4B3
		// (set) Token: 0x0601FACA RID: 129738 RVA: 0x008BF2C7 File Offset: 0x008BD4C7
		public unsafe UTexture2DArray LutArray
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2DArray>(base.NativePtr / (IntPtr)sizeof(void*) + S_FoliageLutData.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + S_FoliageLutData.__PropertyOffset_2, value);
			}
		}

		// Token: 0x0601FACB RID: 129739 RVA: 0x008BF2DC File Offset: 0x008BD4DC
		public S_FoliageLutData()
		{
		}

		// Token: 0x0601FACC RID: 129740 RVA: 0x008BF2E4 File Offset: 0x008BD4E4
		[NullableContext(1)]
		public S_FoliageLutData(int FoliageLutIndex, UObject MainWidget, UTexture2DArray LutArray)
		{
			this.FoliageLutIndex = FoliageLutIndex;
			this.MainWidget = MainWidget;
			this.LutArray = LutArray;
		}

		// Token: 0x0601FACD RID: 129741 RVA: 0x008BF301 File Offset: 0x008BD501
		protected override IntPtr GetUStructPtr()
		{
			return S_FoliageLutData.StaticStruct();
		}

		// Token: 0x0601FACE RID: 129742 RVA: 0x008BF30D File Offset: 0x008BD50D
		public S_FoliageLutData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FACF RID: 129743 RVA: 0x008BF317 File Offset: 0x008BD517
		public S_FoliageLutData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FAD0 RID: 129744 RVA: 0x008BF322 File Offset: 0x008BD522
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new S_FoliageLutData(Pointer, false, true);
		}

		// Token: 0x0601FAD1 RID: 129745 RVA: 0x008BF32C File Offset: 0x008BD52C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new S_FoliageLutData(Pointer, MemoryOwner);
		}

		// Token: 0x0400F3FF RID: 62463
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/Assets/PCG/BP_Tools/FoliageLUT/S_FoliageLutData.S_FoliageLutData";

		// Token: 0x0400F400 RID: 62464
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F401 RID: 62465
		internal static int __PropertyOffset_0;

		// Token: 0x0400F402 RID: 62466
		internal static int __PropertyOffset_1;

		// Token: 0x0400F403 RID: 62467
		internal static int __PropertyOffset_2;
	}
}
