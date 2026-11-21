using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003349 RID: 13129
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SDangoPerformData.SDangoPerformData")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SDangoPerformData : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021367 RID: 136039 RVA: 0x0095BC8E File Offset: 0x00959E8E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SDangoPerformData._ScriptStructPtr != 0) ? SDangoPerformData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SDangoPerformData.SDangoPerformData", ref SDangoPerformData._ScriptStructPtr);
		}

		// Token: 0x1700432C RID: 17196
		// (get) Token: 0x06021368 RID: 136040 RVA: 0x0095BCB2 File Offset: 0x00959EB2
		// (set) Token: 0x06021369 RID: 136041 RVA: 0x0095BCC6 File Offset: 0x00959EC6
		public unsafe TEnumAsByte<EDangoActionPerformType> 动画类型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoPerformData.__PropertyOffset_动画类型);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoPerformData.__PropertyOffset_动画类型) = value;
			}
		}

		// Token: 0x1700432D RID: 17197
		// (get) Token: 0x0602136A RID: 136042 RVA: 0x0095BCDB File Offset: 0x00959EDB
		// (set) Token: 0x0602136B RID: 136043 RVA: 0x0095BCEF File Offset: 0x00959EEF
		public unsafe TEnumAsByte<EDangoActionTargetType> 动画目标类型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoPerformData.__PropertyOffset_动画目标类型);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoPerformData.__PropertyOffset_动画目标类型) = value;
			}
		}

		// Token: 0x1700432E RID: 17198
		// (get) Token: 0x0602136C RID: 136044 RVA: 0x0095BD04 File Offset: 0x00959F04
		// (set) Token: 0x0602136D RID: 136045 RVA: 0x0095BD18 File Offset: 0x00959F18
		public unsafe TEnumAsByte<EDangoActionPerformType> 堆叠上方团子动画类型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoPerformData.__PropertyOffset_堆叠上方团子动画类型);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoPerformData.__PropertyOffset_堆叠上方团子动画类型) = value;
			}
		}

		// Token: 0x1700432F RID: 17199
		// (get) Token: 0x0602136E RID: 136046 RVA: 0x0095BD2D File Offset: 0x00959F2D
		// (set) Token: 0x0602136F RID: 136047 RVA: 0x0095BD3D File Offset: 0x00959F3D
		public unsafe int 持续时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDangoPerformData.__PropertyOffset_持续时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDangoPerformData.__PropertyOffset_持续时间) = value;
			}
		}

		// Token: 0x17004330 RID: 17200
		// (get) Token: 0x06021370 RID: 136048 RVA: 0x0095BD50 File Offset: 0x00959F50
		// (set) Token: 0x06021371 RID: 136049 RVA: 0x0095BD93 File Offset: 0x00959F93
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
					result = (this._特效列表 = new TArray<SDangoPerformEffectData>(base.NativePtr + (IntPtr)SDangoPerformData.__PropertyOffset_特效列表, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.特效列表.CopyAssign(value);
			}
		}

		// Token: 0x06021372 RID: 136050 RVA: 0x0095BDA1 File Offset: 0x00959FA1
		public SDangoPerformData()
		{
		}

		// Token: 0x06021373 RID: 136051 RVA: 0x0095BDA9 File Offset: 0x00959FA9
		protected override IntPtr GetUStructPtr()
		{
			return SDangoPerformData.StaticStruct();
		}

		// Token: 0x06021374 RID: 136052 RVA: 0x0095BDB5 File Offset: 0x00959FB5
		[NullableContext(2)]
		public SDangoPerformData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021375 RID: 136053 RVA: 0x0095BDBF File Offset: 0x00959FBF
		public SDangoPerformData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021376 RID: 136054 RVA: 0x0095BDCA File Offset: 0x00959FCA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SDangoPerformData(Pointer, false, true);
		}

		// Token: 0x06021377 RID: 136055 RVA: 0x0095BDD4 File Offset: 0x00959FD4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SDangoPerformData(Pointer, MemoryOwner);
		}

		// Token: 0x0401228B RID: 74379
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SDangoPerformData.SDangoPerformData";

		// Token: 0x0401228C RID: 74380
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401228D RID: 74381
		internal static int __PropertyOffset_动画类型;

		// Token: 0x0401228E RID: 74382
		internal static int __PropertyOffset_动画目标类型;

		// Token: 0x0401228F RID: 74383
		internal static int __PropertyOffset_堆叠上方团子动画类型;

		// Token: 0x04012290 RID: 74384
		internal static int __PropertyOffset_持续时间;

		// Token: 0x04012291 RID: 74385
		internal static int __PropertyOffset_特效列表;

		// Token: 0x04012292 RID: 74386
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SDangoPerformEffectData> _特效列表;
	}
}
