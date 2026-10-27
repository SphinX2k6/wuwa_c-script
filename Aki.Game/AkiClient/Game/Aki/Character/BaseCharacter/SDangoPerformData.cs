using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200430C RID: 17164
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SDangoPerformData.SDangoPerformData")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SDangoPerformData : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C648 RID: 181832 RVA: 0x00A1ED2C File Offset: 0x00A1CF2C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SDangoPerformData._ScriptStructPtr != 0) ? SDangoPerformData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SDangoPerformData.SDangoPerformData", ref SDangoPerformData._ScriptStructPtr);
		}

		// Token: 0x17006F0E RID: 28430
		// (get) Token: 0x0602C649 RID: 181833 RVA: 0x00A1ED50 File Offset: 0x00A1CF50
		// (set) Token: 0x0602C64A RID: 181834 RVA: 0x00A1ED64 File Offset: 0x00A1CF64
		public unsafe TEnumAsByte<EDangoActionPerformType> 动画类型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoPerformData.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoPerformData.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006F0F RID: 28431
		// (get) Token: 0x0602C64B RID: 181835 RVA: 0x00A1ED79 File Offset: 0x00A1CF79
		// (set) Token: 0x0602C64C RID: 181836 RVA: 0x00A1ED8D File Offset: 0x00A1CF8D
		public unsafe TEnumAsByte<EDangoActionTargetType> 动画目标类型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoPerformData.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoPerformData.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006F10 RID: 28432
		// (get) Token: 0x0602C64D RID: 181837 RVA: 0x00A1EDA2 File Offset: 0x00A1CFA2
		// (set) Token: 0x0602C64E RID: 181838 RVA: 0x00A1EDB6 File Offset: 0x00A1CFB6
		public unsafe TEnumAsByte<EDangoActionPerformType> 堆叠上方团子动画类型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoPerformData.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoPerformData.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006F11 RID: 28433
		// (get) Token: 0x0602C64F RID: 181839 RVA: 0x00A1EDCB File Offset: 0x00A1CFCB
		// (set) Token: 0x0602C650 RID: 181840 RVA: 0x00A1EDDB File Offset: 0x00A1CFDB
		public unsafe int 持续时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoPerformData.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoPerformData.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006F12 RID: 28434
		// (get) Token: 0x0602C651 RID: 181841 RVA: 0x00A1EDEC File Offset: 0x00A1CFEC
		// (set) Token: 0x0602C652 RID: 181842 RVA: 0x00A1EE2F File Offset: 0x00A1D02F
		[Nullable(1)]
		public TArray<SDangoPerformEffectData> 特效列表
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<SDangoPerformEffectData> result;
				if ((result = this._特效列表) == null)
				{
					result = (this._特效列表 = new TArray<SDangoPerformEffectData>(base.NativePtr + (IntPtr)SDangoPerformData.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.特效列表.CopyAssign(value);
			}
		}

		// Token: 0x0602C653 RID: 181843 RVA: 0x00A1EE3D File Offset: 0x00A1D03D
		public SDangoPerformData()
		{
		}

		// Token: 0x0602C654 RID: 181844 RVA: 0x00A1EE45 File Offset: 0x00A1D045
		public SDangoPerformData(TEnumAsByte<EDangoActionPerformType> 动画类型, TEnumAsByte<EDangoActionTargetType> 动画目标类型, TEnumAsByte<EDangoActionPerformType> 堆叠上方团子动画类型, int 持续时间, [Nullable(1)] TArray<SDangoPerformEffectData> 特效列表)
		{
			this.动画类型 = 动画类型;
			this.动画目标类型 = 动画目标类型;
			this.堆叠上方团子动画类型 = 堆叠上方团子动画类型;
			this.持续时间 = 持续时间;
			this.特效列表 = 特效列表;
		}

		// Token: 0x0602C655 RID: 181845 RVA: 0x00A1EE72 File Offset: 0x00A1D072
		protected override IntPtr GetUStructPtr()
		{
			return SDangoPerformData.StaticStruct();
		}

		// Token: 0x0602C656 RID: 181846 RVA: 0x00A1EE7E File Offset: 0x00A1D07E
		[NullableContext(2)]
		public SDangoPerformData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C657 RID: 181847 RVA: 0x00A1EE88 File Offset: 0x00A1D088
		public SDangoPerformData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C658 RID: 181848 RVA: 0x00A1EE93 File Offset: 0x00A1D093
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SDangoPerformData(Pointer, false, true);
		}

		// Token: 0x0602C659 RID: 181849 RVA: 0x00A1EE9D File Offset: 0x00A1D09D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SDangoPerformData(Pointer, MemoryOwner);
		}

		// Token: 0x04017686 RID: 95878
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SDangoPerformData.SDangoPerformData";

		// Token: 0x04017687 RID: 95879
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017688 RID: 95880
		internal static int __PropertyOffset_0;

		// Token: 0x04017689 RID: 95881
		internal static int __PropertyOffset_1;

		// Token: 0x0401768A RID: 95882
		internal static int __PropertyOffset_2;

		// Token: 0x0401768B RID: 95883
		internal static int __PropertyOffset_3;

		// Token: 0x0401768C RID: 95884
		internal static int __PropertyOffset_4;

		// Token: 0x0401768D RID: 95885
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SDangoPerformEffectData> _特效列表;
	}
}
