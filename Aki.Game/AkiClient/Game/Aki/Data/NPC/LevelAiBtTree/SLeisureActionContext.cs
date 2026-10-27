using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.NPC.LevelAiBtTree
{
	// Token: 0x02003EF3 RID: 16115
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/NPC/LevelAiBtTree/SLeisureActionContext.SLeisureActionContext")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class SLeisureActionContext : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028CE2 RID: 167138 RVA: 0x009B50F3 File Offset: 0x009B32F3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SLeisureActionContext._ScriptStructPtr != 0) ? SLeisureActionContext._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/NPC/LevelAiBtTree/SLeisureActionContext.SLeisureActionContext", ref SLeisureActionContext._ScriptStructPtr);
		}

		// Token: 0x17005FAF RID: 24495
		// (get) Token: 0x06028CE3 RID: 167139 RVA: 0x009B5117 File Offset: 0x009B3317
		// (set) Token: 0x06028CE4 RID: 167140 RVA: 0x009B5127 File Offset: 0x009B3327
		public unsafe int Type
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLeisureActionContext.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLeisureActionContext.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005FB0 RID: 24496
		// (get) Token: 0x06028CE5 RID: 167141 RVA: 0x009B5138 File Offset: 0x009B3338
		// (set) Token: 0x06028CE6 RID: 167142 RVA: 0x009B5148 File Offset: 0x009B3348
		public unsafe int TargetEntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLeisureActionContext.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLeisureActionContext.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005FB1 RID: 24497
		// (get) Token: 0x06028CE7 RID: 167143 RVA: 0x009B5159 File Offset: 0x009B3359
		// (set) Token: 0x06028CE8 RID: 167144 RVA: 0x009B5169 File Offset: 0x009B3369
		public unsafe bool UsedBySwitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLeisureActionContext.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLeisureActionContext.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005FB2 RID: 24498
		// (get) Token: 0x06028CE9 RID: 167145 RVA: 0x009B517A File Offset: 0x009B337A
		// (set) Token: 0x06028CEA RID: 167146 RVA: 0x009B518E File Offset: 0x009B338E
		public unsafe string MontagePath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SLeisureActionContext.__PropertyOffset_3)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SLeisureActionContext.__PropertyOffset_3)), value);
			}
		}

		// Token: 0x17005FB3 RID: 24499
		// (get) Token: 0x06028CEB RID: 167147 RVA: 0x009B51A3 File Offset: 0x009B33A3
		// (set) Token: 0x06028CEC RID: 167148 RVA: 0x009B51B3 File Offset: 0x009B33B3
		public unsafe int LoopDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLeisureActionContext.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLeisureActionContext.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x06028CED RID: 167149 RVA: 0x009B51C4 File Offset: 0x009B33C4
		public SLeisureActionContext()
		{
		}

		// Token: 0x06028CEE RID: 167150 RVA: 0x009B51CC File Offset: 0x009B33CC
		public SLeisureActionContext(int Type, int TargetEntityId, bool UsedBySwitch, string MontagePath, int LoopDuration)
		{
			this.Type = Type;
			this.TargetEntityId = TargetEntityId;
			this.UsedBySwitch = UsedBySwitch;
			this.MontagePath = MontagePath;
			this.LoopDuration = LoopDuration;
		}

		// Token: 0x06028CEF RID: 167151 RVA: 0x009B51F9 File Offset: 0x009B33F9
		protected override IntPtr GetUStructPtr()
		{
			return SLeisureActionContext.StaticStruct();
		}

		// Token: 0x06028CF0 RID: 167152 RVA: 0x009B5205 File Offset: 0x009B3405
		[NullableContext(2)]
		public SLeisureActionContext(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028CF1 RID: 167153 RVA: 0x009B520F File Offset: 0x009B340F
		public SLeisureActionContext(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028CF2 RID: 167154 RVA: 0x009B521A File Offset: 0x009B341A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SLeisureActionContext(Pointer, false, true);
		}

		// Token: 0x06028CF3 RID: 167155 RVA: 0x009B5224 File Offset: 0x009B3424
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SLeisureActionContext(Pointer, MemoryOwner);
		}

		// Token: 0x04014DDA RID: 85466
		public const string __ObjectPath = "/Game/Aki/Data/NPC/LevelAiBtTree/SLeisureActionContext.SLeisureActionContext";

		// Token: 0x04014DDB RID: 85467
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014DDC RID: 85468
		internal static int __PropertyOffset_0;

		// Token: 0x04014DDD RID: 85469
		internal static int __PropertyOffset_1;

		// Token: 0x04014DDE RID: 85470
		internal static int __PropertyOffset_2;

		// Token: 0x04014DDF RID: 85471
		internal static int __PropertyOffset_3;

		// Token: 0x04014DE0 RID: 85472
		internal static int __PropertyOffset_4;
	}
}
