using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200333E RID: 13118
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SCharacterConfigHelperParam.SCharacterConfigHelperParam")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class SCharacterConfigHelperParam : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021286 RID: 135814 RVA: 0x0095A825 File Offset: 0x00958A25
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCharacterConfigHelperParam._ScriptStructPtr != 0) ? SCharacterConfigHelperParam._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SCharacterConfigHelperParam.SCharacterConfigHelperParam", ref SCharacterConfigHelperParam._ScriptStructPtr);
		}

		// Token: 0x170042E2 RID: 17122
		// (get) Token: 0x06021287 RID: 135815 RVA: 0x0095A84C File Offset: 0x00958A4C
		// (set) Token: 0x06021288 RID: 135816 RVA: 0x0095A88F File Offset: 0x00958A8F
		public FGameplayTagContainer ActivateTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._ActivateTags) == null)
				{
					result = (this._ActivateTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)SCharacterConfigHelperParam.__PropertyOffset_ActivateTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SCharacterConfigHelperParam.__PropertyOffset_ActivateTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170042E3 RID: 17123
		// (get) Token: 0x06021289 RID: 135817 RVA: 0x0095A8B0 File Offset: 0x00958AB0
		// (set) Token: 0x0602128A RID: 135818 RVA: 0x0095A8C0 File Offset: 0x00958AC0
		public unsafe int Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterConfigHelperParam.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterConfigHelperParam.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x170042E4 RID: 17124
		// (get) Token: 0x0602128B RID: 135819 RVA: 0x0095A8D1 File Offset: 0x00958AD1
		// (set) Token: 0x0602128C RID: 135820 RVA: 0x0095A8E1 File Offset: 0x00958AE1
		public unsafe EConfigApplyType 附加模式
		{
			get
			{
				return (EConfigApplyType)(*(base.NativePtr + (IntPtr)SCharacterConfigHelperParam.__PropertyOffset_附加模式));
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterConfigHelperParam.__PropertyOffset_附加模式) = (byte)value;
			}
		}

		// Token: 0x170042E5 RID: 17125
		// (get) Token: 0x0602128D RID: 135821 RVA: 0x0095A8F2 File Offset: 0x00958AF2
		// (set) Token: 0x0602128E RID: 135822 RVA: 0x0095A906 File Offset: 0x00958B06
		[Nullable(2)]
		public unsafe UKuroDataBag DataBag数据
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroDataBag>(base.NativePtr / (IntPtr)sizeof(void*) + SCharacterConfigHelperParam.__PropertyOffset_DataBag数据);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SCharacterConfigHelperParam.__PropertyOffset_DataBag数据, value);
			}
		}

		// Token: 0x0602128F RID: 135823 RVA: 0x0095A91B File Offset: 0x00958B1B
		public SCharacterConfigHelperParam()
		{
		}

		// Token: 0x06021290 RID: 135824 RVA: 0x0095A923 File Offset: 0x00958B23
		protected override IntPtr GetUStructPtr()
		{
			return SCharacterConfigHelperParam.StaticStruct();
		}

		// Token: 0x06021291 RID: 135825 RVA: 0x0095A92F File Offset: 0x00958B2F
		[NullableContext(2)]
		public SCharacterConfigHelperParam(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021292 RID: 135826 RVA: 0x0095A939 File Offset: 0x00958B39
		public SCharacterConfigHelperParam(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021293 RID: 135827 RVA: 0x0095A944 File Offset: 0x00958B44
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCharacterConfigHelperParam(Pointer, false, true);
		}

		// Token: 0x06021294 RID: 135828 RVA: 0x0095A94E File Offset: 0x00958B4E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCharacterConfigHelperParam(Pointer, MemoryOwner);
		}

		// Token: 0x0401220E RID: 74254
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SCharacterConfigHelperParam.SCharacterConfigHelperParam";

		// Token: 0x0401220F RID: 74255
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012210 RID: 74256
		internal static int __PropertyOffset_ActivateTags;

		// Token: 0x04012211 RID: 74257
		[Nullable(2)]
		private FGameplayTagContainer _ActivateTags;

		// Token: 0x04012212 RID: 74258
		internal static int __PropertyOffset_Priority;

		// Token: 0x04012213 RID: 74259
		internal static int __PropertyOffset_附加模式;

		// Token: 0x04012214 RID: 74260
		internal static int __PropertyOffset_DataBag数据;
	}
}
