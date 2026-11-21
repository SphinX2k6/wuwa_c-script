using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x02003199 RID: 12697
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Qte/SCommonQte.SCommonQte")]
	[UnrealStructLayout(1704, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1704)]
	public class SCommonQte : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F4CD RID: 128205 RVA: 0x0092AB9D File Offset: 0x00928D9D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCommonQte._ScriptStructPtr != 0) ? SCommonQte._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Qte/SCommonQte.SCommonQte", ref SCommonQte._ScriptStructPtr);
		}

		// Token: 0x17003886 RID: 14470
		// (get) Token: 0x0601F4CE RID: 128206 RVA: 0x0092ABC1 File Offset: 0x00928DC1
		// (set) Token: 0x0601F4CF RID: 128207 RVA: 0x0092ABD5 File Offset: 0x00928DD5
		public unsafe string Desc
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCommonQte.__PropertyOffset_Desc)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCommonQte.__PropertyOffset_Desc)), value);
			}
		}

		// Token: 0x17003887 RID: 14471
		// (get) Token: 0x0601F4D0 RID: 128208 RVA: 0x0092ABEC File Offset: 0x00928DEC
		// (set) Token: 0x0601F4D1 RID: 128209 RVA: 0x0092AC2F File Offset: 0x00928E2F
		public SCommonQte_Base BaseConfig
		{
			get
			{
				base.FastCheckIsValid();
				SCommonQte_Base result;
				if ((result = this._BaseConfig) == null)
				{
					result = (this._BaseConfig = new SCommonQte_Base(base.NativePtr + (IntPtr)SCommonQte.__PropertyOffset_BaseConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCommonQte_Base.StaticStruct(), base.NativePtr + (IntPtr)SCommonQte.__PropertyOffset_BaseConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003888 RID: 14472
		// (get) Token: 0x0601F4D2 RID: 128210 RVA: 0x0092AC50 File Offset: 0x00928E50
		// (set) Token: 0x0601F4D3 RID: 128211 RVA: 0x0092AC93 File Offset: 0x00928E93
		public SCommonQte_Extra ExtraConfig
		{
			get
			{
				base.FastCheckIsValid();
				SCommonQte_Extra result;
				if ((result = this._ExtraConfig) == null)
				{
					result = (this._ExtraConfig = new SCommonQte_Extra(base.NativePtr + (IntPtr)SCommonQte.__PropertyOffset_ExtraConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCommonQte_Extra.StaticStruct(), base.NativePtr + (IntPtr)SCommonQte.__PropertyOffset_ExtraConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003889 RID: 14473
		// (get) Token: 0x0601F4D4 RID: 128212 RVA: 0x0092ACB4 File Offset: 0x00928EB4
		// (set) Token: 0x0601F4D5 RID: 128213 RVA: 0x0092ACF7 File Offset: 0x00928EF7
		public SCommonQte_Audio AudioConfig
		{
			get
			{
				base.FastCheckIsValid();
				SCommonQte_Audio result;
				if ((result = this._AudioConfig) == null)
				{
					result = (this._AudioConfig = new SCommonQte_Audio(base.NativePtr + (IntPtr)SCommonQte.__PropertyOffset_AudioConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCommonQte_Audio.StaticStruct(), base.NativePtr + (IntPtr)SCommonQte.__PropertyOffset_AudioConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601F4D6 RID: 128214 RVA: 0x0092AD18 File Offset: 0x00928F18
		public SCommonQte()
		{
		}

		// Token: 0x0601F4D7 RID: 128215 RVA: 0x0092AD20 File Offset: 0x00928F20
		protected override IntPtr GetUStructPtr()
		{
			return SCommonQte.StaticStruct();
		}

		// Token: 0x0601F4D8 RID: 128216 RVA: 0x0092AD2C File Offset: 0x00928F2C
		[NullableContext(2)]
		public SCommonQte(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F4D9 RID: 128217 RVA: 0x0092AD36 File Offset: 0x00928F36
		public SCommonQte(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F4DA RID: 128218 RVA: 0x0092AD41 File Offset: 0x00928F41
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCommonQte(Pointer, false, true);
		}

		// Token: 0x0601F4DB RID: 128219 RVA: 0x0092AD4B File Offset: 0x00928F4B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCommonQte(Pointer, MemoryOwner);
		}

		// Token: 0x04010C76 RID: 68726
		public const string __ObjectPath = "/Game/Aki/Data/Qte/SCommonQte.SCommonQte";

		// Token: 0x04010C77 RID: 68727
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010C78 RID: 68728
		internal static int __PropertyOffset_Desc;

		// Token: 0x04010C79 RID: 68729
		internal static int __PropertyOffset_BaseConfig;

		// Token: 0x04010C7A RID: 68730
		[Nullable(2)]
		private SCommonQte_Base _BaseConfig;

		// Token: 0x04010C7B RID: 68731
		internal static int __PropertyOffset_ExtraConfig;

		// Token: 0x04010C7C RID: 68732
		[Nullable(2)]
		private SCommonQte_Extra _ExtraConfig;

		// Token: 0x04010C7D RID: 68733
		internal static int __PropertyOffset_AudioConfig;

		// Token: 0x04010C7E RID: 68734
		[Nullable(2)]
		private SCommonQte_Audio _AudioConfig;
	}
}
