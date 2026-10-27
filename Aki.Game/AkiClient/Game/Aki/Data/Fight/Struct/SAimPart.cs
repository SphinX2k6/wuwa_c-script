using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x02003F5F RID: 16223
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SAimPart.SAimPart")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class SAimPart : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029536 RID: 169270 RVA: 0x009C16B8 File Offset: 0x009BF8B8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SAimPart._ScriptStructPtr != 0) ? SAimPart._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SAimPart.SAimPart", ref SAimPart._ScriptStructPtr);
		}

		// Token: 0x170062A4 RID: 25252
		// (get) Token: 0x06029537 RID: 169271 RVA: 0x009C16DC File Offset: 0x009BF8DC
		// (set) Token: 0x06029538 RID: 169272 RVA: 0x009C16F0 File Offset: 0x009BF8F0
		public unsafe string BoneName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SAimPart.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SAimPart.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x170062A5 RID: 25253
		// (get) Token: 0x06029539 RID: 169273 RVA: 0x009C1705 File Offset: 0x009BF905
		// (set) Token: 0x0602953A RID: 169274 RVA: 0x009C1719 File Offset: 0x009BF919
		public unsafe FVector Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAimPart.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAimPart.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170062A6 RID: 25254
		// (get) Token: 0x0602953B RID: 169275 RVA: 0x009C172E File Offset: 0x009BF92E
		// (set) Token: 0x0602953C RID: 169276 RVA: 0x009C173E File Offset: 0x009BF93E
		public unsafe float RadiusIn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAimPart.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAimPart.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170062A7 RID: 25255
		// (get) Token: 0x0602953D RID: 169277 RVA: 0x009C174F File Offset: 0x009BF94F
		// (set) Token: 0x0602953E RID: 169278 RVA: 0x009C175F File Offset: 0x009BF95F
		public unsafe float RadiusOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAimPart.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAimPart.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170062A8 RID: 25256
		// (get) Token: 0x0602953F RID: 169279 RVA: 0x009C1770 File Offset: 0x009BF970
		// (set) Token: 0x06029540 RID: 169280 RVA: 0x009C1780 File Offset: 0x009BF980
		public unsafe float RadiusOutOnStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAimPart.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAimPart.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170062A9 RID: 25257
		// (get) Token: 0x06029541 RID: 169281 RVA: 0x009C1791 File Offset: 0x009BF991
		// (set) Token: 0x06029542 RID: 169282 RVA: 0x009C17A1 File Offset: 0x009BF9A1
		public unsafe float MobileCorrect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAimPart.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAimPart.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170062AA RID: 25258
		// (get) Token: 0x06029543 RID: 169283 RVA: 0x009C17B2 File Offset: 0x009BF9B2
		// (set) Token: 0x06029544 RID: 169284 RVA: 0x009C17C2 File Offset: 0x009BF9C2
		public unsafe float GamePadCorrect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAimPart.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAimPart.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170062AB RID: 25259
		// (get) Token: 0x06029545 RID: 169285 RVA: 0x009C17D3 File Offset: 0x009BF9D3
		// (set) Token: 0x06029546 RID: 169286 RVA: 0x009C17E7 File Offset: 0x009BF9E7
		public unsafe string 忽略的骨骼碰撞
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SAimPart.__PropertyOffset_7)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SAimPart.__PropertyOffset_7)), value);
			}
		}

		// Token: 0x06029547 RID: 169287 RVA: 0x009C17FC File Offset: 0x009BF9FC
		public SAimPart()
		{
		}

		// Token: 0x06029548 RID: 169288 RVA: 0x009C1804 File Offset: 0x009BFA04
		public SAimPart(string BoneName, FVector Offset, float RadiusIn, float RadiusOut, float RadiusOutOnStart, float MobileCorrect, float GamePadCorrect, string 忽略的骨骼碰撞)
		{
			this.BoneName = BoneName;
			this.Offset = Offset;
			this.RadiusIn = RadiusIn;
			this.RadiusOut = RadiusOut;
			this.RadiusOutOnStart = RadiusOutOnStart;
			this.MobileCorrect = MobileCorrect;
			this.GamePadCorrect = GamePadCorrect;
			this.忽略的骨骼碰撞 = 忽略的骨骼碰撞;
		}

		// Token: 0x06029549 RID: 169289 RVA: 0x009C1854 File Offset: 0x009BFA54
		protected override IntPtr GetUStructPtr()
		{
			return SAimPart.StaticStruct();
		}

		// Token: 0x0602954A RID: 169290 RVA: 0x009C1860 File Offset: 0x009BFA60
		[NullableContext(2)]
		public SAimPart(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602954B RID: 169291 RVA: 0x009C186A File Offset: 0x009BFA6A
		public SAimPart(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602954C RID: 169292 RVA: 0x009C1875 File Offset: 0x009BFA75
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SAimPart(Pointer, false, true);
		}

		// Token: 0x0602954D RID: 169293 RVA: 0x009C187F File Offset: 0x009BFA7F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SAimPart(Pointer, MemoryOwner);
		}

		// Token: 0x040152CE RID: 86734
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SAimPart.SAimPart";

		// Token: 0x040152CF RID: 86735
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040152D0 RID: 86736
		internal static int __PropertyOffset_0;

		// Token: 0x040152D1 RID: 86737
		internal static int __PropertyOffset_1;

		// Token: 0x040152D2 RID: 86738
		internal static int __PropertyOffset_2;

		// Token: 0x040152D3 RID: 86739
		internal static int __PropertyOffset_3;

		// Token: 0x040152D4 RID: 86740
		internal static int __PropertyOffset_4;

		// Token: 0x040152D5 RID: 86741
		internal static int __PropertyOffset_5;

		// Token: 0x040152D6 RID: 86742
		internal static int __PropertyOffset_6;

		// Token: 0x040152D7 RID: 86743
		internal static int __PropertyOffset_7;
	}
}
