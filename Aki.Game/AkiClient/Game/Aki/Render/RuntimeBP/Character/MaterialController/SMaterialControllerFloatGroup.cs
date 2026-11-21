using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController
{
	// Token: 0x02003132 RID: 12594
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerFloatGroup.SMaterialControllerFloatGroup")]
	[UnrealStructLayout(432, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 432)]
	public class SMaterialControllerFloatGroup : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EFAE RID: 126894 RVA: 0x00922B3C File Offset: 0x00920D3C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMaterialControllerFloatGroup._ScriptStructPtr != 0) ? SMaterialControllerFloatGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerFloatGroup.SMaterialControllerFloatGroup", ref SMaterialControllerFloatGroup._ScriptStructPtr);
		}

		// Token: 0x170036C4 RID: 14020
		// (get) Token: 0x0601EFAF RID: 126895 RVA: 0x00922B60 File Offset: 0x00920D60
		// (set) Token: 0x0601EFB0 RID: 126896 RVA: 0x00922BA3 File Offset: 0x00920DA3
		public FKuroCurveFloat Start
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._Start) == null)
				{
					result = (this._Start = new FKuroCurveFloat(base.NativePtr + (IntPtr)SMaterialControllerFloatGroup.__PropertyOffset_Start, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)SMaterialControllerFloatGroup.__PropertyOffset_Start, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170036C5 RID: 14021
		// (get) Token: 0x0601EFB1 RID: 126897 RVA: 0x00922BC4 File Offset: 0x00920DC4
		// (set) Token: 0x0601EFB2 RID: 126898 RVA: 0x00922C07 File Offset: 0x00920E07
		public FKuroCurveFloat Loop
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._Loop) == null)
				{
					result = (this._Loop = new FKuroCurveFloat(base.NativePtr + (IntPtr)SMaterialControllerFloatGroup.__PropertyOffset_Loop, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)SMaterialControllerFloatGroup.__PropertyOffset_Loop, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170036C6 RID: 14022
		// (get) Token: 0x0601EFB3 RID: 126899 RVA: 0x00922C28 File Offset: 0x00920E28
		// (set) Token: 0x0601EFB4 RID: 126900 RVA: 0x00922C6B File Offset: 0x00920E6B
		public FKuroCurveFloat End
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._End) == null)
				{
					result = (this._End = new FKuroCurveFloat(base.NativePtr + (IntPtr)SMaterialControllerFloatGroup.__PropertyOffset_End, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)SMaterialControllerFloatGroup.__PropertyOffset_End, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601EFB5 RID: 126901 RVA: 0x00922C8C File Offset: 0x00920E8C
		public SMaterialControllerFloatGroup()
		{
		}

		// Token: 0x0601EFB6 RID: 126902 RVA: 0x00922C94 File Offset: 0x00920E94
		protected override IntPtr GetUStructPtr()
		{
			return SMaterialControllerFloatGroup.StaticStruct();
		}

		// Token: 0x0601EFB7 RID: 126903 RVA: 0x00922CA0 File Offset: 0x00920EA0
		[NullableContext(2)]
		public SMaterialControllerFloatGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EFB8 RID: 126904 RVA: 0x00922CAA File Offset: 0x00920EAA
		public SMaterialControllerFloatGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EFB9 RID: 126905 RVA: 0x00922CB5 File Offset: 0x00920EB5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMaterialControllerFloatGroup(Pointer, false, true);
		}

		// Token: 0x0601EFBA RID: 126906 RVA: 0x00922CBF File Offset: 0x00920EBF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMaterialControllerFloatGroup(Pointer, MemoryOwner);
		}

		// Token: 0x040107EA RID: 67562
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerFloatGroup.SMaterialControllerFloatGroup";

		// Token: 0x040107EB RID: 67563
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040107EC RID: 67564
		internal static int __PropertyOffset_Start;

		// Token: 0x040107ED RID: 67565
		[Nullable(2)]
		private FKuroCurveFloat _Start;

		// Token: 0x040107EE RID: 67566
		internal static int __PropertyOffset_Loop;

		// Token: 0x040107EF RID: 67567
		[Nullable(2)]
		private FKuroCurveFloat _Loop;

		// Token: 0x040107F0 RID: 67568
		internal static int __PropertyOffset_End;

		// Token: 0x040107F1 RID: 67569
		[Nullable(2)]
		private FKuroCurveFloat _End;
	}
}
