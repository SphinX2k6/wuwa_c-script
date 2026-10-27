using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x02003ED4 RID: 16084
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Qte/SCommonQte.SCommonQte")]
	[UnrealStructLayout(1704, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1704)]
	public class SCommonQte : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028A9A RID: 166554 RVA: 0x009B1A0C File Offset: 0x009AFC0C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCommonQte._ScriptStructPtr != 0) ? SCommonQte._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Qte/SCommonQte.SCommonQte", ref SCommonQte._ScriptStructPtr);
		}

		// Token: 0x17005EFA RID: 24314
		// (get) Token: 0x06028A9B RID: 166555 RVA: 0x009B1A30 File Offset: 0x009AFC30
		// (set) Token: 0x06028A9C RID: 166556 RVA: 0x009B1A44 File Offset: 0x009AFC44
		public unsafe string Desc
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCommonQte.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCommonQte.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17005EFB RID: 24315
		// (get) Token: 0x06028A9D RID: 166557 RVA: 0x009B1A5C File Offset: 0x009AFC5C
		// (set) Token: 0x06028A9E RID: 166558 RVA: 0x009B1A9F File Offset: 0x009AFC9F
		public SCommonQte_Base BaseConfig
		{
			get
			{
				base.FastCheckIsValid();
				SCommonQte_Base result;
				if ((result = this._BaseConfig) == null)
				{
					result = (this._BaseConfig = new SCommonQte_Base(base.NativePtr + (IntPtr)SCommonQte.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCommonQte_Base.StaticStruct(), base.NativePtr + (IntPtr)SCommonQte.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005EFC RID: 24316
		// (get) Token: 0x06028A9F RID: 166559 RVA: 0x009B1AC0 File Offset: 0x009AFCC0
		// (set) Token: 0x06028AA0 RID: 166560 RVA: 0x009B1B03 File Offset: 0x009AFD03
		public SCommonQte_Extra ExtraConfig
		{
			get
			{
				base.FastCheckIsValid();
				SCommonQte_Extra result;
				if ((result = this._ExtraConfig) == null)
				{
					result = (this._ExtraConfig = new SCommonQte_Extra(base.NativePtr + (IntPtr)SCommonQte.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCommonQte_Extra.StaticStruct(), base.NativePtr + (IntPtr)SCommonQte.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005EFD RID: 24317
		// (get) Token: 0x06028AA1 RID: 166561 RVA: 0x009B1B24 File Offset: 0x009AFD24
		// (set) Token: 0x06028AA2 RID: 166562 RVA: 0x009B1B67 File Offset: 0x009AFD67
		public SCommonQte_Audio AudioConfig
		{
			get
			{
				base.FastCheckIsValid();
				SCommonQte_Audio result;
				if ((result = this._AudioConfig) == null)
				{
					result = (this._AudioConfig = new SCommonQte_Audio(base.NativePtr + (IntPtr)SCommonQte.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCommonQte_Audio.StaticStruct(), base.NativePtr + (IntPtr)SCommonQte.__PropertyOffset_3, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06028AA3 RID: 166563 RVA: 0x009B1B88 File Offset: 0x009AFD88
		public SCommonQte()
		{
		}

		// Token: 0x06028AA4 RID: 166564 RVA: 0x009B1B90 File Offset: 0x009AFD90
		public SCommonQte(string Desc, SCommonQte_Base BaseConfig, SCommonQte_Extra ExtraConfig, SCommonQte_Audio AudioConfig)
		{
			this.Desc = Desc;
			this.BaseConfig = BaseConfig;
			this.ExtraConfig = ExtraConfig;
			this.AudioConfig = AudioConfig;
		}

		// Token: 0x06028AA5 RID: 166565 RVA: 0x009B1BB5 File Offset: 0x009AFDB5
		protected override IntPtr GetUStructPtr()
		{
			return SCommonQte.StaticStruct();
		}

		// Token: 0x06028AA6 RID: 166566 RVA: 0x009B1BC1 File Offset: 0x009AFDC1
		[NullableContext(2)]
		public SCommonQte(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028AA7 RID: 166567 RVA: 0x009B1BCB File Offset: 0x009AFDCB
		public SCommonQte(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028AA8 RID: 166568 RVA: 0x009B1BD6 File Offset: 0x009AFDD6
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCommonQte(Pointer, false, true);
		}

		// Token: 0x06028AA9 RID: 166569 RVA: 0x009B1BE0 File Offset: 0x009AFDE0
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCommonQte(Pointer, MemoryOwner);
		}

		// Token: 0x04014C8F RID: 85135
		public const string __ObjectPath = "/Game/Aki/Data/Qte/SCommonQte.SCommonQte";

		// Token: 0x04014C90 RID: 85136
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014C91 RID: 85137
		internal static int __PropertyOffset_0;

		// Token: 0x04014C92 RID: 85138
		internal static int __PropertyOffset_1;

		// Token: 0x04014C93 RID: 85139
		[Nullable(2)]
		private SCommonQte_Base _BaseConfig;

		// Token: 0x04014C94 RID: 85140
		internal static int __PropertyOffset_2;

		// Token: 0x04014C95 RID: 85141
		[Nullable(2)]
		private SCommonQte_Extra _ExtraConfig;

		// Token: 0x04014C96 RID: 85142
		internal static int __PropertyOffset_3;

		// Token: 0x04014C97 RID: 85143
		[Nullable(2)]
		private SCommonQte_Audio _AudioConfig;
	}
}
