using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.Structure
{
	// Token: 0x020040AF RID: 16559
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/Structure/SCharacterFootprint.SCharacterFootprint")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class SCharacterFootprint : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602AC5E RID: 175198 RVA: 0x009EB0F7 File Offset: 0x009E92F7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCharacterFootprint._ScriptStructPtr != 0) ? SCharacterFootprint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/Role/Common/Data/Structure/SCharacterFootprint.SCharacterFootprint", ref SCharacterFootprint._ScriptStructPtr);
		}

		// Token: 0x17006976 RID: 26998
		// (get) Token: 0x0602AC5F RID: 175199 RVA: 0x009EB11B File Offset: 0x009E931B
		// (set) Token: 0x0602AC60 RID: 175200 RVA: 0x009EB12F File Offset: 0x009E932F
		public unsafe FGameplayTag Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterFootprint.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterFootprint.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006977 RID: 26999
		// (get) Token: 0x0602AC61 RID: 175201 RVA: 0x009EB144 File Offset: 0x009E9344
		// (set) Token: 0x0602AC62 RID: 175202 RVA: 0x009EB154 File Offset: 0x009E9354
		public unsafe int SortID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterFootprint.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterFootprint.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006978 RID: 27000
		// (get) Token: 0x0602AC63 RID: 175203 RVA: 0x009EB165 File Offset: 0x009E9365
		// (set) Token: 0x0602AC64 RID: 175204 RVA: 0x009EB175 File Offset: 0x009E9375
		public unsafe int OverrideGlobalFootEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterFootprint.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterFootprint.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006979 RID: 27001
		// (get) Token: 0x0602AC65 RID: 175205 RVA: 0x009EB186 File Offset: 0x009E9386
		// (set) Token: 0x0602AC66 RID: 175206 RVA: 0x009EB196 File Offset: 0x009E9396
		public unsafe int OverrideOtherCharacterFootEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterFootprint.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterFootprint.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x1700697A RID: 27002
		// (get) Token: 0x0602AC67 RID: 175207 RVA: 0x009EB1A7 File Offset: 0x009E93A7
		// (set) Token: 0x0602AC68 RID: 175208 RVA: 0x009EB1C6 File Offset: 0x009E93C6
		public TSoftObjectPtr<UEffectModelBase> Effect
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)SCharacterFootprint.__PropertyOffset_4, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCharacterFootprint.__PropertyOffset_4, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0602AC69 RID: 175209 RVA: 0x009EB1EB File Offset: 0x009E93EB
		public SCharacterFootprint()
		{
		}

		// Token: 0x0602AC6A RID: 175210 RVA: 0x009EB1F3 File Offset: 0x009E93F3
		public SCharacterFootprint(FGameplayTag Tag, int SortID, int OverrideGlobalFootEffect, int OverrideOtherCharacterFootEffect, TSoftObjectPtr<UEffectModelBase> Effect)
		{
			this.Tag = Tag;
			this.SortID = SortID;
			this.OverrideGlobalFootEffect = OverrideGlobalFootEffect;
			this.OverrideOtherCharacterFootEffect = OverrideOtherCharacterFootEffect;
			this.Effect = Effect;
		}

		// Token: 0x0602AC6B RID: 175211 RVA: 0x009EB220 File Offset: 0x009E9420
		protected override IntPtr GetUStructPtr()
		{
			return SCharacterFootprint.StaticStruct();
		}

		// Token: 0x0602AC6C RID: 175212 RVA: 0x009EB22C File Offset: 0x009E942C
		[NullableContext(2)]
		public SCharacterFootprint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602AC6D RID: 175213 RVA: 0x009EB236 File Offset: 0x009E9436
		public SCharacterFootprint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602AC6E RID: 175214 RVA: 0x009EB241 File Offset: 0x009E9441
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCharacterFootprint(Pointer, false, true);
		}

		// Token: 0x0602AC6F RID: 175215 RVA: 0x009EB24B File Offset: 0x009E944B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCharacterFootprint(Pointer, MemoryOwner);
		}

		// Token: 0x04016244 RID: 90692
		public const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/Structure/SCharacterFootprint.SCharacterFootprint";

		// Token: 0x04016245 RID: 90693
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04016246 RID: 90694
		internal static int __PropertyOffset_0;

		// Token: 0x04016247 RID: 90695
		internal static int __PropertyOffset_1;

		// Token: 0x04016248 RID: 90696
		internal static int __PropertyOffset_2;

		// Token: 0x04016249 RID: 90697
		internal static int __PropertyOffset_3;

		// Token: 0x0401624A RID: 90698
		internal static int __PropertyOffset_4;
	}
}
