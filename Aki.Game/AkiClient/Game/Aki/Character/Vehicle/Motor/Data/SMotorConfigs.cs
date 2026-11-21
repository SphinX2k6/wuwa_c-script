using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Data
{
	// Token: 0x02003292 RID: 12946
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Data/SMotorConfigs.SMotorConfigs")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class SMotorConfigs : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060206CA RID: 132810 RVA: 0x0094637F File Offset: 0x0094457F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMotorConfigs._ScriptStructPtr != 0) ? SMotorConfigs._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/Vehicle/Motor/Data/SMotorConfigs.SMotorConfigs", ref SMotorConfigs._ScriptStructPtr);
		}

		// Token: 0x17003EF8 RID: 16120
		// (get) Token: 0x060206CB RID: 132811 RVA: 0x009463A4 File Offset: 0x009445A4
		// (set) Token: 0x060206CC RID: 132812 RVA: 0x009463E7 File Offset: 0x009445E7
		public FGameplayTagContainer ActivateTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._ActivateTags) == null)
				{
					result = (this._ActivateTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)SMotorConfigs.__PropertyOffset_ActivateTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SMotorConfigs.__PropertyOffset_ActivateTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003EF9 RID: 16121
		// (get) Token: 0x060206CD RID: 132813 RVA: 0x00946408 File Offset: 0x00944608
		// (set) Token: 0x060206CE RID: 132814 RVA: 0x00946418 File Offset: 0x00944618
		public unsafe int Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorConfigs.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorConfigs.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x17003EFA RID: 16122
		// (get) Token: 0x060206CF RID: 132815 RVA: 0x0094642C File Offset: 0x0094462C
		// (set) Token: 0x060206D0 RID: 132816 RVA: 0x0094646F File Offset: 0x0094466F
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
					result = (this._VarNames = new TArray<TEnumAsByte<EMotorPropertyName>>(base.NativePtr + (IntPtr)SMotorConfigs.__PropertyOffset_VarNames, base.MemoryOwner ?? this));
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

		// Token: 0x17003EFB RID: 16123
		// (get) Token: 0x060206D1 RID: 132817 RVA: 0x0094647D File Offset: 0x0094467D
		// (set) Token: 0x060206D2 RID: 132818 RVA: 0x00946491 File Offset: 0x00944691
		[Nullable(2)]
		public unsafe UMotorcycleConfigs Configs
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMotorcycleConfigs>(base.NativePtr / (IntPtr)sizeof(void*) + SMotorConfigs.__PropertyOffset_Configs);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SMotorConfigs.__PropertyOffset_Configs, value);
			}
		}

		// Token: 0x060206D3 RID: 132819 RVA: 0x009464A6 File Offset: 0x009446A6
		public SMotorConfigs()
		{
		}

		// Token: 0x060206D4 RID: 132820 RVA: 0x009464AE File Offset: 0x009446AE
		protected override IntPtr GetUStructPtr()
		{
			return SMotorConfigs.StaticStruct();
		}

		// Token: 0x060206D5 RID: 132821 RVA: 0x009464BA File Offset: 0x009446BA
		[NullableContext(2)]
		public SMotorConfigs(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060206D6 RID: 132822 RVA: 0x009464C4 File Offset: 0x009446C4
		public SMotorConfigs(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060206D7 RID: 132823 RVA: 0x009464CF File Offset: 0x009446CF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMotorConfigs(Pointer, false, true);
		}

		// Token: 0x060206D8 RID: 132824 RVA: 0x009464D9 File Offset: 0x009446D9
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMotorConfigs(Pointer, MemoryOwner);
		}

		// Token: 0x04011849 RID: 71753
		public const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Data/SMotorConfigs.SMotorConfigs";

		// Token: 0x0401184A RID: 71754
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401184B RID: 71755
		internal static int __PropertyOffset_ActivateTags;

		// Token: 0x0401184C RID: 71756
		[Nullable(2)]
		private FGameplayTagContainer _ActivateTags;

		// Token: 0x0401184D RID: 71757
		internal static int __PropertyOffset_Priority;

		// Token: 0x0401184E RID: 71758
		internal static int __PropertyOffset_VarNames;

		// Token: 0x0401184F RID: 71759
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EMotorPropertyName>> _VarNames;

		// Token: 0x04011850 RID: 71760
		internal static int __PropertyOffset_Configs;
	}
}
