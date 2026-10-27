using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Foliage
{
	// Token: 0x02003D84 RID: 15748
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Foliage/Struct_TranslucentFoliage.Struct_TranslucentFoliage")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class Struct_TranslucentFoliage : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026B2C RID: 158508 RVA: 0x0097C4E4 File Offset: 0x0097A6E4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (Struct_TranslucentFoliage._ScriptStructPtr != 0) ? Struct_TranslucentFoliage._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Foliage/Struct_TranslucentFoliage.Struct_TranslucentFoliage", ref Struct_TranslucentFoliage._ScriptStructPtr);
		}

		// Token: 0x170053AA RID: 21418
		// (get) Token: 0x06026B2D RID: 158509 RVA: 0x0097C508 File Offset: 0x0097A708
		// (set) Token: 0x06026B2E RID: 158510 RVA: 0x0097C51C File Offset: 0x0097A71C
		[Nullable(2)]
		public unsafe UStaticMesh StaticMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + Struct_TranslucentFoliage.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Struct_TranslucentFoliage.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170053AB RID: 21419
		// (get) Token: 0x06026B2F RID: 158511 RVA: 0x0097C534 File Offset: 0x0097A734
		// (set) Token: 0x06026B30 RID: 158512 RVA: 0x0097C577 File Offset: 0x0097A777
		public TArray<UMaterialInterface> PCMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._PCMaterials) == null)
				{
					result = (this._PCMaterials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)Struct_TranslucentFoliage.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PCMaterials.CopyAssign(value);
			}
		}

		// Token: 0x170053AC RID: 21420
		// (get) Token: 0x06026B31 RID: 158513 RVA: 0x0097C588 File Offset: 0x0097A788
		// (set) Token: 0x06026B32 RID: 158514 RVA: 0x0097C5CB File Offset: 0x0097A7CB
		public TArray<UMaterialInterface> PCMaterialsOffFade
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._PCMaterialsOffFade) == null)
				{
					result = (this._PCMaterialsOffFade = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)Struct_TranslucentFoliage.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PCMaterialsOffFade.CopyAssign(value);
			}
		}

		// Token: 0x170053AD RID: 21421
		// (get) Token: 0x06026B33 RID: 158515 RVA: 0x0097C5DC File Offset: 0x0097A7DC
		// (set) Token: 0x06026B34 RID: 158516 RVA: 0x0097C61F File Offset: 0x0097A81F
		public TArray<UMaterialInterface> MobileMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._MobileMaterials) == null)
				{
					result = (this._MobileMaterials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)Struct_TranslucentFoliage.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MobileMaterials.CopyAssign(value);
			}
		}

		// Token: 0x170053AE RID: 21422
		// (get) Token: 0x06026B35 RID: 158517 RVA: 0x0097C630 File Offset: 0x0097A830
		// (set) Token: 0x06026B36 RID: 158518 RVA: 0x0097C673 File Offset: 0x0097A873
		public TArray<UMaterialInterface> MobileMaterialsOffFade
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._MobileMaterialsOffFade) == null)
				{
					result = (this._MobileMaterialsOffFade = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)Struct_TranslucentFoliage.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MobileMaterialsOffFade.CopyAssign(value);
			}
		}

		// Token: 0x170053AF RID: 21423
		// (get) Token: 0x06026B37 RID: 158519 RVA: 0x0097C684 File Offset: 0x0097A884
		// (set) Token: 0x06026B38 RID: 158520 RVA: 0x0097C6C7 File Offset: 0x0097A8C7
		public TArray<UMaterialInterface> PCMaterialsNoDissolve
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._PCMaterialsNoDissolve) == null)
				{
					result = (this._PCMaterialsNoDissolve = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)Struct_TranslucentFoliage.__PropertyOffset_5, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PCMaterialsNoDissolve.CopyAssign(value);
			}
		}

		// Token: 0x170053B0 RID: 21424
		// (get) Token: 0x06026B39 RID: 158521 RVA: 0x0097C6D8 File Offset: 0x0097A8D8
		// (set) Token: 0x06026B3A RID: 158522 RVA: 0x0097C71B File Offset: 0x0097A91B
		public TArray<UMaterialInterface> MobileMaterialsNoDissolve
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._MobileMaterialsNoDissolve) == null)
				{
					result = (this._MobileMaterialsNoDissolve = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)Struct_TranslucentFoliage.__PropertyOffset_6, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MobileMaterialsNoDissolve.CopyAssign(value);
			}
		}

		// Token: 0x06026B3B RID: 158523 RVA: 0x0097C729 File Offset: 0x0097A929
		public Struct_TranslucentFoliage()
		{
		}

		// Token: 0x06026B3C RID: 158524 RVA: 0x0097C731 File Offset: 0x0097A931
		public Struct_TranslucentFoliage(UStaticMesh StaticMesh, TArray<UMaterialInterface> PCMaterials, TArray<UMaterialInterface> PCMaterialsOffFade, TArray<UMaterialInterface> MobileMaterials, TArray<UMaterialInterface> MobileMaterialsOffFade, TArray<UMaterialInterface> PCMaterialsNoDissolve, TArray<UMaterialInterface> MobileMaterialsNoDissolve)
		{
			this.StaticMesh = StaticMesh;
			this.PCMaterials = PCMaterials;
			this.PCMaterialsOffFade = PCMaterialsOffFade;
			this.MobileMaterials = MobileMaterials;
			this.MobileMaterialsOffFade = MobileMaterialsOffFade;
			this.PCMaterialsNoDissolve = PCMaterialsNoDissolve;
			this.MobileMaterialsNoDissolve = MobileMaterialsNoDissolve;
		}

		// Token: 0x06026B3D RID: 158525 RVA: 0x0097C76E File Offset: 0x0097A96E
		protected override IntPtr GetUStructPtr()
		{
			return Struct_TranslucentFoliage.StaticStruct();
		}

		// Token: 0x06026B3E RID: 158526 RVA: 0x0097C77A File Offset: 0x0097A97A
		[NullableContext(2)]
		public Struct_TranslucentFoliage(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026B3F RID: 158527 RVA: 0x0097C784 File Offset: 0x0097A984
		public Struct_TranslucentFoliage(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026B40 RID: 158528 RVA: 0x0097C78F File Offset: 0x0097A98F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new Struct_TranslucentFoliage(Pointer, false, true);
		}

		// Token: 0x06026B41 RID: 158529 RVA: 0x0097C799 File Offset: 0x0097A999
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new Struct_TranslucentFoliage(Pointer, MemoryOwner);
		}

		// Token: 0x0401375D RID: 79709
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Foliage/Struct_TranslucentFoliage.Struct_TranslucentFoliage";

		// Token: 0x0401375E RID: 79710
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401375F RID: 79711
		internal static int __PropertyOffset_0;

		// Token: 0x04013760 RID: 79712
		internal static int __PropertyOffset_1;

		// Token: 0x04013761 RID: 79713
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _PCMaterials;

		// Token: 0x04013762 RID: 79714
		internal static int __PropertyOffset_2;

		// Token: 0x04013763 RID: 79715
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _PCMaterialsOffFade;

		// Token: 0x04013764 RID: 79716
		internal static int __PropertyOffset_3;

		// Token: 0x04013765 RID: 79717
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _MobileMaterials;

		// Token: 0x04013766 RID: 79718
		internal static int __PropertyOffset_4;

		// Token: 0x04013767 RID: 79719
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _MobileMaterialsOffFade;

		// Token: 0x04013768 RID: 79720
		internal static int __PropertyOffset_5;

		// Token: 0x04013769 RID: 79721
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _PCMaterialsNoDissolve;

		// Token: 0x0401376A RID: 79722
		internal static int __PropertyOffset_6;

		// Token: 0x0401376B RID: 79723
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _MobileMaterialsNoDissolve;
	}
}
