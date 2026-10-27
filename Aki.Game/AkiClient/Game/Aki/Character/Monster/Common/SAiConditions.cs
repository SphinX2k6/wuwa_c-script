using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Condition.Enum;
using AkiClient.Game.Aki.Protocol;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.Monster.Common
{
	// Token: 0x02004251 RID: 16977
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Monster/Common/SAiConditions.SAiConditions")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 177)]
	public class SAiConditions : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602BFA9 RID: 180137 RVA: 0x00A10DC2 File Offset: 0x00A0EFC2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SAiConditions._ScriptStructPtr != 0) ? SAiConditions._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/Monster/Common/SAiConditions.SAiConditions", ref SAiConditions._ScriptStructPtr);
		}

		// Token: 0x17006D26 RID: 27942
		// (get) Token: 0x0602BFAA RID: 180138 RVA: 0x00A10DE8 File Offset: 0x00A0EFE8
		// (set) Token: 0x0602BFAB RID: 180139 RVA: 0x00A10E2B File Offset: 0x00A0F02B
		public TMap<FGameplayTag, FFloatRange> Tags
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, FFloatRange> result;
				if ((result = this._Tags) == null)
				{
					result = (this._Tags = new TMap<FGameplayTag, FFloatRange>(base.NativePtr + (IntPtr)SAiConditions.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Tags.CopyAssign(value);
			}
		}

		// Token: 0x17006D27 RID: 27943
		// (get) Token: 0x0602BFAC RID: 180140 RVA: 0x00A10E3C File Offset: 0x00A0F03C
		// (set) Token: 0x0602BFAD RID: 180141 RVA: 0x00A10E7F File Offset: 0x00A0F07F
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
					result = (this._Attributes = new TMap<TEnumAsByte<EAttributeType>, FFloatRange>(base.NativePtr + (IntPtr)SAiConditions.__PropertyOffset_1, base.MemoryOwner ?? this));
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

		// Token: 0x17006D28 RID: 27944
		// (get) Token: 0x0602BFAE RID: 180142 RVA: 0x00A10E90 File Offset: 0x00A0F090
		// (set) Token: 0x0602BFAF RID: 180143 RVA: 0x00A10ED3 File Offset: 0x00A0F0D3
		public TArray<SAiAttributeRate> AttributeRates
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SAiAttributeRate> result;
				if ((result = this._AttributeRates) == null)
				{
					result = (this._AttributeRates = new TArray<SAiAttributeRate>(base.NativePtr + (IntPtr)SAiConditions.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AttributeRates.CopyAssign(value);
			}
		}

		// Token: 0x17006D29 RID: 27945
		// (get) Token: 0x0602BFB0 RID: 180144 RVA: 0x00A10EE1 File Offset: 0x00A0F0E1
		// (set) Token: 0x0602BFB1 RID: 180145 RVA: 0x00A10EF5 File Offset: 0x00A0F0F5
		[Nullable(0)]
		public unsafe TEnumAsByte<SConditionGroupType> Logic
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SAiConditions.__PropertyOffset_3);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SAiConditions.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x0602BFB2 RID: 180146 RVA: 0x00A10F0A File Offset: 0x00A0F10A
		public SAiConditions()
		{
		}

		// Token: 0x0602BFB3 RID: 180147 RVA: 0x00A10F12 File Offset: 0x00A0F112
		public SAiConditions(TMap<FGameplayTag, FFloatRange> Tags, [Nullable(new byte[]
		{
			1,
			0
		})] TMap<TEnumAsByte<EAttributeType>, FFloatRange> Attributes, TArray<SAiAttributeRate> AttributeRates, [Nullable(0)] TEnumAsByte<SConditionGroupType> Logic)
		{
			this.Tags = Tags;
			this.Attributes = Attributes;
			this.AttributeRates = AttributeRates;
			this.Logic = Logic;
		}

		// Token: 0x0602BFB4 RID: 180148 RVA: 0x00A10F37 File Offset: 0x00A0F137
		protected override IntPtr GetUStructPtr()
		{
			return SAiConditions.StaticStruct();
		}

		// Token: 0x0602BFB5 RID: 180149 RVA: 0x00A10F43 File Offset: 0x00A0F143
		[NullableContext(2)]
		public SAiConditions(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602BFB6 RID: 180150 RVA: 0x00A10F4D File Offset: 0x00A0F14D
		public SAiConditions(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602BFB7 RID: 180151 RVA: 0x00A10F58 File Offset: 0x00A0F158
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SAiConditions(Pointer, false, true);
		}

		// Token: 0x0602BFB8 RID: 180152 RVA: 0x00A10F62 File Offset: 0x00A0F162
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SAiConditions(Pointer, MemoryOwner);
		}

		// Token: 0x04016F86 RID: 94086
		public const string __ObjectPath = "/Game/Aki/Character/Monster/Common/SAiConditions.SAiConditions";

		// Token: 0x04016F87 RID: 94087
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04016F88 RID: 94088
		internal static int __PropertyOffset_0;

		// Token: 0x04016F89 RID: 94089
		[Nullable(2)]
		private TMap<FGameplayTag, FFloatRange> _Tags;

		// Token: 0x04016F8A RID: 94090
		internal static int __PropertyOffset_1;

		// Token: 0x04016F8B RID: 94091
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EAttributeType>, FFloatRange> _Attributes;

		// Token: 0x04016F8C RID: 94092
		internal static int __PropertyOffset_2;

		// Token: 0x04016F8D RID: 94093
		[Nullable(2)]
		private TArray<SAiAttributeRate> _AttributeRates;

		// Token: 0x04016F8E RID: 94094
		internal static int __PropertyOffset_3;
	}
}
