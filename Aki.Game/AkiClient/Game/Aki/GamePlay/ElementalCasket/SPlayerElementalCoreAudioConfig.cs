using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.GamePlay.ElementalCasket
{
	// Token: 0x02003157 RID: 12631
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/GamePlay/ElementalCasket/SPlayerElementalCoreAudioConfig.SPlayerElementalCoreAudioConfig")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class SPlayerElementalCoreAudioConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F153 RID: 127315 RVA: 0x00925F88 File Offset: 0x00924188
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SPlayerElementalCoreAudioConfig._ScriptStructPtr != 0) ? SPlayerElementalCoreAudioConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/GamePlay/ElementalCasket/SPlayerElementalCoreAudioConfig.SPlayerElementalCoreAudioConfig", ref SPlayerElementalCoreAudioConfig._ScriptStructPtr);
		}

		// Token: 0x17003744 RID: 14148
		// (get) Token: 0x0601F154 RID: 127316 RVA: 0x00925FAC File Offset: 0x009241AC
		// (set) Token: 0x0601F155 RID: 127317 RVA: 0x00925FC0 File Offset: 0x009241C0
		public unsafe string WhooshEventName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SPlayerElementalCoreAudioConfig.__PropertyOffset_WhooshEventName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SPlayerElementalCoreAudioConfig.__PropertyOffset_WhooshEventName)), value);
			}
		}

		// Token: 0x17003745 RID: 14149
		// (get) Token: 0x0601F156 RID: 127318 RVA: 0x00925FD5 File Offset: 0x009241D5
		// (set) Token: 0x0601F157 RID: 127319 RVA: 0x00925FE9 File Offset: 0x009241E9
		public unsafe string LoopEventName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SPlayerElementalCoreAudioConfig.__PropertyOffset_LoopEventName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SPlayerElementalCoreAudioConfig.__PropertyOffset_LoopEventName)), value);
			}
		}

		// Token: 0x0601F158 RID: 127320 RVA: 0x00925FFE File Offset: 0x009241FE
		public SPlayerElementalCoreAudioConfig()
		{
		}

		// Token: 0x0601F159 RID: 127321 RVA: 0x00926006 File Offset: 0x00924206
		protected override IntPtr GetUStructPtr()
		{
			return SPlayerElementalCoreAudioConfig.StaticStruct();
		}

		// Token: 0x0601F15A RID: 127322 RVA: 0x00926012 File Offset: 0x00924212
		[NullableContext(2)]
		public SPlayerElementalCoreAudioConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F15B RID: 127323 RVA: 0x0092601C File Offset: 0x0092421C
		public SPlayerElementalCoreAudioConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F15C RID: 127324 RVA: 0x00926027 File Offset: 0x00924227
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SPlayerElementalCoreAudioConfig(Pointer, false, true);
		}

		// Token: 0x0601F15D RID: 127325 RVA: 0x00926031 File Offset: 0x00924231
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SPlayerElementalCoreAudioConfig(Pointer, MemoryOwner);
		}

		// Token: 0x040109BF RID: 68031
		public const string __ObjectPath = "/Game/Aki/GamePlay/ElementalCasket/SPlayerElementalCoreAudioConfig.SPlayerElementalCoreAudioConfig";

		// Token: 0x040109C0 RID: 68032
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040109C1 RID: 68033
		internal static int __PropertyOffset_WhooshEventName;

		// Token: 0x040109C2 RID: 68034
		internal static int __PropertyOffset_LoopEventName;
	}
}
