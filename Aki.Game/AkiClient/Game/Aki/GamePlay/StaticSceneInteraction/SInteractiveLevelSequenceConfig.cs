using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.GamePlay.StaticSceneInteraction
{
	// Token: 0x02003E56 RID: 15958
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/GamePlay/StaticSceneInteraction/SInteractiveLevelSequenceConfig.SInteractiveLevelSequenceConfig")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SInteractiveLevelSequenceConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060281C5 RID: 164293 RVA: 0x009A44FC File Offset: 0x009A26FC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SInteractiveLevelSequenceConfig._ScriptStructPtr != 0) ? SInteractiveLevelSequenceConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/GamePlay/StaticSceneInteraction/SInteractiveLevelSequenceConfig.SInteractiveLevelSequenceConfig", ref SInteractiveLevelSequenceConfig._ScriptStructPtr);
		}

		// Token: 0x17005BCB RID: 23499
		// (get) Token: 0x060281C6 RID: 164294 RVA: 0x009A4520 File Offset: 0x009A2720
		// (set) Token: 0x060281C7 RID: 164295 RVA: 0x009A4534 File Offset: 0x009A2734
		public unsafe string Mark
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SInteractiveLevelSequenceConfig.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SInteractiveLevelSequenceConfig.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17005BCC RID: 23500
		// (get) Token: 0x060281C8 RID: 164296 RVA: 0x009A4549 File Offset: 0x009A2749
		// (set) Token: 0x060281C9 RID: 164297 RVA: 0x009A4559 File Offset: 0x009A2759
		public unsafe float 切入时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInteractiveLevelSequenceConfig.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInteractiveLevelSequenceConfig.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005BCD RID: 23501
		// (get) Token: 0x060281CA RID: 164298 RVA: 0x009A456A File Offset: 0x009A276A
		// (set) Token: 0x060281CB RID: 164299 RVA: 0x009A457A File Offset: 0x009A277A
		public unsafe float 切出时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInteractiveLevelSequenceConfig.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInteractiveLevelSequenceConfig.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x060281CC RID: 164300 RVA: 0x009A458B File Offset: 0x009A278B
		public SInteractiveLevelSequenceConfig()
		{
		}

		// Token: 0x060281CD RID: 164301 RVA: 0x009A4593 File Offset: 0x009A2793
		public SInteractiveLevelSequenceConfig(string Mark, float 切入时间, float 切出时间)
		{
			this.Mark = Mark;
			this.切入时间 = 切入时间;
			this.切出时间 = 切出时间;
		}

		// Token: 0x060281CE RID: 164302 RVA: 0x009A45B0 File Offset: 0x009A27B0
		protected override IntPtr GetUStructPtr()
		{
			return SInteractiveLevelSequenceConfig.StaticStruct();
		}

		// Token: 0x060281CF RID: 164303 RVA: 0x009A45BC File Offset: 0x009A27BC
		[NullableContext(2)]
		public SInteractiveLevelSequenceConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060281D0 RID: 164304 RVA: 0x009A45C6 File Offset: 0x009A27C6
		public SInteractiveLevelSequenceConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060281D1 RID: 164305 RVA: 0x009A45D1 File Offset: 0x009A27D1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SInteractiveLevelSequenceConfig(Pointer, false, true);
		}

		// Token: 0x060281D2 RID: 164306 RVA: 0x009A45DB File Offset: 0x009A27DB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SInteractiveLevelSequenceConfig(Pointer, MemoryOwner);
		}

		// Token: 0x040146A7 RID: 83623
		public const string __ObjectPath = "/Game/Aki/GamePlay/StaticSceneInteraction/SInteractiveLevelSequenceConfig.SInteractiveLevelSequenceConfig";

		// Token: 0x040146A8 RID: 83624
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040146A9 RID: 83625
		internal static int __PropertyOffset_0;

		// Token: 0x040146AA RID: 83626
		internal static int __PropertyOffset_1;

		// Token: 0x040146AB RID: 83627
		internal static int __PropertyOffset_2;
	}
}
