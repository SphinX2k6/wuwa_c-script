using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x02003EDE RID: 16094
	[UnrealObjectPath("/Game/Aki/Data/Qte/SCommonQte_SelectOption.SCommonQte_SelectOption")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class SCommonQte_SelectOption : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028BAD RID: 166829 RVA: 0x009B3490 File Offset: 0x009B1690
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCommonQte_SelectOption._ScriptStructPtr != 0) ? SCommonQte_SelectOption._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Qte/SCommonQte_SelectOption.SCommonQte_SelectOption", ref SCommonQte_SelectOption._ScriptStructPtr);
		}

		// Token: 0x17005F5C RID: 24412
		// (get) Token: 0x06028BAE RID: 166830 RVA: 0x009B34B4 File Offset: 0x009B16B4
		// (set) Token: 0x06028BAF RID: 166831 RVA: 0x009B34C8 File Offset: 0x009B16C8
		public unsafe TEnumAsByte<ECommonQteViewType_SelectOption> ViewType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_SelectOption.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_SelectOption.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005F5D RID: 24413
		// (get) Token: 0x06028BB0 RID: 166832 RVA: 0x009B34E0 File Offset: 0x009B16E0
		// (set) Token: 0x06028BB1 RID: 166833 RVA: 0x009B3523 File Offset: 0x009B1723
		[Nullable(1)]
		public TArray<SCommonQteButton> UIConfigList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<SCommonQteButton> result;
				if ((result = this._UIConfigList) == null)
				{
					result = (this._UIConfigList = new TArray<SCommonQteButton>(base.NativePtr + (IntPtr)SCommonQte_SelectOption.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.UIConfigList.CopyAssign(value);
			}
		}

		// Token: 0x17005F5E RID: 24414
		// (get) Token: 0x06028BB2 RID: 166834 RVA: 0x009B3531 File Offset: 0x009B1731
		// (set) Token: 0x06028BB3 RID: 166835 RVA: 0x009B3541 File Offset: 0x009B1741
		public unsafe int DefaultOption
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_SelectOption.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_SelectOption.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005F5F RID: 24415
		// (get) Token: 0x06028BB4 RID: 166836 RVA: 0x009B3552 File Offset: 0x009B1752
		// (set) Token: 0x06028BB5 RID: 166837 RVA: 0x009B3562 File Offset: 0x009B1762
		public unsafe bool IsAttachToActor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_SelectOption.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_SelectOption.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F60 RID: 24416
		// (get) Token: 0x06028BB6 RID: 166838 RVA: 0x009B3573 File Offset: 0x009B1773
		// (set) Token: 0x06028BB7 RID: 166839 RVA: 0x009B3587 File Offset: 0x009B1787
		public unsafe SCommonQte_Attach AttachConfig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCommonQte_SelectOption.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCommonQte_SelectOption.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x06028BB8 RID: 166840 RVA: 0x009B359C File Offset: 0x009B179C
		public SCommonQte_SelectOption()
		{
		}

		// Token: 0x06028BB9 RID: 166841 RVA: 0x009B35A4 File Offset: 0x009B17A4
		public SCommonQte_SelectOption(TEnumAsByte<ECommonQteViewType_SelectOption> ViewType, [Nullable(1)] TArray<SCommonQteButton> UIConfigList, int DefaultOption, bool IsAttachToActor, SCommonQte_Attach AttachConfig)
		{
			this.ViewType = ViewType;
			this.UIConfigList = UIConfigList;
			this.DefaultOption = DefaultOption;
			this.IsAttachToActor = IsAttachToActor;
			this.AttachConfig = AttachConfig;
		}

		// Token: 0x06028BBA RID: 166842 RVA: 0x009B35D1 File Offset: 0x009B17D1
		protected override IntPtr GetUStructPtr()
		{
			return SCommonQte_SelectOption.StaticStruct();
		}

		// Token: 0x06028BBB RID: 166843 RVA: 0x009B35DD File Offset: 0x009B17DD
		[NullableContext(2)]
		public SCommonQte_SelectOption(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028BBC RID: 166844 RVA: 0x009B35E7 File Offset: 0x009B17E7
		public SCommonQte_SelectOption(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028BBD RID: 166845 RVA: 0x009B35F2 File Offset: 0x009B17F2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCommonQte_SelectOption(Pointer, false, true);
		}

		// Token: 0x06028BBE RID: 166846 RVA: 0x009B35FC File Offset: 0x009B17FC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCommonQte_SelectOption(Pointer, MemoryOwner);
		}

		// Token: 0x04014D16 RID: 85270
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Qte/SCommonQte_SelectOption.SCommonQte_SelectOption";

		// Token: 0x04014D17 RID: 85271
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014D18 RID: 85272
		internal static int __PropertyOffset_0;

		// Token: 0x04014D19 RID: 85273
		internal static int __PropertyOffset_1;

		// Token: 0x04014D1A RID: 85274
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SCommonQteButton> _UIConfigList;

		// Token: 0x04014D1B RID: 85275
		internal static int __PropertyOffset_2;

		// Token: 0x04014D1C RID: 85276
		internal static int __PropertyOffset_3;

		// Token: 0x04014D1D RID: 85277
		internal static int __PropertyOffset_4;
	}
}
