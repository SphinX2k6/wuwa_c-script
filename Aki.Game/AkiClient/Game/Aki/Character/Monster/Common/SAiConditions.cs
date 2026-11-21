using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Condition.Enum;
using AkiClient.Game.Aki.Protocol;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.Monster.Common
{
	// Token: 0x020032C9 RID: 13001
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Monster/Common/SAiConditions.SAiConditions")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 177)]
	public class SAiConditions : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06020EDF RID: 134879 RVA: 0x00952C02 File Offset: 0x00950E02
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SAiConditions._ScriptStructPtr != 0) ? SAiConditions._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/Monster/Common/SAiConditions.SAiConditions", ref SAiConditions._ScriptStructPtr);
		}

		// Token: 0x170041CF RID: 16847
		// (get) Token: 0x06020EE0 RID: 134880 RVA: 0x00952C28 File Offset: 0x00950E28
		// (set) Token: 0x06020EE1 RID: 134881 RVA: 0x00952C6B File Offset: 0x00950E6B
		public TMap<FGameplayTag, FFloatRange> Tags
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, FFloatRange> result;
				if ((result = this._Tags) == null)
				{
					result = (this._Tags = new TMap<FGameplayTag, FFloatRange>(base.NativePtr + (IntPtr)SAiConditions.__PropertyOffset_Tags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Tags.CopyAssign(value);
			}
		}

		// Token: 0x170041D0 RID: 16848
		// (get) Token: 0x06020EE2 RID: 134882 RVA: 0x00952C7C File Offset: 0x00950E7C
		// (set) Token: 0x06020EE3 RID: 134883 RVA: 0x00952CBF File Offset: 0x00950EBF
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TMap<TEnumAsByte<EAttributeType>, FFloatRange> Attributes
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EAttributeType>, FFloatRange> result;
				if ((result = this._Attributes) == null)
				{
					result = (this._Attributes = new TMap<TEnumAsByte<EAttributeType>, FFloatRange>(base.NativePtr + (IntPtr)SAiConditions.__PropertyOffset_Attributes, base.MemoryOwner ?? this));
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
				this.Attributes.CopyAssign(value);
			}
		}

		// Token: 0x170041D1 RID: 16849
		// (get) Token: 0x06020EE4 RID: 134884 RVA: 0x00952CD0 File Offset: 0x00950ED0
		// (set) Token: 0x06020EE5 RID: 134885 RVA: 0x00952D13 File Offset: 0x00950F13
		public TArray<SAiAttributeRate> AttributeRates
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SAiAttributeRate> result;
				if ((result = this._AttributeRates) == null)
				{
					result = (this._AttributeRates = new TArray<SAiAttributeRate>(base.NativePtr + (IntPtr)SAiConditions.__PropertyOffset_AttributeRates, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AttributeRates.CopyAssign(value);
			}
		}

		// Token: 0x170041D2 RID: 16850
		// (get) Token: 0x06020EE6 RID: 134886 RVA: 0x00952D21 File Offset: 0x00950F21
		// (set) Token: 0x06020EE7 RID: 134887 RVA: 0x00952D35 File Offset: 0x00950F35
		[Nullable(0)]
		public unsafe TEnumAsByte<SConditionGroupType> Logic
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SAiConditions.__PropertyOffset_Logic);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SAiConditions.__PropertyOffset_Logic) = value;
			}
		}

		// Token: 0x06020EE8 RID: 134888 RVA: 0x00952D4A File Offset: 0x00950F4A
		public SAiConditions()
		{
		}

		// Token: 0x06020EE9 RID: 134889 RVA: 0x00952D52 File Offset: 0x00950F52
		protected override IntPtr GetUStructPtr()
		{
			return SAiConditions.StaticStruct();
		}

		// Token: 0x06020EEA RID: 134890 RVA: 0x00952D5E File Offset: 0x00950F5E
		[NullableContext(2)]
		public SAiConditions(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06020EEB RID: 134891 RVA: 0x00952D68 File Offset: 0x00950F68
		public SAiConditions(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06020EEC RID: 134892 RVA: 0x00952D73 File Offset: 0x00950F73
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SAiConditions(Pointer, false, true);
		}

		// Token: 0x06020EED RID: 134893 RVA: 0x00952D7D File Offset: 0x00950F7D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SAiConditions(Pointer, MemoryOwner);
		}

		// Token: 0x04011D64 RID: 73060
		public const string __ObjectPath = "/Game/Aki/Character/Monster/Common/SAiConditions.SAiConditions";

		// Token: 0x04011D65 RID: 73061
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011D66 RID: 73062
		internal static int __PropertyOffset_Tags;

		// Token: 0x04011D67 RID: 73063
		[Nullable(2)]
		private TMap<FGameplayTag, FFloatRange> _Tags;

		// Token: 0x04011D68 RID: 73064
		internal static int __PropertyOffset_Attributes;

		// Token: 0x04011D69 RID: 73065
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EAttributeType>, FFloatRange> _Attributes;

		// Token: 0x04011D6A RID: 73066
		internal static int __PropertyOffset_AttributeRates;

		// Token: 0x04011D6B RID: 73067
		[Nullable(2)]
		private TArray<SAiAttributeRate> _AttributeRates;

		// Token: 0x04011D6C RID: 73068
		internal static int __PropertyOffset_Logic;
	}
}
