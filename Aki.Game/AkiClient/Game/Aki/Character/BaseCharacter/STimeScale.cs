using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004337 RID: 17207
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/STimeScale.STimeScale")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class STimeScale : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602CA04 RID: 182788 RVA: 0x00A2459A File Offset: 0x00A2279A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (STimeScale._ScriptStructPtr != 0) ? STimeScale._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/STimeScale.STimeScale", ref STimeScale._ScriptStructPtr);
		}

		// Token: 0x17007043 RID: 28739
		// (get) Token: 0x0602CA05 RID: 182789 RVA: 0x00A245BE File Offset: 0x00A227BE
		// (set) Token: 0x0602CA06 RID: 182790 RVA: 0x00A245D2 File Offset: 0x00A227D2
		[Nullable(2)]
		public unsafe UCurveFloat 时间膨胀变化曲线
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + STimeScale.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + STimeScale.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17007044 RID: 28740
		// (get) Token: 0x0602CA07 RID: 182791 RVA: 0x00A245E7 File Offset: 0x00A227E7
		// (set) Token: 0x0602CA08 RID: 182792 RVA: 0x00A245F7 File Offset: 0x00A227F7
		public unsafe float 时间膨胀时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)STimeScale.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)STimeScale.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17007045 RID: 28741
		// (get) Token: 0x0602CA09 RID: 182793 RVA: 0x00A24608 File Offset: 0x00A22808
		// (set) Token: 0x0602CA0A RID: 182794 RVA: 0x00A24618 File Offset: 0x00A22818
		public unsafe float 时间膨胀值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)STimeScale.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)STimeScale.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17007046 RID: 28742
		// (get) Token: 0x0602CA0B RID: 182795 RVA: 0x00A24629 File Offset: 0x00A22829
		// (set) Token: 0x0602CA0C RID: 182796 RVA: 0x00A24639 File Offset: 0x00A22839
		public unsafe int 优先级
		{
			get
			{
				return *(base.NativePtr + (IntPtr)STimeScale.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)STimeScale.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x0602CA0D RID: 182797 RVA: 0x00A2464A File Offset: 0x00A2284A
		public STimeScale()
		{
		}

		// Token: 0x0602CA0E RID: 182798 RVA: 0x00A24652 File Offset: 0x00A22852
		[NullableContext(1)]
		public STimeScale(UCurveFloat 时间膨胀变化曲线, float 时间膨胀时长, float 时间膨胀值, int 优先级)
		{
			this.时间膨胀变化曲线 = 时间膨胀变化曲线;
			this.时间膨胀时长 = 时间膨胀时长;
			this.时间膨胀值 = 时间膨胀值;
			this.优先级 = 优先级;
		}

		// Token: 0x0602CA0F RID: 182799 RVA: 0x00A24677 File Offset: 0x00A22877
		protected override IntPtr GetUStructPtr()
		{
			return STimeScale.StaticStruct();
		}

		// Token: 0x0602CA10 RID: 182800 RVA: 0x00A24683 File Offset: 0x00A22883
		[NullableContext(2)]
		public STimeScale(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602CA11 RID: 182801 RVA: 0x00A2468D File Offset: 0x00A2288D
		public STimeScale(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602CA12 RID: 182802 RVA: 0x00A24698 File Offset: 0x00A22898
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new STimeScale(Pointer, false, true);
		}

		// Token: 0x0602CA13 RID: 182803 RVA: 0x00A246A2 File Offset: 0x00A228A2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new STimeScale(Pointer, MemoryOwner);
		}

		// Token: 0x04017865 RID: 96357
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/STimeScale.STimeScale";

		// Token: 0x04017866 RID: 96358
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017867 RID: 96359
		internal static int __PropertyOffset_0;

		// Token: 0x04017868 RID: 96360
		internal static int __PropertyOffset_1;

		// Token: 0x04017869 RID: 96361
		internal static int __PropertyOffset_2;

		// Token: 0x0401786A RID: 96362
		internal static int __PropertyOffset_3;
	}
}
