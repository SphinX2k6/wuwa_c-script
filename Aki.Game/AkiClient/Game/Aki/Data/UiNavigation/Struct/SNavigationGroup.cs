using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.UiNavigation.Struct
{
	// Token: 0x02003160 RID: 12640
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/UiNavigation/Struct/SNavigationGroup.SNavigationGroup")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 179)]
	public class SNavigationGroup : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F215 RID: 127509 RVA: 0x00927230 File Offset: 0x00925430
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SNavigationGroup._ScriptStructPtr != 0) ? SNavigationGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/UiNavigation/Struct/SNavigationGroup.SNavigationGroup", ref SNavigationGroup._ScriptStructPtr);
		}

		// Token: 0x1700378A RID: 14218
		// (get) Token: 0x0601F216 RID: 127510 RVA: 0x00927254 File Offset: 0x00925454
		// (set) Token: 0x0601F217 RID: 127511 RVA: 0x00927268 File Offset: 0x00925468
		public unsafe string GroupName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SNavigationGroup.__PropertyOffset_GroupName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SNavigationGroup.__PropertyOffset_GroupName)), value);
			}
		}

		// Token: 0x1700378B RID: 14219
		// (get) Token: 0x0601F218 RID: 127512 RVA: 0x0092727D File Offset: 0x0092547D
		// (set) Token: 0x0601F219 RID: 127513 RVA: 0x0092728D File Offset: 0x0092548D
		public unsafe int GroupType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_GroupType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_GroupType) = value;
			}
		}

		// Token: 0x1700378C RID: 14220
		// (get) Token: 0x0601F21A RID: 127514 RVA: 0x0092729E File Offset: 0x0092549E
		// (set) Token: 0x0601F21B RID: 127515 RVA: 0x009272B2 File Offset: 0x009254B2
		public unsafe string PrevGroupName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SNavigationGroup.__PropertyOffset_PrevGroupName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SNavigationGroup.__PropertyOffset_PrevGroupName)), value);
			}
		}

		// Token: 0x1700378D RID: 14221
		// (get) Token: 0x0601F21C RID: 127516 RVA: 0x009272C7 File Offset: 0x009254C7
		// (set) Token: 0x0601F21D RID: 127517 RVA: 0x009272DB File Offset: 0x009254DB
		public unsafe string NextGroupName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SNavigationGroup.__PropertyOffset_NextGroupName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SNavigationGroup.__PropertyOffset_NextGroupName)), value);
			}
		}

		// Token: 0x1700378E RID: 14222
		// (get) Token: 0x0601F21E RID: 127518 RVA: 0x009272F0 File Offset: 0x009254F0
		// (set) Token: 0x0601F21F RID: 127519 RVA: 0x00927304 File Offset: 0x00925504
		public unsafe string InsideGroupName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SNavigationGroup.__PropertyOffset_InsideGroupName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SNavigationGroup.__PropertyOffset_InsideGroupName)), value);
			}
		}

		// Token: 0x1700378F RID: 14223
		// (get) Token: 0x0601F220 RID: 127520 RVA: 0x0092731C File Offset: 0x0092551C
		// (set) Token: 0x0601F221 RID: 127521 RVA: 0x0092735F File Offset: 0x0092555F
		public TArray<string> ExtraInsideGroupNameList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._ExtraInsideGroupNameList) == null)
				{
					result = (this._ExtraInsideGroupNameList = new TArray<string>(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_ExtraInsideGroupNameList, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ExtraInsideGroupNameList.CopyAssign(value);
			}
		}

		// Token: 0x17003790 RID: 14224
		// (get) Token: 0x0601F222 RID: 127522 RVA: 0x00927370 File Offset: 0x00925570
		// (set) Token: 0x0601F223 RID: 127523 RVA: 0x009273B3 File Offset: 0x009255B3
		public TMap<string, string> GroupNameMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, string> result;
				if ((result = this._GroupNameMap) == null)
				{
					result = (this._GroupNameMap = new TMap<string, string>(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_GroupNameMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.GroupNameMap.CopyAssign(value);
			}
		}

		// Token: 0x17003791 RID: 14225
		// (get) Token: 0x0601F224 RID: 127524 RVA: 0x009273C1 File Offset: 0x009255C1
		// (set) Token: 0x0601F225 RID: 127525 RVA: 0x009273D1 File Offset: 0x009255D1
		public unsafe UINavigationWrapMode HorizontalWrapMode
		{
			get
			{
				return (UINavigationWrapMode)(*(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_HorizontalWrapMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_HorizontalWrapMode) = (byte)value;
			}
		}

		// Token: 0x17003792 RID: 14226
		// (get) Token: 0x0601F226 RID: 127526 RVA: 0x009273E2 File Offset: 0x009255E2
		// (set) Token: 0x0601F227 RID: 127527 RVA: 0x009273F2 File Offset: 0x009255F2
		public unsafe UINavigationPriorityMode HorizontalPriorityMode
		{
			get
			{
				return (UINavigationPriorityMode)(*(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_HorizontalPriorityMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_HorizontalPriorityMode) = (byte)value;
			}
		}

		// Token: 0x17003793 RID: 14227
		// (get) Token: 0x0601F228 RID: 127528 RVA: 0x00927403 File Offset: 0x00925603
		// (set) Token: 0x0601F229 RID: 127529 RVA: 0x00927413 File Offset: 0x00925613
		public unsafe UINavigationWrapMode VerticalWrapMode
		{
			get
			{
				return (UINavigationWrapMode)(*(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_VerticalWrapMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_VerticalWrapMode) = (byte)value;
			}
		}

		// Token: 0x17003794 RID: 14228
		// (get) Token: 0x0601F22A RID: 127530 RVA: 0x00927424 File Offset: 0x00925624
		// (set) Token: 0x0601F22B RID: 127531 RVA: 0x00927434 File Offset: 0x00925634
		public unsafe UINavigationPriorityMode VerticalPriorityMode
		{
			get
			{
				return (UINavigationPriorityMode)(*(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_VerticalPriorityMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_VerticalPriorityMode) = (byte)value;
			}
		}

		// Token: 0x17003795 RID: 14229
		// (get) Token: 0x0601F22C RID: 127532 RVA: 0x00927445 File Offset: 0x00925645
		// (set) Token: 0x0601F22D RID: 127533 RVA: 0x00927455 File Offset: 0x00925655
		public unsafe bool SelectableMemory
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_SelectableMemory) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_SelectableMemory) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003796 RID: 14230
		// (get) Token: 0x0601F22E RID: 127534 RVA: 0x00927466 File Offset: 0x00925666
		// (set) Token: 0x0601F22F RID: 127535 RVA: 0x00927476 File Offset: 0x00925676
		public unsafe bool AllowNavigationInSelfDynamic
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_AllowNavigationInSelfDynamic) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_AllowNavigationInSelfDynamic) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003797 RID: 14231
		// (get) Token: 0x0601F230 RID: 127536 RVA: 0x00927487 File Offset: 0x00925687
		// (set) Token: 0x0601F231 RID: 127537 RVA: 0x00927497 File Offset: 0x00925697
		public unsafe bool RefreshNavigation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_RefreshNavigation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_RefreshNavigation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003798 RID: 14232
		// (get) Token: 0x0601F232 RID: 127538 RVA: 0x009274A8 File Offset: 0x009256A8
		// (set) Token: 0x0601F233 RID: 127539 RVA: 0x009274B8 File Offset: 0x009256B8
		public unsafe bool SuitableListenerByNoDynamic
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_SuitableListenerByNoDynamic) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_SuitableListenerByNoDynamic) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003799 RID: 14233
		// (get) Token: 0x0601F234 RID: 127540 RVA: 0x009274C9 File Offset: 0x009256C9
		// (set) Token: 0x0601F235 RID: 127541 RVA: 0x009274D9 File Offset: 0x009256D9
		public unsafe bool SlideToLeftOrTop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_SlideToLeftOrTop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_SlideToLeftOrTop) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700379A RID: 14234
		// (get) Token: 0x0601F236 RID: 127542 RVA: 0x009274EA File Offset: 0x009256EA
		// (set) Token: 0x0601F237 RID: 127543 RVA: 0x009274FA File Offset: 0x009256FA
		public unsafe bool SlideToRightOrDown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_SlideToRightOrDown) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_SlideToRightOrDown) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700379B RID: 14235
		// (get) Token: 0x0601F238 RID: 127544 RVA: 0x0092750B File Offset: 0x0092570B
		// (set) Token: 0x0601F239 RID: 127545 RVA: 0x0092751B File Offset: 0x0092571B
		public unsafe bool WaitScrollAnimation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_WaitScrollAnimation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationGroup.__PropertyOffset_WaitScrollAnimation) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601F23A RID: 127546 RVA: 0x0092752C File Offset: 0x0092572C
		public SNavigationGroup()
		{
		}

		// Token: 0x0601F23B RID: 127547 RVA: 0x00927534 File Offset: 0x00925734
		protected override IntPtr GetUStructPtr()
		{
			return SNavigationGroup.StaticStruct();
		}

		// Token: 0x0601F23C RID: 127548 RVA: 0x00927540 File Offset: 0x00925740
		[NullableContext(2)]
		public SNavigationGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F23D RID: 127549 RVA: 0x0092754A File Offset: 0x0092574A
		public SNavigationGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F23E RID: 127550 RVA: 0x00927555 File Offset: 0x00925755
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SNavigationGroup(Pointer, false, true);
		}

		// Token: 0x0601F23F RID: 127551 RVA: 0x0092755F File Offset: 0x0092575F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SNavigationGroup(Pointer, MemoryOwner);
		}

		// Token: 0x04010A35 RID: 68149
		public const string __ObjectPath = "/Game/Aki/Data/UiNavigation/Struct/SNavigationGroup.SNavigationGroup";

		// Token: 0x04010A36 RID: 68150
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010A37 RID: 68151
		internal static int __PropertyOffset_GroupName;

		// Token: 0x04010A38 RID: 68152
		internal static int __PropertyOffset_GroupType;

		// Token: 0x04010A39 RID: 68153
		internal static int __PropertyOffset_PrevGroupName;

		// Token: 0x04010A3A RID: 68154
		internal static int __PropertyOffset_NextGroupName;

		// Token: 0x04010A3B RID: 68155
		internal static int __PropertyOffset_InsideGroupName;

		// Token: 0x04010A3C RID: 68156
		internal static int __PropertyOffset_ExtraInsideGroupNameList;

		// Token: 0x04010A3D RID: 68157
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ExtraInsideGroupNameList;

		// Token: 0x04010A3E RID: 68158
		internal static int __PropertyOffset_GroupNameMap;

		// Token: 0x04010A3F RID: 68159
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, string> _GroupNameMap;

		// Token: 0x04010A40 RID: 68160
		internal static int __PropertyOffset_HorizontalWrapMode;

		// Token: 0x04010A41 RID: 68161
		internal static int __PropertyOffset_HorizontalPriorityMode;

		// Token: 0x04010A42 RID: 68162
		internal static int __PropertyOffset_VerticalWrapMode;

		// Token: 0x04010A43 RID: 68163
		internal static int __PropertyOffset_VerticalPriorityMode;

		// Token: 0x04010A44 RID: 68164
		internal static int __PropertyOffset_SelectableMemory;

		// Token: 0x04010A45 RID: 68165
		internal static int __PropertyOffset_AllowNavigationInSelfDynamic;

		// Token: 0x04010A46 RID: 68166
		internal static int __PropertyOffset_RefreshNavigation;

		// Token: 0x04010A47 RID: 68167
		internal static int __PropertyOffset_SuitableListenerByNoDynamic;

		// Token: 0x04010A48 RID: 68168
		internal static int __PropertyOffset_SlideToLeftOrTop;

		// Token: 0x04010A49 RID: 68169
		internal static int __PropertyOffset_SlideToRightOrDown;

		// Token: 0x04010A4A RID: 68170
		internal static int __PropertyOffset_WaitScrollAnimation;
	}
}
