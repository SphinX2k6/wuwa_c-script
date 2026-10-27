using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.GamePlay.ElementalCasket
{
	// Token: 0x02003E68 RID: 15976
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/GamePlay/ElementalCasket/SPlayerElementalCoreAudioConfig.SPlayerElementalCoreAudioConfig")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class SPlayerElementalCoreAudioConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602830D RID: 164621 RVA: 0x009A640C File Offset: 0x009A460C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SPlayerElementalCoreAudioConfig._ScriptStructPtr != 0) ? SPlayerElementalCoreAudioConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/GamePlay/ElementalCasket/SPlayerElementalCoreAudioConfig.SPlayerElementalCoreAudioConfig", ref SPlayerElementalCoreAudioConfig._ScriptStructPtr);
		}

		// Token: 0x17005C3D RID: 23613
		// (get) Token: 0x0602830E RID: 164622 RVA: 0x009A6430 File Offset: 0x009A4630
		// (set) Token: 0x0602830F RID: 164623 RVA: 0x009A6444 File Offset: 0x009A4644
		public unsafe string WhooshEventName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SPlayerElementalCoreAudioConfig.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SPlayerElementalCoreAudioConfig.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17005C3E RID: 23614
		// (get) Token: 0x06028310 RID: 164624 RVA: 0x009A6459 File Offset: 0x009A4659
		// (set) Token: 0x06028311 RID: 164625 RVA: 0x009A646D File Offset: 0x009A466D
		public unsafe string LoopEventName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SPlayerElementalCoreAudioConfig.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SPlayerElementalCoreAudioConfig.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x06028312 RID: 164626 RVA: 0x009A6482 File Offset: 0x009A4682
		public SPlayerElementalCoreAudioConfig()
		{
		}

		// Token: 0x06028313 RID: 164627 RVA: 0x009A648A File Offset: 0x009A468A
		public SPlayerElementalCoreAudioConfig(string WhooshEventName, string LoopEventName)
		{
			this.WhooshEventName = WhooshEventName;
			this.LoopEventName = LoopEventName;
		}

		// Token: 0x06028314 RID: 164628 RVA: 0x009A64A0 File Offset: 0x009A46A0
		protected override IntPtr GetUStructPtr()
		{
			return SPlayerElementalCoreAudioConfig.StaticStruct();
		}

		// Token: 0x06028315 RID: 164629 RVA: 0x009A64AC File Offset: 0x009A46AC
		[NullableContext(2)]
		public SPlayerElementalCoreAudioConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028316 RID: 164630 RVA: 0x009A64B6 File Offset: 0x009A46B6
		public SPlayerElementalCoreAudioConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028317 RID: 164631 RVA: 0x009A64C1 File Offset: 0x009A46C1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SPlayerElementalCoreAudioConfig(Pointer, false, true);
		}

		// Token: 0x06028318 RID: 164632 RVA: 0x009A64CB File Offset: 0x009A46CB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SPlayerElementalCoreAudioConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0401475E RID: 83806
		public const string __ObjectPath = "/Game/Aki/GamePlay/ElementalCasket/SPlayerElementalCoreAudioConfig.SPlayerElementalCoreAudioConfig";

		// Token: 0x0401475F RID: 83807
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014760 RID: 83808
		internal static int __PropertyOffset_0;

		// Token: 0x04014761 RID: 83809
		internal static int __PropertyOffset_1;
	}
}
