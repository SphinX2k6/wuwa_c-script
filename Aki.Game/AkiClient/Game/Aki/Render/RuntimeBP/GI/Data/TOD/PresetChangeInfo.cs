using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.Data.TOD
{
	// Token: 0x02003D6C RID: 15724
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/Data/TOD/PresetChangeInfo.PresetChangeInfo")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class PresetChangeInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602696B RID: 158059 RVA: 0x00979055 File Offset: 0x00977255
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (PresetChangeInfo._ScriptStructPtr != 0) ? PresetChangeInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/GI/Data/TOD/PresetChangeInfo.PresetChangeInfo", ref PresetChangeInfo._ScriptStructPtr);
		}

		// Token: 0x1700531C RID: 21276
		// (get) Token: 0x0602696C RID: 158060 RVA: 0x00979079 File Offset: 0x00977279
		// (set) Token: 0x0602696D RID: 158061 RVA: 0x00979089 File Offset: 0x00977289
		public unsafe bool ReloadSelected
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PresetChangeInfo.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PresetChangeInfo.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700531D RID: 21277
		// (get) Token: 0x0602696E RID: 158062 RVA: 0x0097909A File Offset: 0x0097729A
		// (set) Token: 0x0602696F RID: 158063 RVA: 0x009790AA File Offset: 0x009772AA
		public unsafe int Selected
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PresetChangeInfo.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PresetChangeInfo.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700531E RID: 21278
		// (get) Token: 0x06026970 RID: 158064 RVA: 0x009790BB File Offset: 0x009772BB
		// (set) Token: 0x06026971 RID: 158065 RVA: 0x009790CF File Offset: 0x009772CF
		public unsafe TEnumAsByte<PresetSelection> Mode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PresetChangeInfo.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PresetChangeInfo.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x1700531F RID: 21279
		// (get) Token: 0x06026972 RID: 158066 RVA: 0x009790E4 File Offset: 0x009772E4
		// (set) Token: 0x06026973 RID: 158067 RVA: 0x009790F4 File Offset: 0x009772F4
		public unsafe float TransitionDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PresetChangeInfo.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PresetChangeInfo.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005320 RID: 21280
		// (get) Token: 0x06026974 RID: 158068 RVA: 0x00979105 File Offset: 0x00977305
		// (set) Token: 0x06026975 RID: 158069 RVA: 0x00979119 File Offset: 0x00977319
		public unsafe TEnumAsByte<EEasingFunc> TransitionFunc
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PresetChangeInfo.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PresetChangeInfo.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005321 RID: 21281
		// (get) Token: 0x06026976 RID: 158070 RVA: 0x0097912E File Offset: 0x0097732E
		// (set) Token: 0x06026977 RID: 158071 RVA: 0x0097913E File Offset: 0x0097733E
		public unsafe float ChangeAfterTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PresetChangeInfo.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PresetChangeInfo.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x06026978 RID: 158072 RVA: 0x0097914F File Offset: 0x0097734F
		public PresetChangeInfo()
		{
		}

		// Token: 0x06026979 RID: 158073 RVA: 0x00979157 File Offset: 0x00977357
		public PresetChangeInfo(bool ReloadSelected, int Selected, TEnumAsByte<PresetSelection> Mode, float TransitionDuration, TEnumAsByte<EEasingFunc> TransitionFunc, float ChangeAfterTime)
		{
			this.ReloadSelected = ReloadSelected;
			this.Selected = Selected;
			this.Mode = Mode;
			this.TransitionDuration = TransitionDuration;
			this.TransitionFunc = TransitionFunc;
			this.ChangeAfterTime = ChangeAfterTime;
		}

		// Token: 0x0602697A RID: 158074 RVA: 0x0097918C File Offset: 0x0097738C
		protected override IntPtr GetUStructPtr()
		{
			return PresetChangeInfo.StaticStruct();
		}

		// Token: 0x0602697B RID: 158075 RVA: 0x00979198 File Offset: 0x00977398
		[NullableContext(2)]
		public PresetChangeInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602697C RID: 158076 RVA: 0x009791A2 File Offset: 0x009773A2
		public PresetChangeInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602697D RID: 158077 RVA: 0x009791AD File Offset: 0x009773AD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new PresetChangeInfo(Pointer, false, true);
		}

		// Token: 0x0602697E RID: 158078 RVA: 0x009791B7 File Offset: 0x009773B7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new PresetChangeInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04013646 RID: 79430
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/Data/TOD/PresetChangeInfo.PresetChangeInfo";

		// Token: 0x04013647 RID: 79431
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013648 RID: 79432
		internal static int __PropertyOffset_0;

		// Token: 0x04013649 RID: 79433
		internal static int __PropertyOffset_1;

		// Token: 0x0401364A RID: 79434
		internal static int __PropertyOffset_2;

		// Token: 0x0401364B RID: 79435
		internal static int __PropertyOffset_3;

		// Token: 0x0401364C RID: 79436
		internal static int __PropertyOffset_4;

		// Token: 0x0401364D RID: 79437
		internal static int __PropertyOffset_5;
	}
}
