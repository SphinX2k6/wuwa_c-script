using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController
{
	// Token: 0x02003130 RID: 12592
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerColorGroup.SMaterialControllerColorGroup")]
	[UnrealStructLayout(1632, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1632)]
	public class SMaterialControllerColorGroup : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EF96 RID: 126870 RVA: 0x009228C0 File Offset: 0x00920AC0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMaterialControllerColorGroup._ScriptStructPtr != 0) ? SMaterialControllerColorGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerColorGroup.SMaterialControllerColorGroup", ref SMaterialControllerColorGroup._ScriptStructPtr);
		}

		// Token: 0x170036BF RID: 14015
		// (get) Token: 0x0601EF97 RID: 126871 RVA: 0x009228E4 File Offset: 0x00920AE4
		// (set) Token: 0x0601EF98 RID: 126872 RVA: 0x00922927 File Offset: 0x00920B27
		public FKuroCurveLinearColor Start
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._Start) == null)
				{
					result = (this._Start = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)SMaterialControllerColorGroup.__PropertyOffset_Start, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)SMaterialControllerColorGroup.__PropertyOffset_Start, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170036C0 RID: 14016
		// (get) Token: 0x0601EF99 RID: 126873 RVA: 0x00922948 File Offset: 0x00920B48
		// (set) Token: 0x0601EF9A RID: 126874 RVA: 0x0092298B File Offset: 0x00920B8B
		public FKuroCurveLinearColor Loop
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._Loop) == null)
				{
					result = (this._Loop = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)SMaterialControllerColorGroup.__PropertyOffset_Loop, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)SMaterialControllerColorGroup.__PropertyOffset_Loop, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170036C1 RID: 14017
		// (get) Token: 0x0601EF9B RID: 126875 RVA: 0x009229AC File Offset: 0x00920BAC
		// (set) Token: 0x0601EF9C RID: 126876 RVA: 0x009229EF File Offset: 0x00920BEF
		public FKuroCurveLinearColor End
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._End) == null)
				{
					result = (this._End = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)SMaterialControllerColorGroup.__PropertyOffset_End, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)SMaterialControllerColorGroup.__PropertyOffset_End, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601EF9D RID: 126877 RVA: 0x00922A10 File Offset: 0x00920C10
		public SMaterialControllerColorGroup()
		{
		}

		// Token: 0x0601EF9E RID: 126878 RVA: 0x00922A18 File Offset: 0x00920C18
		protected override IntPtr GetUStructPtr()
		{
			return SMaterialControllerColorGroup.StaticStruct();
		}

		// Token: 0x0601EF9F RID: 126879 RVA: 0x00922A24 File Offset: 0x00920C24
		[NullableContext(2)]
		public SMaterialControllerColorGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EFA0 RID: 126880 RVA: 0x00922A2E File Offset: 0x00920C2E
		public SMaterialControllerColorGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EFA1 RID: 126881 RVA: 0x00922A39 File Offset: 0x00920C39
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMaterialControllerColorGroup(Pointer, false, true);
		}

		// Token: 0x0601EFA2 RID: 126882 RVA: 0x00922A43 File Offset: 0x00920C43
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMaterialControllerColorGroup(Pointer, MemoryOwner);
		}

		// Token: 0x040107DD RID: 67549
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerColorGroup.SMaterialControllerColorGroup";

		// Token: 0x040107DE RID: 67550
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040107DF RID: 67551
		internal static int __PropertyOffset_Start;

		// Token: 0x040107E0 RID: 67552
		[Nullable(2)]
		private FKuroCurveLinearColor _Start;

		// Token: 0x040107E1 RID: 67553
		internal static int __PropertyOffset_Loop;

		// Token: 0x040107E2 RID: 67554
		[Nullable(2)]
		private FKuroCurveLinearColor _Loop;

		// Token: 0x040107E3 RID: 67555
		internal static int __PropertyOffset_End;

		// Token: 0x040107E4 RID: 67556
		[Nullable(2)]
		private FKuroCurveLinearColor _End;
	}
}
