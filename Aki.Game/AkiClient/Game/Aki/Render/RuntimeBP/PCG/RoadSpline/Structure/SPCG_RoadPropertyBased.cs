using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.RoadSpline.Structure
{
	// Token: 0x02003C2D RID: 15405
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/Structure/SPCG_RoadPropertyBased.SPCG_RoadPropertyBased")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 60)]
	public class SPCG_RoadPropertyBased : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023631 RID: 144945 RVA: 0x00922B87 File Offset: 0x00920D87
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SPCG_RoadPropertyBased._ScriptStructPtr != 0) ? SPCG_RoadPropertyBased._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/Structure/SPCG_RoadPropertyBased.SPCG_RoadPropertyBased", ref SPCG_RoadPropertyBased._ScriptStructPtr);
		}

		// Token: 0x1700410D RID: 16653
		// (get) Token: 0x06023632 RID: 144946 RVA: 0x00922BAB File Offset: 0x00920DAB
		// (set) Token: 0x06023633 RID: 144947 RVA: 0x00922BBF File Offset: 0x00920DBF
		[Nullable(2)]
		public unsafe UStaticMesh 基础模型
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + SPCG_RoadPropertyBased.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SPCG_RoadPropertyBased.__PropertyOffset_0, value);
			}
		}

		// Token: 0x1700410E RID: 16654
		// (get) Token: 0x06023634 RID: 144948 RVA: 0x00922BD4 File Offset: 0x00920DD4
		// (set) Token: 0x06023635 RID: 144949 RVA: 0x00922C17 File Offset: 0x00920E17
		[Nullable(1)]
		public TArray<UMaterialInterface> 覆写材质
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._覆写材质) == null)
				{
					result = (this._覆写材质 = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)SPCG_RoadPropertyBased.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.覆写材质.CopyAssign(value);
			}
		}

		// Token: 0x1700410F RID: 16655
		// (get) Token: 0x06023636 RID: 144950 RVA: 0x00922C25 File Offset: 0x00920E25
		// (set) Token: 0x06023637 RID: 144951 RVA: 0x00922C39 File Offset: 0x00920E39
		public unsafe TEnumAsByte<ESplineMeshAxis> 前向轴
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPCG_RoadPropertyBased.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPCG_RoadPropertyBased.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17004110 RID: 16656
		// (get) Token: 0x06023638 RID: 144952 RVA: 0x00922C4E File Offset: 0x00920E4E
		// (set) Token: 0x06023639 RID: 144953 RVA: 0x00922C62 File Offset: 0x00920E62
		public unsafe FVector 模型偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPCG_RoadPropertyBased.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPCG_RoadPropertyBased.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17004111 RID: 16657
		// (get) Token: 0x0602363A RID: 144954 RVA: 0x00922C77 File Offset: 0x00920E77
		// (set) Token: 0x0602363B RID: 144955 RVA: 0x00922C87 File Offset: 0x00920E87
		public unsafe float 轴向旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPCG_RoadPropertyBased.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPCG_RoadPropertyBased.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004112 RID: 16658
		// (get) Token: 0x0602363C RID: 144956 RVA: 0x00922C98 File Offset: 0x00920E98
		// (set) Token: 0x0602363D RID: 144957 RVA: 0x00922CA8 File Offset: 0x00920EA8
		public unsafe float 宽度缩放
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPCG_RoadPropertyBased.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPCG_RoadPropertyBased.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004113 RID: 16659
		// (get) Token: 0x0602363E RID: 144958 RVA: 0x00922CB9 File Offset: 0x00920EB9
		// (set) Token: 0x0602363F RID: 144959 RVA: 0x00922CC9 File Offset: 0x00920EC9
		public unsafe float 长度缩放
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPCG_RoadPropertyBased.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPCG_RoadPropertyBased.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004114 RID: 16660
		// (get) Token: 0x06023640 RID: 144960 RVA: 0x00922CDA File Offset: 0x00920EDA
		// (set) Token: 0x06023641 RID: 144961 RVA: 0x00922CEA File Offset: 0x00920EEA
		public unsafe bool 均匀分布
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPCG_RoadPropertyBased.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPCG_RoadPropertyBased.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004115 RID: 16661
		// (get) Token: 0x06023642 RID: 144962 RVA: 0x00922CFB File Offset: 0x00920EFB
		// (set) Token: 0x06023643 RID: 144963 RVA: 0x00922D0B File Offset: 0x00920F0B
		public unsafe float 分布缩放
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPCG_RoadPropertyBased.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPCG_RoadPropertyBased.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x06023644 RID: 144964 RVA: 0x00922D1C File Offset: 0x00920F1C
		public SPCG_RoadPropertyBased()
		{
		}

		// Token: 0x06023645 RID: 144965 RVA: 0x00922D24 File Offset: 0x00920F24
		[NullableContext(1)]
		public SPCG_RoadPropertyBased(UStaticMesh 基础模型, TArray<UMaterialInterface> 覆写材质, [Nullable(0)] TEnumAsByte<ESplineMeshAxis> 前向轴, FVector 模型偏移, float 轴向旋转, float 宽度缩放, float 长度缩放, bool 均匀分布, float 分布缩放)
		{
			this.基础模型 = 基础模型;
			this.覆写材质 = 覆写材质;
			this.前向轴 = 前向轴;
			this.模型偏移 = 模型偏移;
			this.轴向旋转 = 轴向旋转;
			this.宽度缩放 = 宽度缩放;
			this.长度缩放 = 长度缩放;
			this.均匀分布 = 均匀分布;
			this.分布缩放 = 分布缩放;
		}

		// Token: 0x06023646 RID: 144966 RVA: 0x00922D7C File Offset: 0x00920F7C
		protected override IntPtr GetUStructPtr()
		{
			return SPCG_RoadPropertyBased.StaticStruct();
		}

		// Token: 0x06023647 RID: 144967 RVA: 0x00922D88 File Offset: 0x00920F88
		[NullableContext(2)]
		public SPCG_RoadPropertyBased(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023648 RID: 144968 RVA: 0x00922D92 File Offset: 0x00920F92
		public SPCG_RoadPropertyBased(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023649 RID: 144969 RVA: 0x00922D9D File Offset: 0x00920F9D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SPCG_RoadPropertyBased(Pointer, false, true);
		}

		// Token: 0x0602364A RID: 144970 RVA: 0x00922DA7 File Offset: 0x00920FA7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SPCG_RoadPropertyBased(Pointer, MemoryOwner);
		}

		// Token: 0x04011773 RID: 71539
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/Structure/SPCG_RoadPropertyBased.SPCG_RoadPropertyBased";

		// Token: 0x04011774 RID: 71540
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011775 RID: 71541
		internal static int __PropertyOffset_0;

		// Token: 0x04011776 RID: 71542
		internal static int __PropertyOffset_1;

		// Token: 0x04011777 RID: 71543
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _覆写材质;

		// Token: 0x04011778 RID: 71544
		internal static int __PropertyOffset_2;

		// Token: 0x04011779 RID: 71545
		internal static int __PropertyOffset_3;

		// Token: 0x0401177A RID: 71546
		internal static int __PropertyOffset_4;

		// Token: 0x0401177B RID: 71547
		internal static int __PropertyOffset_5;

		// Token: 0x0401177C RID: 71548
		internal static int __PropertyOffset_6;

		// Token: 0x0401177D RID: 71549
		internal static int __PropertyOffset_7;

		// Token: 0x0401177E RID: 71550
		internal static int __PropertyOffset_8;
	}
}
