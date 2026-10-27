using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.LightPrefab.Struction
{
	// Token: 0x02003C6F RID: 15471
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/LightPrefab/Struction/PCG_LightPrefab_Mesh.PCG_LightPrefab_Mesh")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1098)]
	public class PCG_LightPrefab_Mesh : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023E11 RID: 146961 RVA: 0x0092F92E File Offset: 0x0092DB2E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (PCG_LightPrefab_Mesh._ScriptStructPtr != 0) ? PCG_LightPrefab_Mesh._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/PCG/LightPrefab/Struction/PCG_LightPrefab_Mesh.PCG_LightPrefab_Mesh", ref PCG_LightPrefab_Mesh._ScriptStructPtr);
		}

		// Token: 0x170043EC RID: 17388
		// (get) Token: 0x06023E12 RID: 146962 RVA: 0x0092F952 File Offset: 0x0092DB52
		// (set) Token: 0x06023E13 RID: 146963 RVA: 0x0092F966 File Offset: 0x0092DB66
		[Nullable(2)]
		public unsafe UStaticMesh 灯光模型
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + PCG_LightPrefab_Mesh.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PCG_LightPrefab_Mesh.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170043ED RID: 17389
		// (get) Token: 0x06023E14 RID: 146964 RVA: 0x0092F97C File Offset: 0x0092DB7C
		// (set) Token: 0x06023E15 RID: 146965 RVA: 0x0092F9BF File Offset: 0x0092DBBF
		public FKuroCurveLinearColor 自发光颜色Color
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._自发光颜色Color) == null)
				{
					result = (this._自发光颜色Color = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)PCG_LightPrefab_Mesh.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)PCG_LightPrefab_Mesh.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170043EE RID: 17390
		// (get) Token: 0x06023E16 RID: 146966 RVA: 0x0092F9E0 File Offset: 0x0092DBE0
		// (set) Token: 0x06023E17 RID: 146967 RVA: 0x0092FA23 File Offset: 0x0092DC23
		public FKuroCurveLinearColor 自发光颜色DayColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._自发光颜色DayColor) == null)
				{
					result = (this._自发光颜色DayColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)PCG_LightPrefab_Mesh.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)PCG_LightPrefab_Mesh.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170043EF RID: 17391
		// (get) Token: 0x06023E18 RID: 146968 RVA: 0x0092FA44 File Offset: 0x0092DC44
		// (set) Token: 0x06023E19 RID: 146969 RVA: 0x0092FA54 File Offset: 0x0092DC54
		public unsafe bool UseWholeDayEmission
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_LightPrefab_Mesh.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_LightPrefab_Mesh.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x170043F0 RID: 17392
		// (get) Token: 0x06023E1A RID: 146970 RVA: 0x0092FA65 File Offset: 0x0092DC65
		// (set) Token: 0x06023E1B RID: 146971 RVA: 0x0092FA75 File Offset: 0x0092DC75
		public unsafe bool UseMaterialLOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_LightPrefab_Mesh.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_LightPrefab_Mesh.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x06023E1C RID: 146972 RVA: 0x0092FA86 File Offset: 0x0092DC86
		public PCG_LightPrefab_Mesh()
		{
		}

		// Token: 0x06023E1D RID: 146973 RVA: 0x0092FA8E File Offset: 0x0092DC8E
		public PCG_LightPrefab_Mesh(UStaticMesh 灯光模型, FKuroCurveLinearColor 自发光颜色Color, FKuroCurveLinearColor 自发光颜色DayColor, bool UseWholeDayEmission, bool UseMaterialLOD)
		{
			this.灯光模型 = 灯光模型;
			this.自发光颜色Color = 自发光颜色Color;
			this.自发光颜色DayColor = 自发光颜色DayColor;
			this.UseWholeDayEmission = UseWholeDayEmission;
			this.UseMaterialLOD = UseMaterialLOD;
		}

		// Token: 0x06023E1E RID: 146974 RVA: 0x0092FABB File Offset: 0x0092DCBB
		protected override IntPtr GetUStructPtr()
		{
			return PCG_LightPrefab_Mesh.StaticStruct();
		}

		// Token: 0x06023E1F RID: 146975 RVA: 0x0092FAC7 File Offset: 0x0092DCC7
		[NullableContext(2)]
		public PCG_LightPrefab_Mesh(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023E20 RID: 146976 RVA: 0x0092FAD1 File Offset: 0x0092DCD1
		public PCG_LightPrefab_Mesh(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023E21 RID: 146977 RVA: 0x0092FADC File Offset: 0x0092DCDC
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new PCG_LightPrefab_Mesh(Pointer, false, true);
		}

		// Token: 0x06023E22 RID: 146978 RVA: 0x0092FAE6 File Offset: 0x0092DCE6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new PCG_LightPrefab_Mesh(Pointer, MemoryOwner);
		}

		// Token: 0x04011BF3 RID: 72691
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/LightPrefab/Struction/PCG_LightPrefab_Mesh.PCG_LightPrefab_Mesh";

		// Token: 0x04011BF4 RID: 72692
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011BF5 RID: 72693
		internal static int __PropertyOffset_0;

		// Token: 0x04011BF6 RID: 72694
		internal static int __PropertyOffset_1;

		// Token: 0x04011BF7 RID: 72695
		[Nullable(2)]
		private FKuroCurveLinearColor _自发光颜色Color;

		// Token: 0x04011BF8 RID: 72696
		internal static int __PropertyOffset_2;

		// Token: 0x04011BF9 RID: 72697
		[Nullable(2)]
		private FKuroCurveLinearColor _自发光颜色DayColor;

		// Token: 0x04011BFA RID: 72698
		internal static int __PropertyOffset_3;

		// Token: 0x04011BFB RID: 72699
		internal static int __PropertyOffset_4;
	}
}
