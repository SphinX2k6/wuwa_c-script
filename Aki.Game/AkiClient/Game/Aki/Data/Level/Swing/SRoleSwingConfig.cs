using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Level.Swing
{
	// Token: 0x020031C0 RID: 12736
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Level/Swing/SRoleSwingConfig.SRoleSwingConfig")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class SRoleSwingConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F7DD RID: 128989 RVA: 0x0092EFA4 File Offset: 0x0092D1A4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SRoleSwingConfig._ScriptStructPtr != 0) ? SRoleSwingConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Level/Swing/SRoleSwingConfig.SRoleSwingConfig", ref SRoleSwingConfig._ScriptStructPtr);
		}

		// Token: 0x1700399B RID: 14747
		// (get) Token: 0x0601F7DE RID: 128990 RVA: 0x0092EFC8 File Offset: 0x0092D1C8
		// (set) Token: 0x0601F7DF RID: 128991 RVA: 0x0092F00B File Offset: 0x0092D20B
		public TArray<int> RoleId
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._RoleId) == null)
				{
					result = (this._RoleId = new TArray<int>(base.NativePtr + (IntPtr)SRoleSwingConfig.__PropertyOffset_RoleId, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RoleId.CopyAssign(value);
			}
		}

		// Token: 0x1700399C RID: 14748
		// (get) Token: 0x0601F7E0 RID: 128992 RVA: 0x0092F019 File Offset: 0x0092D219
		// (set) Token: 0x0601F7E1 RID: 128993 RVA: 0x0092F038 File Offset: 0x0092D238
		public TSoftObjectPtr<UAnimMontage> SwingMontage
		{
			get
			{
				return new TSoftObjectPtr<UAnimMontage>(base.NativePtr + (IntPtr)SRoleSwingConfig.__PropertyOffset_SwingMontage, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SRoleSwingConfig.__PropertyOffset_SwingMontage, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0601F7E2 RID: 128994 RVA: 0x0092F05D File Offset: 0x0092D25D
		public SRoleSwingConfig()
		{
		}

		// Token: 0x0601F7E3 RID: 128995 RVA: 0x0092F065 File Offset: 0x0092D265
		protected override IntPtr GetUStructPtr()
		{
			return SRoleSwingConfig.StaticStruct();
		}

		// Token: 0x0601F7E4 RID: 128996 RVA: 0x0092F071 File Offset: 0x0092D271
		[NullableContext(2)]
		public SRoleSwingConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F7E5 RID: 128997 RVA: 0x0092F07B File Offset: 0x0092D27B
		public SRoleSwingConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F7E6 RID: 128998 RVA: 0x0092F086 File Offset: 0x0092D286
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SRoleSwingConfig(Pointer, false, true);
		}

		// Token: 0x0601F7E7 RID: 128999 RVA: 0x0092F090 File Offset: 0x0092D290
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SRoleSwingConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04010E40 RID: 69184
		public const string __ObjectPath = "/Game/Aki/Data/Level/Swing/SRoleSwingConfig.SRoleSwingConfig";

		// Token: 0x04010E41 RID: 69185
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010E42 RID: 69186
		internal static int __PropertyOffset_RoleId;

		// Token: 0x04010E43 RID: 69187
		[Nullable(2)]
		private TArray<int> _RoleId;

		// Token: 0x04010E44 RID: 69188
		internal static int __PropertyOffset_SwingMontage;
	}
}
