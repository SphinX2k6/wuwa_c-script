using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Data
{
	// Token: 0x0200404D RID: 16461
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Data/SMotorConfigs.SMotorConfigs")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class SMotorConfigs : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602A4BD RID: 173245 RVA: 0x009DBDCB File Offset: 0x009D9FCB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMotorConfigs._ScriptStructPtr != 0) ? SMotorConfigs._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/Vehicle/Motor/Data/SMotorConfigs.SMotorConfigs", ref SMotorConfigs._ScriptStructPtr);
		}

		// Token: 0x170067B5 RID: 26549
		// (get) Token: 0x0602A4BE RID: 173246 RVA: 0x009DBDF0 File Offset: 0x009D9FF0
		// (set) Token: 0x0602A4BF RID: 173247 RVA: 0x009DBE33 File Offset: 0x009DA033
		public FGameplayTagContainer ActivateTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._ActivateTags) == null)
				{
					result = (this._ActivateTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)SMotorConfigs.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SMotorConfigs.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170067B6 RID: 26550
		// (get) Token: 0x0602A4C0 RID: 173248 RVA: 0x009DBE54 File Offset: 0x009DA054
		// (set) Token: 0x0602A4C1 RID: 173249 RVA: 0x009DBE64 File Offset: 0x009DA064
		public unsafe int Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorConfigs.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorConfigs.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170067B7 RID: 26551
		// (get) Token: 0x0602A4C2 RID: 173250 RVA: 0x009DBE78 File Offset: 0x009DA078
		// (set) Token: 0x0602A4C3 RID: 173251 RVA: 0x009DBEBB File Offset: 0x009DA0BB
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<EMotorPropertyName>> VarNames
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<EMotorPropertyName>> result;
				if ((result = this._VarNames) == null)
				{
					result = (this._VarNames = new TArray<TEnumAsByte<EMotorPropertyName>>(base.NativePtr + (IntPtr)SMotorConfigs.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.VarNames.CopyAssign(value);
			}
		}

		// Token: 0x170067B8 RID: 26552
		// (get) Token: 0x0602A4C4 RID: 173252 RVA: 0x009DBEC9 File Offset: 0x009DA0C9
		// (set) Token: 0x0602A4C5 RID: 173253 RVA: 0x009DBEDD File Offset: 0x009DA0DD
		[Nullable(2)]
		public unsafe UMotorcycleConfigs Configs
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMotorcycleConfigs>(base.NativePtr / (IntPtr)sizeof(void*) + SMotorConfigs.__PropertyOffset_3);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SMotorConfigs.__PropertyOffset_3, value);
			}
		}

		// Token: 0x0602A4C6 RID: 173254 RVA: 0x009DBEF2 File Offset: 0x009DA0F2
		public SMotorConfigs()
		{
		}

		// Token: 0x0602A4C7 RID: 173255 RVA: 0x009DBEFA File Offset: 0x009DA0FA
		public SMotorConfigs(FGameplayTagContainer ActivateTags, int Priority, [Nullable(new byte[]
		{
			1,
			0
		})] TArray<TEnumAsByte<EMotorPropertyName>> VarNames, UMotorcycleConfigs Configs)
		{
			this.ActivateTags = ActivateTags;
			this.Priority = Priority;
			this.VarNames = VarNames;
			this.Configs = Configs;
		}

		// Token: 0x0602A4C8 RID: 173256 RVA: 0x009DBF1F File Offset: 0x009DA11F
		protected override IntPtr GetUStructPtr()
		{
			return SMotorConfigs.StaticStruct();
		}

		// Token: 0x0602A4C9 RID: 173257 RVA: 0x009DBF2B File Offset: 0x009DA12B
		[NullableContext(2)]
		public SMotorConfigs(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602A4CA RID: 173258 RVA: 0x009DBF35 File Offset: 0x009DA135
		public SMotorConfigs(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602A4CB RID: 173259 RVA: 0x009DBF40 File Offset: 0x009DA140
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMotorConfigs(Pointer, false, true);
		}

		// Token: 0x0602A4CC RID: 173260 RVA: 0x009DBF4A File Offset: 0x009DA14A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMotorConfigs(Pointer, MemoryOwner);
		}

		// Token: 0x04015D14 RID: 89364
		public const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Data/SMotorConfigs.SMotorConfigs";

		// Token: 0x04015D15 RID: 89365
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015D16 RID: 89366
		internal static int __PropertyOffset_0;

		// Token: 0x04015D17 RID: 89367
		[Nullable(2)]
		private FGameplayTagContainer _ActivateTags;

		// Token: 0x04015D18 RID: 89368
		internal static int __PropertyOffset_1;

		// Token: 0x04015D19 RID: 89369
		internal static int __PropertyOffset_2;

		// Token: 0x04015D1A RID: 89370
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EMotorPropertyName>> _VarNames;

		// Token: 0x04015D1B RID: 89371
		internal static int __PropertyOffset_3;
	}
}
