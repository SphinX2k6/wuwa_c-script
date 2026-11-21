using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003336 RID: 13110
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SAudioEventProbabilityCooldownInfo.SAudioEventProbabilityCooldownInfo")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SAudioEventProbabilityCooldownInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060211E6 RID: 135654 RVA: 0x00959B53 File Offset: 0x00957D53
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SAudioEventProbabilityCooldownInfo._ScriptStructPtr != 0) ? SAudioEventProbabilityCooldownInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SAudioEventProbabilityCooldownInfo.SAudioEventProbabilityCooldownInfo", ref SAudioEventProbabilityCooldownInfo._ScriptStructPtr);
		}

		// Token: 0x170042AE RID: 17070
		// (get) Token: 0x060211E7 RID: 135655 RVA: 0x00959B77 File Offset: 0x00957D77
		// (set) Token: 0x060211E8 RID: 135656 RVA: 0x00959B87 File Offset: 0x00957D87
		public unsafe float DefaultProbability
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAudioEventProbabilityCooldownInfo.__PropertyOffset_DefaultProbability);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAudioEventProbabilityCooldownInfo.__PropertyOffset_DefaultProbability) = value;
			}
		}

		// Token: 0x170042AF RID: 17071
		// (get) Token: 0x060211E9 RID: 135657 RVA: 0x00959B98 File Offset: 0x00957D98
		// (set) Token: 0x060211EA RID: 135658 RVA: 0x00959BA8 File Offset: 0x00957DA8
		public unsafe int DefaultCooldownTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAudioEventProbabilityCooldownInfo.__PropertyOffset_DefaultCooldownTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAudioEventProbabilityCooldownInfo.__PropertyOffset_DefaultCooldownTime) = value;
			}
		}

		// Token: 0x170042B0 RID: 17072
		// (get) Token: 0x060211EB RID: 135659 RVA: 0x00959BBC File Offset: 0x00957DBC
		// (set) Token: 0x060211EC RID: 135660 RVA: 0x00959BFF File Offset: 0x00957DFF
		public TArray<SGameplayTagProbabilityCooldownInfo> TagProbability
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SGameplayTagProbabilityCooldownInfo> result;
				if ((result = this._TagProbability) == null)
				{
					result = (this._TagProbability = new TArray<SGameplayTagProbabilityCooldownInfo>(base.NativePtr + (IntPtr)SAudioEventProbabilityCooldownInfo.__PropertyOffset_TagProbability, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TagProbability.CopyAssign(value);
			}
		}

		// Token: 0x060211ED RID: 135661 RVA: 0x00959C0D File Offset: 0x00957E0D
		public SAudioEventProbabilityCooldownInfo()
		{
		}

		// Token: 0x060211EE RID: 135662 RVA: 0x00959C15 File Offset: 0x00957E15
		protected override IntPtr GetUStructPtr()
		{
			return SAudioEventProbabilityCooldownInfo.StaticStruct();
		}

		// Token: 0x060211EF RID: 135663 RVA: 0x00959C21 File Offset: 0x00957E21
		[NullableContext(2)]
		public SAudioEventProbabilityCooldownInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060211F0 RID: 135664 RVA: 0x00959C2B File Offset: 0x00957E2B
		public SAudioEventProbabilityCooldownInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060211F1 RID: 135665 RVA: 0x00959C36 File Offset: 0x00957E36
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SAudioEventProbabilityCooldownInfo(Pointer, false, true);
		}

		// Token: 0x060211F2 RID: 135666 RVA: 0x00959C40 File Offset: 0x00957E40
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SAudioEventProbabilityCooldownInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040121C1 RID: 74177
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SAudioEventProbabilityCooldownInfo.SAudioEventProbabilityCooldownInfo";

		// Token: 0x040121C2 RID: 74178
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040121C3 RID: 74179
		internal static int __PropertyOffset_DefaultProbability;

		// Token: 0x040121C4 RID: 74180
		internal static int __PropertyOffset_DefaultCooldownTime;

		// Token: 0x040121C5 RID: 74181
		internal static int __PropertyOffset_TagProbability;

		// Token: 0x040121C6 RID: 74182
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SGameplayTagProbabilityCooldownInfo> _TagProbability;
	}
}
