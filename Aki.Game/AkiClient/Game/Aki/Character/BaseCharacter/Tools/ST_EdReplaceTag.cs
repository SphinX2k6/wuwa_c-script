using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Tools
{
	// Token: 0x02004348 RID: 17224
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Tools/ST_EdReplaceTag.ST_EdReplaceTag")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class ST_EdReplaceTag : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602CAA0 RID: 182944 RVA: 0x00A25458 File Offset: 0x00A23658
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (ST_EdReplaceTag._ScriptStructPtr != 0) ? ST_EdReplaceTag._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Tools/ST_EdReplaceTag.ST_EdReplaceTag", ref ST_EdReplaceTag._ScriptStructPtr);
		}

		// Token: 0x17007062 RID: 28770
		// (get) Token: 0x0602CAA1 RID: 182945 RVA: 0x00A2547C File Offset: 0x00A2367C
		// (set) Token: 0x0602CAA2 RID: 182946 RVA: 0x00A25490 File Offset: 0x00A23690
		public unsafe FGameplayTag OldTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ST_EdReplaceTag.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ST_EdReplaceTag.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17007063 RID: 28771
		// (get) Token: 0x0602CAA3 RID: 182947 RVA: 0x00A254A5 File Offset: 0x00A236A5
		// (set) Token: 0x0602CAA4 RID: 182948 RVA: 0x00A254B9 File Offset: 0x00A236B9
		public unsafe FGameplayTag NewTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ST_EdReplaceTag.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ST_EdReplaceTag.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x0602CAA5 RID: 182949 RVA: 0x00A254CE File Offset: 0x00A236CE
		public ST_EdReplaceTag()
		{
		}

		// Token: 0x0602CAA6 RID: 182950 RVA: 0x00A254D6 File Offset: 0x00A236D6
		public ST_EdReplaceTag(FGameplayTag OldTag, FGameplayTag NewTag)
		{
			this.OldTag = OldTag;
			this.NewTag = NewTag;
		}

		// Token: 0x0602CAA7 RID: 182951 RVA: 0x00A254EC File Offset: 0x00A236EC
		protected override IntPtr GetUStructPtr()
		{
			return ST_EdReplaceTag.StaticStruct();
		}

		// Token: 0x0602CAA8 RID: 182952 RVA: 0x00A254F8 File Offset: 0x00A236F8
		[NullableContext(2)]
		public ST_EdReplaceTag(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602CAA9 RID: 182953 RVA: 0x00A25502 File Offset: 0x00A23702
		public ST_EdReplaceTag(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602CAAA RID: 182954 RVA: 0x00A2550D File Offset: 0x00A2370D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new ST_EdReplaceTag(Pointer, false, true);
		}

		// Token: 0x0602CAAB RID: 182955 RVA: 0x00A25517 File Offset: 0x00A23717
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new ST_EdReplaceTag(Pointer, MemoryOwner);
		}

		// Token: 0x040178C0 RID: 96448
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Tools/ST_EdReplaceTag.ST_EdReplaceTag";

		// Token: 0x040178C1 RID: 96449
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040178C2 RID: 96450
		internal static int __PropertyOffset_0;

		// Token: 0x040178C3 RID: 96451
		internal static int __PropertyOffset_1;
	}
}
