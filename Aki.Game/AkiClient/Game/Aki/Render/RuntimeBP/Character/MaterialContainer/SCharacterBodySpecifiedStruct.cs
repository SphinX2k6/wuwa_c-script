using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialContainer
{
	// Token: 0x02003E25 RID: 15909
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialContainer/SCharacterBodySpecifiedStruct.SCharacterBodySpecifiedStruct")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SCharacterBodySpecifiedStruct : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06027DF3 RID: 163315 RVA: 0x0099D7E4 File Offset: 0x0099B9E4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCharacterBodySpecifiedStruct._ScriptStructPtr != 0) ? SCharacterBodySpecifiedStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Character/MaterialContainer/SCharacterBodySpecifiedStruct.SCharacterBodySpecifiedStruct", ref SCharacterBodySpecifiedStruct._ScriptStructPtr);
		}

		// Token: 0x17005A88 RID: 23176
		// (get) Token: 0x06027DF4 RID: 163316 RVA: 0x0099D808 File Offset: 0x0099BA08
		// (set) Token: 0x06027DF5 RID: 163317 RVA: 0x0099D81C File Offset: 0x0099BA1C
		public unsafe TEnumAsByte<ECharacterBodySpecifiedType> SpecifiedType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterBodySpecifiedStruct.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterBodySpecifiedStruct.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005A89 RID: 23177
		// (get) Token: 0x06027DF6 RID: 163318 RVA: 0x0099D834 File Offset: 0x0099BA34
		// (set) Token: 0x06027DF7 RID: 163319 RVA: 0x0099D877 File Offset: 0x0099BA77
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<ECharacterBodyType>> BodyTypes
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<ECharacterBodyType>> result;
				if ((result = this._BodyTypes) == null)
				{
					result = (this._BodyTypes = new TArray<TEnumAsByte<ECharacterBodyType>>(base.NativePtr + (IntPtr)SCharacterBodySpecifiedStruct.__PropertyOffset_1, base.MemoryOwner ?? this));
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
				this.BodyTypes.CopyAssign(value);
			}
		}

		// Token: 0x06027DF8 RID: 163320 RVA: 0x0099D885 File Offset: 0x0099BA85
		public SCharacterBodySpecifiedStruct()
		{
		}

		// Token: 0x06027DF9 RID: 163321 RVA: 0x0099D88D File Offset: 0x0099BA8D
		public SCharacterBodySpecifiedStruct(TEnumAsByte<ECharacterBodySpecifiedType> SpecifiedType, [Nullable(new byte[]
		{
			1,
			0
		})] TArray<TEnumAsByte<ECharacterBodyType>> BodyTypes)
		{
			this.SpecifiedType = SpecifiedType;
			this.BodyTypes = BodyTypes;
		}

		// Token: 0x06027DFA RID: 163322 RVA: 0x0099D8A3 File Offset: 0x0099BAA3
		protected override IntPtr GetUStructPtr()
		{
			return SCharacterBodySpecifiedStruct.StaticStruct();
		}

		// Token: 0x06027DFB RID: 163323 RVA: 0x0099D8AF File Offset: 0x0099BAAF
		[NullableContext(2)]
		public SCharacterBodySpecifiedStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027DFC RID: 163324 RVA: 0x0099D8B9 File Offset: 0x0099BAB9
		public SCharacterBodySpecifiedStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027DFD RID: 163325 RVA: 0x0099D8C4 File Offset: 0x0099BAC4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCharacterBodySpecifiedStruct(Pointer, false, true);
		}

		// Token: 0x06027DFE RID: 163326 RVA: 0x0099D8CE File Offset: 0x0099BACE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCharacterBodySpecifiedStruct(Pointer, MemoryOwner);
		}

		// Token: 0x0401438E RID: 82830
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/MaterialContainer/SCharacterBodySpecifiedStruct.SCharacterBodySpecifiedStruct";

		// Token: 0x0401438F RID: 82831
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014390 RID: 82832
		internal static int __PropertyOffset_0;

		// Token: 0x04014391 RID: 82833
		internal static int __PropertyOffset_1;

		// Token: 0x04014392 RID: 82834
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<ECharacterBodyType>> _BodyTypes;
	}
}
