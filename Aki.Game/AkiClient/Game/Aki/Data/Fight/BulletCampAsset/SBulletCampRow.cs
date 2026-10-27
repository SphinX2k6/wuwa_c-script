using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Fight.BulletCampAsset
{
	// Token: 0x02003F84 RID: 16260
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Fight/BulletCampAsset/SBulletCampRow.SBulletCampRow")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class SBulletCampRow : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602981E RID: 170014 RVA: 0x009C5CB0 File Offset: 0x009C3EB0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SBulletCampRow._ScriptStructPtr != 0) ? SBulletCampRow._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/BulletCampAsset/SBulletCampRow.SBulletCampRow", ref SBulletCampRow._ScriptStructPtr);
		}

		// Token: 0x170063A3 RID: 25507
		// (get) Token: 0x0602981F RID: 170015 RVA: 0x009C5CD4 File Offset: 0x009C3ED4
		// (set) Token: 0x06029820 RID: 170016 RVA: 0x009C5CE8 File Offset: 0x009C3EE8
		[Nullable(2)]
		public unsafe BulletCampType_C Ref
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BulletCampType_C>(base.NativePtr / (IntPtr)sizeof(void*) + SBulletCampRow.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SBulletCampRow.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06029821 RID: 170017 RVA: 0x009C5CFD File Offset: 0x009C3EFD
		public SBulletCampRow()
		{
		}

		// Token: 0x06029822 RID: 170018 RVA: 0x009C5D05 File Offset: 0x009C3F05
		[NullableContext(1)]
		public SBulletCampRow(BulletCampType_C Ref)
		{
			this.Ref = Ref;
		}

		// Token: 0x06029823 RID: 170019 RVA: 0x009C5D14 File Offset: 0x009C3F14
		protected override IntPtr GetUStructPtr()
		{
			return SBulletCampRow.StaticStruct();
		}

		// Token: 0x06029824 RID: 170020 RVA: 0x009C5D20 File Offset: 0x009C3F20
		[NullableContext(2)]
		public SBulletCampRow(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029825 RID: 170021 RVA: 0x009C5D2A File Offset: 0x009C3F2A
		public SBulletCampRow(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029826 RID: 170022 RVA: 0x009C5D35 File Offset: 0x009C3F35
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SBulletCampRow(Pointer, false, true);
		}

		// Token: 0x06029827 RID: 170023 RVA: 0x009C5D3F File Offset: 0x009C3F3F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SBulletCampRow(Pointer, MemoryOwner);
		}

		// Token: 0x04015469 RID: 87145
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Fight/BulletCampAsset/SBulletCampRow.SBulletCampRow";

		// Token: 0x0401546A RID: 87146
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401546B RID: 87147
		internal static int __PropertyOffset_0;
	}
}
