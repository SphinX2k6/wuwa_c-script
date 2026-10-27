using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.GamePlay.StaticSceneInteraction
{
	// Token: 0x02003E57 RID: 15959
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/GamePlay/StaticSceneInteraction/SInteractivePPVConfig.SInteractivePPVConfig")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SInteractivePPVConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060281D3 RID: 164307 RVA: 0x009A45E4 File Offset: 0x009A27E4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SInteractivePPVConfig._ScriptStructPtr != 0) ? SInteractivePPVConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/GamePlay/StaticSceneInteraction/SInteractivePPVConfig.SInteractivePPVConfig", ref SInteractivePPVConfig._ScriptStructPtr);
		}

		// Token: 0x17005BCE RID: 23502
		// (get) Token: 0x060281D4 RID: 164308 RVA: 0x009A4608 File Offset: 0x009A2808
		// (set) Token: 0x060281D5 RID: 164309 RVA: 0x009A461C File Offset: 0x009A281C
		[Nullable(2)]
		public unsafe AActor PPVActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + SInteractivePPVConfig.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SInteractivePPVConfig.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17005BCF RID: 23503
		// (get) Token: 0x060281D6 RID: 164310 RVA: 0x009A4631 File Offset: 0x009A2831
		// (set) Token: 0x060281D7 RID: 164311 RVA: 0x009A4641 File Offset: 0x009A2841
		public unsafe float TransitionTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInteractivePPVConfig.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInteractivePPVConfig.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005BD0 RID: 23504
		// (get) Token: 0x060281D8 RID: 164312 RVA: 0x009A4652 File Offset: 0x009A2852
		// (set) Token: 0x060281D9 RID: 164313 RVA: 0x009A4662 File Offset: 0x009A2862
		public unsafe float AimBlendWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInteractivePPVConfig.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInteractivePPVConfig.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x060281DA RID: 164314 RVA: 0x009A4673 File Offset: 0x009A2873
		public SInteractivePPVConfig()
		{
		}

		// Token: 0x060281DB RID: 164315 RVA: 0x009A467B File Offset: 0x009A287B
		[NullableContext(1)]
		public SInteractivePPVConfig(AActor PPVActor, float TransitionTime, float AimBlendWeight)
		{
			this.PPVActor = PPVActor;
			this.TransitionTime = TransitionTime;
			this.AimBlendWeight = AimBlendWeight;
		}

		// Token: 0x060281DC RID: 164316 RVA: 0x009A4698 File Offset: 0x009A2898
		protected override IntPtr GetUStructPtr()
		{
			return SInteractivePPVConfig.StaticStruct();
		}

		// Token: 0x060281DD RID: 164317 RVA: 0x009A46A4 File Offset: 0x009A28A4
		[NullableContext(2)]
		public SInteractivePPVConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060281DE RID: 164318 RVA: 0x009A46AE File Offset: 0x009A28AE
		public SInteractivePPVConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060281DF RID: 164319 RVA: 0x009A46B9 File Offset: 0x009A28B9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SInteractivePPVConfig(Pointer, false, true);
		}

		// Token: 0x060281E0 RID: 164320 RVA: 0x009A46C3 File Offset: 0x009A28C3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SInteractivePPVConfig(Pointer, MemoryOwner);
		}

		// Token: 0x040146AC RID: 83628
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/GamePlay/StaticSceneInteraction/SInteractivePPVConfig.SInteractivePPVConfig";

		// Token: 0x040146AD RID: 83629
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040146AE RID: 83630
		internal static int __PropertyOffset_0;

		// Token: 0x040146AF RID: 83631
		internal static int __PropertyOffset_1;

		// Token: 0x040146B0 RID: 83632
		internal static int __PropertyOffset_2;
	}
}
