using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042ED RID: 17133
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SAttributeModifierData.SAttributeModifierData")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class SAttributeModifierData : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C3BE RID: 181182 RVA: 0x00A1B09C File Offset: 0x00A1929C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SAttributeModifierData._ScriptStructPtr != 0) ? SAttributeModifierData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SAttributeModifierData.SAttributeModifierData", ref SAttributeModifierData._ScriptStructPtr);
		}

		// Token: 0x17006E43 RID: 28227
		// (get) Token: 0x0602C3BF RID: 181183 RVA: 0x00A1B0C0 File Offset: 0x00A192C0
		// (set) Token: 0x0602C3C0 RID: 181184 RVA: 0x00A1B103 File Offset: 0x00A19303
		[Nullable(1)]
		public FGameplayAttribute 属性类型
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FGameplayAttribute result;
				if ((result = this._属性类型) == null)
				{
					result = (this._属性类型 = new FGameplayAttribute(base.NativePtr + (IntPtr)SAttributeModifierData.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttribute.StaticStruct(), base.NativePtr + (IntPtr)SAttributeModifierData.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006E44 RID: 28228
		// (get) Token: 0x0602C3C1 RID: 181185 RVA: 0x00A1B124 File Offset: 0x00A19324
		// (set) Token: 0x0602C3C2 RID: 181186 RVA: 0x00A1B138 File Offset: 0x00A19338
		public unsafe TEnumAsByte<EAttributeTarget> 操作对象
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAttributeModifierData.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAttributeModifierData.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006E45 RID: 28229
		// (get) Token: 0x0602C3C3 RID: 181187 RVA: 0x00A1B14D File Offset: 0x00A1934D
		// (set) Token: 0x0602C3C4 RID: 181188 RVA: 0x00A1B161 File Offset: 0x00A19361
		public unsafe TEnumAsByte<EAttributeOperation> 操作
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAttributeModifierData.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAttributeModifierData.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006E46 RID: 28230
		// (get) Token: 0x0602C3C5 RID: 181189 RVA: 0x00A1B176 File Offset: 0x00A19376
		// (set) Token: 0x0602C3C6 RID: 181190 RVA: 0x00A1B186 File Offset: 0x00A19386
		public unsafe float 值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAttributeModifierData.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAttributeModifierData.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x0602C3C7 RID: 181191 RVA: 0x00A1B197 File Offset: 0x00A19397
		public SAttributeModifierData()
		{
		}

		// Token: 0x0602C3C8 RID: 181192 RVA: 0x00A1B19F File Offset: 0x00A1939F
		public SAttributeModifierData([Nullable(1)] FGameplayAttribute 属性类型, TEnumAsByte<EAttributeTarget> 操作对象, TEnumAsByte<EAttributeOperation> 操作, float 值)
		{
			this.属性类型 = 属性类型;
			this.操作对象 = 操作对象;
			this.操作 = 操作;
			this.值 = 值;
		}

		// Token: 0x0602C3C9 RID: 181193 RVA: 0x00A1B1C4 File Offset: 0x00A193C4
		protected override IntPtr GetUStructPtr()
		{
			return SAttributeModifierData.StaticStruct();
		}

		// Token: 0x0602C3CA RID: 181194 RVA: 0x00A1B1D0 File Offset: 0x00A193D0
		[NullableContext(2)]
		public SAttributeModifierData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C3CB RID: 181195 RVA: 0x00A1B1DA File Offset: 0x00A193DA
		public SAttributeModifierData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C3CC RID: 181196 RVA: 0x00A1B1E5 File Offset: 0x00A193E5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SAttributeModifierData(Pointer, false, true);
		}

		// Token: 0x0602C3CD RID: 181197 RVA: 0x00A1B1EF File Offset: 0x00A193EF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SAttributeModifierData(Pointer, MemoryOwner);
		}

		// Token: 0x04017546 RID: 95558
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SAttributeModifierData.SAttributeModifierData";

		// Token: 0x04017547 RID: 95559
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017548 RID: 95560
		internal static int __PropertyOffset_0;

		// Token: 0x04017549 RID: 95561
		[Nullable(2)]
		private FGameplayAttribute _属性类型;

		// Token: 0x0401754A RID: 95562
		internal static int __PropertyOffset_1;

		// Token: 0x0401754B RID: 95563
		internal static int __PropertyOffset_2;

		// Token: 0x0401754C RID: 95564
		internal static int __PropertyOffset_3;
	}
}
