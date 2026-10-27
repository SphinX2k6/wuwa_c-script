using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.QuickTimeAction
{
	// Token: 0x02003EB1 RID: 16049
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/SQtaCondition_Content.SQtaCondition_Content")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 43)]
	public class SQtaCondition_Content : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602895C RID: 166236 RVA: 0x009AFD9F File Offset: 0x009ADF9F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SQtaCondition_Content._ScriptStructPtr != 0) ? SQtaCondition_Content._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/QuickTimeAction/SQtaCondition_Content.SQtaCondition_Content", ref SQtaCondition_Content._ScriptStructPtr);
		}

		// Token: 0x17005E9D RID: 24221
		// (get) Token: 0x0602895D RID: 166237 RVA: 0x009AFDC3 File Offset: 0x009ADFC3
		// (set) Token: 0x0602895E RID: 166238 RVA: 0x009AFDD7 File Offset: 0x009ADFD7
		public unsafe TEnumAsByte<EQtaConditionType> ConditionType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaCondition_Content.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaCondition_Content.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005E9E RID: 24222
		// (get) Token: 0x0602895F RID: 166239 RVA: 0x009AFDEC File Offset: 0x009ADFEC
		// (set) Token: 0x06028960 RID: 166240 RVA: 0x009AFE00 File Offset: 0x009AE000
		public unsafe TEnumAsByte<EQtaCondition_CheckInputType> InputMatchType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaCondition_Content.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaCondition_Content.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005E9F RID: 24223
		// (get) Token: 0x06028961 RID: 166241 RVA: 0x009AFE18 File Offset: 0x009AE018
		// (set) Token: 0x06028962 RID: 166242 RVA: 0x009AFE5B File Offset: 0x009AE05B
		[Nullable(1)]
		public FGameplayTagContainer Tags
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._Tags) == null)
				{
					result = (this._Tags = new FGameplayTagContainer(base.NativePtr + (IntPtr)SQtaCondition_Content.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SQtaCondition_Content.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005EA0 RID: 24224
		// (get) Token: 0x06028963 RID: 166243 RVA: 0x009AFE7C File Offset: 0x009AE07C
		// (set) Token: 0x06028964 RID: 166244 RVA: 0x009AFE8C File Offset: 0x009AE08C
		public unsafe bool AnyTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaCondition_Content.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaCondition_Content.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005EA1 RID: 24225
		// (get) Token: 0x06028965 RID: 166245 RVA: 0x009AFE9D File Offset: 0x009AE09D
		// (set) Token: 0x06028966 RID: 166246 RVA: 0x009AFEB1 File Offset: 0x009AE0B1
		public unsafe TEnumAsByte<EQtaCondition_EventName> EventName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaCondition_Content.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaCondition_Content.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005EA2 RID: 24226
		// (get) Token: 0x06028967 RID: 166247 RVA: 0x009AFEC6 File Offset: 0x009AE0C6
		// (set) Token: 0x06028968 RID: 166248 RVA: 0x009AFED6 File Offset: 0x009AE0D6
		public unsafe bool Reverse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaCondition_Content.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaCondition_Content.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x06028969 RID: 166249 RVA: 0x009AFEE7 File Offset: 0x009AE0E7
		public SQtaCondition_Content()
		{
		}

		// Token: 0x0602896A RID: 166250 RVA: 0x009AFEEF File Offset: 0x009AE0EF
		public SQtaCondition_Content(TEnumAsByte<EQtaConditionType> ConditionType, TEnumAsByte<EQtaCondition_CheckInputType> InputMatchType, [Nullable(1)] FGameplayTagContainer Tags, bool AnyTag, TEnumAsByte<EQtaCondition_EventName> EventName, bool Reverse)
		{
			this.ConditionType = ConditionType;
			this.InputMatchType = InputMatchType;
			this.Tags = Tags;
			this.AnyTag = AnyTag;
			this.EventName = EventName;
			this.Reverse = Reverse;
		}

		// Token: 0x0602896B RID: 166251 RVA: 0x009AFF24 File Offset: 0x009AE124
		protected override IntPtr GetUStructPtr()
		{
			return SQtaCondition_Content.StaticStruct();
		}

		// Token: 0x0602896C RID: 166252 RVA: 0x009AFF30 File Offset: 0x009AE130
		[NullableContext(2)]
		public SQtaCondition_Content(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602896D RID: 166253 RVA: 0x009AFF3A File Offset: 0x009AE13A
		public SQtaCondition_Content(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602896E RID: 166254 RVA: 0x009AFF45 File Offset: 0x009AE145
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SQtaCondition_Content(Pointer, false, true);
		}

		// Token: 0x0602896F RID: 166255 RVA: 0x009AFF4F File Offset: 0x009AE14F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SQtaCondition_Content(Pointer, MemoryOwner);
		}

		// Token: 0x04014B6D RID: 84845
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/QuickTimeAction/SQtaCondition_Content.SQtaCondition_Content";

		// Token: 0x04014B6E RID: 84846
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014B6F RID: 84847
		internal static int __PropertyOffset_0;

		// Token: 0x04014B70 RID: 84848
		internal static int __PropertyOffset_1;

		// Token: 0x04014B71 RID: 84849
		internal static int __PropertyOffset_2;

		// Token: 0x04014B72 RID: 84850
		[Nullable(2)]
		private FGameplayTagContainer _Tags;

		// Token: 0x04014B73 RID: 84851
		internal static int __PropertyOffset_3;

		// Token: 0x04014B74 RID: 84852
		internal static int __PropertyOffset_4;

		// Token: 0x04014B75 RID: 84853
		internal static int __PropertyOffset_5;
	}
}
