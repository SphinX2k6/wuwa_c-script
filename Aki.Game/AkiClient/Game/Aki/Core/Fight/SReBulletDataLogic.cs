using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003275 RID: 12917
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Core/Fight/SReBulletDataLogic.SReBulletDataLogic")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class SReBulletDataLogic : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06020438 RID: 132152 RVA: 0x0094158C File Offset: 0x0093F78C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SReBulletDataLogic._ScriptStructPtr != 0) ? SReBulletDataLogic._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Core/Fight/SReBulletDataLogic.SReBulletDataLogic", ref SReBulletDataLogic._ScriptStructPtr);
		}

		// Token: 0x17003E2C RID: 15916
		// (get) Token: 0x06020439 RID: 132153 RVA: 0x009415B0 File Offset: 0x0093F7B0
		// (set) Token: 0x0602043A RID: 132154 RVA: 0x009415CF File Offset: 0x0093F7CF
		public TSoftObjectPtr<BulletLogicType_C> 预设
		{
			get
			{
				return new TSoftObjectPtr<BulletLogicType_C>(base.NativePtr + (IntPtr)SReBulletDataLogic.__PropertyOffset_预设, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SReBulletDataLogic.__PropertyOffset_预设, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0602043B RID: 132155 RVA: 0x009415F4 File Offset: 0x0093F7F4
		public SReBulletDataLogic()
		{
		}

		// Token: 0x0602043C RID: 132156 RVA: 0x009415FC File Offset: 0x0093F7FC
		protected override IntPtr GetUStructPtr()
		{
			return SReBulletDataLogic.StaticStruct();
		}

		// Token: 0x0602043D RID: 132157 RVA: 0x00941608 File Offset: 0x0093F808
		[NullableContext(2)]
		public SReBulletDataLogic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602043E RID: 132158 RVA: 0x00941612 File Offset: 0x0093F812
		public SReBulletDataLogic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602043F RID: 132159 RVA: 0x0094161D File Offset: 0x0093F81D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SReBulletDataLogic(Pointer, false, true);
		}

		// Token: 0x06020440 RID: 132160 RVA: 0x00941627 File Offset: 0x0093F827
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SReBulletDataLogic(Pointer, MemoryOwner);
		}

		// Token: 0x040116A9 RID: 71337
		public const string __ObjectPath = "/Game/Aki/Core/Fight/SReBulletDataLogic.SReBulletDataLogic";

		// Token: 0x040116AA RID: 71338
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040116AB RID: 71339
		internal static int __PropertyOffset_预设;
	}
}
