using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Level.Swing
{
	// Token: 0x02003F04 RID: 16132
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Level/Swing/SRoleSwingConfig.SRoleSwingConfig")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class SRoleSwingConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028E49 RID: 167497 RVA: 0x009B6FBC File Offset: 0x009B51BC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SRoleSwingConfig._ScriptStructPtr != 0) ? SRoleSwingConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Level/Swing/SRoleSwingConfig.SRoleSwingConfig", ref SRoleSwingConfig._ScriptStructPtr);
		}

		// Token: 0x17006030 RID: 24624
		// (get) Token: 0x06028E4A RID: 167498 RVA: 0x009B6FE0 File Offset: 0x009B51E0
		// (set) Token: 0x06028E4B RID: 167499 RVA: 0x009B7023 File Offset: 0x009B5223
		public TArray<int> RoleId
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._RoleId) == null)
				{
					result = (this._RoleId = new TArray<int>(base.NativePtr + (IntPtr)SRoleSwingConfig.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RoleId.CopyAssign(value);
			}
		}

		// Token: 0x17006031 RID: 24625
		// (get) Token: 0x06028E4C RID: 167500 RVA: 0x009B7031 File Offset: 0x009B5231
		// (set) Token: 0x06028E4D RID: 167501 RVA: 0x009B7050 File Offset: 0x009B5250
		public TSoftObjectPtr<UAnimMontage> SwingMontage
		{
			get
			{
				return new TSoftObjectPtr<UAnimMontage>(base.NativePtr + (IntPtr)SRoleSwingConfig.__PropertyOffset_1, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SRoleSwingConfig.__PropertyOffset_1, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x06028E4E RID: 167502 RVA: 0x009B7075 File Offset: 0x009B5275
		public SRoleSwingConfig()
		{
		}

		// Token: 0x06028E4F RID: 167503 RVA: 0x009B707D File Offset: 0x009B527D
		public SRoleSwingConfig(TArray<int> RoleId, TSoftObjectPtr<UAnimMontage> SwingMontage)
		{
			this.RoleId = RoleId;
			this.SwingMontage = SwingMontage;
		}

		// Token: 0x06028E50 RID: 167504 RVA: 0x009B7093 File Offset: 0x009B5293
		protected override IntPtr GetUStructPtr()
		{
			return SRoleSwingConfig.StaticStruct();
		}

		// Token: 0x06028E51 RID: 167505 RVA: 0x009B709F File Offset: 0x009B529F
		[NullableContext(2)]
		public SRoleSwingConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028E52 RID: 167506 RVA: 0x009B70A9 File Offset: 0x009B52A9
		public SRoleSwingConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028E53 RID: 167507 RVA: 0x009B70B4 File Offset: 0x009B52B4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SRoleSwingConfig(Pointer, false, true);
		}

		// Token: 0x06028E54 RID: 167508 RVA: 0x009B70BE File Offset: 0x009B52BE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SRoleSwingConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04014EA0 RID: 85664
		public const string __ObjectPath = "/Game/Aki/Data/Level/Swing/SRoleSwingConfig.SRoleSwingConfig";

		// Token: 0x04014EA1 RID: 85665
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014EA2 RID: 85666
		internal static int __PropertyOffset_0;

		// Token: 0x04014EA3 RID: 85667
		[Nullable(2)]
		private TArray<int> _RoleId;

		// Token: 0x04014EA4 RID: 85668
		internal static int __PropertyOffset_1;
	}
}
