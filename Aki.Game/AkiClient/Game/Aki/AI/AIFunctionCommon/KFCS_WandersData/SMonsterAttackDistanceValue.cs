using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.AI.AIFunctionCommon.KFCS_WandersData
{
	// Token: 0x0200444A RID: 17482
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/AI/AIFunctionCommon/KFCS_WandersData/SMonsterAttackDistanceValue.SMonsterAttackDistanceValue")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class SMonsterAttackDistanceValue : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602D41B RID: 185371 RVA: 0x00A37E44 File Offset: 0x00A36044
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMonsterAttackDistanceValue._ScriptStructPtr != 0) ? SMonsterAttackDistanceValue._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/AI/AIFunctionCommon/KFCS_WandersData/SMonsterAttackDistanceValue.SMonsterAttackDistanceValue", ref SMonsterAttackDistanceValue._ScriptStructPtr);
		}

		// Token: 0x170072BF RID: 29375
		// (get) Token: 0x0602D41C RID: 185372 RVA: 0x00A37E68 File Offset: 0x00A36068
		// (set) Token: 0x0602D41D RID: 185373 RVA: 0x00A37E78 File Offset: 0x00A36078
		public unsafe float 近距离战斗圈
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMonsterAttackDistanceValue.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMonsterAttackDistanceValue.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170072C0 RID: 29376
		// (get) Token: 0x0602D41E RID: 185374 RVA: 0x00A37E89 File Offset: 0x00A36089
		// (set) Token: 0x0602D41F RID: 185375 RVA: 0x00A37E99 File Offset: 0x00A36099
		public unsafe float 远距离战斗圈
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMonsterAttackDistanceValue.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMonsterAttackDistanceValue.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170072C1 RID: 29377
		// (get) Token: 0x0602D420 RID: 185376 RVA: 0x00A37EAA File Offset: 0x00A360AA
		// (set) Token: 0x0602D421 RID: 185377 RVA: 0x00A37EBA File Offset: 0x00A360BA
		public unsafe float 近距离战斗角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMonsterAttackDistanceValue.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMonsterAttackDistanceValue.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170072C2 RID: 29378
		// (get) Token: 0x0602D422 RID: 185378 RVA: 0x00A37ECB File Offset: 0x00A360CB
		// (set) Token: 0x0602D423 RID: 185379 RVA: 0x00A37EDB File Offset: 0x00A360DB
		public unsafe float 近距离摄像机角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMonsterAttackDistanceValue.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMonsterAttackDistanceValue.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170072C3 RID: 29379
		// (get) Token: 0x0602D424 RID: 185380 RVA: 0x00A37EEC File Offset: 0x00A360EC
		// (set) Token: 0x0602D425 RID: 185381 RVA: 0x00A37EFC File Offset: 0x00A360FC
		public unsafe float 中距离战斗角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMonsterAttackDistanceValue.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMonsterAttackDistanceValue.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170072C4 RID: 29380
		// (get) Token: 0x0602D426 RID: 185382 RVA: 0x00A37F0D File Offset: 0x00A3610D
		// (set) Token: 0x0602D427 RID: 185383 RVA: 0x00A37F1D File Offset: 0x00A3611D
		public unsafe float 中距离摄像机角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMonsterAttackDistanceValue.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMonsterAttackDistanceValue.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170072C5 RID: 29381
		// (get) Token: 0x0602D428 RID: 185384 RVA: 0x00A37F2E File Offset: 0x00A3612E
		// (set) Token: 0x0602D429 RID: 185385 RVA: 0x00A37F3E File Offset: 0x00A3613E
		public unsafe float 远距离摄像机角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMonsterAttackDistanceValue.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMonsterAttackDistanceValue.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x0602D42A RID: 185386 RVA: 0x00A37F4F File Offset: 0x00A3614F
		public SMonsterAttackDistanceValue()
		{
		}

		// Token: 0x0602D42B RID: 185387 RVA: 0x00A37F57 File Offset: 0x00A36157
		public SMonsterAttackDistanceValue(float 近距离战斗圈, float 远距离战斗圈, float 近距离战斗角度, float 近距离摄像机角度, float 中距离战斗角度, float 中距离摄像机角度, float 远距离摄像机角度)
		{
			this.近距离战斗圈 = 近距离战斗圈;
			this.远距离战斗圈 = 远距离战斗圈;
			this.近距离战斗角度 = 近距离战斗角度;
			this.近距离摄像机角度 = 近距离摄像机角度;
			this.中距离战斗角度 = 中距离战斗角度;
			this.中距离摄像机角度 = 中距离摄像机角度;
			this.远距离摄像机角度 = 远距离摄像机角度;
		}

		// Token: 0x0602D42C RID: 185388 RVA: 0x00A37F94 File Offset: 0x00A36194
		protected override IntPtr GetUStructPtr()
		{
			return SMonsterAttackDistanceValue.StaticStruct();
		}

		// Token: 0x0602D42D RID: 185389 RVA: 0x00A37FA0 File Offset: 0x00A361A0
		[NullableContext(2)]
		public SMonsterAttackDistanceValue(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602D42E RID: 185390 RVA: 0x00A37FAA File Offset: 0x00A361AA
		public SMonsterAttackDistanceValue(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602D42F RID: 185391 RVA: 0x00A37FB5 File Offset: 0x00A361B5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMonsterAttackDistanceValue(Pointer, false, true);
		}

		// Token: 0x0602D430 RID: 185392 RVA: 0x00A37FBF File Offset: 0x00A361BF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMonsterAttackDistanceValue(Pointer, MemoryOwner);
		}

		// Token: 0x0401813A RID: 98618
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/AI/AIFunctionCommon/KFCS_WandersData/SMonsterAttackDistanceValue.SMonsterAttackDistanceValue";

		// Token: 0x0401813B RID: 98619
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401813C RID: 98620
		internal static int __PropertyOffset_0;

		// Token: 0x0401813D RID: 98621
		internal static int __PropertyOffset_1;

		// Token: 0x0401813E RID: 98622
		internal static int __PropertyOffset_2;

		// Token: 0x0401813F RID: 98623
		internal static int __PropertyOffset_3;

		// Token: 0x04018140 RID: 98624
		internal static int __PropertyOffset_4;

		// Token: 0x04018141 RID: 98625
		internal static int __PropertyOffset_5;

		// Token: 0x04018142 RID: 98626
		internal static int __PropertyOffset_6;
	}
}
